using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200005E RID: 94
	public class UniversalRenderPipelineDebugDisplaySettings : DebugDisplaySettings<UniversalRenderPipelineDebugDisplaySettings>
	{
		// Token: 0x06000834 RID: 2100 RVA: 0x00031BD8 File Offset: 0x0002FDD8
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalRenderPipelineDebugDisplaySettings()
		{
			Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalRenderPipelineDebugDisplaySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr);
			UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__commonSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, "<commonSettings>k__BackingField");
			UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__materialSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, "<materialSettings>k__BackingField");
			UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__renderingSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, "<renderingSettings>k__BackingField");
			UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__lightingSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, "<lightingSettings>k__BackingField");
			UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__volumeSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, "<volumeSettings>k__BackingField");
			UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__displayStats_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, "<displayStats>k__BackingField");
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_commonSettings_Private_get_DebugDisplaySettingsCommon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664439);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_set_commonSettings_Private_set_Void_DebugDisplaySettingsCommon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664440);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_materialSettings_Public_get_DebugDisplaySettingsMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664441);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_set_materialSettings_Private_set_Void_DebugDisplaySettingsMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664442);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_renderingSettings_Public_get_DebugDisplaySettingsRendering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664443);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_set_renderingSettings_Private_set_Void_DebugDisplaySettingsRendering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664444);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_lightingSettings_Public_get_DebugDisplaySettingsLighting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664445);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_set_lightingSettings_Private_set_Void_DebugDisplaySettingsLighting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664446);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_volumeSettings_Public_get_DebugDisplaySettingsVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664447);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_set_volumeSettings_Private_set_Void_DebugDisplaySettingsVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664448);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_displayStats_Internal_get_DebugDisplayStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664449);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_set_displayStats_Private_set_Void_DebugDisplayStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664450);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664451);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664452);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664453);
			UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_UpdateFrameTiming_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr, 100664454);
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x00031DC0 File Offset: 0x0002FFC0
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x00031E00 File Offset: 0x00030000
		public unsafe DebugDisplaySettingsCommon commonSettings
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_commonSettings_Private_get_DebugDisplaySettingsCommon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsCommon>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_set_commonSettings_Private_set_Void_DebugDisplaySettingsCommon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00031E44 File Offset: 0x00030044
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00031E84 File Offset: 0x00030084
		public unsafe DebugDisplaySettingsMaterial materialSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_materialSettings_Public_get_DebugDisplaySettingsMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_set_materialSettings_Private_set_Void_DebugDisplaySettingsMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00031EC8 File Offset: 0x000300C8
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00031F08 File Offset: 0x00030108
		public unsafe DebugDisplaySettingsRendering renderingSettings
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_renderingSettings_Public_get_DebugDisplaySettingsRendering_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_set_renderingSettings_Private_set_Void_DebugDisplaySettingsRendering_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00031F4C File Offset: 0x0003014C
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00031F8C File Offset: 0x0003018C
		public unsafe DebugDisplaySettingsLighting lightingSettings
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_lightingSettings_Public_get_DebugDisplaySettingsLighting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsLighting>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_set_lightingSettings_Private_set_Void_DebugDisplaySettingsLighting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00031FD0 File Offset: 0x000301D0
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00032010 File Offset: 0x00030210
		public unsafe DebugDisplaySettingsVolume volumeSettings
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_volumeSettings_Public_get_DebugDisplaySettingsVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsVolume>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_set_volumeSettings_Private_set_Void_DebugDisplaySettingsVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00032054 File Offset: 0x00030254
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00032094 File Offset: 0x00030294
		public unsafe DebugDisplayStats displayStats
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_displayStats_Internal_get_DebugDisplayStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugDisplayStats>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_set_displayStats_Private_set_Void_DebugDisplayStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x000320D8 File Offset: 0x000302D8
		public unsafe override bool IsPostProcessingAllowed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606177, XrefRangeEnd = 606182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00032120 File Offset: 0x00030320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606182, XrefRangeEnd = 606188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalRenderPipelineDebugDisplaySettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderPipelineDebugDisplaySettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0003215C File Offset: 0x0003035C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606188, XrefRangeEnd = 606253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00032198 File Offset: 0x00030398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606253, XrefRangeEnd = 606254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFrameTiming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineDebugDisplaySettings.NativeMethodInfoPtr_UpdateFrameTiming_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0000589A File Offset: 0x00003A9A
		public UniversalRenderPipelineDebugDisplaySettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x000321CC File Offset: 0x000303CC
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x000058A3 File Offset: 0x00003AA3
		public unsafe DebugDisplaySettingsCommon _commonSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__commonSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsCommon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__commonSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x000321FC File Offset: 0x000303FC
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x000058C2 File Offset: 0x00003AC2
		public unsafe DebugDisplaySettingsMaterial _materialSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__materialSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__materialSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x0003222C File Offset: 0x0003042C
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x000058E1 File Offset: 0x00003AE1
		public unsafe DebugDisplaySettingsRendering _renderingSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__renderingSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__renderingSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x0003225C File Offset: 0x0003045C
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x00005900 File Offset: 0x00003B00
		public unsafe DebugDisplaySettingsLighting _lightingSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__lightingSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsLighting>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__lightingSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x0003228C File Offset: 0x0003048C
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x0000591F File Offset: 0x00003B1F
		public unsafe DebugDisplaySettingsVolume _volumeSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__volumeSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__volumeSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x000322BC File Offset: 0x000304BC
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x0000593E File Offset: 0x00003B3E
		public unsafe DebugDisplayStats _displayStats_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__displayStats_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplayStats>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineDebugDisplaySettings.NativeFieldInfoPtr__displayStats_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeFieldInfoPtr__commonSettings_k__BackingField;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr__materialSettings_k__BackingField;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr__renderingSettings_k__BackingField;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeFieldInfoPtr__lightingSettings_k__BackingField;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeFieldInfoPtr__volumeSettings_k__BackingField;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeFieldInfoPtr__displayStats_k__BackingField;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_get_commonSettings_Private_get_DebugDisplaySettingsCommon_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_set_commonSettings_Private_set_Void_DebugDisplaySettingsCommon_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_get_materialSettings_Public_get_DebugDisplaySettingsMaterial_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_set_materialSettings_Private_set_Void_DebugDisplaySettingsMaterial_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingSettings_Public_get_DebugDisplaySettingsRendering_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingSettings_Private_set_Void_DebugDisplaySettingsRendering_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_get_lightingSettings_Public_get_DebugDisplaySettingsLighting_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_set_lightingSettings_Private_set_Void_DebugDisplaySettingsLighting_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeSettings_Public_get_DebugDisplaySettingsVolume_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_set_volumeSettings_Private_set_Void_DebugDisplaySettingsVolume_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_get_displayStats_Internal_get_DebugDisplayStats_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_set_displayStats_Private_set_Void_DebugDisplayStats_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_get_Boolean_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFrameTiming_Internal_Void_0;
	}
}
