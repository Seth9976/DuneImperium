using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis;
using worm.canis.entities;

namespace lib.canis.worm_canis.data.Skirmish.ScoringMethods
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class SkirmishScoringMethod : Object
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00069200 File Offset: 0x00067400
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishScoringMethod()
		{
			Il2CppClassPointerStore<SkirmishScoringMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "lib.canis.worm_canis.data.Skirmish.ScoringMethods", "SkirmishScoringMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishScoringMethod>.NativeClassPtr);
			SkirmishScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethod>.NativeClassPtr, 100663305);
			SkirmishScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Abstract_Virtual_New_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethod>.NativeClassPtr, 100663306);
			SkirmishScoringMethod.NativeMethodInfoPtr_Compute_Public_Abstract_Virtual_New_SkirmishScoreItem_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethod>.NativeClassPtr, 100663307);
			SkirmishScoringMethod.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethod>.NativeClassPtr, 100663308);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00069280 File Offset: 0x00067480
		public unsafe virtual int MethodID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkirmishScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000692C8 File Offset: 0x000674C8
		public unsafe virtual LocalizableTextVariables PromptKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkirmishScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Abstract_Virtual_New_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00069314 File Offset: 0x00067514
		[CallerCount(0)]
		public unsafe virtual SkirmishScoreItem Compute(WormMatch wormMatch, WormPlayer wormPlayer)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkirmishScoringMethod.NativeMethodInfoPtr_Compute_Public_Abstract_Virtual_New_SkirmishScoreItem_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishScoreItem>(intPtr3) : null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00069384 File Offset: 0x00067584
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishScoringMethod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishScoringMethod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoringMethod.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020FF File Offset: 0x000002FF
		public SkirmishScoringMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodID_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptKey_Public_Abstract_Virtual_New_get_LocalizableTextVariables_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Abstract_Virtual_New_SkirmishScoreItem_WormMatch_WormPlayer_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
