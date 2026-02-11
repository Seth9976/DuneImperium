using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000025 RID: 37
	public sealed class FrictionJoint2D : AnchoredJoint2D
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00004118 File Offset: 0x00002318
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0000412A File Offset: 0x0000232A
		public float maxForce
		{
			get
			{
				return FrictionJoint2D.get_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				FrictionJoint2D.set_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0000413D File Offset: 0x0000233D
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x0000414F File Offset: 0x0000234F
		public float maxTorque
		{
			get
			{
				return FrictionJoint2D.get_maxTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				FrictionJoint2D.set_maxTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000205 RID: 517
		private static readonly FrictionJoint2D.get_maxForceDelegate get_maxForceDelegateField = IL2CPP.ResolveICall<FrictionJoint2D.get_maxForceDelegate>("UnityEngine.FrictionJoint2D::get_maxForce");

		// Token: 0x04000206 RID: 518
		private static readonly FrictionJoint2D.set_maxForceDelegate set_maxForceDelegateField = IL2CPP.ResolveICall<FrictionJoint2D.set_maxForceDelegate>("UnityEngine.FrictionJoint2D::set_maxForce");

		// Token: 0x04000207 RID: 519
		private static readonly FrictionJoint2D.get_maxTorqueDelegate get_maxTorqueDelegateField = IL2CPP.ResolveICall<FrictionJoint2D.get_maxTorqueDelegate>("UnityEngine.FrictionJoint2D::get_maxTorque");

		// Token: 0x04000208 RID: 520
		private static readonly FrictionJoint2D.set_maxTorqueDelegate set_maxTorqueDelegateField = IL2CPP.ResolveICall<FrictionJoint2D.set_maxTorqueDelegate>("UnityEngine.FrictionJoint2D::set_maxTorque");

		// Token: 0x02000189 RID: 393
		// (Invoke) Token: 0x0600073A RID: 1850
		private delegate float get_maxForceDelegate(IntPtr @this);

		// Token: 0x0200018A RID: 394
		// (Invoke) Token: 0x0600073C RID: 1852
		private delegate void set_maxForceDelegate(IntPtr @this, float value);

		// Token: 0x0200018B RID: 395
		// (Invoke) Token: 0x0600073E RID: 1854
		private delegate float get_maxTorqueDelegate(IntPtr @this);

		// Token: 0x0200018C RID: 396
		// (Invoke) Token: 0x06000740 RID: 1856
		private delegate void set_maxTorqueDelegate(IntPtr @this, float value);
	}
}
