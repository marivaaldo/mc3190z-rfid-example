namespace Treinamento.Frames
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.aboutMenuButton = new System.Windows.Forms.Button();
            this.changeWindowButton = new System.Windows.Forms.Button();
            this.rfidMenuButton = new System.Windows.Forms.Button();
            this.musicMenuButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.aboutMenuButton);
            this.mainPanel.Controls.Add(this.changeWindowButton);
            this.mainPanel.Controls.Add(this.rfidMenuButton);
            this.mainPanel.Controls.Add(this.musicMenuButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(240, 188);
            // 
            // aboutMenuButton
            // 
            this.aboutMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.aboutMenuButton.Location = new System.Drawing.Point(122, 96);
            this.aboutMenuButton.Name = "aboutMenuButton";
            this.aboutMenuButton.Size = new System.Drawing.Size(112, 86);
            this.aboutMenuButton.TabIndex = 3;
            this.aboutMenuButton.Text = "Sobre";
            this.aboutMenuButton.Click += new System.EventHandler(this.aboutMenuButton_Click);
            // 
            // changeWindowButton
            // 
            this.changeWindowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.changeWindowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changeWindowButton.Location = new System.Drawing.Point(5, 96);
            this.changeWindowButton.Name = "changeWindowButton";
            this.changeWindowButton.Size = new System.Drawing.Size(112, 86);
            this.changeWindowButton.TabIndex = 2;
            this.changeWindowButton.Text = "Imagens";
            this.changeWindowButton.Click += new System.EventHandler(this.changeWindowButton_Click);
            // 
            // rfidMenuButton
            // 
            this.rfidMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.rfidMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rfidMenuButton.Location = new System.Drawing.Point(122, 5);
            this.rfidMenuButton.Name = "rfidMenuButton";
            this.rfidMenuButton.Size = new System.Drawing.Size(112, 86);
            this.rfidMenuButton.TabIndex = 1;
            this.rfidMenuButton.Text = "RFID";
            this.rfidMenuButton.Click += new System.EventHandler(this.rfidMenuButton_Click);
            // 
            // musicMenuButton
            // 
            this.musicMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.musicMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.musicMenuButton.Location = new System.Drawing.Point(5, 5);
            this.musicMenuButton.Name = "musicMenuButton";
            this.musicMenuButton.Size = new System.Drawing.Size(112, 86);
            this.musicMenuButton.TabIndex = 0;
            this.musicMenuButton.Text = "Música";
            this.musicMenuButton.Click += new System.EventHandler(this.musicMenuButton_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 188);
            this.Controls.Add(this.mainPanel);
            this.Menu = this.mainMenu1;
            this.Name = "MainFrame";
            this.Text = "Treinamento";
            this.Deactivate += new System.EventHandler(this.MainFrame_Deactivate);
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.EnabledChanged += new System.EventHandler(this.MainFrame_EnabledChanged);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainFrame_Closing);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button musicMenuButton;
        private System.Windows.Forms.Button aboutMenuButton;
        private System.Windows.Forms.Button changeWindowButton;
        private System.Windows.Forms.Button rfidMenuButton;
        private System.Windows.Forms.MenuItem menuItem1;





    }
}

