using DevExpress.XtraEditors;
using FuXin.Lis.UI.Area;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuXin.Lis.Startup
{
    public partial class FLogin : DevExpress.XtraEditors.XtraForm
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMain fmain = new FMain();
            fmain.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}