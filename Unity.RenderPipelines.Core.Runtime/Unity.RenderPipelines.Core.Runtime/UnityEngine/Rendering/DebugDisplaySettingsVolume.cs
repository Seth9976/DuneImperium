using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x0200005F RID: 95
	public class DebugDisplaySettingsVolume : Object
	{
		// Token: 0x0600066E RID: 1646 RVA: 0x00026018 File Offset: 0x00024218
		// Note: this type is marked as 'beforefieldinit'.
		static DebugDisplaySettingsVolume()
		{
			Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugDisplaySettingsVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr);
			DebugDisplaySettingsVolume.NativeFieldInfoPtr__volumeDebugSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr, "<volumeDebugSettings>k__BackingField");
			DebugDisplaySettingsVolume.NativeFieldInfoPtr_volumeComponentEnumIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr, "volumeComponentEnumIndex");
			DebugDisplaySettingsVolume.NativeMethodInfoPtr_get_volumeDebugSettings_Public_get_IVolumeDebugSettings2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr, 100664144);
			DebugDisplaySettingsVolume.NativeMethodInfoPtr__ctor_Public_Void_IVolumeDebugSettings2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr, 100664145);
			DebugDisplaySettingsVolume.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr, 100664146);
			DebugDisplaySettingsVolume.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr, 100664147);
			DebugDisplaySettingsVolume.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr, 100664148);
			DebugDisplaySettingsVolume.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr, 100664149);
			DebugDisplaySettingsVolume.NativeMethodInfoPtr_CreatePanel_Public_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr, 100664150);
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x000260FC File Offset: 0x000242FC
		public unsafe IVolumeDebugSettings2 volumeDebugSettings
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.NativeMethodInfoPtr_get_volumeDebugSettings_Public_get_IVolumeDebugSettings2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVolumeDebugSettings2>(intPtr3) : null;
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0002613C File Offset: 0x0002433C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugDisplaySettingsVolume(IVolumeDebugSettings2 volumeDebugSettings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volumeDebugSettings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.NativeMethodInfoPtr__ctor_Public_Void_IVolumeDebugSettings2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00026188 File Offset: 0x00024388
		public unsafe virtual bool AreAnySettingsActive
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x000261C4 File Offset: 0x000243C4
		public unsafe virtual bool IsPostProcessingAllowed
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00026200 File Offset: 0x00024400
		public unsafe virtual bool IsLightingActive
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0002623C File Offset: 0x0002443C
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetScreenClearColor(ref Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00026288 File Offset: 0x00024488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961982, XrefRangeEnd = 961986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDebugDisplaySettingsPanelDisposable CreatePanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.NativeMethodInfoPtr_CreatePanel_Public_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDebugDisplaySettingsPanelDisposable>(intPtr3) : null;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000048C3 File Offset: 0x00002AC3
		public DebugDisplaySettingsVolume(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x000262C8 File Offset: 0x000244C8
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x000048CC File Offset: 0x00002ACC
		public unsafe IVolumeDebugSettings2 _volumeDebugSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.NativeFieldInfoPtr__volumeDebugSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVolumeDebugSettings2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.NativeFieldInfoPtr__volumeDebugSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x000262F8 File Offset: 0x000244F8
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x000048EB File Offset: 0x00002AEB
		public unsafe int volumeComponentEnumIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.NativeFieldInfoPtr_volumeComponentEnumIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.NativeFieldInfoPtr_volumeComponentEnumIndex)) = value;
			}
		}

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeFieldInfoPtr__volumeDebugSettings_k__BackingField;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeFieldInfoPtr_volumeComponentEnumIndex;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeDebugSettings_Public_get_IVolumeDebugSettings2_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IVolumeDebugSettings2_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_CreatePanel_Public_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0;

		// Token: 0x02000189 RID: 393
		public static class Styles : Object
		{
			// Token: 0x0600165F RID: 5727 RVA: 0x00060D80 File Offset: 0x0005EF80
			// Note: this type is marked as 'beforefieldinit'.
			static Styles()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsVolume.Styles>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr, "Styles");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Styles>.NativeClassPtr);
				DebugDisplaySettingsVolume.Styles.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Styles>.NativeClassPtr, "none");
				DebugDisplaySettingsVolume.Styles.NativeFieldInfoPtr_editorCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Styles>.NativeClassPtr, "editorCamera");
			}

			// Token: 0x06001660 RID: 5728 RVA: 0x0000B3E8 File Offset: 0x000095E8
			public Styles(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000633 RID: 1587
			// (get) Token: 0x06001661 RID: 5729 RVA: 0x00060DD4 File Offset: 0x0005EFD4
			// (set) Token: 0x06001662 RID: 5730 RVA: 0x0000B3F1 File Offset: 0x000095F1
			public unsafe static GUIContent none
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Styles.NativeFieldInfoPtr_none, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Styles.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000634 RID: 1588
			// (get) Token: 0x06001663 RID: 5731 RVA: 0x00060DFC File Offset: 0x0005EFFC
			// (set) Token: 0x06001664 RID: 5732 RVA: 0x0000B403 File Offset: 0x00009603
			public unsafe static GUIContent editorCamera
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Styles.NativeFieldInfoPtr_editorCamera, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Styles.NativeFieldInfoPtr_editorCamera, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400104E RID: 4174
			private static readonly IntPtr NativeFieldInfoPtr_none;

			// Token: 0x0400104F RID: 4175
			private static readonly IntPtr NativeFieldInfoPtr_editorCamera;
		}

		// Token: 0x0200018A RID: 394
		public static class Strings : Object
		{
			// Token: 0x06001665 RID: 5733 RVA: 0x00060E24 File Offset: 0x0005F024
			// Note: this type is marked as 'beforefieldinit'.
			static Strings()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr, "Strings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr);
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "none");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "camera");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "parameter");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_component = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "component");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_debugViewNotSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "debugViewNotSupported");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_parameterNotOverrided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "parameterNotOverrided");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_volumeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "volumeInfo");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "gameObject");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_resultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "resultValue");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_resultValueTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "resultValueTooltip");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_globalDefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "globalDefaultValue");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_globalDefaultValueTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "globalDefaultValueTooltip");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_qualityLevelValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "qualityLevelValue");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_qualityLevelValueTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "qualityLevelValueTooltip");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "global");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_local = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "local");
				DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_volumeProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.Strings>.NativeClassPtr, "volumeProfile");
			}

			// Token: 0x06001666 RID: 5734 RVA: 0x0000B415 File Offset: 0x00009615
			public Strings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000635 RID: 1589
			// (get) Token: 0x06001667 RID: 5735 RVA: 0x00060FA4 File Offset: 0x0005F1A4
			// (set) Token: 0x06001668 RID: 5736 RVA: 0x0000B41E File Offset: 0x0000961E
			public unsafe static string none
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_none, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_none, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000636 RID: 1590
			// (get) Token: 0x06001669 RID: 5737 RVA: 0x00060FC4 File Offset: 0x0005F1C4
			// (set) Token: 0x0600166A RID: 5738 RVA: 0x0000B430 File Offset: 0x00009630
			public unsafe static string camera
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_camera, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_camera, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000637 RID: 1591
			// (get) Token: 0x0600166B RID: 5739 RVA: 0x00060FE4 File Offset: 0x0005F1E4
			// (set) Token: 0x0600166C RID: 5740 RVA: 0x0000B442 File Offset: 0x00009642
			public unsafe static string parameter
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_parameter, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_parameter, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000638 RID: 1592
			// (get) Token: 0x0600166D RID: 5741 RVA: 0x00061004 File Offset: 0x0005F204
			// (set) Token: 0x0600166E RID: 5742 RVA: 0x0000B454 File Offset: 0x00009654
			public unsafe static string component
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_component, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_component, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000639 RID: 1593
			// (get) Token: 0x0600166F RID: 5743 RVA: 0x00061024 File Offset: 0x0005F224
			// (set) Token: 0x06001670 RID: 5744 RVA: 0x0000B466 File Offset: 0x00009666
			public unsafe static string debugViewNotSupported
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_debugViewNotSupported, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_debugViewNotSupported, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700063A RID: 1594
			// (get) Token: 0x06001671 RID: 5745 RVA: 0x00061044 File Offset: 0x0005F244
			// (set) Token: 0x06001672 RID: 5746 RVA: 0x0000B478 File Offset: 0x00009678
			public unsafe static string parameterNotOverrided
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_parameterNotOverrided, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_parameterNotOverrided, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700063B RID: 1595
			// (get) Token: 0x06001673 RID: 5747 RVA: 0x00061064 File Offset: 0x0005F264
			// (set) Token: 0x06001674 RID: 5748 RVA: 0x0000B48A File Offset: 0x0000968A
			public unsafe static string volumeInfo
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_volumeInfo, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_volumeInfo, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700063C RID: 1596
			// (get) Token: 0x06001675 RID: 5749 RVA: 0x00061084 File Offset: 0x0005F284
			// (set) Token: 0x06001676 RID: 5750 RVA: 0x0000B49C File Offset: 0x0000969C
			public unsafe static string gameObject
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_gameObject, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_gameObject, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700063D RID: 1597
			// (get) Token: 0x06001677 RID: 5751 RVA: 0x000610A4 File Offset: 0x0005F2A4
			// (set) Token: 0x06001678 RID: 5752 RVA: 0x0000B4AE File Offset: 0x000096AE
			public unsafe static string resultValue
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_resultValue, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_resultValue, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700063E RID: 1598
			// (get) Token: 0x06001679 RID: 5753 RVA: 0x000610C4 File Offset: 0x0005F2C4
			// (set) Token: 0x0600167A RID: 5754 RVA: 0x0000B4C0 File Offset: 0x000096C0
			public unsafe static string resultValueTooltip
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_resultValueTooltip, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_resultValueTooltip, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700063F RID: 1599
			// (get) Token: 0x0600167B RID: 5755 RVA: 0x000610E4 File Offset: 0x0005F2E4
			// (set) Token: 0x0600167C RID: 5756 RVA: 0x0000B4D2 File Offset: 0x000096D2
			public unsafe static string globalDefaultValue
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_globalDefaultValue, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_globalDefaultValue, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000640 RID: 1600
			// (get) Token: 0x0600167D RID: 5757 RVA: 0x00061104 File Offset: 0x0005F304
			// (set) Token: 0x0600167E RID: 5758 RVA: 0x0000B4E4 File Offset: 0x000096E4
			public unsafe static string globalDefaultValueTooltip
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_globalDefaultValueTooltip, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_globalDefaultValueTooltip, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000641 RID: 1601
			// (get) Token: 0x0600167F RID: 5759 RVA: 0x00061124 File Offset: 0x0005F324
			// (set) Token: 0x06001680 RID: 5760 RVA: 0x0000B4F6 File Offset: 0x000096F6
			public unsafe static string qualityLevelValue
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_qualityLevelValue, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_qualityLevelValue, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000642 RID: 1602
			// (get) Token: 0x06001681 RID: 5761 RVA: 0x00061144 File Offset: 0x0005F344
			// (set) Token: 0x06001682 RID: 5762 RVA: 0x0000B508 File Offset: 0x00009708
			public unsafe static string qualityLevelValueTooltip
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_qualityLevelValueTooltip, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_qualityLevelValueTooltip, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000643 RID: 1603
			// (get) Token: 0x06001683 RID: 5763 RVA: 0x00061164 File Offset: 0x0005F364
			// (set) Token: 0x06001684 RID: 5764 RVA: 0x0000B51A File Offset: 0x0000971A
			public unsafe static string global
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_global, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_global, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000644 RID: 1604
			// (get) Token: 0x06001685 RID: 5765 RVA: 0x00061184 File Offset: 0x0005F384
			// (set) Token: 0x06001686 RID: 5766 RVA: 0x0000B52C File Offset: 0x0000972C
			public unsafe static string local
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_local, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_local, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000645 RID: 1605
			// (get) Token: 0x06001687 RID: 5767 RVA: 0x000611A4 File Offset: 0x0005F3A4
			// (set) Token: 0x06001688 RID: 5768 RVA: 0x0000B53E File Offset: 0x0000973E
			public unsafe static string volumeProfile
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_volumeProfile, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.Strings.NativeFieldInfoPtr_volumeProfile, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001050 RID: 4176
			private static readonly IntPtr NativeFieldInfoPtr_none;

			// Token: 0x04001051 RID: 4177
			private static readonly IntPtr NativeFieldInfoPtr_camera;

			// Token: 0x04001052 RID: 4178
			private static readonly IntPtr NativeFieldInfoPtr_parameter;

			// Token: 0x04001053 RID: 4179
			private static readonly IntPtr NativeFieldInfoPtr_component;

			// Token: 0x04001054 RID: 4180
			private static readonly IntPtr NativeFieldInfoPtr_debugViewNotSupported;

			// Token: 0x04001055 RID: 4181
			private static readonly IntPtr NativeFieldInfoPtr_parameterNotOverrided;

			// Token: 0x04001056 RID: 4182
			private static readonly IntPtr NativeFieldInfoPtr_volumeInfo;

			// Token: 0x04001057 RID: 4183
			private static readonly IntPtr NativeFieldInfoPtr_gameObject;

			// Token: 0x04001058 RID: 4184
			private static readonly IntPtr NativeFieldInfoPtr_resultValue;

			// Token: 0x04001059 RID: 4185
			private static readonly IntPtr NativeFieldInfoPtr_resultValueTooltip;

			// Token: 0x0400105A RID: 4186
			private static readonly IntPtr NativeFieldInfoPtr_globalDefaultValue;

			// Token: 0x0400105B RID: 4187
			private static readonly IntPtr NativeFieldInfoPtr_globalDefaultValueTooltip;

			// Token: 0x0400105C RID: 4188
			private static readonly IntPtr NativeFieldInfoPtr_qualityLevelValue;

			// Token: 0x0400105D RID: 4189
			private static readonly IntPtr NativeFieldInfoPtr_qualityLevelValueTooltip;

			// Token: 0x0400105E RID: 4190
			private static readonly IntPtr NativeFieldInfoPtr_global;

			// Token: 0x0400105F RID: 4191
			private static readonly IntPtr NativeFieldInfoPtr_local;

			// Token: 0x04001060 RID: 4192
			private static readonly IntPtr NativeFieldInfoPtr_volumeProfile;
		}

		// Token: 0x0200018B RID: 395
		public static class WidgetFactory : Object
		{
			// Token: 0x06001689 RID: 5769 RVA: 0x000611C4 File Offset: 0x0005F3C4
			// Note: this type is marked as 'beforefieldinit'.
			static WidgetFactory()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr, "WidgetFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr);
				DebugDisplaySettingsVolume.WidgetFactory.NativeFieldInfoPtr_s_EmptyDebugUIValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, "s_EmptyDebugUIValue");
				DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_CreateComponentSelector_Public_Static_EnumField_SettingsPanel_Action_2_Field_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, 100664153);
				DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_CreateCameraSelector_Public_Static_ObjectPopupField_SettingsPanel_Action_2_Field_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, 100664154);
				DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_CreateVolumeParameterWidget_Private_Static_Widget_String_Boolean_VolumeParameter_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, 100664155);
				DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_GetSelectedVolumeComponent_Private_Static_VolumeComponent_VolumeProfile_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, 100664156);
				DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_GetResolutionChain_Private_Static_List_1_VolumeParameterChain_DebugDisplaySettingsVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, 100664157);
				DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_CreateVolumeTable_Public_Static_Table_DebugDisplaySettingsVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, 100664158);
				DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_SetTableColumnVisibility_Private_Static_Void_DebugDisplaySettingsVolume_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, 100664159);
				DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_GenerateTableColumns_Private_Static_Void_Table_DebugDisplaySettingsVolume_List_1_VolumeParameterChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, 100664160);
				DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_GenerateTableRows_Private_Static_Void_Table_List_1_VolumeParameterChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, 100664161);
			}

			// Token: 0x0600168A RID: 5770 RVA: 0x000612B8 File Offset: 0x0005F4B8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 961359, RefRangeEnd = 961360, XrefRangeStart = 961245, XrefRangeEnd = 961359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.EnumField CreateComponentSelector(DebugDisplaySettingsVolume.SettingsPanel panel, Action<DebugUI.Field<int>, int> refresh)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refresh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_CreateComponentSelector_Public_Static_EnumField_SettingsPanel_Action_2_Field_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.EnumField>(intPtr3) : null;
			}

			// Token: 0x0600168B RID: 5771 RVA: 0x00061310 File Offset: 0x0005F510
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 961400, RefRangeEnd = 961401, XrefRangeStart = 961360, XrefRangeEnd = 961400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.ObjectPopupField CreateCameraSelector(DebugDisplaySettingsVolume.SettingsPanel panel, Action<DebugUI.Field<Object>, Object> refresh)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refresh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_CreateCameraSelector_Public_Static_ObjectPopupField_SettingsPanel_Action_2_Field_1_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.ObjectPopupField>(intPtr3) : null;
			}

			// Token: 0x0600168C RID: 5772 RVA: 0x00061368 File Offset: 0x0005F568
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 961408, RefRangeEnd = 961409, XrefRangeStart = 961401, XrefRangeEnd = 961408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateVolumeParameterWidget(string name, bool isResultParameter, VolumeParameter param, Func<bool> isHiddenCallback = null)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isResultParameter;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(param);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(isHiddenCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_CreateVolumeParameterWidget_Private_Static_Widget_String_Boolean_VolumeParameter_Func_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
			}

			// Token: 0x0600168D RID: 5773 RVA: 0x000613E0 File Offset: 0x0005F5E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 961434, RefRangeEnd = 961435, XrefRangeStart = 961409, XrefRangeEnd = 961434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static VolumeComponent GetSelectedVolumeComponent(VolumeProfile profile, Type selectedType)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_GetSelectedVolumeComponent_Private_Static_VolumeComponent_VolumeProfile_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeComponent>(intPtr3) : null;
			}

			// Token: 0x0600168E RID: 5774 RVA: 0x00061438 File Offset: 0x0005F638
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 961496, RefRangeEnd = 961498, XrefRangeStart = 961435, XrefRangeEnd = 961496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static List<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> GetResolutionChain(DebugDisplaySettingsVolume data)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_GetResolutionChain_Private_Static_List_1_VolumeParameterChain_DebugDisplaySettingsVolume_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>>(intPtr3) : null;
				}
			}

			// Token: 0x0600168F RID: 5775 RVA: 0x0006147C File Offset: 0x0005F67C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 961536, RefRangeEnd = 961537, XrefRangeStart = 961498, XrefRangeEnd = 961536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Table CreateVolumeTable(DebugDisplaySettingsVolume data)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_CreateVolumeTable_Public_Static_Table_DebugDisplaySettingsVolume_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Table>(intPtr3) : null;
				}
			}

			// Token: 0x06001690 RID: 5776 RVA: 0x000614C0 File Offset: 0x0005F6C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 961577, RefRangeEnd = 961578, XrefRangeStart = 961537, XrefRangeEnd = 961577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void SetTableColumnVisibility(DebugDisplaySettingsVolume data, DebugUI.Table table)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_SetTableColumnVisibility_Private_Static_Void_DebugDisplaySettingsVolume_Table_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001691 RID: 5777 RVA: 0x00061508 File Offset: 0x0005F708
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 961718, RefRangeEnd = 961719, XrefRangeStart = 961578, XrefRangeEnd = 961718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GenerateTableColumns(DebugUI.Table table, DebugDisplaySettingsVolume data, List<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> resolutionChain)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolutionChain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_GenerateTableColumns_Private_Static_Void_Table_DebugDisplaySettingsVolume_List_1_VolumeParameterChain_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001692 RID: 5778 RVA: 0x00061564 File Offset: 0x0005F764
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 961783, RefRangeEnd = 961784, XrefRangeStart = 961719, XrefRangeEnd = 961783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GenerateTableRows(DebugUI.Table table, List<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> resolutionChain)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolutionChain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.NativeMethodInfoPtr_GenerateTableRows_Private_Static_Void_Table_List_1_VolumeParameterChain_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001693 RID: 5779 RVA: 0x0000B550 File Offset: 0x00009750
			public WidgetFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000646 RID: 1606
			// (get) Token: 0x06001694 RID: 5780 RVA: 0x000615AC File Offset: 0x0005F7AC
			// (set) Token: 0x06001695 RID: 5781 RVA: 0x0000B559 File Offset: 0x00009759
			public unsafe static DebugUI.Value s_EmptyDebugUIValue
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.WidgetFactory.NativeFieldInfoPtr_s_EmptyDebugUIValue, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.Value>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.WidgetFactory.NativeFieldInfoPtr_s_EmptyDebugUIValue, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001061 RID: 4193
			private static readonly IntPtr NativeFieldInfoPtr_s_EmptyDebugUIValue;

			// Token: 0x04001062 RID: 4194
			private static readonly IntPtr NativeMethodInfoPtr_CreateComponentSelector_Public_Static_EnumField_SettingsPanel_Action_2_Field_1_Int32_Int32_0;

			// Token: 0x04001063 RID: 4195
			private static readonly IntPtr NativeMethodInfoPtr_CreateCameraSelector_Public_Static_ObjectPopupField_SettingsPanel_Action_2_Field_1_Object_Object_0;

			// Token: 0x04001064 RID: 4196
			private static readonly IntPtr NativeMethodInfoPtr_CreateVolumeParameterWidget_Private_Static_Widget_String_Boolean_VolumeParameter_Func_1_Boolean_0;

			// Token: 0x04001065 RID: 4197
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectedVolumeComponent_Private_Static_VolumeComponent_VolumeProfile_Type_0;

			// Token: 0x04001066 RID: 4198
			private static readonly IntPtr NativeMethodInfoPtr_GetResolutionChain_Private_Static_List_1_VolumeParameterChain_DebugDisplaySettingsVolume_0;

			// Token: 0x04001067 RID: 4199
			private static readonly IntPtr NativeMethodInfoPtr_CreateVolumeTable_Public_Static_Table_DebugDisplaySettingsVolume_0;

			// Token: 0x04001068 RID: 4200
			private static readonly IntPtr NativeMethodInfoPtr_SetTableColumnVisibility_Private_Static_Void_DebugDisplaySettingsVolume_Table_0;

			// Token: 0x04001069 RID: 4201
			private static readonly IntPtr NativeMethodInfoPtr_GenerateTableColumns_Private_Static_Void_Table_DebugDisplaySettingsVolume_List_1_VolumeParameterChain_0;

			// Token: 0x0400106A RID: 4202
			private static readonly IntPtr NativeMethodInfoPtr_GenerateTableRows_Private_Static_Void_Table_List_1_VolumeParameterChain_0;

			// Token: 0x02000228 RID: 552
			public sealed class VolumeParameterChain : ValueType
			{
				// Token: 0x06001B91 RID: 7057 RVA: 0x00070304 File Offset: 0x0006E504
				// Note: this type is marked as 'beforefieldinit'.
				static VolumeParameterChain()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, "VolumeParameterChain");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.NativeClassPtr);
					DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain.NativeFieldInfoPtr_nameAndTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.NativeClassPtr, "nameAndTooltip");
					DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain.NativeFieldInfoPtr_volumeProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.NativeClassPtr, "volumeProfile");
					DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain.NativeFieldInfoPtr_volumeComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.NativeClassPtr, "volumeComponent");
					DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain.NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.NativeClassPtr, "volume");
				}

				// Token: 0x06001B92 RID: 7058 RVA: 0x0000DCC1 File Offset: 0x0000BEC1
				public VolumeParameterChain(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06001B93 RID: 7059 RVA: 0x0000DCCA File Offset: 0x0000BECA
				public VolumeParameterChain()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.NativeClassPtr))
				{
				}

				// Token: 0x170007C2 RID: 1986
				// (get) Token: 0x06001B94 RID: 7060 RVA: 0x00070380 File Offset: 0x0006E580
				// (set) Token: 0x06001B95 RID: 7061 RVA: 0x0000DCDC File Offset: 0x0000BEDC
				public DebugUI.Widget.NameAndTooltip nameAndTooltip
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain.NativeFieldInfoPtr_nameAndTooltip);
						return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain.NativeFieldInfoPtr_nameAndTooltip), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007C3 RID: 1987
				// (get) Token: 0x06001B96 RID: 7062 RVA: 0x000703B0 File Offset: 0x0006E5B0
				// (set) Token: 0x06001B97 RID: 7063 RVA: 0x0000DD0A File Offset: 0x0000BF0A
				public unsafe VolumeProfile volumeProfile
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain.NativeFieldInfoPtr_volumeProfile);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeProfile>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain.NativeFieldInfoPtr_volumeProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170007C4 RID: 1988
				// (get) Token: 0x06001B98 RID: 7064 RVA: 0x000703E0 File Offset: 0x0006E5E0
				// (set) Token: 0x06001B99 RID: 7065 RVA: 0x0000DD29 File Offset: 0x0000BF29
				public unsafe VolumeComponent volumeComponent
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain.NativeFieldInfoPtr_volumeComponent);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeComponent>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain.NativeFieldInfoPtr_volumeComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170007C5 RID: 1989
				// (get) Token: 0x06001B9A RID: 7066 RVA: 0x00070410 File Offset: 0x0006E610
				// (set) Token: 0x06001B9B RID: 7067 RVA: 0x0000DD48 File Offset: 0x0000BF48
				public unsafe Volume volume
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain.NativeFieldInfoPtr_volume);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Volume>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain.NativeFieldInfoPtr_volume), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001401 RID: 5121
				private static readonly IntPtr NativeFieldInfoPtr_nameAndTooltip;

				// Token: 0x04001402 RID: 5122
				private static readonly IntPtr NativeFieldInfoPtr_volumeProfile;

				// Token: 0x04001403 RID: 5123
				private static readonly IntPtr NativeFieldInfoPtr_volumeComponent;

				// Token: 0x04001404 RID: 5124
				private static readonly IntPtr NativeFieldInfoPtr_volume;
			}

			// Token: 0x02000229 RID: 553
			[ObfuscatedName("UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06001B9C RID: 7068 RVA: 0x00070440 File Offset: 0x0006E640
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c>.NativeClassPtr);
					DebugDisplaySettingsVolume.WidgetFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c>.NativeClassPtr, "<>9");
					DebugDisplaySettingsVolume.WidgetFactory.__c.NativeFieldInfoPtr___9__9_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c>.NativeClassPtr, "<>9__9_2");
					DebugDisplaySettingsVolume.WidgetFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c>.NativeClassPtr, 100664164);
					DebugDisplaySettingsVolume.WidgetFactory.__c.NativeMethodInfoPtr__GenerateTableColumns_b__9_2_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c>.NativeClassPtr, 100664165);
					DebugDisplaySettingsVolume.WidgetFactory.__c.NativeMethodInfoPtr___cctor_b__11_0_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c>.NativeClassPtr, 100664166);
				}

				// Token: 0x06001B9D RID: 7069 RVA: 0x000704D0 File Offset: 0x0006E6D0
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001B9E RID: 7070 RVA: 0x0007050C File Offset: 0x0006E70C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961164, XrefRangeEnd = 961166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Object _GenerateTableColumns_b__9_2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c.NativeMethodInfoPtr__GenerateTableColumns_b__9_2_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x06001B9F RID: 7071 RVA: 0x0007054C File Offset: 0x0006E74C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961166, XrefRangeEnd = 961168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Object __cctor_b__11_0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c.NativeMethodInfoPtr___cctor_b__11_0_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x06001BA0 RID: 7072 RVA: 0x0000DD67 File Offset: 0x0000BF67
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007C6 RID: 1990
				// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x0007058C File Offset: 0x0006E78C
				// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x0000DD70 File Offset: 0x0000BF70
				public unsafe static DebugDisplaySettingsVolume.WidgetFactory.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.WidgetFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsVolume.WidgetFactory.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.WidgetFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170007C7 RID: 1991
				// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x000705B4 File Offset: 0x0006E7B4
				// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x0000DD82 File Offset: 0x0000BF82
				public unsafe static Func<Object> __9__9_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsVolume.WidgetFactory.__c.NativeFieldInfoPtr___9__9_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsVolume.WidgetFactory.__c.NativeFieldInfoPtr___9__9_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001405 RID: 5125
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04001406 RID: 5126
				private static readonly IntPtr NativeFieldInfoPtr___9__9_2;

				// Token: 0x04001407 RID: 5127
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001408 RID: 5128
				private static readonly IntPtr NativeMethodInfoPtr__GenerateTableColumns_b__9_2_Internal_Object_0;

				// Token: 0x04001409 RID: 5129
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__11_0_Internal_Object_0;
			}

			// Token: 0x0200022A RID: 554
			[ObfuscatedName("UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+<>c__DisplayClass0_0")]
			public sealed class __c__DisplayClass0_0 : Object
			{
				// Token: 0x06001BA5 RID: 7077 RVA: 0x000705DC File Offset: 0x0006E7DC
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass0_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass0_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664167);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateComponentSelector_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664168);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateComponentSelector_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664169);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateComponentSelector_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664170);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateComponentSelector_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664171);
				}

				// Token: 0x06001BA6 RID: 7078 RVA: 0x00070680 File Offset: 0x0006E880
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass0_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001BA7 RID: 7079 RVA: 0x000706BC File Offset: 0x0006E8BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961168, XrefRangeEnd = 961173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateComponentSelector_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateComponentSelector_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001BA8 RID: 7080 RVA: 0x000706F8 File Offset: 0x0006E8F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961173, XrefRangeEnd = 961178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateComponentSelector_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateComponentSelector_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001BA9 RID: 7081 RVA: 0x00070738 File Offset: 0x0006E938
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961178, XrefRangeEnd = 961179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateComponentSelector_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateComponentSelector_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001BAA RID: 7082 RVA: 0x00070774 File Offset: 0x0006E974
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961179, XrefRangeEnd = 961180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateComponentSelector_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateComponentSelector_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001BAB RID: 7083 RVA: 0x0000DD94 File Offset: 0x0000BF94
				public __c__DisplayClass0_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007C8 RID: 1992
				// (get) Token: 0x06001BAC RID: 7084 RVA: 0x000707B4 File Offset: 0x0006E9B4
				// (set) Token: 0x06001BAD RID: 7085 RVA: 0x0000DD9D File Offset: 0x0000BF9D
				public unsafe DebugDisplaySettingsVolume.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsVolume.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400140A RID: 5130
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x0400140B RID: 5131
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400140C RID: 5132
				private static readonly IntPtr NativeMethodInfoPtr__CreateComponentSelector_b__0_Internal_Int32_0;

				// Token: 0x0400140D RID: 5133
				private static readonly IntPtr NativeMethodInfoPtr__CreateComponentSelector_b__1_Internal_Void_Int32_0;

				// Token: 0x0400140E RID: 5134
				private static readonly IntPtr NativeMethodInfoPtr__CreateComponentSelector_b__2_Internal_Int32_0;

				// Token: 0x0400140F RID: 5135
				private static readonly IntPtr NativeMethodInfoPtr__CreateComponentSelector_b__3_Internal_Void_Int32_0;
			}

			// Token: 0x0200022B RID: 555
			[ObfuscatedName("UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+<>c__DisplayClass1_0")]
			public sealed class __c__DisplayClass1_0 : Object
			{
				// Token: 0x06001BAE RID: 7086 RVA: 0x000707E4 File Offset: 0x0006E9E4
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass1_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass1_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664172);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateCameraSelector_b__0_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664173);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateCameraSelector_b__1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664174);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateCameraSelector_b__2_Internal_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664175);
				}

				// Token: 0x06001BAF RID: 7087 RVA: 0x00070874 File Offset: 0x0006EA74
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass1_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001BB0 RID: 7088 RVA: 0x000708B0 File Offset: 0x0006EAB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961180, XrefRangeEnd = 961185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Object _CreateCameraSelector_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateCameraSelector_b__0_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x06001BB1 RID: 7089 RVA: 0x000708F0 File Offset: 0x0006EAF0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961185, XrefRangeEnd = 961200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateCameraSelector_b__1(Object value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateCameraSelector_b__1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001BB2 RID: 7090 RVA: 0x00070934 File Offset: 0x0006EB34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961200, XrefRangeEnd = 961205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerable<Object> _CreateCameraSelector_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateCameraSelector_b__2_Internal_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
				}

				// Token: 0x06001BB3 RID: 7091 RVA: 0x0000DDBC File Offset: 0x0000BFBC
				public __c__DisplayClass1_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007C9 RID: 1993
				// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x00070974 File Offset: 0x0006EB74
				// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x0000DDC5 File Offset: 0x0000BFC5
				public unsafe DebugDisplaySettingsVolume.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsVolume.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001410 RID: 5136
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001411 RID: 5137
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001412 RID: 5138
				private static readonly IntPtr NativeMethodInfoPtr__CreateCameraSelector_b__0_Internal_Object_0;

				// Token: 0x04001413 RID: 5139
				private static readonly IntPtr NativeMethodInfoPtr__CreateCameraSelector_b__1_Internal_Void_Object_0;

				// Token: 0x04001414 RID: 5140
				private static readonly IntPtr NativeMethodInfoPtr__CreateCameraSelector_b__2_Internal_IEnumerable_1_Object_0;
			}

			// Token: 0x0200022C RID: 556
			[ObfuscatedName("UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+<>c__DisplayClass7_0")]
			public sealed class __c__DisplayClass7_0 : Object
			{
				// Token: 0x06001BB6 RID: 7094 RVA: 0x000709A4 File Offset: 0x0006EBA4
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass7_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass7_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, "timer");
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_refreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, "refreshRate");
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, "data");
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, "table");
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_volumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, "volumes");
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, 100664176);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__CreateVolumeTable_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, 100664177);
				}

				// Token: 0x06001BB7 RID: 7095 RVA: 0x00070A5C File Offset: 0x0006EC5C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass7_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001BB8 RID: 7096 RVA: 0x00070A98 File Offset: 0x0006EC98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961205, XrefRangeEnd = 961229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _CreateVolumeTable_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__CreateVolumeTable_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001BB9 RID: 7097 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
				public __c__DisplayClass7_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007CA RID: 1994
				// (get) Token: 0x06001BBA RID: 7098 RVA: 0x00070AD4 File Offset: 0x0006ECD4
				// (set) Token: 0x06001BBB RID: 7099 RVA: 0x0000DDED File Offset: 0x0000BFED
				public unsafe float timer
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_timer);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_timer)) = value;
					}
				}

				// Token: 0x170007CB RID: 1995
				// (get) Token: 0x06001BBC RID: 7100 RVA: 0x00070AFC File Offset: 0x0006ECFC
				// (set) Token: 0x06001BBD RID: 7101 RVA: 0x0000DE08 File Offset: 0x0000C008
				public unsafe float refreshRate
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_refreshRate);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_refreshRate)) = value;
					}
				}

				// Token: 0x170007CC RID: 1996
				// (get) Token: 0x06001BBE RID: 7102 RVA: 0x00070B24 File Offset: 0x0006ED24
				// (set) Token: 0x06001BBF RID: 7103 RVA: 0x0000DE23 File Offset: 0x0000C023
				public unsafe DebugDisplaySettingsVolume data
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_data);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsVolume>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170007CD RID: 1997
				// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x00070B54 File Offset: 0x0006ED54
				// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x0000DE42 File Offset: 0x0000C042
				public unsafe DebugUI.Table table
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_table);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.Table>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_table), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170007CE RID: 1998
				// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00070B84 File Offset: 0x0006ED84
				// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x0000DE61 File Offset: 0x0000C061
				public unsafe Il2CppReferenceArray<Volume> volumes
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_volumes);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Volume>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_volumes), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001415 RID: 5141
				private static readonly IntPtr NativeFieldInfoPtr_timer;

				// Token: 0x04001416 RID: 5142
				private static readonly IntPtr NativeFieldInfoPtr_refreshRate;

				// Token: 0x04001417 RID: 5143
				private static readonly IntPtr NativeFieldInfoPtr_data;

				// Token: 0x04001418 RID: 5144
				private static readonly IntPtr NativeFieldInfoPtr_table;

				// Token: 0x04001419 RID: 5145
				private static readonly IntPtr NativeFieldInfoPtr_volumes;

				// Token: 0x0400141A RID: 5146
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400141B RID: 5147
				private static readonly IntPtr NativeMethodInfoPtr__CreateVolumeTable_b__0_Internal_Boolean_0;
			}

			// Token: 0x0200022D RID: 557
			[ObfuscatedName("UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+<>c__DisplayClass9_0")]
			public sealed class __c__DisplayClass9_0 : Object
			{
				// Token: 0x06001BC4 RID: 7108 RVA: 0x00070BB4 File Offset: 0x0006EDB4
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass9_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass9_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr, "data");
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr, 100664178);
				}

				// Token: 0x06001BC5 RID: 7109 RVA: 0x00070C08 File Offset: 0x0006EE08
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass9_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001BC6 RID: 7110 RVA: 0x0000DE80 File Offset: 0x0000C080
				public __c__DisplayClass9_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007CF RID: 1999
				// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x00070C44 File Offset: 0x0006EE44
				// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x0000DE89 File Offset: 0x0000C089
				public unsafe DebugDisplaySettingsVolume data
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_0.NativeFieldInfoPtr_data);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsVolume>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400141C RID: 5148
				private static readonly IntPtr NativeFieldInfoPtr_data;

				// Token: 0x0400141D RID: 5149
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}

			// Token: 0x0200022E RID: 558
			[ObfuscatedName("UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+<>c__DisplayClass9_1")]
			public sealed class __c__DisplayClass9_1 : Object
			{
				// Token: 0x06001BC9 RID: 7113 RVA: 0x00070C74 File Offset: 0x0006EE74
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass9_1()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass9_1");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1>.NativeClassPtr);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeFieldInfoPtr_chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1>.NativeClassPtr, "chain");
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1>.NativeClassPtr, "CS$<>8__locals1");
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1>.NativeClassPtr, 100664179);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeMethodInfoPtr__GenerateTableColumns_b__0_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1>.NativeClassPtr, 100664180);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeMethodInfoPtr__GenerateTableColumns_b__1_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1>.NativeClassPtr, 100664181);
					DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeMethodInfoPtr__GenerateTableColumns_b__3_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1>.NativeClassPtr, 100664182);
				}

				// Token: 0x06001BCA RID: 7114 RVA: 0x00070D18 File Offset: 0x0006EF18
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass9_1()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001BCB RID: 7115 RVA: 0x00070D54 File Offset: 0x0006EF54
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961229, XrefRangeEnd = 961245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Object _GenerateTableColumns_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeMethodInfoPtr__GenerateTableColumns_b__0_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x06001BCC RID: 7116 RVA: 0x00070D94 File Offset: 0x0006EF94
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Object _GenerateTableColumns_b__1()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeMethodInfoPtr__GenerateTableColumns_b__1_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x06001BCD RID: 7117 RVA: 0x00070DD4 File Offset: 0x0006EFD4
				[CallerCount(0)]
				public unsafe Object _GenerateTableColumns_b__3()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeMethodInfoPtr__GenerateTableColumns_b__3_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x06001BCE RID: 7118 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
				public __c__DisplayClass9_1(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007D0 RID: 2000
				// (get) Token: 0x06001BCF RID: 7119 RVA: 0x00070E14 File Offset: 0x0006F014
				// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x0000DEB1 File Offset: 0x0000C0B1
				public DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain chain
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeFieldInfoPtr_chain);
						return new DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeFieldInfoPtr_chain), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170007D1 RID: 2001
				// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x00070E44 File Offset: 0x0006F044
				// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x0000DEDF File Offset: 0x0000C0DF
				public unsafe DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_0 field_Public___c__DisplayClass9_0_0
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.WidgetFactory.__c__DisplayClass9_1.NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400141E RID: 5150
				private static readonly IntPtr NativeFieldInfoPtr_chain;

				// Token: 0x0400141F RID: 5151
				private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0;

				// Token: 0x04001420 RID: 5152
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001421 RID: 5153
				private static readonly IntPtr NativeMethodInfoPtr__GenerateTableColumns_b__0_Internal_Object_0;

				// Token: 0x04001422 RID: 5154
				private static readonly IntPtr NativeMethodInfoPtr__GenerateTableColumns_b__1_Internal_Object_0;

				// Token: 0x04001423 RID: 5155
				private static readonly IntPtr NativeMethodInfoPtr__GenerateTableColumns_b__3_Internal_Object_0;
			}
		}

		// Token: 0x0200018C RID: 396
		public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsVolume>
		{
			// Token: 0x06001696 RID: 5782 RVA: 0x000615D4 File Offset: 0x0005F7D4
			// Note: this type is marked as 'beforefieldinit'.
			static SettingsPanel()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsVolume.SettingsPanel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsVolume>.NativeClassPtr, "SettingsPanel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsVolume.SettingsPanel>.NativeClassPtr);
				DebugDisplaySettingsVolume.SettingsPanel.NativeFieldInfoPtr_m_VolumeTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsVolume.SettingsPanel>.NativeClassPtr, "m_VolumeTable");
				DebugDisplaySettingsVolume.SettingsPanel.NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.SettingsPanel>.NativeClassPtr, 100664183);
				DebugDisplaySettingsVolume.SettingsPanel.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.SettingsPanel>.NativeClassPtr, 100664184);
				DebugDisplaySettingsVolume.SettingsPanel.NativeMethodInfoPtr___ctor_b__0_0_Private_Void_Field_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.SettingsPanel>.NativeClassPtr, 100664185);
				DebugDisplaySettingsVolume.SettingsPanel.NativeMethodInfoPtr___ctor_b__0_1_Private_Void_Field_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsVolume.SettingsPanel>.NativeClassPtr, 100664186);
			}

			// Token: 0x06001697 RID: 5783 RVA: 0x00061664 File Offset: 0x0005F864
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 961944, RefRangeEnd = 961945, XrefRangeStart = 961784, XrefRangeEnd = 961944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SettingsPanel(DebugDisplaySettingsVolume data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsVolume.SettingsPanel>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.SettingsPanel.NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001698 RID: 5784 RVA: 0x000616B0 File Offset: 0x0005F8B0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 961979, RefRangeEnd = 961981, XrefRangeStart = 961945, XrefRangeEnd = 961979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Refresh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.SettingsPanel.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001699 RID: 5785 RVA: 0x000616E4 File Offset: 0x0005F8E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961981, XrefRangeEnd = 961982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__0_0(DebugUI.Field<int> _, int __)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref __;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.SettingsPanel.NativeMethodInfoPtr___ctor_b__0_0_Private_Void_Field_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600169A RID: 5786 RVA: 0x00061734 File Offset: 0x0005F934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__0_1(DebugUI.Field<Object> _, Object __)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsVolume.SettingsPanel.NativeMethodInfoPtr___ctor_b__0_1_Private_Void_Field_1_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600169B RID: 5787 RVA: 0x0000B56B File Offset: 0x0000976B
			public SettingsPanel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000647 RID: 1607
			// (get) Token: 0x0600169C RID: 5788 RVA: 0x00061788 File Offset: 0x0005F988
			// (set) Token: 0x0600169D RID: 5789 RVA: 0x0000B574 File Offset: 0x00009774
			public unsafe DebugUI.Table m_VolumeTable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.SettingsPanel.NativeFieldInfoPtr_m_VolumeTable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.Table>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsVolume.SettingsPanel.NativeFieldInfoPtr_m_VolumeTable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400106B RID: 4203
			private static readonly IntPtr NativeFieldInfoPtr_m_VolumeTable;

			// Token: 0x0400106C RID: 4204
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsVolume_0;

			// Token: 0x0400106D RID: 4205
			private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

			// Token: 0x0400106E RID: 4206
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_0_Private_Void_Field_1_Int32_Int32_0;

			// Token: 0x0400106F RID: 4207
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_1_Private_Void_Field_1_Object_Object_0;
		}
	}
}
