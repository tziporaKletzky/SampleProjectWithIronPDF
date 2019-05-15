<!DOCTYPE html>

<%@ Page Language="C#" AutoEventWireup="True" Inherits="MyLogin"  CodeBehind="MyLogin.aspx.cs" %>

<%--<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>--%>
<%--<%@ Register Src="Controls/Bottom.ascx" TagName="Bottom" TagPrefix="uc2" %>
<%@ Register Src="Controls/Top.ascx" TagName="Top" TagPrefix="uc1" %>--%>
 <meta http-equiv="X-UA-Compatible" content="IE=5" />

<%--    <meta name="a" http-equiv="X-UA-Compatible" content="IE=EmulateIE11" />--%>
<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl" style="height: 100%">

<%--<script language="javascript">
    function NavParent() {
        if (document.parentWindow.name == "ifrContent") {
            document.parentWindow.parent.navigate("login.aspx");
        }
    }

</script>--%>
     
<head runat="server">
    <title>כניסה למערכת</title>
</head>
<body class="body_NoMargin" style="height: 100%"
    dir="rtl">
    <form id="form1" style="height: 100%" runat="server" defaultbutton="btnToPdf" defaultfocus="txtUserID">
    <asp:Button ID="btnToPdf" Text="ConvertToPdf" runat="server" OnClick="btnToPdf_Click"></asp:Button >
    <input type="hidden" id="hidPassword" runat="server" />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
