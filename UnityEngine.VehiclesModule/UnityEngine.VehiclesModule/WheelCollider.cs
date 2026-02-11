using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class WheelCollider : Collider
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002438 File Offset: 0x00000638
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.get_center_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000205A File Offset: 0x0000025A
		// (set) Token: 0x06000005 RID: 5 RVA: 0x0000206C File Offset: 0x0000026C
		public float radius
		{
			get
			{
				return WheelCollider.get_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelCollider.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000207F File Offset: 0x0000027F
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002091 File Offset: 0x00000291
		public float suspensionDistance
		{
			get
			{
				return WheelCollider.get_suspensionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelCollider.set_suspensionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020A4 File Offset: 0x000002A4
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000020B6 File Offset: 0x000002B6
		public bool suspensionExpansionLimited
		{
			get
			{
				return WheelCollider.get_suspensionExpansionLimitedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelCollider.set_suspensionExpansionLimitedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020C9 File Offset: 0x000002C9
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000020DB File Offset: 0x000002DB
		public float forceAppPointDistance
		{
			get
			{
				return WheelCollider.get_forceAppPointDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelCollider.set_forceAppPointDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020EE File Offset: 0x000002EE
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002100 File Offset: 0x00000300
		public float mass
		{
			get
			{
				return WheelCollider.get_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelCollider.set_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002113 File Offset: 0x00000313
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002125 File Offset: 0x00000325
		public float wheelDampingRate
		{
			get
			{
				return WheelCollider.get_wheelDampingRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelCollider.set_wheelDampingRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002138 File Offset: 0x00000338
		// (set) Token: 0x06000011 RID: 17 RVA: 0x0000214A File Offset: 0x0000034A
		public float motorTorque
		{
			get
			{
				return WheelCollider.get_motorTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelCollider.set_motorTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000215D File Offset: 0x0000035D
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000216F File Offset: 0x0000036F
		public float brakeTorque
		{
			get
			{
				return WheelCollider.get_brakeTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelCollider.set_brakeTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002182 File Offset: 0x00000382
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002194 File Offset: 0x00000394
		public float steerAngle
		{
			get
			{
				return WheelCollider.get_steerAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelCollider.set_steerAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000021A7 File Offset: 0x000003A7
		public bool isGrounded
		{
			get
			{
				return WheelCollider.get_isGroundedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000021B9 File Offset: 0x000003B9
		public float rpm
		{
			get
			{
				return WheelCollider.get_rpmDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000021CB File Offset: 0x000003CB
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000021DD File Offset: 0x000003DD
		public float sprungMass
		{
			get
			{
				return WheelCollider.get_sprungMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelCollider.set_sprungMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000021F0 File Offset: 0x000003F0
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002202 File Offset: 0x00000402
		public float rotationSpeed
		{
			get
			{
				return WheelCollider.get_rotationSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelCollider.set_rotationSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002215 File Offset: 0x00000415
		public void ResetSprungMasses()
		{
			WheelCollider.ResetSprungMassesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002227 File Offset: 0x00000427
		public void ConfigureVehicleSubsteps(float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold)
		{
			WheelCollider.ConfigureVehicleSubstepsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), speedThreshold, stepsBelowThreshold, stepsAboveThreshold);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000223C File Offset: 0x0000043C
		public void GetWorldPose(out Vector3 pos, out Quaternion quat)
		{
			WheelCollider.GetWorldPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out pos, out quat);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002250 File Offset: 0x00000450
		public void get_center_Injected(out Vector3 ret)
		{
			WheelCollider.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002263 File Offset: 0x00000463
		public void set_center_Injected(ref Vector3 value)
		{
			WheelCollider.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000001 RID: 1
		private static readonly WheelCollider.get_radiusDelegate get_radiusDelegateField = IL2CPP.ResolveICall<WheelCollider.get_radiusDelegate>("UnityEngine.WheelCollider::get_radius");

		// Token: 0x04000002 RID: 2
		private static readonly WheelCollider.set_radiusDelegate set_radiusDelegateField = IL2CPP.ResolveICall<WheelCollider.set_radiusDelegate>("UnityEngine.WheelCollider::set_radius");

		// Token: 0x04000003 RID: 3
		private static readonly WheelCollider.get_suspensionDistanceDelegate get_suspensionDistanceDelegateField = IL2CPP.ResolveICall<WheelCollider.get_suspensionDistanceDelegate>("UnityEngine.WheelCollider::get_suspensionDistance");

		// Token: 0x04000004 RID: 4
		private static readonly WheelCollider.set_suspensionDistanceDelegate set_suspensionDistanceDelegateField = IL2CPP.ResolveICall<WheelCollider.set_suspensionDistanceDelegate>("UnityEngine.WheelCollider::set_suspensionDistance");

		// Token: 0x04000005 RID: 5
		private static readonly WheelCollider.get_suspensionExpansionLimitedDelegate get_suspensionExpansionLimitedDelegateField = IL2CPP.ResolveICall<WheelCollider.get_suspensionExpansionLimitedDelegate>("UnityEngine.WheelCollider::get_suspensionExpansionLimited");

		// Token: 0x04000006 RID: 6
		private static readonly WheelCollider.set_suspensionExpansionLimitedDelegate set_suspensionExpansionLimitedDelegateField = IL2CPP.ResolveICall<WheelCollider.set_suspensionExpansionLimitedDelegate>("UnityEngine.WheelCollider::set_suspensionExpansionLimited");

		// Token: 0x04000007 RID: 7
		private static readonly WheelCollider.get_forceAppPointDistanceDelegate get_forceAppPointDistanceDelegateField = IL2CPP.ResolveICall<WheelCollider.get_forceAppPointDistanceDelegate>("UnityEngine.WheelCollider::get_forceAppPointDistance");

		// Token: 0x04000008 RID: 8
		private static readonly WheelCollider.set_forceAppPointDistanceDelegate set_forceAppPointDistanceDelegateField = IL2CPP.ResolveICall<WheelCollider.set_forceAppPointDistanceDelegate>("UnityEngine.WheelCollider::set_forceAppPointDistance");

		// Token: 0x04000009 RID: 9
		private static readonly WheelCollider.get_massDelegate get_massDelegateField = IL2CPP.ResolveICall<WheelCollider.get_massDelegate>("UnityEngine.WheelCollider::get_mass");

		// Token: 0x0400000A RID: 10
		private static readonly WheelCollider.set_massDelegate set_massDelegateField = IL2CPP.ResolveICall<WheelCollider.set_massDelegate>("UnityEngine.WheelCollider::set_mass");

		// Token: 0x0400000B RID: 11
		private static readonly WheelCollider.get_wheelDampingRateDelegate get_wheelDampingRateDelegateField = IL2CPP.ResolveICall<WheelCollider.get_wheelDampingRateDelegate>("UnityEngine.WheelCollider::get_wheelDampingRate");

		// Token: 0x0400000C RID: 12
		private static readonly WheelCollider.set_wheelDampingRateDelegate set_wheelDampingRateDelegateField = IL2CPP.ResolveICall<WheelCollider.set_wheelDampingRateDelegate>("UnityEngine.WheelCollider::set_wheelDampingRate");

		// Token: 0x0400000D RID: 13
		private static readonly WheelCollider.get_motorTorqueDelegate get_motorTorqueDelegateField = IL2CPP.ResolveICall<WheelCollider.get_motorTorqueDelegate>("UnityEngine.WheelCollider::get_motorTorque");

		// Token: 0x0400000E RID: 14
		private static readonly WheelCollider.set_motorTorqueDelegate set_motorTorqueDelegateField = IL2CPP.ResolveICall<WheelCollider.set_motorTorqueDelegate>("UnityEngine.WheelCollider::set_motorTorque");

		// Token: 0x0400000F RID: 15
		private static readonly WheelCollider.get_brakeTorqueDelegate get_brakeTorqueDelegateField = IL2CPP.ResolveICall<WheelCollider.get_brakeTorqueDelegate>("UnityEngine.WheelCollider::get_brakeTorque");

		// Token: 0x04000010 RID: 16
		private static readonly WheelCollider.set_brakeTorqueDelegate set_brakeTorqueDelegateField = IL2CPP.ResolveICall<WheelCollider.set_brakeTorqueDelegate>("UnityEngine.WheelCollider::set_brakeTorque");

		// Token: 0x04000011 RID: 17
		private static readonly WheelCollider.get_steerAngleDelegate get_steerAngleDelegateField = IL2CPP.ResolveICall<WheelCollider.get_steerAngleDelegate>("UnityEngine.WheelCollider::get_steerAngle");

		// Token: 0x04000012 RID: 18
		private static readonly WheelCollider.set_steerAngleDelegate set_steerAngleDelegateField = IL2CPP.ResolveICall<WheelCollider.set_steerAngleDelegate>("UnityEngine.WheelCollider::set_steerAngle");

		// Token: 0x04000013 RID: 19
		private static readonly WheelCollider.get_isGroundedDelegate get_isGroundedDelegateField = IL2CPP.ResolveICall<WheelCollider.get_isGroundedDelegate>("UnityEngine.WheelCollider::get_isGrounded");

		// Token: 0x04000014 RID: 20
		private static readonly WheelCollider.get_rpmDelegate get_rpmDelegateField = IL2CPP.ResolveICall<WheelCollider.get_rpmDelegate>("UnityEngine.WheelCollider::get_rpm");

		// Token: 0x04000015 RID: 21
		private static readonly WheelCollider.get_sprungMassDelegate get_sprungMassDelegateField = IL2CPP.ResolveICall<WheelCollider.get_sprungMassDelegate>("UnityEngine.WheelCollider::get_sprungMass");

		// Token: 0x04000016 RID: 22
		private static readonly WheelCollider.set_sprungMassDelegate set_sprungMassDelegateField = IL2CPP.ResolveICall<WheelCollider.set_sprungMassDelegate>("UnityEngine.WheelCollider::set_sprungMass");

		// Token: 0x04000017 RID: 23
		private static readonly WheelCollider.get_rotationSpeedDelegate get_rotationSpeedDelegateField = IL2CPP.ResolveICall<WheelCollider.get_rotationSpeedDelegate>("UnityEngine.WheelCollider::get_rotationSpeed");

		// Token: 0x04000018 RID: 24
		private static readonly WheelCollider.set_rotationSpeedDelegate set_rotationSpeedDelegateField = IL2CPP.ResolveICall<WheelCollider.set_rotationSpeedDelegate>("UnityEngine.WheelCollider::set_rotationSpeed");

		// Token: 0x04000019 RID: 25
		private static readonly WheelCollider.ResetSprungMassesDelegate ResetSprungMassesDelegateField = IL2CPP.ResolveICall<WheelCollider.ResetSprungMassesDelegate>("UnityEngine.WheelCollider::ResetSprungMasses");

		// Token: 0x0400001A RID: 26
		private static readonly WheelCollider.ConfigureVehicleSubstepsDelegate ConfigureVehicleSubstepsDelegateField = IL2CPP.ResolveICall<WheelCollider.ConfigureVehicleSubstepsDelegate>("UnityEngine.WheelCollider::ConfigureVehicleSubsteps");

		// Token: 0x0400001B RID: 27
		private static readonly WheelCollider.GetWorldPoseDelegate GetWorldPoseDelegateField = IL2CPP.ResolveICall<WheelCollider.GetWorldPoseDelegate>("UnityEngine.WheelCollider::GetWorldPose");

		// Token: 0x0400001C RID: 28
		private static readonly WheelCollider.get_center_InjectedDelegate get_center_InjectedDelegateField = IL2CPP.ResolveICall<WheelCollider.get_center_InjectedDelegate>("UnityEngine.WheelCollider::get_center_Injected");

		// Token: 0x0400001D RID: 29
		private static readonly WheelCollider.set_center_InjectedDelegate set_center_InjectedDelegateField = IL2CPP.ResolveICall<WheelCollider.set_center_InjectedDelegate>("UnityEngine.WheelCollider::set_center_Injected");

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000022 RID: 34
		private delegate float get_radiusDelegate(IntPtr @this);

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000024 RID: 36
		private delegate void set_radiusDelegate(IntPtr @this, float value);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000026 RID: 38
		private delegate float get_suspensionDistanceDelegate(IntPtr @this);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000028 RID: 40
		private delegate void set_suspensionDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600002A RID: 42
		private delegate bool get_suspensionExpansionLimitedDelegate(IntPtr @this);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600002C RID: 44
		private delegate void set_suspensionExpansionLimitedDelegate(IntPtr @this, bool value);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600002E RID: 46
		private delegate float get_forceAppPointDistanceDelegate(IntPtr @this);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000030 RID: 48
		private delegate void set_forceAppPointDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000032 RID: 50
		private delegate float get_massDelegate(IntPtr @this);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000034 RID: 52
		private delegate void set_massDelegate(IntPtr @this, float value);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000036 RID: 54
		private delegate float get_wheelDampingRateDelegate(IntPtr @this);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000038 RID: 56
		private delegate void set_wheelDampingRateDelegate(IntPtr @this, float value);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x0600003A RID: 58
		private delegate float get_motorTorqueDelegate(IntPtr @this);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x0600003C RID: 60
		private delegate void set_motorTorqueDelegate(IntPtr @this, float value);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600003E RID: 62
		private delegate float get_brakeTorqueDelegate(IntPtr @this);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000040 RID: 64
		private delegate void set_brakeTorqueDelegate(IntPtr @this, float value);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000042 RID: 66
		private delegate float get_steerAngleDelegate(IntPtr @this);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000044 RID: 68
		private delegate void set_steerAngleDelegate(IntPtr @this, float value);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000046 RID: 70
		private delegate bool get_isGroundedDelegate(IntPtr @this);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000048 RID: 72
		private delegate float get_rpmDelegate(IntPtr @this);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x0600004A RID: 74
		private delegate float get_sprungMassDelegate(IntPtr @this);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x0600004C RID: 76
		private delegate void set_sprungMassDelegate(IntPtr @this, float value);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600004E RID: 78
		private delegate float get_rotationSpeedDelegate(IntPtr @this);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x06000050 RID: 80
		private delegate void set_rotationSpeedDelegate(IntPtr @this, float value);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000052 RID: 82
		private delegate void ResetSprungMassesDelegate(IntPtr @this);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000054 RID: 84
		private delegate void ConfigureVehicleSubstepsDelegate(IntPtr @this, float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000056 RID: 86
		private delegate void GetWorldPoseDelegate(IntPtr @this, [Out] IntPtr pos, [Out] IntPtr quat);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000058 RID: 88
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x0600005A RID: 90
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
