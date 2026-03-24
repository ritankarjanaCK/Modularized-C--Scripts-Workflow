string getCombinedDocIds()
{
    const string DOC_AND_ATTACHMENT_IDS = "DocAndAttachmentIDs";
    const string GUARANTEE_FORM_ID = "GuaranteeFormID";
    
    var values = new[]
    {
        GetVariableValue("DocAndAttachmentIDs"),
        GetVariableValue("GuaranteeFormID")
    };

    return string.Join("|",
        System.Linq.Enumerable.Where(values, v => !string.IsNullOrWhiteSpace(v))
    );
}

return getCombinedDocIds();