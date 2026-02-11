using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000029 RID: 41
	public sealed class TargetJoint2D : Joint2D
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0000C4AC File Offset: 0x0000A6AC
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x000043F2 File Offset: 0x000025F2
		public Vector2 anchor
		{
			get
			{
				Vector2 vector;
				this.get_anchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_anchor_Injected(ref value);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x000043FC File Offset: 0x000025FC
		public Vector2 target
		{
			get
			{
				Vector2 vector;
				this.get_target_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_target_Injected(ref value);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x00004406 File Offset: 0x00002606
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x00004418 File Offset: 0x00002618
		public bool autoConfigureTarget
		{
			get
			{
				return TargetJoint2D.get_autoConfigureTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TargetJoint2D.set_autoConfigureTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0000442B File Offset: 0x0000262B
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x0000443D File Offset: 0x0000263D
		public float maxForce
		{
			get
			{
				return TargetJoint2D.get_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TargetJoint2D.set_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00004450 File Offset: 0x00002650
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x00004462 File Offset: 0x00002662
		public float dampingRatio
		{
			get
			{
				return TargetJoint2D.get_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TargetJoint2D.set_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00004475 File Offset: 0x00002675
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00004487 File Offset: 0x00002687
		public float frequency
		{
			get
			{
				return TargetJoint2D.get_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TargetJoint2D.set_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000449A File Offset: 0x0000269A
		public void get_anchor_Injected(out Vector2 ret)
		{
			TargetJoint2D.get_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000044AD File Offset: 0x000026AD
		public void set_anchor_Injected(ref Vector2 value)
		{
			TargetJoint2D.set_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000044C0 File Offset: 0x000026C0
		public void get_target_Injected(out Vector2 ret)
		{
			TargetJoint2D.get_target_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000044D3 File Offset: 0x000026D3
		public void set_target_Injected(ref Vector2 value)
		{
			TargetJoint2D.set_target_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400022C RID: 556
		private static readonly TargetJoint2D.get_autoConfigureTargetDelegate get_autoConfigureTargetDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_autoConfigureTargetDelegate>("UnityEngine.TargetJoint2D::get_autoConfigureTarget");

		// Token: 0x0400022D RID: 557
		private static readonly TargetJoint2D.set_autoConfigureTargetDelegate set_autoConfigureTargetDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_autoConfigureTargetDelegate>("UnityEngine.TargetJoint2D::set_autoConfigureTarget");

		// Token: 0x0400022E RID: 558
		private static readonly TargetJoint2D.get_maxForceDelegate get_maxForceDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_maxForceDelegate>("UnityEngine.TargetJoint2D::get_maxForce");

		// Token: 0x0400022F RID: 559
		private static readonly TargetJoint2D.set_maxForceDelegate set_maxForceDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_maxForceDelegate>("UnityEngine.TargetJoint2D::set_maxForce");

		// Token: 0x04000230 RID: 560
		private static readonly TargetJoint2D.get_dampingRatioDelegate get_dampingRatioDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_dampingRatioDelegate>("UnityEngine.TargetJoint2D::get_dampingRatio");

		// Token: 0x04000231 RID: 561
		private static readonly TargetJoint2D.set_dampingRatioDelegate set_dampingRatioDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_dampingRatioDelegate>("UnityEngine.TargetJoint2D::set_dampingRatio");

		// Token: 0x04000232 RID: 562
		private static readonly TargetJoint2D.get_frequencyDelegate get_frequencyDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_frequencyDelegate>("UnityEngine.TargetJoint2D::get_frequency");

		// Token: 0x04000233 RID: 563
		private static readonly TargetJoint2D.set_frequencyDelegate set_frequencyDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_frequencyDelegate>("UnityEngine.TargetJoint2D::set_frequency");

		// Token: 0x04000234 RID: 564
		private static readonly TargetJoint2D.get_anchor_InjectedDelegate get_anchor_InjectedDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_anchor_InjectedDelegate>("UnityEngine.TargetJoint2D::get_anchor_Injected");

		// Token: 0x04000235 RID: 565
		private static readonly TargetJoint2D.set_anchor_InjectedDelegate set_anchor_InjectedDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_anchor_InjectedDelegate>("UnityEngine.TargetJoint2D::set_anchor_Injected");

		// Token: 0x04000236 RID: 566
		private static readonly TargetJoint2D.get_target_InjectedDelegate get_target_InjectedDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_target_InjectedDelegate>("UnityEngine.TargetJoint2D::get_target_Injected");

		// Token: 0x04000237 RID: 567
		private static readonly TargetJoint2D.set_target_InjectedDelegate set_target_InjectedDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_target_InjectedDelegate>("UnityEngine.TargetJoint2D::set_target_Injected");

		// Token: 0x020001B0 RID: 432
		// (Invoke) Token: 0x06000788 RID: 1928
		private delegate bool get_autoConfigureTargetDelegate(IntPtr @this);

		// Token: 0x020001B1 RID: 433
		// (Invoke) Token: 0x0600078A RID: 1930
		private delegate void set_autoConfigureTargetDelegate(IntPtr @this, bool value);

		// Token: 0x020001B2 RID: 434
		// (Invoke) Token: 0x0600078C RID: 1932
		private delegate float get_maxForceDelegate(IntPtr @this);

		// Token: 0x020001B3 RID: 435
		// (Invoke) Token: 0x0600078E RID: 1934
		private delegate void set_maxForceDelegate(IntPtr @this, float value);

		// Token: 0x020001B4 RID: 436
		// (Invoke) Token: 0x06000790 RID: 1936
		private delegate float get_dampingRatioDelegate(IntPtr @this);

		// Token: 0x020001B5 RID: 437
		// (Invoke) Token: 0x06000792 RID: 1938
		private delegate void set_dampingRatioDelegate(IntPtr @this, float value);

		// Token: 0x020001B6 RID: 438
		// (Invoke) Token: 0x06000794 RID: 1940
		private delegate float get_frequencyDelegate(IntPtr @this);

		// Token: 0x020001B7 RID: 439
		// (Invoke) Token: 0x06000796 RID: 1942
		private delegate void set_frequencyDelegate(IntPtr @this, float value);

		// Token: 0x020001B8 RID: 440
		// (Invoke) Token: 0x06000798 RID: 1944
		private delegate void get_anchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001B9 RID: 441
		// (Invoke) Token: 0x0600079A RID: 1946
		private delegate void set_anchor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001BA RID: 442
		// (Invoke) Token: 0x0600079C RID: 1948
		private delegate void get_target_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001BB RID: 443
		// (Invoke) Token: 0x0600079E RID: 1950
		private delegate void set_target_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
