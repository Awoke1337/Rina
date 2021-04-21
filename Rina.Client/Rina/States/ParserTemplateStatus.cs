using System;
using System.Runtime.InteropServices;
using Rina.Client.Attributes;
using Rina.Maps;

namespace Rina.States
{
	// Token: 0x02000024 RID: 36
	internal class ParserTemplateStatus
	{
		// Token: 0x060000AE RID: 174
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr res, [MarshalAs(UnmanagedType.Bool)] ref bool result);

		// Token: 0x060000AF RID: 175
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x060000B0 RID: 176 RVA: 0x00005D58 File Offset: 0x00003F58
		public static int ForgotPrototype()
		{
			object[] selection = new object[0];
			object[] array = TaskReader.TestRule(0, selection, null);
			return (int)array[0];
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005D88 File Offset: 0x00003F88
		private static int RevertPrototype()
		{
			object[] selection = new object[0];
			object[] array = TaskReader.TestRule(1, selection, null);
			return (int)array[0];
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005DB8 File Offset: 0x00003FB8
		private static int QueryRef()
		{
			object[] selection = new object[0];
			object[] array = TaskReader.TestRule(2, selection, null);
			return (int)array[0];
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005DE8 File Offset: 0x00003FE8
		private static int AddRef()
		{
			object[] selection = new object[0];
			object[] array = TaskReader.TestRule(3, selection, null);
			return (int)array[0];
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000024D4 File Offset: 0x000006D4
		public ParserTemplateStatus()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002AA8 File Offset: 0x00000CA8
		internal static bool CloneDefinition()
		{
			return ParserTemplateStatus.ConnectDefinition == null;
		}

		// Token: 0x0400005D RID: 93
		private static object ConnectDefinition;
	}
}
