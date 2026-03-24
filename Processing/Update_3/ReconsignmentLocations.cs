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




string getReconsignmentLocations()
{
    var locationsMap = new System.Collections.Generic.Dictionary<string, string>
    {
        { "London", "London" },
        { "Cologne", "Cologne" },
        { "Geneva", "Geneva" },
        { "Milan", "Milan" },
        { "Paris", "Paris" },
        { "Singapore", "Singapore" },
        { "Zurich", "Zurich" }
    };

    const string RECONSIGNMENT_LOCATIONS_PATH = "THE_PROPERTY.To_which_locations_will_the_property_be_reconsigned";

    var selectedLocationList = new System.Collections.Generic.List<string>();

    foreach (var entry in locationsMap)
    {
        var value = getTemplateFieldValue($"{RECONSIGNMENT_LOCATIONS_PATH}.{entry.Key}");

        if (string.Equals(value, "True", System.StringComparison.OrdinalIgnoreCase))
        {
            selectedLocationList.Add(entry.Value);
        }
    }

    return string.Join(" ", selectedLocationList);
}



return getReconsignmentLocations();