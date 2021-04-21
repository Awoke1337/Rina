using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;
using Rina.Client.Attributes;
using Rina.Client.Readers;
using Rina.Database;
using Rina.Structs;

namespace Rina.Maps
{
	// Token: 0x02000029 RID: 41
	internal partial class ExporterRefMap : Form
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x000063E0 File Offset: 0x000045E0
		public ExporterRefMap()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
			bool flag;
			using (WindowsIdentity current = WindowsIdentity.GetCurrent())
			{
				flag = new WindowsPrincipal(current).IsInRole(WindowsBuiltInRole.Administrator);
			}
			if (!flag)
			{
				MessageBox.Show("Client yönetici olarak çalışmadığı için başlatılamadı.");
				Environment.Exit(0);
			}
			ProductReaderStructBuilder.objectIdentifier = this;
			this.RestartRef();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002B59 File Offset: 0x00000D59
		private void AssetRef(object sender, EventArgs e)
		{
			this.account = Path.GetTempPath() + "Rina_Updater.exe";
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000644C File Offset: 0x0000464C
		public void DefineRef()
		{
			if (File.Exists(this.account))
			{
				File.Delete(this.account);
			}
			Uri address = new Uri(ProductReaderStructBuilder.m_PrinterIdentifier);
			WebClient webClient = new WebClient();
			webClient.Headers.Add("user-agent", ProductReaderStructBuilder.m_SchemaIdentifier);
			webClient.DownloadFileAsync(address, this.account);
			webClient.DownloadFileCompleted += this.CollectRef;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000064B4 File Offset: 0x000046B4
		private void CollectRef(object sender, AsyncCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				MessageBox.Show("Güncelleme indirilemiyor, lütfen bağlantınızı kontrol edin.", "İndirilemedi");
				this.DefineRef();
				return;
			}
			Process.Start(new ProcessStartInfo(this.account)
			{
				Arguments = "\"" + Process.GetCurrentProcess().MainModule.FileName + "\""
			});
			Environment.Exit(0);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002B70 File Offset: 0x00000D70
		private void ListRef(object sender, EventArgs e)
		{
			if (MapperRef.CalculateReader(ProductReaderStructBuilder._StateIdentifier) != ProductReaderStructBuilder._ValIdentifier)
			{
				this.DefineRef();
				return;
			}
			ProductReaderStructBuilder.objectIdentifier.Hide();
			new ContextAuthenticationReader().Show();
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000651C File Offset: 0x0000471C
		private void RestartRef()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ExporterRefMap));
			this.descriptor = new ProgressBar();
			this.publisher = new Label();
			this.callback = new Label();
			this._Printer = new Label();
			base.SuspendLayout();
			this.descriptor.Location = new Point(12, 116);
			this.descriptor.Name = "progressBar1";
			this.descriptor.Size = new Size(436, 42);
			this.descriptor.TabIndex = 0;
			this.publisher.AutoSize = true;
			this.publisher.Location = new Point(9, 100);
			this.publisher.Name = "currentProgressText";
			this.publisher.Size = new Size(63, 13);
			this.publisher.TabIndex = 9;
			this.publisher.Text = "İlerleme: 0%";
			this.callback.AutoSize = true;
			this.callback.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.callback.Location = new Point(88, 27);
			this.callback.Name = "label1";
			this.callback.Size = new Size(273, 24);
			this.callback.TabIndex = 10;
			this.callback.Text = "Yeni client sürümü bulundu.";
			this._Printer.AutoSize = true;
			this._Printer.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
			this._Printer.Location = new Point(125, 51);
			this._Printer.Name = "label2";
			this._Printer.Size = new Size(203, 18);
			this._Printer.TabIndex = 11;
			this._Printer.Text = "Sizin için herşeyi hallediyoruz.";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.ControlLightLight;
			this.BackgroundImageLayout = ImageLayout.Center;
			base.ClientSize = new Size(459, 171);
			base.Controls.Add(this._Printer);
			base.Controls.Add(this.callback);
			base.Controls.Add(this.publisher);
			base.Controls.Add(this.descriptor);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Updater";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "\"";
			base.Load += this.AssetRef;
			base.Shown += this.ListRef;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002BC2 File Offset: 0x00000DC2
		internal static bool InsertDefinition()
		{
			return ExporterRefMap.SelectDefinition == null;
		}

		// Token: 0x04000067 RID: 103
		private string account;

		// Token: 0x04000069 RID: 105
		private ProgressBar descriptor;

		// Token: 0x0400006A RID: 106
		public Label publisher;

		// Token: 0x0400006B RID: 107
		private Label callback;

		// Token: 0x0400006C RID: 108
		private Label _Printer;

		// Token: 0x0400006D RID: 109
		internal static object SelectDefinition;
	}
}
