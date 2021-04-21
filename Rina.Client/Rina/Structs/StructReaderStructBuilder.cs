using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using Rina.Client.Annotations;
using Rina.Client.Attributes;
using Rina.Instances;

namespace Rina.Structs
{
	// Token: 0x02000017 RID: 23
	internal class StructReaderStructBuilder : Issuer
	{
		// Token: 0x0600005E RID: 94 RVA: 0x0000290F File Offset: 0x00000B0F
		[CompilerGenerated]
		public IEnumerable<ShelvingOptions> SetPrototype()
		{
			return this.test;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002917 File Offset: 0x00000B17
		[CompilerGenerated]
		private void AwakePrototype(IEnumerable<ShelvingOptions> value)
		{
			this.test = value;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002920 File Offset: 0x00000B20
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002928 File Offset: 0x00000B28
		public string SerialNumber { get; private set; }

		// Token: 0x06000062 RID: 98 RVA: 0x0000558C File Offset: 0x0000378C
		public StructReaderStructBuilder(ManagementBaseObject last)
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor(last);
			ushort[] source = (ushort[])last["BiosCharacteristics"];
			this.AwakePrototype(source.Select(new Func<ushort, ShelvingOptions>(StructReaderStructBuilder.<>c.m_Comparator.FlushPrototype)).ToArray<ShelvingOptions>());
			this.SerialNumber = base.CollectPrototype<string>(last, "SerialNumber");
			if (!string.IsNullOrEmpty(this.SerialNumber))
			{
				this.SerialNumber = this.SerialNumber.ToLower();
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005618 File Offset: 0x00003818
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(base.OrderPrototype());
			foreach (ShelvingOptions shelvingOptions in this.SetPrototype())
			{
				string name = Enum.GetName(typeof(ShelvingOptions), shelvingOptions);
				stringBuilder.AppendLine(name);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002931 File Offset: 0x00000B31
		internal static bool CollectConfig()
		{
			return StructReaderStructBuilder.ReflectConfig == null;
		}

		// Token: 0x04000035 RID: 53
		[CompilerGenerated]
		private IEnumerable<ShelvingOptions> test;

		// Token: 0x04000036 RID: 54
		[CompilerGenerated]
		private string expression;

		// Token: 0x04000037 RID: 55
		internal static object ReflectConfig;
	}
}
