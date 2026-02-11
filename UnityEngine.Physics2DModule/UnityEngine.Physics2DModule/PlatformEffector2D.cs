using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000030 RID: 48
	public class PlatformEffector2D : Effector2D
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0000497B File Offset: 0x00002B7B
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x0000498D File Offset: 0x00002B8D
		public bool useOneWay
		{
			get
			{
				return PlatformEffector2D.get_useOneWayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_useOneWayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x000049A0 File Offset: 0x00002BA0
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x000049B2 File Offset: 0x00002BB2
		public bool useOneWayGrouping
		{
			get
			{
				return PlatformEffector2D.get_useOneWayGroupingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_useOneWayGroupingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x000049C5 File Offset: 0x00002BC5
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x000049D7 File Offset: 0x00002BD7
		public bool useSideFriction
		{
			get
			{
				return PlatformEffector2D.get_useSideFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_useSideFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x000049EA File Offset: 0x00002BEA
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x000049FC File Offset: 0x00002BFC
		public bool useSideBounce
		{
			get
			{
				return PlatformEffector2D.get_useSideBounceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_useSideBounceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00004A0F File Offset: 0x00002C0F
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00004A21 File Offset: 0x00002C21
		public float surfaceArc
		{
			get
			{
				return PlatformEffector2D.get_surfaceArcDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_surfaceArcDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00004A34 File Offset: 0x00002C34
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00004A46 File Offset: 0x00002C46
		public float sideArc
		{
			get
			{
				return PlatformEffector2D.get_sideArcDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_sideArcDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00004A59 File Offset: 0x00002C59
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00004A6B File Offset: 0x00002C6B
		public float rotationalOffset
		{
			get
			{
				return PlatformEffector2D.get_rotationalOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_rotationalOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0000C9DC File Offset: 0x0000ABDC
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00004A7E File Offset: 0x00002C7E
		public bool oneWay
		{
			get
			{
				return this.useOneWay;
			}
			set
			{
				this.useOneWay = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0000C9F4 File Offset: 0x0000ABF4
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00004A89 File Offset: 0x00002C89
		public bool sideFriction
		{
			get
			{
				return this.useSideFriction;
			}
			set
			{
				this.useSideFriction = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000CA0C File Offset: 0x0000AC0C
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00004A94 File Offset: 0x00002C94
		public bool sideBounce
		{
			get
			{
				return this.useSideBounce;
			}
			set
			{
				this.useSideBounce = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0000CA24 File Offset: 0x0000AC24
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00004A9F File Offset: 0x00002C9F
		public float sideAngleVariance
		{
			get
			{
				return this.sideArc;
			}
			set
			{
				this.sideArc = value;
			}
		}

		// Token: 0x04000277 RID: 631
		private static readonly PlatformEffector2D.get_useOneWayDelegate get_useOneWayDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_useOneWayDelegate>("UnityEngine.PlatformEffector2D::get_useOneWay");

		// Token: 0x04000278 RID: 632
		private static readonly PlatformEffector2D.set_useOneWayDelegate set_useOneWayDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_useOneWayDelegate>("UnityEngine.PlatformEffector2D::set_useOneWay");

		// Token: 0x04000279 RID: 633
		private static readonly PlatformEffector2D.get_useOneWayGroupingDelegate get_useOneWayGroupingDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_useOneWayGroupingDelegate>("UnityEngine.PlatformEffector2D::get_useOneWayGrouping");

		// Token: 0x0400027A RID: 634
		private static readonly PlatformEffector2D.set_useOneWayGroupingDelegate set_useOneWayGroupingDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_useOneWayGroupingDelegate>("UnityEngine.PlatformEffector2D::set_useOneWayGrouping");

		// Token: 0x0400027B RID: 635
		private static readonly PlatformEffector2D.get_useSideFrictionDelegate get_useSideFrictionDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_useSideFrictionDelegate>("UnityEngine.PlatformEffector2D::get_useSideFriction");

		// Token: 0x0400027C RID: 636
		private static readonly PlatformEffector2D.set_useSideFrictionDelegate set_useSideFrictionDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_useSideFrictionDelegate>("UnityEngine.PlatformEffector2D::set_useSideFriction");

		// Token: 0x0400027D RID: 637
		private static readonly PlatformEffector2D.get_useSideBounceDelegate get_useSideBounceDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_useSideBounceDelegate>("UnityEngine.PlatformEffector2D::get_useSideBounce");

		// Token: 0x0400027E RID: 638
		private static readonly PlatformEffector2D.set_useSideBounceDelegate set_useSideBounceDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_useSideBounceDelegate>("UnityEngine.PlatformEffector2D::set_useSideBounce");

		// Token: 0x0400027F RID: 639
		private static readonly PlatformEffector2D.get_surfaceArcDelegate get_surfaceArcDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_surfaceArcDelegate>("UnityEngine.PlatformEffector2D::get_surfaceArc");

		// Token: 0x04000280 RID: 640
		private static readonly PlatformEffector2D.set_surfaceArcDelegate set_surfaceArcDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_surfaceArcDelegate>("UnityEngine.PlatformEffector2D::set_surfaceArc");

		// Token: 0x04000281 RID: 641
		private static readonly PlatformEffector2D.get_sideArcDelegate get_sideArcDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_sideArcDelegate>("UnityEngine.PlatformEffector2D::get_sideArc");

		// Token: 0x04000282 RID: 642
		private static readonly PlatformEffector2D.set_sideArcDelegate set_sideArcDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_sideArcDelegate>("UnityEngine.PlatformEffector2D::set_sideArc");

		// Token: 0x04000283 RID: 643
		private static readonly PlatformEffector2D.get_rotationalOffsetDelegate get_rotationalOffsetDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_rotationalOffsetDelegate>("UnityEngine.PlatformEffector2D::get_rotationalOffset");

		// Token: 0x04000284 RID: 644
		private static readonly PlatformEffector2D.set_rotationalOffsetDelegate set_rotationalOffsetDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_rotationalOffsetDelegate>("UnityEngine.PlatformEffector2D::set_rotationalOffset");

		// Token: 0x020001FB RID: 507
		// (Invoke) Token: 0x0600081E RID: 2078
		private delegate bool get_useOneWayDelegate(IntPtr @this);

		// Token: 0x020001FC RID: 508
		// (Invoke) Token: 0x06000820 RID: 2080
		private delegate void set_useOneWayDelegate(IntPtr @this, bool value);

		// Token: 0x020001FD RID: 509
		// (Invoke) Token: 0x06000822 RID: 2082
		private delegate bool get_useOneWayGroupingDelegate(IntPtr @this);

		// Token: 0x020001FE RID: 510
		// (Invoke) Token: 0x06000824 RID: 2084
		private delegate void set_useOneWayGroupingDelegate(IntPtr @this, bool value);

		// Token: 0x020001FF RID: 511
		// (Invoke) Token: 0x06000826 RID: 2086
		private delegate bool get_useSideFrictionDelegate(IntPtr @this);

		// Token: 0x02000200 RID: 512
		// (Invoke) Token: 0x06000828 RID: 2088
		private delegate void set_useSideFrictionDelegate(IntPtr @this, bool value);

		// Token: 0x02000201 RID: 513
		// (Invoke) Token: 0x0600082A RID: 2090
		private delegate bool get_useSideBounceDelegate(IntPtr @this);

		// Token: 0x02000202 RID: 514
		// (Invoke) Token: 0x0600082C RID: 2092
		private delegate void set_useSideBounceDelegate(IntPtr @this, bool value);

		// Token: 0x02000203 RID: 515
		// (Invoke) Token: 0x0600082E RID: 2094
		private delegate float get_surfaceArcDelegate(IntPtr @this);

		// Token: 0x02000204 RID: 516
		// (Invoke) Token: 0x06000830 RID: 2096
		private delegate void set_surfaceArcDelegate(IntPtr @this, float value);

		// Token: 0x02000205 RID: 517
		// (Invoke) Token: 0x06000832 RID: 2098
		private delegate float get_sideArcDelegate(IntPtr @this);

		// Token: 0x02000206 RID: 518
		// (Invoke) Token: 0x06000834 RID: 2100
		private delegate void set_sideArcDelegate(IntPtr @this, float value);

		// Token: 0x02000207 RID: 519
		// (Invoke) Token: 0x06000836 RID: 2102
		private delegate float get_rotationalOffsetDelegate(IntPtr @this);

		// Token: 0x02000208 RID: 520
		// (Invoke) Token: 0x06000838 RID: 2104
		private delegate void set_rotationalOffsetDelegate(IntPtr @this, float value);
	}
}
