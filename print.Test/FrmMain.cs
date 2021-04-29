using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace print.Test
{
    public partial class FrmMain : Form
    {
        readonly Neusoft.Dawn.Core.Util.Print _printTool = new Neusoft.Dawn.Core.Util.Print();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var template = new UcTmp();
            //(1)default size: A4
            _printTool.SetPageSize(PaperKind.A5, true);

            //(2)set size
            //var pageSize = new PaperSize("test", (int)(595.32 / 72 * 100), (int)(419.52 / 72 * 100));
            //_printTool.SetPageSize(pageSize, false);


            _printTool.PrintPage(0, 0, template);
        }
    }
}
