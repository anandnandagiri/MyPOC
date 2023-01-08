// See https://aka.ms/new-console-template for more information


using HTMLMinifer;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;

string fileext = "";
//fileext = ".min";

var ignorehml = Environment.GetCommandLineArgs().Where(c => c.ToString().ToLower() == "ignorehtml").ToList();
if (ignorehml.Count == 0)
{
    HTML.Init(fileext);
}

var ignorecss = Environment.GetCommandLineArgs().Where(c => c.ToString().ToLower() == "ignorecss").ToList();
if (ignorecss.Count == 0)
{
    CSS.Init(fileext);
}


var ignoreJS = Environment.GetCommandLineArgs().Where(c => c.ToString().ToLower() == "ignorejs").ToList();
if (ignoreJS.Count==0)
{
    JS.Init(fileext);
}


Console.WriteLine(""); Console.WriteLine("");

 