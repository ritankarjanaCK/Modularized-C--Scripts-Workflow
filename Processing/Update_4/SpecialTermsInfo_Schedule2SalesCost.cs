
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


string getScheduleIISaleCostText()
{
    var value = getTemplateFieldValue("Schedule_II_Sale_Cost.Please_enter_any_special_charges_or_terms");

    if (string.IsNullOrWhiteSpace(value))
    {
        return string.Empty;
    }

    return "*Schedule II Sale Cost: " + value.Trim();
}


return getScheduleIISaleCostText();