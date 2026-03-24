
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


string getPropertySpecialTermsText()
{
    var value = getTemplateFieldValue("THE_PROPERTY.Please_enter_any_special_terms");

    if (string.IsNullOrWhiteSpace(value))
    {
        return string.Empty;
    }

    return "*Property: " + value.Trim();
}



return getPropertySpecialTermsText();