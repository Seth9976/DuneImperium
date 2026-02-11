using System;
using dbg_client.camera;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace lib.src.camera
{
	// Token: 0x0200001E RID: 30
	public class CameraScrollDisableOnMouseOver : MonoBehaviour
	{
		// Token: 0x06000121 RID: 289 RVA: 0x00021394 File Offset: 0x0001F594
		// Note: this type is marked as 'beforefieldinit'.
		static CameraScrollDisableOnMouseOver()
		{
			Il2CppClassPointerStore<CameraScrollDisableOnMouseOver>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.src.camera", "CameraScrollDisableOnMouseOver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraScrollDisableOnMouseOver>.NativeClassPtr);
			CameraScrollDisableOnMouseOver.NativeFieldInfoPtr_scrollDisabler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraScrollDisableOnMouseOver>.NativeClassPtr, "scrollDisabler");
			CameraScrollDisableOnMouseOver.NativeFieldInfoPtr_mouseOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraScrollDisableOnMouseOver>.NativeClassPtr, "mouseOver");
			CameraScrollDisableOnMouseOver.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScrollDisableOnMouseOver>.NativeClassPtr, 100663528);
			CameraScrollDisableOnMouseOver.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScrollDisableOnMouseOver>.NativeClassPtr, 100663529);
			CameraScrollDisableOnMouseOver.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScrollDisableOnMouseOver>.NativeClassPtr, 100663530);
			CameraScrollDisableOnMouseOver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScrollDisableOnMouseOver>.NativeClassPtr, 100663531);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0002143C File Offset: 0x0001F63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497301, XrefRangeEnd = 497312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData pointerEventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraScrollDisableOnMouseOver.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00021480 File Offset: 0x0001F680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497312, XrefRangeEnd = 497323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData pointerEventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraScrollDisableOnMouseOver.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000214C4 File Offset: 0x0001F6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497323, XrefRangeEnd = 497334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraScrollDisableOnMouseOver.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000214F8 File Offset: 0x0001F6F8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraScrollDisableOnMouseOver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraScrollDisableOnMouseOver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraScrollDisableOnMouseOver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002710 File Offset: 0x00000910
		public CameraScrollDisableOnMouseOver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00021534 File Offset: 0x0001F734
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002719 File Offset: 0x00000919
		public unsafe CameraScrollDisablerRegister scrollDisabler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraScrollDisableOnMouseOver.NativeFieldInfoPtr_scrollDisabler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraScrollDisablerRegister>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraScrollDisableOnMouseOver.NativeFieldInfoPtr_scrollDisabler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00021564 File Offset: 0x0001F764
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002738 File Offset: 0x00000938
		public unsafe bool mouseOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraScrollDisableOnMouseOver.NativeFieldInfoPtr_mouseOver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraScrollDisableOnMouseOver.NativeFieldInfoPtr_mouseOver)) = value;
			}
		}

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_scrollDisabler;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_mouseOver;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
