<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>delete</title>
</head>
<body>
    <form action="/video/delete" method ="post"> 
    <fieldset> 
    <legend> id del video</legend>
    <label for ="idvideo">id video</label>
    <input type="text" name="idvideo" />
    <input type="submit" value = "eliminar" />
    </fieldset>
    </form>
</body>
</html>
