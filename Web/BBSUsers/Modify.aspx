<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="BBS.Web.BBSUsers.Modify" Title="修改页" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Uid
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblUid" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Uname
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUname" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UPassword
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUPassword" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UEmail
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUEmail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UBirthday
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtUBirthday" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Usex
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkUsex" Text="Usex" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UClass
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUClass" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UStatement
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUStatement" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		URegDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtURegDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UState
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUState" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UPoint
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUPoint" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

