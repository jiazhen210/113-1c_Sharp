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

namespace Load_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exitButton.Text = "離開";
            try
            {
                StreamReader inputFile;//用來讀取檔案物件
                string countryName;   //用來保存檔案中的資料
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText("Countries,txt");//開啟檔案
                    while (!inputFile.EndOfStream) //當未達到檔案結尾時
                    {
                        countryName = inputFile.ReadLine();//讀取一行資料
                        countriesListBox.Items.Add(countryName);//將資料加入list box
                    }
                    inputFile.Close();//關閉檔案
                }
                else
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void countriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(countriesListBox.SelectedItems.ToString());
        }
    }
}
