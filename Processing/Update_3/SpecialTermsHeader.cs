string getSpecialTermsLabel()
{
    var specialTermsApply = GetVariableValue("SpecialTermsApply");

    if (string.Equals(specialTermsApply, "True", System.StringComparison.OrdinalIgnoreCase))
    {
        return "SPECIAL TERMS";
    }

    return string.Empty;
}

return getSpecialTermsLabel();