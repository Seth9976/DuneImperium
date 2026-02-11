using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002B RID: 43
	public sealed class WheelJoint2D : AnchoredJoint2D
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00004542 File Offset: 0x00002742
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00004554 File Offset: 0x00002754
		public bool useMotor
		{
			get
			{
				return WheelJoint2D.get_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelJoint2D.set_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00004567 File Offset: 0x00002767
		public float jointTranslation
		{
			get
			{
				return WheelJoint2D.get_jointTranslationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00004579 File Offset: 0x00002779
		public float jointLinearSpeed
		{
			get
			{
				return WheelJoint2D.get_jointLinearSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0000458B File Offset: 0x0000278B
		public float jointSpeed
		{
			get
			{
				return WheelJoint2D.get_jointSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0000459D File Offset: 0x0000279D
		public float jointAngle
		{
			get
			{
				return WheelJoint2D.get_jointAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000045AF File Offset: 0x000027AF
		public float GetMotorTorque(float timeStep)
		{
			return WheelJoint2D.GetMotorTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep);
		}

		// Token: 0x0400023D RID: 573
		private static readonly WheelJoint2D.get_useMotorDelegate get_useMotorDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_useMotorDelegate>("UnityEngine.WheelJoint2D::get_useMotor");

		// Token: 0x0400023E RID: 574
		private static readonly WheelJoint2D.set_useMotorDelegate set_useMotorDelegateField = IL2CPP.ResolveICall<WheelJoint2D.set_useMotorDelegate>("UnityEngine.WheelJoint2D::set_useMotor");

		// Token: 0x0400023F RID: 575
		private static readonly WheelJoint2D.get_jointTranslationDelegate get_jointTranslationDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_jointTranslationDelegate>("UnityEngine.WheelJoint2D::get_jointTranslation");

		// Token: 0x04000240 RID: 576
		private static readonly WheelJoint2D.get_jointLinearSpeedDelegate get_jointLinearSpeedDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_jointLinearSpeedDelegate>("UnityEngine.WheelJoint2D::get_jointLinearSpeed");

		// Token: 0x04000241 RID: 577
		private static readonly WheelJoint2D.get_jointSpeedDelegate get_jointSpeedDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_jointSpeedDelegate>("UnityEngine.WheelJoint2D::get_jointSpeed");

		// Token: 0x04000242 RID: 578
		private static readonly WheelJoint2D.get_jointAngleDelegate get_jointAngleDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_jointAngleDelegate>("UnityEngine.WheelJoint2D::get_jointAngle");

		// Token: 0x04000243 RID: 579
		private static readonly WheelJoint2D.GetMotorTorqueDelegate GetMotorTorqueDelegateField = IL2CPP.ResolveICall<WheelJoint2D.GetMotorTorqueDelegate>("UnityEngine.WheelJoint2D::GetMotorTorque");

		// Token: 0x020001C1 RID: 449
		// (Invoke) Token: 0x060007AA RID: 1962
		private delegate bool get_useMotorDelegate(IntPtr @this);

		// Token: 0x020001C2 RID: 450
		// (Invoke) Token: 0x060007AC RID: 1964
		private delegate void set_useMotorDelegate(IntPtr @this, bool value);

		// Token: 0x020001C3 RID: 451
		// (Invoke) Token: 0x060007AE RID: 1966
		private delegate float get_jointTranslationDelegate(IntPtr @this);

		// Token: 0x020001C4 RID: 452
		// (Invoke) Token: 0x060007B0 RID: 1968
		private delegate float get_jointLinearSpeedDelegate(IntPtr @this);

		// Token: 0x020001C5 RID: 453
		// (Invoke) Token: 0x060007B2 RID: 1970
		private delegate float get_jointSpeedDelegate(IntPtr @this);

		// Token: 0x020001C6 RID: 454
		// (Invoke) Token: 0x060007B4 RID: 1972
		private delegate float get_jointAngleDelegate(IntPtr @this);

		// Token: 0x020001C7 RID: 455
		// (Invoke) Token: 0x060007B6 RID: 1974
		private delegate float GetMotorTorqueDelegate(IntPtr @this, float timeStep);
	}
}
