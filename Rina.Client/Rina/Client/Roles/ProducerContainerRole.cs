using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using Rina.Client.Attributes;
using Rina.Composer;
using Rina.Database;
using Rina.Objects;
using Rina.Structs;

namespace Rina.Client.Roles
{
	// Token: 0x02000038 RID: 56
	internal class ProducerContainerRole
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x00010130 File Offset: 0x0000E330
		public static void DisableReader()
		{
			if (ProductReaderStructBuilder.customerIdentifier.Count <= 0)
			{
				MappingRef.LoginReader("CHECKCOMPLETE", new string[0]);
				MappingRef.PrepareReader();
				return;
			}
			if (ProducerContainerRole.paramsRef >= ProductReaderStructBuilder.customerIdentifier.Count)
			{
				MappingRef.LoginReader("DOWNLOADCOMPLETE", new string[0]);
				MappingRef.PrepareReader();
				ProductReaderStructBuilder.m_ItemIdentifier = 1;
				return;
			}
			MapperRef mapperRef = new MapperRef();
			mapperRef.IncludeReader();
			mapperRef.ViewSingleton();
			if (ProductReaderStructBuilder.customerIdentifier[ProducerContainerRole.paramsRef].Contains("/"))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(MapperRef.fieldRef + "\\" + ProductReaderStructBuilder.customerIdentifier[ProducerContainerRole.paramsRef]));
			}
			WebClient webClient = new WebClient();
			webClient.Headers.Add("user-agent", ProductReaderStructBuilder.m_SchemaIdentifier);
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProducerContainerRole.EnableReader);
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(ProducerContainerRole.CheckReader);
			ProducerContainerRole.parameterRef.Start();
			webClient.DownloadFileAsync(new Uri(ProductReaderStructBuilder._RoleIdentifier + ProductReaderStructBuilder.customerIdentifier[ProducerContainerRole.paramsRef]), MapperRef.fieldRef + "\\" + ProductReaderStructBuilder.customerIdentifier[ProducerContainerRole.paramsRef]);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001026C File Offset: 0x0000E46C
		private static void EnableReader(object info, object connection)
		{
			ProducerContainerRole.m_ParserRef = ProducerContainerRole.utilsRef + connection.BytesReceived;
			MappingRef.LoginReader("DOWNLOADFILE", new string[]
			{
				ProductReaderStructBuilder.customerIdentifier[ProducerContainerRole.paramsRef],
				StatusRef.CallReader((double)connection.BytesReceived).ToString("0.00") + " MB ",
				StatusRef.CallReader((double)connection.TotalBytesToReceive).ToString("0.00") + " MB"
			});
			MappingRef.SetReader(StatusRef.DeleteReader(ProductReaderStructBuilder._IndexerIdentifier + ProducerContainerRole.m_ParserRef));
			MappingRef.AwakeReader((long)connection.ProgressPercentage, StatusRef.RateReader((double)connection.BytesReceived, ProducerContainerRole.parameterRef));
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00003226 File Offset: 0x00001426
		private static void CheckReader(object setup, object pred)
		{
			ProducerContainerRole.utilsRef = ProducerContainerRole.m_ParserRef;
			MappingRef.AwakeReader(100L, 0.0);
			ProducerContainerRole.paramsRef++;
			ProducerContainerRole.parameterRef.Reset();
			ProducerContainerRole.DisableReader();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000024D4 File Offset: 0x000006D4
		public ProducerContainerRole()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00003264 File Offset: 0x00001464
		static ProducerContainerRole()
		{
			AdvisorConnectionAttribute.CancelComposer();
			ProducerContainerRole.parameterRef = new Stopwatch();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00003275 File Offset: 0x00001475
		internal static bool DefineOrder()
		{
			return ProducerContainerRole.CompareOrder == null;
		}

		// Token: 0x04000107 RID: 263
		private static int paramsRef;

		// Token: 0x04000108 RID: 264
		private static long utilsRef;

		// Token: 0x04000109 RID: 265
		private static long m_ParserRef;

		// Token: 0x0400010A RID: 266
		private static Stopwatch parameterRef;

		// Token: 0x0400010B RID: 267
		internal static object CompareOrder;
	}
}
