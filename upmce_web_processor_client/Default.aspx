<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="upmce_web_processor_client.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EMV Processor DI Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="MessageTextbox" runat="server" Width="250px" ReadOnly="true" />
        <asp:Button ID="ProcessTextbox" runat="server" Text="Process Sale" OnClick="Process_Handler" />
    </div>
    </form>
</body>
</html>
