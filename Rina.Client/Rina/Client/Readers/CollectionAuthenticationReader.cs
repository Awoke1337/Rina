using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Rina.Authentication;
using Rina.Client.Attributes;
using Rina.Client.Records;
using Rina.Maps;
using Rina.Objects;
using Rina.Structs;

namespace Rina.Client.Readers
{
	// Token: 0x02000057 RID: 87
	internal class CollectionAuthenticationReader
	{
		// Token: 0x06000247 RID: 583 RVA: 0x00014134 File Offset: 0x00012334
		public static void InsertRule()
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			MappingRef.LoginReader("LISTDOWNLOAD", new string[0]);
			backgroundWorker.DoWork += new DoWorkEventHandler(CollectionAuthenticationReader.CompareRule);
			backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CollectionAuthenticationReader.ComputeRule);
			if (!backgroundWorker.IsBusy)
			{
				backgroundWorker.RunWorkerAsync();
				return;
			}
			MessageBox.Show(RegistryReader.DisableRule("UNKNOWNERROR", new object[]
			{
				"DownloadList isBusy"
			}));
			Application.Exit();
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000141B0 File Offset: 0x000123B0
		public static string RemoveRule(string reference, Array pred, byte[] third)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			byte[] array = new byte[32];
			Array.Copy(pred, 0, array, 0, 32);
			aes.Key = array;
			aes.IV = third;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			string result = string.Empty;
			try
			{
				byte[] array2 = Convert.FromBase64String(reference);
				cryptoStream.Write(array2, 0, array2.Length);
				cryptoStream.FlushFinalBlock();
				byte[] array3 = memoryStream.ToArray();
				result = Encoding.ASCII.GetString(array3, 0, array3.Length);
			}
			finally
			{
				memoryStream.Close();
				cryptoStream.Close();
			}
			return result;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002E35 File Offset: 0x00001035
		public static string RegisterRule(string info)
		{
			char[] array = info.ToCharArray();
			Array.Reverse(array);
			return new string(array);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000032CC File Offset: 0x000014CC
		public static int WriteRule(int position_i, int cont_count)
		{
			return (position_i % cont_count + cont_count) % cont_count;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00014264 File Offset: 0x00012464
		public static string ManageRule(object item)
		{
			object[] array = TaskReader.TestRule(27, new object[]
			{
				item
			}, null);
			return (string)array[0];
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001429C File Offset: 0x0001249C
		private static void CompareRule(object key, object vis)
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.Headers.Add("user-agent", ProductReaderStructBuilder.m_SchemaIdentifier);
				StreamReader streamReader = new StreamReader(webClient.OpenRead(ProductReaderStructBuilder._RoleIdentifier + ProductReaderStructBuilder._InterpreterIdentifier));
				while (!streamReader.EndOfStream)
				{
					TaskInvocationRecord.SortRule(streamReader.ReadLine());
				}
				webClient.Headers.Add("user-agent", ProductReaderStructBuilder.m_SchemaIdentifier);
				streamReader = new StreamReader(webClient.OpenRead(ProductReaderStructBuilder._RoleIdentifier + ProductReaderStructBuilder.messageIdentifier));
				int num = 0;
				int num2 = 0;
				while (!streamReader.EndOfStream)
				{
					string text = CollectionAuthenticationReader.ManageRule(streamReader.ReadLine());
					if (num != 0)
					{
						try
						{
							TaskInvocationRecord.SetRule(text);
							goto IL_10E;
						}
						catch
						{
							MessageBox.Show("CLEO listesi derlenirken problem oluştu.", "Derleme Hatası");
							Application.Exit();
							goto IL_10E;
						}
						goto IL_BE;
					}
					goto IL_BE;
					IL_10E:
					num++;
					continue;
					IL_BE:
					num2 = Convert.ToInt32(text.Split(new char[]
					{
						'|'
					})[0]);
					if (!text.Split(new char[]
					{
						'|'
					})[1].Equals("RINADAN_SELAMLAR"))
					{
						MessageBox.Show("Uzak sunucudan code (1) adlı liste yüklenemedi.", "Uzak sunucudan liste yüklenemedi.");
						Application.Exit();
						goto IL_10E;
					}
					goto IL_10E;
				}
				if (num2 != ProductReaderStructBuilder.dispatcherIdentifier.Count)
				{
					MessageBox.Show("Uzak sunucudan code (1) adlı listeyi derlerken problem oluştu.", "Uzak sunucudan liste yüklenemedi.");
					Application.Exit();
				}
				webClient.Headers.Add("user-agent", ProductReaderStructBuilder.m_SchemaIdentifier);
				streamReader = new StreamReader(webClient.OpenRead(ProductReaderStructBuilder._RoleIdentifier + ProductReaderStructBuilder._WrapperIdentifier));
				int num3 = 0;
				while (!streamReader.EndOfStream)
				{
					string text2 = CollectionAuthenticationReader.ManageRule(streamReader.ReadLine());
					if (num3 == 0)
					{
						Convert.ToInt32(text2.Split(new char[]
						{
							'|'
						})[0]);
						if (!text2.Split(new char[]
						{
							'|'
						})[1].Equals("RINADAN_SELAMLAR"))
						{
							MessageBox.Show("Uzak sunucudan code (2) adlı liste yüklenemedi.", "Uzak sunucudan liste yüklenemedi.");
							Application.Exit();
						}
					}
					else
					{
						try
						{
							TaskInvocationRecord.ChangeRule(text2);
						}
						catch
						{
							MessageBox.Show("ENB listesi derlenirken problem oluştu.", "Derleme Hatası");
							Application.Exit();
						}
					}
					num3++;
				}
				webClient.Headers.Add("user-agent", ProductReaderStructBuilder.m_SchemaIdentifier);
				streamReader = new StreamReader(webClient.OpenRead(ProductReaderStructBuilder._RoleIdentifier + ProductReaderStructBuilder._ProducerIdentifier));
				int num4 = 0;
				while (!streamReader.EndOfStream)
				{
					string text3 = CollectionAuthenticationReader.ManageRule(streamReader.ReadLine());
					if (num4 == 0)
					{
						Convert.ToInt32(text3.Split(new char[]
						{
							'|'
						})[0]);
						if (!text3.Split(new char[]
						{
							'|'
						})[1].Equals("RINADAN_SELAMLAR"))
						{
							MessageBox.Show("Uzak sunucudan code (3) adlı liste yüklenemedi.", "Uzak sunucudan liste yüklenemedi.");
							Application.Exit();
						}
					}
					else
					{
						try
						{
							TaskInvocationRecord.LoginRule(text3);
						}
						catch
						{
							MessageBox.Show("ASI listesi derlenirken problem oluştu.", "Derleme Hatası");
							Application.Exit();
						}
					}
					num4++;
				}
			}
			catch (WebException ex)
			{
				MessageBox.Show("İndirme sunucusuna bağlanılamadı. Hata sizden veya sunucudan\nkaynaklı olabilir lütfen bir yetkiliye ulaşınız.\n\n\nHata kodu: " + ((HttpWebResponse)ex.Response).StatusCode.ToString(), "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Application.Exit();
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000035B9 File Offset: 0x000017B9
		private static void ComputeRule(object task, object map)
		{
			StubRef.ValidateReader();
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000024D4 File Offset: 0x000006D4
		public CollectionAuthenticationReader()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000035C0 File Offset: 0x000017C0
		internal static bool GetPolicy()
		{
			return CollectionAuthenticationReader.ConcatPolicy == null;
		}

		// Token: 0x040001BF RID: 447
		private static object ConcatPolicy;
	}
}
