using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000028 RID: 40
	public sealed class SliderJoint2D : AnchoredJoint2D
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00004303 File Offset: 0x00002503
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x00004315 File Offset: 0x00002515
		public bool autoConfigureAngle
		{
			get
			{
				return SliderJoint2D.get_autoConfigureAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SliderJoint2D.set_autoConfigureAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00004328 File Offset: 0x00002528
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x0000433A File Offset: 0x0000253A
		public float angle
		{
			get
			{
				return SliderJoint2D.get_angleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SliderJoint2D.set_angleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0000434D File Offset: 0x0000254D
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x0000435F File Offset: 0x0000255F
		public bool useMotor
		{
			get
			{
				return SliderJoint2D.get_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SliderJoint2D.set_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00004372 File Offset: 0x00002572
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x00004384 File Offset: 0x00002584
		public bool useLimits
		{
			get
			{
				return SliderJoint2D.get_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SliderJoint2D.set_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00004397 File Offset: 0x00002597
		public JointLimitState2D limitState
		{
			get
			{
				return SliderJoint2D.get_limitStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x000043A9 File Offset: 0x000025A9
		public float referenceAngle
		{
			get
			{
				return SliderJoint2D.get_referenceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x000043BB File Offset: 0x000025BB
		public float jointTranslation
		{
			get
			{
				return SliderJoint2D.get_jointTranslationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x000043CD File Offset: 0x000025CD
		public float jointSpeed
		{
			get
			{
				return SliderJoint2D.get_jointSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000043DF File Offset: 0x000025DF
		public float GetMotorForce(float timeStep)
		{
			return SliderJoint2D.GetMotorForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep);
		}

		// Token: 0x0400021F RID: 543
		private static readonly SliderJoint2D.get_autoConfigureAngleDelegate get_autoConfigureAngleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_autoConfigureAngleDelegate>("UnityEngine.SliderJoint2D::get_autoConfigureAngle");

		// Token: 0x04000220 RID: 544
		private static readonly SliderJoint2D.set_autoConfigureAngleDelegate set_autoConfigureAngleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.set_autoConfigureAngleDelegate>("UnityEngine.SliderJoint2D::set_autoConfigureAngle");

		// Token: 0x04000221 RID: 545
		private static readonly SliderJoint2D.get_angleDelegate get_angleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_angleDelegate>("UnityEngine.SliderJoint2D::get_angle");

		// Token: 0x04000222 RID: 546
		private static readonly SliderJoint2D.set_angleDelegate set_angleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.set_angleDelegate>("UnityEngine.SliderJoint2D::set_angle");

		// Token: 0x04000223 RID: 547
		private static readonly SliderJoint2D.get_useMotorDelegate get_useMotorDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_useMotorDelegate>("UnityEngine.SliderJoint2D::get_useMotor");

		// Token: 0x04000224 RID: 548
		private static readonly SliderJoint2D.set_useMotorDelegate set_useMotorDelegateField = IL2CPP.ResolveICall<SliderJoint2D.set_useMotorDelegate>("UnityEngine.SliderJoint2D::set_useMotor");

		// Token: 0x04000225 RID: 549
		private static readonly SliderJoint2D.get_useLimitsDelegate get_useLimitsDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_useLimitsDelegate>("UnityEngine.SliderJoint2D::get_useLimits");

		// Token: 0x04000226 RID: 550
		private static readonly SliderJoint2D.set_useLimitsDelegate set_useLimitsDelegateField = IL2CPP.ResolveICall<SliderJoint2D.set_useLimitsDelegate>("UnityEngine.SliderJoint2D::set_useLimits");

		// Token: 0x04000227 RID: 551
		private static readonly SliderJoint2D.get_limitStateDelegate get_limitStateDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_limitStateDelegate>("UnityEngine.SliderJoint2D::get_limitState");

		// Token: 0x04000228 RID: 552
		private static readonly SliderJoint2D.get_referenceAngleDelegate get_referenceAngleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_referenceAngleDelegate>("UnityEngine.SliderJoint2D::get_referenceAngle");

		// Token: 0x04000229 RID: 553
		private static readonly SliderJoint2D.get_jointTranslationDelegate get_jointTranslationDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_jointTranslationDelegate>("UnityEngine.SliderJoint2D::get_jointTranslation");

		// Token: 0x0400022A RID: 554
		private static readonly SliderJoint2D.get_jointSpeedDelegate get_jointSpeedDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_jointSpeedDelegate>("UnityEngine.SliderJoint2D::get_jointSpeed");

		// Token: 0x0400022B RID: 555
		private static readonly SliderJoint2D.GetMotorForceDelegate GetMotorForceDelegateField = IL2CPP.ResolveICall<SliderJoint2D.GetMotorForceDelegate>("UnityEngine.SliderJoint2D::GetMotorForce");

		// Token: 0x020001A3 RID: 419
		// (Invoke) Token: 0x0600076E RID: 1902
		private delegate bool get_autoConfigureAngleDelegate(IntPtr @this);

		// Token: 0x020001A4 RID: 420
		// (Invoke) Token: 0x06000770 RID: 1904
		private delegate void set_autoConfigureAngleDelegate(IntPtr @this, bool value);

		// Token: 0x020001A5 RID: 421
		// (Invoke) Token: 0x06000772 RID: 1906
		private delegate float get_angleDelegate(IntPtr @this);

		// Token: 0x020001A6 RID: 422
		// (Invoke) Token: 0x06000774 RID: 1908
		private delegate void set_angleDelegate(IntPtr @this, float value);

		// Token: 0x020001A7 RID: 423
		// (Invoke) Token: 0x06000776 RID: 1910
		private delegate bool get_useMotorDelegate(IntPtr @this);

		// Token: 0x020001A8 RID: 424
		// (Invoke) Token: 0x06000778 RID: 1912
		private delegate void set_useMotorDelegate(IntPtr @this, bool value);

		// Token: 0x020001A9 RID: 425
		// (Invoke) Token: 0x0600077A RID: 1914
		private delegate bool get_useLimitsDelegate(IntPtr @this);

		// Token: 0x020001AA RID: 426
		// (Invoke) Token: 0x0600077C RID: 1916
		private delegate void set_useLimitsDelegate(IntPtr @this, bool value);

		// Token: 0x020001AB RID: 427
		// (Invoke) Token: 0x0600077E RID: 1918
		private delegate JointLimitState2D get_limitStateDelegate(IntPtr @this);

		// Token: 0x020001AC RID: 428
		// (Invoke) Token: 0x06000780 RID: 1920
		private delegate float get_referenceAngleDelegate(IntPtr @this);

		// Token: 0x020001AD RID: 429
		// (Invoke) Token: 0x06000782 RID: 1922
		private delegate float get_jointTranslationDelegate(IntPtr @this);

		// Token: 0x020001AE RID: 430
		// (Invoke) Token: 0x06000784 RID: 1924
		private delegate float get_jointSpeedDelegate(IntPtr @this);

		// Token: 0x020001AF RID: 431
		// (Invoke) Token: 0x06000786 RID: 1926
		private delegate float GetMotorForceDelegate(IntPtr @this, float timeStep);
	}
}
