using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Symbol.ResourceCoordination;
using Symbol.RFID3;

namespace Treinamento.Frames
{
    public partial class MainFrame : Form
    {
        #region private Process Player

        private Process Player = null;

        #endregion

        #region private string MusicPath

        private string MusicPath
        {
            get
            {
                return @"\MUSIC\Wesley Safadão - Aquele 1%.mp3";
            }
        }

        #endregion

        #region private Trigger Trigger

        private Trigger _Trigger = null;

        private Trigger Trigger
        {
            get
            {
                if (_Trigger == null)
                {
                    var available = TriggerDevice.AvailableTriggers;

                    foreach (var t in available)
                    {
                        if (t.ID == TriggerID.TRIGGER3)
                        {
                            _Trigger = new Trigger(t);

                            break;
                        }
                    }
                }

                return _Trigger;
            }
        }

        #endregion

        #region private RFIDReader RFIDReader

        private RFIDReader _RFIDReader = null;

        private RFIDReader RFIDReader
        {
            get
            {
                if (_RFIDReader == null || !_RFIDReader.IsConnected)
                {
                    //
                    // Cria um cliente para o RFID readoer

                    _RFIDReader = new RFIDReader("127.0.0.1", 0, 0);

                    //
                    // Conecta

                    try
                    {
                        _RFIDReader.Connect();
                    }
                    catch
                    {
                        return null;
                    }

                    //
                    // Quando uma tag for lida, gerar um novo evento

                    _RFIDReader.Events.AttachTagDataWithReadEvent = true;

                    //
                    // Handler para quando uma tag for lida

                    _RFIDReader.Events.ReadNotify += RFIDReader_ReadNotify;
                }

                return _RFIDReader;
            }
        }

        #endregion

        #region private TestFrame TestFrame

        private TestFrame _TestFrame = null;

        private TestFrame TestFrame
        {
            get
            {
                if (_TestFrame == null)
                {
                    _TestFrame = new TestFrame();
                }

                return _TestFrame;
            }
        }

        #endregion

        #region private IList<string> TagsFound

        private IList<string> _TagsFound = null;

        private IList<string> TagsFound
        {
            get
            {
                if (_TagsFound == null)
                {
                    _TagsFound = new List<string>();
                }

                return _TagsFound;
            }
            set
            {
                _TagsFound = value;
            }
        }

        #endregion

        public MainFrame()
        {
            InitializeComponent();

            if (Trigger != null)
            {
                Trigger.Stage2Notify += new Trigger.TriggerEventHandler(Trigger_Stage2Notify);
            }

            this.Refresh();
        }

        #region Aux Functions

        private void StartRFIDRead()
        {
            //
            // Bloqueia o botão

            rfidMenuButton.Enabled = false;
            rfidMenuButton.Text = "Lendo RFID...";
            rfidMenuButton.Refresh();

            //
            // Limpa as tags

            TagsFound = null;

            //
            // Inicia uma leitura

            try
            {
                RFIDReader.Actions.Inventory.Perform();
            }
            catch
            {
                //
                // Desbloqueia o botão

                rfidMenuButton.Text = "RFID";
                rfidMenuButton.Enabled = true;
                rfidMenuButton.Refresh();

                MessageBox.Show("Falha ao iniciar o leitor RFID", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                return;
            }

            Debug.WriteLine("Leitura RFID iniciada... ");
        }

        private void StopRFIDRead()
        {
            if (RFIDReader == null)
            {
                return;
            }

            //
            // Encerra a leitura

            try
            {
                RFIDReader.Actions.Inventory.Stop();

                Debug.WriteLine("Leitura RFID finalizada...");
            }
            finally
            {
                //
                // Desbloqueia o botão

                rfidMenuButton.Text = "RFID";
                rfidMenuButton.Enabled = true;
                rfidMenuButton.Refresh();
            }
        }

        #endregion

        #region RFID Reader Events Handlers

        void Trigger_Stage2Notify(object sender, TriggerEventArgs e)
        {
            if (e.NewState == TriggerState.STAGE2)
            {
                //
                // Pressionou o gatilho

                StartRFIDRead();
            }
            else
            {
                //
                // Soltou o gatilho

                StopRFIDRead();
            }
        }

        void RFIDReader_ReadNotify(object obj, Events.ReadEventArgs args)
        {
            string id = args.ReadEventData.TagData.TagID;

            if (!TagsFound.Contains(id))
            {
                TagsFound.Add(id);

                MessageBox.Show(id, "Tag RFID");
            }
        }

        #endregion

        #region Frame Events Handlers

        private void MainFrame_Load(object sender, EventArgs e)
        {
            mainPanel.Focus();
        }

        private void MainFrame_Closing(object sender, CancelEventArgs e)
        {
            try
            {
                RFIDReader.Disconnect();
            }
            catch
            {
            }
        }

        private void MainFrame_Deactivate(object sender, EventArgs e)
        {
            try
            {
                RFIDReader.Disconnect();
            }
            catch
            {
            }
        }

        private void musicMenuButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja tocar a música?", "Música", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = MusicPath,
                UseShellExecute = true
            };

            Player = Process.Start(info);
        }

        private void rfidMenuButton_Click(object sender, EventArgs e)
        {
            if (!rfidMenuButton.Enabled)
            {
                return;
            }

            //
            // Inicia a leitura

            StartRFIDRead();

            //
            // Aguarda por 5 segundos

            var t = new System.Windows.Forms.Timer() { Interval = 5 * 1000, Enabled = true };

            t.Tick += (s, evt) => { StopRFIDRead(); t.Enabled = false; t.Dispose(); };
        }

        private void changeWindowButton_Click(object sender, EventArgs e)
        {
            TestFrame.Show();
        }

        private void aboutMenuButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Aplicação teste para o MC3190Z.\n\n" +

                "Desenvolvido por \n" +
                "// Marivaldo Júnior\n" +
                "// marivaldo@ioct.com.br" +
                "// https://git.io/v2OOw", "Sobre");
        }

        private void MainFrame_EnabledChanged(object sender, EventArgs e)
        {
            if (!this.Enabled)
            {
                RFIDReader.Disconnect();
            }
        }

        #endregion
    }
}