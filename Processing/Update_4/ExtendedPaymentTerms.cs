
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


string getExtendedPaymentTermsText()
{
    var value = getTemplateFieldValue("EXTENDED_PAYMENT_TERMS.Please_enter_any_special_terms_extended");

    if (string.IsNullOrWhiteSpace(value))
    {
        return string.Empty;
    }

    return "*Extended Payment Terms: " + value.Trim();
}


return getExtendedPaymentTermsText();