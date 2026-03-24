/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

string getStoredIds()
{
    var attachmentLists = new System.Collections.Generic.List<string>
    {
        GetVariableValue("MainDocID"),
        GetVariableValue("ItemScheduleAttachments"),
        GetVariableValue("MarketingScheduleAttachment"),
        GetVariableValue("GuaranteeFormAttachment"),
        GetVariableValue("ItemScheduleAttachmentID"),
        GetVariableValue("PRA_Schedule"),
        GetVariableValue("FE_Consignment_Agreement"),
        GetVariableValue("Final_Word_Conignment_Guarantee"),
        GetVariableValue("Commercial_Approval_Attachment_1"),
        GetVariableValue("Commercial_Approval_Attachment_2")
    };

    var filteredAttachmentList = new System.Collections.Generic.List<string>();

  /**

   * @description    : Returns result for foreach.

   * @author         : Ritankar Jana | 20-03-2026

   * @param          : var value in values

   * @returns        : foreach

   **/

    foreach (var attachment in attachmentLists)
    {
        if (!string.IsNullOrWhiteSpace(attachment))
        {
            filteredAttachmentsList.Add(attachment.Trim());
        }
    }

    return string.Join("|", filteredAttachmentsList);
}

return getStoredIds();