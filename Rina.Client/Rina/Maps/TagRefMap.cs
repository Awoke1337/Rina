using System;
using System.Collections.Generic;
using System.Linq;
using Rina.Client.Annotations;
using Rina.Client.Attributes;
using Rina.Objects;
using Rina.States;

namespace Rina.Maps
{
	// Token: 0x0200000A RID: 10
	internal class TagRefMap : Process
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002458 File Offset: 0x00000658
		public override string Name
		{
			get
			{
				return "Microsoft Hyper-V";
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000245F File Offset: 0x0000065F
		public override bool FillProperty(IEnumerable<Instance> v)
		{
			return v.Any(new Func<Instance, bool>(TagRefMap.<>c.m_Template.StartPrototype));
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002486 File Offset: 0x00000686
		public override bool DisableProperty(RefSingletonObject item)
		{
			return item.Manufacturer.Contains("microsoft") && item.Model.Contains("virtual");
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000024AC File Offset: 0x000006AC
		public TagRefMap()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000024B9 File Offset: 0x000006B9
		internal static bool PopConfig()
		{
			return TagRefMap.SetConfig == null;
		}

		// Token: 0x0400000F RID: 15
		private static object SetConfig;
	}
}
