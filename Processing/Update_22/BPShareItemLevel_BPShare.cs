string getBpShareItemLevelBpText()
{
    const string BP_SHARE_ITEM_LEVEL_BP_SHARE = "BPShareItemLevel_BPShare";
    var bpShareItemLevel = GetVariableValue("BPShareItemLevel_BPShare");

    if (string.IsNullOrWhiteSpace(bpShareItemLevel))
    {
        return string.Empty;
    }

    return "*BP Share Item Level - BP: " + bpShareItemLevel.Trim();
}

return getBpShareItemLevelBpText();