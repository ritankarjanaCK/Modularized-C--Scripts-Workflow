/**
 * @description       : Fetches the variable value for "Account", trims whitespace, and returns fallback empty string if null.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

/**
   * @description    : Returns the trimmed Account variable value or empty string when missing.
   * @author         : Ritankar Jana | 20-03-2026
   * @param          : none
   * @returns        : string
   **/

string getTrimmedAccount()
{
    const string ACCOUNT = "Account";
    return GetVariableValue(ACCOUNT)?.Trim() ?? string.Empty;
}



return getTrimmedAccount();


