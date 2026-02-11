using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000026 RID: 38
	public sealed class HingeJoint2D : AnchoredJoint2D
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00004162 File Offset: 0x00002362
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00004174 File Offset: 0x00002374
		public bool useMotor
		{
			get
			{
				return HingeJoint2D.get_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint2D.set_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00004187 File Offset: 0x00002387
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00004199 File Offset: 0x00002399
		public bool useLimits
		{
			get
			{
				return HingeJoint2D.get_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint2D.set_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x000041AC File Offset: 0x000023AC
		public JointLimitState2D limitState
		{
			get
			{
				return HingeJoint2D.get_limitStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x000041BE File Offset: 0x000023BE
		public float referenceAngle
		{
			get
			{
				return HingeJoint2D.get_referenceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x000041D0 File Offset: 0x000023D0
		public float jointAngle
		{
			get
			{
				return HingeJoint2D.get_jointAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x000041E2 File Offset: 0x000023E2
		public float jointSpeed
		{
			get
			{
				return HingeJoint2D.get_jointSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000041F4 File Offset: 0x000023F4
		public float GetMotorTorque(float timeStep)
		{
			return HingeJoint2D.GetMotorTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep);
		}

		// Token: 0x04000209 RID: 521
		private static readonly HingeJoint2D.get_useMotorDelegate get_useMotorDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_useMotorDelegate>("UnityEngine.HingeJoint2D::get_useMotor");

		// Token: 0x0400020A RID: 522
		private static readonly HingeJoint2D.set_useMotorDelegate set_useMotorDelegateField = IL2CPP.ResolveICall<HingeJoint2D.set_useMotorDelegate>("UnityEngine.HingeJoint2D::set_useMotor");

		// Token: 0x0400020B RID: 523
		private static readonly HingeJoint2D.get_useLimitsDelegate get_useLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_useLimitsDelegate>("UnityEngine.HingeJoint2D::get_useLimits");

		// Token: 0x0400020C RID: 524
		private static readonly HingeJoint2D.set_useLimitsDelegate set_useLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint2D.set_useLimitsDelegate>("UnityEngine.HingeJoint2D::set_useLimits");

		// Token: 0x0400020D RID: 525
		private static readonly HingeJoint2D.get_limitStateDelegate get_limitStateDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_limitStateDelegate>("UnityEngine.HingeJoint2D::get_limitState");

		// Token: 0x0400020E RID: 526
		private static readonly HingeJoint2D.get_referenceAngleDelegate get_referenceAngleDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_referenceAngleDelegate>("UnityEngine.HingeJoint2D::get_referenceAngle");

		// Token: 0x0400020F RID: 527
		private static readonly HingeJoint2D.get_jointAngleDelegate get_jointAngleDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_jointAngleDelegate>("UnityEngine.HingeJoint2D::get_jointAngle");

		// Token: 0x04000210 RID: 528
		private static readonly HingeJoint2D.get_jointSpeedDelegate get_jointSpeedDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_jointSpeedDelegate>("UnityEngine.HingeJoint2D::get_jointSpeed");

		// Token: 0x04000211 RID: 529
		private static readonly HingeJoint2D.GetMotorTorqueDelegate GetMotorTorqueDelegateField = IL2CPP.ResolveICall<HingeJoint2D.GetMotorTorqueDelegate>("UnityEngine.HingeJoint2D::GetMotorTorque");

		// Token: 0x0200018D RID: 397
		// (Invoke) Token: 0x06000742 RID: 1858
		private delegate bool get_useMotorDelegate(IntPtr @this);

		// Token: 0x0200018E RID: 398
		// (Invoke) Token: 0x06000744 RID: 1860
		private delegate void set_useMotorDelegate(IntPtr @this, bool value);

		// Token: 0x0200018F RID: 399
		// (Invoke) Token: 0x06000746 RID: 1862
		private delegate bool get_useLimitsDelegate(IntPtr @this);

		// Token: 0x02000190 RID: 400
		// (Invoke) Token: 0x06000748 RID: 1864
		private delegate void set_useLimitsDelegate(IntPtr @this, bool value);

		// Token: 0x02000191 RID: 401
		// (Invoke) Token: 0x0600074A RID: 1866
		private delegate JointLimitState2D get_limitStateDelegate(IntPtr @this);

		// Token: 0x02000192 RID: 402
		// (Invoke) Token: 0x0600074C RID: 1868
		private delegate float get_referenceAngleDelegate(IntPtr @this);

		// Token: 0x02000193 RID: 403
		// (Invoke) Token: 0x0600074E RID: 1870
		private delegate float get_jointAngleDelegate(IntPtr @this);

		// Token: 0x02000194 RID: 404
		// (Invoke) Token: 0x06000750 RID: 1872
		private delegate float get_jointSpeedDelegate(IntPtr @this);

		// Token: 0x02000195 RID: 405
		// (Invoke) Token: 0x06000752 RID: 1874
		private delegate float GetMotorTorqueDelegate(IntPtr @this, float timeStep);
	}
}
