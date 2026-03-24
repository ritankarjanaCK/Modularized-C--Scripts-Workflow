/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

string getMarketingScheduledAttachments(int maxCount)
{
    const string basePath = "Params.Params.TemplateFieldData.Schedule_III_Marketing_Schedule.Marketing_Schedule.Please_attach_marketing_promises_Attachments.Please_attach_marketing_promises_SingleValue";
    var attachmentsList = new System.Collections.Generic.List<string>();
    
    for (int iterator = 1; iterator <= maxCount; iterator++)
    {
        var path = $"{basePath}[{iterator}].Document.Uid";
        var attachmentId = GetVariableValue(path);

        if (!string.IsNullOrWhiteSpace(attachmentId))
        {
            attachmentsList.Add(attachmentId);
        }
    }

    return string.Join("|", attachmentsList);
}


return getMarketingScheduledAttachments(50);