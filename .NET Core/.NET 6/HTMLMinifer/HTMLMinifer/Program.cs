// See https://aka.ms/new-console-template for more information


using HTMLMinifer;
using System.ComponentModel.Design.Serialization;

string fileext = "";

//fileext = ".min";

HTML.Init(fileext);
CSS.Init(fileext);
JS.Init(fileext);

Console.WriteLine(""); Console.WriteLine("");