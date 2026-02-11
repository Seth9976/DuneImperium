using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000C7 RID: 199
	[Serializable]
	public class ScreenSpaceAmbientOcclusionSettings : Object
	{
		// Token: 0x06000F7D RID: 3965 RVA: 0x0004A994 File Offset: 0x00048B94
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenSpaceAmbientOcclusionSettings()
		{
			Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ScreenSpaceAmbientOcclusionSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr);
			ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_AOMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "AOMethod");
			ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Downsample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "Downsample");
			ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_AfterOpaque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "AfterOpaque");
			ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "Source");
			ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_NormalSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "NormalSamples");
			ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "Intensity");
			ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_DirectLightingStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "DirectLightingStrength");
			ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "Radius");
			ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "Samples");
			ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_BlurQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "BlurQuality");
			ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "Falloff");
			ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_SampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "SampleCount");
			ScreenSpaceAmbientOcclusionSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, 100665241);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0004AAC8 File Offset: 0x00048CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615272, XrefRangeEnd = 615273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenSpaceAmbientOcclusionSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceAmbientOcclusionSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0000989A File Offset: 0x00007A9A
		public ScreenSpaceAmbientOcclusionSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x0004AB04 File Offset: 0x00048D04
		// (set) Token: 0x06000F81 RID: 3969 RVA: 0x000098A3 File Offset: 0x00007AA3
		public unsafe ScreenSpaceAmbientOcclusionSettings.AOMethodOptions AOMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_AOMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_AOMethod)) = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x0004AB2C File Offset: 0x00048D2C
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x000098BE File Offset: 0x00007ABE
		public unsafe bool Downsample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Downsample);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Downsample)) = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x0004AB54 File Offset: 0x00048D54
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x000098D9 File Offset: 0x00007AD9
		public unsafe bool AfterOpaque
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_AfterOpaque);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_AfterOpaque)) = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x0004AB7C File Offset: 0x00048D7C
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x000098F4 File Offset: 0x00007AF4
		public unsafe ScreenSpaceAmbientOcclusionSettings.DepthSource Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Source);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Source)) = value;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x0004ABA4 File Offset: 0x00048DA4
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x0000990F File Offset: 0x00007B0F
		public unsafe ScreenSpaceAmbientOcclusionSettings.NormalQuality NormalSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_NormalSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_NormalSamples)) = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0004ABCC File Offset: 0x00048DCC
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x0000992A File Offset: 0x00007B2A
		public unsafe float Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Intensity)) = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0004ABF4 File Offset: 0x00048DF4
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x00009945 File Offset: 0x00007B45
		public unsafe float DirectLightingStrength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_DirectLightingStrength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_DirectLightingStrength)) = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0004AC1C File Offset: 0x00048E1C
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x00009960 File Offset: 0x00007B60
		public unsafe float Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x0004AC44 File Offset: 0x00048E44
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x0000997B File Offset: 0x00007B7B
		public unsafe ScreenSpaceAmbientOcclusionSettings.AOSampleOption Samples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Samples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Samples)) = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x0004AC6C File Offset: 0x00048E6C
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00009996 File Offset: 0x00007B96
		public unsafe ScreenSpaceAmbientOcclusionSettings.BlurQualityOptions BlurQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_BlurQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_BlurQuality)) = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x0004AC94 File Offset: 0x00048E94
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x000099B1 File Offset: 0x00007BB1
		public unsafe float Falloff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Falloff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_Falloff)) = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x0004ACBC File Offset: 0x00048EBC
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x000099CC File Offset: 0x00007BCC
		public unsafe int SampleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_SampleCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusionSettings.NativeFieldInfoPtr_SampleCount)) = value;
			}
		}

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeFieldInfoPtr_AOMethod;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeFieldInfoPtr_Downsample;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeFieldInfoPtr_AfterOpaque;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeFieldInfoPtr_Source;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeFieldInfoPtr_NormalSamples;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeFieldInfoPtr_Intensity;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeFieldInfoPtr_DirectLightingStrength;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeFieldInfoPtr_Samples;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeFieldInfoPtr_BlurQuality;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeFieldInfoPtr_Falloff;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeFieldInfoPtr_SampleCount;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001B2 RID: 434
		public enum DepthSource
		{
			// Token: 0x04001664 RID: 5732
			Depth,
			// Token: 0x04001665 RID: 5733
			DepthNormals
		}

		// Token: 0x020001B3 RID: 435
		public enum NormalQuality
		{
			// Token: 0x04001667 RID: 5735
			Low,
			// Token: 0x04001668 RID: 5736
			Medium,
			// Token: 0x04001669 RID: 5737
			High
		}

		// Token: 0x020001B4 RID: 436
		public enum AOSampleOption
		{
			// Token: 0x0400166B RID: 5739
			High,
			// Token: 0x0400166C RID: 5740
			Medium,
			// Token: 0x0400166D RID: 5741
			Low
		}

		// Token: 0x020001B5 RID: 437
		public enum AOMethodOptions
		{
			// Token: 0x0400166F RID: 5743
			BlueNoise,
			// Token: 0x04001670 RID: 5744
			InterleavedGradient
		}

		// Token: 0x020001B6 RID: 438
		public enum BlurQualityOptions
		{
			// Token: 0x04001672 RID: 5746
			High,
			// Token: 0x04001673 RID: 5747
			Medium,
			// Token: 0x04001674 RID: 5748
			Low
		}
	}
}
