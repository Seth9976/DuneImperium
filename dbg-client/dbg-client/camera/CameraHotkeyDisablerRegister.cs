using System;
using boardgames.input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dbg_client.camera
{
	// Token: 0x02000041 RID: 65
	public class CameraHotkeyDisablerRegister : MonoBehaviour
	{
		// Token: 0x0600028C RID: 652 RVA: 0x00025A50 File Offset: 0x00023C50
		// Note: this type is marked as 'beforefieldinit'.
		static CameraHotkeyDisablerRegister()
		{
			Il2CppClassPointerStore<CameraHotkeyDisablerRegister>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbg_client.camera", "CameraHotkeyDisablerRegister");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraHotkeyDisablerRegister>.NativeClassPtr);
			CameraHotkeyDisablerRegister.NativeFieldInfoPtr__HotkeyDisabler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraHotkeyDisablerRegister>.NativeClassPtr, "<HotkeyDisabler>k__BackingField");
			CameraHotkeyDisablerRegister.NativeMethodInfoPtr_get_HotkeyDisabler_Public_get_Disabler_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHotkeyDisablerRegister>.NativeClassPtr, 100663707);
			CameraHotkeyDisablerRegister.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHotkeyDisablerRegister>.NativeClassPtr, 100663708);
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00025ABC File Offset: 0x00023CBC
		public unsafe Disabler<GameObject> HotkeyDisabler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraHotkeyDisablerRegister.NativeMethodInfoPtr_get_HotkeyDisabler_Public_get_Disabler_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Disabler<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00025AFC File Offset: 0x00023CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498894, XrefRangeEnd = 498902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraHotkeyDisablerRegister()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraHotkeyDisablerRegister>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraHotkeyDisablerRegister.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000031DF File Offset: 0x000013DF
		public CameraHotkeyDisablerRegister(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00025B38 File Offset: 0x00023D38
		// (set) Token: 0x06000291 RID: 657 RVA: 0x000031E8 File Offset: 0x000013E8
		public unsafe Disabler<GameObject> _HotkeyDisabler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeyDisablerRegister.NativeFieldInfoPtr__HotkeyDisabler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Disabler<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeyDisablerRegister.NativeFieldInfoPtr__HotkeyDisabler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr__HotkeyDisabler_k__BackingField;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_get_HotkeyDisabler_Public_get_Disabler_1_GameObject_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
