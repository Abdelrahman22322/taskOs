using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void opration_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'c':
                case 'C':
                    if (File.Exists(file_name.Text))
                    {
                        MessageBox.Show("This file has already been created");
                    }
                    else
                    {
                        FileStream Fs = new FileStream(file_name.Text, FileMode.Create, FileAccess.ReadWrite);
                        
                        Fs.Close();
                    }

                    break;
                case 'd':
                case 'D':
                    if (File.Exists(file_name.Text))
                    {
                        File.Delete(file_name.Text);
                    }
                    else
                        MessageBox.Show("This File does Not exist");

                    break;

                case 'o':
                case 'O':
                    if (File.Exists(file_name.Text))
                    {
                        FileStream fs = new FileStream(file_name.Text, FileMode.Open, FileAccess.Read);

                        StreamReader str = new StreamReader(fs);
                            
                                str.BaseStream.Seek(0, SeekOrigin.Begin);
                                file_content.Text = str.ReadToEnd();
                             
                                str.Close();
                                fs.Close();
                            

                            //byte[] Bytes = new byte[fss.Length];
                            //int NumberBytesToRead = (int)fss.Length;
                            //int ByteRead = 0;

                            //while (NumberBytesToRead > 0)
                            //{
                            //    int n = fss.Read(Bytes, ByteRead, NumberBytesToRead);

                            //    if (n == 0)
                            //        break;
                            //    NumberBytesToRead -= n;
                            //    ByteRead += n;


                            //}


                            //foreach (var VARIABLE in Bytes)
                            //{
                            //    Console.Write((char)VARIABLE);
                            //}

                           

                        
                    }
                    else
                        MessageBox.Show("This file does not exist");

                    break;
                case 's':
                case 'S':
                    
                    FileStream fss = new FileStream(file_name.Text, FileMode.Open, FileAccess.Write);

                    
                    StreamWriter strW = new StreamWriter(fss);
                        
                            strW.Write(file_content.Text);
                            strW.Flush();

                       strW.Close();
                    fss.Close();
                    

                    break;

                case '?':
                case '؟':

                    MessageBox.Show("c =create \nd =delete \no =open \ns =save");

                    break;



            }
        }
    }
}
