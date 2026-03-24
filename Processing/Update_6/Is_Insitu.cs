string getIsInsituFlag()
{
    const string IS_INSITU = "Is_Insitu";

    var value = GetVariableValue(IS_INSITU);
    if (string.Equals(value, "In situ; in client custody with availability to view", System.StringComparison.OrdinalIgnoreCase))
    {
        return "Yes";
    }

    return string.Empty;
}


return getIsInsituFlag();