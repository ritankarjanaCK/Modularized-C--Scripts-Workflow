/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/


string getStoredIds()
{
    var attachmentLists = new[]
    {
        GetVariableValue("MainDocID"),
        GetVariableValue("ItemScheduleAttachments"),
        GetVariableValue("MarketingScheduleAttachment"),
        GetVariableValue("ItemScheduleAttachmentID")
    };

    return string.Join("|",
        System.Linq.Enumerable.Where(attachmentLists, attachment => !string.IsNullOrWhiteSpace(attachment))
    );
}

return getStoredIds();