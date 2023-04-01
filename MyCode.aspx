<%@ Language="C#" Inherits="MyStuff.MinhaClass"   src="MyCode.cs" %>
<HTML>
    <body>
        <form id="MyForm" runat="server">
            <asp:textbox id="MyTextBox" text="Hello World" runat="server"></asp:textbox>
            <asp:button id="MyButton" text="Echo Input" Onclick="MyButton_Click" runat="server"></asp:button>
            <asp:label id="MyLabel" runat="server" />
        </form>
		
		
		
		
		
	<pre>
		&lt;&#37;@ Language="C#" Inherits="MyStuff.MinhaClass"  src="MyCode.cs" %&gt;
		&lt;HTML&gt;
		    &lt;body&gt;
			&lt;form id="MyForm" runat="server"&gt;
			    &lt;asp:textbox id="MyTextBox" text="Hello World" runat="server"&gt;&lt;/asp:textbox&gt;
			    &lt;asp:button id="MyButton" text="Echo Input" Onclick="MyButton_Click" runat="server"&gt;&lt;/asp:button&gt;
			    &lt;asp:label id="MyLabel" runat="server" /&gt;
			&lt;/form&gt;
		    &lt;/body&gt;
		&lt;/HTML&gt;
	</pre>
	<b>MyCode.cs</b>
	<pre>
		using System;
		using System.Web;
		using System.Web.UI;
		using System.Web.UI.WebControls;

		namespace MyStuff
		{
		    public class MinhaClass : Page
		    {
			protected System.Web.UI.WebControls.Label MyLabel;
			protected System.Web.UI.WebControls.Button MyButton;
			protected System.Web.UI.WebControls.TextBox MyTextBox;

			public void MyButton_Click(Object sender, EventArgs e)
			{
			    MyLabel.Text = MyTextBox.Text.ToString();
			}
		    }
		}
	</pre>
    </body>
</HTML>