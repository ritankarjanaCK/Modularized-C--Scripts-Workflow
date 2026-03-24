/**
 * @description       : This script constructs a document name by fetching values.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/



/**
   * @description    : Constructs the document name by fetching values from DocumentNameVariable1, DocumentNameVariable2, and DocumentNameVariable3, trimming 
                       whitespace, and joining non-empty parts with underscores. The final name is suffixed with "~[x]".
   * @author         : Ritankar Jana | 20-03-2026
   * @param          : none
   * @returns        : string
   **/
string getDocumentName()
{
    var part1 = GetVariableValue("DocumentNameVariable1")?.Trim();
    var part2 = GetVariableValue("DocumentNameVariable2")?.Trim();
    var part3 = GetVariableValue("DocumentNameVariable3")?.Trim();

    var parts = new[] { part1, part2, part3 };

    var combined = string.Join("_",
        System.Linq.Enumerable.Where(parts, p => !string.IsNullOrWhiteSpace(p))
    );

    return combined + "~[x]";
}

return getDocumentName();