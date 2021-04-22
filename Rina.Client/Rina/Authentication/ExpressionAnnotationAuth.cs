using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Rina.Client.Attributes;
using Rina.Client.Polices;
using Rina.Client.Roles;
using Rina.Composer;
using Rina.Maps;
using Rina.Queues;
using Rina.Shared;
using Rina.Structs;

namespace Rina.Authentication
{
	// Token: 0x02000025 RID: 37
	internal class ExpressionAnnotationAuth
	{
		// Token: 0x060000B6 RID: 182
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern SecureStringVariantType NtQueryInformationProcess([In] IntPtr value, [In] KnownSemanticTypeValues map, out IntPtr filter, [In] int size_v2, [Optional] out int visitor3);

		// Token: 0x060000B7 RID: 183
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern SecureStringVariantType NtClose([In] IntPtr task);

		// Token: 0x060000B8 RID: 184
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern SecureStringVariantType NtRemoveProcessDebug(IntPtr task, IntPtr visitor);

		// Token: 0x060000B9 RID: 185
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern SecureStringVariantType NtSetInformationDebugObject([In] IntPtr init, [In] LossOfScopeAction caller, [In] IntPtr res, [In] int ivk2_Low, [Optional] out int reg3);

		// Token: 0x060000BA RID: 186
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern SecureStringVariantType NtQuerySystemInformation([In] YesNoNoneErrorEnum first, IntPtr attr, [In] int indexOf_comp, [Optional] out int counter2);

		// Token: 0x060000BB RID: 187 RVA: 0x00005E18 File Offset: 0x00004018
		public static int PublishRef()
		{
			object[] selection = new object[0];
			object[] array = TaskReader.TestRule(4, selection, null);
			return (int)array[0];
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005E48 File Offset: 0x00004048
		private static int ResetRef()
		{
			ProductReaderStructBuilder.mockIdentifier++;
			IntPtr intPtr = new IntPtr(0);
			try
			{
				int num;
				if (ExpressionAnnotationAuth.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, (KnownSemanticTypeValues)7, out intPtr, Marshal.SizeOf(intPtr), out num) == (SecureStringVariantType)0U && intPtr == new IntPtr(-1))
				{
					Console.WriteLine("DebugPort : {0:X}", intPtr);
					return 1;
				}
			}
			catch
			{
				ProductReaderStructBuilder._AdvisorIdentifier = 1;
			}
			ProductReaderStructBuilder.codeIdentifier++;
			return 0;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005ED8 File Offset: 0x000040D8
		private static bool SelectRef()
		{
			object[] selection = new object[0];
			object[] array = TaskReader.TestRule(5, selection, null);
			return (bool)array[0];
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005F08 File Offset: 0x00004108
		private unsafe static bool InitRef()
		{
			ProductReaderStructBuilder.mockIdentifier++;
			try
			{
				ConfigurationPolicyPolicy configurationPolicyPolicy;
				int num;
				if (ExpressionAnnotationAuth.NtQuerySystemInformation((YesNoNoneErrorEnum)35, new IntPtr((void*)(&configurationPolicyPolicy)), Marshal.SizeOf(configurationPolicyPolicy), out num) == (SecureStringVariantType)0U && configurationPolicyPolicy.m_Rule && !configurationPolicyPolicy._Annotation)
				{
					return true;
				}
			}
			catch
			{
				ProductReaderStructBuilder._AdvisorIdentifier = 1;
			}
			ProductReaderStructBuilder.codeIdentifier++;
			return false;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000024D4 File Offset: 0x000006D4
		public ExpressionAnnotationAuth()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002AB2 File Offset: 0x00000CB2
		static ExpressionAnnotationAuth()
		{
			AdvisorConnectionAttribute.CancelComposer();
			ExpressionAnnotationAuth._Exception = new IntPtr(-1);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002AC4 File Offset: 0x00000CC4
		internal static bool StartDefinition()
		{
			return ExpressionAnnotationAuth.CalculateDefinition == null;
		}

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr _Exception;

		// Token: 0x0400005F RID: 95
		internal static object CalculateDefinition;
	}
}
