string getIsInsituFlag()
{
    var value = GetVariableValue("Is_Insitu");
    var assertVal="In situ; in client custody with availability to view";
    if (string.Equals(value,assertVal,System.StringComparison.OrdinalIgnoreCase))
    {
        return "Yes";
    }

    return string.Empty;
}


return getIsInsituFlag();