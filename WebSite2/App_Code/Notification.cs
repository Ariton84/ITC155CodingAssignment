using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Notification
/// </summary>
public class Notification
{
    public string note;
    public string date;
    public string getNote()
    {
        return note + " " + date;
    }

}