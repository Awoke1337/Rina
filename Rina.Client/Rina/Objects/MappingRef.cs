using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Rina.Authentication;
using Rina.Client.Attributes;
using Rina.Client.Exceptions;
using Rina.Dispatcher;
using Rina.Structs;

namespace Rina.Objects
{
	// Token: 0x02000034 RID: 52
	internal class MappingRef
	{
		// Token: 0x0600018E RID: 398 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public static void LoginReader(string param, params string[] Arguments)
		{
			ProductReaderStructBuilder._BridgeIdentifier._Advisor.Text = RegistryReader.DisableRule(param, Arguments);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000FCC8 File Offset: 0x0000DEC8
		public static void SetReader(long reference)
		{
			if (reference >= 0L && reference <= 100L)
			{
				ProductReaderStructBuilder._BridgeIdentifier._Tag.Value = Convert.ToInt32(reference);
				ProductReaderStructBuilder._BridgeIdentifier.attr.Text = RegistryReader.DisableRule("COMPLETEPROGRESS", new object[]
				{
					reference
				});
				return;
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000FD2C File Offset: 0x0000DF2C
		public static void AwakeReader(long first_end, double cust)
		{
			if (first_end >= 0L && first_end <= 100L)
			{
				ProductReaderStructBuilder._BridgeIdentifier.m_Mock.Value = Convert.ToInt32(first_end);
				ProductReaderStructBuilder._BridgeIdentifier.configuration.Text = RegistryReader.DisableRule("CURRENTPROGRESS", new object[]
				{
					first_end,
					cust.ToString("0.00")
				});
				return;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000FDA0 File Offset: 0x0000DFA0
		public static bool CustomizeReader(string init, string attr, long length_dir)
		{
			foreach (ProductReaderStructBuilder.DicConnectionAttribute dicConnectionAttribute in ProductReaderStructBuilder.m_BaseIdentifier)
			{
				if (dicConnectionAttribute.singletonReader == init && dicConnectionAttribute._AnnotationReader == length_dir && dicConnectionAttribute.m_RuleReader == attr)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000FE18 File Offset: 0x0000E018
		public static int InvokeReader(string res, string b, long long_0)
		{
			using (List<ProductReaderStructBuilder.RepositoryIdentifier>.Enumerator enumerator = ProductReaderStructBuilder.dispatcherIdentifier.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ProductReaderStructBuilder.RepositoryIdentifier repositoryIdentifier = enumerator.Current;
					if (res == repositoryIdentifier.queueIdentifier && repositoryIdentifier.procIdentifier == long_0 && repositoryIdentifier.valueIdentifier == b)
					{
						return 1;
					}
				}
				return 0;
			}
			int result;
			return result;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00003148 File Offset: 0x00001348
		public static int CreateReader(string i, string cont, long helper)
		{
			return MappingRef.InvokeReader(MappingRef.FlushReader(i + "\\cleo\\" + cont), MappingRef.CalcReader(i + "\\cleo\\" + cont), helper);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000FE90 File Offset: 0x0000E090
		public static string FlushReader(string value)
		{
			if (value == string.Empty)
			{
				return string.Empty;
			}
			Prototype prototype = new Prototype();
			string text = string.Empty;
			FileStream fileStream = new FileStream(value, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 16777216);
			foreach (byte b in prototype.ComputeHash(fileStream))
			{
				text += b.ToString("x2").ToLower();
			}
			fileStream.Flush();
			fileStream.Close();
			fileStream.Dispose();
			prototype.Dispose();
			return text;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000FF1C File Offset: 0x0000E11C
		public static string CalcReader(string res)
		{
			string result;
			using (FileStream fileStream = new FileStream(res, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				result = BitConverter.ToString(new SHA256Managed().ComputeHash(fileStream)).Replace("-", string.Empty).ToLower();
			}
			return result;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00003172 File Offset: 0x00001372
		public static void PrepareReader()
		{
			ProductReaderStructBuilder._BridgeIdentifier.Hide();
			Dispatcher dispatcher = new Dispatcher();
			dispatcher.Show();
			dispatcher.BringToFront();
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000024D4 File Offset: 0x000006D4
		public MappingRef()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000318E File Offset: 0x0000138E
		internal static bool ResolveOrder()
		{
			return MappingRef.InvokeOrder == null;
		}

		// Token: 0x04000102 RID: 258
		internal static object InvokeOrder;
	}
}
