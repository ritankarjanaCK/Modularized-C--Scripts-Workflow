string getLanguageDisplay()
{
    const string LANGUAGE = "Language";
    const string LOCATION = "Location";
    var language = GetVariableValue(LANGUAGE);

    if (string.Equals(language, "English", System.StringComparison.OrdinalIgnoreCase))
    {
        return "English";
    }

    var location = GetVariableValue(LOCATION);

    return $"{location} {language}".Trim();
}

return getLanguageDisplay();