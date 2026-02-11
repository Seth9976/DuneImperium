using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000031 RID: 49
	public class SurfaceEffector2D : Effector2D
	{
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00004AAA File Offset: 0x00002CAA
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00004ABC File Offset: 0x00002CBC
		public float speed
		{
			get
			{
				return SurfaceEffector2D.get_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00004ACF File Offset: 0x00002CCF
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00004AE1 File Offset: 0x00002CE1
		public float speedVariation
		{
			get
			{
				return SurfaceEffector2D.get_speedVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_speedVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00004AF4 File Offset: 0x00002CF4
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00004B06 File Offset: 0x00002D06
		public float forceScale
		{
			get
			{
				return SurfaceEffector2D.get_forceScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_forceScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00004B19 File Offset: 0x00002D19
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00004B2B File Offset: 0x00002D2B
		public bool useContactForce
		{
			get
			{
				return SurfaceEffector2D.get_useContactForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_useContactForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00004B3E File Offset: 0x00002D3E
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00004B50 File Offset: 0x00002D50
		public bool useFriction
		{
			get
			{
				return SurfaceEffector2D.get_useFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_useFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00004B63 File Offset: 0x00002D63
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00004B75 File Offset: 0x00002D75
		public bool useBounce
		{
			get
			{
				return SurfaceEffector2D.get_useBounceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_useBounceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000285 RID: 645
		private static readonly SurfaceEffector2D.get_speedDelegate get_speedDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_speedDelegate>("UnityEngine.SurfaceEffector2D::get_speed");

		// Token: 0x04000286 RID: 646
		private static readonly SurfaceEffector2D.set_speedDelegate set_speedDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_speedDelegate>("UnityEngine.SurfaceEffector2D::set_speed");

		// Token: 0x04000287 RID: 647
		private static readonly SurfaceEffector2D.get_speedVariationDelegate get_speedVariationDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_speedVariationDelegate>("UnityEngine.SurfaceEffector2D::get_speedVariation");

		// Token: 0x04000288 RID: 648
		private static readonly SurfaceEffector2D.set_speedVariationDelegate set_speedVariationDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_speedVariationDelegate>("UnityEngine.SurfaceEffector2D::set_speedVariation");

		// Token: 0x04000289 RID: 649
		private static readonly SurfaceEffector2D.get_forceScaleDelegate get_forceScaleDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_forceScaleDelegate>("UnityEngine.SurfaceEffector2D::get_forceScale");

		// Token: 0x0400028A RID: 650
		private static readonly SurfaceEffector2D.set_forceScaleDelegate set_forceScaleDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_forceScaleDelegate>("UnityEngine.SurfaceEffector2D::set_forceScale");

		// Token: 0x0400028B RID: 651
		private static readonly SurfaceEffector2D.get_useContactForceDelegate get_useContactForceDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_useContactForceDelegate>("UnityEngine.SurfaceEffector2D::get_useContactForce");

		// Token: 0x0400028C RID: 652
		private static readonly SurfaceEffector2D.set_useContactForceDelegate set_useContactForceDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_useContactForceDelegate>("UnityEngine.SurfaceEffector2D::set_useContactForce");

		// Token: 0x0400028D RID: 653
		private static readonly SurfaceEffector2D.get_useFrictionDelegate get_useFrictionDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_useFrictionDelegate>("UnityEngine.SurfaceEffector2D::get_useFriction");

		// Token: 0x0400028E RID: 654
		private static readonly SurfaceEffector2D.set_useFrictionDelegate set_useFrictionDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_useFrictionDelegate>("UnityEngine.SurfaceEffector2D::set_useFriction");

		// Token: 0x0400028F RID: 655
		private static readonly SurfaceEffector2D.get_useBounceDelegate get_useBounceDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_useBounceDelegate>("UnityEngine.SurfaceEffector2D::get_useBounce");

		// Token: 0x04000290 RID: 656
		private static readonly SurfaceEffector2D.set_useBounceDelegate set_useBounceDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_useBounceDelegate>("UnityEngine.SurfaceEffector2D::set_useBounce");

		// Token: 0x02000209 RID: 521
		// (Invoke) Token: 0x0600083A RID: 2106
		private delegate float get_speedDelegate(IntPtr @this);

		// Token: 0x0200020A RID: 522
		// (Invoke) Token: 0x0600083C RID: 2108
		private delegate void set_speedDelegate(IntPtr @this, float value);

		// Token: 0x0200020B RID: 523
		// (Invoke) Token: 0x0600083E RID: 2110
		private delegate float get_speedVariationDelegate(IntPtr @this);

		// Token: 0x0200020C RID: 524
		// (Invoke) Token: 0x06000840 RID: 2112
		private delegate void set_speedVariationDelegate(IntPtr @this, float value);

		// Token: 0x0200020D RID: 525
		// (Invoke) Token: 0x06000842 RID: 2114
		private delegate float get_forceScaleDelegate(IntPtr @this);

		// Token: 0x0200020E RID: 526
		// (Invoke) Token: 0x06000844 RID: 2116
		private delegate void set_forceScaleDelegate(IntPtr @this, float value);

		// Token: 0x0200020F RID: 527
		// (Invoke) Token: 0x06000846 RID: 2118
		private delegate bool get_useContactForceDelegate(IntPtr @this);

		// Token: 0x02000210 RID: 528
		// (Invoke) Token: 0x06000848 RID: 2120
		private delegate void set_useContactForceDelegate(IntPtr @this, bool value);

		// Token: 0x02000211 RID: 529
		// (Invoke) Token: 0x0600084A RID: 2122
		private delegate bool get_useFrictionDelegate(IntPtr @this);

		// Token: 0x02000212 RID: 530
		// (Invoke) Token: 0x0600084C RID: 2124
		private delegate void set_useFrictionDelegate(IntPtr @this, bool value);

		// Token: 0x02000213 RID: 531
		// (Invoke) Token: 0x0600084E RID: 2126
		private delegate bool get_useBounceDelegate(IntPtr @this);

		// Token: 0x02000214 RID: 532
		// (Invoke) Token: 0x06000850 RID: 2128
		private delegate void set_useBounceDelegate(IntPtr @this, bool value);
	}
}
