using System;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lib.canis.worm_canis.data.Skirmish.ScoringMethods;
using worm.canis.entities;

namespace worm.canis.data.Skirmish.ScoringMethods
{
	// Token: 0x0200005F RID: 95
	public class PentagonSpaceScoringMethod : SkirmishScoringMethod
	{
		// Token: 0x06000B2C RID: 2860 RVA: 0x0008CEA0 File Offset: 0x0008B0A0
		// Note: this type is marked as 'beforefieldinit'.
		static PentagonSpaceScoringMethod()
		{
			Il2CppClassPointerStore<PentagonSpaceScoringMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.ScoringMethods", "PentagonSpaceScoringMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PentagonSpaceScoringMethod>.NativeClassPtr);
			PentagonSpaceScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PentagonSpaceScoringMethod>.NativeClassPtr, 100665448);
			PentagonSpaceScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PentagonSpaceScoringMethod>.NativeClassPtr, 100665449);
			PentagonSpaceScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PentagonSpaceScoringMethod>.NativeClassPtr, 100665450);
			PentagonSpaceScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PentagonSpaceScoringMethod>.NativeClassPtr, 100665451);
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0008CF20 File Offset: 0x0008B120
		public unsafe override int MethodID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PentagonSpaceScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x0008CF68 File Offset: 0x0008B168
		public unsafe override LocalizableTextVariables PromptKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72859, XrefRangeEnd = 72865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PentagonSpaceScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0008CFB4 File Offset: 0x0008B1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72865, XrefRangeEnd = 72900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SkirmishScoreItem Compute(WormMatch wormMatch, WormPlayer wormPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wormPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PentagonSpaceScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishScoreItem>(intPtr3) : null;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0008D024 File Offset: 0x0008B224
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PentagonSpaceScoringMethod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PentagonSpaceScoringMethod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PentagonSpaceScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00006C63 File Offset: 0x00004E63
		public PentagonSpaceScoringMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000618 RID: 1560
		[ObfuscatedName("worm.canis.data.Skirmish.ScoringMethods.PentagonSpaceScoringMethod+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06004E43 RID: 20035 RVA: 0x001A1FF8 File Offset: 0x001A01F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<PentagonSpaceScoringMethod.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PentagonSpaceScoringMethod>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PentagonSpaceScoringMethod.__c__DisplayClass4_0>.NativeClassPtr);
				PentagonSpaceScoringMethod.__c__DisplayClass4_0.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PentagonSpaceScoringMethod.__c__DisplayClass4_0>.NativeClassPtr, "wormMatch");
				PentagonSpaceScoringMethod.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PentagonSpaceScoringMethod.__c__DisplayClass4_0>.NativeClassPtr, 100665452);
				PentagonSpaceScoringMethod.__c__DisplayClass4_0.NativeMethodInfoPtr__Compute_b__0_Internal_Int32_KeyValuePair_2_ArchetypeID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PentagonSpaceScoringMethod.__c__DisplayClass4_0>.NativeClassPtr, 100665453);
			}

			// Token: 0x06004E44 RID: 20036 RVA: 0x001A2060 File Offset: 0x001A0260
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PentagonSpaceScoringMethod.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PentagonSpaceScoringMethod.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E45 RID: 20037 RVA: 0x001A209C File Offset: 0x001A029C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72841, XrefRangeEnd = 72859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Compute_b__0(KeyValuePair<ArchetypeID, int> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PentagonSpaceScoringMethod.__c__DisplayClass4_0.NativeMethodInfoPtr__Compute_b__0_Internal_Int32_KeyValuePair_2_ArchetypeID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E46 RID: 20038 RVA: 0x0001B046 File Offset: 0x00019246
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001341 RID: 4929
			// (get) Token: 0x06004E47 RID: 20039 RVA: 0x001A20F0 File Offset: 0x001A02F0
			// (set) Token: 0x06004E48 RID: 20040 RVA: 0x0001B04F File Offset: 0x0001924F
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PentagonSpaceScoringMethod.__c__DisplayClass4_0.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PentagonSpaceScoringMethod.__c__DisplayClass4_0.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400335D RID: 13149
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x0400335E RID: 13150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400335F RID: 13151
			private static readonly IntPtr NativeMethodInfoPtr__Compute_b__0_Internal_Int32_KeyValuePair_2_ArchetypeID_Int32_0;
		}
	}
}
