using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sslDataTextBox
{
    public class TxtDataTextBox : TextEdit
    {
        public TxtDataTextBox()
        {
            /// Set textbox settings and color
            this.Enabled = true;
            this.MaskBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MaskBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ShowToolTips = false;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ForeColor = System.Drawing.Color.Black;
            /// Add event handlers for textbox
            this.KeyDown += TxtDataTextBox_KeyDown;
            this.Leave += TxtDataTextBox_Leave;
            this.LostFocus += TxtDataTextBox_LostFocus;
            this.DoubleClick += TxtDataTextBox_DoubleClick;
        }
        
        private void TxtDataTextBox_LostFocus(object sender, EventArgs e)
        {
            /// On leaving textbox split string and set tag and edit value
            char[] chrSeparator = new char[] { '|' };
            string[] strSeparator = new string[] { "Tag:" };
            string[] strItem = this.Text.Split(chrSeparator);
            string[] strItemTag = this.Text.Split(strSeparator, StringSplitOptions.None);

            if (this.Text.Contains("|") == true)
            {
                if (this.Text.Contains("Tag:") == true)
                {
                    this.Tag = strItemTag[1].Trim();
                    this.EditValue = strItem[0].Trim();
                }
                else
                {
                    this.Tag = strItem[0].Trim();
                    this.EditValue = strItem[1].Trim();
                }
            }
            //bool found = false;
            //string inputText = this.Text;

            //foreach (string item in this.MaskBox.AutoCompleteCustomSource)
            //{
            //    if (inputText.ToUpper().Trim() == item.ToUpper().Trim())
            //    {
            //        found = true;
            //    }
            //}

            //if (found == false)
            //{
            //    MessageBox.Show("Not a valid item! Please choose an item or make it empty!");
            //    this.Focus();
            //    this.SelectAll();
            //}

            /// On leaving textbox split string and set tag and edit value
            //char[] chrSeparator = new char[] { '|' };
            //string[] strSeparator = new string[] { "Tag:" };
            //string[] strItem = this.Text.Split(chrSeparator);
            //string[] strItemTag = this.Text.Split(strSeparator, StringSplitOptions.None);

            //if (this.Text.Contains("|") == true)
            //{
            //    if (this.Text.Contains("Tag:") == true)
            //    {
            //        this.Tag = strItemTag[1].Trim().ToUpper();
            //        this.EditValue = strItem[0].Trim().ToUpper();
            //    }
            //    else
            //    {
            //        this.Tag = strItem[0].Trim().ToUpper();
            //        this.EditValue = strItem[0].Trim().ToUpper();
            //    }
            //}
            //else if (this.Text != "")
            //{
            //    this.Tag = strItem[0].Trim().ToUpper();
            //    this.EditValue = strItem[0].Trim().ToUpper();
            //}
            //else if (this.Text == "")
            //{
            //    this.EditValue = null;
            //}
            //if (this.Text.Contains("|") == true)
            //{
            //    if (this.Text.Contains("Tag:") == true)
            //    {
            //        this.Tag = strItemTag[1].Trim();
            //        this.EditValue = strItem[0].Trim();
            //    }
            //    else
            //    {
            //        this.Tag = strItem[0].Trim();
            //        this.EditValue = strItem[0].Trim().ToUpper();
            //    }
            //}
        }

        private void TxtDataTextBox_DoubleClick(object sender, EventArgs e)
        {
            /// Show user control
            ShowDataList();
        }

        private void Fp_Hiding(object sender, FlyoutPanelEventArgs e)
        {
            /// On hiding the user control set the selected text
            if (ClGridItems.StrReturnValue != null)
            {
                this.Text = ClGridItems.StrReturnValue;
                ClGridItems.StrReturnValue = null;
            }
        }

        private void TxtDataTextBox_Leave(object sender, EventArgs e)
        {
            /// On leaving textbox split string and set tag and edit value
            char[] chrSeparator = new char[] { '|' };
            string[] strSeparator = new string[] { "Tag:" };
            string[] strItem = this.Text.Split(chrSeparator);
            string[] strItemTag = this.Text.Split(strSeparator, StringSplitOptions.None);

            //Set text to uppercase
            this.Text = this.Text.ToUpper();

            //Check value
            if (this.Text.Contains("|") == true)
            {
                if (this.Text.Contains("TAG:") == true)
                {
                    this.Tag = strItemTag[1].Trim().ToUpper();
                    this.EditValue = strItem[0].Trim().ToUpper();
                }
                else
                {
                    this.Tag = strItem[0].Trim().ToUpper();
                    this.EditValue = strItem[1].Trim().ToUpper();
                }
            }
            else if (this.Text == "")
            {
                this.EditValue = null;
            }
            // Check if input is found in list
            bool found = false;
            string inputText = this.Text;



            foreach (string item in this.MaskBox.AutoCompleteCustomSource)
            {
                if (inputText.ToUpper().Trim() == item.Trim().ToUpper())
                {
                    found = true;
                }
            }

            if (found == false)
            {
                foreach (string item in this.MaskBox.AutoCompleteCustomSource)
                {
                    char[] chrSeparatorCheck = new char[] { '|' };
                    string[] strItemCheck = item.Split(chrSeparatorCheck);
                    if (inputText.ToUpper().Trim() == strItemCheck[0].Trim().ToUpper())
                    {
                        found = true;
                    }
                }
            }

            if (found == false && this.Text != "")
            {
                Boolean bAgenda = false; // temporary till agenda is renewed

                if (this.Parent.Name == "frmDetailAgenda")
                {
                    if (this.Name == "fsDtxtCHAUFFEUR")
                    {
                        bAgenda = true;
                    }
                    if (this.Name == "fsDtxtAFLEVERAAR")
                    {
                        bAgenda = true;
                    }
                    if (this.Name == "fsDtxtSCHIPPER")
                    {
                        bAgenda = true;
                    }
                    if (this.Name == "fsDtxtMATROOS")
                    {
                        bAgenda = true;
                    }
                }

                if (bAgenda == false)
                {
                    MessageBox.Show("Not a valid item! Please choose an item or make it empty!");
                    this.Focus();
                    this.SelectAll();
                }
                
            }
            //else
            //{
            //    /// On leaving textbox split string and set tag and edit value
            //    char[] chrSeparator = new char[] { '|' };
            //    string[] strSeparator = new string[] { "Tag:" };
            //    string[] strItem = this.Text.Split(chrSeparator);
            //    string[] strItemTag = this.Text.Split(strSeparator, StringSplitOptions.None);

            //    if (this.Text.Contains("|") == true)
            //    {
            //        if (this.Text.Contains("Tag:") == true)
            //        {
            //            this.Tag = strItemTag[1].Trim().ToUpper();
            //            this.EditValue = strItem[0].Trim().ToUpper();
            //        }
            //        else
            //        {
            //            this.Tag = strItem[0].Trim().ToUpper();
            //            this.EditValue = strItem[0].Trim().ToUpper();
            //        }
            //    }
            //    else if (this.Text != "")
            //    {
            //        this.Tag = strItem[0].Trim().ToUpper();
            //        this.EditValue = strItem[0].Trim().ToUpper();
            //    }
            //    else if (this.Text == "")
            //    {
            //        this.EditValue = null;
            //    }
            //}
        }
        
        private void TxtDataTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            /// Handle specific key inputs
            if (e.KeyCode == System.Windows.Forms.Keys.F6)
            {
                /// Show user control
                ShowDataList();
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.Down)
            {
                /// On key down (arrow key) iterate throug custom source downwards
                bool bFound = false;
                //char[] chrSeparator = new char[] { '|' };
                //string[] strSeparator = new string[] { "Tag:" };

                foreach (String item in this.MaskBox.AutoCompleteCustomSource)
                {
                    if (bFound == true)
                    {
                        this.EditValue = item;

                        return;
                    }

                    if (this.Text.Trim() == "")
                    {
                        this.EditValue = item;
                        bFound = false;
                        return;
                    }
                    else
                    {
                        string strText = "";
                        if (this.Text.Contains("|") == false)
                        {
                            if (this.Tag == null)
                            {
                                strText = this.Text;
                            }
                            else
                            {
                                strText = this.Tag.ToString() + " | " + this.EditValue;
                            }
                            
                        }
                        else
                        {
                            strText = this.Text;
                        }
                        if (strText.ToUpper().Trim() == item.ToUpper().Trim())
                        {
                            bFound = true;
                        }                        
                    }
                }
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.Up)
            {
                /// On key up (arrow key) iterate throug custom source upwards
                string strPrevious = "";
                char[] chrSeparator = new char[] { '|' };

                foreach (String item in this.MaskBox.AutoCompleteCustomSource)
                {
                    string[] strItem = item.Split(chrSeparator);
                    string strText = "";

                    if (this.Text.Contains("|") == false)
                    {
                        if (this.Tag == null)
                        {
                            strText = this.Text;
                        }
                        else
                        {
                            strText = this.Tag.ToString() + " | " + this.EditValue;
                        }
                    }
                    else
                    {
                        strText = this.Text;
                    }

                    if (strText.ToUpper().Trim() == item.ToUpper().Trim())
                    {
                        if (strPrevious == "")
                        {
                            return;
                        }

                        this.EditValue = strPrevious;

                        return;
                    }

                    strPrevious = item;
                }
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F3)
            {
                /// Show user control with information about the field and data
                ucDataInformation fp = new ucDataInformation
                {
                    OwnerControl = this,
                    ParentForm = this.FindForm()
                };
                fp.OptionsBeakPanel.CloseOnOuterClick = true;
                fp.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
                fp.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;

                if (this.Tag != null)
                {
                    if (this.Tag.ToString() != "")
                    {
                        DataItemInformation.ItemHeader = this.ToolTipTitle + " : " + this.Tag;
                    }
                    else
                    {
                        DataItemInformation.ItemHeader = this.ToolTipTitle;
                    }
                }
                else
                {
                    DataItemInformation.ItemHeader = this.ToolTipTitle;
                }
                DataItemInformation.ItemContext = String.Format(this.ToolTip,this.Tag, this.EditValue);
                
                fp.ShowBeakForm();
            }
        }

        private void ShowDataList()
        {
            /// Set user control Flyout Panel
            ucChooseItem fp = new ucChooseItem
            {
                Width = 650,
                Height = 500,
                OwnerControl = this,
                ParentForm = this.FindForm()
            };
            fp.OptionsBeakPanel.CloseOnOuterClick = true;
            fp.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center;
            fp.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;

            /// Create an bindinglist from the auto complete custom source
            BindingList<SelectItems> blItemsList = new BindingList<SelectItems>();

            foreach (String item in this.MaskBox.AutoCompleteCustomSource)
            {
                blItemsList.Add(new SelectItems() { ItemString = item });
            }

            /// Set global bindinglist for passing to user control
            ClGridItems.BlItems = blItemsList;

            /// Add event handler for hiding the control
            fp.Hiding += Fp_Hiding;
            /// Show control as beak form
            fp.ShowBeakForm();
        }
    }
}
