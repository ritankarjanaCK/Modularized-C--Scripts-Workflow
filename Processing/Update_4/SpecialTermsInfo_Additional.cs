string getTemplateFieldValue(string relativePath)
{
    if (string.IsNullOrWhiteSpace(relativePath))
    {
        throw new ArgumentException("Field path cannot be null or empty.", nameof(relativePath));
    }

    const string BASEPATH = "Params.Params.TemplateFieldData.";

    try
    {
        return GetVariableValue(BASEPATH + relativePath);
    }
    catch (Exception ex)
    {
        throw new ApplicationException(
            $"Error retrieving value for path: {BASEPATH + relativePath}", ex
        );
    }
}



string getAdditionalSpecialTermsText()
{
    const string ADDITIONAL_SPECIAL_TERMS_PATH = "Special_Terms.List_any_additional_special_terms_here";
    var value = getTemplateFieldValue(ADDITIONAL_SPECIAL_TERMS_PATH);

    if (string.IsNullOrWhiteSpace(value))
    {
        return string.Empty;
    }

    return "*Other Additional Special Terms: " + value.Trim();
}


return getAdditionalSpecialTermsText();
