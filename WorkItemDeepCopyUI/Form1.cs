using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.TeamFoundation.Client;

namespace WorkItemDeepCopyUI
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> RplDic = new Dictionary<string, string>();


        public Form1()
        {
            InitializeComponent();
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
