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
using System.Linq.Expressions;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            try
            {
                decimal total = 0m;
                decimal sales;

                StreamReader inputFile;
                inputFile = File.OpenText("Sales.txt");
                while (!inputFile.EndOfStream)
                {
                    if(decimal.TryParse(inputFile.ReadLine(), out sales))
                    {
                            total += sales;
                    }
                    else
                    {
                            MessageBox.Show("invalid input");
                    }
                }

                inputFile.Close();

                totalLabel.Text = total.ToString("c");

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
