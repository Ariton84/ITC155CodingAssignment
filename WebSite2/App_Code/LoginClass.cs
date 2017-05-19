using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for LoginClass
/// </summary>
public class LoginClass
{
    
    string user;
    string pass;
    private bool v;
    private string text;
    private bool v1;
    private bool v2;

    public LoginClass(string userName, string password)
    {
        user = userName;
        pass = password;
        
    }

    public LoginClass(bool v, string text)
    {
        this.v = v;
        this.text = text;
    }

    public LoginClass(bool v1, bool v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }
}