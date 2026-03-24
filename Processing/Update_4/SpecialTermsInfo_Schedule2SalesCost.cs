
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


string getScheduleIISaleCostText()
{
    const string SCHEDULE_II_SALE_COST_PATH = "Schedule_II_Sale_Cost.Please_enter_any_special_charges_or_terms";
    var value = getTemplateFieldValue(SCHEDULE_II_SALE_COST_PATH);

    if (string.IsNullOrWhiteSpace(value))
    {
        return string.Empty;
    }

    return "*Schedule II Sale Cost: " + value.Trim();
}


return getScheduleIISaleCostText();