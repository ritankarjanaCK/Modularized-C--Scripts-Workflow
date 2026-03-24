string getBpShareItemLevelSellersText()
{
    var bpShareSellers = GetVariableValue("BPShareItemLevel_Sellers");

    if (string.IsNullOrWhiteSpace(bpShareSellers))
    {
        return string.Empty;
    }

    return "*BP Share Item Level - Sellers: " + bpShareSellers.Trim();
}

return getBpShareItemLevelSellersText();