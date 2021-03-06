﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[AttributeUsage(AttributeTargets.Class)]
public class AddtionalInfoAttribute : Attribute
{
    string name; string update; string download;
    public AddtionalInfoAttribute(string name, string update)
    {
        this.name = name; this.update = update;
    }
    public string Name { get { return name; } }
    public string Update { get { return update; } }
    public string Download
    {
        set { download = value; }
        get { return download; }
    }
}

