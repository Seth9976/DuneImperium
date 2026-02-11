using System;
using dbg_client.camera;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.input
{
	// Token: 0x0200012E RID: 302
	public class CameraScrollDisabler : MonoBehaviour
	{
		// Token: 0x06000D60 RID: 3424 RVA: 0x00047D20 File Offset: 0x00045F20
		// Note: this type is marked as 'beforefieldinit'.
		static CameraScrollDisabler()
		{
			Il2CppClassPointerStore<CameraScrollDisabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "CameraScrollDisabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraScrollDisabler>.NativeClassPtr);
			CameraScrollDisabler.NativeFieldInfoPtr_disableKeysOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraScrollDisabler>.NativeClassPtr, "disableKeysOnEnable");
			CameraScrollDisabler.NativeFieldInfoPtr_enableKeysOnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraScrollDisabler>.NativeClassPtr, "enableKeysOnDisable");
			CameraScrollDisabler.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraScrollDisabler>.NativeClassPtr, "cam");
			CameraScrollDisabler.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScrollDisabler>.NativeClassPtr, 100665241);
			CameraScrollDisabler.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScrollDisabler>.NativeClassPtr, 100665242);
			CameraScrollDisabler.NativeMethodInfoPtr_Event_UpdateScrollEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScrollDisabler>.NativeClassPtr, 100665243);
			CameraScrollDisabler.NativeMethodInfoPtr_Event_TryUpdateScrollEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScrollDisabler>.NativeClassPtr, 100665244);
			CameraScrollDisabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScrollDisabler>.NativeClassPtr, 100665245);
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00047DF0 File Offset: 0x00045FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510765, XrefRangeEnd = 510766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraScrollDisabler.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00047E24 File Offset: 0x00046024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510766, XrefRangeEnd = 510767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraScrollDisabler.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00047E58 File Offset: 0x00046058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 510783, RefRangeEnd = 510785, XrefRangeStart = 510767, XrefRangeEnd = 510783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UpdateScrollEnabled(bool hotkeysEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hotkeysEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraScrollDisabler.NativeMethodInfoPtr_Event_UpdateScrollEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00047E98 File Offset: 0x00046098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510785, XrefRangeEnd = 510801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_TryUpdateScrollEnabled(bool hotkeysEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hotkeysEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraScrollDisabler.NativeMethodInfoPtr_Event_TryUpdateScrollEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00047ED8 File Offset: 0x000460D8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraScrollDisabler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraScrollDisabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraScrollDisabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00008777 File Offset: 0x00006977
		public CameraScrollDisabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00047F14 File Offset: 0x00046114
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x00008780 File Offset: 0x00006980
		public unsafe bool disableKeysOnEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraScrollDisabler.NativeFieldInfoPtr_disableKeysOnEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraScrollDisabler.NativeFieldInfoPtr_disableKeysOnEnable)) = value;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x00047F3C File Offset: 0x0004613C
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x0000879B File Offset: 0x0000699B
		public unsafe bool enableKeysOnDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraScrollDisabler.NativeFieldInfoPtr_enableKeysOnDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraScrollDisabler.NativeFieldInfoPtr_enableKeysOnDisable)) = value;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x00047F64 File Offset: 0x00046164
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x000087B6 File Offset: 0x000069B6
		public unsafe CameraScrollDisablerRegister cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraScrollDisabler.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraScrollDisablerRegister>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraScrollDisabler.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeFieldInfoPtr_disableKeysOnEnable;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeFieldInfoPtr_enableKeysOnDisable;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_Event_UpdateScrollEnabled_Public_Void_Boolean_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_Event_TryUpdateScrollEnabled_Public_Void_Boolean_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
