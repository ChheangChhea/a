using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public abstract class AbstractDrink
        {
            public abstract object GetDescription(double weight);
            public abstract double TotalWeight { get; }
            public string Decription
            {
                get
                {
                    GetDescription(TotalWeight).ToString();
                }
            }
        }

    }
}
