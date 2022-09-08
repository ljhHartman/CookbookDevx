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
using DevExpress.XtraGrid.Views.Grid;

namespace sslDataTextBox
{
    public partial class ucChooseItem : FlyoutPanel
    {
        public ucChooseItem()
        {
            InitializeComponent();
            /// Show find panel of the gridview
            gridView1.ShowFindPanel();
            /// Add event handlers for control and gridview
            this.Showing += UcChooseItem_Showing;
            this.gridView1.DoubleClick += GridView1_DoubleClick;
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            /// On double click on the gridview get selected value and return to textbox
            GridView view = (GridView)sender;
            string strItem = view.FocusedValue.ToString();
            clGridItems.strReturnValue = strItem;
            this.HideBeakForm();
        }

        private void UcChooseItem_Showing(object sender, FlyoutPanelEventArgs e)
        {
            /// On load/showing set the datasource for the gridview retrieved from the textbox class
            gcItems.DataSource = clGridItems.blItems;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            /// On click get selected value and return to textbox
            if (gridView1.RowCount > 0)
            {
                int[] iRows = gridView1.GetSelectedRows();
                int iRow = iRows[0];
                gridView1.FocusedRowHandle = gridView1.GetVisibleRowHandle(iRow);
                clGridItems.strReturnValue = gridView1.FocusedValue.ToString();
                this.HideBeakForm();
            }
            else
            {
                clGridItems.strReturnValue = null;
                this.HideBeakForm();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            /// Return to textbox without a value
            clGridItems.strReturnValue = null;
            this.HideBeakForm();
        }
    }
}
