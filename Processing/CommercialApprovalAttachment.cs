/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

//Instance - 1
/**
 * @description    : Returns result for getCommercialApprovalAttachments.
 * @author         : Ritankar Jana | 20-03-2026
 * @param          : int maxCount
 * @returns        : string
 **/
string getCommercialApprovalAttachments(int maxCount)
{
    const string BASEPATH = "Params.Params.TemplateFieldData.Guarantee_Form.Please_provide_the_Commercial_Approval_email_Attachments.Please_provide_the_Commercial_Approval_email_SingleValue";
    var attachmentsList = new System.Collections.Generic.List<string>();

    for (int index = 1; index <= maxCount; index++)
    {
        var path = $"{BASEPATH}[{index}].Document.Uid";
        var attachmentId = GetVariableValue(path);

        if (!string.IsNullOrWhiteSpace(attachmentId))
        {
            attachmentsList.Add(attachmentId);
        }
    }

    return string.Join("|", attachmentsList);
}


return getCommercialApprovalAttachments(50);

// Instance - 2
/**
 * @description    : Returns result for getCommercialApprovalAttachments.
 * @author         : Ritankar Jana | 20-03-2026
 * @param          : int maxCount
 * @returns        : string
 **/
string getCommercialApprovalAttachments(int maxCount)
{
    const string basePath = "Params.Params.TemplateFieldData.Guarantee_Form.Please_provide_the_Overage_Share_Commercial_Approval_email_Attachments.Please_provide_the_Overage_Share_Commercial_Approval_email_SingleValue";
    var attachmentsList = new System.Collections.Generic.List<string>();

    for (int index = 1; index <= maxCount; index++)
    {
        var path = $"{basePath}[{index}].Document.Uid";
        var attachmentId = GetVariableValue(path);

        if (!string.IsNullOrWhiteSpace(attachmentId))
        {
            attachmentsList.Add(attachmentId);
        }
    }

    return string.Join("|", attachmentsList);
}


return getCommercialApprovalAttachments(50);