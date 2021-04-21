using System;
using System.Collections.Generic;
using System.Linq;
using Rina.Client.Attributes;
using Rina.Client.Exceptions;
using Rina.Client.Licensing;
using Rina.Composer;
using Rina.Objects;
using Rina.States;
using Rina.Structs;

namespace Rina.Maps
{
	// Token: 0x02000013 RID: 19
	internal class ObjectRefMap : Policy
	{
		// Token: 0x06000037 RID: 55 RVA: 0x0000269F File Offset: 0x0000089F
		public override bool DisableProperty(StructReaderStructBuilder var1)
		{
			return var1.SerialNumber.Contains("vmware");
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000026B1 File Offset: 0x000008B1
		public override bool DisableProperty(RefSingletonObject reference)
		{
			return reference.Manufacturer.Contains("vmware") || reference.Model.Contains("vmware") || reference.OEMStringArray.Contains("virtual");
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000026E9 File Offset: 0x000008E9
		public override bool FillProperty(IEnumerable<Instance> param)
		{
			return param.Any(new Func<Instance, bool>(ObjectRefMap.<>c.m_Server.InitPrototype));
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005194 File Offset: 0x00003394
		public override bool CheckProperty(IEnumerable<RoleVisitorException> i)
		{
			if (!i.Any(new Func<RoleVisitorException, bool>(ObjectRefMap.<>c.m_Server.PrintPrototype)))
			{
				if (!i.Any(new Func<RoleVisitorException, bool>(ObjectRefMap.<>c.m_Server.CountPrototype)))
				{
					if (!i.Any(new Func<RoleVisitorException, bool>(ObjectRefMap.<>c.m_Server.StopPrototype)))
					{
						if (!i.Any(new Func<RoleVisitorException, bool>(ObjectRefMap.<>c.m_Server.MovePrototype)))
						{
							if (!i.Any(new Func<RoleVisitorException, bool>(ObjectRefMap.<>c.m_Server.SearchPrototype)))
							{
								return i.Any(new Func<RoleVisitorException, bool>(ObjectRefMap.<>c.m_Server.ConnectPrototype));
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005294 File Offset: 0x00003494
		public override bool TestProperty(IEnumerable<ContainerWatcherLicense> reference)
		{
			if (!reference.Any(new Func<ContainerWatcherLicense, bool>(ObjectRefMap.<>c.m_Server.SetupPrototype)))
			{
				if (!reference.Any(new Func<ContainerWatcherLicense, bool>(ObjectRefMap.<>c.m_Server.GetPrototype)))
				{
					return reference.Any(new Func<ContainerWatcherLicense, bool>(ObjectRefMap.<>c.m_Server.PostPrototype));
				}
			}
			return true;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002710 File Offset: 0x00000910
		public ObjectRefMap()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000271D File Offset: 0x0000091D
		internal static bool PrintConfig()
		{
			return ObjectRefMap.UpdateConfig == null;
		}

		// Token: 0x04000020 RID: 32
		internal static object UpdateConfig;
	}
}
