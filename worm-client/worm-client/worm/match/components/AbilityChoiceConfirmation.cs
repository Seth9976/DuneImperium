using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001A7 RID: 423
	public class AbilityChoiceConfirmation : MonoBehaviour
	{
		// Token: 0x060012C4 RID: 4804 RVA: 0x00051158 File Offset: 0x0004F358
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityChoiceConfirmation()
		{
			Il2CppClassPointerStore<AbilityChoiceConfirmation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "AbilityChoiceConfirmation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityChoiceConfirmation>.NativeClassPtr);
			AbilityChoiceConfirmation.NativeMethodInfoPtr_get_ConfirmationPromptText_Public_Abstract_Virtual_New_get_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityChoiceConfirmation>.NativeClassPtr, 100665851);
			AbilityChoiceConfirmation.NativeMethodInfoPtr_RequiresConfirmation_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityChoiceConfirmation>.NativeClassPtr, 100665852);
			AbilityChoiceConfirmation.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityChoiceConfirmation>.NativeClassPtr, 100665853);
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x000511C4 File Offset: 0x0004F3C4
		public unsafe virtual LocalizedString ConfirmationPromptText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityChoiceConfirmation.NativeMethodInfoPtr_get_ConfirmationPromptText_Public_Abstract_Virtual_New_get_LocalizedString_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
			}
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00051210 File Offset: 0x0004F410
		[CallerCount(0)]
		public unsafe virtual bool RequiresConfirmation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityChoiceConfirmation.NativeMethodInfoPtr_RequiresConfirmation_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x00051258 File Offset: 0x0004F458
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityChoiceConfirmation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityChoiceConfirmation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityChoiceConfirmation.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0000BB76 File Offset: 0x00009D76
		public AbilityChoiceConfirmation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfirmationPromptText_Public_Abstract_Virtual_New_get_LocalizedString_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_RequiresConfirmation_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
