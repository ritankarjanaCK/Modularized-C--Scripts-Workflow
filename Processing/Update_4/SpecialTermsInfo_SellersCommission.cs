
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


string getSellersCommissionText()
{
    const string SELLERS_COMMISSION_PATH = "SELLERS_COMMISSION.Please_enter_any_special_terms_sellers";
    var value = getTemplateFieldValue(SELLERS_COMMISSION_PATH);

    if (string.IsNullOrWhiteSpace(value))
    {
        return string.Empty;
    }

    return "*Seller's Commission: " + value.Trim();
}

return getSellersCommissionText();