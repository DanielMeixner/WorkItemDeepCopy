using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkItemDeepCopyUI
{
    [Serializable]
    public class WiDcConfig
    {
        public int NrOfChangesetLinksToKeep = 1;
        public int RootWorkItemId = -1;
        public string CustomFieldValue = string.Empty;
        public string CustomFieldRefName = string.Empty;
        public string HistoryComment = string.Empty;
        public List<string> WorkItemLinkTypesToIgnore = new List<string>();
        public List<string> WorkItemTypesToIgnore = new List<string>();
        public string PrimaryLinkTypeEnd = string.Empty;
        public string HistoricLinkTypeEndTo = "Historical Descendant";
        public bool KeepVersionedItemLinks;
        public bool KeepChangesetLinks;
        public bool KeepLinkToLatestChangesetOnly;
        public bool ReplaceHyperlinkUri;
        public bool ReplaceCustomFieldValue;
        public bool CopyAttachments;
        public Dictionary<string, string> UrlReplaceDic;

        public Uri tfsuri { get; set; }
    }
}
