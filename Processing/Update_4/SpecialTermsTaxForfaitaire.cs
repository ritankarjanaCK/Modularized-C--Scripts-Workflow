string getTaxForfaitaireValue()
{
    const string TAX_FORFAITAIRE = "TaxForfaitaire";
    var value = GetVariableValue(TAX_FORFAITAIRE);

    const string EXCLUDED_VALUE_1 = "Professional";
    const string EXCLUDED_VALUE_2 = "Non-Fiscal resident in France (not a French resident for tax purposes)";
    const string EXCLUDED_VALUE_3 = "Fiscal resident in France";
    
    var excludedValues = new[]
    {
        EXCLUDED_VALUE_1, 
        EXCLUDED_VALUE_2, 
        EXCLUDED_VALUE_3
    };

    if (string.IsNullOrWhiteSpace(value) ||
        System.Linq.Enumerable.Contains(excludedValues, value))
    {
        return string.Empty;
    }

    return value;
}

return getTaxForfaitaireValue();