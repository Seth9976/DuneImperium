using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.worm_canis.data.Skirmish.ScoringMethods;
using worm.canis.entities;

namespace worm.canis.data.Skirmish.ScoringMethods.RiseOfIx
{
	// Token: 0x02000071 RID: 113
	public class TechnologistScoringMethod : SkirmishScoringMethod
	{
		// Token: 0x06000B98 RID: 2968 RVA: 0x0008EE20 File Offset: 0x0008D020
		// Note: this type is marked as 'beforefieldinit'.
		static TechnologistScoringMethod()
		{
			Il2CppClassPointerStore<TechnologistScoringMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.ScoringMethods.RiseOfIx", "TechnologistScoringMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TechnologistScoringMethod>.NativeClassPtr);
			TechnologistScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechnologistScoringMethod>.NativeClassPtr, 100665527);
			TechnologistScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechnologistScoringMethod>.NativeClassPtr, 100665528);
			TechnologistScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechnologistScoringMethod>.NativeClassPtr, 100665529);
			TechnologistScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechnologistScoringMethod>.NativeClassPtr, 100665530);
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0008EEA0 File Offset: 0x0008D0A0
		public unsafe override int MethodID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TechnologistScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0008EEE8 File Offset: 0x0008D0E8
		public unsafe override LocalizableTextVariables PromptKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73316, XrefRangeEnd = 73322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TechnologistScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0008EF34 File Offset: 0x0008D134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73322, XrefRangeEnd = 73337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TechnologistScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishScoreItem>(intPtr3) : null;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0008EFA4 File Offset: 0x0008D1A4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TechnologistScoringMethod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TechnologistScoringMethod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TechnologistScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00006D05 File Offset: 0x00004F05
		public TechnologistScoringMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
