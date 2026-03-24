/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

string getConsignorAndAccount()
{
    var consignorName = GetVariableValue("ConsignorName");
    var accountNumber = GetVariableValue("LegacyAccountNumber");

    return $"{consignorName}_{accountNumber}";
}

return getConsignorAndAccount();