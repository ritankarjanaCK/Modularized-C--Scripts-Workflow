/**
 * @description       : Fetches the current date, formats it as MM_dd_yyyy, and returns it as a string.
 * @author            : Ritankar Jana
 * @group             : CloudKaptan
 * @last modified on  : 20-03-2026
 * @last modified by  : Ritankar Jana
 **/


/**
   * @description    : Returns the current date formatted as MM_dd_yyyy.
   * @author         : Ritankar Jana | 20-03-2026
   * @param          : none
   * @returns        : string
   **/
string getCurrentDateFormatted()
{
    return System.DateTime.Now.ToString("MM_dd_yyyy");
}



return getCurrentDateFormatted();