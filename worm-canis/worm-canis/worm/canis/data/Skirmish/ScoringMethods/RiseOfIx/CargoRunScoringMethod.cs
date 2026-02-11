using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.worm_canis.data.Skirmish.ScoringMethods;
using worm.canis.entities;

namespace worm.canis.data.Skirmish.ScoringMethods.RiseOfIx
{
	// Token: 0x0200006B RID: 107
	public class CargoRunScoringMethod : SkirmishScoringMethod
	{
		// Token: 0x06000B74 RID: 2932 RVA: 0x0008E3A0 File Offset: 0x0008C5A0
		// Note: this type is marked as 'beforefieldinit'.
		static CargoRunScoringMethod()
		{
			Il2CppClassPointerStore<CargoRunScoringMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.ScoringMethods.RiseOfIx", "CargoRunScoringMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CargoRunScoringMethod>.NativeClassPtr);
			CargoRunScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CargoRunScoringMethod>.NativeClassPtr, 100665500);
			CargoRunScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CargoRunScoringMethod>.NativeClassPtr, 100665501);
			CargoRunScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CargoRunScoringMethod>.NativeClassPtr, 100665502);
			CargoRunScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CargoRunScoringMethod>.NativeClassPtr, 100665503);
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0008E420 File Offset: 0x0008C620
		public unsafe override int MethodID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CargoRunScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0008E468 File Offset: 0x0008C668
		public unsafe override LocalizableTextVariables PromptKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73164, XrefRangeEnd = 73170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CargoRunScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0008E4B4 File Offset: 0x0008C6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73170, XrefRangeEnd = 73185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CargoRunScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishScoreItem>(intPtr3) : null;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0008E524 File Offset: 0x0008C724
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CargoRunScoringMethod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CargoRunScoringMethod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CargoRunScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00006CCF File Offset: 0x00004ECF
		public CargoRunScoringMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
