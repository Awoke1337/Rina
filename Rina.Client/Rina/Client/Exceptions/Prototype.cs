using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Rina.Client.Attributes;

namespace Rina.Client.Exceptions
{
	// Token: 0x02000002 RID: 2
	internal sealed class Prototype : HashAlgorithm
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000023E2 File Offset: 0x000005E2
		public Prototype()
		{
			AdvisorConnectionAttribute.CancelComposer();
			this..ctor(3988292384U, uint.MaxValue);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00005070 File Offset: 0x00003270
		public Prototype(uint idx_setup, uint map)
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
			this.reader = Prototype.InstantiatePrototype(idx_setup);
			this.m_Singleton = map;
			this.uint_0 = map;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000023F5 File Offset: 0x000005F5
		public override void Initialize()
		{
			this.m_Singleton = this.uint_0;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002403 File Offset: 0x00000603
		protected override void HashCore(byte[] var1, int selection_min, int startstate)
		{
			this.m_Singleton = Prototype.InterruptPrototype(this.reader, this.m_Singleton, var1, selection_min, startstate);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000050A4 File Offset: 0x000032A4
		protected override byte[] HashFinal()
		{
			byte[] array = Prototype.PushPrototype(~this.m_Singleton);
			this.HashValue = array;
			return array;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000241F File Offset: 0x0000061F
		public override int HashSize
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002423 File Offset: 0x00000623
		public static uint QueryPrototype(object info)
		{
			return Prototype.AddPrototype(uint.MaxValue, info);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000242C File Offset: 0x0000062C
		public static uint AddPrototype(uint uint_1, object pred)
		{
			return Prototype.ExcludePrototype(3988292384U, uint_1, pred);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000243A File Offset: 0x0000063A
		public static uint ExcludePrototype(uint taskstart, uint token, object template)
		{
			return ~Prototype.InterruptPrototype(Prototype.InstantiatePrototype(taskstart), token, template, 0, template.Length);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000050C8 File Offset: 0x000032C8
		private static uint[] InstantiatePrototype(uint spec_X)
		{
			if (spec_X == 3988292384U && Prototype.m_Ref != null)
			{
				return Prototype.m_Ref;
			}
			uint[] array = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ spec_X);
					}
					else
					{
						num >>= 1;
					}
				}
				array[i] = num;
			}
			if (spec_X == 3988292384U)
			{
				Prototype.m_Ref = array;
			}
			return array;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00005138 File Offset: 0x00003338
		private static uint InterruptPrototype(object reference, uint next_pred, IList<byte> dic, int cfg2ID, int int_0)
		{
			uint num = next_pred;
			for (int i = cfg2ID; i < int_0 - cfg2ID; i++)
			{
				num = (num >> 8 ^ reference[(int)((uint)dic[i] ^ (num & 255U))]);
			}
			return num;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00005170 File Offset: 0x00003370
		private static byte[] PushPrototype(uint instancestart)
		{
			byte[] bytes = BitConverter.GetBytes(instancestart);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			return bytes;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000244E File Offset: 0x0000064E
		internal static bool MoveConfig()
		{
			return Prototype.CallConfig == null;
		}

		// Token: 0x04000002 RID: 2
		private static uint[] m_Ref;

		// Token: 0x04000003 RID: 3
		private readonly uint uint_0;

		// Token: 0x04000004 RID: 4
		private readonly uint[] reader;

		// Token: 0x04000005 RID: 5
		private uint m_Singleton;

		// Token: 0x04000006 RID: 6
		private static object CallConfig;
	}
}
