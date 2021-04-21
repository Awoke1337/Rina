using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Rina.Client.Attributes;

namespace Costura
{
	// Token: 0x02000066 RID: 102
	[CompilerGenerated]
	internal static class AssemblyLoader
	{
		// Token: 0x06000272 RID: 626 RVA: 0x0000367E File Offset: 0x0000187E
		private static string CultureToString(CultureInfo culture)
		{
			if (culture != null)
			{
				return culture.Name;
			}
			return "";
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00015520 File Offset: 0x00013720
		private static Assembly ReadExistingAssembly(AssemblyName name)
		{
			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				AssemblyName name2 = assembly.GetName();
				if (string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(AssemblyLoader.CultureToString(name2.CultureInfo), AssemblyLoader.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					return assembly;
				}
			}
			return null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00015588 File Offset: 0x00013788
		private static void CopyTo(Stream source, Stream destination)
		{
			byte[] array = new byte[81920];
			int count;
			while ((count = source.Read(array, 0, array.Length)) != 0)
			{
				destination.Write(array, 0, count);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000155BC File Offset: 0x000137BC
		private static Stream LoadStream(string fullName)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (fullName.EndsWith(".compressed"))
			{
				Stream result;
				using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(fullName))
				{
					using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
					{
						MemoryStream memoryStream = new MemoryStream();
						AssemblyLoader.CopyTo(deflateStream, memoryStream);
						memoryStream.Position = 0L;
						result = memoryStream;
					}
				}
				return result;
			}
			return executingAssembly.GetManifestResourceStream(fullName);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0001564C File Offset: 0x0001384C
		private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
		{
			string fullName;
			if (resourceNames.TryGetValue(name, out fullName))
			{
				return AssemblyLoader.LoadStream(fullName);
			}
			return null;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0001566C File Offset: 0x0001386C
		private static byte[] ReadStream(Stream stream)
		{
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00015694 File Offset: 0x00013894
		private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
		{
			string text = requestedAssemblyName.Name.ToLowerInvariant();
			if (requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name))
			{
				text = requestedAssemblyName.CultureInfo.Name + "." + text;
			}
			byte[] rawAssembly;
			using (Stream stream = AssemblyLoader.LoadStream(assemblyNames, text))
			{
				if (stream == null)
				{
					return null;
				}
				rawAssembly = AssemblyLoader.ReadStream(stream);
			}
			using (Stream stream2 = AssemblyLoader.LoadStream(symbolNames, text))
			{
				if (stream2 != null)
				{
					byte[] rawSymbolStore = AssemblyLoader.ReadStream(stream2);
					return Assembly.Load(rawAssembly, rawSymbolStore);
				}
			}
			return Assembly.Load(rawAssembly);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00015754 File Offset: 0x00013954
		public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
		{
			object obj = AssemblyLoader.nullCacheLock;
			Assembly result;
			lock (obj)
			{
				if (!AssemblyLoader.nullCache.ContainsKey(e.Name))
				{
					goto IL_34;
				}
				result = null;
			}
			return result;
			IL_34:
			AssemblyName assemblyName = new AssemblyName(e.Name);
			Assembly assembly = AssemblyLoader.ReadExistingAssembly(assemblyName);
			if (assembly != null)
			{
				return assembly;
			}
			assembly = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName);
			if (assembly == null)
			{
				obj = AssemblyLoader.nullCacheLock;
				lock (obj)
				{
					AssemblyLoader.nullCache[e.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00015834 File Offset: 0x00013A34
		static AssemblyLoader()
		{
			AdvisorConnectionAttribute.CancelComposer();
			AssemblyLoader.nullCacheLock = new object();
			AssemblyLoader.nullCache = new Dictionary<string, bool>();
			AssemblyLoader.assemblyNames = new Dictionary<string, string>();
			AssemblyLoader.symbolNames = new Dictionary<string, string>();
			AssemblyLoader.assemblyNames.Add("costura", "costura.costura.dll.compressed");
			AssemblyLoader.assemblyNames.Add("discordrpc", "costura.discordrpc.dll.compressed");
			AssemblyLoader.symbolNames.Add("discordrpc", "costura.discordrpc.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("metroframework.design", "costura.metroframework.design.dll.compressed");
			AssemblyLoader.assemblyNames.Add("metroframework", "costura.metroframework.dll.compressed");
			AssemblyLoader.assemblyNames.Add("metroframework.fonts", "costura.metroframework.fonts.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.management.infrastructure", "costura.microsoft.management.infrastructure.dll.compressed");
			AssemblyLoader.assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.management.automation", "costura.system.management.automation.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.principal.windows", "costura.system.security.principal.windows.dll.compressed");
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000368F File Offset: 0x0000188F
		public static void Attach()
		{
			if (Interlocked.Exchange(ref AssemblyLoader.isAttached, 1) == 1)
			{
				return;
			}
			AppDomain.CurrentDomain.AssemblyResolve += AssemblyLoader.ResolveAssembly;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000036B6 File Offset: 0x000018B6
		internal static bool InstantiateStruct()
		{
			return AssemblyLoader.StopStruct == null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002BF0 File Offset: 0x00000DF0
		internal static void VerifyStruct()
		{
		}

		// Token: 0x040001D8 RID: 472
		private static object nullCacheLock;

		// Token: 0x040001D9 RID: 473
		private static Dictionary<string, bool> nullCache;

		// Token: 0x040001DA RID: 474
		private static Dictionary<string, string> assemblyNames;

		// Token: 0x040001DB RID: 475
		private static Dictionary<string, string> symbolNames;

		// Token: 0x040001DC RID: 476
		private static int isAttached;

		// Token: 0x040001DD RID: 477
		internal static AssemblyLoader StopStruct;
	}
}
