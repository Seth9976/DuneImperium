using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public class Physics : Object
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00004F50 File Offset: 0x00003150
		// Note: this type is marked as 'beforefieldinit'.
		static Physics()
		{
			Il2CppClassPointerStore<Physics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Physics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Physics>.NativeClassPtr);
			Physics.NativeFieldInfoPtr_ContactModifyEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics>.NativeClassPtr, "ContactModifyEvent");
			Physics.NativeFieldInfoPtr_ContactModifyEventCCD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics>.NativeClassPtr, "ContactModifyEventCCD");
			Physics.NativeFieldInfoPtr_ContactEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics>.NativeClassPtr, "ContactEvent");
			Physics.NativeFieldInfoPtr_s_ReusableCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics>.NativeClassPtr, "s_ReusableCollision");
			Physics.NativeMethodInfoPtr_OnSceneContactModify_Private_Static_Void_PhysicsScene_IntPtr_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663301);
			Physics.NativeMethodInfoPtr_get_invokeCollisionCallbacks_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663302);
			Physics.NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663303);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663304);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663305);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663306);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663307);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663308);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663309);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663310);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663311);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663312);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663313);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663314);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663315);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663316);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663317);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663318);
			Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663319);
			Physics.NativeMethodInfoPtr_Internal_RaycastAll_Private_Static_Il2CppStructArray_1_RaycastHit_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663320);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663321);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663322);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663323);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663324);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663325);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663326);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663327);
			Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663328);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663329);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663330);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663331);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663332);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663333);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663334);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663335);
			Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663336);
			Physics.NativeMethodInfoPtr_get_reuseCollisionCallbacks_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663337);
			Physics.NativeMethodInfoPtr_GetColliderByInstanceID_Internal_Static_Collider_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663338);
			Physics.NativeMethodInfoPtr_GetBodyByInstanceID_Internal_Static_Component_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663339);
			Physics.NativeMethodInfoPtr_SendOnCollisionEnter_Private_Static_Void_Component_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663340);
			Physics.NativeMethodInfoPtr_SendOnCollisionStay_Private_Static_Void_Component_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663341);
			Physics.NativeMethodInfoPtr_SendOnCollisionExit_Private_Static_Void_Component_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663342);
			Physics.NativeMethodInfoPtr_OnSceneContact_Private_Static_Void_PhysicsScene_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663343);
			Physics.NativeMethodInfoPtr_ReportContacts_Private_Static_Void_ReadOnly_ContactPairHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663344);
			Physics.NativeMethodInfoPtr_GetCollisionToReport_Private_Static_Collision_byref_ContactPairHeader_byref_ContactPair_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663345);
			Physics.NativeMethodInfoPtr_get_defaultPhysicsScene_Injected_Private_Static_Void_byref_PhysicsScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663347);
			Physics.NativeMethodInfoPtr_Internal_RaycastAll_Injected_Private_Static_Il2CppStructArray_1_RaycastHit_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663348);
			Physics.get_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<Physics.get_defaultContactOffsetDelegate>("UnityEngine.Physics::get_defaultContactOffset");
			Physics.set_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<Physics.set_defaultContactOffsetDelegate>("UnityEngine.Physics::set_defaultContactOffset");
			Physics.get_sleepThresholdDelegateField = IL2CPP.ResolveICall<Physics.get_sleepThresholdDelegate>("UnityEngine.Physics::get_sleepThreshold");
			Physics.set_sleepThresholdDelegateField = IL2CPP.ResolveICall<Physics.set_sleepThresholdDelegate>("UnityEngine.Physics::set_sleepThreshold");
			Physics.get_queriesHitTriggersDelegateField = IL2CPP.ResolveICall<Physics.get_queriesHitTriggersDelegate>("UnityEngine.Physics::get_queriesHitTriggers");
			Physics.set_queriesHitTriggersDelegateField = IL2CPP.ResolveICall<Physics.set_queriesHitTriggersDelegate>("UnityEngine.Physics::set_queriesHitTriggers");
			Physics.get_queriesHitBackfacesDelegateField = IL2CPP.ResolveICall<Physics.get_queriesHitBackfacesDelegate>("UnityEngine.Physics::get_queriesHitBackfaces");
			Physics.set_queriesHitBackfacesDelegateField = IL2CPP.ResolveICall<Physics.set_queriesHitBackfacesDelegate>("UnityEngine.Physics::set_queriesHitBackfaces");
			Physics.get_bounceThresholdDelegateField = IL2CPP.ResolveICall<Physics.get_bounceThresholdDelegate>("UnityEngine.Physics::get_bounceThreshold");
			Physics.set_bounceThresholdDelegateField = IL2CPP.ResolveICall<Physics.set_bounceThresholdDelegate>("UnityEngine.Physics::set_bounceThreshold");
			Physics.get_defaultMaxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<Physics.get_defaultMaxDepenetrationVelocityDelegate>("UnityEngine.Physics::get_defaultMaxDepenetrationVelocity");
			Physics.set_defaultMaxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<Physics.set_defaultMaxDepenetrationVelocityDelegate>("UnityEngine.Physics::set_defaultMaxDepenetrationVelocity");
			Physics.get_defaultSolverIterationsDelegateField = IL2CPP.ResolveICall<Physics.get_defaultSolverIterationsDelegate>("UnityEngine.Physics::get_defaultSolverIterations");
			Physics.set_defaultSolverIterationsDelegateField = IL2CPP.ResolveICall<Physics.set_defaultSolverIterationsDelegate>("UnityEngine.Physics::set_defaultSolverIterations");
			Physics.get_defaultSolverVelocityIterationsDelegateField = IL2CPP.ResolveICall<Physics.get_defaultSolverVelocityIterationsDelegate>("UnityEngine.Physics::get_defaultSolverVelocityIterations");
			Physics.set_defaultSolverVelocityIterationsDelegateField = IL2CPP.ResolveICall<Physics.set_defaultSolverVelocityIterationsDelegate>("UnityEngine.Physics::set_defaultSolverVelocityIterations");
			Physics.get_simulationModeDelegateField = IL2CPP.ResolveICall<Physics.get_simulationModeDelegate>("UnityEngine.Physics::get_simulationMode");
			Physics.set_simulationModeDelegateField = IL2CPP.ResolveICall<Physics.set_simulationModeDelegate>("UnityEngine.Physics::set_simulationMode");
			Physics.get_defaultMaxAngularSpeedDelegateField = IL2CPP.ResolveICall<Physics.get_defaultMaxAngularSpeedDelegate>("UnityEngine.Physics::get_defaultMaxAngularSpeed");
			Physics.set_defaultMaxAngularSpeedDelegateField = IL2CPP.ResolveICall<Physics.set_defaultMaxAngularSpeedDelegate>("UnityEngine.Physics::set_defaultMaxAngularSpeed");
			Physics.get_improvedPatchFrictionDelegateField = IL2CPP.ResolveICall<Physics.get_improvedPatchFrictionDelegate>("UnityEngine.Physics::get_improvedPatchFriction");
			Physics.set_improvedPatchFrictionDelegateField = IL2CPP.ResolveICall<Physics.set_improvedPatchFrictionDelegate>("UnityEngine.Physics::set_improvedPatchFriction");
			Physics.set_invokeCollisionCallbacksDelegateField = IL2CPP.ResolveICall<Physics.set_invokeCollisionCallbacksDelegate>("UnityEngine.Physics::set_invokeCollisionCallbacks");
			Physics.IgnoreCollisionDelegateField = IL2CPP.ResolveICall<Physics.IgnoreCollisionDelegate>("UnityEngine.Physics::IgnoreCollision");
			Physics.IgnoreLayerCollisionDelegateField = IL2CPP.ResolveICall<Physics.IgnoreLayerCollisionDelegate>("UnityEngine.Physics::IgnoreLayerCollision");
			Physics.GetIgnoreLayerCollisionDelegateField = IL2CPP.ResolveICall<Physics.GetIgnoreLayerCollisionDelegate>("UnityEngine.Physics::GetIgnoreLayerCollision");
			Physics.GetIgnoreCollisionDelegateField = IL2CPP.ResolveICall<Physics.GetIgnoreCollisionDelegate>("UnityEngine.Physics::GetIgnoreCollision");
			Physics.SyncTransformsDelegateField = IL2CPP.ResolveICall<Physics.SyncTransformsDelegate>("UnityEngine.Physics::SyncTransforms");
			Physics.get_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<Physics.get_autoSyncTransformsDelegate>("UnityEngine.Physics::get_autoSyncTransforms");
			Physics.set_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<Physics.set_autoSyncTransformsDelegate>("UnityEngine.Physics::set_autoSyncTransforms");
			Physics.set_reuseCollisionCallbacksDelegateField = IL2CPP.ResolveICall<Physics.set_reuseCollisionCallbacksDelegate>("UnityEngine.Physics::set_reuseCollisionCallbacks");
			Physics.get_interCollisionDistanceDelegateField = IL2CPP.ResolveICall<Physics.get_interCollisionDistanceDelegate>("UnityEngine.Physics::get_interCollisionDistance");
			Physics.set_interCollisionDistanceDelegateField = IL2CPP.ResolveICall<Physics.set_interCollisionDistanceDelegate>("UnityEngine.Physics::set_interCollisionDistance");
			Physics.get_interCollisionStiffnessDelegateField = IL2CPP.ResolveICall<Physics.get_interCollisionStiffnessDelegate>("UnityEngine.Physics::get_interCollisionStiffness");
			Physics.set_interCollisionStiffnessDelegateField = IL2CPP.ResolveICall<Physics.set_interCollisionStiffnessDelegate>("UnityEngine.Physics::set_interCollisionStiffness");
			Physics.get_interCollisionSettingsToggleDelegateField = IL2CPP.ResolveICall<Physics.get_interCollisionSettingsToggleDelegate>("UnityEngine.Physics::get_interCollisionSettingsToggle");
			Physics.set_interCollisionSettingsToggleDelegateField = IL2CPP.ResolveICall<Physics.set_interCollisionSettingsToggleDelegate>("UnityEngine.Physics::set_interCollisionSettingsToggle");
			Physics.BakeMeshDelegateField = IL2CPP.ResolveICall<Physics.BakeMeshDelegate>("UnityEngine.Physics::BakeMesh");
			Physics.ResolveShapeToColliderDelegateField = IL2CPP.ResolveICall<Physics.ResolveShapeToColliderDelegate>("UnityEngine.Physics::ResolveShapeToCollider");
			Physics.ResolveActorToComponentDelegateField = IL2CPP.ResolveICall<Physics.ResolveActorToComponentDelegate>("UnityEngine.Physics::ResolveActorToComponent");
			Physics.ResolveShapeToInstanceIDDelegateField = IL2CPP.ResolveICall<Physics.ResolveShapeToInstanceIDDelegate>("UnityEngine.Physics::ResolveShapeToInstanceID");
			Physics.ResolveActorToInstanceIDDelegateField = IL2CPP.ResolveICall<Physics.ResolveActorToInstanceIDDelegate>("UnityEngine.Physics::ResolveActorToInstanceID");
			Physics.TranslateTriangleIndexDelegateField = IL2CPP.ResolveICall<Physics.TranslateTriangleIndexDelegate>("UnityEngine.Physics::TranslateTriangleIndex");
			Physics.TranslateTriangleIndexFromIDDelegateField = IL2CPP.ResolveICall<Physics.TranslateTriangleIndexFromIDDelegate>("UnityEngine.Physics::TranslateTriangleIndexFromID");
			Physics.IsShapeTriggerDelegateField = IL2CPP.ResolveICall<Physics.IsShapeTriggerDelegate>("UnityEngine.Physics::IsShapeTrigger");
			Physics.get_gravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.get_gravity_InjectedDelegate>("UnityEngine.Physics::get_gravity_Injected");
			Physics.set_gravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.set_gravity_InjectedDelegate>("UnityEngine.Physics::set_gravity_Injected");
			Physics.Query_CapsuleCastAll_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Query_CapsuleCastAll_InjectedDelegate>("UnityEngine.Physics::Query_CapsuleCastAll_Injected");
			Physics.Query_SphereCastAll_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Query_SphereCastAll_InjectedDelegate>("UnityEngine.Physics::Query_SphereCastAll_Injected");
			Physics.OverlapCapsule_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.OverlapCapsule_Internal_InjectedDelegate>("UnityEngine.Physics::OverlapCapsule_Internal_Injected");
			Physics.OverlapSphere_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.OverlapSphere_Internal_InjectedDelegate>("UnityEngine.Physics::OverlapSphere_Internal_Injected");
			Physics.Simulate_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Simulate_Internal_InjectedDelegate>("UnityEngine.Physics::Simulate_Internal_Injected");
			Physics.InterpolateBodies_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.InterpolateBodies_Internal_InjectedDelegate>("UnityEngine.Physics::InterpolateBodies_Internal_Injected");
			Physics.ResetInterpolationPoses_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.ResetInterpolationPoses_Internal_InjectedDelegate>("UnityEngine.Physics::ResetInterpolationPoses_Internal_Injected");
			Physics.Query_ComputePenetration_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Query_ComputePenetration_InjectedDelegate>("UnityEngine.Physics::Query_ComputePenetration_Injected");
			Physics.Query_ClosestPoint_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Query_ClosestPoint_InjectedDelegate>("UnityEngine.Physics::Query_ClosestPoint_Injected");
			Physics.get_clothGravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.get_clothGravity_InjectedDelegate>("UnityEngine.Physics::get_clothGravity_Injected");
			Physics.set_clothGravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.set_clothGravity_InjectedDelegate>("UnityEngine.Physics::set_clothGravity_Injected");
			Physics.CheckSphere_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.CheckSphere_Internal_InjectedDelegate>("UnityEngine.Physics::CheckSphere_Internal_Injected");
			Physics.CheckCapsule_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.CheckCapsule_Internal_InjectedDelegate>("UnityEngine.Physics::CheckCapsule_Internal_Injected");
			Physics.CheckBox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.CheckBox_Internal_InjectedDelegate>("UnityEngine.Physics::CheckBox_Internal_Injected");
			Physics.OverlapBox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics.OverlapBox_Internal_InjectedDelegate>("UnityEngine.Physics::OverlapBox_Internal_Injected");
			Physics.Internal_BoxCastAll_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Internal_BoxCastAll_InjectedDelegate>("UnityEngine.Physics::Internal_BoxCastAll_Injected");
			Physics.Internal_RebuildBroadphaseRegions_InjectedDelegateField = IL2CPP.ResolveICall<Physics.Internal_RebuildBroadphaseRegions_InjectedDelegate>("UnityEngine.Physics::Internal_RebuildBroadphaseRegions_Injected");
			Physics.GetActorLinearVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.GetActorLinearVelocity_InjectedDelegate>("UnityEngine.Physics::GetActorLinearVelocity_Injected");
			Physics.GetActorAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Physics.GetActorAngularVelocity_InjectedDelegate>("UnityEngine.Physics::GetActorAngularVelocity_Injected");
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000575C File Offset: 0x0000395C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254603, XrefRangeEnd = 1254613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCCD;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_OnSceneContactModify_Private_Static_Void_PhysicsScene_IntPtr_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000057B8 File Offset: 0x000039B8
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000023D7 File Offset: 0x000005D7
		public unsafe static bool invokeCollisionCallbacks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254613, XrefRangeEnd = 1254615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_get_invokeCollisionCallbacks_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Physics.set_invokeCollisionCallbacksDelegateField(value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000057E8 File Offset: 0x000039E8
		public unsafe static PhysicsScene defaultPhysicsScene
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 1254620, RefRangeEnd = 1254645, XrefRangeStart = 1254615, XrefRangeEnd = 1254620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005818 File Offset: 0x00003A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254645, XrefRangeEnd = 1254650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005890 File Offset: 0x00003A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254650, XrefRangeEnd = 1254659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000058F8 File Offset: 0x00003AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254659, XrefRangeEnd = 1254668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005954 File Offset: 0x00003B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254668, XrefRangeEnd = 1254677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000059A0 File Offset: 0x00003BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254677, XrefRangeEnd = 1254682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005A24 File Offset: 0x00003C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254682, XrefRangeEnd = 1254687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005A9C File Offset: 0x00003C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254687, XrefRangeEnd = 1254692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005B04 File Offset: 0x00003D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254692, XrefRangeEnd = 1254697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005B60 File Offset: 0x00003D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254697, XrefRangeEnd = 1254702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254702, XrefRangeEnd = 1254711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005C24 File Offset: 0x00003E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254711, XrefRangeEnd = 1254720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005C70 File Offset: 0x00003E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254720, XrefRangeEnd = 1254725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005CB0 File Offset: 0x00003EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254725, XrefRangeEnd = 1254730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00005D28 File Offset: 0x00003F28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1254738, RefRangeEnd = 1254741, XrefRangeStart = 1254730, XrefRangeEnd = 1254738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005D90 File Offset: 0x00003F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254741, XrefRangeEnd = 1254746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00005DEC File Offset: 0x00003FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254746, XrefRangeEnd = 1254751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005E38 File Offset: 0x00004038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254751, XrefRangeEnd = 1254756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Internal_RaycastAll_Private_Static_Il2CppStructArray_1_RaycastHit_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005EB0 File Offset: 0x000040B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1254771, RefRangeEnd = 1254778, XrefRangeStart = 1254756, XrefRangeEnd = 1254771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005F28 File Offset: 0x00004128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254778, XrefRangeEnd = 1254782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005F94 File Offset: 0x00004194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254782, XrefRangeEnd = 1254786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005FF0 File Offset: 0x000041F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254786, XrefRangeEnd = 1254790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006040 File Offset: 0x00004240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254790, XrefRangeEnd = 1254794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000060AC File Offset: 0x000042AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254794, XrefRangeEnd = 1254798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00006108 File Offset: 0x00004308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254798, XrefRangeEnd = 1254802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00006158 File Offset: 0x00004358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254802, XrefRangeEnd = 1254806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00006198 File Offset: 0x00004398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254806, XrefRangeEnd = 1254816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00006214 File Offset: 0x00004414
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1254826, RefRangeEnd = 1254828, XrefRangeStart = 1254816, XrefRangeEnd = 1254826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006280 File Offset: 0x00004480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254828, XrefRangeEnd = 1254838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000062E0 File Offset: 0x000044E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254838, XrefRangeEnd = 1254848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00006330 File Offset: 0x00004530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254848, XrefRangeEnd = 1254858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000063B8 File Offset: 0x000045B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254858, XrefRangeEnd = 1254868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006434 File Offset: 0x00004634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254868, XrefRangeEnd = 1254878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000064A0 File Offset: 0x000046A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254878, XrefRangeEnd = 1254888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00006500 File Offset: 0x00004700
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x000024F0 File Offset: 0x000006F0
		public unsafe static bool reuseCollisionCallbacks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254888, XrefRangeEnd = 1254890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_get_reuseCollisionCallbacks_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Physics.set_reuseCollisionCallbacksDelegateField(value);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00006530 File Offset: 0x00004730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254890, XrefRangeEnd = 1254892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Collider GetColliderByInstanceID(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_GetColliderByInstanceID_Internal_Static_Collider_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr3) : null;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00006570 File Offset: 0x00004770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254892, XrefRangeEnd = 1254894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Component GetBodyByInstanceID(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_GetBodyByInstanceID_Internal_Static_Component_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000065B0 File Offset: 0x000047B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1254896, RefRangeEnd = 1254898, XrefRangeStart = 1254894, XrefRangeEnd = 1254896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendOnCollisionEnter(Component component, Collision collision)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_SendOnCollisionEnter_Private_Static_Void_Component_Collision_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000065F8 File Offset: 0x000047F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1254910, RefRangeEnd = 1254912, XrefRangeStart = 1254898, XrefRangeEnd = 1254910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendOnCollisionStay(Component component, Collision collision)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_SendOnCollisionStay_Private_Static_Void_Component_Collision_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00006640 File Offset: 0x00004840
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1254914, RefRangeEnd = 1254916, XrefRangeStart = 1254912, XrefRangeEnd = 1254914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendOnCollisionExit(Component component, Collision collision)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_SendOnCollisionExit_Private_Static_Void_Component_Collision_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00006688 File Offset: 0x00004888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254916, XrefRangeEnd = 1254938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_OnSceneContact_Private_Static_Void_PhysicsScene_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000066D8 File Offset: 0x000048D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1254985, RefRangeEnd = 1254986, XrefRangeStart = 1254938, XrefRangeEnd = 1254985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportContacts(NativeArray<ContactPairHeader>.ReadOnly array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_ReportContacts_Private_Static_Void_ReadOnly_ContactPairHeader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00006714 File Offset: 0x00004914
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1255009, RefRangeEnd = 1255015, XrefRangeStart = 1254986, XrefRangeEnd = 1255009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Collision GetCollisionToReport([In] ref ContactPairHeader header, [In] ref ContactPair pair, bool flipped)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &header;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pair;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_GetCollisionToReport_Private_Static_Collision_byref_ContactPairHeader_byref_ContactPair_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collision>(intPtr3) : null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006770 File Offset: 0x00004970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255015, XrefRangeEnd = 1255017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_defaultPhysicsScene_Injected(out PhysicsScene ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_get_defaultPhysicsScene_Injected_Private_Static_Void_byref_PhysicsScene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000067A4 File Offset: 0x000049A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255017, XrefRangeEnd = 1255019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit> Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryTriggerInteraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.NativeMethodInfoPtr_Internal_RaycastAll_Injected_Private_Static_Il2CppStructArray_1_RaycastHit_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002236 File Offset: 0x00000436
		public Physics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000681C File Offset: 0x00004A1C
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000223F File Offset: 0x0000043F
		public unsafe static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Physics.NativeFieldInfoPtr_ContactModifyEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PhysicsScene, NativeArray<ModifiableContactPair>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Physics.NativeFieldInfoPtr_ContactModifyEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00006844 File Offset: 0x00004A44
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002251 File Offset: 0x00000451
		public unsafe static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Physics.NativeFieldInfoPtr_ContactModifyEventCCD, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PhysicsScene, NativeArray<ModifiableContactPair>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Physics.NativeFieldInfoPtr_ContactModifyEventCCD, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000686C File Offset: 0x00004A6C
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002263 File Offset: 0x00000463
		public unsafe static Physics.ContactEventDelegate ContactEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Physics.NativeFieldInfoPtr_ContactEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Physics.ContactEventDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Physics.NativeFieldInfoPtr_ContactEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00006894 File Offset: 0x00004A94
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002275 File Offset: 0x00000475
		public unsafe static Collision s_ReusableCollision
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Physics.NativeFieldInfoPtr_s_ReusableCollision, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collision>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Physics.NativeFieldInfoPtr_s_ReusableCollision, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002287 File Offset: 0x00000487
		public static void add_ContactModifyEvent(Action<PhysicsScene, NativeArray<ModifiableContactPair>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002294 File Offset: 0x00000494
		public static void remove_ContactModifyEvent(Action<PhysicsScene, NativeArray<ModifiableContactPair>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000022A1 File Offset: 0x000004A1
		public static void add_ContactModifyEventCCD(Action<PhysicsScene, NativeArray<ModifiableContactPair>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000022AE File Offset: 0x000004AE
		public static void remove_ContactModifyEventCCD(Action<PhysicsScene, NativeArray<ModifiableContactPair>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000068BC File Offset: 0x00004ABC
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000022BB File Offset: 0x000004BB
		public static Vector3 gravity
		{
			get
			{
				Vector3 vector;
				Physics.get_gravity_Injected(out vector);
				return vector;
			}
			set
			{
				Physics.set_gravity_Injected(ref value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000022C4 File Offset: 0x000004C4
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000022D0 File Offset: 0x000004D0
		public static float defaultContactOffset
		{
			get
			{
				return Physics.get_defaultContactOffsetDelegateField();
			}
			set
			{
				Physics.set_defaultContactOffsetDelegateField(value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000022DD File Offset: 0x000004DD
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000022E9 File Offset: 0x000004E9
		public static float sleepThreshold
		{
			get
			{
				return Physics.get_sleepThresholdDelegateField();
			}
			set
			{
				Physics.set_sleepThresholdDelegateField(value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000022F6 File Offset: 0x000004F6
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002302 File Offset: 0x00000502
		public static bool queriesHitTriggers
		{
			get
			{
				return Physics.get_queriesHitTriggersDelegateField();
			}
			set
			{
				Physics.set_queriesHitTriggersDelegateField(value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000230F File Offset: 0x0000050F
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000231B File Offset: 0x0000051B
		public static bool queriesHitBackfaces
		{
			get
			{
				return Physics.get_queriesHitBackfacesDelegateField();
			}
			set
			{
				Physics.set_queriesHitBackfacesDelegateField(value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002334 File Offset: 0x00000534
		public static float bounceThreshold
		{
			get
			{
				return Physics.get_bounceThresholdDelegateField();
			}
			set
			{
				Physics.set_bounceThresholdDelegateField(value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002341 File Offset: 0x00000541
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0000234D File Offset: 0x0000054D
		public static float defaultMaxDepenetrationVelocity
		{
			get
			{
				return Physics.get_defaultMaxDepenetrationVelocityDelegateField();
			}
			set
			{
				Physics.set_defaultMaxDepenetrationVelocityDelegateField(value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000235A File Offset: 0x0000055A
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002366 File Offset: 0x00000566
		public static int defaultSolverIterations
		{
			get
			{
				return Physics.get_defaultSolverIterationsDelegateField();
			}
			set
			{
				Physics.set_defaultSolverIterationsDelegateField(value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002373 File Offset: 0x00000573
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000237F File Offset: 0x0000057F
		public static int defaultSolverVelocityIterations
		{
			get
			{
				return Physics.get_defaultSolverVelocityIterationsDelegateField();
			}
			set
			{
				Physics.set_defaultSolverVelocityIterationsDelegateField(value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000238C File Offset: 0x0000058C
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002398 File Offset: 0x00000598
		public static SimulationMode simulationMode
		{
			get
			{
				return Physics.get_simulationModeDelegateField();
			}
			set
			{
				Physics.set_simulationModeDelegateField(value);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000023A5 File Offset: 0x000005A5
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000023B1 File Offset: 0x000005B1
		public static float defaultMaxAngularSpeed
		{
			get
			{
				return Physics.get_defaultMaxAngularSpeedDelegateField();
			}
			set
			{
				Physics.set_defaultMaxAngularSpeedDelegateField(value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000023BE File Offset: 0x000005BE
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000023CA File Offset: 0x000005CA
		public static bool improvedPatchFriction
		{
			get
			{
				return Physics.get_improvedPatchFrictionDelegateField();
			}
			set
			{
				Physics.set_improvedPatchFrictionDelegateField(value);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000023E4 File Offset: 0x000005E4
		public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore)
		{
			Physics.IgnoreCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2), ignore);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000023FD File Offset: 0x000005FD
		public static void IgnoreCollision(Collider collider1, Collider collider2)
		{
			Physics.IgnoreCollision(collider1, collider2, true);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002409 File Offset: 0x00000609
		public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore)
		{
			Physics.IgnoreLayerCollisionDelegateField(layer1, layer2, ignore);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002418 File Offset: 0x00000618
		public static void IgnoreLayerCollision(int layer1, int layer2)
		{
			Physics.IgnoreLayerCollision(layer1, layer2, true);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002424 File Offset: 0x00000624
		public static bool GetIgnoreLayerCollision(int layer1, int layer2)
		{
			return Physics.GetIgnoreLayerCollisionDelegateField(layer1, layer2);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002432 File Offset: 0x00000632
		public static bool GetIgnoreCollision(Collider collider1, Collider collider2)
		{
			return Physics.GetIgnoreCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2));
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000068D4 File Offset: 0x00004AD4
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			Vector3 vector = end - start;
			return Physics.defaultPhysicsScene.Raycast(start, vector, vector.magnitude, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00006908 File Offset: 0x00004B08
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask)
		{
			return Physics.Linecast(start, end, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00006924 File Offset: 0x00004B24
		public static bool Linecast(Vector3 start, Vector3 end)
		{
			return Physics.Linecast(start, end, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00006940 File Offset: 0x00004B40
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			Vector3 vector = end - start;
			return Physics.defaultPhysicsScene.Raycast(start, vector, out hitInfo, vector.magnitude, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00006974 File Offset: 0x00004B74
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask)
		{
			return Physics.Linecast(start, end, out hitInfo, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00006990 File Offset: 0x00004B90
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo)
		{
			return Physics.Linecast(start, end, out hitInfo, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000069B0 File Offset: 0x00004BB0
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			RaycastHit raycastHit;
			return Physics.defaultPhysicsScene.CapsuleCast(point1, point2, radius, direction, out raycastHit, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000069DC File Offset: 0x00004BDC
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000069FC File Offset: 0x00004BFC
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00006A1C File Offset: 0x00004C1C
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00006A40 File Offset: 0x00004C40
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006A6C File Offset: 0x00004C6C
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00006A90 File Offset: 0x00004C90
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006AB4 File Offset: 0x00004CB4
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo)
		{
			return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00006ADC File Offset: 0x00004CDC
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.SphereCast(origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00006B08 File Offset: 0x00004D08
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			return Physics.SphereCast(origin, radius, direction, out hitInfo, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00006B28 File Offset: 0x00004D28
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			return Physics.SphereCast(origin, radius, direction, out hitInfo, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00006B48 File Offset: 0x00004D48
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo)
		{
			return Physics.SphereCast(origin, radius, direction, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00006B6C File Offset: 0x00004D6C
		public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			RaycastHit raycastHit;
			return Physics.SphereCast(ray.origin, radius, ray.direction, out raycastHit, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00006B98 File Offset: 0x00004D98
		public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask)
		{
			return Physics.SphereCast(ray, radius, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00006BB4 File Offset: 0x00004DB4
		public static bool SphereCast(Ray ray, float radius, float maxDistance)
		{
			return Physics.SphereCast(ray, radius, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00006BD4 File Offset: 0x00004DD4
		public static bool SphereCast(Ray ray, float radius)
		{
			return Physics.SphereCast(ray, radius, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00006BF8 File Offset: 0x00004DF8
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.SphereCast(ray.origin, radius, ray.direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00006C24 File Offset: 0x00004E24
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			return Physics.SphereCast(ray, radius, out hitInfo, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00006C44 File Offset: 0x00004E44
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance)
		{
			return Physics.SphereCast(ray, radius, out hitInfo, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00006C64 File Offset: 0x00004E64
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo)
		{
			return Physics.SphereCast(ray, radius, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006C88 File Offset: 0x00004E88
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			RaycastHit raycastHit;
			return Physics.defaultPhysicsScene.BoxCast(center, halfExtents, direction, out raycastHit, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00006CB4 File Offset: 0x00004EB4
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask)
		{
			return Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00006CD4 File Offset: 0x00004ED4
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance)
		{
			return Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00006CF4 File Offset: 0x00004EF4
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation)
		{
			return Physics.BoxCast(center, halfExtents, direction, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00006D18 File Offset: 0x00004F18
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction)
		{
			return Physics.BoxCast(center, halfExtents, direction, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00006D40 File Offset: 0x00004F40
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00006D6C File Offset: 0x00004F6C
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask)
		{
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006D90 File Offset: 0x00004F90
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance)
		{
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006DB4 File Offset: 0x00004FB4
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation)
		{
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00006DDC File Offset: 0x00004FDC
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo)
		{
			return Physics.BoxCast(center, halfExtents, direction, out hitInfo, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000244A File Offset: 0x0000064A
		public static Il2CppStructArray<RaycastHit> Query_CapsuleCastAll(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Query_CapsuleCastAll_Injected(ref physicsScene, ref p0, ref p1, radius, ref direction, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002460 File Offset: 0x00000660
		public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00006E04 File Offset: 0x00005004
		public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask)
		{
			return Physics.CapsuleCastAll(point1, point2, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006E24 File Offset: 0x00005024
		public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance)
		{
			return Physics.CapsuleCastAll(point1, point2, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006E44 File Offset: 0x00005044
		public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction)
		{
			return Physics.CapsuleCastAll(point1, point2, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000246D File Offset: 0x0000066D
		public static Il2CppStructArray<RaycastHit> Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Query_SphereCastAll_Injected(ref physicsScene, ref origin, radius, ref direction, maxDistance, mask, queryTriggerInteraction);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002481 File Offset: 0x00000681
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00006E68 File Offset: 0x00005068
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask)
		{
			return Physics.SphereCastAll(origin, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00006E88 File Offset: 0x00005088
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance)
		{
			return Physics.SphereCastAll(origin, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006EA8 File Offset: 0x000050A8
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction)
		{
			return Physics.SphereCastAll(origin, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00006ECC File Offset: 0x000050CC
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.SphereCastAll(ray.origin, radius, ray.direction, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00006EF8 File Offset: 0x000050F8
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask)
		{
			return Physics.SphereCastAll(ray, radius, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00006F14 File Offset: 0x00005114
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius, float maxDistance)
		{
			return Physics.SphereCastAll(ray, radius, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00006F34 File Offset: 0x00005134
		public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius)
		{
			return Physics.SphereCastAll(ray, radius, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000248E File Offset: 0x0000068E
		public static Il2CppReferenceArray<Collider> OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapCapsule_Internal_Injected(ref physicsScene, ref point0, ref point1, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00006F58 File Offset: 0x00005158
		public static Il2CppReferenceArray<Collider> OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapCapsule_Internal(Physics.defaultPhysicsScene, point0, point1, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00006F7C File Offset: 0x0000517C
		public static Il2CppReferenceArray<Collider> OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask)
		{
			return Physics.OverlapCapsule(point0, point1, radius, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00006F98 File Offset: 0x00005198
		public static Il2CppReferenceArray<Collider> OverlapCapsule(Vector3 point0, Vector3 point1, float radius)
		{
			return Physics.OverlapCapsule(point0, point1, radius, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000024A0 File Offset: 0x000006A0
		public static Il2CppReferenceArray<Collider> OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapSphere_Internal_Injected(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00006FB4 File Offset: 0x000051B4
		public static Il2CppReferenceArray<Collider> OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapSphere_Internal(Physics.defaultPhysicsScene, position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00006FD4 File Offset: 0x000051D4
		public static Il2CppReferenceArray<Collider> OverlapSphere(Vector3 position, float radius, int layerMask)
		{
			return Physics.OverlapSphere(position, radius, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006FF0 File Offset: 0x000051F0
		public static Il2CppReferenceArray<Collider> OverlapSphere(Vector3 position, float radius)
		{
			return Physics.OverlapSphere(position, radius, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000024AF File Offset: 0x000006AF
		public static void Simulate_Internal(PhysicsScene physicsScene, float step)
		{
			Physics.Simulate_Internal_Injected(ref physicsScene, step);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000700C File Offset: 0x0000520C
		public static void Simulate(float step)
		{
			bool flag = Physics.simulationMode != SimulationMode.Script;
			if (flag)
			{
				Debug.LogWarning("Physics.Simulate(...) was called but simulation mode is not set to Script. You should set simulation mode to Script first before calling this function therefore the simulation was not run.");
			}
			else
			{
				Physics.Simulate_Internal(Physics.defaultPhysicsScene, step);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000024B9 File Offset: 0x000006B9
		public static void InterpolateBodies_Internal(PhysicsScene physicsScene)
		{
			Physics.InterpolateBodies_Internal_Injected(ref physicsScene);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000024C2 File Offset: 0x000006C2
		public static void ResetInterpolationPoses_Internal(PhysicsScene physicsScene)
		{
			Physics.ResetInterpolationPoses_Internal_Injected(ref physicsScene);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000024CB File Offset: 0x000006CB
		public static void SyncTransforms()
		{
			Physics.SyncTransformsDelegateField();
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000024D7 File Offset: 0x000006D7
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000024E3 File Offset: 0x000006E3
		public static bool autoSyncTransforms
		{
			get
			{
				return Physics.get_autoSyncTransformsDelegateField();
			}
			set
			{
				Physics.set_autoSyncTransformsDelegateField(value);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000024FD File Offset: 0x000006FD
		public static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance)
		{
			return Physics.Query_ComputePenetration_Injected(colliderA, ref positionA, ref rotationA, colliderB, ref positionB, ref rotationB, ref direction, ref distance);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00007044 File Offset: 0x00005244
		public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance)
		{
			direction = Vector3.zero;
			distance = 0f;
			return Physics.Query_ComputePenetration(colliderA, positionA, rotationA, colliderB, positionB, rotationB, ref direction, ref distance);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000707C File Offset: 0x0000527C
		public static Vector3 Query_ClosestPoint(Collider collider, Vector3 position, Quaternion rotation, Vector3 point)
		{
			Vector3 vector;
			Physics.Query_ClosestPoint_Injected(collider, ref position, ref rotation, ref point, out vector);
			return vector;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00007098 File Offset: 0x00005298
		public static Vector3 ClosestPoint(Vector3 point, Collider collider, Vector3 position, Quaternion rotation)
		{
			return Physics.Query_ClosestPoint(collider, position, rotation, point);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00002512 File Offset: 0x00000712
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000251E File Offset: 0x0000071E
		public static float interCollisionDistance
		{
			get
			{
				return Physics.get_interCollisionDistanceDelegateField();
			}
			set
			{
				Physics.set_interCollisionDistanceDelegateField(value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000252B File Offset: 0x0000072B
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002537 File Offset: 0x00000737
		public static float interCollisionStiffness
		{
			get
			{
				return Physics.get_interCollisionStiffnessDelegateField();
			}
			set
			{
				Physics.set_interCollisionStiffnessDelegateField(value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002544 File Offset: 0x00000744
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002550 File Offset: 0x00000750
		public static bool interCollisionSettingsToggle
		{
			get
			{
				return Physics.get_interCollisionSettingsToggleDelegateField();
			}
			set
			{
				Physics.set_interCollisionSettingsToggleDelegateField(value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000070B4 File Offset: 0x000052B4
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000255D File Offset: 0x0000075D
		public static Vector3 clothGravity
		{
			get
			{
				Vector3 vector;
				Physics.get_clothGravity_Injected(out vector);
				return vector;
			}
			set
			{
				Physics.set_clothGravity_Injected(ref value);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000070CC File Offset: 0x000052CC
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.OverlapSphere(position, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000070F4 File Offset: 0x000052F4
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask)
		{
			return Physics.OverlapSphereNonAlloc(position, radius, results, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007110 File Offset: 0x00005310
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Il2CppReferenceArray<Collider> results)
		{
			return Physics.OverlapSphereNonAlloc(position, radius, results, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002566 File Offset: 0x00000766
		public static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckSphere_Internal_Injected(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000712C File Offset: 0x0000532C
		public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckSphere_Internal(Physics.defaultPhysicsScene, position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000714C File Offset: 0x0000534C
		public static bool CheckSphere(Vector3 position, float radius, int layerMask)
		{
			return Physics.CheckSphere(position, radius, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00007168 File Offset: 0x00005368
		public static bool CheckSphere(Vector3 position, float radius)
		{
			return Physics.CheckSphere(position, radius, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00007184 File Offset: 0x00005384
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.CapsuleCast(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000071B0 File Offset: 0x000053B0
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			return Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000071D4 File Offset: 0x000053D4
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			return Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000071F8 File Offset: 0x000053F8
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			return Physics.CapsuleCastNonAlloc(point1, point2, radius, direction, results, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00007220 File Offset: 0x00005420
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.SphereCast(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000724C File Offset: 0x0000544C
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			return Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000726C File Offset: 0x0000546C
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			return Physics.SphereCastNonAlloc(origin, radius, direction, results, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000728C File Offset: 0x0000548C
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			return Physics.SphereCastNonAlloc(origin, radius, direction, results, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000072B0 File Offset: 0x000054B0
		public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.SphereCastNonAlloc(ray.origin, radius, ray.direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000072DC File Offset: 0x000054DC
		public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
		{
			return Physics.SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000072FC File Offset: 0x000054FC
		public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results, float maxDistance)
		{
			return Physics.SphereCastNonAlloc(ray, radius, results, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000731C File Offset: 0x0000551C
		public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results)
		{
			return Physics.SphereCastNonAlloc(ray, radius, results, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002575 File Offset: 0x00000775
		public static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckCapsule_Internal_Injected(ref physicsScene, ref start, ref end, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00007340 File Offset: 0x00005540
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckCapsule_Internal(Physics.defaultPhysicsScene, start, end, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007364 File Offset: 0x00005564
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask)
		{
			return Physics.CheckCapsule(start, end, radius, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007380 File Offset: 0x00005580
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius)
		{
			return Physics.CheckCapsule(start, end, radius, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002587 File Offset: 0x00000787
		public static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckBox_Internal_Injected(ref physicsScene, ref center, ref halfExtents, ref orientation, layermask, queryTriggerInteraction);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000073A0 File Offset: 0x000055A0
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckBox_Internal(Physics.defaultPhysicsScene, center, halfExtents, orientation, layermask, queryTriggerInteraction);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000073C4 File Offset: 0x000055C4
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask)
		{
			return Physics.CheckBox(center, halfExtents, orientation, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000073E0 File Offset: 0x000055E0
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
		{
			return Physics.CheckBox(center, halfExtents, orientation, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00007400 File Offset: 0x00005600
		public static bool CheckBox(Vector3 center, Vector3 halfExtents)
		{
			return Physics.CheckBox(center, halfExtents, Quaternion.identity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000259A File Offset: 0x0000079A
		public static Il2CppReferenceArray<Collider> OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapBox_Internal_Injected(ref physicsScene, ref center, ref halfExtents, ref orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00007424 File Offset: 0x00005624
		public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.OverlapBox_Internal(Physics.defaultPhysicsScene, center, halfExtents, orientation, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00007448 File Offset: 0x00005648
		public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask)
		{
			return Physics.OverlapBox(center, halfExtents, orientation, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00007464 File Offset: 0x00005664
		public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
		{
			return Physics.OverlapBox(center, halfExtents, orientation, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00007480 File Offset: 0x00005680
		public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents)
		{
			return Physics.OverlapBox(center, halfExtents, Quaternion.identity, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000074A0 File Offset: 0x000056A0
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.OverlapBox(center, halfExtents, results, orientation, mask, queryTriggerInteraction);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000074C8 File Offset: 0x000056C8
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, int mask)
		{
			return Physics.OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000074E8 File Offset: 0x000056E8
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation)
		{
			return Physics.OverlapBoxNonAlloc(center, halfExtents, results, orientation, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00007508 File Offset: 0x00005708
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results)
		{
			return Physics.OverlapBoxNonAlloc(center, halfExtents, results, Quaternion.identity, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000752C File Offset: 0x0000572C
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.BoxCast(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00007558 File Offset: 0x00005758
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation)
		{
			return Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00007580 File Offset: 0x00005780
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, float maxDistance)
		{
			return Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000075A4 File Offset: 0x000057A4
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, float maxDistance, int layerMask)
		{
			return Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000075C8 File Offset: 0x000057C8
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results)
		{
			return Physics.BoxCastNonAlloc(center, halfExtents, direction, results, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000025AD File Offset: 0x000007AD
		public static Il2CppStructArray<RaycastHit> Internal_BoxCastAll(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.Internal_BoxCastAll_Injected(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000025C4 File Offset: 0x000007C4
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000075F0 File Offset: 0x000057F0
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask)
		{
			return Physics.BoxCastAll(center, halfExtents, direction, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00007610 File Offset: 0x00005810
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance)
		{
			return Physics.BoxCastAll(center, halfExtents, direction, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00007630 File Offset: 0x00005830
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation)
		{
			return Physics.BoxCastAll(center, halfExtents, direction, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00007654 File Offset: 0x00005854
		public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction)
		{
			return Physics.BoxCastAll(center, halfExtents, direction, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000767C File Offset: 0x0000587C
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.defaultPhysicsScene.OverlapCapsule(point0, point1, radius, results, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000076A4 File Offset: 0x000058A4
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask)
		{
			return Physics.OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000076C4 File Offset: 0x000058C4
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results)
		{
			return Physics.OverlapCapsuleNonAlloc(point0, point1, radius, results, -1, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000025D1 File Offset: 0x000007D1
		public static void Internal_RebuildBroadphaseRegions(Bounds bounds, int subdivisions)
		{
			Physics.Internal_RebuildBroadphaseRegions_Injected(ref bounds, subdivisions);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000076E4 File Offset: 0x000058E4
		public static void RebuildBroadphaseRegions(Bounds worldBounds, int subdivisions)
		{
			bool flag = subdivisions < 1 || subdivisions > 16;
			if (flag)
			{
				throw new ArgumentException("Physics.RebuildBroadphaseRegions requires the subdivisions to be greater than zero and less than 17.");
			}
			bool flag2 = worldBounds.extents.x <= 0f || worldBounds.extents.y <= 0f || worldBounds.extents.z <= 0f;
			if (flag2)
			{
				throw new ArgumentException("Physics.RebuildBroadphaseRegions requires the world bounds to be non-empty, and have positive extents.");
			}
			Physics.Internal_RebuildBroadphaseRegions(worldBounds, subdivisions);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000025DB File Offset: 0x000007DB
		public static void BakeMesh(int meshID, bool convex, MeshColliderCookingOptions cookingOptions)
		{
			Physics.BakeMeshDelegateField(meshID, convex, cookingOptions);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000025EA File Offset: 0x000007EA
		public static void BakeMesh(int meshID, bool convex)
		{
			Physics.BakeMesh(meshID, convex, MeshColliderCookingOptions.CookForFasterSimulation | MeshColliderCookingOptions.EnableMeshCleaning | MeshColliderCookingOptions.WeldColocatedVertices | MeshColliderCookingOptions.UseFastMidphase);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00007768 File Offset: 0x00005968
		public static Collider ResolveShapeToCollider(IntPtr shapePtr)
		{
			IntPtr intPtr = Physics.ResolveShapeToColliderDelegateField(shapePtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00007790 File Offset: 0x00005990
		public static Component ResolveActorToComponent(IntPtr actorPtr)
		{
			IntPtr intPtr = Physics.ResolveActorToComponentDelegateField(actorPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000025F7 File Offset: 0x000007F7
		public static int ResolveShapeToInstanceID(IntPtr shapePtr)
		{
			return Physics.ResolveShapeToInstanceIDDelegateField(shapePtr);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002604 File Offset: 0x00000804
		public static int ResolveActorToInstanceID(IntPtr actorPtr)
		{
			return Physics.ResolveActorToInstanceIDDelegateField(actorPtr);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002611 File Offset: 0x00000811
		public static uint TranslateTriangleIndex(IntPtr shapePtr, uint rawIndex)
		{
			return Physics.TranslateTriangleIndexDelegateField(shapePtr, rawIndex);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000261F File Offset: 0x0000081F
		public static uint TranslateTriangleIndexFromID(int instanceID, uint faceIndex)
		{
			return Physics.TranslateTriangleIndexFromIDDelegateField(instanceID, faceIndex);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000262D File Offset: 0x0000082D
		public static bool IsShapeTrigger(IntPtr shapePtr)
		{
			return Physics.IsShapeTriggerDelegateField(shapePtr);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000077B8 File Offset: 0x000059B8
		public static Vector3 GetActorLinearVelocity(IntPtr actorPtr)
		{
			Vector3 vector;
			Physics.GetActorLinearVelocity_Injected(actorPtr, out vector);
			return vector;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000077D0 File Offset: 0x000059D0
		public static Vector3 GetActorAngularVelocity(IntPtr actorPtr)
		{
			Vector3 vector;
			Physics.GetActorAngularVelocity_Injected(actorPtr, out vector);
			return vector;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000077E8 File Offset: 0x000059E8
		// (set) Token: 0x06000127 RID: 295 RVA: 0x0000263A File Offset: 0x0000083A
		public static float minPenetrationForPenalty
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00007800 File Offset: 0x00005A00
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0000263D File Offset: 0x0000083D
		public static float bounceTreshold
		{
			get
			{
				return Physics.bounceThreshold;
			}
			set
			{
				Physics.bounceThreshold = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00007818 File Offset: 0x00005A18
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002647 File Offset: 0x00000847
		public static float sleepVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00007830 File Offset: 0x00005A30
		// (set) Token: 0x0600012D RID: 301 RVA: 0x0000264A File Offset: 0x0000084A
		public static float sleepAngularVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00007848 File Offset: 0x00005A48
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0000264D File Offset: 0x0000084D
		public static float maxAngularVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00007860 File Offset: 0x00005A60
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00002650 File Offset: 0x00000850
		public static int solverIterationCount
		{
			get
			{
				return Physics.defaultSolverIterations;
			}
			set
			{
				Physics.defaultSolverIterations = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00007878 File Offset: 0x00005A78
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0000265A File Offset: 0x0000085A
		public static int solverVelocityIterationCount
		{
			get
			{
				return Physics.defaultSolverVelocityIterations;
			}
			set
			{
				Physics.defaultSolverVelocityIterations = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00007890 File Offset: 0x00005A90
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002664 File Offset: 0x00000864
		public static float penetrationPenaltyForce
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000078A8 File Offset: 0x00005AA8
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00002667 File Offset: 0x00000867
		public static bool autoSimulation
		{
			get
			{
				return Physics.simulationMode != SimulationMode.Script;
			}
			set
			{
				Physics.simulationMode = (value ? SimulationMode.FixedUpdate : SimulationMode.Script);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002677 File Offset: 0x00000877
		public static void add_ContactEvent(Physics.ContactEventDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002684 File Offset: 0x00000884
		public static void remove_ContactEvent(Physics.ContactEventDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002691 File Offset: 0x00000891
		public static void get_gravity_Injected(out Vector3 ret)
		{
			Physics.get_gravity_InjectedDelegateField(out ret);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000269E File Offset: 0x0000089E
		public static void set_gravity_Injected(ref Vector3 value)
		{
			Physics.set_gravity_InjectedDelegateField(ref value);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000078C8 File Offset: 0x00005AC8
		public static Il2CppStructArray<RaycastHit> Query_CapsuleCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.Query_CapsuleCastAll_InjectedDelegateField(ref physicsScene, ref p0, ref p1, radius, ref direction, maxDistance, mask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000078FC File Offset: 0x00005AFC
		public static Il2CppStructArray<RaycastHit> Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.Query_SphereCastAll_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, maxDistance, mask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000792C File Offset: 0x00005B2C
		public static Il2CppReferenceArray<Collider> OverlapCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.OverlapCapsule_Internal_InjectedDelegateField(ref physicsScene, ref point0, ref point1, radius, layerMask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000795C File Offset: 0x00005B5C
		public static Il2CppReferenceArray<Collider> OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.OverlapSphere_Internal_InjectedDelegateField(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000026AB File Offset: 0x000008AB
		public static void Simulate_Internal_Injected(ref PhysicsScene physicsScene, float step)
		{
			Physics.Simulate_Internal_InjectedDelegateField(ref physicsScene, step);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000026B9 File Offset: 0x000008B9
		public static void InterpolateBodies_Internal_Injected(ref PhysicsScene physicsScene)
		{
			Physics.InterpolateBodies_Internal_InjectedDelegateField(ref physicsScene);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000026C6 File Offset: 0x000008C6
		public static void ResetInterpolationPoses_Internal_Injected(ref PhysicsScene physicsScene)
		{
			Physics.ResetInterpolationPoses_Internal_InjectedDelegateField(ref physicsScene);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00007988 File Offset: 0x00005B88
		public static bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance)
		{
			return Physics.Query_ComputePenetration_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(colliderA), ref positionA, ref rotationA, IL2CPP.Il2CppObjectBaseToPtr(colliderB), ref positionB, ref rotationB, ref direction, ref distance);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000026D3 File Offset: 0x000008D3
		public static void Query_ClosestPoint_Injected(Collider collider, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, out Vector3 ret)
		{
			Physics.Query_ClosestPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref position, ref rotation, ref point, out ret);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000026EA File Offset: 0x000008EA
		public static void get_clothGravity_Injected(out Vector3 ret)
		{
			Physics.get_clothGravity_InjectedDelegateField(out ret);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000026F7 File Offset: 0x000008F7
		public static void set_clothGravity_Injected(ref Vector3 value)
		{
			Physics.set_clothGravity_InjectedDelegateField(ref value);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002704 File Offset: 0x00000904
		public static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckSphere_Internal_InjectedDelegateField(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002716 File Offset: 0x00000916
		public static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckCapsule_Internal_InjectedDelegateField(ref physicsScene, ref start, ref end, radius, layerMask, queryTriggerInteraction);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000272A File Offset: 0x0000092A
		public static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return Physics.CheckBox_Internal_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref orientation, layermask, queryTriggerInteraction);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000079B8 File Offset: 0x00005BB8
		public static Il2CppReferenceArray<Collider> OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.OverlapBox_Internal_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref orientation, layerMask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000079E8 File Offset: 0x00005BE8
		public static Il2CppStructArray<RaycastHit> Internal_BoxCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Physics.Internal_BoxCastAll_InjectedDelegateField(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layerMask, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000273E File Offset: 0x0000093E
		public static void Internal_RebuildBroadphaseRegions_Injected(ref Bounds bounds, int subdivisions)
		{
			Physics.Internal_RebuildBroadphaseRegions_InjectedDelegateField(ref bounds, subdivisions);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000274C File Offset: 0x0000094C
		public static void GetActorLinearVelocity_Injected(IntPtr actorPtr, out Vector3 ret)
		{
			Physics.GetActorLinearVelocity_InjectedDelegateField(actorPtr, out ret);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000275A File Offset: 0x0000095A
		public static void GetActorAngularVelocity_Injected(IntPtr actorPtr, out Vector3 ret)
		{
			Physics.GetActorAngularVelocity_InjectedDelegateField(actorPtr, out ret);
		}

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_ContactModifyEvent;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_ContactModifyEventCCD;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_ContactEvent;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_s_ReusableCollision;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_OnSceneContactModify_Private_Static_Void_PhysicsScene_IntPtr_Int32_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_invokeCollisionCallbacks_Public_Static_get_Boolean_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastAll_Private_Static_Il2CppStructArray_1_RaycastHit_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_get_reuseCollisionCallbacks_Public_Static_get_Boolean_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_GetColliderByInstanceID_Internal_Static_Collider_Int32_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_GetBodyByInstanceID_Internal_Static_Component_Int32_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_SendOnCollisionEnter_Private_Static_Void_Component_Collision_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_SendOnCollisionStay_Private_Static_Void_Component_Collision_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_SendOnCollisionExit_Private_Static_Void_Component_Collision_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_OnSceneContact_Private_Static_Void_PhysicsScene_IntPtr_Int32_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_ReportContacts_Private_Static_Void_ReadOnly_ContactPairHeader_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_GetCollisionToReport_Private_Static_Collision_byref_ContactPairHeader_byref_ContactPair_Boolean_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultPhysicsScene_Injected_Private_Static_Void_byref_PhysicsScene_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_Internal_RaycastAll_Injected_Private_Static_Il2CppStructArray_1_RaycastHit_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0;

		// Token: 0x04000053 RID: 83
		public const float k_MaxFloatMinusEpsilon = 3.4028233E+38f;

		// Token: 0x04000054 RID: 84
		public const int IgnoreRaycastLayer = 4;

		// Token: 0x04000055 RID: 85
		public const int DefaultRaycastLayers = -5;

		// Token: 0x04000056 RID: 86
		public const int AllLayers = -1;

		// Token: 0x04000057 RID: 87
		public const int kIgnoreRaycastLayer = 4;

		// Token: 0x04000058 RID: 88
		public const int kDefaultRaycastLayers = -5;

		// Token: 0x04000059 RID: 89
		public const int kAllLayers = -1;

		// Token: 0x0400005A RID: 90
		private static readonly Physics.get_defaultContactOffsetDelegate get_defaultContactOffsetDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly Physics.set_defaultContactOffsetDelegate set_defaultContactOffsetDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly Physics.get_sleepThresholdDelegate get_sleepThresholdDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly Physics.set_sleepThresholdDelegate set_sleepThresholdDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly Physics.get_queriesHitTriggersDelegate get_queriesHitTriggersDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly Physics.set_queriesHitTriggersDelegate set_queriesHitTriggersDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly Physics.get_queriesHitBackfacesDelegate get_queriesHitBackfacesDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly Physics.set_queriesHitBackfacesDelegate set_queriesHitBackfacesDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly Physics.get_bounceThresholdDelegate get_bounceThresholdDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly Physics.set_bounceThresholdDelegate set_bounceThresholdDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly Physics.get_defaultMaxDepenetrationVelocityDelegate get_defaultMaxDepenetrationVelocityDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly Physics.set_defaultMaxDepenetrationVelocityDelegate set_defaultMaxDepenetrationVelocityDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly Physics.get_defaultSolverIterationsDelegate get_defaultSolverIterationsDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly Physics.set_defaultSolverIterationsDelegate set_defaultSolverIterationsDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly Physics.get_defaultSolverVelocityIterationsDelegate get_defaultSolverVelocityIterationsDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly Physics.set_defaultSolverVelocityIterationsDelegate set_defaultSolverVelocityIterationsDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly Physics.get_simulationModeDelegate get_simulationModeDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly Physics.set_simulationModeDelegate set_simulationModeDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly Physics.get_defaultMaxAngularSpeedDelegate get_defaultMaxAngularSpeedDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly Physics.set_defaultMaxAngularSpeedDelegate set_defaultMaxAngularSpeedDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly Physics.get_improvedPatchFrictionDelegate get_improvedPatchFrictionDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly Physics.set_improvedPatchFrictionDelegate set_improvedPatchFrictionDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly Physics.set_invokeCollisionCallbacksDelegate set_invokeCollisionCallbacksDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly Physics.IgnoreCollisionDelegate IgnoreCollisionDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly Physics.IgnoreLayerCollisionDelegate IgnoreLayerCollisionDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly Physics.GetIgnoreLayerCollisionDelegate GetIgnoreLayerCollisionDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly Physics.GetIgnoreCollisionDelegate GetIgnoreCollisionDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly Physics.SyncTransformsDelegate SyncTransformsDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly Physics.get_autoSyncTransformsDelegate get_autoSyncTransformsDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly Physics.set_autoSyncTransformsDelegate set_autoSyncTransformsDelegateField;

		// Token: 0x04000078 RID: 120
		private static readonly Physics.set_reuseCollisionCallbacksDelegate set_reuseCollisionCallbacksDelegateField;

		// Token: 0x04000079 RID: 121
		private static readonly Physics.get_interCollisionDistanceDelegate get_interCollisionDistanceDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly Physics.set_interCollisionDistanceDelegate set_interCollisionDistanceDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly Physics.get_interCollisionStiffnessDelegate get_interCollisionStiffnessDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly Physics.set_interCollisionStiffnessDelegate set_interCollisionStiffnessDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly Physics.get_interCollisionSettingsToggleDelegate get_interCollisionSettingsToggleDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly Physics.set_interCollisionSettingsToggleDelegate set_interCollisionSettingsToggleDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly Physics.BakeMeshDelegate BakeMeshDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly Physics.ResolveShapeToColliderDelegate ResolveShapeToColliderDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly Physics.ResolveActorToComponentDelegate ResolveActorToComponentDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly Physics.ResolveShapeToInstanceIDDelegate ResolveShapeToInstanceIDDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly Physics.ResolveActorToInstanceIDDelegate ResolveActorToInstanceIDDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly Physics.TranslateTriangleIndexDelegate TranslateTriangleIndexDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly Physics.TranslateTriangleIndexFromIDDelegate TranslateTriangleIndexFromIDDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly Physics.IsShapeTriggerDelegate IsShapeTriggerDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly Physics.get_gravity_InjectedDelegate get_gravity_InjectedDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly Physics.set_gravity_InjectedDelegate set_gravity_InjectedDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly Physics.Query_CapsuleCastAll_InjectedDelegate Query_CapsuleCastAll_InjectedDelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly Physics.Query_SphereCastAll_InjectedDelegate Query_SphereCastAll_InjectedDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly Physics.OverlapCapsule_Internal_InjectedDelegate OverlapCapsule_Internal_InjectedDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly Physics.OverlapSphere_Internal_InjectedDelegate OverlapSphere_Internal_InjectedDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly Physics.Simulate_Internal_InjectedDelegate Simulate_Internal_InjectedDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly Physics.InterpolateBodies_Internal_InjectedDelegate InterpolateBodies_Internal_InjectedDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly Physics.ResetInterpolationPoses_Internal_InjectedDelegate ResetInterpolationPoses_Internal_InjectedDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly Physics.Query_ComputePenetration_InjectedDelegate Query_ComputePenetration_InjectedDelegateField;

		// Token: 0x04000091 RID: 145
		private static readonly Physics.Query_ClosestPoint_InjectedDelegate Query_ClosestPoint_InjectedDelegateField;

		// Token: 0x04000092 RID: 146
		private static readonly Physics.get_clothGravity_InjectedDelegate get_clothGravity_InjectedDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly Physics.set_clothGravity_InjectedDelegate set_clothGravity_InjectedDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly Physics.CheckSphere_Internal_InjectedDelegate CheckSphere_Internal_InjectedDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly Physics.CheckCapsule_Internal_InjectedDelegate CheckCapsule_Internal_InjectedDelegateField;

		// Token: 0x04000096 RID: 150
		private static readonly Physics.CheckBox_Internal_InjectedDelegate CheckBox_Internal_InjectedDelegateField;

		// Token: 0x04000097 RID: 151
		private static readonly Physics.OverlapBox_Internal_InjectedDelegate OverlapBox_Internal_InjectedDelegateField;

		// Token: 0x04000098 RID: 152
		private static readonly Physics.Internal_BoxCastAll_InjectedDelegate Internal_BoxCastAll_InjectedDelegateField;

		// Token: 0x04000099 RID: 153
		private static readonly Physics.Internal_RebuildBroadphaseRegions_InjectedDelegate Internal_RebuildBroadphaseRegions_InjectedDelegateField;

		// Token: 0x0400009A RID: 154
		private static readonly Physics.GetActorLinearVelocity_InjectedDelegate GetActorLinearVelocity_InjectedDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly Physics.GetActorAngularVelocity_InjectedDelegate GetActorAngularVelocity_InjectedDelegateField;

		// Token: 0x02000032 RID: 50
		public sealed class ContactEventDelegate : MulticastDelegate
		{
			// Token: 0x06000436 RID: 1078 RVA: 0x00004845 File Offset: 0x00002A45
			// Note: this type is marked as 'beforefieldinit'.
			static ContactEventDelegate()
			{
				Il2CppClassPointerStore<Physics.ContactEventDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Physics>.NativeClassPtr, "ContactEventDelegate");
				Physics.ContactEventDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics.ContactEventDelegate>.NativeClassPtr, 100663349);
				Physics.ContactEventDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhysicsScene_ReadOnly_ContactPairHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics.ContactEventDelegate>.NativeClassPtr, 100663350);
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x0000C790 File Offset: 0x0000A990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254600, XrefRangeEnd = 1254603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContactEventDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Physics.ContactEventDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.ContactEventDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x0000C7EC File Offset: 0x0000A9EC
			[CallerCount(0)]
			public unsafe void Invoke(PhysicsScene scene, NativeArray<ContactPairHeader>.ReadOnly headerArray)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref scene;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(headerArray));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics.ContactEventDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhysicsScene_ReadOnly_ContactPairHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x00004883 File Offset: 0x00002A83
			public ContactEventDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600043A RID: 1082 RVA: 0x0000488C File Offset: 0x00002A8C
			public static implicit operator Physics.ContactEventDelegate(Action<PhysicsScene, NativeArray<ContactPairHeader>.ReadOnly> A_0)
			{
				return DelegateSupport.ConvertDelegate<Physics.ContactEventDelegate>(A_0);
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x00004894 File Offset: 0x00002A94
			public static Physics.ContactEventDelegate operator +(Physics.ContactEventDelegate A_0, Physics.ContactEventDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Physics.ContactEventDelegate>();
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x000048A2 File Offset: 0x00002AA2
			public static Physics.ContactEventDelegate operator -(Physics.ContactEventDelegate A_0, Physics.ContactEventDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Physics.ContactEventDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04000315 RID: 789
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000316 RID: 790
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhysicsScene_ReadOnly_ContactPairHeader_0;
		}

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x0600043E RID: 1086
		private delegate float get_defaultContactOffsetDelegate();

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000440 RID: 1088
		private delegate void set_defaultContactOffsetDelegate(float value);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000442 RID: 1090
		private delegate float get_sleepThresholdDelegate();

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000444 RID: 1092
		private delegate void set_sleepThresholdDelegate(float value);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000446 RID: 1094
		private delegate bool get_queriesHitTriggersDelegate();

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000448 RID: 1096
		private delegate void set_queriesHitTriggersDelegate(bool value);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x0600044A RID: 1098
		private delegate bool get_queriesHitBackfacesDelegate();

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x0600044C RID: 1100
		private delegate void set_queriesHitBackfacesDelegate(bool value);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x0600044E RID: 1102
		private delegate float get_bounceThresholdDelegate();

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000450 RID: 1104
		private delegate void set_bounceThresholdDelegate(float value);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000452 RID: 1106
		private delegate float get_defaultMaxDepenetrationVelocityDelegate();

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000454 RID: 1108
		private delegate void set_defaultMaxDepenetrationVelocityDelegate(float value);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x06000456 RID: 1110
		private delegate int get_defaultSolverIterationsDelegate();

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x06000458 RID: 1112
		private delegate void set_defaultSolverIterationsDelegate(int value);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x0600045A RID: 1114
		private delegate int get_defaultSolverVelocityIterationsDelegate();

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x0600045C RID: 1116
		private delegate void set_defaultSolverVelocityIterationsDelegate(int value);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x0600045E RID: 1118
		private delegate SimulationMode get_simulationModeDelegate();

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000460 RID: 1120
		private delegate void set_simulationModeDelegate(SimulationMode value);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000462 RID: 1122
		private delegate float get_defaultMaxAngularSpeedDelegate();

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000464 RID: 1124
		private delegate void set_defaultMaxAngularSpeedDelegate(float value);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000466 RID: 1126
		private delegate bool get_improvedPatchFrictionDelegate();

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000468 RID: 1128
		private delegate void set_improvedPatchFrictionDelegate(bool value);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x0600046A RID: 1130
		private delegate void set_invokeCollisionCallbacksDelegate(bool value);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x0600046C RID: 1132
		private delegate void IgnoreCollisionDelegate(IntPtr collider1, IntPtr collider2, bool ignore);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600046E RID: 1134
		private delegate void IgnoreLayerCollisionDelegate(int layer1, int layer2, bool ignore);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000470 RID: 1136
		private delegate bool GetIgnoreLayerCollisionDelegate(int layer1, int layer2);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000472 RID: 1138
		private delegate bool GetIgnoreCollisionDelegate(IntPtr collider1, IntPtr collider2);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000474 RID: 1140
		private delegate void SyncTransformsDelegate();

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x06000476 RID: 1142
		private delegate bool get_autoSyncTransformsDelegate();

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x06000478 RID: 1144
		private delegate void set_autoSyncTransformsDelegate(bool value);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x0600047A RID: 1146
		private delegate void set_reuseCollisionCallbacksDelegate(bool value);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x0600047C RID: 1148
		private delegate float get_interCollisionDistanceDelegate();

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x0600047E RID: 1150
		private delegate void set_interCollisionDistanceDelegate(float value);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000480 RID: 1152
		private delegate float get_interCollisionStiffnessDelegate();

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000482 RID: 1154
		private delegate void set_interCollisionStiffnessDelegate(float value);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000484 RID: 1156
		private delegate bool get_interCollisionSettingsToggleDelegate();

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000486 RID: 1158
		private delegate void set_interCollisionSettingsToggleDelegate(bool value);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x06000488 RID: 1160
		private delegate void BakeMeshDelegate(int meshID, bool convex, MeshColliderCookingOptions cookingOptions);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600048A RID: 1162
		private delegate IntPtr ResolveShapeToColliderDelegate(IntPtr shapePtr);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x0600048C RID: 1164
		private delegate IntPtr ResolveActorToComponentDelegate(IntPtr actorPtr);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x0600048E RID: 1166
		private delegate int ResolveShapeToInstanceIDDelegate(IntPtr shapePtr);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000490 RID: 1168
		private delegate int ResolveActorToInstanceIDDelegate(IntPtr actorPtr);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000492 RID: 1170
		private delegate uint TranslateTriangleIndexDelegate(IntPtr shapePtr, uint rawIndex);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000494 RID: 1172
		private delegate uint TranslateTriangleIndexFromIDDelegate(int instanceID, uint faceIndex);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000496 RID: 1174
		private delegate bool IsShapeTriggerDelegate(IntPtr shapePtr);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x06000498 RID: 1176
		private delegate void get_gravity_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600049A RID: 1178
		private delegate void set_gravity_InjectedDelegate(IntPtr value);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600049C RID: 1180
		private delegate IntPtr Query_CapsuleCastAll_InjectedDelegate(IntPtr physicsScene, IntPtr p0, IntPtr p1, float radius, IntPtr direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x0600049E RID: 1182
		private delegate IntPtr Query_SphereCastAll_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060004A0 RID: 1184
		private delegate IntPtr OverlapCapsule_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point0, IntPtr point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060004A2 RID: 1186
		private delegate IntPtr OverlapSphere_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060004A4 RID: 1188
		private delegate void Simulate_Internal_InjectedDelegate(IntPtr physicsScene, float step);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060004A6 RID: 1190
		private delegate void InterpolateBodies_Internal_InjectedDelegate(IntPtr physicsScene);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060004A8 RID: 1192
		private delegate void ResetInterpolationPoses_Internal_InjectedDelegate(IntPtr physicsScene);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060004AA RID: 1194
		private delegate bool Query_ComputePenetration_InjectedDelegate(IntPtr colliderA, IntPtr positionA, IntPtr rotationA, IntPtr colliderB, IntPtr positionB, IntPtr rotationB, IntPtr direction, IntPtr distance);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060004AC RID: 1196
		private delegate void Query_ClosestPoint_InjectedDelegate(IntPtr collider, IntPtr position, IntPtr rotation, IntPtr point, [Out] IntPtr ret);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060004AE RID: 1198
		private delegate void get_clothGravity_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060004B0 RID: 1200
		private delegate void set_clothGravity_InjectedDelegate(IntPtr value);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060004B2 RID: 1202
		private delegate bool CheckSphere_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060004B4 RID: 1204
		private delegate bool CheckCapsule_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr start, IntPtr end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060004B6 RID: 1206
		private delegate bool CheckBox_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060004B8 RID: 1208
		private delegate IntPtr OverlapBox_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060004BA RID: 1210
		private delegate IntPtr Internal_BoxCastAll_InjectedDelegate(IntPtr physicsScene, IntPtr center, IntPtr halfExtents, IntPtr direction, IntPtr orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060004BC RID: 1212
		private delegate void Internal_RebuildBroadphaseRegions_InjectedDelegate(IntPtr bounds, int subdivisions);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060004BE RID: 1214
		private delegate void GetActorLinearVelocity_InjectedDelegate(IntPtr actorPtr, [Out] IntPtr ret);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060004C0 RID: 1216
		private delegate void GetActorAngularVelocity_InjectedDelegate(IntPtr actorPtr, [Out] IntPtr ret);
	}
}
