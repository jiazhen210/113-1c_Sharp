using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m;//月利率
            decimal balance;//餘額
            int months;//月份

            if (decimal.TryParse(startingBalTextBox.Text, out balance)&&balance>0)
            {
                if (int.TryParse(monthsTextBox.Text, out months) && months>0)
                {
                    int count = 1;//迴圈計數器
                    while (count <= months) ;
                    {
                        //計算餘額
                        balance = balance + (INTEREST_RATE * balance);
                        detailListBox.Items.Add("第" + count + "個月的餘額是" + balance.ToString("c"));
                        count += 1;
                    }
                    //顯示結果
                    endingBalanceLabel.Text = balance.ToString("c");
                }

                else
                {
                    MessageBox.Show("輸入【月份數量】資料格式錯誤");
                }

            }
            else
            {
                MessageBox.Show("輸入【起始餘額】資料格式錯誤");
            }
        }
    }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes, the endingBalanceLabel control,
            // and the ListBox.
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // Reset the focus.
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
