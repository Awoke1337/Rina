using System;
using System.Reflection;
using Rina.Client.Attributes;

namespace Rina.Dispatcher
{
	// Token: 0x0200008E RID: 142
	internal class MappingSingletonDispatcher
	{
		// Token: 0x06000513 RID: 1299 RVA: 0x00020D64 File Offset: 0x0001EF64
		internal static void AssetComposer(int typemdt)
		{
			Type type = MappingSingletonDispatcher.m_VisitorSingleton.ResolveType(33554432 + typemdt);
			foreach (FieldInfo fieldInfo in type.GetFields())
			{
				MethodInfo method = (MethodInfo)MappingSingletonDispatcher.m_VisitorSingleton.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000024D4 File Offset: 0x000006D4
		public MappingSingletonDispatcher()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000500B File Offset: 0x0000320B
		static MappingSingletonDispatcher()
		{
			AdvisorConnectionAttribute.CancelComposer();
			MappingSingletonDispatcher.m_VisitorSingleton = typeof(MappingSingletonDispatcher).Assembly.ManifestModule;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000502B File Offset: 0x0000322B
		internal static bool OrderBridge()
		{
			return MappingSingletonDispatcher.PatchBridge == null;
		}

		// Token: 0x0400025E RID: 606
		internal static Module m_VisitorSingleton;

		// Token: 0x0400025F RID: 607
		private static object PatchBridge;

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x06000518 RID: 1304
		internal delegate void ServerWatcherLicense(object o);
	}
}
