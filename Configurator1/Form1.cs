﻿using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Configurator1
{
   public enum base_comandEC 
    {
       START_CONFIG  =  0x01,//0x70 // начать сеанс работы с модемом
       STOP_CONFIG  =   0x02,//0x79 // завершить сеанс работы с модемом
       SET_MODEM_DATA = 0x71, // получить общие данные о модеме
       GET_NUMBER_EK =  0x11,//0x21 // получить номер ЭК
       SET_NUMBER_EK =  0x21,//0x22 // установить номер ЭК
       GET_PIN_COD =    0x12, // получить PIN-код
       SET_PIN_COD  =   0x22, // установить  PIN-код
       GET_GPRS_DATA =  0x13,//0x73 // получить параметры GPRS соединения
       SET_GPRS_DATA =  0x23,//0x74 // установить  параметры GPRS соединения
       GET_N_PHONE   =  0x14,//0x82 // получить номер телефона диспетчера
       SET_N_PHONE  =   0x24,//0x72 // установить номер телефона диспетчера
       GET_GPRS_SOCKET= 0x15,//0x75 // получить параметры GPRS сокета
       SET_GPRS_SOCKET =0x25,//0x76 // установить параметры GPRS сокета
       GET_EMAIL_DATA=  0x16,//0x77 // получить параметры Email
       SET_EMAIL_DATA = 0x26//0x78 // установить параметры Email
    }
    public partial class Form1 : Form
    {
        int phone = 0;
        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            tServerAddress.ReadOnly = true;
            tServerAddress.TextAlign = HorizontalAlignment.Center;
            tServerAddress.Text = "ec.axion-med.ru";
            
            //tPortNumber.ReadOnly = true;
            //tPortNumber.TextAlign = HorizontalAlignment.Center;
            //tPortNumber.Text = "25";
        }

        private void ConnectCom_Click(object sender, EventArgs e)
        {
            Program.sPort.PortName = comboBox1.Text;
            Program.sPort.BaudRate = 115200;
            Program.sPort.StopBits = StopBits.One;
            Program.sPort.Parity = Parity.None;
            Program.sPort.DataBits = 8;
            Program.sPort.Open();
            if (Program.sPort.IsOpen)
            {
                Program.sPort.Write(START_CONFIG);
            }
        }

        private void DisconnectCom_Click(object sender, EventArgs e)
        {
            Program.sPort.Close();
            comboBox1.Items.Clear();
          //  string[] ports = SerialPort.GetPortNames();
         //   comboBox1.Items.AddRange(ports);
        }
       private void WritePhone_Click(object sender, EventArgs e)
        {
          //  int wPhone = 0;
             
           
            try
            {
               // string str = Convert.ToString(textPhone);
                if (textPhone != null)
                {
                  //  int.TryParse(str, out wPhone);
                    
                    phone = textPhone.TextLength;
                    if (phone < 11) { MessageBox.Show("не верно указан телефон"); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

       private void WritePin_Click(object sender, EventArgs e)
       {
           string str = "0000";
           string in_str = "";
           try
           {
               in_str = Convert.ToString(textPIN);
               if (in_str != str)
               {
                   MessageBox.Show("не верно введен пин код");
               }
               else { //отправить по com порту пин код и компанду
               }

           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }

       private void ReadDataSettings_Click(object sender, EventArgs e)
       {
           // отправка запроса, и
           //считывание данных с кардиографа
       }

       private void Mts_Click(object sender, EventArgs e)
       {
           try
           {
                textAPN.TextAlign = HorizontalAlignment.Center;
                textAPN.Text = "internet.mts.ru";
                textNameUser.TextAlign = HorizontalAlignment.Center;
                textNameUser.Text = "mts";
                textPassword.TextAlign = HorizontalAlignment.Center;
                textPassword.Text = "mts";
               
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }

       private void Megafon_Click(object sender, EventArgs e)
       {
           try
           {
                textAPN.TextAlign = HorizontalAlignment.Center;
               textAPN.Text = "internet";
                textNameUser.TextAlign = HorizontalAlignment.Center;
                textNameUser.Text = "gdata";
                textPassword.TextAlign = HorizontalAlignment.Center;
                textPassword.Text = "gdata";
               
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }

       private void Beeline_Click(object sender, EventArgs e)
       {
           try
           {
                textAPN.TextAlign = HorizontalAlignment.Center;
                textAPN.Text = "internet.beeline.ru";
                textNameUser.TextAlign = HorizontalAlignment.Center;
                textNameUser.Text = "beeline";
                textPassword.TextAlign = HorizontalAlignment.Center;
                textPassword.Text = "beeline";
               
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }

       private void T2_Click(object sender, EventArgs e)
       {
           
               try
           {
                textAPN.TextAlign = HorizontalAlignment.Center;
                textAPN.Text = "internet.tele2.ru";
                textNameUser.TextAlign = HorizontalAlignment.Center;
               textNameUser.Text = "";
                textPassword.TextAlign = HorizontalAlignment.Center;
               textPassword.Text = "";
               
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }

       private void ReadEmail_Click(object sender, EventArgs e)
       {
            /*отправить команду по com на считывание данных(email) с кардиографа*/
           
        }

        private void WriteEmail_Click(object sender, EventArgs e)
       {
            
           /*считать все поля  потом запись данных(email) на кардиограф*/
          
       }
    

      
    }
}
