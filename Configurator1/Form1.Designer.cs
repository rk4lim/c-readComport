namespace Configurator1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.WritePhone = new System.Windows.Forms.Button();
            this.WriteSnumber = new System.Windows.Forms.Button();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textSNumber = new System.Windows.Forms.TextBox();
            this.textPIN = new System.Windows.Forms.TextBox();
            this.PhoneDisp = new System.Windows.Forms.Label();
            this.SerialNumber = new System.Windows.Forms.Label();
            this.PinCode = new System.Windows.Forms.Label();
            this.WritePin = new System.Windows.Forms.Button();
            this.ReadDataSettings = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Sett_settings = new System.Windows.Forms.TabPage();
            this.Sett_gprs = new System.Windows.Forms.TabPage();
            this.WriteDataGPRS = new System.Windows.Forms.Button();
            this.ReadDataGPRS = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textNameUser = new System.Windows.Forms.TextBox();
            this.textAPN = new System.Windows.Forms.TextBox();
            this.T2 = new System.Windows.Forms.Button();
            this.Beeline = new System.Windows.Forms.Button();
            this.Megafon = new System.Windows.Forms.Button();
            this.Mts = new System.Windows.Forms.Button();
            this.Sett_Email = new System.Windows.Forms.TabPage();
            this.WriteEmail = new System.Windows.Forms.Button();
            this.ReadEmail = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupConfig = new System.Windows.Forms.GroupBox();
            this.ConnectCom = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DisconnectCom = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Sett_settings.SuspendLayout();
            this.Sett_gprs.SuspendLayout();
            this.Sett_Email.SuspendLayout();
            this.groupConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // WritePhone
            // 
            this.WritePhone.Location = new System.Drawing.Point(186, 47);
            this.WritePhone.Name = "WritePhone";
            this.WritePhone.Size = new System.Drawing.Size(75, 23);
            this.WritePhone.TabIndex = 0;
            this.WritePhone.Text = "Записать";
            this.WritePhone.UseVisualStyleBackColor = true;
            this.WritePhone.Click += new System.EventHandler(this.WritePhone_Click);
            // 
            // WriteSnumber
            // 
            this.WriteSnumber.Location = new System.Drawing.Point(186, 111);
            this.WriteSnumber.Name = "WriteSnumber";
            this.WriteSnumber.Size = new System.Drawing.Size(75, 23);
            this.WriteSnumber.TabIndex = 1;
            this.WriteSnumber.Text = "Записать";
            this.WriteSnumber.UseVisualStyleBackColor = true;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(105, 21);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(156, 20);
            this.textPhone.TabIndex = 2;
            // 
            // textSNumber
            // 
            this.textSNumber.Location = new System.Drawing.Point(105, 85);
            this.textSNumber.Name = "textSNumber";
            this.textSNumber.Size = new System.Drawing.Size(156, 20);
            this.textSNumber.TabIndex = 3;
            // 
            // textPIN
            // 
            this.textPIN.Location = new System.Drawing.Point(105, 157);
            this.textPIN.Name = "textPIN";
            this.textPIN.Size = new System.Drawing.Size(156, 20);
            this.textPIN.TabIndex = 4;
            // 
            // PhoneDisp
            // 
            this.PhoneDisp.AutoSize = true;
            this.PhoneDisp.Location = new System.Drawing.Point(0, 5);
            this.PhoneDisp.Name = "PhoneDisp";
            this.PhoneDisp.Size = new System.Drawing.Size(113, 13);
            this.PhoneDisp.TabIndex = 5;
            this.PhoneDisp.Text = "Телефон диспетчера";
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSize = true;
            this.SerialNumber.Location = new System.Drawing.Point(6, 69);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(93, 13);
            this.SerialNumber.TabIndex = 6;
            this.SerialNumber.Text = "Серийный номер";
            // 
            // PinCode
            // 
            this.PinCode.AutoSize = true;
            this.PinCode.Location = new System.Drawing.Point(6, 157);
            this.PinCode.Name = "PinCode";
            this.PinCode.Size = new System.Drawing.Size(46, 13);
            this.PinCode.TabIndex = 7;
            this.PinCode.Text = "PIN код";
            // 
            // WritePin
            // 
            this.WritePin.Location = new System.Drawing.Point(186, 183);
            this.WritePin.Name = "WritePin";
            this.WritePin.Size = new System.Drawing.Size(75, 23);
            this.WritePin.TabIndex = 8;
            this.WritePin.Text = "Записать";
            this.WritePin.UseVisualStyleBackColor = true;
            this.WritePin.Click += new System.EventHandler(this.WritePin_Click);
            // 
            // ReadDataSettings
            // 
            this.ReadDataSettings.Location = new System.Drawing.Point(6, 228);
            this.ReadDataSettings.Name = "ReadDataSettings";
            this.ReadDataSettings.Size = new System.Drawing.Size(107, 36);
            this.ReadDataSettings.TabIndex = 9;
            this.ReadDataSettings.Text = "Считать данные";
            this.ReadDataSettings.UseVisualStyleBackColor = true;
            this.ReadDataSettings.Click += new System.EventHandler(this.ReadDataSettings_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Sett_settings);
            this.tabControl1.Controls.Add(this.Sett_gprs);
            this.tabControl1.Controls.Add(this.Sett_Email);
            this.tabControl1.Location = new System.Drawing.Point(16, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(275, 296);
            this.tabControl1.TabIndex = 1;
            // 
            // Sett_settings
            // 
            this.Sett_settings.Controls.Add(this.ReadDataSettings);
            this.Sett_settings.Controls.Add(this.PhoneDisp);
            this.Sett_settings.Controls.Add(this.WritePin);
            this.Sett_settings.Controls.Add(this.textPhone);
            this.Sett_settings.Controls.Add(this.textPIN);
            this.Sett_settings.Controls.Add(this.PinCode);
            this.Sett_settings.Controls.Add(this.WritePhone);
            this.Sett_settings.Controls.Add(this.SerialNumber);
            this.Sett_settings.Controls.Add(this.WriteSnumber);
            this.Sett_settings.Controls.Add(this.textSNumber);
            this.Sett_settings.Location = new System.Drawing.Point(4, 22);
            this.Sett_settings.Name = "Sett_settings";
            this.Sett_settings.Padding = new System.Windows.Forms.Padding(3);
            this.Sett_settings.Size = new System.Drawing.Size(267, 270);
            this.Sett_settings.TabIndex = 0;
            this.Sett_settings.Text = "Установки";
            this.Sett_settings.UseVisualStyleBackColor = true;
            // 
            // Sett_gprs
            // 
            this.Sett_gprs.Controls.Add(this.WriteDataGPRS);
            this.Sett_gprs.Controls.Add(this.ReadDataGPRS);
            this.Sett_gprs.Controls.Add(this.textPassword);
            this.Sett_gprs.Controls.Add(this.textNameUser);
            this.Sett_gprs.Controls.Add(this.textAPN);
            this.Sett_gprs.Controls.Add(this.T2);
            this.Sett_gprs.Controls.Add(this.Beeline);
            this.Sett_gprs.Controls.Add(this.Megafon);
            this.Sett_gprs.Controls.Add(this.Mts);
            this.Sett_gprs.Location = new System.Drawing.Point(4, 22);
            this.Sett_gprs.Name = "Sett_gprs";
            this.Sett_gprs.Padding = new System.Windows.Forms.Padding(3);
            this.Sett_gprs.Size = new System.Drawing.Size(267, 270);
            this.Sett_gprs.TabIndex = 1;
            this.Sett_gprs.Text = "GPRS";
            this.Sett_gprs.UseVisualStyleBackColor = true;
            // 
            // WriteDataGPRS
            // 
            this.WriteDataGPRS.Location = new System.Drawing.Point(170, 193);
            this.WriteDataGPRS.Name = "WriteDataGPRS";
            this.WriteDataGPRS.Size = new System.Drawing.Size(75, 23);
            this.WriteDataGPRS.TabIndex = 10;
            this.WriteDataGPRS.Text = "Записать";
            this.WriteDataGPRS.UseVisualStyleBackColor = true;
            // 
            // ReadDataGPRS
            // 
            this.ReadDataGPRS.Location = new System.Drawing.Point(27, 193);
            this.ReadDataGPRS.Name = "ReadDataGPRS";
            this.ReadDataGPRS.Size = new System.Drawing.Size(75, 23);
            this.ReadDataGPRS.TabIndex = 9;
            this.ReadDataGPRS.Text = "Считать";
            this.ReadDataGPRS.UseVisualStyleBackColor = true;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(45, 151);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(177, 20);
            this.textPassword.TabIndex = 8;
            // 
            // textNameUser
            // 
            this.textNameUser.Location = new System.Drawing.Point(45, 125);
            this.textNameUser.Name = "textNameUser";
            this.textNameUser.Size = new System.Drawing.Size(177, 20);
            this.textNameUser.TabIndex = 7;
            // 
            // textAPN
            // 
            this.textAPN.Location = new System.Drawing.Point(45, 97);
            this.textAPN.Name = "textAPN";
            this.textAPN.Size = new System.Drawing.Size(177, 20);
            this.textAPN.TabIndex = 6;
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(201, 20);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(55, 53);
            this.T2.TabIndex = 5;
            this.T2.Text = "Tele2";
            this.T2.UseVisualStyleBackColor = true;
            this.T2.Click += new System.EventHandler(this.T2_Click);
            // 
            // Beeline
            // 
            this.Beeline.Location = new System.Drawing.Point(140, 20);
            this.Beeline.Name = "Beeline";
            this.Beeline.Size = new System.Drawing.Size(55, 53);
            this.Beeline.TabIndex = 4;
            this.Beeline.Text = "BeeLine";
            this.Beeline.UseVisualStyleBackColor = true;
            this.Beeline.Click += new System.EventHandler(this.Beeline_Click);
            // 
            // Megafon
            // 
            this.Megafon.Location = new System.Drawing.Point(67, 20);
            this.Megafon.Name = "Megafon";
            this.Megafon.Size = new System.Drawing.Size(67, 53);
            this.Megafon.TabIndex = 3;
            this.Megafon.Text = "Мегафон";
            this.Megafon.UseVisualStyleBackColor = true;
            this.Megafon.Click += new System.EventHandler(this.Megafon_Click);
            // 
            // Mts
            // 
            this.Mts.Location = new System.Drawing.Point(6, 20);
            this.Mts.Name = "Mts";
            this.Mts.Size = new System.Drawing.Size(55, 53);
            this.Mts.TabIndex = 0;
            this.Mts.Text = "MTC";
            this.Mts.UseVisualStyleBackColor = true;
            this.Mts.Click += new System.EventHandler(this.Mts_Click);
            // 
            // Sett_Email
            // 
            this.Sett_Email.Controls.Add(this.WriteEmail);
            this.Sett_Email.Controls.Add(this.ReadEmail);
            this.Sett_Email.Controls.Add(this.textBox13);
            this.Sett_Email.Controls.Add(this.textBox12);
            this.Sett_Email.Controls.Add(this.textBox11);
            this.Sett_Email.Controls.Add(this.textBox10);
            this.Sett_Email.Controls.Add(this.textBox9);
            this.Sett_Email.Controls.Add(this.textBox8);
            this.Sett_Email.Controls.Add(this.textBox7);
            this.Sett_Email.Controls.Add(this.label10);
            this.Sett_Email.Controls.Add(this.label9);
            this.Sett_Email.Controls.Add(this.label8);
            this.Sett_Email.Controls.Add(this.label7);
            this.Sett_Email.Controls.Add(this.label6);
            this.Sett_Email.Controls.Add(this.label5);
            this.Sett_Email.Controls.Add(this.label4);
            this.Sett_Email.Location = new System.Drawing.Point(4, 22);
            this.Sett_Email.Name = "Sett_Email";
            this.Sett_Email.Padding = new System.Windows.Forms.Padding(3);
            this.Sett_Email.Size = new System.Drawing.Size(267, 270);
            this.Sett_Email.TabIndex = 2;
            this.Sett_Email.Text = "Email";
            this.Sett_Email.UseVisualStyleBackColor = true;
            // 
            // WriteEmail
            // 
            this.WriteEmail.Location = new System.Drawing.Point(169, 222);
            this.WriteEmail.Name = "WriteEmail";
            this.WriteEmail.Size = new System.Drawing.Size(75, 23);
            this.WriteEmail.TabIndex = 15;
            this.WriteEmail.Text = "Записать";
            this.WriteEmail.UseVisualStyleBackColor = true;
            this.WriteEmail.Click += new System.EventHandler(this.WriteEmail_Click);
            // 
            // ReadEmail
            // 
            this.ReadEmail.Location = new System.Drawing.Point(14, 222);
            this.ReadEmail.Name = "ReadEmail";
            this.ReadEmail.Size = new System.Drawing.Size(75, 23);
            this.ReadEmail.TabIndex = 14;
            this.ReadEmail.Text = "Считать";
            this.ReadEmail.UseVisualStyleBackColor = true;
            this.ReadEmail.Click += new System.EventHandler(this.ReadEmail_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(111, 186);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 13;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(111, 160);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 12;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(111, 134);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 11;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(111, 108);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 10;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(111, 82);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(111, 56);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(111, 30);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Тема сообщения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Андрес назначения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Адрес отправителя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Номер порта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Адрес Сервера";
            // 
            // groupConfig
            // 
            this.groupConfig.Controls.Add(this.DisconnectCom);
            this.groupConfig.Controls.Add(this.comboBox1);
            this.groupConfig.Controls.Add(this.ConnectCom);
            this.groupConfig.Controls.Add(this.tabControl1);
            this.groupConfig.Location = new System.Drawing.Point(30, 43);
            this.groupConfig.Name = "groupConfig";
            this.groupConfig.Size = new System.Drawing.Size(320, 442);
            this.groupConfig.TabIndex = 2;
            this.groupConfig.TabStop = false;
            // 
            // ConnectCom
            // 
            this.ConnectCom.Location = new System.Drawing.Point(16, 19);
            this.ConnectCom.Name = "ConnectCom";
            this.ConnectCom.Size = new System.Drawing.Size(90, 42);
            this.ConnectCom.TabIndex = 2;
            this.ConnectCom.Text = "Подключить";
            this.ConnectCom.UseVisualStyleBackColor = true;
            this.ConnectCom.Click += new System.EventHandler(this.ConnectCom_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // DisconnectCom
            // 
            this.DisconnectCom.Location = new System.Drawing.Point(16, 67);
            this.DisconnectCom.Name = "DisconnectCom";
            this.DisconnectCom.Size = new System.Drawing.Size(90, 42);
            this.DisconnectCom.TabIndex = 4;
            this.DisconnectCom.Text = "Отключить";
            this.DisconnectCom.UseVisualStyleBackColor = true;
            this.DisconnectCom.Click += new System.EventHandler(this.DisconnectCom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 505);
            this.Controls.Add(this.groupConfig);
            this.Name = "Form1";
            this.Text = "Configurator GSM";
            this.tabControl1.ResumeLayout(false);
            this.Sett_settings.ResumeLayout(false);
            this.Sett_settings.PerformLayout();
            this.Sett_gprs.ResumeLayout(false);
            this.Sett_gprs.PerformLayout();
            this.Sett_Email.ResumeLayout(false);
            this.Sett_Email.PerformLayout();
            this.groupConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WritePhone;
        private System.Windows.Forms.Button WriteSnumber;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textSNumber;
        private System.Windows.Forms.TextBox textPIN;
        private System.Windows.Forms.Label PhoneDisp;
        private System.Windows.Forms.Label SerialNumber;
        private System.Windows.Forms.Label PinCode;
        private System.Windows.Forms.Button WritePin;
        private System.Windows.Forms.Button ReadDataSettings;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Sett_settings;
        private System.Windows.Forms.TabPage Sett_gprs;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textNameUser;
        private System.Windows.Forms.TextBox textAPN;
        private System.Windows.Forms.Button T2;
        private System.Windows.Forms.Button Beeline;
        private System.Windows.Forms.Button Megafon;
        private System.Windows.Forms.Button Mts;
        private System.Windows.Forms.TabPage Sett_Email;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button WriteDataGPRS;
        private System.Windows.Forms.Button ReadDataGPRS;
        private System.Windows.Forms.Button WriteEmail;
        private System.Windows.Forms.Button ReadEmail;
        private System.Windows.Forms.GroupBox groupConfig;
        private System.Windows.Forms.Button ConnectCom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button DisconnectCom;


    }
}

