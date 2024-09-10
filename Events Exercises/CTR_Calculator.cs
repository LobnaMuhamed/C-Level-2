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
    public partial class CTR_Calculator : UserControl
    {
        public int Result = -1;

        public class CalculatingEventArgs : EventArgs
        {
            public int Num1 { get; }
            public int Num2 { get; }
            public int Result { get; }

            public CalculatingEventArgs(int result, int num1, int num2)
            {
                Num1 = num1;
                Num2 = num2;
                Result = result;
            }
        }

        public event EventHandler<CalculatingEventArgs> OnBtnClicked;


        public void RaiseOnCalculationComplete(int Result, int Val1, int Val2)
        {
            CalculatingEventArgs e = new CalculatingEventArgs(Result, Val1, Val2);
            OnBtnClicked?.Invoke(this, e);
        }



        public CTR_Calculator()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbNumber1.Text.ToString(), out int Num1) &&
                int.TryParse(txtbNumber2.Text.ToString(), out int Num2)
                )
            {
                Result = Num1 + Num2;
                txtbResult.Text = Result.ToString();
                RaiseOnCalculationComplete(Result, Num1, Num2);
            }
        }


    }
}
