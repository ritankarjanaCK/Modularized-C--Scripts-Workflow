/**
 * @description       : Utility functions for this script file.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

string getTrimmedConsignmentId()
{
    const string CONSIGNMENT_ID = "consignmentId";
    var consignmentId = GetVariableValue(CONSIGNMENT_ID);
    return consignmentId?.Trim() ?? string.Empty;
}

return getTrimmedConsignmentId();