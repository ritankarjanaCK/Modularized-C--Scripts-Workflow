/**
 * @description       : Fetches the variable value for "DocumentNameVariable1", sanitizes it by replacing invalid filename characters with 
                        underscores, and returns the sanitized string. If the input is null or whitespace, it returns an empty string.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/




/**
   * @description    : Returns the sanitized DocumentNameVariable1 value, ensuring it is safe for use as a filename.
   * @author         : Ritankar Jana | 20-03-2026
   * @param          : none
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
   * @description    : Fetches the DocumentNameVariable1 value, sanitizes it for safe filename usage, and returns the sanitized string.
   * @author         : Ritankar Jana | 20-03-2026
   * @param          : none
   * @returns        : string
**/
string getSanitizedDocumentNameVariable1()
{
    var documentName = GetVariableValue("DocumentNameVariable1");
    return sanitizeFileName(documentName);
}




return getSanitizedDocumentNameVariable1();