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


int getIncludedItemCount()
{
    const string BASEPATH = "Item_{0}.Include_Item_{0}";

    int count = 0;

    for (int index = 1; index <= 20; index++)
    {
        var relativePath = string.Format(BASEPATH, index);
        var value = getTemplateFieldValue(relativePath);

        if (string.Equals(value, "True", System.StringComparison.OrdinalIgnoreCase))
        {
            count++;
        }
    }

    return count;
}

return getIncludedItemCount();