/*
Gabe Sibulkin
Prof. Gitlitz
CRC Lab, CPET 222
Can't do newlines(input3) but can manage the first two inputs.
 3/19/21
*/


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

namespace CRC_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GrabInputFiles_Click(object sender, EventArgs e)
        {
            // local variables
            String info;

            // declare & instantiate an OpenFileDialog object
            OpenFileDialog fDial = new OpenFileDialog();

            // ininitalize file search to current folder
            fDial.InitialDirectory = Path.Combine(Application.StartupPath, "");

            // filter for only text files in the working folder
            fDial.Filter = "Text Files (*.txt) | *.txt";

            // show dialog, select and display text file
            if (fDial.ShowDialog() == DialogResult.OK)
            {
                // initialize String to absolute path the selected text file
                String file = fDial.FileName;
                /* instantiate and initialize a StreamReader object to the 
                 * selected text file
                 */
                StreamReader reader = new StreamReader(file);
                // copy the absolute path name of text file to textBox1
                PathBox.AppendText(file);
                //textBox1.AppendText(file);
                info = reader.ReadToEnd();
                DataBox.Clear();
                DataBox.AppendText(info);
                //textBox2.Clear();
                //textBox2.AppendText(info + "\r\n\r\n");
                reader.Close(); // close file reading resources
                //restore OpenFileDialog opening directory to original directory
                fDial.RestoreDirectory = true;
            }
            else
            {
                // something wrong if this path is taken
                DataBox.Text = "Error reading text files";
            }
        }

        private void CRC_Button_Click(object sender, EventArgs e)
        {
            String inString;

            byte[] byteAry;

            inString = DataBox.Text;

            if (inString.Length == 0)
            {
                DataBox.Text = "Input must be selected!";
            }

            byteAry = toByteArray(inString);

            byte crc = CRC8(byteAry);

            textBox1.Text = crc.ToString();
            textBox2.Text = Convert.ToString(crc, 16);
            textBox3.Text = Convert.ToString(crc, 8);
            textBox4.Text = Convert.ToString(crc, 2);

        }

        static byte[] toByteArray(string input)
        {
            // declare local variables            

            Encoding asciiEncoder = Encoding.ASCII;

            byte[] byteAry;                                             // an array of bytes            

            byteAry = new byte[input.Length + 1];                       // transfer string into byte array using Encoding object    

            asciiEncoder.GetBytes(input, 0, input.Length, byteAry, 0);  // copy a null character into last index of byte array

            byteAry[byteAry.Length - 1] = 0;

            return byteAry;
        }

        public static byte CRC8(byte[] bytes)
        {
            const int poly = 0x125;
            byte crc = 0; /* start with 0 so first byte can be 'xored' in */
            

            foreach (byte CurrentByte in bytes) // moves through each byte of data
            {
                
                if (CurrentByte != 0x00) // check if it's the end of the message
                {
                    crc ^= CurrentByte; /* XOR-in the next input byte */

                    for (int i = 0; i < 8; i++) // move through each byte
                    {
                        if ((crc & 0x80) != 0) // check for carry
                        {
                            crc = (byte)((crc << 1) ^ poly); // do xor 
                        }
                        else
                        {
                            crc <<= 1; // not at carry location shift to the left and try again
                        }
                    }
                }
            }

            return crc;
        }
        

    }
        

        
}
