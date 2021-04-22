using System;
using System.Reflection;
using System.Windows.Forms;

namespace Rina.Client.Roles
{
	// Token: 0x02000091 RID: 145
	internal static class RegContainerRole
	{
		// Token: 0x0600051D RID: 1309 RVA: 0x0000503D File Offset: 0x0000323D
		internal static string CallComposer(Assembly assembly)
		{
			if (!(assembly == typeof(RegContainerRole).Assembly))
			{
				return assembly.Location;
			}
			return Application.ExecutablePath;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00005063 File Offset: 0x00003263
		internal static bool DefineService()
		{
			return RegContainerRole.CompareService == null;
		}

		// Token: 0x04000261 RID: 609
		private static object CompareService;
	}
}
