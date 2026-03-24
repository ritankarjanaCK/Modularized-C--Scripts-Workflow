
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

string getConsignor1Name()
{
    return getTemplateFieldValue("CONSIGNOR_INFORMATION.Consignor_1.Consignor_1_Name");
}

return getConsignor1Name();




// Sanitizing the conisgnor name.

/**

 * @description    : Returns result for sanitizeFileName.

 * @author         : Ritankar Jana | 12-02-2025

 * @param          : string input

 * @returns        : string

 **/

string sanitizeFileName(string input)
{
    if (string.IsNullOrWhiteSpace(input))
    {
        return string.Empty;
    }

    const string invalidCharsPattern = @"[\/:*?<>""|]+";

    var sanitized = System.Text.RegularExpressions.Regex.Replace(input,invalidCharsPattern,"_");

    return sanitized.Trim().TrimEnd('.');
}

/**

 * @description    : Returns result for getSanitizedConsignorName.

 * @author         : Ritankar Jana | 12-02-2025

 * @param          : none

 * @returns        : string

 **/

string getSanitizedConsignorName()
{
    var consignorName = GetVariableValue("ConsignorName");
    return sanitizeFileName(consignorName);
}


return getSanitizedConsignorName();