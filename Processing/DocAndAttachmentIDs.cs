/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

string getStoredIds()
{
    const string MAIN_DOC_ID = "MainDocID";
    const string ITEM_SCHEDULE_ATTACHMENTS = "ItemScheduleAttachments";
    const string MARKETING_SCHEDULE_ATTACHMENT = "MarketingScheduleAttachment";
    const string GUARANTEE_FORM_ATTACHMENT = "GuaranteeFormAttachment";
    const string ITEM_SCHEDULE_ATTACHMENT_ID = "ItemScheduleAttachmentID";
    const string PRA_SCHEDULE = "PRA_Schedule";
    const string FE_CONSIGNMENT_AGREEMENT = "FE_Consignment_Agreement";
    const string FINAL_WORD_CONIGNMENT_GUARANTEE = "Final_Word_Conignment_Guarantee";
    const string COMMERCIAL_APPROVAL_ATTACHMENT_1 = "Commercial_Approval_Attachment_1";
    const string COMMERCIAL_APPROVAL_ATTACHMENT_2 = "Commercial_Approval_Attachment_2";

    var attachmentLists = new System.Collections.Generic.List<string>
    {
        GetVariableValue(MAIN_DOC_ID),
        GetVariableValue(ITEM_SCHEDULE_ATTACHMENTS),
        GetVariableValue(MARKETING_SCHEDULE_ATTACHMENT),
        GetVariableValue(GUARANTEE_FORM_ATTACHMENT),
        GetVariableValue(ITEM_SCHEDULE_ATTACHMENT_ID),
        GetVariableValue(PRA_SCHEDULE),
        GetVariableValue(FE_CONSIGNMENT_AGREEMENT),
        GetVariableValue(FINAL_WORD_CONIGNMENT_GUARANTEE),
        GetVariableValue(COMMERCIAL_APPROVAL_ATTACHMENT_1),
        GetVariableValue(COMMERCIAL_APPROVAL_ATTACHMENT_2)
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