<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Curriculum.ascx.cs" Inherits="Curriculum" %>

<%if (false) { %>
    <link href="_css/main.css" rel="stylesheet" type="text/css" />
<% }%>

<article id="mainContent">
    <h1>Graphic Design</h1>
    <p>The Graphic Design program helps students to develop skills in listening, negotiating, research, thinking creatively, idea generation, and manipulating visual languages and techniques. Students are encouraged to cultivate and share ideas, as well as develop their own philosophy and unique way of working. </p>
    <blockquote>Roux Academy's Graphic Design program helped me mature both as a designer and as a creative professional. Their cross-disciplinary approach helped me see multiple sides and solutions to every problem I encountered, and that's something that has translated to how I approach design in my career. Roux Academy was tremendously important in helping shape the designer I've become. <span class="quote">&#8211;Tabitha Knowles, Lead Designer Veroscare Partners</span></blockquote>

    <h2>Required Curriculum</h2>
    <p>While every program is different and course loads are tailored to meet the individual student&rsquo;s needs, this list represents the required curriculum for any student seeking a BA in Graphic Design.</p>

    <asp:Table ID="Table1" runat="server" Caption="First semester course load for Graphic Design degree">
        <asp:TableRow runat="server">
            <asp:TableHeaderCell runat="server">First Semester</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server">credit hours</asp:TableHeaderCell>
        </asp:TableRow>
    </asp:Table>

    <asp:Table ID="Table2" runat="server" Caption="Second semester course load for Graphic Design degree">
        <asp:TableRow runat="server">
            <asp:TableHeaderCell runat="server">Second Semester</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server">credit hours</asp:TableHeaderCell>
        </asp:TableRow>
    </asp:Table>

    <asp:Table ID="Table3" runat="server" Caption="Third semester course load for Graphic Design degree">
        <asp:TableRow runat="server">
            <asp:TableHeaderCell runat="server">Third Semester</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server">credit hours</asp:TableHeaderCell>
        </asp:TableRow>
    </asp:Table>

    <asp:Table ID="Table4" runat="server" Caption="Fourth semester course load for Graphic Design degree">
        <asp:TableRow runat="server">
            <asp:TableHeaderCell runat="server">Fourth Semester</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server">credit hours</asp:TableHeaderCell>
        </asp:TableRow>
    </asp:Table>
 
</article>
