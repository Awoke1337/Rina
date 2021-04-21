using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Rina.Client.Attributes;

namespace Rina.Objects
{
	// Token: 0x02000027 RID: 39
	internal class IdentifierSingletonObject
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00002AED File Offset: 0x00000CED
		public static void GetRef()
		{
			IdentifierSingletonObject.PostRef(true);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00006060 File Offset: 0x00004260
		private static int PostRef(bool includereference)
		{
			int result = 0;
			if (IdentifierSingletonObject.m_Helper.Count == 0 && IdentifierSingletonObject.m_Setter.Count == 0)
			{
				IdentifierSingletonObject.OrderRef();
			}
			foreach (Process process in Process.GetProcesses())
			{
				if (IdentifierSingletonObject.m_Helper.Contains(process.ProcessName) || IdentifierSingletonObject.m_Setter.Contains(process.MainWindowTitle))
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("BAD PROCESS FOUND: " + process.ProcessName);
					result = 1;
					if (includereference)
					{
						try
						{
							process.Kill();
						}
						catch (Win32Exception ex)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.Write("Win32Exception: " + ex.Message);
						}
						catch (NotSupportedException ex2)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.Write("NotSupportedException: " + ex2.Message);
						}
						catch (InvalidOperationException ex3)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.Write("InvalidOperationException: " + ex3.Message);
						}
					}
					return result;
				}
			}
			return result;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00006184 File Offset: 0x00004384
		private static int OrderRef()
		{
			if (IdentifierSingletonObject.m_Helper.Count > 0 && IdentifierSingletonObject.m_Setter.Count > 0)
			{
				return 1;
			}
			IdentifierSingletonObject.m_Helper.Add("ollydbg");
			IdentifierSingletonObject.m_Helper.Add("ida");
			IdentifierSingletonObject.m_Helper.Add("ida64");
			IdentifierSingletonObject.m_Helper.Add("idag");
			IdentifierSingletonObject.m_Helper.Add("idag64");
			IdentifierSingletonObject.m_Helper.Add("idaw");
			IdentifierSingletonObject.m_Helper.Add("idaw64");
			IdentifierSingletonObject.m_Helper.Add("idaq");
			IdentifierSingletonObject.m_Helper.Add("idaq64");
			IdentifierSingletonObject.m_Helper.Add("idau");
			IdentifierSingletonObject.m_Helper.Add("idau64");
			IdentifierSingletonObject.m_Helper.Add("scylla");
			IdentifierSingletonObject.m_Helper.Add("scylla_x64");
			IdentifierSingletonObject.m_Helper.Add("scylla_x86");
			IdentifierSingletonObject.m_Helper.Add("protection_id");
			IdentifierSingletonObject.m_Helper.Add("x64dbg");
			IdentifierSingletonObject.m_Helper.Add("x32dbg");
			IdentifierSingletonObject.m_Helper.Add("windbg");
			IdentifierSingletonObject.m_Helper.Add("reshacker");
			IdentifierSingletonObject.m_Helper.Add("ImportREC");
			IdentifierSingletonObject.m_Helper.Add("IMMUNITYDEBUGGER");
			IdentifierSingletonObject.m_Helper.Add("MegaDumper");
			IdentifierSingletonObject.m_Setter.Add("OLLYDBG");
			IdentifierSingletonObject.m_Setter.Add("ida");
			IdentifierSingletonObject.m_Setter.Add("disassembly");
			IdentifierSingletonObject.m_Setter.Add("scylla");
			IdentifierSingletonObject.m_Setter.Add("Debug");
			IdentifierSingletonObject.m_Setter.Add("[CPU");
			IdentifierSingletonObject.m_Setter.Add("Immunity");
			IdentifierSingletonObject.m_Setter.Add("WinDbg");
			IdentifierSingletonObject.m_Setter.Add("x32dbg");
			IdentifierSingletonObject.m_Setter.Add("x64dbg");
			IdentifierSingletonObject.m_Setter.Add("Import reconstructor");
			IdentifierSingletonObject.m_Setter.Add("MegaDumper");
			IdentifierSingletonObject.m_Setter.Add("MegaDumper 1.0 by CodeCracker / SnD");
			return 0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000024D4 File Offset: 0x000006D4
		public IdentifierSingletonObject()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002AF6 File Offset: 0x00000CF6
		static IdentifierSingletonObject()
		{
			AdvisorConnectionAttribute.CancelComposer();
			IdentifierSingletonObject.m_Helper = new HashSet<string>();
			IdentifierSingletonObject.m_Setter = new HashSet<string>();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002B11 File Offset: 0x00000D11
		internal static bool CustomizeDefinition()
		{
			return IdentifierSingletonObject.TestDefinition == null;
		}

		// Token: 0x04000061 RID: 97
		private static HashSet<string> m_Helper;

		// Token: 0x04000062 RID: 98
		private static HashSet<string> m_Setter;

		// Token: 0x04000063 RID: 99
		private static object TestDefinition;
	}
}
