<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>edit</title>
</head>
<body>
   <form action="/video/edit" method ="post"> 
   <fieldset> 
   <legend> editar video</legend>

    <label for ="idvideo">id video</label>
    <input type="text" name="idvideo" />

     <label for ="titulo">titulo</label>
    <input type="text" name="titulo" />

     <label for ="repro">reproducciones</label>
    <input type="text" name="repro" />

     <label for ="url">url</label>
    <input type="text" name="url" />

    <input type="submit" value ="editar" />
    </fieldset>
    </form>
</body>
</html>
