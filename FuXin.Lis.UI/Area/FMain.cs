using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuXin.Lis.UI.Area
{
    public partial class FMain : DevExpress.XtraBars.TabForm
    {
        private Dictionary<string, TabFormPage> TabPageDic = new Dictionary<string, TabFormPage>();
        private Dictionary<string, TabFormContentContainer> TabContentDic = new Dictionary<string, TabFormContentContainer>();
        public FMain()
        {
            InitializeComponent();
        }

        private void tabFormControl1_Click(object sender, EventArgs e)
        {

        }

     

     

        private void tabFormControl1_SelectedPageChanged(object sender, TabFormSelectedPageChangedEventArgs e)
        {
           
        }



        private void AddTab(string tabName, string tabText, DevExpress.XtraEditors.XtraForm xtraForm = null, XtraUserControl xtraUserControl = null)
        {
            TabFormPage tabPage;

            var isTabPageExsit = TabPageDic.TryGetValue(tabName, out tabPage);
            if (isTabPageExsit)//判断新增的TabPage是否已经存在
            {
                test.SelectedPage = tabPage;//设置为选中
                return;
            }
            TabFormPage newTabPage = new TabFormPage();

            newTabPage.Name = tabName;//设置新TabPage的Name
            newTabPage.Text = tabText;//设置新TabPage的标题文本
            TabPageDic.Add(tabName, newTabPage);
            test.Pages.Add(newTabPage);//添加
            foreach (System.Windows.Forms.Control control in this.Controls) 
            {
                //MessageBox.Show(control.Name);
            }
            test.SelectedPage = newTabPage;//设置为选中
            
            //if (xtraForm != null)
            //{
            //    xtraForm.Dock = DockStyle.Fill;
            //    xtraForm.FormBorderStyle = FormBorderStyle.None;
            //    xtraForm.TopLevel = false;
            //    newForm.Parent = ((XtraTabControl)sender).SelectedTabPage;
            //    xtraForm.ControlBox = false;
            //    xtraForm.Visible = true;

            //    tabFormContentContainer2.Controls.Add(xtraForm);
            //}
            //if (xtraUserControl != null)
            //{
            //    xtraUserControl.Dock = DockStyle.Fill;
            //    newTabPage.ContentContainer.Controls.Add(xtraUserControl);
            //}

        }

        private void FMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("是否确认关闭", "提示", MessageBoxButtons.OK) ==DialogResult.OK)
            {
                Process current = Process.GetCurrentProcess();
                // 获取当前本地计算机上指定的进程名称的所有进程
                Process[] processes = Process.GetProcessesByName(current.ProcessName);
                foreach (var process in processes)
                {
                    if (!process.HasExited) process.Kill();
                }
            }  
          
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            RibbonForm1 rf = new RibbonForm1();
            rf.TopLevel = false;
          
            AddTab(e.Item.Name, e.Item.Caption, rf);
            //tabFormContentContainer TabFormContentContainer
          

        }

        private void test_PageClosed(object sender, PageClosedEventArgs e)
        {
            TabPageDic.Remove(e.Page.Name);
        }
    }
}