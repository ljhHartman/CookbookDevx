using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sslTextBox
{
    public class txtTextBox : TextEdit
    {
        public txtTextBox()
        {
            this.Enabled = true;
            this.ShowToolTips = false;

            this.KeyDown += TxtTextBox_KeyDown;
            this.Leave += TxtTextBox_Leave;
        }

        private void TxtTextBox_Leave(object sender, EventArgs e)
        {
            if (this.Parent.Name != "frmDetailCostRevenue" && this.Parent.Name != "ucPackagesStock" && this.Parent.Name != "frmDetailVersion" && this.Parent.Name != "frmDetailStockProducts")
            {
                if (this.Text == "")
                {
                    this.EditValue = null;
                }
                else if (this.Text != "")
                {
                    decimal dNumber;
                    if (Decimal.TryParse(this.Text, out dNumber))
                    {
                        this.Text = this.Text.Replace(".", ",");
                    }
                }
            }
            else
            {
                if (this.Text == "")
                {
                    this.EditValue = null;
                }
            }
            
        }

        private void TxtTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F3)
            {
                /// Show user control with information about the field and data
                ucDataInformation fp = new ucDataInformation();
                fp.OwnerControl = this;
                fp.ParentForm = this.FindForm();
                fp.OptionsBeakPanel.CloseOnOuterClick = true;
                fp.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
                fp.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;

                clInformation.ItemHeader = this.ToolTipTitle;
                clInformation.ItemContext = String.Format(this.ToolTip, this.EditValue);

                fp.ShowBeakForm();
            }
        }
    }
}
