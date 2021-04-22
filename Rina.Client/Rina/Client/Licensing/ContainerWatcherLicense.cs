using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using Rina.Client.Attributes;

namespace Rina.Client.Licensing
{
	// Token: 0x0200001D RID: 29
	internal class ContainerWatcherLicense
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000029A8 File Offset: 0x00000BA8
		// (set) Token: 0x06000076 RID: 118 RVA: 0x000029B0 File Offset: 0x00000BB0
		public string DisplayName { get; private set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000029B9 File Offset: 0x00000BB9
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000029C1 File Offset: 0x00000BC1
		public string Name { get; private set; }

		// Token: 0x06000079 RID: 121 RVA: 0x000029CA File Offset: 0x00000BCA
		[CompilerGenerated]
		public string VerifyPrototype()
		{
			return this._Predicate;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000029D2 File Offset: 0x00000BD2
		[CompilerGenerated]
		private void PopPrototype(string def)
		{
			this._Predicate = def;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000029DB File Offset: 0x00000BDB
		[CompilerGenerated]
		public FileInfo DisablePrototype()
		{
			return this.specification;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000029E3 File Offset: 0x00000BE3
		[CompilerGenerated]
		private void EnablePrototype(FileInfo spec)
		{
			this.specification = spec;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000029EC File Offset: 0x00000BEC
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000029F4 File Offset: 0x00000BF4
		public FileVersionInfo Version { get; private set; }

		// Token: 0x0600007F RID: 127 RVA: 0x000056D4 File Offset: 0x000038D4
		public ContainerWatcherLicense(ServiceController asset)
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
			this.Name = asset.ServiceName.ToLower();
			this.DisplayName = asset.DisplayName.ToLower();
			try
			{
				string name = "SYSTEM\\CurrentControlSet\\Services\\" + asset.ServiceName;
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
				string name2 = registryKey.GetValue("ImagePath").ToString();
				registryKey.Close();
				this.PopPrototype(Environment.ExpandEnvironmentVariables(name2).ToLower());
				Match match = ContainerWatcherLicense._Resolver.Match(this.VerifyPrototype());
				if (match.Success)
				{
					string text = match.Groups["name"].Value;
					if (!File.Exists(text))
					{
						text += ".exe";
					}
					if (File.Exists(text))
					{
						this.EnablePrototype(new FileInfo(text));
						if (this.DisablePrototype() != null && this.DisablePrototype().Exists)
						{
							this.Version = FileVersionInfo.GetVersionInfo(text);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000057E0 File Offset: 0x000039E0
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("{0} ({1})", this.DisplayName, this.Name);
			if (this.DisablePrototype() != null)
			{
				if (this.DisablePrototype() != null)
				{
					stringBuilder.AppendFormat(" - {0}", this.DisablePrototype().ToString());
				}
				if (this.Version != null)
				{
					stringBuilder.AppendFormat(" (v{0})", this.Version.ProductVersion);
				}
			}
			else
			{
				stringBuilder.AppendFormat(" - {0}", this.VerifyPrototype());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000029FD File Offset: 0x00000BFD
		static ContainerWatcherLicense()
		{
			AdvisorConnectionAttribute.CancelComposer();
			ContainerWatcherLicense._Resolver = new Regex("((?<name>[A-Z]:.+?(\\.exe|\\Z))|(?:\"(?<name>.+?)\"))", RegexOptions.IgnoreCase);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002A14 File Offset: 0x00000C14
		internal static bool LogoutDefinition()
		{
			return ContainerWatcherLicense.RunDefinition == null;
		}

		// Token: 0x04000040 RID: 64
		private static Regex _Resolver;

		// Token: 0x04000041 RID: 65
		[CompilerGenerated]
		private string _Map;

		// Token: 0x04000042 RID: 66
		[CompilerGenerated]
		private string m_Serializer;

		// Token: 0x04000043 RID: 67
		[CompilerGenerated]
		private string _Predicate;

		// Token: 0x04000044 RID: 68
		[CompilerGenerated]
		private FileInfo specification;

		// Token: 0x04000045 RID: 69
		[CompilerGenerated]
		private FileVersionInfo m_Manager;

		// Token: 0x04000046 RID: 70
		internal static object RunDefinition;
	}
}
