# // MC3190Z - RFID - Example

# 1. Requisitos

* Microsoft Visual Studio 2008
* Microsoft Windows Mobile 6 Professional SDK
* Microsoft ActiveSync 4.5
* Microsoft Windows Mobile Device Center
* EMDK for .NET v2.8 (MC3190Z SDK for .NET)
* Microsoft .NET CF 2.0 (Para o dispositivo)
* **Download dos requisitos:** http://bit.ly/20RsxUX

# 2. MC3190Z no Visual Studio

## 2.1 Configurações do dispositivo
* Acessar o menu: Tools > Options > Device Tools > Devices
  Duplicar "Windows Mobile 6 Professional Device" utilizando "Save as..." e definindo o novo nome para "MC3190Z Device"
  Duplicar "Windows Mobile 6 Professional Emulator" utilizando "Save as..." e definindo o novo nome para "MC3190Z Emulator"
* Nas propriedades do "MC3190Z Emulator" acessar: Emulator Options > Display e definir
  Video: Width = 320 e Height = 320.

![Configurações de Dispositivos](http://s10.postimg.org/8v4s7catl/Options_Devices_Tools_Devices.png)

## 2.2 Configurações do Form Factor (Design das telas)

* Acessar o menu: Tools > Options > Device Tools > Form Factors
  Duplicar "Windows Mobile 6 Classic" utilizando "Save as..." e definindo o novo nome para "MC3190Z"
  Após duplicar, acessar as propriedades do novo Form Factor e desmarcar a opção "Show Skin"
  Defina Width = 240 e Height = 240
* Ainda na janela "Form Factors", defina "Default Form Factor" para "MC3190Z"

![Configurações do Form Factor](http://s10.postimg.org/ao7ovnw09/Options_Devices_Tools_Form_Factors.png)

# 3. Debug

No menu superior esquerdo, existe um combo box onde você pode escolher onde deseja executar o aplicativo.
* MC3190Z Emulator: irá executar o aplicativo na máquina de desenvolvimento utilizando um emulador
* MC3190Z Device: irá executar o aplicativo diretamente no dispositivo

# Contato
### // Marivaldo Júnior
### // marivaldoeng@gmail.com
