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
	// Token: 0x02000053 RID: 83
	public class CircleSpaceScoringMethod : SkirmishScoringMethod
	{
		// Token: 0x06000AE4 RID: 2788 RVA: 0x0008B9A0 File Offset: 0x00089BA0
		// Note: this type is marked as 'beforefieldinit'.
		static CircleSpaceScoringMethod()
		{
			Il2CppClassPointerStore<CircleSpaceScoringMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.ScoringMethods", "CircleSpaceScoringMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircleSpaceScoringMethod>.NativeClassPtr);
			CircleSpaceScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleSpaceScoringMethod>.NativeClassPtr, 100665395);
			CircleSpaceScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleSpaceScoringMethod>.NativeClassPtr, 100665396);
			CircleSpaceScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleSpaceScoringMethod>.NativeClassPtr, 100665397);
			CircleSpaceScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleSpaceScoringMethod>.NativeClassPtr, 100665398);
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0008BA20 File Offset: 0x00089C20
		public unsafe override int MethodID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CircleSpaceScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0008BA68 File Offset: 0x00089C68
		public unsafe override LocalizableTextVariables PromptKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72532, XrefRangeEnd = 72538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CircleSpaceScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0008BAB4 File Offset: 0x00089CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72538, XrefRangeEnd = 72573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CircleSpaceScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishScoreItem>(intPtr3) : null;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0008BB24 File Offset: 0x00089D24
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CircleSpaceScoringMethod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CircleSpaceScoringMethod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleSpaceScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00006BF7 File Offset: 0x00004DF7
		public CircleSpaceScoringMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000616 RID: 1558
		[ObfuscatedName("worm.canis.data.Skirmish.ScoringMethods.CircleSpaceScoringMethod+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06004E35 RID: 20021 RVA: 0x001A1D78 File Offset: 0x0019FF78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CircleSpaceScoringMethod.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CircleSpaceScoringMethod>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircleSpaceScoringMethod.__c__DisplayClass4_0>.NativeClassPtr);
				CircleSpaceScoringMethod.__c__DisplayClass4_0.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleSpaceScoringMethod.__c__DisplayClass4_0>.NativeClassPtr, "wormMatch");
				CircleSpaceScoringMethod.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleSpaceScoringMethod.__c__DisplayClass4_0>.NativeClassPtr, 100665399);
				CircleSpaceScoringMethod.__c__DisplayClass4_0.NativeMethodInfoPtr__Compute_b__0_Internal_Int32_KeyValuePair_2_ArchetypeID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleSpaceScoringMethod.__c__DisplayClass4_0>.NativeClassPtr, 100665400);
			}

			// Token: 0x06004E36 RID: 20022 RVA: 0x001A1DE0 File Offset: 0x0019FFE0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CircleSpaceScoringMethod.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleSpaceScoringMethod.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E37 RID: 20023 RVA: 0x001A1E1C File Offset: 0x001A001C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72514, XrefRangeEnd = 72532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Compute_b__0(KeyValuePair<ArchetypeID, int> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleSpaceScoringMethod.__c__DisplayClass4_0.NativeMethodInfoPtr__Compute_b__0_Internal_Int32_KeyValuePair_2_ArchetypeID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E38 RID: 20024 RVA: 0x0001AFF1 File Offset: 0x000191F1
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700133E RID: 4926
			// (get) Token: 0x06004E39 RID: 20025 RVA: 0x001A1E70 File Offset: 0x001A0070
			// (set) Token: 0x06004E3A RID: 20026 RVA: 0x0001AFFA File Offset: 0x000191FA
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleSpaceScoringMethod.__c__DisplayClass4_0.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleSpaceScoringMethod.__c__DisplayClass4_0.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003356 RID: 13142
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003357 RID: 13143
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003358 RID: 13144
			private static readonly IntPtr NativeMethodInfoPtr__Compute_b__0_Internal_Int32_KeyValuePair_2_ArchetypeID_Int32_0;
		}
	}
}
