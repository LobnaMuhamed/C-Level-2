using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_Exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctR_Calculator1.OnBtnClicked += MyFun;
        }


        private void MyFun(object sender, CTR_Calculator.CalculatingEventArgs e)
        {
            MessageBox.Show($"Num1 = {e.Num1} ,Num2 = {e.Num2} , Result = {e.Result}");
        }
    }
}
