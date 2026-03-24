/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

// Instance - 1
/**
 * @description    : Returns result for getTemplateFieldValue.
 * @author         : Ritankar Jana | 20-03-2026
 * @param          : string relativePath
 * @returns        : string
 **/
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

/**
 * @description    : Returns result for getAccountNameForFile.
 * @author         : Ritankar Jana | 20-03-2026
 * @param          : none
 * @returns        : string
 **/

string getAccountNameForFile()
{
    var accountName = getTemplateFieldValue("Account_Name_For_File");

    if (string.IsNullOrWhiteSpace(accountName) || accountName == "-")
    {
        return GetVariableValue("ManuallyEnteredNameAndAccount");
    }

    return accountName;
}


return getAccountNameForFile();


// Instance - 2

/**
 * @description    : Returns result for getAccountOrConsignorName.
 * @author         : Ritankar Jana | 20-03-2026
 * @param          : none
 * @returns        : string
 **/

string getAccountOrConsignorName()
{
    var account = GetVariableValue("Account");

    if (string.IsNullOrWhiteSpace(account))
    {
        return GetVariableValue("ConsignorName");
    }

    return account;
}

return getAccountOrConsignorName();