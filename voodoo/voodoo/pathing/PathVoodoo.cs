using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;
using UnityEngine.Events;

namespace voodoo.pathing
{
	// Token: 0x02000032 RID: 50
	public class PathVoodoo : PathAnimator
	{
		// Token: 0x06000201 RID: 513 RVA: 0x0000F570 File Offset: 0x0000D770
		// Note: this type is marked as 'beforefieldinit'.
		static PathVoodoo()
		{
			Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.pathing", "PathVoodoo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr);
			PathVoodoo.NativeFieldInfoPtr_pathColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "pathColor");
			PathVoodoo.NativeFieldInfoPtr_waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "waypoints");
			PathVoodoo.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "target");
			PathVoodoo.NativeFieldInfoPtr_disableOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "disableOrientation");
			PathVoodoo.NativeFieldInfoPtr_disablePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "disablePosition");
			PathVoodoo.NativeFieldInfoPtr_globalLookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "globalLookAt");
			PathVoodoo.NativeFieldInfoPtr_globalFollowPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "globalFollowPath");
			PathVoodoo.NativeFieldInfoPtr_globalFollowPathBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "globalFollowPathBias");
			PathVoodoo.NativeFieldInfoPtr_updateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "updateMode");
			PathVoodoo.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "loop");
			PathVoodoo.NativeFieldInfoPtr_autoStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "autoStart");
			PathVoodoo.NativeFieldInfoPtr_velocityBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "velocityBias");
			PathVoodoo.NativeFieldInfoPtr_currentPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "currentPos");
			PathVoodoo.NativeFieldInfoPtr_isPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "isPlaying");
			PathVoodoo.NativeFieldInfoPtr_waypointChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "waypointChanged");
			PathVoodoo.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "onComplete");
			PathVoodoo.NativeFieldInfoPtr_presampledPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "presampledPath");
			PathVoodoo.NativeFieldInfoPtr_samplesNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "samplesNum");
			PathVoodoo.NativeFieldInfoPtr__lastPassedWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "_lastPassedWaypoint");
			PathVoodoo.NativeFieldInfoPtr_positionSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "positionSamples");
			PathVoodoo.NativeFieldInfoPtr_rotationSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "rotationSamples");
			PathVoodoo.NativeFieldInfoPtr_velocitySamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "velocitySamples");
			PathVoodoo.NativeFieldInfoPtr_waypointSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "waypointSamples");
			PathVoodoo.NativeFieldInfoPtr_samplesDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "samplesDistances");
			PathVoodoo.NativeFieldInfoPtr_totalDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "totalDistance");
			PathVoodoo.NativeFieldInfoPtr_updateTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "updateTransform");
			PathVoodoo.NativeFieldInfoPtr_isWeighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "isWeighted");
			PathVoodoo.NativeFieldInfoPtr_relativeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "relativeMode");
			PathVoodoo.NativeFieldInfoPtr_scaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "scaleCurve");
			PathVoodoo.NativeFieldInfoPtr_scaleCurveMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "scaleCurveMode");
			PathVoodoo.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "startScale");
			PathVoodoo.NativeFieldInfoPtr_endScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "endScale");
			PathVoodoo.NativeFieldInfoPtr_unblockTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "unblockTime");
			PathVoodoo.NativeFieldInfoPtr__lastVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "_lastVelocity");
			PathVoodoo.NativeFieldInfoPtr_destParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "destParent");
			PathVoodoo.NativeFieldInfoPtr_startLT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "startLT");
			PathVoodoo.NativeFieldInfoPtr_destLT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "destLT");
			PathVoodoo.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "start");
			PathVoodoo.NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "dest");
			PathVoodoo.NativeFieldInfoPtr_unitView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "unitView");
			PathVoodoo.NativeFieldInfoPtr_unitPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "unitPosition");
			PathVoodoo.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663514);
			PathVoodoo.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663515);
			PathVoodoo.NativeMethodInfoPtr_get_Waypoints_Public_get_Il2CppReferenceArray_1_Waypoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663516);
			PathVoodoo.NativeMethodInfoPtr_set_Waypoints_Public_set_Void_Il2CppReferenceArray_1_Waypoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663517);
			PathVoodoo.NativeMethodInfoPtr_get_Target_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663518);
			PathVoodoo.NativeMethodInfoPtr_set_Target_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663519);
			PathVoodoo.NativeMethodInfoPtr_get_DisableOrientation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663520);
			PathVoodoo.NativeMethodInfoPtr_set_DisableOrientation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663521);
			PathVoodoo.NativeMethodInfoPtr_get_DisablePosition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663522);
			PathVoodoo.NativeMethodInfoPtr_set_DisablePosition_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663523);
			PathVoodoo.NativeMethodInfoPtr_get_GlobalLookAt_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663524);
			PathVoodoo.NativeMethodInfoPtr_set_GlobalLookAt_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663525);
			PathVoodoo.NativeMethodInfoPtr_get_GlobalFollowPath_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663526);
			PathVoodoo.NativeMethodInfoPtr_set_GlobalFollowPath_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663527);
			PathVoodoo.NativeMethodInfoPtr_get_GlobalFollowPathBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663528);
			PathVoodoo.NativeMethodInfoPtr_set_GlobalFollowPathBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663529);
			PathVoodoo.NativeMethodInfoPtr_get_UpdateMode_Public_get_UpdateModeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663530);
			PathVoodoo.NativeMethodInfoPtr_set_UpdateMode_Public_set_Void_UpdateModeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663531);
			PathVoodoo.NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663532);
			PathVoodoo.NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663533);
			PathVoodoo.NativeMethodInfoPtr_get_AutoStart_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663534);
			PathVoodoo.NativeMethodInfoPtr_set_AutoStart_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663535);
			PathVoodoo.NativeMethodInfoPtr_get_VelocityBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663536);
			PathVoodoo.NativeMethodInfoPtr_set_VelocityBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663537);
			PathVoodoo.NativeMethodInfoPtr_get_CurrentPos_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663538);
			PathVoodoo.NativeMethodInfoPtr_set_CurrentPos_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663539);
			PathVoodoo.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663540);
			PathVoodoo.NativeMethodInfoPtr_get_WaypointChanged_Public_get_WaypointChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663541);
			PathVoodoo.NativeMethodInfoPtr_set_WaypointChanged_Public_set_Void_WaypointChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663542);
			PathVoodoo.NativeMethodInfoPtr_get_PresampledPath_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663543);
			PathVoodoo.NativeMethodInfoPtr_get_SamplesNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663544);
			PathVoodoo.NativeMethodInfoPtr_get_LastPassedWayponint_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663545);
			PathVoodoo.NativeMethodInfoPtr_get_PositionSamples_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663546);
			PathVoodoo.NativeMethodInfoPtr_get_RotationSamples_Public_get_Il2CppStructArray_1_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663547);
			PathVoodoo.NativeMethodInfoPtr_get_VelocitySamples_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663548);
			PathVoodoo.NativeMethodInfoPtr_get_WaypointSamples_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663549);
			PathVoodoo.NativeMethodInfoPtr_get_SamplesDistances_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663550);
			PathVoodoo.NativeMethodInfoPtr_get_TotalDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663551);
			PathVoodoo.NativeMethodInfoPtr_get_UpdateTransform_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663552);
			PathVoodoo.NativeMethodInfoPtr_set_UpdateTransform_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663553);
			PathVoodoo.NativeMethodInfoPtr_get_IsWeighted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663554);
			PathVoodoo.NativeMethodInfoPtr_set_IsWeighted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663555);
			PathVoodoo.NativeMethodInfoPtr_get_RelativeMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663556);
			PathVoodoo.NativeMethodInfoPtr_set_RelativeMode_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663557);
			PathVoodoo.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663558);
			PathVoodoo.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663559);
			PathVoodoo.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663560);
			PathVoodoo.NativeMethodInfoPtr_DoUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663561);
			PathVoodoo.NativeMethodInfoPtr_Play_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663562);
			PathVoodoo.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663563);
			PathVoodoo.NativeMethodInfoPtr_Rewind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663564);
			PathVoodoo.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663565);
			PathVoodoo.NativeMethodInfoPtr_InitWithContext_Public_Virtual_Void_UnitView_UnitPosition_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663566);
			PathVoodoo.NativeMethodInfoPtr_updateWeights_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663567);
			PathVoodoo.NativeMethodInfoPtr_sampledPositionAndRotationAndVelocityAndWaypointAtPos_Public_Void_Single_byref_Vector3_byref_Quaternion_byref_Single_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663568);
			PathVoodoo.NativeMethodInfoPtr_computeScaleAtPos_Public_Virtual_New_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663569);
			PathVoodoo.NativeMethodInfoPtr_computeRotationAtPos_Public_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663570);
			PathVoodoo.NativeMethodInfoPtr_GetWaypointRotation_Public_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663571);
			PathVoodoo.NativeMethodInfoPtr_computePositionAtPos_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663572);
			PathVoodoo.NativeMethodInfoPtr_computeVelocityAtPos_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663573);
			PathVoodoo.NativeMethodInfoPtr_UpdateTarget_Public_Void_Vector3_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663574);
			PathVoodoo.NativeMethodInfoPtr_UpdateTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663575);
			PathVoodoo.NativeMethodInfoPtr_raiseWaypointUpdatedEvents_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663576);
			PathVoodoo.NativeMethodInfoPtr_GetCurrentWaypoint_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663577);
			PathVoodoo.NativeMethodInfoPtr_GetWaypointFromPos_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663578);
			PathVoodoo.NativeMethodInfoPtr_GetFaceForwardForPos_Public_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663579);
			PathVoodoo.NativeMethodInfoPtr_UpdatePathSamples_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663580);
			PathVoodoo.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663581);
			PathVoodoo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, 100663582);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000FE38 File Offset: 0x0000E038
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000FE6C File Offset: 0x0000E06C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		// (set) Token: 0x06000205 RID: 517 RVA: 0x0000FEE0 File Offset: 0x0000E0E0
		public unsafe Il2CppReferenceArray<Waypoint> Waypoints
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_Waypoints_Public_get_Il2CppReferenceArray_1_Waypoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Waypoint>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107841, XrefRangeEnd = 1107844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_Waypoints_Public_set_Void_Il2CppReferenceArray_1_Waypoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000FF24 File Offset: 0x0000E124
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0000FF64 File Offset: 0x0000E164
		public unsafe Transform Target
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_Target_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_Target_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0000FFE4 File Offset: 0x0000E1E4
		public unsafe bool DisableOrientation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_DisableOrientation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_DisableOrientation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00010024 File Offset: 0x0000E224
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00010060 File Offset: 0x0000E260
		public unsafe bool DisablePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_DisablePosition_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_DisablePosition_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000100A0 File Offset: 0x0000E2A0
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000100E0 File Offset: 0x0000E2E0
		public unsafe Transform GlobalLookAt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_GlobalLookAt_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_GlobalLookAt_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00010124 File Offset: 0x0000E324
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00010160 File Offset: 0x0000E360
		public unsafe bool GlobalFollowPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_GlobalFollowPath_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_GlobalFollowPath_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000101A0 File Offset: 0x0000E3A0
		// (set) Token: 0x06000211 RID: 529 RVA: 0x000101DC File Offset: 0x0000E3DC
		public unsafe float GlobalFollowPathBias
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_GlobalFollowPathBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_GlobalFollowPathBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0001021C File Offset: 0x0000E41C
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00010258 File Offset: 0x0000E458
		public unsafe PathVoodoo.UpdateModeType UpdateMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_UpdateMode_Public_get_UpdateModeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 337738, RefRangeEnd = 337747, XrefRangeStart = 337738, XrefRangeEnd = 337747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_UpdateMode_Public_set_Void_UpdateModeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00010298 File Offset: 0x0000E498
		// (set) Token: 0x06000215 RID: 533 RVA: 0x000102D4 File Offset: 0x0000E4D4
		public unsafe bool Loop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00010314 File Offset: 0x0000E514
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00010350 File Offset: 0x0000E550
		public unsafe bool AutoStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_AutoStart_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_AutoStart_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00010390 File Offset: 0x0000E590
		// (set) Token: 0x06000219 RID: 537 RVA: 0x000103CC File Offset: 0x0000E5CC
		public unsafe float VelocityBias
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_VelocityBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_VelocityBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0001040C File Offset: 0x0000E60C
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00010448 File Offset: 0x0000E648
		public unsafe float CurrentPos
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_CurrentPos_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107844, XrefRangeEnd = 1107845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_CurrentPos_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00010488 File Offset: 0x0000E688
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600021D RID: 541 RVA: 0x000104C4 File Offset: 0x0000E6C4
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00010504 File Offset: 0x0000E704
		public unsafe PathVoodoo.WaypointChangedEvent WaypointChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_WaypointChanged_Public_get_WaypointChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathVoodoo.WaypointChangedEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_WaypointChanged_Public_set_Void_WaypointChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00010548 File Offset: 0x0000E748
		public unsafe bool PresampledPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_PresampledPath_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00010584 File Offset: 0x0000E784
		public unsafe int SamplesNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_SamplesNum_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000221 RID: 545 RVA: 0x000105C0 File Offset: 0x0000E7C0
		public unsafe int LastPassedWayponint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_LastPassedWayponint_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000222 RID: 546 RVA: 0x000105FC File Offset: 0x0000E7FC
		public unsafe Il2CppStructArray<Vector3> PositionSamples
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_PositionSamples_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0001063C File Offset: 0x0000E83C
		public unsafe Il2CppStructArray<Quaternion> RotationSamples
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_RotationSamples_Public_get_Il2CppStructArray_1_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Quaternion>>(intPtr3) : null;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0001067C File Offset: 0x0000E87C
		public unsafe Il2CppStructArray<float> VelocitySamples
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_VelocitySamples_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000106BC File Offset: 0x0000E8BC
		public unsafe Il2CppStructArray<int> WaypointSamples
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_WaypointSamples_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000226 RID: 550 RVA: 0x000106FC File Offset: 0x0000E8FC
		public unsafe Il2CppStructArray<float> SamplesDistances
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_SamplesDistances_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0001073C File Offset: 0x0000E93C
		public unsafe float TotalDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_TotalDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00010778 File Offset: 0x0000E978
		// (set) Token: 0x06000229 RID: 553 RVA: 0x000107B4 File Offset: 0x0000E9B4
		public unsafe bool UpdateTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_UpdateTransform_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_UpdateTransform_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600022A RID: 554 RVA: 0x000107F4 File Offset: 0x0000E9F4
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00010830 File Offset: 0x0000EA30
		public unsafe bool IsWeighted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_IsWeighted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_IsWeighted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00010870 File Offset: 0x0000EA70
		// (set) Token: 0x0600022D RID: 557 RVA: 0x000108AC File Offset: 0x0000EAAC
		public unsafe bool RelativeMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_get_RelativeMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_set_RelativeMode_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000108EC File Offset: 0x0000EAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107845, XrefRangeEnd = 1107850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00010920 File Offset: 0x0000EB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107850, XrefRangeEnd = 1107855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00010954 File Offset: 0x0000EB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107855, XrefRangeEnd = 1107856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00010988 File Offset: 0x0000EB88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1107874, RefRangeEnd = 1107877, XrefRangeStart = 1107856, XrefRangeEnd = 1107874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_DoUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000109BC File Offset: 0x0000EBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107877, XrefRangeEnd = 1107878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodoo.NativeMethodInfoPtr_Play_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000109F8 File Offset: 0x0000EBF8
		[CallerCount(0)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00010A2C File Offset: 0x0000EC2C
		[CallerCount(0)]
		public unsafe void Rewind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_Rewind_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00010A60 File Offset: 0x0000EC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107878, XrefRangeEnd = 1107881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00010A94 File Offset: 0x0000EC94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107928, RefRangeEnd = 1107929, XrefRangeStart = 1107881, XrefRangeEnd = 1107928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitWithContext(UnitView unitView, UnitPosition unitPosition, LocalTransform dlt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unitView);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unitPosition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dlt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodoo.NativeMethodInfoPtr_InitWithContext_Public_Virtual_Void_UnitView_UnitPosition_LocalTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00010B04 File Offset: 0x0000ED04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107929, XrefRangeEnd = 1107971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void updateWeights(bool force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodoo.NativeMethodInfoPtr_updateWeights_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00010B50 File Offset: 0x0000ED50
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1107972, RefRangeEnd = 1107980, XrefRangeStart = 1107971, XrefRangeEnd = 1107972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void sampledPositionAndRotationAndVelocityAndWaypointAtPos(float pos, out Vector3 position, out Quaternion rotation, out float velocity, out int waypoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &waypoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_sampledPositionAndRotationAndVelocityAndWaypointAtPos_Public_Void_Single_byref_Vector3_byref_Quaternion_byref_Single_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00010BC8 File Offset: 0x0000EDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107980, XrefRangeEnd = 1107982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 computeScaleAtPos(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodoo.NativeMethodInfoPtr_computeScaleAtPos_Public_Virtual_New_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00010C1C File Offset: 0x0000EE1C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1107992, RefRangeEnd = 1108001, XrefRangeStart = 1107982, XrefRangeEnd = 1107992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion computeRotationAtPos(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_computeRotationAtPos_Public_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00010C68 File Offset: 0x0000EE68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1108010, RefRangeEnd = 1108014, XrefRangeStart = 1108001, XrefRangeEnd = 1108010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion GetWaypointRotation(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_GetWaypointRotation_Public_Quaternion_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00010CB4 File Offset: 0x0000EEB4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1108017, RefRangeEnd = 1108032, XrefRangeStart = 1108014, XrefRangeEnd = 1108017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 computePositionAtPos(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_computePositionAtPos_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00010D00 File Offset: 0x0000EF00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1108037, RefRangeEnd = 1108041, XrefRangeStart = 1108032, XrefRangeEnd = 1108037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float computeVelocityAtPos(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_computeVelocityAtPos_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00010D4C File Offset: 0x0000EF4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1108061, RefRangeEnd = 1108063, XrefRangeStart = 1108041, XrefRangeEnd = 1108061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTarget(Vector3 position, Vector3 scale, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_UpdateTarget_Public_Void_Vector3_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00010DA8 File Offset: 0x0000EFA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1108087, RefRangeEnd = 1108090, XrefRangeStart = 1108063, XrefRangeEnd = 1108087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_UpdateTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00010DDC File Offset: 0x0000EFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108090, XrefRangeEnd = 1108094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void raiseWaypointUpdatedEvents(int waypoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref waypoint;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_raiseWaypointUpdatedEvents_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00010E1C File Offset: 0x0000F01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108094, XrefRangeEnd = 1108095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCurrentWaypoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_GetCurrentWaypoint_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00010E58 File Offset: 0x0000F058
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1108099, RefRangeEnd = 1108109, XrefRangeStart = 1108095, XrefRangeEnd = 1108099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetWaypointFromPos(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_GetWaypointFromPos_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00010EA4 File Offset: 0x0000F0A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1108125, RefRangeEnd = 1108127, XrefRangeStart = 1108109, XrefRangeEnd = 1108125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion GetFaceForwardForPos(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_GetFaceForwardForPos_Public_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1108164, RefRangeEnd = 1108168, XrefRangeStart = 1108127, XrefRangeEnd = 1108164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePathSamples()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_UpdatePathSamples_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00010F24 File Offset: 0x0000F124
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00010F58 File Offset: 0x0000F158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108168, XrefRangeEnd = 1108179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathVoodoo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00003183 File Offset: 0x00001383
		public PathVoodoo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00010F94 File Offset: 0x0000F194
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0000318C File Offset: 0x0000138C
		public unsafe Color pathColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_pathColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_pathColor)) = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00010FBC File Offset: 0x0000F1BC
		// (set) Token: 0x0600024B RID: 587 RVA: 0x000031A7 File Offset: 0x000013A7
		public unsafe Il2CppReferenceArray<Waypoint> waypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_waypoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Waypoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_waypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00010FEC File Offset: 0x0000F1EC
		// (set) Token: 0x0600024D RID: 589 RVA: 0x000031C6 File Offset: 0x000013C6
		public unsafe Transform target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0001101C File Offset: 0x0000F21C
		// (set) Token: 0x0600024F RID: 591 RVA: 0x000031E5 File Offset: 0x000013E5
		public unsafe bool disableOrientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_disableOrientation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_disableOrientation)) = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00011044 File Offset: 0x0000F244
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00003200 File Offset: 0x00001400
		public unsafe bool disablePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_disablePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_disablePosition)) = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0001106C File Offset: 0x0000F26C
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0000321B File Offset: 0x0000141B
		public unsafe Transform globalLookAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_globalLookAt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_globalLookAt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0001109C File Offset: 0x0000F29C
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0000323A File Offset: 0x0000143A
		public unsafe bool globalFollowPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_globalFollowPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_globalFollowPath)) = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000110C4 File Offset: 0x0000F2C4
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00003255 File Offset: 0x00001455
		public unsafe float globalFollowPathBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_globalFollowPathBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_globalFollowPathBias)) = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000110EC File Offset: 0x0000F2EC
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00003270 File Offset: 0x00001470
		public unsafe PathVoodoo.UpdateModeType updateMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_updateMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_updateMode)) = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00011114 File Offset: 0x0000F314
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0000328B File Offset: 0x0000148B
		public unsafe bool loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_loop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_loop)) = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0001113C File Offset: 0x0000F33C
		// (set) Token: 0x0600025D RID: 605 RVA: 0x000032A6 File Offset: 0x000014A6
		public unsafe bool autoStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_autoStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_autoStart)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00011164 File Offset: 0x0000F364
		// (set) Token: 0x0600025F RID: 607 RVA: 0x000032C1 File Offset: 0x000014C1
		public unsafe float velocityBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_velocityBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_velocityBias)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0001118C File Offset: 0x0000F38C
		// (set) Token: 0x06000261 RID: 609 RVA: 0x000032DC File Offset: 0x000014DC
		public unsafe float currentPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_currentPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_currentPos)) = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000111B4 File Offset: 0x0000F3B4
		// (set) Token: 0x06000263 RID: 611 RVA: 0x000032F7 File Offset: 0x000014F7
		public unsafe bool isPlaying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_isPlaying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_isPlaying)) = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000264 RID: 612 RVA: 0x000111DC File Offset: 0x0000F3DC
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00003312 File Offset: 0x00001512
		public unsafe PathVoodoo.WaypointChangedEvent waypointChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_waypointChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathVoodoo.WaypointChangedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_waypointChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0001120C File Offset: 0x0000F40C
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00003331 File Offset: 0x00001531
		public unsafe UnityEvent onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0001123C File Offset: 0x0000F43C
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00003350 File Offset: 0x00001550
		public unsafe bool presampledPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_presampledPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_presampledPath)) = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00011264 File Offset: 0x0000F464
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0000336B File Offset: 0x0000156B
		public unsafe int samplesNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_samplesNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_samplesNum)) = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0001128C File Offset: 0x0000F48C
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00003386 File Offset: 0x00001586
		public unsafe int _lastPassedWaypoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr__lastPassedWaypoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr__lastPassedWaypoint)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000112B4 File Offset: 0x0000F4B4
		// (set) Token: 0x0600026F RID: 623 RVA: 0x000033A1 File Offset: 0x000015A1
		public unsafe Il2CppStructArray<Vector3> positionSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_positionSamples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_positionSamples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000270 RID: 624 RVA: 0x000112E4 File Offset: 0x0000F4E4
		// (set) Token: 0x06000271 RID: 625 RVA: 0x000033C0 File Offset: 0x000015C0
		public unsafe Il2CppStructArray<Quaternion> rotationSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_rotationSamples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Quaternion>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_rotationSamples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00011314 File Offset: 0x0000F514
		// (set) Token: 0x06000273 RID: 627 RVA: 0x000033DF File Offset: 0x000015DF
		public unsafe Il2CppStructArray<float> velocitySamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_velocitySamples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_velocitySamples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00011344 File Offset: 0x0000F544
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000033FE File Offset: 0x000015FE
		public unsafe Il2CppStructArray<int> waypointSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_waypointSamples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_waypointSamples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00011374 File Offset: 0x0000F574
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0000341D File Offset: 0x0000161D
		public unsafe Il2CppStructArray<float> samplesDistances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_samplesDistances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_samplesDistances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000113A4 File Offset: 0x0000F5A4
		// (set) Token: 0x06000279 RID: 633 RVA: 0x0000343C File Offset: 0x0000163C
		public unsafe float totalDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_totalDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_totalDistance)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600027A RID: 634 RVA: 0x000113CC File Offset: 0x0000F5CC
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00003457 File Offset: 0x00001657
		public unsafe bool updateTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_updateTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_updateTransform)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600027C RID: 636 RVA: 0x000113F4 File Offset: 0x0000F5F4
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00003472 File Offset: 0x00001672
		public unsafe bool isWeighted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_isWeighted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_isWeighted)) = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0001141C File Offset: 0x0000F61C
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0000348D File Offset: 0x0000168D
		public unsafe bool relativeMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_relativeMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_relativeMode)) = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00011444 File Offset: 0x0000F644
		// (set) Token: 0x06000281 RID: 641 RVA: 0x000034A8 File Offset: 0x000016A8
		public unsafe AnimationCurve scaleCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_scaleCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_scaleCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00011474 File Offset: 0x0000F674
		// (set) Token: 0x06000283 RID: 643 RVA: 0x000034C7 File Offset: 0x000016C7
		public unsafe PathVoodoo.ScaleCurveMode scaleCurveMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_scaleCurveMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_scaleCurveMode)) = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0001149C File Offset: 0x0000F69C
		// (set) Token: 0x06000285 RID: 645 RVA: 0x000034E2 File Offset: 0x000016E2
		public unsafe Vector3 startScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_startScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_startScale)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000286 RID: 646 RVA: 0x000114C4 File Offset: 0x0000F6C4
		// (set) Token: 0x06000287 RID: 647 RVA: 0x000034FD File Offset: 0x000016FD
		public unsafe Vector3 endScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_endScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_endScale)) = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000288 RID: 648 RVA: 0x000114EC File Offset: 0x0000F6EC
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00003518 File Offset: 0x00001718
		public unsafe float unblockTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_unblockTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_unblockTime)) = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00011514 File Offset: 0x0000F714
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00003533 File Offset: 0x00001733
		public unsafe float _lastVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr__lastVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr__lastVelocity)) = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0001153C File Offset: 0x0000F73C
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0000354E File Offset: 0x0000174E
		public unsafe Transform destParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_destParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_destParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0001156C File Offset: 0x0000F76C
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000356D File Offset: 0x0000176D
		public unsafe LocalTransform startLT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_startLT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_startLT)) = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00011594 File Offset: 0x0000F794
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00003588 File Offset: 0x00001788
		public unsafe LocalTransform destLT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_destLT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_destLT)) = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000292 RID: 658 RVA: 0x000115BC File Offset: 0x0000F7BC
		// (set) Token: 0x06000293 RID: 659 RVA: 0x000035A3 File Offset: 0x000017A3
		public unsafe GlobalTransform start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_start)) = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000115E4 File Offset: 0x0000F7E4
		// (set) Token: 0x06000295 RID: 661 RVA: 0x000035BE File Offset: 0x000017BE
		public unsafe GlobalTransform dest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_dest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_dest)) = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0001160C File Offset: 0x0000F80C
		// (set) Token: 0x06000297 RID: 663 RVA: 0x000035D9 File Offset: 0x000017D9
		public unsafe UnitView unitView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_unitView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_unitView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0001163C File Offset: 0x0000F83C
		// (set) Token: 0x06000299 RID: 665 RVA: 0x000035F8 File Offset: 0x000017F8
		public unsafe UnitPosition unitPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_unitPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodoo.NativeFieldInfoPtr_unitPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr_pathColor;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr_waypoints;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr_disableOrientation;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_disablePosition;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr_globalLookAt;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr_globalFollowPath;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeFieldInfoPtr_globalFollowPathBias;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_updateMode;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_loop;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr_autoStart;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr_velocityBias;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr_currentPos;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeFieldInfoPtr_isPlaying;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr_waypointChanged;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeFieldInfoPtr_presampledPath;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeFieldInfoPtr_samplesNum;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeFieldInfoPtr__lastPassedWaypoint;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr_positionSamples;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeFieldInfoPtr_rotationSamples;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_velocitySamples;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_waypointSamples;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_samplesDistances;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_totalDistance;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_updateTransform;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_isWeighted;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_relativeMode;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_scaleCurve;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_scaleCurveMode;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_startScale;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_endScale;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_unblockTime;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr__lastVelocity;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_destParent;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_startLT;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_destLT;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_dest;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_unitView;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_unitPosition;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_get_Waypoints_Public_get_Il2CppReferenceArray_1_Waypoint_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_set_Waypoints_Public_set_Void_Il2CppReferenceArray_1_Waypoint_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Transform_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Public_set_Void_Transform_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_get_DisableOrientation_Public_get_Boolean_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_set_DisableOrientation_Public_set_Void_Boolean_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_get_DisablePosition_Public_get_Boolean_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_set_DisablePosition_Public_set_Void_Boolean_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalLookAt_Public_get_Transform_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_set_GlobalLookAt_Public_set_Void_Transform_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalFollowPath_Public_get_Boolean_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_set_GlobalFollowPath_Public_set_Void_Boolean_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalFollowPathBias_Public_get_Single_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_set_GlobalFollowPathBias_Public_set_Void_Single_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateMode_Public_get_UpdateModeType_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateMode_Public_set_Void_UpdateModeType_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoStart_Public_get_Boolean_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoStart_Public_set_Void_Boolean_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_get_VelocityBias_Public_get_Single_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_set_VelocityBias_Public_set_Void_Single_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPos_Public_get_Single_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPos_Public_set_Void_Single_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_get_WaypointChanged_Public_get_WaypointChangedEvent_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_set_WaypointChanged_Public_set_Void_WaypointChangedEvent_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_get_PresampledPath_Public_get_Boolean_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_get_SamplesNum_Public_get_Int32_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_get_LastPassedWayponint_Public_get_Int32_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionSamples_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationSamples_Public_get_Il2CppStructArray_1_Quaternion_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_get_VelocitySamples_Public_get_Il2CppStructArray_1_Single_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_get_WaypointSamples_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_get_SamplesDistances_Public_get_Il2CppStructArray_1_Single_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDistance_Public_get_Single_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateTransform_Public_get_Boolean_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateTransform_Public_set_Void_Boolean_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWeighted_Public_get_Boolean_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_set_IsWeighted_Public_set_Void_Boolean_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeMode_Public_get_Boolean_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_set_RelativeMode_Public_set_Void_Boolean_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdate_Private_Void_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_Rewind_Public_Void_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_InitWithContext_Public_Virtual_Void_UnitView_UnitPosition_LocalTransform_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_updateWeights_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_sampledPositionAndRotationAndVelocityAndWaypointAtPos_Public_Void_Single_byref_Vector3_byref_Quaternion_byref_Single_byref_Int32_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_computeScaleAtPos_Public_Virtual_New_Vector3_Single_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_computeRotationAtPos_Public_Quaternion_Single_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_GetWaypointRotation_Public_Quaternion_Int32_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_computePositionAtPos_Public_Vector3_Single_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_computeVelocityAtPos_Public_Single_Single_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTarget_Public_Void_Vector3_Vector3_Quaternion_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTarget_Public_Void_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_raiseWaypointUpdatedEvents_Private_Void_Int32_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentWaypoint_Public_Int32_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_GetWaypointFromPos_Public_Int32_Single_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_GetFaceForwardForPos_Public_Quaternion_Single_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePathSamples_Public_Void_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C0 RID: 192
		[Serializable]
		public class WaypointChangedEvent : UnityEvent<int>
		{
			// Token: 0x06000A91 RID: 2705 RVA: 0x000072F2 File Offset: 0x000054F2
			// Note: this type is marked as 'beforefieldinit'.
			static WaypointChangedEvent()
			{
				Il2CppClassPointerStore<PathVoodoo.WaypointChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathVoodoo>.NativeClassPtr, "WaypointChangedEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathVoodoo.WaypointChangedEvent>.NativeClassPtr);
				PathVoodoo.WaypointChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodoo.WaypointChangedEvent>.NativeClassPtr, 100663583);
			}

			// Token: 0x06000A92 RID: 2706 RVA: 0x0002C158 File Offset: 0x0002A358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107838, XrefRangeEnd = 1107841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WaypointChangedEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathVoodoo.WaypointChangedEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodoo.WaypointChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A93 RID: 2707 RVA: 0x00007326 File Offset: 0x00005526
			public WaypointChangedEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000685 RID: 1669
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000C1 RID: 193
		public enum UpdateModeType
		{
			// Token: 0x04000687 RID: 1671
			OnUpdate,
			// Token: 0x04000688 RID: 1672
			OnFixedUpdate
		}

		// Token: 0x020000C2 RID: 194
		public enum ScaleCurveMode
		{
			// Token: 0x0400068A RID: 1674
			Lerp,
			// Token: 0x0400068B RID: 1675
			Multiply
		}
	}
}
