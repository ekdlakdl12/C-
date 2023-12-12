using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A129_FormClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //this는 form1을 가르킴
            this.ClientSize = new Size(500, 500);

            // form2 객체를 생성하고 this.AddOwndedForm을 사용하여 f2를 추가 
            Form f2 = new Form2();
            this.AddOwnedForm(f2);

            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
