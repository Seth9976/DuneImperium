using System;
using Canis.entities;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.skirmishScripts
{
	// Token: 0x02000052 RID: 82
	[Serializable]
	public class SkirmishScoringMethod : Object
	{
		// Token: 0x060004F4 RID: 1268 RVA: 0x0002C86C File Offset: 0x0002AA6C
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishScoringMethod()
		{
			Il2CppClassPointerStore<SkirmishScoringMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.skirmishScripts", "SkirmishScoringMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishScoringMethod>.NativeClassPtr);
			SkirmishScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethod>.NativeClassPtr, 100664298);
			SkirmishScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Abstract_Virtual_New_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethod>.NativeClassPtr, 100664299);
			SkirmishScoringMethod.NativeMethodInfoPtr_Compute_Public_Abstract_Virtual_New_SkirmishScoreItem_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethod>.NativeClassPtr, 100664300);
			SkirmishScoringMethod.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoringMethod>.NativeClassPtr, 100664301);
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0002C8EC File Offset: 0x0002AAEC
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

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0002C934 File Offset: 0x0002AB34
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

		// Token: 0x060004F7 RID: 1271 RVA: 0x0002C980 File Offset: 0x0002AB80
		[CallerCount(0)]
		public unsafe virtual SkirmishScoreItem Compute(Match match, PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkirmishScoringMethod.NativeMethodInfoPtr_Compute_Public_Abstract_Virtual_New_SkirmishScoreItem_Match_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishScoreItem>(intPtr3) : null;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
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

		// Token: 0x060004F9 RID: 1273 RVA: 0x000042FA File Offset: 0x000024FA
		public SkirmishScoringMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodID_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptKey_Public_Abstract_Virtual_New_get_LocalizableTextVariables_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Abstract_Virtual_New_SkirmishScoreItem_Match_PlayerEntity_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
