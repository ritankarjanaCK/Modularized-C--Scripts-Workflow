string getCombinedDocIds()
{
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