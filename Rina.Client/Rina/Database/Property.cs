using System;
using System.Collections.Generic;
using System.Linq;
using Rina.Client.Annotations;
using Rina.Client.Attributes;
using Rina.States;

namespace Rina.Database
{
	// Token: 0x0200000C RID: 12
	internal class Property : Process
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000024FD File Offset: 0x000006FD
		public override string Name
		{
			get
			{
				return "QEMU";
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002504 File Offset: 0x00000704
		public override bool FillProperty(IEnumerable<Instance> setup)
		{
			return setup.Any(new Func<Instance, bool>(Property.<>c._Watcher.PublishPrototype));
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000024AC File Offset: 0x000006AC
		public Property()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000252B File Offset: 0x0000072B
		internal static bool CalculateConfig()
		{
			return Property.NewConfig == null;
		}

		// Token: 0x04000013 RID: 19
		internal static object NewConfig;
	}
}
