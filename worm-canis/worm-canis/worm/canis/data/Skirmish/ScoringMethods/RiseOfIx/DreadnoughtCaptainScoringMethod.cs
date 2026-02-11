using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.worm_canis.data.Skirmish.ScoringMethods;
using worm.canis.entities;

namespace worm.canis.data.Skirmish.ScoringMethods.RiseOfIx
{
	// Token: 0x0200006C RID: 108
	public class DreadnoughtCaptainScoringMethod : SkirmishScoringMethod
	{
		// Token: 0x06000B7A RID: 2938 RVA: 0x0008E560 File Offset: 0x0008C760
		// Note: this type is marked as 'beforefieldinit'.
		static DreadnoughtCaptainScoringMethod()
		{
			Il2CppClassPointerStore<DreadnoughtCaptainScoringMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.ScoringMethods.RiseOfIx", "DreadnoughtCaptainScoringMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DreadnoughtCaptainScoringMethod>.NativeClassPtr);
			DreadnoughtCaptainScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtCaptainScoringMethod>.NativeClassPtr, 100665504);
			DreadnoughtCaptainScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtCaptainScoringMethod>.NativeClassPtr, 100665505);
			DreadnoughtCaptainScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtCaptainScoringMethod>.NativeClassPtr, 100665506);
			DreadnoughtCaptainScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtCaptainScoringMethod>.NativeClassPtr, 100665507);
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0008E5E0 File Offset: 0x0008C7E0
		public unsafe override int MethodID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DreadnoughtCaptainScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0008E628 File Offset: 0x0008C828
		public unsafe override LocalizableTextVariables PromptKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73185, XrefRangeEnd = 73191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DreadnoughtCaptainScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0008E674 File Offset: 0x0008C874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73191, XrefRangeEnd = 73206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DreadnoughtCaptainScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishScoreItem>(intPtr3) : null;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0008E6E4 File Offset: 0x0008C8E4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DreadnoughtCaptainScoringMethod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DreadnoughtCaptainScoringMethod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtCaptainScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00006CD8 File Offset: 0x00004ED8
		public DreadnoughtCaptainScoringMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
