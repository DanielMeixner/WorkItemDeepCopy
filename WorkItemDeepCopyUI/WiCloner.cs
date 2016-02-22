using System;
using System.Collections.Generic;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Common;

namespace WorkItemDeepCopyUI
{
    public class WiCloner
    {
        private Dictionary<int, int> ReplacedIds;
        private List<WorkItemLink> CompleteLinkList;
        private List<int> touchedWiIds;
        private WorkItemStore store;

        public string Result { get; set; }

        public WiCloner(WiDcConfig config)
        {
            this.ReplacedIds = new Dictionary<int, int>();
            this.CompleteLinkList = new List<WorkItemLink>();
            this.touchedWiIds = new List<int>();
            this.DeepCopy(config);
            this.RecreateAllLinksWithinNewIds();
            this.Result = "Generated " + (object)this.ReplacedIds.Count + " linked Work Items.";
        }

        public int DeepCopy(WiDcConfig a_WiDcConfig)
        {
            this.store = new WorkItemStore(TfsTeamProjectCollectionFactory.GetTeamProjectCollection(a_WiDcConfig.tfsuri));
            WorkItem workItem1 = this.store.GetWorkItem(a_WiDcConfig.RootWorkItemId);
            List<int> list1 = new List<int>();
            this.touchedWiIds.Add(a_WiDcConfig.RootWorkItemId);
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            foreach (WorkItemLink workItemLink in (VariableSizeList)workItem1.WorkItemLinks)
            {
                if (!this.touchedWiIds.Contains(workItemLink.TargetId))
                {
                    if (workItemLink.LinkTypeEnd.Name == a_WiDcConfig.PrimaryLinkTypeEnd)
                    {
                        int targetId = workItemLink.TargetId;
                        int key = -1;
                        if (!a_WiDcConfig.WorkItemTypesToIgnore.Contains(((object)this.store.GetWorkItem(targetId).Type.Name).ToString()))
                        {
                            if (!this.ReplacedIds.TryGetValue(targetId, out key))
                            {
                                a_WiDcConfig.RootWorkItemId = targetId;
                                key = this.DeepCopy(a_WiDcConfig);
                            }
                            list1.Add(targetId);
                            dictionary.Add(key, workItemLink.LinkTypeEnd.Name);
                            this.ReplacedIds.Add(targetId, key);
                        }
                    }
                    else if (!a_WiDcConfig.WorkItemLinkTypesToIgnore.Contains(workItemLink.LinkTypeEnd.Name))
                        this.CompleteLinkList.Add(workItemLink);
                }
            }
            WorkItem workItem2 = !a_WiDcConfig.CopyAttachments ? workItem1.Copy(workItem1.Type, WorkItemCopyFlags.None) : workItem1.Copy(workItem1.Type, WorkItemCopyFlags.CopyFiles);
            workItem2.History = "Deep Copy: Copied original WI";
            workItem2.Save();
            WorkItemLink link1 = new WorkItemLink(this.store.WorkItemLinkTypes.LinkTypeEnds[a_WiDcConfig.HistoricLinkTypeEndTo], a_WiDcConfig.RootWorkItemId);
            //dd, 03.04.2014 - wegen Castingfehler
            //link1.Comment = a_WiDcConfig.HistoryComment + (object)"(" + (string)(object)workItem1.Id + "-->" + (string)(object)workItem2.Id + ")";
            link1.Comment = a_WiDcConfig.HistoryComment + "(" + workItem1.Id.ToString() + "-->" + workItem2.Id.ToString() + ")";
            workItem2.WorkItemLinks.Add(link1);
            workItem2.History = "Deep Copy: Added History Link";
            workItem2.Save();
            foreach (KeyValuePair<int, string> keyValuePair in dictionary)
            {
                WorkItemLink link2 = new WorkItemLink(this.store.WorkItemLinkTypes.LinkTypeEnds[keyValuePair.Value], keyValuePair.Key);
                workItem2.WorkItemLinks.Add(link2);
            }
            workItem2.History = "Deep Copy: Added Parent/Child Links to Work Items";
            workItem2.Save();
            List<Hyperlink> list2 = new List<Hyperlink>();
            List<Hyperlink> list3 = new List<Hyperlink>();
            foreach (Link link2 in (VariableSizeList)workItem1.Links)
            {
                if (link2.BaseType == BaseLinkType.Hyperlink)
                {
                    Hyperlink hyperlink1 = link2 as Hyperlink;
                    string location = hyperlink1.Location;
                    if (a_WiDcConfig.ReplaceHyperlinkUri)
                    {
                        foreach (KeyValuePair<string, string> keyValuePair in a_WiDcConfig.UrlReplaceDic)
                            location = location.Replace(keyValuePair.Key, keyValuePair.Value);
                    }
                    Hyperlink hyperlink2 = new Hyperlink(location);
                    hyperlink2.Comment = link2.Comment;
                    list2.Add(hyperlink2);
                    list3.Add(hyperlink1);
                }
            }
            foreach (Hyperlink hyperlink in list3)
                workItem2.Links.Remove((Link)hyperlink);
            foreach (Hyperlink link2 in list2)
                workItem2.Links.Add(link2);
            workItem2.History = !a_WiDcConfig.ReplaceHyperlinkUri ? "Deep Copy: Added Hyperlinks (no URL replacement)" : "Deep Copy: Added Hyperlinks (with URL replacement)";
            if (workItem2.IsValid())
                workItem2.Save();
            if (a_WiDcConfig.KeepChangesetLinks)
            {
                foreach (Link link2 in (VariableSizeList)workItem1.Links)
                {
                    if (link2.BaseType == BaseLinkType.ExternalLink)
                    {
                        ExternalLink externalLink = link2 as ExternalLink;
                        if (externalLink != null && externalLink.ArtifactLinkType.Name == "Fixed in Changeset")
                            workItem2.Links.Add(new ExternalLink(link2.ArtifactLinkType, externalLink.LinkedArtifactUri));
                    }
                }
                workItem2.History = "Deep Copy: Added Changeset Links";
                workItem2.Save();
            }
            else if (a_WiDcConfig.KeepLinkToLatestChangesetOnly)
            {
                int num = a_WiDcConfig.NrOfChangesetLinksToKeep;
                List<ExternalLink> list4 = new List<ExternalLink>();
                foreach (Link link2 in (VariableSizeList)workItem1.Links)
                {
                    if (link2.BaseType == BaseLinkType.ExternalLink)
                    {
                        ExternalLink externalLink = link2 as ExternalLink;
                        if (externalLink != null && externalLink.ArtifactLinkType.Name == "Fixed in Changeset")
                            list4.Add(externalLink);
                    }
                }
                ExternalLink externalLink1 = (ExternalLink)null;
                foreach (ExternalLink externalLink2 in list4)
                {
                    if (externalLink1 == null)
                        externalLink1 = externalLink2;
                    else if (((object)externalLink1.LinkedArtifactUri).ToString().Substring(((object)externalLink1.LinkedArtifactUri).ToString().IndexOf("Changeset/")).CompareTo(((object)externalLink2.LinkedArtifactUri).ToString().Substring(((object)externalLink2.LinkedArtifactUri).ToString().IndexOf("Changeset/"))) < 0)
                        externalLink1 = externalLink2;
                }
                if (externalLink1 != null)
                {
                    workItem2.Links.Add(new ExternalLink(externalLink1.ArtifactLinkType, externalLink1.LinkedArtifactUri));
                    workItem2.History = "Deep Copy: Added latest Changeset Link";
                    workItem2.Save();
                }
            }
            if (a_WiDcConfig.KeepVersionedItemLinks)
            {
                foreach (Link link2 in (VariableSizeList)workItem1.Links)
                {
                    if (link2.BaseType == BaseLinkType.ExternalLink)
                    {
                        ExternalLink externalLink = link2 as ExternalLink;
                        if (externalLink != null && externalLink.ArtifactLinkType.Name == "Source Code File")
                            workItem2.Links.Add(new ExternalLink(link2.ArtifactLinkType, externalLink.LinkedArtifactUri));
                    }
                }
            }
            workItem2.History = "Deep Copy: Added Versioned Item Links";
            workItem2.Save();
            if (a_WiDcConfig.ReplaceCustomFieldValue)
            {
                Field field1 = (Field)null;
                foreach (Field field2 in (ReadOnlyList)workItem2.Fields)
                {
                    if (field2.ReferenceName == a_WiDcConfig.CustomFieldRefName)
                    {
                        field1 = field2;
                        break;
                    }
                }
                if (field1 != null)
                {
                    object obj = workItem2.Fields[a_WiDcConfig.CustomFieldRefName].Value;
                    try
                    {
                        field1.Value = (object)a_WiDcConfig.CustomFieldValue;
                        workItem2.History = "Deep Copy: Replaced Custom Field value.";
                        workItem2.Save();
                    }
                    catch
                    {
                        field1.Value = obj;
                        workItem2.History = "Deep Copy: Replaced Custom Field value - FAILED [wrong value type!].";
                        workItem2.Save();
                    }
                }
            }
            return workItem2.Id;
        }

        public void RecreateAllLinksWithinNewIds()
        {
            foreach (WorkItemLink wlink in this.CompleteLinkList)
                this.RecreateLink(wlink, this.ReplacedIds);
        }

        private void RecreateLink(WorkItemLink wlink, Dictionary<int, int> ReplacedIds)
        {
            int num1;
            if (!ReplacedIds.TryGetValue(wlink.TargetId, out num1))
                return;
            int num2;
            if (!ReplacedIds.TryGetValue(wlink.SourceId, out num2))
                return;
            try
            {
                WorkItem workItem1 = this.store.GetWorkItem(num2);
                WorkItem workItem2 = this.store.GetWorkItem(num1);
                workItem1.WorkItemLinks.Add(new WorkItemLink(wlink.LinkTypeEnd, num2, num1));
                string str = "Copied Link according to historical ancestor.";
                workItem1.History = str;
                workItem2.History = str;
                workItem2.Save();
                workItem1.Save();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
