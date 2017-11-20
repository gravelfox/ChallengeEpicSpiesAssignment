<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" maintainScrollPositionOnPostBack="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img class="auto-style1" src="epic-spies-logo.jpg" /><br />
        <br />
        <h1>Spy New Assignment Form</h1>
        <p>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:&nbsp;
            <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of previous assignment:</p>
        <p>
            <asp:Calendar ID="prevEndCal" runat="server" ></asp:Calendar>
        </p>
        <p>
            Start date of new assignment:</p>
        <p>
            <asp:Calendar ID="newStartCal" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected end date of new assignment:</p>
        <p>
            <asp:Calendar ID="newEndCal" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
        </p>
        <p>
            <asp:Label ID="msgLabel" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
