using System;
using System.Diagnostics;
using Rina.Client.Attributes;
using Rina.Structs;

namespace Rina.Composer
{
	// Token: 0x02000035 RID: 53
	internal class StatusRef
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00003198 File Offset: 0x00001398
		public static long DeleteReader(long IDitem)
		{
			return IDitem * 100L / ProductReaderStructBuilder.m_StrategyIdentifier;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000031AB File Offset: 0x000013AB
		public static double CallReader(double reference)
		{
			return reference / 1024.0 / 1024.0;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000FF78 File Offset: 0x0000E178
		public static double RateReader(double def, Stopwatch reg)
		{
			return def / 1024.0 / reg.Elapsed.TotalSeconds;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000024D4 File Offset: 0x000006D4
		public StatusRef()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000031C2 File Offset: 0x000013C2
		internal static bool InitOrder()
		{
			return StatusRef.PublishOrder == null;
		}

		// Token: 0x04000103 RID: 259
		private static object PublishOrder;
	}
}
