using System;
using boardgames.menus.prompts;
using dbgclient.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;

namespace worm
{
	// Token: 0x02000053 RID: 83
	public class WormMatchStatsBehaviour : MatchStatsBehaviour
	{
		// Token: 0x0600035B RID: 859 RVA: 0x0002348C File Offset: 0x0002168C
		// Note: this type is marked as 'beforefieldinit'.
		static WormMatchStatsBehaviour()
		{
			Il2CppClassPointerStore<WormMatchStatsBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormMatchStatsBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatchStatsBehaviour>.NativeClassPtr);
			WormMatchStatsBehaviour.NativeMethodInfoPtr_GetCategoryValues_Protected_Virtual_ValueTuple_2_String_String_CategoryDefinition_MatchStatsData_List_1_MatchStatsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchStatsBehaviour>.NativeClassPtr, 100663847);
			WormMatchStatsBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchStatsBehaviour>.NativeClassPtr, 100663848);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000234E4 File Offset: 0x000216E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691598, XrefRangeEnd = 692041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueTuple<string, string> GetCategoryValues(CategoryDefinition category, MatchStatsData ownerData, List<MatchStatsData> friendData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ownerData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(friendData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatchStatsBehaviour.NativeMethodInfoPtr_GetCategoryValues_Protected_Virtual_ValueTuple_2_String_String_CategoryDefinition_MatchStatsData_List_1_MatchStatsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<string, string>(intPtr);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0002355C File Offset: 0x0002175C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692041, XrefRangeEnd = 692042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMatchStatsBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatchStatsBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchStatsBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00003858 File Offset: 0x00001A58
		public WormMatchStatsBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_GetCategoryValues_Protected_Virtual_ValueTuple_2_String_String_CategoryDefinition_MatchStatsData_List_1_MatchStatsData_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002E8 RID: 744
		[ObfuscatedName("worm.WormMatchStatsBehaviour+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06001E42 RID: 7746 RVA: 0x00074D30 File Offset: 0x00072F30
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatchStatsBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr);
				WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, "<>9");
				WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, "<>9__0_0");
				WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, "<>9__0_1");
				WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, "<>9__0_3");
				WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, "<>9__0_4");
				WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, "<>9__0_6");
				WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, "<>9__0_7");
				WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, 100663850);
				WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__0_0_Internal_Int32_MatchStatsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, 100663851);
				WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__0_1_Internal_Int32_MatchStatsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, 100663852);
				WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__0_3_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, 100663853);
				WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__0_4_Internal_Int32_IGrouping_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, 100663854);
				WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__0_6_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, 100663855);
				WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__0_7_Internal_Int32_IGrouping_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr, 100663856);
			}

			// Token: 0x06001E43 RID: 7747 RVA: 0x00074E74 File Offset: 0x00073074
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E44 RID: 7748 RVA: 0x00074EB0 File Offset: 0x000730B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetCategoryValues_b__0_0(MatchStatsData entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__0_0_Internal_Int32_MatchStatsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E45 RID: 7749 RVA: 0x00074F00 File Offset: 0x00073100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetCategoryValues_b__0_1(MatchStatsData entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__0_1_Internal_Int32_MatchStatsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E46 RID: 7750 RVA: 0x00074F50 File Offset: 0x00073150
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetCategoryValues_b__0_3(string data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__0_3_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001E47 RID: 7751 RVA: 0x00074F98 File Offset: 0x00073198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691590, XrefRangeEnd = 691593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetCategoryValues_b__0_4(IGrouping<string, string> group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__0_4_Internal_Int32_IGrouping_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E48 RID: 7752 RVA: 0x00074FE8 File Offset: 0x000731E8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetCategoryValues_b__0_6(string data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__0_6_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001E49 RID: 7753 RVA: 0x00075030 File Offset: 0x00073230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691593, XrefRangeEnd = 691596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetCategoryValues_b__0_7(IGrouping<string, string> group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__0_7_Internal_Int32_IGrouping_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E4A RID: 7754 RVA: 0x00011347 File Offset: 0x0000F547
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700084E RID: 2126
			// (get) Token: 0x06001E4B RID: 7755 RVA: 0x00075080 File Offset: 0x00073280
			// (set) Token: 0x06001E4C RID: 7756 RVA: 0x00011350 File Offset: 0x0000F550
			public unsafe static WormMatchStatsBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatchStatsBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084F RID: 2127
			// (get) Token: 0x06001E4D RID: 7757 RVA: 0x000750A8 File Offset: 0x000732A8
			// (set) Token: 0x06001E4E RID: 7758 RVA: 0x00011362 File Offset: 0x0000F562
			public unsafe static Func<MatchStatsData, int> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchStatsData, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000850 RID: 2128
			// (get) Token: 0x06001E4F RID: 7759 RVA: 0x000750D0 File Offset: 0x000732D0
			// (set) Token: 0x06001E50 RID: 7760 RVA: 0x00011374 File Offset: 0x0000F574
			public unsafe static Func<MatchStatsData, int> __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchStatsData, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000851 RID: 2129
			// (get) Token: 0x06001E51 RID: 7761 RVA: 0x000750F8 File Offset: 0x000732F8
			// (set) Token: 0x06001E52 RID: 7762 RVA: 0x00011386 File Offset: 0x0000F586
			public unsafe static Func<string, string> __9__0_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000852 RID: 2130
			// (get) Token: 0x06001E53 RID: 7763 RVA: 0x00075120 File Offset: 0x00073320
			// (set) Token: 0x06001E54 RID: 7764 RVA: 0x00011398 File Offset: 0x0000F598
			public unsafe static Func<IGrouping<string, string>, int> __9__0_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, string>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000853 RID: 2131
			// (get) Token: 0x06001E55 RID: 7765 RVA: 0x00075148 File Offset: 0x00073348
			// (set) Token: 0x06001E56 RID: 7766 RVA: 0x000113AA File Offset: 0x0000F5AA
			public unsafe static Func<string, string> __9__0_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000854 RID: 2132
			// (get) Token: 0x06001E57 RID: 7767 RVA: 0x00075170 File Offset: 0x00073370
			// (set) Token: 0x06001E58 RID: 7768 RVA: 0x000113BC File Offset: 0x0000F5BC
			public unsafe static Func<IGrouping<string, string>, int> __9__0_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, string>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatchStatsBehaviour.__c.NativeFieldInfoPtr___9__0_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400118A RID: 4490
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400118B RID: 4491
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x0400118C RID: 4492
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x0400118D RID: 4493
			private static readonly IntPtr NativeFieldInfoPtr___9__0_3;

			// Token: 0x0400118E RID: 4494
			private static readonly IntPtr NativeFieldInfoPtr___9__0_4;

			// Token: 0x0400118F RID: 4495
			private static readonly IntPtr NativeFieldInfoPtr___9__0_6;

			// Token: 0x04001190 RID: 4496
			private static readonly IntPtr NativeFieldInfoPtr___9__0_7;

			// Token: 0x04001191 RID: 4497
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001192 RID: 4498
			private static readonly IntPtr NativeMethodInfoPtr__GetCategoryValues_b__0_0_Internal_Int32_MatchStatsData_0;

			// Token: 0x04001193 RID: 4499
			private static readonly IntPtr NativeMethodInfoPtr__GetCategoryValues_b__0_1_Internal_Int32_MatchStatsData_0;

			// Token: 0x04001194 RID: 4500
			private static readonly IntPtr NativeMethodInfoPtr__GetCategoryValues_b__0_3_Internal_String_String_0;

			// Token: 0x04001195 RID: 4501
			private static readonly IntPtr NativeMethodInfoPtr__GetCategoryValues_b__0_4_Internal_Int32_IGrouping_2_String_String_0;

			// Token: 0x04001196 RID: 4502
			private static readonly IntPtr NativeMethodInfoPtr__GetCategoryValues_b__0_6_Internal_String_String_0;

			// Token: 0x04001197 RID: 4503
			private static readonly IntPtr NativeMethodInfoPtr__GetCategoryValues_b__0_7_Internal_Int32_IGrouping_2_String_String_0;
		}

		// Token: 0x020002E9 RID: 745
		[ObfuscatedName("worm.WormMatchStatsBehaviour+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x06001E59 RID: 7769 RVA: 0x00075198 File Offset: 0x00073398
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<WormMatchStatsBehaviour.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatchStatsBehaviour>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c__DisplayClass0_0>.NativeClassPtr);
				WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeFieldInfoPtr_filters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c__DisplayClass0_0>.NativeClassPtr, "filters");
				WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeFieldInfoPtr_leaderKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c__DisplayClass0_0>.NativeClassPtr, "leaderKeys");
				WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeFieldInfoPtr_allianceKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c__DisplayClass0_0>.NativeClassPtr, "allianceKeys");
				WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c__DisplayClass0_0>.NativeClassPtr, 100663857);
				WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeMethodInfoPtr__GetCategoryValues_b__2_Internal_String_MatchStatsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c__DisplayClass0_0>.NativeClassPtr, 100663858);
				WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeMethodInfoPtr__GetCategoryValues_b__5_Internal_String_MatchStatsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c__DisplayClass0_0>.NativeClassPtr, 100663859);
			}

			// Token: 0x06001E5A RID: 7770 RVA: 0x0007523C File Offset: 0x0007343C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatchStatsBehaviour.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E5B RID: 7771 RVA: 0x00075278 File Offset: 0x00073478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691596, XrefRangeEnd = 691597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetCategoryValues_b__2(MatchStatsData _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeMethodInfoPtr__GetCategoryValues_b__2_Internal_String_MatchStatsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001E5C RID: 7772 RVA: 0x000752C0 File Offset: 0x000734C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691597, XrefRangeEnd = 691598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetCategoryValues_b__5(MatchStatsData _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeMethodInfoPtr__GetCategoryValues_b__5_Internal_String_MatchStatsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001E5D RID: 7773 RVA: 0x000113CE File Offset: 0x0000F5CE
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000855 RID: 2133
			// (get) Token: 0x06001E5E RID: 7774 RVA: 0x00075308 File Offset: 0x00073508
			// (set) Token: 0x06001E5F RID: 7775 RVA: 0x000113D7 File Offset: 0x0000F5D7
			public unsafe List<StatsFilter> filters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeFieldInfoPtr_filters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StatsFilter>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeFieldInfoPtr_filters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000856 RID: 2134
			// (get) Token: 0x06001E60 RID: 7776 RVA: 0x00075338 File Offset: 0x00073538
			// (set) Token: 0x06001E61 RID: 7777 RVA: 0x000113F6 File Offset: 0x0000F5F6
			public unsafe Il2CppStringArray leaderKeys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeFieldInfoPtr_leaderKeys);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeFieldInfoPtr_leaderKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000857 RID: 2135
			// (get) Token: 0x06001E62 RID: 7778 RVA: 0x00075368 File Offset: 0x00073568
			// (set) Token: 0x06001E63 RID: 7779 RVA: 0x00011415 File Offset: 0x0000F615
			public unsafe Il2CppStringArray allianceKeys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeFieldInfoPtr_allianceKeys);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchStatsBehaviour.__c__DisplayClass0_0.NativeFieldInfoPtr_allianceKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001198 RID: 4504
			private static readonly IntPtr NativeFieldInfoPtr_filters;

			// Token: 0x04001199 RID: 4505
			private static readonly IntPtr NativeFieldInfoPtr_leaderKeys;

			// Token: 0x0400119A RID: 4506
			private static readonly IntPtr NativeFieldInfoPtr_allianceKeys;

			// Token: 0x0400119B RID: 4507
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400119C RID: 4508
			private static readonly IntPtr NativeMethodInfoPtr__GetCategoryValues_b__2_Internal_String_MatchStatsData_0;

			// Token: 0x0400119D RID: 4509
			private static readonly IntPtr NativeMethodInfoPtr__GetCategoryValues_b__5_Internal_String_MatchStatsData_0;
		}
	}
}
