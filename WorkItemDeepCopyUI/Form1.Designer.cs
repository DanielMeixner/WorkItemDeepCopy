using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace WorkItemDeepCopyUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbRootWorkItemId;
        private System.Windows.Forms.DataGridView UrlReplTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCustomFieldRefValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCustomFieldRefName;
        private System.Windows.Forms.TabControl dgWiTypes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox cbReplaceHyperlinks;
        private System.Windows.Forms.CheckBox cbReplaceCustomField;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHistoryComment;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox cbCopyLinksToVersionendItems;
        private System.Windows.Forms.CheckBox cbKeepLatestChangesetLinksOnly;
        private System.Windows.Forms.CheckBox cbCopyLinksToChangesets;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.CheckBox cbCopyAttachments;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgWilTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkItemLinkType;
        private System.Windows.Forms.DataGridView dgWiTypes2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox tbPrimaryLinkTypeEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbTfsUri;
        private System.Uri projCollUri;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tbRootWorkItemId = new System.Windows.Forms.TextBox();
            this.UrlReplTable = new System.Windows.Forms.DataGridView();
            this.OriginalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCustomFieldRefValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCustomFieldRefName = new System.Windows.Forms.TextBox();
            this.dgWiTypes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbTfsUri = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbReplaceHyperlinks = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbReplaceCustomField = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHistoryComment = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cbCopyLinksToVersionendItems = new System.Windows.Forms.CheckBox();
            this.cbKeepLatestChangesetLinksOnly = new System.Windows.Forms.CheckBox();
            this.cbCopyLinksToChangesets = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tbPrimaryLinkTypeEnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgWilTypes = new System.Windows.Forms.DataGridView();
            this.WorkItemLinkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dgWiTypes2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.cbCopyAttachments = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UrlReplTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.dgWiTypes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWilTypes)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWiTypes2)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Deep Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbRootWorkItemId
            // 
            this.tbRootWorkItemId.Location = new System.Drawing.Point(133, 36);
            this.tbRootWorkItemId.Name = "tbRootWorkItemId";
            this.tbRootWorkItemId.Size = new System.Drawing.Size(56, 20);
            this.tbRootWorkItemId.TabIndex = 1;
            this.tbRootWorkItemId.Text = "12";
            // 
            // UrlReplTable
            // 
            this.UrlReplTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrlReplTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OriginalValue,
            this.NewValue});
            this.UrlReplTable.Location = new System.Drawing.Point(6, 66);
            this.UrlReplTable.Name = "UrlReplTable";
            this.UrlReplTable.Size = new System.Drawing.Size(418, 154);
            this.UrlReplTable.TabIndex = 2;
            // 
            // OriginalValue
            // 
            this.OriginalValue.HeaderText = "Original Value";
            this.OriginalValue.Name = "OriginalValue";
            this.OriginalValue.Width = 200;
            // 
            // NewValue
            // 
            this.NewValue.HeaderText = "New Value";
            this.NewValue.Name = "NewValue";
            this.NewValue.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Root Work Item ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCustomFieldRefValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCustomFieldRefName);
            this.groupBox1.Location = new System.Drawing.Point(21, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 108);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Field Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Field Value:";
            // 
            // tbCustomFieldRefValue
            // 
            this.tbCustomFieldRefValue.Location = new System.Drawing.Point(120, 57);
            this.tbCustomFieldRefValue.Name = "tbCustomFieldRefValue";
            this.tbCustomFieldRefValue.Size = new System.Drawing.Size(275, 20);
            this.tbCustomFieldRefValue.TabIndex = 6;
            this.tbCustomFieldRefValue.Text = "V 2.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Field Ref Name:";
            // 
            // tbCustomFieldRefName
            // 
            this.tbCustomFieldRefName.Location = new System.Drawing.Point(120, 28);
            this.tbCustomFieldRefName.Name = "tbCustomFieldRefName";
            this.tbCustomFieldRefName.Size = new System.Drawing.Size(275, 20);
            this.tbCustomFieldRefName.TabIndex = 4;
            this.tbCustomFieldRefName.Text = "MyCompany.Product.Version";
            // 
            // dgWiTypes
            // 
            this.dgWiTypes.Controls.Add(this.tabPage1);
            this.dgWiTypes.Controls.Add(this.tabPage2);
            this.dgWiTypes.Controls.Add(this.tabPage3);
            this.dgWiTypes.Controls.Add(this.tabPage4);
            this.dgWiTypes.Controls.Add(this.tabPage5);
            this.dgWiTypes.Controls.Add(this.tabPage6);
            this.dgWiTypes.Controls.Add(this.tabPage7);
            this.dgWiTypes.Controls.Add(this.tabPage8);
            this.dgWiTypes.Location = new System.Drawing.Point(12, 22);
            this.dgWiTypes.Name = "dgWiTypes";
            this.dgWiTypes.SelectedIndex = 0;
            this.dgWiTypes.Size = new System.Drawing.Size(510, 345);
            this.dgWiTypes.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.lbTfsUri);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbRootWorkItemId);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(28, 76);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(20, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Uri";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbTfsUri
            // 
            this.lbTfsUri.AutoSize = true;
            this.lbTfsUri.Location = new System.Drawing.Point(90, 76);
            this.lbTfsUri.Name = "lbTfsUri";
            this.lbTfsUri.Size = new System.Drawing.Size(0, 13);
            this.lbTfsUri.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbReplaceHyperlinks);
            this.tabPage2.Controls.Add(this.UrlReplTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hyperlinks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbReplaceHyperlinks
            // 
            this.cbReplaceHyperlinks.AutoSize = true;
            this.cbReplaceHyperlinks.Location = new System.Drawing.Point(6, 31);
            this.cbReplaceHyperlinks.Name = "cbReplaceHyperlinks";
            this.cbReplaceHyperlinks.Size = new System.Drawing.Size(116, 17);
            this.cbReplaceHyperlinks.TabIndex = 7;
            this.cbReplaceHyperlinks.Text = "Redirect hyperlinks";
            this.cbReplaceHyperlinks.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbReplaceCustomField);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(502, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Custom Field";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbReplaceCustomField
            // 
            this.cbReplaceCustomField.AutoSize = true;
            this.cbReplaceCustomField.Location = new System.Drawing.Point(21, 27);
            this.cbReplaceCustomField.Name = "cbReplaceCustomField";
            this.cbReplaceCustomField.Size = new System.Drawing.Size(159, 17);
            this.cbReplaceCustomField.TabIndex = 11;
            this.cbReplaceCustomField.Text = "Replace Custom Field Value";
            this.cbReplaceCustomField.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.tbHistoryComment);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(502, 319);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "History";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "History Comment:";
            // 
            // tbHistoryComment
            // 
            this.tbHistoryComment.Location = new System.Drawing.Point(28, 75);
            this.tbHistoryComment.Multiline = true;
            this.tbHistoryComment.Name = "tbHistoryComment";
            this.tbHistoryComment.Size = new System.Drawing.Size(299, 44);
            this.tbHistoryComment.TabIndex = 9;
            this.tbHistoryComment.Text = "History Link created by Deep Copy";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cbCopyLinksToVersionendItems);
            this.tabPage5.Controls.Add(this.cbKeepLatestChangesetLinksOnly);
            this.tabPage5.Controls.Add(this.cbCopyLinksToChangesets);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(502, 319);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Changesets";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cbCopyLinksToVersionendItems
            // 
            this.cbCopyLinksToVersionendItems.AutoSize = true;
            this.cbCopyLinksToVersionendItems.Location = new System.Drawing.Point(26, 95);
            this.cbCopyLinksToVersionendItems.Name = "cbCopyLinksToVersionendItems";
            this.cbCopyLinksToVersionendItems.Size = new System.Drawing.Size(168, 17);
            this.cbCopyLinksToVersionendItems.TabIndex = 9;
            this.cbCopyLinksToVersionendItems.Text = "Copy Links to Versioned Items";
            this.cbCopyLinksToVersionendItems.UseVisualStyleBackColor = true;
            // 
            // cbKeepLatestChangesetLinksOnly
            // 
            this.cbKeepLatestChangesetLinksOnly.AutoSize = true;
            this.cbKeepLatestChangesetLinksOnly.Location = new System.Drawing.Point(26, 72);
            this.cbKeepLatestChangesetLinksOnly.Name = "cbKeepLatestChangesetLinksOnly";
            this.cbKeepLatestChangesetLinksOnly.Size = new System.Drawing.Size(196, 17);
            this.cbKeepLatestChangesetLinksOnly.TabIndex = 6;
            this.cbKeepLatestChangesetLinksOnly.Text = "Keep link to latest changesets only. ";
            this.cbKeepLatestChangesetLinksOnly.UseVisualStyleBackColor = true;
            // 
            // cbCopyLinksToChangesets
            // 
            this.cbCopyLinksToChangesets.AutoSize = true;
            this.cbCopyLinksToChangesets.Location = new System.Drawing.Point(26, 49);
            this.cbCopyLinksToChangesets.Name = "cbCopyLinksToChangesets";
            this.cbCopyLinksToChangesets.Size = new System.Drawing.Size(144, 17);
            this.cbCopyLinksToChangesets.TabIndex = 5;
            this.cbCopyLinksToChangesets.Text = "Copy links to changesets";
            this.cbCopyLinksToChangesets.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tbPrimaryLinkTypeEnd);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.dgWilTypes);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(502, 319);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "WI Link Types";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tbPrimaryLinkTypeEnd
            // 
            this.tbPrimaryLinkTypeEnd.Location = new System.Drawing.Point(33, 76);
            this.tbPrimaryLinkTypeEnd.Name = "tbPrimaryLinkTypeEnd";
            this.tbPrimaryLinkTypeEnd.ReadOnly = true;
            this.tbPrimaryLinkTypeEnd.Size = new System.Drawing.Size(445, 20);
            this.tbPrimaryLinkTypeEnd.TabIndex = 8;
            this.tbPrimaryLinkTypeEnd.Text = "Child";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Primary Link Type End";
            // 
            // dgWilTypes
            // 
            this.dgWilTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWilTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkItemLinkType});
            this.dgWilTypes.Location = new System.Drawing.Point(33, 171);
            this.dgWilTypes.Name = "dgWilTypes";
            this.dgWilTypes.Size = new System.Drawing.Size(445, 114);
            this.dgWilTypes.TabIndex = 3;
            this.dgWilTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWilTypes_CellContentClick);
            // 
            // WorkItemLinkType
            // 
            this.WorkItemLinkType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WorkItemLinkType.HeaderText = "Work Item Link Type";
            this.WorkItemLinkType.Name = "WorkItemLinkType";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ignore the following Work Item Link Types";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dgWiTypes2);
            this.tabPage7.Controls.Add(this.label5);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(502, 319);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "WI Types";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dgWiTypes2
            // 
            this.dgWiTypes2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWiTypes2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgWiTypes2.Location = new System.Drawing.Point(24, 122);
            this.dgWiTypes2.Name = "dgWiTypes2";
            this.dgWiTypes2.Size = new System.Drawing.Size(445, 114);
            this.dgWiTypes2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Work Item Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ignore the following Work Item Types";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.cbCopyAttachments);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(502, 319);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Attachments";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // cbCopyAttachments
            // 
            this.cbCopyAttachments.AutoSize = true;
            this.cbCopyAttachments.Location = new System.Drawing.Point(15, 33);
            this.cbCopyAttachments.Name = "cbCopyAttachments";
            this.cbCopyAttachments.Size = new System.Drawing.Size(112, 17);
            this.cbCopyAttachments.TabIndex = 10;
            this.cbCopyAttachments.Text = "Copy Attachments";
            this.cbCopyAttachments.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(9, 378);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 408);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgWiTypes);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "conplement AG - Work Item Deep Copy";
            ((System.ComponentModel.ISupportInitialize)(this.UrlReplTable)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgWilTypes)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWiTypes2)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
    }
}