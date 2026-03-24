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
   * @description    : Checks if there are any special terms applied in the consignment.
   * @author         : Ritankar Jana | 20-03-2026
   * @param          : none
   * @returns        : string
   **/
string getHasSpecialTerms()
{
    var specialTerms = new[]
    {
        getTemplateFieldValue("EXTENDED_PAYMENT_TERMS.Special_Terms_Apply_Extended"),
        getTemplateFieldValue("INTRODUCTORY_COMMISSION.Special_Terms_Apply_Intro"),
        getTemplateFieldValue("THE_PROPERTY.Special_Terms_Apply_Property"),
        getTemplateFieldValue("SELLERS_COMMISSION.Special_Terms_Apply_Sellers"),
        getTemplateFieldValue("Schedule_II_Sale_Cost.Special_Terms_Apply"),
        getTemplateFieldValue("Special_Terms.Are_there_any_special_terms_for_this_consignment_other_than_noted_above")
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