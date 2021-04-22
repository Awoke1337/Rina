namespace Rina.Maps
{
	// Token: 0x02000029 RID: 41
	internal partial class ExporterRefMap : global::System.Windows.Forms.Form
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00002BA3 File Offset: 0x00000DA3
		protected override void Dispose(bool isconfig)
		{
			if (isconfig && this.m_Class != null)
			{
				this.m_Class.Dispose();
			}
			base.Dispose(isconfig);
		}

		// Token: 0x04000068 RID: 104
		private global::System.IDisposable m_Class;
	}
}
