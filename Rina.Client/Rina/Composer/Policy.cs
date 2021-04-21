using System;
using System.Collections.Generic;
using System.Linq;
using Rina.Client.Annotations;
using Rina.Client.Attributes;
using Rina.Objects;
using Rina.States;

namespace Rina.Composer
{
	// Token: 0x02000011 RID: 17
	internal abstract class Policy : Process
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002614 File Offset: 0x00000814
		public override string Name
		{
			get
			{
				return "VMware";
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000261B File Offset: 0x0000081B
		public override bool FillProperty(IEnumerable<Instance> value)
		{
			return value.Any(new Func<Instance, bool>(Policy.<>c._Container.SelectPrototype));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002642 File Offset: 0x00000842
		public override bool DisableProperty(RefSingletonObject value)
		{
			return value.Manufacturer.Contains("vmware") && value.Model.Contains("virtual");
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000024AC File Offset: 0x000006AC
		protected Policy()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002668 File Offset: 0x00000868
		internal static bool DeleteConfig()
		{
			return Policy.InsertConfig == null;
		}

		// Token: 0x0400001C RID: 28
		internal static object InsertConfig;
	}
}
