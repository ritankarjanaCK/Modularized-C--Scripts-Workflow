string getSpecialTermsLabel()
{
    const string SPECIAL_TERMS_APPLY_PATH = "SpecialTermsApply";

    var specialTermsApply = GetVariableValue(SPECIAL_TERMS_APPLY_PATH);

    if (string.Equals(specialTermsApply, "True", System.StringComparison.OrdinalIgnoreCase))
    {
        return "SPECIAL TERMS";
    }

    return string.Empty;
}

return getSpecialTermsLabel();