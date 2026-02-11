using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public class Rigidbody : Component
	{
		// Token: 0x06000182 RID: 386 RVA: 0x00007F44 File Offset: 0x00006144
		// Note: this type is marked as 'beforefieldinit'.
		static Rigidbody()
		{
			Il2CppClassPointerStore<Rigidbody>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Rigidbody");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr);
			Rigidbody.NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663357);
			Rigidbody.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663358);
			Rigidbody.NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663359);
			Rigidbody.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663360);
			Rigidbody.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663361);
			Rigidbody.NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663362);
			Rigidbody.NativeMethodInfoPtr_MoveRotation_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663363);
			Rigidbody.NativeMethodInfoPtr_AddForce_Public_Void_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663364);
			Rigidbody.NativeMethodInfoPtr_AddForce_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663365);
			Rigidbody.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663366);
			Rigidbody.NativeMethodInfoPtr_get_velocity_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663367);
			Rigidbody.NativeMethodInfoPtr_set_velocity_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663368);
			Rigidbody.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663369);
			Rigidbody.NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663370);
			Rigidbody.NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663371);
			Rigidbody.NativeMethodInfoPtr_MovePosition_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663372);
			Rigidbody.NativeMethodInfoPtr_MoveRotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663373);
			Rigidbody.NativeMethodInfoPtr_AddForce_Injected_Private_Void_byref_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663374);
			Rigidbody.get_dragDelegateField = IL2CPP.ResolveICall<Rigidbody.get_dragDelegate>("UnityEngine.Rigidbody::get_drag");
			Rigidbody.set_dragDelegateField = IL2CPP.ResolveICall<Rigidbody.set_dragDelegate>("UnityEngine.Rigidbody::set_drag");
			Rigidbody.get_angularDragDelegateField = IL2CPP.ResolveICall<Rigidbody.get_angularDragDelegate>("UnityEngine.Rigidbody::get_angularDrag");
			Rigidbody.set_angularDragDelegateField = IL2CPP.ResolveICall<Rigidbody.set_angularDragDelegate>("UnityEngine.Rigidbody::set_angularDrag");
			Rigidbody.get_massDelegateField = IL2CPP.ResolveICall<Rigidbody.get_massDelegate>("UnityEngine.Rigidbody::get_mass");
			Rigidbody.set_massDelegateField = IL2CPP.ResolveICall<Rigidbody.set_massDelegate>("UnityEngine.Rigidbody::set_mass");
			Rigidbody.SetDensityDelegateField = IL2CPP.ResolveICall<Rigidbody.SetDensityDelegate>("UnityEngine.Rigidbody::SetDensity");
			Rigidbody.get_useGravityDelegateField = IL2CPP.ResolveICall<Rigidbody.get_useGravityDelegate>("UnityEngine.Rigidbody::get_useGravity");
			Rigidbody.set_useGravityDelegateField = IL2CPP.ResolveICall<Rigidbody.set_useGravityDelegate>("UnityEngine.Rigidbody::set_useGravity");
			Rigidbody.get_maxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.get_maxDepenetrationVelocityDelegate>("UnityEngine.Rigidbody::get_maxDepenetrationVelocity");
			Rigidbody.set_maxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.set_maxDepenetrationVelocityDelegate>("UnityEngine.Rigidbody::set_maxDepenetrationVelocity");
			Rigidbody.get_isKinematicDelegateField = IL2CPP.ResolveICall<Rigidbody.get_isKinematicDelegate>("UnityEngine.Rigidbody::get_isKinematic");
			Rigidbody.set_isKinematicDelegateField = IL2CPP.ResolveICall<Rigidbody.set_isKinematicDelegate>("UnityEngine.Rigidbody::set_isKinematic");
			Rigidbody.get_freezeRotationDelegateField = IL2CPP.ResolveICall<Rigidbody.get_freezeRotationDelegate>("UnityEngine.Rigidbody::get_freezeRotation");
			Rigidbody.set_freezeRotationDelegateField = IL2CPP.ResolveICall<Rigidbody.set_freezeRotationDelegate>("UnityEngine.Rigidbody::set_freezeRotation");
			Rigidbody.get_constraintsDelegateField = IL2CPP.ResolveICall<Rigidbody.get_constraintsDelegate>("UnityEngine.Rigidbody::get_constraints");
			Rigidbody.set_constraintsDelegateField = IL2CPP.ResolveICall<Rigidbody.set_constraintsDelegate>("UnityEngine.Rigidbody::set_constraints");
			Rigidbody.get_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<Rigidbody.get_collisionDetectionModeDelegate>("UnityEngine.Rigidbody::get_collisionDetectionMode");
			Rigidbody.set_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<Rigidbody.set_collisionDetectionModeDelegate>("UnityEngine.Rigidbody::set_collisionDetectionMode");
			Rigidbody.get_automaticCenterOfMassDelegateField = IL2CPP.ResolveICall<Rigidbody.get_automaticCenterOfMassDelegate>("UnityEngine.Rigidbody::get_automaticCenterOfMass");
			Rigidbody.set_automaticCenterOfMassDelegateField = IL2CPP.ResolveICall<Rigidbody.set_automaticCenterOfMassDelegate>("UnityEngine.Rigidbody::set_automaticCenterOfMass");
			Rigidbody.get_automaticInertiaTensorDelegateField = IL2CPP.ResolveICall<Rigidbody.get_automaticInertiaTensorDelegate>("UnityEngine.Rigidbody::get_automaticInertiaTensor");
			Rigidbody.set_automaticInertiaTensorDelegateField = IL2CPP.ResolveICall<Rigidbody.set_automaticInertiaTensorDelegate>("UnityEngine.Rigidbody::set_automaticInertiaTensor");
			Rigidbody.get_detectCollisionsDelegateField = IL2CPP.ResolveICall<Rigidbody.get_detectCollisionsDelegate>("UnityEngine.Rigidbody::get_detectCollisions");
			Rigidbody.set_detectCollisionsDelegateField = IL2CPP.ResolveICall<Rigidbody.set_detectCollisionsDelegate>("UnityEngine.Rigidbody::set_detectCollisions");
			Rigidbody.get_interpolationDelegateField = IL2CPP.ResolveICall<Rigidbody.get_interpolationDelegate>("UnityEngine.Rigidbody::get_interpolation");
			Rigidbody.set_interpolationDelegateField = IL2CPP.ResolveICall<Rigidbody.set_interpolationDelegate>("UnityEngine.Rigidbody::set_interpolation");
			Rigidbody.get_solverIterationsDelegateField = IL2CPP.ResolveICall<Rigidbody.get_solverIterationsDelegate>("UnityEngine.Rigidbody::get_solverIterations");
			Rigidbody.set_solverIterationsDelegateField = IL2CPP.ResolveICall<Rigidbody.set_solverIterationsDelegate>("UnityEngine.Rigidbody::set_solverIterations");
			Rigidbody.get_sleepThresholdDelegateField = IL2CPP.ResolveICall<Rigidbody.get_sleepThresholdDelegate>("UnityEngine.Rigidbody::get_sleepThreshold");
			Rigidbody.set_sleepThresholdDelegateField = IL2CPP.ResolveICall<Rigidbody.set_sleepThresholdDelegate>("UnityEngine.Rigidbody::set_sleepThreshold");
			Rigidbody.get_maxAngularVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.get_maxAngularVelocityDelegate>("UnityEngine.Rigidbody::get_maxAngularVelocity");
			Rigidbody.set_maxAngularVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.set_maxAngularVelocityDelegate>("UnityEngine.Rigidbody::set_maxAngularVelocity");
			Rigidbody.get_maxLinearVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.get_maxLinearVelocityDelegate>("UnityEngine.Rigidbody::get_maxLinearVelocity");
			Rigidbody.set_maxLinearVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody.set_maxLinearVelocityDelegate>("UnityEngine.Rigidbody::set_maxLinearVelocity");
			Rigidbody.SleepDelegateField = IL2CPP.ResolveICall<Rigidbody.SleepDelegate>("UnityEngine.Rigidbody::Sleep");
			Rigidbody.IsSleepingDelegateField = IL2CPP.ResolveICall<Rigidbody.IsSleepingDelegate>("UnityEngine.Rigidbody::IsSleeping");
			Rigidbody.WakeUpDelegateField = IL2CPP.ResolveICall<Rigidbody.WakeUpDelegate>("UnityEngine.Rigidbody::WakeUp");
			Rigidbody.ResetCenterOfMassDelegateField = IL2CPP.ResolveICall<Rigidbody.ResetCenterOfMassDelegate>("UnityEngine.Rigidbody::ResetCenterOfMass");
			Rigidbody.ResetInertiaTensorDelegateField = IL2CPP.ResolveICall<Rigidbody.ResetInertiaTensorDelegate>("UnityEngine.Rigidbody::ResetInertiaTensor");
			Rigidbody.get_solverVelocityIterationsDelegateField = IL2CPP.ResolveICall<Rigidbody.get_solverVelocityIterationsDelegate>("UnityEngine.Rigidbody::get_solverVelocityIterations");
			Rigidbody.set_solverVelocityIterationsDelegateField = IL2CPP.ResolveICall<Rigidbody.set_solverVelocityIterationsDelegate>("UnityEngine.Rigidbody::set_solverVelocityIterations");
			Rigidbody.get_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_angularVelocity_InjectedDelegate>("UnityEngine.Rigidbody::get_angularVelocity_Injected");
			Rigidbody.set_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_angularVelocity_InjectedDelegate>("UnityEngine.Rigidbody::set_angularVelocity_Injected");
			Rigidbody.get_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_centerOfMass_InjectedDelegate>("UnityEngine.Rigidbody::get_centerOfMass_Injected");
			Rigidbody.set_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_centerOfMass_InjectedDelegate>("UnityEngine.Rigidbody::set_centerOfMass_Injected");
			Rigidbody.get_worldCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_worldCenterOfMass_InjectedDelegate>("UnityEngine.Rigidbody::get_worldCenterOfMass_Injected");
			Rigidbody.get_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_inertiaTensorRotation_InjectedDelegate>("UnityEngine.Rigidbody::get_inertiaTensorRotation_Injected");
			Rigidbody.set_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_inertiaTensorRotation_InjectedDelegate>("UnityEngine.Rigidbody::set_inertiaTensorRotation_Injected");
			Rigidbody.get_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_inertiaTensor_InjectedDelegate>("UnityEngine.Rigidbody::get_inertiaTensor_Injected");
			Rigidbody.set_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_inertiaTensor_InjectedDelegate>("UnityEngine.Rigidbody::set_inertiaTensor_Injected");
			Rigidbody.set_position_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_position_InjectedDelegate>("UnityEngine.Rigidbody::set_position_Injected");
			Rigidbody.Move_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.Move_InjectedDelegate>("UnityEngine.Rigidbody::Move_Injected");
			Rigidbody.GetRelativePointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.GetRelativePointVelocity_InjectedDelegate>("UnityEngine.Rigidbody::GetRelativePointVelocity_Injected");
			Rigidbody.GetPointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.GetPointVelocity_InjectedDelegate>("UnityEngine.Rigidbody::GetPointVelocity_Injected");
			Rigidbody.get_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_excludeLayers_InjectedDelegate>("UnityEngine.Rigidbody::get_excludeLayers_Injected");
			Rigidbody.set_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_excludeLayers_InjectedDelegate>("UnityEngine.Rigidbody::set_excludeLayers_Injected");
			Rigidbody.get_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.get_includeLayers_InjectedDelegate>("UnityEngine.Rigidbody::get_includeLayers_Injected");
			Rigidbody.set_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.set_includeLayers_InjectedDelegate>("UnityEngine.Rigidbody::set_includeLayers_Injected");
			Rigidbody.GetAccumulatedForce_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.GetAccumulatedForce_InjectedDelegate>("UnityEngine.Rigidbody::GetAccumulatedForce_Injected");
			Rigidbody.GetAccumulatedTorque_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.GetAccumulatedTorque_InjectedDelegate>("UnityEngine.Rigidbody::GetAccumulatedTorque_Injected");
			Rigidbody.AddRelativeForce_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddRelativeForce_InjectedDelegate>("UnityEngine.Rigidbody::AddRelativeForce_Injected");
			Rigidbody.AddTorque_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddTorque_InjectedDelegate>("UnityEngine.Rigidbody::AddTorque_Injected");
			Rigidbody.AddRelativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddRelativeTorque_InjectedDelegate>("UnityEngine.Rigidbody::AddRelativeTorque_Injected");
			Rigidbody.AddForceAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddForceAtPosition_InjectedDelegate>("UnityEngine.Rigidbody::AddForceAtPosition_Injected");
			Rigidbody.AddExplosionForce_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.AddExplosionForce_InjectedDelegate>("UnityEngine.Rigidbody::AddExplosionForce_Injected");
			Rigidbody.Internal_ClosestPointOnBounds_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.Internal_ClosestPointOnBounds_InjectedDelegate>("UnityEngine.Rigidbody::Internal_ClosestPointOnBounds_Injected");
			Rigidbody.SweepTest_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.SweepTest_InjectedDelegate>("UnityEngine.Rigidbody::SweepTest_Injected");
			Rigidbody.Internal_SweepTestAll_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody.Internal_SweepTestAll_InjectedDelegate>("UnityEngine.Rigidbody::Internal_SweepTestAll_Injected");
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000084E8 File Offset: 0x000066E8
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00008524 File Offset: 0x00006724
		public unsafe Vector3 velocity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1255060, RefRangeEnd = 1255061, XrefRangeStart = 1255058, XrefRangeEnd = 1255060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1255063, RefRangeEnd = 1255064, XrefRangeStart = 1255061, XrefRangeEnd = 1255063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00008564 File Offset: 0x00006764
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002B2A File Offset: 0x00000D2A
		public unsafe Vector3 position
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1255066, RefRangeEnd = 1255077, XrefRangeStart = 1255064, XrefRangeEnd = 1255066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_get_position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_position_Injected(ref value);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000085A0 File Offset: 0x000067A0
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000085DC File Offset: 0x000067DC
		public unsafe Quaternion rotation
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1255079, RefRangeEnd = 1255081, XrefRangeStart = 1255077, XrefRangeEnd = 1255079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255081, XrefRangeEnd = 1255083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000861C File Offset: 0x0000681C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1255085, RefRangeEnd = 1255088, XrefRangeStart = 1255083, XrefRangeEnd = 1255085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000865C File Offset: 0x0000685C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255088, XrefRangeEnd = 1255090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRotation(Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_MoveRotation_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000869C File Offset: 0x0000689C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255090, XrefRangeEnd = 1255092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddForce(Vector3 force, ForceMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref force;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_AddForce_Public_Void_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000086E8 File Offset: 0x000068E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1255094, RefRangeEnd = 1255095, XrefRangeStart = 1255092, XrefRangeEnd = 1255094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddForce(Vector3 force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_AddForce_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00008728 File Offset: 0x00006928
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rigidbody()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00008764 File Offset: 0x00006964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255095, XrefRangeEnd = 1255097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_velocity_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_get_velocity_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000087A4 File Offset: 0x000069A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255097, XrefRangeEnd = 1255099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_velocity_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_set_velocity_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000087E4 File Offset: 0x000069E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255099, XrefRangeEnd = 1255101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_position_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00008824 File Offset: 0x00006A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255101, XrefRangeEnd = 1255103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rotation_Injected(out Quaternion ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00008864 File Offset: 0x00006A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255103, XrefRangeEnd = 1255105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_rotation_Injected(ref Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000088A4 File Offset: 0x00006AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255105, XrefRangeEnd = 1255107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePosition_Injected(ref Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_MovePosition_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000088E4 File Offset: 0x00006AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255107, XrefRangeEnd = 1255109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRotation_Injected(ref Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_MoveRotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00008924 File Offset: 0x00006B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255109, XrefRangeEnd = 1255111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddForce_Injected(ref Vector3 force, ForceMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &force;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rigidbody.NativeMethodInfoPtr_AddForce_Injected_Private_Void_byref_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000292A File Offset: 0x00000B2A
		public Rigidbody(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00008970 File Offset: 0x00006B70
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00002933 File Offset: 0x00000B33
		public Vector3 angularVelocity
		{
			get
			{
				Vector3 vector;
				this.get_angularVelocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_angularVelocity_Injected(ref value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000293D File Offset: 0x00000B3D
		// (set) Token: 0x06000199 RID: 409 RVA: 0x0000294F File Offset: 0x00000B4F
		public float drag
		{
			get
			{
				return Rigidbody.get_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00002962 File Offset: 0x00000B62
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002974 File Offset: 0x00000B74
		public float angularDrag
		{
			get
			{
				return Rigidbody.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00002987 File Offset: 0x00000B87
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002999 File Offset: 0x00000B99
		public float mass
		{
			get
			{
				return Rigidbody.get_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000029AC File Offset: 0x00000BAC
		public void SetDensity(float density)
		{
			Rigidbody.SetDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), density);
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000029BF File Offset: 0x00000BBF
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000029D1 File Offset: 0x00000BD1
		public bool useGravity
		{
			get
			{
				return Rigidbody.get_useGravityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_useGravityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000029E4 File Offset: 0x00000BE4
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000029F6 File Offset: 0x00000BF6
		public float maxDepenetrationVelocity
		{
			get
			{
				return Rigidbody.get_maxDepenetrationVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_maxDepenetrationVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002A09 File Offset: 0x00000C09
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002A1B File Offset: 0x00000C1B
		public bool isKinematic
		{
			get
			{
				return Rigidbody.get_isKinematicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_isKinematicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00002A2E File Offset: 0x00000C2E
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002A40 File Offset: 0x00000C40
		public bool freezeRotation
		{
			get
			{
				return Rigidbody.get_freezeRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_freezeRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002A53 File Offset: 0x00000C53
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002A65 File Offset: 0x00000C65
		public RigidbodyConstraints constraints
		{
			get
			{
				return Rigidbody.get_constraintsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_constraintsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002A78 File Offset: 0x00000C78
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002A8A File Offset: 0x00000C8A
		public CollisionDetectionMode collisionDetectionMode
		{
			get
			{
				return Rigidbody.get_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00002A9D File Offset: 0x00000C9D
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002AAF File Offset: 0x00000CAF
		public bool automaticCenterOfMass
		{
			get
			{
				return Rigidbody.get_automaticCenterOfMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_automaticCenterOfMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00008988 File Offset: 0x00006B88
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002AC2 File Offset: 0x00000CC2
		public Vector3 centerOfMass
		{
			get
			{
				Vector3 vector;
				this.get_centerOfMass_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_centerOfMass_Injected(ref value);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001AF RID: 431 RVA: 0x000089A0 File Offset: 0x00006BA0
		public Vector3 worldCenterOfMass
		{
			get
			{
				Vector3 vector;
				this.get_worldCenterOfMass_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00002ACC File Offset: 0x00000CCC
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002ADE File Offset: 0x00000CDE
		public bool automaticInertiaTensor
		{
			get
			{
				return Rigidbody.get_automaticInertiaTensorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_automaticInertiaTensorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000089B8 File Offset: 0x00006BB8
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002AF1 File Offset: 0x00000CF1
		public Quaternion inertiaTensorRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_inertiaTensorRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_inertiaTensorRotation_Injected(ref value);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000089D0 File Offset: 0x00006BD0
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002AFB File Offset: 0x00000CFB
		public Vector3 inertiaTensor
		{
			get
			{
				Vector3 vector;
				this.get_inertiaTensor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_inertiaTensor_Injected(ref value);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00002B05 File Offset: 0x00000D05
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002B17 File Offset: 0x00000D17
		public bool detectCollisions
		{
			get
			{
				return Rigidbody.get_detectCollisionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_detectCollisionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00002B34 File Offset: 0x00000D34
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002B46 File Offset: 0x00000D46
		public RigidbodyInterpolation interpolation
		{
			get
			{
				return Rigidbody.get_interpolationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_interpolationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00002B59 File Offset: 0x00000D59
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002B6B File Offset: 0x00000D6B
		public int solverIterations
		{
			get
			{
				return Rigidbody.get_solverIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_solverIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00002B7E File Offset: 0x00000D7E
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002B90 File Offset: 0x00000D90
		public float sleepThreshold
		{
			get
			{
				return Rigidbody.get_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00002BA3 File Offset: 0x00000DA3
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002BB5 File Offset: 0x00000DB5
		public float maxAngularVelocity
		{
			get
			{
				return Rigidbody.get_maxAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_maxAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00002BC8 File Offset: 0x00000DC8
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002BDA File Offset: 0x00000DDA
		public float maxLinearVelocity
		{
			get
			{
				return Rigidbody.get_maxLinearVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_maxLinearVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002BED File Offset: 0x00000DED
		public void Move(Vector3 position, Quaternion rotation)
		{
			this.Move_Injected(ref position, ref rotation);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002BF9 File Offset: 0x00000DF9
		public void Sleep()
		{
			Rigidbody.SleepDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002C0B File Offset: 0x00000E0B
		public bool IsSleeping()
		{
			return Rigidbody.IsSleepingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002C1D File Offset: 0x00000E1D
		public void WakeUp()
		{
			Rigidbody.WakeUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002C2F File Offset: 0x00000E2F
		public void ResetCenterOfMass()
		{
			Rigidbody.ResetCenterOfMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002C41 File Offset: 0x00000E41
		public void ResetInertiaTensor()
		{
			Rigidbody.ResetInertiaTensorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000089E8 File Offset: 0x00006BE8
		public Vector3 GetRelativePointVelocity(Vector3 relativePoint)
		{
			Vector3 vector;
			this.GetRelativePointVelocity_Injected(ref relativePoint, out vector);
			return vector;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00008A00 File Offset: 0x00006C00
		public Vector3 GetPointVelocity(Vector3 worldPoint)
		{
			Vector3 vector;
			this.GetPointVelocity_Injected(ref worldPoint, out vector);
			return vector;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00002C53 File Offset: 0x00000E53
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002C65 File Offset: 0x00000E65
		public int solverVelocityIterations
		{
			get
			{
				return Rigidbody.get_solverVelocityIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody.set_solverVelocityIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00008A18 File Offset: 0x00006C18
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002C78 File Offset: 0x00000E78
		public LayerMask excludeLayers
		{
			get
			{
				LayerMask layerMask;
				this.get_excludeLayers_Injected(out layerMask);
				return layerMask;
			}
			set
			{
				this.set_excludeLayers_Injected(ref value);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00008A30 File Offset: 0x00006C30
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002C82 File Offset: 0x00000E82
		public LayerMask includeLayers
		{
			get
			{
				LayerMask layerMask;
				this.get_includeLayers_Injected(out layerMask);
				return layerMask;
			}
			set
			{
				this.set_includeLayers_Injected(ref value);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00008A48 File Offset: 0x00006C48
		public Vector3 GetAccumulatedForce(float step)
		{
			Vector3 vector;
			this.GetAccumulatedForce_Injected(step, out vector);
			return vector;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00008A60 File Offset: 0x00006C60
		public Vector3 GetAccumulatedForce()
		{
			return this.GetAccumulatedForce(Time.fixedDeltaTime);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00008A80 File Offset: 0x00006C80
		public Vector3 GetAccumulatedTorque(float step)
		{
			Vector3 vector;
			this.GetAccumulatedTorque_Injected(step, out vector);
			return vector;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00008A98 File Offset: 0x00006C98
		public Vector3 GetAccumulatedTorque()
		{
			return this.GetAccumulatedTorque(Time.fixedDeltaTime);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002C8C File Offset: 0x00000E8C
		public void AddForce(float x, float y, float z, ForceMode mode)
		{
			this.AddForce(new Vector3(x, y, z), mode);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002CA0 File Offset: 0x00000EA0
		public void AddForce(float x, float y, float z)
		{
			this.AddForce(new Vector3(x, y, z), ForceMode.Force);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002CB3 File Offset: 0x00000EB3
		public void AddRelativeForce(Vector3 force, ForceMode mode)
		{
			this.AddRelativeForce_Injected(ref force, mode);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002CBE File Offset: 0x00000EBE
		public void AddRelativeForce(Vector3 force)
		{
			this.AddRelativeForce(force, ForceMode.Force);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002CCA File Offset: 0x00000ECA
		public void AddRelativeForce(float x, float y, float z, ForceMode mode)
		{
			this.AddRelativeForce(new Vector3(x, y, z), mode);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002CDE File Offset: 0x00000EDE
		public void AddRelativeForce(float x, float y, float z)
		{
			this.AddRelativeForce(new Vector3(x, y, z), ForceMode.Force);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002CF1 File Offset: 0x00000EF1
		public void AddTorque(Vector3 torque, ForceMode mode)
		{
			this.AddTorque_Injected(ref torque, mode);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002CFC File Offset: 0x00000EFC
		public void AddTorque(Vector3 torque)
		{
			this.AddTorque(torque, ForceMode.Force);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002D08 File Offset: 0x00000F08
		public void AddTorque(float x, float y, float z, ForceMode mode)
		{
			this.AddTorque(new Vector3(x, y, z), mode);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002D1C File Offset: 0x00000F1C
		public void AddTorque(float x, float y, float z)
		{
			this.AddTorque(new Vector3(x, y, z), ForceMode.Force);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002D2F File Offset: 0x00000F2F
		public void AddRelativeTorque(Vector3 torque, ForceMode mode)
		{
			this.AddRelativeTorque_Injected(ref torque, mode);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002D3A File Offset: 0x00000F3A
		public void AddRelativeTorque(Vector3 torque)
		{
			this.AddRelativeTorque(torque, ForceMode.Force);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002D46 File Offset: 0x00000F46
		public void AddRelativeTorque(float x, float y, float z, ForceMode mode)
		{
			this.AddRelativeTorque(new Vector3(x, y, z), mode);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002D5A File Offset: 0x00000F5A
		public void AddRelativeTorque(float x, float y, float z)
		{
			this.AddRelativeTorque(x, y, z, ForceMode.Force);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002D68 File Offset: 0x00000F68
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode)
		{
			this.AddForceAtPosition_Injected(ref force, ref position, mode);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002D75 File Offset: 0x00000F75
		public void AddForceAtPosition(Vector3 force, Vector3 position)
		{
			this.AddForceAtPosition(force, position, ForceMode.Force);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002D82 File Offset: 0x00000F82
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode)
		{
			this.AddExplosionForce_Injected(explosionForce, ref explosionPosition, explosionRadius, upwardsModifier, mode);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002D92 File Offset: 0x00000F92
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier)
		{
			this.AddExplosionForce(explosionForce, explosionPosition, explosionRadius, upwardsModifier, ForceMode.Force);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002DA2 File Offset: 0x00000FA2
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius)
		{
			this.AddExplosionForce(explosionForce, explosionPosition, explosionRadius, 0f, ForceMode.Force);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002DB5 File Offset: 0x00000FB5
		public void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance)
		{
			this.Internal_ClosestPointOnBounds_Injected(ref point, ref outPos, ref distance);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00008AB8 File Offset: 0x00006CB8
		public Vector3 ClosestPointOnBounds(Vector3 position)
		{
			float num = 0f;
			Vector3 zero = Vector3.zero;
			this.Internal_ClosestPointOnBounds(position, ref zero, ref num);
			return zero;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00008AE4 File Offset: 0x00006CE4
		public RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit)
		{
			RaycastHit raycastHit;
			this.SweepTest_Injected(ref direction, maxDistance, queryTriggerInteraction, ref hasHit, out raycastHit);
			return raycastHit;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00008B00 File Offset: 0x00006D00
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
		{
			float magnitude = direction.magnitude;
			bool flag = magnitude > float.Epsilon;
			bool flag3;
			if (flag)
			{
				Vector3 vector = direction / magnitude;
				bool flag2 = false;
				hitInfo = this.SweepTest(vector, maxDistance, queryTriggerInteraction, ref flag2);
				flag3 = flag2;
			}
			else
			{
				hitInfo = default(RaycastHit);
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00008B54 File Offset: 0x00006D54
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			return this.SweepTest(direction, out hitInfo, maxDistance, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00008B70 File Offset: 0x00006D70
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo)
		{
			return this.SweepTest(direction, out hitInfo, float.PositiveInfinity, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002DC1 File Offset: 0x00000FC1
		public Il2CppStructArray<RaycastHit> Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
		{
			return this.Internal_SweepTestAll_Injected(ref direction, maxDistance, queryTriggerInteraction);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002DCD File Offset: 0x00000FCD
		public Il2CppStructArray<RaycastHit> SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00008B90 File Offset: 0x00006D90
		public Il2CppStructArray<RaycastHit> SweepTestAll(Vector3 direction, float maxDistance)
		{
			return this.SweepTestAll(direction, maxDistance, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00008BAC File Offset: 0x00006DAC
		public Il2CppStructArray<RaycastHit> SweepTestAll(Vector3 direction)
		{
			return this.SweepTestAll(direction, float.PositiveInfinity, QueryTriggerInteraction.UseGlobal);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00008BCC File Offset: 0x00006DCC
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002DDA File Offset: 0x00000FDA
		public float sleepVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00008BE4 File Offset: 0x00006DE4
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002DDD File Offset: 0x00000FDD
		public float sleepAngularVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public void SetMaxAngularVelocity(float a)
		{
			this.maxAngularVelocity = a;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00008BFC File Offset: 0x00006DFC
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002DEB File Offset: 0x00000FEB
		public bool useConeFriction
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00008C10 File Offset: 0x00006E10
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00002DEE File Offset: 0x00000FEE
		public int solverIterationCount
		{
			get
			{
				return this.solverIterations;
			}
			set
			{
				this.solverIterations = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00008C28 File Offset: 0x00006E28
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00002DF9 File Offset: 0x00000FF9
		public int solverVelocityIterationCount
		{
			get
			{
				return this.solverVelocityIterations;
			}
			set
			{
				this.solverVelocityIterations = value;
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002E04 File Offset: 0x00001004
		public void get_angularVelocity_Injected(out Vector3 ret)
		{
			Rigidbody.get_angularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002E17 File Offset: 0x00001017
		public void set_angularVelocity_Injected(ref Vector3 value)
		{
			Rigidbody.set_angularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002E2A File Offset: 0x0000102A
		public void get_centerOfMass_Injected(out Vector3 ret)
		{
			Rigidbody.get_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002E3D File Offset: 0x0000103D
		public void set_centerOfMass_Injected(ref Vector3 value)
		{
			Rigidbody.set_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002E50 File Offset: 0x00001050
		public void get_worldCenterOfMass_Injected(out Vector3 ret)
		{
			Rigidbody.get_worldCenterOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002E63 File Offset: 0x00001063
		public void get_inertiaTensorRotation_Injected(out Quaternion ret)
		{
			Rigidbody.get_inertiaTensorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002E76 File Offset: 0x00001076
		public void set_inertiaTensorRotation_Injected(ref Quaternion value)
		{
			Rigidbody.set_inertiaTensorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002E89 File Offset: 0x00001089
		public void get_inertiaTensor_Injected(out Vector3 ret)
		{
			Rigidbody.get_inertiaTensor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002E9C File Offset: 0x0000109C
		public void set_inertiaTensor_Injected(ref Vector3 value)
		{
			Rigidbody.set_inertiaTensor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002EAF File Offset: 0x000010AF
		public void set_position_Injected(ref Vector3 value)
		{
			Rigidbody.set_position_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002EC2 File Offset: 0x000010C2
		public void Move_Injected(ref Vector3 position, ref Quaternion rotation)
		{
			Rigidbody.Move_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref rotation);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002ED6 File Offset: 0x000010D6
		public void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret)
		{
			Rigidbody.GetRelativePointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativePoint, out ret);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002EEA File Offset: 0x000010EA
		public void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret)
		{
			Rigidbody.GetPointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref worldPoint, out ret);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002EFE File Offset: 0x000010FE
		public void get_excludeLayers_Injected(out LayerMask ret)
		{
			Rigidbody.get_excludeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002F11 File Offset: 0x00001111
		public void set_excludeLayers_Injected(ref LayerMask value)
		{
			Rigidbody.set_excludeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002F24 File Offset: 0x00001124
		public void get_includeLayers_Injected(out LayerMask ret)
		{
			Rigidbody.get_includeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002F37 File Offset: 0x00001137
		public void set_includeLayers_Injected(ref LayerMask value)
		{
			Rigidbody.set_includeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002F4A File Offset: 0x0000114A
		public void GetAccumulatedForce_Injected(float step, out Vector3 ret)
		{
			Rigidbody.GetAccumulatedForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), step, out ret);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002F5E File Offset: 0x0000115E
		public void GetAccumulatedTorque_Injected(float step, out Vector3 ret)
		{
			Rigidbody.GetAccumulatedTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), step, out ret);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002F72 File Offset: 0x00001172
		public void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode)
		{
			Rigidbody.AddRelativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, mode);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002F86 File Offset: 0x00001186
		public void AddTorque_Injected(ref Vector3 torque, ForceMode mode)
		{
			Rigidbody.AddTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref torque, mode);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002F9A File Offset: 0x0000119A
		public void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode)
		{
			Rigidbody.AddRelativeTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref torque, mode);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002FAE File Offset: 0x000011AE
		public void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode)
		{
			Rigidbody.AddForceAtPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, ref position, mode);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002FC3 File Offset: 0x000011C3
		public void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode)
		{
			Rigidbody.AddExplosionForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), explosionForce, ref explosionPosition, explosionRadius, upwardsModifier, mode);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002FDC File Offset: 0x000011DC
		public void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance)
		{
			Rigidbody.Internal_ClosestPointOnBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, ref outPos, ref distance);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002FF1 File Offset: 0x000011F1
		public void SweepTest_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret)
		{
			Rigidbody.SweepTest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, maxDistance, queryTriggerInteraction, ref hasHit, out ret);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00008C40 File Offset: 0x00006E40
		public Il2CppStructArray<RaycastHit> Internal_SweepTestAll_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
		{
			IntPtr intPtr = Rigidbody.Internal_SweepTestAll_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, maxDistance, queryTriggerInteraction);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_MoveRotation_Public_Void_Quaternion_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_AddForce_Public_Void_Vector3_ForceMode_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_AddForce_Public_Void_Vector3_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_get_velocity_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_set_velocity_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_MovePosition_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_MoveRotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_AddForce_Injected_Private_Void_byref_Vector3_ForceMode_0;

		// Token: 0x040000D5 RID: 213
		private static readonly Rigidbody.get_dragDelegate get_dragDelegateField;

		// Token: 0x040000D6 RID: 214
		private static readonly Rigidbody.set_dragDelegate set_dragDelegateField;

		// Token: 0x040000D7 RID: 215
		private static readonly Rigidbody.get_angularDragDelegate get_angularDragDelegateField;

		// Token: 0x040000D8 RID: 216
		private static readonly Rigidbody.set_angularDragDelegate set_angularDragDelegateField;

		// Token: 0x040000D9 RID: 217
		private static readonly Rigidbody.get_massDelegate get_massDelegateField;

		// Token: 0x040000DA RID: 218
		private static readonly Rigidbody.set_massDelegate set_massDelegateField;

		// Token: 0x040000DB RID: 219
		private static readonly Rigidbody.SetDensityDelegate SetDensityDelegateField;

		// Token: 0x040000DC RID: 220
		private static readonly Rigidbody.get_useGravityDelegate get_useGravityDelegateField;

		// Token: 0x040000DD RID: 221
		private static readonly Rigidbody.set_useGravityDelegate set_useGravityDelegateField;

		// Token: 0x040000DE RID: 222
		private static readonly Rigidbody.get_maxDepenetrationVelocityDelegate get_maxDepenetrationVelocityDelegateField;

		// Token: 0x040000DF RID: 223
		private static readonly Rigidbody.set_maxDepenetrationVelocityDelegate set_maxDepenetrationVelocityDelegateField;

		// Token: 0x040000E0 RID: 224
		private static readonly Rigidbody.get_isKinematicDelegate get_isKinematicDelegateField;

		// Token: 0x040000E1 RID: 225
		private static readonly Rigidbody.set_isKinematicDelegate set_isKinematicDelegateField;

		// Token: 0x040000E2 RID: 226
		private static readonly Rigidbody.get_freezeRotationDelegate get_freezeRotationDelegateField;

		// Token: 0x040000E3 RID: 227
		private static readonly Rigidbody.set_freezeRotationDelegate set_freezeRotationDelegateField;

		// Token: 0x040000E4 RID: 228
		private static readonly Rigidbody.get_constraintsDelegate get_constraintsDelegateField;

		// Token: 0x040000E5 RID: 229
		private static readonly Rigidbody.set_constraintsDelegate set_constraintsDelegateField;

		// Token: 0x040000E6 RID: 230
		private static readonly Rigidbody.get_collisionDetectionModeDelegate get_collisionDetectionModeDelegateField;

		// Token: 0x040000E7 RID: 231
		private static readonly Rigidbody.set_collisionDetectionModeDelegate set_collisionDetectionModeDelegateField;

		// Token: 0x040000E8 RID: 232
		private static readonly Rigidbody.get_automaticCenterOfMassDelegate get_automaticCenterOfMassDelegateField;

		// Token: 0x040000E9 RID: 233
		private static readonly Rigidbody.set_automaticCenterOfMassDelegate set_automaticCenterOfMassDelegateField;

		// Token: 0x040000EA RID: 234
		private static readonly Rigidbody.get_automaticInertiaTensorDelegate get_automaticInertiaTensorDelegateField;

		// Token: 0x040000EB RID: 235
		private static readonly Rigidbody.set_automaticInertiaTensorDelegate set_automaticInertiaTensorDelegateField;

		// Token: 0x040000EC RID: 236
		private static readonly Rigidbody.get_detectCollisionsDelegate get_detectCollisionsDelegateField;

		// Token: 0x040000ED RID: 237
		private static readonly Rigidbody.set_detectCollisionsDelegate set_detectCollisionsDelegateField;

		// Token: 0x040000EE RID: 238
		private static readonly Rigidbody.get_interpolationDelegate get_interpolationDelegateField;

		// Token: 0x040000EF RID: 239
		private static readonly Rigidbody.set_interpolationDelegate set_interpolationDelegateField;

		// Token: 0x040000F0 RID: 240
		private static readonly Rigidbody.get_solverIterationsDelegate get_solverIterationsDelegateField;

		// Token: 0x040000F1 RID: 241
		private static readonly Rigidbody.set_solverIterationsDelegate set_solverIterationsDelegateField;

		// Token: 0x040000F2 RID: 242
		private static readonly Rigidbody.get_sleepThresholdDelegate get_sleepThresholdDelegateField;

		// Token: 0x040000F3 RID: 243
		private static readonly Rigidbody.set_sleepThresholdDelegate set_sleepThresholdDelegateField;

		// Token: 0x040000F4 RID: 244
		private static readonly Rigidbody.get_maxAngularVelocityDelegate get_maxAngularVelocityDelegateField;

		// Token: 0x040000F5 RID: 245
		private static readonly Rigidbody.set_maxAngularVelocityDelegate set_maxAngularVelocityDelegateField;

		// Token: 0x040000F6 RID: 246
		private static readonly Rigidbody.get_maxLinearVelocityDelegate get_maxLinearVelocityDelegateField;

		// Token: 0x040000F7 RID: 247
		private static readonly Rigidbody.set_maxLinearVelocityDelegate set_maxLinearVelocityDelegateField;

		// Token: 0x040000F8 RID: 248
		private static readonly Rigidbody.SleepDelegate SleepDelegateField;

		// Token: 0x040000F9 RID: 249
		private static readonly Rigidbody.IsSleepingDelegate IsSleepingDelegateField;

		// Token: 0x040000FA RID: 250
		private static readonly Rigidbody.WakeUpDelegate WakeUpDelegateField;

		// Token: 0x040000FB RID: 251
		private static readonly Rigidbody.ResetCenterOfMassDelegate ResetCenterOfMassDelegateField;

		// Token: 0x040000FC RID: 252
		private static readonly Rigidbody.ResetInertiaTensorDelegate ResetInertiaTensorDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly Rigidbody.get_solverVelocityIterationsDelegate get_solverVelocityIterationsDelegateField;

		// Token: 0x040000FE RID: 254
		private static readonly Rigidbody.set_solverVelocityIterationsDelegate set_solverVelocityIterationsDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly Rigidbody.get_angularVelocity_InjectedDelegate get_angularVelocity_InjectedDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly Rigidbody.set_angularVelocity_InjectedDelegate set_angularVelocity_InjectedDelegateField;

		// Token: 0x04000101 RID: 257
		private static readonly Rigidbody.get_centerOfMass_InjectedDelegate get_centerOfMass_InjectedDelegateField;

		// Token: 0x04000102 RID: 258
		private static readonly Rigidbody.set_centerOfMass_InjectedDelegate set_centerOfMass_InjectedDelegateField;

		// Token: 0x04000103 RID: 259
		private static readonly Rigidbody.get_worldCenterOfMass_InjectedDelegate get_worldCenterOfMass_InjectedDelegateField;

		// Token: 0x04000104 RID: 260
		private static readonly Rigidbody.get_inertiaTensorRotation_InjectedDelegate get_inertiaTensorRotation_InjectedDelegateField;

		// Token: 0x04000105 RID: 261
		private static readonly Rigidbody.set_inertiaTensorRotation_InjectedDelegate set_inertiaTensorRotation_InjectedDelegateField;

		// Token: 0x04000106 RID: 262
		private static readonly Rigidbody.get_inertiaTensor_InjectedDelegate get_inertiaTensor_InjectedDelegateField;

		// Token: 0x04000107 RID: 263
		private static readonly Rigidbody.set_inertiaTensor_InjectedDelegate set_inertiaTensor_InjectedDelegateField;

		// Token: 0x04000108 RID: 264
		private static readonly Rigidbody.set_position_InjectedDelegate set_position_InjectedDelegateField;

		// Token: 0x04000109 RID: 265
		private static readonly Rigidbody.Move_InjectedDelegate Move_InjectedDelegateField;

		// Token: 0x0400010A RID: 266
		private static readonly Rigidbody.GetRelativePointVelocity_InjectedDelegate GetRelativePointVelocity_InjectedDelegateField;

		// Token: 0x0400010B RID: 267
		private static readonly Rigidbody.GetPointVelocity_InjectedDelegate GetPointVelocity_InjectedDelegateField;

		// Token: 0x0400010C RID: 268
		private static readonly Rigidbody.get_excludeLayers_InjectedDelegate get_excludeLayers_InjectedDelegateField;

		// Token: 0x0400010D RID: 269
		private static readonly Rigidbody.set_excludeLayers_InjectedDelegate set_excludeLayers_InjectedDelegateField;

		// Token: 0x0400010E RID: 270
		private static readonly Rigidbody.get_includeLayers_InjectedDelegate get_includeLayers_InjectedDelegateField;

		// Token: 0x0400010F RID: 271
		private static readonly Rigidbody.set_includeLayers_InjectedDelegate set_includeLayers_InjectedDelegateField;

		// Token: 0x04000110 RID: 272
		private static readonly Rigidbody.GetAccumulatedForce_InjectedDelegate GetAccumulatedForce_InjectedDelegateField;

		// Token: 0x04000111 RID: 273
		private static readonly Rigidbody.GetAccumulatedTorque_InjectedDelegate GetAccumulatedTorque_InjectedDelegateField;

		// Token: 0x04000112 RID: 274
		private static readonly Rigidbody.AddRelativeForce_InjectedDelegate AddRelativeForce_InjectedDelegateField;

		// Token: 0x04000113 RID: 275
		private static readonly Rigidbody.AddTorque_InjectedDelegate AddTorque_InjectedDelegateField;

		// Token: 0x04000114 RID: 276
		private static readonly Rigidbody.AddRelativeTorque_InjectedDelegate AddRelativeTorque_InjectedDelegateField;

		// Token: 0x04000115 RID: 277
		private static readonly Rigidbody.AddForceAtPosition_InjectedDelegate AddForceAtPosition_InjectedDelegateField;

		// Token: 0x04000116 RID: 278
		private static readonly Rigidbody.AddExplosionForce_InjectedDelegate AddExplosionForce_InjectedDelegateField;

		// Token: 0x04000117 RID: 279
		private static readonly Rigidbody.Internal_ClosestPointOnBounds_InjectedDelegate Internal_ClosestPointOnBounds_InjectedDelegateField;

		// Token: 0x04000118 RID: 280
		private static readonly Rigidbody.SweepTest_InjectedDelegate SweepTest_InjectedDelegateField;

		// Token: 0x04000119 RID: 281
		private static readonly Rigidbody.Internal_SweepTestAll_InjectedDelegate Internal_SweepTestAll_InjectedDelegateField;

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060004C4 RID: 1220
		private delegate float get_dragDelegate(IntPtr @this);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060004C6 RID: 1222
		private delegate void set_dragDelegate(IntPtr @this, float value);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060004C8 RID: 1224
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060004CA RID: 1226
		private delegate void set_angularDragDelegate(IntPtr @this, float value);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060004CC RID: 1228
		private delegate float get_massDelegate(IntPtr @this);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060004CE RID: 1230
		private delegate void set_massDelegate(IntPtr @this, float value);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060004D0 RID: 1232
		private delegate void SetDensityDelegate(IntPtr @this, float density);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060004D2 RID: 1234
		private delegate bool get_useGravityDelegate(IntPtr @this);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060004D4 RID: 1236
		private delegate void set_useGravityDelegate(IntPtr @this, bool value);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060004D6 RID: 1238
		private delegate float get_maxDepenetrationVelocityDelegate(IntPtr @this);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060004D8 RID: 1240
		private delegate void set_maxDepenetrationVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060004DA RID: 1242
		private delegate bool get_isKinematicDelegate(IntPtr @this);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060004DC RID: 1244
		private delegate void set_isKinematicDelegate(IntPtr @this, bool value);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060004DE RID: 1246
		private delegate bool get_freezeRotationDelegate(IntPtr @this);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060004E0 RID: 1248
		private delegate void set_freezeRotationDelegate(IntPtr @this, bool value);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060004E2 RID: 1250
		private delegate RigidbodyConstraints get_constraintsDelegate(IntPtr @this);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060004E4 RID: 1252
		private delegate void set_constraintsDelegate(IntPtr @this, RigidbodyConstraints value);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060004E6 RID: 1254
		private delegate CollisionDetectionMode get_collisionDetectionModeDelegate(IntPtr @this);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060004E8 RID: 1256
		private delegate void set_collisionDetectionModeDelegate(IntPtr @this, CollisionDetectionMode value);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060004EA RID: 1258
		private delegate bool get_automaticCenterOfMassDelegate(IntPtr @this);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060004EC RID: 1260
		private delegate void set_automaticCenterOfMassDelegate(IntPtr @this, bool value);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060004EE RID: 1262
		private delegate bool get_automaticInertiaTensorDelegate(IntPtr @this);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060004F0 RID: 1264
		private delegate void set_automaticInertiaTensorDelegate(IntPtr @this, bool value);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060004F2 RID: 1266
		private delegate bool get_detectCollisionsDelegate(IntPtr @this);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060004F4 RID: 1268
		private delegate void set_detectCollisionsDelegate(IntPtr @this, bool value);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060004F6 RID: 1270
		private delegate RigidbodyInterpolation get_interpolationDelegate(IntPtr @this);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060004F8 RID: 1272
		private delegate void set_interpolationDelegate(IntPtr @this, RigidbodyInterpolation value);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060004FA RID: 1274
		private delegate int get_solverIterationsDelegate(IntPtr @this);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060004FC RID: 1276
		private delegate void set_solverIterationsDelegate(IntPtr @this, int value);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060004FE RID: 1278
		private delegate float get_sleepThresholdDelegate(IntPtr @this);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000500 RID: 1280
		private delegate void set_sleepThresholdDelegate(IntPtr @this, float value);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x06000502 RID: 1282
		private delegate float get_maxAngularVelocityDelegate(IntPtr @this);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000504 RID: 1284
		private delegate void set_maxAngularVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x06000506 RID: 1286
		private delegate float get_maxLinearVelocityDelegate(IntPtr @this);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000508 RID: 1288
		private delegate void set_maxLinearVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x0600050A RID: 1290
		private delegate void SleepDelegate(IntPtr @this);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x0600050C RID: 1292
		private delegate bool IsSleepingDelegate(IntPtr @this);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x0600050E RID: 1294
		private delegate void WakeUpDelegate(IntPtr @this);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000510 RID: 1296
		private delegate void ResetCenterOfMassDelegate(IntPtr @this);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000512 RID: 1298
		private delegate void ResetInertiaTensorDelegate(IntPtr @this);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000514 RID: 1300
		private delegate int get_solverVelocityIterationsDelegate(IntPtr @this);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x06000516 RID: 1302
		private delegate void set_solverVelocityIterationsDelegate(IntPtr @this, int value);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x06000518 RID: 1304
		private delegate void get_angularVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x0600051A RID: 1306
		private delegate void set_angularVelocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x0600051C RID: 1308
		private delegate void get_centerOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x0600051E RID: 1310
		private delegate void set_centerOfMass_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x06000520 RID: 1312
		private delegate void get_worldCenterOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x06000522 RID: 1314
		private delegate void get_inertiaTensorRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x06000524 RID: 1316
		private delegate void set_inertiaTensorRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x06000526 RID: 1318
		private delegate void get_inertiaTensor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x06000528 RID: 1320
		private delegate void set_inertiaTensor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x0600052A RID: 1322
		private delegate void set_position_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x0600052C RID: 1324
		private delegate void Move_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr rotation);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x0600052E RID: 1326
		private delegate void GetRelativePointVelocity_InjectedDelegate(IntPtr @this, IntPtr relativePoint, [Out] IntPtr ret);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x06000530 RID: 1328
		private delegate void GetPointVelocity_InjectedDelegate(IntPtr @this, IntPtr worldPoint, [Out] IntPtr ret);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x06000532 RID: 1330
		private delegate void get_excludeLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x06000534 RID: 1332
		private delegate void set_excludeLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x06000536 RID: 1334
		private delegate void get_includeLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x06000538 RID: 1336
		private delegate void set_includeLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x0600053A RID: 1338
		private delegate void GetAccumulatedForce_InjectedDelegate(IntPtr @this, float step, [Out] IntPtr ret);

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x0600053C RID: 1340
		private delegate void GetAccumulatedTorque_InjectedDelegate(IntPtr @this, float step, [Out] IntPtr ret);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x0600053E RID: 1342
		private delegate void AddRelativeForce_InjectedDelegate(IntPtr @this, IntPtr force, ForceMode mode);

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x06000540 RID: 1344
		private delegate void AddTorque_InjectedDelegate(IntPtr @this, IntPtr torque, ForceMode mode);

		// Token: 0x020000B5 RID: 181
		// (Invoke) Token: 0x06000542 RID: 1346
		private delegate void AddRelativeTorque_InjectedDelegate(IntPtr @this, IntPtr torque, ForceMode mode);

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x06000544 RID: 1348
		private delegate void AddForceAtPosition_InjectedDelegate(IntPtr @this, IntPtr force, IntPtr position, ForceMode mode);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x06000546 RID: 1350
		private delegate void AddExplosionForce_InjectedDelegate(IntPtr @this, float explosionForce, IntPtr explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x06000548 RID: 1352
		private delegate void Internal_ClosestPointOnBounds_InjectedDelegate(IntPtr @this, IntPtr point, IntPtr outPos, IntPtr distance);

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x0600054A RID: 1354
		private delegate void SweepTest_InjectedDelegate(IntPtr @this, IntPtr direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, IntPtr hasHit, [Out] IntPtr ret);

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x0600054C RID: 1356
		private delegate IntPtr Internal_SweepTestAll_InjectedDelegate(IntPtr @this, IntPtr direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction);
	}
}
