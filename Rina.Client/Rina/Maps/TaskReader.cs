using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Rina.Client.Attributes;

namespace Rina.Maps
{
	// Token: 0x02000069 RID: 105
	internal class TaskReader
	{
		// Token: 0x0600027E RID: 638 RVA: 0x000036C0 File Offset: 0x000018C0
		internal static object[] EnableRule()
		{
			return new object[1];
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00015938 File Offset: 0x00013B38
		internal static object[] CheckRule<T>(int res_count, object cust, object field, ref T counter2)
		{
			Comparison<TaskReader.GlobalReader> comparison = null;
			lock (TaskReader.object_0)
			{
				if (!TaskReader.m_ThreadReader)
				{
					TaskReader.m_ThreadReader = true;
					TaskReader.CloneRule();
				}
			}
			TaskReader.SetterRuleTask setterRuleTask = null;
			if (TaskReader.m_IssuerReader[res_count] != null)
			{
				setterRuleTask = TaskReader.m_IssuerReader[res_count];
			}
			else
			{
				TaskReader.productReader.BaseStream.Position = (long)TaskReader.m_DefinitionReader[res_count];
				setterRuleTask = new TaskReader.SetterRuleTask();
				Module module = typeof(TaskReader).Module;
				int metadataToken = TaskReader.VisitRule(TaskReader.productReader);
				int num = TaskReader.VisitRule(TaskReader.productReader);
				int num2 = TaskReader.VisitRule(TaskReader.productReader);
				int num3 = TaskReader.VisitRule(TaskReader.productReader);
				setterRuleTask.m_DescriptorReader = module.ResolveMethod(metadataToken);
				ParameterInfo[] parameters = setterRuleTask.m_DescriptorReader.GetParameters();
				setterRuleTask._CallbackReader = new TaskReader.SystemConnectionAttribute[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					Type type = parameters[i].ParameterType;
					TaskReader.SystemConnectionAttribute systemConnectionAttribute = new TaskReader.SystemConnectionAttribute();
					systemConnectionAttribute.m_AttributeReader = type.IsByRef;
					systemConnectionAttribute.proccesorReader = i;
					setterRuleTask._CallbackReader[i] = systemConnectionAttribute;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					TaskReader.XmlReadMode paramReader;
					if (type == typeof(string))
					{
						paramReader = (TaskReader.XmlReadMode)14;
					}
					else if (type == typeof(byte))
					{
						paramReader = (TaskReader.XmlReadMode)2;
					}
					else if (type == typeof(sbyte))
					{
						paramReader = (TaskReader.XmlReadMode)1;
					}
					else if (type == typeof(short))
					{
						paramReader = (TaskReader.XmlReadMode)3;
					}
					else if (type == typeof(ushort))
					{
						paramReader = (TaskReader.XmlReadMode)4;
					}
					else if (type == typeof(int))
					{
						paramReader = (TaskReader.XmlReadMode)5;
					}
					else if (type == typeof(uint))
					{
						paramReader = (TaskReader.XmlReadMode)6;
					}
					else if (type == typeof(long))
					{
						paramReader = (TaskReader.XmlReadMode)7;
					}
					else if (type == typeof(ulong))
					{
						paramReader = (TaskReader.XmlReadMode)8;
					}
					else if (type == typeof(float))
					{
						paramReader = (TaskReader.XmlReadMode)9;
					}
					else if (type == typeof(double))
					{
						paramReader = (TaskReader.XmlReadMode)10;
					}
					else if (type == typeof(bool))
					{
						paramReader = (TaskReader.XmlReadMode)11;
					}
					else if (type == typeof(IntPtr))
					{
						paramReader = (TaskReader.XmlReadMode)12;
					}
					else if (type == typeof(UIntPtr))
					{
						paramReader = (TaskReader.XmlReadMode)13;
					}
					else if (type == typeof(char))
					{
						paramReader = (TaskReader.XmlReadMode)15;
					}
					else
					{
						paramReader = (TaskReader.XmlReadMode)0;
					}
					systemConnectionAttribute._ParamReader = paramReader;
				}
				setterRuleTask.printerReader = new List<TaskReader.ListContainerRole>(num);
				for (int j = 0; j < num; j++)
				{
					int num4 = TaskReader.VisitRule(TaskReader.productReader);
					TaskReader.ListContainerRole listContainerRole = new TaskReader.ListContainerRole();
					listContainerRole.exceptionReader = null;
					if (num4 >= 0 && num4 < 50)
					{
						listContainerRole.regReader = (TaskReader.XmlReadMode)(num4 & 31);
						listContainerRole.errorReader = ((num4 & 32) > 0);
					}
					listContainerRole.m_ObserverReader = j;
					setterRuleTask.printerReader.Add(listContainerRole);
				}
				setterRuleTask.m_ValReader = new List<TaskReader.GlobalReader>(num2);
				for (int k = 0; k < num2; k++)
				{
					int num5 = TaskReader.VisitRule(TaskReader.productReader);
					int num6 = TaskReader.VisitRule(TaskReader.productReader);
					TaskReader.GlobalReader globalReader = new TaskReader.GlobalReader();
					globalReader.m_HelperReader = num5;
					globalReader.m_EventReader = num6;
					TaskReader.FacadeWatcherClass facadeWatcherClass = new TaskReader.FacadeWatcherClass();
					globalReader.m_FactoryReader = facadeWatcherClass;
					num5 = TaskReader.VisitRule(TaskReader.productReader);
					num6 = TaskReader.VisitRule(TaskReader.productReader);
					int num7 = TaskReader.VisitRule(TaskReader.productReader);
					facadeWatcherClass.setterReader = num5;
					facadeWatcherClass.methodReader = num6;
					facadeWatcherClass.stateReader = num7;
					if (num7 == 0)
					{
						facadeWatcherClass._AccountReader = module.ResolveType(TaskReader.VisitRule(TaskReader.productReader));
					}
					else if (num7 == 1)
					{
						facadeWatcherClass.m_ClassReader = TaskReader.VisitRule(TaskReader.productReader);
					}
					else
					{
						TaskReader.VisitRule(TaskReader.productReader);
					}
					setterRuleTask.m_ValReader.Add(globalReader);
				}
				List<TaskReader.GlobalReader> valReader = setterRuleTask.m_ValReader;
				if (comparison == null)
				{
					comparison = new Comparison<TaskReader.GlobalReader>(TaskReader.LogoutRule<T>);
				}
				valReader.Sort(comparison);
				setterRuleTask._PublisherReader = new List<TaskReader.FieldWatcherClass>(num3);
				for (int l = 0; l < num3; l++)
				{
					TaskReader.FieldWatcherClass fieldWatcherClass = new TaskReader.FieldWatcherClass();
					byte b = TaskReader.productReader.ReadByte();
					fieldWatcherClass._WrapperReader = (TaskReader.UnhandledExceptionAction)b;
					if (b > 173)
					{
						throw new Exception();
					}
					int num8 = (int)TaskReader.merchantReader[(int)b];
					if (num8 == 0)
					{
						fieldWatcherClass.m_ProducerReader = null;
					}
					else
					{
						object producerReader;
						switch (num8)
						{
						case 1:
							producerReader = TaskReader.VisitRule(TaskReader.productReader);
							break;
						case 2:
							producerReader = TaskReader.productReader.ReadInt64();
							break;
						case 3:
							producerReader = TaskReader.productReader.ReadSingle();
							break;
						case 4:
							producerReader = TaskReader.productReader.ReadDouble();
							break;
						case 5:
						{
							int num9 = TaskReader.VisitRule(TaskReader.productReader);
							int[] array = new int[num9];
							for (int m = 0; m < num9; m++)
							{
								array[m] = TaskReader.VisitRule(TaskReader.productReader);
							}
							producerReader = array;
							break;
						}
						default:
							throw new Exception();
						}
						fieldWatcherClass.m_ProducerReader = producerReader;
					}
					setterRuleTask._PublisherReader.Add(fieldWatcherClass);
				}
				TaskReader.m_IssuerReader[res_count] = setterRuleTask;
			}
			TaskReader.SingletonSingletonObject singletonSingletonObject = new TaskReader.SingletonSingletonObject();
			singletonSingletonObject.adapterReader = setterRuleTask;
			ParameterInfo[] parameters2 = setterRuleTask.m_DescriptorReader.GetParameters();
			bool flag2 = false;
			int num10 = 0;
			if (setterRuleTask.m_DescriptorReader is MethodInfo)
			{
				MethodInfo methodInfo = (MethodInfo)setterRuleTask.m_DescriptorReader;
				if (methodInfo.ReturnType != typeof(void))
				{
					flag2 = true;
				}
			}
			if (setterRuleTask.m_DescriptorReader.IsStatic)
			{
				singletonSingletonObject._BroadcasterReader = new TaskReader.ExpressionReader[parameters2.Length];
				for (int n = 0; n < parameters2.Length; n++)
				{
					Type parameterType = parameters2[n].ParameterType;
					singletonSingletonObject._BroadcasterReader[n] = TaskReader.ExpressionReader.RunRule(parameterType, cust[n]);
					if (parameterType.IsByRef)
					{
						num10++;
					}
				}
			}
			else
			{
				singletonSingletonObject._BroadcasterReader = new TaskReader.ExpressionReader[parameters2.Length + 1];
				if (setterRuleTask.m_DescriptorReader.DeclaringType.IsValueType)
				{
					singletonSingletonObject._BroadcasterReader[0] = new TaskReader.ObjectPolicyPolicy(new TaskReader.CandidateReader(field), setterRuleTask.m_DescriptorReader.DeclaringType);
				}
				else
				{
					singletonSingletonObject._BroadcasterReader[0] = new TaskReader.CandidateReader(field);
				}
				for (int num11 = 0; num11 < parameters2.Length; num11++)
				{
					Type parameterType2 = parameters2[num11].ParameterType;
					if (parameterType2.IsByRef)
					{
						singletonSingletonObject._BroadcasterReader[num11 + 1] = TaskReader.ExpressionReader.RunRule(parameterType2, cust[num11]);
						num10++;
					}
					else
					{
						singletonSingletonObject._BroadcasterReader[num11 + 1] = TaskReader.ExpressionReader.RunRule(parameterType2, cust[num11]);
					}
				}
			}
			singletonSingletonObject._ListenerReader = new TaskReader.ExpressionReader[setterRuleTask.printerReader.Count];
			for (int num12 = 0; num12 < setterRuleTask.printerReader.Count; num12++)
			{
				TaskReader.ListContainerRole listContainerRole2 = setterRuleTask.printerReader[num12];
				switch (listContainerRole2.regReader)
				{
				case (TaskReader.XmlReadMode)0:
					singletonSingletonObject._ListenerReader[num12] = null;
					break;
				case (TaskReader.XmlReadMode)1:
				case (TaskReader.XmlReadMode)2:
				case (TaskReader.XmlReadMode)3:
				case (TaskReader.XmlReadMode)4:
				case (TaskReader.XmlReadMode)5:
				case (TaskReader.XmlReadMode)6:
				case (TaskReader.XmlReadMode)11:
				case (TaskReader.XmlReadMode)15:
					singletonSingletonObject._ListenerReader[num12] = new TaskReader.ExporterPolicyPolicy(0, listContainerRole2.regReader);
					break;
				case (TaskReader.XmlReadMode)7:
				case (TaskReader.XmlReadMode)8:
					singletonSingletonObject._ListenerReader[num12] = new TaskReader.AlgoReader(0L, listContainerRole2.regReader);
					break;
				case (TaskReader.XmlReadMode)9:
				case (TaskReader.XmlReadMode)10:
					singletonSingletonObject._ListenerReader[num12] = new TaskReader.IssuerInvocationRecord(0.0, listContainerRole2.regReader);
					break;
				case (TaskReader.XmlReadMode)12:
					singletonSingletonObject._ListenerReader[num12] = new TaskReader.WorkerAuthenticationReader(IntPtr.Zero);
					break;
				case (TaskReader.XmlReadMode)13:
					singletonSingletonObject._ListenerReader[num12] = new TaskReader.WorkerAuthenticationReader(UIntPtr.Zero);
					break;
				case (TaskReader.XmlReadMode)14:
					singletonSingletonObject._ListenerReader[num12] = null;
					break;
				case (TaskReader.XmlReadMode)16:
					singletonSingletonObject._ListenerReader[num12] = new TaskReader.CandidateReader(null);
					break;
				}
			}
			try
			{
				singletonSingletonObject.OrderAnnotation();
			}
			finally
			{
				singletonSingletonObject.AssetAnnotation();
			}
			int num13 = 0;
			if (flag2)
			{
				num13 = 1;
			}
			num13 += num10;
			object[] array2 = new object[num13];
			if (flag2)
			{
				array2[0] = null;
			}
			if (setterRuleTask.m_DescriptorReader is MethodInfo)
			{
				MethodInfo methodInfo2 = (MethodInfo)setterRuleTask.m_DescriptorReader;
				if (methodInfo2.ReturnType != typeof(void) && singletonSingletonObject._CreatorReader != null)
				{
					array2[0] = singletonSingletonObject._CreatorReader.PatchProperty(methodInfo2.ReturnType);
				}
			}
			if (num10 > 0)
			{
				int num14 = 0;
				if (flag2)
				{
					num14++;
				}
				for (int num15 = 0; num15 < parameters2.Length; num15++)
				{
					Type type2 = parameters2[num15].ParameterType;
					if (type2.IsByRef)
					{
						type2 = type2.GetElementType();
						if (singletonSingletonObject._BroadcasterReader[num15] != null)
						{
							if (setterRuleTask.m_DescriptorReader.IsStatic)
							{
								array2[num14] = singletonSingletonObject._BroadcasterReader[num15].PatchProperty(type2);
							}
							else
							{
								array2[num14] = singletonSingletonObject._BroadcasterReader[num15 + 1].PatchProperty(type2);
							}
						}
						else
						{
							array2[num14] = null;
						}
						num14++;
					}
				}
			}
			if (!setterRuleTask.m_DescriptorReader.IsStatic && setterRuleTask.m_DescriptorReader.DeclaringType.IsValueType)
			{
				counter2 = (T)((object)singletonSingletonObject._BroadcasterReader[0].PatchProperty(setterRuleTask.m_DescriptorReader.DeclaringType));
			}
			return array2;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000036C8 File Offset: 0x000018C8
		internal static object[] TestRule(int previousinit, object selection, object control)
		{
			return TaskReader.CheckRule<int>(previousinit, selection, control, ref TaskReader.writerReader);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000036D7 File Offset: 0x000018D7
		internal static object[] DestroyRule<T>(int previous_task, object second, ref T third)
		{
			return TaskReader.CheckRule<T>(previous_task, second, third, ref third);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00016324 File Offset: 0x00014524
		internal static void CloneRule()
		{
			if (TaskReader.m_DefinitionReader == null)
			{
				BinaryReader binaryReader = new BinaryReader(typeof(TaskReader).Assembly.GetManifestResourceStream("Dic.Parser"));
				binaryReader.BaseStream.Position = 0L;
				byte[] v = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
				binaryReader.Close();
				TaskReader.NewRule(v);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0001638C File Offset: 0x0001458C
		internal static void NewRule(byte[] v)
		{
			MemoryStream input = new MemoryStream(v);
			TaskReader.productReader = new BinaryReader(input);
			TaskReader.merchantReader = new byte[255];
			int num = TaskReader.VisitRule(TaskReader.productReader);
			for (int i = 0; i < num; i++)
			{
				int num2 = (int)TaskReader.productReader.ReadByte();
				TaskReader.merchantReader[num2] = TaskReader.productReader.ReadByte();
			}
			num = TaskReader.VisitRule(TaskReader.productReader);
			TaskReader.structReader = new List<string>(num);
			for (int j = 0; j < num; j++)
			{
				TaskReader.structReader.Add(Encoding.Unicode.GetString(TaskReader.productReader.ReadBytes(TaskReader.VisitRule(TaskReader.productReader))));
			}
			num = TaskReader.VisitRule(TaskReader.productReader);
			TaskReader.m_IssuerReader = new TaskReader.SetterRuleTask[num];
			TaskReader.m_DefinitionReader = new int[num];
			for (int k = 0; k < num; k++)
			{
				TaskReader.m_IssuerReader[k] = null;
				TaskReader.m_DefinitionReader[k] = TaskReader.VisitRule(TaskReader.productReader);
			}
			int num3 = (int)TaskReader.productReader.BaseStream.Position;
			for (int l = 0; l < num; l++)
			{
				int num4 = TaskReader.m_DefinitionReader[l];
				TaskReader.m_DefinitionReader[l] = num3;
				num3 += num4;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000164C0 File Offset: 0x000146C0
		internal static int VisitRule(BinaryReader first)
		{
			bool flag = false;
			uint num = (uint)first.ReadByte();
			uint num2 = 0U | (num & 63U);
			if ((num & 64U) != 0U)
			{
				flag = true;
			}
			if (num >= 128U)
			{
				int num3 = 0;
				for (;;)
				{
					uint num4 = (uint)first.ReadByte();
					num2 |= (num4 & 127U) << 7 * num3 + 6;
					if (num4 < 128U)
					{
						break;
					}
					num3++;
				}
				if (flag)
				{
					return (int)(~(int)num2);
				}
				return (int)num2;
			}
			else
			{
				if (!flag)
				{
					return (int)num2;
				}
				return (int)(~(int)num2);
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000024D4 File Offset: 0x000006D4
		public TaskReader()
		{
			AdvisorConnectionAttribute.CancelComposer();
			base..ctor();
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000036EC File Offset: 0x000018EC
		[CompilerGenerated]
		private static int LogoutRule<T>(TaskReader.FacadeWatcherClass res, TaskReader.FacadeWatcherClass vis)
		{
			return res.m_FactoryReader.setterReader.CompareTo(vis.m_FactoryReader.setterReader);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00003709 File Offset: 0x00001909
		static TaskReader()
		{
			AdvisorConnectionAttribute.CancelComposer();
			TaskReader.m_IssuerReader = null;
			TaskReader.m_DefinitionReader = null;
			TaskReader.m_ThreadReader = false;
			TaskReader.object_0 = 1;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000372D File Offset: 0x0000192D
		internal static bool VisitStruct()
		{
			return TaskReader.PrintStruct == null;
		}

		// Token: 0x040001DE RID: 478
		internal static TaskReader.SetterRuleTask[] m_IssuerReader;

		// Token: 0x040001DF RID: 479
		internal static int[] m_DefinitionReader;

		// Token: 0x040001E0 RID: 480
		internal static List<string> structReader;

		// Token: 0x040001E1 RID: 481
		private static BinaryReader productReader;

		// Token: 0x040001E2 RID: 482
		private static byte[] merchantReader;

		// Token: 0x040001E3 RID: 483
		private static bool m_ThreadReader;

		// Token: 0x040001E4 RID: 484
		private static object object_0;

		// Token: 0x040001E5 RID: 485
		private static int writerReader;

		// Token: 0x040001E6 RID: 486
		private static object PrintStruct;

		// Token: 0x0200006A RID: 106
		internal enum CMSSECTIONID : byte
		{

		}

		// Token: 0x0200006B RID: 107
		internal abstract class ExpressionReader
		{
			// Token: 0x06000289 RID: 649 RVA: 0x000024D4 File Offset: 0x000006D4
			public ExpressionReader()
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
			}

			// Token: 0x0600028A RID: 650 RVA: 0x00003737 File Offset: 0x00001937
			internal bool UpdateRule()
			{
				return this.m_ComparatorReader == (TaskReader.CMSSECTIONID)0;
			}

			// Token: 0x0600028B RID: 651 RVA: 0x00003742 File Offset: 0x00001942
			internal bool CalculateRule()
			{
				return this.m_ComparatorReader == (TaskReader.CMSSECTIONID)1;
			}

			// Token: 0x0600028C RID: 652 RVA: 0x0000374D File Offset: 0x0000194D
			internal bool PatchRule()
			{
				return this.m_ComparatorReader == (TaskReader.CMSSECTIONID)3 || this.m_ComparatorReader == (TaskReader.CMSSECTIONID)4;
			}

			// Token: 0x0600028D RID: 653 RVA: 0x00003763 File Offset: 0x00001963
			internal bool ResolveRule()
			{
				return this.m_ComparatorReader == (TaskReader.CMSSECTIONID)2;
			}

			// Token: 0x0600028E RID: 654 RVA: 0x0000376E File Offset: 0x0000196E
			internal bool CancelRule()
			{
				return this.m_ComparatorReader == (TaskReader.CMSSECTIONID)5;
			}

			// Token: 0x0600028F RID: 655 RVA: 0x00003779 File Offset: 0x00001979
			internal bool ViewRule()
			{
				return this.m_ComparatorReader == (TaskReader.CMSSECTIONID)6;
			}

			// Token: 0x06000290 RID: 656 RVA: 0x00002A1E File Offset: 0x00000C1E
			internal virtual bool VisitProperty()
			{
				return false;
			}

			// Token: 0x06000291 RID: 657 RVA: 0x00002A1E File Offset: 0x00000C1E
			internal virtual bool LogoutProperty()
			{
				return false;
			}

			// Token: 0x06000292 RID: 658
			internal abstract void UpdateProperty(TaskReader.ExpressionReader first);

			// Token: 0x06000293 RID: 659 RVA: 0x00002A1E File Offset: 0x00000C1E
			internal virtual bool CalculateProperty()
			{
				return false;
			}

			// Token: 0x06000294 RID: 660 RVA: 0x00003784 File Offset: 0x00001984
			internal ExpressionReader(TaskReader.CMSSECTIONID asset)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = asset;
			}

			// Token: 0x06000295 RID: 661
			internal abstract object PatchProperty(Type v);

			// Token: 0x06000296 RID: 662
			internal abstract bool ResolveProperty(TaskReader.ExpressionReader var1);

			// Token: 0x06000297 RID: 663
			internal abstract bool CancelProperty(TaskReader.ExpressionReader v);

			// Token: 0x06000298 RID: 664
			internal abstract bool ViewProperty();

			// Token: 0x06000299 RID: 665
			internal abstract TaskReader.ExpressionReader IncludeProperty();

			// Token: 0x0600029A RID: 666 RVA: 0x00002A1E File Offset: 0x00000C1E
			internal virtual bool RunProperty()
			{
				return false;
			}

			// Token: 0x0600029B RID: 667
			internal abstract void FindProperty(TaskReader.ExpressionReader value);

			// Token: 0x0600029C RID: 668 RVA: 0x0001652C File Offset: 0x0001472C
			internal static TaskReader.ConstraintValues IncludeRule(Type v)
			{
				Type type = v;
				if (!(type != null))
				{
					return (TaskReader.ConstraintValues)18;
				}
				if (type.IsByRef)
				{
					type = type.GetElementType();
				}
				if (type == typeof(string))
				{
					return (TaskReader.ConstraintValues)14;
				}
				if (type == typeof(byte))
				{
					return (TaskReader.ConstraintValues)2;
				}
				if (type == typeof(sbyte))
				{
					return (TaskReader.ConstraintValues)1;
				}
				if (type == typeof(short))
				{
					return (TaskReader.ConstraintValues)3;
				}
				if (type == typeof(ushort))
				{
					return (TaskReader.ConstraintValues)4;
				}
				if (type == typeof(int))
				{
					return (TaskReader.ConstraintValues)5;
				}
				if (type == typeof(uint))
				{
					return (TaskReader.ConstraintValues)6;
				}
				if (type == typeof(long))
				{
					return (TaskReader.ConstraintValues)7;
				}
				if (type == typeof(ulong))
				{
					return (TaskReader.ConstraintValues)8;
				}
				if (type == typeof(float))
				{
					return (TaskReader.ConstraintValues)9;
				}
				if (type == typeof(double))
				{
					return (TaskReader.ConstraintValues)10;
				}
				if (type == typeof(bool))
				{
					return (TaskReader.ConstraintValues)11;
				}
				if (type == typeof(IntPtr))
				{
					return (TaskReader.ConstraintValues)12;
				}
				if (type == typeof(UIntPtr))
				{
					return (TaskReader.ConstraintValues)13;
				}
				if (type == typeof(char))
				{
					return (TaskReader.ConstraintValues)15;
				}
				if (type == typeof(object))
				{
					return (TaskReader.ConstraintValues)0;
				}
				if (type.IsEnum)
				{
					return (TaskReader.ConstraintValues)16;
				}
				return (TaskReader.ConstraintValues)17;
			}

			// Token: 0x0600029D RID: 669 RVA: 0x000166BC File Offset: 0x000148BC
			internal static TaskReader.ExpressionReader RunRule(Type key, object ord)
			{
				TaskReader.ConstraintValues constraintValues = TaskReader.ExpressionReader.IncludeRule(key);
				TaskReader.ConstraintValues constraintValues2 = (TaskReader.ConstraintValues)18;
				if (ord != null)
				{
					constraintValues2 = TaskReader.ExpressionReader.IncludeRule(ord.GetType());
				}
				TaskReader.ExpressionReader expressionReader = null;
				switch (constraintValues)
				{
				case (TaskReader.ConstraintValues)0:
				{
					TaskReader.ConstraintValues constraintValues3 = constraintValues2;
					if (constraintValues3 == (TaskReader.ConstraintValues)15)
					{
						expressionReader = new TaskReader.CandidateReader(ord);
					}
					else
					{
						expressionReader = TaskReader.ExpressionReader.FindRule(ord);
					}
					break;
				}
				case (TaskReader.ConstraintValues)1:
				{
					TaskReader.ConstraintValues constraintValues4 = constraintValues2;
					switch (constraintValues4)
					{
					case (TaskReader.ConstraintValues)1:
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)((sbyte)ord), (TaskReader.XmlReadMode)1);
						break;
					case (TaskReader.ConstraintValues)2:
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)((sbyte)((byte)ord)), (TaskReader.XmlReadMode)1);
						break;
					default:
						if (constraintValues4 != (TaskReader.ConstraintValues)11)
						{
							if (constraintValues4 != (TaskReader.ConstraintValues)15)
							{
								throw new InvalidCastException();
							}
							expressionReader = new TaskReader.ExporterPolicyPolicy((int)((sbyte)((char)ord)), (TaskReader.XmlReadMode)1);
						}
						else if (!(bool)ord)
						{
							expressionReader = new TaskReader.ExporterPolicyPolicy(0, (TaskReader.XmlReadMode)1);
						}
						else
						{
							expressionReader = new TaskReader.ExporterPolicyPolicy(1, (TaskReader.XmlReadMode)1);
						}
						break;
					}
					break;
				}
				case (TaskReader.ConstraintValues)2:
				{
					TaskReader.ConstraintValues constraintValues5 = constraintValues2;
					switch (constraintValues5)
					{
					case (TaskReader.ConstraintValues)1:
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)((byte)((sbyte)ord)), (TaskReader.XmlReadMode)2);
						break;
					case (TaskReader.ConstraintValues)2:
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)((byte)ord), (TaskReader.XmlReadMode)2);
						break;
					default:
						if (constraintValues5 != (TaskReader.ConstraintValues)11)
						{
							if (constraintValues5 != (TaskReader.ConstraintValues)15)
							{
								throw new InvalidCastException();
							}
							expressionReader = new TaskReader.ExporterPolicyPolicy((int)((byte)((char)ord)), (TaskReader.XmlReadMode)2);
						}
						else if (!(bool)ord)
						{
							expressionReader = new TaskReader.ExporterPolicyPolicy(0, (TaskReader.XmlReadMode)2);
						}
						else
						{
							expressionReader = new TaskReader.ExporterPolicyPolicy(1, (TaskReader.XmlReadMode)2);
						}
						break;
					}
					break;
				}
				case (TaskReader.ConstraintValues)3:
				{
					TaskReader.ConstraintValues constraintValues6 = constraintValues2;
					if (constraintValues6 != (TaskReader.ConstraintValues)3)
					{
						if (constraintValues6 != (TaskReader.ConstraintValues)11)
						{
							if (constraintValues6 != (TaskReader.ConstraintValues)15)
							{
								throw new InvalidCastException();
							}
							expressionReader = new TaskReader.ExporterPolicyPolicy((int)((short)((char)ord)), (TaskReader.XmlReadMode)3);
						}
						else if (!(bool)ord)
						{
							expressionReader = new TaskReader.ExporterPolicyPolicy(0, (TaskReader.XmlReadMode)3);
						}
						else
						{
							expressionReader = new TaskReader.ExporterPolicyPolicy(1, (TaskReader.XmlReadMode)3);
						}
					}
					else
					{
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)((short)ord), (TaskReader.XmlReadMode)3);
					}
					break;
				}
				case (TaskReader.ConstraintValues)4:
				{
					TaskReader.ConstraintValues constraintValues7 = constraintValues2;
					if (constraintValues7 != (TaskReader.ConstraintValues)4)
					{
						if (constraintValues7 != (TaskReader.ConstraintValues)11)
						{
							if (constraintValues7 != (TaskReader.ConstraintValues)15)
							{
								throw new InvalidCastException();
							}
							expressionReader = new TaskReader.ExporterPolicyPolicy((int)((char)ord), (TaskReader.XmlReadMode)4);
						}
						else if ((bool)ord)
						{
							expressionReader = new TaskReader.ExporterPolicyPolicy(1, (TaskReader.XmlReadMode)4);
						}
						else
						{
							expressionReader = new TaskReader.ExporterPolicyPolicy(0, (TaskReader.XmlReadMode)4);
						}
					}
					else
					{
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)((ushort)ord), (TaskReader.XmlReadMode)4);
					}
					break;
				}
				case (TaskReader.ConstraintValues)5:
				{
					TaskReader.ConstraintValues constraintValues8 = constraintValues2;
					if (constraintValues8 != (TaskReader.ConstraintValues)5)
					{
						if (constraintValues8 != (TaskReader.ConstraintValues)11)
						{
							if (constraintValues8 != (TaskReader.ConstraintValues)15)
							{
								throw new InvalidCastException();
							}
							expressionReader = new TaskReader.ExporterPolicyPolicy((int)((char)ord), (TaskReader.XmlReadMode)5);
						}
						else if ((bool)ord)
						{
							expressionReader = new TaskReader.ExporterPolicyPolicy(1, (TaskReader.XmlReadMode)5);
						}
						else
						{
							expressionReader = new TaskReader.ExporterPolicyPolicy(0, (TaskReader.XmlReadMode)5);
						}
					}
					else
					{
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)ord, (TaskReader.XmlReadMode)5);
					}
					break;
				}
				case (TaskReader.ConstraintValues)6:
				{
					TaskReader.ConstraintValues constraintValues9 = constraintValues2;
					if (constraintValues9 != (TaskReader.ConstraintValues)6)
					{
						if (constraintValues9 != (TaskReader.ConstraintValues)11)
						{
							if (constraintValues9 != (TaskReader.ConstraintValues)15)
							{
								throw new InvalidCastException();
							}
							expressionReader = new TaskReader.ExporterPolicyPolicy((uint)((char)ord), (TaskReader.XmlReadMode)6);
						}
						else if (!(bool)ord)
						{
							expressionReader = new TaskReader.ExporterPolicyPolicy(0U, (TaskReader.XmlReadMode)6);
						}
						else
						{
							expressionReader = new TaskReader.ExporterPolicyPolicy(1U, (TaskReader.XmlReadMode)6);
						}
					}
					else
					{
						expressionReader = new TaskReader.ExporterPolicyPolicy((uint)ord, (TaskReader.XmlReadMode)6);
					}
					break;
				}
				case (TaskReader.ConstraintValues)7:
				{
					TaskReader.ConstraintValues constraintValues10 = constraintValues2;
					if (constraintValues10 != (TaskReader.ConstraintValues)7)
					{
						if (constraintValues10 != (TaskReader.ConstraintValues)11)
						{
							if (constraintValues10 != (TaskReader.ConstraintValues)15)
							{
								throw new InvalidCastException();
							}
							expressionReader = new TaskReader.AlgoReader((long)((ulong)((char)ord)), (TaskReader.XmlReadMode)7);
						}
						else if ((bool)ord)
						{
							expressionReader = new TaskReader.AlgoReader(1L, (TaskReader.XmlReadMode)7);
						}
						else
						{
							expressionReader = new TaskReader.AlgoReader(0L, (TaskReader.XmlReadMode)7);
						}
					}
					else
					{
						expressionReader = new TaskReader.AlgoReader((long)ord, (TaskReader.XmlReadMode)7);
					}
					break;
				}
				case (TaskReader.ConstraintValues)8:
				{
					TaskReader.ConstraintValues constraintValues11 = constraintValues2;
					if (constraintValues11 != (TaskReader.ConstraintValues)8)
					{
						if (constraintValues11 != (TaskReader.ConstraintValues)11)
						{
							if (constraintValues11 != (TaskReader.ConstraintValues)15)
							{
								throw new InvalidCastException();
							}
							expressionReader = new TaskReader.AlgoReader((ulong)((char)ord), (TaskReader.XmlReadMode)8);
						}
						else if (!(bool)ord)
						{
							expressionReader = new TaskReader.AlgoReader(0UL, (TaskReader.XmlReadMode)8);
						}
						else
						{
							expressionReader = new TaskReader.AlgoReader(1UL, (TaskReader.XmlReadMode)8);
						}
					}
					else
					{
						expressionReader = new TaskReader.AlgoReader((ulong)ord, (TaskReader.XmlReadMode)8);
					}
					break;
				}
				case (TaskReader.ConstraintValues)9:
				{
					TaskReader.ConstraintValues constraintValues12 = constraintValues2;
					if (constraintValues12 != (TaskReader.ConstraintValues)9)
					{
						throw new InvalidCastException();
					}
					expressionReader = new TaskReader.IssuerInvocationRecord((float)ord);
					break;
				}
				case (TaskReader.ConstraintValues)10:
				{
					TaskReader.ConstraintValues constraintValues13 = constraintValues2;
					if (constraintValues13 != (TaskReader.ConstraintValues)10)
					{
						throw new InvalidCastException();
					}
					expressionReader = new TaskReader.IssuerInvocationRecord((double)ord);
					break;
				}
				case (TaskReader.ConstraintValues)11:
					switch (constraintValues2)
					{
					case (TaskReader.ConstraintValues)1:
						expressionReader = new TaskReader.ExporterPolicyPolicy((sbyte)ord != 0);
						goto IL_684;
					case (TaskReader.ConstraintValues)2:
						expressionReader = new TaskReader.ExporterPolicyPolicy((byte)ord != 0);
						goto IL_684;
					case (TaskReader.ConstraintValues)3:
						expressionReader = new TaskReader.ExporterPolicyPolicy((short)ord != 0);
						goto IL_684;
					case (TaskReader.ConstraintValues)4:
						expressionReader = new TaskReader.ExporterPolicyPolicy((ushort)ord != 0);
						goto IL_684;
					case (TaskReader.ConstraintValues)5:
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)ord != 0);
						goto IL_684;
					case (TaskReader.ConstraintValues)6:
						expressionReader = new TaskReader.ExporterPolicyPolicy((uint)ord != 0U);
						goto IL_684;
					case (TaskReader.ConstraintValues)7:
						expressionReader = new TaskReader.ExporterPolicyPolicy((long)ord != 0L);
						goto IL_684;
					case (TaskReader.ConstraintValues)8:
						expressionReader = new TaskReader.ExporterPolicyPolicy((ulong)ord != 0UL);
						goto IL_684;
					case (TaskReader.ConstraintValues)9:
					case (TaskReader.ConstraintValues)10:
					case (TaskReader.ConstraintValues)12:
					case (TaskReader.ConstraintValues)13:
					case (TaskReader.ConstraintValues)14:
					case (TaskReader.ConstraintValues)15:
					case (TaskReader.ConstraintValues)16:
						throw new InvalidCastException();
					case (TaskReader.ConstraintValues)11:
						expressionReader = new TaskReader.ExporterPolicyPolicy((bool)ord);
						goto IL_684;
					case (TaskReader.ConstraintValues)18:
						expressionReader = new TaskReader.ExporterPolicyPolicy(false);
						goto IL_684;
					}
					expressionReader = new TaskReader.ExporterPolicyPolicy(ord != null);
					break;
				case (TaskReader.ConstraintValues)12:
				{
					TaskReader.ConstraintValues constraintValues14 = constraintValues2;
					if (constraintValues14 != (TaskReader.ConstraintValues)12)
					{
						throw new InvalidCastException();
					}
					expressionReader = new TaskReader.WorkerAuthenticationReader((IntPtr)ord);
					break;
				}
				case (TaskReader.ConstraintValues)13:
				{
					TaskReader.ConstraintValues constraintValues15 = constraintValues2;
					if (constraintValues15 != (TaskReader.ConstraintValues)13)
					{
						throw new InvalidCastException();
					}
					expressionReader = new TaskReader.WorkerAuthenticationReader((UIntPtr)ord);
					break;
				}
				case (TaskReader.ConstraintValues)14:
					expressionReader = new TaskReader.ResolverReader(ord as string);
					break;
				case (TaskReader.ConstraintValues)15:
				{
					TaskReader.ConstraintValues constraintValues16 = constraintValues2;
					switch (constraintValues16)
					{
					case (TaskReader.ConstraintValues)1:
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)((sbyte)ord), (TaskReader.XmlReadMode)15);
						break;
					case (TaskReader.ConstraintValues)2:
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)((byte)ord), (TaskReader.XmlReadMode)15);
						break;
					case (TaskReader.ConstraintValues)3:
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)((short)ord), (TaskReader.XmlReadMode)15);
						break;
					case (TaskReader.ConstraintValues)4:
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)((ushort)ord), (TaskReader.XmlReadMode)15);
						break;
					case (TaskReader.ConstraintValues)5:
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)ord, (TaskReader.XmlReadMode)15);
						break;
					case (TaskReader.ConstraintValues)6:
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)((uint)ord), (TaskReader.XmlReadMode)15);
						break;
					default:
						if (constraintValues16 != (TaskReader.ConstraintValues)15)
						{
							throw new InvalidCastException();
						}
						expressionReader = new TaskReader.ExporterPolicyPolicy((int)((char)ord), (TaskReader.XmlReadMode)15);
						break;
					}
					break;
				}
				case (TaskReader.ConstraintValues)16:
				case (TaskReader.ConstraintValues)17:
					expressionReader = TaskReader.ExpressionReader.FindRule(ord);
					break;
				case (TaskReader.ConstraintValues)18:
					throw new InvalidCastException();
				}
				IL_684:
				if (key.IsByRef)
				{
					expressionReader = new TaskReader.ObjectPolicyPolicy(expressionReader, key.GetElementType());
				}
				return expressionReader;
			}

			// Token: 0x0600029E RID: 670 RVA: 0x00016D6C File Offset: 0x00014F6C
			private static TaskReader.ExpressionReader FindRule(object spec)
			{
				if (spec != null && spec.GetType().IsEnum)
				{
					Type underlyingType = Enum.GetUnderlyingType(spec.GetType());
					object ord = Convert.ChangeType(spec, underlyingType);
					TaskReader.ExpressionReader expressionReader = TaskReader.ExpressionReader.ConcatRule(TaskReader.ExpressionReader.RunRule(underlyingType, ord));
					if (expressionReader != null)
					{
						return expressionReader as TaskReader.ModelAuthenticationReader;
					}
				}
				return new TaskReader.CandidateReader(spec);
			}

			// Token: 0x0600029F RID: 671 RVA: 0x00016DBC File Offset: 0x00014FBC
			private static TaskReader.ModelAuthenticationReader ConcatRule(TaskReader.ExpressionReader info)
			{
				TaskReader.ModelAuthenticationReader modelAuthenticationReader = info as TaskReader.ModelAuthenticationReader;
				if (modelAuthenticationReader == null && info.VisitProperty())
				{
					modelAuthenticationReader = (info.IncludeProperty() as TaskReader.ModelAuthenticationReader);
				}
				return modelAuthenticationReader;
			}

			// Token: 0x060002A0 RID: 672 RVA: 0x00003798 File Offset: 0x00001998
			internal static bool CalcStruct()
			{
				return TaskReader.ExpressionReader.RestartStruct == null;
			}

			// Token: 0x040001E8 RID: 488
			internal TaskReader.CMSSECTIONID m_ComparatorReader;

			// Token: 0x040001E9 RID: 489
			private static object RestartStruct;
		}

		// Token: 0x0200006C RID: 108
		private class CandidateReader : TaskReader.ExpressionReader
		{
			// Token: 0x060002A1 RID: 673 RVA: 0x000037A2 File Offset: 0x000019A2
			public CandidateReader()
			{
				AdvisorConnectionAttribute.CancelComposer();
				this..ctor(null);
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x000037B0 File Offset: 0x000019B0
			internal override void FindProperty(TaskReader.ExpressionReader reference)
			{
				if (!(reference is TaskReader.CandidateReader))
				{
					this._ConsumerReader = reference.IncludeProperty();
					return;
				}
				this._ConsumerReader = ((TaskReader.CandidateReader)reference)._ConsumerReader;
				this.m_InstanceReader = ((TaskReader.CandidateReader)reference).m_InstanceReader;
			}

			// Token: 0x060002A3 RID: 675 RVA: 0x000037E9 File Offset: 0x000019E9
			internal override void UpdateProperty(TaskReader.ExpressionReader ident)
			{
				this.FindProperty(ident);
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x000037F2 File Offset: 0x000019F2
			public CandidateReader(object asset)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor((TaskReader.CMSSECTIONID)0);
				this._ConsumerReader = asset;
				this.m_InstanceReader = null;
			}

			// Token: 0x060002A5 RID: 677 RVA: 0x0000380E File Offset: 0x00001A0E
			public CandidateReader(object init, Type b)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor((TaskReader.CMSSECTIONID)0);
				this._ConsumerReader = init;
				this.m_InstanceReader = b;
			}

			// Token: 0x060002A6 RID: 678 RVA: 0x0000382A File Offset: 0x00001A2A
			public override string ToString()
			{
				if (this._ConsumerReader != null)
				{
					return this._ConsumerReader.ToString();
				}
				return "null";
			}

			// Token: 0x060002A7 RID: 679 RVA: 0x00016DE8 File Offset: 0x00014FE8
			internal override object PatchProperty(Type setup)
			{
				if (this._ConsumerReader == null)
				{
					return null;
				}
				if (setup != null && setup.IsByRef)
				{
					setup = setup.GetElementType();
				}
				if (!(this._ConsumerReader is TaskReader.ExpressionReader))
				{
					object obj = this._ConsumerReader;
					if (obj != null && setup != null && obj.GetType() != setup)
					{
						if (setup == typeof(RuntimeFieldHandle) && obj is FieldInfo)
						{
							obj = ((FieldInfo)obj).FieldHandle;
						}
						else if (setup == typeof(RuntimeTypeHandle) && obj is Type)
						{
							obj = ((Type)obj).TypeHandle;
						}
						else if (setup == typeof(RuntimeMethodHandle) && obj is MethodBase)
						{
							obj = ((MethodBase)obj).MethodHandle;
						}
					}
					return obj;
				}
				if (this.m_InstanceReader != null)
				{
					return ((TaskReader.ExpressionReader)this._ConsumerReader).PatchProperty(this.m_InstanceReader);
				}
				object obj2 = ((TaskReader.ExpressionReader)this._ConsumerReader).PatchProperty(setup);
				if (obj2 != null && setup != null && obj2.GetType() != setup)
				{
					if (!(setup == typeof(RuntimeFieldHandle)) || !(obj2 is FieldInfo))
					{
						if (setup == typeof(RuntimeTypeHandle) && obj2 is Type)
						{
							obj2 = ((Type)obj2).TypeHandle;
						}
						else if (setup == typeof(RuntimeMethodHandle) && obj2 is MethodBase)
						{
							obj2 = ((MethodBase)obj2).MethodHandle;
						}
					}
					else
					{
						obj2 = ((FieldInfo)obj2).FieldHandle;
					}
				}
				return obj2;
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x00016FC0 File Offset: 0x000151C0
			internal override bool ResolveProperty(TaskReader.ExpressionReader value)
			{
				if (value.VisitProperty())
				{
					return ((TaskReader.MockReader)value).ResolveProperty(this);
				}
				object obj = this.PatchProperty(null);
				object obj2 = value.PatchProperty(null);
				return obj == obj2;
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x00016FF8 File Offset: 0x000151F8
			internal override bool CancelProperty(TaskReader.ExpressionReader task)
			{
				if (task.VisitProperty())
				{
					return ((TaskReader.MockReader)task).CancelProperty(this);
				}
				object obj = this.PatchProperty(null);
				object obj2 = task.PatchProperty(null);
				return obj != obj2;
			}

			// Token: 0x060002AA RID: 682 RVA: 0x00017034 File Offset: 0x00015234
			internal override TaskReader.ExpressionReader IncludeProperty()
			{
				TaskReader.ExpressionReader expressionReader = this._ConsumerReader as TaskReader.ExpressionReader;
				if (expressionReader != null)
				{
					return expressionReader.IncludeProperty();
				}
				return this;
			}

			// Token: 0x060002AB RID: 683 RVA: 0x00017058 File Offset: 0x00015258
			internal override bool ViewProperty()
			{
				if (this._ConsumerReader != null)
				{
					TaskReader.ExpressionReader expressionReader = this._ConsumerReader as TaskReader.ExpressionReader;
					return expressionReader == null || expressionReader.PatchProperty(null) != null;
				}
				return false;
			}

			// Token: 0x060002AC RID: 684 RVA: 0x00003845 File Offset: 0x00001A45
			internal static bool MapStruct()
			{
				return TaskReader.CandidateReader.RateStruct == null;
			}

			// Token: 0x040001EA RID: 490
			public TaskReader.ExpressionReader _ConsumerReader;

			// Token: 0x040001EB RID: 491
			public Type m_InstanceReader;

			// Token: 0x040001EC RID: 492
			private static object RateStruct;
		}

		// Token: 0x0200006D RID: 109
		private class ResolverReader : TaskReader.ExpressionReader
		{
			// Token: 0x060002AD RID: 685 RVA: 0x0000384F File Offset: 0x00001A4F
			public ResolverReader(string instance)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor((TaskReader.CMSSECTIONID)6);
				this.m_SerializerReader = instance;
			}

			// Token: 0x060002AE RID: 686 RVA: 0x00003864 File Offset: 0x00001A64
			internal override void FindProperty(TaskReader.ExpressionReader instance)
			{
				this.m_SerializerReader = ((TaskReader.ResolverReader)instance).m_SerializerReader;
			}

			// Token: 0x060002AF RID: 687 RVA: 0x000037E9 File Offset: 0x000019E9
			internal override void UpdateProperty(TaskReader.ExpressionReader init)
			{
				this.FindProperty(init);
			}

			// Token: 0x060002B0 RID: 688 RVA: 0x00003877 File Offset: 0x00001A77
			public override string ToString()
			{
				if (this.m_SerializerReader == null)
				{
					return "null";
				}
				return "\"" + this.m_SerializerReader + "\"";
			}

			// Token: 0x060002B1 RID: 689 RVA: 0x0000389C File Offset: 0x00001A9C
			internal override bool ViewProperty()
			{
				return this.m_SerializerReader != null;
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x000038AA File Offset: 0x00001AAA
			internal override object PatchProperty(Type def)
			{
				return this.m_SerializerReader;
			}

			// Token: 0x060002B3 RID: 691 RVA: 0x0001708C File Offset: 0x0001528C
			internal override bool ResolveProperty(TaskReader.ExpressionReader key)
			{
				if (key.VisitProperty())
				{
					return ((TaskReader.MockReader)key).ResolveProperty(this);
				}
				object serializerReader = this.m_SerializerReader;
				object obj = key.PatchProperty(null);
				return serializerReader == obj;
			}

			// Token: 0x060002B4 RID: 692 RVA: 0x000170C4 File Offset: 0x000152C4
			internal override bool CancelProperty(TaskReader.ExpressionReader value)
			{
				if (value.VisitProperty())
				{
					return ((TaskReader.MockReader)value).CancelProperty(this);
				}
				object serializerReader = this.m_SerializerReader;
				object obj = value.PatchProperty(null);
				return serializerReader != obj;
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x000038B2 File Offset: 0x00001AB2
			internal override TaskReader.ExpressionReader IncludeProperty()
			{
				return this;
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x000038B5 File Offset: 0x00001AB5
			internal static bool CollectStruct()
			{
				return TaskReader.ResolverReader.ReflectStruct == null;
			}

			// Token: 0x040001ED RID: 493
			public string m_SerializerReader;

			// Token: 0x040001EE RID: 494
			internal static object ReflectStruct;
		}

		// Token: 0x0200006E RID: 110
		[StructLayout(LayoutKind.Explicit)]
		private struct ProxyAuthenticationAnnotation
		{
			// Token: 0x040001EF RID: 495
			[FieldOffset(0)]
			public byte predicateReader;

			// Token: 0x040001F0 RID: 496
			[FieldOffset(0)]
			public sbyte specificationReader;

			// Token: 0x040001F1 RID: 497
			[FieldOffset(0)]
			public ushort m_ManagerReader;

			// Token: 0x040001F2 RID: 498
			[FieldOffset(0)]
			public short _ProcessReader;

			// Token: 0x040001F3 RID: 499
			[FieldOffset(0)]
			public uint _SchemaReader;

			// Token: 0x040001F4 RID: 500
			[FieldOffset(0)]
			public int tokenizerReader;

			// Token: 0x040001F5 RID: 501
			[FieldOffset(0)]
			public ulong roleReader;

			// Token: 0x040001F6 RID: 502
			[FieldOffset(0)]
			public long _InterpreterReader;
		}

		// Token: 0x0200006F RID: 111
		private abstract class ModelAuthenticationReader : TaskReader.ExpressionReader
		{
			// Token: 0x060002B7 RID: 695
			public abstract bool ConcatProperty();

			// Token: 0x060002B8 RID: 696
			public abstract bool MapProperty();

			// Token: 0x060002B9 RID: 697
			public abstract TaskReader.ExpressionReader ReadProperty(TaskReader.XmlReadMode res);

			// Token: 0x060002BA RID: 698
			public abstract TaskReader.ExporterPolicyPolicy ForgotProperty();

			// Token: 0x060002BB RID: 699
			public abstract TaskReader.ExporterPolicyPolicy RevertProperty();

			// Token: 0x060002BC RID: 700
			public abstract TaskReader.ExporterPolicyPolicy QueryWatcher();

			// Token: 0x060002BD RID: 701
			public abstract TaskReader.ExporterPolicyPolicy AddWatcher();

			// Token: 0x060002BE RID: 702
			public abstract TaskReader.ExporterPolicyPolicy ExcludeWatcher();

			// Token: 0x060002BF RID: 703
			public abstract TaskReader.ExporterPolicyPolicy InstantiateWatcher();

			// Token: 0x060002C0 RID: 704
			public abstract TaskReader.ExporterPolicyPolicy InterruptWatcher();

			// Token: 0x060002C1 RID: 705
			public abstract TaskReader.AlgoReader PushWatcher();

			// Token: 0x060002C2 RID: 706
			public abstract TaskReader.AlgoReader StartWatcher();

			// Token: 0x060002C3 RID: 707
			public abstract TaskReader.ExporterPolicyPolicy PublishWatcher();

			// Token: 0x060002C4 RID: 708
			public abstract TaskReader.ExporterPolicyPolicy ResetWatcher();

			// Token: 0x060002C5 RID: 709
			public abstract TaskReader.ExporterPolicyPolicy SelectWatcher();

			// Token: 0x060002C6 RID: 710
			public abstract TaskReader.AlgoReader InitWatcher();

			// Token: 0x060002C7 RID: 711
			public abstract TaskReader.ExporterPolicyPolicy PrintWatcher();

			// Token: 0x060002C8 RID: 712
			public abstract TaskReader.ExporterPolicyPolicy CountWatcher();

			// Token: 0x060002C9 RID: 713
			public abstract TaskReader.ExporterPolicyPolicy StopWatcher();

			// Token: 0x060002CA RID: 714
			public abstract TaskReader.AlgoReader MoveWatcher();

			// Token: 0x060002CB RID: 715
			public abstract TaskReader.ExporterPolicyPolicy SearchWatcher();

			// Token: 0x060002CC RID: 716
			public abstract TaskReader.ExporterPolicyPolicy ConnectWatcher();

			// Token: 0x060002CD RID: 717
			public abstract TaskReader.ExporterPolicyPolicy SetupWatcher();

			// Token: 0x060002CE RID: 718
			public abstract TaskReader.ExporterPolicyPolicy GetWatcher();

			// Token: 0x060002CF RID: 719
			public abstract TaskReader.ExporterPolicyPolicy PostWatcher();

			// Token: 0x060002D0 RID: 720
			public abstract TaskReader.ExporterPolicyPolicy OrderWatcher();

			// Token: 0x060002D1 RID: 721
			public abstract TaskReader.AlgoReader AssetWatcher();

			// Token: 0x060002D2 RID: 722
			public abstract TaskReader.AlgoReader DefineWatcher();

			// Token: 0x060002D3 RID: 723
			public abstract TaskReader.ExporterPolicyPolicy CollectWatcher();

			// Token: 0x060002D4 RID: 724
			public abstract TaskReader.ExporterPolicyPolicy ListWatcher();

			// Token: 0x060002D5 RID: 725
			public abstract TaskReader.ExporterPolicyPolicy RestartWatcher();

			// Token: 0x060002D6 RID: 726
			public abstract TaskReader.ExporterPolicyPolicy ReflectWatcher();

			// Token: 0x060002D7 RID: 727
			public abstract TaskReader.ExporterPolicyPolicy InsertWatcher();

			// Token: 0x060002D8 RID: 728
			public abstract TaskReader.ExporterPolicyPolicy RemoveWatcher();

			// Token: 0x060002D9 RID: 729
			public abstract TaskReader.AlgoReader RegisterWatcher();

			// Token: 0x060002DA RID: 730
			public abstract TaskReader.AlgoReader WriteWatcher();

			// Token: 0x060002DB RID: 731
			public abstract TaskReader.IssuerInvocationRecord ManageWatcher();

			// Token: 0x060002DC RID: 732
			public abstract TaskReader.IssuerInvocationRecord CompareWatcher();

			// Token: 0x060002DD RID: 733
			public abstract TaskReader.IssuerInvocationRecord ComputeWatcher();

			// Token: 0x060002DE RID: 734
			public abstract TaskReader.WorkerAuthenticationReader SortWatcher();

			// Token: 0x060002DF RID: 735
			public abstract TaskReader.WorkerAuthenticationReader ChangeWatcher();

			// Token: 0x060002E0 RID: 736
			public abstract TaskReader.WorkerAuthenticationReader LoginWatcher();

			// Token: 0x060002E1 RID: 737
			public abstract TaskReader.WorkerAuthenticationReader SetWatcher();

			// Token: 0x060002E2 RID: 738
			public abstract TaskReader.WorkerAuthenticationReader AwakeWatcher();

			// Token: 0x060002E3 RID: 739
			public abstract TaskReader.WorkerAuthenticationReader CustomizeWatcher();

			// Token: 0x060002E4 RID: 740
			public abstract TaskReader.ExpressionReader InvokeWatcher();

			// Token: 0x060002E5 RID: 741
			public abstract TaskReader.ExpressionReader CreateWatcher(TaskReader.ExpressionReader res);

			// Token: 0x060002E6 RID: 742
			public abstract TaskReader.ExpressionReader FlushWatcher(TaskReader.ExpressionReader param);

			// Token: 0x060002E7 RID: 743
			public abstract TaskReader.ExpressionReader CalcWatcher(TaskReader.ExpressionReader v);

			// Token: 0x060002E8 RID: 744
			public abstract TaskReader.ExpressionReader PrepareWatcher(TaskReader.ExpressionReader spec);

			// Token: 0x060002E9 RID: 745
			public abstract TaskReader.ExpressionReader DeleteWatcher(TaskReader.ExpressionReader var1);

			// Token: 0x060002EA RID: 746
			public abstract TaskReader.ExpressionReader CallWatcher(TaskReader.ExpressionReader last);

			// Token: 0x060002EB RID: 747
			public abstract TaskReader.ExpressionReader RateWatcher(TaskReader.ExpressionReader last);

			// Token: 0x060002EC RID: 748
			public abstract TaskReader.ExpressionReader ValidateWatcher(TaskReader.ExpressionReader init);

			// Token: 0x060002ED RID: 749
			public abstract TaskReader.ExpressionReader VerifyWatcher(TaskReader.ExpressionReader ident);

			// Token: 0x060002EE RID: 750
			public abstract TaskReader.ExpressionReader PopWatcher(TaskReader.ExpressionReader asset);

			// Token: 0x060002EF RID: 751
			public abstract TaskReader.ExpressionReader FillWatcher(TaskReader.ExpressionReader var1);

			// Token: 0x060002F0 RID: 752
			public abstract TaskReader.ExpressionReader DisableWatcher(TaskReader.ExpressionReader param);

			// Token: 0x060002F1 RID: 753
			public abstract TaskReader.ExpressionReader EnableWatcher(TaskReader.ExpressionReader key);

			// Token: 0x060002F2 RID: 754
			public abstract TaskReader.ExpressionReader CheckWatcher(TaskReader.ExpressionReader def);

			// Token: 0x060002F3 RID: 755
			public abstract TaskReader.ExpressionReader TestWatcher(TaskReader.ExpressionReader reference);

			// Token: 0x060002F4 RID: 756
			public abstract TaskReader.ExpressionReader DestroyWatcher();

			// Token: 0x060002F5 RID: 757
			public abstract TaskReader.ExpressionReader CloneWatcher(TaskReader.ExpressionReader config);

			// Token: 0x060002F6 RID: 758
			public abstract TaskReader.ModelAuthenticationReader NewWatcher();

			// Token: 0x060002F7 RID: 759
			public abstract TaskReader.ExpressionReader VisitWatcher(TaskReader.ExpressionReader task);

			// Token: 0x060002F8 RID: 760
			public abstract TaskReader.ExpressionReader LogoutWatcher(TaskReader.ExpressionReader var1);

			// Token: 0x060002F9 RID: 761
			public abstract TaskReader.ExpressionReader UpdateWatcher(TaskReader.ExpressionReader setup);

			// Token: 0x060002FA RID: 762
			public abstract bool CalculateWatcher(TaskReader.ExpressionReader setup);

			// Token: 0x060002FB RID: 763
			public abstract bool PatchWatcher(TaskReader.ExpressionReader v);

			// Token: 0x060002FC RID: 764
			public abstract bool ResolveWatcher(TaskReader.ExpressionReader init);

			// Token: 0x060002FD RID: 765
			public abstract bool CancelWatcher(TaskReader.ExpressionReader item);

			// Token: 0x060002FE RID: 766
			public abstract bool ViewWatcher(TaskReader.ExpressionReader key);

			// Token: 0x060002FF RID: 767
			public abstract bool IncludeWatcher(TaskReader.ExpressionReader res);

			// Token: 0x06000300 RID: 768
			public abstract bool RunWatcher(TaskReader.ExpressionReader spec);

			// Token: 0x06000301 RID: 769
			public abstract bool FindWatcher(TaskReader.ExpressionReader spec);

			// Token: 0x06000302 RID: 770 RVA: 0x000038BF File Offset: 0x00001ABF
			internal override bool CalculateProperty()
			{
				return true;
			}

			// Token: 0x06000303 RID: 771 RVA: 0x000038C2 File Offset: 0x00001AC2
			protected ModelAuthenticationReader()
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
			}

			// Token: 0x06000304 RID: 772 RVA: 0x000038CF File Offset: 0x00001ACF
			internal static bool DestroyListener()
			{
				return TaskReader.ModelAuthenticationReader.AssetListener == null;
			}

			// Token: 0x040001F7 RID: 503
			internal static object AssetListener;
		}

		// Token: 0x02000070 RID: 112
		private class AlgoReader : TaskReader.ModelAuthenticationReader
		{
			// Token: 0x06000305 RID: 773 RVA: 0x000038D9 File Offset: 0x00001AD9
			internal override void FindProperty(TaskReader.ExpressionReader info)
			{
				this._IteratorReader = ((TaskReader.AlgoReader)info)._IteratorReader;
				this._MessageReader = ((TaskReader.AlgoReader)info)._MessageReader;
			}

			// Token: 0x06000306 RID: 774 RVA: 0x000037E9 File Offset: 0x000019E9
			internal override void UpdateProperty(TaskReader.ExpressionReader res)
			{
				this.FindProperty(res);
			}

			// Token: 0x06000307 RID: 775 RVA: 0x000038FD File Offset: 0x00001AFD
			public AlgoReader(long indexident)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)2;
				this._IteratorReader._InterpreterReader = indexident;
				this._MessageReader = (TaskReader.XmlReadMode)7;
			}

			// Token: 0x06000308 RID: 776 RVA: 0x00003924 File Offset: 0x00001B24
			public AlgoReader(TaskReader.AlgoReader v)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = v.m_ComparatorReader;
				this._IteratorReader._InterpreterReader = v._IteratorReader._InterpreterReader;
				this._MessageReader = v._MessageReader;
			}

			// Token: 0x06000309 RID: 777 RVA: 0x0000395F File Offset: 0x00001B5F
			public override TaskReader.ModelAuthenticationReader NewWatcher()
			{
				return new TaskReader.AlgoReader(this);
			}

			// Token: 0x0600030A RID: 778 RVA: 0x00003967 File Offset: 0x00001B67
			public AlgoReader(long v, TaskReader.XmlReadMode attr)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)2;
				this._IteratorReader._InterpreterReader = v;
				this._MessageReader = attr;
			}

			// Token: 0x0600030B RID: 779 RVA: 0x0000398E File Offset: 0x00001B8E
			public AlgoReader(ulong no__instance)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)2;
				this._IteratorReader.roleReader = no__instance;
				this._MessageReader = (TaskReader.XmlReadMode)8;
			}

			// Token: 0x0600030C RID: 780 RVA: 0x000039B5 File Offset: 0x00001BB5
			public AlgoReader(ulong row_instance, TaskReader.XmlReadMode token)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)2;
				this._IteratorReader.roleReader = row_instance;
				this._MessageReader = token;
			}

			// Token: 0x0600030D RID: 781 RVA: 0x000039DC File Offset: 0x00001BDC
			public override bool ConcatProperty()
			{
				if (this._MessageReader == (TaskReader.XmlReadMode)7)
				{
					return this._IteratorReader._InterpreterReader == 0L;
				}
				return this._IteratorReader.roleReader == 0UL;
			}

			// Token: 0x0600030E RID: 782 RVA: 0x00003A14 File Offset: 0x00001C14
			public override bool MapProperty()
			{
				return !this.ConcatProperty();
			}

			// Token: 0x0600030F RID: 783 RVA: 0x000170FC File Offset: 0x000152FC
			public override TaskReader.ExpressionReader ReadProperty(TaskReader.XmlReadMode item)
			{
				switch (item)
				{
				case (TaskReader.XmlReadMode)1:
					return this.RevertProperty();
				case (TaskReader.XmlReadMode)2:
					return this.QueryWatcher();
				case (TaskReader.XmlReadMode)3:
					return this.AddWatcher();
				case (TaskReader.XmlReadMode)4:
					return this.ExcludeWatcher();
				case (TaskReader.XmlReadMode)5:
					return this.InstantiateWatcher();
				case (TaskReader.XmlReadMode)6:
					return this.InterruptWatcher();
				case (TaskReader.XmlReadMode)7:
					return this.PushWatcher();
				case (TaskReader.XmlReadMode)8:
					return this.StartWatcher();
				case (TaskReader.XmlReadMode)11:
					return this.ForgotProperty();
				case (TaskReader.XmlReadMode)15:
					return this.ReadRule();
				case (TaskReader.XmlReadMode)16:
					return this.NewWatcher();
				}
				throw new Exception("truncation not supported");
			}

			// Token: 0x06000310 RID: 784 RVA: 0x000171AC File Offset: 0x000153AC
			internal override object PatchProperty(Type info)
			{
				if (info != null && info.IsByRef)
				{
					info = info.GetElementType();
				}
				if (info == null || info == typeof(object))
				{
					switch (this._MessageReader)
					{
					case (TaskReader.XmlReadMode)1:
						return this._IteratorReader.specificationReader;
					case (TaskReader.XmlReadMode)2:
						return this._IteratorReader.predicateReader;
					case (TaskReader.XmlReadMode)3:
						return this._IteratorReader._ProcessReader;
					case (TaskReader.XmlReadMode)4:
						return this._IteratorReader.m_ManagerReader;
					case (TaskReader.XmlReadMode)5:
						return this._IteratorReader.tokenizerReader;
					case (TaskReader.XmlReadMode)6:
						return this._IteratorReader._SchemaReader;
					case (TaskReader.XmlReadMode)7:
						return this._IteratorReader._InterpreterReader;
					case (TaskReader.XmlReadMode)8:
						return this._IteratorReader.roleReader;
					case (TaskReader.XmlReadMode)11:
						return this.MapProperty();
					case (TaskReader.XmlReadMode)15:
						return (char)this._IteratorReader.tokenizerReader;
					}
					return this._IteratorReader._InterpreterReader;
				}
				if (info == typeof(int))
				{
					return this._IteratorReader.tokenizerReader;
				}
				if (info == typeof(uint))
				{
					return this._IteratorReader._SchemaReader;
				}
				if (info == typeof(short))
				{
					return this._IteratorReader._ProcessReader;
				}
				if (info == typeof(ushort))
				{
					return this._IteratorReader.m_ManagerReader;
				}
				if (info == typeof(byte))
				{
					return this._IteratorReader.predicateReader;
				}
				if (info == typeof(sbyte))
				{
					return this._IteratorReader.specificationReader;
				}
				if (info == typeof(bool))
				{
					return !this.ConcatProperty();
				}
				if (info == typeof(long))
				{
					return this._IteratorReader._InterpreterReader;
				}
				if (info == typeof(ulong))
				{
					return this._IteratorReader.roleReader;
				}
				if (info == typeof(char))
				{
					return (char)this._IteratorReader._InterpreterReader;
				}
				if (!info.IsEnum)
				{
					throw new TaskReader.IndexerReader();
				}
				return this.MapRule(info);
			}

			// Token: 0x06000311 RID: 785 RVA: 0x00017478 File Offset: 0x00015678
			internal object MapRule(Type spec)
			{
				Type underlyingType = Enum.GetUnderlyingType(spec);
				if (underlyingType == typeof(int))
				{
					return Enum.ToObject(spec, this._IteratorReader.tokenizerReader);
				}
				if (underlyingType == typeof(uint))
				{
					return Enum.ToObject(spec, this._IteratorReader._SchemaReader);
				}
				if (underlyingType == typeof(short))
				{
					return Enum.ToObject(spec, this._IteratorReader._ProcessReader);
				}
				if (underlyingType == typeof(ushort))
				{
					return Enum.ToObject(spec, this._IteratorReader.m_ManagerReader);
				}
				if (underlyingType == typeof(byte))
				{
					return Enum.ToObject(spec, this._IteratorReader.predicateReader);
				}
				if (underlyingType == typeof(sbyte))
				{
					return Enum.ToObject(spec, this._IteratorReader.specificationReader);
				}
				if (underlyingType == typeof(long))
				{
					return Enum.ToObject(spec, this._IteratorReader._InterpreterReader);
				}
				if (underlyingType == typeof(ulong))
				{
					return Enum.ToObject(spec, this._IteratorReader.roleReader);
				}
				if (!(underlyingType == typeof(char)))
				{
					return Enum.ToObject(spec, this._IteratorReader._InterpreterReader);
				}
				return Enum.ToObject(spec, (ushort)this._IteratorReader.tokenizerReader);
			}

			// Token: 0x06000312 RID: 786 RVA: 0x00003A1F File Offset: 0x00001C1F
			public override TaskReader.ExporterPolicyPolicy ForgotProperty()
			{
				return new TaskReader.ExporterPolicyPolicy(this.ConcatProperty() ? 0 : 1);
			}

			// Token: 0x06000313 RID: 787 RVA: 0x00003A32 File Offset: 0x00001C32
			internal override bool ViewProperty()
			{
				return this.MapProperty();
			}

			// Token: 0x06000314 RID: 788 RVA: 0x00003A3A File Offset: 0x00001C3A
			public TaskReader.ExporterPolicyPolicy ReadRule()
			{
				return new TaskReader.ExporterPolicyPolicy((int)this._IteratorReader.specificationReader, (TaskReader.XmlReadMode)15);
			}

			// Token: 0x06000315 RID: 789 RVA: 0x00003A4E File Offset: 0x00001C4E
			public override TaskReader.ExporterPolicyPolicy RevertProperty()
			{
				return new TaskReader.ExporterPolicyPolicy((int)this._IteratorReader.specificationReader, (TaskReader.XmlReadMode)1);
			}

			// Token: 0x06000316 RID: 790 RVA: 0x00003A61 File Offset: 0x00001C61
			public override TaskReader.ExporterPolicyPolicy QueryWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((uint)this._IteratorReader.predicateReader, (TaskReader.XmlReadMode)2);
			}

			// Token: 0x06000317 RID: 791 RVA: 0x00003A74 File Offset: 0x00001C74
			public override TaskReader.ExporterPolicyPolicy AddWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)this._IteratorReader._ProcessReader, (TaskReader.XmlReadMode)3);
			}

			// Token: 0x06000318 RID: 792 RVA: 0x00003A87 File Offset: 0x00001C87
			public override TaskReader.ExporterPolicyPolicy ExcludeWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((uint)this._IteratorReader.m_ManagerReader, (TaskReader.XmlReadMode)4);
			}

			// Token: 0x06000319 RID: 793 RVA: 0x00003A9A File Offset: 0x00001C9A
			public override TaskReader.ExporterPolicyPolicy InstantiateWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(this._IteratorReader.tokenizerReader, (TaskReader.XmlReadMode)5);
			}

			// Token: 0x0600031A RID: 794 RVA: 0x00003AAD File Offset: 0x00001CAD
			public override TaskReader.ExporterPolicyPolicy InterruptWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(this._IteratorReader._SchemaReader, (TaskReader.XmlReadMode)6);
			}

			// Token: 0x0600031B RID: 795 RVA: 0x00003AC0 File Offset: 0x00001CC0
			public override TaskReader.AlgoReader PushWatcher()
			{
				return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader, (TaskReader.XmlReadMode)7);
			}

			// Token: 0x0600031C RID: 796 RVA: 0x00003AD3 File Offset: 0x00001CD3
			public override TaskReader.AlgoReader StartWatcher()
			{
				return new TaskReader.AlgoReader(this._IteratorReader.roleReader, (TaskReader.XmlReadMode)8);
			}

			// Token: 0x0600031D RID: 797 RVA: 0x00003AE6 File Offset: 0x00001CE6
			public override TaskReader.ExporterPolicyPolicy PublishWatcher()
			{
				return this.RevertProperty();
			}

			// Token: 0x0600031E RID: 798 RVA: 0x00003AEE File Offset: 0x00001CEE
			public override TaskReader.ExporterPolicyPolicy ResetWatcher()
			{
				return this.AddWatcher();
			}

			// Token: 0x0600031F RID: 799 RVA: 0x00003AF6 File Offset: 0x00001CF6
			public override TaskReader.ExporterPolicyPolicy SelectWatcher()
			{
				return this.InstantiateWatcher();
			}

			// Token: 0x06000320 RID: 800 RVA: 0x00003AFE File Offset: 0x00001CFE
			public override TaskReader.AlgoReader InitWatcher()
			{
				return this.PushWatcher();
			}

			// Token: 0x06000321 RID: 801 RVA: 0x00003B06 File Offset: 0x00001D06
			public override TaskReader.ExporterPolicyPolicy PrintWatcher()
			{
				return this.QueryWatcher();
			}

			// Token: 0x06000322 RID: 802 RVA: 0x00003B0E File Offset: 0x00001D0E
			public override TaskReader.ExporterPolicyPolicy CountWatcher()
			{
				return this.ExcludeWatcher();
			}

			// Token: 0x06000323 RID: 803 RVA: 0x00003B16 File Offset: 0x00001D16
			public override TaskReader.ExporterPolicyPolicy StopWatcher()
			{
				return this.InterruptWatcher();
			}

			// Token: 0x06000324 RID: 804 RVA: 0x00003B1E File Offset: 0x00001D1E
			public override TaskReader.AlgoReader MoveWatcher()
			{
				return this.StartWatcher();
			}

			// Token: 0x06000325 RID: 805 RVA: 0x00003B26 File Offset: 0x00001D26
			public override TaskReader.ExporterPolicyPolicy SearchWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((sbyte)this._IteratorReader._InterpreterReader)), (TaskReader.XmlReadMode)1);
			}

			// Token: 0x06000326 RID: 806 RVA: 0x00003B3A File Offset: 0x00001D3A
			public override TaskReader.ExporterPolicyPolicy ConnectWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((sbyte)this._IteratorReader.roleReader)), (TaskReader.XmlReadMode)1);
			}

			// Token: 0x06000327 RID: 807 RVA: 0x00003B4E File Offset: 0x00001D4E
			public override TaskReader.ExporterPolicyPolicy SetupWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((short)this._IteratorReader._InterpreterReader)), (TaskReader.XmlReadMode)3);
			}

			// Token: 0x06000328 RID: 808 RVA: 0x00003B62 File Offset: 0x00001D62
			public override TaskReader.ExporterPolicyPolicy GetWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((short)this._IteratorReader.roleReader)), (TaskReader.XmlReadMode)3);
			}

			// Token: 0x06000329 RID: 809 RVA: 0x00003B76 File Offset: 0x00001D76
			public override TaskReader.ExporterPolicyPolicy PostWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(checked((int)this._IteratorReader._InterpreterReader), (TaskReader.XmlReadMode)5);
			}

			// Token: 0x0600032A RID: 810 RVA: 0x00003B8A File Offset: 0x00001D8A
			public override TaskReader.ExporterPolicyPolicy OrderWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(checked((int)this._IteratorReader.roleReader), (TaskReader.XmlReadMode)5);
			}

			// Token: 0x0600032B RID: 811 RVA: 0x00003AC0 File Offset: 0x00001CC0
			public override TaskReader.AlgoReader AssetWatcher()
			{
				return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader, (TaskReader.XmlReadMode)7);
			}

			// Token: 0x0600032C RID: 812 RVA: 0x00003B9E File Offset: 0x00001D9E
			public override TaskReader.AlgoReader DefineWatcher()
			{
				return new TaskReader.AlgoReader(checked((long)this._IteratorReader.roleReader), (TaskReader.XmlReadMode)7);
			}

			// Token: 0x0600032D RID: 813 RVA: 0x00003BB2 File Offset: 0x00001DB2
			public override TaskReader.ExporterPolicyPolicy CollectWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((byte)this._IteratorReader._InterpreterReader)), (TaskReader.XmlReadMode)2);
			}

			// Token: 0x0600032E RID: 814 RVA: 0x00003BC6 File Offset: 0x00001DC6
			public override TaskReader.ExporterPolicyPolicy ListWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((byte)this._IteratorReader.roleReader)), (TaskReader.XmlReadMode)2);
			}

			// Token: 0x0600032F RID: 815 RVA: 0x00003BDA File Offset: 0x00001DDA
			public override TaskReader.ExporterPolicyPolicy RestartWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((ushort)this._IteratorReader._InterpreterReader)), (TaskReader.XmlReadMode)4);
			}

			// Token: 0x06000330 RID: 816 RVA: 0x00003BEE File Offset: 0x00001DEE
			public override TaskReader.ExporterPolicyPolicy ReflectWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((ushort)this._IteratorReader.roleReader)), (TaskReader.XmlReadMode)4);
			}

			// Token: 0x06000331 RID: 817 RVA: 0x00003C02 File Offset: 0x00001E02
			public override TaskReader.ExporterPolicyPolicy InsertWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(checked((uint)this._IteratorReader._InterpreterReader), (TaskReader.XmlReadMode)6);
			}

			// Token: 0x06000332 RID: 818 RVA: 0x00003C16 File Offset: 0x00001E16
			public override TaskReader.ExporterPolicyPolicy RemoveWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(checked((uint)this._IteratorReader.roleReader), (TaskReader.XmlReadMode)6);
			}

			// Token: 0x06000333 RID: 819 RVA: 0x00003C2A File Offset: 0x00001E2A
			public override TaskReader.AlgoReader RegisterWatcher()
			{
				return new TaskReader.AlgoReader(checked((ulong)this._IteratorReader._InterpreterReader), (TaskReader.XmlReadMode)8);
			}

			// Token: 0x06000334 RID: 820 RVA: 0x00003AD3 File Offset: 0x00001CD3
			public override TaskReader.AlgoReader WriteWatcher()
			{
				return new TaskReader.AlgoReader(this._IteratorReader.roleReader, (TaskReader.XmlReadMode)8);
			}

			// Token: 0x06000335 RID: 821 RVA: 0x00003C3E File Offset: 0x00001E3E
			public override TaskReader.IssuerInvocationRecord ManageWatcher()
			{
				return new TaskReader.IssuerInvocationRecord((float)this._IteratorReader._InterpreterReader);
			}

			// Token: 0x06000336 RID: 822 RVA: 0x00003C51 File Offset: 0x00001E51
			public override TaskReader.IssuerInvocationRecord CompareWatcher()
			{
				return new TaskReader.IssuerInvocationRecord((double)this._IteratorReader._InterpreterReader);
			}

			// Token: 0x06000337 RID: 823 RVA: 0x00003C64 File Offset: 0x00001E64
			public override TaskReader.IssuerInvocationRecord ComputeWatcher()
			{
				return new TaskReader.IssuerInvocationRecord(this._IteratorReader.roleReader);
			}

			// Token: 0x06000338 RID: 824 RVA: 0x00003C78 File Offset: 0x00001E78
			public override TaskReader.WorkerAuthenticationReader SortWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.InitWatcher()._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)this.SelectWatcher().paramsReader.filterReader);
			}

			// Token: 0x06000339 RID: 825 RVA: 0x00003CAE File Offset: 0x00001EAE
			public override TaskReader.WorkerAuthenticationReader ChangeWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.MoveWatcher()._IteratorReader.roleReader);
				}
				return new TaskReader.WorkerAuthenticationReader((ulong)this.StopWatcher().paramsReader.m_StubReader);
			}

			// Token: 0x0600033A RID: 826 RVA: 0x00003CE4 File Offset: 0x00001EE4
			public override TaskReader.WorkerAuthenticationReader LoginWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.AssetWatcher()._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)this.PostWatcher().paramsReader.filterReader);
			}

			// Token: 0x0600033B RID: 827 RVA: 0x00003D1A File Offset: 0x00001F1A
			public override TaskReader.WorkerAuthenticationReader SetWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.RegisterWatcher()._IteratorReader.roleReader);
				}
				return new TaskReader.WorkerAuthenticationReader((ulong)this.InsertWatcher().paramsReader.m_StubReader);
			}

			// Token: 0x0600033C RID: 828 RVA: 0x00003D50 File Offset: 0x00001F50
			public override TaskReader.WorkerAuthenticationReader AwakeWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.DefineWatcher()._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)this.OrderWatcher().paramsReader.filterReader);
			}

			// Token: 0x0600033D RID: 829 RVA: 0x00003D86 File Offset: 0x00001F86
			public override TaskReader.WorkerAuthenticationReader CustomizeWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this._IteratorReader.roleReader);
				}
				return new TaskReader.WorkerAuthenticationReader((ulong)(checked((uint)this._IteratorReader.roleReader)));
			}

			// Token: 0x0600033E RID: 830 RVA: 0x00003DB3 File Offset: 0x00001FB3
			public override TaskReader.ExpressionReader InvokeWatcher()
			{
				return new TaskReader.AlgoReader(-this._IteratorReader._InterpreterReader);
			}

			// Token: 0x0600033F RID: 831 RVA: 0x000175E8 File Offset: 0x000157E8
			public override TaskReader.ExpressionReader CreateWatcher(TaskReader.ExpressionReader info)
			{
				if (info.VisitProperty())
				{
					info = info.IncludeProperty();
				}
				if (!info.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader + ((TaskReader.AlgoReader)info)._IteratorReader._InterpreterReader);
			}

			// Token: 0x06000340 RID: 832 RVA: 0x00017634 File Offset: 0x00015834
			public override TaskReader.ExpressionReader FlushWatcher(TaskReader.ExpressionReader value)
			{
				if (value.VisitProperty())
				{
					value = value.IncludeProperty();
				}
				if (!value.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(checked(this._IteratorReader._InterpreterReader + ((TaskReader.AlgoReader)value)._IteratorReader._InterpreterReader));
			}

			// Token: 0x06000341 RID: 833 RVA: 0x00017680 File Offset: 0x00015880
			public override TaskReader.ExpressionReader CalcWatcher(TaskReader.ExpressionReader reference)
			{
				if (reference.VisitProperty())
				{
					reference = reference.IncludeProperty();
				}
				if (!reference.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(checked(this._IteratorReader.roleReader + ((TaskReader.AlgoReader)reference)._IteratorReader.roleReader));
			}

			// Token: 0x06000342 RID: 834 RVA: 0x000176CC File Offset: 0x000158CC
			public override TaskReader.ExpressionReader PrepareWatcher(TaskReader.ExpressionReader info)
			{
				if (info.VisitProperty())
				{
					info = info.IncludeProperty();
				}
				if (!info.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader - ((TaskReader.AlgoReader)info)._IteratorReader._InterpreterReader);
			}

			// Token: 0x06000343 RID: 835 RVA: 0x00017718 File Offset: 0x00015918
			public override TaskReader.ExpressionReader DeleteWatcher(TaskReader.ExpressionReader instance)
			{
				if (instance.VisitProperty())
				{
					instance = instance.IncludeProperty();
				}
				if (!instance.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(checked(this._IteratorReader._InterpreterReader - ((TaskReader.AlgoReader)instance)._IteratorReader._InterpreterReader));
			}

			// Token: 0x06000344 RID: 836 RVA: 0x00017764 File Offset: 0x00015964
			public override TaskReader.ExpressionReader CallWatcher(TaskReader.ExpressionReader param)
			{
				if (param.VisitProperty())
				{
					param = param.IncludeProperty();
				}
				if (!param.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(checked(this._IteratorReader.roleReader - ((TaskReader.AlgoReader)param)._IteratorReader.roleReader));
			}

			// Token: 0x06000345 RID: 837 RVA: 0x000177B0 File Offset: 0x000159B0
			public override TaskReader.ExpressionReader RateWatcher(TaskReader.ExpressionReader first)
			{
				if (first.VisitProperty())
				{
					first = first.IncludeProperty();
				}
				if (!first.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader * ((TaskReader.AlgoReader)first)._IteratorReader._InterpreterReader);
			}

			// Token: 0x06000346 RID: 838 RVA: 0x000177FC File Offset: 0x000159FC
			public override TaskReader.ExpressionReader ValidateWatcher(TaskReader.ExpressionReader i)
			{
				if (i.VisitProperty())
				{
					i = i.IncludeProperty();
				}
				if (!i.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(checked(this._IteratorReader._InterpreterReader * ((TaskReader.AlgoReader)i)._IteratorReader._InterpreterReader));
			}

			// Token: 0x06000347 RID: 839 RVA: 0x00017848 File Offset: 0x00015A48
			public override TaskReader.ExpressionReader VerifyWatcher(TaskReader.ExpressionReader instance)
			{
				if (instance.VisitProperty())
				{
					instance = instance.IncludeProperty();
				}
				if (!instance.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(checked(this._IteratorReader.roleReader * ((TaskReader.AlgoReader)instance)._IteratorReader.roleReader));
			}

			// Token: 0x06000348 RID: 840 RVA: 0x00017894 File Offset: 0x00015A94
			public override TaskReader.ExpressionReader PopWatcher(TaskReader.ExpressionReader value)
			{
				if (value.VisitProperty())
				{
					value = value.IncludeProperty();
				}
				if (!value.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader / ((TaskReader.AlgoReader)value)._IteratorReader._InterpreterReader);
			}

			// Token: 0x06000349 RID: 841 RVA: 0x000178E0 File Offset: 0x00015AE0
			public override TaskReader.ExpressionReader FillWatcher(TaskReader.ExpressionReader config)
			{
				if (config.VisitProperty())
				{
					config = config.IncludeProperty();
				}
				if (!config.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(this._IteratorReader.roleReader / ((TaskReader.AlgoReader)config)._IteratorReader.roleReader);
			}

			// Token: 0x0600034A RID: 842 RVA: 0x0001792C File Offset: 0x00015B2C
			public override TaskReader.ExpressionReader DisableWatcher(TaskReader.ExpressionReader asset)
			{
				if (asset.VisitProperty())
				{
					asset = asset.IncludeProperty();
				}
				if (!asset.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader % ((TaskReader.AlgoReader)asset)._IteratorReader._InterpreterReader);
			}

			// Token: 0x0600034B RID: 843 RVA: 0x00017978 File Offset: 0x00015B78
			public override TaskReader.ExpressionReader EnableWatcher(TaskReader.ExpressionReader task)
			{
				if (task.VisitProperty())
				{
					task = task.IncludeProperty();
				}
				if (!task.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(this._IteratorReader.roleReader % ((TaskReader.AlgoReader)task)._IteratorReader.roleReader);
			}

			// Token: 0x0600034C RID: 844 RVA: 0x000179C4 File Offset: 0x00015BC4
			public override TaskReader.ExpressionReader CheckWatcher(TaskReader.ExpressionReader def)
			{
				if (def.VisitProperty())
				{
					def = def.IncludeProperty();
				}
				if (!def.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader & ((TaskReader.AlgoReader)def)._IteratorReader._InterpreterReader);
			}

			// Token: 0x0600034D RID: 845 RVA: 0x00017A10 File Offset: 0x00015C10
			public override TaskReader.ExpressionReader TestWatcher(TaskReader.ExpressionReader param)
			{
				if (param.VisitProperty())
				{
					param = param.IncludeProperty();
				}
				if (!param.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader | ((TaskReader.AlgoReader)param)._IteratorReader._InterpreterReader);
			}

			// Token: 0x0600034E RID: 846 RVA: 0x00003DC6 File Offset: 0x00001FC6
			public override TaskReader.ExpressionReader DestroyWatcher()
			{
				return new TaskReader.AlgoReader(~this._IteratorReader._InterpreterReader);
			}

			// Token: 0x0600034F RID: 847 RVA: 0x00017A5C File Offset: 0x00015C5C
			public override TaskReader.ExpressionReader CloneWatcher(TaskReader.ExpressionReader instance)
			{
				if (instance.VisitProperty())
				{
					instance = instance.IncludeProperty();
				}
				if (!instance.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader ^ ((TaskReader.AlgoReader)instance)._IteratorReader._InterpreterReader);
			}

			// Token: 0x06000350 RID: 848 RVA: 0x00017AA8 File Offset: 0x00015CA8
			public override TaskReader.ExpressionReader VisitWatcher(TaskReader.ExpressionReader item)
			{
				if (item.VisitProperty())
				{
					item = item.IncludeProperty();
				}
				if (item.ResolveRule())
				{
					return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader << ((TaskReader.AlgoReader)item)._IteratorReader.tokenizerReader);
				}
				if (!item.CalculateProperty())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader << ((TaskReader.ModelAuthenticationReader)item).InstantiateWatcher().paramsReader.filterReader);
			}

			// Token: 0x06000351 RID: 849 RVA: 0x00017B2C File Offset: 0x00015D2C
			public override TaskReader.ExpressionReader LogoutWatcher(TaskReader.ExpressionReader def)
			{
				if (def.VisitProperty())
				{
					def = def.IncludeProperty();
				}
				if (def.ResolveRule())
				{
					return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader >> ((TaskReader.AlgoReader)def)._IteratorReader.tokenizerReader);
				}
				if (!def.CalculateProperty())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(this._IteratorReader._InterpreterReader >> ((TaskReader.ModelAuthenticationReader)def).InstantiateWatcher().paramsReader.filterReader);
			}

			// Token: 0x06000352 RID: 850 RVA: 0x00017BB0 File Offset: 0x00015DB0
			public override TaskReader.ExpressionReader UpdateWatcher(TaskReader.ExpressionReader init)
			{
				if (init.VisitProperty())
				{
					init = init.IncludeProperty();
				}
				if (init.ResolveRule())
				{
					return new TaskReader.AlgoReader(this._IteratorReader.roleReader >> ((TaskReader.AlgoReader)init)._IteratorReader.tokenizerReader);
				}
				if (!init.CalculateProperty())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.AlgoReader(this._IteratorReader.roleReader >> ((TaskReader.ModelAuthenticationReader)init).InstantiateWatcher().paramsReader.filterReader);
			}

			// Token: 0x06000353 RID: 851 RVA: 0x00003DD9 File Offset: 0x00001FD9
			public override string ToString()
			{
				if (this._MessageReader == (TaskReader.XmlReadMode)7)
				{
					return this._IteratorReader._InterpreterReader.ToString();
				}
				return this._IteratorReader.roleReader.ToString();
			}

			// Token: 0x06000354 RID: 852 RVA: 0x000038B2 File Offset: 0x00001AB2
			internal override TaskReader.ExpressionReader IncludeProperty()
			{
				return this;
			}

			// Token: 0x06000355 RID: 853 RVA: 0x000038BF File Offset: 0x00001ABF
			internal override bool RunProperty()
			{
				return true;
			}

			// Token: 0x06000356 RID: 854 RVA: 0x00017C34 File Offset: 0x00015E34
			internal override bool ResolveProperty(TaskReader.ExpressionReader var1)
			{
				if (var1.UpdateRule())
				{
					return ((TaskReader.CandidateReader)var1).ResolveProperty(this);
				}
				if (var1.VisitProperty())
				{
					return ((TaskReader.MockReader)var1).ResolveProperty(this);
				}
				TaskReader.ExpressionReader expressionReader = var1.IncludeProperty();
				return expressionReader.ResolveRule() && this._IteratorReader._InterpreterReader == ((TaskReader.AlgoReader)expressionReader)._IteratorReader._InterpreterReader;
			}

			// Token: 0x06000357 RID: 855 RVA: 0x00016DBC File Offset: 0x00014FBC
			private static TaskReader.ModelAuthenticationReader ForgotRule(TaskReader.ExpressionReader init)
			{
				TaskReader.ModelAuthenticationReader modelAuthenticationReader = init as TaskReader.ModelAuthenticationReader;
				if (modelAuthenticationReader == null && init.VisitProperty())
				{
					modelAuthenticationReader = (init.IncludeProperty() as TaskReader.ModelAuthenticationReader);
				}
				return modelAuthenticationReader;
			}

			// Token: 0x06000358 RID: 856 RVA: 0x00017C9C File Offset: 0x00015E9C
			internal override bool CancelProperty(TaskReader.ExpressionReader ident)
			{
				if (ident.UpdateRule())
				{
					return false;
				}
				if (ident.VisitProperty())
				{
					return ((TaskReader.MockReader)ident).CancelProperty(this);
				}
				TaskReader.ExpressionReader expressionReader = ident.IncludeProperty();
				return expressionReader.ResolveRule() && this._IteratorReader.roleReader != ((TaskReader.AlgoReader)expressionReader)._IteratorReader.roleReader;
			}

			// Token: 0x06000359 RID: 857 RVA: 0x00003E05 File Offset: 0x00002005
			public override bool CalculateWatcher(TaskReader.ExpressionReader ident)
			{
				if (ident.VisitProperty())
				{
					ident = ident.IncludeProperty();
				}
				if (!ident.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this._IteratorReader._InterpreterReader >= ((TaskReader.AlgoReader)ident)._IteratorReader._InterpreterReader;
			}

			// Token: 0x0600035A RID: 858 RVA: 0x00003E45 File Offset: 0x00002045
			public override bool PatchWatcher(TaskReader.ExpressionReader config)
			{
				if (config.VisitProperty())
				{
					config = config.IncludeProperty();
				}
				if (!config.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this._IteratorReader.roleReader >= ((TaskReader.AlgoReader)config)._IteratorReader.roleReader;
			}

			// Token: 0x0600035B RID: 859 RVA: 0x00003E85 File Offset: 0x00002085
			public override bool ResolveWatcher(TaskReader.ExpressionReader last)
			{
				if (last.VisitProperty())
				{
					last = last.IncludeProperty();
				}
				if (!last.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this._IteratorReader._InterpreterReader > ((TaskReader.AlgoReader)last)._IteratorReader._InterpreterReader;
			}

			// Token: 0x0600035C RID: 860 RVA: 0x00003EC2 File Offset: 0x000020C2
			public override bool CancelWatcher(TaskReader.ExpressionReader task)
			{
				if (task.VisitProperty())
				{
					task = task.IncludeProperty();
				}
				if (!task.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this._IteratorReader.roleReader > ((TaskReader.AlgoReader)task)._IteratorReader.roleReader;
			}

			// Token: 0x0600035D RID: 861 RVA: 0x00003EFF File Offset: 0x000020FF
			public override bool ViewWatcher(TaskReader.ExpressionReader def)
			{
				if (def.VisitProperty())
				{
					def = def.IncludeProperty();
				}
				if (!def.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this._IteratorReader._InterpreterReader <= ((TaskReader.AlgoReader)def)._IteratorReader._InterpreterReader;
			}

			// Token: 0x0600035E RID: 862 RVA: 0x00003F3F File Offset: 0x0000213F
			public override bool IncludeWatcher(TaskReader.ExpressionReader ident)
			{
				if (ident.VisitProperty())
				{
					ident = ident.IncludeProperty();
				}
				if (!ident.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this._IteratorReader.roleReader <= ((TaskReader.AlgoReader)ident)._IteratorReader.roleReader;
			}

			// Token: 0x0600035F RID: 863 RVA: 0x00003F7F File Offset: 0x0000217F
			public override bool RunWatcher(TaskReader.ExpressionReader def)
			{
				if (def.VisitProperty())
				{
					def = def.IncludeProperty();
				}
				if (!def.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this._IteratorReader._InterpreterReader < ((TaskReader.AlgoReader)def)._IteratorReader._InterpreterReader;
			}

			// Token: 0x06000360 RID: 864 RVA: 0x00003FBC File Offset: 0x000021BC
			public override bool FindWatcher(TaskReader.ExpressionReader v)
			{
				if (v.VisitProperty())
				{
					v = v.IncludeProperty();
				}
				if (!v.ResolveRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this._IteratorReader.roleReader < ((TaskReader.AlgoReader)v)._IteratorReader.roleReader;
			}

			// Token: 0x06000361 RID: 865 RVA: 0x00003FF9 File Offset: 0x000021F9
			internal static bool ValidateListener()
			{
				return TaskReader.AlgoReader.ForgotListener == null;
			}

			// Token: 0x040001F8 RID: 504
			public TaskReader.ProxyAuthenticationAnnotation _IteratorReader;

			// Token: 0x040001F9 RID: 505
			public TaskReader.XmlReadMode _MessageReader;

			// Token: 0x040001FA RID: 506
			private static object ForgotListener;
		}

		// Token: 0x02000071 RID: 113
		internal class FieldWatcherClass
		{
			// Token: 0x06000362 RID: 866 RVA: 0x00017CFC File Offset: 0x00015EFC
			public override string ToString()
			{
				object obj = this._WrapperReader;
				if (this.m_ProducerReader == null)
				{
					return obj.ToString();
				}
				return obj.ToString() + " : " + this.m_ProducerReader.ToString();
			}

			// Token: 0x06000363 RID: 867 RVA: 0x00004003 File Offset: 0x00002203
			public FieldWatcherClass()
			{
				AdvisorConnectionAttribute.CancelComposer();
				this._WrapperReader = (TaskReader.UnhandledExceptionAction)126;
				base..ctor();
			}

			// Token: 0x06000364 RID: 868 RVA: 0x00004018 File Offset: 0x00002218
			internal static bool InitListener()
			{
				return TaskReader.FieldWatcherClass.PublishListener == null;
			}

			// Token: 0x040001FB RID: 507
			internal TaskReader.UnhandledExceptionAction _WrapperReader;

			// Token: 0x040001FC RID: 508
			internal object m_ProducerReader;

			// Token: 0x040001FD RID: 509
			internal static object PublishListener;
		}

		// Token: 0x02000072 RID: 114
		internal class SystemConnectionAttribute
		{
			// Token: 0x06000365 RID: 869 RVA: 0x000024D4 File Offset: 0x000006D4
			public SystemConnectionAttribute()
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
			}

			// Token: 0x06000366 RID: 870 RVA: 0x00004022 File Offset: 0x00002222
			internal static bool FlushListener()
			{
				return TaskReader.SystemConnectionAttribute.InstantiateListener == null;
			}

			// Token: 0x040001FE RID: 510
			public int proccesorReader;

			// Token: 0x040001FF RID: 511
			public bool m_AttributeReader;

			// Token: 0x04000200 RID: 512
			public TaskReader.XmlReadMode _ParamReader;

			// Token: 0x04000201 RID: 513
			private static object InstantiateListener;
		}

		// Token: 0x02000073 RID: 115
		internal class ListContainerRole
		{
			// Token: 0x06000367 RID: 871 RVA: 0x0000402C File Offset: 0x0000222C
			public ListContainerRole()
			{
				AdvisorConnectionAttribute.CancelComposer();
				this.exceptionReader = typeof(object);
				base..ctor();
			}

			// Token: 0x06000368 RID: 872 RVA: 0x00004049 File Offset: 0x00002249
			internal static bool SetListener()
			{
				return TaskReader.ListContainerRole.QueryListener == null;
			}

			// Token: 0x04000202 RID: 514
			public int m_ObserverReader;

			// Token: 0x04000203 RID: 515
			public TaskReader.XmlReadMode regReader;

			// Token: 0x04000204 RID: 516
			public bool errorReader;

			// Token: 0x04000205 RID: 517
			public Type exceptionReader;

			// Token: 0x04000206 RID: 518
			private static object QueryListener;
		}

		// Token: 0x02000074 RID: 116
		internal class GlobalReader
		{
			// Token: 0x06000369 RID: 873 RVA: 0x000024D4 File Offset: 0x000006D4
			public GlobalReader()
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
			}

			// Token: 0x0600036A RID: 874 RVA: 0x00004053 File Offset: 0x00002253
			internal static bool DefineListener()
			{
				return TaskReader.GlobalReader.CompareListener == null;
			}

			// Token: 0x04000207 RID: 519
			public int m_HelperReader;

			// Token: 0x04000208 RID: 520
			public int m_EventReader;

			// Token: 0x04000209 RID: 521
			public TaskReader.FacadeWatcherClass m_FactoryReader;

			// Token: 0x0400020A RID: 522
			internal static object CompareListener;
		}

		// Token: 0x02000075 RID: 117
		internal class FacadeWatcherClass
		{
			// Token: 0x0600036B RID: 875 RVA: 0x000024D4 File Offset: 0x000006D4
			public FacadeWatcherClass()
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
			}

			// Token: 0x0600036C RID: 876 RVA: 0x0000405D File Offset: 0x0000225D
			internal static bool NewListener()
			{
				return TaskReader.FacadeWatcherClass.CloneListener == null;
			}

			// Token: 0x0400020B RID: 523
			public int setterReader;

			// Token: 0x0400020C RID: 524
			public int methodReader;

			// Token: 0x0400020D RID: 525
			public byte _DecoratorReader;

			// Token: 0x0400020E RID: 526
			public Type _AccountReader;

			// Token: 0x0400020F RID: 527
			public int m_ClassReader;

			// Token: 0x04000210 RID: 528
			public int stateReader;

			// Token: 0x04000211 RID: 529
			private static object CloneListener;
		}

		// Token: 0x02000076 RID: 118
		internal class SetterRuleTask
		{
			// Token: 0x0600036D RID: 877 RVA: 0x000024D4 File Offset: 0x000006D4
			public SetterRuleTask()
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
			}

			// Token: 0x0600036E RID: 878 RVA: 0x00004067 File Offset: 0x00002267
			internal static bool AddListener()
			{
				return TaskReader.SetterRuleTask.StartListener == null;
			}

			// Token: 0x04000212 RID: 530
			internal object m_DescriptorReader;

			// Token: 0x04000213 RID: 531
			internal List<TaskReader.FieldWatcherClass> _PublisherReader;

			// Token: 0x04000214 RID: 532
			internal TaskReader.SystemConnectionAttribute[] _CallbackReader;

			// Token: 0x04000215 RID: 533
			internal List<TaskReader.ListContainerRole> printerReader;

			// Token: 0x04000216 RID: 534
			internal List<TaskReader.GlobalReader> m_ValReader;

			// Token: 0x04000217 RID: 535
			private static object StartListener;
		}

		// Token: 0x02000077 RID: 119
		private class WorkerAuthenticationReader : TaskReader.ModelAuthenticationReader
		{
			// Token: 0x0600036F RID: 879 RVA: 0x00004071 File Offset: 0x00002271
			internal void RevertRule(TaskReader.ExpressionReader v)
			{
				if (!v.PatchRule())
				{
					this.FindProperty(v);
					return;
				}
				this._TestsReader = ((TaskReader.WorkerAuthenticationReader)v)._TestsReader;
				this.dicReader = ((TaskReader.WorkerAuthenticationReader)v).dicReader;
			}

			// Token: 0x06000370 RID: 880 RVA: 0x00017D40 File Offset: 0x00015F40
			internal unsafe override void FindProperty(TaskReader.ExpressionReader task)
			{
				if (task.PatchRule())
				{
					if (IntPtr.Size == 8)
					{
						IntPtr value = new IntPtr(((TaskReader.AlgoReader)this._TestsReader)._IteratorReader._InterpreterReader);
						IntPtr intPtr = new IntPtr(((TaskReader.AlgoReader)((TaskReader.WorkerAuthenticationReader)task)._TestsReader)._IteratorReader._InterpreterReader);
						*(long*)((void*)value) = intPtr.ToInt64();
						return;
					}
					IntPtr value2 = new IntPtr(((TaskReader.ExporterPolicyPolicy)this._TestsReader).paramsReader.filterReader);
					IntPtr intPtr2 = new IntPtr(((TaskReader.ExporterPolicyPolicy)((TaskReader.WorkerAuthenticationReader)task)._TestsReader).paramsReader.filterReader);
					*(int*)((void*)value2) = intPtr2.ToInt32();
					return;
				}
				else
				{
					object obj = task.PatchProperty(null);
					if (obj == null)
					{
						return;
					}
					IntPtr value3;
					if (IntPtr.Size == 8)
					{
						value3 = new IntPtr(((TaskReader.AlgoReader)this._TestsReader)._IteratorReader._InterpreterReader);
					}
					else
					{
						value3 = new IntPtr(((TaskReader.ExporterPolicyPolicy)this._TestsReader).paramsReader.filterReader);
					}
					Type type = obj.GetType();
					if (type == typeof(string))
					{
						return;
					}
					if (type == typeof(byte))
					{
						*(byte*)((void*)value3) = (byte)obj;
						return;
					}
					if (type == typeof(sbyte))
					{
						*(byte*)((void*)value3) = (byte)((sbyte)obj);
						return;
					}
					if (type == typeof(short))
					{
						*(short*)((void*)value3) = (short)obj;
						return;
					}
					if (type == typeof(ushort))
					{
						*(short*)((void*)value3) = (short)((ushort)obj);
						return;
					}
					if (type == typeof(int))
					{
						*(int*)((void*)value3) = (int)obj;
						return;
					}
					if (type == typeof(uint))
					{
						*(int*)((void*)value3) = (int)((uint)obj);
						return;
					}
					if (type == typeof(long))
					{
						*(long*)((void*)value3) = (long)obj;
						return;
					}
					if (type == typeof(ulong))
					{
						*(long*)((void*)value3) = (long)((ulong)obj);
						return;
					}
					if (type == typeof(float))
					{
						*(float*)((void*)value3) = (float)obj;
						return;
					}
					if (type == typeof(double))
					{
						*(double*)((void*)value3) = (double)obj;
						return;
					}
					if (type == typeof(bool))
					{
						*(byte*)((void*)value3) = (((bool)obj) ? 1 : 0);
						return;
					}
					if (type == typeof(IntPtr))
					{
						*(IntPtr*)((void*)value3) = (IntPtr)obj;
						return;
					}
					if (type == typeof(UIntPtr))
					{
						*(UIntPtr*)((void*)value3) = (UIntPtr)obj;
						return;
					}
					if (!(type == typeof(char)))
					{
						throw new TaskReader.IndexerReader();
					}
					*(short*)((void*)value3) = (short)((char)obj);
					return;
				}
			}

			// Token: 0x06000371 RID: 881 RVA: 0x000037E9 File Offset: 0x000019E9
			internal override void UpdateProperty(TaskReader.ExpressionReader res)
			{
				this.FindProperty(res);
			}

			// Token: 0x06000372 RID: 882 RVA: 0x0001804C File Offset: 0x0001624C
			public WorkerAuthenticationReader(IntPtr init)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)3;
				if (IntPtr.Size == 8)
				{
					this._TestsReader = new TaskReader.AlgoReader(init.ToInt64());
					this.dicReader = (TaskReader.XmlReadMode)12;
					return;
				}
				this._TestsReader = new TaskReader.ExporterPolicyPolicy(init.ToInt32());
				this.dicReader = (TaskReader.XmlReadMode)12;
			}

			// Token: 0x06000373 RID: 883 RVA: 0x000180A8 File Offset: 0x000162A8
			public WorkerAuthenticationReader(UIntPtr init)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)3;
				if (IntPtr.Size == 8)
				{
					this._TestsReader = new TaskReader.AlgoReader(init.ToUInt64());
					this.dicReader = (TaskReader.XmlReadMode)12;
					return;
				}
				this._TestsReader = new TaskReader.ExporterPolicyPolicy(init.ToUInt32());
				this.dicReader = (TaskReader.XmlReadMode)12;
			}

			// Token: 0x06000374 RID: 884 RVA: 0x00018104 File Offset: 0x00016304
			public WorkerAuthenticationReader()
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)3;
				if (IntPtr.Size == 8)
				{
					this._TestsReader = new TaskReader.AlgoReader(0L);
					this.dicReader = (TaskReader.XmlReadMode)12;
					return;
				}
				this._TestsReader = new TaskReader.ExporterPolicyPolicy(0);
				this.dicReader = (TaskReader.XmlReadMode)12;
			}

			// Token: 0x06000375 RID: 885 RVA: 0x0001815C File Offset: 0x0001635C
			public override TaskReader.ModelAuthenticationReader NewWatcher()
			{
				return new TaskReader.WorkerAuthenticationReader
				{
					_TestsReader = this._TestsReader.NewWatcher(),
					dicReader = this.dicReader
				};
			}

			// Token: 0x06000376 RID: 886 RVA: 0x00018190 File Offset: 0x00016390
			public WorkerAuthenticationReader(long assetPtr)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)3;
				if (IntPtr.Size == 8)
				{
					this._TestsReader = new TaskReader.AlgoReader(assetPtr);
					this.dicReader = (TaskReader.XmlReadMode)12;
					return;
				}
				this._TestsReader = new TaskReader.ExporterPolicyPolicy((int)assetPtr);
				this.dicReader = (TaskReader.XmlReadMode)12;
			}

			// Token: 0x06000377 RID: 887 RVA: 0x000181E4 File Offset: 0x000163E4
			public WorkerAuthenticationReader(long sumreference, TaskReader.XmlReadMode pred)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)3;
				if (IntPtr.Size == 8)
				{
					this._TestsReader = new TaskReader.AlgoReader(sumreference);
					this.dicReader = pred;
					return;
				}
				this._TestsReader = new TaskReader.ExporterPolicyPolicy((int)sumreference);
				this.dicReader = pred;
			}

			// Token: 0x06000378 RID: 888 RVA: 0x00018234 File Offset: 0x00016434
			public WorkerAuthenticationReader(ulong indexOf_reference)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)4;
				if (IntPtr.Size == 8)
				{
					this._TestsReader = new TaskReader.AlgoReader(indexOf_reference);
					this.dicReader = (TaskReader.XmlReadMode)13;
					return;
				}
				this._TestsReader = new TaskReader.ExporterPolicyPolicy((uint)indexOf_reference);
				this.dicReader = (TaskReader.XmlReadMode)13;
			}

			// Token: 0x06000379 RID: 889 RVA: 0x00018288 File Offset: 0x00016488
			public WorkerAuthenticationReader(ulong length_setup, TaskReader.XmlReadMode vis)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)4;
				if (IntPtr.Size == 8)
				{
					this._TestsReader = new TaskReader.AlgoReader(length_setup);
					this.dicReader = vis;
					return;
				}
				this._TestsReader = new TaskReader.ExporterPolicyPolicy((uint)length_setup);
				this.dicReader = vis;
			}

			// Token: 0x0600037A RID: 890 RVA: 0x000040A5 File Offset: 0x000022A5
			public override bool ConcatProperty()
			{
				return this._TestsReader.ConcatProperty();
			}

			// Token: 0x0600037B RID: 891 RVA: 0x00003A14 File Offset: 0x00001C14
			public override bool MapProperty()
			{
				return !this.ConcatProperty();
			}

			// Token: 0x0600037C RID: 892 RVA: 0x00003A32 File Offset: 0x00001C32
			internal override bool ViewProperty()
			{
				return this.MapProperty();
			}

			// Token: 0x0600037D RID: 893 RVA: 0x000038BF File Offset: 0x00001ABF
			internal override bool LogoutProperty()
			{
				return true;
			}

			// Token: 0x0600037E RID: 894 RVA: 0x000182D8 File Offset: 0x000164D8
			public override TaskReader.ExpressionReader ReadProperty(TaskReader.XmlReadMode item)
			{
				switch (item)
				{
				case (TaskReader.XmlReadMode)1:
					return this.RevertProperty();
				case (TaskReader.XmlReadMode)2:
					return this.QueryWatcher();
				case (TaskReader.XmlReadMode)3:
					return this.AddWatcher();
				case (TaskReader.XmlReadMode)4:
					return this.ExcludeWatcher();
				case (TaskReader.XmlReadMode)5:
					return this.InstantiateWatcher();
				case (TaskReader.XmlReadMode)6:
					return this.InterruptWatcher();
				case (TaskReader.XmlReadMode)7:
					return this.PushWatcher();
				case (TaskReader.XmlReadMode)8:
					return this.StartWatcher();
				case (TaskReader.XmlReadMode)11:
					return this.ForgotProperty();
				case (TaskReader.XmlReadMode)12:
					return this;
				case (TaskReader.XmlReadMode)13:
					return this;
				case (TaskReader.XmlReadMode)16:
					return this.NewWatcher();
				}
				throw new Exception("truncation not supported");
			}

			// Token: 0x0600037F RID: 895 RVA: 0x000040B2 File Offset: 0x000022B2
			internal IntPtr QueryAnnotation()
			{
				if (IntPtr.Size == 8)
				{
					return new IntPtr(((TaskReader.AlgoReader)this._TestsReader)._IteratorReader._InterpreterReader);
				}
				return new IntPtr(((TaskReader.ExporterPolicyPolicy)this._TestsReader).paramsReader.filterReader);
			}

			// Token: 0x06000380 RID: 896 RVA: 0x00018388 File Offset: 0x00016588
			internal override object PatchProperty(Type task)
			{
				if (task != null && task.IsByRef)
				{
					task = task.GetElementType();
				}
				if (!(task == typeof(IntPtr)))
				{
					if (task == typeof(UIntPtr))
					{
						if (IntPtr.Size == 8)
						{
							return new UIntPtr(((TaskReader.AlgoReader)this._TestsReader)._IteratorReader.roleReader);
						}
						return new UIntPtr(((TaskReader.ExporterPolicyPolicy)this._TestsReader).paramsReader.m_StubReader);
					}
					else
					{
						if (!(task == null) && !(task == typeof(object)))
						{
							throw new TaskReader.IndexerReader();
						}
						if (IntPtr.Size == 8)
						{
							if (this.dicReader == (TaskReader.XmlReadMode)12)
							{
								return new IntPtr(((TaskReader.AlgoReader)this._TestsReader)._IteratorReader._InterpreterReader);
							}
							return new UIntPtr(((TaskReader.AlgoReader)this._TestsReader)._IteratorReader.roleReader);
						}
						else
						{
							if (this.dicReader == (TaskReader.XmlReadMode)12)
							{
								return new IntPtr(((TaskReader.AlgoReader)this._TestsReader)._IteratorReader.tokenizerReader);
							}
							return new UIntPtr(((TaskReader.ExporterPolicyPolicy)this._TestsReader).paramsReader.m_StubReader);
						}
					}
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new IntPtr(((TaskReader.AlgoReader)this._TestsReader)._IteratorReader._InterpreterReader);
					}
					return new IntPtr(((TaskReader.ExporterPolicyPolicy)this._TestsReader).paramsReader.filterReader);
				}
			}

			// Token: 0x06000381 RID: 897 RVA: 0x000040F1 File Offset: 0x000022F1
			public override TaskReader.ExporterPolicyPolicy ForgotProperty()
			{
				return this._TestsReader.ForgotProperty();
			}

			// Token: 0x06000382 RID: 898 RVA: 0x000040FE File Offset: 0x000022FE
			public override TaskReader.ExporterPolicyPolicy RevertProperty()
			{
				return this._TestsReader.RevertProperty();
			}

			// Token: 0x06000383 RID: 899 RVA: 0x0000410B File Offset: 0x0000230B
			public override TaskReader.ExporterPolicyPolicy QueryWatcher()
			{
				return this._TestsReader.QueryWatcher();
			}

			// Token: 0x06000384 RID: 900 RVA: 0x00004118 File Offset: 0x00002318
			public override TaskReader.ExporterPolicyPolicy AddWatcher()
			{
				return this._TestsReader.AddWatcher();
			}

			// Token: 0x06000385 RID: 901 RVA: 0x00004125 File Offset: 0x00002325
			public override TaskReader.ExporterPolicyPolicy ExcludeWatcher()
			{
				return this._TestsReader.ExcludeWatcher();
			}

			// Token: 0x06000386 RID: 902 RVA: 0x00004132 File Offset: 0x00002332
			public override TaskReader.ExporterPolicyPolicy InstantiateWatcher()
			{
				return this._TestsReader.InstantiateWatcher();
			}

			// Token: 0x06000387 RID: 903 RVA: 0x0000413F File Offset: 0x0000233F
			public override TaskReader.ExporterPolicyPolicy InterruptWatcher()
			{
				return this._TestsReader.InterruptWatcher();
			}

			// Token: 0x06000388 RID: 904 RVA: 0x0000414C File Offset: 0x0000234C
			public override TaskReader.AlgoReader PushWatcher()
			{
				return this._TestsReader.PushWatcher();
			}

			// Token: 0x06000389 RID: 905 RVA: 0x00004159 File Offset: 0x00002359
			public override TaskReader.AlgoReader StartWatcher()
			{
				return this._TestsReader.StartWatcher();
			}

			// Token: 0x0600038A RID: 906 RVA: 0x00003AE6 File Offset: 0x00001CE6
			public override TaskReader.ExporterPolicyPolicy PublishWatcher()
			{
				return this.RevertProperty();
			}

			// Token: 0x0600038B RID: 907 RVA: 0x00003AEE File Offset: 0x00001CEE
			public override TaskReader.ExporterPolicyPolicy ResetWatcher()
			{
				return this.AddWatcher();
			}

			// Token: 0x0600038C RID: 908 RVA: 0x00003AF6 File Offset: 0x00001CF6
			public override TaskReader.ExporterPolicyPolicy SelectWatcher()
			{
				return this.InstantiateWatcher();
			}

			// Token: 0x0600038D RID: 909 RVA: 0x00003AFE File Offset: 0x00001CFE
			public override TaskReader.AlgoReader InitWatcher()
			{
				return this.PushWatcher();
			}

			// Token: 0x0600038E RID: 910 RVA: 0x00003B06 File Offset: 0x00001D06
			public override TaskReader.ExporterPolicyPolicy PrintWatcher()
			{
				return this.QueryWatcher();
			}

			// Token: 0x0600038F RID: 911 RVA: 0x00003B0E File Offset: 0x00001D0E
			public override TaskReader.ExporterPolicyPolicy CountWatcher()
			{
				return this.ExcludeWatcher();
			}

			// Token: 0x06000390 RID: 912 RVA: 0x00003B16 File Offset: 0x00001D16
			public override TaskReader.ExporterPolicyPolicy StopWatcher()
			{
				return this.InterruptWatcher();
			}

			// Token: 0x06000391 RID: 913 RVA: 0x00003B1E File Offset: 0x00001D1E
			public override TaskReader.AlgoReader MoveWatcher()
			{
				return this.StartWatcher();
			}

			// Token: 0x06000392 RID: 914 RVA: 0x00004166 File Offset: 0x00002366
			public override TaskReader.ExporterPolicyPolicy SearchWatcher()
			{
				return this._TestsReader.SearchWatcher();
			}

			// Token: 0x06000393 RID: 915 RVA: 0x00004173 File Offset: 0x00002373
			public override TaskReader.ExporterPolicyPolicy ConnectWatcher()
			{
				return this._TestsReader.ConnectWatcher();
			}

			// Token: 0x06000394 RID: 916 RVA: 0x00004180 File Offset: 0x00002380
			public override TaskReader.ExporterPolicyPolicy SetupWatcher()
			{
				return this._TestsReader.SetupWatcher();
			}

			// Token: 0x06000395 RID: 917 RVA: 0x0000418D File Offset: 0x0000238D
			public override TaskReader.ExporterPolicyPolicy GetWatcher()
			{
				return this._TestsReader.GetWatcher();
			}

			// Token: 0x06000396 RID: 918 RVA: 0x0000419A File Offset: 0x0000239A
			public override TaskReader.ExporterPolicyPolicy PostWatcher()
			{
				return this._TestsReader.PostWatcher();
			}

			// Token: 0x06000397 RID: 919 RVA: 0x000041A7 File Offset: 0x000023A7
			public override TaskReader.ExporterPolicyPolicy OrderWatcher()
			{
				return this._TestsReader.OrderWatcher();
			}

			// Token: 0x06000398 RID: 920 RVA: 0x000041B4 File Offset: 0x000023B4
			public override TaskReader.AlgoReader AssetWatcher()
			{
				return this._TestsReader.AssetWatcher();
			}

			// Token: 0x06000399 RID: 921 RVA: 0x000041C1 File Offset: 0x000023C1
			public override TaskReader.AlgoReader DefineWatcher()
			{
				return this._TestsReader.DefineWatcher();
			}

			// Token: 0x0600039A RID: 922 RVA: 0x000041CE File Offset: 0x000023CE
			public override TaskReader.ExporterPolicyPolicy CollectWatcher()
			{
				return this._TestsReader.CollectWatcher();
			}

			// Token: 0x0600039B RID: 923 RVA: 0x000041DB File Offset: 0x000023DB
			public override TaskReader.ExporterPolicyPolicy ListWatcher()
			{
				return this._TestsReader.ListWatcher();
			}

			// Token: 0x0600039C RID: 924 RVA: 0x000041E8 File Offset: 0x000023E8
			public override TaskReader.ExporterPolicyPolicy RestartWatcher()
			{
				return this._TestsReader.RestartWatcher();
			}

			// Token: 0x0600039D RID: 925 RVA: 0x000041F5 File Offset: 0x000023F5
			public override TaskReader.ExporterPolicyPolicy ReflectWatcher()
			{
				return this._TestsReader.ReflectWatcher();
			}

			// Token: 0x0600039E RID: 926 RVA: 0x00004202 File Offset: 0x00002402
			public override TaskReader.ExporterPolicyPolicy InsertWatcher()
			{
				return this._TestsReader.InsertWatcher();
			}

			// Token: 0x0600039F RID: 927 RVA: 0x0000420F File Offset: 0x0000240F
			public override TaskReader.ExporterPolicyPolicy RemoveWatcher()
			{
				return this._TestsReader.RemoveWatcher();
			}

			// Token: 0x060003A0 RID: 928 RVA: 0x0000421C File Offset: 0x0000241C
			public override TaskReader.AlgoReader RegisterWatcher()
			{
				return this._TestsReader.RegisterWatcher();
			}

			// Token: 0x060003A1 RID: 929 RVA: 0x00004229 File Offset: 0x00002429
			public override TaskReader.AlgoReader WriteWatcher()
			{
				return this._TestsReader.WriteWatcher();
			}

			// Token: 0x060003A2 RID: 930 RVA: 0x00004236 File Offset: 0x00002436
			public override TaskReader.IssuerInvocationRecord ManageWatcher()
			{
				return this._TestsReader.ManageWatcher();
			}

			// Token: 0x060003A3 RID: 931 RVA: 0x00004243 File Offset: 0x00002443
			public override TaskReader.IssuerInvocationRecord CompareWatcher()
			{
				return this._TestsReader.CompareWatcher();
			}

			// Token: 0x060003A4 RID: 932 RVA: 0x00004250 File Offset: 0x00002450
			public override TaskReader.IssuerInvocationRecord ComputeWatcher()
			{
				return this._TestsReader.ComputeWatcher();
			}

			// Token: 0x060003A5 RID: 933 RVA: 0x00003C78 File Offset: 0x00001E78
			public override TaskReader.WorkerAuthenticationReader SortWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.InitWatcher()._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)this.SelectWatcher().paramsReader.filterReader);
			}

			// Token: 0x060003A6 RID: 934 RVA: 0x00003CAE File Offset: 0x00001EAE
			public override TaskReader.WorkerAuthenticationReader ChangeWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.MoveWatcher()._IteratorReader.roleReader);
				}
				return new TaskReader.WorkerAuthenticationReader((ulong)this.StopWatcher().paramsReader.m_StubReader);
			}

			// Token: 0x060003A7 RID: 935 RVA: 0x00003CE4 File Offset: 0x00001EE4
			public override TaskReader.WorkerAuthenticationReader LoginWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.AssetWatcher()._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)this.PostWatcher().paramsReader.filterReader);
			}

			// Token: 0x060003A8 RID: 936 RVA: 0x00003D1A File Offset: 0x00001F1A
			public override TaskReader.WorkerAuthenticationReader SetWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.RegisterWatcher()._IteratorReader.roleReader);
				}
				return new TaskReader.WorkerAuthenticationReader((ulong)this.InsertWatcher().paramsReader.m_StubReader);
			}

			// Token: 0x060003A9 RID: 937 RVA: 0x00003D50 File Offset: 0x00001F50
			public override TaskReader.WorkerAuthenticationReader AwakeWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.DefineWatcher()._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)this.OrderWatcher().paramsReader.filterReader);
			}

			// Token: 0x060003AA RID: 938 RVA: 0x0000425D File Offset: 0x0000245D
			public override TaskReader.WorkerAuthenticationReader CustomizeWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.WriteWatcher()._IteratorReader.roleReader);
				}
				return new TaskReader.WorkerAuthenticationReader((ulong)this.RemoveWatcher().paramsReader.m_StubReader);
			}

			// Token: 0x060003AB RID: 939 RVA: 0x00018524 File Offset: 0x00016724
			public override TaskReader.ExpressionReader InvokeWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(-((TaskReader.AlgoReader)this._TestsReader)._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)(-(long)((TaskReader.ExporterPolicyPolicy)this._TestsReader).paramsReader.filterReader));
			}

			// Token: 0x060003AC RID: 940 RVA: 0x00018574 File Offset: 0x00016774
			public override TaskReader.ExpressionReader CreateWatcher(TaskReader.ExpressionReader init)
			{
				if (init.VisitProperty())
				{
					init = init.IncludeProperty();
				}
				if (!init.CalculateRule())
				{
					if (!init.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader + ((TaskReader.WorkerAuthenticationReader)init).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader + ((TaskReader.WorkerAuthenticationReader)init).InstantiateWatcher().paramsReader.filterReader));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader + ((TaskReader.ExporterPolicyPolicy)init).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader + ((TaskReader.ExporterPolicyPolicy)init).paramsReader.filterReader));
				}
			}

			// Token: 0x060003AD RID: 941 RVA: 0x00018664 File Offset: 0x00016864
			public override TaskReader.ExpressionReader FlushWatcher(TaskReader.ExpressionReader i)
			{
				if (i.VisitProperty())
				{
					i = i.IncludeProperty();
				}
				if (!i.CalculateRule())
				{
					if (!i.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(this.PushWatcher()._IteratorReader._InterpreterReader + ((TaskReader.WorkerAuthenticationReader)i).PushWatcher()._IteratorReader._InterpreterReader));
					}
					return new TaskReader.WorkerAuthenticationReader((long)(checked(this.InstantiateWatcher().paramsReader.filterReader + ((TaskReader.WorkerAuthenticationReader)i).InstantiateWatcher().paramsReader.filterReader)));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(this.PushWatcher()._IteratorReader._InterpreterReader + ((TaskReader.ExporterPolicyPolicy)i).PushWatcher()._IteratorReader._InterpreterReader));
					}
					return new TaskReader.WorkerAuthenticationReader((long)(checked(this.InstantiateWatcher().paramsReader.filterReader + ((TaskReader.ExporterPolicyPolicy)i).paramsReader.filterReader)));
				}
			}

			// Token: 0x060003AE RID: 942 RVA: 0x00018754 File Offset: 0x00016954
			public override TaskReader.ExpressionReader CalcWatcher(TaskReader.ExpressionReader ident)
			{
				if (ident.VisitProperty())
				{
					ident = ident.IncludeProperty();
				}
				if (ident.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(this.PushWatcher()._IteratorReader.roleReader + unchecked((ulong)((TaskReader.ExporterPolicyPolicy)ident).paramsReader.m_StubReader)));
					}
					return new TaskReader.WorkerAuthenticationReader((long)((ulong)(checked(this.InstantiateWatcher().paramsReader.m_StubReader + ((TaskReader.ExporterPolicyPolicy)ident).paramsReader.m_StubReader))));
				}
				else
				{
					if (!ident.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(this.PushWatcher()._IteratorReader.roleReader + ((TaskReader.WorkerAuthenticationReader)ident).PushWatcher()._IteratorReader.roleReader));
					}
					return new TaskReader.WorkerAuthenticationReader((ulong)(checked(this.InstantiateWatcher().paramsReader.m_StubReader + ((TaskReader.WorkerAuthenticationReader)ident).InstantiateWatcher().paramsReader.m_StubReader)));
				}
			}

			// Token: 0x060003AF RID: 943 RVA: 0x00018840 File Offset: 0x00016A40
			public override TaskReader.ExpressionReader PrepareWatcher(TaskReader.ExpressionReader last)
			{
				if (last.VisitProperty())
				{
					last = last.IncludeProperty();
				}
				if (!last.CalculateRule())
				{
					if (!last.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader - ((TaskReader.WorkerAuthenticationReader)last).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader - ((TaskReader.WorkerAuthenticationReader)last).InstantiateWatcher().paramsReader.filterReader));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader - ((TaskReader.ExporterPolicyPolicy)last).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader - ((TaskReader.ExporterPolicyPolicy)last).paramsReader.filterReader));
				}
			}

			// Token: 0x060003B0 RID: 944 RVA: 0x00018930 File Offset: 0x00016B30
			public TaskReader.ExpressionReader AddAnnotation(TaskReader.ExpressionReader spec)
			{
				if (spec.VisitProperty())
				{
					spec = spec.IncludeProperty();
				}
				if (!spec.CalculateRule())
				{
					if (!spec.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(((TaskReader.WorkerAuthenticationReader)spec).PushWatcher()._IteratorReader._InterpreterReader - this.PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(((TaskReader.WorkerAuthenticationReader)spec).InstantiateWatcher().paramsReader.filterReader - this.InstantiateWatcher().paramsReader.filterReader));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(((TaskReader.ExporterPolicyPolicy)spec).PushWatcher()._IteratorReader._InterpreterReader - this.PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(((TaskReader.ExporterPolicyPolicy)spec).paramsReader.filterReader - this.InstantiateWatcher().paramsReader.filterReader));
				}
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x00018A20 File Offset: 0x00016C20
			public override TaskReader.ExpressionReader DeleteWatcher(TaskReader.ExpressionReader config)
			{
				if (config.VisitProperty())
				{
					config = config.IncludeProperty();
				}
				if (!config.CalculateRule())
				{
					if (!config.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(this.PushWatcher()._IteratorReader._InterpreterReader - ((TaskReader.WorkerAuthenticationReader)config).PushWatcher()._IteratorReader._InterpreterReader));
					}
					return new TaskReader.WorkerAuthenticationReader((long)(checked(this.InstantiateWatcher().paramsReader.filterReader - ((TaskReader.WorkerAuthenticationReader)config).InstantiateWatcher().paramsReader.filterReader)));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(this.PushWatcher()._IteratorReader._InterpreterReader - ((TaskReader.ExporterPolicyPolicy)config).PushWatcher()._IteratorReader._InterpreterReader));
					}
					return new TaskReader.WorkerAuthenticationReader((long)(checked(this.InstantiateWatcher().paramsReader.filterReader - ((TaskReader.ExporterPolicyPolicy)config).paramsReader.filterReader)));
				}
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x00018B10 File Offset: 0x00016D10
			public TaskReader.ExpressionReader ExcludeAnnotation(TaskReader.ExpressionReader var1)
			{
				if (var1.VisitProperty())
				{
					var1 = var1.IncludeProperty();
				}
				if (var1.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(((TaskReader.ExporterPolicyPolicy)var1).PushWatcher()._IteratorReader._InterpreterReader - this.PushWatcher()._IteratorReader._InterpreterReader));
					}
					return new TaskReader.WorkerAuthenticationReader((long)(checked(((TaskReader.ExporterPolicyPolicy)var1).paramsReader.filterReader - this.InstantiateWatcher().paramsReader.filterReader)));
				}
				else
				{
					if (!var1.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(((TaskReader.WorkerAuthenticationReader)var1).PushWatcher()._IteratorReader._InterpreterReader - this.PushWatcher()._IteratorReader._InterpreterReader));
					}
					return new TaskReader.WorkerAuthenticationReader((long)(checked(((TaskReader.WorkerAuthenticationReader)var1).InstantiateWatcher().paramsReader.filterReader - this.InstantiateWatcher().paramsReader.filterReader)));
				}
			}

			// Token: 0x060003B3 RID: 947 RVA: 0x00018C00 File Offset: 0x00016E00
			public override TaskReader.ExpressionReader CallWatcher(TaskReader.ExpressionReader def)
			{
				if (def.VisitProperty())
				{
					def = def.IncludeProperty();
				}
				if (!def.CalculateRule())
				{
					if (!def.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(this.PushWatcher()._IteratorReader.roleReader - ((TaskReader.WorkerAuthenticationReader)def).PushWatcher()._IteratorReader.roleReader));
					}
					return new TaskReader.WorkerAuthenticationReader((ulong)(checked(this.InstantiateWatcher().paramsReader.m_StubReader - ((TaskReader.WorkerAuthenticationReader)def).InstantiateWatcher().paramsReader.m_StubReader)));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(this.PushWatcher()._IteratorReader.roleReader - unchecked((ulong)((TaskReader.ExporterPolicyPolicy)def).paramsReader.m_StubReader)));
					}
					return new TaskReader.WorkerAuthenticationReader((long)((ulong)(checked(this.InstantiateWatcher().paramsReader.m_StubReader - ((TaskReader.ExporterPolicyPolicy)def).paramsReader.m_StubReader))));
				}
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x00018CEC File Offset: 0x00016EEC
			public TaskReader.ExpressionReader InstantiateAnnotation(TaskReader.ExpressionReader value)
			{
				if (value.VisitProperty())
				{
					value = value.IncludeProperty();
				}
				if (!value.CalculateRule())
				{
					if (!value.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(((TaskReader.WorkerAuthenticationReader)value).PushWatcher()._IteratorReader.roleReader - this.PushWatcher()._IteratorReader.roleReader));
					}
					return new TaskReader.WorkerAuthenticationReader((ulong)(checked(((TaskReader.WorkerAuthenticationReader)value).InstantiateWatcher().paramsReader.m_StubReader - this.InstantiateWatcher().paramsReader.m_StubReader)));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(unchecked((ulong)((TaskReader.ExporterPolicyPolicy)value).paramsReader.m_StubReader) - this.PushWatcher()._IteratorReader.roleReader));
					}
					return new TaskReader.WorkerAuthenticationReader((long)((ulong)(checked(((TaskReader.ExporterPolicyPolicy)value).paramsReader.m_StubReader - this.InstantiateWatcher().paramsReader.m_StubReader))));
				}
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x00018DD8 File Offset: 0x00016FD8
			public override TaskReader.ExpressionReader RateWatcher(TaskReader.ExpressionReader info)
			{
				if (info.VisitProperty())
				{
					info = info.IncludeProperty();
				}
				if (!info.CalculateRule())
				{
					if (!info.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader * ((TaskReader.WorkerAuthenticationReader)info).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader * ((TaskReader.WorkerAuthenticationReader)info).InstantiateWatcher().paramsReader.filterReader));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader * ((TaskReader.ExporterPolicyPolicy)info).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader * ((TaskReader.ExporterPolicyPolicy)info).paramsReader.filterReader));
				}
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x00018EC8 File Offset: 0x000170C8
			public override TaskReader.ExpressionReader ValidateWatcher(TaskReader.ExpressionReader item)
			{
				if (item.VisitProperty())
				{
					item = item.IncludeProperty();
				}
				if (!item.CalculateRule())
				{
					if (!item.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(this.PushWatcher()._IteratorReader._InterpreterReader * ((TaskReader.WorkerAuthenticationReader)item).PushWatcher()._IteratorReader._InterpreterReader));
					}
					return new TaskReader.WorkerAuthenticationReader((long)(checked(this.InstantiateWatcher().paramsReader.filterReader * ((TaskReader.WorkerAuthenticationReader)item).InstantiateWatcher().paramsReader.filterReader)));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(this.PushWatcher()._IteratorReader._InterpreterReader * ((TaskReader.ExporterPolicyPolicy)item).PushWatcher()._IteratorReader._InterpreterReader));
					}
					return new TaskReader.WorkerAuthenticationReader((long)(checked(this.InstantiateWatcher().paramsReader.filterReader * ((TaskReader.ExporterPolicyPolicy)item).paramsReader.filterReader)));
				}
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x00018FB8 File Offset: 0x000171B8
			public override TaskReader.ExpressionReader VerifyWatcher(TaskReader.ExpressionReader spec)
			{
				if (spec.VisitProperty())
				{
					spec = spec.IncludeProperty();
				}
				if (spec.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(this.PushWatcher()._IteratorReader.roleReader * unchecked((ulong)((TaskReader.ExporterPolicyPolicy)spec).paramsReader.m_StubReader)));
					}
					return new TaskReader.WorkerAuthenticationReader((long)((ulong)(checked(this.InstantiateWatcher().paramsReader.m_StubReader * ((TaskReader.ExporterPolicyPolicy)spec).paramsReader.m_StubReader))));
				}
				else
				{
					if (!spec.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(checked(this.PushWatcher()._IteratorReader.roleReader * ((TaskReader.WorkerAuthenticationReader)spec).PushWatcher()._IteratorReader.roleReader));
					}
					return new TaskReader.WorkerAuthenticationReader((ulong)(checked(this.InstantiateWatcher().paramsReader.m_StubReader * ((TaskReader.WorkerAuthenticationReader)spec).InstantiateWatcher().paramsReader.m_StubReader)));
				}
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x000190A4 File Offset: 0x000172A4
			public override TaskReader.ExpressionReader PopWatcher(TaskReader.ExpressionReader i)
			{
				if (i.VisitProperty())
				{
					i = i.IncludeProperty();
				}
				if (!i.CalculateRule())
				{
					if (!i.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader / ((TaskReader.WorkerAuthenticationReader)i).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader / ((TaskReader.WorkerAuthenticationReader)i).InstantiateWatcher().paramsReader.filterReader));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader / ((TaskReader.ExporterPolicyPolicy)i).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader / ((TaskReader.ExporterPolicyPolicy)i).paramsReader.filterReader));
				}
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x00019194 File Offset: 0x00017394
			public TaskReader.ExpressionReader InterruptAnnotation(TaskReader.ExpressionReader ident)
			{
				if (ident.VisitProperty())
				{
					ident = ident.IncludeProperty();
				}
				if (ident.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(((TaskReader.ExporterPolicyPolicy)ident).PushWatcher()._IteratorReader._InterpreterReader / this.PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(((TaskReader.ExporterPolicyPolicy)ident).paramsReader.filterReader / this.InstantiateWatcher().paramsReader.filterReader));
				}
				else
				{
					if (!ident.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(((TaskReader.WorkerAuthenticationReader)ident).PushWatcher()._IteratorReader._InterpreterReader / this.PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(((TaskReader.WorkerAuthenticationReader)ident).InstantiateWatcher().paramsReader.filterReader / this.InstantiateWatcher().paramsReader.filterReader));
				}
			}

			// Token: 0x060003BA RID: 954 RVA: 0x00019284 File Offset: 0x00017484
			public override TaskReader.ExpressionReader FillWatcher(TaskReader.ExpressionReader config)
			{
				if (config.VisitProperty())
				{
					config = config.IncludeProperty();
				}
				if (config.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader.roleReader / ((TaskReader.ExporterPolicyPolicy)config).PushWatcher()._IteratorReader.roleReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)((ulong)(this.InstantiateWatcher().paramsReader.m_StubReader / ((TaskReader.ExporterPolicyPolicy)config).paramsReader.m_StubReader)));
				}
				else
				{
					if (!config.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader.roleReader / ((TaskReader.WorkerAuthenticationReader)config).PushWatcher()._IteratorReader.roleReader);
					}
					return new TaskReader.WorkerAuthenticationReader((ulong)(this.InstantiateWatcher().paramsReader.m_StubReader / ((TaskReader.WorkerAuthenticationReader)config).InstantiateWatcher().paramsReader.m_StubReader));
				}
			}

			// Token: 0x060003BB RID: 955 RVA: 0x00019374 File Offset: 0x00017574
			public TaskReader.ExpressionReader PushAnnotation(TaskReader.ExpressionReader asset)
			{
				if (asset.VisitProperty())
				{
					asset = asset.IncludeProperty();
				}
				if (!asset.CalculateRule())
				{
					if (!asset.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(((TaskReader.WorkerAuthenticationReader)asset).PushWatcher()._IteratorReader.roleReader / this.PushWatcher()._IteratorReader.roleReader);
					}
					return new TaskReader.WorkerAuthenticationReader((ulong)(((TaskReader.WorkerAuthenticationReader)asset).InstantiateWatcher().paramsReader.m_StubReader / this.InstantiateWatcher().paramsReader.m_StubReader));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(((TaskReader.ExporterPolicyPolicy)asset).PushWatcher()._IteratorReader.roleReader / this.PushWatcher()._IteratorReader.roleReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)((ulong)(((TaskReader.ExporterPolicyPolicy)asset).paramsReader.m_StubReader / this.InstantiateWatcher().paramsReader.m_StubReader)));
				}
			}

			// Token: 0x060003BC RID: 956 RVA: 0x00019464 File Offset: 0x00017664
			public override TaskReader.ExpressionReader DisableWatcher(TaskReader.ExpressionReader instance)
			{
				if (instance.VisitProperty())
				{
					instance = instance.IncludeProperty();
				}
				if (!instance.CalculateRule())
				{
					if (!instance.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader % ((TaskReader.WorkerAuthenticationReader)instance).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader % ((TaskReader.WorkerAuthenticationReader)instance).InstantiateWatcher().paramsReader.filterReader));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader % ((TaskReader.ExporterPolicyPolicy)instance).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader % ((TaskReader.ExporterPolicyPolicy)instance).paramsReader.filterReader));
				}
			}

			// Token: 0x060003BD RID: 957 RVA: 0x00019554 File Offset: 0x00017754
			public TaskReader.ExpressionReader StartAnnotation(TaskReader.ExpressionReader value)
			{
				if (value.VisitProperty())
				{
					value = value.IncludeProperty();
				}
				if (value.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(((TaskReader.ExporterPolicyPolicy)value).PushWatcher()._IteratorReader._InterpreterReader % this.PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(((TaskReader.ExporterPolicyPolicy)value).paramsReader.filterReader % this.InstantiateWatcher().paramsReader.filterReader));
				}
				else
				{
					if (!value.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(((TaskReader.WorkerAuthenticationReader)value).PushWatcher()._IteratorReader._InterpreterReader % this.PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(((TaskReader.WorkerAuthenticationReader)value).InstantiateWatcher().paramsReader.filterReader % this.InstantiateWatcher().paramsReader.filterReader));
				}
			}

			// Token: 0x060003BE RID: 958 RVA: 0x00019644 File Offset: 0x00017844
			public override TaskReader.ExpressionReader EnableWatcher(TaskReader.ExpressionReader var1)
			{
				if (var1.VisitProperty())
				{
					var1 = var1.IncludeProperty();
				}
				if (!var1.CalculateRule())
				{
					if (!var1.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader.roleReader % ((TaskReader.WorkerAuthenticationReader)var1).PushWatcher()._IteratorReader.roleReader);
					}
					return new TaskReader.WorkerAuthenticationReader((ulong)(this.InstantiateWatcher().paramsReader.m_StubReader % ((TaskReader.WorkerAuthenticationReader)var1).InstantiateWatcher().paramsReader.m_StubReader));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader.roleReader % ((TaskReader.ExporterPolicyPolicy)var1).PushWatcher()._IteratorReader.roleReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)((ulong)(this.InstantiateWatcher().paramsReader.m_StubReader % ((TaskReader.ExporterPolicyPolicy)var1).paramsReader.m_StubReader)));
				}
			}

			// Token: 0x060003BF RID: 959 RVA: 0x00019734 File Offset: 0x00017934
			public TaskReader.ExpressionReader PublishAnnotation(TaskReader.ExpressionReader item)
			{
				if (item.VisitProperty())
				{
					item = item.IncludeProperty();
				}
				if (!item.CalculateRule())
				{
					if (!item.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(((TaskReader.WorkerAuthenticationReader)item).PushWatcher()._IteratorReader.roleReader % this.PushWatcher()._IteratorReader.roleReader);
					}
					return new TaskReader.WorkerAuthenticationReader((ulong)(((TaskReader.WorkerAuthenticationReader)item).InstantiateWatcher().paramsReader.m_StubReader % this.InstantiateWatcher().paramsReader.m_StubReader));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(((TaskReader.ExporterPolicyPolicy)item).PushWatcher()._IteratorReader.roleReader % this.PushWatcher()._IteratorReader.roleReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)((ulong)(((TaskReader.ExporterPolicyPolicy)item).paramsReader.m_StubReader % this.InstantiateWatcher().paramsReader.m_StubReader)));
				}
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x00019824 File Offset: 0x00017A24
			public override TaskReader.ExpressionReader CheckWatcher(TaskReader.ExpressionReader def)
			{
				if (def.VisitProperty())
				{
					def = def.IncludeProperty();
				}
				if (def.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader & ((TaskReader.ExporterPolicyPolicy)def).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader & ((TaskReader.ExporterPolicyPolicy)def).paramsReader.filterReader));
				}
				else
				{
					if (!def.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader & ((TaskReader.WorkerAuthenticationReader)def).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader & ((TaskReader.WorkerAuthenticationReader)def).InstantiateWatcher().paramsReader.filterReader));
				}
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x00019914 File Offset: 0x00017B14
			public override TaskReader.ExpressionReader TestWatcher(TaskReader.ExpressionReader instance)
			{
				if (instance.VisitProperty())
				{
					instance = instance.IncludeProperty();
				}
				if (!instance.CalculateRule())
				{
					if (!instance.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader | ((TaskReader.WorkerAuthenticationReader)instance).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader | ((TaskReader.WorkerAuthenticationReader)instance).InstantiateWatcher().paramsReader.filterReader));
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader | ((TaskReader.ExporterPolicyPolicy)instance).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader | ((TaskReader.ExporterPolicyPolicy)instance).paramsReader.filterReader));
				}
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x00004293 File Offset: 0x00002493
			public override TaskReader.ExpressionReader DestroyWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(~this.PushWatcher()._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)(~(long)this.InstantiateWatcher().paramsReader.filterReader));
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x00019A04 File Offset: 0x00017C04
			public override TaskReader.ExpressionReader CloneWatcher(TaskReader.ExpressionReader i)
			{
				if (i.VisitProperty())
				{
					i = i.IncludeProperty();
				}
				if (i.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader ^ ((TaskReader.ExporterPolicyPolicy)i).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader ^ ((TaskReader.ExporterPolicyPolicy)i).paramsReader.filterReader));
				}
				else
				{
					if (!i.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader ^ ((TaskReader.WorkerAuthenticationReader)i).PushWatcher()._IteratorReader._InterpreterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader ^ ((TaskReader.WorkerAuthenticationReader)i).InstantiateWatcher().paramsReader.filterReader));
				}
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x00019AF4 File Offset: 0x00017CF4
			public override TaskReader.ExpressionReader VisitWatcher(TaskReader.ExpressionReader info)
			{
				if (info.VisitProperty())
				{
					info = info.IncludeProperty();
				}
				if (info.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader << ((TaskReader.ExporterPolicyPolicy)info).paramsReader.filterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)((long)this.InstantiateWatcher().paramsReader.filterReader << ((TaskReader.ExporterPolicyPolicy)info).paramsReader.filterReader));
				}
				else
				{
					if (!info.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader << ((TaskReader.WorkerAuthenticationReader)info).PushWatcher()._IteratorReader.tokenizerReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)((long)this.InstantiateWatcher().paramsReader.filterReader << ((TaskReader.WorkerAuthenticationReader)info).InstantiateWatcher().paramsReader.filterReader));
				}
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x00019BEC File Offset: 0x00017DEC
			public override TaskReader.ExpressionReader LogoutWatcher(TaskReader.ExpressionReader first)
			{
				if (first.VisitProperty())
				{
					first = first.IncludeProperty();
				}
				if (first.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader >> ((TaskReader.ExporterPolicyPolicy)first).paramsReader.filterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader >> ((TaskReader.ExporterPolicyPolicy)first).paramsReader.filterReader));
				}
				else
				{
					if (!first.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader._InterpreterReader >> ((TaskReader.WorkerAuthenticationReader)first).PushWatcher()._IteratorReader.tokenizerReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)(this.InstantiateWatcher().paramsReader.filterReader >> ((TaskReader.WorkerAuthenticationReader)first).InstantiateWatcher().paramsReader.filterReader));
				}
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x00019CE4 File Offset: 0x00017EE4
			public override TaskReader.ExpressionReader UpdateWatcher(TaskReader.ExpressionReader init)
			{
				if (init.VisitProperty())
				{
					init = init.IncludeProperty();
				}
				if (init.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader.roleReader >> ((TaskReader.ExporterPolicyPolicy)init).paramsReader.filterReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)((ulong)(this.InstantiateWatcher().paramsReader.m_StubReader >> ((TaskReader.ExporterPolicyPolicy)init).paramsReader.filterReader)));
				}
				else
				{
					if (!init.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return new TaskReader.WorkerAuthenticationReader(this.PushWatcher()._IteratorReader.roleReader >> ((TaskReader.WorkerAuthenticationReader)init).PushWatcher()._IteratorReader.tokenizerReader);
					}
					return new TaskReader.WorkerAuthenticationReader((long)((ulong)(this.InstantiateWatcher().paramsReader.m_StubReader >> ((TaskReader.WorkerAuthenticationReader)init).InstantiateWatcher().paramsReader.filterReader)));
				}
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x000042CB File Offset: 0x000024CB
			public TaskReader.ExpressionReader ResetAnnotation(TaskReader.ExporterPolicyPolicy info)
			{
				return new TaskReader.WorkerAuthenticationReader((long)((ulong)(info.paramsReader.m_StubReader >> this.InstantiateWatcher().paramsReader.filterReader)));
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x000042F2 File Offset: 0x000024F2
			public TaskReader.ExpressionReader SelectAnnotation(TaskReader.ExporterPolicyPolicy asset)
			{
				return new TaskReader.WorkerAuthenticationReader((long)(asset.paramsReader.filterReader >> this.PushWatcher()._IteratorReader.tokenizerReader));
			}

			// Token: 0x060003C9 RID: 969 RVA: 0x00004319 File Offset: 0x00002519
			public TaskReader.ExpressionReader InitAnnotation(TaskReader.ExporterPolicyPolicy res)
			{
				return new TaskReader.WorkerAuthenticationReader((long)((long)res.paramsReader.filterReader << this.PushWatcher()._IteratorReader.tokenizerReader));
			}

			// Token: 0x060003CA RID: 970 RVA: 0x00004340 File Offset: 0x00002540
			public override string ToString()
			{
				return this._TestsReader.ToString();
			}

			// Token: 0x060003CB RID: 971 RVA: 0x000038B2 File Offset: 0x00001AB2
			internal override TaskReader.ExpressionReader IncludeProperty()
			{
				return this;
			}

			// Token: 0x060003CC RID: 972 RVA: 0x000038BF File Offset: 0x00001ABF
			internal override bool RunProperty()
			{
				return true;
			}

			// Token: 0x060003CD RID: 973 RVA: 0x00019DDC File Offset: 0x00017FDC
			internal override bool ResolveProperty(TaskReader.ExpressionReader def)
			{
				if (def.UpdateRule())
				{
					return false;
				}
				if (def.VisitProperty())
				{
					return ((TaskReader.MockReader)def).ResolveProperty(this);
				}
				TaskReader.ExpressionReader expressionReader = def.IncludeProperty();
				if (!expressionReader.RunProperty())
				{
					return false;
				}
				if (!expressionReader.CalculateRule())
				{
					if (!expressionReader.PatchRule())
					{
						return false;
					}
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader._InterpreterReader == ((TaskReader.WorkerAuthenticationReader)def).PushWatcher()._IteratorReader._InterpreterReader;
					}
					return this.PushWatcher()._IteratorReader._InterpreterReader == ((TaskReader.WorkerAuthenticationReader)def).PushWatcher()._IteratorReader._InterpreterReader;
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader._InterpreterReader == ((TaskReader.ExporterPolicyPolicy)def).PushWatcher()._IteratorReader._InterpreterReader;
					}
					return this.InstantiateWatcher().paramsReader.filterReader == ((TaskReader.ExporterPolicyPolicy)def).paramsReader.filterReader;
				}
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00019ED8 File Offset: 0x000180D8
			internal override bool CancelProperty(TaskReader.ExpressionReader task)
			{
				if (task.UpdateRule())
				{
					return false;
				}
				if (task.VisitProperty())
				{
					return ((TaskReader.MockReader)task).CancelProperty(this);
				}
				TaskReader.ExpressionReader expressionReader = task.IncludeProperty();
				if (!expressionReader.RunProperty())
				{
					return false;
				}
				if (!expressionReader.CalculateRule())
				{
					if (!expressionReader.PatchRule())
					{
						return false;
					}
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader.roleReader != ((TaskReader.WorkerAuthenticationReader)task).PushWatcher()._IteratorReader.roleReader;
					}
					return this.PushWatcher()._IteratorReader.roleReader != ((TaskReader.WorkerAuthenticationReader)task).PushWatcher()._IteratorReader.roleReader;
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader.roleReader != ((TaskReader.ExporterPolicyPolicy)task).PushWatcher()._IteratorReader.roleReader;
					}
					return this.InstantiateWatcher().paramsReader.m_StubReader != ((TaskReader.ExporterPolicyPolicy)task).paramsReader.m_StubReader;
				}
			}

			// Token: 0x060003CF RID: 975 RVA: 0x00019FE0 File Offset: 0x000181E0
			public override bool CalculateWatcher(TaskReader.ExpressionReader init)
			{
				if (init.VisitProperty())
				{
					init = init.IncludeProperty();
				}
				if (init.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader._InterpreterReader >= ((TaskReader.ExporterPolicyPolicy)init).PushWatcher()._IteratorReader._InterpreterReader;
					}
					return this.InstantiateWatcher().paramsReader.filterReader >= ((TaskReader.ExporterPolicyPolicy)init).paramsReader.filterReader;
				}
				else
				{
					if (!init.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader._InterpreterReader >= ((TaskReader.WorkerAuthenticationReader)init).PushWatcher()._IteratorReader._InterpreterReader;
					}
					return this.InstantiateWatcher().paramsReader.filterReader >= ((TaskReader.WorkerAuthenticationReader)init).InstantiateWatcher().paramsReader.filterReader;
				}
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x0001A0CC File Offset: 0x000182CC
			public override bool PatchWatcher(TaskReader.ExpressionReader reference)
			{
				if (reference.VisitProperty())
				{
					reference = reference.IncludeProperty();
				}
				if (reference.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader.roleReader >= ((TaskReader.ExporterPolicyPolicy)reference).PushWatcher()._IteratorReader.roleReader;
					}
					return this.InstantiateWatcher().paramsReader.m_StubReader >= ((TaskReader.ExporterPolicyPolicy)reference).paramsReader.m_StubReader;
				}
				else
				{
					if (!reference.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader.roleReader >= ((TaskReader.WorkerAuthenticationReader)reference).PushWatcher()._IteratorReader.roleReader;
					}
					return this.InstantiateWatcher().paramsReader.m_StubReader >= ((TaskReader.WorkerAuthenticationReader)reference).InstantiateWatcher().paramsReader.m_StubReader;
				}
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x0001A1B8 File Offset: 0x000183B8
			public override bool ResolveWatcher(TaskReader.ExpressionReader ident)
			{
				if (ident.VisitProperty())
				{
					ident = ident.IncludeProperty();
				}
				if (!ident.CalculateRule())
				{
					if (!ident.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader._InterpreterReader > ((TaskReader.WorkerAuthenticationReader)ident).PushWatcher()._IteratorReader._InterpreterReader;
					}
					return this.InstantiateWatcher().paramsReader.filterReader > ((TaskReader.WorkerAuthenticationReader)ident).InstantiateWatcher().paramsReader.filterReader;
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader._InterpreterReader > ((TaskReader.ExporterPolicyPolicy)ident).PushWatcher()._IteratorReader._InterpreterReader;
					}
					return this.InstantiateWatcher().paramsReader.filterReader > ((TaskReader.ExporterPolicyPolicy)ident).paramsReader.filterReader;
				}
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x0001A298 File Offset: 0x00018498
			public override bool CancelWatcher(TaskReader.ExpressionReader i)
			{
				if (i.VisitProperty())
				{
					i = i.IncludeProperty();
				}
				if (i.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader.roleReader > ((TaskReader.ExporterPolicyPolicy)i).PushWatcher()._IteratorReader.roleReader;
					}
					return this.InstantiateWatcher().paramsReader.m_StubReader > ((TaskReader.ExporterPolicyPolicy)i).paramsReader.m_StubReader;
				}
				else
				{
					if (!i.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader.roleReader > ((TaskReader.WorkerAuthenticationReader)i).PushWatcher()._IteratorReader.roleReader;
					}
					return this.InstantiateWatcher().paramsReader.m_StubReader > ((TaskReader.WorkerAuthenticationReader)i).InstantiateWatcher().paramsReader.m_StubReader;
				}
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x0001A378 File Offset: 0x00018578
			public override bool ViewWatcher(TaskReader.ExpressionReader task)
			{
				if (task.VisitProperty())
				{
					task = task.IncludeProperty();
				}
				if (task.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader._InterpreterReader <= ((TaskReader.ExporterPolicyPolicy)task).PushWatcher()._IteratorReader._InterpreterReader;
					}
					return this.InstantiateWatcher().paramsReader.filterReader <= ((TaskReader.ExporterPolicyPolicy)task).paramsReader.filterReader;
				}
				else
				{
					if (!task.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader._InterpreterReader <= ((TaskReader.WorkerAuthenticationReader)task).PushWatcher()._IteratorReader._InterpreterReader;
					}
					return this.InstantiateWatcher().paramsReader.filterReader <= ((TaskReader.WorkerAuthenticationReader)task).InstantiateWatcher().paramsReader.filterReader;
				}
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x0001A464 File Offset: 0x00018664
			public override bool IncludeWatcher(TaskReader.ExpressionReader item)
			{
				if (item.VisitProperty())
				{
					item = item.IncludeProperty();
				}
				if (item.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader.roleReader <= ((TaskReader.ExporterPolicyPolicy)item).PushWatcher()._IteratorReader.roleReader;
					}
					return this.InstantiateWatcher().paramsReader.m_StubReader <= ((TaskReader.ExporterPolicyPolicy)item).paramsReader.m_StubReader;
				}
				else
				{
					if (!item.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader.roleReader <= ((TaskReader.WorkerAuthenticationReader)item).PushWatcher()._IteratorReader.roleReader;
					}
					return this.InstantiateWatcher().paramsReader.m_StubReader <= ((TaskReader.WorkerAuthenticationReader)item).InstantiateWatcher().paramsReader.m_StubReader;
				}
			}

			// Token: 0x060003D5 RID: 981 RVA: 0x0001A550 File Offset: 0x00018750
			public override bool RunWatcher(TaskReader.ExpressionReader var1)
			{
				if (var1.VisitProperty())
				{
					var1 = var1.IncludeProperty();
				}
				if (var1.CalculateRule())
				{
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader._InterpreterReader < ((TaskReader.ExporterPolicyPolicy)var1).PushWatcher()._IteratorReader._InterpreterReader;
					}
					return this.InstantiateWatcher().paramsReader.filterReader < ((TaskReader.ExporterPolicyPolicy)var1).paramsReader.filterReader;
				}
				else
				{
					if (!var1.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader._InterpreterReader < ((TaskReader.WorkerAuthenticationReader)var1).PushWatcher()._IteratorReader._InterpreterReader;
					}
					return this.InstantiateWatcher().paramsReader.filterReader < ((TaskReader.WorkerAuthenticationReader)var1).InstantiateWatcher().paramsReader.filterReader;
				}
			}

			// Token: 0x060003D6 RID: 982 RVA: 0x0001A630 File Offset: 0x00018830
			public override bool FindWatcher(TaskReader.ExpressionReader v)
			{
				if (v.VisitProperty())
				{
					v = v.IncludeProperty();
				}
				if (!v.CalculateRule())
				{
					if (!v.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader.roleReader < ((TaskReader.WorkerAuthenticationReader)v).PushWatcher()._IteratorReader.roleReader;
					}
					return this.InstantiateWatcher().paramsReader.m_StubReader < ((TaskReader.WorkerAuthenticationReader)v).InstantiateWatcher().paramsReader.m_StubReader;
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return this.PushWatcher()._IteratorReader.roleReader < ((TaskReader.ExporterPolicyPolicy)v).PushWatcher()._IteratorReader.roleReader;
					}
					return this.InstantiateWatcher().paramsReader.m_StubReader < ((TaskReader.ExporterPolicyPolicy)v).paramsReader.m_StubReader;
				}
			}

			// Token: 0x060003D7 RID: 983 RVA: 0x0000434D File Offset: 0x0000254D
			internal static bool DisableListener()
			{
				return TaskReader.WorkerAuthenticationReader.AwakeListener == null;
			}

			// Token: 0x04000218 RID: 536
			public object _TestsReader;

			// Token: 0x04000219 RID: 537
			public TaskReader.XmlReadMode dicReader;

			// Token: 0x0400021A RID: 538
			internal static object AwakeListener;
		}

		// Token: 0x02000078 RID: 120
		internal class SystemReader
		{
			// Token: 0x060003D8 RID: 984 RVA: 0x00004357 File Offset: 0x00002557
			public int method_0()
			{
				return this.m_AdvisorReader.Count;
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x00004364 File Offset: 0x00002564
			public void PrintAnnotation()
			{
				this.m_AdvisorReader.Clear();
			}

			// Token: 0x060003DA RID: 986 RVA: 0x00004371 File Offset: 0x00002571
			public void CountAnnotation(TaskReader.ExpressionReader var1)
			{
				this.m_AdvisorReader.Add(var1);
			}

			// Token: 0x060003DB RID: 987 RVA: 0x0000437F File Offset: 0x0000257F
			public TaskReader.ExpressionReader StopAnnotation()
			{
				return this.m_AdvisorReader[this.m_AdvisorReader.Count - 1];
			}

			// Token: 0x060003DC RID: 988 RVA: 0x0001A710 File Offset: 0x00018910
			public TaskReader.ExpressionReader MoveAnnotation()
			{
				TaskReader.ExpressionReader result = this.StopAnnotation();
				if (this.m_AdvisorReader.Count != 0)
				{
					this.m_AdvisorReader.RemoveAt(this.m_AdvisorReader.Count - 1);
				}
				return result;
			}

			// Token: 0x060003DD RID: 989 RVA: 0x00004399 File Offset: 0x00002599
			public SystemReader()
			{
				AdvisorConnectionAttribute.CancelComposer();
				this.m_AdvisorReader = new List<TaskReader.ExpressionReader>();
				base..ctor();
			}

			// Token: 0x060003DE RID: 990 RVA: 0x000043B1 File Offset: 0x000025B1
			internal static bool RegisterListener()
			{
				return TaskReader.SystemReader.LoginListener == null;
			}

			// Token: 0x0400021B RID: 539
			private List<TaskReader.ExpressionReader> m_AdvisorReader;

			// Token: 0x0400021C RID: 540
			private static object LoginListener;
		}

		// Token: 0x02000079 RID: 121
		internal abstract class MockReader : TaskReader.ExpressionReader
		{
			// Token: 0x060003DF RID: 991 RVA: 0x000038C2 File Offset: 0x00001AC2
			public MockReader()
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x000038BF File Offset: 0x00001ABF
			internal override bool VisitProperty()
			{
				return true;
			}

			// Token: 0x060003E1 RID: 993
			internal abstract IntPtr ConcatWatcher();

			// Token: 0x060003E2 RID: 994
			internal abstract void MapWatcher(TaskReader.ExpressionReader reference);

			// Token: 0x060003E3 RID: 995 RVA: 0x000038BF File Offset: 0x00001ABF
			internal override bool LogoutProperty()
			{
				return true;
			}

			// Token: 0x060003E4 RID: 996 RVA: 0x000043BB File Offset: 0x000025BB
			internal static bool CancelRecord()
			{
				return TaskReader.MockReader.DestroyRecord == null;
			}

			// Token: 0x0400021D RID: 541
			internal static object DestroyRecord;
		}

		// Token: 0x0200007A RID: 122
		internal class AttributeContainerRole : TaskReader.MockReader
		{
			// Token: 0x060003E5 RID: 997 RVA: 0x000043C5 File Offset: 0x000025C5
			public AttributeContainerRole(int instance_Low, TaskReader.SingletonSingletonObject b)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this._CodeReader = b;
				this._AttrReader = instance_Low;
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)7;
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x0001A74C File Offset: 0x0001894C
			internal override void FindProperty(TaskReader.ExpressionReader i)
			{
				if (i is TaskReader.AttributeContainerRole)
				{
					this._CodeReader = ((TaskReader.AttributeContainerRole)i)._CodeReader;
					this._AttrReader = ((TaskReader.AttributeContainerRole)i)._AttrReader;
					return;
				}
				TaskReader.ListContainerRole listContainerRole = this._CodeReader.adapterReader.printerReader[this._AttrReader];
				if (i is TaskReader.MockReader && (byte)(listContainerRole.regReader & (TaskReader.XmlReadMode)226) > 0)
				{
					TaskReader.MockReader mockReader = i as TaskReader.MockReader;
					TaskReader.ExpressionReader reference = mockReader.IncludeProperty();
					this.MapWatcher(reference);
					return;
				}
				this.MapWatcher(i);
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x000043E7 File Offset: 0x000025E7
			internal override void UpdateProperty(TaskReader.ExpressionReader last)
			{
				this.MapWatcher(last);
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x000043F0 File Offset: 0x000025F0
			internal override IntPtr ConcatWatcher()
			{
				throw new NotImplementedException();
			}

			// Token: 0x060003E9 RID: 1001 RVA: 0x000043F7 File Offset: 0x000025F7
			internal override void MapWatcher(TaskReader.ExpressionReader i)
			{
				this._CodeReader._ListenerReader[this._AttrReader] = i;
			}

			// Token: 0x060003EA RID: 1002 RVA: 0x0000440C File Offset: 0x0000260C
			internal override object PatchProperty(Type ident)
			{
				if (this._CodeReader._ListenerReader[this._AttrReader] == null)
				{
					return null;
				}
				return this.IncludeProperty().PatchProperty(ident);
			}

			// Token: 0x060003EB RID: 1003 RVA: 0x00004430 File Offset: 0x00002630
			internal override TaskReader.ExpressionReader IncludeProperty()
			{
				if (this._CodeReader._ListenerReader[this._AttrReader] == null)
				{
					return new TaskReader.CandidateReader(null);
				}
				return this._CodeReader._ListenerReader[this._AttrReader].IncludeProperty();
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x00004464 File Offset: 0x00002664
			internal override bool RunProperty()
			{
				return this.IncludeProperty().RunProperty();
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x0001A7D8 File Offset: 0x000189D8
			internal override bool ResolveProperty(TaskReader.ExpressionReader info)
			{
				if (!info.VisitProperty())
				{
					return false;
				}
				if (info is TaskReader.AttributeContainerRole)
				{
					TaskReader.AttributeContainerRole attributeContainerRole = (TaskReader.AttributeContainerRole)info;
					return attributeContainerRole._AttrReader == this._AttrReader;
				}
				return false;
			}

			// Token: 0x060003EE RID: 1006 RVA: 0x0001A814 File Offset: 0x00018A14
			internal override bool CancelProperty(TaskReader.ExpressionReader last)
			{
				if (!last.VisitProperty())
				{
					return true;
				}
				if (last is TaskReader.AttributeContainerRole)
				{
					TaskReader.AttributeContainerRole attributeContainerRole = (TaskReader.AttributeContainerRole)last;
					return attributeContainerRole._AttrReader != this._AttrReader;
				}
				return true;
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x00004471 File Offset: 0x00002671
			internal override bool ViewProperty()
			{
				return this.IncludeProperty().ViewProperty();
			}

			// Token: 0x060003F0 RID: 1008 RVA: 0x0000447E File Offset: 0x0000267E
			internal static bool CallRecord()
			{
				return TaskReader.AttributeContainerRole.ValidateRecord == null;
			}

			// Token: 0x0400021E RID: 542
			private TaskReader.SingletonSingletonObject _CodeReader;

			// Token: 0x0400021F RID: 543
			internal int _AttrReader;

			// Token: 0x04000220 RID: 544
			internal static object ValidateRecord;
		}

		// Token: 0x0200007B RID: 123
		internal class ConfigurationReader : TaskReader.MockReader
		{
			// Token: 0x060003F1 RID: 1009 RVA: 0x00004488 File Offset: 0x00002688
			public ConfigurationReader(int key, Array map)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ImporterReader = map;
				this.bridgeReader = key;
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)7;
			}

			// Token: 0x060003F2 RID: 1010 RVA: 0x000043F0 File Offset: 0x000025F0
			internal override IntPtr ConcatWatcher()
			{
				throw new NotImplementedException();
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x000044AA File Offset: 0x000026AA
			internal override void FindProperty(TaskReader.ExpressionReader value)
			{
				if (value is TaskReader.ConfigurationReader)
				{
					this.m_ImporterReader = ((TaskReader.ConfigurationReader)value).m_ImporterReader;
					this.bridgeReader = ((TaskReader.ConfigurationReader)value).bridgeReader;
					return;
				}
				this.MapWatcher(value);
			}

			// Token: 0x060003F4 RID: 1012 RVA: 0x000043E7 File Offset: 0x000025E7
			internal override void UpdateProperty(TaskReader.ExpressionReader task)
			{
				this.MapWatcher(task);
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x000044DE File Offset: 0x000026DE
			internal override void MapWatcher(TaskReader.ExpressionReader asset)
			{
				this.m_ImporterReader.SetValue(asset.PatchProperty(null), this.bridgeReader);
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x000044F8 File Offset: 0x000026F8
			internal override object PatchProperty(Type first)
			{
				return this.IncludeProperty().PatchProperty(first);
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x0001A850 File Offset: 0x00018A50
			internal override TaskReader.ExpressionReader IncludeProperty()
			{
				Type elementType = this.m_ImporterReader.GetType().GetElementType();
				return TaskReader.ExpressionReader.RunRule(elementType, this.m_ImporterReader.GetValue(this.bridgeReader));
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x00004464 File Offset: 0x00002664
			internal override bool RunProperty()
			{
				return this.IncludeProperty().RunProperty();
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x0001A888 File Offset: 0x00018A88
			internal override bool ResolveProperty(TaskReader.ExpressionReader spec)
			{
				if (!spec.VisitProperty())
				{
					return false;
				}
				if (!(spec is TaskReader.ConfigurationReader))
				{
					return false;
				}
				TaskReader.ConfigurationReader configurationReader = (TaskReader.ConfigurationReader)spec;
				return configurationReader.bridgeReader == this.bridgeReader && configurationReader.m_ImporterReader == this.m_ImporterReader;
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x0001A8D4 File Offset: 0x00018AD4
			internal override bool CancelProperty(TaskReader.ExpressionReader info)
			{
				if (!info.VisitProperty())
				{
					return true;
				}
				if (info is TaskReader.ConfigurationReader)
				{
					TaskReader.ConfigurationReader configurationReader = (TaskReader.ConfigurationReader)info;
					return configurationReader.bridgeReader != this.bridgeReader || configurationReader.m_ImporterReader != this.m_ImporterReader;
				}
				return true;
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x00004471 File Offset: 0x00002671
			internal override bool ViewProperty()
			{
				return this.IncludeProperty().ViewProperty();
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x00004506 File Offset: 0x00002706
			internal static bool CreateRecord()
			{
				return TaskReader.ConfigurationReader.ComputeRecord == null;
			}

			// Token: 0x04000221 RID: 545
			private Array m_ImporterReader;

			// Token: 0x04000222 RID: 546
			internal int bridgeReader;

			// Token: 0x04000223 RID: 547
			internal static object ComputeRecord;
		}

		// Token: 0x0200007C RID: 124
		internal class TagReader : TaskReader.MockReader
		{
			// Token: 0x060003FD RID: 1021 RVA: 0x00004510 File Offset: 0x00002710
			public TagReader(FieldInfo def, object reg)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.objectReader = def;
				this._ExporterReader = reg;
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)7;
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x000043F0 File Offset: 0x000025F0
			internal override IntPtr ConcatWatcher()
			{
				throw new NotImplementedException();
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x0001A920 File Offset: 0x00018B20
			internal override void MapWatcher(TaskReader.ExpressionReader last)
			{
				if (this._ExporterReader != null && this._ExporterReader is TaskReader.ExpressionReader)
				{
					this.objectReader.SetValue(((TaskReader.ExpressionReader)this._ExporterReader).PatchProperty(null), last.PatchProperty(null));
					return;
				}
				this.objectReader.SetValue(this._ExporterReader, last.PatchProperty(null));
			}

			// Token: 0x06000400 RID: 1024 RVA: 0x00004532 File Offset: 0x00002732
			internal override void FindProperty(TaskReader.ExpressionReader param)
			{
				if (param is TaskReader.TagReader)
				{
					this.objectReader = ((TaskReader.TagReader)param).objectReader;
					this._ExporterReader = ((TaskReader.TagReader)param)._ExporterReader;
					return;
				}
				this.MapWatcher(param);
			}

			// Token: 0x06000401 RID: 1025 RVA: 0x000043E7 File Offset: 0x000025E7
			internal override void UpdateProperty(TaskReader.ExpressionReader init)
			{
				this.MapWatcher(init);
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x000044F8 File Offset: 0x000026F8
			internal override object PatchProperty(Type info)
			{
				return this.IncludeProperty().PatchProperty(info);
			}

			// Token: 0x06000403 RID: 1027 RVA: 0x0001A980 File Offset: 0x00018B80
			internal override TaskReader.ExpressionReader IncludeProperty()
			{
				if (this._ExporterReader != null && this._ExporterReader is TaskReader.ExpressionReader)
				{
					return TaskReader.ExpressionReader.RunRule(this.objectReader.FieldType, this.objectReader.GetValue(((TaskReader.ExpressionReader)this._ExporterReader).PatchProperty(null)));
				}
				return TaskReader.ExpressionReader.RunRule(this.objectReader.FieldType, this.objectReader.GetValue(this._ExporterReader));
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x00004464 File Offset: 0x00002664
			internal override bool RunProperty()
			{
				return this.IncludeProperty().RunProperty();
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x0001A9F0 File Offset: 0x00018BF0
			internal override bool ResolveProperty(TaskReader.ExpressionReader init)
			{
				if (!init.VisitProperty())
				{
					return false;
				}
				if (init is TaskReader.TagReader)
				{
					TaskReader.TagReader tagReader = (TaskReader.TagReader)init;
					return !(tagReader.objectReader != this.objectReader) && tagReader._ExporterReader == this._ExporterReader;
				}
				return false;
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x0001AA40 File Offset: 0x00018C40
			internal override bool CancelProperty(TaskReader.ExpressionReader i)
			{
				if (!i.VisitProperty())
				{
					return true;
				}
				if (!(i is TaskReader.TagReader))
				{
					return true;
				}
				TaskReader.TagReader tagReader = (TaskReader.TagReader)i;
				return tagReader.objectReader != this.objectReader || tagReader._ExporterReader != this._ExporterReader;
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x00004471 File Offset: 0x00002671
			internal override bool ViewProperty()
			{
				return this.IncludeProperty().ViewProperty();
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x00004566 File Offset: 0x00002766
			internal static bool CountRecord()
			{
				return TaskReader.TagReader.InterruptRecord == null;
			}

			// Token: 0x04000224 RID: 548
			internal FieldInfo objectReader;

			// Token: 0x04000225 RID: 549
			internal object _ExporterReader;

			// Token: 0x04000226 RID: 550
			internal static object InterruptRecord;
		}

		// Token: 0x0200007D RID: 125
		internal class ParamContainerRole : TaskReader.MockReader
		{
			// Token: 0x06000409 RID: 1033 RVA: 0x00004570 File Offset: 0x00002770
			public ParamContainerRole(int min_var1, TaskReader.SingletonSingletonObject map)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this._DispatcherReader = map;
				this.configReader = min_var1;
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)7;
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x000043F0 File Offset: 0x000025F0
			internal override IntPtr ConcatWatcher()
			{
				throw new NotImplementedException();
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x00004592 File Offset: 0x00002792
			internal override void FindProperty(TaskReader.ExpressionReader value)
			{
				if (value is TaskReader.ParamContainerRole)
				{
					this._DispatcherReader = ((TaskReader.ParamContainerRole)value)._DispatcherReader;
					this.configReader = ((TaskReader.ParamContainerRole)value).configReader;
					return;
				}
				this.MapWatcher(value);
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x000043E7 File Offset: 0x000025E7
			internal override void UpdateProperty(TaskReader.ExpressionReader info)
			{
				this.MapWatcher(info);
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x000045C6 File Offset: 0x000027C6
			internal override void MapWatcher(TaskReader.ExpressionReader spec)
			{
				this._DispatcherReader._BroadcasterReader[this.configReader] = spec;
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x000045DB File Offset: 0x000027DB
			internal override object PatchProperty(Type res)
			{
				if (this._DispatcherReader._BroadcasterReader[this.configReader] == null)
				{
					return null;
				}
				return this.IncludeProperty().PatchProperty(res);
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x000045FF File Offset: 0x000027FF
			internal override TaskReader.ExpressionReader IncludeProperty()
			{
				if (this._DispatcherReader._BroadcasterReader[this.configReader] == null)
				{
					return new TaskReader.CandidateReader(null);
				}
				return this._DispatcherReader._BroadcasterReader[this.configReader].IncludeProperty();
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x00004464 File Offset: 0x00002664
			internal override bool RunProperty()
			{
				return this.IncludeProperty().RunProperty();
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x0001AA90 File Offset: 0x00018C90
			internal override bool ResolveProperty(TaskReader.ExpressionReader var1)
			{
				if (!var1.VisitProperty())
				{
					return false;
				}
				if (!(var1 is TaskReader.ParamContainerRole))
				{
					return false;
				}
				TaskReader.ParamContainerRole paramContainerRole = (TaskReader.ParamContainerRole)var1;
				return paramContainerRole.configReader == this.configReader;
			}

			// Token: 0x06000412 RID: 1042 RVA: 0x0001AAC8 File Offset: 0x00018CC8
			internal override bool CancelProperty(TaskReader.ExpressionReader asset)
			{
				if (!asset.VisitProperty())
				{
					return true;
				}
				if (!(asset is TaskReader.ParamContainerRole))
				{
					return true;
				}
				TaskReader.ParamContainerRole paramContainerRole = (TaskReader.ParamContainerRole)asset;
				return paramContainerRole.configReader != this.configReader;
			}

			// Token: 0x06000413 RID: 1043 RVA: 0x00004471 File Offset: 0x00002671
			internal override bool ViewProperty()
			{
				return this.IncludeProperty().ViewProperty();
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x00004633 File Offset: 0x00002833
			internal static bool CheckRecord()
			{
				return TaskReader.ParamContainerRole.LogoutRecord == null;
			}

			// Token: 0x04000227 RID: 551
			private TaskReader.SingletonSingletonObject _DispatcherReader;

			// Token: 0x04000228 RID: 552
			internal int configReader;

			// Token: 0x04000229 RID: 553
			private static object LogoutRecord;
		}

		// Token: 0x0200007E RID: 126
		internal class ObjectPolicyPolicy : TaskReader.MockReader
		{
			// Token: 0x06000415 RID: 1045 RVA: 0x0000463D File Offset: 0x0000283D
			public ObjectPolicyPolicy(TaskReader.ExpressionReader item, Type counter)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_BaseReader = item;
				this.databaseReader = counter;
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)7;
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x000043F0 File Offset: 0x000025F0
			internal override IntPtr ConcatWatcher()
			{
				throw new NotImplementedException();
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x0000465F File Offset: 0x0000285F
			internal override void FindProperty(TaskReader.ExpressionReader last)
			{
				if (!(last is TaskReader.ObjectPolicyPolicy))
				{
					this.m_BaseReader.FindProperty(last);
					return;
				}
				this.databaseReader = ((TaskReader.ObjectPolicyPolicy)last).databaseReader;
				this.m_BaseReader = ((TaskReader.ObjectPolicyPolicy)last).m_BaseReader;
			}

			// Token: 0x06000418 RID: 1048 RVA: 0x000043E7 File Offset: 0x000025E7
			internal override void UpdateProperty(TaskReader.ExpressionReader spec)
			{
				this.MapWatcher(spec);
			}

			// Token: 0x06000419 RID: 1049 RVA: 0x00004698 File Offset: 0x00002898
			internal override void MapWatcher(TaskReader.ExpressionReader setup)
			{
				this.m_BaseReader = setup;
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x0001AB04 File Offset: 0x00018D04
			internal override object PatchProperty(Type param)
			{
				if (this.m_BaseReader == null)
				{
					return new TaskReader.CandidateReader(null);
				}
				if (!(param == null) && !(param == typeof(object)))
				{
					return this.m_BaseReader.PatchProperty(param);
				}
				return this.m_BaseReader.PatchProperty(this.databaseReader);
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x000046A1 File Offset: 0x000028A1
			internal override TaskReader.ExpressionReader IncludeProperty()
			{
				if (this.m_BaseReader == null)
				{
					return new TaskReader.CandidateReader(null);
				}
				return this.m_BaseReader.IncludeProperty();
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x00004464 File Offset: 0x00002664
			internal override bool RunProperty()
			{
				return this.IncludeProperty().RunProperty();
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x0001AB5C File Offset: 0x00018D5C
			internal override bool ResolveProperty(TaskReader.ExpressionReader key)
			{
				if (!key.VisitProperty())
				{
					return false;
				}
				if (!(key is TaskReader.ObjectPolicyPolicy))
				{
					return false;
				}
				TaskReader.ObjectPolicyPolicy objectPolicyPolicy = (TaskReader.ObjectPolicyPolicy)key;
				if (objectPolicyPolicy.databaseReader != this.databaseReader)
				{
					return false;
				}
				if (this.m_BaseReader != null)
				{
					return this.m_BaseReader.ResolveProperty(objectPolicyPolicy.m_BaseReader);
				}
				return objectPolicyPolicy.m_BaseReader == null;
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x0001ABC0 File Offset: 0x00018DC0
			internal override bool CancelProperty(TaskReader.ExpressionReader item)
			{
				if (!item.VisitProperty())
				{
					return true;
				}
				if (!(item is TaskReader.ObjectPolicyPolicy))
				{
					return true;
				}
				TaskReader.ObjectPolicyPolicy objectPolicyPolicy = (TaskReader.ObjectPolicyPolicy)item;
				if (objectPolicyPolicy.databaseReader != this.databaseReader)
				{
					return true;
				}
				if (this.m_BaseReader != null)
				{
					return this.m_BaseReader.CancelProperty(objectPolicyPolicy.m_BaseReader);
				}
				return objectPolicyPolicy.m_BaseReader != null;
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x00004471 File Offset: 0x00002671
			internal override bool ViewProperty()
			{
				return this.IncludeProperty().ViewProperty();
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x000046BD File Offset: 0x000028BD
			internal static bool WriteRecord()
			{
				return TaskReader.ObjectPolicyPolicy.ExcludeRecord == null;
			}

			// Token: 0x0400022A RID: 554
			private TaskReader.ExpressionReader m_BaseReader;

			// Token: 0x0400022B RID: 555
			private Type databaseReader;

			// Token: 0x0400022C RID: 556
			internal static object ExcludeRecord;
		}

		// Token: 0x0200007F RID: 127
		internal enum UnhandledExceptionAction : byte
		{

		}

		// Token: 0x02000080 RID: 128
		[StructLayout(LayoutKind.Explicit)]
		internal struct CustomerSingletonDispatcher
		{
			// Token: 0x0400022E RID: 558
			[FieldOffset(0)]
			public byte _GetterReader;

			// Token: 0x0400022F RID: 559
			[FieldOffset(0)]
			public sbyte _CustomerReader;

			// Token: 0x04000230 RID: 560
			[FieldOffset(0)]
			public ushort m_MappingReader;

			// Token: 0x04000231 RID: 561
			[FieldOffset(0)]
			public short m_StatusReader;

			// Token: 0x04000232 RID: 562
			[FieldOffset(0)]
			public uint m_StubReader;

			// Token: 0x04000233 RID: 563
			[FieldOffset(0)]
			public int filterReader;
		}

		// Token: 0x02000081 RID: 129
		private class ExporterPolicyPolicy : TaskReader.ModelAuthenticationReader
		{
			// Token: 0x06000421 RID: 1057 RVA: 0x000046C7 File Offset: 0x000028C7
			internal override void FindProperty(TaskReader.ExpressionReader instance)
			{
				this.paramsReader = ((TaskReader.ExporterPolicyPolicy)instance).paramsReader;
				this._UtilsReader = ((TaskReader.ExporterPolicyPolicy)instance)._UtilsReader;
			}

			// Token: 0x06000422 RID: 1058 RVA: 0x000037E9 File Offset: 0x000019E9
			internal override void UpdateProperty(TaskReader.ExpressionReader instance)
			{
				this.FindProperty(instance);
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x000046EB File Offset: 0x000028EB
			public ExporterPolicyPolicy(bool isinit)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)1;
				if (!isinit)
				{
					this.paramsReader.filterReader = 0;
				}
				else
				{
					this.paramsReader.filterReader = 1;
				}
				this._UtilsReader = (TaskReader.XmlReadMode)11;
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x00004724 File Offset: 0x00002924
			public ExporterPolicyPolicy(TaskReader.ExporterPolicyPolicy init)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = init.m_ComparatorReader;
				this.paramsReader.filterReader = init.paramsReader.filterReader;
				this._UtilsReader = init._UtilsReader;
			}

			// Token: 0x06000425 RID: 1061 RVA: 0x0000475F File Offset: 0x0000295F
			public override TaskReader.ModelAuthenticationReader NewWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(this);
			}

			// Token: 0x06000426 RID: 1062 RVA: 0x00004767 File Offset: 0x00002967
			public ExporterPolicyPolicy(int row_last)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)1;
				this.paramsReader.filterReader = row_last;
				this._UtilsReader = (TaskReader.XmlReadMode)5;
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x0000478E File Offset: 0x0000298E
			public ExporterPolicyPolicy(uint maxinfo)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)1;
				this.paramsReader.m_StubReader = maxinfo;
				this._UtilsReader = (TaskReader.XmlReadMode)6;
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x000047B5 File Offset: 0x000029B5
			public ExporterPolicyPolicy(int nextinit, TaskReader.XmlReadMode second)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)1;
				this.paramsReader.filterReader = nextinit;
				this._UtilsReader = second;
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x000047DC File Offset: 0x000029DC
			public ExporterPolicyPolicy(uint configend, TaskReader.XmlReadMode cust)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)1;
				this.paramsReader.m_StubReader = configend;
				this._UtilsReader = cust;
			}

			// Token: 0x0600042A RID: 1066 RVA: 0x0001AC24 File Offset: 0x00018E24
			public override bool ConcatProperty()
			{
				TaskReader.XmlReadMode utilsReader = this._UtilsReader;
				switch (utilsReader)
				{
				case (TaskReader.XmlReadMode)1:
				case (TaskReader.XmlReadMode)3:
				case (TaskReader.XmlReadMode)5:
				case (TaskReader.XmlReadMode)7:
					goto IL_46;
				case (TaskReader.XmlReadMode)2:
				case (TaskReader.XmlReadMode)4:
				case (TaskReader.XmlReadMode)6:
					break;
				default:
					if (utilsReader == (TaskReader.XmlReadMode)11)
					{
						goto IL_46;
					}
					if (utilsReader == (TaskReader.XmlReadMode)15)
					{
						goto IL_46;
					}
					break;
				}
				return this.paramsReader.m_StubReader == 0U;
				IL_46:
				return this.paramsReader.filterReader == 0;
			}

			// Token: 0x0600042B RID: 1067 RVA: 0x00003A14 File Offset: 0x00001C14
			public override bool MapProperty()
			{
				return !this.ConcatProperty();
			}

			// Token: 0x0600042C RID: 1068 RVA: 0x0001AC88 File Offset: 0x00018E88
			public override TaskReader.ExpressionReader ReadProperty(TaskReader.XmlReadMode i)
			{
				switch (i)
				{
				case (TaskReader.XmlReadMode)1:
					return this.RevertProperty();
				case (TaskReader.XmlReadMode)2:
					return this.QueryWatcher();
				case (TaskReader.XmlReadMode)3:
					return this.AddWatcher();
				case (TaskReader.XmlReadMode)4:
					return this.ExcludeWatcher();
				case (TaskReader.XmlReadMode)5:
					return this.InstantiateWatcher();
				case (TaskReader.XmlReadMode)6:
					return this.InterruptWatcher();
				case (TaskReader.XmlReadMode)11:
					return this.ForgotProperty();
				case (TaskReader.XmlReadMode)15:
					return this.ConnectAnnotation();
				case (TaskReader.XmlReadMode)16:
					return this.NewWatcher();
				}
				throw new Exception("truncation not supported");
			}

			// Token: 0x0600042D RID: 1069 RVA: 0x0001AD2C File Offset: 0x00018F2C
			internal override object PatchProperty(Type last)
			{
				if (last != null && last.IsByRef)
				{
					last = last.GetElementType();
				}
				if (last == null || last == typeof(object))
				{
					switch (this._UtilsReader)
					{
					case (TaskReader.XmlReadMode)1:
						return this.paramsReader._CustomerReader;
					case (TaskReader.XmlReadMode)2:
						return this.paramsReader._GetterReader;
					case (TaskReader.XmlReadMode)3:
						return this.paramsReader.m_StatusReader;
					case (TaskReader.XmlReadMode)4:
						return this.paramsReader.m_MappingReader;
					case (TaskReader.XmlReadMode)5:
						return this.paramsReader.filterReader;
					case (TaskReader.XmlReadMode)6:
						return this.paramsReader.m_StubReader;
					case (TaskReader.XmlReadMode)7:
						return (long)this.paramsReader.filterReader;
					case (TaskReader.XmlReadMode)8:
						return (ulong)this.paramsReader.m_StubReader;
					case (TaskReader.XmlReadMode)11:
						return this.MapProperty();
					case (TaskReader.XmlReadMode)15:
						return (char)this.paramsReader.filterReader;
					}
					return this.paramsReader.filterReader;
				}
				if (last == typeof(int))
				{
					return this.paramsReader.filterReader;
				}
				if (last == typeof(uint))
				{
					return this.paramsReader.m_StubReader;
				}
				if (last == typeof(short))
				{
					return this.paramsReader.m_StatusReader;
				}
				if (last == typeof(ushort))
				{
					return this.paramsReader.m_MappingReader;
				}
				if (last == typeof(byte))
				{
					return this.paramsReader._GetterReader;
				}
				if (last == typeof(sbyte))
				{
					return this.paramsReader._CustomerReader;
				}
				if (last == typeof(bool))
				{
					return !this.ConcatProperty();
				}
				if (last == typeof(long))
				{
					return (long)this.paramsReader.filterReader;
				}
				if (last == typeof(ulong))
				{
					return (ulong)this.paramsReader.m_StubReader;
				}
				if (last == typeof(char))
				{
					return (char)this.paramsReader.filterReader;
				}
				if (last == typeof(IntPtr))
				{
					return new IntPtr(this.paramsReader.filterReader);
				}
				if (last == typeof(UIntPtr))
				{
					return new UIntPtr(this.paramsReader.m_StubReader);
				}
				if (last.IsEnum)
				{
					return this.SearchAnnotation(last);
				}
				throw new TaskReader.IndexerReader();
			}

			// Token: 0x0600042E RID: 1070 RVA: 0x0001B054 File Offset: 0x00019254
			internal object SearchAnnotation(Type def)
			{
				Type underlyingType = Enum.GetUnderlyingType(def);
				if (underlyingType == typeof(int))
				{
					return Enum.ToObject(def, this.paramsReader.filterReader);
				}
				if (underlyingType == typeof(uint))
				{
					return Enum.ToObject(def, this.paramsReader.m_StubReader);
				}
				if (underlyingType == typeof(short))
				{
					return Enum.ToObject(def, this.paramsReader.m_StatusReader);
				}
				if (underlyingType == typeof(ushort))
				{
					return Enum.ToObject(def, this.paramsReader.m_MappingReader);
				}
				if (underlyingType == typeof(byte))
				{
					return Enum.ToObject(def, this.paramsReader._GetterReader);
				}
				if (underlyingType == typeof(sbyte))
				{
					return Enum.ToObject(def, this.paramsReader._CustomerReader);
				}
				if (underlyingType == typeof(long))
				{
					return Enum.ToObject(def, (long)this.paramsReader.filterReader);
				}
				if (underlyingType == typeof(ulong))
				{
					return Enum.ToObject(def, (ulong)this.paramsReader.m_StubReader);
				}
				if (!(underlyingType == typeof(char)))
				{
					return Enum.ToObject(def, this.paramsReader.filterReader);
				}
				return Enum.ToObject(def, (ushort)this.paramsReader.filterReader);
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x00003A1F File Offset: 0x00001C1F
			public override TaskReader.ExporterPolicyPolicy ForgotProperty()
			{
				return new TaskReader.ExporterPolicyPolicy(this.ConcatProperty() ? 0 : 1);
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x00003A32 File Offset: 0x00001C32
			internal override bool ViewProperty()
			{
				return this.MapProperty();
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x00004803 File Offset: 0x00002A03
			public override TaskReader.ExporterPolicyPolicy RevertProperty()
			{
				return new TaskReader.ExporterPolicyPolicy((int)this.paramsReader._CustomerReader, (TaskReader.XmlReadMode)1);
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x00004816 File Offset: 0x00002A16
			public TaskReader.ExporterPolicyPolicy ConnectAnnotation()
			{
				return new TaskReader.ExporterPolicyPolicy(this.paramsReader.filterReader, (TaskReader.XmlReadMode)15);
			}

			// Token: 0x06000433 RID: 1075 RVA: 0x0000482A File Offset: 0x00002A2A
			public override TaskReader.ExporterPolicyPolicy QueryWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((uint)this.paramsReader._GetterReader, (TaskReader.XmlReadMode)2);
			}

			// Token: 0x06000434 RID: 1076 RVA: 0x0000483D File Offset: 0x00002A3D
			public override TaskReader.ExporterPolicyPolicy AddWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)this.paramsReader.m_StatusReader, (TaskReader.XmlReadMode)3);
			}

			// Token: 0x06000435 RID: 1077 RVA: 0x00004850 File Offset: 0x00002A50
			public override TaskReader.ExporterPolicyPolicy ExcludeWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((uint)this.paramsReader.m_MappingReader, (TaskReader.XmlReadMode)4);
			}

			// Token: 0x06000436 RID: 1078 RVA: 0x00004863 File Offset: 0x00002A63
			public override TaskReader.ExporterPolicyPolicy InstantiateWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(this.paramsReader.filterReader, (TaskReader.XmlReadMode)5);
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x00004876 File Offset: 0x00002A76
			public override TaskReader.ExporterPolicyPolicy InterruptWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(this.paramsReader.m_StubReader, (TaskReader.XmlReadMode)6);
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x00004889 File Offset: 0x00002A89
			public override TaskReader.AlgoReader PushWatcher()
			{
				return new TaskReader.AlgoReader((long)this.paramsReader.filterReader, (TaskReader.XmlReadMode)7);
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x0000489D File Offset: 0x00002A9D
			public override TaskReader.AlgoReader StartWatcher()
			{
				return new TaskReader.AlgoReader((ulong)this.paramsReader.m_StubReader, (TaskReader.XmlReadMode)8);
			}

			// Token: 0x0600043A RID: 1082 RVA: 0x00003AE6 File Offset: 0x00001CE6
			public override TaskReader.ExporterPolicyPolicy PublishWatcher()
			{
				return this.RevertProperty();
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x00003AEE File Offset: 0x00001CEE
			public override TaskReader.ExporterPolicyPolicy ResetWatcher()
			{
				return this.AddWatcher();
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x00003AF6 File Offset: 0x00001CF6
			public override TaskReader.ExporterPolicyPolicy SelectWatcher()
			{
				return this.InstantiateWatcher();
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x00003AFE File Offset: 0x00001CFE
			public override TaskReader.AlgoReader InitWatcher()
			{
				return this.PushWatcher();
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x00003B06 File Offset: 0x00001D06
			public override TaskReader.ExporterPolicyPolicy PrintWatcher()
			{
				return this.QueryWatcher();
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x00003B0E File Offset: 0x00001D0E
			public override TaskReader.ExporterPolicyPolicy CountWatcher()
			{
				return this.ExcludeWatcher();
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x00003B16 File Offset: 0x00001D16
			public override TaskReader.ExporterPolicyPolicy StopWatcher()
			{
				return this.InterruptWatcher();
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x00003B1E File Offset: 0x00001D1E
			public override TaskReader.AlgoReader MoveWatcher()
			{
				return this.StartWatcher();
			}

			// Token: 0x06000442 RID: 1090 RVA: 0x000048B1 File Offset: 0x00002AB1
			public override TaskReader.ExporterPolicyPolicy SearchWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((sbyte)this.paramsReader.filterReader)), (TaskReader.XmlReadMode)1);
			}

			// Token: 0x06000443 RID: 1091 RVA: 0x000048C5 File Offset: 0x00002AC5
			public override TaskReader.ExporterPolicyPolicy ConnectWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((sbyte)this.paramsReader.m_StubReader)), (TaskReader.XmlReadMode)1);
			}

			// Token: 0x06000444 RID: 1092 RVA: 0x000048D9 File Offset: 0x00002AD9
			public override TaskReader.ExporterPolicyPolicy SetupWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((short)this.paramsReader.filterReader)), (TaskReader.XmlReadMode)3);
			}

			// Token: 0x06000445 RID: 1093 RVA: 0x000048ED File Offset: 0x00002AED
			public override TaskReader.ExporterPolicyPolicy GetWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((short)this.paramsReader.m_StubReader)), (TaskReader.XmlReadMode)3);
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x00004863 File Offset: 0x00002A63
			public override TaskReader.ExporterPolicyPolicy PostWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(this.paramsReader.filterReader, (TaskReader.XmlReadMode)5);
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x00004901 File Offset: 0x00002B01
			public override TaskReader.ExporterPolicyPolicy OrderWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(checked((int)this.paramsReader.m_StubReader), (TaskReader.XmlReadMode)5);
			}

			// Token: 0x06000448 RID: 1096 RVA: 0x00004889 File Offset: 0x00002A89
			public override TaskReader.AlgoReader AssetWatcher()
			{
				return new TaskReader.AlgoReader((long)this.paramsReader.filterReader, (TaskReader.XmlReadMode)7);
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x00004915 File Offset: 0x00002B15
			public override TaskReader.AlgoReader DefineWatcher()
			{
				return new TaskReader.AlgoReader((long)((ulong)this.paramsReader.m_StubReader), (TaskReader.XmlReadMode)7);
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x00004929 File Offset: 0x00002B29
			public override TaskReader.ExporterPolicyPolicy CollectWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((byte)this.paramsReader.filterReader)), (TaskReader.XmlReadMode)2);
			}

			// Token: 0x0600044B RID: 1099 RVA: 0x0000493D File Offset: 0x00002B3D
			public override TaskReader.ExporterPolicyPolicy ListWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((byte)this.paramsReader.m_StubReader)), (TaskReader.XmlReadMode)2);
			}

			// Token: 0x0600044C RID: 1100 RVA: 0x00004951 File Offset: 0x00002B51
			public override TaskReader.ExporterPolicyPolicy RestartWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((ushort)this.paramsReader.filterReader)), (TaskReader.XmlReadMode)4);
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x00004965 File Offset: 0x00002B65
			public override TaskReader.ExporterPolicyPolicy ReflectWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((ushort)this.paramsReader.m_StubReader)), (TaskReader.XmlReadMode)4);
			}

			// Token: 0x0600044E RID: 1102 RVA: 0x00004979 File Offset: 0x00002B79
			public override TaskReader.ExporterPolicyPolicy InsertWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(checked((uint)this.paramsReader.filterReader), (TaskReader.XmlReadMode)6);
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x00004876 File Offset: 0x00002A76
			public override TaskReader.ExporterPolicyPolicy RemoveWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(this.paramsReader.m_StubReader, (TaskReader.XmlReadMode)6);
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x0000498D File Offset: 0x00002B8D
			public override TaskReader.AlgoReader RegisterWatcher()
			{
				return new TaskReader.AlgoReader(checked((ulong)this.paramsReader.filterReader), (TaskReader.XmlReadMode)8);
			}

			// Token: 0x06000451 RID: 1105 RVA: 0x0000489D File Offset: 0x00002A9D
			public override TaskReader.AlgoReader WriteWatcher()
			{
				return new TaskReader.AlgoReader((ulong)this.paramsReader.m_StubReader, (TaskReader.XmlReadMode)8);
			}

			// Token: 0x06000452 RID: 1106 RVA: 0x000049A1 File Offset: 0x00002BA1
			public override TaskReader.IssuerInvocationRecord ManageWatcher()
			{
				return new TaskReader.IssuerInvocationRecord((float)this.paramsReader.filterReader);
			}

			// Token: 0x06000453 RID: 1107 RVA: 0x000049B4 File Offset: 0x00002BB4
			public override TaskReader.IssuerInvocationRecord CompareWatcher()
			{
				return new TaskReader.IssuerInvocationRecord((double)this.paramsReader.filterReader);
			}

			// Token: 0x06000454 RID: 1108 RVA: 0x000049C7 File Offset: 0x00002BC7
			public override TaskReader.IssuerInvocationRecord ComputeWatcher()
			{
				return new TaskReader.IssuerInvocationRecord(this.paramsReader.m_StubReader);
			}

			// Token: 0x06000455 RID: 1109 RVA: 0x00003C78 File Offset: 0x00001E78
			public override TaskReader.WorkerAuthenticationReader SortWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.InitWatcher()._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)this.SelectWatcher().paramsReader.filterReader);
			}

			// Token: 0x06000456 RID: 1110 RVA: 0x00003CAE File Offset: 0x00001EAE
			public override TaskReader.WorkerAuthenticationReader ChangeWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.MoveWatcher()._IteratorReader.roleReader);
				}
				return new TaskReader.WorkerAuthenticationReader((ulong)this.StopWatcher().paramsReader.m_StubReader);
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x00003CE4 File Offset: 0x00001EE4
			public override TaskReader.WorkerAuthenticationReader LoginWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.AssetWatcher()._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)this.PostWatcher().paramsReader.filterReader);
			}

			// Token: 0x06000458 RID: 1112 RVA: 0x00003D1A File Offset: 0x00001F1A
			public override TaskReader.WorkerAuthenticationReader SetWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.RegisterWatcher()._IteratorReader.roleReader);
				}
				return new TaskReader.WorkerAuthenticationReader((ulong)this.InsertWatcher().paramsReader.m_StubReader);
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x00003D50 File Offset: 0x00001F50
			public override TaskReader.WorkerAuthenticationReader AwakeWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.DefineWatcher()._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)this.OrderWatcher().paramsReader.filterReader);
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x0000425D File Offset: 0x0000245D
			public override TaskReader.WorkerAuthenticationReader CustomizeWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.WriteWatcher()._IteratorReader.roleReader);
				}
				return new TaskReader.WorkerAuthenticationReader((ulong)this.RemoveWatcher().paramsReader.m_StubReader);
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x0001B1C4 File Offset: 0x000193C4
			public override TaskReader.ExpressionReader InvokeWatcher()
			{
				TaskReader.XmlReadMode utilsReader = this._UtilsReader;
				switch (utilsReader)
				{
				case (TaskReader.XmlReadMode)1:
				case (TaskReader.XmlReadMode)3:
				case (TaskReader.XmlReadMode)5:
					goto IL_43;
				case (TaskReader.XmlReadMode)2:
				case (TaskReader.XmlReadMode)4:
					break;
				default:
					if (utilsReader == (TaskReader.XmlReadMode)11)
					{
						goto IL_43;
					}
					if (utilsReader == (TaskReader.XmlReadMode)15)
					{
						goto IL_43;
					}
					break;
				}
				return new TaskReader.ExporterPolicyPolicy((int)(-(int)((ulong)this.paramsReader.m_StubReader)));
				IL_43:
				return new TaskReader.ExporterPolicyPolicy(-this.paramsReader.filterReader);
			}

			// Token: 0x0600045C RID: 1116 RVA: 0x0001B228 File Offset: 0x00019428
			public override TaskReader.ExpressionReader CreateWatcher(TaskReader.ExpressionReader i)
			{
				if (i.VisitProperty())
				{
					i = i.IncludeProperty();
				}
				if (i.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(this.paramsReader.filterReader + ((TaskReader.ExporterPolicyPolicy)i).paramsReader.filterReader);
				}
				if (!i.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)i).CreateWatcher(this);
			}

			// Token: 0x0600045D RID: 1117 RVA: 0x0001B28C File Offset: 0x0001948C
			public override TaskReader.ExpressionReader FlushWatcher(TaskReader.ExpressionReader spec)
			{
				if (spec.VisitProperty())
				{
					spec = spec.IncludeProperty();
				}
				if (spec.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(checked(this.paramsReader.filterReader + ((TaskReader.ExporterPolicyPolicy)spec).paramsReader.filterReader));
				}
				if (spec.PatchRule())
				{
					return ((TaskReader.WorkerAuthenticationReader)spec).FlushWatcher(this);
				}
				throw new TaskReader.IndexerReader();
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x0001B2F0 File Offset: 0x000194F0
			public override TaskReader.ExpressionReader CalcWatcher(TaskReader.ExpressionReader value)
			{
				if (value.VisitProperty())
				{
					value = value.IncludeProperty();
				}
				if (value.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(checked(this.paramsReader.m_StubReader + ((TaskReader.ExporterPolicyPolicy)value).paramsReader.m_StubReader));
				}
				if (!value.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)value).CalcWatcher(this);
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x0001B354 File Offset: 0x00019554
			public override TaskReader.ExpressionReader PrepareWatcher(TaskReader.ExpressionReader config)
			{
				if (config.VisitProperty())
				{
					config = config.IncludeProperty();
				}
				if (config.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(this.paramsReader.filterReader - ((TaskReader.ExporterPolicyPolicy)config).paramsReader.filterReader);
				}
				if (config.PatchRule())
				{
					return ((TaskReader.WorkerAuthenticationReader)config).AddAnnotation(this);
				}
				throw new TaskReader.IndexerReader();
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x0001B3B8 File Offset: 0x000195B8
			public override TaskReader.ExpressionReader DeleteWatcher(TaskReader.ExpressionReader config)
			{
				if (config.VisitProperty())
				{
					config = config.IncludeProperty();
				}
				if (config.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(checked(this.paramsReader.filterReader - ((TaskReader.ExporterPolicyPolicy)config).paramsReader.filterReader));
				}
				if (!config.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)config).ExcludeAnnotation(this);
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x0001B41C File Offset: 0x0001961C
			public override TaskReader.ExpressionReader CallWatcher(TaskReader.ExpressionReader item)
			{
				if (item.VisitProperty())
				{
					item = item.IncludeProperty();
				}
				if (item.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(checked(this.paramsReader.m_StubReader - ((TaskReader.ExporterPolicyPolicy)item).paramsReader.m_StubReader));
				}
				if (!item.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)item).InstantiateAnnotation(this);
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x0001B480 File Offset: 0x00019680
			public override TaskReader.ExpressionReader RateWatcher(TaskReader.ExpressionReader asset)
			{
				if (asset.VisitProperty())
				{
					asset = asset.IncludeProperty();
				}
				if (asset.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(this.paramsReader.filterReader * ((TaskReader.ExporterPolicyPolicy)asset).paramsReader.filterReader);
				}
				if (!asset.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)asset).RateWatcher(this);
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x0001B4E4 File Offset: 0x000196E4
			public override TaskReader.ExpressionReader ValidateWatcher(TaskReader.ExpressionReader item)
			{
				if (item.VisitProperty())
				{
					item = item.IncludeProperty();
				}
				if (item.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(checked(this.paramsReader.filterReader * ((TaskReader.ExporterPolicyPolicy)item).paramsReader.filterReader));
				}
				if (!item.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)item).ValidateWatcher(this);
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x0001B548 File Offset: 0x00019748
			public override TaskReader.ExpressionReader VerifyWatcher(TaskReader.ExpressionReader last)
			{
				if (last.VisitProperty())
				{
					last = last.IncludeProperty();
				}
				if (last.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(checked(this.paramsReader.m_StubReader * ((TaskReader.ExporterPolicyPolicy)last).paramsReader.m_StubReader));
				}
				if (!last.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)last).VerifyWatcher(this);
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x0001B5AC File Offset: 0x000197AC
			public override TaskReader.ExpressionReader PopWatcher(TaskReader.ExpressionReader setup)
			{
				if (setup.VisitProperty())
				{
					setup = setup.IncludeProperty();
				}
				if (setup.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(this.paramsReader.filterReader / ((TaskReader.ExporterPolicyPolicy)setup).paramsReader.filterReader);
				}
				if (!setup.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)setup).InterruptAnnotation(this);
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x0001B610 File Offset: 0x00019810
			public override TaskReader.ExpressionReader FillWatcher(TaskReader.ExpressionReader v)
			{
				if (v.VisitProperty())
				{
					v = v.IncludeProperty();
				}
				if (v.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(this.paramsReader.m_StubReader / ((TaskReader.ExporterPolicyPolicy)v).paramsReader.m_StubReader);
				}
				if (!v.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)v).PushAnnotation(this);
			}

			// Token: 0x06000467 RID: 1127 RVA: 0x0001B674 File Offset: 0x00019874
			public override TaskReader.ExpressionReader DisableWatcher(TaskReader.ExpressionReader def)
			{
				if (def.VisitProperty())
				{
					def = def.IncludeProperty();
				}
				if (def.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(this.paramsReader.filterReader % ((TaskReader.ExporterPolicyPolicy)def).paramsReader.filterReader);
				}
				if (def.PatchRule())
				{
					return ((TaskReader.WorkerAuthenticationReader)def).StartAnnotation(this);
				}
				throw new TaskReader.IndexerReader();
			}

			// Token: 0x06000468 RID: 1128 RVA: 0x0001B6D8 File Offset: 0x000198D8
			public override TaskReader.ExpressionReader EnableWatcher(TaskReader.ExpressionReader init)
			{
				if (init.VisitProperty())
				{
					init = init.IncludeProperty();
				}
				if (init.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(this.paramsReader.m_StubReader % ((TaskReader.ExporterPolicyPolicy)init).paramsReader.m_StubReader);
				}
				if (!init.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)init).PublishAnnotation(this);
			}

			// Token: 0x06000469 RID: 1129 RVA: 0x0001B73C File Offset: 0x0001993C
			public override TaskReader.ExpressionReader CheckWatcher(TaskReader.ExpressionReader info)
			{
				if (info.VisitProperty())
				{
					info = info.IncludeProperty();
				}
				if (info.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(this.paramsReader.filterReader & ((TaskReader.ExporterPolicyPolicy)info).paramsReader.filterReader);
				}
				if (!info.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)info).CheckWatcher(this);
			}

			// Token: 0x0600046A RID: 1130 RVA: 0x0001B7A0 File Offset: 0x000199A0
			public override TaskReader.ExpressionReader TestWatcher(TaskReader.ExpressionReader def)
			{
				if (def.VisitProperty())
				{
					def = def.IncludeProperty();
				}
				if (def.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(this.paramsReader.filterReader | ((TaskReader.ExporterPolicyPolicy)def).paramsReader.filterReader);
				}
				if (!def.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)def).TestWatcher(this);
			}

			// Token: 0x0600046B RID: 1131 RVA: 0x000049DB File Offset: 0x00002BDB
			public override TaskReader.ExpressionReader DestroyWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(~this.paramsReader.filterReader);
			}

			// Token: 0x0600046C RID: 1132 RVA: 0x0001B804 File Offset: 0x00019A04
			public override TaskReader.ExpressionReader CloneWatcher(TaskReader.ExpressionReader def)
			{
				if (def.VisitProperty())
				{
					def = def.IncludeProperty();
				}
				if (def.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(this.paramsReader.filterReader ^ ((TaskReader.ExporterPolicyPolicy)def).paramsReader.filterReader);
				}
				if (def.PatchRule())
				{
					return ((TaskReader.WorkerAuthenticationReader)def).CloneWatcher(this);
				}
				throw new TaskReader.IndexerReader();
			}

			// Token: 0x0600046D RID: 1133 RVA: 0x0001B868 File Offset: 0x00019A68
			public override TaskReader.ExpressionReader VisitWatcher(TaskReader.ExpressionReader value)
			{
				if (value.VisitProperty())
				{
					value = value.IncludeProperty();
				}
				if (value.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(this.paramsReader.filterReader << ((TaskReader.ExporterPolicyPolicy)value).paramsReader.filterReader);
				}
				if (!value.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)value).InitAnnotation(this);
			}

			// Token: 0x0600046E RID: 1134 RVA: 0x0001B8CC File Offset: 0x00019ACC
			public override TaskReader.ExpressionReader LogoutWatcher(TaskReader.ExpressionReader last)
			{
				if (last.VisitProperty())
				{
					last = last.IncludeProperty();
				}
				if (last.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(this.paramsReader.filterReader >> ((TaskReader.ExporterPolicyPolicy)last).paramsReader.filterReader);
				}
				if (!last.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)last).SelectAnnotation(this);
			}

			// Token: 0x0600046F RID: 1135 RVA: 0x0001B930 File Offset: 0x00019B30
			public override TaskReader.ExpressionReader UpdateWatcher(TaskReader.ExpressionReader v)
			{
				if (v.VisitProperty())
				{
					v = v.IncludeProperty();
				}
				if (v.CalculateRule())
				{
					return new TaskReader.ExporterPolicyPolicy(this.paramsReader.m_StubReader >> ((TaskReader.ExporterPolicyPolicy)v).paramsReader.filterReader);
				}
				if (!v.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)v).ResetAnnotation(this);
			}

			// Token: 0x06000470 RID: 1136 RVA: 0x0001B994 File Offset: 0x00019B94
			public override string ToString()
			{
				TaskReader.XmlReadMode utilsReader = this._UtilsReader;
				switch (utilsReader)
				{
				case (TaskReader.XmlReadMode)1:
				case (TaskReader.XmlReadMode)3:
				case (TaskReader.XmlReadMode)5:
					goto IL_3B;
				case (TaskReader.XmlReadMode)2:
				case (TaskReader.XmlReadMode)4:
					break;
				default:
					if (utilsReader == (TaskReader.XmlReadMode)11)
					{
						goto IL_3B;
					}
					break;
				}
				return this.paramsReader.m_StubReader.ToString();
				IL_3B:
				return this.paramsReader.filterReader.ToString();
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x000038B2 File Offset: 0x00001AB2
			internal override TaskReader.ExpressionReader IncludeProperty()
			{
				return this;
			}

			// Token: 0x06000472 RID: 1138 RVA: 0x000038BF File Offset: 0x00001ABF
			internal override bool RunProperty()
			{
				return true;
			}

			// Token: 0x06000473 RID: 1139 RVA: 0x0001B9EC File Offset: 0x00019BEC
			internal override bool ResolveProperty(TaskReader.ExpressionReader instance)
			{
				if (instance.UpdateRule())
				{
					return ((TaskReader.CandidateReader)instance).ResolveProperty(this);
				}
				if (instance.VisitProperty())
				{
					return ((TaskReader.MockReader)instance).ResolveProperty(this);
				}
				TaskReader.ExpressionReader expressionReader = instance.IncludeProperty();
				if (!expressionReader.RunProperty())
				{
					return false;
				}
				if (expressionReader.ResolveRule())
				{
					return false;
				}
				if (!expressionReader.CalculateRule())
				{
					return ((TaskReader.WorkerAuthenticationReader)expressionReader).ResolveProperty(this);
				}
				return this.paramsReader.filterReader == ((TaskReader.ExporterPolicyPolicy)expressionReader).paramsReader.filterReader;
			}

			// Token: 0x06000474 RID: 1140 RVA: 0x00016DBC File Offset: 0x00014FBC
			private static TaskReader.ModelAuthenticationReader SetupAnnotation(TaskReader.ExpressionReader init)
			{
				TaskReader.ModelAuthenticationReader modelAuthenticationReader = init as TaskReader.ModelAuthenticationReader;
				if (modelAuthenticationReader == null && init.VisitProperty())
				{
					modelAuthenticationReader = (init.IncludeProperty() as TaskReader.ModelAuthenticationReader);
				}
				return modelAuthenticationReader;
			}

			// Token: 0x06000475 RID: 1141 RVA: 0x0001BA70 File Offset: 0x00019C70
			internal override bool CancelProperty(TaskReader.ExpressionReader var1)
			{
				if (var1.UpdateRule())
				{
					return false;
				}
				if (var1.VisitProperty())
				{
					return ((TaskReader.MockReader)var1).CancelProperty(this);
				}
				TaskReader.ExpressionReader expressionReader = var1.IncludeProperty();
				if (!expressionReader.RunProperty())
				{
					return false;
				}
				if (expressionReader.ResolveRule())
				{
					return false;
				}
				if (expressionReader.CalculateRule())
				{
					return this.paramsReader.m_StubReader != ((TaskReader.ExporterPolicyPolicy)expressionReader).paramsReader.m_StubReader;
				}
				return ((TaskReader.WorkerAuthenticationReader)expressionReader).CancelProperty(this);
			}

			// Token: 0x06000476 RID: 1142 RVA: 0x0001BAEC File Offset: 0x00019CEC
			public override bool CalculateWatcher(TaskReader.ExpressionReader asset)
			{
				if (asset.VisitProperty())
				{
					asset = asset.IncludeProperty();
				}
				if (asset.CalculateRule())
				{
					return this.paramsReader.filterReader >= ((TaskReader.ExporterPolicyPolicy)asset).paramsReader.filterReader;
				}
				if (!asset.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)asset).ViewWatcher(this);
			}

			// Token: 0x06000477 RID: 1143 RVA: 0x0001BB4C File Offset: 0x00019D4C
			public override bool PatchWatcher(TaskReader.ExpressionReader key)
			{
				if (key.VisitProperty())
				{
					key = key.IncludeProperty();
				}
				if (key.CalculateRule())
				{
					return this.paramsReader.m_StubReader >= ((TaskReader.ExporterPolicyPolicy)key).paramsReader.m_StubReader;
				}
				if (!key.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)key).IncludeWatcher(this);
			}

			// Token: 0x06000478 RID: 1144 RVA: 0x0001BBAC File Offset: 0x00019DAC
			public override bool ResolveWatcher(TaskReader.ExpressionReader def)
			{
				if (def.VisitProperty())
				{
					def = def.IncludeProperty();
				}
				if (def.CalculateRule())
				{
					return this.paramsReader.filterReader > ((TaskReader.ExporterPolicyPolicy)def).paramsReader.filterReader;
				}
				if (!def.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)def).RunWatcher(this);
			}

			// Token: 0x06000479 RID: 1145 RVA: 0x0001BC0C File Offset: 0x00019E0C
			public override bool CancelWatcher(TaskReader.ExpressionReader spec)
			{
				if (spec.VisitProperty())
				{
					spec = spec.IncludeProperty();
				}
				if (spec.CalculateRule())
				{
					return this.paramsReader.m_StubReader > ((TaskReader.ExporterPolicyPolicy)spec).paramsReader.m_StubReader;
				}
				if (!spec.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)spec).FindWatcher(this);
			}

			// Token: 0x0600047A RID: 1146 RVA: 0x0001BC6C File Offset: 0x00019E6C
			public override bool ViewWatcher(TaskReader.ExpressionReader spec)
			{
				if (spec.VisitProperty())
				{
					spec = spec.IncludeProperty();
				}
				if (spec.CalculateRule())
				{
					return this.paramsReader.filterReader <= ((TaskReader.ExporterPolicyPolicy)spec).paramsReader.filterReader;
				}
				if (!spec.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)spec).CalculateWatcher(this);
			}

			// Token: 0x0600047B RID: 1147 RVA: 0x0001BCCC File Offset: 0x00019ECC
			public override bool IncludeWatcher(TaskReader.ExpressionReader setup)
			{
				if (setup.VisitProperty())
				{
					setup = setup.IncludeProperty();
				}
				if (setup.CalculateRule())
				{
					return this.paramsReader.m_StubReader <= ((TaskReader.ExporterPolicyPolicy)setup).paramsReader.m_StubReader;
				}
				if (!setup.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)setup).PatchWatcher(this);
			}

			// Token: 0x0600047C RID: 1148 RVA: 0x0001BD2C File Offset: 0x00019F2C
			public override bool RunWatcher(TaskReader.ExpressionReader first)
			{
				if (first.VisitProperty())
				{
					first = first.IncludeProperty();
				}
				if (first.CalculateRule())
				{
					return this.paramsReader.filterReader < ((TaskReader.ExporterPolicyPolicy)first).paramsReader.filterReader;
				}
				if (!first.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)first).ResolveWatcher(this);
			}

			// Token: 0x0600047D RID: 1149 RVA: 0x0001BD8C File Offset: 0x00019F8C
			public override bool FindWatcher(TaskReader.ExpressionReader res)
			{
				if (res.VisitProperty())
				{
					res = res.IncludeProperty();
				}
				if (res.CalculateRule())
				{
					return this.paramsReader.m_StubReader < ((TaskReader.ExporterPolicyPolicy)res).paramsReader.m_StubReader;
				}
				if (!res.PatchRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return ((TaskReader.WorkerAuthenticationReader)res).CancelWatcher(this);
			}

			// Token: 0x0600047E RID: 1150 RVA: 0x000049EE File Offset: 0x00002BEE
			internal static bool FlushRecord()
			{
				return TaskReader.ExporterPolicyPolicy.InstantiateRecord == null;
			}

			// Token: 0x04000234 RID: 564
			public TaskReader.CustomerSingletonDispatcher paramsReader;

			// Token: 0x04000235 RID: 565
			public TaskReader.XmlReadMode _UtilsReader;

			// Token: 0x04000236 RID: 566
			internal static object InstantiateRecord;
		}

		// Token: 0x02000082 RID: 130
		private class IssuerInvocationRecord : TaskReader.ModelAuthenticationReader
		{
			// Token: 0x0600047F RID: 1151 RVA: 0x000049F8 File Offset: 0x00002BF8
			internal override void FindProperty(TaskReader.ExpressionReader instance)
			{
				this.m_ParserReader = ((TaskReader.IssuerInvocationRecord)instance).m_ParserReader;
				this.parameterReader = ((TaskReader.IssuerInvocationRecord)instance).parameterReader;
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x000037E9 File Offset: 0x000019E9
			internal override void UpdateProperty(TaskReader.ExpressionReader def)
			{
				this.FindProperty(def);
			}

			// Token: 0x06000481 RID: 1153 RVA: 0x00004A1C File Offset: 0x00002C1C
			public IssuerInvocationRecord(double i)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)5;
				this.parameterReader = (TaskReader.XmlReadMode)10;
				this.m_ParserReader = i;
			}

			// Token: 0x06000482 RID: 1154 RVA: 0x00004A3F File Offset: 0x00002C3F
			public IssuerInvocationRecord(TaskReader.IssuerInvocationRecord first)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = first.m_ComparatorReader;
				this.parameterReader = first.parameterReader;
				this.m_ParserReader = first.m_ParserReader;
			}

			// Token: 0x06000483 RID: 1155 RVA: 0x00004A70 File Offset: 0x00002C70
			public override TaskReader.ModelAuthenticationReader NewWatcher()
			{
				return new TaskReader.IssuerInvocationRecord(this);
			}

			// Token: 0x06000484 RID: 1156 RVA: 0x00004A78 File Offset: 0x00002C78
			public IssuerInvocationRecord(double info, TaskReader.XmlReadMode second)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)5;
				this.m_ParserReader = info;
				this.parameterReader = second;
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x00004A9A File Offset: 0x00002C9A
			public IssuerInvocationRecord(float item)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)5;
				this.m_ParserReader = (double)item;
				this.parameterReader = (TaskReader.XmlReadMode)9;
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x00004ABE File Offset: 0x00002CBE
			public IssuerInvocationRecord(float i, TaskReader.XmlReadMode cont)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this.m_ComparatorReader = (TaskReader.CMSSECTIONID)5;
				this.m_ParserReader = (double)i;
				this.parameterReader = cont;
			}

			// Token: 0x06000487 RID: 1159 RVA: 0x00004AE1 File Offset: 0x00002CE1
			public override bool ConcatProperty()
			{
				return this.m_ParserReader == 0.0;
			}

			// Token: 0x06000488 RID: 1160 RVA: 0x00003A14 File Offset: 0x00001C14
			public override bool MapProperty()
			{
				return !this.ConcatProperty();
			}

			// Token: 0x06000489 RID: 1161 RVA: 0x00004AF4 File Offset: 0x00002CF4
			public override string ToString()
			{
				return this.m_ParserReader.ToString();
			}

			// Token: 0x0600048A RID: 1162 RVA: 0x0001BDEC File Offset: 0x00019FEC
			public override TaskReader.ExpressionReader ReadProperty(TaskReader.XmlReadMode setup)
			{
				switch (setup)
				{
				case (TaskReader.XmlReadMode)1:
					return this.RevertProperty();
				case (TaskReader.XmlReadMode)2:
					return this.QueryWatcher();
				case (TaskReader.XmlReadMode)3:
					return this.AddWatcher();
				case (TaskReader.XmlReadMode)4:
					return this.ExcludeWatcher();
				case (TaskReader.XmlReadMode)5:
					return this.InstantiateWatcher();
				case (TaskReader.XmlReadMode)6:
					return this.InterruptWatcher();
				case (TaskReader.XmlReadMode)7:
					return this.PushWatcher();
				case (TaskReader.XmlReadMode)8:
					return this.StartWatcher();
				case (TaskReader.XmlReadMode)9:
					return this.ManageWatcher();
				case (TaskReader.XmlReadMode)10:
					return this.CompareWatcher();
				case (TaskReader.XmlReadMode)11:
					return this.ForgotProperty();
				default:
					throw new Exception("truncation not supported");
				}
			}

			// Token: 0x0600048B RID: 1163 RVA: 0x0001BE88 File Offset: 0x0001A088
			internal override object PatchProperty(Type param)
			{
				if (param != null && param.IsByRef)
				{
					param = param.GetElementType();
				}
				if (param == typeof(float))
				{
					return (float)this.m_ParserReader;
				}
				if (param == typeof(double))
				{
					return this.m_ParserReader;
				}
				if ((param == null || param == typeof(object)) && this.parameterReader == (TaskReader.XmlReadMode)9)
				{
					return (float)this.m_ParserReader;
				}
				return this.m_ParserReader;
			}

			// Token: 0x0600048C RID: 1164 RVA: 0x00004B01 File Offset: 0x00002D01
			public override TaskReader.ExporterPolicyPolicy ForgotProperty()
			{
				return new TaskReader.ExporterPolicyPolicy((!this.ConcatProperty()) ? 0 : 1);
			}

			// Token: 0x0600048D RID: 1165 RVA: 0x00003A32 File Offset: 0x00001C32
			internal override bool ViewProperty()
			{
				return this.MapProperty();
			}

			// Token: 0x0600048E RID: 1166 RVA: 0x00004B14 File Offset: 0x00002D14
			public override TaskReader.ExporterPolicyPolicy RevertProperty()
			{
				return new TaskReader.ExporterPolicyPolicy((int)((sbyte)this.m_ParserReader), (TaskReader.XmlReadMode)1);
			}

			// Token: 0x0600048F RID: 1167 RVA: 0x00004B23 File Offset: 0x00002D23
			public override TaskReader.ExporterPolicyPolicy QueryWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((uint)((byte)this.m_ParserReader), (TaskReader.XmlReadMode)2);
			}

			// Token: 0x06000490 RID: 1168 RVA: 0x00004B32 File Offset: 0x00002D32
			public override TaskReader.ExporterPolicyPolicy AddWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)((short)this.m_ParserReader), (TaskReader.XmlReadMode)3);
			}

			// Token: 0x06000491 RID: 1169 RVA: 0x00004B41 File Offset: 0x00002D41
			public override TaskReader.ExporterPolicyPolicy ExcludeWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((uint)((ushort)this.m_ParserReader), (TaskReader.XmlReadMode)4);
			}

			// Token: 0x06000492 RID: 1170 RVA: 0x00004B50 File Offset: 0x00002D50
			public override TaskReader.ExporterPolicyPolicy InstantiateWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)this.m_ParserReader, (TaskReader.XmlReadMode)5);
			}

			// Token: 0x06000493 RID: 1171 RVA: 0x00004B5F File Offset: 0x00002D5F
			public override TaskReader.ExporterPolicyPolicy InterruptWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((uint)this.m_ParserReader, (TaskReader.XmlReadMode)6);
			}

			// Token: 0x06000494 RID: 1172 RVA: 0x00004B6E File Offset: 0x00002D6E
			public override TaskReader.AlgoReader PushWatcher()
			{
				return new TaskReader.AlgoReader((long)this.m_ParserReader, (TaskReader.XmlReadMode)7);
			}

			// Token: 0x06000495 RID: 1173 RVA: 0x00004B7D File Offset: 0x00002D7D
			public override TaskReader.AlgoReader StartWatcher()
			{
				return new TaskReader.AlgoReader((ulong)this.m_ParserReader, (TaskReader.XmlReadMode)8);
			}

			// Token: 0x06000496 RID: 1174 RVA: 0x00003AE6 File Offset: 0x00001CE6
			public override TaskReader.ExporterPolicyPolicy PublishWatcher()
			{
				return this.RevertProperty();
			}

			// Token: 0x06000497 RID: 1175 RVA: 0x00003AEE File Offset: 0x00001CEE
			public override TaskReader.ExporterPolicyPolicy ResetWatcher()
			{
				return this.AddWatcher();
			}

			// Token: 0x06000498 RID: 1176 RVA: 0x00003AF6 File Offset: 0x00001CF6
			public override TaskReader.ExporterPolicyPolicy SelectWatcher()
			{
				return this.InstantiateWatcher();
			}

			// Token: 0x06000499 RID: 1177 RVA: 0x00003AFE File Offset: 0x00001CFE
			public override TaskReader.AlgoReader InitWatcher()
			{
				return this.PushWatcher();
			}

			// Token: 0x0600049A RID: 1178 RVA: 0x00003B06 File Offset: 0x00001D06
			public override TaskReader.ExporterPolicyPolicy PrintWatcher()
			{
				return this.QueryWatcher();
			}

			// Token: 0x0600049B RID: 1179 RVA: 0x00003B0E File Offset: 0x00001D0E
			public override TaskReader.ExporterPolicyPolicy CountWatcher()
			{
				return this.ExcludeWatcher();
			}

			// Token: 0x0600049C RID: 1180 RVA: 0x00003B16 File Offset: 0x00001D16
			public override TaskReader.ExporterPolicyPolicy StopWatcher()
			{
				return this.InterruptWatcher();
			}

			// Token: 0x0600049D RID: 1181 RVA: 0x00003B1E File Offset: 0x00001D1E
			public override TaskReader.AlgoReader MoveWatcher()
			{
				return this.StartWatcher();
			}

			// Token: 0x0600049E RID: 1182 RVA: 0x00004B8C File Offset: 0x00002D8C
			public override TaskReader.ExporterPolicyPolicy SearchWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((sbyte)this.m_ParserReader)), (TaskReader.XmlReadMode)1);
			}

			// Token: 0x0600049F RID: 1183 RVA: 0x00004B8C File Offset: 0x00002D8C
			public override TaskReader.ExporterPolicyPolicy ConnectWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((sbyte)this.m_ParserReader)), (TaskReader.XmlReadMode)1);
			}

			// Token: 0x060004A0 RID: 1184 RVA: 0x00004B9B File Offset: 0x00002D9B
			public override TaskReader.ExporterPolicyPolicy SetupWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((short)this.m_ParserReader)), (TaskReader.XmlReadMode)3);
			}

			// Token: 0x060004A1 RID: 1185 RVA: 0x00004B9B File Offset: 0x00002D9B
			public override TaskReader.ExporterPolicyPolicy GetWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((short)this.m_ParserReader)), (TaskReader.XmlReadMode)3);
			}

			// Token: 0x060004A2 RID: 1186 RVA: 0x00004BAA File Offset: 0x00002DAA
			public override TaskReader.ExporterPolicyPolicy PostWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(checked((int)this.m_ParserReader), (TaskReader.XmlReadMode)5);
			}

			// Token: 0x060004A3 RID: 1187 RVA: 0x00004BAA File Offset: 0x00002DAA
			public override TaskReader.ExporterPolicyPolicy OrderWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(checked((int)this.m_ParserReader), (TaskReader.XmlReadMode)5);
			}

			// Token: 0x060004A4 RID: 1188 RVA: 0x00004BB9 File Offset: 0x00002DB9
			public override TaskReader.AlgoReader AssetWatcher()
			{
				return new TaskReader.AlgoReader(checked((long)this.m_ParserReader), (TaskReader.XmlReadMode)7);
			}

			// Token: 0x060004A5 RID: 1189 RVA: 0x00004BB9 File Offset: 0x00002DB9
			public override TaskReader.AlgoReader DefineWatcher()
			{
				return new TaskReader.AlgoReader(checked((long)this.m_ParserReader), (TaskReader.XmlReadMode)7);
			}

			// Token: 0x060004A6 RID: 1190 RVA: 0x00004BC8 File Offset: 0x00002DC8
			public override TaskReader.ExporterPolicyPolicy CollectWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((byte)this.m_ParserReader)), (TaskReader.XmlReadMode)2);
			}

			// Token: 0x060004A7 RID: 1191 RVA: 0x00004BC8 File Offset: 0x00002DC8
			public override TaskReader.ExporterPolicyPolicy ListWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((byte)this.m_ParserReader)), (TaskReader.XmlReadMode)2);
			}

			// Token: 0x060004A8 RID: 1192 RVA: 0x00004BD7 File Offset: 0x00002DD7
			public override TaskReader.ExporterPolicyPolicy RestartWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((ushort)this.m_ParserReader)), (TaskReader.XmlReadMode)4);
			}

			// Token: 0x060004A9 RID: 1193 RVA: 0x00004BD7 File Offset: 0x00002DD7
			public override TaskReader.ExporterPolicyPolicy ReflectWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy((int)(checked((ushort)this.m_ParserReader)), (TaskReader.XmlReadMode)4);
			}

			// Token: 0x060004AA RID: 1194 RVA: 0x00004BE6 File Offset: 0x00002DE6
			public override TaskReader.ExporterPolicyPolicy InsertWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(checked((uint)this.m_ParserReader), (TaskReader.XmlReadMode)6);
			}

			// Token: 0x060004AB RID: 1195 RVA: 0x00004BE6 File Offset: 0x00002DE6
			public override TaskReader.ExporterPolicyPolicy RemoveWatcher()
			{
				return new TaskReader.ExporterPolicyPolicy(checked((uint)this.m_ParserReader), (TaskReader.XmlReadMode)6);
			}

			// Token: 0x060004AC RID: 1196 RVA: 0x00004BF5 File Offset: 0x00002DF5
			public override TaskReader.AlgoReader RegisterWatcher()
			{
				return new TaskReader.AlgoReader(checked((ulong)this.m_ParserReader), (TaskReader.XmlReadMode)8);
			}

			// Token: 0x060004AD RID: 1197 RVA: 0x00004BF5 File Offset: 0x00002DF5
			public override TaskReader.AlgoReader WriteWatcher()
			{
				return new TaskReader.AlgoReader(checked((ulong)this.m_ParserReader), (TaskReader.XmlReadMode)8);
			}

			// Token: 0x060004AE RID: 1198 RVA: 0x00004C04 File Offset: 0x00002E04
			public override TaskReader.IssuerInvocationRecord ManageWatcher()
			{
				return new TaskReader.IssuerInvocationRecord((float)this.m_ParserReader, (TaskReader.XmlReadMode)9);
			}

			// Token: 0x060004AF RID: 1199 RVA: 0x00004C14 File Offset: 0x00002E14
			public override TaskReader.IssuerInvocationRecord CompareWatcher()
			{
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader, (TaskReader.XmlReadMode)10);
			}

			// Token: 0x060004B0 RID: 1200 RVA: 0x00004C24 File Offset: 0x00002E24
			public override TaskReader.IssuerInvocationRecord ComputeWatcher()
			{
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader);
			}

			// Token: 0x060004B1 RID: 1201 RVA: 0x00003C78 File Offset: 0x00001E78
			public override TaskReader.WorkerAuthenticationReader SortWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.InitWatcher()._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)this.SelectWatcher().paramsReader.filterReader);
			}

			// Token: 0x060004B2 RID: 1202 RVA: 0x00003CAE File Offset: 0x00001EAE
			public override TaskReader.WorkerAuthenticationReader ChangeWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.MoveWatcher()._IteratorReader.roleReader);
				}
				return new TaskReader.WorkerAuthenticationReader((ulong)this.StopWatcher().paramsReader.m_StubReader);
			}

			// Token: 0x060004B3 RID: 1203 RVA: 0x00003CE4 File Offset: 0x00001EE4
			public override TaskReader.WorkerAuthenticationReader LoginWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.AssetWatcher()._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)this.PostWatcher().paramsReader.filterReader);
			}

			// Token: 0x060004B4 RID: 1204 RVA: 0x00003D1A File Offset: 0x00001F1A
			public override TaskReader.WorkerAuthenticationReader SetWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.RegisterWatcher()._IteratorReader.roleReader);
				}
				return new TaskReader.WorkerAuthenticationReader((ulong)this.InsertWatcher().paramsReader.m_StubReader);
			}

			// Token: 0x060004B5 RID: 1205 RVA: 0x00003D50 File Offset: 0x00001F50
			public override TaskReader.WorkerAuthenticationReader AwakeWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.DefineWatcher()._IteratorReader._InterpreterReader);
				}
				return new TaskReader.WorkerAuthenticationReader((long)this.OrderWatcher().paramsReader.filterReader);
			}

			// Token: 0x060004B6 RID: 1206 RVA: 0x0000425D File Offset: 0x0000245D
			public override TaskReader.WorkerAuthenticationReader CustomizeWatcher()
			{
				if (IntPtr.Size == 8)
				{
					return new TaskReader.WorkerAuthenticationReader(this.WriteWatcher()._IteratorReader.roleReader);
				}
				return new TaskReader.WorkerAuthenticationReader((ulong)this.RemoveWatcher().paramsReader.m_StubReader);
			}

			// Token: 0x060004B7 RID: 1207 RVA: 0x00004C32 File Offset: 0x00002E32
			public override TaskReader.ExpressionReader InvokeWatcher()
			{
				if (this.parameterReader == (TaskReader.XmlReadMode)9)
				{
					return new TaskReader.IssuerInvocationRecord((float)(-(float)this.m_ParserReader));
				}
				return new TaskReader.IssuerInvocationRecord(-this.m_ParserReader);
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x00004C59 File Offset: 0x00002E59
			public override TaskReader.ExpressionReader CreateWatcher(TaskReader.ExpressionReader config)
			{
				if (config.VisitProperty())
				{
					config = config.IncludeProperty();
				}
				if (!config.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader + ((TaskReader.IssuerInvocationRecord)config).m_ParserReader);
			}

			// Token: 0x060004B9 RID: 1209 RVA: 0x00004C59 File Offset: 0x00002E59
			public override TaskReader.ExpressionReader FlushWatcher(TaskReader.ExpressionReader item)
			{
				if (item.VisitProperty())
				{
					item = item.IncludeProperty();
				}
				if (!item.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader + ((TaskReader.IssuerInvocationRecord)item).m_ParserReader);
			}

			// Token: 0x060004BA RID: 1210 RVA: 0x00004C59 File Offset: 0x00002E59
			public override TaskReader.ExpressionReader CalcWatcher(TaskReader.ExpressionReader value)
			{
				if (value.VisitProperty())
				{
					value = value.IncludeProperty();
				}
				if (!value.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader + ((TaskReader.IssuerInvocationRecord)value).m_ParserReader);
			}

			// Token: 0x060004BB RID: 1211 RVA: 0x00004C90 File Offset: 0x00002E90
			public override TaskReader.ExpressionReader PrepareWatcher(TaskReader.ExpressionReader last)
			{
				if (last.VisitProperty())
				{
					last = last.IncludeProperty();
				}
				if (!last.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader - ((TaskReader.IssuerInvocationRecord)last).m_ParserReader);
			}

			// Token: 0x060004BC RID: 1212 RVA: 0x00004C90 File Offset: 0x00002E90
			public override TaskReader.ExpressionReader DeleteWatcher(TaskReader.ExpressionReader instance)
			{
				if (instance.VisitProperty())
				{
					instance = instance.IncludeProperty();
				}
				if (!instance.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader - ((TaskReader.IssuerInvocationRecord)instance).m_ParserReader);
			}

			// Token: 0x060004BD RID: 1213 RVA: 0x00004C90 File Offset: 0x00002E90
			public override TaskReader.ExpressionReader CallWatcher(TaskReader.ExpressionReader i)
			{
				if (i.VisitProperty())
				{
					i = i.IncludeProperty();
				}
				if (!i.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader - ((TaskReader.IssuerInvocationRecord)i).m_ParserReader);
			}

			// Token: 0x060004BE RID: 1214 RVA: 0x00004CC7 File Offset: 0x00002EC7
			public override TaskReader.ExpressionReader RateWatcher(TaskReader.ExpressionReader key)
			{
				if (key.VisitProperty())
				{
					key = key.IncludeProperty();
				}
				if (!key.CancelRule() || !key.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader * ((TaskReader.IssuerInvocationRecord)key).m_ParserReader);
			}

			// Token: 0x060004BF RID: 1215 RVA: 0x00004D06 File Offset: 0x00002F06
			public override TaskReader.ExpressionReader ValidateWatcher(TaskReader.ExpressionReader config)
			{
				if (config.VisitProperty())
				{
					config = config.IncludeProperty();
				}
				if (!config.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader * ((TaskReader.IssuerInvocationRecord)config).m_ParserReader);
			}

			// Token: 0x060004C0 RID: 1216 RVA: 0x00004D06 File Offset: 0x00002F06
			public override TaskReader.ExpressionReader VerifyWatcher(TaskReader.ExpressionReader config)
			{
				if (config.VisitProperty())
				{
					config = config.IncludeProperty();
				}
				if (!config.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader * ((TaskReader.IssuerInvocationRecord)config).m_ParserReader);
			}

			// Token: 0x060004C1 RID: 1217 RVA: 0x00004D3D File Offset: 0x00002F3D
			public override TaskReader.ExpressionReader PopWatcher(TaskReader.ExpressionReader i)
			{
				if (i.VisitProperty())
				{
					i = i.IncludeProperty();
				}
				if (!i.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader / ((TaskReader.IssuerInvocationRecord)i).m_ParserReader);
			}

			// Token: 0x060004C2 RID: 1218 RVA: 0x00004D3D File Offset: 0x00002F3D
			public override TaskReader.ExpressionReader FillWatcher(TaskReader.ExpressionReader value)
			{
				if (value.VisitProperty())
				{
					value = value.IncludeProperty();
				}
				if (!value.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader / ((TaskReader.IssuerInvocationRecord)value).m_ParserReader);
			}

			// Token: 0x060004C3 RID: 1219 RVA: 0x00004D74 File Offset: 0x00002F74
			public override TaskReader.ExpressionReader DisableWatcher(TaskReader.ExpressionReader param)
			{
				if (param.VisitProperty())
				{
					param = param.IncludeProperty();
				}
				if (!param.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader % ((TaskReader.IssuerInvocationRecord)param).m_ParserReader);
			}

			// Token: 0x060004C4 RID: 1220 RVA: 0x00004D74 File Offset: 0x00002F74
			public override TaskReader.ExpressionReader EnableWatcher(TaskReader.ExpressionReader first)
			{
				if (first.VisitProperty())
				{
					first = first.IncludeProperty();
				}
				if (!first.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return new TaskReader.IssuerInvocationRecord(this.m_ParserReader % ((TaskReader.IssuerInvocationRecord)first).m_ParserReader);
			}

			// Token: 0x060004C5 RID: 1221 RVA: 0x00004DAB File Offset: 0x00002FAB
			public override TaskReader.ExpressionReader CheckWatcher(TaskReader.ExpressionReader instance)
			{
				throw new TaskReader.IndexerReader();
			}

			// Token: 0x060004C6 RID: 1222 RVA: 0x00004DAB File Offset: 0x00002FAB
			public override TaskReader.ExpressionReader TestWatcher(TaskReader.ExpressionReader reference)
			{
				throw new TaskReader.IndexerReader();
			}

			// Token: 0x060004C7 RID: 1223 RVA: 0x00004DAB File Offset: 0x00002FAB
			public override TaskReader.ExpressionReader DestroyWatcher()
			{
				throw new TaskReader.IndexerReader();
			}

			// Token: 0x060004C8 RID: 1224 RVA: 0x00004DAB File Offset: 0x00002FAB
			public override TaskReader.ExpressionReader CloneWatcher(TaskReader.ExpressionReader v)
			{
				throw new TaskReader.IndexerReader();
			}

			// Token: 0x060004C9 RID: 1225 RVA: 0x00004DAB File Offset: 0x00002FAB
			public override TaskReader.ExpressionReader VisitWatcher(TaskReader.ExpressionReader instance)
			{
				throw new TaskReader.IndexerReader();
			}

			// Token: 0x060004CA RID: 1226 RVA: 0x00004DAB File Offset: 0x00002FAB
			public override TaskReader.ExpressionReader LogoutWatcher(TaskReader.ExpressionReader item)
			{
				throw new TaskReader.IndexerReader();
			}

			// Token: 0x060004CB RID: 1227 RVA: 0x00004DAB File Offset: 0x00002FAB
			public override TaskReader.ExpressionReader UpdateWatcher(TaskReader.ExpressionReader param)
			{
				throw new TaskReader.IndexerReader();
			}

			// Token: 0x060004CC RID: 1228 RVA: 0x000038B2 File Offset: 0x00001AB2
			internal override TaskReader.ExpressionReader IncludeProperty()
			{
				return this;
			}

			// Token: 0x060004CD RID: 1229 RVA: 0x0001BF28 File Offset: 0x0001A128
			internal override bool ResolveProperty(TaskReader.ExpressionReader task)
			{
				if (task.UpdateRule())
				{
					return false;
				}
				if (task.VisitProperty())
				{
					return ((TaskReader.MockReader)task).ResolveProperty(this);
				}
				TaskReader.ExpressionReader expressionReader = task.IncludeProperty();
				return expressionReader.CancelRule() && this.m_ParserReader == ((TaskReader.IssuerInvocationRecord)expressionReader).m_ParserReader;
			}

			// Token: 0x060004CE RID: 1230 RVA: 0x0001BF78 File Offset: 0x0001A178
			internal override bool CancelProperty(TaskReader.ExpressionReader def)
			{
				if (def.UpdateRule())
				{
					return false;
				}
				if (def.VisitProperty())
				{
					return ((TaskReader.MockReader)def).CancelProperty(this);
				}
				TaskReader.ExpressionReader expressionReader = def.IncludeProperty();
				return expressionReader.CancelRule() && this.m_ParserReader != ((TaskReader.IssuerInvocationRecord)expressionReader).m_ParserReader;
			}

			// Token: 0x060004CF RID: 1231 RVA: 0x00004DB2 File Offset: 0x00002FB2
			public override bool CalculateWatcher(TaskReader.ExpressionReader v)
			{
				if (v.VisitProperty())
				{
					v = v.IncludeProperty();
				}
				if (!v.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this.m_ParserReader >= ((TaskReader.IssuerInvocationRecord)v).m_ParserReader;
			}

			// Token: 0x060004D0 RID: 1232 RVA: 0x00004DB2 File Offset: 0x00002FB2
			public override bool PatchWatcher(TaskReader.ExpressionReader key)
			{
				if (key.VisitProperty())
				{
					key = key.IncludeProperty();
				}
				if (!key.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this.m_ParserReader >= ((TaskReader.IssuerInvocationRecord)key).m_ParserReader;
			}

			// Token: 0x060004D1 RID: 1233 RVA: 0x00004DE8 File Offset: 0x00002FE8
			public override bool ResolveWatcher(TaskReader.ExpressionReader info)
			{
				if (info.VisitProperty())
				{
					info = info.IncludeProperty();
				}
				if (!info.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this.m_ParserReader > ((TaskReader.IssuerInvocationRecord)info).m_ParserReader;
			}

			// Token: 0x060004D2 RID: 1234 RVA: 0x00004DE8 File Offset: 0x00002FE8
			public override bool CancelWatcher(TaskReader.ExpressionReader spec)
			{
				if (spec.VisitProperty())
				{
					spec = spec.IncludeProperty();
				}
				if (!spec.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this.m_ParserReader > ((TaskReader.IssuerInvocationRecord)spec).m_ParserReader;
			}

			// Token: 0x060004D3 RID: 1235 RVA: 0x00004E1B File Offset: 0x0000301B
			public override bool ViewWatcher(TaskReader.ExpressionReader key)
			{
				if (key.VisitProperty())
				{
					key = key.IncludeProperty();
				}
				if (!key.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this.m_ParserReader <= ((TaskReader.IssuerInvocationRecord)key).m_ParserReader;
			}

			// Token: 0x060004D4 RID: 1236 RVA: 0x00004E1B File Offset: 0x0000301B
			public override bool IncludeWatcher(TaskReader.ExpressionReader task)
			{
				if (task.VisitProperty())
				{
					task = task.IncludeProperty();
				}
				if (!task.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this.m_ParserReader <= ((TaskReader.IssuerInvocationRecord)task).m_ParserReader;
			}

			// Token: 0x060004D5 RID: 1237 RVA: 0x00004E51 File Offset: 0x00003051
			public override bool RunWatcher(TaskReader.ExpressionReader last)
			{
				if (last.VisitProperty())
				{
					last = last.IncludeProperty();
				}
				if (!last.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this.m_ParserReader < ((TaskReader.IssuerInvocationRecord)last).m_ParserReader;
			}

			// Token: 0x060004D6 RID: 1238 RVA: 0x00004E51 File Offset: 0x00003051
			public override bool FindWatcher(TaskReader.ExpressionReader init)
			{
				if (init.VisitProperty())
				{
					init = init.IncludeProperty();
				}
				if (!init.CancelRule())
				{
					throw new TaskReader.IndexerReader();
				}
				return this.m_ParserReader < ((TaskReader.IssuerInvocationRecord)init).m_ParserReader;
			}

			// Token: 0x060004D7 RID: 1239 RVA: 0x00004E84 File Offset: 0x00003084
			internal static bool FindRecord()
			{
				return TaskReader.IssuerInvocationRecord.ResetRecord == null;
			}

			// Token: 0x04000237 RID: 567
			public double m_ParserReader;

			// Token: 0x04000238 RID: 568
			public TaskReader.XmlReadMode parameterReader;

			// Token: 0x04000239 RID: 569
			internal static object ResetRecord;
		}

		// Token: 0x02000083 RID: 131
		private class StrategyReader : Exception
		{
			// Token: 0x060004D8 RID: 1240 RVA: 0x00004E8E File Offset: 0x0000308E
			public StrategyReader(string var1)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor(var1);
			}

			// Token: 0x060004D9 RID: 1241 RVA: 0x00004E9C File Offset: 0x0000309C
			internal static bool RemoveRecord()
			{
				return TaskReader.StrategyReader.MapRecord == null;
			}

			// Token: 0x0400023A RID: 570
			internal static object MapRecord;
		}

		// Token: 0x02000084 RID: 132
		private class IndexerReader : Exception
		{
			// Token: 0x060004DA RID: 1242 RVA: 0x00004EA6 File Offset: 0x000030A6
			public IndexerReader()
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
			}

			// Token: 0x060004DB RID: 1243 RVA: 0x00004E8E File Offset: 0x0000308E
			public IndexerReader(string ident)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor(ident);
			}

			// Token: 0x060004DC RID: 1244 RVA: 0x00004EB3 File Offset: 0x000030B3
			internal static bool LoginRecord()
			{
				return TaskReader.IndexerReader.CollectRecord == null;
			}

			// Token: 0x0400023B RID: 571
			private static object CollectRecord;
		}

		// Token: 0x02000085 RID: 133
		private class ReaderSingletonObject
		{
			// Token: 0x060004DD RID: 1245 RVA: 0x00004EBD File Offset: 0x000030BD
			public ReaderSingletonObject(FieldInfo res, int connection)
			{
				AdvisorConnectionAttribute.CancelComposer();
				base..ctor();
				this._ItemReader = res;
				this.poolReader = connection;
			}

			// Token: 0x060004DE RID: 1246 RVA: 0x00004ED8 File Offset: 0x000030D8
			internal static bool SetupBridge()
			{
				return TaskReader.ReaderSingletonObject.RevertRecord == null;
			}

			// Token: 0x0400023C RID: 572
			internal object _ItemReader;

			// Token: 0x0400023D RID: 573
			internal int poolReader;

			// Token: 0x0400023E RID: 574
			private static object RevertRecord;
		}

		// Token: 0x02000086 RID: 134
		private class ParameterTemplateStatus
		{
			// Token: 0x060004DF RID: 1247 RVA: 0x00004EE2 File Offset: 0x000030E2
			public ParameterTemplateStatus(MethodBase asset, List<TaskReader.ReaderSingletonObject> visitor)
			{
				AdvisorConnectionAttribute.CancelComposer();
				this.mapperReader = new List<TaskReader.ReaderSingletonObject>();
				base..ctor();
				this.mapperReader = visitor;
				this.m_FieldReader = asset;
			}

			// Token: 0x060004E0 RID: 1248 RVA: 0x00004F08 File Offset: 0x00003108
			public ParameterTemplateStatus(MethodBase task, TaskReader.ReaderSingletonObject[] vis)
			{
				AdvisorConnectionAttribute.CancelComposer();
				this.mapperReader = new List<TaskReader.ReaderSingletonObject>();
				base..ctor();
				this.mapperReader.AddRange(vis);
			}

			// Token: 0x060004E1 RID: 1249 RVA: 0x0001BFCC File Offset: 0x0001A1CC
			public override bool Equals(object param)
			{
				TaskReader.ParameterTemplateStatus parameterTemplateStatus = param as TaskReader.ParameterTemplateStatus;
				if (param == null)
				{
					return false;
				}
				if (this.m_FieldReader != parameterTemplateStatus.m_FieldReader)
				{
					return false;
				}
				if (this.mapperReader.Count != parameterTemplateStatus.mapperReader.Count)
				{
					return false;
				}
				for (int i = 0; i < this.mapperReader.Count; i++)
				{
					if (this.mapperReader[i]._ItemReader != parameterTemplateStatus.mapperReader[i]._ItemReader)
					{
						return false;
					}
					if (this.mapperReader[i].poolReader != parameterTemplateStatus.mapperReader[i].poolReader)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x060004E2 RID: 1250 RVA: 0x0001C080 File Offset: 0x0001A280
			public override int GetHashCode()
			{
				int num = this.m_FieldReader.GetHashCode();
				foreach (TaskReader.ReaderSingletonObject readerSingletonObject in this.mapperReader)
				{
					int num2 = readerSingletonObject._ItemReader.GetHashCode() + readerSingletonObject.poolReader;
					num = (num ^ num2) + num2;
				}
				return num;
			}

			// Token: 0x060004E3 RID: 1251 RVA: 0x0001C0F4 File Offset: 0x0001A2F4
			public TaskReader.ReaderSingletonObject GetAnnotation(int columni)
			{
				foreach (TaskReader.ReaderSingletonObject readerSingletonObject in this.mapperReader)
				{
					if (readerSingletonObject.poolReader == columni)
					{
						return readerSingletonObject;
					}
				}
				return null;
			}

			// Token: 0x060004E4 RID: 1252 RVA: 0x0001C154 File Offset: 0x0001A354
			public bool PostAnnotation(int init_end)
			{
				using (List<TaskReader.ReaderSingletonObject>.Enumerator enumerator = this.mapperReader.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						TaskReader.ReaderSingletonObject readerSingletonObject = enumerator.Current;
						if (readerSingletonObject.poolReader == init_end)
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}

			// Token: 0x060004E5 RID: 1253 RVA: 0x00004F2C File Offset: 0x0000312C
			internal static bool CancelBridge()
			{
				return TaskReader.ParameterTemplateStatus.DestroyBridge == null;
			}

			// Token: 0x0400023F RID: 575
			private List<TaskReader.ReaderSingletonObject> mapperReader;

			// Token: 0x04000240 RID: 576
			private MethodBase m_FieldReader;

			// Token: 0x04000241 RID: 577
			private static object DestroyBridge;
		}

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060004E7 RID: 1255
		private delegate object RecordInstance(object target, object[] paramters);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060004EB RID: 1259
		private delegate object FacadeReader(object target);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060004EF RID: 1263
		private delegate void AdapterWatcherClass(IntPtr a, byte b, int c);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060004F3 RID: 1267
		private delegate void RepositoryInstance(IntPtr s, IntPtr t, uint c);

		// Token: 0x0200008B RID: 139
		internal class SingletonSingletonObject
		{
			// Token: 0x060004F6 RID: 1270 RVA: 0x0001C1B4 File Offset: 0x0001A3B4
			internal void OrderAnnotation()
			{
				bool flag = false;
				this.DefineAnnotation(ref flag);
			}

			// Token: 0x060004F7 RID: 1271 RVA: 0x0001C1CC File Offset: 0x0001A3CC
			internal void AssetAnnotation()
			{
				this._ComposerReader.PrintAnnotation();
				this._ListenerReader = null;
				if (this.serviceReader != null)
				{
					foreach (IntPtr hglobal in this.serviceReader)
					{
						try
						{
							Marshal.FreeHGlobal(hglobal);
						}
						catch
						{
						}
					}
					this.serviceReader.Clear();
					this.serviceReader = null;
				}
			}

			// Token: 0x060004F8 RID: 1272 RVA: 0x0001C25C File Offset: 0x0001A45C
			internal void DefineAnnotation(ref bool value)
			{
				while (this._RecordReader > -2)
				{
					if (this.queueReader)
					{
						this.queueReader = false;
						int num = this.repositoryReader;
						int recordReader = this._RecordReader;
						this.ListAnnotation(this.repositoryReader, this._RecordReader);
						this._RecordReader = recordReader;
						this.repositoryReader = num;
					}
					if (this.prototypeSingleton)
					{
						this.prototypeSingleton = false;
						return;
					}
					if (!this.procReader)
					{
						this.repositoryReader = this._RecordReader;
						TaskReader.FieldWatcherClass fieldWatcherClass = this.adapterReader._PublisherReader[this._RecordReader];
						this._ValueReader = fieldWatcherClass.m_ProducerReader;
						try
						{
							this.InsertAnnotation(fieldWatcherClass);
						}
						catch (Exception ex)
						{
							this._ProxyReader = ex;
							value = true;
							this._ComposerReader.PrintAnnotation();
							int num2 = this.repositoryReader;
							TaskReader.GlobalReader globalReader = this.RestartAnnotation(num2, ex);
							List<TaskReader.GlobalReader> list = this.ReflectAnnotation(num2, false);
							List<TaskReader.GlobalReader> list2 = new List<TaskReader.GlobalReader>();
							if (globalReader != null)
							{
								list2.Add(globalReader);
							}
							if (list != null && list.Count > 0)
							{
								list2.AddRange(list);
							}
							List<TaskReader.GlobalReader> list3 = list2;
							if (TaskReader.SingletonSingletonObject.m_ConnectionSingleton == null)
							{
								TaskReader.SingletonSingletonObject.m_ConnectionSingleton = new Comparison<TaskReader.GlobalReader>(TaskReader.SingletonSingletonObject.PopInfo);
							}
							list3.Sort(TaskReader.SingletonSingletonObject.m_ConnectionSingleton);
							TaskReader.GlobalReader globalReader2 = null;
							foreach (TaskReader.GlobalReader globalReader3 in list2)
							{
								if (globalReader3.m_FactoryReader.stateReader != 0)
								{
									this._ComposerReader.CountAnnotation(new TaskReader.CandidateReader(ex));
									this.repositoryReader = globalReader3.m_FactoryReader.m_ClassReader;
									this._RecordReader = this.repositoryReader;
									this.OrderAnnotation();
									if (!this._RefSingleton)
									{
										continue;
									}
									this._RefSingleton = false;
									globalReader2 = globalReader3;
								}
								else
								{
									globalReader2 = globalReader3;
								}
								break;
							}
							if (globalReader2 != null)
							{
								this._PageReader = globalReader2.m_FactoryReader.setterReader;
								this.CollectAnnotation(num2, globalReader2.m_FactoryReader.setterReader);
								if (this._PageReader >= 0)
								{
									this._ComposerReader.CountAnnotation(new TaskReader.CandidateReader(ex));
									this.repositoryReader = this._PageReader;
									this._RecordReader = this.repositoryReader;
									this._PageReader = -1;
									this.OrderAnnotation();
								}
								return;
							}
							throw ex;
						}
						this._RecordReader++;
						continue;
					}
					this.procReader = false;
					return;
				}
				this._ComposerReader.PrintAnnotation();
			}

			// Token: 0x060004F9 RID: 1273 RVA: 0x0001C4EC File Offset: 0x0001A6EC
			internal void CollectAnnotation(int idx_reference, int max_connection)
			{
				if (this.adapterReader.m_ValReader != null)
				{
					foreach (TaskReader.GlobalReader globalReader in this.adapterReader.m_ValReader)
					{
						if ((globalReader.m_FactoryReader.stateReader == 4 || globalReader.m_FactoryReader.stateReader == 2) && globalReader.m_FactoryReader.setterReader >= idx_reference && globalReader.m_FactoryReader.methodReader <= max_connection)
						{
							this.repositoryReader = globalReader.m_FactoryReader.setterReader;
							this._RecordReader = this.repositoryReader;
							bool flag = false;
							this.DefineAnnotation(ref flag);
							if (flag)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060004FA RID: 1274 RVA: 0x0001C5B4 File Offset: 0x0001A7B4
			internal void ListAnnotation(int next_var1, int vis_Ptr)
			{
				if (this.adapterReader.m_ValReader != null)
				{
					foreach (TaskReader.GlobalReader globalReader in this.adapterReader.m_ValReader)
					{
						if (globalReader.m_FactoryReader.stateReader == 2 && globalReader.m_FactoryReader.setterReader >= next_var1 && globalReader.m_FactoryReader.methodReader <= vis_Ptr)
						{
							this.repositoryReader = globalReader.m_FactoryReader.setterReader;
							this._RecordReader = this.repositoryReader;
							bool flag = false;
							this.DefineAnnotation(ref flag);
							if (flag)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060004FB RID: 1275 RVA: 0x0001C66C File Offset: 0x0001A86C
			internal TaskReader.GlobalReader RestartAnnotation(int i_high, Exception vis)
			{
				TaskReader.GlobalReader globalReader = null;
				if (this.adapterReader.m_ValReader != null)
				{
					foreach (TaskReader.GlobalReader globalReader2 in this.adapterReader.m_ValReader)
					{
						if (globalReader2.m_FactoryReader.stateReader == 0 && (globalReader2.m_FactoryReader._AccountReader == vis.GetType() || (globalReader2.m_FactoryReader._AccountReader != null && (globalReader2.m_FactoryReader._AccountReader.FullName == vis.GetType().FullName || globalReader2.m_FactoryReader._AccountReader.FullName == typeof(object).FullName || globalReader2.m_FactoryReader._AccountReader.FullName == typeof(Exception).FullName))) && i_high >= globalReader2.m_HelperReader && i_high <= globalReader2.m_EventReader)
						{
							if (globalReader == null)
							{
								globalReader = globalReader2;
							}
							else if (globalReader2.m_FactoryReader.setterReader < globalReader.m_FactoryReader.setterReader)
							{
								globalReader = globalReader2;
							}
						}
					}
				}
				return globalReader;
			}

			// Token: 0x060004FC RID: 1276 RVA: 0x0001C7BC File Offset: 0x0001A9BC
			internal List<TaskReader.GlobalReader> ReflectAnnotation(int indexOf_init, bool connectionreguired)
			{
				if (this.adapterReader.m_ValReader == null)
				{
					return null;
				}
				List<TaskReader.GlobalReader> list = new List<TaskReader.GlobalReader>();
				foreach (TaskReader.GlobalReader globalReader in this.adapterReader.m_ValReader)
				{
					if ((globalReader.m_FactoryReader.stateReader & 1) == 1 && indexOf_init >= globalReader.m_HelperReader && indexOf_init <= globalReader.m_EventReader)
					{
						list.Add(globalReader);
					}
				}
				if (list.Count == 0)
				{
					return null;
				}
				return list;
			}

			// Token: 0x060004FD RID: 1277 RVA: 0x0001C858 File Offset: 0x0001AA58
			private unsafe void InsertAnnotation(TaskReader.FieldWatcherClass config)
			{
				switch (config._WrapperReader)
				{
				case (TaskReader.UnhandledExceptionAction)0:
					return;
				case (TaskReader.UnhandledExceptionAction)1:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					Array array = (Array)expressionReader.PatchProperty(null);
					this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(array.Length, (TaskReader.XmlReadMode)5));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)2:
					this._RecordReader = (int)this._ValueReader - 1;
					this.queueReader = true;
					return;
				case (TaskReader.UnhandledExceptionAction)3:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.ManageWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)4:
					if (TaskReader.structReader.Count == 0)
					{
						Module module = typeof(TaskReader).Module;
						this._ComposerReader.CountAnnotation(new TaskReader.ResolverReader(module.ResolveString((int)this._ValueReader | 1879048192)));
						return;
					}
					this._ComposerReader.CountAnnotation(new TaskReader.ResolverReader(TaskReader.structReader[(int)this._ValueReader]));
					return;
				case (TaskReader.UnhandledExceptionAction)5:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					Type type = module.ResolveType(num);
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					array.SetValue(expressionReader.PatchProperty(type), modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)6:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.InsertWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)7:
					this._ComposerReader.CountAnnotation(new TaskReader.IssuerInvocationRecord((float)this._ValueReader));
					return;
				case (TaskReader.UnhandledExceptionAction)8:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.RestartWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)9:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(expressionReader);
					if (expressionReader != null && expressionReader.VisitProperty() && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.PublishWatcher());
						return;
					}
					if (modelAuthenticationReader != null && modelAuthenticationReader.PatchRule())
					{
						IntPtr intPtr = ((TaskReader.WorkerAuthenticationReader)modelAuthenticationReader).QueryAnnotation();
						this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy((int)(*(sbyte*)((void*)intPtr)), (TaskReader.XmlReadMode)1));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)10:
				case (TaskReader.UnhandledExceptionAction)22:
				case (TaskReader.UnhandledExceptionAction)53:
				case (TaskReader.UnhandledExceptionAction)111:
				case (TaskReader.UnhandledExceptionAction)113:
				case (TaskReader.UnhandledExceptionAction)140:
					return;
				case (TaskReader.UnhandledExceptionAction)11:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 == null || modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader2.FlushWatcher(modelAuthenticationReader));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)12:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 != null && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader2.EnableWatcher(modelAuthenticationReader));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)13:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (!modelAuthenticationReader.FindWatcher(expressionReader))
					{
						this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(0));
						return;
					}
					this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(1));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)14:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.CountWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)15:
				case (TaskReader.UnhandledExceptionAction)33:
				case (TaskReader.UnhandledExceptionAction)38:
				case (TaskReader.UnhandledExceptionAction)40:
				case (TaskReader.UnhandledExceptionAction)42:
				case (TaskReader.UnhandledExceptionAction)85:
				case (TaskReader.UnhandledExceptionAction)118:
				case (TaskReader.UnhandledExceptionAction)157:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					Type type = array.GetType().GetElementType();
					array.SetValue(expressionReader.PatchProperty(type), modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)16:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					if (expressionReader.CalculateProperty())
					{
						expressionReader = ((TaskReader.ModelAuthenticationReader)expressionReader).CompareWatcher();
					}
					TaskReader.ExpressionReader expressionReader2 = this._ComposerReader.MoveAnnotation();
					expressionReader2.UpdateProperty(expressionReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)17:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 != null && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader2.PopWatcher(modelAuthenticationReader));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)18:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.RegisterWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)19:
				case (TaskReader.UnhandledExceptionAction)27:
				case (TaskReader.UnhandledExceptionAction)58:
				case (TaskReader.UnhandledExceptionAction)92:
				case (TaskReader.UnhandledExceptionAction)116:
				case (TaskReader.UnhandledExceptionAction)143:
					throw new TaskReader.IndexerReader();
				case (TaskReader.UnhandledExceptionAction)20:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					Type type = module.ResolveType(num);
					object obj = this._ComposerReader.MoveAnnotation().IncludeProperty().PatchProperty(type);
					TaskReader.ExpressionReader expressionReader = TaskReader.ExpressionReader.RunRule(type, obj);
					this._ComposerReader.CountAnnotation(expressionReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)21:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.OrderWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)23:
					this.CustomizeInfo(true);
					return;
				case (TaskReader.UnhandledExceptionAction)24:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					object obj = array.GetValue(modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(typeof(int), obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)25:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 != null && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader2.CreateWatcher(modelAuthenticationReader));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)26:
				{
					TaskReader.ExpressionReader expressionReader = this._ListenerReader[(int)this._ValueReader];
					this._ComposerReader.CountAnnotation(expressionReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)28:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader.PatchWatcher(expressionReader))
					{
						this._RecordReader = (int)this._ValueReader - 1;
					}
					return;
				}
				case (TaskReader.UnhandledExceptionAction)29:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					if (expressionReader.CalculateProperty())
					{
						expressionReader = ((TaskReader.ModelAuthenticationReader)expressionReader).ResetWatcher();
					}
					TaskReader.ExpressionReader expressionReader2 = this._ComposerReader.MoveAnnotation();
					expressionReader2.UpdateProperty(expressionReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)30:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					ConstructorInfo constructorInfo = (ConstructorInfo)module.ResolveMethod(num);
					ParameterInfo[] parameters = constructorInfo.GetParameters();
					object[] array2 = new object[parameters.Length];
					TaskReader.ExpressionReader[] array3 = new TaskReader.ExpressionReader[parameters.Length];
					List<TaskReader.ReaderSingletonObject> list = null;
					TaskReader.ParameterTemplateStatus parameterTemplateStatus = null;
					for (int i = 0; i < parameters.Length; i++)
					{
						TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
						ParameterInfo parameterInfo = parameters[parameters.Length - 1 - i];
						Type type = parameterInfo.ParameterType;
						object obj = null;
						bool flag = false;
						if (type.IsByRef)
						{
							TaskReader.TagReader tagReader = expressionReader as TaskReader.TagReader;
							if (tagReader != null)
							{
								if (list == null)
								{
									list = new List<TaskReader.ReaderSingletonObject>();
								}
								list.Add(new TaskReader.ReaderSingletonObject(tagReader.objectReader, i));
								obj = tagReader._ExporterReader;
								if (!(obj is TaskReader.ExpressionReader))
								{
									flag = true;
								}
								else
								{
									expressionReader = (obj as TaskReader.ExpressionReader);
								}
							}
						}
						if (!flag)
						{
							if (expressionReader != null)
							{
								obj = expressionReader.PatchProperty(type);
							}
							if (obj == null)
							{
								if (type.IsByRef)
								{
									type = type.GetElementType();
								}
								if (type.IsValueType)
								{
									obj = Activator.CreateInstance(type);
									if (expressionReader is TaskReader.AttributeContainerRole)
									{
										((TaskReader.MockReader)expressionReader).MapWatcher(TaskReader.ExpressionReader.RunRule(type, obj));
									}
								}
							}
						}
						array3[array2.Length - 1 - i] = expressionReader;
						array2[array2.Length - 1 - i] = obj;
					}
					TaskReader.RecordInstance recordInstance = null;
					if (list != null)
					{
						parameterTemplateStatus = new TaskReader.ParameterTemplateStatus(constructorInfo, list);
						recordInstance = TaskReader.SingletonSingletonObject.FlushInfo(constructorInfo, true, parameterTemplateStatus);
					}
					object obj2;
					if (recordInstance == null)
					{
						obj2 = constructorInfo.Invoke(array2);
					}
					else
					{
						obj2 = recordInstance(null, array2);
					}
					for (int j = 0; j < parameters.Length; j++)
					{
						if (parameters[j].ParameterType.IsByRef && (parameterTemplateStatus == null || !parameterTemplateStatus.PostAnnotation(j)))
						{
							if (array3[j].PatchRule())
							{
								((TaskReader.WorkerAuthenticationReader)array3[j]).RevertRule(TaskReader.ExpressionReader.RunRule(parameters[j].ParameterType, array2[j]));
							}
							else if (!(array3[j] is TaskReader.AttributeContainerRole))
							{
								array3[j].FindProperty(TaskReader.ExpressionReader.RunRule(parameters[j].ParameterType, array2[j]));
							}
							else
							{
								array3[j].FindProperty(TaskReader.ExpressionReader.RunRule(parameters[j].ParameterType.GetElementType(), array2[j]));
							}
						}
					}
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(constructorInfo.DeclaringType, obj2));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)31:
					if (this._ComposerReader.MoveAnnotation().CancelProperty(this._ComposerReader.MoveAnnotation()))
					{
						this._RecordReader = (int)this._ValueReader - 1;
					}
					return;
				case (TaskReader.UnhandledExceptionAction)32:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.AssetWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)34:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.CustomizeWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)35:
					if (!this._ComposerReader.MoveAnnotation().ViewProperty())
					{
						this._RecordReader = (int)this._ValueReader - 1;
					}
					return;
				case (TaskReader.UnhandledExceptionAction)36:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null && modelAuthenticationReader2 != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.TestWatcher(modelAuthenticationReader2));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)37:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = this._ComposerReader.MoveAnnotation() as TaskReader.ModelAuthenticationReader;
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = this._ComposerReader.MoveAnnotation() as TaskReader.ModelAuthenticationReader;
					IntPtr intPtr = TaskReader.SingletonSingletonObject.CallInfo(this._ComposerReader.MoveAnnotation());
					if (intPtr != IntPtr.Zero)
					{
						byte getterReader = modelAuthenticationReader2.QueryWatcher().paramsReader._GetterReader;
						uint num2 = modelAuthenticationReader.InterruptWatcher().paramsReader.m_StubReader;
						TaskReader.SingletonSingletonObject.ValidateInfo(intPtr, getterReader, (int)num2);
					}
					return;
				}
				case (TaskReader.UnhandledExceptionAction)39:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					object obj = array.GetValue(modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					Type type = array.GetType().GetElementType();
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(type, obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)41:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ExpressionReader expressionReader2 = this._ComposerReader.MoveAnnotation();
					expressionReader2.UpdateProperty(expressionReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)43:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.SortWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)44:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					if (!expressionReader.VisitProperty())
					{
						throw new TaskReader.IndexerReader();
					}
					object obj = expressionReader.PatchProperty(null);
					if (obj == null)
					{
						expressionReader = new TaskReader.CandidateReader(null);
					}
					else
					{
						expressionReader = TaskReader.ExpressionReader.RunRule(obj.GetType(), obj);
					}
					this._ComposerReader.CountAnnotation(expressionReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)45:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					object obj = array.GetValue(modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(typeof(short), obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)46:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 != null && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader2.PrepareWatcher(modelAuthenticationReader));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)47:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					if (expressionReader.CalculateProperty())
					{
						expressionReader = ((TaskReader.ModelAuthenticationReader)expressionReader).InitWatcher();
					}
					TaskReader.ExpressionReader expressionReader2 = this._ComposerReader.MoveAnnotation();
					expressionReader2.UpdateProperty(expressionReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)48:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					FieldInfo fieldInfo = module.ResolveField(num);
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					expressionReader.IncludeProperty();
					object obj = expressionReader.PatchProperty(null);
					this._ComposerReader.CountAnnotation(new TaskReader.TagReader(fieldInfo, obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)49:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader.RunWatcher(expressionReader))
					{
						this._RecordReader = (int)this._ValueReader - 1;
					}
					return;
				}
				case (TaskReader.UnhandledExceptionAction)50:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(expressionReader);
					if (expressionReader != null && expressionReader.VisitProperty() && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.ManageWatcher());
						return;
					}
					if (modelAuthenticationReader != null && modelAuthenticationReader.PatchRule())
					{
						IntPtr intPtr = ((TaskReader.WorkerAuthenticationReader)modelAuthenticationReader).QueryAnnotation();
						this._ComposerReader.CountAnnotation(new TaskReader.IssuerInvocationRecord(*(float*)((void*)intPtr), (TaskReader.XmlReadMode)9));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)51:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					object obj = array.GetValue(modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(typeof(long), obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)52:
					this._RecordReader = (int)this._ValueReader - 1;
					return;
				case (TaskReader.UnhandledExceptionAction)54:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.SelectWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)55:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.LoginWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)56:
					this._ComposerReader.CountAnnotation(new TaskReader.AttributeContainerRole((int)this._ValueReader, this));
					return;
				case (TaskReader.UnhandledExceptionAction)57:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader.IncludeWatcher(expressionReader))
					{
						this._RecordReader = (int)this._ValueReader - 1;
					}
					return;
				}
				case (TaskReader.UnhandledExceptionAction)59:
				{
					TaskReader.ExpressionReader expressionReader = TaskReader.SingletonSingletonObject.PrepareInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ExpressionReader expressionReader2 = TaskReader.SingletonSingletonObject.PrepareInfo(this._ComposerReader.MoveAnnotation());
					if (!expressionReader.ResolveProperty(expressionReader2))
					{
						this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(0));
						return;
					}
					this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(1));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)60:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.ListWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)61:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ExpressionReader expressionReader2 = this._ComposerReader.MoveAnnotation();
					if (expressionReader.ResolveProperty(expressionReader2))
					{
						this._RecordReader = (int)this._ValueReader - 1;
					}
					return;
				}
				case (TaskReader.UnhandledExceptionAction)62:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					Type type = module.ResolveType(num);
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					object obj = array.GetValue(modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(type, obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)63:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.ChangeWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)64:
				case (TaskReader.UnhandledExceptionAction)131:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					this._ComposerReader.CountAnnotation(new TaskReader.WorkerAuthenticationReader(module.ResolveMethod(num).MethodHandle.GetFunctionPointer()));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)65:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.CollectWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)66:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader.ViewWatcher(expressionReader))
					{
						this._RecordReader = (int)this._ValueReader - 1;
					}
					return;
				}
				case (TaskReader.UnhandledExceptionAction)67:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 != null && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader2.RateWatcher(modelAuthenticationReader));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)68:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader.CancelWatcher(expressionReader))
					{
						this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(1));
						return;
					}
					this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(0));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)69:
				{
					Module module = typeof(TaskReader).Module;
					Type type = module.ResolveType((int)this._ValueReader);
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					object obj = expressionReader.PatchProperty(type);
					if (obj == null)
					{
						obj = Activator.CreateInstance(type);
					}
					this._ComposerReader.CountAnnotation(new TaskReader.CandidateReader(TaskReader.ExpressionReader.RunRule(type, TaskReader.SingletonSingletonObject.RateInfo(obj))));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)70:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					Type type = module.ResolveType(num);
					TaskReader.MockReader mockReader = this._ComposerReader.MoveAnnotation() as TaskReader.MockReader;
					if (mockReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					object obj = mockReader.PatchProperty(type);
					TaskReader.ExpressionReader expressionReader;
					if (obj != null)
					{
						if (type.IsValueType)
						{
							obj = TaskReader.SingletonSingletonObject.RateInfo(obj);
						}
						expressionReader = TaskReader.ExpressionReader.RunRule(type, obj);
					}
					else if (type.IsValueType)
					{
						obj = Activator.CreateInstance(type);
						expressionReader = TaskReader.ExpressionReader.RunRule(type, obj);
					}
					else
					{
						expressionReader = new TaskReader.CandidateReader(null);
					}
					this._ComposerReader.CountAnnotation(expressionReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)71:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.SearchWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)72:
					this._RefSingleton = (bool)this._ComposerReader.MoveAnnotation().PatchProperty(typeof(bool));
					this.procReader = true;
					return;
				case (TaskReader.UnhandledExceptionAction)73:
				{
					int num = (int)this._ValueReader;
					if (this.adapterReader.m_DescriptorReader.IsStatic)
					{
						this._BroadcasterReader[num] = this.RegisterAnnotation(this._ComposerReader.MoveAnnotation(), this.adapterReader._CallbackReader[num]._ParamReader, false);
						return;
					}
					this._BroadcasterReader[num] = this.RegisterAnnotation(this._ComposerReader.MoveAnnotation(), this.adapterReader._CallbackReader[num - 1]._ParamReader, false);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)74:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(expressionReader);
					if (expressionReader != null && expressionReader.VisitProperty() && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.PrintWatcher());
						return;
					}
					if (modelAuthenticationReader != null && modelAuthenticationReader.PatchRule())
					{
						IntPtr intPtr = ((TaskReader.WorkerAuthenticationReader)modelAuthenticationReader).QueryAnnotation();
						this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy((int)(*(byte*)((void*)intPtr)), (TaskReader.XmlReadMode)2));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)75:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					object obj = array.GetValue(modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(typeof(IntPtr), obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)76:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.CompareWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)77:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					if (expressionReader.CalculateProperty())
					{
						expressionReader = ((TaskReader.ModelAuthenticationReader)expressionReader).PublishWatcher();
					}
					TaskReader.ExpressionReader expressionReader2 = this._ComposerReader.MoveAnnotation();
					expressionReader2.UpdateProperty(expressionReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)78:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					if (expressionReader.CalculateProperty())
					{
						expressionReader = ((TaskReader.ModelAuthenticationReader)expressionReader).SelectWatcher();
					}
					TaskReader.ExpressionReader expressionReader2 = this._ComposerReader.MoveAnnotation();
					expressionReader2.UpdateProperty(expressionReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)79:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(expressionReader);
					if (expressionReader != null && expressionReader.VisitProperty() && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.ResetWatcher());
						return;
					}
					if (modelAuthenticationReader == null || !modelAuthenticationReader.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					IntPtr intPtr = ((TaskReader.WorkerAuthenticationReader)modelAuthenticationReader).QueryAnnotation();
					this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy((int)(*(short*)((void*)intPtr)), (TaskReader.XmlReadMode)3));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)80:
					this._ComposerReader.CountAnnotation(new TaskReader.IssuerInvocationRecord((double)this._ValueReader));
					return;
				case (TaskReader.UnhandledExceptionAction)81:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					bool flag;
					if (!(flag = modelAuthenticationReader.FindWatcher(expressionReader)))
					{
						this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(0));
					}
					else
					{
						this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(1));
					}
					if (flag)
					{
						this._RecordReader = (int)this._ValueReader - 1;
					}
					return;
				}
				case (TaskReader.UnhandledExceptionAction)82:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					if (expressionReader.CalculateProperty())
					{
						expressionReader = ((TaskReader.ModelAuthenticationReader)expressionReader).SortWatcher();
					}
					TaskReader.ExpressionReader expressionReader2 = this._ComposerReader.MoveAnnotation();
					expressionReader2.UpdateProperty(expressionReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)83:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					object obj = array.GetValue(modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(typeof(float), obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)84:
					this._ComposerReader.CountAnnotation(this._ComposerReader.StopAnnotation());
					return;
				case (TaskReader.UnhandledExceptionAction)86:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					FieldInfo fieldInfo = module.ResolveField(num);
					object obj = this._ComposerReader.MoveAnnotation().PatchProperty(fieldInfo.FieldType);
					fieldInfo.SetValue(null, obj);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)87:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.ResetWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)88:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 != null && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader2.UpdateWatcher(modelAuthenticationReader));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)89:
					throw this._ProxyReader;
				case (TaskReader.UnhandledExceptionAction)90:
					this._ComposerReader.CountAnnotation(this._ComposerReader.MoveAnnotation().IncludeProperty());
					return;
				case (TaskReader.UnhandledExceptionAction)91:
					throw (Exception)this._ComposerReader.MoveAnnotation().PatchProperty(null);
				case (TaskReader.UnhandledExceptionAction)93:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 != null && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader2.VisitWatcher(modelAuthenticationReader));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)94:
					this._ComposerReader.CountAnnotation(new TaskReader.CandidateReader(null));
					return;
				case (TaskReader.UnhandledExceptionAction)95:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.StopWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)96:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.SetupWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)97:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.DefineWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)98:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					object obj = array.GetValue(modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(typeof(double), obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)99:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.SetWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)100:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null && modelAuthenticationReader2 != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.CheckWatcher(modelAuthenticationReader2));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)101:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					object obj = array.GetValue(modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(typeof(ushort), obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)102:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(expressionReader);
					if (expressionReader != null && expressionReader.VisitProperty() && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.SelectWatcher());
						return;
					}
					if (modelAuthenticationReader != null && modelAuthenticationReader.PatchRule())
					{
						IntPtr intPtr = ((TaskReader.WorkerAuthenticationReader)modelAuthenticationReader).QueryAnnotation();
						this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(*(int*)((void*)intPtr), (TaskReader.XmlReadMode)5));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)103:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.ReflectWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)104:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 == null || modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader2.VerifyWatcher(modelAuthenticationReader));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)105:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.InitWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)106:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.PrintWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)107:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					object obj = array.GetValue(modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(typeof(uint), obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)108:
					this._ComposerReader.CountAnnotation(new TaskReader.ParamContainerRole((int)this._ValueReader, this));
					return;
				case (TaskReader.UnhandledExceptionAction)109:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.WriteWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)110:
					this._RecordReader = -3;
					if (this._ComposerReader.method_0() > 0)
					{
						this._CreatorReader = this._ComposerReader.MoveAnnotation();
					}
					return;
				case (TaskReader.UnhandledExceptionAction)112:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(expressionReader);
					if (expressionReader != null && expressionReader.VisitProperty() && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.SortWatcher());
						return;
					}
					if (modelAuthenticationReader == null || !modelAuthenticationReader.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					IntPtr intPtr = ((TaskReader.WorkerAuthenticationReader)modelAuthenticationReader).QueryAnnotation();
					if (IntPtr.Size == 8)
					{
						long num3 = *(long*)((void*)intPtr);
						this._ComposerReader.CountAnnotation(new TaskReader.WorkerAuthenticationReader(num3, (TaskReader.XmlReadMode)12));
						return;
					}
					int num = *(int*)((void*)intPtr);
					this._ComposerReader.CountAnnotation(new TaskReader.WorkerAuthenticationReader((long)num, (TaskReader.XmlReadMode)12));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)114:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					module.ResolveType(num);
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					this._ComposerReader.CountAnnotation(new TaskReader.ConfigurationReader(modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader, array));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)115:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					FieldInfo fieldInfo = module.ResolveField(num);
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					object obj = expressionReader.PatchProperty(null);
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(fieldInfo.FieldType, fieldInfo.GetValue(obj)));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)117:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					Type type = module.ResolveType(num);
					uint num2 = (uint)TaskReader.SingletonSingletonObject.PostInfo(type);
					this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(num2, (TaskReader.XmlReadMode)6));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)119:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 == null || modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader2.DisableWatcher(modelAuthenticationReader));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)120:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.PostWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)121:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					FieldInfo fieldInfo = module.ResolveField(num);
					object obj = this._ComposerReader.MoveAnnotation().PatchProperty(fieldInfo.FieldType);
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					object obj2 = expressionReader.PatchProperty(null);
					if (obj2 == null)
					{
						Type type = fieldInfo.DeclaringType;
						if (type.IsByRef)
						{
							type = type.GetElementType();
						}
						if (!type.IsValueType)
						{
							throw new NullReferenceException();
						}
						obj2 = Activator.CreateInstance(type);
						if (expressionReader is TaskReader.AttributeContainerRole)
						{
							((TaskReader.MockReader)expressionReader).MapWatcher(TaskReader.ExpressionReader.RunRule(type, obj2));
						}
					}
					fieldInfo.SetValue(obj2, obj);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)122:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.StopAnnotation());
					if (modelAuthenticationReader != null)
					{
						TaskReader.IssuerInvocationRecord issuerInvocationRecord = modelAuthenticationReader as TaskReader.IssuerInvocationRecord;
						if (issuerInvocationRecord != null)
						{
							if (double.IsNaN(issuerInvocationRecord.m_ParserReader))
							{
								throw new OverflowException("NaN");
							}
							if (double.IsInfinity(issuerInvocationRecord.m_ParserReader))
							{
								throw new OverflowException("Infinity Value");
							}
						}
						return;
					}
					throw new ArithmeticException("Not a number");
				}
				case (TaskReader.UnhandledExceptionAction)123:
				case (TaskReader.UnhandledExceptionAction)168:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					Type type = module.ResolveType(num);
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					object obj = expressionReader.PatchProperty(type);
					if (obj != null)
					{
						if (type.IsValueType)
						{
							obj = TaskReader.SingletonSingletonObject.RateInfo(obj);
						}
						expressionReader = TaskReader.ExpressionReader.RunRule(type, obj);
					}
					else if (!type.IsValueType)
					{
						expressionReader = new TaskReader.CandidateReader(null);
					}
					else
					{
						obj = Activator.CreateInstance(type);
						expressionReader = TaskReader.ExpressionReader.RunRule(type, obj);
					}
					TaskReader.MockReader mockReader = this._ComposerReader.MoveAnnotation() as TaskReader.MockReader;
					if (mockReader != null)
					{
						mockReader.FindProperty(expressionReader);
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)124:
					this._ComposerReader.MoveAnnotation();
					return;
				case (TaskReader.UnhandledExceptionAction)125:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (!modelAuthenticationReader.RunWatcher(expressionReader))
					{
						this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(0));
						return;
					}
					this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(1));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)126:
				{
					int num = (int)this._ValueReader;
					this._ListenerReader[num] = this.RegisterAnnotation(this._ComposerReader.MoveAnnotation(), this.adapterReader.printerReader[num].regReader, this.adapterReader.printerReader[num].errorReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)127:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					Type type = module.ResolveType(num);
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					object obj = expressionReader.PatchProperty(null);
					if (obj == null)
					{
						this._ComposerReader.CountAnnotation(new TaskReader.CandidateReader(null));
						return;
					}
					if (type.IsAssignableFrom(obj.GetType()))
					{
						this._ComposerReader.CountAnnotation(expressionReader);
						return;
					}
					this._ComposerReader.CountAnnotation(new TaskReader.CandidateReader(null));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)128:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					FieldInfo fieldInfo = module.ResolveField(num);
					this._ComposerReader.CountAnnotation(new TaskReader.TagReader(fieldInfo, null));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)129:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					FieldInfo fieldInfo = module.ResolveField(num);
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(fieldInfo.FieldType, fieldInfo.GetValue(null)));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)130:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.GetWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)132:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					if (expressionReader.ViewProperty())
					{
						this._RecordReader = (int)this._ValueReader - 1;
					}
					return;
				}
				case (TaskReader.UnhandledExceptionAction)133:
					this._ComposerReader.CountAnnotation(((TaskReader.ModelAuthenticationReader)this._ComposerReader.MoveAnnotation()).InvokeWatcher());
					return;
				case (TaskReader.UnhandledExceptionAction)134:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = (TaskReader.ModelAuthenticationReader)this._ComposerReader.MoveAnnotation();
					if (modelAuthenticationReader2 != null && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader2.DeleteWatcher(modelAuthenticationReader));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)135:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 == null || modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader2.FillWatcher(modelAuthenticationReader));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)136:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (!modelAuthenticationReader.ResolveWatcher(expressionReader))
					{
						this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(0));
						return;
					}
					this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(1));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)137:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader.CancelWatcher(expressionReader))
					{
						this._RecordReader = (int)this._ValueReader - 1;
					}
					return;
				}
				case (TaskReader.UnhandledExceptionAction)138:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.MoveWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)139:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.ComputeWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)141:
					this.CustomizeInfo(false);
					return;
				case (TaskReader.UnhandledExceptionAction)142:
					this._ComposerReader.CountAnnotation(new TaskReader.AlgoReader((long)this._ValueReader));
					return;
				case (TaskReader.UnhandledExceptionAction)144:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = this._ComposerReader.MoveAnnotation() as TaskReader.ModelAuthenticationReader;
					IntPtr intPtr = TaskReader.SingletonSingletonObject.CallInfo(this._ComposerReader.MoveAnnotation());
					IntPtr intPtr2 = TaskReader.SingletonSingletonObject.CallInfo(this._ComposerReader.MoveAnnotation());
					if (intPtr != IntPtr.Zero && intPtr2 != IntPtr.Zero)
					{
						uint num2 = modelAuthenticationReader.InterruptWatcher().paramsReader.m_StubReader;
						TaskReader.SingletonSingletonObject.VerifyInfo(intPtr2, intPtr, num2);
					}
					return;
				}
				case (TaskReader.UnhandledExceptionAction)145:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = this._ComposerReader.MoveAnnotation() as TaskReader.ModelAuthenticationReader;
					int num = modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader;
					IntPtr intPtr = Marshal.AllocHGlobal(num);
					if (this.serviceReader == null)
					{
						this.serviceReader = new List<IntPtr>();
					}
					this.serviceReader.Add(intPtr);
					this._ComposerReader.CountAnnotation(new TaskReader.WorkerAuthenticationReader(intPtr));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)146:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader.CalculateWatcher(expressionReader))
					{
						this._RecordReader = (int)this._ValueReader - 1;
					}
					return;
				}
				case (TaskReader.UnhandledExceptionAction)147:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 != null && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader2.CalcWatcher(modelAuthenticationReader));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)148:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					if (expressionReader.CalculateProperty())
					{
						expressionReader = ((TaskReader.ModelAuthenticationReader)expressionReader).ManageWatcher();
					}
					TaskReader.ExpressionReader expressionReader2 = this._ComposerReader.MoveAnnotation();
					expressionReader2.UpdateProperty(expressionReader);
					return;
				}
				case (TaskReader.UnhandledExceptionAction)149:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader.ResolveWatcher(expressionReader))
					{
						this._RecordReader = (int)this._ValueReader - 1;
					}
					return;
				}
				case (TaskReader.UnhandledExceptionAction)150:
				{
					int[] array4 = (int[])this._ValueReader;
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					long num3 = modelAuthenticationReader.PushWatcher()._IteratorReader._InterpreterReader;
					if ((num3 < 0L || modelAuthenticationReader.CancelRule()) && IntPtr.Size == 4)
					{
						num3 = (long)((int)num3);
					}
					if (modelAuthenticationReader.CalculateRule())
					{
						TaskReader.ExporterPolicyPolicy exporterPolicyPolicy = (TaskReader.ExporterPolicyPolicy)modelAuthenticationReader;
						if (exporterPolicyPolicy._UtilsReader == (TaskReader.XmlReadMode)6)
						{
							num3 = (long)((ulong)exporterPolicyPolicy.paramsReader.m_StubReader);
						}
					}
					if (num3 < (long)array4.Length && num3 >= 0L)
					{
						this._RecordReader = array4[(int)(checked((IntPtr)num3))] - 1;
					}
					return;
				}
				case (TaskReader.UnhandledExceptionAction)151:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(expressionReader);
					if (expressionReader != null && expressionReader.VisitProperty() && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.CountWatcher());
						return;
					}
					if (modelAuthenticationReader != null && modelAuthenticationReader.PatchRule())
					{
						IntPtr intPtr = ((TaskReader.WorkerAuthenticationReader)modelAuthenticationReader).QueryAnnotation();
						this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy((int)(*(ushort*)((void*)intPtr)), (TaskReader.XmlReadMode)4));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)152:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null && modelAuthenticationReader2 != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.CloneWatcher(modelAuthenticationReader2));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)153:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 != null && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader2.LogoutWatcher(modelAuthenticationReader));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)154:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(expressionReader);
					if (expressionReader != null && expressionReader.VisitProperty() && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.CompareWatcher());
						return;
					}
					if (modelAuthenticationReader != null && modelAuthenticationReader.PatchRule())
					{
						IntPtr intPtr = ((TaskReader.WorkerAuthenticationReader)modelAuthenticationReader).QueryAnnotation();
						this._ComposerReader.CountAnnotation(new TaskReader.IssuerInvocationRecord(*(double*)((void*)intPtr), (TaskReader.XmlReadMode)10));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)155:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(expressionReader);
					if (expressionReader != null && expressionReader.VisitProperty() && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.StopWatcher());
						return;
					}
					if (modelAuthenticationReader != null && modelAuthenticationReader.PatchRule())
					{
						IntPtr intPtr = ((TaskReader.WorkerAuthenticationReader)modelAuthenticationReader).QueryAnnotation();
						this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy(*(uint*)((void*)intPtr), (TaskReader.XmlReadMode)6));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)156:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.AwakeWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)158:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 == null || modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader2.CallWatcher(modelAuthenticationReader));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)159:
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(expressionReader);
					if (expressionReader != null && expressionReader.VisitProperty() && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.InitWatcher());
						return;
					}
					if (modelAuthenticationReader == null || !modelAuthenticationReader.PatchRule())
					{
						throw new TaskReader.IndexerReader();
					}
					IntPtr intPtr = ((TaskReader.WorkerAuthenticationReader)modelAuthenticationReader).QueryAnnotation();
					this._ComposerReader.CountAnnotation(new TaskReader.AlgoReader(*(long*)((void*)intPtr), (TaskReader.XmlReadMode)7));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)160:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.PublishWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)161:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					Type type = module.ResolveType(num);
					TaskReader.MockReader mockReader = this._ComposerReader.MoveAnnotation() as TaskReader.MockReader;
					if (mockReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					if (type.IsValueType)
					{
						object obj = Activator.CreateInstance(type);
						mockReader.MapWatcher(TaskReader.ExpressionReader.RunRule(type, obj));
						return;
					}
					mockReader.MapWatcher(new TaskReader.CandidateReader(null));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)162:
					this._ComposerReader.CountAnnotation(new TaskReader.ExporterPolicyPolicy((int)this._ValueReader));
					return;
				case (TaskReader.UnhandledExceptionAction)163:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader.DestroyWatcher());
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)164:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					object obj = array.GetValue(modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(typeof(byte), obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)165:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					TaskReader.ModelAuthenticationReader modelAuthenticationReader2 = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader2 != null && modelAuthenticationReader != null)
					{
						this._ComposerReader.CountAnnotation(modelAuthenticationReader2.ValidateWatcher(modelAuthenticationReader));
						return;
					}
					throw new TaskReader.IndexerReader();
				}
				case (TaskReader.UnhandledExceptionAction)166:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					object obj = null;
					try
					{
						obj = module.ResolveType(num);
					}
					catch
					{
						try
						{
							obj = module.ResolveMethod(num);
						}
						catch
						{
							try
							{
								obj = module.ResolveField(num);
							}
							catch
							{
								obj = module.ResolveMember(num);
							}
						}
					}
					this._ComposerReader.CountAnnotation(new TaskReader.CandidateReader(obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)167:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = (Array)this._ComposerReader.MoveAnnotation().PatchProperty(null);
					object obj = array.GetValue(modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(typeof(sbyte), obj));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)169:
					this._ComposerReader.CountAnnotation(this._BroadcasterReader[(int)this._ValueReader]);
					return;
				case (TaskReader.UnhandledExceptionAction)170:
				{
					int num = (int)this._ValueReader;
					Module module = typeof(TaskReader).Module;
					Type type = module.ResolveType(num);
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					Array array = Array.CreateInstance(type, modelAuthenticationReader.InstantiateWatcher().paramsReader.filterReader);
					this._ComposerReader.CountAnnotation(new TaskReader.CandidateReader(array));
					return;
				}
				case (TaskReader.UnhandledExceptionAction)171:
					this.prototypeSingleton = true;
					return;
				case (TaskReader.UnhandledExceptionAction)172:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.RemoveWatcher());
					return;
				}
				case (TaskReader.UnhandledExceptionAction)173:
				{
					TaskReader.ModelAuthenticationReader modelAuthenticationReader = TaskReader.SingletonSingletonObject.ComputeInfo(this._ComposerReader.MoveAnnotation());
					if (modelAuthenticationReader == null)
					{
						throw new TaskReader.IndexerReader();
					}
					this._ComposerReader.CountAnnotation(modelAuthenticationReader.ConnectWatcher());
					return;
				}
				default:
					return;
				}
			}

			// Token: 0x060004FE RID: 1278 RVA: 0x0001F5A4 File Offset: 0x0001D7A4
			private TaskReader.ExpressionReader RegisterAnnotation(TaskReader.ExpressionReader last, TaskReader.XmlReadMode cust, bool compreguired = false)
			{
				if (!compreguired && last.VisitProperty())
				{
					last = last.IncludeProperty();
				}
				if (last.CalculateRule())
				{
					return ((TaskReader.ExporterPolicyPolicy)last).ReadProperty(cust);
				}
				if (last.ResolveRule())
				{
					return ((TaskReader.AlgoReader)last).ReadProperty(cust);
				}
				if (last.CancelRule())
				{
					return ((TaskReader.IssuerInvocationRecord)last).ReadProperty(cust);
				}
				if (!last.PatchRule())
				{
					return last;
				}
				return ((TaskReader.WorkerAuthenticationReader)last).ReadProperty(cust);
			}

			// Token: 0x060004FF RID: 1279 RVA: 0x00004F36 File Offset: 0x00003136
			private TaskReader.ExpressionReader ChangeTemplate(int i_length)
			{
				return this._ListenerReader[i_length];
			}

			// Token: 0x06000500 RID: 1280 RVA: 0x00004F40 File Offset: 0x00003140
			private void LoginTemplate(int itemPosition)
			{
				this.CompareInfo(itemPosition, this._ComposerReader.MoveAnnotation());
			}

			// Token: 0x06000501 RID: 1281 RVA: 0x0001F61C File Offset: 0x0001D81C
			private static int PostInfo(Type info)
			{
				if (TaskReader.SingletonSingletonObject.dictionary_0 == null)
				{
					TaskReader.SingletonSingletonObject.dictionary_0 = new Dictionary<Type, int>();
				}
				int result;
				try
				{
					int num = 0;
					if (!TaskReader.SingletonSingletonObject.dictionary_0.TryGetValue(info, out num))
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(int), Type.EmptyTypes, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Sizeof, info);
						ilgenerator.Emit(OpCodes.Ret);
						num = (int)dynamicMethod.Invoke(null, null);
						TaskReader.SingletonSingletonObject.dictionary_0[info] = num;
						result = num;
					}
					else
					{
						result = num;
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}

			// Token: 0x06000502 RID: 1282 RVA: 0x00004F54 File Offset: 0x00003154
			private void CompareInfo(int instance_Y, TaskReader.ExpressionReader vis)
			{
				this._ListenerReader[instance_Y] = this.RegisterAnnotation(vis, this.adapterReader.printerReader[instance_Y].regReader, this.adapterReader.printerReader[instance_Y].errorReader);
			}

			// Token: 0x06000503 RID: 1283 RVA: 0x00016DBC File Offset: 0x00014FBC
			private static TaskReader.ModelAuthenticationReader ComputeInfo(TaskReader.ExpressionReader instance)
			{
				TaskReader.ModelAuthenticationReader modelAuthenticationReader = instance as TaskReader.ModelAuthenticationReader;
				if (modelAuthenticationReader == null && instance.VisitProperty())
				{
					modelAuthenticationReader = (instance.IncludeProperty() as TaskReader.ModelAuthenticationReader);
				}
				return modelAuthenticationReader;
			}

			// Token: 0x06000504 RID: 1284 RVA: 0x0001F6BC File Offset: 0x0001D8BC
			private void CustomizeInfo(bool ignorev)
			{
				int metadataToken = (int)this._ValueReader;
				MethodBase methodBase = typeof(TaskReader).Module.ResolveMethod(metadataToken);
				MethodInfo methodInfo = methodBase as MethodInfo;
				ParameterInfo[] parameters = methodBase.GetParameters();
				object[] array = new object[parameters.Length];
				TaskReader.ExpressionReader[] array2 = new TaskReader.ExpressionReader[parameters.Length];
				List<TaskReader.ReaderSingletonObject> list = null;
				TaskReader.ParameterTemplateStatus parameterTemplateStatus = null;
				for (int i = 0; i < parameters.Length; i++)
				{
					TaskReader.ExpressionReader expressionReader = this._ComposerReader.MoveAnnotation();
					ParameterInfo parameterInfo = parameters[parameters.Length - 1 - i];
					Type type = parameterInfo.ParameterType;
					object obj = null;
					bool flag = false;
					if (type.IsByRef)
					{
						TaskReader.TagReader tagReader = expressionReader as TaskReader.TagReader;
						if (tagReader != null)
						{
							if (list == null)
							{
								list = new List<TaskReader.ReaderSingletonObject>();
							}
							list.Add(new TaskReader.ReaderSingletonObject(tagReader.objectReader, i));
							obj = tagReader._ExporterReader;
							if (!(obj is TaskReader.ExpressionReader))
							{
								flag = true;
							}
							else
							{
								expressionReader = (obj as TaskReader.ExpressionReader);
							}
						}
					}
					if (!flag)
					{
						if (expressionReader != null)
						{
							obj = expressionReader.PatchProperty(type);
						}
						if (obj == null)
						{
							if (type.IsByRef)
							{
								type = type.GetElementType();
							}
							if (type.IsValueType)
							{
								obj = Activator.CreateInstance(type);
								if (expressionReader is TaskReader.AttributeContainerRole)
								{
									((TaskReader.MockReader)expressionReader).MapWatcher(TaskReader.ExpressionReader.RunRule(type, obj));
								}
							}
						}
					}
					array2[array.Length - 1 - i] = expressionReader;
					array[array.Length - 1 - i] = obj;
				}
				TaskReader.RecordInstance recordInstance = null;
				if (list != null)
				{
					parameterTemplateStatus = new TaskReader.ParameterTemplateStatus(methodBase, list);
					recordInstance = TaskReader.SingletonSingletonObject.CreateInfo(methodBase, ignorev, parameterTemplateStatus);
				}
				else if (methodInfo != null && methodInfo.ReturnType.IsByRef)
				{
					recordInstance = TaskReader.SingletonSingletonObject.InvokeInfo(methodBase, ignorev);
				}
				object obj2 = null;
				if (!methodBase.IsStatic)
				{
					TaskReader.ExpressionReader expressionReader2 = this._ComposerReader.MoveAnnotation();
					if (expressionReader2 != null)
					{
						obj2 = expressionReader2.PatchProperty(methodBase.DeclaringType);
					}
					if (obj2 == null)
					{
						Type type2 = methodBase.DeclaringType;
						if (type2.IsByRef)
						{
							type2 = type2.GetElementType();
						}
						if (!type2.IsValueType)
						{
							throw new NullReferenceException();
						}
						obj2 = Activator.CreateInstance(type2);
						if (expressionReader2 is TaskReader.AttributeContainerRole)
						{
							((TaskReader.MockReader)expressionReader2).MapWatcher(TaskReader.ExpressionReader.RunRule(type2, obj2));
						}
					}
				}
				object ord;
				if (recordInstance == null)
				{
					ord = methodBase.Invoke(obj2, array);
				}
				else
				{
					ord = recordInstance(obj2, array);
				}
				for (int j = 0; j < parameters.Length; j++)
				{
					if (parameters[j].ParameterType.IsByRef && (parameterTemplateStatus == null || !parameterTemplateStatus.PostAnnotation(j)))
					{
						if (array2[j].PatchRule())
						{
							((TaskReader.WorkerAuthenticationReader)array2[j]).RevertRule(TaskReader.ExpressionReader.RunRule(parameters[j].ParameterType, array[j]));
						}
						else if (!(array2[j] is TaskReader.AttributeContainerRole))
						{
							array2[j].FindProperty(TaskReader.ExpressionReader.RunRule(parameters[j].ParameterType, array[j]));
						}
						else
						{
							array2[j].FindProperty(TaskReader.ExpressionReader.RunRule(parameters[j].ParameterType.GetElementType(), array[j]));
						}
					}
				}
				if (methodInfo != null && methodInfo.ReturnType != typeof(void))
				{
					this._ComposerReader.CountAnnotation(TaskReader.ExpressionReader.RunRule(methodInfo.ReturnType, ord));
				}
			}

			// Token: 0x06000505 RID: 1285 RVA: 0x0001F9F0 File Offset: 0x0001DBF0
			private static TaskReader.RecordInstance InvokeInfo(object instance, bool istoken)
			{
				TaskReader.RecordInstance result = null;
				if (istoken)
				{
					if (TaskReader.SingletonSingletonObject.readerSingleton.TryGetValue(instance, out result))
					{
						return result;
					}
				}
				else if (TaskReader.SingletonSingletonObject.m_SingletonSingleton.TryGetValue(instance, out result))
				{
					return result;
				}
				MethodInfo methodInfo = instance as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = instance.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (!parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType;
					}
					else
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
				}
				int num = array.Length;
				if (instance.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = ilgenerator.DeclareLocal(array[j]);
				}
				if (instance.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(instance.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					TaskReader.SingletonSingletonObject.CalcInfo(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (array[k].IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
					}
					else if (array[k] != typeof(object))
					{
						ilgenerator.Emit(OpCodes.Castclass, array[k]);
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!instance.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (!instance.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Castclass, instance.DeclaringType);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox, instance.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (!parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
				}
				if (!istoken)
				{
					if (!(methodInfo != null))
					{
						ilgenerator.Emit(OpCodes.Callvirt, instance as ConstructorInfo);
					}
					else
					{
						ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Call, instance as ConstructorInfo);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (!elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						TaskReader.SingletonSingletonObject.CalcInfo(ilgenerator, m);
						ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						ilgenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				TaskReader.RecordInstance recordInstance = (TaskReader.RecordInstance)dynamicMethod.CreateDelegate(typeof(TaskReader.RecordInstance));
				if (istoken)
				{
					TaskReader.SingletonSingletonObject.readerSingleton.Add(instance, recordInstance);
				}
				else
				{
					TaskReader.SingletonSingletonObject.m_SingletonSingleton.Add(instance, recordInstance);
				}
				return recordInstance;
			}

			// Token: 0x06000506 RID: 1286 RVA: 0x0001FE24 File Offset: 0x0001E024
			private static TaskReader.RecordInstance CreateInfo(object item, bool requiresb, TaskReader.ParameterTemplateStatus field)
			{
				TaskReader.RecordInstance result = null;
				if (requiresb)
				{
					if (TaskReader.SingletonSingletonObject.m_RuleSingleton.TryGetValue(field, out result))
					{
						return result;
					}
				}
				else if (TaskReader.SingletonSingletonObject._AnnotationSingleton.TryGetValue(field, out result))
				{
					return result;
				}
				MethodInfo methodInfo = item as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, typeof(TaskReader), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = item.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (item.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					if (!field.PostAnnotation(j))
					{
						array2[j] = ilgenerator.DeclareLocal(array[j]);
					}
					else
					{
						array2[j] = ilgenerator.DeclareLocal(typeof(object));
					}
				}
				if (item.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(item.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					TaskReader.SingletonSingletonObject.CalcInfo(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!field.PostAnnotation(k))
					{
						if (!array[k].IsValueType)
						{
							if (array[k] != typeof(object))
							{
								ilgenerator.Emit(OpCodes.Castclass, array[k]);
							}
						}
						else
						{
							ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
						}
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!item.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (item.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox, item.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Castclass, item.DeclaringType);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (field.PostAnnotation(l))
					{
						TaskReader.ReaderSingletonObject annotation = field.GetAnnotation(l);
						if (!annotation._ItemReader.IsStatic)
						{
							if (!annotation._ItemReader.DeclaringType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Castclass, annotation._ItemReader.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, annotation._ItemReader);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Unbox, annotation._ItemReader.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, annotation._ItemReader);
							}
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldsflda, annotation._ItemReader);
						}
					}
					else if (parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
				}
				if (!requiresb)
				{
					if (!(methodInfo != null))
					{
						ilgenerator.Emit(OpCodes.Callvirt, item as ConstructorInfo);
					}
					else
					{
						ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Call, item as ConstructorInfo);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (!elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						if (field.PostAnnotation(m))
						{
							TaskReader.ReaderSingletonObject annotation2 = field.GetAnnotation(m);
							if (!annotation2._ItemReader.IsStatic)
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								TaskReader.SingletonSingletonObject.CalcInfo(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								TaskReader.SingletonSingletonObject.CalcInfo(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldsfld, annotation2._ItemReader);
								if (annotation2._ItemReader.FieldType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldarg_1);
							TaskReader.SingletonSingletonObject.CalcInfo(ilgenerator, m);
							ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
							if (array2[m].LocalType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
							}
							ilgenerator.Emit(OpCodes.Stelem_Ref);
						}
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				TaskReader.RecordInstance recordInstance = (TaskReader.RecordInstance)dynamicMethod.CreateDelegate(typeof(TaskReader.RecordInstance));
				if (!requiresb)
				{
					TaskReader.SingletonSingletonObject._AnnotationSingleton.Add(field, recordInstance);
				}
				else
				{
					TaskReader.SingletonSingletonObject.m_RuleSingleton.Add(field, recordInstance);
				}
				return recordInstance;
			}

			// Token: 0x06000507 RID: 1287 RVA: 0x0002045C File Offset: 0x0001E65C
			private static TaskReader.RecordInstance FlushInfo(object first, bool deletecfg, TaskReader.ParameterTemplateStatus filter)
			{
				TaskReader.RecordInstance result = null;
				if (TaskReader.SingletonSingletonObject._TemplateSingleton.TryGetValue(filter, out result))
				{
					return result;
				}
				ConstructorInfo constructorInfo = first as ConstructorInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, typeof(TaskReader), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = first.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (first.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					if (filter.PostAnnotation(j))
					{
						array2[j] = ilgenerator.DeclareLocal(typeof(object));
					}
					else
					{
						array2[j] = ilgenerator.DeclareLocal(array[j]);
					}
				}
				if (first.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(first.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					TaskReader.SingletonSingletonObject.CalcInfo(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!filter.PostAnnotation(k))
					{
						if (array[k].IsValueType)
						{
							ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
						}
						else if (array[k] != typeof(object))
						{
							ilgenerator.Emit(OpCodes.Castclass, array[k]);
						}
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (!filter.PostAnnotation(l))
					{
						if (!parameters[l].ParameterType.IsByRef)
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
						}
					}
					else
					{
						TaskReader.ReaderSingletonObject annotation = filter.GetAnnotation(l);
						if (annotation._ItemReader.IsStatic)
						{
							ilgenerator.Emit(OpCodes.Ldsflda, annotation._ItemReader);
						}
						else if (!annotation._ItemReader.DeclaringType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(OpCodes.Castclass, annotation._ItemReader.DeclaringType);
							ilgenerator.Emit(OpCodes.Ldflda, annotation._ItemReader);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(OpCodes.Unbox, annotation._ItemReader.DeclaringType);
							ilgenerator.Emit(OpCodes.Ldflda, annotation._ItemReader);
						}
					}
				}
				ilgenerator.Emit(OpCodes.Newobj, first as ConstructorInfo);
				if (constructorInfo.DeclaringType.IsValueType)
				{
					ilgenerator.Emit(OpCodes.Box, constructorInfo.DeclaringType);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						if (filter.PostAnnotation(m))
						{
							TaskReader.ReaderSingletonObject annotation2 = filter.GetAnnotation(m);
							if (!annotation2._ItemReader.IsStatic)
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								TaskReader.SingletonSingletonObject.CalcInfo(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								TaskReader.SingletonSingletonObject.CalcInfo(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldsfld, annotation2._ItemReader);
								if (annotation2._ItemReader.FieldType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldarg_1);
							TaskReader.SingletonSingletonObject.CalcInfo(ilgenerator, m);
							ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
							if (array2[m].LocalType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
							}
							ilgenerator.Emit(OpCodes.Stelem_Ref);
						}
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				TaskReader.RecordInstance recordInstance = (TaskReader.RecordInstance)dynamicMethod.CreateDelegate(typeof(TaskReader.RecordInstance));
				TaskReader.SingletonSingletonObject._TemplateSingleton.Add(filter, recordInstance);
				return recordInstance;
			}

			// Token: 0x06000508 RID: 1288 RVA: 0x00020900 File Offset: 0x0001EB00
			private static void CalcInfo(ILGenerator info, int caller_start)
			{
				switch (caller_start)
				{
				case -1:
					info.Emit(OpCodes.Ldc_I4_M1);
					return;
				case 0:
					info.Emit(OpCodes.Ldc_I4_0);
					return;
				case 1:
					info.Emit(OpCodes.Ldc_I4_1);
					return;
				case 2:
					info.Emit(OpCodes.Ldc_I4_2);
					return;
				case 3:
					info.Emit(OpCodes.Ldc_I4_3);
					return;
				case 4:
					info.Emit(OpCodes.Ldc_I4_4);
					return;
				case 5:
					info.Emit(OpCodes.Ldc_I4_5);
					return;
				case 6:
					info.Emit(OpCodes.Ldc_I4_6);
					return;
				case 7:
					info.Emit(OpCodes.Ldc_I4_7);
					return;
				case 8:
					info.Emit(OpCodes.Ldc_I4_8);
					return;
				default:
					if (caller_start > -129 && caller_start < 128)
					{
						info.Emit(OpCodes.Ldc_I4_S, (sbyte)caller_start);
						return;
					}
					info.Emit(OpCodes.Ldc_I4, caller_start);
					return;
				}
			}

			// Token: 0x06000509 RID: 1289 RVA: 0x000209E4 File Offset: 0x0001EBE4
			private static TaskReader.ExpressionReader PrepareInfo(TaskReader.ExpressionReader ident)
			{
				TaskReader.ExpressionReader expressionReader = ident.IncludeProperty();
				if (expressionReader.UpdateRule())
				{
					object obj = ident.PatchProperty(null);
					if (obj != null && obj.GetType().IsEnum)
					{
						Type underlyingType = Enum.GetUnderlyingType(obj.GetType());
						object ord = Convert.ChangeType(obj, underlyingType);
						TaskReader.ExpressionReader expressionReader2 = TaskReader.SingletonSingletonObject.DeleteInfo(TaskReader.ExpressionReader.RunRule(underlyingType, ord));
						if (expressionReader2 != null)
						{
							return expressionReader2 as TaskReader.ModelAuthenticationReader;
						}
					}
				}
				return ident;
			}

			// Token: 0x0600050A RID: 1290 RVA: 0x00016DBC File Offset: 0x00014FBC
			private static TaskReader.ModelAuthenticationReader DeleteInfo(TaskReader.ExpressionReader i)
			{
				TaskReader.ModelAuthenticationReader modelAuthenticationReader = i as TaskReader.ModelAuthenticationReader;
				if (modelAuthenticationReader == null && i.VisitProperty())
				{
					modelAuthenticationReader = (i.IncludeProperty() as TaskReader.ModelAuthenticationReader);
				}
				return modelAuthenticationReader;
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x00020A48 File Offset: 0x0001EC48
			private static IntPtr CallInfo(object spec)
			{
				if (spec == null)
				{
					return IntPtr.Zero;
				}
				if (spec.PatchRule())
				{
					return ((TaskReader.WorkerAuthenticationReader)spec).QueryAnnotation();
				}
				if (spec.VisitProperty())
				{
					TaskReader.MockReader mockReader = (TaskReader.MockReader)spec;
					IntPtr result;
					try
					{
						result = mockReader.ConcatWatcher();
					}
					catch
					{
						goto IL_28;
					}
					return result;
				}
				IL_28:
				object obj = spec.PatchProperty(typeof(IntPtr));
				if (obj == null || !(obj.GetType() == typeof(IntPtr)))
				{
					throw new TaskReader.IndexerReader();
				}
				return (IntPtr)obj;
			}

			// Token: 0x0600050C RID: 1292 RVA: 0x00020AD8 File Offset: 0x0001ECD8
			private static object RateInfo(object info)
			{
				if (TaskReader.SingletonSingletonObject.dictionary_1 == null)
				{
					TaskReader.SingletonSingletonObject.dictionary_1 = new Dictionary<Type, TaskReader.FacadeReader>();
				}
				if (info == null)
				{
					return null;
				}
				object result;
				try
				{
					Type type = info.GetType();
					TaskReader.FacadeReader facadeReader;
					if (!TaskReader.SingletonSingletonObject.dictionary_1.TryGetValue(type, out facadeReader))
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
						{
							typeof(object)
						}, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Ldarg_0);
						ilgenerator.Emit(OpCodes.Unbox_Any, type);
						ilgenerator.Emit(OpCodes.Box, type);
						ilgenerator.Emit(OpCodes.Ret);
						TaskReader.FacadeReader facadeReader2 = (TaskReader.FacadeReader)dynamicMethod.CreateDelegate(typeof(TaskReader.FacadeReader));
						TaskReader.SingletonSingletonObject.dictionary_1.Add(type, facadeReader2);
						result = facadeReader2(info);
					}
					else
					{
						result = facadeReader(info);
					}
				}
				catch
				{
					result = null;
				}
				return result;
			}

			// Token: 0x0600050D RID: 1293 RVA: 0x00020BCC File Offset: 0x0001EDCC
			private static void ValidateInfo(IntPtr i, byte indexOf_attr, int dirhigh)
			{
				if (TaskReader.SingletonSingletonObject.m_PropertySingleton == null)
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
					{
						typeof(IntPtr),
						typeof(byte),
						typeof(int)
					}, typeof(TaskReader), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldarg_1);
					ilgenerator.Emit(OpCodes.Ldarg_2);
					ilgenerator.Emit(OpCodes.Initblk);
					ilgenerator.Emit(OpCodes.Ret);
					TaskReader.SingletonSingletonObject.m_PropertySingleton = (TaskReader.AdapterWatcherClass)dynamicMethod.CreateDelegate(typeof(TaskReader.AdapterWatcherClass));
				}
				TaskReader.SingletonSingletonObject.m_PropertySingleton(i, indexOf_attr, dirhigh);
			}

			// Token: 0x0600050E RID: 1294 RVA: 0x00020C98 File Offset: 0x0001EE98
			private static void VerifyInfo(IntPtr var1, IntPtr pol, uint ID_state)
			{
				if (TaskReader.SingletonSingletonObject.m_WatcherSingleton == null)
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
					{
						typeof(IntPtr),
						typeof(IntPtr),
						typeof(uint)
					}, typeof(TaskReader), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldarg_1);
					ilgenerator.Emit(OpCodes.Ldarg_2);
					ilgenerator.Emit(OpCodes.Cpblk);
					ilgenerator.Emit(OpCodes.Ret);
					TaskReader.SingletonSingletonObject.m_WatcherSingleton = (TaskReader.RepositoryInstance)dynamicMethod.CreateDelegate(typeof(TaskReader.RepositoryInstance));
				}
				TaskReader.SingletonSingletonObject.m_WatcherSingleton(var1, pol, ID_state);
			}

			// Token: 0x0600050F RID: 1295 RVA: 0x00004F91 File Offset: 0x00003191
			public SingletonSingletonObject()
			{
				AdvisorConnectionAttribute.CancelComposer();
				this._BroadcasterReader = new TaskReader.ExpressionReader[0];
				this._ListenerReader = new TaskReader.ExpressionReader[0];
				this._ComposerReader = new TaskReader.SystemReader();
				this._PageReader = -1;
				base..ctor();
			}

			// Token: 0x06000510 RID: 1296 RVA: 0x000036EC File Offset: 0x000018EC
			[CompilerGenerated]
			private static int PopInfo(TaskReader.FacadeWatcherClass setup, TaskReader.FacadeWatcherClass counter)
			{
				return setup.m_FactoryReader.setterReader.CompareTo(counter.m_FactoryReader.setterReader);
			}

			// Token: 0x06000511 RID: 1297 RVA: 0x00004FC8 File Offset: 0x000031C8
			static SingletonSingletonObject()
			{
				AdvisorConnectionAttribute.CancelComposer();
				TaskReader.SingletonSingletonObject.readerSingleton = new Dictionary<MethodBase, TaskReader.RecordInstance>();
				TaskReader.SingletonSingletonObject.m_SingletonSingleton = new Dictionary<MethodBase, TaskReader.RecordInstance>();
				TaskReader.SingletonSingletonObject.m_RuleSingleton = new Dictionary<TaskReader.ParameterTemplateStatus, TaskReader.RecordInstance>();
				TaskReader.SingletonSingletonObject._AnnotationSingleton = new Dictionary<TaskReader.ParameterTemplateStatus, TaskReader.RecordInstance>();
				TaskReader.SingletonSingletonObject._TemplateSingleton = new Dictionary<TaskReader.ParameterTemplateStatus, TaskReader.RecordInstance>();
			}

			// Token: 0x06000512 RID: 1298 RVA: 0x00005001 File Offset: 0x00003201
			internal static bool MoveBridge()
			{
				return TaskReader.SingletonSingletonObject.CallBridge == null;
			}

			// Token: 0x04000242 RID: 578
			internal TaskReader.SetterRuleTask adapterReader;

			// Token: 0x04000243 RID: 579
			internal TaskReader.ExpressionReader[] _BroadcasterReader;

			// Token: 0x04000244 RID: 580
			internal TaskReader.ExpressionReader[] _ListenerReader;

			// Token: 0x04000245 RID: 581
			internal TaskReader.SystemReader _ComposerReader;

			// Token: 0x04000246 RID: 582
			internal TaskReader.ExpressionReader _CreatorReader;

			// Token: 0x04000247 RID: 583
			internal Exception _ProxyReader;

			// Token: 0x04000248 RID: 584
			internal List<IntPtr> serviceReader;

			// Token: 0x04000249 RID: 585
			private int _RecordReader;

			// Token: 0x0400024A RID: 586
			private int repositoryReader;

			// Token: 0x0400024B RID: 587
			private int _PageReader;

			// Token: 0x0400024C RID: 588
			private object _ValueReader;

			// Token: 0x0400024D RID: 589
			private bool queueReader;

			// Token: 0x0400024E RID: 590
			private bool procReader;

			// Token: 0x0400024F RID: 591
			private bool prototypeSingleton;

			// Token: 0x04000250 RID: 592
			private bool _RefSingleton;

			// Token: 0x04000251 RID: 593
			private static Dictionary<Type, int> dictionary_0;

			// Token: 0x04000252 RID: 594
			private static Dictionary<MethodBase, TaskReader.RecordInstance> readerSingleton;

			// Token: 0x04000253 RID: 595
			private static Dictionary<MethodBase, TaskReader.RecordInstance> m_SingletonSingleton;

			// Token: 0x04000254 RID: 596
			private static Dictionary<TaskReader.ParameterTemplateStatus, TaskReader.RecordInstance> m_RuleSingleton;

			// Token: 0x04000255 RID: 597
			private static Dictionary<TaskReader.ParameterTemplateStatus, TaskReader.RecordInstance> _AnnotationSingleton;

			// Token: 0x04000256 RID: 598
			private static Dictionary<TaskReader.ParameterTemplateStatus, TaskReader.RecordInstance> _TemplateSingleton;

			// Token: 0x04000257 RID: 599
			private static Dictionary<Type, TaskReader.FacadeReader> dictionary_1;

			// Token: 0x04000258 RID: 600
			private static TaskReader.AdapterWatcherClass m_PropertySingleton;

			// Token: 0x04000259 RID: 601
			private static TaskReader.RepositoryInstance m_WatcherSingleton;

			// Token: 0x0400025A RID: 602
			[CompilerGenerated]
			private static Comparison<TaskReader.GlobalReader> m_ConnectionSingleton;

			// Token: 0x0400025B RID: 603
			internal static object CallBridge;
		}

		// Token: 0x0200008C RID: 140
		internal enum XmlReadMode : byte
		{

		}

		// Token: 0x0200008D RID: 141
		internal enum ConstraintValues : byte
		{

		}
	}
}
