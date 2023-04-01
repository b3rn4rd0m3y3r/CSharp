<%@ Import Namespace="System"%>
<%@ Import Namespace="System.Web"%>
<%@ Import Namespace="System.Web.UI"%>
<%@ Import Namespace="System.Web.UI.WebControls"%>
<%@ Language="C#" %>
<HTML>
	<script runat="server">

			public void MyButton_Click(Object sender, EventArgs e){
			    MyLabel.Text = MyTextBox.Text.ToString();
				}

	</script>
	
    <body>
		<h1>Full</h1>
        <form id="MyForm" runat="server">
            <asp:textbox id="MyTextBox" text="Hello World" runat="server"></asp:textbox>
            <asp:button id="MyButton" text="Echo Input" Onclick="MyButton_Click" runat="server"></asp:button>
            <asp:label id="MyLabel" runat="server" />
        </form>

    </body>
</HTML>