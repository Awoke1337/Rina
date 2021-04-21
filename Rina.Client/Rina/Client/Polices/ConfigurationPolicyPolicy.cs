using System;
using System.Runtime.InteropServices;

namespace Rina.Client.Polices
{
	// Token: 0x02000009 RID: 9
	internal struct ConfigurationPolicyPolicy
	{
		// Token: 0x0400000D RID: 13
		[MarshalAs(UnmanagedType.U1)]
		public bool m_Rule;

		// Token: 0x0400000E RID: 14
		[MarshalAs(UnmanagedType.U1)]
		public bool _Annotation;
	}
}
