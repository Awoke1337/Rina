using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Rina.Client.Attributes;

namespace Rina.Client.Properties
{
	// Token: 0x02000028 RID: 40
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x000024D4 File Offset: 0x000006D4
		internal Resources()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002B1B File Offset: 0x00000D1B
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.m_Method == null)
				{
					Resources.m_Method = new ResourceManager("Rina.Client.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.m_Method;
			}
		}

		// Token: 0x17000014 RID: 20
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002B47 File Offset: 0x00000D47
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			set
			{
				Resources._Decorator = value;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002B4F File Offset: 0x00000D4F
		internal static bool ChangeDefinition()
		{
			return Resources.FindDefinition == null;
		}

		// Token: 0x04000064 RID: 100
		private static ResourceManager m_Method;

		// Token: 0x04000065 RID: 101
		private static CultureInfo _Decorator;

		// Token: 0x04000066 RID: 102
		internal static Resources FindDefinition;
	}
}
