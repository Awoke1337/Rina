using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MetroFramework.Forms;
using Rina.Client.Attributes;
using Rina.Database;
using Rina.Maps;
using Rina.Structs;

namespace Rina.Client.Readers
{
	// Token: 0x0200002A RID: 42
	internal class ContextAuthenticationReader : MetroForm
	{
		// Token: 0x060000DD RID: 221
		[DllImport("ntdll.dll", CharSet = CharSet.Auto)]
		public static extern int NtQueryInformationProcess(IntPtr ident, int result_X, int[] serv, int removeCOUNTER2At, ref int selection3);

		// Token: 0x060000DE RID: 222 RVA: 0x00002BCC File Offset: 0x00000DCC
		public ContextAuthenticationReader()
		{
			AdvisorConnectionAttribute.CancelComposer();
			this._Val = new MapperRef();
			base..ctor();
			ProductReaderStructBuilder._BridgeIdentifier = this;
			this.SortRef();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00006810 File Offset: 0x00004A10
		public void InsertRef()
		{
			object[] selection = new object[0];
			TaskReader.TestRule(6, selection, this);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00006838 File Offset: 0x00004A38
		private void RemoveRef(object sender, EventArgs e)
		{
			TaskReader.TestRule(7, new object[]
			{
				sender,
				e
			}, this);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002BF0 File Offset: 0x00000DF0
		private void RegisterRef(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002BF0 File Offset: 0x00000DF0
		private void WriteRef(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002BF0 File Offset: 0x00000DF0
		private void ManageRef(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002BF0 File Offset: 0x00000DF0
		private void CompareRef(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002BF0 File Offset: 0x00000DF0
		private void ComputeRef(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002BF2 File Offset: 0x00000DF2
		protected override void Dispose(bool outputkey)
		{
			if (outputkey && this.tests != null)
			{
				this.tests.Dispose();
			}
			base.Dispose(outputkey);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00006874 File Offset: 0x00004A74
		private void SortRef()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ContextAuthenticationReader));
			this._System = new StatusStrip();
			this._Advisor = new ToolStripStatusLabel();
			this.m_Mock = new ProgressBar();
			this.attr = new Label();
			this.configuration = new Label();
			this._Bridge = new Label();
			this._Tag = new ProgressBar();
			this._System.SuspendLayout();
			base.SuspendLayout();
			this._System.BackColor = SystemColors.ScrollBar;
			this._System.Items.AddRange(new ToolStripItem[]
			{
				this._Advisor
			});
			this._System.Location = new Point(0, 187);
			this._System.Name = "statusStrip";
			this._System.Size = new Size(476, 22);
			this._System.TabIndex = 0;
			this._System.Text = "Status";
			this._Advisor.Name = "Status";
			this._Advisor.Size = new Size(0, 17);
			this.m_Mock.BackColor = Color.FromArgb(192, 192, 0);
			this.m_Mock.Location = new Point(27, 84);
			this.m_Mock.Name = "currentProgress";
			this.m_Mock.Size = new Size(416, 21);
			this.m_Mock.TabIndex = 2;
			this.m_Mock.Click += this.ComputeRef;
			this.attr.AutoSize = true;
			this.attr.ForeColor = SystemColors.ButtonFace;
			this.attr.Location = new Point(24, 68);
			this.attr.Name = "completeProgressText";
			this.attr.Size = new Size(101, 13);
			this.attr.TabIndex = 3;
			this.attr.Text = "Toplam İlerleme: 0%";
			this.attr.Click += this.ManageRef;
			this.configuration.AutoSize = true;
			this.configuration.ForeColor = SystemColors.ButtonFace;
			this.configuration.Location = new Point(24, 118);
			this.configuration.Name = "currentProgressText";
			this.configuration.Size = new Size(163, 13);
			this.configuration.TabIndex = 4;
			this.configuration.Text = "Dosya İlerlemesi: 0%  |  0.00 kb/s";
			this.configuration.Click += this.CompareRef;
			this._Bridge.AutoSize = true;
			this._Bridge.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this._Bridge.ForeColor = SystemColors.ControlText;
			this._Bridge.Location = new Point(151, -21);
			this._Bridge.Name = "label1";
			this._Bridge.Size = new Size(127, 13);
			this._Bridge.TabIndex = 5;
			this._Bridge.Text = "Dosya Yükleme Aracı";
			this._Tag.Location = new Point(27, 134);
			this._Tag.Name = "completeProgress";
			this._Tag.Size = new Size(416, 21);
			this._Tag.TabIndex = 7;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(476, 209);
			base.Controls.Add(this._Tag);
			base.Controls.Add(this._Bridge);
			base.Controls.Add(this.configuration);
			base.Controls.Add(this.attr);
			base.Controls.Add(this.m_Mock);
			base.Controls.Add(this._System);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new Size(476, 209);
			this.MinimumSize = new Size(476, 209);
			base.Movable = false;
			base.Name = "pForm";
			base.Padding = new Padding(0, 60, 0, 0);
			base.Resizable = false;
			base.ShadowType = 4;
			base.Style = 3;
			this.Text = "Patcher";
			base.Theme = 2;
			base.Load += this.RegisterRef;
			base.Shown += this.RemoveRef;
			this._System.ResumeLayout(false);
			this._System.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002C11 File Offset: 0x00000E11
		internal static bool ConcatDefinition()
		{
			return ContextAuthenticationReader.ViewDefinition == null;
		}

		// Token: 0x0400006E RID: 110
		private MapperRef _Val;

		// Token: 0x0400006F RID: 111
		private IDisposable tests;

		// Token: 0x04000070 RID: 112
		private StatusStrip _System;

		// Token: 0x04000071 RID: 113
		public ToolStripStatusLabel _Advisor;

		// Token: 0x04000072 RID: 114
		public ProgressBar m_Mock;

		// Token: 0x04000073 RID: 115
		public Label attr;

		// Token: 0x04000074 RID: 116
		public Label configuration;

		// Token: 0x04000075 RID: 117
		private Label _Bridge;

		// Token: 0x04000076 RID: 118
		public ProgressBar _Tag;

		// Token: 0x04000077 RID: 119
		private static object ViewDefinition;
	}
}
