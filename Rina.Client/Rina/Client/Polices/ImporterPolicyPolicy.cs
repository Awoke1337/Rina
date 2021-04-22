using System;
using System.Collections.Generic;
using System.Linq;
using Rina.Client.Annotations;
using Rina.Client.Attributes;
using Rina.States;

namespace Rina.Client.Polices
{
	// Token: 0x0200000E RID: 14
	internal class ImporterPolicyPolicy : Process
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002568 File Offset: 0x00000768
		public override string Name
		{
			get
			{
				return "VirtualBox";
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000256F File Offset: 0x0000076F
		public override bool FillProperty(IEnumerable<Instance> spec)
		{
			return spec.Any(new Func<Instance, bool>(ImporterPolicyPolicy.<>c.visitor.ResetPrototype));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002596 File Offset: 0x00000796
		public override bool EnableProperty(IEnumerable<string> param)
		{
			return param.Contains("vboxservice");
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000024AC File Offset: 0x000006AC
		public ImporterPolicyPolicy()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000025A3 File Offset: 0x000007A3
		internal static bool TestConfig()
		{
			return ImporterPolicyPolicy.DisableConfig == null;
		}

		// Token: 0x04000017 RID: 23
		internal static object DisableConfig;
	}
}
