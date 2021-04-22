using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Rina.Client.Attributes;
using Rina.Client.Classes;
using Rina.Client.Exceptions;
using Rina.Client.Readers;
using Rina.Client.Records;
using Rina.Dispatcher;
using Rina.Maps;
using Rina.Objects;
using Rina.Structs;

namespace Rina.Database
{
	// Token: 0x0200003B RID: 59
	internal class MapperRef
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x00010390 File Offset: 0x0000E590
		public static string LogoutReader()
		{
			return string.Concat(new string[]
			{
				Environment.ProcessorCount.ToString(),
				"/",
				Environment.MachineName,
				"/",
				Environment.UserDomainName,
				"\\",
				Environment.UserName,
				"/",
				Environment.GetLogicalDrives().Length.ToString()
			});
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000032CC File Offset: 0x000014CC
		public static int UpdateReader(int assetoffset, int indexOfcaller)
		{
			return (assetoffset % indexOfcaller + indexOfcaller) % indexOfcaller;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00010408 File Offset: 0x0000E608
		public static string CalculateReader(object last)
		{
			object[] array = TaskReader.TestRule(14, new object[]
			{
				last
			}, null);
			return (string)array[0];
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00010440 File Offset: 0x0000E640
		protected static string PatchReader()
		{
			object[] selection = new object[0];
			object[] array = TaskReader.TestRule(15, selection, null);
			return (string)array[0];
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00010470 File Offset: 0x0000E670
		public string ResolveReader()
		{
			Random random = new Random();
			string text = "";
			for (int i = 1; i < 20; i++)
			{
				text += random.Next(0, 9).ToString();
			}
			return text;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000104B0 File Offset: 0x0000E6B0
		public void CancelReader(string setup)
		{
			TaskReader.TestRule(16, new object[]
			{
				setup
			}, this);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000104E0 File Offset: 0x0000E6E0
		public void ViewReader(int indexOf_v)
		{
			TaskReader.TestRule(17, new object[]
			{
				indexOf_v
			}, this);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00010518 File Offset: 0x0000E718
		public void IncludeReader()
		{
			try
			{
				using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\\\SAMP", true))
				{
					if (registryKey == null)
					{
						Registry.CurrentUser.CreateSubKey("Software\\\\SAMP");
						this.IncludeReader();
					}
					else
					{
						object value = registryKey.GetValue(MapperWatcherClass.VerifyRule(43, "gta_sa_exe"));
						if (value != null)
						{
							MapperRef.fieldRef = value.ToString();
						}
						else
						{
							registryKey.SetValue(MapperWatcherClass.VerifyRule(43, "gta_sa_exe"), "NULL");
							registryKey.SetValue("PlayerName", "NULL");
						}
						MapperRef.fieldRef = MapperRef.fieldRef.Replace("\\gta_sa.exe", "");
						RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						RegistryKey registryKey3 = registryKey2.OpenSubKey("Software\\Microsoft\\gameyr", true);
						if (registryKey3 == null)
						{
							registryKey3 = registryKey2.CreateSubKey("Software\\Microsoft\\gameyr");
						}
						if (registryKey3.GetValue("serial") == null)
						{
							registryKey3.SetValue("serial", this.ResolveReader());
						}
						else
						{
							MapperRef.broadcasterRef = registryKey3.GetValue("serial").ToString();
						}
						if (registryKey3.GetValue("file") == null)
						{
							registryKey3.SetValue("file", MapperRef.fieldRef);
						}
						if (registryKey3.GetValue("name") == null)
						{
							MapperRef.m_AdapterRef = "Ad_Soyad";
						}
						else
						{
							MapperRef.m_AdapterRef = (string)registryKey3.GetValue("name");
						}
						if (registryKey2.OpenSubKey("Software\\WOW6432Node\\Microsoft\\ASP.NET", true) == null)
						{
							registryKey3 = registryKey2.CreateSubKey("Software\\WOW6432Node\\Microsoft\\ASP.NET");
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000106C8 File Offset: 0x0000E8C8
		private static bool RunReader(Exception spec)
		{
			int num = Marshal.GetHRForException(spec) & 65535;
			return num == 32 || num == 33;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000106F0 File Offset: 0x0000E8F0
		public static bool FindReader(string spec)
		{
			bool result;
			try
			{
				using (FileStream fileStream = File.Open(spec, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
				{
					if (fileStream != null)
					{
						fileStream.Close();
					}
				}
				return true;
			}
			catch (IOException spec2)
			{
				if (!MapperRef.RunReader(spec2))
				{
					return true;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0001074C File Offset: 0x0000E94C
		public static string ConcatReader(object res)
		{
			object[] array = TaskReader.TestRule(18, new object[]
			{
				res
			}, null);
			return (string)array[0];
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00010784 File Offset: 0x0000E984
		public static int MapReader()
		{
			object[] selection = new object[0];
			object[] array = TaskReader.TestRule(19, selection, null);
			return (int)array[0];
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000107B4 File Offset: 0x0000E9B4
		public static int ReadReader()
		{
			object[] selection = new object[0];
			object[] array = TaskReader.TestRule(20, selection, null);
			return (int)array[0];
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000107E4 File Offset: 0x0000E9E4
		public void ForgotReader(string last)
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey("Software\\Microsoft\\gameyr", true);
			if (registryKey2 == null)
			{
				registryKey2 = registryKey.CreateSubKey("Software\\Microsoft\\gameyr");
			}
			registryKey2.SetValue("name", last);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000032D5 File Offset: 0x000014D5
		public static string RevertReader()
		{
			return MapperRef.broadcasterRef;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0001082C File Offset: 0x0000EA2C
		public static string QuerySingleton()
		{
			string text = string.Empty;
			try
			{
				foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("Select * FROM Win32_NetworkAdapterConfiguration").Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					object obj = managementObject["MacAddress"];
					if (obj != null)
					{
						if (text == string.Empty)
						{
							text = obj.ToString();
						}
						managementObject.Dispose();
					}
				}
				text = text.Replace(":", "");
			}
			catch
			{
				text = "FAILED";
			}
			return text;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000032DC File Offset: 0x000014DC
		public static string AddSingleton()
		{
			return MapperRef.CalculateReader(ProductReaderStructBuilder.eventIdentifier);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000032E8 File Offset: 0x000014E8
		public static string ExcludeSingleton()
		{
			return null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000108DC File Offset: 0x0000EADC
		public bool InstantiateSingleton(string info)
		{
			try
			{
				HttpWebRequest httpWebRequest = WebRequest.Create(info) as HttpWebRequest;
				httpWebRequest.Timeout = 5000;
				httpWebRequest.Method = "HEAD";
				int statusCode = (int)(httpWebRequest.GetResponse() as HttpWebResponse).StatusCode;
				if (statusCode >= 100 && statusCode < 400)
				{
					return true;
				}
				if (statusCode >= 500 && statusCode <= 510)
				{
					return false;
				}
			}
			catch (WebException ex)
			{
				if (ex.Status == WebExceptionStatus.ProtocolError)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00010964 File Offset: 0x0000EB64
		public static string InterruptSingleton()
		{
			string result = string.Empty;
			try
			{
				foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("Select * FROM WIN32_Processor").Get())
				{
					result = ((ManagementObject)managementBaseObject)["ProcessorId"].ToString();
				}
			}
			catch
			{
				result = "FAILED";
			}
			return result;
		}

		// Token: 0x060001C7 RID: 455
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetModuleHandle(string i);

		// Token: 0x060001C8 RID: 456 RVA: 0x000032EB File Offset: 0x000014EB
		public static string StartSingleton()
		{
			return MapperRef.PublishSingleton(8);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000109E8 File Offset: 0x0000EBE8
		public static string PublishSingleton(int idx_param)
		{
			MapperRef.<>c__DisplayClass38_0 CS$<>8__locals1 = new MapperRef.<>c__DisplayClass38_0();
			CS$<>8__locals1.tokenIdentifier = MapperRef.m_QueueRef;
			string result = new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", idx_param).Select(new Func<string, char>(CS$<>8__locals1.StartRule)).ToArray<char>());
			MapperRef.m_QueueRef = CS$<>8__locals1.tokenIdentifier;
			return result;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00010A38 File Offset: 0x0000EC38
		public static string ResetSingleton(int instance)
		{
			MapperRef.<>c__DisplayClass39_0 CS$<>8__locals1 = new MapperRef.<>c__DisplayClass39_0();
			CS$<>8__locals1.taskIdentifier = new Random();
			return new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", instance).Select(new Func<string, char>(CS$<>8__locals1.PublishRule)).ToArray<char>());
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00010A7C File Offset: 0x0000EC7C
		public static bool SelectSingleton()
		{
			bool result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					using (webClient.OpenRead("http://clients3.google.com/generate_204"))
					{
						result = true;
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00010AE4 File Offset: 0x0000ECE4
		public static string InitSingleton(OperatingSystem item)
		{
			string text = item.Version.Major.ToString() + "." + item.Version.Minor.ToString();
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 3236114161U)
			{
				if (num <= 3185781304U)
				{
					if (num != 2793341610U)
					{
						if (num == 3185781304U)
						{
							if (text == "5.2")
							{
								return "Server 2003 R2/Server 2003/XP 64-Bit Edition";
							}
						}
					}
					else if (text == "10.0")
					{
						return "10/Server 2016";
					}
				}
				else if (num != 3219336542U)
				{
					if (num == 3236114161U)
					{
						if (text == "5.1")
						{
							return "XP";
						}
					}
				}
				else if (text == "5.0")
				{
					return "2000";
				}
			}
			else if (num > 4235161167U)
			{
				if (num != 4251938786U)
				{
					if (num == 4268716405U)
					{
						if (text == "6.2")
						{
							return "8/Server 2012";
						}
					}
				}
				else if (text == "6.3")
				{
					return "8.1/Server 2012 R2";
				}
			}
			else if (num != 4218383548U)
			{
				if (num == 4235161167U)
				{
					if (text == "6.0")
					{
						return "Server 2008/Vista";
					}
				}
			}
			else if (text == "6.1")
			{
				return "7/Server 2008 R2";
			}
			return "Unknown";
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00010C38 File Offset: 0x0000EE38
		public static string PrintSingleton()
		{
			string result = "";
			try
			{
				foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard").Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					try
					{
						result = managementObject.GetPropertyValue("SerialNumber").ToString();
					}
					catch
					{
						result = "FAILED";
					}
				}
			}
			catch
			{
				result = "FAILED";
			}
			return result;
		}

		// Token: 0x060001CE RID: 462
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool Wow64DisableWow64FsRedirection(ref IntPtr config);

		// Token: 0x060001CF RID: 463
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool Wow64RevertWow64FsRedirection(IntPtr ident);

		// Token: 0x060001D0 RID: 464 RVA: 0x00010CD4 File Offset: 0x0000EED4
		public static bool MoveSingleton(string def)
		{
			IntPtr ident = 0;
			MapperRef.Wow64DisableWow64FsRedirection(ref ident);
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				Verb = "runas",
				FileName = "CMD.exe",
				Arguments = "/C qwinsta " + def
			};
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			process.WaitForExit();
			string text = process.StandardOutput.ReadToEnd();
			MapperRef.Wow64RevertWow64FsRedirection(ident);
			return text.Contains(def);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00010D7C File Offset: 0x0000EF7C
		public static bool SearchSingleton(string value)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				Verb = "runas",
				FileName = "CMD.exe",
				Arguments = "/C echo " + value
			};
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			process.WaitForExit();
			return process.StandardOutput.ReadToEnd().Contains(value);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00010E10 File Offset: 0x0000F010
		public static string ConnectSingleton()
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "CMD.exe",
				Arguments = "/C wmic csproduct get UUID"
			};
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			process.WaitForExit();
			return process.StandardOutput.ReadToEnd();
		}

		// Token: 0x060001D3 RID: 467
		[DllImport("ntdll.dll")]
		public static extern uint RtlAdjustPrivilege(int start_res, bool readselection, bool insertfilter, out bool v2);

		// Token: 0x060001D4 RID: 468
		[DllImport("ntdll.dll")]
		public static extern uint NtRaiseHardError(uint row_instance, uint map_ID, uint filter_ID, IntPtr init2, uint next_instance3, out uint var14);

		// Token: 0x060001D5 RID: 469 RVA: 0x00010E80 File Offset: 0x0000F080
		public static void PostSingleton()
		{
			bool flag;
			MapperRef.RtlAdjustPrivilege(19, true, false, out flag);
			uint num;
			MapperRef.NtRaiseHardError(3221225506U, 0U, 0U, IntPtr.Zero, 6U, out num);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00010EB0 File Offset: 0x0000F0B0
		public static string OrderSingleton()
		{
			OperatingSystem osversion = Environment.OSVersion;
			Version version = osversion.Version;
			string text = "";
			if (osversion.Platform == PlatformID.Win32Windows)
			{
				int minor = version.Minor;
				if (minor != 0)
				{
					if (minor != 10)
					{
						if (minor == 90)
						{
							text = "Me";
						}
					}
					else if (!(version.Revision.ToString() == "2222A"))
					{
						text = "98";
					}
					else
					{
						text = "98SE";
					}
				}
				else
				{
					text = "95";
				}
			}
			else if (osversion.Platform == PlatformID.Win32NT)
			{
				switch (version.Major)
				{
				case 3:
					text = "NT 3.51";
					break;
				case 4:
					text = "NT 4.0";
					break;
				case 5:
					if (version.Minor == 0)
					{
						text = "2000";
					}
					else
					{
						text = "XP";
					}
					break;
				case 6:
					if (version.Minor == 0)
					{
						text = "Vista";
					}
					else if (version.Minor == 1)
					{
						text = "7";
					}
					else if (version.Minor == 2)
					{
						text = "8";
					}
					else
					{
						text = "8.1";
					}
					break;
				case 10:
					text = "10";
					break;
				}
			}
			if (text != "")
			{
				text = "Windows " + text;
				if (osversion.ServicePack != "")
				{
					text = text + " " + osversion.ServicePack;
				}
			}
			return text;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0001101C File Offset: 0x0000F21C
		public static string AssetSingleton()
		{
			string text = "";
			try
			{
				foreach (ManagementBaseObject managementBaseObject in new ManagementClass("Win32_LogicalDisk").GetInstances())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					text += Convert.ToString(managementObject["VolumeSerialNumber"]);
				}
			}
			catch
			{
				text = "FAILED";
			}
			return text;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000110A8 File Offset: 0x0000F2A8
		public static string[] DefineSingleton(string first, string visitor, SearchOption dic)
		{
			MapperRef.<>c__DisplayClass53_0 CS$<>8__locals1 = new MapperRef.<>c__DisplayClass53_0();
			CS$<>8__locals1.string_0 = first;
			CS$<>8__locals1.m_DefinitionIdentifier = dic;
			return visitor.Split(new char[]
			{
				'|'
			}).SelectMany(new Func<string, IEnumerable<string>>(CS$<>8__locals1.ResetRule)).ToArray<string>();
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000110F0 File Offset: 0x0000F2F0
		public static bool CollectSingleton(string config)
		{
			if (!string.IsNullOrEmpty(config) && config.Contains("_"))
			{
				int num = 0;
				int length = config.Length;
				while (num != length)
				{
					if (num == 0 && (config[num] < 'A' || config[num] > 'Z'))
					{
						return false;
					}
					if (num != 0 && num < length && config[num] == '_' && (config[num + 1] < 'A' || config[num + 1] > 'Z'))
					{
						return false;
					}
					if ((config[num] < 'A' || config[num] > 'Z') && (config[num] < 'a' || config[num] > 'z') && config[num] != '_' && config[num] != '.')
					{
						return false;
					}
					num++;
				}
				return true;
			}
			return false;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000111C8 File Offset: 0x0000F3C8
		public static string ListSingleton(string key)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				result = BitConverter.ToString(md.ComputeHash(Encoding.UTF8.GetBytes(key))).Replace("-", string.Empty).ToLower();
			}
			return result;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00011224 File Offset: 0x0000F424
		public static string RestartSingleton(object task)
		{
			object[] array = TaskReader.TestRule(21, new object[]
			{
				task
			}, null);
			return (string)array[0];
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0001125C File Offset: 0x0000F45C
		public static string ReflectSingleton(string key)
		{
			SHA256 sha = SHA256.Create();
			byte[] counter = sha.ComputeHash(Encoding.ASCII.GetBytes(Dispatcher.m_Base[32].Substring(8)));
			byte[] role = new byte[16];
			sha.Clear();
			sha.Dispose();
			return MapperRef.RemoveSingleton(key, counter, role);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000112B0 File Offset: 0x0000F4B0
		public static string InsertSingleton(string i)
		{
			SHA256 sha = SHA256.Create();
			byte[] key = sha.ComputeHash(Encoding.ASCII.GetBytes(Dispatcher.m_Base[32].Substring(8)));
			byte[] iv = new byte[16];
			sha.Clear();
			sha.Dispose();
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = key;
			aes.IV = iv;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			string result = string.Empty;
			try
			{
				byte[] array = Convert.FromBase64String(i);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				byte[] array2 = memoryStream.ToArray();
				result = Encoding.ASCII.GetString(array2, 0, array2.Length);
			}
			finally
			{
				memoryStream.Close();
				cryptoStream.Close();
			}
			return result;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00011394 File Offset: 0x0000F594
		public static string RemoveSingleton(string init, Array counter, byte[] role)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			byte[] array = new byte[32];
			Array.Copy(counter, 0, array, 0, 32);
			aes.Key = array;
			aes.IV = role;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] bytes = Encoding.ASCII.GetBytes(init);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array2 = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return Convert.ToBase64String(array2, 0, array2.Length);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00011424 File Offset: 0x0000F624
		private static SecureString RegisterSingleton(string first)
		{
			if (first != null)
			{
				SecureString secureString = new SecureString();
				foreach (char c in first)
				{
					secureString.AppendChar(c);
				}
				secureString.MakeReadOnly();
				return secureString;
			}
			throw new ArgumentNullException("");
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00011470 File Offset: 0x0000F670
		public static string WriteSingleton(int initcount = 0)
		{
			object[] array = TaskReader.TestRule(22, new object[]
			{
				initcount
			}, null);
			return (string)array[0];
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000114B0 File Offset: 0x0000F6B0
		public static string ManageSingleton()
		{
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(MapperWatcherClass.VerifyRule(64, "Select * from Win32_ComputerSystem")))
				{
					using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
					{
						using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection.GetEnumerator())
						{
							if (enumerator.MoveNext())
							{
								return enumerator.Current[MapperWatcherClass.VerifyRule(62, "Model")].ToString().ToUpperInvariant();
							}
						}
					}
				}
			}
			catch
			{
			}
			return "FAILED";
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00011570 File Offset: 0x0000F770
		public static string CompareSingleton()
		{
			try
			{
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(MapperWatcherClass.VerifyRule(64, "Select * from Win32_ComputerSystem")).Get().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						return enumerator.Current[MapperWatcherClass.VerifyRule(63, "Manufacturer")].ToString().ToLower();
					}
				}
			}
			catch
			{
				return "FAILED";
			}
			return null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000115FC File Offset: 0x0000F7FC
		public static bool ComputeSingleton()
		{
			if (MapperRef.GetModuleHandle("SbieDll.dll").ToInt32() != 0)
			{
				return true;
			}
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(MapperWatcherClass.VerifyRule(64, "Select * from Win32_ComputerSystem")))
				{
					using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
					{
						foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
						{
							string text = managementBaseObject[MapperWatcherClass.VerifyRule(63, "Manufacturer")].ToString().ToLower();
							if ((text == MapperWatcherClass.VerifyRule(65, "microsoft corporation") && managementBaseObject[MapperWatcherClass.VerifyRule(62, "Model")].ToString().ToUpperInvariant().Contains(MapperWatcherClass.VerifyRule(55, "VIRTUAL"))) || text.Contains(MapperWatcherClass.VerifyRule(56, "vmware")) || text.Contains(MapperWatcherClass.VerifyRule(57, "amazon")) || text.Contains(MapperWatcherClass.VerifyRule(58, "azure")) || text.Contains(MapperWatcherClass.VerifyRule(59, "google")) || text.Contains(MapperWatcherClass.VerifyRule(60, "xen")) || managementBaseObject[MapperWatcherClass.VerifyRule(62, "Model")].ToString() == MapperWatcherClass.VerifyRule(61, "VirtualBox"))
							{
								return true;
							}
						}
					}
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000117F0 File Offset: 0x0000F9F0
		public static SecureString Protect(string x)
		{
			MapperRef.<>c__DisplayClass65_0 CS$<>8__locals1 = new MapperRef.<>c__DisplayClass65_0();
			CS$<>8__locals1.structIdentifier = new SecureString();
			x.ToCharArray().ToList<char>().ForEach(new Action<char>(CS$<>8__locals1.SelectRule));
			CS$<>8__locals1.structIdentifier.MakeReadOnly();
			return CS$<>8__locals1.structIdentifier;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000032F3 File Offset: 0x000014F3
		public int SortSingleton()
		{
			return this.CallSingleton();
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0001183C File Offset: 0x0000FA3C
		public static string ChangeSingleton(string ident)
		{
			byte[] array = new byte[ident.Length / 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToByte(ident.Substring(i * 2, 2), 16);
			}
			return Encoding.Unicode.GetString(array);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00011884 File Offset: 0x0000FA84
		public static string LoginSingleton(string first)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in Encoding.Unicode.GetBytes(first))
			{
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000118D0 File Offset: 0x0000FAD0
		public static string SetSingleton(string var1)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte value in Encoding.Unicode.GetBytes(var1))
			{
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000032FB File Offset: 0x000014FB
		public static string AwakeSingleton(object i)
		{
			return new string(i.Where(new Func<char, bool>(MapperRef.<>c.productIdentifier.InitRule)).ToArray<char>());
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00011910 File Offset: 0x0000FB10
		public static string CustomizeSingleton(string i)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(i))
				{
					result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00011980 File Offset: 0x0000FB80
		public static void InvokeSingleton()
		{
			if (Dispatcher.MoveIdentifier() < ProductReaderStructBuilder.proxyIdentifier + 5L && ProductReaderStructBuilder.proxyIdentifier != 0L)
			{
				return;
			}
			new Thread(new ThreadStart(MapperRef.<>c.productIdentifier.PrintRule)).Start();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000119D4 File Offset: 0x0000FBD4
		public static void CreateSingleton(string reference)
		{
			try
			{
				using (StreamWriter streamWriter = File.AppendText("C:\\Rina_AC.log"))
				{
					streamWriter.WriteLine("[" + DateTime.Now.ToString("yyyy-MM-dd.HH:mm:ss") + "] " + reference);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00011A44 File Offset: 0x0000FC44
		public static void FlushSingleton()
		{
			object[] selection = new object[0];
			TaskReader.TestRule(23, selection, null);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00011A6C File Offset: 0x0000FC6C
		public static bool CalcSingleton()
		{
			object[] selection = new object[0];
			object[] array = TaskReader.TestRule(24, selection, null);
			return (bool)array[0];
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00011A9C File Offset: 0x0000FC9C
		public static string PrepareSingleton()
		{
			object[] selection = new object[0];
			object[] array = TaskReader.TestRule(25, selection, null);
			return (string)array[0];
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00011ACC File Offset: 0x0000FCCC
		public static string DeleteSingleton(string last)
		{
			List<string> list = Directory.GetFiles(last, "*.*", SearchOption.AllDirectories).OrderBy(new Func<string, string>(MapperRef.<>c.productIdentifier.CountRule)).ToList<string>();
			MD5 md = MD5.Create();
			for (int i = 0; i < list.Count; i++)
			{
				string text = list[i];
				string text2 = text.Substring(last.Length + 1);
				byte[] bytes = Encoding.UTF8.GetBytes(text2.ToLower());
				md.TransformBlock(bytes, 0, bytes.Length, bytes, 0);
				byte[] array = File.ReadAllBytes(text);
				if (i == list.Count - 1)
				{
					md.TransformFinalBlock(array, 0, array.Length);
				}
				else
				{
					md.TransformBlock(array, 0, array.Length, array, 0);
				}
			}
			return BitConverter.ToString(md.Hash).Replace("-", "").ToLower();
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00011BB4 File Offset: 0x0000FDB4
		private int CallSingleton()
		{
			MapperRef.<>c__DisplayClass78_0 CS$<>8__locals1;
			CS$<>8__locals1._WriterIdentifier = this;
			CS$<>8__locals1.expressionIdentifier = 0;
			try
			{
				MapperRef.<>c__DisplayClass78_1 CS$<>8__locals2 = new MapperRef.<>c__DisplayClass78_1();
				CS$<>8__locals2.m_CandidateIdentifier = "";
				string text = Registry.CurrentUser.OpenSubKey("SOFTWARE").OpenSubKey("SAMP").GetValue(MapperWatcherClass.VerifyRule(43, "gta_sa_exe")).ToString();
				text = text.Replace("\\gta_sa.exe", "");
				if (!MapperRef.fieldRef.Equals(text))
				{
					MapperRef.PatchSingleton(11);
					OrderVisitorException.TestReader("Oyun yolu açığı tespit edildiği için oyun ve client kapatılıyor! (c1)\n\nA: " + MapperRef.fieldRef + "\nB: " + text, "Rina Anti-Cheat");
				}
				Directory.GetDirectories(MapperRef.fieldRef);
				string[] files = Directory.GetFiles(MapperRef.fieldRef);
				this._ServiceRef = 0L;
				CS$<>8__locals1.expressionIdentifier = 0;
				CS$<>8__locals2.m_CandidateIdentifier = "";
				if (Directory.Exists("C:\\Recycler"))
				{
					using (IEnumerator<string> enumerator = Directory.EnumerateDirectories("C:\\Recycler", "hidefiles", SearchOption.AllDirectories).GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							string str = enumerator.Current;
							MapperRef.PatchSingleton(655);
							OrderVisitorException.TestReader("Gizlenmiş dosya bulundu. Gizli dosyaları kaldırmadan sunucuya erişemezsiniz.", "Rina Anti-Cheat");
							MapperRef.CreateSingleton("Hided Path: " + str);
							return 1;
						}
					}
				}
				if (Directory.Exists("C:\\Winmend~Folder~Hidden"))
				{
					MapperRef.PatchSingleton(655);
					OrderVisitorException.TestReader("Winmend Folder Hidden tespit edildi. Programı kaldırıp tekrar deneyiniz.", "Rina Anti-Cheat");
					MapperRef.CreateSingleton("Winmend detected.");
					return 1;
				}
				if (File.Exists(MapperRef.fieldRef + MapperWatcherClass.VerifyRule(29, "\\enbseries.ini")))
				{
					try
					{
						string text2 = File.ReadAllText(MapperRef.fieldRef + MapperWatcherClass.VerifyRule(29, "\\enbseries.ini"));
						if (!string.IsNullOrEmpty(text2) && (text2.Contains(MapperWatcherClass.VerifyRule(28, "EnableProxyLibrary") + "=1") || text2.Contains(MapperWatcherClass.VerifyRule(28, "EnableProxyLibrary") + "=true") || text2.Contains(MapperWatcherClass.VerifyRule(28, "EnableProxyLibrary") + "=TRUE") || text2.Contains(MapperWatcherClass.VerifyRule(28, "EnableProxyLibrary") + " = 1") || text2.Contains(MapperWatcherClass.VerifyRule(28, "EnableProxyLibrary") + " = true") || text2.Contains(MapperWatcherClass.VerifyRule(28, "EnableProxyLibrary") + " = TRUE")))
						{
							MapperRef.PatchSingleton(14);
							OrderVisitorException.TestReader("ENBSeries.ini içerisinde bulunan EnableProxyLibrary segmenti kapalı olmalıdır. (false veya 0)", "Rina Anti-Cheat");
							return 1;
						}
					}
					catch (Exception ex)
					{
						MapperRef.PatchSingleton(15);
						string str2 = "ENBSeries.ini çözümlenemedi.\n\n(";
						Exception ex2 = ex;
						OrderVisitorException.TestReader(str2 + ((ex2 != null) ? ex2.ToString() : null) + ")", "Rina Anti-Cheat");
						return 1;
					}
				}
				if (File.Exists(MapperRef.fieldRef + MapperWatcherClass.VerifyRule(30, "\\enblocal.ini")))
				{
					try
					{
						string text3 = File.ReadAllText(MapperRef.fieldRef + MapperWatcherClass.VerifyRule(30, "\\enblocal.ini"));
						if (!string.IsNullOrEmpty(text3) && (text3.Contains("EnableProxyLibrary=1") || text3.Contains("EnableProxyLibrary=true") || text3.Contains("EnableProxyLibrary=TRUE") || text3.Contains("EnableProxyLibrary = 1") || text3.Contains("EnableProxyLibrary = true") || text3.Contains("EnableProxyLibrary = TRUE")))
						{
							MapperRef.PatchSingleton(16);
							OrderVisitorException.TestReader("ENBLocal.ini içerisinde bulunan EnableProxyLibrary segmenti kapalı olmalıdır. (false veya 0)", "Rina Anti-Cheat");
							return 1;
						}
					}
					catch (Exception ex3)
					{
						MapperRef.PatchSingleton(17);
						string str3 = "ENBLocal.ini çözümlenemedi.\n\n(";
						Exception ex4 = ex3;
						OrderVisitorException.TestReader(str3 + ((ex4 != null) ? ex4.ToString() : null) + ")", "Rina Anti-Cheat");
						return 1;
					}
				}
				string[] array;
				if (Directory.Exists(MapperRef.fieldRef + "\\cleo"))
				{
					Directory.GetDirectories(MapperRef.fieldRef + "\\cleo");
					array = Directory.GetFiles(MapperRef.fieldRef + "\\cleo");
					for (int i = 0; i < array.Length; i++)
					{
						FileInfo fileInfo = new FileInfo(array[i]);
						new MapperRef();
						this._ServiceRef += fileInfo.Length;
						long length = fileInfo.Length;
						string name = fileInfo.Name;
						string text4 = Path.GetExtension(MapperRef.fieldRef + "\\cleo\\" + name);
						text4 = text4.ToUpper(new CultureInfo(MapperWatcherClass.VerifyRule(15, "en-US"), false));
						if (!text4.Contains(".TXT") && !text4.Contains(".FXT") && !text4.Contains(".DLL") && !text4.Contains(".INI") && MappingRef.CreateReader(MapperRef.fieldRef, name, length) == 0)
						{
							CS$<>8__locals2.m_CandidateIdentifier = CS$<>8__locals2.m_CandidateIdentifier + name + "\n";
							CS$<>8__locals1.expressionIdentifier++;
						}
					}
					if (CS$<>8__locals1.expressionIdentifier > 0)
					{
						MapperRef.PatchSingleton(18);
						OrderVisitorException.TestReader("İzinsiz CLEO bulundu.\n\n" + CS$<>8__locals2.m_CandidateIdentifier + "\nGTA-SA'nın kurulu olduğu klasör içerisinde bulunan CLEO dosyasından bu cleoları silerek sorunu çözebilirsiniz.", "Rina Anti-Cheat");
						return 1;
					}
				}
				string[] array2 = new string[]
				{
					"ANTTWEAKBAR.DLL",
					"SQLITE3.DLL",
					"DSOUND.DLL",
					"SAMPFUNCS.ASI",
					"ZMENU_HUDCOLOR.INI",
					"MOONLOADER.ASI",
					"M0D_S0BEIT_SA.INI",
					"MOD_SA.INI",
					"SPEEDO.PNG",
					"NEEDLE.PNG",
					"S0BEIT_ATHLON.INI"
				};
				array = files;
				for (int i = 0; i < array.Length; i++)
				{
					FileInfo fileInfo2 = new FileInfo(array[i]);
					string name2 = fileInfo2.Name;
					string fullName = fileInfo2.FullName;
					long length2 = fileInfo2.Length;
					if (!(name2 == "Thumbs.db") && !(name2 == "cleo.log"))
					{
						if (length2 != (long)ProductReaderStructBuilder._DicIdentifier)
						{
							if (length2 != (long)ProductReaderStructBuilder._SystemIdentifier)
							{
								if (name2.ToUpper(new CultureInfo(MapperWatcherClass.VerifyRule(15, "en-US"), false)).Contains(".ASI") || name2.ToUpper(new CultureInfo(MapperWatcherClass.VerifyRule(15, "en-US"), false)).Contains(".GTA"))
								{
									long length3 = new FileInfo(MapperRef.fieldRef + "\\" + name2).Length;
									if (!MappingRef.CustomizeReader(MappingRef.FlushReader(MapperRef.fieldRef + "\\" + name2), MappingRef.CalcReader(MapperRef.fieldRef + "\\" + name2), length3))
									{
										CS$<>8__locals2.m_CandidateIdentifier = CS$<>8__locals2.m_CandidateIdentifier + name2 + "\n";
										CS$<>8__locals1.expressionIdentifier++;
									}
								}
								if (name2.ToUpper(new CultureInfo(MapperWatcherClass.VerifyRule(15, "en-US"), false)) == "D3D9.DLL")
								{
									int num = 0;
									long length4 = new FileInfo(MapperRef.fieldRef + "\\" + name2).Length;
									foreach (ProductReaderStructBuilder.InvocationWatcherLicense invocationWatcherLicense in ProductReaderStructBuilder._ConfigIdentifier)
									{
										string a = MappingRef.FlushReader(MapperRef.fieldRef + "\\" + name2);
										string a2 = MappingRef.CalcReader(MapperRef.fieldRef + "\\" + name2);
										if (length4 == invocationWatcherLicense._ReaderReader && a == invocationWatcherLicense.refReader && a2 == invocationWatcherLicense._IdentifierReader)
										{
											num = 1;
											break;
										}
									}
									if (num == 0)
									{
										MapperRef.PatchSingleton(20);
										OrderVisitorException.TestReader("İzinsiz D3D9.dll bulundu.\n\nGTA-SA'nın kurulu olduğu klasör içerisinde bulunan D3D9.dll dosyasını silerek sorunu çözebilirsiniz.", "Rina Anti-Cheat");
										return 1;
									}
								}
								for (int j = 0; j < array2.Length; j++)
								{
									if (name2.ToUpper(new CultureInfo(MapperWatcherClass.VerifyRule(15, "en-US"), false)) == array2[j])
									{
										CS$<>8__locals2.m_CandidateIdentifier = CS$<>8__locals2.m_CandidateIdentifier + name2 + "\n";
										CS$<>8__locals1.expressionIdentifier++;
									}
								}
								goto IL_819;
							}
						}
						MapperRef.PatchSingleton(19);
						OrderVisitorException.TestReader("ANTTWEAKBAR ( " + name2 + " ) tespit edildi. Bu dosyayı silerek sorunu çözebilirsiniz.", "Rina Anti-Cheat");
						return 1;
					}
					IL_819:;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\mod_sa"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "mod_sa\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\nod_sa"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "nod_sa\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\moonloader"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "moonloader\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\RapidFire_Project_Attack"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "RapidFire_Project_Attack\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\EliteModSa"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "EliteModSa\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\Sobreit 0.3DL"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "Sobreit 0.3DL\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\OverLight Custom"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "OverLight Custom\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\OverLight"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "OverLight\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\Sobreit"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "Sobreit\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\Menyoo"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "Menyoo\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\OverLight_Mod"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "OverLight_Mod\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\glance_mod"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "glance_mod\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\RedEclipseMod"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "RedEclipseMod\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\StealingData"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "StealingData\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\BlueEclipseMod"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "BlueEclipseMod\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\CustomSAA2"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "CustomSAA2\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\LiquidMod"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "LiquidMod\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\H3X"))
				{
					CS$<>8__locals2.m_CandidateIdentifier += "H3X\n";
					CS$<>8__locals1.expressionIdentifier++;
				}
				CS$<>8__locals2.m_ComparatorIdentifier = new string[]
				{
					MapperWatcherClass.VerifyRule(16, "cs"),
					MapperWatcherClass.VerifyRule(17, "cleo"),
					MapperWatcherClass.VerifyRule(18, "ct"),
					MapperWatcherClass.VerifyRule(19, "scm"),
					MapperWatcherClass.VerifyRule(20, "cm"),
					MapperWatcherClass.VerifyRule(21, "col")
				};
				if (Directory.Exists(MapperRef.fieldRef + "\\modloader"))
				{
					MapperRef.<>c__DisplayClass78_2 CS$<>8__locals3 = new MapperRef.<>c__DisplayClass78_2();
					CS$<>8__locals3._InstanceIdentifier = CS$<>8__locals2;
					Directory.GetFiles(MapperRef.fieldRef + "\\modloader", "*.*").Where(new Func<string, bool>(CS$<>8__locals3._InstanceIdentifier.SearchRule)).ToArray<string>();
					this._RecordRef = 0;
					CS$<>8__locals3._InstanceIdentifier.StopRule(MapperRef.fieldRef + "\\modloader", 0, ref CS$<>8__locals1);
					for (int k = 0; k < 1; k++)
					{
						string[] directories = Directory.GetDirectories(MapperRef.fieldRef + "\\modloader");
						for (int l = 0; l < directories.Length; l++)
						{
							CS$<>8__locals3._InstanceIdentifier.StopRule(directories[l], 1, ref CS$<>8__locals1);
						}
						if (this._RecordRef != 0)
						{
							MapperRef.PatchSingleton(21);
							OrderVisitorException.TestReader("Modloader içine CLEO ve COL dosyaları koyamazsınız! (Tespit edilen: " + this._RecordRef.ToString() + " adet CLEO / COL)", "Rina Anti-Cheat");
							return 1;
						}
					}
					int num2 = 0;
					string str4 = "";
					CS$<>8__locals3._ConsumerIdentifier = new string[]
					{
						MapperWatcherClass.VerifyRule(22, "asi"),
						MapperWatcherClass.VerifyRule(23, "gta")
					};
					Directory.GetFiles(MapperRef.fieldRef + "\\modloader", "*.*").Where(new Func<string, bool>(CS$<>8__locals3.GetRule)).ToArray<string>();
					this._RecordRef = 0;
					CS$<>8__locals3.ConnectRule(MapperRef.fieldRef + "\\modloader", 0, ref CS$<>8__locals1);
					for (int m = 0; m < 1; m++)
					{
						string[] directories2 = Directory.GetDirectories(MapperRef.fieldRef + "\\modloader");
						for (int n = 0; n < directories2.Length; n++)
						{
							CS$<>8__locals3.ConnectRule(directories2[n], 1, ref CS$<>8__locals1);
						}
						if (num2 != 0)
						{
							MapperRef.PatchSingleton(22);
							OrderVisitorException.TestReader("İzinsiz ASI bulundu.\n\n" + str4 + "\nGTA-SA'nın kurulu olduğu klasör içerisinde bulunan MODLOADER dosyasından bu asileri silerek sorunu çözebilirsiniz.", "Rina Anti-Cheat");
							return 1;
						}
					}
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\scripts"))
				{
					MapperRef.<>c__DisplayClass78_3 CS$<>8__locals4 = new MapperRef.<>c__DisplayClass78_3();
					CS$<>8__locals4.m_SerializerIdentifier = CS$<>8__locals2;
					int num3 = 0;
					string str5 = "";
					CS$<>8__locals4._ResolverIdentifier = new string[]
					{
						MapperWatcherClass.VerifyRule(22, "asi"),
						MapperWatcherClass.VerifyRule(23, "gta")
					};
					Directory.GetFiles(MapperRef.fieldRef + "\\scripts", "*.*").Where(new Func<string, bool>(CS$<>8__locals4.AssetRule)).ToArray<string>();
					this._RecordRef = 0;
					CS$<>8__locals4.PostRule(MapperRef.fieldRef + "\\scripts", 0, ref CS$<>8__locals1);
					for (int num4 = 0; num4 < 1; num4++)
					{
						string[] directories3 = Directory.GetDirectories(MapperRef.fieldRef + "\\scripts");
						for (int num5 = 0; num5 < directories3.Length; num5++)
						{
							CS$<>8__locals4.PostRule(directories3[num5], 1, ref CS$<>8__locals1);
						}
						if (num3 != 0)
						{
							MapperRef.PatchSingleton(22);
							OrderVisitorException.TestReader("İzinsiz ASI bulundu.\n\n" + str5 + "\nGTA-SA'nın kurulu olduğu klasör içerisinde bulunan MODLOADER dosyasından bu asileri silerek sorunu çözebilirsiniz.", "Rina Anti-Cheat");
							return 1;
						}
					}
				}
				if (Directory.Exists(MapperRef.fieldRef + "\\modloader"))
				{
					MapperRef.<>c__DisplayClass78_4 CS$<>8__locals5 = new MapperRef.<>c__DisplayClass78_4();
					CS$<>8__locals5.predicateIdentifier = new string[]
					{
						MapperWatcherClass.VerifyRule(24, "dll")
					};
					CS$<>8__locals5.m_SpecificationIdentifier = 0;
					Directory.GetFiles(MapperRef.fieldRef + "\\modloader", "*.*").Where(new Func<string, bool>(CS$<>8__locals5.ListRule)).ToArray<string>();
					CS$<>8__locals5.DefineRule(MapperRef.fieldRef + "\\modloader", 0);
					for (int num6 = 0; num6 < 1; num6++)
					{
						string[] directories4 = Directory.GetDirectories(MapperRef.fieldRef + "\\modloader");
						for (int num7 = 0; num7 < directories4.Length; num7++)
						{
							CS$<>8__locals5.DefineRule(directories4[num7], 1);
						}
						if (CS$<>8__locals5.m_SpecificationIdentifier != 0)
						{
							MapperRef.PatchSingleton(24);
							OrderVisitorException.TestReader("MODLOADER klasörü içerisine yasaklı DLL (D3D9 / D3D2) koyamazsınız! (Tespit edilen: " + CS$<>8__locals5.m_SpecificationIdentifier.ToString() + " adet yasaklı DLL)", "Rina Anti-Cheat");
							return 1;
						}
					}
				}
				if (CS$<>8__locals1.expressionIdentifier > 0)
				{
					MapperRef.PatchSingleton(25);
					OrderVisitorException.TestReader("Hile bulundu!\n\n" + CS$<>8__locals2.m_CandidateIdentifier + "\nToplam hile: " + CS$<>8__locals1.expressionIdentifier.ToString(), "Rina Anti-Cheat");
				}
			}
			catch
			{
			}
			return CS$<>8__locals1.expressionIdentifier;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00012DC4 File Offset: 0x00010FC4
		public List<MapperRef.IdentifierIdentifier> RateSingleton(Process reference)
		{
			List<MapperRef.IdentifierIdentifier> list = new List<MapperRef.IdentifierIdentifier>();
			IntPtr[] array = new IntPtr[0];
			int num = 0;
			if (!MapperRef.FactoryRuleTask.EnumProcessModulesEx(reference.Handle, array, 0, out num, 3U))
			{
				return list;
			}
			int num2 = num / IntPtr.Size;
			array = new IntPtr[num2];
			if (MapperRef.FactoryRuleTask.EnumProcessModulesEx(reference.Handle, array, num, out num, 3U))
			{
				for (int i = 0; i < num2; i++)
				{
					StringBuilder stringBuilder = new StringBuilder(1024);
					MapperRef.FactoryRuleTask.GetModuleFileNameEx(reference.Handle, array[i], stringBuilder, (uint)stringBuilder.Capacity);
					string fileName = Path.GetFileName(stringBuilder.ToString());
					MapperRef.FactoryRuleTask.ProccesorContainerRole proccesorContainerRole = default(MapperRef.FactoryRuleTask.ProccesorContainerRole);
					MapperRef.FactoryRuleTask.GetModuleInformation(reference.Handle, array[i], out proccesorContainerRole, (uint)(IntPtr.Size * array.Length));
					MapperRef.IdentifierIdentifier item = new MapperRef.IdentifierIdentifier(fileName, proccesorContainerRole.procRef, proccesorContainerRole.prototypeIdentifier, stringBuilder.ToString());
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x060001F3 RID: 499
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(int init_end, bool excludecfg, int compamount);

		// Token: 0x060001F4 RID: 500
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool ReadProcessMemory(IntPtr init, IntPtr cfg, [Out] byte[] temp, int remove_CFG2At, out IntPtr visitor3);

		// Token: 0x060001F5 RID: 501
		[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
		public static extern bool ReadProcessMemory_1(IntPtr param, IntPtr b, [MarshalAs(UnmanagedType.AsAny)] [Out] object field, int instance2, out IntPtr config3);

		// Token: 0x060001F6 RID: 502
		[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
		public static extern bool ReadProcessMemory_2(IntPtr task, IntPtr visitor, IntPtr template, int indexvalue2, out IntPtr result3);

		// Token: 0x060001F7 RID: 503
		[DllImport("kernel32.dll")]
		public static extern void GetNativeSystemInfo(ref MapperRef.PolicyIdentifier var1);

		// Token: 0x060001F8 RID: 504
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern void GetSystemInfo(ref MapperRef.PolicyIdentifier param);

		// Token: 0x060001F9 RID: 505
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern int VirtualQueryEx(IntPtr param, IntPtr pol, out MapperRef.ClientAuthenticationReader comp, uint cont2_end);

		// Token: 0x060001FA RID: 506
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool CloseHandle(IntPtr value);

		// Token: 0x060001FB RID: 507 RVA: 0x00012EA4 File Offset: 0x000110A4
		public int DestroySingleton(IntPtr init, ref List<MapperRef.ClientAuthenticationReader> selection)
		{
			int num = 0;
			IntPtr pol = 0;
			try
			{
				for (;;)
				{
					MapperRef.ClientAuthenticationReader clientAuthenticationReader = default(MapperRef.ClientAuthenticationReader);
					int num2 = 0;
					try
					{
						num2 = MapperRef.VirtualQueryEx(init, pol, out clientAuthenticationReader, (uint)Marshal.SizeOf(typeof(MapperRef.ClientAuthenticationReader)));
						goto IL_B4;
					}
					catch (Exception)
					{
						MapperRef.CreateSingleton("Memory Control has crashed.");
						MapperRef.PatchSingleton(455);
						OrderVisitorException.TestReader("Hafıza kontrolü sırasında problem oluştuğu için oyun kapatıldı.", "Rina Anticheat");
						MapperRef.NewSingleton("QUERYEXCEPTION", "", "", "", 0);
						goto IL_B4;
					}
					IL_73:
					if (clientAuthenticationReader.m_VisitorIdentifier != 1U && clientAuthenticationReader.m_VisitorIdentifier != 0U)
					{
						selection.Add(clientAuthenticationReader);
						num++;
					}
					pol = new IntPtr(clientAuthenticationReader.m_TemplateIdentifier.ToInt32() + clientAuthenticationReader.watcherIdentifier.ToInt32());
					continue;
					IL_B4:
					if (num2 == 0)
					{
						break;
					}
					goto IL_73;
				}
			}
			catch (Exception)
			{
			}
			ProductReaderStructBuilder.stubIdentifier = (long)num;
			return 1;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00012F94 File Offset: 0x00011194
		public int CloneSingleton(Process key, ref int b, ref int helper, ref int caller2, ref string ivk3)
		{
			object[] array = TaskReader.TestRule(26, new object[]
			{
				key,
				b,
				helper,
				caller2,
				ivk3
			}, this);
			b = (int)array[1];
			helper = (int)array[2];
			caller2 = (int)array[3];
			ivk3 = (string)array[4];
			return (int)array[0];
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00013068 File Offset: 0x00011268
		public static void NewSingleton(string v, string col, string template, string token2, int param3ID)
		{
			if (Dispatcher.MoveIdentifier() > ProductReaderStructBuilder.m_ServiceIdentifier + 5L)
			{
				ProductReaderStructBuilder.m_ServiceIdentifier = Dispatcher.MoveIdentifier();
				try
				{
					using (WebClient webClient = new WebClient())
					{
						webClient.Headers.Add("user-agent", ProductReaderStructBuilder.m_SchemaIdentifier);
						string descriptorIdentifier = ProductReaderStructBuilder.descriptorIdentifier;
						webClient.UploadValues(descriptorIdentifier, new NameValueCollection
						{
							{
								"IP",
								ProductReaderStructBuilder._MethodIdentifier
							},
							{
								"LoginKey",
								ProductReaderStructBuilder.m_ExceptionIdentifier
							},
							{
								"Serial",
								ProductReaderStructBuilder.factoryIdentifier + ProductReaderStructBuilder._AccountIdentifier
							},
							{
								"Reg",
								MapperRef.broadcasterRef
							},
							{
								"Name",
								ProductReaderStructBuilder.helperIdentifier
							},
							{
								"Cheat",
								v
							},
							{
								"Title",
								col
							},
							{
								"Process",
								template
							},
							{
								"FilePath",
								token2
							},
							{
								"DetectType",
								param3ID.ToString()
							}
						});
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00013190 File Offset: 0x00011390
		public int VisitSingleton()
		{
			int result;
			try
			{
				StreamReader streamReader = new StreamReader(new WebClient
				{
					Headers = 
					{
						{
							"user-agent",
							ProductReaderStructBuilder.m_SchemaIdentifier
						}
					}
				}.OpenRead(ProductReaderStructBuilder._RoleIdentifier + ProductReaderStructBuilder._AlgoIdentifier));
				ProductReaderStructBuilder.m_DatabaseIdentifier.Clear();
				int num = 0;
				while (!streamReader.EndOfStream)
				{
					string text = CollectionAuthenticationReader.ManageRule(streamReader.ReadLine());
					if (!text.Contains("CHECK_ROW_RINA"))
					{
						TaskInvocationRecord.AwakeRule(text);
					}
					else
					{
						num++;
					}
				}
				if (num != 50)
				{
					MessageBox.Show("Uzak sunucudan code (4) adlı liste yüklenemedi.", "Uzak sunucudan liste yüklenemedi.");
					Application.Exit();
				}
				return 1;
			}
			catch (WebException ex)
			{
				MessageBox.Show("Code 2 sunucusuna bağlanılamadı. Hata sizden veya sunucudan\nkaynaklı olabilir lütfen bir yetkiliye ulaşınız.\n\n\nHata kodu: " + ((HttpWebResponse)ex.Response).StatusCode.ToString(), "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = 0;
			}
			return result;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00013278 File Offset: 0x00011478
		public int LogoutSingleton()
		{
			int result;
			try
			{
				StreamReader streamReader = new StreamReader(new WebClient
				{
					Headers = 
					{
						{
							"user-agent",
							ProductReaderStructBuilder.m_SchemaIdentifier
						}
					}
				}.OpenRead(ProductReaderStructBuilder._RoleIdentifier + ProductReaderStructBuilder._IteratorIdentifier));
				ProductReaderStructBuilder._GetterIdentifier.Clear();
				int num = 0;
				while (!streamReader.EndOfStream)
				{
					string text = CollectionAuthenticationReader.ManageRule(streamReader.ReadLine());
					if (!text.Contains("CHECK_ROW_RINA"))
					{
						TaskInvocationRecord.CustomizeRule(text);
					}
					else
					{
						num++;
					}
				}
				if (num != 50)
				{
					MessageBox.Show("Uzak sunucudan code (5) adlı liste yüklenemedi.", "Uzak sunucudan liste yüklenemedi.");
					Application.Exit();
				}
				return 1;
			}
			catch (WebException ex)
			{
				MessageBox.Show("Code 5 sunucusuna bağlanılamadı. Hata sizden veya sunucudan\nkaynaklı olabilir lütfen bir yetkiliye ulaşınız.\n\n\nHata kodu: " + ((HttpWebResponse)ex.Response).StatusCode.ToString(), "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = 0;
			}
			return result;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00013360 File Offset: 0x00011560
		public void UpdateSingleton(string first, string reg, string state, string task2, int first3_max)
		{
			MapperRef.PatchSingleton(26);
			MapperRef.NewSingleton(first, reg, state, task2, first3_max);
			OrderVisitorException.TestReader(string.Concat(new string[]
			{
				"Bilgisayarınızda sizi diğer oyunculardan üstün tutacak ",
				state,
				" (",
				(!string.IsNullOrEmpty(reg)) ? reg : "başlıksız",
				") adlı hile bulundu."
			}), "Rina Anti-Cheat");
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000133C8 File Offset: 0x000115C8
		public static bool CalculateSingleton(string res)
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				if (processes[i].ProcessName == res)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000133FC File Offset: 0x000115FC
		public static int PatchSingleton(int length_setup)
		{
			MapperRef.<>c__DisplayClass108_0 CS$<>8__locals1 = new MapperRef.<>c__DisplayClass108_0();
			CS$<>8__locals1.m_ManagerIdentifier = length_setup;
			foreach (Process process in Process.GetProcesses("."))
			{
				try
				{
					if (process.MainWindowTitle.Length > 0 && (process.ProcessName == "gta_sa" || process.MainWindowTitle.Contains("SA-MP 0.3") || process.MainWindowTitle.Contains("GTA: San Andreas") || process.MainWindowTitle.Contains("GTA:SA:MP") || process.MainWindowTitle.Contains("GTA Attention")))
					{
						MapperRef.composerRef = false;
						try
						{
							process.Kill();
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
			MapperRef.pageRef = new Thread(new ThreadStart(CS$<>8__locals1.RestartRule));
			MapperRef.pageRef.Start();
			return 1;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000134F4 File Offset: 0x000116F4
		public static int ResolveSingleton(int indexOf_value)
		{
			MapperRef.<>c__DisplayClass109_0 CS$<>8__locals1 = new MapperRef.<>c__DisplayClass109_0();
			CS$<>8__locals1.m_ProcessIdentifier = indexOf_value;
			MapperRef.creatorRef = false;
			try
			{
				new Thread(new ThreadStart(CS$<>8__locals1.ReflectRule)).Start();
			}
			catch
			{
			}
			return 1;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00013540 File Offset: 0x00011740
		protected static int CancelSingleton()
		{
			MapperRef mapperRef = new MapperRef();
			long serviceRef = 0L;
			mapperRef.IncludeReader();
			Directory.GetDirectories(MapperRef.fieldRef);
			Directory.GetFiles(MapperRef.fieldRef);
			if (Directory.Exists(MapperRef.fieldRef + "\\cleo"))
			{
				Directory.GetDirectories(MapperRef.fieldRef + "\\cleo");
				string[] files = Directory.GetFiles(MapperRef.fieldRef + "\\cleo");
				for (int i = 0; i < files.Length; i++)
				{
					serviceRef = new FileInfo(files[i]).Length;
				}
			}
			mapperRef._ServiceRef = serviceRef;
			return 1;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000135E0 File Offset: 0x000117E0
		public void ViewSingleton()
		{
			if (!Directory.Exists(MapperRef.fieldRef))
			{
				this._RepositoryRef.Description = "GTA-SA'nın kurulu olduğu klasörü seçiniz;";
				this._RepositoryRef.ShowDialog();
				MapperRef.fieldRef = this._RepositoryRef.SelectedPath;
				Registry.CurrentUser.OpenSubKey("Software\\SAMP\\", true).SetValue(MapperWatcherClass.VerifyRule(43, "gta_sa_exe"), this._RepositoryRef.SelectedPath + "\\gta_sa.exe");
				this.ViewSingleton();
				return;
			}
			if (!File.Exists(MapperRef.fieldRef + MapperWatcherClass.VerifyRule(26, "/samp.exe")))
			{
				this._RepositoryRef.Description = "SA-MP'nın kurulu olduğu klasörü seçiniz;";
				this._RepositoryRef.ShowDialog();
				MapperRef.fieldRef = this._RepositoryRef.SelectedPath;
				Registry.CurrentUser.OpenSubKey("Software\\SAMP\\", true).SetValue(MapperWatcherClass.VerifyRule(43, "gta_sa_exe"), this._RepositoryRef.SelectedPath + "\\gta_sa.exe");
				this.ViewSingleton();
				return;
			}
			if (!File.Exists(MapperRef.fieldRef + MapperWatcherClass.VerifyRule(27, "/gta_sa.exe")))
			{
				this._RepositoryRef.Description = "GTA-SA'nın kurulu olduğu klasörü seçiniz;";
				this._RepositoryRef.ShowDialog();
				MapperRef.fieldRef = this._RepositoryRef.SelectedPath;
				Registry.CurrentUser.OpenSubKey("Software\\SAMP\\", true).SetValue(MapperWatcherClass.VerifyRule(43, "gta_sa_exe"), this._RepositoryRef.SelectedPath + "\\gta_sa.exe");
				this.ViewSingleton();
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000332C File Offset: 0x0000152C
		public MapperRef()
		{
			AdvisorConnectionAttribute.CancelComposer();
			this._RepositoryRef = new FolderBrowserDialog();
			base..ctor();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00003344 File Offset: 0x00001544
		static MapperRef()
		{
			AdvisorConnectionAttribute.CancelComposer();
			MapperRef.m_FacadeRef = null;
			MapperRef.m_ValueRef = new Random();
			MapperRef.m_QueueRef = 0;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00003361 File Offset: 0x00001561
		internal static bool TestOrder()
		{
			return MapperRef.DisableOrder == null;
		}

		// Token: 0x04000112 RID: 274
		public static string fieldRef;

		// Token: 0x04000113 RID: 275
		public static object m_FacadeRef;

		// Token: 0x04000114 RID: 276
		public static string m_AdapterRef;

		// Token: 0x04000115 RID: 277
		protected static string broadcasterRef;

		// Token: 0x04000116 RID: 278
		public static object _ListenerRef;

		// Token: 0x04000117 RID: 279
		public static bool composerRef;

		// Token: 0x04000118 RID: 280
		public static bool creatorRef;

		// Token: 0x04000119 RID: 281
		public int _ProxyRef;

		// Token: 0x0400011A RID: 282
		public long _ServiceRef;

		// Token: 0x0400011B RID: 283
		public int _RecordRef;

		// Token: 0x0400011C RID: 284
		private FolderBrowserDialog _RepositoryRef;

		// Token: 0x0400011D RID: 285
		public static Thread pageRef;

		// Token: 0x0400011E RID: 286
		private static readonly Random m_ValueRef;

		// Token: 0x0400011F RID: 287
		private static int m_QueueRef;

		// Token: 0x04000120 RID: 288
		internal static object DisableOrder;

		// Token: 0x0200003C RID: 60
		internal class FactoryRuleTask
		{
			// Token: 0x06000209 RID: 521
			[DllImport("psapi.dll")]
			public static extern bool EnumProcessModulesEx(IntPtr task, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)] [In] [Out] IntPtr[] col, int idxdic, [MarshalAs(UnmanagedType.U4)] out int item2, uint mean_attr3);

			// Token: 0x0600020A RID: 522
			[DllImport("psapi.dll")]
			public static extern uint GetModuleFileNameEx(IntPtr def, IntPtr cust, [Out] StringBuilder temp, [MarshalAs(UnmanagedType.U4)] [In] uint removeCUST2At);

			// Token: 0x0600020B RID: 523
			[DllImport("psapi.dll", SetLastError = true)]
			public static extern bool GetModuleInformation(IntPtr param, IntPtr vis, out MapperRef.FactoryRuleTask.ProccesorContainerRole util, uint flags_reference2);

			// Token: 0x0600020C RID: 524 RVA: 0x000024D4 File Offset: 0x000006D4
			public FactoryRuleTask()
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
			}

			// Token: 0x0600020D RID: 525 RVA: 0x0000336B File Offset: 0x0000156B
			internal static bool SelectOrder()
			{
				return MapperRef.FactoryRuleTask.VerifyOrder == null;
			}

			// Token: 0x04000121 RID: 289
			internal static object VerifyOrder;

			// Token: 0x0200003D RID: 61
			internal struct ProccesorContainerRole
			{
				// Token: 0x04000122 RID: 290
				public IntPtr procRef;

				// Token: 0x04000123 RID: 291
				public uint prototypeIdentifier;

				// Token: 0x04000124 RID: 292
				public IntPtr _RefIdentifier;
			}

			// Token: 0x0200003E RID: 62
			internal enum GetterSingletonDispatcher
			{

			}
		}

		// Token: 0x0200003F RID: 63
		internal class IdentifierIdentifier
		{
			// Token: 0x0600020E RID: 526 RVA: 0x00003375 File Offset: 0x00001575
			public IdentifierIdentifier(string spec, IntPtr vis, uint consumer, string info2)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.MapSingleton(spec);
				this.RevertSingleton(vis);
				this.ExcludeRule(consumer);
				this.FilePath = info2;
			}

			// Token: 0x0600020F RID: 527 RVA: 0x0000339F File Offset: 0x0000159F
			[CompilerGenerated]
			public string ConcatSingleton()
			{
				return this.m_ReaderIdentifier;
			}

			// Token: 0x06000210 RID: 528 RVA: 0x000033A7 File Offset: 0x000015A7
			[CompilerGenerated]
			public void MapSingleton(string value)
			{
				this.m_ReaderIdentifier = value;
			}

			// Token: 0x06000211 RID: 529 RVA: 0x000033B0 File Offset: 0x000015B0
			[CompilerGenerated]
			public IntPtr ForgotSingleton()
			{
				return this._SingletonIdentifier;
			}

			// Token: 0x06000212 RID: 530 RVA: 0x000033B8 File Offset: 0x000015B8
			[CompilerGenerated]
			public void RevertSingleton(IntPtr key)
			{
				this._SingletonIdentifier = key;
			}

			// Token: 0x06000213 RID: 531 RVA: 0x000033C1 File Offset: 0x000015C1
			[CompilerGenerated]
			public uint AddRule()
			{
				return this.m_RuleIdentifier;
			}

			// Token: 0x06000214 RID: 532 RVA: 0x000033C9 File Offset: 0x000015C9
			[CompilerGenerated]
			public void ExcludeRule(uint first_end)
			{
				this.m_RuleIdentifier = first_end;
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000215 RID: 533 RVA: 0x000033D2 File Offset: 0x000015D2
			// (set) Token: 0x06000216 RID: 534 RVA: 0x000033DA File Offset: 0x000015DA
			public string FilePath { get; set; }

			// Token: 0x06000217 RID: 535 RVA: 0x000033E3 File Offset: 0x000015E3
			internal static bool VisitOrder()
			{
				return MapperRef.IdentifierIdentifier.PrintOrder == null;
			}

			// Token: 0x04000126 RID: 294
			[CompilerGenerated]
			private string m_ReaderIdentifier;

			// Token: 0x04000127 RID: 295
			[CompilerGenerated]
			private IntPtr _SingletonIdentifier;

			// Token: 0x04000128 RID: 296
			[CompilerGenerated]
			private uint m_RuleIdentifier;

			// Token: 0x04000129 RID: 297
			[CompilerGenerated]
			private string m_AnnotationIdentifier;

			// Token: 0x0400012A RID: 298
			internal static object PrintOrder;
		}

		// Token: 0x02000040 RID: 64
		internal struct ClientAuthenticationReader
		{
			// Token: 0x0400012B RID: 299
			public IntPtr m_TemplateIdentifier;

			// Token: 0x0400012C RID: 300
			public IntPtr _InfoIdentifier;

			// Token: 0x0400012D RID: 301
			public uint _PropertyIdentifier;

			// Token: 0x0400012E RID: 302
			public IntPtr watcherIdentifier;

			// Token: 0x0400012F RID: 303
			public uint m_ConnectionIdentifier;

			// Token: 0x04000130 RID: 304
			public uint m_VisitorIdentifier;

			// Token: 0x04000131 RID: 305
			public uint _AuthenticationIdentifier;
		}

		// Token: 0x02000041 RID: 65
		internal struct PolicyIdentifier
		{
			// Token: 0x04000132 RID: 306
			internal ushort containerIdentifier;

			// Token: 0x04000133 RID: 307
			internal ushort ushort_0;

			// Token: 0x04000134 RID: 308
			internal int m_ServerIdentifier;

			// Token: 0x04000135 RID: 309
			internal IntPtr _RequestIdentifier;

			// Token: 0x04000136 RID: 310
			internal IntPtr _ReponseIdentifier;

			// Token: 0x04000137 RID: 311
			internal IntPtr rulesIdentifier;

			// Token: 0x04000138 RID: 312
			internal int int_0;

			// Token: 0x04000139 RID: 313
			internal int m_ContextIdentifier;

			// Token: 0x0400013A RID: 314
			internal int clientIdentifier;

			// Token: 0x0400013B RID: 315
			internal short _CollectionIdentifier;

			// Token: 0x0400013C RID: 316
			internal short modelIdentifier;
		}

		// Token: 0x02000042 RID: 66
		internal enum SilentFlags : uint
		{

		}

		// Token: 0x02000043 RID: 67
		internal enum WorkerIdentifier : uint
		{

		}

		// Token: 0x02000044 RID: 68
		internal enum RegistryIdentifier : uint
		{

		}
	}
}
