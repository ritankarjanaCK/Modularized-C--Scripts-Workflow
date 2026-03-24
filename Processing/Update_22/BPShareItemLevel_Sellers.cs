string getBpShareItemLevelSellersText()
{
    const string BP_SHARE_ITEM_LEVEL_SELLERS = "BPShareItemLevel_Sellers";
    var bpShareSellers = GetVariableValue(BP_SHARE_ITEM_LEVEL_SELLERS);

    if (string.IsNullOrWhiteSpace(bpShareSellers))
    {
        return string.Empty;
    }

    return "*BP Share Item Level - Sellers: " + bpShareSellers.Trim();
}

return getBpShareItemLevelSellersText();