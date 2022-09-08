using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;

namespace sslTextBox
{
    public partial class ucDataInformation : FlyoutPanel
    {
        public ucDataInformation()
        {
            InitializeComponent();
            this.Showing += UcDataInformation_Showing;
        }

        private void UcDataInformation_Showing(object sender, FlyoutPanelEventArgs e)
        {
            this.lblHeader.Text = clInformation.ItemHeader;
            this.meContext.Text = clInformation.ItemContext;
            this.meContext.ReadOnly = true;
        }
    }
}
