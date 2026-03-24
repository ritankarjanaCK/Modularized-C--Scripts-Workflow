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

/**
 * @description    : Returns result for getAccountNameForFile.
 * @author         : Ritankar Jana | 20-03-2026
 * @param          : none
 * @returns        : string
 **/

string getAccountNameForFile()
{
    const string ACCOUNT_NAME_FOR_FILE = "Account_Name_For_File";
    const string MANUALLY_ENTERED_NAME_AND_ACCOUNT = "ManuallyEnteredNameAndAccount";

    var accountName = getTemplateFieldValue(ACCOUNT_NAME_FOR_FILE);

    if (string.IsNullOrWhiteSpace(accountName) || accountName == "-")
    {
        return GetVariableValue(MANUALLY_ENTERED_NAME_AND_ACCOUNT);
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
    const string ACCOUNT = "Account";
    const string CONSIGNOR_NAME = "ConsignorName";

    var account = GetVariableValue(ACCOUNT);

    if (string.IsNullOrWhiteSpace(account))
    {
        return GetVariableValue(CONSIGNOR_NAME);
    }

    return account;
}

return getAccountOrConsignorName();