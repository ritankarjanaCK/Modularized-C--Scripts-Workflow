
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


string getExtendedPaymentTermsText()
{
    const string EXTENDED_PAYMENT_TERMS_PATH = "EXTENDED_PAYMENT_TERMS.Please_enter_any_special_terms_extended";
    var value = getTemplateFieldValue(EXTENDED_PAYMENT_TERMS_PATH);

    if (string.IsNullOrWhiteSpace(value))
    {
        return string.Empty;
    }

    return "*Extended Payment Terms: " + value.Trim();
}


return getExtendedPaymentTermsText();