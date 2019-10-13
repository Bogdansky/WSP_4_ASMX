<%@ Page Language="C#" CodeBehind="Index.aspx.cs" Inherits="WSP_4_ASMX.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="https://code.jquery.com/jquery-3.4.1.js"></script>
    <script defer="defer" src="Scripts/index.js">
    </script>
</head>
<body>

    <div class="form-group">
        <label for="fieldX">X</label>
        <input type="number" class="form-control" id="fieldX" placeholder="x"/>
        <label for="fieldY">Y</label>
        <input type="number" class="form-control" id="fieldY" placeholder="y"/>
    </div>
    <button class="btn btn-primary">Add</button>
    <div id="result">

    </div>
</body>
</html>