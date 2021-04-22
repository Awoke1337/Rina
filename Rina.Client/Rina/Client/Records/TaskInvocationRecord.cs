using System;
using Rina.Client.Attributes;
using Rina.Structs;

namespace Rina.Client.Records
{
	// Token: 0x02000058 RID: 88
	internal class TaskInvocationRecord
	{
		// Token: 0x06000250 RID: 592 RVA: 0x0001461C File Offset: 0x0001281C
		public static void SortRule(string setup)
		{
			ProductReaderStructBuilder.RepositoryIdentifier item = default(ProductReaderStructBuilder.RepositoryIdentifier);
			item._PageIdentifier = setup.Split(new char[]
			{
				' '
			})[0];
			item.queueIdentifier = setup.Split(new char[]
			{
				' '
			})[1];
			item.procIdentifier = Convert.ToInt64(setup.Split(new char[]
			{
				' '
			})[2]);
			ProductReaderStructBuilder.exporterIdentifier.Add(item);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00014690 File Offset: 0x00012890
		public static void ChangeRule(string item)
		{
			ProductReaderStructBuilder.InvocationWatcherLicense item2 = default(ProductReaderStructBuilder.InvocationWatcherLicense);
			item2._PrototypeReader = item.Split(new char[]
			{
				'|'
			})[0];
			item2.refReader = item.Split(new char[]
			{
				'|'
			})[1];
			item2._IdentifierReader = item.Split(new char[]
			{
				'|'
			})[2];
			item2._ReaderReader = Convert.ToInt64(item.Split(new char[]
			{
				'|'
			})[3]);
			ProductReaderStructBuilder._ConfigIdentifier.Add(item2);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00014720 File Offset: 0x00012920
		public static void LoginRule(string def)
		{
			ProductReaderStructBuilder.DicConnectionAttribute item = default(ProductReaderStructBuilder.DicConnectionAttribute);
			item.singletonReader = def.Split(new char[]
			{
				'|'
			})[0];
			item.m_RuleReader = def.Split(new char[]
			{
				'|'
			})[1];
			item._AnnotationReader = Convert.ToInt64(def.Split(new char[]
			{
				'|'
			})[2]);
			item._TemplateReader = def.Split(new char[]
			{
				'|'
			})[3];
			ProductReaderStructBuilder.m_BaseIdentifier.Add(item);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000147B0 File Offset: 0x000129B0
		public static void SetRule(string info)
		{
			ProductReaderStructBuilder.RepositoryIdentifier item = default(ProductReaderStructBuilder.RepositoryIdentifier);
			item._PageIdentifier = info.Split(new char[]
			{
				'|'
			})[0];
			item.queueIdentifier = info.Split(new char[]
			{
				'|'
			})[1];
			item.valueIdentifier = info.Split(new char[]
			{
				'|'
			})[2];
			item.procIdentifier = Convert.ToInt64(info.Split(new char[]
			{
				'|'
			})[3]);
			ProductReaderStructBuilder.dispatcherIdentifier.Add(item);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00014840 File Offset: 0x00012A40
		public static void AwakeRule(string spec)
		{
			ProductReaderStructBuilder.InfoReader item = default(ProductReaderStructBuilder.InfoReader);
			item.propertyReader = spec.Split(new char[]
			{
				'|'
			})[0];
			item.m_WatcherReader = spec.Split(new char[]
			{
				'|'
			})[1];
			item._ConnectionReader = Convert.ToInt64(spec.Split(new char[]
			{
				'|'
			})[2]);
			item._VisitorReader = spec.Split(new char[]
			{
				'|'
			})[3];
			item._AuthenticationReader = spec.Split(new char[]
			{
				'|'
			})[4];
			item._PolicyReader = spec.Split(new char[]
			{
				'|'
			})[5];
			ProductReaderStructBuilder.m_DatabaseIdentifier.Add(item);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00014904 File Offset: 0x00012B04
		public static void CustomizeRule(string item)
		{
			ProductReaderStructBuilder.BridgePolicyPolicy item2 = default(ProductReaderStructBuilder.BridgePolicyPolicy);
			item2.containerReader = item.Split(new char[]
			{
				'|'
			})[0];
			item2._InvocationReader = item.Split(new char[]
			{
				'|'
			})[1];
			item2.serverReader = item.Split(new char[]
			{
				'|'
			})[2];
			ProductReaderStructBuilder._GetterIdentifier.Add(item2);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000024D4 File Offset: 0x000006D4
		public TaskInvocationRecord()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000035CA File Offset: 0x000017CA
		internal static bool VisitPolicy()
		{
			return TaskInvocationRecord.PrintPolicy == null;
		}

		// Token: 0x040001C0 RID: 448
		private static object PrintPolicy;
	}
}
