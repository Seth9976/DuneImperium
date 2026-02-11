using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000023 RID: 35
	public sealed class SpringJoint2D : AnchoredJoint2D
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00003FD7 File Offset: 0x000021D7
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00003FE9 File Offset: 0x000021E9
		public bool autoConfigureDistance
		{
			get
			{
				return SpringJoint2D.get_autoConfigureDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint2D.set_autoConfigureDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00003FFC File Offset: 0x000021FC
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x0000400E File Offset: 0x0000220E
		public float distance
		{
			get
			{
				return SpringJoint2D.get_distanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint2D.set_distanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00004021 File Offset: 0x00002221
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x00004033 File Offset: 0x00002233
		public float dampingRatio
		{
			get
			{
				return SpringJoint2D.get_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint2D.set_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00004046 File Offset: 0x00002246
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00004058 File Offset: 0x00002258
		public float frequency
		{
			get
			{
				return SpringJoint2D.get_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint2D.set_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040001F7 RID: 503
		private static readonly SpringJoint2D.get_autoConfigureDistanceDelegate get_autoConfigureDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint2D.get_autoConfigureDistanceDelegate>("UnityEngine.SpringJoint2D::get_autoConfigureDistance");

		// Token: 0x040001F8 RID: 504
		private static readonly SpringJoint2D.set_autoConfigureDistanceDelegate set_autoConfigureDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint2D.set_autoConfigureDistanceDelegate>("UnityEngine.SpringJoint2D::set_autoConfigureDistance");

		// Token: 0x040001F9 RID: 505
		private static readonly SpringJoint2D.get_distanceDelegate get_distanceDelegateField = IL2CPP.ResolveICall<SpringJoint2D.get_distanceDelegate>("UnityEngine.SpringJoint2D::get_distance");

		// Token: 0x040001FA RID: 506
		private static readonly SpringJoint2D.set_distanceDelegate set_distanceDelegateField = IL2CPP.ResolveICall<SpringJoint2D.set_distanceDelegate>("UnityEngine.SpringJoint2D::set_distance");

		// Token: 0x040001FB RID: 507
		private static readonly SpringJoint2D.get_dampingRatioDelegate get_dampingRatioDelegateField = IL2CPP.ResolveICall<SpringJoint2D.get_dampingRatioDelegate>("UnityEngine.SpringJoint2D::get_dampingRatio");

		// Token: 0x040001FC RID: 508
		private static readonly SpringJoint2D.set_dampingRatioDelegate set_dampingRatioDelegateField = IL2CPP.ResolveICall<SpringJoint2D.set_dampingRatioDelegate>("UnityEngine.SpringJoint2D::set_dampingRatio");

		// Token: 0x040001FD RID: 509
		private static readonly SpringJoint2D.get_frequencyDelegate get_frequencyDelegateField = IL2CPP.ResolveICall<SpringJoint2D.get_frequencyDelegate>("UnityEngine.SpringJoint2D::get_frequency");

		// Token: 0x040001FE RID: 510
		private static readonly SpringJoint2D.set_frequencyDelegate set_frequencyDelegateField = IL2CPP.ResolveICall<SpringJoint2D.set_frequencyDelegate>("UnityEngine.SpringJoint2D::set_frequency");

		// Token: 0x0200017B RID: 379
		// (Invoke) Token: 0x0600071E RID: 1822
		private delegate bool get_autoConfigureDistanceDelegate(IntPtr @this);

		// Token: 0x0200017C RID: 380
		// (Invoke) Token: 0x06000720 RID: 1824
		private delegate void set_autoConfigureDistanceDelegate(IntPtr @this, bool value);

		// Token: 0x0200017D RID: 381
		// (Invoke) Token: 0x06000722 RID: 1826
		private delegate float get_distanceDelegate(IntPtr @this);

		// Token: 0x0200017E RID: 382
		// (Invoke) Token: 0x06000724 RID: 1828
		private delegate void set_distanceDelegate(IntPtr @this, float value);

		// Token: 0x0200017F RID: 383
		// (Invoke) Token: 0x06000726 RID: 1830
		private delegate float get_dampingRatioDelegate(IntPtr @this);

		// Token: 0x02000180 RID: 384
		// (Invoke) Token: 0x06000728 RID: 1832
		private delegate void set_dampingRatioDelegate(IntPtr @this, float value);

		// Token: 0x02000181 RID: 385
		// (Invoke) Token: 0x0600072A RID: 1834
		private delegate float get_frequencyDelegate(IntPtr @this);

		// Token: 0x02000182 RID: 386
		// (Invoke) Token: 0x0600072C RID: 1836
		private delegate void set_frequencyDelegate(IntPtr @this, float value);
	}
}
