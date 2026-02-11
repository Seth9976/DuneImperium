using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000093 RID: 147
	[Serializable]
	[StructLayout(2)]
	public struct VirtualOffsetSettings
	{
		// Token: 0x06000B1C RID: 2844 RVA: 0x00035850 File Offset: 0x00033A50
		// Note: this type is marked as 'beforefieldinit'.
		static VirtualOffsetSettings()
		{
			Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "VirtualOffsetSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr);
			VirtualOffsetSettings.NativeFieldInfoPtr_useVirtualOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, "useVirtualOffset");
			VirtualOffsetSettings.NativeFieldInfoPtr_outOfGeoOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, "outOfGeoOffset");
			VirtualOffsetSettings.NativeFieldInfoPtr_searchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, "searchMultiplier");
			VirtualOffsetSettings.NativeFieldInfoPtr_rayOriginBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, "rayOriginBias");
			VirtualOffsetSettings.NativeFieldInfoPtr_maxHitsPerRay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, "maxHitsPerRay");
			VirtualOffsetSettings.NativeFieldInfoPtr_collisionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, "collisionMask");
			VirtualOffsetSettings.NativeMethodInfoPtr_SetDefaults_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, 100664986);
			VirtualOffsetSettings.NativeMethodInfoPtr_UpgradeFromTo_Internal_Void_SettingsVersion_SettingsVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, 100664987);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00035920 File Offset: 0x00033B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969772, XrefRangeEnd = 969773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaults()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualOffsetSettings.NativeMethodInfoPtr_SetDefaults_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00035948 File Offset: 0x00033B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969773, XrefRangeEnd = 969774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualOffsetSettings.NativeMethodInfoPtr_UpgradeFromTo_Internal_Void_SettingsVersion_SettingsVersion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00006C05 File Offset: 0x00004E05
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VirtualOffsetSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeFieldInfoPtr_useVirtualOffset;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeFieldInfoPtr_outOfGeoOffset;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeFieldInfoPtr_searchMultiplier;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeFieldInfoPtr_rayOriginBias;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeFieldInfoPtr_maxHitsPerRay;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeFieldInfoPtr_collisionMask;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaults_Internal_Void_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeFromTo_Internal_Void_SettingsVersion_SettingsVersion_0;

		// Token: 0x04000833 RID: 2099
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool useVirtualOffset;

		// Token: 0x04000834 RID: 2100
		[FieldOffset(4)]
		public float outOfGeoOffset;

		// Token: 0x04000835 RID: 2101
		[FieldOffset(8)]
		public float searchMultiplier;

		// Token: 0x04000836 RID: 2102
		[FieldOffset(12)]
		public float rayOriginBias;

		// Token: 0x04000837 RID: 2103
		[FieldOffset(16)]
		public int maxHitsPerRay;

		// Token: 0x04000838 RID: 2104
		[FieldOffset(20)]
		public LayerMask collisionMask;
	}
}
