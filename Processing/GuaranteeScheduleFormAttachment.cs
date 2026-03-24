/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

string getGuaranteeScheduleFormAttachments(int maxCount)
{
    const string BASEPATH = "Params.Params.TemplateFieldData.CONTRACT_DETAILS.Attach_Your_Guarantee_Information_Form_Attachments.Attach_Your_Guarantee_Information_Form_SingleValue";
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

return getGuaranteeScheduleFormAttachments(50);