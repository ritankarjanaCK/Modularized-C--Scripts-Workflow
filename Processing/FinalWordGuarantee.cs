/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

string getFinalWordGuarantee(int maxCount)
{
    const string basePath = "Params.Params.TemplateFieldData.Guarantee_Form.Please_attach_a_Word_version_of_the_final_CA_Attachments.Please_attach_a_Word_version_of_the_final_CA_SingleValue";
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

return getFinalWordGuarantee(50);