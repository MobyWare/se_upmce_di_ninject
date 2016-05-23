<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="upmce_web_processor_factory_client.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EMV Processor Factory Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="SiteLabel" runat="server" Text="Select Processor for your site:" />
        <br />
        <asp:DropDownList ID="ProcessorDropdown" runat="server" >
            <asp:ListItem Value="ProcessorA" Text="ProcessorA EMV Gateway" Selected="True"/>
            <asp:ListItem Value="ProcessorB" Text="ProcessorB EMV Gateway" />
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="ProcessButton" runat="server" Text="Process Sale" OnClick="Process_Handler" />
        <asp:Button ID="ClearButton" runat="server" Text="Clear Messages" OnClick="Clear_Handler" />
        <br />
        <br />
        <asp:TextBox ID="MessageTextbox" runat="server" Height="300px" Width="300px" ReadOnly="true" TextMode="MultiLine" />
        
    </div>
    </form>
</body>
</html>
