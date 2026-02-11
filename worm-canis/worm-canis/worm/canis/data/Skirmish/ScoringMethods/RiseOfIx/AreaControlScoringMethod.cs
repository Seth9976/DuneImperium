using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.worm_canis.data.Skirmish.ScoringMethods;
using worm.canis.entities;

namespace worm.canis.data.Skirmish.ScoringMethods.RiseOfIx
{
	// Token: 0x0200006A RID: 106
	public class AreaControlScoringMethod : SkirmishScoringMethod
	{
		// Token: 0x06000B6E RID: 2926 RVA: 0x0008E1E0 File Offset: 0x0008C3E0
		// Note: this type is marked as 'beforefieldinit'.
		static AreaControlScoringMethod()
		{
			Il2CppClassPointerStore<AreaControlScoringMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.ScoringMethods.RiseOfIx", "AreaControlScoringMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaControlScoringMethod>.NativeClassPtr);
			AreaControlScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaControlScoringMethod>.NativeClassPtr, 100665496);
			AreaControlScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaControlScoringMethod>.NativeClassPtr, 100665497);
			AreaControlScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaControlScoringMethod>.NativeClassPtr, 100665498);
			AreaControlScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaControlScoringMethod>.NativeClassPtr, 100665499);
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0008E260 File Offset: 0x0008C460
		public unsafe override int MethodID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AreaControlScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0008E2A8 File Offset: 0x0008C4A8
		public unsafe override LocalizableTextVariables PromptKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73143, XrefRangeEnd = 73149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AreaControlScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0008E2F4 File Offset: 0x0008C4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73149, XrefRangeEnd = 73164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AreaControlScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishScoreItem>(intPtr3) : null;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0008E364 File Offset: 0x0008C564
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AreaControlScoringMethod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaControlScoringMethod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AreaControlScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00006CC6 File Offset: 0x00004EC6
		public AreaControlScoringMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
