using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000047 RID: 71
	[Serializable]
	[StructLayout(2)]
	public struct GlobalDynamicResolutionSettings
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x0002207C File Offset: 0x0002027C
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalDynamicResolutionSettings()
		{
			Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "GlobalDynamicResolutionSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr);
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "enabled");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_useMipBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "useMipBias");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_enableDLSS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "enableDLSS");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_DLSSPerfQualitySetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "DLSSPerfQualitySetting");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_DLSSInjectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "DLSSInjectionPoint");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_DLSSUseOptimalSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "DLSSUseOptimalSettings");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_DLSSSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "DLSSSharpness");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_fsrOverrideSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "fsrOverrideSharpness");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_fsrSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "fsrSharpness");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_maxPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "maxPercentage");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_minPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "minPercentage");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_dynResType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "dynResType");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_upsampleFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "upsampleFilter");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_forceResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "forceResolution");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_forcedPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "forcedPercentage");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_lowResTransparencyMinimumThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "lowResTransparencyMinimumThreshold");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_rayTracingHalfResThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "rayTracingHalfResThreshold");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_lowResSSGIMinimumThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "lowResSSGIMinimumThreshold");
			GlobalDynamicResolutionSettings.NativeFieldInfoPtr_lowResVolumetricCloudsMinimumThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "lowResVolumetricCloudsMinimumThreshold");
			GlobalDynamicResolutionSettings.NativeMethodInfoPtr_NewDefault_Public_Static_GlobalDynamicResolutionSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, 100664003);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0002223C File Offset: 0x0002043C
		[CallerCount(0)]
		public unsafe static GlobalDynamicResolutionSettings NewDefault()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDynamicResolutionSettings.NativeMethodInfoPtr_NewDefault_Public_Static_GlobalDynamicResolutionSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000043D5 File Offset: 0x000025D5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr_useMipBias;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr_enableDLSS;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_DLSSPerfQualitySetting;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr_DLSSInjectionPoint;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_DLSSUseOptimalSettings;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr_DLSSSharpness;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_fsrOverrideSharpness;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_fsrSharpness;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_maxPercentage;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_minPercentage;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_dynResType;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_upsampleFilter;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_forceResolution;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_forcedPercentage;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_lowResTransparencyMinimumThreshold;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_rayTracingHalfResThreshold;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_lowResSSGIMinimumThreshold;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_lowResVolumetricCloudsMinimumThreshold;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_NewDefault_Public_Static_GlobalDynamicResolutionSettings_0;

		// Token: 0x04000410 RID: 1040
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool enabled;

		// Token: 0x04000411 RID: 1041
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool useMipBias;

		// Token: 0x04000412 RID: 1042
		[FieldOffset(2)]
		[MarshalAs(4)]
		public bool enableDLSS;

		// Token: 0x04000413 RID: 1043
		[FieldOffset(4)]
		public uint DLSSPerfQualitySetting;

		// Token: 0x04000414 RID: 1044
		[FieldOffset(8)]
		public DynamicResolutionHandler.UpsamplerScheduleType DLSSInjectionPoint;

		// Token: 0x04000415 RID: 1045
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool DLSSUseOptimalSettings;

		// Token: 0x04000416 RID: 1046
		[FieldOffset(16)]
		public float DLSSSharpness;

		// Token: 0x04000417 RID: 1047
		[FieldOffset(20)]
		[MarshalAs(4)]
		public bool fsrOverrideSharpness;

		// Token: 0x04000418 RID: 1048
		[FieldOffset(24)]
		public float fsrSharpness;

		// Token: 0x04000419 RID: 1049
		[FieldOffset(28)]
		public float maxPercentage;

		// Token: 0x0400041A RID: 1050
		[FieldOffset(32)]
		public float minPercentage;

		// Token: 0x0400041B RID: 1051
		[FieldOffset(36)]
		public DynamicResolutionType dynResType;

		// Token: 0x0400041C RID: 1052
		[FieldOffset(37)]
		public DynamicResUpscaleFilter upsampleFilter;

		// Token: 0x0400041D RID: 1053
		[FieldOffset(38)]
		[MarshalAs(4)]
		public bool forceResolution;

		// Token: 0x0400041E RID: 1054
		[FieldOffset(40)]
		public float forcedPercentage;

		// Token: 0x0400041F RID: 1055
		[FieldOffset(44)]
		public float lowResTransparencyMinimumThreshold;

		// Token: 0x04000420 RID: 1056
		[FieldOffset(48)]
		public float rayTracingHalfResThreshold;

		// Token: 0x04000421 RID: 1057
		[FieldOffset(52)]
		public float lowResSSGIMinimumThreshold;

		// Token: 0x04000422 RID: 1058
		[FieldOffset(56)]
		public float lowResVolumetricCloudsMinimumThreshold;
	}
}
