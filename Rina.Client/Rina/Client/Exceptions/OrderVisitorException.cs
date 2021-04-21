using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Rina.Client.Attributes;
using Rina.Structs;

namespace Rina.Client.Exceptions
{
	// Token: 0x02000039 RID: 57
	internal class OrderVisitorException
	{
		// Token: 0x060001AB RID: 427 RVA: 0x0000327F File Offset: 0x0000147F
		[CompilerGenerated]
		public static bool DestroyReader()
		{
			return OrderVisitorException.m_StrategyRef;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00003286 File Offset: 0x00001486
		[CompilerGenerated]
		public static void CloneReader(bool setvalue)
		{
			OrderVisitorException.m_StrategyRef = setvalue;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0001032C File Offset: 0x0000E52C
		public static void TestReader(string init, string cont)
		{
			OrderVisitorException.<>c__DisplayClass5_0 CS$<>8__locals1 = new OrderVisitorException.<>c__DisplayClass5_0();
			CS$<>8__locals1.string_0 = init;
			CS$<>8__locals1.m_PoolRef = cont;
			if (!OrderVisitorException.m_StrategyRef)
			{
				ProductReaderStructBuilder.tagIdentifier.PostIdentifier();
				ProductReaderStructBuilder.tagIdentifier.BringToFront();
				OrderVisitorException.CloneReader(true);
				OrderVisitorException.thread_0 = new Thread(new ThreadStart(CS$<>8__locals1.VisitReader));
				OrderVisitorException.thread_0.Start();
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000024D4 File Offset: 0x000006D4
		public OrderVisitorException()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000328E File Offset: 0x0000148E
		internal static bool CalculateOrder()
		{
			return OrderVisitorException.NewOrder == null;
		}

		// Token: 0x0400010C RID: 268
		[CompilerGenerated]
		private static bool m_StrategyRef;

		// Token: 0x0400010D RID: 269
		public static Thread thread_0;

		// Token: 0x0400010E RID: 270
		internal static object NewOrder;
	}
}
