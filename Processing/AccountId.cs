/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

string getTrimmedAccountId()
{
    const string ACCOUNT_ID = "accountId";
    var accountId = GetVariableValue(ACCOUNT_ID);
    return accountId?.Trim() ?? string.Empty;
}

return getTrimmedAccountId();