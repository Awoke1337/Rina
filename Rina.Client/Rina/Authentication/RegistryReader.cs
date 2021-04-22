using System;
using System.Collections.Generic;
using Rina.Client.Attributes;

namespace Rina.Authentication
{
	// Token: 0x0200005E RID: 94
	internal class RegistryReader
	{
		// Token: 0x0600026C RID: 620 RVA: 0x0001538C File Offset: 0x0001358C
		public static string DisableRule(string spec, params object[] Arguments)
		{
			using (Dictionary<string, string>.Enumerator enumerator = RegistryReader.m_TokenReader.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, string> keyValuePair = enumerator.Current;
					if (keyValuePair.Key == spec)
					{
						return string.Format(keyValuePair.Value, Arguments);
					}
				}
				goto IL_50;
			}
			string result;
			return result;
			IL_50:
			return null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000024D4 File Offset: 0x000006D4
		public RegistryReader()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000153FC File Offset: 0x000135FC
		static RegistryReader()
		{
			AdvisorConnectionAttribute.CancelComposer();
			RegistryReader.m_TokenReader = new Dictionary<string, string>
			{
				{
					"UNKNOWNERROR",
					"Bilinmeyen, ancak kritik bir hata oldu .. Sorunu çözmeye yardımcı olabilecek hata mesajı:\n {0}"
				},
				{
					"MISSINGBINARY",
					"{0} eksik olduğundan oyun başlatılamıyor."
				},
				{
					"CANNOTSTART",
					"Oyuna başlayamazsınız, muhtemelen antivirüsünüzü lütfen kapatın."
				},
				{
					"NONETWORK",
					"Sunucuya bağlanılamıyor, lütfen ağ ayarlarınızı kontrol edin ve tekrar deneyin."
				},
				{
					"CONNECTING",
					"Sunucuya bağlanılıyor..."
				},
				{
					"LISTDOWNLOAD",
					"Günceleme listesi indiriliyor..."
				},
				{
					"CHECKFILE",
					"{0} kontrol ediliyor..."
				},
				{
					"DOWNLOADFILE",
					"{0} indiriliyor... {1}/ {2}"
				},
				{
					"COMPLETEPROGRESS",
					"Toplam İlerleme: {0}%"
				},
				{
					"CURRENTPROGRESS",
					"Dosya İlerlemesi: {0}%  |  {1} kb/s"
				},
				{
					"CHECKCOMPLETE",
					"Her dosya düzgün kontrol edildi."
				},
				{
					"DOWNLOADCOMPLETE",
					"Gerekli tüm dosyalar düzgün şekilde indirildi."
				},
				{
					"DOWNLOADSPEED",
					"{0} kb/s"
				}
			};
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000366A File Offset: 0x0000186A
		internal static bool DestroyStruct()
		{
			return RegistryReader.AssetStruct == null;
		}

		// Token: 0x040001CE RID: 462
		private static Dictionary<string, string> m_TokenReader;

		// Token: 0x040001CF RID: 463
		internal static object AssetStruct;
	}
}
