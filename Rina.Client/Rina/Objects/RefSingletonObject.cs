using System;
using System.Management;
using System.Runtime.CompilerServices;
using Rina.Client.Annotations;
using Rina.Client.Attributes;

namespace Rina.Objects
{
	// Token: 0x02000019 RID: 25
	internal class RefSingletonObject : Issuer
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002959 File Offset: 0x00000B59
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002961 File Offset: 0x00000B61
		public string OEMStringArray { get; set; }

		// Token: 0x0600006B RID: 107 RVA: 0x00005698 File Offset: 0x00003898
		public RefSingletonObject(ManagementBaseObject ident)
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor(ident);
			object obj = ident["OEMStringArray"];
			if (obj != null)
			{
				this.OEMStringArray = base.DefinePrototype(obj).ToLower();
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000296A File Offset: 0x00000B6A
		public override string ToString()
		{
			return base.OrderPrototype();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002972 File Offset: 0x00000B72
		internal static bool DestroyDefinition()
		{
			return RefSingletonObject.AssetDefinition == null;
		}

		// Token: 0x0400003B RID: 59
		[CompilerGenerated]
		private string _Consumer;

		// Token: 0x0400003C RID: 60
		internal static object AssetDefinition;
	}
}
