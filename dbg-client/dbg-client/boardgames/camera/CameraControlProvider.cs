using System;
using boardgames.input;
using boardgames.match.behaviours;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace boardgames.camera
{
	// Token: 0x0200029B RID: 667
	public class CameraControlProvider : MonoBehaviour
	{
		// Token: 0x06001F55 RID: 8021 RVA: 0x000860CC File Offset: 0x000842CC
		// Note: this type is marked as 'beforefieldinit'.
		static CameraControlProvider()
		{
			Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.camera", "CameraControlProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr);
			CameraControlProvider.NativeFieldInfoPtr_targetCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "targetCamera");
			CameraControlProvider.NativeFieldInfoPtr_minCameraAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "minCameraAngle");
			CameraControlProvider.NativeFieldInfoPtr_maxCameraAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "maxCameraAngle");
			CameraControlProvider.NativeFieldInfoPtr_zoomSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "zoomSpeed");
			CameraControlProvider.NativeFieldInfoPtr_pinchZoomAdjust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "pinchZoomAdjust");
			CameraControlProvider.NativeFieldInfoPtr_zoomSmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "zoomSmoothTime");
			CameraControlProvider.NativeFieldInfoPtr_disableManualZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "disableManualZoom");
			CameraControlProvider.NativeFieldInfoPtr_keyZoomIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "keyZoomIn");
			CameraControlProvider.NativeFieldInfoPtr_keyZoomOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "keyZoomOut");
			CameraControlProvider.NativeFieldInfoPtr_autoMoveDelayAfterInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "autoMoveDelayAfterInput");
			CameraControlProvider.NativeFieldInfoPtr_timeUntilAutoMoveReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "timeUntilAutoMoveReady");
			CameraControlProvider.NativeFieldInfoPtr_cameraBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "cameraBounds");
			CameraControlProvider.NativeFieldInfoPtr_shrinkBoundsByZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "shrinkBoundsByZoom");
			CameraControlProvider.NativeFieldInfoPtr_shrinkFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "shrinkFactor");
			CameraControlProvider.NativeFieldInfoPtr_centerZoomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "centerZoomOffset");
			CameraControlProvider.NativeFieldInfoPtr_forwardVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "forwardVector");
			CameraControlProvider.NativeFieldInfoPtr_lockedYAngleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "lockedYAngleOffset");
			CameraControlProvider.NativeFieldInfoPtr_lockedZAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "lockedZAngle");
			CameraControlProvider.NativeFieldInfoPtr_translateScreenDeltaDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "translateScreenDeltaDelay");
			CameraControlProvider.NativeFieldInfoPtr_timeUntilEnableTranslateScreenDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "timeUntilEnableTranslateScreenDelta");
			CameraControlProvider.NativeFieldInfoPtr_scrollDisabler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "scrollDisabler");
			CameraControlProvider.NativeFieldInfoPtr_cachedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "cachedTransform");
			CameraControlProvider.NativeFieldInfoPtr_worldPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "worldPlane");
			CameraControlProvider.NativeFieldInfoPtr_zoomPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "zoomPercent");
			CameraControlProvider.NativeFieldInfoPtr_targetZoomPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "targetZoomPercent");
			CameraControlProvider.NativeFieldInfoPtr_zoomVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "zoomVelocity");
			CameraControlProvider.NativeFieldInfoPtr_currentAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "currentAngle");
			CameraControlProvider.NativeFieldInfoPtr_locationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "locationManager");
			CameraControlProvider.NativeFieldInfoPtr_activeTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "activeTransition");
			CameraControlProvider.NativeFieldInfoPtr_matchHub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "matchHub");
			CameraControlProvider.NativeFieldInfoPtr__InStrategicView_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "<InStrategicView>k__BackingField");
			CameraControlProvider.NativeFieldInfoPtr_lockedYAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "lockedYAngle");
			CameraControlProvider.NativeMethodInfoPtr_get_AutoCameraMovementAllowed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668538);
			CameraControlProvider.NativeMethodInfoPtr_get_disableTranslateScreenDelta_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668539);
			CameraControlProvider.NativeMethodInfoPtr_get_CurrentPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668540);
			CameraControlProvider.NativeMethodInfoPtr_get_ZoomPercent_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668541);
			CameraControlProvider.NativeMethodInfoPtr_get_InStrategicView_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668542);
			CameraControlProvider.NativeMethodInfoPtr_set_InStrategicView_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668543);
			CameraControlProvider.NativeMethodInfoPtr_get_PlayerModifiedZoom_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668544);
			CameraControlProvider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668545);
			CameraControlProvider.NativeMethodInfoPtr_TranslateScreenDelta_Public_Virtual_Final_New_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668546);
			CameraControlProvider.NativeMethodInfoPtr_RecalculateZoomVars_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668547);
			CameraControlProvider.NativeMethodInfoPtr_RecalculateZoomVars_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668548);
			CameraControlProvider.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668549);
			CameraControlProvider.NativeMethodInfoPtr_waitAndEnterStrategicView_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668550);
			CameraControlProvider.NativeMethodInfoPtr_enterStrategicView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668551);
			CameraControlProvider.NativeMethodInfoPtr_exitStrategicView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668552);
			CameraControlProvider.NativeMethodInfoPtr_snapVectorToBounds_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668553);
			CameraControlProvider.NativeMethodInfoPtr_LessStrictApproximately_Private_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668554);
			CameraControlProvider.NativeMethodInfoPtr_SetCameraBounds_Public_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668555);
			CameraControlProvider.NativeMethodInfoPtr_Event_ZoomKeyPressed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668556);
			CameraControlProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, 100668557);
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x0008650C File Offset: 0x0008470C
		public unsafe bool AutoCameraMovementAllowed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_get_AutoCameraMovementAllowed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00086548 File Offset: 0x00084748
		public unsafe bool disableTranslateScreenDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_get_disableTranslateScreenDelta_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001F58 RID: 8024 RVA: 0x00086584 File Offset: 0x00084784
		public unsafe virtual Vector3 CurrentPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541181, XrefRangeEnd = 541182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_get_CurrentPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x000865C0 File Offset: 0x000847C0
		public unsafe virtual float ZoomPercent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_get_ZoomPercent_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x000865FC File Offset: 0x000847FC
		// (set) Token: 0x06001F5B RID: 8027 RVA: 0x00086638 File Offset: 0x00084838
		public unsafe bool InStrategicView
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_get_InStrategicView_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_set_InStrategicView_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001F5C RID: 8028 RVA: 0x00086678 File Offset: 0x00084878
		public unsafe bool PlayerModifiedZoom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_get_PlayerModifiedZoom_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x000866B4 File Offset: 0x000848B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541182, XrefRangeEnd = 541220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x000866E8 File Offset: 0x000848E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541220, XrefRangeEnd = 541236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TranslateScreenDelta(Vector3 startPosition, Vector3 endPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_TranslateScreenDelta_Public_Virtual_Final_New_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x00086734 File Offset: 0x00084934
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 541239, RefRangeEnd = 541242, XrefRangeStart = 541236, XrefRangeEnd = 541239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateZoomVars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_RecalculateZoomVars_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x00086768 File Offset: 0x00084968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 541243, RefRangeEnd = 541244, XrefRangeStart = 541242, XrefRangeEnd = 541243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateZoomVars(Vector3 forPosition, Quaternion forRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_RecalculateZoomVars_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x000867B4 File Offset: 0x000849B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541244, XrefRangeEnd = 541333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x000867E8 File Offset: 0x000849E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 541338, RefRangeEnd = 541340, XrefRangeStart = 541333, XrefRangeEnd = 541338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator waitAndEnterStrategicView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_waitAndEnterStrategicView_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00086828 File Offset: 0x00084A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541340, XrefRangeEnd = 541347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void enterStrategicView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_enterStrategicView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x0008685C File Offset: 0x00084A5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 541353, RefRangeEnd = 541355, XrefRangeStart = 541347, XrefRangeEnd = 541353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void exitStrategicView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_exitStrategicView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00086890 File Offset: 0x00084A90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 541358, RefRangeEnd = 541361, XrefRangeStart = 541355, XrefRangeEnd = 541358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 snapVectorToBounds(Vector3 camVector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref camVector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_snapVectorToBounds_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x000868DC File Offset: 0x00084ADC
		[CallerCount(0)]
		public unsafe bool LessStrictApproximately(float a, float b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_LessStrictApproximately_Private_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00086934 File Offset: 0x00084B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541361, XrefRangeEnd = 541362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraBounds(Bounds bounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bounds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_SetCameraBounds_Public_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x00086974 File Offset: 0x00084B74
		[CallerCount(0)]
		public unsafe void Event_ZoomKeyPressed(int direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr_Event_ZoomKeyPressed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x000869B4 File Offset: 0x00084BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541362, XrefRangeEnd = 541365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraControlProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x0001078B File Offset: 0x0000E98B
		public CameraControlProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x000869F0 File Offset: 0x00084BF0
		// (set) Token: 0x06001F6C RID: 8044 RVA: 0x00010794 File Offset: 0x0000E994
		public unsafe Camera targetCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_targetCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_targetCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x00086A20 File Offset: 0x00084C20
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x000107B3 File Offset: 0x0000E9B3
		public unsafe float minCameraAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_minCameraAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_minCameraAngle)) = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x00086A48 File Offset: 0x00084C48
		// (set) Token: 0x06001F70 RID: 8048 RVA: 0x000107CE File Offset: 0x0000E9CE
		public unsafe float maxCameraAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_maxCameraAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_maxCameraAngle)) = value;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x00086A70 File Offset: 0x00084C70
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x000107E9 File Offset: 0x0000E9E9
		public unsafe float zoomSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_zoomSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_zoomSpeed)) = value;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x00086A98 File Offset: 0x00084C98
		// (set) Token: 0x06001F74 RID: 8052 RVA: 0x00010804 File Offset: 0x0000EA04
		public unsafe float pinchZoomAdjust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_pinchZoomAdjust);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_pinchZoomAdjust)) = value;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x00086AC0 File Offset: 0x00084CC0
		// (set) Token: 0x06001F76 RID: 8054 RVA: 0x0001081F File Offset: 0x0000EA1F
		public unsafe float zoomSmoothTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_zoomSmoothTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_zoomSmoothTime)) = value;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x00086AE8 File Offset: 0x00084CE8
		// (set) Token: 0x06001F78 RID: 8056 RVA: 0x0001083A File Offset: 0x0000EA3A
		public unsafe bool disableManualZoom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_disableManualZoom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_disableManualZoom)) = value;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x00086B10 File Offset: 0x00084D10
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x00010855 File Offset: 0x0000EA55
		public unsafe bool keyZoomIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_keyZoomIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_keyZoomIn)) = value;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x00086B38 File Offset: 0x00084D38
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x00010870 File Offset: 0x0000EA70
		public unsafe bool keyZoomOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_keyZoomOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_keyZoomOut)) = value;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x00086B60 File Offset: 0x00084D60
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x0001088B File Offset: 0x0000EA8B
		public unsafe float autoMoveDelayAfterInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_autoMoveDelayAfterInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_autoMoveDelayAfterInput)) = value;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x00086B88 File Offset: 0x00084D88
		// (set) Token: 0x06001F80 RID: 8064 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public unsafe float timeUntilAutoMoveReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_timeUntilAutoMoveReady);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_timeUntilAutoMoveReady)) = value;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x00086BB0 File Offset: 0x00084DB0
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x000108C1 File Offset: 0x0000EAC1
		public unsafe Bounds cameraBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_cameraBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_cameraBounds)) = value;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x00086BD8 File Offset: 0x00084DD8
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x000108DC File Offset: 0x0000EADC
		public unsafe bool shrinkBoundsByZoom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_shrinkBoundsByZoom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_shrinkBoundsByZoom)) = value;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x00086C00 File Offset: 0x00084E00
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x000108F7 File Offset: 0x0000EAF7
		public unsafe float shrinkFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_shrinkFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_shrinkFactor)) = value;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x00086C28 File Offset: 0x00084E28
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x00010912 File Offset: 0x0000EB12
		public unsafe Vector3 centerZoomOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_centerZoomOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_centerZoomOffset)) = value;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x00086C50 File Offset: 0x00084E50
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x0001092D File Offset: 0x0000EB2D
		public unsafe Vector3 forwardVector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_forwardVector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_forwardVector)) = value;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x00086C78 File Offset: 0x00084E78
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x00010948 File Offset: 0x0000EB48
		public unsafe float lockedYAngleOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_lockedYAngleOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_lockedYAngleOffset)) = value;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x00086CA0 File Offset: 0x00084EA0
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x00010963 File Offset: 0x0000EB63
		public unsafe float lockedZAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_lockedZAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_lockedZAngle)) = value;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x00086CC8 File Offset: 0x00084EC8
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x0001097E File Offset: 0x0000EB7E
		public unsafe float translateScreenDeltaDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_translateScreenDeltaDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_translateScreenDeltaDelay)) = value;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x00086CF0 File Offset: 0x00084EF0
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x00010999 File Offset: 0x0000EB99
		public unsafe float timeUntilEnableTranslateScreenDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_timeUntilEnableTranslateScreenDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_timeUntilEnableTranslateScreenDelta)) = value;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x00086D18 File Offset: 0x00084F18
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x000109B4 File Offset: 0x0000EBB4
		public unsafe Disabler<GameObject> scrollDisabler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_scrollDisabler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Disabler<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_scrollDisabler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x00086D48 File Offset: 0x00084F48
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x000109D3 File Offset: 0x0000EBD3
		public unsafe Transform cachedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_cachedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_cachedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x00086D78 File Offset: 0x00084F78
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x000109F2 File Offset: 0x0000EBF2
		public unsafe Plane worldPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_worldPlane);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_worldPlane)) = value;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x00086DA0 File Offset: 0x00084FA0
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x00010A0D File Offset: 0x0000EC0D
		public unsafe float zoomPercent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_zoomPercent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_zoomPercent)) = value;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x00086DC8 File Offset: 0x00084FC8
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x00010A28 File Offset: 0x0000EC28
		public unsafe float targetZoomPercent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_targetZoomPercent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_targetZoomPercent)) = value;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x00086DF0 File Offset: 0x00084FF0
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x00010A43 File Offset: 0x0000EC43
		public unsafe float zoomVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_zoomVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_zoomVelocity)) = value;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x00086E18 File Offset: 0x00085018
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x00010A5E File Offset: 0x0000EC5E
		public unsafe float currentAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_currentAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_currentAngle)) = value;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x00086E40 File Offset: 0x00085040
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x00010A79 File Offset: 0x0000EC79
		public unsafe CameraLocationManager locationManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_locationManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraLocationManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_locationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x00086E70 File Offset: 0x00085070
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x00010A98 File Offset: 0x0000EC98
		public unsafe Command activeTransition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_activeTransition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_activeTransition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x00086EA0 File Offset: 0x000850A0
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x00010AB7 File Offset: 0x0000ECB7
		public unsafe DBGMatchHub matchHub
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_matchHub);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_matchHub), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x00086ED0 File Offset: 0x000850D0
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x00010AD6 File Offset: 0x0000ECD6
		public unsafe bool _InStrategicView_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr__InStrategicView_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr__InStrategicView_k__BackingField)) = value;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x00086EF8 File Offset: 0x000850F8
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x00010AF1 File Offset: 0x0000ECF1
		public unsafe float lockedYAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_lockedYAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider.NativeFieldInfoPtr_lockedYAngle)) = value;
			}
		}

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeFieldInfoPtr_targetCamera;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeFieldInfoPtr_minCameraAngle;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeFieldInfoPtr_maxCameraAngle;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeFieldInfoPtr_zoomSpeed;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeFieldInfoPtr_pinchZoomAdjust;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeFieldInfoPtr_zoomSmoothTime;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeFieldInfoPtr_disableManualZoom;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeFieldInfoPtr_keyZoomIn;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeFieldInfoPtr_keyZoomOut;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeFieldInfoPtr_autoMoveDelayAfterInput;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilAutoMoveReady;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeFieldInfoPtr_cameraBounds;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeFieldInfoPtr_shrinkBoundsByZoom;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeFieldInfoPtr_shrinkFactor;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeFieldInfoPtr_centerZoomOffset;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeFieldInfoPtr_forwardVector;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeFieldInfoPtr_lockedYAngleOffset;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeFieldInfoPtr_lockedZAngle;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeFieldInfoPtr_translateScreenDeltaDelay;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilEnableTranslateScreenDelta;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeFieldInfoPtr_scrollDisabler;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeFieldInfoPtr_cachedTransform;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeFieldInfoPtr_worldPlane;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeFieldInfoPtr_zoomPercent;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeFieldInfoPtr_targetZoomPercent;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeFieldInfoPtr_zoomVelocity;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeFieldInfoPtr_currentAngle;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeFieldInfoPtr_locationManager;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeFieldInfoPtr_activeTransition;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeFieldInfoPtr_matchHub;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeFieldInfoPtr__InStrategicView_k__BackingField;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeFieldInfoPtr_lockedYAngle;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoCameraMovementAllowed_Public_get_Boolean_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_get_disableTranslateScreenDelta_Private_get_Boolean_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_get_ZoomPercent_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_get_InStrategicView_Public_get_Boolean_0;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr_set_InStrategicView_Private_set_Void_Boolean_0;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerModifiedZoom_Public_get_Boolean_0;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeMethodInfoPtr_TranslateScreenDelta_Public_Virtual_Final_New_Void_Vector3_Vector3_0;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateZoomVars_Public_Void_0;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateZoomVars_Public_Void_Vector3_Quaternion_0;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeMethodInfoPtr_waitAndEnterStrategicView_Private_IEnumerator_0;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr_enterStrategicView_Private_Void_0;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_exitStrategicView_Private_Void_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_snapVectorToBounds_Private_Vector3_Vector3_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_LessStrictApproximately_Private_Boolean_Single_Single_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraBounds_Public_Void_Bounds_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_Event_ZoomKeyPressed_Public_Void_Int32_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000499 RID: 1177
		[ObfuscatedName("boardgames.camera.CameraControlProvider+<waitAndEnterStrategicView>d__50")]
		public sealed class _waitAndEnterStrategicView_d__50 : global::Il2CppSystem.Object
		{
			// Token: 0x060037DC RID: 14300 RVA: 0x000CF618 File Offset: 0x000CD818
			// Note: this type is marked as 'beforefieldinit'.
			static _waitAndEnterStrategicView_d__50()
			{
				Il2CppClassPointerStore<CameraControlProvider._waitAndEnterStrategicView_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraControlProvider>.NativeClassPtr, "<waitAndEnterStrategicView>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraControlProvider._waitAndEnterStrategicView_d__50>.NativeClassPtr);
				CameraControlProvider._waitAndEnterStrategicView_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider._waitAndEnterStrategicView_d__50>.NativeClassPtr, "<>1__state");
				CameraControlProvider._waitAndEnterStrategicView_d__50.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider._waitAndEnterStrategicView_d__50>.NativeClassPtr, "<>2__current");
				CameraControlProvider._waitAndEnterStrategicView_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControlProvider._waitAndEnterStrategicView_d__50>.NativeClassPtr, "<>4__this");
				CameraControlProvider._waitAndEnterStrategicView_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider._waitAndEnterStrategicView_d__50>.NativeClassPtr, 100668558);
				CameraControlProvider._waitAndEnterStrategicView_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider._waitAndEnterStrategicView_d__50>.NativeClassPtr, 100668559);
				CameraControlProvider._waitAndEnterStrategicView_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider._waitAndEnterStrategicView_d__50>.NativeClassPtr, 100668560);
				CameraControlProvider._waitAndEnterStrategicView_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider._waitAndEnterStrategicView_d__50>.NativeClassPtr, 100668561);
				CameraControlProvider._waitAndEnterStrategicView_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider._waitAndEnterStrategicView_d__50>.NativeClassPtr, 100668562);
				CameraControlProvider._waitAndEnterStrategicView_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControlProvider._waitAndEnterStrategicView_d__50>.NativeClassPtr, 100668563);
			}

			// Token: 0x060037DD RID: 14301 RVA: 0x000CF6F8 File Offset: 0x000CD8F8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _waitAndEnterStrategicView_d__50(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraControlProvider._waitAndEnterStrategicView_d__50>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider._waitAndEnterStrategicView_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037DE RID: 14302 RVA: 0x000CF740 File Offset: 0x000CD940
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider._waitAndEnterStrategicView_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037DF RID: 14303 RVA: 0x000CF774 File Offset: 0x000CD974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541175, XrefRangeEnd = 541176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider._waitAndEnterStrategicView_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001081 RID: 4225
			// (get) Token: 0x060037E0 RID: 14304 RVA: 0x000CF7B0 File Offset: 0x000CD9B0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider._waitAndEnterStrategicView_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060037E1 RID: 14305 RVA: 0x000CF7F0 File Offset: 0x000CD9F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541176, XrefRangeEnd = 541181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider._waitAndEnterStrategicView_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001082 RID: 4226
			// (get) Token: 0x060037E2 RID: 14306 RVA: 0x000CF824 File Offset: 0x000CDA24
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraControlProvider._waitAndEnterStrategicView_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060037E3 RID: 14307 RVA: 0x0001CB95 File Offset: 0x0001AD95
			public _waitAndEnterStrategicView_d__50(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700107E RID: 4222
			// (get) Token: 0x060037E4 RID: 14308 RVA: 0x000CF864 File Offset: 0x000CDA64
			// (set) Token: 0x060037E5 RID: 14309 RVA: 0x0001CB9E File Offset: 0x0001AD9E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider._waitAndEnterStrategicView_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider._waitAndEnterStrategicView_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700107F RID: 4223
			// (get) Token: 0x060037E6 RID: 14310 RVA: 0x000CF88C File Offset: 0x000CDA8C
			// (set) Token: 0x060037E7 RID: 14311 RVA: 0x0001CBB9 File Offset: 0x0001ADB9
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider._waitAndEnterStrategicView_d__50.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider._waitAndEnterStrategicView_d__50.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001080 RID: 4224
			// (get) Token: 0x060037E8 RID: 14312 RVA: 0x000CF8BC File Offset: 0x000CDABC
			// (set) Token: 0x060037E9 RID: 14313 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
			public unsafe CameraControlProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider._waitAndEnterStrategicView_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraControlProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraControlProvider._waitAndEnterStrategicView_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400225B RID: 8795
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400225C RID: 8796
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400225D RID: 8797
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400225E RID: 8798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400225F RID: 8799
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002260 RID: 8800
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002261 RID: 8801
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002262 RID: 8802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002263 RID: 8803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
