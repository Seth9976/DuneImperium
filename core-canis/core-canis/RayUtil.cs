using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000059 RID: 89
public static class RayUtil : global::Il2CppSystem.Object
{
	// Token: 0x06000668 RID: 1640 RVA: 0x0002D790 File Offset: 0x0002B990
	// Note: this type is marked as 'beforefieldinit'.
	static RayUtil()
	{
		Il2CppClassPointerStore<RayUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "RayUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayUtil>.NativeClassPtr);
		RayUtil.NativeFieldInfoPtr_cameraBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, "cameraBuffer");
		RayUtil.NativeFieldInfoPtr_cachedCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, "cachedCameras");
		RayUtil.NativeFieldInfoPtr_raycastBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, "raycastBuffer");
		RayUtil.NativeFieldInfoPtr_cachedRayHitsInAllCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, "cachedRayHitsInAllCameras");
		RayUtil.NativeFieldInfoPtr_cachedMousethroughHitsInAllCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, "cachedMousethroughHitsInAllCameras");
		RayUtil.NativeFieldInfoPtr_tempScreenRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, "tempScreenRects");
		RayUtil.NativeFieldInfoPtr_cornersScratch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, "cornersScratch");
		RayUtil.NativeFieldInfoPtr_hierarchyCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, "hierarchyCache");
		RayUtil.NativeFieldInfoPtr_cachedVectorArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, "cachedVectorArray");
		RayUtil.NativeFieldInfoPtr_emptyVectorArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, "emptyVectorArray");
		RayUtil.NativeFieldInfoPtr_RaycastDistanceSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, "RaycastDistanceSort");
		RayUtil.NativeFieldInfoPtr_CameraDepthSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, "CameraDepthSort");
		RayUtil.NativeMethodInfoPtr_filterSafeRaycasts_Private_Static_Void_IList_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664266);
		RayUtil.NativeMethodInfoPtr_RaycastAllSorted_Public_Static_Void_Camera_Vector2_List_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664267);
		RayUtil.NativeMethodInfoPtr_RaycastAllSortedIgnoreOverride_Public_Static_Void_Camera_Vector3_Int32_List_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664268);
		RayUtil.NativeMethodInfoPtr_RaycastAllSortedIgnoreOverride_Public_Static_Void_Camera_Vector3_List_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664269);
		RayUtil.NativeMethodInfoPtr_RacastQueryInAllCameras_Public_Static_RaycastQueryData_Vector2_Boolean_IList_1_CameraRaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664270);
		RayUtil.NativeMethodInfoPtr_GetSingleHitInAllCameras_Public_Static_Nullable_1_CameraRaycastHit_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664271);
		RayUtil.NativeMethodInfoPtr_GetSingleMousethroughHit_Private_Static_Nullable_1_CameraRaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664272);
		RayUtil.NativeMethodInfoPtr_getMousethroughCameraHits_Private_Static_Void_IMousethroughArea_RaycastHit_List_1_CameraRaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664273);
		RayUtil.NativeMethodInfoPtr_SortHitsByDistance_Private_Static_Int32_RaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664274);
		RayUtil.NativeMethodInfoPtr_SortCamerasByDepth_Private_Static_Int32_Camera_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664275);
		RayUtil.NativeMethodInfoPtr_GetVisualHierarchy_Public_Static_Void_Transform_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664276);
		RayUtil.NativeMethodInfoPtr_GetLargestVisibleScreenRect_Public_Static_ScreenRect_MonoBounds_byref_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664277);
		RayUtil.NativeMethodInfoPtr_GetLargestVisibleScreenRect_Public_Static_ScreenRect_Transform_Bounds_byref_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664278);
		RayUtil.NativeMethodInfoPtr_GetLargestVisibleScreenRect_Public_Static_ScreenRect_Transform_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664279);
		RayUtil.NativeMethodInfoPtr_GetLargestVisibleScreenRect_Public_Static_ScreenRect_MonoBounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664280);
		RayUtil.NativeMethodInfoPtr_getLargestVisibleScreenRect_Private_Static_ScreenRect_Dictionary_2_Camera_ScreenRect_byref_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664281);
		RayUtil.NativeMethodInfoPtr_GetScreenRects_Public_Static_Dictionary_2_Camera_ScreenRect_Transform_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664282);
		RayUtil.NativeMethodInfoPtr_GetScreenRects_Public_Static_Void_Transform_Bounds_Dictionary_2_Camera_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664283);
		RayUtil.NativeMethodInfoPtr_ElementScreenRect_Public_Static_ScreenRect_Camera_MonoBounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664284);
		RayUtil.NativeMethodInfoPtr_GetScreenRect_Public_Static_ScreenRect_Camera_GlobalTransform_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664285);
		RayUtil.NativeMethodInfoPtr_worldToScreenPoints_Private_Static_IList_1_Vector3_Camera_IList_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664286);
		RayUtil.NativeMethodInfoPtr_globalTransformThroughViewport_Private_Static_Il2CppStructArray_1_Vector3_IMousethroughCamera_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664287);
		RayUtil.NativeMethodInfoPtr_getGlobalCorners_Private_Static_Il2CppStructArray_1_Vector3_MonoBounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664288);
		RayUtil.NativeMethodInfoPtr_getGlobalCorners_Private_Static_Void_Transform_Bounds_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664289);
		RayUtil.NativeMethodInfoPtr_getGlobalCorners_Private_Static_Void_GlobalTransform_Bounds_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayUtil>.NativeClassPtr, 100664290);
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x0002DAA4 File Offset: 0x0002BCA4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 859601, RefRangeEnd = 859603, XrefRangeStart = 859583, XrefRangeEnd = 859601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void filterSafeRaycasts(IList<RaycastHit> hits)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(hits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_filterSafeRaycasts_Private_Static_Void_IList_1_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x0002DADC File Offset: 0x0002BCDC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859658, RefRangeEnd = 859659, XrefRangeStart = 859603, XrefRangeEnd = 859658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RaycastAllSorted(Camera camera, Vector2 screenPoint, List<RaycastHit> hits)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPoint;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hits);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_RaycastAllSorted_Public_Static_Void_Camera_Vector2_List_1_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x0002DB34 File Offset: 0x0002BD34
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 859702, RefRangeEnd = 859705, XrefRangeStart = 859659, XrefRangeEnd = 859702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RaycastAllSortedIgnoreOverride(Camera camera, Vector3 screenPosition, int layerMask, List<RaycastHit> hits)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hits);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_RaycastAllSortedIgnoreOverride_Public_Static_Void_Camera_Vector3_Int32_List_1_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x0002DB98 File Offset: 0x0002BD98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859705, XrefRangeEnd = 859709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RaycastAllSortedIgnoreOverride(Camera camera, Vector3 screenPosition, List<RaycastHit> hits)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hits);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_RaycastAllSortedIgnoreOverride_Public_Static_Void_Camera_Vector3_List_1_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x0002DBF0 File Offset: 0x0002BDF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859826, RefRangeEnd = 859827, XrefRangeStart = 859709, XrefRangeEnd = 859826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RaycastQueryData RacastQueryInAllCameras(Vector2 screenPosition, bool allowOffCameraRectHits = true, IList<CameraRaycastHit> raycastList = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref screenPosition;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowOffCameraRectHits;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastList);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_RacastQueryInAllCameras_Public_Static_RaycastQueryData_Vector2_Boolean_IList_1_CameraRaycastHit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return new RaycastQueryData(intPtr);
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x0002DC48 File Offset: 0x0002BE48
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859905, RefRangeEnd = 859906, XrefRangeStart = 859827, XrefRangeEnd = 859905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Nullable<CameraRaycastHit> GetSingleHitInAllCameras(Vector2 screenPosition, bool allowOffCameraRectHits)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref screenPosition;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowOffCameraRectHits;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_GetSingleHitInAllCameras_Public_Static_Nullable_1_CameraRaycastHit_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return new Nullable<CameraRaycastHit>(intPtr);
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x0002DC90 File Offset: 0x0002BE90
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 859927, RefRangeEnd = 859929, XrefRangeStart = 859906, XrefRangeEnd = 859927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Nullable<CameraRaycastHit> GetSingleMousethroughHit(RaycastHit baseHit)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref baseHit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_GetSingleMousethroughHit_Private_Static_Nullable_1_CameraRaycastHit_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<CameraRaycastHit>(intPtr);
		}
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x0002DCC8 File Offset: 0x0002BEC8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 859948, RefRangeEnd = 859950, XrefRangeStart = 859929, XrefRangeEnd = 859948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getMousethroughCameraHits(IMousethroughArea mousethrough, RaycastHit hit, List<CameraRaycastHit> results)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mousethrough);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hit;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_getMousethroughCameraHits_Private_Static_Void_IMousethroughArea_RaycastHit_List_1_CameraRaycastHit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x0002DD20 File Offset: 0x0002BF20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859950, XrefRangeEnd = 859953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SortHitsByDistance(RaycastHit x, RaycastHit y)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref x;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_SortHitsByDistance_Private_Static_Int32_RaycastHit_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x0002DD6C File Offset: 0x0002BF6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859953, XrefRangeEnd = 859965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SortCamerasByDepth(Camera x, Camera y)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_SortCamerasByDepth_Private_Static_Int32_Camera_Camera_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x0002DDC0 File Offset: 0x0002BFC0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 859986, RefRangeEnd = 859990, XrefRangeStart = 859965, XrefRangeEnd = 859986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetVisualHierarchy(Transform transform, List<Transform> hierarchy)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hierarchy);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_GetVisualHierarchy_Public_Static_Void_Transform_List_1_Transform_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x0002DE08 File Offset: 0x0002C008
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859990, XrefRangeEnd = 859995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect GetLargestVisibleScreenRect(MonoBounds element, out Camera camera)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_GetLargestVisibleScreenRect_Public_Static_ScreenRect_MonoBounds_byref_Camera_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == 0) ? null : new Camera(intPtr4));
		return *IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x0002DE6C File Offset: 0x0002C06C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 860006, RefRangeEnd = 860008, XrefRangeStart = 859995, XrefRangeEnd = 860006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect GetLargestVisibleScreenRect(Transform transform, Bounds localBounds, out Camera camera)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localBounds;
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_GetLargestVisibleScreenRect_Public_Static_ScreenRect_Transform_Bounds_byref_Camera_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == 0) ? null : new Camera(intPtr4));
		return *IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x0002DEE0 File Offset: 0x0002C0E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860008, XrefRangeEnd = 860022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect GetLargestVisibleScreenRect(Transform transform, Bounds localBounds)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localBounds;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_GetLargestVisibleScreenRect_Public_Static_ScreenRect_Transform_Bounds_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x0002DF30 File Offset: 0x0002C130
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 860030, RefRangeEnd = 860031, XrefRangeStart = 860022, XrefRangeEnd = 860030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect GetLargestVisibleScreenRect(MonoBounds element)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_GetLargestVisibleScreenRect_Public_Static_ScreenRect_MonoBounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x0002DF74 File Offset: 0x0002C174
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 860053, RefRangeEnd = 860055, XrefRangeStart = 860031, XrefRangeEnd = 860053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect getLargestVisibleScreenRect(Dictionary<Camera, ScreenRect> rects, out Camera camera)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rects);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_getLargestVisibleScreenRect_Private_Static_ScreenRect_Dictionary_2_Camera_ScreenRect_byref_Camera_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == 0) ? null : new Camera(intPtr4));
		return *IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860055, XrefRangeEnd = 860065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<Camera, ScreenRect> GetScreenRects(Transform element, Bounds bounds)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_GetScreenRects_Public_Static_Dictionary_2_Camera_ScreenRect_Transform_Bounds_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<Camera, ScreenRect>>(intPtr3) : null;
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x0002E02C File Offset: 0x0002C22C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 860168, RefRangeEnd = 860171, XrefRangeStart = 860065, XrefRangeEnd = 860168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetScreenRects(Transform element, Bounds bounds, Dictionary<Camera, ScreenRect> screenRects)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(screenRects);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_GetScreenRects_Public_Static_Void_Transform_Bounds_Dictionary_2_Camera_ScreenRect_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x0002E084 File Offset: 0x0002C284
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860171, XrefRangeEnd = 860194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect ElementScreenRect(this Camera camera, MonoBounds element)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_ElementScreenRect_Public_Static_ScreenRect_Camera_MonoBounds_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x0002E0D8 File Offset: 0x0002C2D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860194, XrefRangeEnd = 860202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect GetScreenRect(this Camera camera, GlobalTransform transform, Bounds bounds)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transform;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_GetScreenRect_Public_Static_ScreenRect_Camera_GlobalTransform_Bounds_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x0002E138 File Offset: 0x0002C338
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 860215, RefRangeEnd = 860218, XrefRangeStart = 860202, XrefRangeEnd = 860215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IList<Vector3> worldToScreenPoints(this Camera camera, IList<Vector3> points)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_worldToScreenPoints_Private_Static_IList_1_Vector3_Camera_IList_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Vector3>>(intPtr3) : null;
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x0002E190 File Offset: 0x0002C390
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 860245, RefRangeEnd = 860246, XrefRangeStart = 860218, XrefRangeEnd = 860245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> globalTransformThroughViewport(IMousethroughCamera mousethrough, Il2CppStructArray<Vector3> corners)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mousethrough);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(corners);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_globalTransformThroughViewport_Private_Static_Il2CppStructArray_1_Vector3_IMousethroughCamera_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x0002E1E8 File Offset: 0x0002C3E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860246, XrefRangeEnd = 860254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> getGlobalCorners(MonoBounds element)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_getGlobalCorners_Private_Static_Il2CppStructArray_1_Vector3_MonoBounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x0002E22C File Offset: 0x0002C42C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 860262, RefRangeEnd = 860264, XrefRangeStart = 860254, XrefRangeEnd = 860262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getGlobalCorners(Transform pointTransformer, Bounds bounds, Il2CppStructArray<Vector3> result)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointTransformer);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_getGlobalCorners_Private_Static_Void_Transform_Bounds_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x0002E284 File Offset: 0x0002C484
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 860275, RefRangeEnd = 860276, XrefRangeStart = 860264, XrefRangeEnd = 860275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getGlobalCorners(GlobalTransform pointTransformer, Bounds bounds, Il2CppStructArray<Vector3> result)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pointTransformer;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RayUtil.NativeMethodInfoPtr_getGlobalCorners_Private_Static_Void_GlobalTransform_Bounds_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x000041EC File Offset: 0x000023EC
	public RayUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06000683 RID: 1667 RVA: 0x0002E2D8 File Offset: 0x0002C4D8
	// (set) Token: 0x06000684 RID: 1668 RVA: 0x000041F5 File Offset: 0x000023F5
	public unsafe static Il2CppReferenceArray<Camera> cameraBuffer
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RayUtil.NativeFieldInfoPtr_cameraBuffer, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Camera>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RayUtil.NativeFieldInfoPtr_cameraBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x06000685 RID: 1669 RVA: 0x0002E300 File Offset: 0x0002C500
	// (set) Token: 0x06000686 RID: 1670 RVA: 0x00004207 File Offset: 0x00002407
	public unsafe static List<Camera> cachedCameras
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RayUtil.NativeFieldInfoPtr_cachedCameras, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RayUtil.NativeFieldInfoPtr_cachedCameras, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x06000687 RID: 1671 RVA: 0x0002E328 File Offset: 0x0002C528
	// (set) Token: 0x06000688 RID: 1672 RVA: 0x00004219 File Offset: 0x00002419
	public unsafe static Il2CppStructArray<RaycastHit> raycastBuffer
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RayUtil.NativeFieldInfoPtr_raycastBuffer, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RayUtil.NativeFieldInfoPtr_raycastBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x06000689 RID: 1673 RVA: 0x0002E350 File Offset: 0x0002C550
	// (set) Token: 0x0600068A RID: 1674 RVA: 0x0000422B File Offset: 0x0000242B
	public unsafe static List<RaycastHit> cachedRayHitsInAllCameras
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RayUtil.NativeFieldInfoPtr_cachedRayHitsInAllCameras, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastHit>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RayUtil.NativeFieldInfoPtr_cachedRayHitsInAllCameras, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x0600068B RID: 1675 RVA: 0x0002E378 File Offset: 0x0002C578
	// (set) Token: 0x0600068C RID: 1676 RVA: 0x0000423D File Offset: 0x0000243D
	public unsafe static List<CameraRaycastHit> cachedMousethroughHitsInAllCameras
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RayUtil.NativeFieldInfoPtr_cachedMousethroughHitsInAllCameras, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CameraRaycastHit>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RayUtil.NativeFieldInfoPtr_cachedMousethroughHitsInAllCameras, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x0600068D RID: 1677 RVA: 0x0002E3A0 File Offset: 0x0002C5A0
	// (set) Token: 0x0600068E RID: 1678 RVA: 0x0000424F File Offset: 0x0000244F
	public unsafe static Dictionary<Camera, ScreenRect> tempScreenRects
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RayUtil.NativeFieldInfoPtr_tempScreenRects, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Camera, ScreenRect>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RayUtil.NativeFieldInfoPtr_tempScreenRects, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x0600068F RID: 1679 RVA: 0x0002E3C8 File Offset: 0x0002C5C8
	// (set) Token: 0x06000690 RID: 1680 RVA: 0x00004261 File Offset: 0x00002461
	public unsafe static List<Vector3> cornersScratch
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RayUtil.NativeFieldInfoPtr_cornersScratch, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RayUtil.NativeFieldInfoPtr_cornersScratch, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x06000691 RID: 1681 RVA: 0x0002E3F0 File Offset: 0x0002C5F0
	// (set) Token: 0x06000692 RID: 1682 RVA: 0x00004273 File Offset: 0x00002473
	public unsafe static List<Transform> hierarchyCache
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RayUtil.NativeFieldInfoPtr_hierarchyCache, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RayUtil.NativeFieldInfoPtr_hierarchyCache, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06000693 RID: 1683 RVA: 0x0002E418 File Offset: 0x0002C618
	// (set) Token: 0x06000694 RID: 1684 RVA: 0x00004285 File Offset: 0x00002485
	public unsafe static Il2CppStructArray<Vector3> cachedVectorArray
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RayUtil.NativeFieldInfoPtr_cachedVectorArray, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RayUtil.NativeFieldInfoPtr_cachedVectorArray, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x06000695 RID: 1685 RVA: 0x0002E440 File Offset: 0x0002C640
	// (set) Token: 0x06000696 RID: 1686 RVA: 0x00004297 File Offset: 0x00002497
	public unsafe static Il2CppStructArray<Vector3> emptyVectorArray
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RayUtil.NativeFieldInfoPtr_emptyVectorArray, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RayUtil.NativeFieldInfoPtr_emptyVectorArray, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06000697 RID: 1687 RVA: 0x0002E468 File Offset: 0x0002C668
	// (set) Token: 0x06000698 RID: 1688 RVA: 0x000042A9 File Offset: 0x000024A9
	public unsafe static Comparison<RaycastHit> RaycastDistanceSort
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RayUtil.NativeFieldInfoPtr_RaycastDistanceSort, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<RaycastHit>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RayUtil.NativeFieldInfoPtr_RaycastDistanceSort, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06000699 RID: 1689 RVA: 0x0002E490 File Offset: 0x0002C690
	// (set) Token: 0x0600069A RID: 1690 RVA: 0x000042BB File Offset: 0x000024BB
	public unsafe static Comparison<Camera> CameraDepthSort
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RayUtil.NativeFieldInfoPtr_CameraDepthSort, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Camera>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RayUtil.NativeFieldInfoPtr_CameraDepthSort, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040004CD RID: 1229
	private static readonly IntPtr NativeFieldInfoPtr_cameraBuffer;

	// Token: 0x040004CE RID: 1230
	private static readonly IntPtr NativeFieldInfoPtr_cachedCameras;

	// Token: 0x040004CF RID: 1231
	private static readonly IntPtr NativeFieldInfoPtr_raycastBuffer;

	// Token: 0x040004D0 RID: 1232
	private static readonly IntPtr NativeFieldInfoPtr_cachedRayHitsInAllCameras;

	// Token: 0x040004D1 RID: 1233
	private static readonly IntPtr NativeFieldInfoPtr_cachedMousethroughHitsInAllCameras;

	// Token: 0x040004D2 RID: 1234
	private static readonly IntPtr NativeFieldInfoPtr_tempScreenRects;

	// Token: 0x040004D3 RID: 1235
	private static readonly IntPtr NativeFieldInfoPtr_cornersScratch;

	// Token: 0x040004D4 RID: 1236
	private static readonly IntPtr NativeFieldInfoPtr_hierarchyCache;

	// Token: 0x040004D5 RID: 1237
	private static readonly IntPtr NativeFieldInfoPtr_cachedVectorArray;

	// Token: 0x040004D6 RID: 1238
	private static readonly IntPtr NativeFieldInfoPtr_emptyVectorArray;

	// Token: 0x040004D7 RID: 1239
	private static readonly IntPtr NativeFieldInfoPtr_RaycastDistanceSort;

	// Token: 0x040004D8 RID: 1240
	private static readonly IntPtr NativeFieldInfoPtr_CameraDepthSort;

	// Token: 0x040004D9 RID: 1241
	private static readonly IntPtr NativeMethodInfoPtr_filterSafeRaycasts_Private_Static_Void_IList_1_RaycastHit_0;

	// Token: 0x040004DA RID: 1242
	private static readonly IntPtr NativeMethodInfoPtr_RaycastAllSorted_Public_Static_Void_Camera_Vector2_List_1_RaycastHit_0;

	// Token: 0x040004DB RID: 1243
	private static readonly IntPtr NativeMethodInfoPtr_RaycastAllSortedIgnoreOverride_Public_Static_Void_Camera_Vector3_Int32_List_1_RaycastHit_0;

	// Token: 0x040004DC RID: 1244
	private static readonly IntPtr NativeMethodInfoPtr_RaycastAllSortedIgnoreOverride_Public_Static_Void_Camera_Vector3_List_1_RaycastHit_0;

	// Token: 0x040004DD RID: 1245
	private static readonly IntPtr NativeMethodInfoPtr_RacastQueryInAllCameras_Public_Static_RaycastQueryData_Vector2_Boolean_IList_1_CameraRaycastHit_0;

	// Token: 0x040004DE RID: 1246
	private static readonly IntPtr NativeMethodInfoPtr_GetSingleHitInAllCameras_Public_Static_Nullable_1_CameraRaycastHit_Vector2_Boolean_0;

	// Token: 0x040004DF RID: 1247
	private static readonly IntPtr NativeMethodInfoPtr_GetSingleMousethroughHit_Private_Static_Nullable_1_CameraRaycastHit_RaycastHit_0;

	// Token: 0x040004E0 RID: 1248
	private static readonly IntPtr NativeMethodInfoPtr_getMousethroughCameraHits_Private_Static_Void_IMousethroughArea_RaycastHit_List_1_CameraRaycastHit_0;

	// Token: 0x040004E1 RID: 1249
	private static readonly IntPtr NativeMethodInfoPtr_SortHitsByDistance_Private_Static_Int32_RaycastHit_RaycastHit_0;

	// Token: 0x040004E2 RID: 1250
	private static readonly IntPtr NativeMethodInfoPtr_SortCamerasByDepth_Private_Static_Int32_Camera_Camera_0;

	// Token: 0x040004E3 RID: 1251
	private static readonly IntPtr NativeMethodInfoPtr_GetVisualHierarchy_Public_Static_Void_Transform_List_1_Transform_0;

	// Token: 0x040004E4 RID: 1252
	private static readonly IntPtr NativeMethodInfoPtr_GetLargestVisibleScreenRect_Public_Static_ScreenRect_MonoBounds_byref_Camera_0;

	// Token: 0x040004E5 RID: 1253
	private static readonly IntPtr NativeMethodInfoPtr_GetLargestVisibleScreenRect_Public_Static_ScreenRect_Transform_Bounds_byref_Camera_0;

	// Token: 0x040004E6 RID: 1254
	private static readonly IntPtr NativeMethodInfoPtr_GetLargestVisibleScreenRect_Public_Static_ScreenRect_Transform_Bounds_0;

	// Token: 0x040004E7 RID: 1255
	private static readonly IntPtr NativeMethodInfoPtr_GetLargestVisibleScreenRect_Public_Static_ScreenRect_MonoBounds_0;

	// Token: 0x040004E8 RID: 1256
	private static readonly IntPtr NativeMethodInfoPtr_getLargestVisibleScreenRect_Private_Static_ScreenRect_Dictionary_2_Camera_ScreenRect_byref_Camera_0;

	// Token: 0x040004E9 RID: 1257
	private static readonly IntPtr NativeMethodInfoPtr_GetScreenRects_Public_Static_Dictionary_2_Camera_ScreenRect_Transform_Bounds_0;

	// Token: 0x040004EA RID: 1258
	private static readonly IntPtr NativeMethodInfoPtr_GetScreenRects_Public_Static_Void_Transform_Bounds_Dictionary_2_Camera_ScreenRect_0;

	// Token: 0x040004EB RID: 1259
	private static readonly IntPtr NativeMethodInfoPtr_ElementScreenRect_Public_Static_ScreenRect_Camera_MonoBounds_0;

	// Token: 0x040004EC RID: 1260
	private static readonly IntPtr NativeMethodInfoPtr_GetScreenRect_Public_Static_ScreenRect_Camera_GlobalTransform_Bounds_0;

	// Token: 0x040004ED RID: 1261
	private static readonly IntPtr NativeMethodInfoPtr_worldToScreenPoints_Private_Static_IList_1_Vector3_Camera_IList_1_Vector3_0;

	// Token: 0x040004EE RID: 1262
	private static readonly IntPtr NativeMethodInfoPtr_globalTransformThroughViewport_Private_Static_Il2CppStructArray_1_Vector3_IMousethroughCamera_Il2CppStructArray_1_Vector3_0;

	// Token: 0x040004EF RID: 1263
	private static readonly IntPtr NativeMethodInfoPtr_getGlobalCorners_Private_Static_Il2CppStructArray_1_Vector3_MonoBounds_0;

	// Token: 0x040004F0 RID: 1264
	private static readonly IntPtr NativeMethodInfoPtr_getGlobalCorners_Private_Static_Void_Transform_Bounds_Il2CppStructArray_1_Vector3_0;

	// Token: 0x040004F1 RID: 1265
	private static readonly IntPtr NativeMethodInfoPtr_getGlobalCorners_Private_Static_Void_GlobalTransform_Bounds_Il2CppStructArray_1_Vector3_0;
}
