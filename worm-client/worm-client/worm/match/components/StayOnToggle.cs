using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace worm.match.components
{
	// Token: 0x020001C2 RID: 450
	public class StayOnToggle : Toggle
	{
		// Token: 0x060013C1 RID: 5057 RVA: 0x00054294 File Offset: 0x00052494
		// Note: this type is marked as 'beforefieldinit'.
		static StayOnToggle()
		{
			Il2CppClassPointerStore<StayOnToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "StayOnToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StayOnToggle>.NativeClassPtr);
			StayOnToggle.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StayOnToggle>.NativeClassPtr, 100666010);
			StayOnToggle.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StayOnToggle>.NativeClassPtr, 100666011);
			StayOnToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StayOnToggle>.NativeClassPtr, 100666012);
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00054300 File Offset: 0x00052500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713328, XrefRangeEnd = 713329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StayOnToggle.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00054350 File Offset: 0x00052550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713329, XrefRangeEnd = 713330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StayOnToggle.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x000543A0 File Offset: 0x000525A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713330, XrefRangeEnd = 713333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StayOnToggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StayOnToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StayOnToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0000C250 File Offset: 0x0000A450
		public StayOnToggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
