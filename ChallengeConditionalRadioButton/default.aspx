<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengeConditionalRadioButton.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note Taking Preferences<br />
            <br />
            <asp:RadioButton ID="radBtnPencil" runat="server" GroupName="radDevices" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Pencil" />
            <br />
            <asp:RadioButton ID="radBtnPen" runat="server" GroupName="radDevices" OnCheckedChanged="RadioButton2_CheckedChanged1" Text="Pen" />
            <br />
            <asp:RadioButton ID="radBtnPhone" runat="server" GroupName="radDevices" Text="Phone" />
        </div>
        <asp:RadioButton ID="radBtnTablet" runat="server" GroupName="radDevices" Text="Tablet" />
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Image ID="imgDevice" runat="server" />
    </form>
</body>
</html>
