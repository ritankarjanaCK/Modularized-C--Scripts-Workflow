/**
 * @description       : Contains code for fetching and sanitizing variable values for folder levels, ensuring they are safe for use in file paths. This includes handling special characters and formatting dates as needed.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/

//Folder_Level_2
/**
 * @description    : Returns result for getLocationName.
 * @author         : Ritankar Jana | 20-03-2026
 * @param          : none
 * @returns        : string
 **/
string getLocationName()
{
    var isNYWine = GetVariableValue("SothebysWineNewYork");

    if (isNYWine == "Yes")
    {
        return "Sothebys Wine New York";
    }

    return GetVariableValue("Location");
}

return getLocationName();



//Folder_Level_6
/**
 * @description    : Returns result for getCurrentYear.
 * @author         : Ritankar Jana | 20-03-2026
 * @param          : none
 * @returns        : string
 **/
string getCurrentYear()
{
    return System.DateTime.Now.ToString("yyyy");
}

return getCurrentYear();



//Folder_Level_4
/**
 * @description    : Returns result for sanitizeFileName.
 * @author         : Ritankar Jana | 20-03-2026
 * @param          : string input
 * @returns        : string
 **/
string sanitizeFileName(string input)
{
    if (string.IsNullOrWhiteSpace(input))
    {
        return string.Empty;
    }

    const string invalidCharsPattern = @"[\/:*?<>""|]+";

    var sanitized = System.Text.RegularExpressions.Regex.Replace(input,invalidCharsPattern,"_");

    return sanitized.Trim().TrimEnd('.');
}

/**

 * @description    : Returns result for getSanitizedFolderLevel4.

 * @author         : Ritankar Jana | 20-03-2026

 * @param          : none

 * @returns        : string

 **/

string getSanitizedFolderLevel4()
{
    var folderLevel4 = GetVariableValue("Folder_Level_4");
    return sanitizeFileName(folderLevel4);
}

return getSanitizedFolderLevel4();





//Folder_Level_3
/**
 * @description    : Returns result for sanitizeFileName.
 * @author         : Ritankar Jana | 20-03-2026
 * @param          : string input
 * @returns        : string
 **/
string sanitizeFileName(string input)
{
    if (string.IsNullOrWhiteSpace(input))
    {
        return string.Empty;
    }

    const string invalidCharsPattern = @"[\/:*?<>""|]+";

    var sanitized = System.Text.RegularExpressions.Regex.Replace(
        input,
        invalidCharsPattern,
        "_"
    );

    return sanitized.Trim().TrimEnd('.');
}

/**
 * @description    : Returns result for getSanitizedFolderLevel3.
 * @author         : Ritankar Jana | 20-03-2026
 * @param          : none
 * @returns        : string
 **/

string getSanitizedFolderLevel3()
{
    var folderLevel3 = GetVariableValue("Folder_Level_3");
    return sanitizeFileName(folderLevel3);
}

return getSanitizedFolderLevel3();