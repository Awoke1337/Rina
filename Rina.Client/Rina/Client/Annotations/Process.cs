using System;
using System.Collections.Generic;
using Rina.Client.Attributes;
using Rina.Client.Exceptions;
using Rina.Client.Licensing;
using Rina.Objects;
using Rina.States;
using Rina.Structs;

namespace Rina.Client.Annotations
{
	// Token: 0x0200001E RID: 30
	internal abstract class Process : UtilsTemplateStatus
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000083 RID: 131
		public abstract string Name { get; }

		// Token: 0x06000084 RID: 132 RVA: 0x00002A1E File Offset: 0x00000C1E
		public virtual bool CheckProperty(IEnumerable<RoleVisitorException> key)
		{
			return false;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002A1E File Offset: 0x00000C1E
		public virtual bool FillProperty(IEnumerable<Instance> asset)
		{
			return false;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002A1E File Offset: 0x00000C1E
		public virtual bool EnableProperty(IEnumerable<string> item)
		{
			return false;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002A1E File Offset: 0x00000C1E
		public virtual bool TestProperty(IEnumerable<ContainerWatcherLicense> value)
		{
			return false;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002A1E File Offset: 0x00000C1E
		public virtual bool DisableProperty(StructReaderStructBuilder config)
		{
			return false;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002A1E File Offset: 0x00000C1E
		public virtual bool DisableProperty(RefSingletonObject instance)
		{
			return false;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000586C File Offset: 0x00003A6C
		public virtual bool CloneProperty(RefSingletonObject first, StructReaderStructBuilder second, IEnumerable<Instance> template, IEnumerable<RoleVisitorException> visitor2, IEnumerable<string> attr3, IEnumerable<ContainerWatcherLicense> counter4)
		{
			bool flag = this.DisableProperty(first);
			bool flag2 = this.DisableProperty(second);
			bool flag3 = this.FillProperty(template);
			bool flag4 = this.CheckProperty(visitor2);
			bool flag5 = this.EnableProperty(attr3);
			bool flag6 = this.TestProperty(counter4);
			return flag || flag2 || flag3 || flag4 || flag5 || flag6;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000024D4 File Offset: 0x000006D4
		protected Process()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002A21 File Offset: 0x00000C21
		internal static bool ExcludeDefinition()
		{
			return Process.PushDefinition == null;
		}

		// Token: 0x04000047 RID: 71
		internal static object PushDefinition;
	}
}
