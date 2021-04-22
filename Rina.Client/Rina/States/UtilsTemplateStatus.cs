using System;
using System.Collections.Generic;
using Rina.Client.Exceptions;
using Rina.Client.Licensing;
using Rina.Objects;
using Rina.Structs;

namespace Rina.States
{
	// Token: 0x0200001F RID: 31
	internal interface UtilsTemplateStatus
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600008D RID: 141
		string Name { get; }

		// Token: 0x0600008E RID: 142
		bool DisableProperty(RefSingletonObject reference);

		// Token: 0x0600008F RID: 143
		bool DisableProperty(StructReaderStructBuilder i);

		// Token: 0x06000090 RID: 144
		bool FillProperty(IEnumerable<Instance> config);

		// Token: 0x06000091 RID: 145
		bool CheckProperty(IEnumerable<RoleVisitorException> item);

		// Token: 0x06000092 RID: 146
		bool EnableProperty(IEnumerable<string> setup);

		// Token: 0x06000093 RID: 147
		bool TestProperty(IEnumerable<ContainerWatcherLicense> info);

		// Token: 0x06000094 RID: 148
		bool CloneProperty(RefSingletonObject config, StructReaderStructBuilder second, IEnumerable<Instance> control, IEnumerable<RoleVisitorException> ivk2, IEnumerable<string> cont3, IEnumerable<ContainerWatcherLicense> ord4);
	}
}
