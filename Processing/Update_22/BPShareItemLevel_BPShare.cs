string getBpShareItemLevelBpText()
{
    var bpShareItemLevel = GetVariableValue("BPShareItemLevel_BPShare");

    if (string.IsNullOrWhiteSpace(bpShareItemLevel))
    {
        return string.Empty;
    }

    return "*BP Share Item Level - BP: " + bpShareItemLevel.Trim();
}

return getBpShareItemLevelBpText();