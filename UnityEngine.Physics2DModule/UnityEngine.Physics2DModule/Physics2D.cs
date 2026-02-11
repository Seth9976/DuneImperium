using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public class Physics2D : Object
	{
		// Token: 0x0600008A RID: 138 RVA: 0x000063FC File Offset: 0x000045FC
		// Note: this type is marked as 'beforefieldinit'.
		static Physics2D()
		{
			Il2CppClassPointerStore<Physics2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Physics2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Physics2D>.NativeClassPtr);
			Physics2D.NativeFieldInfoPtr_m_LastDisabledRigidbody2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, "m_LastDisabledRigidbody2D");
			Physics2D.NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663314);
			Physics2D.NativeMethodInfoPtr_get_queriesHitTriggers_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663315);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663316);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663317);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663318);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663319);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663320);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663321);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663322);
			Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_List_1_RaycastHit2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663323);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663324);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663325);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663326);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Private_Static_Il2CppStructArray_1_RaycastHit2D_PhysicsScene2D_Vector3_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663327);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663328);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663329);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663330);
			Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Injected_Private_Static_Il2CppStructArray_1_RaycastHit2D_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663332);
			Physics2D.get_velocityIterationsDelegateField = IL2CPP.ResolveICall<Physics2D.get_velocityIterationsDelegate>("UnityEngine.Physics2D::get_velocityIterations");
			Physics2D.set_velocityIterationsDelegateField = IL2CPP.ResolveICall<Physics2D.set_velocityIterationsDelegate>("UnityEngine.Physics2D::set_velocityIterations");
			Physics2D.get_positionIterationsDelegateField = IL2CPP.ResolveICall<Physics2D.get_positionIterationsDelegate>("UnityEngine.Physics2D::get_positionIterations");
			Physics2D.set_positionIterationsDelegateField = IL2CPP.ResolveICall<Physics2D.set_positionIterationsDelegate>("UnityEngine.Physics2D::set_positionIterations");
			Physics2D.set_queriesHitTriggersDelegateField = IL2CPP.ResolveICall<Physics2D.set_queriesHitTriggersDelegate>("UnityEngine.Physics2D::set_queriesHitTriggers");
			Physics2D.get_queriesStartInCollidersDelegateField = IL2CPP.ResolveICall<Physics2D.get_queriesStartInCollidersDelegate>("UnityEngine.Physics2D::get_queriesStartInColliders");
			Physics2D.set_queriesStartInCollidersDelegateField = IL2CPP.ResolveICall<Physics2D.set_queriesStartInCollidersDelegate>("UnityEngine.Physics2D::set_queriesStartInColliders");
			Physics2D.get_callbacksOnDisableDelegateField = IL2CPP.ResolveICall<Physics2D.get_callbacksOnDisableDelegate>("UnityEngine.Physics2D::get_callbacksOnDisable");
			Physics2D.set_callbacksOnDisableDelegateField = IL2CPP.ResolveICall<Physics2D.set_callbacksOnDisableDelegate>("UnityEngine.Physics2D::set_callbacksOnDisable");
			Physics2D.get_reuseCollisionCallbacksDelegateField = IL2CPP.ResolveICall<Physics2D.get_reuseCollisionCallbacksDelegate>("UnityEngine.Physics2D::get_reuseCollisionCallbacks");
			Physics2D.set_reuseCollisionCallbacksDelegateField = IL2CPP.ResolveICall<Physics2D.set_reuseCollisionCallbacksDelegate>("UnityEngine.Physics2D::set_reuseCollisionCallbacks");
			Physics2D.get_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<Physics2D.get_autoSyncTransformsDelegate>("UnityEngine.Physics2D::get_autoSyncTransforms");
			Physics2D.set_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<Physics2D.set_autoSyncTransformsDelegate>("UnityEngine.Physics2D::set_autoSyncTransforms");
			Physics2D.get_simulationModeDelegateField = IL2CPP.ResolveICall<Physics2D.get_simulationModeDelegate>("UnityEngine.Physics2D::get_simulationMode");
			Physics2D.set_simulationModeDelegateField = IL2CPP.ResolveICall<Physics2D.set_simulationModeDelegate>("UnityEngine.Physics2D::set_simulationMode");
			Physics2D.get_velocityThresholdDelegateField = IL2CPP.ResolveICall<Physics2D.get_velocityThresholdDelegate>("UnityEngine.Physics2D::get_velocityThreshold");
			Physics2D.set_velocityThresholdDelegateField = IL2CPP.ResolveICall<Physics2D.set_velocityThresholdDelegate>("UnityEngine.Physics2D::set_velocityThreshold");
			Physics2D.get_maxLinearCorrectionDelegateField = IL2CPP.ResolveICall<Physics2D.get_maxLinearCorrectionDelegate>("UnityEngine.Physics2D::get_maxLinearCorrection");
			Physics2D.set_maxLinearCorrectionDelegateField = IL2CPP.ResolveICall<Physics2D.set_maxLinearCorrectionDelegate>("UnityEngine.Physics2D::set_maxLinearCorrection");
			Physics2D.get_maxAngularCorrectionDelegateField = IL2CPP.ResolveICall<Physics2D.get_maxAngularCorrectionDelegate>("UnityEngine.Physics2D::get_maxAngularCorrection");
			Physics2D.set_maxAngularCorrectionDelegateField = IL2CPP.ResolveICall<Physics2D.set_maxAngularCorrectionDelegate>("UnityEngine.Physics2D::set_maxAngularCorrection");
			Physics2D.get_maxTranslationSpeedDelegateField = IL2CPP.ResolveICall<Physics2D.get_maxTranslationSpeedDelegate>("UnityEngine.Physics2D::get_maxTranslationSpeed");
			Physics2D.set_maxTranslationSpeedDelegateField = IL2CPP.ResolveICall<Physics2D.set_maxTranslationSpeedDelegate>("UnityEngine.Physics2D::set_maxTranslationSpeed");
			Physics2D.get_maxRotationSpeedDelegateField = IL2CPP.ResolveICall<Physics2D.get_maxRotationSpeedDelegate>("UnityEngine.Physics2D::get_maxRotationSpeed");
			Physics2D.set_maxRotationSpeedDelegateField = IL2CPP.ResolveICall<Physics2D.set_maxRotationSpeedDelegate>("UnityEngine.Physics2D::set_maxRotationSpeed");
			Physics2D.get_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<Physics2D.get_defaultContactOffsetDelegate>("UnityEngine.Physics2D::get_defaultContactOffset");
			Physics2D.set_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<Physics2D.set_defaultContactOffsetDelegate>("UnityEngine.Physics2D::set_defaultContactOffset");
			Physics2D.get_baumgarteScaleDelegateField = IL2CPP.ResolveICall<Physics2D.get_baumgarteScaleDelegate>("UnityEngine.Physics2D::get_baumgarteScale");
			Physics2D.set_baumgarteScaleDelegateField = IL2CPP.ResolveICall<Physics2D.set_baumgarteScaleDelegate>("UnityEngine.Physics2D::set_baumgarteScale");
			Physics2D.get_baumgarteTOIScaleDelegateField = IL2CPP.ResolveICall<Physics2D.get_baumgarteTOIScaleDelegate>("UnityEngine.Physics2D::get_baumgarteTOIScale");
			Physics2D.set_baumgarteTOIScaleDelegateField = IL2CPP.ResolveICall<Physics2D.set_baumgarteTOIScaleDelegate>("UnityEngine.Physics2D::set_baumgarteTOIScale");
			Physics2D.get_timeToSleepDelegateField = IL2CPP.ResolveICall<Physics2D.get_timeToSleepDelegate>("UnityEngine.Physics2D::get_timeToSleep");
			Physics2D.set_timeToSleepDelegateField = IL2CPP.ResolveICall<Physics2D.set_timeToSleepDelegate>("UnityEngine.Physics2D::set_timeToSleep");
			Physics2D.get_linearSleepToleranceDelegateField = IL2CPP.ResolveICall<Physics2D.get_linearSleepToleranceDelegate>("UnityEngine.Physics2D::get_linearSleepTolerance");
			Physics2D.set_linearSleepToleranceDelegateField = IL2CPP.ResolveICall<Physics2D.set_linearSleepToleranceDelegate>("UnityEngine.Physics2D::set_linearSleepTolerance");
			Physics2D.get_angularSleepToleranceDelegateField = IL2CPP.ResolveICall<Physics2D.get_angularSleepToleranceDelegate>("UnityEngine.Physics2D::get_angularSleepTolerance");
			Physics2D.set_angularSleepToleranceDelegateField = IL2CPP.ResolveICall<Physics2D.set_angularSleepToleranceDelegate>("UnityEngine.Physics2D::set_angularSleepTolerance");
			Physics2D.SyncTransformsDelegateField = IL2CPP.ResolveICall<Physics2D.SyncTransformsDelegate>("UnityEngine.Physics2D::SyncTransforms");
			Physics2D.IgnoreCollisionDelegateField = IL2CPP.ResolveICall<Physics2D.IgnoreCollisionDelegate>("UnityEngine.Physics2D::IgnoreCollision");
			Physics2D.GetIgnoreCollisionDelegateField = IL2CPP.ResolveICall<Physics2D.GetIgnoreCollisionDelegate>("UnityEngine.Physics2D::GetIgnoreCollision");
			Physics2D.IgnoreLayerCollision_InternalDelegateField = IL2CPP.ResolveICall<Physics2D.IgnoreLayerCollision_InternalDelegate>("UnityEngine.Physics2D::IgnoreLayerCollision_Internal");
			Physics2D.GetIgnoreLayerCollision_InternalDelegateField = IL2CPP.ResolveICall<Physics2D.GetIgnoreLayerCollision_InternalDelegate>("UnityEngine.Physics2D::GetIgnoreLayerCollision_Internal");
			Physics2D.SetLayerCollisionMask_InternalDelegateField = IL2CPP.ResolveICall<Physics2D.SetLayerCollisionMask_InternalDelegate>("UnityEngine.Physics2D::SetLayerCollisionMask_Internal");
			Physics2D.GetLayerCollisionMask_InternalDelegateField = IL2CPP.ResolveICall<Physics2D.GetLayerCollisionMask_InternalDelegate>("UnityEngine.Physics2D::GetLayerCollisionMask_Internal");
			Physics2D.IsTouchingDelegateField = IL2CPP.ResolveICall<Physics2D.IsTouchingDelegate>("UnityEngine.Physics2D::IsTouching");
			Physics2D.IsTouchingLayersDelegateField = IL2CPP.ResolveICall<Physics2D.IsTouchingLayersDelegate>("UnityEngine.Physics2D::IsTouchingLayers");
			Physics2D.get_gravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.get_gravity_InjectedDelegate>("UnityEngine.Physics2D::get_gravity_Injected");
			Physics2D.set_gravity_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.set_gravity_InjectedDelegate>("UnityEngine.Physics2D::set_gravity_Injected");
			Physics2D.Simulate_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.Simulate_Internal_InjectedDelegate>("UnityEngine.Physics2D::Simulate_Internal_Injected");
			Physics2D.IsTouching_TwoCollidersWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.IsTouching_TwoCollidersWithFilter_InjectedDelegate>("UnityEngine.Physics2D::IsTouching_TwoCollidersWithFilter_Injected");
			Physics2D.IsTouching_SingleColliderWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.IsTouching_SingleColliderWithFilter_InjectedDelegate>("UnityEngine.Physics2D::IsTouching_SingleColliderWithFilter_Injected");
			Physics2D.ClosestPoint_Collider_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.ClosestPoint_Collider_InjectedDelegate>("UnityEngine.Physics2D::ClosestPoint_Collider_Injected");
			Physics2D.ClosestPoint_Rigidbody_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.ClosestPoint_Rigidbody_InjectedDelegate>("UnityEngine.Physics2D::ClosestPoint_Rigidbody_Injected");
			Physics2D.LinecastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.LinecastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::LinecastAll_Internal_Injected");
			Physics2D.RaycastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.RaycastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::RaycastAll_Internal_Injected");
			Physics2D.CircleCastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.CircleCastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::CircleCastAll_Internal_Injected");
			Physics2D.BoxCastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.BoxCastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::BoxCastAll_Internal_Injected");
			Physics2D.CapsuleCastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.CapsuleCastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::CapsuleCastAll_Internal_Injected");
			Physics2D.OverlapPointAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.OverlapPointAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::OverlapPointAll_Internal_Injected");
			Physics2D.OverlapCircleAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.OverlapCircleAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::OverlapCircleAll_Internal_Injected");
			Physics2D.OverlapBoxAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.OverlapBoxAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::OverlapBoxAll_Internal_Injected");
			Physics2D.OverlapCapsuleAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.OverlapCapsuleAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::OverlapCapsuleAll_Internal_Injected");
			Physics2D.GetColliderContactsArray_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetColliderContactsArray_InjectedDelegate>("UnityEngine.Physics2D::GetColliderContactsArray_Injected");
			Physics2D.GetColliderColliderContactsArray_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetColliderColliderContactsArray_InjectedDelegate>("UnityEngine.Physics2D::GetColliderColliderContactsArray_Injected");
			Physics2D.GetRigidbodyContactsArray_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetRigidbodyContactsArray_InjectedDelegate>("UnityEngine.Physics2D::GetRigidbodyContactsArray_Injected");
			Physics2D.GetColliderContactsCollidersOnlyArray_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetColliderContactsCollidersOnlyArray_InjectedDelegate>("UnityEngine.Physics2D::GetColliderContactsCollidersOnlyArray_Injected");
			Physics2D.GetRigidbodyContactsCollidersOnlyArray_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetRigidbodyContactsCollidersOnlyArray_InjectedDelegate>("UnityEngine.Physics2D::GetRigidbodyContactsCollidersOnlyArray_Injected");
			Physics2D.GetColliderContactsList_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetColliderContactsList_InjectedDelegate>("UnityEngine.Physics2D::GetColliderContactsList_Injected");
			Physics2D.GetColliderColliderContactsList_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetColliderColliderContactsList_InjectedDelegate>("UnityEngine.Physics2D::GetColliderColliderContactsList_Injected");
			Physics2D.GetRigidbodyContactsList_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetRigidbodyContactsList_InjectedDelegate>("UnityEngine.Physics2D::GetRigidbodyContactsList_Injected");
			Physics2D.GetColliderContactsCollidersOnlyList_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetColliderContactsCollidersOnlyList_InjectedDelegate>("UnityEngine.Physics2D::GetColliderContactsCollidersOnlyList_Injected");
			Physics2D.GetRigidbodyContactsCollidersOnlyList_InjectedDelegateField = IL2CPP.ResolveICall<Physics2D.GetRigidbodyContactsCollidersOnlyList_InjectedDelegate>("UnityEngine.Physics2D::GetRigidbodyContactsCollidersOnlyList_Injected");
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000069E0 File Offset: 0x00004BE0
		public unsafe static PhysicsScene2D defaultPhysicsScene
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 320672, RefRangeEnd = 320673, XrefRangeStart = 320672, XrefRangeEnd = 320673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00006A10 File Offset: 0x00004C10
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000023F2 File Offset: 0x000005F2
		public unsafe static bool queriesHitTriggers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268297, XrefRangeEnd = 1268299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_get_queriesHitTriggers_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Physics2D.set_queriesHitTriggersDelegateField(value);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00006A40 File Offset: 0x00004C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268299, XrefRangeEnd = 1268305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00006A8C File Offset: 0x00004C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268305, XrefRangeEnd = 1268309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00006AE8 File Offset: 0x00004CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268309, XrefRangeEnd = 1268315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00006B50 File Offset: 0x00004D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268315, XrefRangeEnd = 1268321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00006BC8 File Offset: 0x00004DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268321, XrefRangeEnd = 1268327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDepth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00006C4C File Offset: 0x00004E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268327, XrefRangeEnd = 1268332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00006CB8 File Offset: 0x00004EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268332, XrefRangeEnd = 1268337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00006D34 File Offset: 0x00004F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268337, XrefRangeEnd = 1268342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = float.PositiveInfinity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contactFilter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_List_1_RaycastHit2D_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268342, XrefRangeEnd = 1268350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll(Ray ray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00006DF0 File Offset: 0x00004FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268350, XrefRangeEnd = 1268358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll(Ray ray, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00006E40 File Offset: 0x00005040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268358, XrefRangeEnd = 1268366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll(Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00006E9C File Offset: 0x0000509C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268366, XrefRangeEnd = 1268371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Private_Static_Il2CppStructArray_1_RaycastHit2D_PhysicsScene2D_Vector3_Vector3_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00006F14 File Offset: 0x00005114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268371, XrefRangeEnd = 1268376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRayIntersectionNonAlloc(Ray ray, Il2CppStructArray<RaycastHit2D> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00006F64 File Offset: 0x00005164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268376, XrefRangeEnd = 1268381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRayIntersectionNonAlloc(Ray ray, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00006FC4 File Offset: 0x000051C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268381, XrefRangeEnd = 1268386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRayIntersectionNonAlloc(Ray ray, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00007030 File Offset: 0x00005230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268386, XrefRangeEnd = 1268388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &physicsScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2D.NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Injected_Private_Static_Il2CppStructArray_1_RaycastHit2D_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000239C File Offset: 0x0000059C
		public Physics2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000070A8 File Offset: 0x000052A8
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000023A5 File Offset: 0x000005A5
		public unsafe static List<Rigidbody2D> m_LastDisabledRigidbody2D
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Physics2D.NativeFieldInfoPtr_m_LastDisabledRigidbody2D, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Rigidbody2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Physics2D.NativeFieldInfoPtr_m_LastDisabledRigidbody2D, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000023B7 File Offset: 0x000005B7
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000023C3 File Offset: 0x000005C3
		public static int velocityIterations
		{
			get
			{
				return Physics2D.get_velocityIterationsDelegateField();
			}
			set
			{
				Physics2D.set_velocityIterationsDelegateField(value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000023D0 File Offset: 0x000005D0
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000023DC File Offset: 0x000005DC
		public static int positionIterations
		{
			get
			{
				return Physics2D.get_positionIterationsDelegateField();
			}
			set
			{
				Physics2D.set_positionIterationsDelegateField(value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000070D0 File Offset: 0x000052D0
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000023E9 File Offset: 0x000005E9
		public static Vector2 gravity
		{
			get
			{
				Vector2 vector;
				Physics2D.get_gravity_Injected(out vector);
				return vector;
			}
			set
			{
				Physics2D.set_gravity_Injected(ref value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000023FF File Offset: 0x000005FF
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000240B File Offset: 0x0000060B
		public static bool queriesStartInColliders
		{
			get
			{
				return Physics2D.get_queriesStartInCollidersDelegateField();
			}
			set
			{
				Physics2D.set_queriesStartInCollidersDelegateField(value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002418 File Offset: 0x00000618
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002424 File Offset: 0x00000624
		public static bool callbacksOnDisable
		{
			get
			{
				return Physics2D.get_callbacksOnDisableDelegateField();
			}
			set
			{
				Physics2D.set_callbacksOnDisableDelegateField(value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00002431 File Offset: 0x00000631
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000243D File Offset: 0x0000063D
		public static bool reuseCollisionCallbacks
		{
			get
			{
				return Physics2D.get_reuseCollisionCallbacksDelegateField();
			}
			set
			{
				Physics2D.set_reuseCollisionCallbacksDelegateField(value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000244A File Offset: 0x0000064A
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002456 File Offset: 0x00000656
		public static bool autoSyncTransforms
		{
			get
			{
				return Physics2D.get_autoSyncTransformsDelegateField();
			}
			set
			{
				Physics2D.set_autoSyncTransformsDelegateField(value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002463 File Offset: 0x00000663
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000246F File Offset: 0x0000066F
		public static SimulationMode2D simulationMode
		{
			get
			{
				return Physics2D.get_simulationModeDelegateField();
			}
			set
			{
				Physics2D.set_simulationModeDelegateField(value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000247C File Offset: 0x0000067C
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002488 File Offset: 0x00000688
		public static float velocityThreshold
		{
			get
			{
				return Physics2D.get_velocityThresholdDelegateField();
			}
			set
			{
				Physics2D.set_velocityThresholdDelegateField(value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002495 File Offset: 0x00000695
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x000024A1 File Offset: 0x000006A1
		public static float maxLinearCorrection
		{
			get
			{
				return Physics2D.get_maxLinearCorrectionDelegateField();
			}
			set
			{
				Physics2D.set_maxLinearCorrectionDelegateField(value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000024AE File Offset: 0x000006AE
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000024BA File Offset: 0x000006BA
		public static float maxAngularCorrection
		{
			get
			{
				return Physics2D.get_maxAngularCorrectionDelegateField();
			}
			set
			{
				Physics2D.set_maxAngularCorrectionDelegateField(value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000024C7 File Offset: 0x000006C7
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000024D3 File Offset: 0x000006D3
		public static float maxTranslationSpeed
		{
			get
			{
				return Physics2D.get_maxTranslationSpeedDelegateField();
			}
			set
			{
				Physics2D.set_maxTranslationSpeedDelegateField(value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000024E0 File Offset: 0x000006E0
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000024EC File Offset: 0x000006EC
		public static float maxRotationSpeed
		{
			get
			{
				return Physics2D.get_maxRotationSpeedDelegateField();
			}
			set
			{
				Physics2D.set_maxRotationSpeedDelegateField(value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000024F9 File Offset: 0x000006F9
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002505 File Offset: 0x00000705
		public static float defaultContactOffset
		{
			get
			{
				return Physics2D.get_defaultContactOffsetDelegateField();
			}
			set
			{
				Physics2D.set_defaultContactOffsetDelegateField(value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002512 File Offset: 0x00000712
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000251E File Offset: 0x0000071E
		public static float baumgarteScale
		{
			get
			{
				return Physics2D.get_baumgarteScaleDelegateField();
			}
			set
			{
				Physics2D.set_baumgarteScaleDelegateField(value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000252B File Offset: 0x0000072B
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002537 File Offset: 0x00000737
		public static float baumgarteTOIScale
		{
			get
			{
				return Physics2D.get_baumgarteTOIScaleDelegateField();
			}
			set
			{
				Physics2D.set_baumgarteTOIScaleDelegateField(value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002544 File Offset: 0x00000744
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002550 File Offset: 0x00000750
		public static float timeToSleep
		{
			get
			{
				return Physics2D.get_timeToSleepDelegateField();
			}
			set
			{
				Physics2D.set_timeToSleepDelegateField(value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000255D File Offset: 0x0000075D
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002569 File Offset: 0x00000769
		public static float linearSleepTolerance
		{
			get
			{
				return Physics2D.get_linearSleepToleranceDelegateField();
			}
			set
			{
				Physics2D.set_linearSleepToleranceDelegateField(value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002576 File Offset: 0x00000776
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002582 File Offset: 0x00000782
		public static float angularSleepTolerance
		{
			get
			{
				return Physics2D.get_angularSleepToleranceDelegateField();
			}
			set
			{
				Physics2D.set_angularSleepToleranceDelegateField(value);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000070E8 File Offset: 0x000052E8
		public static bool Simulate(float step)
		{
			return Physics2D.Simulate_Internal(Physics2D.defaultPhysicsScene, step);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000258F File Offset: 0x0000078F
		public static bool Simulate_Internal(PhysicsScene2D physicsScene, float step)
		{
			return Physics2D.Simulate_Internal_Injected(ref physicsScene, step);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002599 File Offset: 0x00000799
		public static void SyncTransforms()
		{
			Physics2D.SyncTransformsDelegateField();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000025A5 File Offset: 0x000007A5
		public static void IgnoreCollision(Collider2D collider1, Collider2D collider2)
		{
			Physics2D.IgnoreCollision(collider1, collider2, true);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000025B1 File Offset: 0x000007B1
		public static void IgnoreCollision(Collider2D collider1, Collider2D collider2, bool ignore)
		{
			Physics2D.IgnoreCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2), ignore);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000025CA File Offset: 0x000007CA
		public static bool GetIgnoreCollision(Collider2D collider1, Collider2D collider2)
		{
			return Physics2D.GetIgnoreCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2));
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000025E2 File Offset: 0x000007E2
		public static void IgnoreLayerCollision(int layer1, int layer2)
		{
			Physics2D.IgnoreLayerCollision(layer1, layer2, true);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00007108 File Offset: 0x00005308
		public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore)
		{
			bool flag = layer1 < 0 || layer1 > 31;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
			}
			bool flag2 = layer2 < 0 || layer2 > 31;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("layer2 is out of range. Layer numbers must be in the range 0 to 31.");
			}
			Physics2D.IgnoreLayerCollision_Internal(layer1, layer2, ignore);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000025EE File Offset: 0x000007EE
		public static void IgnoreLayerCollision_Internal(int layer1, int layer2, bool ignore)
		{
			Physics2D.IgnoreLayerCollision_InternalDelegateField(layer1, layer2, ignore);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00007158 File Offset: 0x00005358
		public static bool GetIgnoreLayerCollision(int layer1, int layer2)
		{
			bool flag = layer1 < 0 || layer1 > 31;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
			}
			bool flag2 = layer2 < 0 || layer2 > 31;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("layer2 is out of range. Layer numbers must be in the range 0 to 31.");
			}
			return Physics2D.GetIgnoreLayerCollision_Internal(layer1, layer2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000025FD File Offset: 0x000007FD
		public static bool GetIgnoreLayerCollision_Internal(int layer1, int layer2)
		{
			return Physics2D.GetIgnoreLayerCollision_InternalDelegateField(layer1, layer2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000071A8 File Offset: 0x000053A8
		public static void SetLayerCollisionMask(int layer, int layerMask)
		{
			bool flag = layer < 0 || layer > 31;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
			}
			Physics2D.SetLayerCollisionMask_Internal(layer, layerMask);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000260B File Offset: 0x0000080B
		public static void SetLayerCollisionMask_Internal(int layer, int layerMask)
		{
			Physics2D.SetLayerCollisionMask_InternalDelegateField(layer, layerMask);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000071DC File Offset: 0x000053DC
		public static int GetLayerCollisionMask(int layer)
		{
			bool flag = layer < 0 || layer > 31;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
			}
			return Physics2D.GetLayerCollisionMask_Internal(layer);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002619 File Offset: 0x00000819
		public static int GetLayerCollisionMask_Internal(int layer)
		{
			return Physics2D.GetLayerCollisionMask_InternalDelegateField(layer);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002626 File Offset: 0x00000826
		public static bool IsTouching(Collider2D collider1, Collider2D collider2)
		{
			return Physics2D.IsTouchingDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2));
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00007210 File Offset: 0x00005410
		public static bool IsTouching(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter)
		{
			return Physics2D.IsTouching_TwoCollidersWithFilter(collider1, collider2, contactFilter);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000263E File Offset: 0x0000083E
		public static bool IsTouching_TwoCollidersWithFilter(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter)
		{
			return Physics2D.IsTouching_TwoCollidersWithFilter_Injected(collider1, collider2, ref contactFilter);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000722C File Offset: 0x0000542C
		public static bool IsTouching(Collider2D collider, ContactFilter2D contactFilter)
		{
			return Physics2D.IsTouching_SingleColliderWithFilter(collider, contactFilter);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002649 File Offset: 0x00000849
		public static bool IsTouching_SingleColliderWithFilter(Collider2D collider, ContactFilter2D contactFilter)
		{
			return Physics2D.IsTouching_SingleColliderWithFilter_Injected(collider, ref contactFilter);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00007248 File Offset: 0x00005448
		public static bool IsTouchingLayers(Collider2D collider)
		{
			return Physics2D.IsTouchingLayers(collider, -1);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002653 File Offset: 0x00000853
		public static bool IsTouchingLayers(Collider2D collider, int layerMask)
		{
			return Physics2D.IsTouchingLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), layerMask);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00007264 File Offset: 0x00005464
		public static Vector2 ClosestPoint(Vector2 position, Collider2D collider)
		{
			bool flag = collider == null;
			if (flag)
			{
				throw new ArgumentNullException("Collider cannot be NULL.");
			}
			return Physics2D.ClosestPoint_Collider(position, collider);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00007294 File Offset: 0x00005494
		public static Vector2 ClosestPoint(Vector2 position, Rigidbody2D rigidbody)
		{
			bool flag = rigidbody == null;
			if (flag)
			{
				throw new ArgumentNullException("Rigidbody cannot be NULL.");
			}
			return Physics2D.ClosestPoint_Rigidbody(position, rigidbody);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000072C4 File Offset: 0x000054C4
		public static Vector2 ClosestPoint_Collider(Vector2 position, Collider2D collider)
		{
			Vector2 vector;
			Physics2D.ClosestPoint_Collider_Injected(ref position, collider, out vector);
			return vector;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000072DC File Offset: 0x000054DC
		public static Vector2 ClosestPoint_Rigidbody(Vector2 position, Rigidbody2D rigidbody)
		{
			Vector2 vector;
			Physics2D.ClosestPoint_Rigidbody_Injected(ref position, rigidbody, out vector);
			return vector;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000072F4 File Offset: 0x000054F4
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end)
		{
			return Physics2D.defaultPhysicsScene.Linecast(start, end, -5);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007318 File Offset: 0x00005518
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter2D);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000734C File Offset: 0x0000554C
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter2D);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000737C File Offset: 0x0000557C
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter2D);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000073A8 File Offset: 0x000055A8
		public static int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter, results);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000073CC File Offset: 0x000055CC
		public static int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter, results);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000073F0 File Offset: 0x000055F0
		public static Il2CppStructArray<RaycastHit2D> LinecastAll(Vector2 start, Vector2 end)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.LinecastAll_Internal(Physics2D.defaultPhysicsScene, start, end, contactFilter2D);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007424 File Offset: 0x00005624
		public static Il2CppStructArray<RaycastHit2D> LinecastAll(Vector2 start, Vector2 end, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.LinecastAll_Internal(Physics2D.defaultPhysicsScene, start, end, contactFilter2D);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00007454 File Offset: 0x00005654
		public static Il2CppStructArray<RaycastHit2D> LinecastAll(Vector2 start, Vector2 end, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.LinecastAll_Internal(Physics2D.defaultPhysicsScene, start, end, contactFilter2D);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00007480 File Offset: 0x00005680
		public static Il2CppStructArray<RaycastHit2D> LinecastAll(Vector2 start, Vector2 end, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.LinecastAll_Internal(Physics2D.defaultPhysicsScene, start, end, contactFilter2D);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002666 File Offset: 0x00000866
		public static Il2CppStructArray<RaycastHit2D> LinecastAll_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter)
		{
			return Physics2D.LinecastAll_Internal_Injected(ref physicsScene, ref start, ref end, ref contactFilter);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000074AC File Offset: 0x000056AC
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.Linecast(start, end, results, -5);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000074D0 File Offset: 0x000056D0
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter2D, results);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00007504 File Offset: 0x00005704
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter2D, results);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00007538 File Offset: 0x00005738
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter2D, results);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00007568 File Offset: 0x00005768
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.Raycast(origin, direction, float.PositiveInfinity, results, -5);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00007594 File Offset: 0x00005794
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, results, -5);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000075BC File Offset: 0x000057BC
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, contactFilter2D, results);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000075F4 File Offset: 0x000057F4
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, contactFilter2D, results);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00007628 File Offset: 0x00005828
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, contactFilter2D, results);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00007658 File Offset: 0x00005858
		public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, float.PositiveInfinity, contactFilter2D);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00007690 File Offset: 0x00005890
		public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction, float distance)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, distance, contactFilter2D);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000076C4 File Offset: 0x000058C4
		public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, distance, contactFilter2D);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000076F8 File Offset: 0x000058F8
		public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, distance, contactFilter2D);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00007728 File Offset: 0x00005928
		public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, distance, contactFilter2D);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002675 File Offset: 0x00000875
		public static Il2CppStructArray<RaycastHit2D> RaycastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return Physics2D.RaycastAll_Internal_Injected(ref physicsScene, ref origin, ref direction, distance, ref contactFilter);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007754 File Offset: 0x00005954
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction)
		{
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, float.PositiveInfinity, -5);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007780 File Offset: 0x00005980
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance)
		{
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, -5);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000077A8 File Offset: 0x000059A8
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000077E0 File Offset: 0x000059E0
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007814 File Offset: 0x00005A14
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007844 File Offset: 0x00005A44
		public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, float.PositiveInfinity, contactFilter, results);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00007870 File Offset: 0x00005A70
		public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter, results);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00007898 File Offset: 0x00005A98
		public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
		{
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter, results);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000078C0 File Offset: 0x00005AC0
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, float.PositiveInfinity, contactFilter2D);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000078F8 File Offset: 0x00005AF8
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000792C File Offset: 0x00005B2C
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00007960 File Offset: 0x00005B60
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00007990 File Offset: 0x00005B90
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, distance, contactFilter2D);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002685 File Offset: 0x00000885
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return Physics2D.CircleCastAll_Internal_Injected(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000079C0 File Offset: 0x00005BC0
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, float.PositiveInfinity, results, -5);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000079EC File Offset: 0x00005BEC
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, results, -5);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00007A14 File Offset: 0x00005C14
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter2D, results);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00007A4C File Offset: 0x00005C4C
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter2D, results);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00007A84 File Offset: 0x00005C84
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter2D, results);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00007AB8 File Offset: 0x00005CB8
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, float.PositiveInfinity, -5);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00007AE4 File Offset: 0x00005CE4
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, -5);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00007B0C File Offset: 0x00005D0C
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00007B44 File Offset: 0x00005D44
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00007B7C File Offset: 0x00005D7C
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00007BB0 File Offset: 0x00005DB0
		public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, float.PositiveInfinity, contactFilter, results);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00007BDC File Offset: 0x00005DDC
		public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00007C08 File Offset: 0x00005E08
		public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00007C34 File Offset: 0x00005E34
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, float.PositiveInfinity, contactFilter2D);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00007C6C File Offset: 0x00005E6C
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00007CA4 File Offset: 0x00005EA4
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00007CDC File Offset: 0x00005EDC
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00007D10 File Offset: 0x00005F10
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002697 File Offset: 0x00000897
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return Physics2D.BoxCastAll_Internal_Injected(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00007D40 File Offset: 0x00005F40
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, float.PositiveInfinity, results, -5);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00007D6C File Offset: 0x00005F6C
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, results, -5);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00007D98 File Offset: 0x00005F98
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00007DD4 File Offset: 0x00005FD4
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00007E0C File Offset: 0x0000600C
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00007E40 File Offset: 0x00006040
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, -5);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00007E6C File Offset: 0x0000606C
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, -5);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00007E98 File Offset: 0x00006098
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00007ED4 File Offset: 0x000060D4
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00007F0C File Offset: 0x0000610C
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00007F40 File Offset: 0x00006140
		public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, contactFilter, results);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00007F70 File Offset: 0x00006170
		public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00007F9C File Offset: 0x0000619C
		public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00007FC8 File Offset: 0x000061C8
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, contactFilter2D);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00008004 File Offset: 0x00006204
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000026AB File Offset: 0x000008AB
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return Physics2D.CapsuleCastAll_Internal_Injected(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000803C File Offset: 0x0000623C
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00008074 File Offset: 0x00006274
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000080A8 File Offset: 0x000062A8
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, contactFilter2D);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000080DC File Offset: 0x000062DC
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, results, -5);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000810C File Offset: 0x0000630C
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, results, -5);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00008138 File Offset: 0x00006338
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00008174 File Offset: 0x00006374
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000081B0 File Offset: 0x000063B0
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter2D, results);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000081E8 File Offset: 0x000063E8
		public static RaycastHit2D GetRayIntersection(Ray ray)
		{
			return Physics2D.defaultPhysicsScene.GetRayIntersection(ray, float.PositiveInfinity, -5);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00008210 File Offset: 0x00006410
		public static RaycastHit2D GetRayIntersection(Ray ray, float distance)
		{
			return Physics2D.defaultPhysicsScene.GetRayIntersection(ray, distance, -5);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00008234 File Offset: 0x00006434
		public static RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask)
		{
			return Physics2D.defaultPhysicsScene.GetRayIntersection(ray, distance, layerMask);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00008258 File Offset: 0x00006458
		public static Collider2D OverlapPoint(Vector2 point)
		{
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, -5);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000827C File Offset: 0x0000647C
		public static Collider2D OverlapPoint(Vector2 point, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter2D);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000082B0 File Offset: 0x000064B0
		public static Collider2D OverlapPoint(Vector2 point, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter2D);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000082E0 File Offset: 0x000064E0
		public static Collider2D OverlapPoint(Vector2 point, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter2D);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000830C File Offset: 0x0000650C
		public static int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter, results);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00008330 File Offset: 0x00006530
		public static int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter, results);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00008354 File Offset: 0x00006554
		public static Il2CppReferenceArray<Collider2D> OverlapPointAll(Vector2 point)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapPointAll_Internal(Physics2D.defaultPhysicsScene, point, contactFilter2D);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00008384 File Offset: 0x00006584
		public static Il2CppReferenceArray<Collider2D> OverlapPointAll(Vector2 point, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapPointAll_Internal(Physics2D.defaultPhysicsScene, point, contactFilter2D);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000083B4 File Offset: 0x000065B4
		public static Il2CppReferenceArray<Collider2D> OverlapPointAll(Vector2 point, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.OverlapPointAll_Internal(Physics2D.defaultPhysicsScene, point, contactFilter2D);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000083E0 File Offset: 0x000065E0
		public static Il2CppReferenceArray<Collider2D> OverlapPointAll(Vector2 point, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.OverlapPointAll_Internal(Physics2D.defaultPhysicsScene, point, contactFilter2D);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000026C1 File Offset: 0x000008C1
		public static Il2CppReferenceArray<Collider2D> OverlapPointAll_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter)
		{
			return Physics2D.OverlapPointAll_Internal_Injected(ref physicsScene, ref point, ref contactFilter);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00008408 File Offset: 0x00006608
		public static int OverlapPointNonAlloc(Vector2 point, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, results, -5);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000842C File Offset: 0x0000662C
		public static int OverlapPointNonAlloc(Vector2 point, Il2CppReferenceArray<Collider2D> results, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter2D, results);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00008460 File Offset: 0x00006660
		public static int OverlapPointNonAlloc(Vector2 point, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter2D, results);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00008490 File Offset: 0x00006690
		public static int OverlapPointNonAlloc(Vector2 point, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter2D, results);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000084BC File Offset: 0x000066BC
		public static Collider2D OverlapCircle(Vector2 point, float radius)
		{
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, -5);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000084E0 File Offset: 0x000066E0
		public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter2D);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00008514 File Offset: 0x00006714
		public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter2D);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00008544 File Offset: 0x00006744
		public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter2D);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00008570 File Offset: 0x00006770
		public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter, results);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00008594 File Offset: 0x00006794
		public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter, results);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000085B8 File Offset: 0x000067B8
		public static Il2CppReferenceArray<Collider2D> OverlapCircleAll(Vector2 point, float radius)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapCircleAll_Internal(Physics2D.defaultPhysicsScene, point, radius, contactFilter2D);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000085EC File Offset: 0x000067EC
		public static Il2CppReferenceArray<Collider2D> OverlapCircleAll(Vector2 point, float radius, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapCircleAll_Internal(Physics2D.defaultPhysicsScene, point, radius, contactFilter2D);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000861C File Offset: 0x0000681C
		public static Il2CppReferenceArray<Collider2D> OverlapCircleAll(Vector2 point, float radius, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.OverlapCircleAll_Internal(Physics2D.defaultPhysicsScene, point, radius, contactFilter2D);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00008648 File Offset: 0x00006848
		public static Il2CppReferenceArray<Collider2D> OverlapCircleAll(Vector2 point, float radius, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.OverlapCircleAll_Internal(Physics2D.defaultPhysicsScene, point, radius, contactFilter2D);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000026CE File Offset: 0x000008CE
		public static Il2CppReferenceArray<Collider2D> OverlapCircleAll_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter)
		{
			return Physics2D.OverlapCircleAll_Internal_Injected(ref physicsScene, ref point, radius, ref contactFilter);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00008674 File Offset: 0x00006874
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, results, -5);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00008698 File Offset: 0x00006898
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter2D, results);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000086CC File Offset: 0x000068CC
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter2D, results);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00008700 File Offset: 0x00006900
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter2D, results);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00008730 File Offset: 0x00006930
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle)
		{
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, -5);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00008754 File Offset: 0x00006954
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter2D);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00008788 File Offset: 0x00006988
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter2D);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000087BC File Offset: 0x000069BC
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter2D);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000087EC File Offset: 0x000069EC
		public static int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter, results);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00008814 File Offset: 0x00006A14
		public static int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter, results);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000883C File Offset: 0x00006A3C
		public static Il2CppReferenceArray<Collider2D> OverlapBoxAll(Vector2 point, Vector2 size, float angle)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapBoxAll_Internal(Physics2D.defaultPhysicsScene, point, size, angle, contactFilter2D);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00008870 File Offset: 0x00006A70
		public static Il2CppReferenceArray<Collider2D> OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapBoxAll_Internal(Physics2D.defaultPhysicsScene, point, size, angle, contactFilter2D);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000088A4 File Offset: 0x00006AA4
		public static Il2CppReferenceArray<Collider2D> OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.OverlapBoxAll_Internal(Physics2D.defaultPhysicsScene, point, size, angle, contactFilter2D);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000088D4 File Offset: 0x00006AD4
		public static Il2CppReferenceArray<Collider2D> OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.OverlapBoxAll_Internal(Physics2D.defaultPhysicsScene, point, size, angle, contactFilter2D);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000026DC File Offset: 0x000008DC
		public static Il2CppReferenceArray<Collider2D> OverlapBoxAll_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter)
		{
			return Physics2D.OverlapBoxAll_Internal_Injected(ref physicsScene, ref point, ref size, angle, ref contactFilter);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00008900 File Offset: 0x00006B00
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, results, -5);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00008928 File Offset: 0x00006B28
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter2D, results);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00008960 File Offset: 0x00006B60
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter2D, results);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00008994 File Offset: 0x00006B94
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter2D, results);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000089C4 File Offset: 0x00006BC4
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB)
		{
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, -5);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000089E8 File Offset: 0x00006BE8
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter2D);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00008A1C File Offset: 0x00006C1C
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter2D);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00008A4C File Offset: 0x00006C4C
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter2D);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00008A78 File Offset: 0x00006C78
		public static int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter, results);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00008A9C File Offset: 0x00006C9C
		public static int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter, results);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00008AC0 File Offset: 0x00006CC0
		public static Il2CppReferenceArray<Collider2D> OverlapAreaAll(Vector2 pointA, Vector2 pointB)
		{
			return Physics2D.OverlapAreaAllToBox_Internal(pointA, pointB, -5, float.NegativeInfinity, float.PositiveInfinity);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00008AE8 File Offset: 0x00006CE8
		public static Il2CppReferenceArray<Collider2D> OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask)
		{
			return Physics2D.OverlapAreaAllToBox_Internal(pointA, pointB, layerMask, float.NegativeInfinity, float.PositiveInfinity);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00008B0C File Offset: 0x00006D0C
		public static Il2CppReferenceArray<Collider2D> OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth)
		{
			return Physics2D.OverlapAreaAllToBox_Internal(pointA, pointB, layerMask, minDepth, float.PositiveInfinity);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00008B2C File Offset: 0x00006D2C
		public static Il2CppReferenceArray<Collider2D> OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth, float maxDepth)
		{
			return Physics2D.OverlapAreaAllToBox_Internal(pointA, pointB, layerMask, minDepth, maxDepth);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00008B4C File Offset: 0x00006D4C
		public static Il2CppReferenceArray<Collider2D> OverlapAreaAllToBox_Internal(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth, float maxDepth)
		{
			Vector2 vector = (pointA + pointB) * 0.5f;
			Vector2 vector2 = new Vector2(Mathf.Abs(pointA.x - pointB.x), Math.Abs(pointA.y - pointB.y));
			return Physics2D.OverlapBoxAll(vector, vector2, 0f, layerMask, minDepth, maxDepth);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00008BAC File Offset: 0x00006DAC
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, results, -5);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00008BD0 File Offset: 0x00006DD0
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter2D, results);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00008C04 File Offset: 0x00006E04
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter2D, results);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00008C38 File Offset: 0x00006E38
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter2D, results);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00008C68 File Offset: 0x00006E68
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle)
		{
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, -5);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00008C90 File Offset: 0x00006E90
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008CC8 File Offset: 0x00006EC8
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00008CFC File Offset: 0x00006EFC
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00008D2C File Offset: 0x00006F2C
		public static int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter, results);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00008D54 File Offset: 0x00006F54
		public static int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter, results);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00008D7C File Offset: 0x00006F7C
		public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapCapsuleAll_Internal(Physics2D.defaultPhysicsScene, point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00008DB0 File Offset: 0x00006FB0
		public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.OverlapCapsuleAll_Internal(Physics2D.defaultPhysicsScene, point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00008DE4 File Offset: 0x00006FE4
		public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.OverlapCapsuleAll_Internal(Physics2D.defaultPhysicsScene, point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00008E14 File Offset: 0x00007014
		public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.OverlapCapsuleAll_Internal(Physics2D.defaultPhysicsScene, point, size, direction, angle, contactFilter2D);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000026EC File Offset: 0x000008EC
		public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter)
		{
			return Physics2D.OverlapCapsuleAll_Internal_Injected(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00008E44 File Offset: 0x00007044
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, results, -5);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00008E6C File Offset: 0x0000706C
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter2D, results);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00008EA4 File Offset: 0x000070A4
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter2D, results);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00008EDC File Offset: 0x000070DC
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D contactFilter2D = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
			return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter2D, results);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00008F10 File Offset: 0x00007110
		public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCollider(collider, contactFilter, results);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00008F2C File Offset: 0x0000712C
		public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return PhysicsScene2D.OverlapCollider(collider, contactFilter, results);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00008F48 File Offset: 0x00007148
		public static int GetContacts(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetColliderColliderContactsArray(collider1, collider2, contactFilter, contacts);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00008F64 File Offset: 0x00007164
		public static int GetContacts(Collider2D collider, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetColliderContactsArray(collider, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00008F8C File Offset: 0x0000718C
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetColliderContactsArray(collider, contactFilter, contacts);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00008FA8 File Offset: 0x000071A8
		public static int GetContacts(Collider2D collider, Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetColliderContactsCollidersOnlyArray(collider, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00008FD0 File Offset: 0x000071D0
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetColliderContactsCollidersOnlyArray(collider, contactFilter, colliders);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00008FEC File Offset: 0x000071EC
		public static int GetContacts(Rigidbody2D rigidbody, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetRigidbodyContactsArray(rigidbody, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00009014 File Offset: 0x00007214
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetRigidbodyContactsArray(rigidbody, contactFilter, contacts);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00009030 File Offset: 0x00007230
		public static int GetContacts(Rigidbody2D rigidbody, Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyArray(rigidbody, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00009058 File Offset: 0x00007258
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyArray(rigidbody, contactFilter, colliders);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000026FE File Offset: 0x000008FE
		public static int GetColliderContactsArray(Collider2D collider, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
		{
			return Physics2D.GetColliderContactsArray_Injected(collider, ref contactFilter, results);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002709 File Offset: 0x00000909
		public static int GetColliderColliderContactsArray(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
		{
			return Physics2D.GetColliderColliderContactsArray_Injected(collider1, collider2, ref contactFilter, results);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002715 File Offset: 0x00000915
		public static int GetRigidbodyContactsArray(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
		{
			return Physics2D.GetRigidbodyContactsArray_Injected(rigidbody, ref contactFilter, results);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002720 File Offset: 0x00000920
		public static int GetColliderContactsCollidersOnlyArray(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.GetColliderContactsCollidersOnlyArray_Injected(collider, ref contactFilter, results);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000272B File Offset: 0x0000092B
		public static int GetRigidbodyContactsCollidersOnlyArray(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyArray_Injected(rigidbody, ref contactFilter, results);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00009074 File Offset: 0x00007274
		public static int GetContacts(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetColliderColliderContactsList(collider1, collider2, contactFilter, contacts);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00009090 File Offset: 0x00007290
		public static int GetContacts(Collider2D collider, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetColliderContactsList(collider, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000090B8 File Offset: 0x000072B8
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetColliderContactsList(collider, contactFilter, contacts);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000090D4 File Offset: 0x000072D4
		public static int GetContacts(Collider2D collider, List<Collider2D> colliders)
		{
			return Physics2D.GetColliderContactsCollidersOnlyList(collider, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000090FC File Offset: 0x000072FC
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> colliders)
		{
			return Physics2D.GetColliderContactsCollidersOnlyList(collider, contactFilter, colliders);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00009118 File Offset: 0x00007318
		public static int GetContacts(Rigidbody2D rigidbody, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetRigidbodyContactsList(rigidbody, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00009140 File Offset: 0x00007340
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetRigidbodyContactsList(rigidbody, contactFilter, contacts);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000915C File Offset: 0x0000735C
		public static int GetContacts(Rigidbody2D rigidbody, List<Collider2D> colliders)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyList(rigidbody, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00009184 File Offset: 0x00007384
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<Collider2D> colliders)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyList(rigidbody, contactFilter, colliders);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002736 File Offset: 0x00000936
		public static int GetColliderContactsList(Collider2D collider, ContactFilter2D contactFilter, List<ContactPoint2D> results)
		{
			return Physics2D.GetColliderContactsList_Injected(collider, ref contactFilter, results);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002741 File Offset: 0x00000941
		public static int GetColliderColliderContactsList(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, List<ContactPoint2D> results)
		{
			return Physics2D.GetColliderColliderContactsList_Injected(collider1, collider2, ref contactFilter, results);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000274D File Offset: 0x0000094D
		public static int GetRigidbodyContactsList(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<ContactPoint2D> results)
		{
			return Physics2D.GetRigidbodyContactsList_Injected(rigidbody, ref contactFilter, results);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002758 File Offset: 0x00000958
		public static int GetColliderContactsCollidersOnlyList(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.GetColliderContactsCollidersOnlyList_Injected(collider, ref contactFilter, results);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002763 File Offset: 0x00000963
		public static int GetRigidbodyContactsCollidersOnlyList(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyList_Injected(rigidbody, ref contactFilter, results);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000276E File Offset: 0x0000096E
		public static void SetEditorDragMovement(bool dragging, Il2CppReferenceArray<GameObject> objs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000091A0 File Offset: 0x000073A0
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000277B File Offset: 0x0000097B
		public static bool raycastsHitTriggers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000091B4 File Offset: 0x000073B4
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000277E File Offset: 0x0000097E
		public static bool raycastsStartInColliders
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x000091C8 File Offset: 0x000073C8
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002781 File Offset: 0x00000981
		public static bool deleteStopsCallbacks
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x000091DC File Offset: 0x000073DC
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002784 File Offset: 0x00000984
		public static bool changeStopsCallbacks
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000091F0 File Offset: 0x000073F0
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002787 File Offset: 0x00000987
		public static float minPenetrationForPenalty
		{
			get
			{
				return Physics2D.defaultContactOffset;
			}
			set
			{
				Physics2D.defaultContactOffset = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00009208 File Offset: 0x00007408
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002791 File Offset: 0x00000991
		public static bool autoSimulation
		{
			get
			{
				return Physics2D.simulationMode != SimulationMode2D.Script;
			}
			set
			{
				Physics2D.simulationMode = (value ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00009228 File Offset: 0x00007428
		// (set) Token: 0x060001AE RID: 430 RVA: 0x000027A1 File Offset: 0x000009A1
		public static Color colliderAwakeColor
		{
			get
			{
				return Color.magenta;
			}
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00009240 File Offset: 0x00007440
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x000027A4 File Offset: 0x000009A4
		public static Color colliderAsleepColor
		{
			get
			{
				return Color.magenta;
			}
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00009258 File Offset: 0x00007458
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x000027A7 File Offset: 0x000009A7
		public static Color colliderContactColor
		{
			get
			{
				return Color.magenta;
			}
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00009270 File Offset: 0x00007470
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x000027AA File Offset: 0x000009AA
		public static Color colliderAABBColor
		{
			get
			{
				return Color.magenta;
			}
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00009288 File Offset: 0x00007488
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x000027AD File Offset: 0x000009AD
		public static float contactArrowScale
		{
			get
			{
				return 0.2f;
			}
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000027B0 File Offset: 0x000009B0
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x000027BD File Offset: 0x000009BD
		public static bool alwaysShowColliders
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000027CA File Offset: 0x000009CA
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000027D7 File Offset: 0x000009D7
		public static bool showCollidersFilled
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001BB RID: 443 RVA: 0x000027E4 File Offset: 0x000009E4
		// (set) Token: 0x060001BC RID: 444 RVA: 0x000027F1 File Offset: 0x000009F1
		public static bool showColliderSleep
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000027FE File Offset: 0x000009FE
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0000280B File Offset: 0x00000A0B
		public static bool showColliderContacts
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001BF RID: 447 RVA: 0x000092A0 File Offset: 0x000074A0
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002818 File Offset: 0x00000A18
		public static bool showColliderAABB
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000281B File Offset: 0x00000A1B
		public static void get_gravity_Injected(out Vector2 ret)
		{
			Physics2D.get_gravity_InjectedDelegateField(out ret);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002828 File Offset: 0x00000A28
		public static void set_gravity_Injected(ref Vector2 value)
		{
			Physics2D.set_gravity_InjectedDelegateField(ref value);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002835 File Offset: 0x00000A35
		public static bool Simulate_Internal_Injected(ref PhysicsScene2D physicsScene, float step)
		{
			return Physics2D.Simulate_Internal_InjectedDelegateField(ref physicsScene, step);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002843 File Offset: 0x00000A43
		public static bool IsTouching_TwoCollidersWithFilter_Injected(Collider2D collider1, Collider2D collider2, ref ContactFilter2D contactFilter)
		{
			return Physics2D.IsTouching_TwoCollidersWithFilter_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2), ref contactFilter);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000285C File Offset: 0x00000A5C
		public static bool IsTouching_SingleColliderWithFilter_Injected(Collider2D collider, ref ContactFilter2D contactFilter)
		{
			return Physics2D.IsTouching_SingleColliderWithFilter_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000286F File Offset: 0x00000A6F
		public static void ClosestPoint_Collider_Injected(ref Vector2 position, Collider2D collider, out Vector2 ret)
		{
			Physics2D.ClosestPoint_Collider_InjectedDelegateField(ref position, IL2CPP.Il2CppObjectBaseToPtr(collider), out ret);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002883 File Offset: 0x00000A83
		public static void ClosestPoint_Rigidbody_Injected(ref Vector2 position, Rigidbody2D rigidbody, out Vector2 ret)
		{
			Physics2D.ClosestPoint_Rigidbody_InjectedDelegateField(ref position, IL2CPP.Il2CppObjectBaseToPtr(rigidbody), out ret);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000092B4 File Offset: 0x000074B4
		public static Il2CppStructArray<RaycastHit2D> LinecastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.LinecastAll_Internal_InjectedDelegateField(ref physicsScene, ref start, ref end, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000092E0 File Offset: 0x000074E0
		public static Il2CppStructArray<RaycastHit2D> RaycastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.RaycastAll_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref direction, distance, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000930C File Offset: 0x0000750C
		public static Il2CppStructArray<RaycastHit2D> CircleCastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.CircleCastAll_Internal_InjectedDelegateField(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000933C File Offset: 0x0000753C
		public static Il2CppStructArray<RaycastHit2D> BoxCastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.BoxCastAll_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000936C File Offset: 0x0000756C
		public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.CapsuleCastAll_Internal_InjectedDelegateField(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000093A0 File Offset: 0x000075A0
		public static Il2CppReferenceArray<Collider2D> OverlapPointAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.OverlapPointAll_Internal_InjectedDelegateField(ref physicsScene, ref point, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000093CC File Offset: 0x000075CC
		public static Il2CppReferenceArray<Collider2D> OverlapCircleAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.OverlapCircleAll_Internal_InjectedDelegateField(ref physicsScene, ref point, radius, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000093F8 File Offset: 0x000075F8
		public static Il2CppReferenceArray<Collider2D> OverlapBoxAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, float angle, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.OverlapBoxAll_Internal_InjectedDelegateField(ref physicsScene, ref point, ref size, angle, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00009424 File Offset: 0x00007624
		public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref Vector2 size, CapsuleDirection2D direction, float angle, ref ContactFilter2D contactFilter)
		{
			IntPtr intPtr = Physics2D.OverlapCapsuleAll_Internal_InjectedDelegateField(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002897 File Offset: 0x00000A97
		public static int GetColliderContactsArray_Injected(Collider2D collider, ref ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
		{
			return Physics2D.GetColliderContactsArray_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000028B0 File Offset: 0x00000AB0
		public static int GetColliderColliderContactsArray_Injected(Collider2D collider1, Collider2D collider2, ref ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
		{
			return Physics2D.GetColliderColliderContactsArray_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000028CF File Offset: 0x00000ACF
		public static int GetRigidbodyContactsArray_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
		{
			return Physics2D.GetRigidbodyContactsArray_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rigidbody), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000028E8 File Offset: 0x00000AE8
		public static int GetColliderContactsCollidersOnlyArray_Injected(Collider2D collider, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.GetColliderContactsCollidersOnlyArray_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002901 File Offset: 0x00000B01
		public static int GetRigidbodyContactsCollidersOnlyArray_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyArray_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rigidbody), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000291A File Offset: 0x00000B1A
		public static int GetColliderContactsList_Injected(Collider2D collider, ref ContactFilter2D contactFilter, List<ContactPoint2D> results)
		{
			return Physics2D.GetColliderContactsList_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002933 File Offset: 0x00000B33
		public static int GetColliderColliderContactsList_Injected(Collider2D collider1, Collider2D collider2, ref ContactFilter2D contactFilter, List<ContactPoint2D> results)
		{
			return Physics2D.GetColliderColliderContactsList_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider1), IL2CPP.Il2CppObjectBaseToPtr(collider2), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002952 File Offset: 0x00000B52
		public static int GetRigidbodyContactsList_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, List<ContactPoint2D> results)
		{
			return Physics2D.GetRigidbodyContactsList_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rigidbody), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000296B File Offset: 0x00000B6B
		public static int GetColliderContactsCollidersOnlyList_Injected(Collider2D collider, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.GetColliderContactsCollidersOnlyList_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002984 File Offset: 0x00000B84
		public static int GetRigidbodyContactsCollidersOnlyList_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Physics2D.GetRigidbodyContactsCollidersOnlyList_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rigidbody), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_m_LastDisabledRigidbody2D;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene2D_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_get_queriesHitTriggers_Public_Static_get_Boolean_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_Single_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_Single_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_List_1_RaycastHit2D_Single_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Private_Static_Il2CppStructArray_1_RaycastHit2D_PhysicsScene2D_Vector3_Vector3_Single_Int32_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Injected_Private_Static_Il2CppStructArray_1_RaycastHit2D_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_0;

		// Token: 0x04000045 RID: 69
		public const int IgnoreRaycastLayer = 4;

		// Token: 0x04000046 RID: 70
		public const int DefaultRaycastLayers = -5;

		// Token: 0x04000047 RID: 71
		public const int AllLayers = -1;

		// Token: 0x04000048 RID: 72
		public const int MaxPolygonShapeVertices = 8;

		// Token: 0x04000049 RID: 73
		private static readonly Physics2D.get_velocityIterationsDelegate get_velocityIterationsDelegateField;

		// Token: 0x0400004A RID: 74
		private static readonly Physics2D.set_velocityIterationsDelegate set_velocityIterationsDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly Physics2D.get_positionIterationsDelegate get_positionIterationsDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly Physics2D.set_positionIterationsDelegate set_positionIterationsDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly Physics2D.set_queriesHitTriggersDelegate set_queriesHitTriggersDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly Physics2D.get_queriesStartInCollidersDelegate get_queriesStartInCollidersDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly Physics2D.set_queriesStartInCollidersDelegate set_queriesStartInCollidersDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly Physics2D.get_callbacksOnDisableDelegate get_callbacksOnDisableDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly Physics2D.set_callbacksOnDisableDelegate set_callbacksOnDisableDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly Physics2D.get_reuseCollisionCallbacksDelegate get_reuseCollisionCallbacksDelegateField;

		// Token: 0x04000053 RID: 83
		private static readonly Physics2D.set_reuseCollisionCallbacksDelegate set_reuseCollisionCallbacksDelegateField;

		// Token: 0x04000054 RID: 84
		private static readonly Physics2D.get_autoSyncTransformsDelegate get_autoSyncTransformsDelegateField;

		// Token: 0x04000055 RID: 85
		private static readonly Physics2D.set_autoSyncTransformsDelegate set_autoSyncTransformsDelegateField;

		// Token: 0x04000056 RID: 86
		private static readonly Physics2D.get_simulationModeDelegate get_simulationModeDelegateField;

		// Token: 0x04000057 RID: 87
		private static readonly Physics2D.set_simulationModeDelegate set_simulationModeDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly Physics2D.get_velocityThresholdDelegate get_velocityThresholdDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly Physics2D.set_velocityThresholdDelegate set_velocityThresholdDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly Physics2D.get_maxLinearCorrectionDelegate get_maxLinearCorrectionDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly Physics2D.set_maxLinearCorrectionDelegate set_maxLinearCorrectionDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly Physics2D.get_maxAngularCorrectionDelegate get_maxAngularCorrectionDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly Physics2D.set_maxAngularCorrectionDelegate set_maxAngularCorrectionDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly Physics2D.get_maxTranslationSpeedDelegate get_maxTranslationSpeedDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly Physics2D.set_maxTranslationSpeedDelegate set_maxTranslationSpeedDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly Physics2D.get_maxRotationSpeedDelegate get_maxRotationSpeedDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly Physics2D.set_maxRotationSpeedDelegate set_maxRotationSpeedDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly Physics2D.get_defaultContactOffsetDelegate get_defaultContactOffsetDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly Physics2D.set_defaultContactOffsetDelegate set_defaultContactOffsetDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly Physics2D.get_baumgarteScaleDelegate get_baumgarteScaleDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly Physics2D.set_baumgarteScaleDelegate set_baumgarteScaleDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly Physics2D.get_baumgarteTOIScaleDelegate get_baumgarteTOIScaleDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly Physics2D.set_baumgarteTOIScaleDelegate set_baumgarteTOIScaleDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly Physics2D.get_timeToSleepDelegate get_timeToSleepDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly Physics2D.set_timeToSleepDelegate set_timeToSleepDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly Physics2D.get_linearSleepToleranceDelegate get_linearSleepToleranceDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly Physics2D.set_linearSleepToleranceDelegate set_linearSleepToleranceDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly Physics2D.get_angularSleepToleranceDelegate get_angularSleepToleranceDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly Physics2D.set_angularSleepToleranceDelegate set_angularSleepToleranceDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly Physics2D.SyncTransformsDelegate SyncTransformsDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly Physics2D.IgnoreCollisionDelegate IgnoreCollisionDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly Physics2D.GetIgnoreCollisionDelegate GetIgnoreCollisionDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly Physics2D.IgnoreLayerCollision_InternalDelegate IgnoreLayerCollision_InternalDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly Physics2D.GetIgnoreLayerCollision_InternalDelegate GetIgnoreLayerCollision_InternalDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly Physics2D.SetLayerCollisionMask_InternalDelegate SetLayerCollisionMask_InternalDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly Physics2D.GetLayerCollisionMask_InternalDelegate GetLayerCollisionMask_InternalDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly Physics2D.IsTouchingDelegate IsTouchingDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly Physics2D.IsTouchingLayersDelegate IsTouchingLayersDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly Physics2D.get_gravity_InjectedDelegate get_gravity_InjectedDelegateField;

		// Token: 0x04000078 RID: 120
		private static readonly Physics2D.set_gravity_InjectedDelegate set_gravity_InjectedDelegateField;

		// Token: 0x04000079 RID: 121
		private static readonly Physics2D.Simulate_Internal_InjectedDelegate Simulate_Internal_InjectedDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly Physics2D.IsTouching_TwoCollidersWithFilter_InjectedDelegate IsTouching_TwoCollidersWithFilter_InjectedDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly Physics2D.IsTouching_SingleColliderWithFilter_InjectedDelegate IsTouching_SingleColliderWithFilter_InjectedDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly Physics2D.ClosestPoint_Collider_InjectedDelegate ClosestPoint_Collider_InjectedDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly Physics2D.ClosestPoint_Rigidbody_InjectedDelegate ClosestPoint_Rigidbody_InjectedDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly Physics2D.LinecastAll_Internal_InjectedDelegate LinecastAll_Internal_InjectedDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly Physics2D.RaycastAll_Internal_InjectedDelegate RaycastAll_Internal_InjectedDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly Physics2D.CircleCastAll_Internal_InjectedDelegate CircleCastAll_Internal_InjectedDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly Physics2D.BoxCastAll_Internal_InjectedDelegate BoxCastAll_Internal_InjectedDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly Physics2D.CapsuleCastAll_Internal_InjectedDelegate CapsuleCastAll_Internal_InjectedDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly Physics2D.OverlapPointAll_Internal_InjectedDelegate OverlapPointAll_Internal_InjectedDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly Physics2D.OverlapCircleAll_Internal_InjectedDelegate OverlapCircleAll_Internal_InjectedDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly Physics2D.OverlapBoxAll_Internal_InjectedDelegate OverlapBoxAll_Internal_InjectedDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly Physics2D.OverlapCapsuleAll_Internal_InjectedDelegate OverlapCapsuleAll_Internal_InjectedDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly Physics2D.GetColliderContactsArray_InjectedDelegate GetColliderContactsArray_InjectedDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly Physics2D.GetColliderColliderContactsArray_InjectedDelegate GetColliderColliderContactsArray_InjectedDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly Physics2D.GetRigidbodyContactsArray_InjectedDelegate GetRigidbodyContactsArray_InjectedDelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly Physics2D.GetColliderContactsCollidersOnlyArray_InjectedDelegate GetColliderContactsCollidersOnlyArray_InjectedDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly Physics2D.GetRigidbodyContactsCollidersOnlyArray_InjectedDelegate GetRigidbodyContactsCollidersOnlyArray_InjectedDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly Physics2D.GetColliderContactsList_InjectedDelegate GetColliderContactsList_InjectedDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly Physics2D.GetColliderColliderContactsList_InjectedDelegate GetColliderColliderContactsList_InjectedDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly Physics2D.GetRigidbodyContactsList_InjectedDelegate GetRigidbodyContactsList_InjectedDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly Physics2D.GetColliderContactsCollidersOnlyList_InjectedDelegate GetColliderContactsCollidersOnlyList_InjectedDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly Physics2D.GetRigidbodyContactsCollidersOnlyList_InjectedDelegate GetRigidbodyContactsCollidersOnlyList_InjectedDelegateField;

		// Token: 0x02000053 RID: 83
		public enum GizmoOptions
		{
			// Token: 0x0400029D RID: 669
			AllColliders = 1,
			// Token: 0x0400029E RID: 670
			CollidersOutlined,
			// Token: 0x0400029F RID: 671
			CollidersFilled = 4,
			// Token: 0x040002A0 RID: 672
			CollidersSleeping = 8,
			// Token: 0x040002A1 RID: 673
			ColliderContacts = 16,
			// Token: 0x040002A2 RID: 674
			ColliderBounds = 32
		}

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x060004D4 RID: 1236
		private delegate int get_velocityIterationsDelegate();

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x060004D6 RID: 1238
		private delegate void set_velocityIterationsDelegate(int value);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x060004D8 RID: 1240
		private delegate int get_positionIterationsDelegate();

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x060004DA RID: 1242
		private delegate void set_positionIterationsDelegate(int value);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x060004DC RID: 1244
		private delegate void set_queriesHitTriggersDelegate(bool value);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x060004DE RID: 1246
		private delegate bool get_queriesStartInCollidersDelegate();

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x060004E0 RID: 1248
		private delegate void set_queriesStartInCollidersDelegate(bool value);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x060004E2 RID: 1250
		private delegate bool get_callbacksOnDisableDelegate();

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x060004E4 RID: 1252
		private delegate void set_callbacksOnDisableDelegate(bool value);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x060004E6 RID: 1254
		private delegate bool get_reuseCollisionCallbacksDelegate();

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x060004E8 RID: 1256
		private delegate void set_reuseCollisionCallbacksDelegate(bool value);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x060004EA RID: 1258
		private delegate bool get_autoSyncTransformsDelegate();

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x060004EC RID: 1260
		private delegate void set_autoSyncTransformsDelegate(bool value);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x060004EE RID: 1262
		private delegate SimulationMode2D get_simulationModeDelegate();

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x060004F0 RID: 1264
		private delegate void set_simulationModeDelegate(SimulationMode2D value);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x060004F2 RID: 1266
		private delegate float get_velocityThresholdDelegate();

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060004F4 RID: 1268
		private delegate void set_velocityThresholdDelegate(float value);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060004F6 RID: 1270
		private delegate float get_maxLinearCorrectionDelegate();

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060004F8 RID: 1272
		private delegate void set_maxLinearCorrectionDelegate(float value);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060004FA RID: 1274
		private delegate float get_maxAngularCorrectionDelegate();

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060004FC RID: 1276
		private delegate void set_maxAngularCorrectionDelegate(float value);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060004FE RID: 1278
		private delegate float get_maxTranslationSpeedDelegate();

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x06000500 RID: 1280
		private delegate void set_maxTranslationSpeedDelegate(float value);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x06000502 RID: 1282
		private delegate float get_maxRotationSpeedDelegate();

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x06000504 RID: 1284
		private delegate void set_maxRotationSpeedDelegate(float value);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x06000506 RID: 1286
		private delegate float get_defaultContactOffsetDelegate();

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x06000508 RID: 1288
		private delegate void set_defaultContactOffsetDelegate(float value);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x0600050A RID: 1290
		private delegate float get_baumgarteScaleDelegate();

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x0600050C RID: 1292
		private delegate void set_baumgarteScaleDelegate(float value);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x0600050E RID: 1294
		private delegate float get_baumgarteTOIScaleDelegate();

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x06000510 RID: 1296
		private delegate void set_baumgarteTOIScaleDelegate(float value);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x06000512 RID: 1298
		private delegate float get_timeToSleepDelegate();

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000514 RID: 1300
		private delegate void set_timeToSleepDelegate(float value);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x06000516 RID: 1302
		private delegate float get_linearSleepToleranceDelegate();

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x06000518 RID: 1304
		private delegate void set_linearSleepToleranceDelegate(float value);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x0600051A RID: 1306
		private delegate float get_angularSleepToleranceDelegate();

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x0600051C RID: 1308
		private delegate void set_angularSleepToleranceDelegate(float value);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x0600051E RID: 1310
		private delegate void SyncTransformsDelegate();

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x06000520 RID: 1312
		private delegate void IgnoreCollisionDelegate(IntPtr collider1, IntPtr collider2, bool ignore);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x06000522 RID: 1314
		private delegate bool GetIgnoreCollisionDelegate(IntPtr collider1, IntPtr collider2);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x06000524 RID: 1316
		private delegate void IgnoreLayerCollision_InternalDelegate(int layer1, int layer2, bool ignore);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x06000526 RID: 1318
		private delegate bool GetIgnoreLayerCollision_InternalDelegate(int layer1, int layer2);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x06000528 RID: 1320
		private delegate void SetLayerCollisionMask_InternalDelegate(int layer, int layerMask);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x0600052A RID: 1322
		private delegate int GetLayerCollisionMask_InternalDelegate(int layer);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x0600052C RID: 1324
		private delegate bool IsTouchingDelegate(IntPtr collider1, IntPtr collider2);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x0600052E RID: 1326
		private delegate bool IsTouchingLayersDelegate(IntPtr collider, int layerMask);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x06000530 RID: 1328
		private delegate void get_gravity_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x06000532 RID: 1330
		private delegate void set_gravity_InjectedDelegate(IntPtr value);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x06000534 RID: 1332
		private delegate bool Simulate_Internal_InjectedDelegate(IntPtr physicsScene, float step);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x06000536 RID: 1334
		private delegate bool IsTouching_TwoCollidersWithFilter_InjectedDelegate(IntPtr collider1, IntPtr collider2, IntPtr contactFilter);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x06000538 RID: 1336
		private delegate bool IsTouching_SingleColliderWithFilter_InjectedDelegate(IntPtr collider, IntPtr contactFilter);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x0600053A RID: 1338
		private delegate void ClosestPoint_Collider_InjectedDelegate(IntPtr position, IntPtr collider, [Out] IntPtr ret);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x0600053C RID: 1340
		private delegate void ClosestPoint_Rigidbody_InjectedDelegate(IntPtr position, IntPtr rigidbody, [Out] IntPtr ret);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x0600053E RID: 1342
		private delegate IntPtr LinecastAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr start, IntPtr end, IntPtr contactFilter);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x06000540 RID: 1344
		private delegate IntPtr RaycastAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr direction, float distance, IntPtr contactFilter);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x06000542 RID: 1346
		private delegate IntPtr CircleCastAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, float radius, IntPtr direction, float distance, IntPtr contactFilter);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x06000544 RID: 1348
		private delegate IntPtr BoxCastAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, float angle, IntPtr direction, float distance, IntPtr contactFilter);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x06000546 RID: 1350
		private delegate IntPtr CapsuleCastAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr origin, IntPtr size, CapsuleDirection2D capsuleDirection, float angle, IntPtr direction, float distance, IntPtr contactFilter);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x06000548 RID: 1352
		private delegate IntPtr OverlapPointAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr contactFilter);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x0600054A RID: 1354
		private delegate IntPtr OverlapCircleAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, float radius, IntPtr contactFilter);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x0600054C RID: 1356
		private delegate IntPtr OverlapBoxAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr size, float angle, IntPtr contactFilter);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x0600054E RID: 1358
		private delegate IntPtr OverlapCapsuleAll_Internal_InjectedDelegate(IntPtr physicsScene, IntPtr point, IntPtr size, CapsuleDirection2D direction, float angle, IntPtr contactFilter);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x06000550 RID: 1360
		private delegate int GetColliderContactsArray_InjectedDelegate(IntPtr collider, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x06000552 RID: 1362
		private delegate int GetColliderColliderContactsArray_InjectedDelegate(IntPtr collider1, IntPtr collider2, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000554 RID: 1364
		private delegate int GetRigidbodyContactsArray_InjectedDelegate(IntPtr rigidbody, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x06000556 RID: 1366
		private delegate int GetColliderContactsCollidersOnlyArray_InjectedDelegate(IntPtr collider, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000558 RID: 1368
		private delegate int GetRigidbodyContactsCollidersOnlyArray_InjectedDelegate(IntPtr rigidbody, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x0600055A RID: 1370
		private delegate int GetColliderContactsList_InjectedDelegate(IntPtr collider, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x0600055C RID: 1372
		private delegate int GetColliderColliderContactsList_InjectedDelegate(IntPtr collider1, IntPtr collider2, IntPtr contactFilter, IntPtr results);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x0600055E RID: 1374
		private delegate int GetRigidbodyContactsList_InjectedDelegate(IntPtr rigidbody, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06000560 RID: 1376
		private delegate int GetColliderContactsCollidersOnlyList_InjectedDelegate(IntPtr collider, IntPtr contactFilter, IntPtr results);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000562 RID: 1378
		private delegate int GetRigidbodyContactsCollidersOnlyList_InjectedDelegate(IntPtr rigidbody, IntPtr contactFilter, IntPtr results);
	}
}
