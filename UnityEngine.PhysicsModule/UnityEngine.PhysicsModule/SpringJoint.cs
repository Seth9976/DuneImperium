using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002A RID: 42
	public class SpringJoint : Joint
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x000043CD File Offset: 0x000025CD
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000043DF File Offset: 0x000025DF
		public float spring
		{
			get
			{
				return SpringJoint.get_springDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_springDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x000043F2 File Offset: 0x000025F2
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00004404 File Offset: 0x00002604
		public float damper
		{
			get
			{
				return SpringJoint.get_damperDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_damperDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00004417 File Offset: 0x00002617
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x00004429 File Offset: 0x00002629
		public float minDistance
		{
			get
			{
				return SpringJoint.get_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0000443C File Offset: 0x0000263C
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x0000444E File Offset: 0x0000264E
		public float maxDistance
		{
			get
			{
				return SpringJoint.get_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00004461 File Offset: 0x00002661
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00004473 File Offset: 0x00002673
		public float tolerance
		{
			get
			{
				return SpringJoint.get_toleranceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint.set_toleranceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040002D2 RID: 722
		private static readonly SpringJoint.get_springDelegate get_springDelegateField = IL2CPP.ResolveICall<SpringJoint.get_springDelegate>("UnityEngine.SpringJoint::get_spring");

		// Token: 0x040002D3 RID: 723
		private static readonly SpringJoint.set_springDelegate set_springDelegateField = IL2CPP.ResolveICall<SpringJoint.set_springDelegate>("UnityEngine.SpringJoint::set_spring");

		// Token: 0x040002D4 RID: 724
		private static readonly SpringJoint.get_damperDelegate get_damperDelegateField = IL2CPP.ResolveICall<SpringJoint.get_damperDelegate>("UnityEngine.SpringJoint::get_damper");

		// Token: 0x040002D5 RID: 725
		private static readonly SpringJoint.set_damperDelegate set_damperDelegateField = IL2CPP.ResolveICall<SpringJoint.set_damperDelegate>("UnityEngine.SpringJoint::set_damper");

		// Token: 0x040002D6 RID: 726
		private static readonly SpringJoint.get_minDistanceDelegate get_minDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint.get_minDistanceDelegate>("UnityEngine.SpringJoint::get_minDistance");

		// Token: 0x040002D7 RID: 727
		private static readonly SpringJoint.set_minDistanceDelegate set_minDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint.set_minDistanceDelegate>("UnityEngine.SpringJoint::set_minDistance");

		// Token: 0x040002D8 RID: 728
		private static readonly SpringJoint.get_maxDistanceDelegate get_maxDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint.get_maxDistanceDelegate>("UnityEngine.SpringJoint::get_maxDistance");

		// Token: 0x040002D9 RID: 729
		private static readonly SpringJoint.set_maxDistanceDelegate set_maxDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint.set_maxDistanceDelegate>("UnityEngine.SpringJoint::set_maxDistance");

		// Token: 0x040002DA RID: 730
		private static readonly SpringJoint.get_toleranceDelegate get_toleranceDelegateField = IL2CPP.ResolveICall<SpringJoint.get_toleranceDelegate>("UnityEngine.SpringJoint::get_tolerance");

		// Token: 0x040002DB RID: 731
		private static readonly SpringJoint.set_toleranceDelegate set_toleranceDelegateField = IL2CPP.ResolveICall<SpringJoint.set_toleranceDelegate>("UnityEngine.SpringJoint::set_tolerance");

		// Token: 0x020001A5 RID: 421
		// (Invoke) Token: 0x06000722 RID: 1826
		private delegate float get_springDelegate(IntPtr @this);

		// Token: 0x020001A6 RID: 422
		// (Invoke) Token: 0x06000724 RID: 1828
		private delegate void set_springDelegate(IntPtr @this, float value);

		// Token: 0x020001A7 RID: 423
		// (Invoke) Token: 0x06000726 RID: 1830
		private delegate float get_damperDelegate(IntPtr @this);

		// Token: 0x020001A8 RID: 424
		// (Invoke) Token: 0x06000728 RID: 1832
		private delegate void set_damperDelegate(IntPtr @this, float value);

		// Token: 0x020001A9 RID: 425
		// (Invoke) Token: 0x0600072A RID: 1834
		private delegate float get_minDistanceDelegate(IntPtr @this);

		// Token: 0x020001AA RID: 426
		// (Invoke) Token: 0x0600072C RID: 1836
		private delegate void set_minDistanceDelegate(IntPtr @this, float value);

		// Token: 0x020001AB RID: 427
		// (Invoke) Token: 0x0600072E RID: 1838
		private delegate float get_maxDistanceDelegate(IntPtr @this);

		// Token: 0x020001AC RID: 428
		// (Invoke) Token: 0x06000730 RID: 1840
		private delegate void set_maxDistanceDelegate(IntPtr @this, float value);

		// Token: 0x020001AD RID: 429
		// (Invoke) Token: 0x06000732 RID: 1842
		private delegate float get_toleranceDelegate(IntPtr @this);

		// Token: 0x020001AE RID: 430
		// (Invoke) Token: 0x06000734 RID: 1844
		private delegate void set_toleranceDelegate(IntPtr @this, float value);
	}
}
