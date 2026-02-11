using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000092 RID: 146
	[Serializable]
	[StructLayout(2)]
	public struct ProbeDilationSettings
	{
		// Token: 0x06000B18 RID: 2840 RVA: 0x0003572C File Offset: 0x0003392C
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeDilationSettings()
		{
			Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeDilationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr);
			ProbeDilationSettings.NativeFieldInfoPtr_enableDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, "enableDilation");
			ProbeDilationSettings.NativeFieldInfoPtr_dilationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, "dilationDistance");
			ProbeDilationSettings.NativeFieldInfoPtr_dilationValidityThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, "dilationValidityThreshold");
			ProbeDilationSettings.NativeFieldInfoPtr_dilationIterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, "dilationIterations");
			ProbeDilationSettings.NativeFieldInfoPtr_squaredDistWeighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, "squaredDistWeighting");
			ProbeDilationSettings.NativeMethodInfoPtr_SetDefaults_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, 100664984);
			ProbeDilationSettings.NativeMethodInfoPtr_UpgradeFromTo_Internal_Void_SettingsVersion_SettingsVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, 100664985);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x000357E8 File Offset: 0x000339E8
		[CallerCount(0)]
		public unsafe void SetDefaults()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeDilationSettings.NativeMethodInfoPtr_SetDefaults_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00035810 File Offset: 0x00033A10
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpgradeFromTo(ProbeVolumeBakingProcessSettings.SettingsVersion from, ProbeVolumeBakingProcessSettings.SettingsVersion to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeDilationSettings.NativeMethodInfoPtr_UpgradeFromTo_Internal_Void_SettingsVersion_SettingsVersion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00006BF3 File Offset: 0x00004DF3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeDilationSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeFieldInfoPtr_enableDilation;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeFieldInfoPtr_dilationDistance;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeFieldInfoPtr_dilationValidityThreshold;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeFieldInfoPtr_dilationIterations;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeFieldInfoPtr_squaredDistWeighting;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaults_Internal_Void_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeFromTo_Internal_Void_SettingsVersion_SettingsVersion_0;

		// Token: 0x04000826 RID: 2086
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool enableDilation;

		// Token: 0x04000827 RID: 2087
		[FieldOffset(4)]
		public float dilationDistance;

		// Token: 0x04000828 RID: 2088
		[FieldOffset(8)]
		public float dilationValidityThreshold;

		// Token: 0x04000829 RID: 2089
		[FieldOffset(12)]
		public int dilationIterations;

		// Token: 0x0400082A RID: 2090
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool squaredDistWeighting;
	}
}
