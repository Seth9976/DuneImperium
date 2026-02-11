using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace boardgames.menus
{
	// Token: 0x0200014F RID: 335
	public class FireEventOnKeyPress : MonoBehaviour
	{
		// Token: 0x06001132 RID: 4402 RVA: 0x00045E2C File Offset: 0x0004402C
		// Note: this type is marked as 'beforefieldinit'.
		static FireEventOnKeyPress()
		{
			Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.menus", "FireEventOnKeyPress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr);
			FireEventOnKeyPress.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr, "code");
			FireEventOnKeyPress.NativeFieldInfoPtr_onKeyPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr, "onKeyPressed");
			FireEventOnKeyPress.NativeFieldInfoPtr_canvasRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr, "canvasRect");
			FireEventOnKeyPress.NativeFieldInfoPtr_requireGameObjectVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr, "requireGameObjectVisibility");
			FireEventOnKeyPress.NativeFieldInfoPtr_eventCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr, "eventCamera");
			FireEventOnKeyPress.NativeFieldInfoPtr_raycastResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr, "raycastResults");
			FireEventOnKeyPress.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr, "eventData");
			FireEventOnKeyPress.NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr, "rectTransform");
			FireEventOnKeyPress.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr, 100665834);
			FireEventOnKeyPress.NativeMethodInfoPtr_tryGetCamera_Private_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr, 100665835);
			FireEventOnKeyPress.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr, 100665836);
			FireEventOnKeyPress.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr, 100665837);
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00045F4C File Offset: 0x0004414C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999857, XrefRangeEnd = 999879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireEventOnKeyPress.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00045F80 File Offset: 0x00044180
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 999888, RefRangeEnd = 999890, XrefRangeStart = 999879, XrefRangeEnd = 999888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Camera tryGetCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireEventOnKeyPress.NativeMethodInfoPtr_tryGetCamera_Private_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00045FC0 File Offset: 0x000441C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999890, XrefRangeEnd = 999919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireEventOnKeyPress.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00045FF4 File Offset: 0x000441F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999919, XrefRangeEnd = 999925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FireEventOnKeyPress()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FireEventOnKeyPress>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireEventOnKeyPress.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0000A00E File Offset: 0x0000820E
		public FireEventOnKeyPress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x00046030 File Offset: 0x00044230
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x0000A017 File Offset: 0x00008217
		public unsafe KeyCode code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_code)) = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x00046058 File Offset: 0x00044258
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x0000A032 File Offset: 0x00008232
		public unsafe UnityEvent onKeyPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_onKeyPressed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_onKeyPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x00046088 File Offset: 0x00044288
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x0000A051 File Offset: 0x00008251
		public unsafe RectTransform canvasRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_canvasRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_canvasRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x000460B8 File Offset: 0x000442B8
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x0000A070 File Offset: 0x00008270
		public unsafe bool requireGameObjectVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_requireGameObjectVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_requireGameObjectVisibility)) = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x000460E0 File Offset: 0x000442E0
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x0000A08B File Offset: 0x0000828B
		public unsafe Camera eventCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_eventCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_eventCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x00046110 File Offset: 0x00044310
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x0000A0AA File Offset: 0x000082AA
		public unsafe List<RaycastResult> raycastResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_raycastResults);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_raycastResults), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x00046140 File Offset: 0x00044340
		// (set) Token: 0x06001145 RID: 4421 RVA: 0x0000A0C9 File Offset: 0x000082C9
		public unsafe PointerEventData eventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_eventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x00046170 File Offset: 0x00044370
		// (set) Token: 0x06001147 RID: 4423 RVA: 0x0000A0E8 File Offset: 0x000082E8
		public unsafe RectTransform rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventOnKeyPress.NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeFieldInfoPtr_code;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeFieldInfoPtr_onKeyPressed;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeFieldInfoPtr_canvasRect;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeFieldInfoPtr_requireGameObjectVisibility;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeFieldInfoPtr_eventCamera;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeFieldInfoPtr_raycastResults;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeFieldInfoPtr_eventData;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeFieldInfoPtr_rectTransform;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_tryGetCamera_Private_Camera_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
