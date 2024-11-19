using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chp4_prob7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal income;    //收入
            decimal taxrate;   //稅率
            decimal payable;   //應交稅額
            decimal netIncome; //淨收入

            //以下作答

            income = decimal.Parse(incomeTextBox.Text);
            if (income >0 && income <= 590000)
            {
                taxrate = 0.05m;
                payable = taxrate * income;
            }
            else if (income <= 1330000)
            {
                taxrate = 0.12m;
                payable =590000*0.05m+(income-590000)*0.12m;
            }
            else if (income <= 2660000)
            {
                taxrate = 0.20m;
                payable = 590000 * 0.05m + (1330000 - 590000) * 0.12m+(income-1330000)*0.20m;
            }
            else if (income <= 4980000)
            {
                taxrate = 0.30m;
                payable = 590000 * 0.05m + (1330000 - 590000) * 0.12m + (2660000 - 1330000) * 0.20m+(income-2660000)*0.3m;
            }
            else
            {
                payable = 590000 * 0.05m + (1330000 - 590000) * 0.12m + (2660000 - 1330000) * 0.20m + (4980000 - 2660000) * 0.3m+ (income - 2660000) * 0.4m;
            }
            netIncome = income - payable;
           

            taxPayableLabel.Text = payable.ToString("C"); // 假設應繳稅額顯示在名為 taxTextBox 的 TextBox 控件中
            netIncomeLabel.Text = netIncome.ToString("C"); // 假設淨收入顯示在名為 netIncomeTextBox 的 TextBox 控件中
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 
