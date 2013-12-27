BBCodeParser
============

A BBCode parser for the .NET framework.

The parser and lexer were generated with ANTLR 4.

Configuring and adding new BBCode rules is simple and easy.

Examples
--------

```csharp
var bbc = new BBC();

bbc["[code]{text}[/code]"] =
	_ => "<pre>" + _.text + "</pre>";

bbc["[b]{text}[/b]"] =
	_ => "<strong>" + bbc.Transform(_.text) + "</strong>";

bbc["[i]{text}[/i]"] =
	_ => "<em>" + bbc.Transform(_.text) + "</em>";

bbc["[date/]"] =
	_ => DateTime.Now.ToShortDateString();

bbc["[url={url}]{text}[/url]"] =
	_ => "<a href='" + _.url + "'>" + _.text + "</a>";
	
Console.WriteLine(bbc.Transform("[date/] [b]this is bold[/b] and [code]this is [b]code[/b][/code]\nand this is [b]bold [i]italic[/i][/b]\n[url='http://google.com']test[/url]"));
```

Or for the default BBCode->HTML support, just do:

```csharp
Console.WriteLine(BBCode.Basic().Transform("[b]Awesome[/b]"));
```
