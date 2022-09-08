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

namespace sslDataTextBox
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
            this.lblHeader.Text = DataItemInformation.ItemHeader;
            this.meContext.Text = DataItemInformation.ItemContext;
            this.meContext.ReadOnly = true;
            
        }
    }
}
