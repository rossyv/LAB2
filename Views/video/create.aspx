﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>registrar video</title>
     <meta charset="UTF-8">
  <meta name="description" content="ASP.NET MVC 2 CRUD video">
  <meta name="keywords" content="ASP.NET, MVC, FACPYA">
  <meta name="author" content="Rosa maria vega jinez">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>

<form action= "/video/create" method = "post">
<fieldset>
<legend>datos del video</legend>
<label for = "idvideo" >idvideo</label>
<input type = "text" name= "idvideo" />

<label for = "titulo" >titulo</label>
<input type = "text" name= "titulo" />

<label for = "repro" >repro</label>
<input type = "text" name= "repro" />

<label for = "url" >url</label>
<input type = "text" name= "url" />
<input type= "submit" value= "registrar" />
   

</body>
</html>
