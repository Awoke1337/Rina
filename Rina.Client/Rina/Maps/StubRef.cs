using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Rina.Authentication;
using Rina.Client.Attributes;
using Rina.Client.Roles;
using Rina.Composer;
using Rina.Database;
using Rina.Objects;
using Rina.Structs;

namespace Rina.Maps
{
	// Token: 0x02000036 RID: 54
	internal class StubRef
	{
		// Token: 0x0600019E RID: 414 RVA: 0x0000FFA0 File Offset: 0x0000E1A0
		public static void ValidateReader()
		{
			StubRef.filterRef.WorkerReportsProgress = true;
			StubRef.filterRef.DoWork += new DoWorkEventHandler(StubRef.VerifyReader);
			StubRef.filterRef.ProgressChanged += StubRef.PopReader;
			StubRef.filterRef.RunWorkerCompleted += new RunWorkerCompletedEventHandler(StubRef.FillReader);
			if (!StubRef.filterRef.IsBusy)
			{
				StubRef.filterRef.RunWorkerAsync();
				return;
			}
			MessageBox.Show(RegistryReader.DisableRule("UNKNOWNERROR", new object[]
			{
				"CheckFiles isBusy"
			}));
			Application.Exit();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00010034 File Offset: 0x0000E234
		private static void VerifyReader(object key, object result)
		{
			MapperRef mapperRef = new MapperRef();
			mapperRef.IncludeReader();
			mapperRef.ViewSingleton();
			foreach (ProductReaderStructBuilder.RepositoryIdentifier repositoryIdentifier in ProductReaderStructBuilder.exporterIdentifier)
			{
				ProductReaderStructBuilder.m_StrategyIdentifier += repositoryIdentifier.procIdentifier;
				StubRef.filterRef.ReportProgress(0, Path.GetFileName(repositoryIdentifier._PageIdentifier));
				if (!File.Exists(MapperRef.fieldRef + "\\" + repositoryIdentifier._PageIdentifier) || MappingRef.FlushReader(MapperRef.fieldRef + "\\" + repositoryIdentifier._PageIdentifier) != repositoryIdentifier.queueIdentifier)
				{
					ProductReaderStructBuilder.customerIdentifier.Add(repositoryIdentifier._PageIdentifier);
				}
				else
				{
					ProductReaderStructBuilder._IndexerIdentifier += repositoryIdentifier.procIdentifier;
					StubRef.filterRef.ReportProgress(1);
				}
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000031CC File Offset: 0x000013CC
		private static void PopReader(object sender, ProgressChangedEventArgs e)
		{
			if (e.ProgressPercentage != 0)
			{
				MappingRef.SetReader(StatusRef.DeleteReader(ProductReaderStructBuilder._IndexerIdentifier));
				return;
			}
			MappingRef.LoginReader("CHECKFILE", new string[]
			{
				e.UserState.ToString()
			});
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00003204 File Offset: 0x00001404
		private static void FillReader(object task, object caller)
		{
			ProducerContainerRole.DisableReader();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000024D4 File Offset: 0x000006D4
		public StubRef()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000320B File Offset: 0x0000140B
		static StubRef()
		{
			AdvisorConnectionAttribute.CancelComposer();
			StubRef.filterRef = new BackgroundWorker();
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000321C File Offset: 0x0000141C
		internal static bool FlushOrder()
		{
			return StubRef.InstantiateOrder == null;
		}

		// Token: 0x04000104 RID: 260
		private static BackgroundWorker filterRef;

		// Token: 0x04000105 RID: 261
		internal static object InstantiateOrder;

		// Token: 0x02000037 RID: 55
		private enum XmlNamespaceScope
		{

		}
	}
}
