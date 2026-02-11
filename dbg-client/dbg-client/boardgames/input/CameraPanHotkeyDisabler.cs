using System;
using dbg_client.camera;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.input
{
	// Token: 0x0200012D RID: 301
	public class CameraPanHotkeyDisabler : MonoBehaviour
	{
		// Token: 0x06000D54 RID: 3412 RVA: 0x00047B00 File Offset: 0x00045D00
		// Note: this type is marked as 'beforefieldinit'.
		static CameraPanHotkeyDisabler()
		{
			Il2CppClassPointerStore<CameraPanHotkeyDisabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "CameraPanHotkeyDisabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraPanHotkeyDisabler>.NativeClassPtr);
			CameraPanHotkeyDisabler.NativeFieldInfoPtr_disableKeysOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPanHotkeyDisabler>.NativeClassPtr, "disableKeysOnEnable");
			CameraPanHotkeyDisabler.NativeFieldInfoPtr_enableKeysOnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPanHotkeyDisabler>.NativeClassPtr, "enableKeysOnDisable");
			CameraPanHotkeyDisabler.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPanHotkeyDisabler>.NativeClassPtr, "handler");
			CameraPanHotkeyDisabler.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanHotkeyDisabler>.NativeClassPtr, 100665237);
			CameraPanHotkeyDisabler.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanHotkeyDisabler>.NativeClassPtr, 100665238);
			CameraPanHotkeyDisabler.NativeMethodInfoPtr_Event_UpdateHotkeysEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanHotkeyDisabler>.NativeClassPtr, 100665239);
			CameraPanHotkeyDisabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanHotkeyDisabler>.NativeClassPtr, 100665240);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00047BBC File Offset: 0x00045DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510746, XrefRangeEnd = 510747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanHotkeyDisabler.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00047BF0 File Offset: 0x00045DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510747, XrefRangeEnd = 510748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanHotkeyDisabler.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00047C24 File Offset: 0x00045E24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 510763, RefRangeEnd = 510765, XrefRangeStart = 510748, XrefRangeEnd = 510763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UpdateHotkeysEnabled(bool hotkeysEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hotkeysEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanHotkeyDisabler.NativeMethodInfoPtr_Event_UpdateHotkeysEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00047C64 File Offset: 0x00045E64
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraPanHotkeyDisabler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraPanHotkeyDisabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanHotkeyDisabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00008719 File Offset: 0x00006919
		public CameraPanHotkeyDisabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x00047CA0 File Offset: 0x00045EA0
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x00008722 File Offset: 0x00006922
		public unsafe bool disableKeysOnEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanHotkeyDisabler.NativeFieldInfoPtr_disableKeysOnEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanHotkeyDisabler.NativeFieldInfoPtr_disableKeysOnEnable)) = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00047CC8 File Offset: 0x00045EC8
		// (set) Token: 0x06000D5D RID: 3421 RVA: 0x0000873D File Offset: 0x0000693D
		public unsafe bool enableKeysOnDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanHotkeyDisabler.NativeFieldInfoPtr_enableKeysOnDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanHotkeyDisabler.NativeFieldInfoPtr_enableKeysOnDisable)) = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x00047CF0 File Offset: 0x00045EF0
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x00008758 File Offset: 0x00006958
		public unsafe CameraHotkeyDisablerRegister handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanHotkeyDisabler.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraHotkeyDisablerRegister>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanHotkeyDisabler.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeFieldInfoPtr_disableKeysOnEnable;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeFieldInfoPtr_enableKeysOnDisable;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_Event_UpdateHotkeysEnabled_Public_Void_Boolean_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
