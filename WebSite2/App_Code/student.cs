using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for student
/// </summary>
public class student
{
    public int credits;
    public string firstName;
    public string lastName;
    public string major;
    public string[] currentClasses;
    public string[] completedClasses;
    public student()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string display()
    {
        return "Hello " + firstName + " " + lastName;
    }
    public void addCredit(int adcred)
    {
        credits += adcred;
    }
    public string viewCurClasses()
    {
        string classret = "";
        for (int i = 0; i < currentClasses.Length; i++)
        {
            classret += "<br>" + currentClasses[i];
        }

        return classret;
    }
    public string viewCompClasses()
    {
        string classret = "";
        for (int i = 0; i < completedClasses.Length; i++)
        {
            classret += "<br>" + completedClasses[i];
        }

        return classret;
    }
}