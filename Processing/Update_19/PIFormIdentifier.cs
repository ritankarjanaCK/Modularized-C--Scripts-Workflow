string getLanguageDisplay()
{
    var language = GetVariableValue("Language");

    if (string.Equals(language, "English", System.StringComparison.OrdinalIgnoreCase))
    {
        return "English";
    }

    var location = GetVariableValue("Location");

    return $"{location} {language}".Trim();
}

return getLanguageDisplay();