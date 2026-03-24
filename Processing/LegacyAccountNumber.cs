/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

string sanitizeFileName(string input)
{
    if (string.IsNullOrWhiteSpace(input))
    {
        return string.Empty;
    }

    const string invalidCharsPattern = @"[\/:*?<>""|]+";

    var sanitized = System.Text.RegularExpressions.Regex.Replace(
        input,
        invalidCharsPattern,
        "_"
    );

    return sanitized.Trim().TrimEnd('.');
}

/**

 * @description    : Returns result for getSanitizedLegacyAccountNumber.

 * @author         : Ritankar Jana | 20-03-2026

 * @param          : none

 * @returns        : string

 **/

string getSanitizedLegacyAccountNumber()
{
    const string LEGACY_ACCOUNT_NUMBER = "LegacyAccountNumber";
    var accountNumber = GetVariableValue(LEGACY_ACCOUNT_NUMBER);
    return sanitizeFileName(accountNumber);
}


return getSanitizedLegacyAccountNumber();