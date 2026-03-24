/**
 * @description       : Checks if there are any special terms applied in the consignment by evaluating multiple template fields .
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
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
   * @description    : Checks if there are any special terms applied in the consignment.
   * @author         : Ritankar Jana | 20-03-2026
   * @param          : none
   * @returns        : string
   **/
string getHasSpecialTerms()
{
    const string EXTENDED_PAYMENT_TERMS_PATH = "EXTENDED_PAYMENT_TERMS.Special_Terms_Apply_Extended";
    const string INTRODUCTORY_COMMISSION_PATH = "INTRODUCTORY_COMMISSION.Special_Terms_Apply_Intro";
    const string PROPERTY_SPECIAL_TERMS_PATH = "THE_PROPERTY.Special_Terms_Apply_Property";
    const string SELLERS_COMMISSION_PATH = "SELLERS_COMMISSION.Special_Terms_Apply_Sellers";
    const string SCHEDULE_II_SALE_COST_PATH = "Schedule_II_Sale_Cost.Special_Terms_Apply";
    const string SPECIAL_TERMS_PATH = "Special_Terms.Are_there_any_special_terms_for_this_consignment_other_than_noted_above";
    
    var specialTerms = new[]
    {
        getTemplateFieldValue(EXTENDED_PAYMENT_TERMS_PATH),
        getTemplateFieldValue(INTRODUCTORY_COMMISSION_PATH),
        getTemplateFieldValue(PROPERTY_SPECIAL_TERMS_PATH),
        getTemplateFieldValue(SELLERS_COMMISSION_PATH),
        getTemplateFieldValue(SCHEDULE_II_SALE_COST_PATH),
        getTemplateFieldValue(SPECIAL_TERMS_PATH)
    };

    foreach (var specialTerm in specialTerms)
    {
        if (string.Equals(specialTerm, "True", System.StringComparison.OrdinalIgnoreCase))
        {
            return "True";
        }
    }

    return string.Empty;
}


return getHasSpecialTerms();