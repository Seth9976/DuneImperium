using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000024 RID: 36
	public sealed class DistanceJoint2D : AnchoredJoint2D
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0000406B File Offset: 0x0000226B
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x0000407D File Offset: 0x0000227D
		public bool autoConfigureDistance
		{
			get
			{
				return DistanceJoint2D.get_autoConfigureDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DistanceJoint2D.set_autoConfigureDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00004090 File Offset: 0x00002290
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x000040A2 File Offset: 0x000022A2
		public float distance
		{
			get
			{
				return DistanceJoint2D.get_distanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DistanceJoint2D.set_distanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003DA RID: 986 RVA: 0x000040B5 File Offset: 0x000022B5
		// (set) Token: 0x060003DB RID: 987 RVA: 0x000040C7 File Offset: 0x000022C7
		public bool maxDistanceOnly
		{
			get
			{
				return DistanceJoint2D.get_maxDistanceOnlyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DistanceJoint2D.set_maxDistanceOnlyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040001FF RID: 511
		private static readonly DistanceJoint2D.get_autoConfigureDistanceDelegate get_autoConfigureDistanceDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.get_autoConfigureDistanceDelegate>("UnityEngine.DistanceJoint2D::get_autoConfigureDistance");

		// Token: 0x04000200 RID: 512
		private static readonly DistanceJoint2D.set_autoConfigureDistanceDelegate set_autoConfigureDistanceDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.set_autoConfigureDistanceDelegate>("UnityEngine.DistanceJoint2D::set_autoConfigureDistance");

		// Token: 0x04000201 RID: 513
		private static readonly DistanceJoint2D.get_distanceDelegate get_distanceDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.get_distanceDelegate>("UnityEngine.DistanceJoint2D::get_distance");

		// Token: 0x04000202 RID: 514
		private static readonly DistanceJoint2D.set_distanceDelegate set_distanceDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.set_distanceDelegate>("UnityEngine.DistanceJoint2D::set_distance");

		// Token: 0x04000203 RID: 515
		private static readonly DistanceJoint2D.get_maxDistanceOnlyDelegate get_maxDistanceOnlyDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.get_maxDistanceOnlyDelegate>("UnityEngine.DistanceJoint2D::get_maxDistanceOnly");

		// Token: 0x04000204 RID: 516
		private static readonly DistanceJoint2D.set_maxDistanceOnlyDelegate set_maxDistanceOnlyDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.set_maxDistanceOnlyDelegate>("UnityEngine.DistanceJoint2D::set_maxDistanceOnly");

		// Token: 0x02000183 RID: 387
		// (Invoke) Token: 0x0600072E RID: 1838
		private delegate bool get_autoConfigureDistanceDelegate(IntPtr @this);

		// Token: 0x02000184 RID: 388
		// (Invoke) Token: 0x06000730 RID: 1840
		private delegate void set_autoConfigureDistanceDelegate(IntPtr @this, bool value);

		// Token: 0x02000185 RID: 389
		// (Invoke) Token: 0x06000732 RID: 1842
		private delegate float get_distanceDelegate(IntPtr @this);

		// Token: 0x02000186 RID: 390
		// (Invoke) Token: 0x06000734 RID: 1844
		private delegate void set_distanceDelegate(IntPtr @this, float value);

		// Token: 0x02000187 RID: 391
		// (Invoke) Token: 0x06000736 RID: 1846
		private delegate bool get_maxDistanceOnlyDelegate(IntPtr @this);

		// Token: 0x02000188 RID: 392
		// (Invoke) Token: 0x06000738 RID: 1848
		private delegate void set_maxDistanceOnlyDelegate(IntPtr @this, bool value);
	}
}
