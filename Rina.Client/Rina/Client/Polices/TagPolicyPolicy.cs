using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using Rina.Authentication;
using Rina.Client.Attributes;
using Rina.Client.Readers;
using Rina.Objects;
using Rina.Structs;

namespace Rina.Client.Polices
{
	// Token: 0x02000059 RID: 89
	internal class TagPolicyPolicy
	{
		// Token: 0x06000258 RID: 600 RVA: 0x00014974 File Offset: 0x00012B74
		public static void InvokeRule()
		{
			MappingRef.LoginReader("CONNECTING", new string[0]);
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += TagPolicyPolicy.CreateRule;
			backgroundWorker.RunWorkerCompleted += TagPolicyPolicy.FlushRule;
			if (backgroundWorker.IsBusy)
			{
				MessageBox.Show(RegistryReader.DisableRule("UNKNOWNERROR", new object[]
				{
					"CheckNetwork isBusy"
				}));
				Application.Exit();
				return;
			}
			backgroundWorker.RunWorkerAsync();
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000149F0 File Offset: 0x00012BF0
		private static void CreateRule(object sender, DoWorkEventArgs e)
		{
			try
			{
				new WebClient
				{
					Headers = 
					{
						{
							"user-agent",
							ProductReaderStructBuilder.m_SchemaIdentifier
						}
					}
				}.OpenRead(ProductReaderStructBuilder._RoleIdentifier);
				e.Result = true;
			}
			catch
			{
				e.Result = false;
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000035D4 File Offset: 0x000017D4
		private static void FlushRule(object sender, RunWorkerCompletedEventArgs e)
		{
			if (Convert.ToBoolean(e.Result))
			{
				CollectionAuthenticationReader.InsertRule();
				return;
			}
			MessageBox.Show(RegistryReader.DisableRule("NONETWORK", new object[0]));
			Application.Exit();
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000024D4 File Offset: 0x000006D4
		public TagPolicyPolicy()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00003604 File Offset: 0x00001804
		internal static bool OrderPolicy()
		{
			return TagPolicyPolicy.PatchPolicy == null;
		}

		// Token: 0x040001C1 RID: 449
		internal static object PatchPolicy;
	}
}
