<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register TagPrefix="controls" TagName="header" Src="Header.ascx" %>
<%@ Register TagPrefix="controls" TagName="curriculum"  Src="Curriculum.ascx" %>
<%@ Register TagPrefix="controls" TagName="sidebar"  Src="Sidebar.ascx" %>
<%@ Register TagPrefix="controls" TagName="footer" Src="Footer.ascx" %>

<!doctype html>
<html>

<controls:header runat="server" />

<body>

    <controls:curriculum runat="server" />

    <controls:sidebar runat="server" />

    <controls:footer runat="server" />

</body>
</html>

