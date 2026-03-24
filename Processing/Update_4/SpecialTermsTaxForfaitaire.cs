string getTaxForfaitaireValue()
{
    var value = GetVariableValue("TaxForfaitaire");

    var excludedValues = new[]
    {
        "Professional",
        "Non-Fiscal resident in France (not a French resident for tax purposes)",
        "Fiscal resident in France"
    };

    if (string.IsNullOrWhiteSpace(value) ||
        System.Linq.Enumerable.Contains(excludedValues, value))
    {
        return string.Empty;
    }

    return value;
}

return getTaxForfaitaireValue();