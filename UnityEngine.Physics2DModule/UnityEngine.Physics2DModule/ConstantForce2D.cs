using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000033 RID: 51
	public sealed class ConstantForce2D : PhysicsUpdateBehaviour2D
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0000CB68 File Offset: 0x0000AD68
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00004B88 File Offset: 0x00002D88
		public Vector2 force
		{
			get
			{
				Vector2 vector;
				this.get_force_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_force_Injected(ref value);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x0000CB80 File Offset: 0x0000AD80
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00004B92 File Offset: 0x00002D92
		public Vector2 relativeForce
		{
			get
			{
				Vector2 vector;
				this.get_relativeForce_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_relativeForce_Injected(ref value);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00004B9C File Offset: 0x00002D9C
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00004BAE File Offset: 0x00002DAE
		public float torque
		{
			get
			{
				return ConstantForce2D.get_torqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConstantForce2D.set_torqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00004BC1 File Offset: 0x00002DC1
		public void get_force_Injected(out Vector2 ret)
		{
			ConstantForce2D.get_force_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00004BD4 File Offset: 0x00002DD4
		public void set_force_Injected(ref Vector2 value)
		{
			ConstantForce2D.set_force_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00004BE7 File Offset: 0x00002DE7
		public void get_relativeForce_Injected(out Vector2 ret)
		{
			ConstantForce2D.get_relativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00004BFA File Offset: 0x00002DFA
		public void set_relativeForce_Injected(ref Vector2 value)
		{
			ConstantForce2D.set_relativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000291 RID: 657
		private static readonly ConstantForce2D.get_torqueDelegate get_torqueDelegateField = IL2CPP.ResolveICall<ConstantForce2D.get_torqueDelegate>("UnityEngine.ConstantForce2D::get_torque");

		// Token: 0x04000292 RID: 658
		private static readonly ConstantForce2D.set_torqueDelegate set_torqueDelegateField = IL2CPP.ResolveICall<ConstantForce2D.set_torqueDelegate>("UnityEngine.ConstantForce2D::set_torque");

		// Token: 0x04000293 RID: 659
		private static readonly ConstantForce2D.get_force_InjectedDelegate get_force_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce2D.get_force_InjectedDelegate>("UnityEngine.ConstantForce2D::get_force_Injected");

		// Token: 0x04000294 RID: 660
		private static readonly ConstantForce2D.set_force_InjectedDelegate set_force_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce2D.set_force_InjectedDelegate>("UnityEngine.ConstantForce2D::set_force_Injected");

		// Token: 0x04000295 RID: 661
		private static readonly ConstantForce2D.get_relativeForce_InjectedDelegate get_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce2D.get_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce2D::get_relativeForce_Injected");

		// Token: 0x04000296 RID: 662
		private static readonly ConstantForce2D.set_relativeForce_InjectedDelegate set_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ConstantForce2D.set_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce2D::set_relativeForce_Injected");

		// Token: 0x02000215 RID: 533
		// (Invoke) Token: 0x06000852 RID: 2130
		private delegate float get_torqueDelegate(IntPtr @this);

		// Token: 0x02000216 RID: 534
		// (Invoke) Token: 0x06000854 RID: 2132
		private delegate void set_torqueDelegate(IntPtr @this, float value);

		// Token: 0x02000217 RID: 535
		// (Invoke) Token: 0x06000856 RID: 2134
		private delegate void get_force_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000218 RID: 536
		// (Invoke) Token: 0x06000858 RID: 2136
		private delegate void set_force_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000219 RID: 537
		// (Invoke) Token: 0x0600085A RID: 2138
		private delegate void get_relativeForce_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200021A RID: 538
		// (Invoke) Token: 0x0600085C RID: 2140
		private delegate void set_relativeForce_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
