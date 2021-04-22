using System;
using System.Windows.Forms;
using Rina.Client.Attributes;
using Rina.Client.Classes;

namespace Rina.Maps
{
	// Token: 0x02000033 RID: 51
	internal static class DispatcherRefMap
	{
		// Token: 0x0600018C RID: 396 RVA: 0x0000FC40 File Offset: 0x0000DE40
		[STAThread]
		private static void ChangeReader()
		{
			MapperWatcherClass.RateRule();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			AdvisorConnectionAttribute.CancelComposer();
			try
			{
				Application.Run(new ExporterRefMap());
			}
			catch (Exception ex)
			{
				string str = "Beklenmeyen Hata: ";
				Exception ex2 = ex;
				MessageBox.Show(str + ((ex2 != null) ? ex2.ToString() : null));
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000313E File Offset: 0x0000133E
		internal static bool WriteOrder()
		{
			return DispatcherRefMap.ExcludeOrder == null;
		}

		// Token: 0x04000101 RID: 257
		internal static object ExcludeOrder;
	}
}
