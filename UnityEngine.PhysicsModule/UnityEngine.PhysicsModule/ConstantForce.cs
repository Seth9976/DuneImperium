using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000027 RID: 39
	public class ConstantForce : Behaviour
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0000BF7C File Offset: 0x0000A17C
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00004059 File Offset: 0x00002259
		public Vector3 force
		{
			get
			{
				Vector3 vector;
				this.get_force_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_force_Injected(ref value);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x0000BF94 File Offset: 0x0000A194
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x00004063 File Offset: 0x00002263
		public Vector3 relativeForce
		{
			get
			{
				Vector3 vector;
				this.get_relativeForce_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_relativeForce_Injected(ref value);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0000BFAC File Offset: 0x0000A1AC
		// (set) Token: 0x060003AA RID: 938 RVA: 0x0000406D File Offset: 0x0000226D
		public Vector3 torque
		{
			get
			{
				Vector3 vector;
				this.get_torque_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_torque_Injected(ref value);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000BFC4 File Offset: 0x0000A1C4
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00004077 File Offset: 0x00002277
		public Vector3 relativeTorque
		{
			get
			{
				Vector3 vector;
				this.get_relativeTorque_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_relativeTorque_Injected(ref value);
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00004081 File Offset: 0x00002281
		public void get_force_Injected(out Vector3 ret)
		{
			ConstantForce.get_force_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00004094 File Offset: 0x00002294
		public void set_force_Injected(ref Vector3 value)
		{
			ConstantForce.set_force_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000040A7 File Offset: 0x000022A7
		public void get_relativeForce_Injected(out Vector3 ret)
		{
			ConstantForce.get_relativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000040BA File Offset: 0x000022BA
		public void set_relativeForce_Injected(ref Vector3 value)
		{
			ConstantForce.set_relativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000040CD File Offset: 0x000022CD
		public void get_torque_Injected(out Vector3 ret)
		{
			ConstantForce.get_torque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000040E0 File Offset: 0x000022E0
		public void set_torque_Injected(ref Vector3 value)
		{
			ConstantForce.set_torque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000040F3 File Offset: 0x000022F3
		public void get_relativeTorque_Injected(out Vector3 ret)
		{
			ConstantForce.get_relativeTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00004106 File Offset: 0x00002306
		public void set_relativeTorque_Injected(ref Vector3 value)
		{
			ConstantForce.set_relativeTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040002A5 RID: 677
		private static readonly ConstantForce.get_force_InjectedDelegate get_force_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.get_force_InjectedDelegate>("UnityEngine.ConstantForce::get_force_Injected");

		// Token: 0x040002A6 RID: 678
		private static readonly ConstantForce.set_force_InjectedDelegate set_force_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.set_force_InjectedDelegate>("UnityEngine.ConstantForce::set_force_Injected");

		// Token: 0x040002A7 RID: 679
		private static readonly ConstantForce.get_relativeForce_InjectedDelegate get_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.get_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce::get_relativeForce_Injected");

		// Token: 0x040002A8 RID: 680
		private static readonly ConstantForce.set_relativeForce_InjectedDelegate set_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.set_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce::set_relativeForce_Injected");

		// Token: 0x040002A9 RID: 681
		private static readonly ConstantForce.get_torque_InjectedDelegate get_torque_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.get_torque_InjectedDelegate>("UnityEngine.ConstantForce::get_torque_Injected");

		// Token: 0x040002AA RID: 682
		private static readonly ConstantForce.set_torque_InjectedDelegate set_torque_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.set_torque_InjectedDelegate>("UnityEngine.ConstantForce::set_torque_Injected");

		// Token: 0x040002AB RID: 683
		private static readonly ConstantForce.get_relativeTorque_InjectedDelegate get_relativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.get_relativeTorque_InjectedDelegate>("UnityEngine.ConstantForce::get_relativeTorque_Injected");

		// Token: 0x040002AC RID: 684
		private static readonly ConstantForce.set_relativeTorque_InjectedDelegate set_relativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce.set_relativeTorque_InjectedDelegate>("UnityEngine.ConstantForce::set_relativeTorque_Injected");

		// Token: 0x02000178 RID: 376
		// (Invoke) Token: 0x060006C8 RID: 1736
		private delegate void get_force_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000179 RID: 377
		// (Invoke) Token: 0x060006CA RID: 1738
		private delegate void set_force_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200017A RID: 378
		// (Invoke) Token: 0x060006CC RID: 1740
		private delegate void get_relativeForce_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200017B RID: 379
		// (Invoke) Token: 0x060006CE RID: 1742
		private delegate void set_relativeForce_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200017C RID: 380
		// (Invoke) Token: 0x060006D0 RID: 1744
		private delegate void get_torque_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200017D RID: 381
		// (Invoke) Token: 0x060006D2 RID: 1746
		private delegate void set_torque_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200017E RID: 382
		// (Invoke) Token: 0x060006D4 RID: 1748
		private delegate void get_relativeTorque_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200017F RID: 383
		// (Invoke) Token: 0x060006D6 RID: 1750
		private delegate void set_relativeTorque_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
