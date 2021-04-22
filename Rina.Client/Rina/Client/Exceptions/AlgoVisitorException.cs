using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Rina.Client.Exceptions
{
	// Token: 0x0200005A RID: 90
	internal struct AlgoVisitorException
	{
		// Token: 0x0600025D RID: 605
		[DllImport("ntdll.dll")]
		private static extern int NtQueryInformationProcess(IntPtr param, int next_map, ref AlgoVisitorException util, int length_key2, out uint second3);

		// Token: 0x0600025E RID: 606 RVA: 0x0000360E File Offset: 0x0000180E
		public static Process PrepareRule()
		{
			return AlgoVisitorException.DeleteRule(Process.GetCurrentProcess().Handle);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00014A50 File Offset: 0x00012C50
		public static Process DeleteRule(IntPtr asset)
		{
			AlgoVisitorException ex = default(AlgoVisitorException);
			uint num2;
			int num = AlgoVisitorException.NtQueryInformationProcess(asset, 0, ref ex, Marshal.SizeOf(ex), out num2);
			if (num == 0)
			{
				try
				{
					return Process.GetProcessById(ex.m_ClientReader.ToInt32());
				}
				catch (ArgumentException)
				{
					return null;
				}
			}
			throw new Win32Exception(num);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00014AB4 File Offset: 0x00012CB4
		public static bool CallRule()
		{
			bool result;
			using (Process process = AlgoVisitorException.PrepareRule())
			{
				if (process != null)
				{
					result = (process.SessionId == 0 && StringComparer.OrdinalIgnoreCase.Equals(process.ProcessName, "services"));
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000361F File Offset: 0x0000181F
		internal static bool CalcPolicy()
		{
			return AlgoVisitorException.RestartPolicy == null;
		}

		// Token: 0x040001C2 RID: 450
		internal IntPtr _RequestReader;

		// Token: 0x040001C3 RID: 451
		internal IntPtr reponseReader;

		// Token: 0x040001C4 RID: 452
		internal IntPtr rulesReader;

		// Token: 0x040001C5 RID: 453
		internal IntPtr _InterceptorReader;

		// Token: 0x040001C6 RID: 454
		internal IntPtr _ContextReader;

		// Token: 0x040001C7 RID: 455
		internal IntPtr m_ClientReader;

		// Token: 0x040001C8 RID: 456
		internal static object RestartPolicy;
	}
}
