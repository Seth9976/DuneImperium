using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020002F1 RID: 753
	public class LODGroup : Component
	{
		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002D60 RID: 11616 RVA: 0x000B3820 File Offset: 0x000B1A20
		// (set) Token: 0x06002D61 RID: 11617 RVA: 0x00011EE7 File Offset: 0x000100E7
		public Vector3 localReferencePoint
		{
			get
			{
				Vector3 vector;
				this.get_localReferencePoint_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_localReferencePoint_Injected(ref value);
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002D62 RID: 11618 RVA: 0x00011EF1 File Offset: 0x000100F1
		// (set) Token: 0x06002D63 RID: 11619 RVA: 0x00011F03 File Offset: 0x00010103
		public float size
		{
			get
			{
				return LODGroup.get_sizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_sizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06002D64 RID: 11620 RVA: 0x00011F16 File Offset: 0x00010116
		public int lodCount
		{
			get
			{
				return LODGroup.get_lodCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x00011F28 File Offset: 0x00010128
		// (set) Token: 0x06002D66 RID: 11622 RVA: 0x00011F3A File Offset: 0x0001013A
		public bool lastLODBillboard
		{
			get
			{
				return LODGroup.get_lastLODBillboardDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_lastLODBillboardDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06002D67 RID: 11623 RVA: 0x00011F4D File Offset: 0x0001014D
		// (set) Token: 0x06002D68 RID: 11624 RVA: 0x00011F5F File Offset: 0x0001015F
		public LODFadeMode fadeMode
		{
			get
			{
				return LODGroup.get_fadeModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_fadeModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x00011F72 File Offset: 0x00010172
		// (set) Token: 0x06002D6A RID: 11626 RVA: 0x00011F84 File Offset: 0x00010184
		public bool animateCrossFading
		{
			get
			{
				return LODGroup.get_animateCrossFadingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_animateCrossFadingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06002D6B RID: 11627 RVA: 0x00011F97 File Offset: 0x00010197
		// (set) Token: 0x06002D6C RID: 11628 RVA: 0x00011FA9 File Offset: 0x000101A9
		public bool enabled
		{
			get
			{
				return LODGroup.get_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00011FBC File Offset: 0x000101BC
		public void RecalculateBounds()
		{
			LODGroup.RecalculateBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00011FCE File Offset: 0x000101CE
		public void ForceLOD(int index)
		{
			LODGroup.ForceLODDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x00011FE1 File Offset: 0x000101E1
		// (set) Token: 0x06002D70 RID: 11632 RVA: 0x00011FED File Offset: 0x000101ED
		public static float crossFadeAnimationDuration
		{
			get
			{
				return LODGroup.get_crossFadeAnimationDurationDelegateField();
			}
			set
			{
				LODGroup.set_crossFadeAnimationDurationDelegateField(value);
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x000B3838 File Offset: 0x000B1A38
		public Vector3 worldReferencePoint
		{
			get
			{
				Vector3 vector;
				this.get_worldReferencePoint_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00011FFA File Offset: 0x000101FA
		public void get_localReferencePoint_Injected(out Vector3 ret)
		{
			LODGroup.get_localReferencePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x0001200D File Offset: 0x0001020D
		public void set_localReferencePoint_Injected(ref Vector3 value)
		{
			LODGroup.set_localReferencePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00012020 File Offset: 0x00010220
		public void get_worldReferencePoint_Injected(out Vector3 ret)
		{
			LODGroup.get_worldReferencePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04002904 RID: 10500
		private static readonly LODGroup.get_sizeDelegate get_sizeDelegateField = IL2CPP.ResolveICall<LODGroup.get_sizeDelegate>("UnityEngine.LODGroup::get_size");

		// Token: 0x04002905 RID: 10501
		private static readonly LODGroup.set_sizeDelegate set_sizeDelegateField = IL2CPP.ResolveICall<LODGroup.set_sizeDelegate>("UnityEngine.LODGroup::set_size");

		// Token: 0x04002906 RID: 10502
		private static readonly LODGroup.get_lodCountDelegate get_lodCountDelegateField = IL2CPP.ResolveICall<LODGroup.get_lodCountDelegate>("UnityEngine.LODGroup::get_lodCount");

		// Token: 0x04002907 RID: 10503
		private static readonly LODGroup.get_lastLODBillboardDelegate get_lastLODBillboardDelegateField = IL2CPP.ResolveICall<LODGroup.get_lastLODBillboardDelegate>("UnityEngine.LODGroup::get_lastLODBillboard");

		// Token: 0x04002908 RID: 10504
		private static readonly LODGroup.set_lastLODBillboardDelegate set_lastLODBillboardDelegateField = IL2CPP.ResolveICall<LODGroup.set_lastLODBillboardDelegate>("UnityEngine.LODGroup::set_lastLODBillboard");

		// Token: 0x04002909 RID: 10505
		private static readonly LODGroup.get_fadeModeDelegate get_fadeModeDelegateField = IL2CPP.ResolveICall<LODGroup.get_fadeModeDelegate>("UnityEngine.LODGroup::get_fadeMode");

		// Token: 0x0400290A RID: 10506
		private static readonly LODGroup.set_fadeModeDelegate set_fadeModeDelegateField = IL2CPP.ResolveICall<LODGroup.set_fadeModeDelegate>("UnityEngine.LODGroup::set_fadeMode");

		// Token: 0x0400290B RID: 10507
		private static readonly LODGroup.get_animateCrossFadingDelegate get_animateCrossFadingDelegateField = IL2CPP.ResolveICall<LODGroup.get_animateCrossFadingDelegate>("UnityEngine.LODGroup::get_animateCrossFading");

		// Token: 0x0400290C RID: 10508
		private static readonly LODGroup.set_animateCrossFadingDelegate set_animateCrossFadingDelegateField = IL2CPP.ResolveICall<LODGroup.set_animateCrossFadingDelegate>("UnityEngine.LODGroup::set_animateCrossFading");

		// Token: 0x0400290D RID: 10509
		private static readonly LODGroup.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<LODGroup.get_enabledDelegate>("UnityEngine.LODGroup::get_enabled");

		// Token: 0x0400290E RID: 10510
		private static readonly LODGroup.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<LODGroup.set_enabledDelegate>("UnityEngine.LODGroup::set_enabled");

		// Token: 0x0400290F RID: 10511
		private static readonly LODGroup.RecalculateBoundsDelegate RecalculateBoundsDelegateField = IL2CPP.ResolveICall<LODGroup.RecalculateBoundsDelegate>("UnityEngine.LODGroup::RecalculateBounds");

		// Token: 0x04002910 RID: 10512
		private static readonly LODGroup.ForceLODDelegate ForceLODDelegateField = IL2CPP.ResolveICall<LODGroup.ForceLODDelegate>("UnityEngine.LODGroup::ForceLOD");

		// Token: 0x04002911 RID: 10513
		private static readonly LODGroup.get_crossFadeAnimationDurationDelegate get_crossFadeAnimationDurationDelegateField = IL2CPP.ResolveICall<LODGroup.get_crossFadeAnimationDurationDelegate>("UnityEngine.LODGroup::get_crossFadeAnimationDuration");

		// Token: 0x04002912 RID: 10514
		private static readonly LODGroup.set_crossFadeAnimationDurationDelegate set_crossFadeAnimationDurationDelegateField = IL2CPP.ResolveICall<LODGroup.set_crossFadeAnimationDurationDelegate>("UnityEngine.LODGroup::set_crossFadeAnimationDuration");

		// Token: 0x04002913 RID: 10515
		private static readonly LODGroup.get_localReferencePoint_InjectedDelegate get_localReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_localReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::get_localReferencePoint_Injected");

		// Token: 0x04002914 RID: 10516
		private static readonly LODGroup.set_localReferencePoint_InjectedDelegate set_localReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.set_localReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::set_localReferencePoint_Injected");

		// Token: 0x04002915 RID: 10517
		private static readonly LODGroup.get_worldReferencePoint_InjectedDelegate get_worldReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_worldReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::get_worldReferencePoint_Injected");

		// Token: 0x02000B3C RID: 2876
		// (Invoke) Token: 0x06003F6D RID: 16237
		private delegate float get_sizeDelegate(IntPtr @this);

		// Token: 0x02000B3D RID: 2877
		// (Invoke) Token: 0x06003F6F RID: 16239
		private delegate void set_sizeDelegate(IntPtr @this, float value);

		// Token: 0x02000B3E RID: 2878
		// (Invoke) Token: 0x06003F71 RID: 16241
		private delegate int get_lodCountDelegate(IntPtr @this);

		// Token: 0x02000B3F RID: 2879
		// (Invoke) Token: 0x06003F73 RID: 16243
		private delegate bool get_lastLODBillboardDelegate(IntPtr @this);

		// Token: 0x02000B40 RID: 2880
		// (Invoke) Token: 0x06003F75 RID: 16245
		private delegate void set_lastLODBillboardDelegate(IntPtr @this, bool value);

		// Token: 0x02000B41 RID: 2881
		// (Invoke) Token: 0x06003F77 RID: 16247
		private delegate LODFadeMode get_fadeModeDelegate(IntPtr @this);

		// Token: 0x02000B42 RID: 2882
		// (Invoke) Token: 0x06003F79 RID: 16249
		private delegate void set_fadeModeDelegate(IntPtr @this, LODFadeMode value);

		// Token: 0x02000B43 RID: 2883
		// (Invoke) Token: 0x06003F7B RID: 16251
		private delegate bool get_animateCrossFadingDelegate(IntPtr @this);

		// Token: 0x02000B44 RID: 2884
		// (Invoke) Token: 0x06003F7D RID: 16253
		private delegate void set_animateCrossFadingDelegate(IntPtr @this, bool value);

		// Token: 0x02000B45 RID: 2885
		// (Invoke) Token: 0x06003F7F RID: 16255
		private delegate bool get_enabledDelegate(IntPtr @this);

		// Token: 0x02000B46 RID: 2886
		// (Invoke) Token: 0x06003F81 RID: 16257
		private delegate void set_enabledDelegate(IntPtr @this, bool value);

		// Token: 0x02000B47 RID: 2887
		// (Invoke) Token: 0x06003F83 RID: 16259
		private delegate void RecalculateBoundsDelegate(IntPtr @this);

		// Token: 0x02000B48 RID: 2888
		// (Invoke) Token: 0x06003F85 RID: 16261
		private delegate void ForceLODDelegate(IntPtr @this, int index);

		// Token: 0x02000B49 RID: 2889
		// (Invoke) Token: 0x06003F87 RID: 16263
		private delegate float get_crossFadeAnimationDurationDelegate();

		// Token: 0x02000B4A RID: 2890
		// (Invoke) Token: 0x06003F89 RID: 16265
		private delegate void set_crossFadeAnimationDurationDelegate(float value);

		// Token: 0x02000B4B RID: 2891
		// (Invoke) Token: 0x06003F8B RID: 16267
		private delegate void get_localReferencePoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B4C RID: 2892
		// (Invoke) Token: 0x06003F8D RID: 16269
		private delegate void set_localReferencePoint_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B4D RID: 2893
		// (Invoke) Token: 0x06003F8F RID: 16271
		private delegate void get_worldReferencePoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
