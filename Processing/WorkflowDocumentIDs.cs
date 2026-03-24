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
    const string ITEM_SCHEDULE_ATTACHMENT_ID = "ItemScheduleAttachmentID";
    var attachmentLists = new[]
    {
        GetVariableValue(MAIN_DOC_ID),
        GetVariableValue(ITEM_SCHEDULE_ATTACHMENTS),
        GetVariableValue(MARKETING_SCHEDULE_ATTACHMENT),
        GetVariableValue(ITEM_SCHEDULE_ATTACHMENT_ID)
    };

    return string.Join("|",
        System.Linq.Enumerable.Where(attachmentLists, attachment => !string.IsNullOrWhiteSpace(attachment))
    );
}

return getStoredIds();