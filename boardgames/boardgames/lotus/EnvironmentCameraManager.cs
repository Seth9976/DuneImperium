using System;
using boardgames.camera;
using DG.Tweening;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000D1 RID: 209
	public class EnvironmentCameraManager : BaseCameraManager
	{
		// Token: 0x06000A11 RID: 2577 RVA: 0x0003132C File Offset: 0x0002F52C
		// Note: this type is marked as 'beforefieldinit'.
		static EnvironmentCameraManager()
		{
			Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "EnvironmentCameraManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr);
			EnvironmentCameraManager.NativeFieldInfoPtr_InitializeOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "InitializeOnStart");
			EnvironmentCameraManager.NativeFieldInfoPtr_DragID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "DragID");
			EnvironmentCameraManager.NativeFieldInfoPtr_cameraBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "cameraBox");
			EnvironmentCameraManager.NativeFieldInfoPtr_currentZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "currentZoom");
			EnvironmentCameraManager.NativeFieldInfoPtr_zoomMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "zoomMax");
			EnvironmentCameraManager.NativeFieldInfoPtr_zoomMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "zoomMin");
			EnvironmentCameraManager.NativeFieldInfoPtr_cameraBoxAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "cameraBoxAdjustments");
			EnvironmentCameraManager.NativeFieldInfoPtr_cameraBoxZoomMaxRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "cameraBoxZoomMaxRatio");
			EnvironmentCameraManager.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "cam");
			EnvironmentCameraManager.NativeFieldInfoPtr_camT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "camT");
			EnvironmentCameraManager.NativeFieldInfoPtr_currentTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "currentTransition");
			EnvironmentCameraManager.NativeFieldInfoPtr_runningTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "runningTweens");
			EnvironmentCameraManager.NativeFieldInfoPtr_startingLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "startingLocation");
			EnvironmentCameraManager.NativeFieldInfoPtr_startingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "startingPosition");
			EnvironmentCameraManager.NativeFieldInfoPtr_currentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "currentPosition");
			EnvironmentCameraManager.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "positions");
			EnvironmentCameraManager.NativeFieldInfoPtr_positionsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "positionsMap");
			EnvironmentCameraManager.NativeFieldInfoPtr_envDragPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "envDragPosition");
			EnvironmentCameraManager.NativeFieldInfoPtr_savedPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "savedPositions");
			EnvironmentCameraManager.NativeFieldInfoPtr_lastLoadedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "lastLoadedPosition");
			EnvironmentCameraManager.NativeFieldInfoPtr_defaultSavePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "defaultSavePosition");
			EnvironmentCameraManager.NativeFieldInfoPtr_isTransitioning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "isTransitioning");
			EnvironmentCameraManager.NativeFieldInfoPtr_scrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "scrollSpeed");
			EnvironmentCameraManager.NativeFieldInfoPtr_environmentDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "environmentDrag");
			EnvironmentCameraManager.NativeFieldInfoPtr_environmentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "environmentContainer");
			EnvironmentCameraManager.NativeFieldInfoPtr_lastInputPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "lastInputPosition");
			EnvironmentCameraManager.NativeFieldInfoPtr_envPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "envPlane");
			EnvironmentCameraManager.NativeFieldInfoPtr_defaultFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "defaultFOV");
			EnvironmentCameraManager.NativeFieldInfoPtr_um = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "um");
			EnvironmentCameraManager.NativeFieldInfoPtr_dragEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "dragEnabled");
			EnvironmentCameraManager.NativeFieldInfoPtr_look = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "look");
			EnvironmentCameraManager.NativeFieldInfoPtr_easeInputMovementTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "easeInputMovementTime");
			EnvironmentCameraManager.NativeFieldInfoPtr_easingMinimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "easingMinimum");
			EnvironmentCameraManager.NativeFieldInfoPtr_easingDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "easingDrag");
			EnvironmentCameraManager.NativeFieldInfoPtr_endDragVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "endDragVelocity");
			EnvironmentCameraManager.NativeFieldInfoPtr_endDragDamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "endDragDamp");
			EnvironmentCameraManager.NativeFieldInfoPtr_scrolling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "scrolling");
			EnvironmentCameraManager.NativeFieldInfoPtr_dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "dragging");
			EnvironmentCameraManager.NativeFieldInfoPtr_easingScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "easingScroll");
			EnvironmentCameraManager.NativeFieldInfoPtr_endScrollVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "endScrollVelocity");
			EnvironmentCameraManager.NativeFieldInfoPtr_endScrollDamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "endScrollDamp");
			EnvironmentCameraManager.NativeMethodInfoPtr_get_ZoomMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664929);
			EnvironmentCameraManager.NativeMethodInfoPtr_set_ZoomMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664930);
			EnvironmentCameraManager.NativeMethodInfoPtr_get_ZoomMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664931);
			EnvironmentCameraManager.NativeMethodInfoPtr_set_ZoomMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664932);
			EnvironmentCameraManager.NativeMethodInfoPtr_get_CamT_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664933);
			EnvironmentCameraManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664934);
			EnvironmentCameraManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664935);
			EnvironmentCameraManager.NativeMethodInfoPtr_InitPositionsMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664936);
			EnvironmentCameraManager.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664937);
			EnvironmentCameraManager.NativeMethodInfoPtr_Clone_Public_EnvironmentCameraPosition_EnvironmentCameraPosition_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664938);
			EnvironmentCameraManager.NativeMethodInfoPtr_SavePosition_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664939);
			EnvironmentCameraManager.NativeMethodInfoPtr_LoadPosition_Public_Virtual_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664940);
			EnvironmentCameraManager.NativeMethodInfoPtr_TransitionTo_Public_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664941);
			EnvironmentCameraManager.NativeMethodInfoPtr_TransitionTo_Public_IEnumerator_EnvironmentCameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664942);
			EnvironmentCameraManager.NativeMethodInfoPtr_TransitionToEnvrionmentAt_Public_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664943);
			EnvironmentCameraManager.NativeMethodInfoPtr_TransitionBackToEnvironment_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664944);
			EnvironmentCameraManager.NativeMethodInfoPtr_TransitionEnvironmentTo_Public_IEnumerator_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664945);
			EnvironmentCameraManager.NativeMethodInfoPtr_clearTransition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664946);
			EnvironmentCameraManager.NativeMethodInfoPtr_CutTo_Public_Void_EnvironmentCameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664947);
			EnvironmentCameraManager.NativeMethodInfoPtr_doTransition_Private_IEnumerator_EnvironmentCameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664948);
			EnvironmentCameraManager.NativeMethodInfoPtr_transitionToSavedLocation_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664949);
			EnvironmentCameraManager.NativeMethodInfoPtr_transitionCamera_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664950);
			EnvironmentCameraManager.NativeMethodInfoPtr_lerpLookAt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664951);
			EnvironmentCameraManager.NativeMethodInfoPtr_HandleScroll_Public_Virtual_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664952);
			EnvironmentCameraManager.NativeMethodInfoPtr_clampPosition_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664953);
			EnvironmentCameraManager.NativeMethodInfoPtr_clampScroll_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664954);
			EnvironmentCameraManager.NativeMethodInfoPtr_HandleDrag_Public_Virtual_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664955);
			EnvironmentCameraManager.NativeMethodInfoPtr_HandleEnvironmentDrag_Public_Virtual_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664956);
			EnvironmentCameraManager.NativeMethodInfoPtr_CanDragEnvironment_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664957);
			EnvironmentCameraManager.NativeMethodInfoPtr_CanTransition_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664958);
			EnvironmentCameraManager.NativeMethodInfoPtr_BlocksHover_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664959);
			EnvironmentCameraManager.NativeMethodInfoPtr_SetDragEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664960);
			EnvironmentCameraManager.NativeMethodInfoPtr_StartDrag_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664961);
			EnvironmentCameraManager.NativeMethodInfoPtr_OnDrag_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664962);
			EnvironmentCameraManager.NativeMethodInfoPtr_EndDrag_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664963);
			EnvironmentCameraManager.NativeMethodInfoPtr_StartPan_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664964);
			EnvironmentCameraManager.NativeMethodInfoPtr_UpdateAxialCameraMovement_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664965);
			EnvironmentCameraManager.NativeMethodInfoPtr_setLookAtPlanePoint_Public_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664966);
			EnvironmentCameraManager.NativeMethodInfoPtr_GetScrollPercentage_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664967);
			EnvironmentCameraManager.NativeMethodInfoPtr_getLookAtPlanePoint_Private_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664968);
			EnvironmentCameraManager.NativeMethodInfoPtr_getEnvPlanePoint_Private_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664969);
			EnvironmentCameraManager.NativeMethodInfoPtr_getEnvPlanePointFromViewport_Private_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664970);
			EnvironmentCameraManager.NativeMethodInfoPtr_GetDistanceFromEnvironmentPlane_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664971);
			EnvironmentCameraManager.NativeMethodInfoPtr_shouldRevertSavedPosition_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664972);
			EnvironmentCameraManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664973);
			EnvironmentCameraManager.NativeMethodInfoPtr__transitionCamera_b__67_0_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664974);
			EnvironmentCameraManager.NativeMethodInfoPtr__transitionCamera_b__67_1_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664975);
			EnvironmentCameraManager.NativeMethodInfoPtr__transitionCamera_b__67_2_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664976);
			EnvironmentCameraManager.NativeMethodInfoPtr__transitionCamera_b__67_3_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, 100664977);
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00031A64 File Offset: 0x0002FC64
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x00031AA0 File Offset: 0x0002FCA0
		public unsafe float ZoomMax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_get_ZoomMax_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993752, XrefRangeEnd = 993758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_set_ZoomMax_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00031AE0 File Offset: 0x0002FCE0
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00031B1C File Offset: 0x0002FD1C
		public unsafe float ZoomMin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_get_ZoomMin_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993758, XrefRangeEnd = 993764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_set_ZoomMin_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00031B5C File Offset: 0x0002FD5C
		public unsafe Transform CamT
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 993768, RefRangeEnd = 993773, XrefRangeStart = 993764, XrefRangeEnd = 993768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_get_CamT_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00031B9C File Offset: 0x0002FD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993773, XrefRangeEnd = 993774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00031BD0 File Offset: 0x0002FDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993774, XrefRangeEnd = 993804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00031C04 File Offset: 0x0002FE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993804, XrefRangeEnd = 993808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitPositionsMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_InitPositionsMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00031C38 File Offset: 0x0002FE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 993868, RefRangeEnd = 993869, XrefRangeStart = 993808, XrefRangeEnd = 993868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00031C6C File Offset: 0x0002FE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993869, XrefRangeEnd = 993879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvironmentCameraPosition Clone(EnvironmentCameraPosition original, Transform newLookAt = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newLookAt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_Clone_Public_EnvironmentCameraPosition_EnvironmentCameraPosition_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnvironmentCameraPosition>(intPtr3) : null;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00031CD0 File Offset: 0x0002FED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 993897, RefRangeEnd = 993898, XrefRangeStart = 993879, XrefRangeEnd = 993897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SavePosition(string positionTag = "default")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(positionTag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_SavePosition_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00031D14 File Offset: 0x0002FF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993898, XrefRangeEnd = 993904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator LoadPosition(string positionTag = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(positionTag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentCameraManager.NativeMethodInfoPtr_LoadPosition_Public_Virtual_IEnumerator_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00031D70 File Offset: 0x0002FF70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 993909, RefRangeEnd = 993910, XrefRangeStart = 993904, XrefRangeEnd = 993909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TransitionTo(string destinationID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(destinationID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_TransitionTo_Public_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00031DC0 File Offset: 0x0002FFC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 993916, RefRangeEnd = 993918, XrefRangeStart = 993910, XrefRangeEnd = 993916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TransitionTo(EnvironmentCameraPosition newPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newPos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_TransitionTo_Public_IEnumerator_EnvironmentCameraPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00031E10 File Offset: 0x00030010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993918, XrefRangeEnd = 993924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TransitionToEnvrionmentAt(string destinationID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(destinationID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_TransitionToEnvrionmentAt_Public_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00031E60 File Offset: 0x00030060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 993928, RefRangeEnd = 993929, XrefRangeStart = 993924, XrefRangeEnd = 993928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TransitionBackToEnvironment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_TransitionBackToEnvironment_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00031EA0 File Offset: 0x000300A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993929, XrefRangeEnd = 993934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TransitionEnvironmentTo(Vector3 positionToLookAt, float duration = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref positionToLookAt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_TransitionEnvironmentTo_Public_IEnumerator_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00031EFC File Offset: 0x000300FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 993946, RefRangeEnd = 993949, XrefRangeStart = 993934, XrefRangeEnd = 993946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void clearTransition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_clearTransition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00031F30 File Offset: 0x00030130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993949, XrefRangeEnd = 993963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CutTo(EnvironmentCameraPosition pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_CutTo_Public_Void_EnvironmentCameraPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00031F74 File Offset: 0x00030174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993963, XrefRangeEnd = 993969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator doTransition(EnvironmentCameraPosition newPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newPos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_doTransition_Private_IEnumerator_EnvironmentCameraPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00031FC4 File Offset: 0x000301C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993969, XrefRangeEnd = 993975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator transitionToSavedLocation(string positionTag = "default")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(positionTag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_transitionToSavedLocation_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00032014 File Offset: 0x00030214
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 993980, RefRangeEnd = 993982, XrefRangeStart = 993975, XrefRangeEnd = 993980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator transitionCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_transitionCamera_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00032054 File Offset: 0x00030254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993982, XrefRangeEnd = 993983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void lerpLookAt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_lerpLookAt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00032088 File Offset: 0x00030288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993983, XrefRangeEnd = 993996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HandleScroll(float scrollDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scrollDelta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentCameraManager.NativeMethodInfoPtr_HandleScroll_Public_Virtual_Boolean_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000320DC File Offset: 0x000302DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 994017, RefRangeEnd = 994021, XrefRangeStart = 993996, XrefRangeEnd = 994017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 clampPosition(Vector3 clampPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clampPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_clampPosition_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00032128 File Offset: 0x00030328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994021, XrefRangeEnd = 994022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float clampScroll(float scrollDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scrollDelta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_clampScroll_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00032174 File Offset: 0x00030374
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HandleDrag(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentCameraManager.NativeMethodInfoPtr_HandleDrag_Public_Virtual_Boolean_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000321CC File Offset: 0x000303CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994022, XrefRangeEnd = 994035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HandleEnvironmentDrag(Transform t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentCameraManager.NativeMethodInfoPtr_HandleEnvironmentDrag_Public_Virtual_Boolean_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00032224 File Offset: 0x00030424
		[CallerCount(0)]
		public unsafe bool CanDragEnvironment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_CanDragEnvironment_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00032260 File Offset: 0x00030460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994035, XrefRangeEnd = 994039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanTransition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_CanTransition_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0003229C File Offset: 0x0003049C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994039, XrefRangeEnd = 994043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool BlocksHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentCameraManager.NativeMethodInfoPtr_BlocksHover_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x000322E4 File Offset: 0x000304E4
		[CallerCount(0)]
		public unsafe void SetDragEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_SetDragEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00032324 File Offset: 0x00030524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994043, XrefRangeEnd = 994049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartDrag(Vector2 pressPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pressPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentCameraManager.NativeMethodInfoPtr_StartDrag_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00032370 File Offset: 0x00030570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994049, XrefRangeEnd = 994059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDrag(Vector2 pressPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pressPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentCameraManager.NativeMethodInfoPtr_OnDrag_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x000323BC File Offset: 0x000305BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994059, XrefRangeEnd = 994061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentCameraManager.NativeMethodInfoPtr_EndDrag_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x000323F8 File Offset: 0x000305F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994061, XrefRangeEnd = 994065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPan()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_StartPan_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0003242C File Offset: 0x0003062C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994065, XrefRangeEnd = 994079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAxialCameraMovement(Vector3 moveDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveDirection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_UpdateAxialCameraMovement_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0003246C File Offset: 0x0003066C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994079, XrefRangeEnd = 994081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setLookAtPlanePoint(Transform source, Transform lookAt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lookAt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_setLookAtPlanePoint_Public_Void_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x000324C0 File Offset: 0x000306C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994081, XrefRangeEnd = 994085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetScrollPercentage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_GetScrollPercentage_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x000324FC File Offset: 0x000306FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 994090, RefRangeEnd = 994094, XrefRangeStart = 994085, XrefRangeEnd = 994090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 getLookAtPlanePoint(Transform source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_getLookAtPlanePoint_Private_Vector3_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0003254C File Offset: 0x0003074C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 994107, RefRangeEnd = 994109, XrefRangeStart = 994094, XrefRangeEnd = 994107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 getEnvPlanePoint(Vector2 screenPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_getEnvPlanePoint_Private_Vector3_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00032598 File Offset: 0x00030798
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 994115, RefRangeEnd = 994118, XrefRangeStart = 994109, XrefRangeEnd = 994115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 getEnvPlanePointFromViewport(Vector2 screenPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_getEnvPlanePointFromViewport_Private_Vector3_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x000325E4 File Offset: 0x000307E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 994120, RefRangeEnd = 994124, XrefRangeStart = 994118, XrefRangeEnd = 994120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDistanceFromEnvironmentPlane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_GetDistanceFromEnvironmentPlane_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00032620 File Offset: 0x00030820
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 994132, RefRangeEnd = 994135, XrefRangeStart = 994124, XrefRangeEnd = 994132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool shouldRevertSavedPosition(string positionTag = "default")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(positionTag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr_shouldRevertSavedPosition_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00032670 File Offset: 0x00030870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994135, XrefRangeEnd = 994162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvironmentCameraManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x000326AC File Offset: 0x000308AC
		[CallerCount(0)]
		public unsafe Vector3 _transitionCamera_b__67_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr__transitionCamera_b__67_0_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000326E8 File Offset: 0x000308E8
		[CallerCount(0)]
		public unsafe void _transitionCamera_b__67_1(Vector3 v3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v3;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr__transitionCamera_b__67_1_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00032728 File Offset: 0x00030928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994162, XrefRangeEnd = 994164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _transitionCamera_b__67_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr__transitionCamera_b__67_2_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00032764 File Offset: 0x00030964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994164, XrefRangeEnd = 994166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _transitionCamera_b__67_3(float fov)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fov;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.NativeMethodInfoPtr__transitionCamera_b__67_3_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000068F1 File Offset: 0x00004AF1
		public EnvironmentCameraManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x000327A4 File Offset: 0x000309A4
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x000068FA File Offset: 0x00004AFA
		public unsafe bool InitializeOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_InitializeOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_InitializeOnStart)) = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x000327CC File Offset: 0x000309CC
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00006915 File Offset: 0x00004B15
		public unsafe static string DragID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnvironmentCameraManager.NativeFieldInfoPtr_DragID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnvironmentCameraManager.NativeFieldInfoPtr_DragID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x000327EC File Offset: 0x000309EC
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00006927 File Offset: 0x00004B27
		public unsafe BoxCollider cameraBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_cameraBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_cameraBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x0003281C File Offset: 0x00030A1C
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x00006946 File Offset: 0x00004B46
		public unsafe float currentZoom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_currentZoom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_currentZoom)) = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00032844 File Offset: 0x00030A44
		// (set) Token: 0x06000A4D RID: 2637 RVA: 0x00006961 File Offset: 0x00004B61
		public unsafe float zoomMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_zoomMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_zoomMax)) = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0003286C File Offset: 0x00030A6C
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x0000697C File Offset: 0x00004B7C
		public unsafe float zoomMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_zoomMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_zoomMin)) = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00032894 File Offset: 0x00030A94
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00006997 File Offset: 0x00004B97
		public unsafe List<EnvironmentCameraManager.PlatformCameraBoxAdjustment> cameraBoxAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_cameraBoxAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EnvironmentCameraManager.PlatformCameraBoxAdjustment>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_cameraBoxAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x000328C4 File Offset: 0x00030AC4
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x000069B6 File Offset: 0x00004BB6
		public unsafe float cameraBoxZoomMaxRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_cameraBoxZoomMaxRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_cameraBoxZoomMaxRatio)) = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x000328EC File Offset: 0x00030AEC
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x000069D1 File Offset: 0x00004BD1
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0003291C File Offset: 0x00030B1C
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x000069F0 File Offset: 0x00004BF0
		public unsafe Transform camT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_camT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_camT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0003294C File Offset: 0x00030B4C
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x00006A0F File Offset: 0x00004C0F
		public unsafe IEnumerator currentTransition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_currentTransition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_currentTransition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0003297C File Offset: 0x00030B7C
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x00006A2E File Offset: 0x00004C2E
		public unsafe List<Tween> runningTweens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_runningTweens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_runningTweens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x000329AC File Offset: 0x00030BAC
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00006A4D File Offset: 0x00004C4D
		public unsafe Transform startingLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_startingLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_startingLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x000329DC File Offset: 0x00030BDC
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00006A6C File Offset: 0x00004C6C
		public unsafe EnvironmentCameraPosition startingPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_startingPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentCameraPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_startingPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00032A0C File Offset: 0x00030C0C
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00006A8B File Offset: 0x00004C8B
		public unsafe EnvironmentCameraPosition currentPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_currentPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentCameraPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_currentPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00032A3C File Offset: 0x00030C3C
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00006AAA File Offset: 0x00004CAA
		public unsafe List<EnvironmentCameraPosition> positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EnvironmentCameraPosition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00032A6C File Offset: 0x00030C6C
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00006AC9 File Offset: 0x00004CC9
		public unsafe LocalDataManager<string, EnvironmentCameraPosition> positionsMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_positionsMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataManager<string, EnvironmentCameraPosition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_positionsMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00032A9C File Offset: 0x00030C9C
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00006AE8 File Offset: 0x00004CE8
		public unsafe EnvironmentCameraPosition envDragPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_envDragPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentCameraPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_envDragPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00032ACC File Offset: 0x00030CCC
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00006B07 File Offset: 0x00004D07
		public unsafe Dictionary<string, EnvironmentCameraManager.EnvironmentCameraPositionData> savedPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_savedPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, EnvironmentCameraManager.EnvironmentCameraPositionData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_savedPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00032AFC File Offset: 0x00030CFC
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x00006B26 File Offset: 0x00004D26
		public unsafe string lastLoadedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_lastLoadedPosition);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_lastLoadedPosition), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00032B24 File Offset: 0x00030D24
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00006B45 File Offset: 0x00004D45
		public unsafe static string defaultSavePosition
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnvironmentCameraManager.NativeFieldInfoPtr_defaultSavePosition, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnvironmentCameraManager.NativeFieldInfoPtr_defaultSavePosition, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00032B44 File Offset: 0x00030D44
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00006B57 File Offset: 0x00004D57
		public unsafe bool isTransitioning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_isTransitioning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_isTransitioning)) = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00032B6C File Offset: 0x00030D6C
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00006B72 File Offset: 0x00004D72
		public unsafe float scrollSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_scrollSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_scrollSpeed)) = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00032B94 File Offset: 0x00030D94
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00006B8D File Offset: 0x00004D8D
		public unsafe Transform environmentDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_environmentDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_environmentDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00032BC4 File Offset: 0x00030DC4
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00006BAC File Offset: 0x00004DAC
		public unsafe Transform environmentContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_environmentContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_environmentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00032BF4 File Offset: 0x00030DF4
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00006BCB File Offset: 0x00004DCB
		public unsafe Vector2 lastInputPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_lastInputPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_lastInputPosition)) = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00032C1C File Offset: 0x00030E1C
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x00006BE6 File Offset: 0x00004DE6
		public unsafe Plane envPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_envPlane);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_envPlane)) = value;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x00032C44 File Offset: 0x00030E44
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x00006C01 File Offset: 0x00004E01
		public unsafe float defaultFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_defaultFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_defaultFOV)) = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x00032C6C File Offset: 0x00030E6C
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x00006C1C File Offset: 0x00004E1C
		public unsafe UpdateManager um
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_um);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_um), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00032C9C File Offset: 0x00030E9C
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x00006C3B File Offset: 0x00004E3B
		public unsafe bool dragEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_dragEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_dragEnabled)) = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x00032CC4 File Offset: 0x00030EC4
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x00006C56 File Offset: 0x00004E56
		public unsafe Vector3 look
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_look);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_look)) = value;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x00032CEC File Offset: 0x00030EEC
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x00006C71 File Offset: 0x00004E71
		public unsafe float easeInputMovementTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_easeInputMovementTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_easeInputMovementTime)) = value;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x00032D14 File Offset: 0x00030F14
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x00006C8C File Offset: 0x00004E8C
		public unsafe float easingMinimum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_easingMinimum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_easingMinimum)) = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x00032D3C File Offset: 0x00030F3C
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x00006CA7 File Offset: 0x00004EA7
		public unsafe bool easingDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_easingDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_easingDrag)) = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x00032D64 File Offset: 0x00030F64
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x00006CC2 File Offset: 0x00004EC2
		public unsafe Vector3 endDragVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_endDragVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_endDragVelocity)) = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x00032D8C File Offset: 0x00030F8C
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x00006CDD File Offset: 0x00004EDD
		public unsafe Vector3 endDragDamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_endDragDamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_endDragDamp)) = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00032DB4 File Offset: 0x00030FB4
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x00006CF8 File Offset: 0x00004EF8
		public unsafe bool scrolling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_scrolling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_scrolling)) = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00032DDC File Offset: 0x00030FDC
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x00006D13 File Offset: 0x00004F13
		public unsafe bool dragging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_dragging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_dragging)) = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00032E04 File Offset: 0x00031004
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x00006D2E File Offset: 0x00004F2E
		public unsafe bool easingScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_easingScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_easingScroll)) = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00032E2C File Offset: 0x0003102C
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00006D49 File Offset: 0x00004F49
		public unsafe Vector3 endScrollVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_endScrollVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_endScrollVelocity)) = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00032E54 File Offset: 0x00031054
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x00006D64 File Offset: 0x00004F64
		public unsafe Vector3 endScrollDamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_endScrollDamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.NativeFieldInfoPtr_endScrollDamp)) = value;
			}
		}

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeFieldInfoPtr_InitializeOnStart;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeFieldInfoPtr_DragID;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeFieldInfoPtr_cameraBox;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeFieldInfoPtr_currentZoom;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeFieldInfoPtr_zoomMax;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeFieldInfoPtr_zoomMin;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeFieldInfoPtr_cameraBoxAdjustments;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeFieldInfoPtr_cameraBoxZoomMaxRatio;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeFieldInfoPtr_camT;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeFieldInfoPtr_currentTransition;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeFieldInfoPtr_runningTweens;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeFieldInfoPtr_startingLocation;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeFieldInfoPtr_startingPosition;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeFieldInfoPtr_currentPosition;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeFieldInfoPtr_positionsMap;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeFieldInfoPtr_envDragPosition;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr_savedPositions;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr_lastLoadedPosition;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeFieldInfoPtr_defaultSavePosition;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeFieldInfoPtr_isTransitioning;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeFieldInfoPtr_scrollSpeed;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeFieldInfoPtr_environmentDrag;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeFieldInfoPtr_environmentContainer;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeFieldInfoPtr_lastInputPosition;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeFieldInfoPtr_envPlane;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeFieldInfoPtr_defaultFOV;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeFieldInfoPtr_um;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeFieldInfoPtr_dragEnabled;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeFieldInfoPtr_look;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeFieldInfoPtr_easeInputMovementTime;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeFieldInfoPtr_easingMinimum;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeFieldInfoPtr_easingDrag;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeFieldInfoPtr_endDragVelocity;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeFieldInfoPtr_endDragDamp;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeFieldInfoPtr_scrolling;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeFieldInfoPtr_dragging;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeFieldInfoPtr_easingScroll;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeFieldInfoPtr_endScrollVelocity;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeFieldInfoPtr_endScrollDamp;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_get_ZoomMax_Public_get_Single_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_set_ZoomMax_Public_set_Void_Single_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_get_ZoomMin_Public_get_Single_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_set_ZoomMin_Public_set_Void_Single_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_get_CamT_Public_get_Transform_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_InitPositionsMap_Public_Void_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_EnvironmentCameraPosition_EnvironmentCameraPosition_Transform_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_SavePosition_Public_Void_String_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_LoadPosition_Public_Virtual_IEnumerator_String_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_TransitionTo_Public_IEnumerator_String_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_TransitionTo_Public_IEnumerator_EnvironmentCameraPosition_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_TransitionToEnvrionmentAt_Public_IEnumerator_String_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_TransitionBackToEnvironment_Public_IEnumerator_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_TransitionEnvironmentTo_Public_IEnumerator_Vector3_Single_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_clearTransition_Private_Void_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_CutTo_Public_Void_EnvironmentCameraPosition_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_doTransition_Private_IEnumerator_EnvironmentCameraPosition_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_transitionToSavedLocation_Private_IEnumerator_String_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_transitionCamera_Private_IEnumerator_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_lerpLookAt_Private_Void_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_HandleScroll_Public_Virtual_Boolean_Single_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_clampPosition_Private_Vector3_Vector3_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_clampScroll_Private_Single_Single_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_HandleDrag_Public_Virtual_Boolean_UnitView_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_HandleEnvironmentDrag_Public_Virtual_Boolean_Transform_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_CanDragEnvironment_Public_Boolean_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_CanTransition_Public_Boolean_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_BlocksHover_Public_Virtual_Boolean_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_SetDragEnabled_Public_Void_Boolean_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_StartDrag_Public_Virtual_Void_Vector2_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_Void_Vector2_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_EndDrag_Public_Virtual_Void_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_StartPan_Public_Void_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAxialCameraMovement_Public_Void_Vector3_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_setLookAtPlanePoint_Public_Void_Transform_Transform_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_GetScrollPercentage_Public_Single_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_getLookAtPlanePoint_Private_Vector3_Transform_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_getEnvPlanePoint_Private_Vector3_Vector2_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_getEnvPlanePointFromViewport_Private_Vector3_Vector2_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_GetDistanceFromEnvironmentPlane_Public_Single_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_shouldRevertSavedPosition_Private_Boolean_String_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr__transitionCamera_b__67_0_Private_Vector3_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr__transitionCamera_b__67_1_Private_Void_Vector3_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr__transitionCamera_b__67_2_Private_Single_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr__transitionCamera_b__67_3_Private_Void_Single_0;

		// Token: 0x02000236 RID: 566
		[Serializable]
		public class PlatformCameraBoxAdjustment : global::Il2CppSystem.Object
		{
			// Token: 0x06001A18 RID: 6680 RVA: 0x00061D00 File Offset: 0x0005FF00
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformCameraBoxAdjustment()
			{
				Il2CppClassPointerStore<EnvironmentCameraManager.PlatformCameraBoxAdjustment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "PlatformCameraBoxAdjustment");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentCameraManager.PlatformCameraBoxAdjustment>.NativeClassPtr);
				EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager.PlatformCameraBoxAdjustment>.NativeClassPtr, "Platform");
				EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager.PlatformCameraBoxAdjustment>.NativeClassPtr, "X");
				EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager.PlatformCameraBoxAdjustment>.NativeClassPtr, "Y");
				EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeFieldInfoPtr_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager.PlatformCameraBoxAdjustment>.NativeClassPtr, "Z");
				EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager.PlatformCameraBoxAdjustment>.NativeClassPtr, 100664978);
			}

			// Token: 0x06001A19 RID: 6681 RVA: 0x00061D90 File Offset: 0x0005FF90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlatformCameraBoxAdjustment()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentCameraManager.PlatformCameraBoxAdjustment>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A1A RID: 6682 RVA: 0x0000E372 File Offset: 0x0000C572
			public PlatformCameraBoxAdjustment(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x06001A1B RID: 6683 RVA: 0x00061DCC File Offset: 0x0005FFCC
			// (set) Token: 0x06001A1C RID: 6684 RVA: 0x0000E37B File Offset: 0x0000C57B
			public unsafe uint Platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeFieldInfoPtr_Platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeFieldInfoPtr_Platform)) = value;
				}
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x06001A1D RID: 6685 RVA: 0x00061DF4 File Offset: 0x0005FFF4
			// (set) Token: 0x06001A1E RID: 6686 RVA: 0x0000E396 File Offset: 0x0000C596
			public unsafe float X
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeFieldInfoPtr_X);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeFieldInfoPtr_X)) = value;
				}
			}

			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x06001A1F RID: 6687 RVA: 0x00061E1C File Offset: 0x0006001C
			// (set) Token: 0x06001A20 RID: 6688 RVA: 0x0000E3B1 File Offset: 0x0000C5B1
			public unsafe float Y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeFieldInfoPtr_Y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeFieldInfoPtr_Y)) = value;
				}
			}

			// Token: 0x1700079F RID: 1951
			// (get) Token: 0x06001A21 RID: 6689 RVA: 0x00061E44 File Offset: 0x00060044
			// (set) Token: 0x06001A22 RID: 6690 RVA: 0x0000E3CC File Offset: 0x0000C5CC
			public unsafe float Z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeFieldInfoPtr_Z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.PlatformCameraBoxAdjustment.NativeFieldInfoPtr_Z)) = value;
				}
			}

			// Token: 0x04000FCA RID: 4042
			private static readonly IntPtr NativeFieldInfoPtr_Platform;

			// Token: 0x04000FCB RID: 4043
			private static readonly IntPtr NativeFieldInfoPtr_X;

			// Token: 0x04000FCC RID: 4044
			private static readonly IntPtr NativeFieldInfoPtr_Y;

			// Token: 0x04000FCD RID: 4045
			private static readonly IntPtr NativeFieldInfoPtr_Z;

			// Token: 0x04000FCE RID: 4046
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000237 RID: 567
		public class EnvironmentCameraPositionData : global::Il2CppSystem.Object
		{
			// Token: 0x06001A23 RID: 6691 RVA: 0x00061E6C File Offset: 0x0006006C
			// Note: this type is marked as 'beforefieldinit'.
			static EnvironmentCameraPositionData()
			{
				Il2CppClassPointerStore<EnvironmentCameraManager.EnvironmentCameraPositionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "EnvironmentCameraPositionData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentCameraManager.EnvironmentCameraPositionData>.NativeClassPtr);
				EnvironmentCameraManager.EnvironmentCameraPositionData.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager.EnvironmentCameraPositionData>.NativeClassPtr, "position");
				EnvironmentCameraManager.EnvironmentCameraPositionData.NativeFieldInfoPtr_lookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager.EnvironmentCameraPositionData>.NativeClassPtr, "lookAt");
				EnvironmentCameraManager.EnvironmentCameraPositionData.NativeFieldInfoPtr_fieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager.EnvironmentCameraPositionData>.NativeClassPtr, "fieldOfView");
				EnvironmentCameraManager.EnvironmentCameraPositionData.NativeFieldInfoPtr_revertOnMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager.EnvironmentCameraPositionData>.NativeClassPtr, "revertOnMovement");
				EnvironmentCameraManager.EnvironmentCameraPositionData.NativeMethodInfoPtr__ctor_Public_Void_EnvironmentCameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager.EnvironmentCameraPositionData>.NativeClassPtr, 100664979);
				EnvironmentCameraManager.EnvironmentCameraPositionData.NativeMethodInfoPtr_Apply_Public_Void_EnvironmentCameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager.EnvironmentCameraPositionData>.NativeClassPtr, 100664980);
			}

			// Token: 0x06001A24 RID: 6692 RVA: 0x00061F10 File Offset: 0x00060110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993516, XrefRangeEnd = 993524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnvironmentCameraPositionData(EnvironmentCameraPosition source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentCameraManager.EnvironmentCameraPositionData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.EnvironmentCameraPositionData.NativeMethodInfoPtr__ctor_Public_Void_EnvironmentCameraPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A25 RID: 6693 RVA: 0x00061F5C File Offset: 0x0006015C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993524, XrefRangeEnd = 993531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Apply(EnvironmentCameraPosition dest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager.EnvironmentCameraPositionData.NativeMethodInfoPtr_Apply_Public_Void_EnvironmentCameraPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A26 RID: 6694 RVA: 0x0000E3E7 File Offset: 0x0000C5E7
			public EnvironmentCameraPositionData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x06001A27 RID: 6695 RVA: 0x00061FA0 File Offset: 0x000601A0
			// (set) Token: 0x06001A28 RID: 6696 RVA: 0x0000E3F0 File Offset: 0x0000C5F0
			public unsafe Vector3 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.EnvironmentCameraPositionData.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.EnvironmentCameraPositionData.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x170007A1 RID: 1953
			// (get) Token: 0x06001A29 RID: 6697 RVA: 0x00061FC8 File Offset: 0x000601C8
			// (set) Token: 0x06001A2A RID: 6698 RVA: 0x0000E40B File Offset: 0x0000C60B
			public unsafe Vector3 lookAt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.EnvironmentCameraPositionData.NativeFieldInfoPtr_lookAt);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.EnvironmentCameraPositionData.NativeFieldInfoPtr_lookAt)) = value;
				}
			}

			// Token: 0x170007A2 RID: 1954
			// (get) Token: 0x06001A2B RID: 6699 RVA: 0x00061FF0 File Offset: 0x000601F0
			// (set) Token: 0x06001A2C RID: 6700 RVA: 0x0000E426 File Offset: 0x0000C626
			public unsafe float fieldOfView
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.EnvironmentCameraPositionData.NativeFieldInfoPtr_fieldOfView);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.EnvironmentCameraPositionData.NativeFieldInfoPtr_fieldOfView)) = value;
				}
			}

			// Token: 0x170007A3 RID: 1955
			// (get) Token: 0x06001A2D RID: 6701 RVA: 0x00062018 File Offset: 0x00060218
			// (set) Token: 0x06001A2E RID: 6702 RVA: 0x0000E441 File Offset: 0x0000C641
			public unsafe bool revertOnMovement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.EnvironmentCameraPositionData.NativeFieldInfoPtr_revertOnMovement);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager.EnvironmentCameraPositionData.NativeFieldInfoPtr_revertOnMovement)) = value;
				}
			}

			// Token: 0x04000FCF RID: 4047
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04000FD0 RID: 4048
			private static readonly IntPtr NativeFieldInfoPtr_lookAt;

			// Token: 0x04000FD1 RID: 4049
			private static readonly IntPtr NativeFieldInfoPtr_fieldOfView;

			// Token: 0x04000FD2 RID: 4050
			private static readonly IntPtr NativeFieldInfoPtr_revertOnMovement;

			// Token: 0x04000FD3 RID: 4051
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EnvironmentCameraPosition_0;

			// Token: 0x04000FD4 RID: 4052
			private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_EnvironmentCameraPosition_0;
		}

		// Token: 0x02000238 RID: 568
		[ObfuscatedName("lotus.EnvironmentCameraManager+<LoadPosition>d__57")]
		public sealed class _LoadPosition_d__57 : global::Il2CppSystem.Object
		{
			// Token: 0x06001A2F RID: 6703 RVA: 0x00062040 File Offset: 0x00060240
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadPosition_d__57()
			{
				Il2CppClassPointerStore<EnvironmentCameraManager._LoadPosition_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "<LoadPosition>d__57");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentCameraManager._LoadPosition_d__57>.NativeClassPtr);
				EnvironmentCameraManager._LoadPosition_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._LoadPosition_d__57>.NativeClassPtr, "<>1__state");
				EnvironmentCameraManager._LoadPosition_d__57.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._LoadPosition_d__57>.NativeClassPtr, "<>2__current");
				EnvironmentCameraManager._LoadPosition_d__57.NativeFieldInfoPtr_positionTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._LoadPosition_d__57>.NativeClassPtr, "positionTag");
				EnvironmentCameraManager._LoadPosition_d__57.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._LoadPosition_d__57>.NativeClassPtr, "<>4__this");
				EnvironmentCameraManager._LoadPosition_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._LoadPosition_d__57>.NativeClassPtr, 100664981);
				EnvironmentCameraManager._LoadPosition_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._LoadPosition_d__57>.NativeClassPtr, 100664982);
				EnvironmentCameraManager._LoadPosition_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._LoadPosition_d__57>.NativeClassPtr, 100664983);
				EnvironmentCameraManager._LoadPosition_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._LoadPosition_d__57>.NativeClassPtr, 100664984);
				EnvironmentCameraManager._LoadPosition_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._LoadPosition_d__57>.NativeClassPtr, 100664985);
				EnvironmentCameraManager._LoadPosition_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._LoadPosition_d__57>.NativeClassPtr, 100664986);
			}

			// Token: 0x06001A30 RID: 6704 RVA: 0x00062134 File Offset: 0x00060334
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadPosition_d__57(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentCameraManager._LoadPosition_d__57>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._LoadPosition_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A31 RID: 6705 RVA: 0x0006217C File Offset: 0x0006037C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._LoadPosition_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A32 RID: 6706 RVA: 0x000621B0 File Offset: 0x000603B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993531, XrefRangeEnd = 993548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._LoadPosition_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007A8 RID: 1960
			// (get) Token: 0x06001A33 RID: 6707 RVA: 0x000621EC File Offset: 0x000603EC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._LoadPosition_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A34 RID: 6708 RVA: 0x0006222C File Offset: 0x0006042C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993548, XrefRangeEnd = 993553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._LoadPosition_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007A9 RID: 1961
			// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00062260 File Offset: 0x00060460
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._LoadPosition_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A36 RID: 6710 RVA: 0x0000E45C File Offset: 0x0000C65C
			public _LoadPosition_d__57(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x06001A37 RID: 6711 RVA: 0x000622A0 File Offset: 0x000604A0
			// (set) Token: 0x06001A38 RID: 6712 RVA: 0x0000E465 File Offset: 0x0000C665
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._LoadPosition_d__57.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._LoadPosition_d__57.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x06001A39 RID: 6713 RVA: 0x000622C8 File Offset: 0x000604C8
			// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0000E480 File Offset: 0x0000C680
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._LoadPosition_d__57.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._LoadPosition_d__57.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x06001A3B RID: 6715 RVA: 0x000622F8 File Offset: 0x000604F8
			// (set) Token: 0x06001A3C RID: 6716 RVA: 0x0000E49F File Offset: 0x0000C69F
			public unsafe string positionTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._LoadPosition_d__57.NativeFieldInfoPtr_positionTag);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._LoadPosition_d__57.NativeFieldInfoPtr_positionTag), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007A7 RID: 1959
			// (get) Token: 0x06001A3D RID: 6717 RVA: 0x00062320 File Offset: 0x00060520
			// (set) Token: 0x06001A3E RID: 6718 RVA: 0x0000E4BE File Offset: 0x0000C6BE
			public unsafe EnvironmentCameraManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._LoadPosition_d__57.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentCameraManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._LoadPosition_d__57.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FD5 RID: 4053
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000FD6 RID: 4054
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000FD7 RID: 4055
			private static readonly IntPtr NativeFieldInfoPtr_positionTag;

			// Token: 0x04000FD8 RID: 4056
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000FD9 RID: 4057
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000FDA RID: 4058
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FDB RID: 4059
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000FDC RID: 4060
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000FDD RID: 4061
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FDE RID: 4062
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000239 RID: 569
		[ObfuscatedName("lotus.EnvironmentCameraManager+<TransitionEnvironmentTo>d__62")]
		public sealed class _TransitionEnvironmentTo_d__62 : global::Il2CppSystem.Object
		{
			// Token: 0x06001A3F RID: 6719 RVA: 0x00062350 File Offset: 0x00060550
			// Note: this type is marked as 'beforefieldinit'.
			static _TransitionEnvironmentTo_d__62()
			{
				Il2CppClassPointerStore<EnvironmentCameraManager._TransitionEnvironmentTo_d__62>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "<TransitionEnvironmentTo>d__62");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionEnvironmentTo_d__62>.NativeClassPtr);
				EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionEnvironmentTo_d__62>.NativeClassPtr, "<>1__state");
				EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionEnvironmentTo_d__62>.NativeClassPtr, "<>2__current");
				EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionEnvironmentTo_d__62>.NativeClassPtr, "<>4__this");
				EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeFieldInfoPtr_positionToLookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionEnvironmentTo_d__62>.NativeClassPtr, "positionToLookAt");
				EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionEnvironmentTo_d__62>.NativeClassPtr, 100664987);
				EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionEnvironmentTo_d__62>.NativeClassPtr, 100664988);
				EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionEnvironmentTo_d__62>.NativeClassPtr, 100664989);
				EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionEnvironmentTo_d__62>.NativeClassPtr, 100664990);
				EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionEnvironmentTo_d__62>.NativeClassPtr, 100664991);
				EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionEnvironmentTo_d__62>.NativeClassPtr, 100664992);
			}

			// Token: 0x06001A40 RID: 6720 RVA: 0x00062444 File Offset: 0x00060644
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TransitionEnvironmentTo_d__62(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionEnvironmentTo_d__62>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A41 RID: 6721 RVA: 0x0006248C File Offset: 0x0006068C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A42 RID: 6722 RVA: 0x000624C0 File Offset: 0x000606C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993553, XrefRangeEnd = 993577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007AE RID: 1966
			// (get) Token: 0x06001A43 RID: 6723 RVA: 0x000624FC File Offset: 0x000606FC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A44 RID: 6724 RVA: 0x0006253C File Offset: 0x0006073C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993577, XrefRangeEnd = 993582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007AF RID: 1967
			// (get) Token: 0x06001A45 RID: 6725 RVA: 0x00062570 File Offset: 0x00060770
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A46 RID: 6726 RVA: 0x0000E4DD File Offset: 0x0000C6DD
			public _TransitionEnvironmentTo_d__62(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x06001A47 RID: 6727 RVA: 0x000625B0 File Offset: 0x000607B0
			// (set) Token: 0x06001A48 RID: 6728 RVA: 0x0000E4E6 File Offset: 0x0000C6E6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x06001A49 RID: 6729 RVA: 0x000625D8 File Offset: 0x000607D8
			// (set) Token: 0x06001A4A RID: 6730 RVA: 0x0000E501 File Offset: 0x0000C701
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007AC RID: 1964
			// (get) Token: 0x06001A4B RID: 6731 RVA: 0x00062608 File Offset: 0x00060808
			// (set) Token: 0x06001A4C RID: 6732 RVA: 0x0000E520 File Offset: 0x0000C720
			public unsafe EnvironmentCameraManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentCameraManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007AD RID: 1965
			// (get) Token: 0x06001A4D RID: 6733 RVA: 0x00062638 File Offset: 0x00060838
			// (set) Token: 0x06001A4E RID: 6734 RVA: 0x0000E53F File Offset: 0x0000C73F
			public unsafe Vector3 positionToLookAt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeFieldInfoPtr_positionToLookAt);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionEnvironmentTo_d__62.NativeFieldInfoPtr_positionToLookAt)) = value;
				}
			}

			// Token: 0x04000FDF RID: 4063
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000FE0 RID: 4064
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000FE1 RID: 4065
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000FE2 RID: 4066
			private static readonly IntPtr NativeFieldInfoPtr_positionToLookAt;

			// Token: 0x04000FE3 RID: 4067
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000FE4 RID: 4068
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FE5 RID: 4069
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000FE6 RID: 4070
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000FE7 RID: 4071
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FE8 RID: 4072
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200023A RID: 570
		[ObfuscatedName("lotus.EnvironmentCameraManager+<TransitionTo>d__59")]
		public sealed class _TransitionTo_d__59 : global::Il2CppSystem.Object
		{
			// Token: 0x06001A4F RID: 6735 RVA: 0x00062660 File Offset: 0x00060860
			// Note: this type is marked as 'beforefieldinit'.
			static _TransitionTo_d__59()
			{
				Il2CppClassPointerStore<EnvironmentCameraManager._TransitionTo_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "<TransitionTo>d__59");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionTo_d__59>.NativeClassPtr);
				EnvironmentCameraManager._TransitionTo_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionTo_d__59>.NativeClassPtr, "<>1__state");
				EnvironmentCameraManager._TransitionTo_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionTo_d__59>.NativeClassPtr, "<>2__current");
				EnvironmentCameraManager._TransitionTo_d__59.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionTo_d__59>.NativeClassPtr, "<>4__this");
				EnvironmentCameraManager._TransitionTo_d__59.NativeFieldInfoPtr_newPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionTo_d__59>.NativeClassPtr, "newPos");
				EnvironmentCameraManager._TransitionTo_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionTo_d__59>.NativeClassPtr, 100664993);
				EnvironmentCameraManager._TransitionTo_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionTo_d__59>.NativeClassPtr, 100664994);
				EnvironmentCameraManager._TransitionTo_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionTo_d__59>.NativeClassPtr, 100664995);
				EnvironmentCameraManager._TransitionTo_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionTo_d__59>.NativeClassPtr, 100664996);
				EnvironmentCameraManager._TransitionTo_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionTo_d__59>.NativeClassPtr, 100664997);
				EnvironmentCameraManager._TransitionTo_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionTo_d__59>.NativeClassPtr, 100664998);
			}

			// Token: 0x06001A50 RID: 6736 RVA: 0x00062754 File Offset: 0x00060954
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TransitionTo_d__59(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionTo_d__59>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionTo_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A51 RID: 6737 RVA: 0x0006279C File Offset: 0x0006099C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionTo_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A52 RID: 6738 RVA: 0x000627D0 File Offset: 0x000609D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993582, XrefRangeEnd = 993591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionTo_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007B4 RID: 1972
			// (get) Token: 0x06001A53 RID: 6739 RVA: 0x0006280C File Offset: 0x00060A0C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionTo_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A54 RID: 6740 RVA: 0x0006284C File Offset: 0x00060A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993591, XrefRangeEnd = 993596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionTo_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007B5 RID: 1973
			// (get) Token: 0x06001A55 RID: 6741 RVA: 0x00062880 File Offset: 0x00060A80
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionTo_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A56 RID: 6742 RVA: 0x0000E55A File Offset: 0x0000C75A
			public _TransitionTo_d__59(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007B0 RID: 1968
			// (get) Token: 0x06001A57 RID: 6743 RVA: 0x000628C0 File Offset: 0x00060AC0
			// (set) Token: 0x06001A58 RID: 6744 RVA: 0x0000E563 File Offset: 0x0000C763
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionTo_d__59.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionTo_d__59.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007B1 RID: 1969
			// (get) Token: 0x06001A59 RID: 6745 RVA: 0x000628E8 File Offset: 0x00060AE8
			// (set) Token: 0x06001A5A RID: 6746 RVA: 0x0000E57E File Offset: 0x0000C77E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionTo_d__59.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionTo_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B2 RID: 1970
			// (get) Token: 0x06001A5B RID: 6747 RVA: 0x00062918 File Offset: 0x00060B18
			// (set) Token: 0x06001A5C RID: 6748 RVA: 0x0000E59D File Offset: 0x0000C79D
			public unsafe EnvironmentCameraManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionTo_d__59.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentCameraManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionTo_d__59.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B3 RID: 1971
			// (get) Token: 0x06001A5D RID: 6749 RVA: 0x00062948 File Offset: 0x00060B48
			// (set) Token: 0x06001A5E RID: 6750 RVA: 0x0000E5BC File Offset: 0x0000C7BC
			public unsafe EnvironmentCameraPosition newPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionTo_d__59.NativeFieldInfoPtr_newPos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentCameraPosition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionTo_d__59.NativeFieldInfoPtr_newPos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FE9 RID: 4073
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000FEA RID: 4074
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000FEB RID: 4075
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000FEC RID: 4076
			private static readonly IntPtr NativeFieldInfoPtr_newPos;

			// Token: 0x04000FED RID: 4077
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000FEE RID: 4078
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FEF RID: 4079
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000FF0 RID: 4080
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000FF1 RID: 4081
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FF2 RID: 4082
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200023B RID: 571
		[ObfuscatedName("lotus.EnvironmentCameraManager+<TransitionToEnvrionmentAt>d__60")]
		public sealed class _TransitionToEnvrionmentAt_d__60 : global::Il2CppSystem.Object
		{
			// Token: 0x06001A5F RID: 6751 RVA: 0x00062978 File Offset: 0x00060B78
			// Note: this type is marked as 'beforefieldinit'.
			static _TransitionToEnvrionmentAt_d__60()
			{
				Il2CppClassPointerStore<EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "<TransitionToEnvrionmentAt>d__60");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60>.NativeClassPtr);
				EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60>.NativeClassPtr, "<>1__state");
				EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60>.NativeClassPtr, "<>2__current");
				EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60>.NativeClassPtr, "<>4__this");
				EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeFieldInfoPtr_destinationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60>.NativeClassPtr, "destinationID");
				EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60>.NativeClassPtr, 100664999);
				EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60>.NativeClassPtr, 100665000);
				EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60>.NativeClassPtr, 100665001);
				EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60>.NativeClassPtr, 100665002);
				EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60>.NativeClassPtr, 100665003);
				EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60>.NativeClassPtr, 100665004);
			}

			// Token: 0x06001A60 RID: 6752 RVA: 0x00062A6C File Offset: 0x00060C6C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TransitionToEnvrionmentAt_d__60(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A61 RID: 6753 RVA: 0x00062AB4 File Offset: 0x00060CB4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A62 RID: 6754 RVA: 0x00062AE8 File Offset: 0x00060CE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993596, XrefRangeEnd = 993608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007BA RID: 1978
			// (get) Token: 0x06001A63 RID: 6755 RVA: 0x00062B24 File Offset: 0x00060D24
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A64 RID: 6756 RVA: 0x00062B64 File Offset: 0x00060D64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993608, XrefRangeEnd = 993613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007BB RID: 1979
			// (get) Token: 0x06001A65 RID: 6757 RVA: 0x00062B98 File Offset: 0x00060D98
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A66 RID: 6758 RVA: 0x0000E5DB File Offset: 0x0000C7DB
			public _TransitionToEnvrionmentAt_d__60(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007B6 RID: 1974
			// (get) Token: 0x06001A67 RID: 6759 RVA: 0x00062BD8 File Offset: 0x00060DD8
			// (set) Token: 0x06001A68 RID: 6760 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007B7 RID: 1975
			// (get) Token: 0x06001A69 RID: 6761 RVA: 0x00062C00 File Offset: 0x00060E00
			// (set) Token: 0x06001A6A RID: 6762 RVA: 0x0000E5FF File Offset: 0x0000C7FF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B8 RID: 1976
			// (get) Token: 0x06001A6B RID: 6763 RVA: 0x00062C30 File Offset: 0x00060E30
			// (set) Token: 0x06001A6C RID: 6764 RVA: 0x0000E61E File Offset: 0x0000C81E
			public unsafe EnvironmentCameraManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentCameraManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B9 RID: 1977
			// (get) Token: 0x06001A6D RID: 6765 RVA: 0x00062C60 File Offset: 0x00060E60
			// (set) Token: 0x06001A6E RID: 6766 RVA: 0x0000E63D File Offset: 0x0000C83D
			public unsafe string destinationID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeFieldInfoPtr_destinationID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._TransitionToEnvrionmentAt_d__60.NativeFieldInfoPtr_destinationID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000FF3 RID: 4083
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000FF4 RID: 4084
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000FF5 RID: 4085
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000FF6 RID: 4086
			private static readonly IntPtr NativeFieldInfoPtr_destinationID;

			// Token: 0x04000FF7 RID: 4087
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000FF8 RID: 4088
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FF9 RID: 4089
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000FFA RID: 4090
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000FFB RID: 4091
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FFC RID: 4092
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200023C RID: 572
		[ObfuscatedName("lotus.EnvironmentCameraManager+<doTransition>d__65")]
		public sealed class _doTransition_d__65 : global::Il2CppSystem.Object
		{
			// Token: 0x06001A6F RID: 6767 RVA: 0x00062C88 File Offset: 0x00060E88
			// Note: this type is marked as 'beforefieldinit'.
			static _doTransition_d__65()
			{
				Il2CppClassPointerStore<EnvironmentCameraManager._doTransition_d__65>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "<doTransition>d__65");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentCameraManager._doTransition_d__65>.NativeClassPtr);
				EnvironmentCameraManager._doTransition_d__65.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._doTransition_d__65>.NativeClassPtr, "<>1__state");
				EnvironmentCameraManager._doTransition_d__65.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._doTransition_d__65>.NativeClassPtr, "<>2__current");
				EnvironmentCameraManager._doTransition_d__65.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._doTransition_d__65>.NativeClassPtr, "<>4__this");
				EnvironmentCameraManager._doTransition_d__65.NativeFieldInfoPtr_newPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._doTransition_d__65>.NativeClassPtr, "newPos");
				EnvironmentCameraManager._doTransition_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._doTransition_d__65>.NativeClassPtr, 100665005);
				EnvironmentCameraManager._doTransition_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._doTransition_d__65>.NativeClassPtr, 100665006);
				EnvironmentCameraManager._doTransition_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._doTransition_d__65>.NativeClassPtr, 100665007);
				EnvironmentCameraManager._doTransition_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._doTransition_d__65>.NativeClassPtr, 100665008);
				EnvironmentCameraManager._doTransition_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._doTransition_d__65>.NativeClassPtr, 100665009);
				EnvironmentCameraManager._doTransition_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._doTransition_d__65>.NativeClassPtr, 100665010);
			}

			// Token: 0x06001A70 RID: 6768 RVA: 0x00062D7C File Offset: 0x00060F7C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _doTransition_d__65(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentCameraManager._doTransition_d__65>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._doTransition_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A71 RID: 6769 RVA: 0x00062DC4 File Offset: 0x00060FC4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._doTransition_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A72 RID: 6770 RVA: 0x00062DF8 File Offset: 0x00060FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993613, XrefRangeEnd = 993631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._doTransition_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007C0 RID: 1984
			// (get) Token: 0x06001A73 RID: 6771 RVA: 0x00062E34 File Offset: 0x00061034
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._doTransition_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A74 RID: 6772 RVA: 0x00062E74 File Offset: 0x00061074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993631, XrefRangeEnd = 993636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._doTransition_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007C1 RID: 1985
			// (get) Token: 0x06001A75 RID: 6773 RVA: 0x00062EA8 File Offset: 0x000610A8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._doTransition_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A76 RID: 6774 RVA: 0x0000E65C File Offset: 0x0000C85C
			public _doTransition_d__65(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007BC RID: 1980
			// (get) Token: 0x06001A77 RID: 6775 RVA: 0x00062EE8 File Offset: 0x000610E8
			// (set) Token: 0x06001A78 RID: 6776 RVA: 0x0000E665 File Offset: 0x0000C865
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._doTransition_d__65.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._doTransition_d__65.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007BD RID: 1981
			// (get) Token: 0x06001A79 RID: 6777 RVA: 0x00062F10 File Offset: 0x00061110
			// (set) Token: 0x06001A7A RID: 6778 RVA: 0x0000E680 File Offset: 0x0000C880
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._doTransition_d__65.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._doTransition_d__65.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007BE RID: 1982
			// (get) Token: 0x06001A7B RID: 6779 RVA: 0x00062F40 File Offset: 0x00061140
			// (set) Token: 0x06001A7C RID: 6780 RVA: 0x0000E69F File Offset: 0x0000C89F
			public unsafe EnvironmentCameraManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._doTransition_d__65.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentCameraManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._doTransition_d__65.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007BF RID: 1983
			// (get) Token: 0x06001A7D RID: 6781 RVA: 0x00062F70 File Offset: 0x00061170
			// (set) Token: 0x06001A7E RID: 6782 RVA: 0x0000E6BE File Offset: 0x0000C8BE
			public unsafe EnvironmentCameraPosition newPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._doTransition_d__65.NativeFieldInfoPtr_newPos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentCameraPosition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._doTransition_d__65.NativeFieldInfoPtr_newPos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FFD RID: 4093
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000FFE RID: 4094
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000FFF RID: 4095
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001000 RID: 4096
			private static readonly IntPtr NativeFieldInfoPtr_newPos;

			// Token: 0x04001001 RID: 4097
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001002 RID: 4098
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001003 RID: 4099
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001004 RID: 4100
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001005 RID: 4101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001006 RID: 4102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200023D RID: 573
		[ObfuscatedName("lotus.EnvironmentCameraManager+<transitionCamera>d__67")]
		public sealed class _transitionCamera_d__67 : global::Il2CppSystem.Object
		{
			// Token: 0x06001A7F RID: 6783 RVA: 0x00062FA0 File Offset: 0x000611A0
			// Note: this type is marked as 'beforefieldinit'.
			static _transitionCamera_d__67()
			{
				Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "<transitionCamera>d__67");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr);
				EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr, "<>1__state");
				EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr, "<>2__current");
				EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr, "<>4__this");
				EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr__lookTo_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr, "<lookTo>5__2");
				EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr__finalCameraPosition_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr, "<finalCameraPosition>5__3");
				EnvironmentCameraManager._transitionCamera_d__67.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr, 100665011);
				EnvironmentCameraManager._transitionCamera_d__67.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr, 100665012);
				EnvironmentCameraManager._transitionCamera_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr, 100665013);
				EnvironmentCameraManager._transitionCamera_d__67.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr, 100665014);
				EnvironmentCameraManager._transitionCamera_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr, 100665015);
				EnvironmentCameraManager._transitionCamera_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr, 100665016);
			}

			// Token: 0x06001A80 RID: 6784 RVA: 0x000630A8 File Offset: 0x000612A8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _transitionCamera_d__67(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentCameraManager._transitionCamera_d__67>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._transitionCamera_d__67.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A81 RID: 6785 RVA: 0x000630F0 File Offset: 0x000612F0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._transitionCamera_d__67.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A82 RID: 6786 RVA: 0x00063124 File Offset: 0x00061324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993636, XrefRangeEnd = 993718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._transitionCamera_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007C7 RID: 1991
			// (get) Token: 0x06001A83 RID: 6787 RVA: 0x00063160 File Offset: 0x00061360
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._transitionCamera_d__67.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A84 RID: 6788 RVA: 0x000631A0 File Offset: 0x000613A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993718, XrefRangeEnd = 993723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._transitionCamera_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007C8 RID: 1992
			// (get) Token: 0x06001A85 RID: 6789 RVA: 0x000631D4 File Offset: 0x000613D4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._transitionCamera_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A86 RID: 6790 RVA: 0x0000E6DD File Offset: 0x0000C8DD
			public _transitionCamera_d__67(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007C2 RID: 1986
			// (get) Token: 0x06001A87 RID: 6791 RVA: 0x00063214 File Offset: 0x00061414
			// (set) Token: 0x06001A88 RID: 6792 RVA: 0x0000E6E6 File Offset: 0x0000C8E6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007C3 RID: 1987
			// (get) Token: 0x06001A89 RID: 6793 RVA: 0x0006323C File Offset: 0x0006143C
			// (set) Token: 0x06001A8A RID: 6794 RVA: 0x0000E701 File Offset: 0x0000C901
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C4 RID: 1988
			// (get) Token: 0x06001A8B RID: 6795 RVA: 0x0006326C File Offset: 0x0006146C
			// (set) Token: 0x06001A8C RID: 6796 RVA: 0x0000E720 File Offset: 0x0000C920
			public unsafe EnvironmentCameraManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentCameraManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C5 RID: 1989
			// (get) Token: 0x06001A8D RID: 6797 RVA: 0x0006329C File Offset: 0x0006149C
			// (set) Token: 0x06001A8E RID: 6798 RVA: 0x0000E73F File Offset: 0x0000C93F
			public unsafe Vector3 _lookTo_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr__lookTo_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr__lookTo_5__2)) = value;
				}
			}

			// Token: 0x170007C6 RID: 1990
			// (get) Token: 0x06001A8F RID: 6799 RVA: 0x000632C4 File Offset: 0x000614C4
			// (set) Token: 0x06001A90 RID: 6800 RVA: 0x0000E75A File Offset: 0x0000C95A
			public unsafe Vector3 _finalCameraPosition_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr__finalCameraPosition_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionCamera_d__67.NativeFieldInfoPtr__finalCameraPosition_5__3)) = value;
				}
			}

			// Token: 0x04001007 RID: 4103
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001008 RID: 4104
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001009 RID: 4105
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400100A RID: 4106
			private static readonly IntPtr NativeFieldInfoPtr__lookTo_5__2;

			// Token: 0x0400100B RID: 4107
			private static readonly IntPtr NativeFieldInfoPtr__finalCameraPosition_5__3;

			// Token: 0x0400100C RID: 4108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400100D RID: 4109
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400100E RID: 4110
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400100F RID: 4111
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001010 RID: 4112
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001011 RID: 4113
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200023E RID: 574
		[ObfuscatedName("lotus.EnvironmentCameraManager+<transitionToSavedLocation>d__66")]
		public sealed class _transitionToSavedLocation_d__66 : global::Il2CppSystem.Object
		{
			// Token: 0x06001A91 RID: 6801 RVA: 0x000632EC File Offset: 0x000614EC
			// Note: this type is marked as 'beforefieldinit'.
			static _transitionToSavedLocation_d__66()
			{
				Il2CppClassPointerStore<EnvironmentCameraManager._transitionToSavedLocation_d__66>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnvironmentCameraManager>.NativeClassPtr, "<transitionToSavedLocation>d__66");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentCameraManager._transitionToSavedLocation_d__66>.NativeClassPtr);
				EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._transitionToSavedLocation_d__66>.NativeClassPtr, "<>1__state");
				EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._transitionToSavedLocation_d__66>.NativeClassPtr, "<>2__current");
				EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._transitionToSavedLocation_d__66>.NativeClassPtr, "<>4__this");
				EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeFieldInfoPtr_positionTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentCameraManager._transitionToSavedLocation_d__66>.NativeClassPtr, "positionTag");
				EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._transitionToSavedLocation_d__66>.NativeClassPtr, 100665017);
				EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._transitionToSavedLocation_d__66>.NativeClassPtr, 100665018);
				EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._transitionToSavedLocation_d__66>.NativeClassPtr, 100665019);
				EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._transitionToSavedLocation_d__66>.NativeClassPtr, 100665020);
				EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._transitionToSavedLocation_d__66>.NativeClassPtr, 100665021);
				EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentCameraManager._transitionToSavedLocation_d__66>.NativeClassPtr, 100665022);
			}

			// Token: 0x06001A92 RID: 6802 RVA: 0x000633E0 File Offset: 0x000615E0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _transitionToSavedLocation_d__66(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentCameraManager._transitionToSavedLocation_d__66>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A93 RID: 6803 RVA: 0x00063428 File Offset: 0x00061628
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A94 RID: 6804 RVA: 0x0006345C File Offset: 0x0006165C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993723, XrefRangeEnd = 993747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007CD RID: 1997
			// (get) Token: 0x06001A95 RID: 6805 RVA: 0x00063498 File Offset: 0x00061698
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A96 RID: 6806 RVA: 0x000634D8 File Offset: 0x000616D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993747, XrefRangeEnd = 993752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007CE RID: 1998
			// (get) Token: 0x06001A97 RID: 6807 RVA: 0x0006350C File Offset: 0x0006170C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A98 RID: 6808 RVA: 0x0000E775 File Offset: 0x0000C975
			public _transitionToSavedLocation_d__66(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007C9 RID: 1993
			// (get) Token: 0x06001A99 RID: 6809 RVA: 0x0006354C File Offset: 0x0006174C
			// (set) Token: 0x06001A9A RID: 6810 RVA: 0x0000E77E File Offset: 0x0000C97E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007CA RID: 1994
			// (get) Token: 0x06001A9B RID: 6811 RVA: 0x00063574 File Offset: 0x00061774
			// (set) Token: 0x06001A9C RID: 6812 RVA: 0x0000E799 File Offset: 0x0000C999
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CB RID: 1995
			// (get) Token: 0x06001A9D RID: 6813 RVA: 0x000635A4 File Offset: 0x000617A4
			// (set) Token: 0x06001A9E RID: 6814 RVA: 0x0000E7B8 File Offset: 0x0000C9B8
			public unsafe EnvironmentCameraManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvironmentCameraManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CC RID: 1996
			// (get) Token: 0x06001A9F RID: 6815 RVA: 0x000635D4 File Offset: 0x000617D4
			// (set) Token: 0x06001AA0 RID: 6816 RVA: 0x0000E7D7 File Offset: 0x0000C9D7
			public unsafe string positionTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeFieldInfoPtr_positionTag);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentCameraManager._transitionToSavedLocation_d__66.NativeFieldInfoPtr_positionTag), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001012 RID: 4114
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001013 RID: 4115
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001014 RID: 4116
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001015 RID: 4117
			private static readonly IntPtr NativeFieldInfoPtr_positionTag;

			// Token: 0x04001016 RID: 4118
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001017 RID: 4119
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001018 RID: 4120
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001019 RID: 4121
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400101A RID: 4122
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400101B RID: 4123
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
