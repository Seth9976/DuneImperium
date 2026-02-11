using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lib.canis.worm_canis.data.Skirmish.ScoringMethods;
using worm.canis.entities;

namespace worm.canis.data.Skirmish.ScoringMethods.RiseOfIx
{
	// Token: 0x02000070 RID: 112
	public class TechnologicalDiversityScoringMethod : SkirmishScoringMethod
	{
		// Token: 0x06000B92 RID: 2962 RVA: 0x0008EC60 File Offset: 0x0008CE60
		// Note: this type is marked as 'beforefieldinit'.
		static TechnologicalDiversityScoringMethod()
		{
			Il2CppClassPointerStore<TechnologicalDiversityScoringMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.ScoringMethods.RiseOfIx", "TechnologicalDiversityScoringMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TechnologicalDiversityScoringMethod>.NativeClassPtr);
			TechnologicalDiversityScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechnologicalDiversityScoringMethod>.NativeClassPtr, 100665520);
			TechnologicalDiversityScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechnologicalDiversityScoringMethod>.NativeClassPtr, 100665521);
			TechnologicalDiversityScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechnologicalDiversityScoringMethod>.NativeClassPtr, 100665522);
			TechnologicalDiversityScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechnologicalDiversityScoringMethod>.NativeClassPtr, 100665523);
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0008ECE0 File Offset: 0x0008CEE0
		public unsafe override int MethodID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TechnologicalDiversityScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0008ED28 File Offset: 0x0008CF28
		public unsafe override LocalizableTextVariables PromptKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73270, XrefRangeEnd = 73276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TechnologicalDiversityScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0008ED74 File Offset: 0x0008CF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73276, XrefRangeEnd = 73316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TechnologicalDiversityScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishScoreItem>(intPtr3) : null;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0008EDE4 File Offset: 0x0008CFE4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TechnologicalDiversityScoringMethod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TechnologicalDiversityScoringMethod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TechnologicalDiversityScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00006CFC File Offset: 0x00004EFC
		public TechnologicalDiversityScoringMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200061A RID: 1562
		[ObfuscatedName("worm.canis.data.Skirmish.ScoringMethods.RiseOfIx.TechnologicalDiversityScoringMethod+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004E4F RID: 20047 RVA: 0x001A2248 File Offset: 0x001A0448
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TechnologicalDiversityScoringMethod.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TechnologicalDiversityScoringMethod>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TechnologicalDiversityScoringMethod.__c>.NativeClassPtr);
				TechnologicalDiversityScoringMethod.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechnologicalDiversityScoringMethod.__c>.NativeClassPtr, "<>9");
				TechnologicalDiversityScoringMethod.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechnologicalDiversityScoringMethod.__c>.NativeClassPtr, "<>9__4_0");
				TechnologicalDiversityScoringMethod.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechnologicalDiversityScoringMethod.__c>.NativeClassPtr, 100665525);
				TechnologicalDiversityScoringMethod.__c.NativeMethodInfoPtr__Compute_b__4_0_Internal_Int32_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechnologicalDiversityScoringMethod.__c>.NativeClassPtr, 100665526);
			}

			// Token: 0x06004E50 RID: 20048 RVA: 0x001A22C4 File Offset: 0x001A04C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TechnologicalDiversityScoringMethod.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TechnologicalDiversityScoringMethod.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E51 RID: 20049 RVA: 0x001A2300 File Offset: 0x001A0500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73269, XrefRangeEnd = 73270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Compute_b__4_0(WormTechTilePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TechnologicalDiversityScoringMethod.__c.NativeMethodInfoPtr__Compute_b__4_0_Internal_Int32_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E52 RID: 20050 RVA: 0x0001B096 File Offset: 0x00019296
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001343 RID: 4931
			// (get) Token: 0x06004E53 RID: 20051 RVA: 0x001A2350 File Offset: 0x001A0550
			// (set) Token: 0x06004E54 RID: 20052 RVA: 0x0001B09F File Offset: 0x0001929F
			public unsafe static TechnologicalDiversityScoringMethod.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TechnologicalDiversityScoringMethod.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TechnologicalDiversityScoringMethod.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TechnologicalDiversityScoringMethod.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001344 RID: 4932
			// (get) Token: 0x06004E55 RID: 20053 RVA: 0x001A2378 File Offset: 0x001A0578
			// (set) Token: 0x06004E56 RID: 20054 RVA: 0x0001B0B1 File Offset: 0x000192B1
			public unsafe static Func<WormTechTilePlayable, int> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TechnologicalDiversityScoringMethod.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTilePlayable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TechnologicalDiversityScoringMethod.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003363 RID: 13155
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003364 RID: 13156
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04003365 RID: 13157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003366 RID: 13158
			private static readonly IntPtr NativeMethodInfoPtr__Compute_b__4_0_Internal_Int32_WormTechTilePlayable_0;
		}
	}
}
