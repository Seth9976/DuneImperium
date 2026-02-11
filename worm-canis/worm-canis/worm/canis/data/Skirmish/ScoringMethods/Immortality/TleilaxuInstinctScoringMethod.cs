using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.worm_canis.data.Skirmish.ScoringMethods;
using worm.canis.entities;

namespace worm.canis.data.Skirmish.ScoringMethods.Immortality
{
	// Token: 0x02000078 RID: 120
	public class TleilaxuInstinctScoringMethod : SkirmishScoringMethod
	{
		// Token: 0x06000BC2 RID: 3010 RVA: 0x0008FA60 File Offset: 0x0008DC60
		// Note: this type is marked as 'beforefieldinit'.
		static TleilaxuInstinctScoringMethod()
		{
			Il2CppClassPointerStore<TleilaxuInstinctScoringMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.ScoringMethods.Immortality", "TleilaxuInstinctScoringMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TleilaxuInstinctScoringMethod>.NativeClassPtr);
			TleilaxuInstinctScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuInstinctScoringMethod>.NativeClassPtr, 100665555);
			TleilaxuInstinctScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuInstinctScoringMethod>.NativeClassPtr, 100665556);
			TleilaxuInstinctScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuInstinctScoringMethod>.NativeClassPtr, 100665557);
			TleilaxuInstinctScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuInstinctScoringMethod>.NativeClassPtr, 100665558);
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0008FAE0 File Offset: 0x0008DCE0
		public unsafe override int MethodID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TleilaxuInstinctScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0008FB28 File Offset: 0x0008DD28
		public unsafe override LocalizableTextVariables PromptKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73460, XrefRangeEnd = 73466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TleilaxuInstinctScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0008FB74 File Offset: 0x0008DD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73466, XrefRangeEnd = 73481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TleilaxuInstinctScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishScoreItem>(intPtr3) : null;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0008FBE4 File Offset: 0x0008DDE4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TleilaxuInstinctScoringMethod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TleilaxuInstinctScoringMethod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuInstinctScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00006D44 File Offset: 0x00004F44
		public TleilaxuInstinctScoringMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
