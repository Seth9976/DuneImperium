using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000028 RID: 40
	public class Joint : Component
	{
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0000C160 File Offset: 0x0000A360
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00004119 File Offset: 0x00002319
		public Rigidbody connectedBody
		{
			get
			{
				IntPtr intPtr = Joint.get_connectedBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				Joint.set_connectedBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0000C18C File Offset: 0x0000A38C
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00004131 File Offset: 0x00002331
		public ArticulationBody connectedArticulationBody
		{
			get
			{
				IntPtr intPtr = Joint.get_connectedArticulationBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArticulationBody>(intPtr2) : null;
			}
			set
			{
				Joint.set_connectedArticulationBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0000C1B8 File Offset: 0x0000A3B8
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00004149 File Offset: 0x00002349
		public Vector3 axis
		{
			get
			{
				Vector3 vector;
				this.get_axis_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_axis_Injected(ref value);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00004153 File Offset: 0x00002353
		public Vector3 anchor
		{
			get
			{
				Vector3 vector;
				this.get_anchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_anchor_Injected(ref value);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0000C1E8 File Offset: 0x0000A3E8
		// (set) Token: 0x060003BF RID: 959 RVA: 0x0000415D File Offset: 0x0000235D
		public Vector3 connectedAnchor
		{
			get
			{
				Vector3 vector;
				this.get_connectedAnchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_connectedAnchor_Injected(ref value);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00004167 File Offset: 0x00002367
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00004179 File Offset: 0x00002379
		public bool autoConfigureConnectedAnchor
		{
			get
			{
				return Joint.get_autoConfigureConnectedAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_autoConfigureConnectedAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0000418C File Offset: 0x0000238C
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x0000419E File Offset: 0x0000239E
		public float breakForce
		{
			get
			{
				return Joint.get_breakForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_breakForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x000041B1 File Offset: 0x000023B1
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000041C3 File Offset: 0x000023C3
		public float breakTorque
		{
			get
			{
				return Joint.get_breakTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_breakTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x000041D6 File Offset: 0x000023D6
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x000041E8 File Offset: 0x000023E8
		public bool enableCollision
		{
			get
			{
				return Joint.get_enableCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_enableCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x000041FB File Offset: 0x000023FB
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x0000420D File Offset: 0x0000240D
		public bool enablePreprocessing
		{
			get
			{
				return Joint.get_enablePreprocessingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_enablePreprocessingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00004220 File Offset: 0x00002420
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00004232 File Offset: 0x00002432
		public float massScale
		{
			get
			{
				return Joint.get_massScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_massScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00004245 File Offset: 0x00002445
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00004257 File Offset: 0x00002457
		public float connectedMassScale
		{
			get
			{
				return Joint.get_connectedMassScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Joint.set_connectedMassScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000426A File Offset: 0x0000246A
		public void GetCurrentForces(ref Vector3 linearForce, ref Vector3 angularForce)
		{
			Joint.GetCurrentForcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref linearForce, ref angularForce);
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0000C200 File Offset: 0x0000A400
		public Vector3 currentForce
		{
			get
			{
				Vector3 zero = Vector3.zero;
				Vector3 zero2 = Vector3.zero;
				this.GetCurrentForces(ref zero, ref zero2);
				return zero;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0000C22C File Offset: 0x0000A42C
		public Vector3 currentTorque
		{
			get
			{
				Vector3 zero = Vector3.zero;
				Vector3 zero2 = Vector3.zero;
				this.GetCurrentForces(ref zero, ref zero2);
				return zero2;
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000427E File Offset: 0x0000247E
		public void get_axis_Injected(out Vector3 ret)
		{
			Joint.get_axis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00004291 File Offset: 0x00002491
		public void set_axis_Injected(ref Vector3 value)
		{
			Joint.set_axis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000042A4 File Offset: 0x000024A4
		public void get_anchor_Injected(out Vector3 ret)
		{
			Joint.get_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000042B7 File Offset: 0x000024B7
		public void set_anchor_Injected(ref Vector3 value)
		{
			Joint.set_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000042CA File Offset: 0x000024CA
		public void get_connectedAnchor_Injected(out Vector3 ret)
		{
			Joint.get_connectedAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000042DD File Offset: 0x000024DD
		public void set_connectedAnchor_Injected(ref Vector3 value)
		{
			Joint.set_connectedAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040002AD RID: 685
		private static readonly Joint.get_connectedBodyDelegate get_connectedBodyDelegateField = IL2CPP.ResolveICall<Joint.get_connectedBodyDelegate>("UnityEngine.Joint::get_connectedBody");

		// Token: 0x040002AE RID: 686
		private static readonly Joint.set_connectedBodyDelegate set_connectedBodyDelegateField = IL2CPP.ResolveICall<Joint.set_connectedBodyDelegate>("UnityEngine.Joint::set_connectedBody");

		// Token: 0x040002AF RID: 687
		private static readonly Joint.get_connectedArticulationBodyDelegate get_connectedArticulationBodyDelegateField = IL2CPP.ResolveICall<Joint.get_connectedArticulationBodyDelegate>("UnityEngine.Joint::get_connectedArticulationBody");

		// Token: 0x040002B0 RID: 688
		private static readonly Joint.set_connectedArticulationBodyDelegate set_connectedArticulationBodyDelegateField = IL2CPP.ResolveICall<Joint.set_connectedArticulationBodyDelegate>("UnityEngine.Joint::set_connectedArticulationBody");

		// Token: 0x040002B1 RID: 689
		private static readonly Joint.get_autoConfigureConnectedAnchorDelegate get_autoConfigureConnectedAnchorDelegateField = IL2CPP.ResolveICall<Joint.get_autoConfigureConnectedAnchorDelegate>("UnityEngine.Joint::get_autoConfigureConnectedAnchor");

		// Token: 0x040002B2 RID: 690
		private static readonly Joint.set_autoConfigureConnectedAnchorDelegate set_autoConfigureConnectedAnchorDelegateField = IL2CPP.ResolveICall<Joint.set_autoConfigureConnectedAnchorDelegate>("UnityEngine.Joint::set_autoConfigureConnectedAnchor");

		// Token: 0x040002B3 RID: 691
		private static readonly Joint.get_breakForceDelegate get_breakForceDelegateField = IL2CPP.ResolveICall<Joint.get_breakForceDelegate>("UnityEngine.Joint::get_breakForce");

		// Token: 0x040002B4 RID: 692
		private static readonly Joint.set_breakForceDelegate set_breakForceDelegateField = IL2CPP.ResolveICall<Joint.set_breakForceDelegate>("UnityEngine.Joint::set_breakForce");

		// Token: 0x040002B5 RID: 693
		private static readonly Joint.get_breakTorqueDelegate get_breakTorqueDelegateField = IL2CPP.ResolveICall<Joint.get_breakTorqueDelegate>("UnityEngine.Joint::get_breakTorque");

		// Token: 0x040002B6 RID: 694
		private static readonly Joint.set_breakTorqueDelegate set_breakTorqueDelegateField = IL2CPP.ResolveICall<Joint.set_breakTorqueDelegate>("UnityEngine.Joint::set_breakTorque");

		// Token: 0x040002B7 RID: 695
		private static readonly Joint.get_enableCollisionDelegate get_enableCollisionDelegateField = IL2CPP.ResolveICall<Joint.get_enableCollisionDelegate>("UnityEngine.Joint::get_enableCollision");

		// Token: 0x040002B8 RID: 696
		private static readonly Joint.set_enableCollisionDelegate set_enableCollisionDelegateField = IL2CPP.ResolveICall<Joint.set_enableCollisionDelegate>("UnityEngine.Joint::set_enableCollision");

		// Token: 0x040002B9 RID: 697
		private static readonly Joint.get_enablePreprocessingDelegate get_enablePreprocessingDelegateField = IL2CPP.ResolveICall<Joint.get_enablePreprocessingDelegate>("UnityEngine.Joint::get_enablePreprocessing");

		// Token: 0x040002BA RID: 698
		private static readonly Joint.set_enablePreprocessingDelegate set_enablePreprocessingDelegateField = IL2CPP.ResolveICall<Joint.set_enablePreprocessingDelegate>("UnityEngine.Joint::set_enablePreprocessing");

		// Token: 0x040002BB RID: 699
		private static readonly Joint.get_massScaleDelegate get_massScaleDelegateField = IL2CPP.ResolveICall<Joint.get_massScaleDelegate>("UnityEngine.Joint::get_massScale");

		// Token: 0x040002BC RID: 700
		private static readonly Joint.set_massScaleDelegate set_massScaleDelegateField = IL2CPP.ResolveICall<Joint.set_massScaleDelegate>("UnityEngine.Joint::set_massScale");

		// Token: 0x040002BD RID: 701
		private static readonly Joint.get_connectedMassScaleDelegate get_connectedMassScaleDelegateField = IL2CPP.ResolveICall<Joint.get_connectedMassScaleDelegate>("UnityEngine.Joint::get_connectedMassScale");

		// Token: 0x040002BE RID: 702
		private static readonly Joint.set_connectedMassScaleDelegate set_connectedMassScaleDelegateField = IL2CPP.ResolveICall<Joint.set_connectedMassScaleDelegate>("UnityEngine.Joint::set_connectedMassScale");

		// Token: 0x040002BF RID: 703
		private static readonly Joint.GetCurrentForcesDelegate GetCurrentForcesDelegateField = IL2CPP.ResolveICall<Joint.GetCurrentForcesDelegate>("UnityEngine.Joint::GetCurrentForces");

		// Token: 0x040002C0 RID: 704
		private static readonly Joint.get_axis_InjectedDelegate get_axis_InjectedDelegateField = IL2CPP.ResolveICall<Joint.get_axis_InjectedDelegate>("UnityEngine.Joint::get_axis_Injected");

		// Token: 0x040002C1 RID: 705
		private static readonly Joint.set_axis_InjectedDelegate set_axis_InjectedDelegateField = IL2CPP.ResolveICall<Joint.set_axis_InjectedDelegate>("UnityEngine.Joint::set_axis_Injected");

		// Token: 0x040002C2 RID: 706
		private static readonly Joint.get_anchor_InjectedDelegate get_anchor_InjectedDelegateField = IL2CPP.ResolveICall<Joint.get_anchor_InjectedDelegate>("UnityEngine.Joint::get_anchor_Injected");

		// Token: 0x040002C3 RID: 707
		private static readonly Joint.set_anchor_InjectedDelegate set_anchor_InjectedDelegateField = IL2CPP.ResolveICall<Joint.set_anchor_InjectedDelegate>("UnityEngine.Joint::set_anchor_Injected");

		// Token: 0x040002C4 RID: 708
		private static readonly Joint.get_connectedAnchor_InjectedDelegate get_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<Joint.get_connectedAnchor_InjectedDelegate>("UnityEngine.Joint::get_connectedAnchor_Injected");

		// Token: 0x040002C5 RID: 709
		private static readonly Joint.set_connectedAnchor_InjectedDelegate set_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<Joint.set_connectedAnchor_InjectedDelegate>("UnityEngine.Joint::set_connectedAnchor_Injected");

		// Token: 0x02000180 RID: 384
		// (Invoke) Token: 0x060006D8 RID: 1752
		private delegate IntPtr get_connectedBodyDelegate(IntPtr @this);

		// Token: 0x02000181 RID: 385
		// (Invoke) Token: 0x060006DA RID: 1754
		private delegate void set_connectedBodyDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000182 RID: 386
		// (Invoke) Token: 0x060006DC RID: 1756
		private delegate IntPtr get_connectedArticulationBodyDelegate(IntPtr @this);

		// Token: 0x02000183 RID: 387
		// (Invoke) Token: 0x060006DE RID: 1758
		private delegate void set_connectedArticulationBodyDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000184 RID: 388
		// (Invoke) Token: 0x060006E0 RID: 1760
		private delegate bool get_autoConfigureConnectedAnchorDelegate(IntPtr @this);

		// Token: 0x02000185 RID: 389
		// (Invoke) Token: 0x060006E2 RID: 1762
		private delegate void set_autoConfigureConnectedAnchorDelegate(IntPtr @this, bool value);

		// Token: 0x02000186 RID: 390
		// (Invoke) Token: 0x060006E4 RID: 1764
		private delegate float get_breakForceDelegate(IntPtr @this);

		// Token: 0x02000187 RID: 391
		// (Invoke) Token: 0x060006E6 RID: 1766
		private delegate void set_breakForceDelegate(IntPtr @this, float value);

		// Token: 0x02000188 RID: 392
		// (Invoke) Token: 0x060006E8 RID: 1768
		private delegate float get_breakTorqueDelegate(IntPtr @this);

		// Token: 0x02000189 RID: 393
		// (Invoke) Token: 0x060006EA RID: 1770
		private delegate void set_breakTorqueDelegate(IntPtr @this, float value);

		// Token: 0x0200018A RID: 394
		// (Invoke) Token: 0x060006EC RID: 1772
		private delegate bool get_enableCollisionDelegate(IntPtr @this);

		// Token: 0x0200018B RID: 395
		// (Invoke) Token: 0x060006EE RID: 1774
		private delegate void set_enableCollisionDelegate(IntPtr @this, bool value);

		// Token: 0x0200018C RID: 396
		// (Invoke) Token: 0x060006F0 RID: 1776
		private delegate bool get_enablePreprocessingDelegate(IntPtr @this);

		// Token: 0x0200018D RID: 397
		// (Invoke) Token: 0x060006F2 RID: 1778
		private delegate void set_enablePreprocessingDelegate(IntPtr @this, bool value);

		// Token: 0x0200018E RID: 398
		// (Invoke) Token: 0x060006F4 RID: 1780
		private delegate float get_massScaleDelegate(IntPtr @this);

		// Token: 0x0200018F RID: 399
		// (Invoke) Token: 0x060006F6 RID: 1782
		private delegate void set_massScaleDelegate(IntPtr @this, float value);

		// Token: 0x02000190 RID: 400
		// (Invoke) Token: 0x060006F8 RID: 1784
		private delegate float get_connectedMassScaleDelegate(IntPtr @this);

		// Token: 0x02000191 RID: 401
		// (Invoke) Token: 0x060006FA RID: 1786
		private delegate void set_connectedMassScaleDelegate(IntPtr @this, float value);

		// Token: 0x02000192 RID: 402
		// (Invoke) Token: 0x060006FC RID: 1788
		private delegate void GetCurrentForcesDelegate(IntPtr @this, IntPtr linearForce, IntPtr angularForce);

		// Token: 0x02000193 RID: 403
		// (Invoke) Token: 0x060006FE RID: 1790
		private delegate void get_axis_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000194 RID: 404
		// (Invoke) Token: 0x06000700 RID: 1792
		private delegate void set_axis_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000195 RID: 405
		// (Invoke) Token: 0x06000702 RID: 1794
		private delegate void get_anchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000196 RID: 406
		// (Invoke) Token: 0x06000704 RID: 1796
		private delegate void set_anchor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000197 RID: 407
		// (Invoke) Token: 0x06000706 RID: 1798
		private delegate void get_connectedAnchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000198 RID: 408
		// (Invoke) Token: 0x06000708 RID: 1800
		private delegate void set_connectedAnchor_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
