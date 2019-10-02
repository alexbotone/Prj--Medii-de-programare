<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AlexBotonePrj._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
    </div>

    <div class="row">
        <div class="col-md-4">
            <table class="nav-justified">
                <tr>
                    <td colspan="4" style="font-family: Arial, Helvetica, sans-serif; background-color: #FFFF99; font-weight: bold; font-size: x-large; color: #333333">Inserare&nbsp; Liga, Echipa, Jucator</td>
                </tr>
                <tr>
                    <td style="width: 136px; height: 9px">&nbsp;</td>
                    <td class="modal-sm" style="width: 323px; height: 9px">&nbsp;</td>
                    <td style="height: 9px">&nbsp;</td>
                    <td style="height: 9px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 136px; height: 9px">
                        <asp:Label ID="Label6" runat="server" BackColor="#FF9933">Id Liga</asp:Label>
                    </td>
                    <td class="modal-sm" style="width: 323px; height: 9px">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    <td style="height: 9px">
                        <asp:Button ID="BtnInsertl" runat="server" BackColor="#FF9933" Font-Bold="True" Font-Size="Medium" Height="23px" Text="Inserare liga" Width="102px" OnClick="BtnInsertl_Click" />
                    </td>
                    <td style="height: 9px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 136px; height: 9px">
                        <asp:Label ID="Label7" runat="server" Text="Nume Liga" BackColor="#FF9933"></asp:Label>
                    </td>
                    <td class="modal-sm" style="width: 323px; height: 9px">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 9px">&nbsp;</td>
                    <td style="height: 9px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="height: 9px" colspan="4">
                        <asp:GridView ID="GridView3" runat="server" style="margin-right: 398px" Width="563px">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td style="width: 136px; height: 8px"></td>
                    <td class="modal-sm" style="width: 323px; height: 8px"></td>
                    <td style="height: 8px"></td>
                    <td style="height: 8px"></td>
                </tr>
                <tr>
                    <td style="width: 136px; height: 9px">
                        <asp:Label ID="Label11" runat="server" Text="Echipa Id" BackColor="#66CCFF"></asp:Label>
                    </td>
                    <td class="modal-sm" style="width: 323px; height: 9px">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    <td style="height: 9px">
                        <asp:Button ID="BtnInseraree" runat="server" BackColor="#66CCFF" Font-Bold="True" Height="20px" style="margin-top: 8px" Text="Inserare echipa" Width="114px" OnClick="BtnInseraree_Click" />
                    </td>
                    <td style="height: 9px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 136px; height: 9px">
                        <asp:Label ID="Label9" runat="server" Text="Nume" BackColor="#66CCFF"></asp:Label>
                    </td>
                    <td class="modal-sm" style="width: 323px; height: 9px">
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 9px">&nbsp;</td>
                    <td style="height: 9px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 136px; height: 9px">
                        <asp:Label ID="Label10" runat="server" Text="Liga" BackColor="#66CCFF"></asp:Label>
                    </td>
                    <td class="modal-sm" style="width: 323px; height: 9px">
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 9px"></td>
                    <td style="height: 9px"></td>
                </tr>
                <tr>
                    <td style="height: 9px" colspan="4">
                        <asp:GridView ID="GridView2" runat="server" Width="621px">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td style="width: 136px; height: 9px">&nbsp;</td>
                    <td class="modal-sm" style="width: 323px; height: 9px">&nbsp;</td>
                    <td style="height: 9px">&nbsp;</td>
                    <td style="height: 9px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 136px; height: 9px"></td>
                    <td class="modal-sm" style="width: 323px; height: 9px"></td>
                    <td style="height: 9px"></td>
                    <td style="height: 9px"></td>
                </tr>
                <tr>
                    <td style="width: 136px">
                        <asp:Label ID="Label5" runat="server" BackColor="#99FF66" BorderColor="White" Text="ID"></asp:Label>
                    </td>
                    <td class="modal-sm" style="width: 323px">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    <td>
                        <asp:Button ID="BtnSearch" runat="server" BackColor="#33CC33" Font-Bold="True" Font-Size="Medium" ForeColor="Black" Height="24px" style="margin-top: 17px" Text="Search " Width="76px" CssClass="col-xs-offset-0" OnClick="BtnSearch_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="height: 20px; width: 136px">
                        <asp:Label ID="Label1" runat="server" BackColor="#99FF66" BorderColor="White" Text="Nume"></asp:Label>
                    </td>
                    <td style="height: 20px; width: 323px">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 20px"></td>
                    <td style="height: 20px"></td>
                </tr>
                <tr>
                    <td style="width: 136px">
                        <asp:Label ID="Label2" runat="server" BackColor="#99FF66" BorderColor="White" Text="Prenume"></asp:Label>
                    </td>
                    <td class="modal-sm" style="width: 323px">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="height: 20px; width: 136px">
                        <asp:Label ID="Label3" runat="server" BackColor="#99FF66" BorderColor="White" Text="Varsta"></asp:Label>
                    </td>
                    <td style="height: 20px; width: 323px">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 20px"></td>
                    <td style="height: 20px"></td>
                </tr>
                <tr>
                    <td style="width: 136px; height: 22px;">
                        <asp:Label ID="Label4" runat="server" BackColor="#99FF66" BorderColor="White" Text="Echipa"></asp:Label>
                    </td>
                    <td class="modal-sm" style="width: 323px; height: 22px;">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 22px"></td>
                    <td style="height: 22px"></td>
                </tr>
                <tr>
                    <td style="width: 136px; height: 20px;"></td>
                    <td class="modal-sm" style="width: 323px; height: 20px;"></td>
                    <td style="height: 20px"></td>
                    <td style="height: 20px"></td>
                </tr>
                <tr>
                    <td style="width: 136px">&nbsp;</td>
                    <td class="modal-sm" style="width: 323px">
                        <asp:Button ID="BtnInsert" runat="server" BackColor="#33CC33" Font-Bold="True" Font-Size="Medium" ForeColor="Black" Height="38px" Text="Insert" Width="76px" OnClick="BtnInsert_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="BtnUpdate" runat="server" BackColor="#33CC33" Font-Bold="True" Font-Size="Medium" ForeColor="Black" Height="38px" Text="Update" Width="76px" OnClick="BtnUpdate_Click" />
&nbsp;&nbsp;&nbsp;
                        </td>
                    <td>
                        <asp:Button ID="BtnDelete" runat="server" BackColor="#33CC33" BorderColor="Red" BorderStyle="Double" BorderWidth="5px" Font-Bold="True" Font-Size="Medium" ForeColor="Black" Height="38px" Text="Delete" Width="76px" OnClick="BtnDelete_Click"  />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 136px; height: 20px"></td>
                    <td class="modal-sm" style="height: 20px; width: 323px"></td>
                    <td style="height: 20px"></td>
                    <td style="height: 20px"></td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="GridView1" runat="server" Width="607px">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td style="width: 136px">&nbsp;</td>
                    <td class="modal-sm" style="width: 323px">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </div>

</asp:Content>
