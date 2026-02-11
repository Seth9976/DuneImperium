using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000029 RID: 41
	public class HingeJoint : Joint
	{
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x000042F0 File Offset: 0x000024F0
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00004302 File Offset: 0x00002502
		public bool useMotor
		{
			get
			{
				return HingeJoint.get_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint.set_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00004315 File Offset: 0x00002515
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00004327 File Offset: 0x00002527
		public bool useLimits
		{
			get
			{
				return HingeJoint.get_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint.set_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0000433A File Offset: 0x0000253A
		// (set) Token: 0x060003DD RID: 989 RVA: 0x0000434C File Offset: 0x0000254C
		public bool extendedLimits
		{
			get
			{
				return HingeJoint.get_extendedLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint.set_extendedLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0000435F File Offset: 0x0000255F
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00004371 File Offset: 0x00002571
		public bool useSpring
		{
			get
			{
				return HingeJoint.get_useSpringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint.set_useSpringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00004384 File Offset: 0x00002584
		public float velocity
		{
			get
			{
				return HingeJoint.get_velocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00004396 File Offset: 0x00002596
		public float angle
		{
			get
			{
				return HingeJoint.get_angleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x000043A8 File Offset: 0x000025A8
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x000043BA File Offset: 0x000025BA
		public bool useAcceleration
		{
			get
			{
				return HingeJoint.get_useAccelerationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint.set_useAccelerationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040002C6 RID: 710
		private static readonly HingeJoint.get_useMotorDelegate get_useMotorDelegateField = IL2CPP.ResolveICall<HingeJoint.get_useMotorDelegate>("UnityEngine.HingeJoint::get_useMotor");

		// Token: 0x040002C7 RID: 711
		private static readonly HingeJoint.set_useMotorDelegate set_useMotorDelegateField = IL2CPP.ResolveICall<HingeJoint.set_useMotorDelegate>("UnityEngine.HingeJoint::set_useMotor");

		// Token: 0x040002C8 RID: 712
		private static readonly HingeJoint.get_useLimitsDelegate get_useLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint.get_useLimitsDelegate>("UnityEngine.HingeJoint::get_useLimits");

		// Token: 0x040002C9 RID: 713
		private static readonly HingeJoint.set_useLimitsDelegate set_useLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint.set_useLimitsDelegate>("UnityEngine.HingeJoint::set_useLimits");

		// Token: 0x040002CA RID: 714
		private static readonly HingeJoint.get_extendedLimitsDelegate get_extendedLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint.get_extendedLimitsDelegate>("UnityEngine.HingeJoint::get_extendedLimits");

		// Token: 0x040002CB RID: 715
		private static readonly HingeJoint.set_extendedLimitsDelegate set_extendedLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint.set_extendedLimitsDelegate>("UnityEngine.HingeJoint::set_extendedLimits");

		// Token: 0x040002CC RID: 716
		private static readonly HingeJoint.get_useSpringDelegate get_useSpringDelegateField = IL2CPP.ResolveICall<HingeJoint.get_useSpringDelegate>("UnityEngine.HingeJoint::get_useSpring");

		// Token: 0x040002CD RID: 717
		private static readonly HingeJoint.set_useSpringDelegate set_useSpringDelegateField = IL2CPP.ResolveICall<HingeJoint.set_useSpringDelegate>("UnityEngine.HingeJoint::set_useSpring");

		// Token: 0x040002CE RID: 718
		private static readonly HingeJoint.get_velocityDelegate get_velocityDelegateField = IL2CPP.ResolveICall<HingeJoint.get_velocityDelegate>("UnityEngine.HingeJoint::get_velocity");

		// Token: 0x040002CF RID: 719
		private static readonly HingeJoint.get_angleDelegate get_angleDelegateField = IL2CPP.ResolveICall<HingeJoint.get_angleDelegate>("UnityEngine.HingeJoint::get_angle");

		// Token: 0x040002D0 RID: 720
		private static readonly HingeJoint.get_useAccelerationDelegate get_useAccelerationDelegateField = IL2CPP.ResolveICall<HingeJoint.get_useAccelerationDelegate>("UnityEngine.HingeJoint::get_useAcceleration");

		// Token: 0x040002D1 RID: 721
		private static readonly HingeJoint.set_useAccelerationDelegate set_useAccelerationDelegateField = IL2CPP.ResolveICall<HingeJoint.set_useAccelerationDelegate>("UnityEngine.HingeJoint::set_useAcceleration");

		// Token: 0x02000199 RID: 409
		// (Invoke) Token: 0x0600070A RID: 1802
		private delegate bool get_useMotorDelegate(IntPtr @this);

		// Token: 0x0200019A RID: 410
		// (Invoke) Token: 0x0600070C RID: 1804
		private delegate void set_useMotorDelegate(IntPtr @this, bool value);

		// Token: 0x0200019B RID: 411
		// (Invoke) Token: 0x0600070E RID: 1806
		private delegate bool get_useLimitsDelegate(IntPtr @this);

		// Token: 0x0200019C RID: 412
		// (Invoke) Token: 0x06000710 RID: 1808
		private delegate void set_useLimitsDelegate(IntPtr @this, bool value);

		// Token: 0x0200019D RID: 413
		// (Invoke) Token: 0x06000712 RID: 1810
		private delegate bool get_extendedLimitsDelegate(IntPtr @this);

		// Token: 0x0200019E RID: 414
		// (Invoke) Token: 0x06000714 RID: 1812
		private delegate void set_extendedLimitsDelegate(IntPtr @this, bool value);

		// Token: 0x0200019F RID: 415
		// (Invoke) Token: 0x06000716 RID: 1814
		private delegate bool get_useSpringDelegate(IntPtr @this);

		// Token: 0x020001A0 RID: 416
		// (Invoke) Token: 0x06000718 RID: 1816
		private delegate void set_useSpringDelegate(IntPtr @this, bool value);

		// Token: 0x020001A1 RID: 417
		// (Invoke) Token: 0x0600071A RID: 1818
		private delegate float get_velocityDelegate(IntPtr @this);

		// Token: 0x020001A2 RID: 418
		// (Invoke) Token: 0x0600071C RID: 1820
		private delegate float get_angleDelegate(IntPtr @this);

		// Token: 0x020001A3 RID: 419
		// (Invoke) Token: 0x0600071E RID: 1822
		private delegate bool get_useAccelerationDelegate(IntPtr @this);

		// Token: 0x020001A4 RID: 420
		// (Invoke) Token: 0x06000720 RID: 1824
		private delegate void set_useAccelerationDelegate(IntPtr @this, bool value);
	}
}
