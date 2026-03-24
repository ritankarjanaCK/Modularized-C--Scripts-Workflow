string getTemplateFieldValue(string relativePath)
{
    if (string.IsNullOrWhiteSpace(relativePath))
    {
        throw new ArgumentException("Field path cannot be null or empty.", nameof(relativePath));
    }

    const string basePath = "Params.Params.TemplateFieldData.";

    try
    {
        return GetVariableValue(basePath + relativePath);
    }
    catch (Exception ex)
    {
        throw new ApplicationException(
            $"Error retrieving value for path: {basePath + relativePath}", ex
        );
    }
}



string getAdditionalSpecialTermsText()
{
    var value = getTemplateFieldValue("Special_Terms.List_any_additional_special_terms_here");

    if (string.IsNullOrWhiteSpace(value))
    {
        return string.Empty;
    }

    return "*Other Additional Special Terms: " + value.Trim();
}


return getAdditionalSpecialTermsText();
