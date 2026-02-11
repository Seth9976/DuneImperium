using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.data
{
	// Token: 0x0200013B RID: 315
	public class DailyChallengeRulesData : DataComponent
	{
		// Token: 0x06001058 RID: 4184 RVA: 0x0004331C File Offset: 0x0004151C
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeRulesData()
		{
			Il2CppClassPointerStore<DailyChallengeRulesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data", "DailyChallengeRulesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeRulesData>.NativeClassPtr);
			DailyChallengeRulesData.NativeFieldInfoPtr_RuleMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeRulesData>.NativeClassPtr, "RuleMods");
			DailyChallengeRulesData.NativeFieldInfoPtr_ScoringMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeRulesData>.NativeClassPtr, "ScoringMethods");
			DailyChallengeRulesData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_Int32_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeRulesData>.NativeClassPtr, 100665694);
			DailyChallengeRulesData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeRulesData>.NativeClassPtr, 100665695);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0004339C File Offset: 0x0004159C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 999237, RefRangeEnd = 999238, XrefRangeStart = 999228, XrefRangeEnd = 999237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeRulesData(IReadOnlyList<int> skirmishRuleMods, IReadOnlyList<int> scoringMethods)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeRulesData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skirmishRuleMods);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scoringMethods);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeRulesData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_Int32_IReadOnlyList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x000433FC File Offset: 0x000415FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999238, XrefRangeEnd = 999249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeRulesData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00009986 File Offset: 0x00007B86
		public DailyChallengeRulesData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x00043440 File Offset: 0x00041640
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x0000998F File Offset: 0x00007B8F
		public unsafe IReadOnlyList<int> RuleMods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesData.NativeFieldInfoPtr_RuleMods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesData.NativeFieldInfoPtr_RuleMods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x00043470 File Offset: 0x00041670
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x000099AE File Offset: 0x00007BAE
		public unsafe IReadOnlyList<int> ScoringMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesData.NativeFieldInfoPtr_ScoringMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesData.NativeFieldInfoPtr_ScoringMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeFieldInfoPtr_RuleMods;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeFieldInfoPtr_ScoringMethods;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_Int32_IReadOnlyList_1_Int32_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
