using System;
using System.Management;
using Rina.Client.Annotations;
using Rina.Client.Attributes;

namespace Rina.Client.Exceptions
{
	// Token: 0x0200001C RID: 28
	internal class RoleVisitorException : Issuer
	{
		// Token: 0x06000073 RID: 115 RVA: 0x0000297C File Offset: 0x00000B7C
		public RoleVisitorException(ManagementBaseObject param)
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor(param);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000299E File Offset: 0x00000B9E
		internal static bool InterruptDefinition()
		{
			return RoleVisitorException.EnableDefinition == null;
		}

		// Token: 0x0400003F RID: 63
		internal static object EnableDefinition;
	}
}
