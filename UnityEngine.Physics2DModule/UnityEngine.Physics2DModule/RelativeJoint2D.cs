using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000027 RID: 39
	public sealed class RelativeJoint2D : Joint2D
	{
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00004207 File Offset: 0x00002407
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00004219 File Offset: 0x00002419
		public float maxForce
		{
			get
			{
				return RelativeJoint2D.get_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0000422C File Offset: 0x0000242C
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x0000423E File Offset: 0x0000243E
		public float maxTorque
		{
			get
			{
				return RelativeJoint2D.get_maxTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_maxTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00004251 File Offset: 0x00002451
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00004263 File Offset: 0x00002463
		public float correctionScale
		{
			get
			{
				return RelativeJoint2D.get_correctionScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_correctionScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00004276 File Offset: 0x00002476
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00004288 File Offset: 0x00002488
		public bool autoConfigureOffset
		{
			get
			{
				return RelativeJoint2D.get_autoConfigureOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_autoConfigureOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x0000429B File Offset: 0x0000249B
		public Vector2 linearOffset
		{
			get
			{
				Vector2 vector;
				this.get_linearOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_linearOffset_Injected(ref value);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000042A5 File Offset: 0x000024A5
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000042B7 File Offset: 0x000024B7
		public float angularOffset
		{
			get
			{
				return RelativeJoint2D.get_angularOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_angularOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000C300 File Offset: 0x0000A500
		public Vector2 target
		{
			get
			{
				Vector2 vector;
				this.get_target_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000042CA File Offset: 0x000024CA
		public void get_linearOffset_Injected(out Vector2 ret)
		{
			RelativeJoint2D.get_linearOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000042DD File Offset: 0x000024DD
		public void set_linearOffset_Injected(ref Vector2 value)
		{
			RelativeJoint2D.set_linearOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000042F0 File Offset: 0x000024F0
		public void get_target_Injected(out Vector2 ret)
		{
			RelativeJoint2D.get_target_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000212 RID: 530
		private static readonly RelativeJoint2D.get_maxForceDelegate get_maxForceDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_maxForceDelegate>("UnityEngine.RelativeJoint2D::get_maxForce");

		// Token: 0x04000213 RID: 531
		private static readonly RelativeJoint2D.set_maxForceDelegate set_maxForceDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_maxForceDelegate>("UnityEngine.RelativeJoint2D::set_maxForce");

		// Token: 0x04000214 RID: 532
		private static readonly RelativeJoint2D.get_maxTorqueDelegate get_maxTorqueDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_maxTorqueDelegate>("UnityEngine.RelativeJoint2D::get_maxTorque");

		// Token: 0x04000215 RID: 533
		private static readonly RelativeJoint2D.set_maxTorqueDelegate set_maxTorqueDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_maxTorqueDelegate>("UnityEngine.RelativeJoint2D::set_maxTorque");

		// Token: 0x04000216 RID: 534
		private static readonly RelativeJoint2D.get_correctionScaleDelegate get_correctionScaleDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_correctionScaleDelegate>("UnityEngine.RelativeJoint2D::get_correctionScale");

		// Token: 0x04000217 RID: 535
		private static readonly RelativeJoint2D.set_correctionScaleDelegate set_correctionScaleDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_correctionScaleDelegate>("UnityEngine.RelativeJoint2D::set_correctionScale");

		// Token: 0x04000218 RID: 536
		private static readonly RelativeJoint2D.get_autoConfigureOffsetDelegate get_autoConfigureOffsetDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_autoConfigureOffsetDelegate>("UnityEngine.RelativeJoint2D::get_autoConfigureOffset");

		// Token: 0x04000219 RID: 537
		private static readonly RelativeJoint2D.set_autoConfigureOffsetDelegate set_autoConfigureOffsetDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_autoConfigureOffsetDelegate>("UnityEngine.RelativeJoint2D::set_autoConfigureOffset");

		// Token: 0x0400021A RID: 538
		private static readonly RelativeJoint2D.get_angularOffsetDelegate get_angularOffsetDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_angularOffsetDelegate>("UnityEngine.RelativeJoint2D::get_angularOffset");

		// Token: 0x0400021B RID: 539
		private static readonly RelativeJoint2D.set_angularOffsetDelegate set_angularOffsetDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_angularOffsetDelegate>("UnityEngine.RelativeJoint2D::set_angularOffset");

		// Token: 0x0400021C RID: 540
		private static readonly RelativeJoint2D.get_linearOffset_InjectedDelegate get_linearOffset_InjectedDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_linearOffset_InjectedDelegate>("UnityEngine.RelativeJoint2D::get_linearOffset_Injected");

		// Token: 0x0400021D RID: 541
		private static readonly RelativeJoint2D.set_linearOffset_InjectedDelegate set_linearOffset_InjectedDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_linearOffset_InjectedDelegate>("UnityEngine.RelativeJoint2D::set_linearOffset_Injected");

		// Token: 0x0400021E RID: 542
		private static readonly RelativeJoint2D.get_target_InjectedDelegate get_target_InjectedDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_target_InjectedDelegate>("UnityEngine.RelativeJoint2D::get_target_Injected");

		// Token: 0x02000196 RID: 406
		// (Invoke) Token: 0x06000754 RID: 1876
		private delegate float get_maxForceDelegate(IntPtr @this);

		// Token: 0x02000197 RID: 407
		// (Invoke) Token: 0x06000756 RID: 1878
		private delegate void set_maxForceDelegate(IntPtr @this, float value);

		// Token: 0x02000198 RID: 408
		// (Invoke) Token: 0x06000758 RID: 1880
		private delegate float get_maxTorqueDelegate(IntPtr @this);

		// Token: 0x02000199 RID: 409
		// (Invoke) Token: 0x0600075A RID: 1882
		private delegate void set_maxTorqueDelegate(IntPtr @this, float value);

		// Token: 0x0200019A RID: 410
		// (Invoke) Token: 0x0600075C RID: 1884
		private delegate float get_correctionScaleDelegate(IntPtr @this);

		// Token: 0x0200019B RID: 411
		// (Invoke) Token: 0x0600075E RID: 1886
		private delegate void set_correctionScaleDelegate(IntPtr @this, float value);

		// Token: 0x0200019C RID: 412
		// (Invoke) Token: 0x06000760 RID: 1888
		private delegate bool get_autoConfigureOffsetDelegate(IntPtr @this);

		// Token: 0x0200019D RID: 413
		// (Invoke) Token: 0x06000762 RID: 1890
		private delegate void set_autoConfigureOffsetDelegate(IntPtr @this, bool value);

		// Token: 0x0200019E RID: 414
		// (Invoke) Token: 0x06000764 RID: 1892
		private delegate float get_angularOffsetDelegate(IntPtr @this);

		// Token: 0x0200019F RID: 415
		// (Invoke) Token: 0x06000766 RID: 1894
		private delegate void set_angularOffsetDelegate(IntPtr @this, float value);

		// Token: 0x020001A0 RID: 416
		// (Invoke) Token: 0x06000768 RID: 1896
		private delegate void get_linearOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001A1 RID: 417
		// (Invoke) Token: 0x0600076A RID: 1898
		private delegate void set_linearOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001A2 RID: 418
		// (Invoke) Token: 0x0600076C RID: 1900
		private delegate void get_target_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
