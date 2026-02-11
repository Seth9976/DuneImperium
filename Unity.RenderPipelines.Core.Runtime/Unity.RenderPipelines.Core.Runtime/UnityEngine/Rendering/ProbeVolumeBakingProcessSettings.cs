using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000094 RID: 148
	[Serializable]
	[StructLayout(2)]
	public struct ProbeVolumeBakingProcessSettings
	{
		// Token: 0x06000B20 RID: 2848 RVA: 0x00035988 File Offset: 0x00033B88
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeVolumeBakingProcessSettings()
		{
			Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeBakingProcessSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr);
			ProbeVolumeBakingProcessSettings.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, "m_Version");
			ProbeVolumeBakingProcessSettings.NativeFieldInfoPtr_dilationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, "dilationSettings");
			ProbeVolumeBakingProcessSettings.NativeFieldInfoPtr_virtualOffsetSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, "virtualOffsetSettings");
			ProbeVolumeBakingProcessSettings.NativeMethodInfoPtr_get_Default_Internal_Static_get_ProbeVolumeBakingProcessSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, 100664988);
			ProbeVolumeBakingProcessSettings.NativeMethodInfoPtr__ctor_Internal_Void_ProbeDilationSettings_VirtualOffsetSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, 100664989);
			ProbeVolumeBakingProcessSettings.NativeMethodInfoPtr_SetDefaults_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, 100664990);
			ProbeVolumeBakingProcessSettings.NativeMethodInfoPtr_Upgrade_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, 100664991);
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00035A44 File Offset: 0x00033C44
		public unsafe static ProbeVolumeBakingProcessSettings Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969774, XrefRangeEnd = 969775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeBakingProcessSettings.NativeMethodInfoPtr_get_Default_Internal_Static_get_ProbeVolumeBakingProcessSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00035A74 File Offset: 0x00033C74
		[CallerCount(0)]
		public unsafe ProbeVolumeBakingProcessSettings(ProbeDilationSettings dilationSettings, VirtualOffsetSettings virtualOffsetSettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dilationSettings;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref virtualOffsetSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeBakingProcessSettings.NativeMethodInfoPtr__ctor_Internal_Void_ProbeDilationSettings_VirtualOffsetSettings_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00035AB4 File Offset: 0x00033CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969775, XrefRangeEnd = 969776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaults()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeBakingProcessSettings.NativeMethodInfoPtr_SetDefaults_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00035ADC File Offset: 0x00033CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969776, XrefRangeEnd = 969777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Upgrade()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeBakingProcessSettings.NativeMethodInfoPtr_Upgrade_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00006C17 File Offset: 0x00004E17
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeVolumeBakingProcessSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeFieldInfoPtr_dilationSettings;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeFieldInfoPtr_virtualOffsetSettings;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Internal_Static_get_ProbeVolumeBakingProcessSettings_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProbeDilationSettings_VirtualOffsetSettings_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaults_Internal_Void_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_Upgrade_Internal_Void_0;

		// Token: 0x04000840 RID: 2112
		[FieldOffset(0)]
		public ProbeVolumeBakingProcessSettings.SettingsVersion m_Version;

		// Token: 0x04000841 RID: 2113
		[FieldOffset(4)]
		public ProbeDilationSettings dilationSettings;

		// Token: 0x04000842 RID: 2114
		[FieldOffset(24)]
		public VirtualOffsetSettings virtualOffsetSettings;

		// Token: 0x020001D6 RID: 470
		public enum SettingsVersion
		{
			// Token: 0x040012D2 RID: 4818
			Initial,
			// Token: 0x040012D3 RID: 4819
			ThreadedVirtualOffset,
			// Token: 0x040012D4 RID: 4820
			Max,
			// Token: 0x040012D5 RID: 4821
			Current = 1
		}
	}
}
