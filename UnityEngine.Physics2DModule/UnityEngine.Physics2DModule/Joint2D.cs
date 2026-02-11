using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000021 RID: 33
	public class Joint2D : Behaviour
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0000BF5C File Offset: 0x0000A15C
		public Rigidbody2D attachedRigidbody
		{
			get
			{
				IntPtr intPtr = Joint2D.get_attachedRigidbodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0000BF88 File Offset: 0x0000A188
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00003E4F File Offset: 0x0000204F
		public Rigidbody2D connectedBody
		{
			get
			{
				IntPtr intPtr = Joint2D.get_connectedBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				Joint2D.set_connectedBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00003E67 File Offset: 0x00002067
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00003E79 File Offset: 0x00002079
		public bool enableCollision
		{
			get
			{
				return Joint2D.get_enableCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint2D.set_enableCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00003E8C File Offset: 0x0000208C
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00003E9E File Offset: 0x0000209E
		public float breakForce
		{
			get
			{
				return Joint2D.get_breakForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint2D.set_breakForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00003EB1 File Offset: 0x000020B1
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00003EC3 File Offset: 0x000020C3
		public float breakTorque
		{
			get
			{
				return Joint2D.get_breakTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint2D.set_breakTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00003ED6 File Offset: 0x000020D6
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00003EE8 File Offset: 0x000020E8
		public JointBreakAction2D breakAction
		{
			get
			{
				return Joint2D.get_breakActionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint2D.set_breakActionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		public Vector2 reactionForce
		{
			get
			{
				Vector2 vector;
				this.get_reactionForce_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00003EFB File Offset: 0x000020FB
		public float reactionTorque
		{
			get
			{
				return Joint2D.get_reactionTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		public Vector2 GetReactionForce(float timeStep)
		{
			Vector2 vector;
			this.GetReactionForce_Injected(timeStep, out vector);
			return vector;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00003F0D File Offset: 0x0000210D
		public float GetReactionTorque(float timeStep)
		{
			return Joint2D.GetReactionTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep);
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00003F20 File Offset: 0x00002120
		public bool collideConnected
		{
			get
			{
				return this.enableCollision;
			}
			set
			{
				this.enableCollision = value;
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00003F2B File Offset: 0x0000212B
		public void get_reactionForce_Injected(out Vector2 ret)
		{
			Joint2D.get_reactionForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00003F3E File Offset: 0x0000213E
		public void GetReactionForce_Injected(float timeStep, out Vector2 ret)
		{
			Joint2D.GetReactionForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep, out ret);
		}

		// Token: 0x040001E2 RID: 482
		private static readonly Joint2D.get_attachedRigidbodyDelegate get_attachedRigidbodyDelegateField = IL2CPP.ResolveICall<Joint2D.get_attachedRigidbodyDelegate>("UnityEngine.Joint2D::get_attachedRigidbody");

		// Token: 0x040001E3 RID: 483
		private static readonly Joint2D.get_connectedBodyDelegate get_connectedBodyDelegateField = IL2CPP.ResolveICall<Joint2D.get_connectedBodyDelegate>("UnityEngine.Joint2D::get_connectedBody");

		// Token: 0x040001E4 RID: 484
		private static readonly Joint2D.set_connectedBodyDelegate set_connectedBodyDelegateField = IL2CPP.ResolveICall<Joint2D.set_connectedBodyDelegate>("UnityEngine.Joint2D::set_connectedBody");

		// Token: 0x040001E5 RID: 485
		private static readonly Joint2D.get_enableCollisionDelegate get_enableCollisionDelegateField = IL2CPP.ResolveICall<Joint2D.get_enableCollisionDelegate>("UnityEngine.Joint2D::get_enableCollision");

		// Token: 0x040001E6 RID: 486
		private static readonly Joint2D.set_enableCollisionDelegate set_enableCollisionDelegateField = IL2CPP.ResolveICall<Joint2D.set_enableCollisionDelegate>("UnityEngine.Joint2D::set_enableCollision");

		// Token: 0x040001E7 RID: 487
		private static readonly Joint2D.get_breakForceDelegate get_breakForceDelegateField = IL2CPP.ResolveICall<Joint2D.get_breakForceDelegate>("UnityEngine.Joint2D::get_breakForce");

		// Token: 0x040001E8 RID: 488
		private static readonly Joint2D.set_breakForceDelegate set_breakForceDelegateField = IL2CPP.ResolveICall<Joint2D.set_breakForceDelegate>("UnityEngine.Joint2D::set_breakForce");

		// Token: 0x040001E9 RID: 489
		private static readonly Joint2D.get_breakTorqueDelegate get_breakTorqueDelegateField = IL2CPP.ResolveICall<Joint2D.get_breakTorqueDelegate>("UnityEngine.Joint2D::get_breakTorque");

		// Token: 0x040001EA RID: 490
		private static readonly Joint2D.set_breakTorqueDelegate set_breakTorqueDelegateField = IL2CPP.ResolveICall<Joint2D.set_breakTorqueDelegate>("UnityEngine.Joint2D::set_breakTorque");

		// Token: 0x040001EB RID: 491
		private static readonly Joint2D.get_breakActionDelegate get_breakActionDelegateField = IL2CPP.ResolveICall<Joint2D.get_breakActionDelegate>("UnityEngine.Joint2D::get_breakAction");

		// Token: 0x040001EC RID: 492
		private static readonly Joint2D.set_breakActionDelegate set_breakActionDelegateField = IL2CPP.ResolveICall<Joint2D.set_breakActionDelegate>("UnityEngine.Joint2D::set_breakAction");

		// Token: 0x040001ED RID: 493
		private static readonly Joint2D.get_reactionTorqueDelegate get_reactionTorqueDelegateField = IL2CPP.ResolveICall<Joint2D.get_reactionTorqueDelegate>("UnityEngine.Joint2D::get_reactionTorque");

		// Token: 0x040001EE RID: 494
		private static readonly Joint2D.GetReactionTorqueDelegate GetReactionTorqueDelegateField = IL2CPP.ResolveICall<Joint2D.GetReactionTorqueDelegate>("UnityEngine.Joint2D::GetReactionTorque");

		// Token: 0x040001EF RID: 495
		private static readonly Joint2D.get_reactionForce_InjectedDelegate get_reactionForce_InjectedDelegateField = IL2CPP.ResolveICall<Joint2D.get_reactionForce_InjectedDelegate>("UnityEngine.Joint2D::get_reactionForce_Injected");

		// Token: 0x040001F0 RID: 496
		private static readonly Joint2D.GetReactionForce_InjectedDelegate GetReactionForce_InjectedDelegateField = IL2CPP.ResolveICall<Joint2D.GetReactionForce_InjectedDelegate>("UnityEngine.Joint2D::GetReactionForce_Injected");

		// Token: 0x02000166 RID: 358
		// (Invoke) Token: 0x060006F4 RID: 1780
		private delegate IntPtr get_attachedRigidbodyDelegate(IntPtr @this);

		// Token: 0x02000167 RID: 359
		// (Invoke) Token: 0x060006F6 RID: 1782
		private delegate IntPtr get_connectedBodyDelegate(IntPtr @this);

		// Token: 0x02000168 RID: 360
		// (Invoke) Token: 0x060006F8 RID: 1784
		private delegate void set_connectedBodyDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000169 RID: 361
		// (Invoke) Token: 0x060006FA RID: 1786
		private delegate bool get_enableCollisionDelegate(IntPtr @this);

		// Token: 0x0200016A RID: 362
		// (Invoke) Token: 0x060006FC RID: 1788
		private delegate void set_enableCollisionDelegate(IntPtr @this, bool value);

		// Token: 0x0200016B RID: 363
		// (Invoke) Token: 0x060006FE RID: 1790
		private delegate float get_breakForceDelegate(IntPtr @this);

		// Token: 0x0200016C RID: 364
		// (Invoke) Token: 0x06000700 RID: 1792
		private delegate void set_breakForceDelegate(IntPtr @this, float value);

		// Token: 0x0200016D RID: 365
		// (Invoke) Token: 0x06000702 RID: 1794
		private delegate float get_breakTorqueDelegate(IntPtr @this);

		// Token: 0x0200016E RID: 366
		// (Invoke) Token: 0x06000704 RID: 1796
		private delegate void set_breakTorqueDelegate(IntPtr @this, float value);

		// Token: 0x0200016F RID: 367
		// (Invoke) Token: 0x06000706 RID: 1798
		private delegate JointBreakAction2D get_breakActionDelegate(IntPtr @this);

		// Token: 0x02000170 RID: 368
		// (Invoke) Token: 0x06000708 RID: 1800
		private delegate void set_breakActionDelegate(IntPtr @this, JointBreakAction2D value);

		// Token: 0x02000171 RID: 369
		// (Invoke) Token: 0x0600070A RID: 1802
		private delegate float get_reactionTorqueDelegate(IntPtr @this);

		// Token: 0x02000172 RID: 370
		// (Invoke) Token: 0x0600070C RID: 1804
		private delegate float GetReactionTorqueDelegate(IntPtr @this, float timeStep);

		// Token: 0x02000173 RID: 371
		// (Invoke) Token: 0x0600070E RID: 1806
		private delegate void get_reactionForce_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000174 RID: 372
		// (Invoke) Token: 0x06000710 RID: 1808
		private delegate void GetReactionForce_InjectedDelegate(IntPtr @this, float timeStep, [Out] IntPtr ret);
	}
}
