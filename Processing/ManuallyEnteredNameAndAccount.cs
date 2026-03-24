/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

string getConsignorAndAccount()
{
    const string CONSIGNOR_NAME = "ConsignorName";
    const string ACCOUNT_NUMBER = "LegacyAccountNumber";
    
    var consignorName = GetVariableValue(CONSIGNOR_NAME);
    var accountNumber = GetVariableValue(ACCOUNT_NUMBER);

    return $"{consignorName}_{accountNumber}";
}

return getConsignorAndAccount();