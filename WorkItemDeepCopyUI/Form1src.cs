using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.TeamFoundation.Client;

namespace WorkItemDeepCopyUI
{
    class Form1src : Form
    {
        #region Fields

        private Dictionary<string, string> RplDic = new Dictionary<string, string>();
        private IContainer components;
        private Button button1;
        private TextBox tbRootWorkItemId;
        private DataGridView UrlReplTable;
        private DataGridViewTextBoxColumn OriginalValue;
        private DataGridViewTextBoxColumn NewValue;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox tbCustomFieldRefValue;
        private Label label3;
        private TextBox tbCustomFieldRefName;
        private TabControl dgWiTypes;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private CheckBox cbReplaceHyperlinks;
        private CheckBox cbReplaceCustomField;
        private TabPage tabPage4;
        private Label label2;
        private TextBox tbHistoryComment;
        private TabPage tabPage5;
        private CheckBox cbCopyLinksToVersionendItems;
        private CheckBox cbKeepLatestChangesetLinksOnly;
        private CheckBox cbCopyLinksToChangesets;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private Label label6;
        private Label label5;
        private TabPage tabPage8;
        private CheckBox cbCopyAttachments;
        private Button button2;
        private DataGridView dgWilTypes;
        private DataGridViewTextBoxColumn WorkItemLinkType;
        private DataGridView dgWiTypes2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox tbPrimaryLinkTypeEnd;
        private Label label7;
        private Label lbResult;
        private LinkLabel linkLabel1;
        private Label lbTfsUri;
        private Uri projCollUri;

        #endregion

        public Form1src()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.button1 = new Button();
            this.tbRootWorkItemId = new TextBox();
            this.UrlReplTable = new DataGridView();
            this.OriginalValue = new DataGridViewTextBoxColumn();
            this.NewValue = new DataGridViewTextBoxColumn();
            this.label1 = new Label();
            this.groupBox1 = new GroupBox();
            this.label4 = new Label();
            this.tbCustomFieldRefValue = new TextBox();
            this.label3 = new Label();
            this.tbCustomFieldRefName = new TextBox();
            this.dgWiTypes = new TabControl();
            this.tabPage1 = new TabPage();
            this.tabPage2 = new TabPage();
            this.cbReplaceHyperlinks = new CheckBox();
            this.tabPage3 = new TabPage();
            this.cbReplaceCustomField = new CheckBox();
            this.tabPage4 = new TabPage();
            this.label2 = new Label();
            this.tbHistoryComment = new TextBox();
            this.tabPage5 = new TabPage();
            this.cbCopyLinksToVersionendItems = new CheckBox();
            this.cbKeepLatestChangesetLinksOnly = new CheckBox();
            this.cbCopyLinksToChangesets = new CheckBox();
            this.tabPage6 = new TabPage();
            this.tbPrimaryLinkTypeEnd = new TextBox();
            this.label7 = new Label();
            this.dgWilTypes = new DataGridView();
            this.WorkItemLinkType = new DataGridViewTextBoxColumn();
            this.label6 = new Label();
            this.tabPage7 = new TabPage();
            this.dgWiTypes2 = new DataGridView();
            this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.label5 = new Label();
            this.tabPage8 = new TabPage();
            this.cbCopyAttachments = new CheckBox();
            this.button2 = new Button();
            this.lbResult = new Label();
            this.lbTfsUri = new Label();
            this.linkLabel1 = new LinkLabel();
            //this.UrlReplTable.BeginInit();
            this.groupBox1.SuspendLayout();
            this.dgWiTypes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            //this.dgWilTypes.BeginInit();
            this.tabPage7.SuspendLayout();
            //this.dgWiTypes2.BeginInit();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            this.button1.Location = new Point(443, 373);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Deep Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.tbRootWorkItemId.Location = new Point(133, 36);
            this.tbRootWorkItemId.Name = "tbRootWorkItemId";
            this.tbRootWorkItemId.Size = new Size(56, 20);
            this.tbRootWorkItemId.TabIndex = 1;
            this.tbRootWorkItemId.Text = "12";
            this.UrlReplTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrlReplTable.Columns.AddRange((DataGridViewColumn)this.OriginalValue, (DataGridViewColumn)this.NewValue);
            this.UrlReplTable.Location = new Point(6, 66);
            this.UrlReplTable.Name = "UrlReplTable";
            this.UrlReplTable.Size = new Size(418, 154);
            this.UrlReplTable.TabIndex = 2;
            this.OriginalValue.HeaderText = "Original Value";
            this.OriginalValue.Name = "OriginalValue";
            this.OriginalValue.Width = 200;
            this.NewValue.HeaderText = "New Value";
            this.NewValue.Name = "NewValue";
            this.NewValue.Width = 200;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Root Work Item ID:";
            this.groupBox1.Controls.Add((Control)this.label4);
            this.groupBox1.Controls.Add((Control)this.tbCustomFieldRefValue);
            this.groupBox1.Controls.Add((Control)this.label3);
            this.groupBox1.Controls.Add((Control)this.tbCustomFieldRefName);
            this.groupBox1.Location = new Point(21, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(401, 108);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Field Value";
            this.label4.AutoSize = true;
            this.label4.Location = new Point(15, 60);
            this.label4.Name = "label4";
            this.label4.Size = new Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Field Value:";
            this.tbCustomFieldRefValue.Location = new Point(120, 57);
            this.tbCustomFieldRefValue.Name = "tbCustomFieldRefValue";
            this.tbCustomFieldRefValue.Size = new Size(275, 20);
            this.tbCustomFieldRefValue.TabIndex = 6;
            this.tbCustomFieldRefValue.Text = "V 2.0";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(15, 31);
            this.label3.Name = "label3";
            this.label3.Size = new Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Field Ref Name:";
            this.tbCustomFieldRefName.Location = new Point(120, 28);
            this.tbCustomFieldRefName.Name = "tbCustomFieldRefName";
            this.tbCustomFieldRefName.Size = new Size(275, 20);
            this.tbCustomFieldRefName.TabIndex = 4;
            this.tbCustomFieldRefName.Text = "MyCompany.Product.Version";
            this.dgWiTypes.Controls.Add((Control)this.tabPage1);
            this.dgWiTypes.Controls.Add((Control)this.tabPage2);
            this.dgWiTypes.Controls.Add((Control)this.tabPage3);
            this.dgWiTypes.Controls.Add((Control)this.tabPage4);
            this.dgWiTypes.Controls.Add((Control)this.tabPage5);
            this.dgWiTypes.Controls.Add((Control)this.tabPage6);
            this.dgWiTypes.Controls.Add((Control)this.tabPage7);
            this.dgWiTypes.Controls.Add((Control)this.tabPage8);
            this.dgWiTypes.Location = new Point(12, 22);
            this.dgWiTypes.Name = "dgWiTypes";
            this.dgWiTypes.SelectedIndex = 0;
            this.dgWiTypes.Size = new Size(510, 345);
            this.dgWiTypes.TabIndex = 11;
            this.tabPage1.Controls.Add((Control)this.linkLabel1);
            this.tabPage1.Controls.Add((Control)this.lbTfsUri);
            this.tabPage1.Controls.Add((Control)this.label1);
            this.tabPage1.Controls.Add((Control)this.tbRootWorkItemId);
            this.tabPage1.Location = new Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new Padding(3);
            this.tabPage1.Size = new Size(502, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage2.Controls.Add((Control)this.cbReplaceHyperlinks);
            this.tabPage2.Controls.Add((Control)this.UrlReplTable);
            this.tabPage2.Location = new Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new Padding(3);
            this.tabPage2.Size = new Size(502, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hyperlinks";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.cbReplaceHyperlinks.AutoSize = true;
            this.cbReplaceHyperlinks.Location = new Point(6, 31);
            this.cbReplaceHyperlinks.Name = "cbReplaceHyperlinks";
            this.cbReplaceHyperlinks.Size = new Size(116, 17);
            this.cbReplaceHyperlinks.TabIndex = 7;
            this.cbReplaceHyperlinks.Text = "Redirect hyperlinks";
            this.cbReplaceHyperlinks.UseVisualStyleBackColor = true;
            this.tabPage3.Controls.Add((Control)this.cbReplaceCustomField);
            this.tabPage3.Controls.Add((Control)this.groupBox1);
            this.tabPage3.Location = new Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new Padding(3);
            this.tabPage3.Size = new Size(502, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Custom Field";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.cbReplaceCustomField.AutoSize = true;
            this.cbReplaceCustomField.Location = new Point(21, 27);
            this.cbReplaceCustomField.Name = "cbReplaceCustomField";
            this.cbReplaceCustomField.Size = new Size(159, 17);
            this.cbReplaceCustomField.TabIndex = 11;
            this.cbReplaceCustomField.Text = "Replace Custom Field Value";
            this.cbReplaceCustomField.UseVisualStyleBackColor = true;
            this.tabPage4.Controls.Add((Control)this.label2);
            this.tabPage4.Controls.Add((Control)this.tbHistoryComment);
            this.tabPage4.Location = new Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new Padding(3);
            this.tabPage4.Size = new Size(502, 319);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "History";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "History Comment:";
            this.tbHistoryComment.Location = new Point(28, 75);
            this.tbHistoryComment.Multiline = true;
            this.tbHistoryComment.Name = "tbHistoryComment";
            this.tbHistoryComment.Size = new Size(299, 44);
            this.tbHistoryComment.TabIndex = 9;
            this.tbHistoryComment.Text = "History Link created by Deep Copy";
            this.tabPage5.Controls.Add((Control)this.cbCopyLinksToVersionendItems);
            this.tabPage5.Controls.Add((Control)this.cbKeepLatestChangesetLinksOnly);
            this.tabPage5.Controls.Add((Control)this.cbCopyLinksToChangesets);
            this.tabPage5.Location = new Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new Padding(3);
            this.tabPage5.Size = new Size(502, 319);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Changesets";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.cbCopyLinksToVersionendItems.AutoSize = true;
            this.cbCopyLinksToVersionendItems.Location = new Point(26, 95);
            this.cbCopyLinksToVersionendItems.Name = "cbCopyLinksToVersionendItems";
            this.cbCopyLinksToVersionendItems.Size = new Size(168, 17);
            this.cbCopyLinksToVersionendItems.TabIndex = 9;
            this.cbCopyLinksToVersionendItems.Text = "Copy Links to Versioned Items";
            this.cbCopyLinksToVersionendItems.UseVisualStyleBackColor = true;
            this.cbKeepLatestChangesetLinksOnly.AutoSize = true;
            this.cbKeepLatestChangesetLinksOnly.Location = new Point(26, 72);
            this.cbKeepLatestChangesetLinksOnly.Name = "cbKeepLatestChangesetLinksOnly";
            this.cbKeepLatestChangesetLinksOnly.Size = new Size(196, 17);
            this.cbKeepLatestChangesetLinksOnly.TabIndex = 6;
            this.cbKeepLatestChangesetLinksOnly.Text = "Keep link to latest changesets only. ";
            this.cbKeepLatestChangesetLinksOnly.UseVisualStyleBackColor = true;
            this.cbCopyLinksToChangesets.AutoSize = true;
            this.cbCopyLinksToChangesets.Location = new Point(26, 49);
            this.cbCopyLinksToChangesets.Name = "cbCopyLinksToChangesets";
            this.cbCopyLinksToChangesets.Size = new Size(144, 17);
            this.cbCopyLinksToChangesets.TabIndex = 5;
            this.cbCopyLinksToChangesets.Text = "Copy links to changesets";
            this.cbCopyLinksToChangesets.UseVisualStyleBackColor = true;
            this.tabPage6.Controls.Add((Control)this.tbPrimaryLinkTypeEnd);
            this.tabPage6.Controls.Add((Control)this.label7);
            this.tabPage6.Controls.Add((Control)this.dgWilTypes);
            this.tabPage6.Controls.Add((Control)this.label6);
            this.tabPage6.Location = new Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new Padding(3);
            this.tabPage6.Size = new Size(502, 319);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "WI Link Types";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tbPrimaryLinkTypeEnd.Location = new Point(33, 76);
            this.tbPrimaryLinkTypeEnd.Name = "tbPrimaryLinkTypeEnd";
            this.tbPrimaryLinkTypeEnd.ReadOnly = true;
            this.tbPrimaryLinkTypeEnd.Size = new Size(445, 20);
            this.tbPrimaryLinkTypeEnd.TabIndex = 8;
            this.tbPrimaryLinkTypeEnd.Text = "Child";
            this.label7.AutoSize = true;
            this.label7.Location = new Point(30, 48);
            this.label7.Name = "label7";
            this.label7.Size = new Size(113, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Primary Link Type End";
            this.dgWilTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWilTypes.Columns.AddRange(new DataGridViewColumn[1]
      {
        (DataGridViewColumn) this.WorkItemLinkType
      });
            this.dgWilTypes.Location = new Point(33, 171);
            this.dgWilTypes.Name = "dgWilTypes";
            this.dgWilTypes.Size = new Size(445, 114);
            this.dgWilTypes.TabIndex = 3;
            this.dgWilTypes.CellContentClick += new DataGridViewCellEventHandler(this.dgWilTypes_CellContentClick);
            this.WorkItemLinkType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.WorkItemLinkType.HeaderText = "Work Item Link Type";
            this.WorkItemLinkType.Name = "WorkItemLinkType";
            this.label6.AutoSize = true;
            this.label6.Location = new Point(30, 139);
            this.label6.Name = "label6";
            this.label6.Size = new Size(206, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ignore the following Work Item Link Types";
            this.tabPage7.Controls.Add((Control)this.dgWiTypes2);
            this.tabPage7.Controls.Add((Control)this.label5);
            this.tabPage7.Location = new Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new Padding(3);
            this.tabPage7.Size = new Size(502, 319);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "WI Types";
            this.tabPage7.UseVisualStyleBackColor = true;
            this.dgWiTypes2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWiTypes2.Columns.AddRange(new DataGridViewColumn[1]
      {
        (DataGridViewColumn) this.dataGridViewTextBoxColumn1
      });
            this.dgWiTypes2.Location = new Point(24, 122);
            this.dgWiTypes2.Name = "dgWiTypes2";
            this.dgWiTypes2.Size = new Size(445, 114);
            this.dgWiTypes2.TabIndex = 4;
            this.dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Work Item Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.label5.AutoSize = true;
            this.label5.Location = new Point(21, 86);
            this.label5.Name = "label5";
            this.label5.Size = new Size(183, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ignore the following Work Item Types";
            this.tabPage8.Controls.Add((Control)this.cbCopyAttachments);
            this.tabPage8.Location = new Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new Padding(3);
            this.tabPage8.Size = new Size(502, 319);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Attachments";
            this.tabPage8.UseVisualStyleBackColor = true;
            this.cbCopyAttachments.AutoSize = true;
            this.cbCopyAttachments.Location = new Point(15, 33);
            this.cbCopyAttachments.Name = "cbCopyAttachments";
            this.cbCopyAttachments.Size = new Size(112, 17);
            this.cbCopyAttachments.TabIndex = 10;
            this.cbCopyAttachments.Text = "Copy Attachments";
            this.cbCopyAttachments.UseVisualStyleBackColor = true;
            this.button2.Location = new Point(362, 373);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new Point(9, 378);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new Size(0, 13);
            this.lbResult.TabIndex = 13;
            this.lbTfsUri.AutoSize = true;
            this.lbTfsUri.Location = new Point(90, 76);
            this.lbTfsUri.Name = "lbTfsUri";
            this.lbTfsUri.Size = new Size(0, 13);
            this.lbTfsUri.TabIndex = 5;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new Point(28, 76);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new Size(20, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Uri";
            this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(537, 408);
            this.Controls.Add((Control)this.lbResult);
            this.Controls.Add((Control)this.button2);
            this.Controls.Add((Control)this.dgWiTypes);
            this.Controls.Add((Control)this.button1);
            this.Name = "Form1";
            this.Text = "conplement AG - Work Item Deep Copy";
            //this.UrlReplTable.EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dgWiTypes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            //this.dgWilTypes.EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            //this.dgWiTypes2.EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.projCollUri == (Uri)null)
            {
                using (TeamProjectPicker teamProjectPicker = new TeamProjectPicker(TeamProjectPickerMode.MultiProject, false))
                {
                    if (teamProjectPicker.ShowDialog() != DialogResult.OK)
                        return;
                    this.projCollUri = teamProjectPicker.SelectedTeamProjectCollection.Uri;
                    this.lbTfsUri.Text = this.projCollUri.ToString();
                }
            }
            WiDcConfig config = new WiDcConfig();
            if (!int.TryParse(this.tbRootWorkItemId.Text, out config.RootWorkItemId))
            {
                int num = (int)MessageBox.Show("Specify Root Work Item ID!");
            }
            else
            {
                config.PrimaryLinkTypeEnd = this.tbPrimaryLinkTypeEnd.Text;
                config.CopyAttachments = this.cbCopyAttachments.Checked;
                config.CustomFieldRefName = this.tbCustomFieldRefName.Text;
                config.CustomFieldValue = this.tbCustomFieldRefValue.Text;
                config.HistoryComment = this.tbHistoryComment.Text;
                config.KeepChangesetLinks = this.cbCopyLinksToChangesets.Checked;
                config.KeepLinkToLatestChangesetOnly = this.cbKeepLatestChangesetLinksOnly.Checked;
                config.KeepVersionedItemLinks = this.cbCopyLinksToVersionendItems.Checked;
                config.ReplaceCustomFieldValue = this.cbReplaceCustomField.Checked;
                config.ReplaceHyperlinkUri = this.cbReplaceHyperlinks.Checked;
                config.tfsuri = this.projCollUri;
                if (this.dgWiTypes.RowCount > 0)
                {
                    foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.dgWilTypes.Rows)
                    {
                        try
                        {
                            config.WorkItemLinkTypesToIgnore.Add((string)this.dgWilTypes[0, dataGridViewRow.Index].Value);
                        }
                        catch
                        {
                        }
                    }
                }
                if (this.dgWiTypes.RowCount > 0)
                {
                    foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.dgWiTypes2.Rows)
                    {
                        try
                        {
                            config.WorkItemTypesToIgnore.Add((string)this.dgWiTypes2[0, dataGridViewRow.Index].Value);
                        }
                        catch
                        {
                        }
                    }
                }
                foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.UrlReplTable.Rows)
                {
                    string key = (string)this.UrlReplTable["OriginalValue", dataGridViewRow.Index].Value;
                    string str = (string)this.UrlReplTable["NewValue", dataGridViewRow.Index].Value;
                    if (key != null && str != null)
                    {
                        this.RplDic.Remove(key);
                        this.RplDic.Add(key, str);
                    }
                }
                config.UrlReplaceDic = this.RplDic;
                this.lbResult.Text = new WiCloner(config).Result;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgWilTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (TeamProjectPicker teamProjectPicker = new TeamProjectPicker(TeamProjectPickerMode.MultiProject, false))
            {
                if (teamProjectPicker.ShowDialog() != DialogResult.OK)
                    return;
                this.projCollUri = teamProjectPicker.SelectedTeamProjectCollection.Uri;
                this.lbTfsUri.Text = this.projCollUri.ToString();
            }
        }
    }
}
