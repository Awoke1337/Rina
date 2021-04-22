using System;
using System.Management;
using Rina.Client.Annotations;
using Rina.Client.Attributes;

namespace Rina.Tasks
{
	// Token: 0x0200001B RID: 27
	internal class HelperRuleTask : Issuer
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0000297C File Offset: 0x00000B7C
		public HelperRuleTask(ManagementBaseObject spec)
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor(spec);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000296A File Offset: 0x00000B6A
		public override string ToString()
		{
			return base.OrderPrototype();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002994 File Offset: 0x00000B94
		internal static bool ComputeDefinition()
		{
			return HelperRuleTask.MoveDefinition == null;
		}

		// Token: 0x0400003E RID: 62
		internal static object MoveDefinition;
	}
}
