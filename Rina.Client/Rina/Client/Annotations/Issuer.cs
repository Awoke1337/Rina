using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.Script.Serialization;
using Rina.Client.Attributes;

namespace Rina.Client.Annotations
{
	// Token: 0x02000015 RID: 21
	internal abstract class Issuer
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00002832 File Offset: 0x00000A32
		[CompilerGenerated]
		public Dictionary<string, object> ListPrototype()
		{
			return this._Definition;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000283A File Offset: 0x00000A3A
		[CompilerGenerated]
		public void RestartPrototype(Dictionary<string, object> last)
		{
			this._Definition = last;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002843 File Offset: 0x00000A43
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000284B File Offset: 0x00000A4B
		public string Caption { get; protected set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002854 File Offset: 0x00000A54
		// (set) Token: 0x06000050 RID: 80 RVA: 0x0000285C File Offset: 0x00000A5C
		public string Name { get; protected set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002865 File Offset: 0x00000A65
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000286D File Offset: 0x00000A6D
		public string Manufacturer { get; protected set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002876 File Offset: 0x00000A76
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000287E File Offset: 0x00000A7E
		public string Model { get; protected set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002887 File Offset: 0x00000A87
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000288F File Offset: 0x00000A8F
		public string Description { get; protected set; }

		// Token: 0x06000057 RID: 87 RVA: 0x00005318 File Offset: 0x00003518
		public Issuer(ManagementBaseObject def)
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
			this.RestartPrototype(new Dictionary<string, object>());
			foreach (PropertyData propertyData in def.Properties)
			{
				this.ListPrototype().Add(propertyData.Name, propertyData.Value);
			}
			this.Caption = this.CollectPrototype<string>(def, "Caption");
			this.Name = this.CollectPrototype<string>(def, "Name");
			this.Manufacturer = this.CollectPrototype<string>(def, "Manufacturer");
			this.Model = this.CollectPrototype<string>(def, "Model");
			this.Description = this.CollectPrototype<string>(def, "Description");
			if (!string.IsNullOrEmpty(this.Caption))
			{
				this.Caption = this.Caption.ToLower();
			}
			if (!string.IsNullOrEmpty(this.Name))
			{
				this.Name = this.Name.ToLower();
			}
			if (!string.IsNullOrEmpty(this.Manufacturer))
			{
				this.Manufacturer = this.Manufacturer.ToLower();
			}
			if (!string.IsNullOrEmpty(this.Model))
			{
				this.Model = this.Model.ToLower();
			}
			if (!string.IsNullOrEmpty(this.Description))
			{
				this.Description = this.Description.ToLower();
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002898 File Offset: 0x00000A98
		public override string ToString()
		{
			return string.Format("manufacturer={0}, name={1}, model={2}, caption={3}, description={4}", new object[]
			{
				this.Manufacturer,
				this.Name,
				this.Model,
				this.Caption,
				this.Description
			});
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005484 File Offset: 0x00003684
		protected string OrderPrototype()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string text in this.ListPrototype().Keys)
			{
				stringBuilder.AppendLine(string.Format("{0} = {1}", text, this.AssetPrototype(this.ListPrototype()[text])));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000028D7 File Offset: 0x00000AD7
		private object AssetPrototype(object key)
		{
			if (key == null)
			{
				return string.Empty;
			}
			if (!key.GetType().IsArray)
			{
				return key;
			}
			return this.DefinePrototype(key);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000028F8 File Offset: 0x00000AF8
		protected string DefinePrototype(object init)
		{
			return new JavaScriptSerializer().Serialize(init);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005508 File Offset: 0x00003708
		protected T CollectPrototype<T>(ManagementBaseObject spec, string attr)
		{
			object obj = null;
			try
			{
				obj = spec[attr];
			}
			catch
			{
			}
			if (obj != null)
			{
				return (T)((object)Convert.ChangeType(obj, typeof(T)));
			}
			if (typeof(T) == typeof(string))
			{
				return (T)((object)Convert.ChangeType(string.Empty, typeof(T)));
			}
			return default(T);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002905 File Offset: 0x00000B05
		internal static bool RestartConfig()
		{
			return Issuer.SearchConfig == null;
		}

		// Token: 0x0400002D RID: 45
		[CompilerGenerated]
		private Dictionary<string, object> _Definition;

		// Token: 0x0400002E RID: 46
		[CompilerGenerated]
		private string m_Struct;

		// Token: 0x0400002F RID: 47
		[CompilerGenerated]
		private string m_Merchant;

		// Token: 0x04000030 RID: 48
		[CompilerGenerated]
		private string m_Thread;

		// Token: 0x04000031 RID: 49
		[CompilerGenerated]
		private string m_Initializer;

		// Token: 0x04000032 RID: 50
		[CompilerGenerated]
		private string writer;

		// Token: 0x04000033 RID: 51
		private static object SearchConfig;
	}
}
