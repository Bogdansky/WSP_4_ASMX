<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" CodeBehind="Default.aspx.cs" Inherits="App_For_AddS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="Scripts/index.js"></script>

    <div class="form-group">
        <label for="fieldX">X</label>
        <input type="number" class="form-control" id="fieldX" placeholder="x">
        <label for="fieldY">Y</label>
        <input type="number" class="form-control" id="fieldY" placeholder="y">
    </div>
    <a class="btn btn-primary">Add</a>
    <div id="result">

    </div>
    <script defer src="Scripts/index.js"></script>
</asp:Content>
