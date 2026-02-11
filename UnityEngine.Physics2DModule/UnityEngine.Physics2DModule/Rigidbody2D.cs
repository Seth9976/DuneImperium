using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public sealed class Rigidbody2D : Component
	{
		// Token: 0x06000230 RID: 560 RVA: 0x0000A2B8 File Offset: 0x000084B8
		// Note: this type is marked as 'beforefieldinit'.
		static Rigidbody2D()
		{
			Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Rigidbody2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr);
			Rigidbody2D.get_rotationDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_rotationDelegate>("UnityEngine.Rigidbody2D::get_rotation");
			Rigidbody2D.set_rotationDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_rotationDelegate>("UnityEngine.Rigidbody2D::set_rotation");
			Rigidbody2D.SetRotation_AngleDelegateField = IL2CPP.ResolveICall<Rigidbody2D.SetRotation_AngleDelegate>("UnityEngine.Rigidbody2D::SetRotation_Angle");
			Rigidbody2D.MoveRotation_AngleDelegateField = IL2CPP.ResolveICall<Rigidbody2D.MoveRotation_AngleDelegate>("UnityEngine.Rigidbody2D::MoveRotation_Angle");
			Rigidbody2D.get_angularVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_angularVelocityDelegate>("UnityEngine.Rigidbody2D::get_angularVelocity");
			Rigidbody2D.set_angularVelocityDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_angularVelocityDelegate>("UnityEngine.Rigidbody2D::set_angularVelocity");
			Rigidbody2D.get_useAutoMassDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_useAutoMassDelegate>("UnityEngine.Rigidbody2D::get_useAutoMass");
			Rigidbody2D.set_useAutoMassDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_useAutoMassDelegate>("UnityEngine.Rigidbody2D::set_useAutoMass");
			Rigidbody2D.get_massDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_massDelegate>("UnityEngine.Rigidbody2D::get_mass");
			Rigidbody2D.set_massDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_massDelegate>("UnityEngine.Rigidbody2D::set_mass");
			Rigidbody2D.get_sharedMaterialDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_sharedMaterialDelegate>("UnityEngine.Rigidbody2D::get_sharedMaterial");
			Rigidbody2D.set_sharedMaterialDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_sharedMaterialDelegate>("UnityEngine.Rigidbody2D::set_sharedMaterial");
			Rigidbody2D.get_inertiaDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_inertiaDelegate>("UnityEngine.Rigidbody2D::get_inertia");
			Rigidbody2D.set_inertiaDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_inertiaDelegate>("UnityEngine.Rigidbody2D::set_inertia");
			Rigidbody2D.get_dragDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_dragDelegate>("UnityEngine.Rigidbody2D::get_drag");
			Rigidbody2D.set_dragDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_dragDelegate>("UnityEngine.Rigidbody2D::set_drag");
			Rigidbody2D.get_angularDragDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_angularDragDelegate>("UnityEngine.Rigidbody2D::get_angularDrag");
			Rigidbody2D.set_angularDragDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_angularDragDelegate>("UnityEngine.Rigidbody2D::set_angularDrag");
			Rigidbody2D.get_gravityScaleDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_gravityScaleDelegate>("UnityEngine.Rigidbody2D::get_gravityScale");
			Rigidbody2D.set_gravityScaleDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_gravityScaleDelegate>("UnityEngine.Rigidbody2D::set_gravityScale");
			Rigidbody2D.get_bodyTypeDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_bodyTypeDelegate>("UnityEngine.Rigidbody2D::get_bodyType");
			Rigidbody2D.set_bodyTypeDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_bodyTypeDelegate>("UnityEngine.Rigidbody2D::set_bodyType");
			Rigidbody2D.SetDragBehaviourDelegateField = IL2CPP.ResolveICall<Rigidbody2D.SetDragBehaviourDelegate>("UnityEngine.Rigidbody2D::SetDragBehaviour");
			Rigidbody2D.get_useFullKinematicContactsDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_useFullKinematicContactsDelegate>("UnityEngine.Rigidbody2D::get_useFullKinematicContacts");
			Rigidbody2D.set_useFullKinematicContactsDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_useFullKinematicContactsDelegate>("UnityEngine.Rigidbody2D::set_useFullKinematicContacts");
			Rigidbody2D.get_fixedAngleDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_fixedAngleDelegate>("UnityEngine.Rigidbody2D::get_fixedAngle");
			Rigidbody2D.set_fixedAngleDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_fixedAngleDelegate>("UnityEngine.Rigidbody2D::set_fixedAngle");
			Rigidbody2D.get_freezeRotationDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_freezeRotationDelegate>("UnityEngine.Rigidbody2D::get_freezeRotation");
			Rigidbody2D.set_freezeRotationDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_freezeRotationDelegate>("UnityEngine.Rigidbody2D::set_freezeRotation");
			Rigidbody2D.get_constraintsDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_constraintsDelegate>("UnityEngine.Rigidbody2D::get_constraints");
			Rigidbody2D.set_constraintsDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_constraintsDelegate>("UnityEngine.Rigidbody2D::set_constraints");
			Rigidbody2D.IsSleepingDelegateField = IL2CPP.ResolveICall<Rigidbody2D.IsSleepingDelegate>("UnityEngine.Rigidbody2D::IsSleeping");
			Rigidbody2D.IsAwakeDelegateField = IL2CPP.ResolveICall<Rigidbody2D.IsAwakeDelegate>("UnityEngine.Rigidbody2D::IsAwake");
			Rigidbody2D.SleepDelegateField = IL2CPP.ResolveICall<Rigidbody2D.SleepDelegate>("UnityEngine.Rigidbody2D::Sleep");
			Rigidbody2D.WakeUpDelegateField = IL2CPP.ResolveICall<Rigidbody2D.WakeUpDelegate>("UnityEngine.Rigidbody2D::WakeUp");
			Rigidbody2D.get_simulatedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_simulatedDelegate>("UnityEngine.Rigidbody2D::get_simulated");
			Rigidbody2D.set_simulatedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_simulatedDelegate>("UnityEngine.Rigidbody2D::set_simulated");
			Rigidbody2D.get_interpolationDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_interpolationDelegate>("UnityEngine.Rigidbody2D::get_interpolation");
			Rigidbody2D.set_interpolationDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_interpolationDelegate>("UnityEngine.Rigidbody2D::set_interpolation");
			Rigidbody2D.get_sleepModeDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_sleepModeDelegate>("UnityEngine.Rigidbody2D::get_sleepMode");
			Rigidbody2D.set_sleepModeDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_sleepModeDelegate>("UnityEngine.Rigidbody2D::set_sleepMode");
			Rigidbody2D.get_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_collisionDetectionModeDelegate>("UnityEngine.Rigidbody2D::get_collisionDetectionMode");
			Rigidbody2D.set_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_collisionDetectionModeDelegate>("UnityEngine.Rigidbody2D::set_collisionDetectionMode");
			Rigidbody2D.get_attachedColliderCountDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_attachedColliderCountDelegate>("UnityEngine.Rigidbody2D::get_attachedColliderCount");
			Rigidbody2D.get_totalTorqueDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_totalTorqueDelegate>("UnityEngine.Rigidbody2D::get_totalTorque");
			Rigidbody2D.set_totalTorqueDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_totalTorqueDelegate>("UnityEngine.Rigidbody2D::set_totalTorque");
			Rigidbody2D.IsTouchingDelegateField = IL2CPP.ResolveICall<Rigidbody2D.IsTouchingDelegate>("UnityEngine.Rigidbody2D::IsTouching");
			Rigidbody2D.IsTouchingLayersDelegateField = IL2CPP.ResolveICall<Rigidbody2D.IsTouchingLayersDelegate>("UnityEngine.Rigidbody2D::IsTouchingLayers");
			Rigidbody2D.AddTorqueDelegateField = IL2CPP.ResolveICall<Rigidbody2D.AddTorqueDelegate>("UnityEngine.Rigidbody2D::AddTorque");
			Rigidbody2D.GetAttachedCollidersArray_InternalDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetAttachedCollidersArray_InternalDelegate>("UnityEngine.Rigidbody2D::GetAttachedCollidersArray_Internal");
			Rigidbody2D.GetAttachedCollidersList_InternalDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetAttachedCollidersList_InternalDelegate>("UnityEngine.Rigidbody2D::GetAttachedCollidersList_Internal");
			Rigidbody2D.get_position_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_position_InjectedDelegate>("UnityEngine.Rigidbody2D::get_position_Injected");
			Rigidbody2D.set_position_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_position_InjectedDelegate>("UnityEngine.Rigidbody2D::set_position_Injected");
			Rigidbody2D.SetRotation_Quaternion_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.SetRotation_Quaternion_InjectedDelegate>("UnityEngine.Rigidbody2D::SetRotation_Quaternion_Injected");
			Rigidbody2D.MovePosition_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.MovePosition_InjectedDelegate>("UnityEngine.Rigidbody2D::MovePosition_Injected");
			Rigidbody2D.MoveRotation_Quaternion_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.MoveRotation_Quaternion_InjectedDelegate>("UnityEngine.Rigidbody2D::MoveRotation_Quaternion_Injected");
			Rigidbody2D.get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_velocity_InjectedDelegate>("UnityEngine.Rigidbody2D::get_velocity_Injected");
			Rigidbody2D.set_velocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_velocity_InjectedDelegate>("UnityEngine.Rigidbody2D::set_velocity_Injected");
			Rigidbody2D.get_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_centerOfMass_InjectedDelegate>("UnityEngine.Rigidbody2D::get_centerOfMass_Injected");
			Rigidbody2D.set_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_centerOfMass_InjectedDelegate>("UnityEngine.Rigidbody2D::set_centerOfMass_Injected");
			Rigidbody2D.get_worldCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_worldCenterOfMass_InjectedDelegate>("UnityEngine.Rigidbody2D::get_worldCenterOfMass_Injected");
			Rigidbody2D.get_totalForce_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_totalForce_InjectedDelegate>("UnityEngine.Rigidbody2D::get_totalForce_Injected");
			Rigidbody2D.set_totalForce_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_totalForce_InjectedDelegate>("UnityEngine.Rigidbody2D::set_totalForce_Injected");
			Rigidbody2D.get_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_excludeLayers_InjectedDelegate>("UnityEngine.Rigidbody2D::get_excludeLayers_Injected");
			Rigidbody2D.set_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_excludeLayers_InjectedDelegate>("UnityEngine.Rigidbody2D::set_excludeLayers_Injected");
			Rigidbody2D.get_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.get_includeLayers_InjectedDelegate>("UnityEngine.Rigidbody2D::get_includeLayers_Injected");
			Rigidbody2D.set_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.set_includeLayers_InjectedDelegate>("UnityEngine.Rigidbody2D::set_includeLayers_Injected");
			Rigidbody2D.IsTouching_OtherColliderWithFilter_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.IsTouching_OtherColliderWithFilter_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::IsTouching_OtherColliderWithFilter_Internal_Injected");
			Rigidbody2D.IsTouching_AnyColliderWithFilter_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.IsTouching_AnyColliderWithFilter_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::IsTouching_AnyColliderWithFilter_Internal_Injected");
			Rigidbody2D.OverlapPoint_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.OverlapPoint_InjectedDelegate>("UnityEngine.Rigidbody2D::OverlapPoint_Injected");
			Rigidbody2D.AddForce_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.AddForce_InjectedDelegate>("UnityEngine.Rigidbody2D::AddForce_Injected");
			Rigidbody2D.AddRelativeForce_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.AddRelativeForce_InjectedDelegate>("UnityEngine.Rigidbody2D::AddRelativeForce_Injected");
			Rigidbody2D.AddForceAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.AddForceAtPosition_InjectedDelegate>("UnityEngine.Rigidbody2D::AddForceAtPosition_Injected");
			Rigidbody2D.GetPoint_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetPoint_InjectedDelegate>("UnityEngine.Rigidbody2D::GetPoint_Injected");
			Rigidbody2D.GetRelativePoint_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetRelativePoint_InjectedDelegate>("UnityEngine.Rigidbody2D::GetRelativePoint_Injected");
			Rigidbody2D.GetVector_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetVector_InjectedDelegate>("UnityEngine.Rigidbody2D::GetVector_Injected");
			Rigidbody2D.GetRelativeVector_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetRelativeVector_InjectedDelegate>("UnityEngine.Rigidbody2D::GetRelativeVector_Injected");
			Rigidbody2D.GetPointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetPointVelocity_InjectedDelegate>("UnityEngine.Rigidbody2D::GetPointVelocity_Injected");
			Rigidbody2D.GetRelativePointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.GetRelativePointVelocity_InjectedDelegate>("UnityEngine.Rigidbody2D::GetRelativePointVelocity_Injected");
			Rigidbody2D.OverlapColliderArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.OverlapColliderArray_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::OverlapColliderArray_Internal_Injected");
			Rigidbody2D.OverlapColliderList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.OverlapColliderList_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::OverlapColliderList_Internal_Injected");
			Rigidbody2D.CastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.CastArray_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastArray_Internal_Injected");
			Rigidbody2D.CastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.CastList_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastList_Internal_Injected");
			Rigidbody2D.CastFilteredArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.CastFilteredArray_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastFilteredArray_Internal_Injected");
			Rigidbody2D.CastFilteredList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Rigidbody2D.CastFilteredList_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastFilteredList_Internal_Injected");
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002B82 File Offset: 0x00000D82
		public Rigidbody2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000A7E4 File Offset: 0x000089E4
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00002B8B File Offset: 0x00000D8B
		public Vector2 position
		{
			get
			{
				Vector2 vector;
				this.get_position_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_position_Injected(ref value);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00002B95 File Offset: 0x00000D95
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002BA7 File Offset: 0x00000DA7
		public float rotation
		{
			get
			{
				return Rigidbody2D.get_rotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_rotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002BBA File Offset: 0x00000DBA
		public void SetRotation(float angle)
		{
			this.SetRotation_Angle(angle);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002BC5 File Offset: 0x00000DC5
		public void SetRotation_Angle(float angle)
		{
			Rigidbody2D.SetRotation_AngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), angle);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public void SetRotation(Quaternion rotation)
		{
			this.SetRotation_Quaternion(rotation);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002BE3 File Offset: 0x00000DE3
		public void SetRotation_Quaternion(Quaternion rotation)
		{
			this.SetRotation_Quaternion_Injected(ref rotation);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002BED File Offset: 0x00000DED
		public void MovePosition(Vector2 position)
		{
			this.MovePosition_Injected(ref position);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002BF7 File Offset: 0x00000DF7
		public void MoveRotation(float angle)
		{
			this.MoveRotation_Angle(angle);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002C02 File Offset: 0x00000E02
		public void MoveRotation_Angle(float angle)
		{
			Rigidbody2D.MoveRotation_AngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), angle);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002C15 File Offset: 0x00000E15
		public void MoveRotation(Quaternion rotation)
		{
			this.MoveRotation_Quaternion(rotation);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002C20 File Offset: 0x00000E20
		public void MoveRotation_Quaternion(Quaternion rotation)
		{
			this.MoveRotation_Quaternion_Injected(ref rotation);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0000A7FC File Offset: 0x000089FC
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00002C2A File Offset: 0x00000E2A
		public Vector2 velocity
		{
			get
			{
				Vector2 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_velocity_Injected(ref value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00002C34 File Offset: 0x00000E34
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002C46 File Offset: 0x00000E46
		public float angularVelocity
		{
			get
			{
				return Rigidbody2D.get_angularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_angularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00002C59 File Offset: 0x00000E59
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00002C6B File Offset: 0x00000E6B
		public bool useAutoMass
		{
			get
			{
				return Rigidbody2D.get_useAutoMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_useAutoMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00002C7E File Offset: 0x00000E7E
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00002C90 File Offset: 0x00000E90
		public float mass
		{
			get
			{
				return Rigidbody2D.get_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000A814 File Offset: 0x00008A14
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00002CA3 File Offset: 0x00000EA3
		public PhysicsMaterial2D sharedMaterial
		{
			get
			{
				IntPtr intPtr = Rigidbody2D.get_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsMaterial2D>(intPtr2) : null;
			}
			set
			{
				Rigidbody2D.set_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000A840 File Offset: 0x00008A40
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00002CBB File Offset: 0x00000EBB
		public Vector2 centerOfMass
		{
			get
			{
				Vector2 vector;
				this.get_centerOfMass_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_centerOfMass_Injected(ref value);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000A858 File Offset: 0x00008A58
		public Vector2 worldCenterOfMass
		{
			get
			{
				Vector2 vector;
				this.get_worldCenterOfMass_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00002CC5 File Offset: 0x00000EC5
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00002CD7 File Offset: 0x00000ED7
		public float inertia
		{
			get
			{
				return Rigidbody2D.get_inertiaDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_inertiaDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00002CEA File Offset: 0x00000EEA
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00002CFC File Offset: 0x00000EFC
		public float drag
		{
			get
			{
				return Rigidbody2D.get_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00002D0F File Offset: 0x00000F0F
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00002D21 File Offset: 0x00000F21
		public float angularDrag
		{
			get
			{
				return Rigidbody2D.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00002D34 File Offset: 0x00000F34
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00002D46 File Offset: 0x00000F46
		public float gravityScale
		{
			get
			{
				return Rigidbody2D.get_gravityScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_gravityScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00002D59 File Offset: 0x00000F59
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00002D6B File Offset: 0x00000F6B
		public RigidbodyType2D bodyType
		{
			get
			{
				return Rigidbody2D.get_bodyTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_bodyTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002D7E File Offset: 0x00000F7E
		public void SetDragBehaviour(bool dragged)
		{
			Rigidbody2D.SetDragBehaviourDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), dragged);
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00002D91 File Offset: 0x00000F91
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00002DA3 File Offset: 0x00000FA3
		public bool useFullKinematicContacts
		{
			get
			{
				return Rigidbody2D.get_useFullKinematicContactsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_useFullKinematicContactsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000A870 File Offset: 0x00008A70
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00002DB6 File Offset: 0x00000FB6
		public bool isKinematic
		{
			get
			{
				return this.bodyType == RigidbodyType2D.Kinematic;
			}
			set
			{
				this.bodyType = (value ? RigidbodyType2D.Kinematic : RigidbodyType2D.Dynamic);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00002DC7 File Offset: 0x00000FC7
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00002DD9 File Offset: 0x00000FD9
		public bool fixedAngle
		{
			get
			{
				return Rigidbody2D.get_fixedAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_fixedAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00002DEC File Offset: 0x00000FEC
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00002DFE File Offset: 0x00000FFE
		public bool freezeRotation
		{
			get
			{
				return Rigidbody2D.get_freezeRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_freezeRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00002E11 File Offset: 0x00001011
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00002E23 File Offset: 0x00001023
		public RigidbodyConstraints2D constraints
		{
			get
			{
				return Rigidbody2D.get_constraintsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_constraintsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002E36 File Offset: 0x00001036
		public bool IsSleeping()
		{
			return Rigidbody2D.IsSleepingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002E48 File Offset: 0x00001048
		public bool IsAwake()
		{
			return Rigidbody2D.IsAwakeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002E5A File Offset: 0x0000105A
		public void Sleep()
		{
			Rigidbody2D.SleepDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002E6C File Offset: 0x0000106C
		public void WakeUp()
		{
			Rigidbody2D.WakeUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00002E7E File Offset: 0x0000107E
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00002E90 File Offset: 0x00001090
		public bool simulated
		{
			get
			{
				return Rigidbody2D.get_simulatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_simulatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00002EA3 File Offset: 0x000010A3
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00002EB5 File Offset: 0x000010B5
		public RigidbodyInterpolation2D interpolation
		{
			get
			{
				return Rigidbody2D.get_interpolationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_interpolationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00002EC8 File Offset: 0x000010C8
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00002EDA File Offset: 0x000010DA
		public RigidbodySleepMode2D sleepMode
		{
			get
			{
				return Rigidbody2D.get_sleepModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_sleepModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00002EED File Offset: 0x000010ED
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002EFF File Offset: 0x000010FF
		public CollisionDetectionMode2D collisionDetectionMode
		{
			get
			{
				return Rigidbody2D.get_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00002F12 File Offset: 0x00001112
		public int attachedColliderCount
		{
			get
			{
				return Rigidbody2D.get_attachedColliderCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0000A88C File Offset: 0x00008A8C
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00002F24 File Offset: 0x00001124
		public Vector2 totalForce
		{
			get
			{
				Vector2 vector;
				this.get_totalForce_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_totalForce_Injected(ref value);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00002F2E File Offset: 0x0000112E
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00002F40 File Offset: 0x00001140
		public float totalTorque
		{
			get
			{
				return Rigidbody2D.get_totalTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Rigidbody2D.set_totalTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000A8A4 File Offset: 0x00008AA4
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00002F53 File Offset: 0x00001153
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

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000A8BC File Offset: 0x00008ABC
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00002F5D File Offset: 0x0000115D
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

		// Token: 0x06000276 RID: 630 RVA: 0x00002F67 File Offset: 0x00001167
		public bool IsTouching(Collider2D collider)
		{
			return Rigidbody2D.IsTouchingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(collider));
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter)
		{
			return this.IsTouching_OtherColliderWithFilter_Internal(collider, contactFilter);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002F7F File Offset: 0x0000117F
		public bool IsTouching_OtherColliderWithFilter_Internal(Collider2D collider, ContactFilter2D contactFilter)
		{
			return this.IsTouching_OtherColliderWithFilter_Internal_Injected(collider, ref contactFilter);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		public bool IsTouching(ContactFilter2D contactFilter)
		{
			return this.IsTouching_AnyColliderWithFilter_Internal(contactFilter);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002F8A File Offset: 0x0000118A
		public bool IsTouching_AnyColliderWithFilter_Internal(ContactFilter2D contactFilter)
		{
			return this.IsTouching_AnyColliderWithFilter_Internal_Injected(ref contactFilter);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000A90C File Offset: 0x00008B0C
		public bool IsTouchingLayers()
		{
			return this.IsTouchingLayers(-1);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002F94 File Offset: 0x00001194
		public bool IsTouchingLayers(int layerMask)
		{
			return Rigidbody2D.IsTouchingLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layerMask);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002FA7 File Offset: 0x000011A7
		public bool OverlapPoint(Vector2 point)
		{
			return this.OverlapPoint_Injected(ref point);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000A928 File Offset: 0x00008B28
		public Vector2 ClosestPoint(Vector2 position)
		{
			return Physics2D.ClosestPoint(position, this);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002FB1 File Offset: 0x000011B1
		public void AddForce(Vector2 force)
		{
			this.AddForce(force, ForceMode2D.Force);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002FBD File Offset: 0x000011BD
		public void AddForce(Vector2 force, ForceMode2D mode)
		{
			this.AddForce_Injected(ref force, mode);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002FC8 File Offset: 0x000011C8
		public void AddRelativeForce(Vector2 relativeForce)
		{
			this.AddRelativeForce(relativeForce, ForceMode2D.Force);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002FD4 File Offset: 0x000011D4
		public void AddRelativeForce(Vector2 relativeForce, ForceMode2D mode)
		{
			this.AddRelativeForce_Injected(ref relativeForce, mode);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002FDF File Offset: 0x000011DF
		public void AddForceAtPosition(Vector2 force, Vector2 position)
		{
			this.AddForceAtPosition(force, position, ForceMode2D.Force);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002FEC File Offset: 0x000011EC
		public void AddForceAtPosition(Vector2 force, Vector2 position, ForceMode2D mode)
		{
			this.AddForceAtPosition_Injected(ref force, ref position, mode);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002FF9 File Offset: 0x000011F9
		public void AddTorque(float torque)
		{
			this.AddTorque(torque, ForceMode2D.Force);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00003005 File Offset: 0x00001205
		public void AddTorque(float torque, ForceMode2D mode)
		{
			Rigidbody2D.AddTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), torque, mode);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000A944 File Offset: 0x00008B44
		public Vector2 GetPoint(Vector2 point)
		{
			Vector2 vector;
			this.GetPoint_Injected(ref point, out vector);
			return vector;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000A95C File Offset: 0x00008B5C
		public Vector2 GetRelativePoint(Vector2 relativePoint)
		{
			Vector2 vector;
			this.GetRelativePoint_Injected(ref relativePoint, out vector);
			return vector;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000A974 File Offset: 0x00008B74
		public Vector2 GetVector(Vector2 vector)
		{
			Vector2 vector2;
			this.GetVector_Injected(ref vector, out vector2);
			return vector2;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000A98C File Offset: 0x00008B8C
		public Vector2 GetRelativeVector(Vector2 relativeVector)
		{
			Vector2 vector;
			this.GetRelativeVector_Injected(ref relativeVector, out vector);
			return vector;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000A9A4 File Offset: 0x00008BA4
		public Vector2 GetPointVelocity(Vector2 point)
		{
			Vector2 vector;
			this.GetPointVelocity_Injected(ref point, out vector);
			return vector;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000A9BC File Offset: 0x00008BBC
		public Vector2 GetRelativePointVelocity(Vector2 relativePoint)
		{
			Vector2 vector;
			this.GetRelativePointVelocity_Injected(ref relativePoint, out vector);
			return vector;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000A9D4 File Offset: 0x00008BD4
		public int OverlapCollider(ContactFilter2D contactFilter, [Out] Il2CppReferenceArray<Collider2D> results)
		{
			return this.OverlapColliderArray_Internal(contactFilter, results);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00003019 File Offset: 0x00001219
		public int OverlapColliderArray_Internal(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return this.OverlapColliderArray_Internal_Injected(ref contactFilter, results);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000A9F0 File Offset: 0x00008BF0
		public int OverlapCollider(ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return this.OverlapColliderList_Internal(contactFilter, results);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00003024 File Offset: 0x00001224
		public int OverlapColliderList_Internal(ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return this.OverlapColliderList_Internal_Injected(ref contactFilter, results);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000AA0C File Offset: 0x00008C0C
		public int GetContacts(Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000AA34 File Offset: 0x00008C34
		public int GetContacts(List<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000AA5C File Offset: 0x00008C5C
		public int GetContacts(ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, contactFilter, contacts);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000AA78 File Offset: 0x00008C78
		public int GetContacts(ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
		{
			return Physics2D.GetContacts(this, contactFilter, contacts);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000AA94 File Offset: 0x00008C94
		public int GetContacts(Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000AABC File Offset: 0x00008CBC
		public int GetContacts(List<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000AAE4 File Offset: 0x00008CE4
		public int GetContacts(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, contactFilter, colliders);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000AB00 File Offset: 0x00008D00
		public int GetContacts(ContactFilter2D contactFilter, List<Collider2D> colliders)
		{
			return Physics2D.GetContacts(this, contactFilter, colliders);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000AB1C File Offset: 0x00008D1C
		public int GetAttachedColliders([Out] Il2CppReferenceArray<Collider2D> results)
		{
			return this.GetAttachedCollidersArray_Internal(results);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000302F File Offset: 0x0000122F
		public int GetAttachedCollidersArray_Internal(Il2CppReferenceArray<Collider2D> results)
		{
			return Rigidbody2D.GetAttachedCollidersArray_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000AB38 File Offset: 0x00008D38
		public int GetAttachedColliders(List<Collider2D> results)
		{
			return this.GetAttachedCollidersList_Internal(results);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00003047 File Offset: 0x00001247
		public int GetAttachedCollidersList_Internal(List<Collider2D> results)
		{
			return Rigidbody2D.GetAttachedCollidersList_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000AB54 File Offset: 0x00008D54
		public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastArray_Internal(direction, float.PositiveInfinity, results);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000AB74 File Offset: 0x00008D74
		public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return this.CastArray_Internal(direction, distance, results);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000305F File Offset: 0x0000125F
		public int CastArray_Internal(Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastArray_Internal_Injected(ref direction, distance, results);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000AB90 File Offset: 0x00008D90
		public int Cast(Vector2 direction, List<RaycastHit2D> results, [Optional] float distance)
		{
			return this.CastList_Internal(direction, distance, results);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000306B File Offset: 0x0000126B
		public int CastList_Internal(Vector2 direction, float distance, List<RaycastHit2D> results)
		{
			return this.CastList_Internal_Injected(ref direction, distance, results);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000ABAC File Offset: 0x00008DAC
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastFilteredArray_Internal(direction, float.PositiveInfinity, contactFilter, results);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000ABCC File Offset: 0x00008DCC
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
		{
			return this.CastFilteredArray_Internal(direction, distance, contactFilter, results);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00003077 File Offset: 0x00001277
		public int CastFilteredArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return this.CastFilteredArray_Internal_Injected(ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000ABEC File Offset: 0x00008DEC
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance)
		{
			return this.CastFilteredList_Internal(direction, distance, contactFilter, results);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00003086 File Offset: 0x00001286
		public int CastFilteredList_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return this.CastFilteredList_Internal_Injected(ref direction, distance, ref contactFilter, results);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00003095 File Offset: 0x00001295
		public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000030A2 File Offset: 0x000012A2
		public void get_position_Injected(out Vector2 ret)
		{
			Rigidbody2D.get_position_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000030B5 File Offset: 0x000012B5
		public void set_position_Injected(ref Vector2 value)
		{
			Rigidbody2D.set_position_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000030C8 File Offset: 0x000012C8
		public void SetRotation_Quaternion_Injected(ref Quaternion rotation)
		{
			Rigidbody2D.SetRotation_Quaternion_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rotation);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000030DB File Offset: 0x000012DB
		public void MovePosition_Injected(ref Vector2 position)
		{
			Rigidbody2D.MovePosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000030EE File Offset: 0x000012EE
		public void MoveRotation_Quaternion_Injected(ref Quaternion rotation)
		{
			Rigidbody2D.MoveRotation_Quaternion_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rotation);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00003101 File Offset: 0x00001301
		public void get_velocity_Injected(out Vector2 ret)
		{
			Rigidbody2D.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00003114 File Offset: 0x00001314
		public void set_velocity_Injected(ref Vector2 value)
		{
			Rigidbody2D.set_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00003127 File Offset: 0x00001327
		public void get_centerOfMass_Injected(out Vector2 ret)
		{
			Rigidbody2D.get_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000313A File Offset: 0x0000133A
		public void set_centerOfMass_Injected(ref Vector2 value)
		{
			Rigidbody2D.set_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000314D File Offset: 0x0000134D
		public void get_worldCenterOfMass_Injected(out Vector2 ret)
		{
			Rigidbody2D.get_worldCenterOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00003160 File Offset: 0x00001360
		public void get_totalForce_Injected(out Vector2 ret)
		{
			Rigidbody2D.get_totalForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00003173 File Offset: 0x00001373
		public void set_totalForce_Injected(ref Vector2 value)
		{
			Rigidbody2D.set_totalForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00003186 File Offset: 0x00001386
		public void get_excludeLayers_Injected(out LayerMask ret)
		{
			Rigidbody2D.get_excludeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00003199 File Offset: 0x00001399
		public void set_excludeLayers_Injected(ref LayerMask value)
		{
			Rigidbody2D.set_excludeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000031AC File Offset: 0x000013AC
		public void get_includeLayers_Injected(out LayerMask ret)
		{
			Rigidbody2D.get_includeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000031BF File Offset: 0x000013BF
		public void set_includeLayers_Injected(ref LayerMask value)
		{
			Rigidbody2D.set_includeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000031D2 File Offset: 0x000013D2
		public bool IsTouching_OtherColliderWithFilter_Internal_Injected(Collider2D collider, ref ContactFilter2D contactFilter)
		{
			return Rigidbody2D.IsTouching_OtherColliderWithFilter_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(collider), ref contactFilter);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000031EB File Offset: 0x000013EB
		public bool IsTouching_AnyColliderWithFilter_Internal_Injected(ref ContactFilter2D contactFilter)
		{
			return Rigidbody2D.IsTouching_AnyColliderWithFilter_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref contactFilter);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000031FE File Offset: 0x000013FE
		public bool OverlapPoint_Injected(ref Vector2 point)
		{
			return Rigidbody2D.OverlapPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00003211 File Offset: 0x00001411
		public void AddForce_Injected(ref Vector2 force, ForceMode2D mode)
		{
			Rigidbody2D.AddForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, mode);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00003225 File Offset: 0x00001425
		public void AddRelativeForce_Injected(ref Vector2 relativeForce, ForceMode2D mode)
		{
			Rigidbody2D.AddRelativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativeForce, mode);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00003239 File Offset: 0x00001439
		public void AddForceAtPosition_Injected(ref Vector2 force, ref Vector2 position, ForceMode2D mode)
		{
			Rigidbody2D.AddForceAtPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, ref position, mode);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000324E File Offset: 0x0000144E
		public void GetPoint_Injected(ref Vector2 point, out Vector2 ret)
		{
			Rigidbody2D.GetPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, out ret);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00003262 File Offset: 0x00001462
		public void GetRelativePoint_Injected(ref Vector2 relativePoint, out Vector2 ret)
		{
			Rigidbody2D.GetRelativePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativePoint, out ret);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00003276 File Offset: 0x00001476
		public void GetVector_Injected(ref Vector2 vector, out Vector2 ret)
		{
			Rigidbody2D.GetVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref vector, out ret);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000328A File Offset: 0x0000148A
		public void GetRelativeVector_Injected(ref Vector2 relativeVector, out Vector2 ret)
		{
			Rigidbody2D.GetRelativeVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativeVector, out ret);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000329E File Offset: 0x0000149E
		public void GetPointVelocity_Injected(ref Vector2 point, out Vector2 ret)
		{
			Rigidbody2D.GetPointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, out ret);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000032B2 File Offset: 0x000014B2
		public void GetRelativePointVelocity_Injected(ref Vector2 relativePoint, out Vector2 ret)
		{
			Rigidbody2D.GetRelativePointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativePoint, out ret);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000032C6 File Offset: 0x000014C6
		public int OverlapColliderArray_Internal_Injected(ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
		{
			return Rigidbody2D.OverlapColliderArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000032DF File Offset: 0x000014DF
		public int OverlapColliderList_Internal_Injected(ref ContactFilter2D contactFilter, List<Collider2D> results)
		{
			return Rigidbody2D.OverlapColliderList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000032F8 File Offset: 0x000014F8
		public int CastArray_Internal_Injected(ref Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results)
		{
			return Rigidbody2D.CastArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00003312 File Offset: 0x00001512
		public int CastList_Internal_Injected(ref Vector2 direction, float distance, List<RaycastHit2D> results)
		{
			return Rigidbody2D.CastList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000332C File Offset: 0x0000152C
		public int CastFilteredArray_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
		{
			return Rigidbody2D.CastFilteredArray_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00003348 File Offset: 0x00001548
		public int CastFilteredList_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return Rigidbody2D.CastFilteredList_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref direction, distance, ref contactFilter, IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x040000DE RID: 222
		private static readonly Rigidbody2D.get_rotationDelegate get_rotationDelegateField;

		// Token: 0x040000DF RID: 223
		private static readonly Rigidbody2D.set_rotationDelegate set_rotationDelegateField;

		// Token: 0x040000E0 RID: 224
		private static readonly Rigidbody2D.SetRotation_AngleDelegate SetRotation_AngleDelegateField;

		// Token: 0x040000E1 RID: 225
		private static readonly Rigidbody2D.MoveRotation_AngleDelegate MoveRotation_AngleDelegateField;

		// Token: 0x040000E2 RID: 226
		private static readonly Rigidbody2D.get_angularVelocityDelegate get_angularVelocityDelegateField;

		// Token: 0x040000E3 RID: 227
		private static readonly Rigidbody2D.set_angularVelocityDelegate set_angularVelocityDelegateField;

		// Token: 0x040000E4 RID: 228
		private static readonly Rigidbody2D.get_useAutoMassDelegate get_useAutoMassDelegateField;

		// Token: 0x040000E5 RID: 229
		private static readonly Rigidbody2D.set_useAutoMassDelegate set_useAutoMassDelegateField;

		// Token: 0x040000E6 RID: 230
		private static readonly Rigidbody2D.get_massDelegate get_massDelegateField;

		// Token: 0x040000E7 RID: 231
		private static readonly Rigidbody2D.set_massDelegate set_massDelegateField;

		// Token: 0x040000E8 RID: 232
		private static readonly Rigidbody2D.get_sharedMaterialDelegate get_sharedMaterialDelegateField;

		// Token: 0x040000E9 RID: 233
		private static readonly Rigidbody2D.set_sharedMaterialDelegate set_sharedMaterialDelegateField;

		// Token: 0x040000EA RID: 234
		private static readonly Rigidbody2D.get_inertiaDelegate get_inertiaDelegateField;

		// Token: 0x040000EB RID: 235
		private static readonly Rigidbody2D.set_inertiaDelegate set_inertiaDelegateField;

		// Token: 0x040000EC RID: 236
		private static readonly Rigidbody2D.get_dragDelegate get_dragDelegateField;

		// Token: 0x040000ED RID: 237
		private static readonly Rigidbody2D.set_dragDelegate set_dragDelegateField;

		// Token: 0x040000EE RID: 238
		private static readonly Rigidbody2D.get_angularDragDelegate get_angularDragDelegateField;

		// Token: 0x040000EF RID: 239
		private static readonly Rigidbody2D.set_angularDragDelegate set_angularDragDelegateField;

		// Token: 0x040000F0 RID: 240
		private static readonly Rigidbody2D.get_gravityScaleDelegate get_gravityScaleDelegateField;

		// Token: 0x040000F1 RID: 241
		private static readonly Rigidbody2D.set_gravityScaleDelegate set_gravityScaleDelegateField;

		// Token: 0x040000F2 RID: 242
		private static readonly Rigidbody2D.get_bodyTypeDelegate get_bodyTypeDelegateField;

		// Token: 0x040000F3 RID: 243
		private static readonly Rigidbody2D.set_bodyTypeDelegate set_bodyTypeDelegateField;

		// Token: 0x040000F4 RID: 244
		private static readonly Rigidbody2D.SetDragBehaviourDelegate SetDragBehaviourDelegateField;

		// Token: 0x040000F5 RID: 245
		private static readonly Rigidbody2D.get_useFullKinematicContactsDelegate get_useFullKinematicContactsDelegateField;

		// Token: 0x040000F6 RID: 246
		private static readonly Rigidbody2D.set_useFullKinematicContactsDelegate set_useFullKinematicContactsDelegateField;

		// Token: 0x040000F7 RID: 247
		private static readonly Rigidbody2D.get_fixedAngleDelegate get_fixedAngleDelegateField;

		// Token: 0x040000F8 RID: 248
		private static readonly Rigidbody2D.set_fixedAngleDelegate set_fixedAngleDelegateField;

		// Token: 0x040000F9 RID: 249
		private static readonly Rigidbody2D.get_freezeRotationDelegate get_freezeRotationDelegateField;

		// Token: 0x040000FA RID: 250
		private static readonly Rigidbody2D.set_freezeRotationDelegate set_freezeRotationDelegateField;

		// Token: 0x040000FB RID: 251
		private static readonly Rigidbody2D.get_constraintsDelegate get_constraintsDelegateField;

		// Token: 0x040000FC RID: 252
		private static readonly Rigidbody2D.set_constraintsDelegate set_constraintsDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly Rigidbody2D.IsSleepingDelegate IsSleepingDelegateField;

		// Token: 0x040000FE RID: 254
		private static readonly Rigidbody2D.IsAwakeDelegate IsAwakeDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly Rigidbody2D.SleepDelegate SleepDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly Rigidbody2D.WakeUpDelegate WakeUpDelegateField;

		// Token: 0x04000101 RID: 257
		private static readonly Rigidbody2D.get_simulatedDelegate get_simulatedDelegateField;

		// Token: 0x04000102 RID: 258
		private static readonly Rigidbody2D.set_simulatedDelegate set_simulatedDelegateField;

		// Token: 0x04000103 RID: 259
		private static readonly Rigidbody2D.get_interpolationDelegate get_interpolationDelegateField;

		// Token: 0x04000104 RID: 260
		private static readonly Rigidbody2D.set_interpolationDelegate set_interpolationDelegateField;

		// Token: 0x04000105 RID: 261
		private static readonly Rigidbody2D.get_sleepModeDelegate get_sleepModeDelegateField;

		// Token: 0x04000106 RID: 262
		private static readonly Rigidbody2D.set_sleepModeDelegate set_sleepModeDelegateField;

		// Token: 0x04000107 RID: 263
		private static readonly Rigidbody2D.get_collisionDetectionModeDelegate get_collisionDetectionModeDelegateField;

		// Token: 0x04000108 RID: 264
		private static readonly Rigidbody2D.set_collisionDetectionModeDelegate set_collisionDetectionModeDelegateField;

		// Token: 0x04000109 RID: 265
		private static readonly Rigidbody2D.get_attachedColliderCountDelegate get_attachedColliderCountDelegateField;

		// Token: 0x0400010A RID: 266
		private static readonly Rigidbody2D.get_totalTorqueDelegate get_totalTorqueDelegateField;

		// Token: 0x0400010B RID: 267
		private static readonly Rigidbody2D.set_totalTorqueDelegate set_totalTorqueDelegateField;

		// Token: 0x0400010C RID: 268
		private static readonly Rigidbody2D.IsTouchingDelegate IsTouchingDelegateField;

		// Token: 0x0400010D RID: 269
		private static readonly Rigidbody2D.IsTouchingLayersDelegate IsTouchingLayersDelegateField;

		// Token: 0x0400010E RID: 270
		private static readonly Rigidbody2D.AddTorqueDelegate AddTorqueDelegateField;

		// Token: 0x0400010F RID: 271
		private static readonly Rigidbody2D.GetAttachedCollidersArray_InternalDelegate GetAttachedCollidersArray_InternalDelegateField;

		// Token: 0x04000110 RID: 272
		private static readonly Rigidbody2D.GetAttachedCollidersList_InternalDelegate GetAttachedCollidersList_InternalDelegateField;

		// Token: 0x04000111 RID: 273
		private static readonly Rigidbody2D.get_position_InjectedDelegate get_position_InjectedDelegateField;

		// Token: 0x04000112 RID: 274
		private static readonly Rigidbody2D.set_position_InjectedDelegate set_position_InjectedDelegateField;

		// Token: 0x04000113 RID: 275
		private static readonly Rigidbody2D.SetRotation_Quaternion_InjectedDelegate SetRotation_Quaternion_InjectedDelegateField;

		// Token: 0x04000114 RID: 276
		private static readonly Rigidbody2D.MovePosition_InjectedDelegate MovePosition_InjectedDelegateField;

		// Token: 0x04000115 RID: 277
		private static readonly Rigidbody2D.MoveRotation_Quaternion_InjectedDelegate MoveRotation_Quaternion_InjectedDelegateField;

		// Token: 0x04000116 RID: 278
		private static readonly Rigidbody2D.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField;

		// Token: 0x04000117 RID: 279
		private static readonly Rigidbody2D.set_velocity_InjectedDelegate set_velocity_InjectedDelegateField;

		// Token: 0x04000118 RID: 280
		private static readonly Rigidbody2D.get_centerOfMass_InjectedDelegate get_centerOfMass_InjectedDelegateField;

		// Token: 0x04000119 RID: 281
		private static readonly Rigidbody2D.set_centerOfMass_InjectedDelegate set_centerOfMass_InjectedDelegateField;

		// Token: 0x0400011A RID: 282
		private static readonly Rigidbody2D.get_worldCenterOfMass_InjectedDelegate get_worldCenterOfMass_InjectedDelegateField;

		// Token: 0x0400011B RID: 283
		private static readonly Rigidbody2D.get_totalForce_InjectedDelegate get_totalForce_InjectedDelegateField;

		// Token: 0x0400011C RID: 284
		private static readonly Rigidbody2D.set_totalForce_InjectedDelegate set_totalForce_InjectedDelegateField;

		// Token: 0x0400011D RID: 285
		private static readonly Rigidbody2D.get_excludeLayers_InjectedDelegate get_excludeLayers_InjectedDelegateField;

		// Token: 0x0400011E RID: 286
		private static readonly Rigidbody2D.set_excludeLayers_InjectedDelegate set_excludeLayers_InjectedDelegateField;

		// Token: 0x0400011F RID: 287
		private static readonly Rigidbody2D.get_includeLayers_InjectedDelegate get_includeLayers_InjectedDelegateField;

		// Token: 0x04000120 RID: 288
		private static readonly Rigidbody2D.set_includeLayers_InjectedDelegate set_includeLayers_InjectedDelegateField;

		// Token: 0x04000121 RID: 289
		private static readonly Rigidbody2D.IsTouching_OtherColliderWithFilter_Internal_InjectedDelegate IsTouching_OtherColliderWithFilter_Internal_InjectedDelegateField;

		// Token: 0x04000122 RID: 290
		private static readonly Rigidbody2D.IsTouching_AnyColliderWithFilter_Internal_InjectedDelegate IsTouching_AnyColliderWithFilter_Internal_InjectedDelegateField;

		// Token: 0x04000123 RID: 291
		private static readonly Rigidbody2D.OverlapPoint_InjectedDelegate OverlapPoint_InjectedDelegateField;

		// Token: 0x04000124 RID: 292
		private static readonly Rigidbody2D.AddForce_InjectedDelegate AddForce_InjectedDelegateField;

		// Token: 0x04000125 RID: 293
		private static readonly Rigidbody2D.AddRelativeForce_InjectedDelegate AddRelativeForce_InjectedDelegateField;

		// Token: 0x04000126 RID: 294
		private static readonly Rigidbody2D.AddForceAtPosition_InjectedDelegate AddForceAtPosition_InjectedDelegateField;

		// Token: 0x04000127 RID: 295
		private static readonly Rigidbody2D.GetPoint_InjectedDelegate GetPoint_InjectedDelegateField;

		// Token: 0x04000128 RID: 296
		private static readonly Rigidbody2D.GetRelativePoint_InjectedDelegate GetRelativePoint_InjectedDelegateField;

		// Token: 0x04000129 RID: 297
		private static readonly Rigidbody2D.GetVector_InjectedDelegate GetVector_InjectedDelegateField;

		// Token: 0x0400012A RID: 298
		private static readonly Rigidbody2D.GetRelativeVector_InjectedDelegate GetRelativeVector_InjectedDelegateField;

		// Token: 0x0400012B RID: 299
		private static readonly Rigidbody2D.GetPointVelocity_InjectedDelegate GetPointVelocity_InjectedDelegateField;

		// Token: 0x0400012C RID: 300
		private static readonly Rigidbody2D.GetRelativePointVelocity_InjectedDelegate GetRelativePointVelocity_InjectedDelegateField;

		// Token: 0x0400012D RID: 301
		private static readonly Rigidbody2D.OverlapColliderArray_Internal_InjectedDelegate OverlapColliderArray_Internal_InjectedDelegateField;

		// Token: 0x0400012E RID: 302
		private static readonly Rigidbody2D.OverlapColliderList_Internal_InjectedDelegate OverlapColliderList_Internal_InjectedDelegateField;

		// Token: 0x0400012F RID: 303
		private static readonly Rigidbody2D.CastArray_Internal_InjectedDelegate CastArray_Internal_InjectedDelegateField;

		// Token: 0x04000130 RID: 304
		private static readonly Rigidbody2D.CastList_Internal_InjectedDelegate CastList_Internal_InjectedDelegateField;

		// Token: 0x04000131 RID: 305
		private static readonly Rigidbody2D.CastFilteredArray_Internal_InjectedDelegate CastFilteredArray_Internal_InjectedDelegateField;

		// Token: 0x04000132 RID: 306
		private static readonly Rigidbody2D.CastFilteredList_Internal_InjectedDelegate CastFilteredList_Internal_InjectedDelegateField;

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000568 RID: 1384
		private delegate float get_rotationDelegate(IntPtr @this);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x0600056A RID: 1386
		private delegate void set_rotationDelegate(IntPtr @this, float value);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x0600056C RID: 1388
		private delegate void SetRotation_AngleDelegate(IntPtr @this, float angle);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x0600056E RID: 1390
		private delegate void MoveRotation_AngleDelegate(IntPtr @this, float angle);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x06000570 RID: 1392
		private delegate float get_angularVelocityDelegate(IntPtr @this);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x06000572 RID: 1394
		private delegate void set_angularVelocityDelegate(IntPtr @this, float value);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x06000574 RID: 1396
		private delegate bool get_useAutoMassDelegate(IntPtr @this);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x06000576 RID: 1398
		private delegate void set_useAutoMassDelegate(IntPtr @this, bool value);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x06000578 RID: 1400
		private delegate float get_massDelegate(IntPtr @this);

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x0600057A RID: 1402
		private delegate void set_massDelegate(IntPtr @this, float value);

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x0600057C RID: 1404
		private delegate IntPtr get_sharedMaterialDelegate(IntPtr @this);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x0600057E RID: 1406
		private delegate void set_sharedMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x06000580 RID: 1408
		private delegate float get_inertiaDelegate(IntPtr @this);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x06000582 RID: 1410
		private delegate void set_inertiaDelegate(IntPtr @this, float value);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x06000584 RID: 1412
		private delegate float get_dragDelegate(IntPtr @this);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x06000586 RID: 1414
		private delegate void set_dragDelegate(IntPtr @this, float value);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x06000588 RID: 1416
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x0600058A RID: 1418
		private delegate void set_angularDragDelegate(IntPtr @this, float value);

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x0600058C RID: 1420
		private delegate float get_gravityScaleDelegate(IntPtr @this);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x0600058E RID: 1422
		private delegate void set_gravityScaleDelegate(IntPtr @this, float value);

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x06000590 RID: 1424
		private delegate RigidbodyType2D get_bodyTypeDelegate(IntPtr @this);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x06000592 RID: 1426
		private delegate void set_bodyTypeDelegate(IntPtr @this, RigidbodyType2D value);

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x06000594 RID: 1428
		private delegate void SetDragBehaviourDelegate(IntPtr @this, bool dragged);

		// Token: 0x020000B5 RID: 181
		// (Invoke) Token: 0x06000596 RID: 1430
		private delegate bool get_useFullKinematicContactsDelegate(IntPtr @this);

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x06000598 RID: 1432
		private delegate void set_useFullKinematicContactsDelegate(IntPtr @this, bool value);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x0600059A RID: 1434
		private delegate bool get_fixedAngleDelegate(IntPtr @this);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x0600059C RID: 1436
		private delegate void set_fixedAngleDelegate(IntPtr @this, bool value);

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x0600059E RID: 1438
		private delegate bool get_freezeRotationDelegate(IntPtr @this);

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x060005A0 RID: 1440
		private delegate void set_freezeRotationDelegate(IntPtr @this, bool value);

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x060005A2 RID: 1442
		private delegate RigidbodyConstraints2D get_constraintsDelegate(IntPtr @this);

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x060005A4 RID: 1444
		private delegate void set_constraintsDelegate(IntPtr @this, RigidbodyConstraints2D value);

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x060005A6 RID: 1446
		private delegate bool IsSleepingDelegate(IntPtr @this);

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x060005A8 RID: 1448
		private delegate bool IsAwakeDelegate(IntPtr @this);

		// Token: 0x020000BF RID: 191
		// (Invoke) Token: 0x060005AA RID: 1450
		private delegate void SleepDelegate(IntPtr @this);

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x060005AC RID: 1452
		private delegate void WakeUpDelegate(IntPtr @this);

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x060005AE RID: 1454
		private delegate bool get_simulatedDelegate(IntPtr @this);

		// Token: 0x020000C2 RID: 194
		// (Invoke) Token: 0x060005B0 RID: 1456
		private delegate void set_simulatedDelegate(IntPtr @this, bool value);

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x060005B2 RID: 1458
		private delegate RigidbodyInterpolation2D get_interpolationDelegate(IntPtr @this);

		// Token: 0x020000C4 RID: 196
		// (Invoke) Token: 0x060005B4 RID: 1460
		private delegate void set_interpolationDelegate(IntPtr @this, RigidbodyInterpolation2D value);

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x060005B6 RID: 1462
		private delegate RigidbodySleepMode2D get_sleepModeDelegate(IntPtr @this);

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x060005B8 RID: 1464
		private delegate void set_sleepModeDelegate(IntPtr @this, RigidbodySleepMode2D value);

		// Token: 0x020000C7 RID: 199
		// (Invoke) Token: 0x060005BA RID: 1466
		private delegate CollisionDetectionMode2D get_collisionDetectionModeDelegate(IntPtr @this);

		// Token: 0x020000C8 RID: 200
		// (Invoke) Token: 0x060005BC RID: 1468
		private delegate void set_collisionDetectionModeDelegate(IntPtr @this, CollisionDetectionMode2D value);

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x060005BE RID: 1470
		private delegate int get_attachedColliderCountDelegate(IntPtr @this);

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x060005C0 RID: 1472
		private delegate float get_totalTorqueDelegate(IntPtr @this);

		// Token: 0x020000CB RID: 203
		// (Invoke) Token: 0x060005C2 RID: 1474
		private delegate void set_totalTorqueDelegate(IntPtr @this, float value);

		// Token: 0x020000CC RID: 204
		// (Invoke) Token: 0x060005C4 RID: 1476
		private delegate bool IsTouchingDelegate(IntPtr @this, IntPtr collider);

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x060005C6 RID: 1478
		private delegate bool IsTouchingLayersDelegate(IntPtr @this, int layerMask);

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x060005C8 RID: 1480
		private delegate void AddTorqueDelegate(IntPtr @this, float torque, ForceMode2D mode);

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x060005CA RID: 1482
		private delegate int GetAttachedCollidersArray_InternalDelegate(IntPtr @this, IntPtr results);

		// Token: 0x020000D0 RID: 208
		// (Invoke) Token: 0x060005CC RID: 1484
		private delegate int GetAttachedCollidersList_InternalDelegate(IntPtr @this, IntPtr results);

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x060005CE RID: 1486
		private delegate void get_position_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000D2 RID: 210
		// (Invoke) Token: 0x060005D0 RID: 1488
		private delegate void set_position_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x060005D2 RID: 1490
		private delegate void SetRotation_Quaternion_InjectedDelegate(IntPtr @this, IntPtr rotation);

		// Token: 0x020000D4 RID: 212
		// (Invoke) Token: 0x060005D4 RID: 1492
		private delegate void MovePosition_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x060005D6 RID: 1494
		private delegate void MoveRotation_Quaternion_InjectedDelegate(IntPtr @this, IntPtr rotation);

		// Token: 0x020000D6 RID: 214
		// (Invoke) Token: 0x060005D8 RID: 1496
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x060005DA RID: 1498
		private delegate void set_velocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x060005DC RID: 1500
		private delegate void get_centerOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x060005DE RID: 1502
		private delegate void set_centerOfMass_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x060005E0 RID: 1504
		private delegate void get_worldCenterOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x060005E2 RID: 1506
		private delegate void get_totalForce_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x060005E4 RID: 1508
		private delegate void set_totalForce_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x060005E6 RID: 1510
		private delegate void get_excludeLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000DE RID: 222
		// (Invoke) Token: 0x060005E8 RID: 1512
		private delegate void set_excludeLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x060005EA RID: 1514
		private delegate void get_includeLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x060005EC RID: 1516
		private delegate void set_includeLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x060005EE RID: 1518
		private delegate bool IsTouching_OtherColliderWithFilter_Internal_InjectedDelegate(IntPtr @this, IntPtr collider, IntPtr contactFilter);

		// Token: 0x020000E2 RID: 226
		// (Invoke) Token: 0x060005F0 RID: 1520
		private delegate bool IsTouching_AnyColliderWithFilter_Internal_InjectedDelegate(IntPtr @this, IntPtr contactFilter);

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x060005F2 RID: 1522
		private delegate bool OverlapPoint_InjectedDelegate(IntPtr @this, IntPtr point);

		// Token: 0x020000E4 RID: 228
		// (Invoke) Token: 0x060005F4 RID: 1524
		private delegate void AddForce_InjectedDelegate(IntPtr @this, IntPtr force, ForceMode2D mode);

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x060005F6 RID: 1526
		private delegate void AddRelativeForce_InjectedDelegate(IntPtr @this, IntPtr relativeForce, ForceMode2D mode);

		// Token: 0x020000E6 RID: 230
		// (Invoke) Token: 0x060005F8 RID: 1528
		private delegate void AddForceAtPosition_InjectedDelegate(IntPtr @this, IntPtr force, IntPtr position, ForceMode2D mode);

		// Token: 0x020000E7 RID: 231
		// (Invoke) Token: 0x060005FA RID: 1530
		private delegate void GetPoint_InjectedDelegate(IntPtr @this, IntPtr point, [Out] IntPtr ret);

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x060005FC RID: 1532
		private delegate void GetRelativePoint_InjectedDelegate(IntPtr @this, IntPtr relativePoint, [Out] IntPtr ret);

		// Token: 0x020000E9 RID: 233
		// (Invoke) Token: 0x060005FE RID: 1534
		private delegate void GetVector_InjectedDelegate(IntPtr @this, IntPtr vector, [Out] IntPtr ret);

		// Token: 0x020000EA RID: 234
		// (Invoke) Token: 0x06000600 RID: 1536
		private delegate void GetRelativeVector_InjectedDelegate(IntPtr @this, IntPtr relativeVector, [Out] IntPtr ret);

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x06000602 RID: 1538
		private delegate void GetPointVelocity_InjectedDelegate(IntPtr @this, IntPtr point, [Out] IntPtr ret);

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x06000604 RID: 1540
		private delegate void GetRelativePointVelocity_InjectedDelegate(IntPtr @this, IntPtr relativePoint, [Out] IntPtr ret);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x06000606 RID: 1542
		private delegate int OverlapColliderArray_Internal_InjectedDelegate(IntPtr @this, IntPtr contactFilter, IntPtr results);

		// Token: 0x020000EE RID: 238
		// (Invoke) Token: 0x06000608 RID: 1544
		private delegate int OverlapColliderList_Internal_InjectedDelegate(IntPtr @this, IntPtr contactFilter, IntPtr results);

		// Token: 0x020000EF RID: 239
		// (Invoke) Token: 0x0600060A RID: 1546
		private delegate int CastArray_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr results);

		// Token: 0x020000F0 RID: 240
		// (Invoke) Token: 0x0600060C RID: 1548
		private delegate int CastList_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr results);

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x0600060E RID: 1550
		private delegate int CastFilteredArray_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x06000610 RID: 1552
		private delegate int CastFilteredList_Internal_InjectedDelegate(IntPtr @this, IntPtr direction, float distance, IntPtr contactFilter, IntPtr results);
	}
}
