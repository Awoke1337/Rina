using System;
using System.Management;
using Rina.Client.Annotations;
using Rina.Client.Attributes;

namespace Rina.States
{
	// Token: 0x0200001A RID: 26
	internal class Instance : Issuer
	{
		// Token: 0x0600006E RID: 110 RVA: 0x0000297C File Offset: 0x00000B7C
		public Instance(ManagementBaseObject item)
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor(item);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000298A File Offset: 0x00000B8A
		internal static bool ValidateDefinition()
		{
			return Instance.ForgotDefinition == null;
		}

		// Token: 0x0400003D RID: 61
		internal static object ForgotDefinition;
	}
}
