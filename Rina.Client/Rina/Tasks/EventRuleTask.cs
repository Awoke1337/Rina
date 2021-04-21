using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using Rina.Client.Attributes;
using Rina.Client.Exceptions;
using Rina.Client.Licensing;
using Rina.Client.Polices;
using Rina.Database;
using Rina.Maps;
using Rina.Objects;
using Rina.States;
using Rina.Structs;

namespace Rina.Tasks
{
	// Token: 0x02000020 RID: 32
	internal class EventRuleTask
	{
		// Token: 0x06000095 RID: 149 RVA: 0x000058B8 File Offset: 0x00003AB8
		static EventRuleTask()
		{
			AdvisorConnectionAttribute.CancelComposer();
			EventRuleTask.m_Schema = new UtilsTemplateStatus[]
			{
				new ObjectRefMap(),
				new TagRefMap(),
				new Property(),
				new ImporterPolicyPolicy()
			};
			EventRuleTask.tokenizer = EventRuleTask.LogoutPrototype<RefSingletonObject>("Win32_ComputerSystem");
			EventRuleTask.role = EventRuleTask.LogoutPrototype<StructReaderStructBuilder>("Win32_BIOS");
			EventRuleTask.object_0 = EventRuleTask.LogoutPrototype<HelperRuleTask>("Win32_MotherboardDevice");
			EventRuleTask._Algo = EventRuleTask.UpdatePrototype<RoleVisitorException>("Win32_PnPEntity");
			EventRuleTask.order = EventRuleTask.UpdatePrototype<Instance>("Win32_DiskDrive");
			EventRuleTask.m_Iterator = EventRuleTask.VisitPrototype();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000594C File Offset: 0x00003B4C
		public static bool ClonePrototype(out string v)
		{
			EventRuleTask.<>c__DisplayClass8_0 CS$<>8__locals1 = new EventRuleTask.<>c__DisplayClass8_0();
			CS$<>8__locals1._Message = Process.GetProcesses().Select(new Func<Process, string>(EventRuleTask.<>c.m_Wrapper.PatchPrototype)).OrderBy(new Func<string, string>(EventRuleTask.<>c.m_Wrapper.ResolvePrototype)).ToArray<string>();
			UtilsTemplateStatus utilsTemplateStatus = EventRuleTask.m_Schema.FirstOrDefault(new Func<UtilsTemplateStatus, bool>(CS$<>8__locals1.CalculatePrototype));
			bool flag = utilsTemplateStatus != null;
			v = ((!flag) ? null : utilsTemplateStatus.Name);
			return flag;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000059E4 File Offset: 0x00003BE4
		public static bool NewPrototype()
		{
			string text;
			return EventRuleTask.ClonePrototype(out text);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000059F8 File Offset: 0x00003BF8
		private static IEnumerable<ContainerWatcherLicense> VisitPrototype()
		{
			return ServiceController.GetServices().Select(new Func<ServiceController, ContainerWatcherLicense>(EventRuleTask.<>c.m_Wrapper.CancelPrototype)).OrderBy(new Func<ContainerWatcherLicense, string>(EventRuleTask.<>c.m_Wrapper.ViewPrototype)).ToArray<ContainerWatcherLicense>();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00005A58 File Offset: 0x00003C58
		private static T LogoutPrototype<T>(string key)
		{
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementClass(key).GetInstances().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ManagementBaseObject managementBaseObject = enumerator.Current;
					return (T)((object)Activator.CreateInstance(typeof(T), new object[]
					{
						managementBaseObject
					}));
				}
			}
			return default(T);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00005AD0 File Offset: 0x00003CD0
		private static List<T> UpdatePrototype<T>(string instance)
		{
			ManagementClass managementClass = new ManagementClass(instance);
			List<T> list = new List<T>();
			foreach (ManagementBaseObject managementBaseObject in managementClass.GetInstances())
			{
				list.Add((T)((object)Activator.CreateInstance(typeof(T), new object[]
				{
					managementBaseObject
				})));
			}
			return list;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000024D4 File Offset: 0x000006D4
		public EventRuleTask()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002A2B File Offset: 0x00000C2B
		internal static bool PublishDefinition()
		{
			return EventRuleTask.ReadDefinition == null;
		}

		// Token: 0x04000048 RID: 72
		private static UtilsTemplateStatus[] m_Schema;

		// Token: 0x04000049 RID: 73
		private static RefSingletonObject tokenizer;

		// Token: 0x0400004A RID: 74
		private static StructReaderStructBuilder role;

		// Token: 0x0400004B RID: 75
		private static object object_0;

		// Token: 0x0400004C RID: 76
		private static IEnumerable<Instance> order;

		// Token: 0x0400004D RID: 77
		private static IEnumerable<RoleVisitorException> _Algo;

		// Token: 0x0400004E RID: 78
		private static IEnumerable<ContainerWatcherLicense> m_Iterator;

		// Token: 0x0400004F RID: 79
		private static object ReadDefinition;
	}
}
