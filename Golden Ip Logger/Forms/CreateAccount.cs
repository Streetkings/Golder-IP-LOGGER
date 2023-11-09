using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace Word.Scripts.Forms;

public class CreateAccount : Form
{
	private FirebaseConfig firebaseConfig_0;

	private IFirebaseClient ifirebaseClient_0;

	private IContainer icontainer_0;

	private Guna2Panel guna2Panel_0;

	private Guna2HtmlLabel guna2HtmlLabel_0;

	private Guna2PictureBox guna2PictureBox_0;

	private Guna2TextBox guna2TextBox_0;

	private Guna2TextBox guna2TextBox_1;

	private Guna2Button guna2Button_0;

	private Guna2Panel guna2Panel_1;

	private Guna2ControlBox guna2ControlBox_0;

	private Guna2ControlBox guna2ControlBox_1;

	private Guna2ControlBox guna2ControlBox_2;

	private Guna2DragControl guna2DragControl_0;

	private Guna2AnimateWindow guna2AnimateWindow_0;

	private Guna2BorderlessForm guna2BorderlessForm_0;

	private static CreateAccount createAccount_0;

	public CreateAccount()
	{
		firebaseConfig_0 = new FirebaseConfig
		{
			BasePath = "https://ferramenta-5f719-default-rtdb.firebaseio.com/",
			AuthSecret = "HBmLJ7VoLemEvCs0iU6wQmA51IV94N8BlhJ5Voez"
		};
		icontainer_0 = null;
		InitializeComponent();
	}

	private void guna2Button_0_Click(object sender, EventArgs e)
	{
		try
		{
			if (!string.IsNullOrWhiteSpace(guna2TextBox_0.Text) || !string.IsNullOrWhiteSpace(guna2TextBox_1.Text))
			{
				GClass0 data = new GClass0
				{
					String_0 = guna2TextBox_0.Text,
					String_1 = guna2TextBox_1.Text,
					String_2 = "api_exe",
					String_3 = "_p2",
					String_4 = "_p3",
					String_5 = "_p4",
					String_6 = "_p5",
					String_7 = "_p6",
					Boolean_0 = false,
					Boolean_1 = false,
					Boolean_2 = false,
					Boolean_4 = false,
					Boolean_5 = false,
					Boolean_3 = false
				};
				ifirebaseClient_0.Set("Users/" + guna2TextBox_0.Text, data);
				MessageBox.Show("Your account successfully created!", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Please verify your information and try again.", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		catch (Exception)
		{
			MessageBox.Show("Please verify your information and try again.", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void guna2Panel_0_Paint(object sender, PaintEventArgs e)
	{
	}

	private void CreateAccount_Load(object sender, EventArgs e)
	{
		try
		{
			ifirebaseClient_0 = new FirebaseClient((IFirebaseConfig)(object)firebaseConfig_0);
		}
		catch (Exception)
		{
			MessageBox.Show("Sorry, we have a problem, please try again later!", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Application.Exit();
		}
	}

	private void guna2ControlBox_2_Click(object sender, EventArgs e)
	{
		try
		{
			Close();
		}
		catch (Exception)
		{
			MessageBox.Show("Sorry, we have a problem, please try again later!", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new Container();
		ComponentResourceManager resources = new ComponentResourceManager(typeof(CreateAccount));
		guna2Panel_0 = new Guna2Panel();
		guna2HtmlLabel_0 = new Guna2HtmlLabel();
		guna2PictureBox_0 = new Guna2PictureBox();
		guna2TextBox_0 = new Guna2TextBox();
		guna2TextBox_1 = new Guna2TextBox();
		guna2Button_0 = new Guna2Button();
		guna2Panel_1 = new Guna2Panel();
		guna2ControlBox_0 = new Guna2ControlBox();
		guna2ControlBox_1 = new Guna2ControlBox();
		guna2ControlBox_2 = new Guna2ControlBox();
		guna2DragControl_0 = new Guna2DragControl(icontainer_0);
		guna2AnimateWindow_0 = new Guna2AnimateWindow(icontainer_0);
		guna2BorderlessForm_0 = new Guna2BorderlessForm(icontainer_0);
		guna2Panel_0.SuspendLayout();
		((ISupportInitialize)guna2PictureBox_0).BeginInit();
		guna2Panel_1.SuspendLayout();
		SuspendLayout();
		guna2Panel_0.BackColor = Color.FromArgb(48, 26, 140);
		guna2Panel_0.Controls.Add(guna2HtmlLabel_0);
		guna2Panel_0.Controls.Add(guna2PictureBox_0);
		guna2Panel_0.Controls.Add(guna2TextBox_0);
		guna2Panel_0.Controls.Add(guna2TextBox_1);
		guna2Panel_0.Controls.Add(guna2Button_0);
		guna2Panel_0.Dock = DockStyle.Fill;
		guna2Panel_0.Location = new Point(0, 40);
		guna2Panel_0.Name = "guna2Panel2";
		guna2Panel_0.Size = new Size(746, 410);
		guna2Panel_0.TabIndex = 6;
		guna2Panel_0.Paint += guna2Panel_0_Paint;
		guna2HtmlLabel_0.BackColor = Color.Transparent;
		guna2HtmlLabel_0.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		guna2HtmlLabel_0.ForeColor = Color.FromArgb(77, 232, 254);
		guna2HtmlLabel_0.Location = new Point(12, 381);
		guna2HtmlLabel_0.Name = "guna2HtmlLabel1";
		guna2HtmlLabel_0.Size = new Size(155, 17);
		guna2HtmlLabel_0.TabIndex = 10;
		guna2HtmlLabel_0.Text = "Telegram @Andromeda_RAT ";
		guna2PictureBox_0.BackColor = Color.Transparent;
		guna2PictureBox_0.Image = (Image)resources.GetObject("guna2PictureBox4.Image");
		guna2PictureBox_0.ImageRotate = 0f;
		guna2PictureBox_0.Location = new Point(351, 23);
		guna2PictureBox_0.Name = "guna2PictureBox4";
		guna2PictureBox_0.Size = new Size(63, 60);
		guna2PictureBox_0.SizeMode = PictureBoxSizeMode.Zoom;
		guna2PictureBox_0.TabIndex = 7;
		guna2PictureBox_0.TabStop = false;
		guna2PictureBox_0.UseTransparentBackground = true;
		guna2TextBox_0.BorderThickness = 0;
		guna2TextBox_0.Cursor = Cursors.IBeam;
		guna2TextBox_0.DefaultText = "";
		guna2TextBox_0.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		guna2TextBox_0.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		guna2TextBox_0.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		guna2TextBox_0.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		guna2TextBox_0.FillColor = Color.FromArgb(48, 26, 140);
		guna2TextBox_0.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		guna2TextBox_0.Font = new Font("Segoe UI", 9f);
		guna2TextBox_0.ForeColor = Color.FromArgb(77, 232, 254);
		guna2TextBox_0.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		guna2TextBox_0.Location = new Point(186, 112);
		guna2TextBox_0.MaxLength = 99999999;
		guna2TextBox_0.Name = "TxtUsername";
		guna2TextBox_0.PasswordChar = '\0';
		guna2TextBox_0.PlaceholderForeColor = Color.FromArgb(77, 232, 254);
		guna2TextBox_0.PlaceholderText = "Username";
		guna2TextBox_0.SelectedText = "";
		guna2TextBox_0.ShadowDecoration.Enabled = true;
		guna2TextBox_0.ShadowDecoration.Shadow = new Padding(5, 1, 2, 10);
		guna2TextBox_0.Size = new Size(392, 36);
		guna2TextBox_0.TabIndex = 1;
		guna2TextBox_1.BorderThickness = 0;
		guna2TextBox_1.Cursor = Cursors.IBeam;
		guna2TextBox_1.DefaultText = "";
		guna2TextBox_1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		guna2TextBox_1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		guna2TextBox_1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		guna2TextBox_1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		guna2TextBox_1.FillColor = Color.FromArgb(48, 26, 140);
		guna2TextBox_1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		guna2TextBox_1.Font = new Font("Segoe UI", 9f);
		guna2TextBox_1.ForeColor = Color.FromArgb(77, 232, 254);
		guna2TextBox_1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		guna2TextBox_1.Location = new Point(186, 171);
		guna2TextBox_1.MaxLength = 99999999;
		guna2TextBox_1.Name = "TxtPassword";
		guna2TextBox_1.PasswordChar = '*';
		guna2TextBox_1.PlaceholderForeColor = Color.FromArgb(77, 232, 254);
		guna2TextBox_1.PlaceholderText = "***********";
		guna2TextBox_1.SelectedText = "";
		guna2TextBox_1.ShadowDecoration.Enabled = true;
		guna2TextBox_1.ShadowDecoration.Shadow = new Padding(5, 1, 2, 10);
		guna2TextBox_1.Size = new Size(392, 36);
		guna2TextBox_1.TabIndex = 4;
		guna2Button_0.DisabledState.BorderColor = Color.DarkGray;
		guna2Button_0.DisabledState.CustomBorderColor = Color.DarkGray;
		guna2Button_0.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
		guna2Button_0.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
		guna2Button_0.FillColor = Color.FromArgb(48, 26, 140);
		guna2Button_0.Font = new Font("Segoe UI", 9f);
		guna2Button_0.ForeColor = Color.FromArgb(77, 232, 254);
		guna2Button_0.Location = new Point(283, 288);
		guna2Button_0.Name = "BtnLogin";
		guna2Button_0.ShadowDecoration.Enabled = true;
		guna2Button_0.ShadowDecoration.Shadow = new Padding(5, 1, 2, 10);
		guna2Button_0.Size = new Size(180, 45);
		guna2Button_0.TabIndex = 0;
		guna2Button_0.Text = "Create Account";
		guna2Button_0.Click += guna2Button_0_Click;
		guna2Panel_1.BackColor = Color.FromArgb(48, 26, 140);
		guna2Panel_1.Controls.Add(guna2ControlBox_0);
		guna2Panel_1.Controls.Add(guna2ControlBox_1);
		guna2Panel_1.Controls.Add(guna2ControlBox_2);
		guna2Panel_1.Dock = DockStyle.Top;
		guna2Panel_1.Location = new Point(0, 0);
		guna2Panel_1.Name = "guna2Panel1";
		guna2Panel_1.Size = new Size(746, 40);
		guna2Panel_1.TabIndex = 5;
		guna2ControlBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		guna2ControlBox_0.ControlBoxType = ControlBoxType.MinimizeBox;
		guna2ControlBox_0.FillColor = Color.FromArgb(48, 26, 140);
		guna2ControlBox_0.IconColor = Color.FromArgb(77, 232, 254);
		guna2ControlBox_0.Location = new Point(593, 4);
		guna2ControlBox_0.Name = "guna2ControlBox3";
		guna2ControlBox_0.Size = new Size(45, 29);
		guna2ControlBox_0.TabIndex = 9;
		guna2ControlBox_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		guna2ControlBox_1.ControlBoxType = ControlBoxType.MaximizeBox;
		guna2ControlBox_1.FillColor = Color.FromArgb(48, 26, 140);
		guna2ControlBox_1.IconColor = Color.FromArgb(77, 232, 254);
		guna2ControlBox_1.Location = new Point(644, 4);
		guna2ControlBox_1.Name = "guna2ControlBox2";
		guna2ControlBox_1.Size = new Size(45, 29);
		guna2ControlBox_1.TabIndex = 8;
		guna2ControlBox_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		guna2ControlBox_2.FillColor = Color.FromArgb(48, 26, 140);
		guna2ControlBox_2.IconColor = Color.FromArgb(77, 232, 254);
		guna2ControlBox_2.Location = new Point(695, 4);
		guna2ControlBox_2.Name = "guna2ControlBox1";
		guna2ControlBox_2.Size = new Size(45, 29);
		guna2ControlBox_2.TabIndex = 7;
		guna2ControlBox_2.Click += guna2ControlBox_2_Click;
		guna2DragControl_0.DockIndicatorTransparencyValue = 0.6;
		guna2DragControl_0.TargetControl = guna2Panel_1;
		guna2DragControl_0.UseTransparentDrag = true;
		guna2BorderlessForm_0.ContainerControl = this;
		guna2BorderlessForm_0.DockIndicatorTransparencyValue = 0.6;
		guna2BorderlessForm_0.TransparentWhileDrag = true;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(746, 450);
		base.Controls.Add(guna2Panel_0);
		base.Controls.Add(guna2Panel_1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)resources.GetObject("$this.Icon");
		base.Name = "CreateAccount";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "CreateAccount";
		base.Load += CreateAccount_Load;
		guna2Panel_0.ResumeLayout(performLayout: false);
		guna2Panel_0.PerformLayout();
		((ISupportInitialize)guna2PictureBox_0).EndInit();
		guna2Panel_1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	internal static bool smethod_0()
	{
		return createAccount_0 == null;
	}

	internal static CreateAccount smethod_1()
	{
		return createAccount_0;
	}
}
