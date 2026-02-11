using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000032 RID: 50
	public class RectMask2D : UIBehaviour
	{
		// Token: 0x06000576 RID: 1398 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
		// Note: this type is marked as 'beforefieldinit'.
		static RectMask2D()
		{
			Il2CppClassPointerStore<RectMask2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "RectMask2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr);
			RectMask2D.NativeFieldInfoPtr_m_VertexClipper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_VertexClipper");
			RectMask2D.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_RectTransform");
			RectMask2D.NativeFieldInfoPtr_m_MaskableTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_MaskableTargets");
			RectMask2D.NativeFieldInfoPtr_m_ClipTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_ClipTargets");
			RectMask2D.NativeFieldInfoPtr_m_ShouldRecalculateClipRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_ShouldRecalculateClipRects");
			RectMask2D.NativeFieldInfoPtr_m_Clippers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Clippers");
			RectMask2D.NativeFieldInfoPtr_m_LastClipRectCanvasSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_LastClipRectCanvasSpace");
			RectMask2D.NativeFieldInfoPtr_m_ForceClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_ForceClip");
			RectMask2D.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Padding");
			RectMask2D.NativeFieldInfoPtr_m_Softness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Softness");
			RectMask2D.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Canvas");
			RectMask2D.NativeFieldInfoPtr_m_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, "m_Corners");
			RectMask2D.NativeMethodInfoPtr_get_padding_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664189);
			RectMask2D.NativeMethodInfoPtr_set_padding_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664190);
			RectMask2D.NativeMethodInfoPtr_get_softness_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664191);
			RectMask2D.NativeMethodInfoPtr_set_softness_Public_set_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664192);
			RectMask2D.NativeMethodInfoPtr_get_Canvas_Internal_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664193);
			RectMask2D.NativeMethodInfoPtr_get_canvasRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664194);
			RectMask2D.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664195);
			RectMask2D.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664196);
			RectMask2D.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664197);
			RectMask2D.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664198);
			RectMask2D.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664199);
			RectMask2D.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664200);
			RectMask2D.NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664201);
			RectMask2D.NativeMethodInfoPtr_PerformClipping_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664202);
			RectMask2D.NativeMethodInfoPtr_UpdateClipSoftness_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664203);
			RectMask2D.NativeMethodInfoPtr_AddClippable_Public_Void_IClippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664204);
			RectMask2D.NativeMethodInfoPtr_RemoveClippable_Public_Void_IClippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664205);
			RectMask2D.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664206);
			RectMask2D.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr, 100664207);
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0001C760 File Offset: 0x0001A960
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x0001C79C File Offset: 0x0001A99C
		public unsafe Vector4 padding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_padding_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1090298, RefRangeEnd = 1090299, XrefRangeStart = 1090297, XrefRangeEnd = 1090298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_set_padding_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0001C7DC File Offset: 0x0001A9DC
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x0001C818 File Offset: 0x0001AA18
		public unsafe Vector2Int softness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_softness_Public_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090299, XrefRangeEnd = 1090300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_set_softness_Public_set_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0001C858 File Offset: 0x0001AA58
		public unsafe Canvas Canvas
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1090325, RefRangeEnd = 1090331, XrefRangeStart = 1090300, XrefRangeEnd = 1090325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_Canvas_Internal_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x0001C898 File Offset: 0x0001AA98
		public unsafe Rect canvasRect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1090337, RefRangeEnd = 1090339, XrefRangeStart = 1090331, XrefRangeEnd = 1090337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_canvasRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0001C8D4 File Offset: 0x0001AAD4
		public unsafe RectTransform rectTransform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090339, XrefRangeEnd = 1090343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0001C914 File Offset: 0x0001AB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090343, XrefRangeEnd = 1090374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectMask2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectMask2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0001C950 File Offset: 0x0001AB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090374, XrefRangeEnd = 1090377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0001C98C File Offset: 0x0001AB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090377, XrefRangeEnd = 1090389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0001C9C8 File Offset: 0x0001ABC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090389, XrefRangeEnd = 1090391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0001CA04 File Offset: 0x0001AC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090391, XrefRangeEnd = 1090400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0001CA6C File Offset: 0x0001AC6C
		public unsafe Rect rootCanvasRect
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1090410, RefRangeEnd = 1090411, XrefRangeStart = 1090400, XrefRangeEnd = 1090410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0001CAA8 File Offset: 0x0001ACA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090411, XrefRangeEnd = 1090488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PerformClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_PerformClipping_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0001CAE4 File Offset: 0x0001ACE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090488, XrefRangeEnd = 1090521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateClipSoftness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_UpdateClipSoftness_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0001CB20 File Offset: 0x0001AD20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1090534, RefRangeEnd = 1090535, XrefRangeStart = 1090521, XrefRangeEnd = 1090534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddClippable(IClippable clippable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clippable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_AddClippable_Public_Void_IClippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0001CB64 File Offset: 0x0001AD64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1090552, RefRangeEnd = 1090553, XrefRangeStart = 1090535, XrefRangeEnd = 1090552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveClippable(IClippable clippable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clippable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectMask2D.NativeMethodInfoPtr_RemoveClippable_Public_Void_IClippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0001CBA8 File Offset: 0x0001ADA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090553, XrefRangeEnd = 1090555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0001CBE4 File Offset: 0x0001ADE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectMask2D.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00003DAB File Offset: 0x00001FAB
		public RectMask2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0001CC20 File Offset: 0x0001AE20
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00003DB4 File Offset: 0x00001FB4
		public unsafe RectangularVertexClipper m_VertexClipper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_VertexClipper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectangularVertexClipper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_VertexClipper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0001CC50 File Offset: 0x0001AE50
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00003DD3 File Offset: 0x00001FD3
		public unsafe RectTransform m_RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0001CC80 File Offset: 0x0001AE80
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00003DF2 File Offset: 0x00001FF2
		public unsafe HashSet<MaskableGraphic> m_MaskableTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_MaskableTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<MaskableGraphic>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_MaskableTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00003E11 File Offset: 0x00002011
		public unsafe HashSet<IClippable> m_ClipTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ClipTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IClippable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ClipTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0001CCE0 File Offset: 0x0001AEE0
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00003E30 File Offset: 0x00002030
		public unsafe bool m_ShouldRecalculateClipRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ShouldRecalculateClipRects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ShouldRecalculateClipRects)) = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0001CD08 File Offset: 0x0001AF08
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00003E4B File Offset: 0x0000204B
		public unsafe List<RectMask2D> m_Clippers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Clippers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectMask2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Clippers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0001CD38 File Offset: 0x0001AF38
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00003E6A File Offset: 0x0000206A
		public unsafe Rect m_LastClipRectCanvasSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_LastClipRectCanvasSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_LastClipRectCanvasSpace)) = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0001CD60 File Offset: 0x0001AF60
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00003E85 File Offset: 0x00002085
		public unsafe bool m_ForceClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ForceClip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_ForceClip)) = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0001CD88 File Offset: 0x0001AF88
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00003EA0 File Offset: 0x000020A0
		public unsafe Vector4 m_Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Padding)) = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0001CDB0 File Offset: 0x0001AFB0
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00003EBB File Offset: 0x000020BB
		public unsafe Vector2Int m_Softness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Softness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Softness)) = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0001CDD8 File Offset: 0x0001AFD8
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00003ED6 File Offset: 0x000020D6
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0001CE08 File Offset: 0x0001B008
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00003EF5 File Offset: 0x000020F5
		public unsafe Il2CppStructArray<Vector3> m_Corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectMask2D.NativeFieldInfoPtr_m_Corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeFieldInfoPtr_m_VertexClipper;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr_m_MaskableTargets;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipTargets;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldRecalculateClipRects;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeFieldInfoPtr_m_Clippers;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeFieldInfoPtr_m_LastClipRectCanvasSpace;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr_m_ForceClip;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_m_Softness;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_m_Corners;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_get_padding_Public_get_Vector4_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_set_padding_Public_set_Void_Vector4_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_get_softness_Public_get_Vector2Int_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_set_softness_Public_set_Void_Vector2Int_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_get_Canvas_Internal_get_Canvas_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_get_canvasRect_Public_get_Rect_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_PerformClipping_Public_Virtual_New_Void_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClipSoftness_Public_Virtual_New_Void_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_AddClippable_Public_Void_IClippable_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_RemoveClippable_Public_Void_IClippable_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0;
	}
}
