using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Rina.Client.Attributes
{
	// Token: 0x02000023 RID: 35
	internal class TestsConnectionAttribute
	{
		// Token: 0x060000A7 RID: 167
		[DllImport("kernel32.dll")]
		private static extern IntPtr ZeroMemory(IntPtr config, IntPtr vis);

		// Token: 0x060000A8 RID: 168
		[DllImport("kernel32.dll")]
		private static extern IntPtr VirtualProtect(IntPtr spec, IntPtr pol, IntPtr serv, ref IntPtr instance2);

		// Token: 0x060000A9 RID: 169 RVA: 0x00005B48 File Offset: 0x00003D48
		private static void FindPrototype(IntPtr item, int ivk_Position)
		{
			IntPtr intPtr = (IntPtr)ivk_Position;
			IntPtr serv = 0;
			TestsConnectionAttribute.VirtualProtect(item, intPtr, (IntPtr)64, ref serv);
			TestsConnectionAttribute.ZeroMemory(item, intPtr);
			IntPtr intPtr2 = 0;
			TestsConnectionAttribute.VirtualProtect(item, intPtr, serv, ref intPtr2);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005B90 File Offset: 0x00003D90
		public static void ConcatPrototype()
		{
			IntPtr baseAddress = Process.GetCurrentProcess().MainModule.BaseAddress;
			int num = Marshal.ReadInt32((IntPtr)(baseAddress.ToInt32() + 60));
			short num2 = Marshal.ReadInt16((IntPtr)(baseAddress.ToInt32() + num + 6));
			TestsConnectionAttribute.FindPrototype(baseAddress, 30);
			for (int i = 0; i < TestsConnectionAttribute._Error.Length; i++)
			{
				TestsConnectionAttribute.FindPrototype((IntPtr)(baseAddress.ToInt32() + num + TestsConnectionAttribute._Error[i]), 4);
			}
			for (int j = 0; j < TestsConnectionAttribute.reg.Length; j++)
			{
				TestsConnectionAttribute.FindPrototype((IntPtr)(baseAddress.ToInt32() + num + TestsConnectionAttribute.reg[j]), 2);
			}
			for (int k = 0; k < TestsConnectionAttribute.observer.Length; k++)
			{
				TestsConnectionAttribute.FindPrototype((IntPtr)(baseAddress.ToInt32() + num + TestsConnectionAttribute.observer[k]), 1);
			}
			int l = 0;
			int num3 = 0;
			while (l <= (int)num2)
			{
				if (num3 == 0)
				{
					TestsConnectionAttribute.FindPrototype((IntPtr)(baseAddress.ToInt32() + num + 250 + 40 * l + 32), 2);
				}
				TestsConnectionAttribute.FindPrototype((IntPtr)(baseAddress.ToInt32() + num + 250 + 40 * l + TestsConnectionAttribute._Param[num3]), 4);
				num3++;
				if (num3 == TestsConnectionAttribute._Param.Length)
				{
					l++;
					num3 = 0;
				}
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000024D4 File Offset: 0x000006D4
		public TestsConnectionAttribute()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005CEC File Offset: 0x00003EEC
		static TestsConnectionAttribute()
		{
			AdvisorConnectionAttribute.CancelComposer();
			TestsConnectionAttribute._Param = new int[]
			{
				8,
				12,
				16,
				20,
				24,
				28,
				36
			};
			TestsConnectionAttribute.observer = new int[]
			{
				26,
				27
			};
			TestsConnectionAttribute.reg = new int[]
			{
				4,
				22,
				24,
				64,
				66,
				68,
				70,
				72,
				74,
				76,
				92,
				94
			};
			TestsConnectionAttribute._Error = new int[]
			{
				0,
				8,
				12,
				16,
				22,
				28,
				32,
				40,
				44,
				52,
				60,
				76,
				80,
				84,
				88,
				96,
				100,
				104,
				108,
				112,
				116,
				260,
				264,
				268,
				272,
				276,
				284
			};
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002A9E File Offset: 0x00000C9E
		internal static bool CompareDefinition()
		{
			return TestsConnectionAttribute.PopDefinition == null;
		}

		// Token: 0x04000058 RID: 88
		private static int[] _Param;

		// Token: 0x04000059 RID: 89
		private static int[] observer;

		// Token: 0x0400005A RID: 90
		private static int[] reg;

		// Token: 0x0400005B RID: 91
		private static int[] _Error;

		// Token: 0x0400005C RID: 92
		internal static object PopDefinition;
	}
}
