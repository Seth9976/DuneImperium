using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020002DB RID: 731
	public sealed class Projector : Behaviour
	{
		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x00011D9A File Offset: 0x0000FF9A
		// (set) Token: 0x06002D4D RID: 11597 RVA: 0x00011DAC File Offset: 0x0000FFAC
		public float nearClipPlane
		{
			get
			{
				return Projector.get_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002D4E RID: 11598 RVA: 0x00011DBF File Offset: 0x0000FFBF
		// (set) Token: 0x06002D4F RID: 11599 RVA: 0x00011DD1 File Offset: 0x0000FFD1
		public float farClipPlane
		{
			get
			{
				return Projector.get_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002D50 RID: 11600 RVA: 0x00011DE4 File Offset: 0x0000FFE4
		// (set) Token: 0x06002D51 RID: 11601 RVA: 0x00011DF6 File Offset: 0x0000FFF6
		public float fieldOfView
		{
			get
			{
				return Projector.get_fieldOfViewDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_fieldOfViewDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x00011E09 File Offset: 0x00010009
		// (set) Token: 0x06002D53 RID: 11603 RVA: 0x00011E1B File Offset: 0x0001001B
		public float aspectRatio
		{
			get
			{
				return Projector.get_aspectRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_aspectRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x00011E2E File Offset: 0x0001002E
		// (set) Token: 0x06002D55 RID: 11605 RVA: 0x00011E40 File Offset: 0x00010040
		public bool orthographic
		{
			get
			{
				return Projector.get_orthographicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_orthographicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x00011E53 File Offset: 0x00010053
		// (set) Token: 0x06002D57 RID: 11607 RVA: 0x00011E65 File Offset: 0x00010065
		public float orthographicSize
		{
			get
			{
				return Projector.get_orthographicSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_orthographicSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06002D58 RID: 11608 RVA: 0x00011E78 File Offset: 0x00010078
		// (set) Token: 0x06002D59 RID: 11609 RVA: 0x00011E8A File Offset: 0x0001008A
		public int ignoreLayers
		{
			get
			{
				return Projector.get_ignoreLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_ignoreLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x000B36B0 File Offset: 0x000B18B0
		// (set) Token: 0x06002D5B RID: 11611 RVA: 0x00011E9D File Offset: 0x0001009D
		public Material material
		{
			get
			{
				IntPtr intPtr = Projector.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				Projector.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400289C RID: 10396
		private static readonly Projector.get_nearClipPlaneDelegate get_nearClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.get_nearClipPlaneDelegate>("UnityEngine.Projector::get_nearClipPlane");

		// Token: 0x0400289D RID: 10397
		private static readonly Projector.set_nearClipPlaneDelegate set_nearClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.set_nearClipPlaneDelegate>("UnityEngine.Projector::set_nearClipPlane");

		// Token: 0x0400289E RID: 10398
		private static readonly Projector.get_farClipPlaneDelegate get_farClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.get_farClipPlaneDelegate>("UnityEngine.Projector::get_farClipPlane");

		// Token: 0x0400289F RID: 10399
		private static readonly Projector.set_farClipPlaneDelegate set_farClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.set_farClipPlaneDelegate>("UnityEngine.Projector::set_farClipPlane");

		// Token: 0x040028A0 RID: 10400
		private static readonly Projector.get_fieldOfViewDelegate get_fieldOfViewDelegateField = IL2CPP.ResolveICall<Projector.get_fieldOfViewDelegate>("UnityEngine.Projector::get_fieldOfView");

		// Token: 0x040028A1 RID: 10401
		private static readonly Projector.set_fieldOfViewDelegate set_fieldOfViewDelegateField = IL2CPP.ResolveICall<Projector.set_fieldOfViewDelegate>("UnityEngine.Projector::set_fieldOfView");

		// Token: 0x040028A2 RID: 10402
		private static readonly Projector.get_aspectRatioDelegate get_aspectRatioDelegateField = IL2CPP.ResolveICall<Projector.get_aspectRatioDelegate>("UnityEngine.Projector::get_aspectRatio");

		// Token: 0x040028A3 RID: 10403
		private static readonly Projector.set_aspectRatioDelegate set_aspectRatioDelegateField = IL2CPP.ResolveICall<Projector.set_aspectRatioDelegate>("UnityEngine.Projector::set_aspectRatio");

		// Token: 0x040028A4 RID: 10404
		private static readonly Projector.get_orthographicDelegate get_orthographicDelegateField = IL2CPP.ResolveICall<Projector.get_orthographicDelegate>("UnityEngine.Projector::get_orthographic");

		// Token: 0x040028A5 RID: 10405
		private static readonly Projector.set_orthographicDelegate set_orthographicDelegateField = IL2CPP.ResolveICall<Projector.set_orthographicDelegate>("UnityEngine.Projector::set_orthographic");

		// Token: 0x040028A6 RID: 10406
		private static readonly Projector.get_orthographicSizeDelegate get_orthographicSizeDelegateField = IL2CPP.ResolveICall<Projector.get_orthographicSizeDelegate>("UnityEngine.Projector::get_orthographicSize");

		// Token: 0x040028A7 RID: 10407
		private static readonly Projector.set_orthographicSizeDelegate set_orthographicSizeDelegateField = IL2CPP.ResolveICall<Projector.set_orthographicSizeDelegate>("UnityEngine.Projector::set_orthographicSize");

		// Token: 0x040028A8 RID: 10408
		private static readonly Projector.get_ignoreLayersDelegate get_ignoreLayersDelegateField = IL2CPP.ResolveICall<Projector.get_ignoreLayersDelegate>("UnityEngine.Projector::get_ignoreLayers");

		// Token: 0x040028A9 RID: 10409
		private static readonly Projector.set_ignoreLayersDelegate set_ignoreLayersDelegateField = IL2CPP.ResolveICall<Projector.set_ignoreLayersDelegate>("UnityEngine.Projector::set_ignoreLayers");

		// Token: 0x040028AA RID: 10410
		private static readonly Projector.get_materialDelegate get_materialDelegateField = IL2CPP.ResolveICall<Projector.get_materialDelegate>("UnityEngine.Projector::get_material");

		// Token: 0x040028AB RID: 10411
		private static readonly Projector.set_materialDelegate set_materialDelegateField = IL2CPP.ResolveICall<Projector.set_materialDelegate>("UnityEngine.Projector::set_material");

		// Token: 0x02000B2A RID: 2858
		// (Invoke) Token: 0x06003F49 RID: 16201
		private delegate float get_nearClipPlaneDelegate(IntPtr @this);

		// Token: 0x02000B2B RID: 2859
		// (Invoke) Token: 0x06003F4B RID: 16203
		private delegate void set_nearClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x02000B2C RID: 2860
		// (Invoke) Token: 0x06003F4D RID: 16205
		private delegate float get_farClipPlaneDelegate(IntPtr @this);

		// Token: 0x02000B2D RID: 2861
		// (Invoke) Token: 0x06003F4F RID: 16207
		private delegate void set_farClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x02000B2E RID: 2862
		// (Invoke) Token: 0x06003F51 RID: 16209
		private delegate float get_fieldOfViewDelegate(IntPtr @this);

		// Token: 0x02000B2F RID: 2863
		// (Invoke) Token: 0x06003F53 RID: 16211
		private delegate void set_fieldOfViewDelegate(IntPtr @this, float value);

		// Token: 0x02000B30 RID: 2864
		// (Invoke) Token: 0x06003F55 RID: 16213
		private delegate float get_aspectRatioDelegate(IntPtr @this);

		// Token: 0x02000B31 RID: 2865
		// (Invoke) Token: 0x06003F57 RID: 16215
		private delegate void set_aspectRatioDelegate(IntPtr @this, float value);

		// Token: 0x02000B32 RID: 2866
		// (Invoke) Token: 0x06003F59 RID: 16217
		private delegate bool get_orthographicDelegate(IntPtr @this);

		// Token: 0x02000B33 RID: 2867
		// (Invoke) Token: 0x06003F5B RID: 16219
		private delegate void set_orthographicDelegate(IntPtr @this, bool value);

		// Token: 0x02000B34 RID: 2868
		// (Invoke) Token: 0x06003F5D RID: 16221
		private delegate float get_orthographicSizeDelegate(IntPtr @this);

		// Token: 0x02000B35 RID: 2869
		// (Invoke) Token: 0x06003F5F RID: 16223
		private delegate void set_orthographicSizeDelegate(IntPtr @this, float value);

		// Token: 0x02000B36 RID: 2870
		// (Invoke) Token: 0x06003F61 RID: 16225
		private delegate int get_ignoreLayersDelegate(IntPtr @this);

		// Token: 0x02000B37 RID: 2871
		// (Invoke) Token: 0x06003F63 RID: 16227
		private delegate void set_ignoreLayersDelegate(IntPtr @this, int value);

		// Token: 0x02000B38 RID: 2872
		// (Invoke) Token: 0x06003F65 RID: 16229
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x02000B39 RID: 2873
		// (Invoke) Token: 0x06003F67 RID: 16231
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);
	}
}
