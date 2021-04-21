using System;
using System.Collections.Generic;
using DiscordRPC;
using Rina.Client.Attributes;
using Rina.Database;

namespace Rina.Structs
{
	// Token: 0x02000051 RID: 81
	internal class ProductReaderStructBuilder
	{
		// Token: 0x06000244 RID: 580 RVA: 0x000024D4 File Offset: 0x000006D4
		public ProductReaderStructBuilder()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00013C70 File Offset: 0x00011E70
		static ProductReaderStructBuilder()
		{
			AdvisorConnectionAttribute.CancelComposer();
			ProductReaderStructBuilder.m_SchemaIdentifier = "Keep-Delived";
			ProductReaderStructBuilder.tokenizerIdentifier = MapperRef.OrderSingleton();
			ProductReaderStructBuilder._RoleIdentifier = "http://51.195.61.169/data/";
			ProductReaderStructBuilder._InterpreterIdentifier = "patchlist.txt";
			ProductReaderStructBuilder._AlgoIdentifier = "r_cl.php";
			ProductReaderStructBuilder._IteratorIdentifier = "r_whitelist.php";
			ProductReaderStructBuilder.messageIdentifier = "r_m_cleos.php";
			ProductReaderStructBuilder._WrapperIdentifier = "r_m_d3d9.php";
			ProductReaderStructBuilder._ProducerIdentifier = "r_m_asi.php";
			ProductReaderStructBuilder._ProccesorIdentifier = "samp.bin";
			ProductReaderStructBuilder._AttributeIdentifier = new string[]
			{
				"a",
				"b",
				"c",
				"d",
				"e",
				"f",
				"g",
				"h",
				"i",
				"j",
				"k",
				"l",
				"m",
				"n",
				"o",
				"p",
				"q",
				"r",
				"s",
				"t",
				"u",
				"v",
				"w",
				"x",
				"y",
				"z",
				"A",
				"B",
				"C",
				"D",
				"E",
				"F",
				"G",
				"H",
				"I",
				"J",
				"K",
				"L",
				"M",
				"N",
				"O",
				"P",
				"Q",
				"R",
				"S",
				"T",
				"U",
				"V",
				"W",
				"X",
				"Y",
				"Z",
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"0"
			};
			ProductReaderStructBuilder.paramIdentifier = 62;
			ProductReaderStructBuilder.observerIdentifier = 32;
			ProductReaderStructBuilder.m_RegIdentifier = 0;
			ProductReaderStructBuilder.errorIdentifier = 0;
			ProductReaderStructBuilder.m_ExceptionIdentifier = "";
			ProductReaderStructBuilder._GlobalIdentifier = 0;
			ProductReaderStructBuilder.helperIdentifier = "";
			ProductReaderStructBuilder.eventIdentifier = "http://51.195.61.169/data/getip.php";
			ProductReaderStructBuilder.factoryIdentifier = MapperRef.InterruptSingleton();
			ProductReaderStructBuilder._SetterIdentifier = MapperRef.QuerySingleton();
			ProductReaderStructBuilder._MethodIdentifier = MapperRef.AddSingleton();
			ProductReaderStructBuilder.decoratorIdentifier = MapperRef.LogoutReader();
			ProductReaderStructBuilder._AccountIdentifier = MapperRef.AssetSingleton();
			ProductReaderStructBuilder.classIdentifier = MapperRef.CalculateReader("http://51.195.61.169/data/serverip.txt");
			ProductReaderStructBuilder._StateIdentifier = "http://51.195.61.169/data/r_assver.php";
			ProductReaderStructBuilder.descriptorIdentifier = "http://51.195.61.169/data/loghack.php";
			ProductReaderStructBuilder.publisherIdentifier = "http://51.195.61.169/data/timestamp.php";
			ProductReaderStructBuilder._CallbackIdentifier = "http://51.195.61.169/data/r_update.php";
			ProductReaderStructBuilder.m_PrinterIdentifier = "http://51.195.61.169/data/Rina_Updater.exe";
			ProductReaderStructBuilder._ValIdentifier = "DsB 1.5.0";
			ProductReaderStructBuilder.m_TestsIdentifier = "";
			ProductReaderStructBuilder._DicIdentifier = 643072;
			ProductReaderStructBuilder._SystemIdentifier = 754548;
			ProductReaderStructBuilder._AdvisorIdentifier = 0;
			ProductReaderStructBuilder.mockIdentifier = 0;
			ProductReaderStructBuilder.codeIdentifier = 0;
			ProductReaderStructBuilder.m_AttrIdentifier = MapperRef.ExcludeSingleton();
			ProductReaderStructBuilder.configurationIdentifier = "";
			ProductReaderStructBuilder.long_0 = 0L;
			ProductReaderStructBuilder.exporterIdentifier = new List<ProductReaderStructBuilder.RepositoryIdentifier>();
			ProductReaderStructBuilder.dispatcherIdentifier = new List<ProductReaderStructBuilder.RepositoryIdentifier>();
			ProductReaderStructBuilder._ConfigIdentifier = new List<ProductReaderStructBuilder.InvocationWatcherLicense>();
			ProductReaderStructBuilder.m_BaseIdentifier = new List<ProductReaderStructBuilder.DicConnectionAttribute>();
			ProductReaderStructBuilder.m_DatabaseIdentifier = new List<ProductReaderStructBuilder.InfoReader>();
			ProductReaderStructBuilder._GetterIdentifier = new List<ProductReaderStructBuilder.BridgePolicyPolicy>();
			ProductReaderStructBuilder.customerIdentifier = new List<string>();
			ProductReaderStructBuilder.m_MappingIdentifier = new Dictionary<int, string>();
			ProductReaderStructBuilder.m_StatusIdentifier = new Dictionary<int, bool>();
			ProductReaderStructBuilder.stubIdentifier = 0L;
			ProductReaderStructBuilder.filterIdentifier = 0L;
			ProductReaderStructBuilder._ParamsIdentifier = 0L;
			ProductReaderStructBuilder._UtilsIdentifier = 0L;
			ProductReaderStructBuilder.parserIdentifier = 0L;
			ProductReaderStructBuilder._ParameterIdentifier = 0L;
			ProductReaderStructBuilder._PoolIdentifier = "";
			ProductReaderStructBuilder.mapperIdentifier = "";
			ProductReaderStructBuilder._FieldIdentifier = "";
			ProductReaderStructBuilder.facadeIdentifier = "";
			ProductReaderStructBuilder._AdapterIdentifier = -1;
			ProductReaderStructBuilder.listenerIdentifier = 0;
			ProductReaderStructBuilder._CreatorIdentifier = false;
			ProductReaderStructBuilder.proxyIdentifier = 0L;
			ProductReaderStructBuilder.m_ServiceIdentifier = 0L;
			ProductReaderStructBuilder.m_RecordIdentifier = "C:\\Windows";
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000035AF File Offset: 0x000017AF
		internal static bool StartPolicy()
		{
			return ProductReaderStructBuilder.CalculatePolicy == null;
		}

		// Token: 0x04000160 RID: 352
		public static string m_SchemaIdentifier;

		// Token: 0x04000161 RID: 353
		public static string tokenizerIdentifier;

		// Token: 0x04000162 RID: 354
		public static string _RoleIdentifier;

		// Token: 0x04000163 RID: 355
		public static string _InterpreterIdentifier;

		// Token: 0x04000164 RID: 356
		public static string _AlgoIdentifier;

		// Token: 0x04000165 RID: 357
		public static string _IteratorIdentifier;

		// Token: 0x04000166 RID: 358
		public static string messageIdentifier;

		// Token: 0x04000167 RID: 359
		public static string _WrapperIdentifier;

		// Token: 0x04000168 RID: 360
		public static string _ProducerIdentifier;

		// Token: 0x04000169 RID: 361
		public static string _ProccesorIdentifier;

		// Token: 0x0400016A RID: 362
		public static string[] _AttributeIdentifier;

		// Token: 0x0400016B RID: 363
		public static int paramIdentifier;

		// Token: 0x0400016C RID: 364
		public static int observerIdentifier;

		// Token: 0x0400016D RID: 365
		public static int m_RegIdentifier;

		// Token: 0x0400016E RID: 366
		public static int errorIdentifier;

		// Token: 0x0400016F RID: 367
		public static string m_ExceptionIdentifier;

		// Token: 0x04000170 RID: 368
		public static int _GlobalIdentifier;

		// Token: 0x04000171 RID: 369
		public static string helperIdentifier;

		// Token: 0x04000172 RID: 370
		public static string eventIdentifier;

		// Token: 0x04000173 RID: 371
		public static string factoryIdentifier;

		// Token: 0x04000174 RID: 372
		public static string _SetterIdentifier;

		// Token: 0x04000175 RID: 373
		public static string _MethodIdentifier;

		// Token: 0x04000176 RID: 374
		public static string decoratorIdentifier;

		// Token: 0x04000177 RID: 375
		public static string _AccountIdentifier;

		// Token: 0x04000178 RID: 376
		public static string classIdentifier;

		// Token: 0x04000179 RID: 377
		public static string _StateIdentifier;

		// Token: 0x0400017A RID: 378
		public static string descriptorIdentifier;

		// Token: 0x0400017B RID: 379
		public static string publisherIdentifier;

		// Token: 0x0400017C RID: 380
		public static string _CallbackIdentifier;

		// Token: 0x0400017D RID: 381
		public static string m_PrinterIdentifier;

		// Token: 0x0400017E RID: 382
		public static string _ValIdentifier;

		// Token: 0x0400017F RID: 383
		public static string m_TestsIdentifier;

		// Token: 0x04000180 RID: 384
		public static int _DicIdentifier;

		// Token: 0x04000181 RID: 385
		public static int _SystemIdentifier;

		// Token: 0x04000182 RID: 386
		public static int _AdvisorIdentifier;

		// Token: 0x04000183 RID: 387
		public static int mockIdentifier;

		// Token: 0x04000184 RID: 388
		public static int codeIdentifier;

		// Token: 0x04000185 RID: 389
		public static string m_AttrIdentifier;

		// Token: 0x04000186 RID: 390
		public static string configurationIdentifier;

		// Token: 0x04000187 RID: 391
		public static long long_0;

		// Token: 0x04000188 RID: 392
		public static object _BridgeIdentifier;

		// Token: 0x04000189 RID: 393
		public static object tagIdentifier;

		// Token: 0x0400018A RID: 394
		public static object objectIdentifier;

		// Token: 0x0400018B RID: 395
		public static List<ProductReaderStructBuilder.RepositoryIdentifier> exporterIdentifier;

		// Token: 0x0400018C RID: 396
		public static List<ProductReaderStructBuilder.RepositoryIdentifier> dispatcherIdentifier;

		// Token: 0x0400018D RID: 397
		public static List<ProductReaderStructBuilder.InvocationWatcherLicense> _ConfigIdentifier;

		// Token: 0x0400018E RID: 398
		public static List<ProductReaderStructBuilder.DicConnectionAttribute> m_BaseIdentifier;

		// Token: 0x0400018F RID: 399
		public static List<ProductReaderStructBuilder.InfoReader> m_DatabaseIdentifier;

		// Token: 0x04000190 RID: 400
		public static List<ProductReaderStructBuilder.BridgePolicyPolicy> _GetterIdentifier;

		// Token: 0x04000191 RID: 401
		public static List<string> customerIdentifier;

		// Token: 0x04000192 RID: 402
		public static Dictionary<int, string> m_MappingIdentifier;

		// Token: 0x04000193 RID: 403
		public static Dictionary<int, bool> m_StatusIdentifier;

		// Token: 0x04000194 RID: 404
		public static long stubIdentifier;

		// Token: 0x04000195 RID: 405
		public static long filterIdentifier;

		// Token: 0x04000196 RID: 406
		public static long _ParamsIdentifier;

		// Token: 0x04000197 RID: 407
		public static long _UtilsIdentifier;

		// Token: 0x04000198 RID: 408
		public static long parserIdentifier;

		// Token: 0x04000199 RID: 409
		public static long _ParameterIdentifier;

		// Token: 0x0400019A RID: 410
		public static long m_StrategyIdentifier;

		// Token: 0x0400019B RID: 411
		public static long _IndexerIdentifier;

		// Token: 0x0400019C RID: 412
		public static int m_ItemIdentifier;

		// Token: 0x0400019D RID: 413
		public static string _PoolIdentifier;

		// Token: 0x0400019E RID: 414
		public static string mapperIdentifier;

		// Token: 0x0400019F RID: 415
		public static string _FieldIdentifier;

		// Token: 0x040001A0 RID: 416
		public static string facadeIdentifier;

		// Token: 0x040001A1 RID: 417
		public static int _AdapterIdentifier;

		// Token: 0x040001A2 RID: 418
		public static Timestamps m_BroadcasterIdentifier;

		// Token: 0x040001A3 RID: 419
		public static int listenerIdentifier;

		// Token: 0x040001A4 RID: 420
		public static bool m_ComposerIdentifier;

		// Token: 0x040001A5 RID: 421
		public static bool _CreatorIdentifier;

		// Token: 0x040001A6 RID: 422
		public static long proxyIdentifier;

		// Token: 0x040001A7 RID: 423
		public static long m_ServiceIdentifier;

		// Token: 0x040001A8 RID: 424
		public static string m_RecordIdentifier;

		// Token: 0x040001A9 RID: 425
		internal static object CalculatePolicy;

		// Token: 0x02000052 RID: 82
		internal struct RepositoryIdentifier
		{
			// Token: 0x040001AA RID: 426
			public string _PageIdentifier;

			// Token: 0x040001AB RID: 427
			public string valueIdentifier;

			// Token: 0x040001AC RID: 428
			public string queueIdentifier;

			// Token: 0x040001AD RID: 429
			public long procIdentifier;
		}

		// Token: 0x02000053 RID: 83
		internal struct InvocationWatcherLicense
		{
			// Token: 0x040001AE RID: 430
			public string _PrototypeReader;

			// Token: 0x040001AF RID: 431
			public string refReader;

			// Token: 0x040001B0 RID: 432
			public string _IdentifierReader;

			// Token: 0x040001B1 RID: 433
			public long _ReaderReader;
		}

		// Token: 0x02000054 RID: 84
		internal struct DicConnectionAttribute
		{
			// Token: 0x040001B2 RID: 434
			public string singletonReader;

			// Token: 0x040001B3 RID: 435
			public string m_RuleReader;

			// Token: 0x040001B4 RID: 436
			public long _AnnotationReader;

			// Token: 0x040001B5 RID: 437
			public string _TemplateReader;
		}

		// Token: 0x02000055 RID: 85
		internal struct InfoReader
		{
			// Token: 0x040001B6 RID: 438
			public string propertyReader;

			// Token: 0x040001B7 RID: 439
			public string m_WatcherReader;

			// Token: 0x040001B8 RID: 440
			public long _ConnectionReader;

			// Token: 0x040001B9 RID: 441
			public string _VisitorReader;

			// Token: 0x040001BA RID: 442
			public string _AuthenticationReader;

			// Token: 0x040001BB RID: 443
			public string _PolicyReader;
		}

		// Token: 0x02000056 RID: 86
		internal struct BridgePolicyPolicy
		{
			// Token: 0x040001BC RID: 444
			public string containerReader;

			// Token: 0x040001BD RID: 445
			public string _InvocationReader;

			// Token: 0x040001BE RID: 446
			public string serverReader;
		}
	}
}
