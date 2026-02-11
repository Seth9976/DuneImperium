using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.skirmishScripts
{
	// Token: 0x02000049 RID: 73
	public class ReflectionsSkirmishCollections : SkirmishCollections
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x0002B790 File Offset: 0x00029990
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionsSkirmishCollections()
		{
			Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.skirmishScripts", "ReflectionsSkirmishCollections");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr);
			ReflectionsSkirmishCollections.NativeFieldInfoPtr_assemblyReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr, "assemblyReference");
			ReflectionsSkirmishCollections.NativeFieldInfoPtr_allModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr, "allModifiers");
			ReflectionsSkirmishCollections.NativeFieldInfoPtr_allScoringMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr, "allScoringMethods");
			ReflectionsSkirmishCollections.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr, 100664241);
			ReflectionsSkirmishCollections.NativeMethodInfoPtr_FindAllSkirmishRules_Private_IEnumerable_1_SkirmishRulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr, 100664242);
			ReflectionsSkirmishCollections.NativeMethodInfoPtr_get_AllRulesModifiers_Public_Virtual_get_IReadOnlyList_1_SkirmishRulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr, 100664243);
			ReflectionsSkirmishCollections.NativeMethodInfoPtr_FindAllScoringMethods_Private_IEnumerable_1_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr, 100664244);
			ReflectionsSkirmishCollections.NativeMethodInfoPtr_get_AllScoringMethods_Public_Virtual_get_IReadOnlyList_1_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr, 100664245);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0002B860 File Offset: 0x00029A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553592, XrefRangeEnd = 553608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionsSkirmishCollections(string assembly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0002B8AC File Offset: 0x00029AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553608, XrefRangeEnd = 553614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<SkirmishRulesModifier> FindAllSkirmishRules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections.NativeMethodInfoPtr_FindAllSkirmishRules_Private_IEnumerable_1_SkirmishRulesModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SkirmishRulesModifier>>(intPtr3) : null;
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0002B8EC File Offset: 0x00029AEC
		public unsafe override IReadOnlyList<SkirmishRulesModifier> AllRulesModifiers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553614, XrefRangeEnd = 553645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReflectionsSkirmishCollections.NativeMethodInfoPtr_get_AllRulesModifiers_Public_Virtual_get_IReadOnlyList_1_SkirmishRulesModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SkirmishRulesModifier>>(intPtr3) : null;
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0002B938 File Offset: 0x00029B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553645, XrefRangeEnd = 553651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<SkirmishScoringMethod> FindAllScoringMethods()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections.NativeMethodInfoPtr_FindAllScoringMethods_Private_IEnumerable_1_SkirmishScoringMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SkirmishScoringMethod>>(intPtr3) : null;
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0002B978 File Offset: 0x00029B78
		public unsafe override IReadOnlyList<SkirmishScoringMethod> AllScoringMethods
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553651, XrefRangeEnd = 553682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReflectionsSkirmishCollections.NativeMethodInfoPtr_get_AllScoringMethods_Public_Virtual_get_IReadOnlyList_1_SkirmishScoringMethod_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SkirmishScoringMethod>>(intPtr3) : null;
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00003FBA File Offset: 0x000021BA
		public ReflectionsSkirmishCollections(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0002B9C4 File Offset: 0x00029BC4
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00003FC3 File Offset: 0x000021C3
		public unsafe string assemblyReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections.NativeFieldInfoPtr_assemblyReference);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections.NativeFieldInfoPtr_assemblyReference), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0002B9EC File Offset: 0x00029BEC
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00003FE2 File Offset: 0x000021E2
		public unsafe List<SkirmishRulesModifier> allModifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections.NativeFieldInfoPtr_allModifiers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkirmishRulesModifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections.NativeFieldInfoPtr_allModifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0002BA1C File Offset: 0x00029C1C
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00004001 File Offset: 0x00002201
		public unsafe List<SkirmishScoringMethod> allScoringMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections.NativeFieldInfoPtr_allScoringMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkirmishScoringMethod>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections.NativeFieldInfoPtr_allScoringMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeFieldInfoPtr_assemblyReference;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeFieldInfoPtr_allModifiers;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeFieldInfoPtr_allScoringMethods;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_FindAllSkirmishRules_Private_IEnumerable_1_SkirmishRulesModifier_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_get_AllRulesModifiers_Public_Virtual_get_IReadOnlyList_1_SkirmishRulesModifier_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_FindAllScoringMethods_Private_IEnumerable_1_SkirmishScoringMethod_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_get_AllScoringMethods_Public_Virtual_get_IReadOnlyList_1_SkirmishScoringMethod_0;

		// Token: 0x0200029F RID: 671
		[ObfuscatedName("Canis.skirmishScripts.ReflectionsSkirmishCollections+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C57 RID: 7255 RVA: 0x000871D4 File Offset: 0x000853D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReflectionsSkirmishCollections.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionsSkirmishCollections.__c>.NativeClassPtr);
				ReflectionsSkirmishCollections.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections.__c>.NativeClassPtr, "<>9");
				ReflectionsSkirmishCollections.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections.__c>.NativeClassPtr, "<>9__6_0");
				ReflectionsSkirmishCollections.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections.__c>.NativeClassPtr, "<>9__9_0");
				ReflectionsSkirmishCollections.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections.__c>.NativeClassPtr, 100664247);
				ReflectionsSkirmishCollections.__c.NativeMethodInfoPtr__get_AllRulesModifiers_b__6_0_Internal_Int32_SkirmishRulesModifier_SkirmishRulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections.__c>.NativeClassPtr, 100664248);
				ReflectionsSkirmishCollections.__c.NativeMethodInfoPtr__get_AllScoringMethods_b__9_0_Internal_Int32_SkirmishScoringMethod_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections.__c>.NativeClassPtr, 100664249);
			}

			// Token: 0x06001C58 RID: 7256 RVA: 0x00087278 File Offset: 0x00085478
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionsSkirmishCollections.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C59 RID: 7257 RVA: 0x000872B4 File Offset: 0x000854B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_AllRulesModifiers_b__6_0(SkirmishRulesModifier a, SkirmishRulesModifier b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections.__c.NativeMethodInfoPtr__get_AllRulesModifiers_b__6_0_Internal_Int32_SkirmishRulesModifier_SkirmishRulesModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C5A RID: 7258 RVA: 0x00087314 File Offset: 0x00085514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_AllScoringMethods_b__9_0(SkirmishScoringMethod a, SkirmishScoringMethod b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections.__c.NativeMethodInfoPtr__get_AllScoringMethods_b__9_0_Internal_Int32_SkirmishScoringMethod_SkirmishScoringMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C5B RID: 7259 RVA: 0x0000D87C File Offset: 0x0000BA7C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700068A RID: 1674
			// (get) Token: 0x06001C5C RID: 7260 RVA: 0x00087374 File Offset: 0x00085574
			// (set) Token: 0x06001C5D RID: 7261 RVA: 0x0000D885 File Offset: 0x0000BA85
			public unsafe static ReflectionsSkirmishCollections.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReflectionsSkirmishCollections.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionsSkirmishCollections.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionsSkirmishCollections.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068B RID: 1675
			// (get) Token: 0x06001C5E RID: 7262 RVA: 0x0008739C File Offset: 0x0008559C
			// (set) Token: 0x06001C5F RID: 7263 RVA: 0x0000D897 File Offset: 0x0000BA97
			public unsafe static Comparison<SkirmishRulesModifier> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReflectionsSkirmishCollections.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<SkirmishRulesModifier>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionsSkirmishCollections.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068C RID: 1676
			// (get) Token: 0x06001C60 RID: 7264 RVA: 0x000873C4 File Offset: 0x000855C4
			// (set) Token: 0x06001C61 RID: 7265 RVA: 0x0000D8A9 File Offset: 0x0000BAA9
			public unsafe static Comparison<SkirmishScoringMethod> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReflectionsSkirmishCollections.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<SkirmishScoringMethod>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionsSkirmishCollections.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001215 RID: 4629
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001216 RID: 4630
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04001217 RID: 4631
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04001218 RID: 4632
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001219 RID: 4633
			private static readonly IntPtr NativeMethodInfoPtr__get_AllRulesModifiers_b__6_0_Internal_Int32_SkirmishRulesModifier_SkirmishRulesModifier_0;

			// Token: 0x0400121A RID: 4634
			private static readonly IntPtr NativeMethodInfoPtr__get_AllScoringMethods_b__9_0_Internal_Int32_SkirmishScoringMethod_SkirmishScoringMethod_0;
		}

		// Token: 0x020002A0 RID: 672
		[ObfuscatedName("Canis.skirmishScripts.ReflectionsSkirmishCollections+<FindAllScoringMethods>d__7")]
		public sealed class _FindAllScoringMethods_d__7 : Object
		{
			// Token: 0x06001C62 RID: 7266 RVA: 0x000873EC File Offset: 0x000855EC
			// Note: this type is marked as 'beforefieldinit'.
			static _FindAllScoringMethods_d__7()
			{
				Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr, "<FindAllScoringMethods>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr);
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, "<>1__state");
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, "<>2__current");
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, "<>l__initialThreadId");
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, "<>4__this");
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr__rulesModifierType_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, "<rulesModifierType>5__2");
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, "<>7__wrap2");
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, 100664250);
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, 100664251);
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, 100664252);
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, 100664253);
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_skirmishScripts_SkirmishScoringMethod__get_Current_Private_Virtual_Final_New_get_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, 100664254);
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, 100664255);
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, 100664256);
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_skirmishScripts_SkirmishScoringMethod__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, 100664257);
				ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr, 100664258);
			}

			// Token: 0x06001C63 RID: 7267 RVA: 0x00087544 File Offset: 0x00085744
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FindAllScoringMethods_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllScoringMethods_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C64 RID: 7268 RVA: 0x0008758C File Offset: 0x0008578C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553478, XrefRangeEnd = 553483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C65 RID: 7269 RVA: 0x000875C0 File Offset: 0x000857C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553483, XrefRangeEnd = 553525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C66 RID: 7270 RVA: 0x000875FC File Offset: 0x000857FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553525, XrefRangeEnd = 553528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000693 RID: 1683
			// (get) Token: 0x06001C67 RID: 7271 RVA: 0x00087630 File Offset: 0x00085830
			public unsafe SkirmishScoringMethod System.Collections.Generic.IEnumerator<Canis.skirmishScripts.SkirmishScoringMethod>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_skirmishScripts_SkirmishScoringMethod__get_Current_Private_Virtual_Final_New_get_SkirmishScoringMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishScoringMethod>(intPtr3) : null;
				}
			}

			// Token: 0x06001C68 RID: 7272 RVA: 0x00087670 File Offset: 0x00085870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553528, XrefRangeEnd = 553533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000694 RID: 1684
			// (get) Token: 0x06001C69 RID: 7273 RVA: 0x000876A4 File Offset: 0x000858A4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C6A RID: 7274 RVA: 0x000876E4 File Offset: 0x000858E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553533, XrefRangeEnd = 553535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<SkirmishScoringMethod> System_Collections_Generic_IEnumerable_Canis_skirmishScripts_SkirmishScoringMethod__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_skirmishScripts_SkirmishScoringMethod__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SkirmishScoringMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<SkirmishScoringMethod>>(intPtr3) : null;
			}

			// Token: 0x06001C6B RID: 7275 RVA: 0x00087724 File Offset: 0x00085924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001C6C RID: 7276 RVA: 0x0000D8BB File Offset: 0x0000BABB
			public _FindAllScoringMethods_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700068D RID: 1677
			// (get) Token: 0x06001C6D RID: 7277 RVA: 0x00087764 File Offset: 0x00085964
			// (set) Token: 0x06001C6E RID: 7278 RVA: 0x0000D8C4 File Offset: 0x0000BAC4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x06001C6F RID: 7279 RVA: 0x0008778C File Offset: 0x0008598C
			// (set) Token: 0x06001C70 RID: 7280 RVA: 0x0000D8DF File Offset: 0x0000BADF
			public unsafe SkirmishScoringMethod __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkirmishScoringMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x06001C71 RID: 7281 RVA: 0x000877BC File Offset: 0x000859BC
			// (set) Token: 0x06001C72 RID: 7282 RVA: 0x0000D8FE File Offset: 0x0000BAFE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x06001C73 RID: 7283 RVA: 0x000877E4 File Offset: 0x000859E4
			// (set) Token: 0x06001C74 RID: 7284 RVA: 0x0000D919 File Offset: 0x0000BB19
			public unsafe ReflectionsSkirmishCollections __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionsSkirmishCollections>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x06001C75 RID: 7285 RVA: 0x00087814 File Offset: 0x00085A14
			// (set) Token: 0x06001C76 RID: 7286 RVA: 0x0000D938 File Offset: 0x0000BB38
			public unsafe Type _rulesModifierType_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr__rulesModifierType_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr__rulesModifierType_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x06001C77 RID: 7287 RVA: 0x00087844 File Offset: 0x00085A44
			// (set) Token: 0x06001C78 RID: 7288 RVA: 0x0000D957 File Offset: 0x0000BB57
			public unsafe IEnumerator<Type> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllScoringMethods_d__7.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400121B RID: 4635
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400121C RID: 4636
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400121D RID: 4637
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400121E RID: 4638
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400121F RID: 4639
			private static readonly IntPtr NativeFieldInfoPtr__rulesModifierType_5__2;

			// Token: 0x04001220 RID: 4640
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001221 RID: 4641
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001222 RID: 4642
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001223 RID: 4643
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001224 RID: 4644
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001225 RID: 4645
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_skirmishScripts_SkirmishScoringMethod__get_Current_Private_Virtual_Final_New_get_SkirmishScoringMethod_0;

			// Token: 0x04001226 RID: 4646
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001227 RID: 4647
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001228 RID: 4648
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_skirmishScripts_SkirmishScoringMethod__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SkirmishScoringMethod_0;

			// Token: 0x04001229 RID: 4649
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020002A1 RID: 673
		[ObfuscatedName("Canis.skirmishScripts.ReflectionsSkirmishCollections+<FindAllSkirmishRules>d__4")]
		public sealed class _FindAllSkirmishRules_d__4 : Object
		{
			// Token: 0x06001C79 RID: 7289 RVA: 0x00087874 File Offset: 0x00085A74
			// Note: this type is marked as 'beforefieldinit'.
			static _FindAllSkirmishRules_d__4()
			{
				Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionsSkirmishCollections>.NativeClassPtr, "<FindAllSkirmishRules>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr);
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, "<>1__state");
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, "<>2__current");
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, "<>l__initialThreadId");
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, "<>4__this");
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr__rulesModifierType_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, "<rulesModifierType>5__2");
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, "<>7__wrap2");
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, 100664259);
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, 100664260);
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, 100664261);
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, 100664262);
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_skirmishScripts_SkirmishRulesModifier__get_Current_Private_Virtual_Final_New_get_SkirmishRulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, 100664263);
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, 100664264);
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, 100664265);
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_skirmishScripts_SkirmishRulesModifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SkirmishRulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, 100664266);
				ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr, 100664267);
			}

			// Token: 0x06001C7A RID: 7290 RVA: 0x000879CC File Offset: 0x00085BCC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FindAllSkirmishRules_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C7B RID: 7291 RVA: 0x00087A14 File Offset: 0x00085C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553535, XrefRangeEnd = 553540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C7C RID: 7292 RVA: 0x00087A48 File Offset: 0x00085C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553540, XrefRangeEnd = 553582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C7D RID: 7293 RVA: 0x00087A84 File Offset: 0x00085C84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553582, XrefRangeEnd = 553585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x06001C7E RID: 7294 RVA: 0x00087AB8 File Offset: 0x00085CB8
			public unsafe SkirmishRulesModifier System.Collections.Generic.IEnumerator<Canis.skirmishScripts.SkirmishRulesModifier>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_skirmishScripts_SkirmishRulesModifier__get_Current_Private_Virtual_Final_New_get_SkirmishRulesModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishRulesModifier>(intPtr3) : null;
				}
			}

			// Token: 0x06001C7F RID: 7295 RVA: 0x00087AF8 File Offset: 0x00085CF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553585, XrefRangeEnd = 553590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x06001C80 RID: 7296 RVA: 0x00087B2C File Offset: 0x00085D2C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C81 RID: 7297 RVA: 0x00087B6C File Offset: 0x00085D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553590, XrefRangeEnd = 553592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<SkirmishRulesModifier> System_Collections_Generic_IEnumerable_Canis_skirmishScripts_SkirmishRulesModifier__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_skirmishScripts_SkirmishRulesModifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SkirmishRulesModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<SkirmishRulesModifier>>(intPtr3) : null;
			}

			// Token: 0x06001C82 RID: 7298 RVA: 0x00087BAC File Offset: 0x00085DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001C83 RID: 7299 RVA: 0x0000D976 File Offset: 0x0000BB76
			public _FindAllSkirmishRules_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000695 RID: 1685
			// (get) Token: 0x06001C84 RID: 7300 RVA: 0x00087BEC File Offset: 0x00085DEC
			// (set) Token: 0x06001C85 RID: 7301 RVA: 0x0000D97F File Offset: 0x0000BB7F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000696 RID: 1686
			// (get) Token: 0x06001C86 RID: 7302 RVA: 0x00087C14 File Offset: 0x00085E14
			// (set) Token: 0x06001C87 RID: 7303 RVA: 0x0000D99A File Offset: 0x0000BB9A
			public unsafe SkirmishRulesModifier __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkirmishRulesModifier>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000697 RID: 1687
			// (get) Token: 0x06001C88 RID: 7304 RVA: 0x00087C44 File Offset: 0x00085E44
			// (set) Token: 0x06001C89 RID: 7305 RVA: 0x0000D9B9 File Offset: 0x0000BBB9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000698 RID: 1688
			// (get) Token: 0x06001C8A RID: 7306 RVA: 0x00087C6C File Offset: 0x00085E6C
			// (set) Token: 0x06001C8B RID: 7307 RVA: 0x0000D9D4 File Offset: 0x0000BBD4
			public unsafe ReflectionsSkirmishCollections __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionsSkirmishCollections>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x06001C8C RID: 7308 RVA: 0x00087C9C File Offset: 0x00085E9C
			// (set) Token: 0x06001C8D RID: 7309 RVA: 0x0000D9F3 File Offset: 0x0000BBF3
			public unsafe Type _rulesModifierType_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr__rulesModifierType_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr__rulesModifierType_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x06001C8E RID: 7310 RVA: 0x00087CCC File Offset: 0x00085ECC
			// (set) Token: 0x06001C8F RID: 7311 RVA: 0x0000DA12 File Offset: 0x0000BC12
			public unsafe IEnumerator<Type> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionsSkirmishCollections._FindAllSkirmishRules_d__4.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400122A RID: 4650
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400122B RID: 4651
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400122C RID: 4652
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400122D RID: 4653
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400122E RID: 4654
			private static readonly IntPtr NativeFieldInfoPtr__rulesModifierType_5__2;

			// Token: 0x0400122F RID: 4655
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001230 RID: 4656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001231 RID: 4657
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001232 RID: 4658
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001233 RID: 4659
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001234 RID: 4660
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_skirmishScripts_SkirmishRulesModifier__get_Current_Private_Virtual_Final_New_get_SkirmishRulesModifier_0;

			// Token: 0x04001235 RID: 4661
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001236 RID: 4662
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001237 RID: 4663
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_skirmishScripts_SkirmishRulesModifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_SkirmishRulesModifier_0;

			// Token: 0x04001238 RID: 4664
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
