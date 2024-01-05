using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Utilities
/// </summary>
public class Utilities
{
	public Utilities()
	{
		
	}

    public string PreventInjection(string input)
    {
        string[] forbiddenWords = { "'", ";", "--", "or", "delete", "drop" };

        char[] forbiddenChars = { '*', '=', '<', '>', '&' };

        Dictionary<string, string> allowedReplacements = new Dictionary<string, string>
    {
        { "'", " " },
        { ";", " " },
        { "--", " " },
        { "or", " " },
        { "delete", " " },
        { "drop", " " }
    };

        string cleanedInput = input;

        foreach (char forbiddenChar in forbiddenChars)
        {
            cleanedInput = cleanedInput.Replace(forbiddenChar, ' ');
        }

        foreach (var forbiddenWord in forbiddenWords)
        {
            cleanedInput = cleanedInput.Replace(forbiddenWord, allowedReplacements[forbiddenWord]);
        }

        return cleanedInput;
    }

}