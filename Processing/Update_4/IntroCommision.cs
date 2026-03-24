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

string getIntroductoryCommissionText()
{
    const string INTRODUCTORY_COMMISSION_PATH = "INTRODUCTORY_COMMISSION.Please_enter_any_special_terms_intro";
    var value = getTemplateFieldValue(INTRODUCTORY_COMMISSION_PATH);

    if (string.IsNullOrWhiteSpace(value))
    {
        return string.Empty;
    }

    return "*Introductory Commission: " + value.Trim();
}


return getIntroductoryCommissionText();