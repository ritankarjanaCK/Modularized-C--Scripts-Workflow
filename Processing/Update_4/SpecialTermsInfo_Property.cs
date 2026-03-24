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


string getPropertySpecialTermsText()
{
    const string PROPERTY_SPECIAL_TERMS_PATH = "THE_PROPERTY.Please_enter_any_special_terms";
    var value = getTemplateFieldValue(PROPERTY_SPECIAL_TERMS_PATH);

    if (string.IsNullOrWhiteSpace(value))
    {
        return string.Empty;
    }

    return "*Property: " + value.Trim();
}



return getPropertySpecialTermsText();