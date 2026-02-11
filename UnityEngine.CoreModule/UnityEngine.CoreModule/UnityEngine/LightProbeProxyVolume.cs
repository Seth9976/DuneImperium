using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000D6 RID: 214
	public sealed class LightProbeProxyVolume : Behaviour
	{
		// Token: 0x06000E9B RID: 3739 RVA: 0x000487FC File Offset: 0x000469FC
		// Note: this type is marked as 'beforefieldinit'.
		static LightProbeProxyVolume()
		{
			Il2CppClassPointerStore<LightProbeProxyVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightProbeProxyVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbeProxyVolume>.NativeClassPtr);
			LightProbeProxyVolume.get_isFeatureSupportedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_isFeatureSupportedDelegate>("UnityEngine.LightProbeProxyVolume::get_isFeatureSupported");
			LightProbeProxyVolume.get_probeDensityDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_probeDensityDelegate>("UnityEngine.LightProbeProxyVolume::get_probeDensity");
			LightProbeProxyVolume.set_probeDensityDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_probeDensityDelegate>("UnityEngine.LightProbeProxyVolume::set_probeDensity");
			LightProbeProxyVolume.get_gridResolutionXDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionXDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionX");
			LightProbeProxyVolume.set_gridResolutionXDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionXDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionX");
			LightProbeProxyVolume.get_gridResolutionYDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionYDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionY");
			LightProbeProxyVolume.set_gridResolutionYDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionYDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionY");
			LightProbeProxyVolume.get_gridResolutionZDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionZDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionZ");
			LightProbeProxyVolume.set_gridResolutionZDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionZDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionZ");
			LightProbeProxyVolume.get_boundingBoxModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_boundingBoxModeDelegate>("UnityEngine.LightProbeProxyVolume::get_boundingBoxMode");
			LightProbeProxyVolume.set_boundingBoxModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_boundingBoxModeDelegate>("UnityEngine.LightProbeProxyVolume::set_boundingBoxMode");
			LightProbeProxyVolume.get_resolutionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_resolutionModeDelegate>("UnityEngine.LightProbeProxyVolume::get_resolutionMode");
			LightProbeProxyVolume.set_resolutionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_resolutionModeDelegate>("UnityEngine.LightProbeProxyVolume::set_resolutionMode");
			LightProbeProxyVolume.get_probePositionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_probePositionModeDelegate>("UnityEngine.LightProbeProxyVolume::get_probePositionMode");
			LightProbeProxyVolume.set_probePositionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_probePositionModeDelegate>("UnityEngine.LightProbeProxyVolume::set_probePositionMode");
			LightProbeProxyVolume.get_refreshModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_refreshModeDelegate>("UnityEngine.LightProbeProxyVolume::get_refreshMode");
			LightProbeProxyVolume.set_refreshModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_refreshModeDelegate>("UnityEngine.LightProbeProxyVolume::set_refreshMode");
			LightProbeProxyVolume.get_qualityModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_qualityModeDelegate>("UnityEngine.LightProbeProxyVolume::get_qualityMode");
			LightProbeProxyVolume.set_qualityModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_qualityModeDelegate>("UnityEngine.LightProbeProxyVolume::set_qualityMode");
			LightProbeProxyVolume.get_dataFormatDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_dataFormatDelegate>("UnityEngine.LightProbeProxyVolume::get_dataFormat");
			LightProbeProxyVolume.set_dataFormatDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_dataFormatDelegate>("UnityEngine.LightProbeProxyVolume::set_dataFormat");
			LightProbeProxyVolume.SetDirtyFlagDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.SetDirtyFlagDelegate>("UnityEngine.LightProbeProxyVolume::SetDirtyFlag");
			LightProbeProxyVolume.get_boundsGlobal_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_boundsGlobal_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_boundsGlobal_Injected");
			LightProbeProxyVolume.get_sizeCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_sizeCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_sizeCustom_Injected");
			LightProbeProxyVolume.set_sizeCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_sizeCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_sizeCustom_Injected");
			LightProbeProxyVolume.get_originCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_originCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_originCustom_Injected");
			LightProbeProxyVolume.set_originCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_originCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_originCustom_Injected");
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0000717D File Offset: 0x0000537D
		public LightProbeProxyVolume(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00007186 File Offset: 0x00005386
		public static bool isFeatureSupported
		{
			get
			{
				return LightProbeProxyVolume.get_isFeatureSupportedDelegateField();
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x000489C4 File Offset: 0x00046BC4
		public Bounds boundsGlobal
		{
			get
			{
				Bounds bounds;
				this.get_boundsGlobal_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x000489DC File Offset: 0x00046BDC
		// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x00007192 File Offset: 0x00005392
		public Vector3 sizeCustom
		{
			get
			{
				Vector3 vector;
				this.get_sizeCustom_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_sizeCustom_Injected(ref value);
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x000489F4 File Offset: 0x00046BF4
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x0000719C File Offset: 0x0000539C
		public Vector3 originCustom
		{
			get
			{
				Vector3 vector;
				this.get_originCustom_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_originCustom_Injected(ref value);
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x000071A6 File Offset: 0x000053A6
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x000071B8 File Offset: 0x000053B8
		public float probeDensity
		{
			get
			{
				return LightProbeProxyVolume.get_probeDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_probeDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x000071CB File Offset: 0x000053CB
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x000071DD File Offset: 0x000053DD
		public int gridResolutionX
		{
			get
			{
				return LightProbeProxyVolume.get_gridResolutionXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_gridResolutionXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x000071F0 File Offset: 0x000053F0
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x00007202 File Offset: 0x00005402
		public int gridResolutionY
		{
			get
			{
				return LightProbeProxyVolume.get_gridResolutionYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_gridResolutionYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00007215 File Offset: 0x00005415
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x00007227 File Offset: 0x00005427
		public int gridResolutionZ
		{
			get
			{
				return LightProbeProxyVolume.get_gridResolutionZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_gridResolutionZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x0000723A File Offset: 0x0000543A
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x0000724C File Offset: 0x0000544C
		public LightProbeProxyVolume.BoundingBoxMode boundingBoxMode
		{
			get
			{
				return LightProbeProxyVolume.get_boundingBoxModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_boundingBoxModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0000725F File Offset: 0x0000545F
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x00007271 File Offset: 0x00005471
		public LightProbeProxyVolume.ResolutionMode resolutionMode
		{
			get
			{
				return LightProbeProxyVolume.get_resolutionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_resolutionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00007284 File Offset: 0x00005484
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00007296 File Offset: 0x00005496
		public LightProbeProxyVolume.ProbePositionMode probePositionMode
		{
			get
			{
				return LightProbeProxyVolume.get_probePositionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_probePositionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x000072A9 File Offset: 0x000054A9
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x000072BB File Offset: 0x000054BB
		public LightProbeProxyVolume.RefreshMode refreshMode
		{
			get
			{
				return LightProbeProxyVolume.get_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x000072CE File Offset: 0x000054CE
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x000072E0 File Offset: 0x000054E0
		public LightProbeProxyVolume.QualityMode qualityMode
		{
			get
			{
				return LightProbeProxyVolume.get_qualityModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_qualityModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x000072F3 File Offset: 0x000054F3
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x00007305 File Offset: 0x00005505
		public LightProbeProxyVolume.DataFormat dataFormat
		{
			get
			{
				return LightProbeProxyVolume.get_dataFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_dataFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00007318 File Offset: 0x00005518
		public void Update()
		{
			this.SetDirtyFlag(true);
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00007323 File Offset: 0x00005523
		public void SetDirtyFlag(bool flag)
		{
			LightProbeProxyVolume.SetDirtyFlagDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), flag);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00007336 File Offset: 0x00005536
		public void get_boundsGlobal_Injected(out Bounds ret)
		{
			LightProbeProxyVolume.get_boundsGlobal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00007349 File Offset: 0x00005549
		public void get_sizeCustom_Injected(out Vector3 ret)
		{
			LightProbeProxyVolume.get_sizeCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0000735C File Offset: 0x0000555C
		public void set_sizeCustom_Injected(ref Vector3 value)
		{
			LightProbeProxyVolume.set_sizeCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0000736F File Offset: 0x0000556F
		public void get_originCustom_Injected(out Vector3 ret)
		{
			LightProbeProxyVolume.get_originCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00007382 File Offset: 0x00005582
		public void set_originCustom_Injected(ref Vector3 value)
		{
			LightProbeProxyVolume.set_originCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000CC1 RID: 3265
		private static readonly LightProbeProxyVolume.get_isFeatureSupportedDelegate get_isFeatureSupportedDelegateField;

		// Token: 0x04000CC2 RID: 3266
		private static readonly LightProbeProxyVolume.get_probeDensityDelegate get_probeDensityDelegateField;

		// Token: 0x04000CC3 RID: 3267
		private static readonly LightProbeProxyVolume.set_probeDensityDelegate set_probeDensityDelegateField;

		// Token: 0x04000CC4 RID: 3268
		private static readonly LightProbeProxyVolume.get_gridResolutionXDelegate get_gridResolutionXDelegateField;

		// Token: 0x04000CC5 RID: 3269
		private static readonly LightProbeProxyVolume.set_gridResolutionXDelegate set_gridResolutionXDelegateField;

		// Token: 0x04000CC6 RID: 3270
		private static readonly LightProbeProxyVolume.get_gridResolutionYDelegate get_gridResolutionYDelegateField;

		// Token: 0x04000CC7 RID: 3271
		private static readonly LightProbeProxyVolume.set_gridResolutionYDelegate set_gridResolutionYDelegateField;

		// Token: 0x04000CC8 RID: 3272
		private static readonly LightProbeProxyVolume.get_gridResolutionZDelegate get_gridResolutionZDelegateField;

		// Token: 0x04000CC9 RID: 3273
		private static readonly LightProbeProxyVolume.set_gridResolutionZDelegate set_gridResolutionZDelegateField;

		// Token: 0x04000CCA RID: 3274
		private static readonly LightProbeProxyVolume.get_boundingBoxModeDelegate get_boundingBoxModeDelegateField;

		// Token: 0x04000CCB RID: 3275
		private static readonly LightProbeProxyVolume.set_boundingBoxModeDelegate set_boundingBoxModeDelegateField;

		// Token: 0x04000CCC RID: 3276
		private static readonly LightProbeProxyVolume.get_resolutionModeDelegate get_resolutionModeDelegateField;

		// Token: 0x04000CCD RID: 3277
		private static readonly LightProbeProxyVolume.set_resolutionModeDelegate set_resolutionModeDelegateField;

		// Token: 0x04000CCE RID: 3278
		private static readonly LightProbeProxyVolume.get_probePositionModeDelegate get_probePositionModeDelegateField;

		// Token: 0x04000CCF RID: 3279
		private static readonly LightProbeProxyVolume.set_probePositionModeDelegate set_probePositionModeDelegateField;

		// Token: 0x04000CD0 RID: 3280
		private static readonly LightProbeProxyVolume.get_refreshModeDelegate get_refreshModeDelegateField;

		// Token: 0x04000CD1 RID: 3281
		private static readonly LightProbeProxyVolume.set_refreshModeDelegate set_refreshModeDelegateField;

		// Token: 0x04000CD2 RID: 3282
		private static readonly LightProbeProxyVolume.get_qualityModeDelegate get_qualityModeDelegateField;

		// Token: 0x04000CD3 RID: 3283
		private static readonly LightProbeProxyVolume.set_qualityModeDelegate set_qualityModeDelegateField;

		// Token: 0x04000CD4 RID: 3284
		private static readonly LightProbeProxyVolume.get_dataFormatDelegate get_dataFormatDelegateField;

		// Token: 0x04000CD5 RID: 3285
		private static readonly LightProbeProxyVolume.set_dataFormatDelegate set_dataFormatDelegateField;

		// Token: 0x04000CD6 RID: 3286
		private static readonly LightProbeProxyVolume.SetDirtyFlagDelegate SetDirtyFlagDelegateField;

		// Token: 0x04000CD7 RID: 3287
		private static readonly LightProbeProxyVolume.get_boundsGlobal_InjectedDelegate get_boundsGlobal_InjectedDelegateField;

		// Token: 0x04000CD8 RID: 3288
		private static readonly LightProbeProxyVolume.get_sizeCustom_InjectedDelegate get_sizeCustom_InjectedDelegateField;

		// Token: 0x04000CD9 RID: 3289
		private static readonly LightProbeProxyVolume.set_sizeCustom_InjectedDelegate set_sizeCustom_InjectedDelegateField;

		// Token: 0x04000CDA RID: 3290
		private static readonly LightProbeProxyVolume.get_originCustom_InjectedDelegate get_originCustom_InjectedDelegateField;

		// Token: 0x04000CDB RID: 3291
		private static readonly LightProbeProxyVolume.set_originCustom_InjectedDelegate set_originCustom_InjectedDelegateField;

		// Token: 0x02000619 RID: 1561
		public enum ResolutionMode
		{
			// Token: 0x04002BB0 RID: 11184
			Automatic,
			// Token: 0x04002BB1 RID: 11185
			Custom
		}

		// Token: 0x0200061A RID: 1562
		public enum BoundingBoxMode
		{
			// Token: 0x04002BB3 RID: 11187
			AutomaticLocal,
			// Token: 0x04002BB4 RID: 11188
			AutomaticWorld,
			// Token: 0x04002BB5 RID: 11189
			Custom
		}

		// Token: 0x0200061B RID: 1563
		public enum ProbePositionMode
		{
			// Token: 0x04002BB7 RID: 11191
			CellCorner,
			// Token: 0x04002BB8 RID: 11192
			CellCenter
		}

		// Token: 0x0200061C RID: 1564
		public enum RefreshMode
		{
			// Token: 0x04002BBA RID: 11194
			Automatic,
			// Token: 0x04002BBB RID: 11195
			EveryFrame,
			// Token: 0x04002BBC RID: 11196
			ViaScripting
		}

		// Token: 0x0200061D RID: 1565
		public enum QualityMode
		{
			// Token: 0x04002BBE RID: 11198
			Low,
			// Token: 0x04002BBF RID: 11199
			Normal
		}

		// Token: 0x0200061E RID: 1566
		public enum DataFormat
		{
			// Token: 0x04002BC1 RID: 11201
			HalfFloat,
			// Token: 0x04002BC2 RID: 11202
			Float
		}

		// Token: 0x0200061F RID: 1567
		// (Invoke) Token: 0x0600353D RID: 13629
		private delegate bool get_isFeatureSupportedDelegate();

		// Token: 0x02000620 RID: 1568
		// (Invoke) Token: 0x0600353F RID: 13631
		private delegate float get_probeDensityDelegate(IntPtr @this);

		// Token: 0x02000621 RID: 1569
		// (Invoke) Token: 0x06003541 RID: 13633
		private delegate void set_probeDensityDelegate(IntPtr @this, float value);

		// Token: 0x02000622 RID: 1570
		// (Invoke) Token: 0x06003543 RID: 13635
		private delegate int get_gridResolutionXDelegate(IntPtr @this);

		// Token: 0x02000623 RID: 1571
		// (Invoke) Token: 0x06003545 RID: 13637
		private delegate void set_gridResolutionXDelegate(IntPtr @this, int value);

		// Token: 0x02000624 RID: 1572
		// (Invoke) Token: 0x06003547 RID: 13639
		private delegate int get_gridResolutionYDelegate(IntPtr @this);

		// Token: 0x02000625 RID: 1573
		// (Invoke) Token: 0x06003549 RID: 13641
		private delegate void set_gridResolutionYDelegate(IntPtr @this, int value);

		// Token: 0x02000626 RID: 1574
		// (Invoke) Token: 0x0600354B RID: 13643
		private delegate int get_gridResolutionZDelegate(IntPtr @this);

		// Token: 0x02000627 RID: 1575
		// (Invoke) Token: 0x0600354D RID: 13645
		private delegate void set_gridResolutionZDelegate(IntPtr @this, int value);

		// Token: 0x02000628 RID: 1576
		// (Invoke) Token: 0x0600354F RID: 13647
		private delegate LightProbeProxyVolume.BoundingBoxMode get_boundingBoxModeDelegate(IntPtr @this);

		// Token: 0x02000629 RID: 1577
		// (Invoke) Token: 0x06003551 RID: 13649
		private delegate void set_boundingBoxModeDelegate(IntPtr @this, LightProbeProxyVolume.BoundingBoxMode value);

		// Token: 0x0200062A RID: 1578
		// (Invoke) Token: 0x06003553 RID: 13651
		private delegate LightProbeProxyVolume.ResolutionMode get_resolutionModeDelegate(IntPtr @this);

		// Token: 0x0200062B RID: 1579
		// (Invoke) Token: 0x06003555 RID: 13653
		private delegate void set_resolutionModeDelegate(IntPtr @this, LightProbeProxyVolume.ResolutionMode value);

		// Token: 0x0200062C RID: 1580
		// (Invoke) Token: 0x06003557 RID: 13655
		private delegate LightProbeProxyVolume.ProbePositionMode get_probePositionModeDelegate(IntPtr @this);

		// Token: 0x0200062D RID: 1581
		// (Invoke) Token: 0x06003559 RID: 13657
		private delegate void set_probePositionModeDelegate(IntPtr @this, LightProbeProxyVolume.ProbePositionMode value);

		// Token: 0x0200062E RID: 1582
		// (Invoke) Token: 0x0600355B RID: 13659
		private delegate LightProbeProxyVolume.RefreshMode get_refreshModeDelegate(IntPtr @this);

		// Token: 0x0200062F RID: 1583
		// (Invoke) Token: 0x0600355D RID: 13661
		private delegate void set_refreshModeDelegate(IntPtr @this, LightProbeProxyVolume.RefreshMode value);

		// Token: 0x02000630 RID: 1584
		// (Invoke) Token: 0x0600355F RID: 13663
		private delegate LightProbeProxyVolume.QualityMode get_qualityModeDelegate(IntPtr @this);

		// Token: 0x02000631 RID: 1585
		// (Invoke) Token: 0x06003561 RID: 13665
		private delegate void set_qualityModeDelegate(IntPtr @this, LightProbeProxyVolume.QualityMode value);

		// Token: 0x02000632 RID: 1586
		// (Invoke) Token: 0x06003563 RID: 13667
		private delegate LightProbeProxyVolume.DataFormat get_dataFormatDelegate(IntPtr @this);

		// Token: 0x02000633 RID: 1587
		// (Invoke) Token: 0x06003565 RID: 13669
		private delegate void set_dataFormatDelegate(IntPtr @this, LightProbeProxyVolume.DataFormat value);

		// Token: 0x02000634 RID: 1588
		// (Invoke) Token: 0x06003567 RID: 13671
		private delegate void SetDirtyFlagDelegate(IntPtr @this, bool flag);

		// Token: 0x02000635 RID: 1589
		// (Invoke) Token: 0x06003569 RID: 13673
		private delegate void get_boundsGlobal_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000636 RID: 1590
		// (Invoke) Token: 0x0600356B RID: 13675
		private delegate void get_sizeCustom_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000637 RID: 1591
		// (Invoke) Token: 0x0600356D RID: 13677
		private delegate void set_sizeCustom_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000638 RID: 1592
		// (Invoke) Token: 0x0600356F RID: 13679
		private delegate void get_originCustom_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000639 RID: 1593
		// (Invoke) Token: 0x06003571 RID: 13681
		private delegate void set_originCustom_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
