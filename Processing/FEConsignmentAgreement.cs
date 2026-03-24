/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/


string getFEConsignmentAgreement(int maxCount)
{
    const string BASEPATH = "Params.Params.TemplateFieldData.Guarantee_Form.Please_attach_the_the_FE_Consignment_Agreement_including_any_attachments_Attachments.Please_attach_the_the_FE_Consignment_Agreement_including_any_attachments_SingleValue";
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
return getFEConsignmentAgreement(50);