using System;
using System.Collections.Generic;
using System.Linq;
using Rina.Client.Annotations;
using Rina.Client.Attributes;

namespace Rina.Composer
{
	// Token: 0x02000010 RID: 16
	internal class SerializerPropertyComp : Process
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000025DA File Offset: 0x000007DA
		public override string Name
		{
			get
			{
				return "Microsoft Virtual PC";
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000025E1 File Offset: 0x000007E1
		public override bool EnableProperty(IEnumerable<string> ident)
		{
			return (ident.Contains("vpcmap") && ident.Contains("vmsrvc")) || ident.Contains("vmusrvc");
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000024AC File Offset: 0x000006AC
		public SerializerPropertyComp()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000260A File Offset: 0x0000080A
		internal static bool VerifyConfig()
		{
			return SerializerPropertyComp.ChangeConfig == null;
		}

		// Token: 0x0400001B RID: 27
		internal static object ChangeConfig;
	}
}
