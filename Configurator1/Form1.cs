using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Configurator1
{
    public partial class Form1 : Form
    {
        int phone = 0;
        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }

        private void ConnectCom_Click(object sender, EventArgs e)
        {
            Program.sPort.PortName = comboBox1.Text;
            Program.sPort.BaudRate = 115200;
            Program.sPort.StopBits = StopBits.One;
            Program.sPort.Parity = Parity.None;
            Program.sPort.DataBits = 8;
            Program.sPort.Open();
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
               textAPN.Text = "internet.mts.ru";
               textNameUser.Text = "mts";
               textPassword.Text = "mts";
               //далее записать даныне по ком порту
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }

       private void Megafon_Click(object sender, EventArgs e)
       {
           try
           {
               textAPN.Text = "internet";
               textNameUser.Text = "gdata";
               textPassword.Text = "gdata";
               //далее записать даныне по ком порту
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }

       private void Beeline_Click(object sender, EventArgs e)
       {
           try
           {
               textAPN.Text = "internet.beeline.ru";
               textNameUser.Text = "beeline";
               textPassword.Text = "beeline";
               //далее записать даныне по ком порту
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }

       private void T2_Click(object sender, EventArgs e)
       {
           
               try
           {
               textAPN.Text = "internet.tele2.ru";
               textNameUser.Text = "";
               textPassword.Text = "";
               //далее записать даныне по ком порту
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }

       private void ReadEmail_Click(object sender, EventArgs e)
       {
           /*отправить команду по com на считывание данных(email) с кардиографа*/
       }

       private void WriteEmail_Click(object sender, EventArgs e)
       {
           /*запись данных(email) на кардиограф*/
       }
    

      
    }
}
