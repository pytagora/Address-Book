﻿using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

[assembly: ComVisible(false)]

[assembly: AssemblyCompany(AssemblyDescription.Company)]
[assembly: AssemblyTrademark(AssemblyDescription.Trademark)]
[assembly: AssemblyCopyright(AssemblyDescription.Copyright)]

[assembly: AssemblyConfiguration(AssemblyDescription.Configuration)]

[assembly: AssemblyTitle(AssemblyDescription.Title)]
[assembly: AssemblyProduct(AssemblyDescription.Product)]

[assembly: AssemblyDescription(AssemblyDescription.Description)]
[assembly: AssemblyVersion(AssemblyDescription.Version)]
[assembly: AssemblyCulture(AssemblyDescription.Culture)]
[assembly: NeutralResourcesLanguage("en-US")]

internal static partial class AssemblyDescription
{
    public const string Title = "Address book";
    public const string Company = "Valentino Skobljanec";
    public const string Trademark = "";
    public const string Copyright = "Copyright © 2018 " + Company;
    public const string Product = "Address book";
    public const string Description = "Desktop App for storing contacts";
 
    public const string Culture = "";

    public const string Version = "1.0.2";

    public const string Configuration = "";
}