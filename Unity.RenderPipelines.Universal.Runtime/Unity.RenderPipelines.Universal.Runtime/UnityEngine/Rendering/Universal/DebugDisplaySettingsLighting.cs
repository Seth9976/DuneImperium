using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000057 RID: 87
	public class DebugDisplaySettingsLighting : Object
	{
		// Token: 0x06000714 RID: 1812 RVA: 0x0002DFEC File Offset: 0x0002C1EC
		// Note: this type is marked as 'beforefieldinit'.
		static DebugDisplaySettingsLighting()
		{
			Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DebugDisplaySettingsLighting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr);
			DebugDisplaySettingsLighting.NativeFieldInfoPtr__lightingDebugMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, "<lightingDebugMode>k__BackingField");
			DebugDisplaySettingsLighting.NativeFieldInfoPtr__lightingFeatureFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, "<lightingFeatureFlags>k__BackingField");
			DebugDisplaySettingsLighting.NativeFieldInfoPtr__hdrDebugMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, "<hdrDebugMode>k__BackingField");
			DebugDisplaySettingsLighting.NativeMethodInfoPtr_get_lightingDebugMode_Public_get_DebugLightingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, 100664131);
			DebugDisplaySettingsLighting.NativeMethodInfoPtr_set_lightingDebugMode_Public_set_Void_DebugLightingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, 100664132);
			DebugDisplaySettingsLighting.NativeMethodInfoPtr_get_lightingFeatureFlags_Public_get_DebugLightingFeatureFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, 100664133);
			DebugDisplaySettingsLighting.NativeMethodInfoPtr_set_lightingFeatureFlags_Public_set_Void_DebugLightingFeatureFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, 100664134);
			DebugDisplaySettingsLighting.NativeMethodInfoPtr_get_hdrDebugMode_Public_get_HDRDebugMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, 100664135);
			DebugDisplaySettingsLighting.NativeMethodInfoPtr_set_hdrDebugMode_Public_set_Void_HDRDebugMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, 100664136);
			DebugDisplaySettingsLighting.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, 100664137);
			DebugDisplaySettingsLighting.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, 100664138);
			DebugDisplaySettingsLighting.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, 100664139);
			DebugDisplaySettingsLighting.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, 100664140);
			DebugDisplaySettingsLighting.NativeMethodInfoPtr_UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel_Private_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, 100664141);
			DebugDisplaySettingsLighting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, 100664142);
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x0002E148 File Offset: 0x0002C348
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x0002E184 File Offset: 0x0002C384
		public unsafe DebugLightingMode lightingDebugMode
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.NativeMethodInfoPtr_get_lightingDebugMode_Public_get_DebugLightingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.NativeMethodInfoPtr_set_lightingDebugMode_Public_set_Void_DebugLightingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x0002E1C4 File Offset: 0x0002C3C4
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x0002E200 File Offset: 0x0002C400
		public unsafe DebugLightingFeatureFlags lightingFeatureFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.NativeMethodInfoPtr_get_lightingFeatureFlags_Public_get_DebugLightingFeatureFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.NativeMethodInfoPtr_set_lightingFeatureFlags_Public_set_Void_DebugLightingFeatureFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x0002E240 File Offset: 0x0002C440
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x0002E27C File Offset: 0x0002C47C
		public unsafe HDRDebugMode hdrDebugMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.NativeMethodInfoPtr_get_hdrDebugMode_Public_get_HDRDebugMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.NativeMethodInfoPtr_set_hdrDebugMode_Public_set_Void_HDRDebugMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x0002E2BC File Offset: 0x0002C4BC
		public unsafe virtual bool AreAnySettingsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x0002E2F8 File Offset: 0x0002C4F8
		public unsafe virtual bool IsPostProcessingAllowed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x0002E334 File Offset: 0x0002C534
		public unsafe virtual bool IsLightingActive
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0002E370 File Offset: 0x0002C570
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0002E3BC File Offset: 0x0002C5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603923, XrefRangeEnd = 603949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDebugDisplaySettingsPanelDisposable UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.NativeMethodInfoPtr_UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel_Private_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDebugDisplaySettingsPanelDisposable>(intPtr3) : null;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0002E3FC File Offset: 0x0002C5FC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugDisplaySettingsLighting()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000051BF File Offset: 0x000033BF
		public DebugDisplaySettingsLighting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x0002E438 File Offset: 0x0002C638
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x000051C8 File Offset: 0x000033C8
		public unsafe DebugLightingMode _lightingDebugMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsLighting.NativeFieldInfoPtr__lightingDebugMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsLighting.NativeFieldInfoPtr__lightingDebugMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0002E460 File Offset: 0x0002C660
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x000051E3 File Offset: 0x000033E3
		public unsafe DebugLightingFeatureFlags _lightingFeatureFlags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsLighting.NativeFieldInfoPtr__lightingFeatureFlags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsLighting.NativeFieldInfoPtr__lightingFeatureFlags_k__BackingField)) = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x0002E488 File Offset: 0x0002C688
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x000051FE File Offset: 0x000033FE
		public unsafe HDRDebugMode _hdrDebugMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsLighting.NativeFieldInfoPtr__hdrDebugMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsLighting.NativeFieldInfoPtr__hdrDebugMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeFieldInfoPtr__lightingDebugMode_k__BackingField;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeFieldInfoPtr__lightingFeatureFlags_k__BackingField;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr__hdrDebugMode_k__BackingField;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_get_lightingDebugMode_Public_get_DebugLightingMode_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_set_lightingDebugMode_Public_set_Void_DebugLightingMode_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_get_lightingFeatureFlags_Public_get_DebugLightingFeatureFlags_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_set_lightingFeatureFlags_Public_set_Void_DebugLightingFeatureFlags_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_get_hdrDebugMode_Public_get_HDRDebugMode_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_set_hdrDebugMode_Public_set_Void_HDRDebugMode_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel_Private_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200016E RID: 366
		public static class Strings : Object
		{
			// Token: 0x06001C0B RID: 7179 RVA: 0x00073C1C File Offset: 0x00071E1C
			// Note: this type is marked as 'beforefieldinit'.
			static Strings()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsLighting.Strings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, "Strings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsLighting.Strings>.NativeClassPtr);
				DebugDisplaySettingsLighting.Strings.NativeFieldInfoPtr_LightingDebugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsLighting.Strings>.NativeClassPtr, "LightingDebugMode");
				DebugDisplaySettingsLighting.Strings.NativeFieldInfoPtr_LightingFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsLighting.Strings>.NativeClassPtr, "LightingFeatures");
				DebugDisplaySettingsLighting.Strings.NativeFieldInfoPtr_HDRDebugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsLighting.Strings>.NativeClassPtr, "HDRDebugMode");
			}

			// Token: 0x06001C0C RID: 7180 RVA: 0x0000FF17 File Offset: 0x0000E117
			public Strings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A0F RID: 2575
			// (get) Token: 0x06001C0D RID: 7181 RVA: 0x00073C84 File Offset: 0x00071E84
			// (set) Token: 0x06001C0E RID: 7182 RVA: 0x0000FF20 File Offset: 0x0000E120
			public unsafe static DebugUI.Widget.NameAndTooltip LightingDebugMode
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsLighting.Strings.NativeFieldInfoPtr_LightingDebugMode, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsLighting.Strings.NativeFieldInfoPtr_LightingDebugMode, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A10 RID: 2576
			// (get) Token: 0x06001C0F RID: 7183 RVA: 0x00073CC0 File Offset: 0x00071EC0
			// (set) Token: 0x06001C10 RID: 7184 RVA: 0x0000FF37 File Offset: 0x0000E137
			public unsafe static DebugUI.Widget.NameAndTooltip LightingFeatures
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsLighting.Strings.NativeFieldInfoPtr_LightingFeatures, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsLighting.Strings.NativeFieldInfoPtr_LightingFeatures, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A11 RID: 2577
			// (get) Token: 0x06001C11 RID: 7185 RVA: 0x00073CFC File Offset: 0x00071EFC
			// (set) Token: 0x06001C12 RID: 7186 RVA: 0x0000FF4E File Offset: 0x0000E14E
			public unsafe static DebugUI.Widget.NameAndTooltip HDRDebugMode
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsLighting.Strings.NativeFieldInfoPtr_HDRDebugMode, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsLighting.Strings.NativeFieldInfoPtr_HDRDebugMode, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x04001468 RID: 5224
			private static readonly IntPtr NativeFieldInfoPtr_LightingDebugMode;

			// Token: 0x04001469 RID: 5225
			private static readonly IntPtr NativeFieldInfoPtr_LightingFeatures;

			// Token: 0x0400146A RID: 5226
			private static readonly IntPtr NativeFieldInfoPtr_HDRDebugMode;
		}

		// Token: 0x0200016F RID: 367
		public static class WidgetFactory : Object
		{
			// Token: 0x06001C13 RID: 7187 RVA: 0x00073D38 File Offset: 0x00071F38
			// Note: this type is marked as 'beforefieldinit'.
			static WidgetFactory()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, "WidgetFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory>.NativeClassPtr);
				DebugDisplaySettingsLighting.WidgetFactory.NativeMethodInfoPtr_CreateLightingDebugMode_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory>.NativeClassPtr, 100664144);
				DebugDisplaySettingsLighting.WidgetFactory.NativeMethodInfoPtr_CreateLightingFeatures_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory>.NativeClassPtr, 100664145);
				DebugDisplaySettingsLighting.WidgetFactory.NativeMethodInfoPtr_CreateHDRDebugMode_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory>.NativeClassPtr, 100664146);
			}

			// Token: 0x06001C14 RID: 7188 RVA: 0x00073DA0 File Offset: 0x00071FA0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 603807, RefRangeEnd = 603809, XrefRangeStart = 603758, XrefRangeEnd = 603807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateLightingDebugMode(DebugDisplaySettingsLighting.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.NativeMethodInfoPtr_CreateLightingDebugMode_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C15 RID: 7189 RVA: 0x00073DE4 File Offset: 0x00071FE4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 603846, RefRangeEnd = 603848, XrefRangeStart = 603809, XrefRangeEnd = 603846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateLightingFeatures(DebugDisplaySettingsLighting.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.NativeMethodInfoPtr_CreateLightingFeatures_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C16 RID: 7190 RVA: 0x00073E28 File Offset: 0x00072028
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 603897, RefRangeEnd = 603899, XrefRangeStart = 603848, XrefRangeEnd = 603897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateHDRDebugMode(DebugDisplaySettingsLighting.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.NativeMethodInfoPtr_CreateHDRDebugMode_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C17 RID: 7191 RVA: 0x0000FF65 File Offset: 0x0000E165
			public WidgetFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400146B RID: 5227
			private static readonly IntPtr NativeMethodInfoPtr_CreateLightingDebugMode_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x0400146C RID: 5228
			private static readonly IntPtr NativeMethodInfoPtr_CreateLightingFeatures_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x0400146D RID: 5229
			private static readonly IntPtr NativeMethodInfoPtr_CreateHDRDebugMode_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x0200021D RID: 541
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+WidgetFactory+<>c__DisplayClass0_0")]
			public sealed class __c__DisplayClass0_0 : Object
			{
				// Token: 0x060023D4 RID: 9172 RVA: 0x0008671C File Offset: 0x0008491C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass0_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass0_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr);
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664147);
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateLightingDebugMode_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664148);
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateLightingDebugMode_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664149);
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateLightingDebugMode_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664150);
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateLightingDebugMode_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664151);
				}

				// Token: 0x060023D5 RID: 9173 RVA: 0x000867C0 File Offset: 0x000849C0
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass0_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023D6 RID: 9174 RVA: 0x000867FC File Offset: 0x000849FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603742, XrefRangeEnd = 603743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateLightingDebugMode_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateLightingDebugMode_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060023D7 RID: 9175 RVA: 0x00086838 File Offset: 0x00084A38
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603743, XrefRangeEnd = 603744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateLightingDebugMode_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateLightingDebugMode_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023D8 RID: 9176 RVA: 0x00086878 File Offset: 0x00084A78
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603744, XrefRangeEnd = 603745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateLightingDebugMode_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateLightingDebugMode_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060023D9 RID: 9177 RVA: 0x000868B4 File Offset: 0x00084AB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603745, XrefRangeEnd = 603746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateLightingDebugMode_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateLightingDebugMode_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023DA RID: 9178 RVA: 0x00014A0A File Offset: 0x00012C0A
				public __c__DisplayClass0_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CE3 RID: 3299
				// (get) Token: 0x060023DB RID: 9179 RVA: 0x000868F4 File Offset: 0x00084AF4
				// (set) Token: 0x060023DC RID: 9180 RVA: 0x00014A13 File Offset: 0x00012C13
				public unsafe DebugDisplaySettingsLighting.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsLighting.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040018F2 RID: 6386
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x040018F3 RID: 6387
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040018F4 RID: 6388
				private static readonly IntPtr NativeMethodInfoPtr__CreateLightingDebugMode_b__0_Internal_Int32_0;

				// Token: 0x040018F5 RID: 6389
				private static readonly IntPtr NativeMethodInfoPtr__CreateLightingDebugMode_b__1_Internal_Void_Int32_0;

				// Token: 0x040018F6 RID: 6390
				private static readonly IntPtr NativeMethodInfoPtr__CreateLightingDebugMode_b__2_Internal_Int32_0;

				// Token: 0x040018F7 RID: 6391
				private static readonly IntPtr NativeMethodInfoPtr__CreateLightingDebugMode_b__3_Internal_Void_Int32_0;
			}

			// Token: 0x0200021E RID: 542
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+WidgetFactory+<>c__DisplayClass1_0")]
			public sealed class __c__DisplayClass1_0 : Object
			{
				// Token: 0x060023DD RID: 9181 RVA: 0x00086924 File Offset: 0x00084B24
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass1_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass1_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr);
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664152);
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateLightingFeatures_b__0_Internal_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664153);
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateLightingFeatures_b__1_Internal_Void_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664154);
				}

				// Token: 0x060023DE RID: 9182 RVA: 0x000869A0 File Offset: 0x00084BA0
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass1_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023DF RID: 9183 RVA: 0x000869DC File Offset: 0x00084BDC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603746, XrefRangeEnd = 603750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Enum _CreateLightingFeatures_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateLightingFeatures_b__0_Internal_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060023E0 RID: 9184 RVA: 0x00086A18 File Offset: 0x00084C18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603750, XrefRangeEnd = 603754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateLightingFeatures_b__1(Enum value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateLightingFeatures_b__1_Internal_Void_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023E1 RID: 9185 RVA: 0x00014A32 File Offset: 0x00012C32
				public __c__DisplayClass1_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CE4 RID: 3300
				// (get) Token: 0x060023E2 RID: 9186 RVA: 0x00086A58 File Offset: 0x00084C58
				// (set) Token: 0x060023E3 RID: 9187 RVA: 0x00014A3B File Offset: 0x00012C3B
				public unsafe DebugDisplaySettingsLighting.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsLighting.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040018F8 RID: 6392
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x040018F9 RID: 6393
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040018FA RID: 6394
				private static readonly IntPtr NativeMethodInfoPtr__CreateLightingFeatures_b__0_Internal_Enum_0;

				// Token: 0x040018FB RID: 6395
				private static readonly IntPtr NativeMethodInfoPtr__CreateLightingFeatures_b__1_Internal_Void_Enum_0;
			}

			// Token: 0x0200021F RID: 543
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+WidgetFactory+<>c__DisplayClass2_0")]
			public sealed class __c__DisplayClass2_0 : Object
			{
				// Token: 0x060023E4 RID: 9188 RVA: 0x00086A88 File Offset: 0x00084C88
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass2_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass2_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr);
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664155);
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateHDRDebugMode_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664156);
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateHDRDebugMode_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664157);
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateHDRDebugMode_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664158);
					DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateHDRDebugMode_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664159);
				}

				// Token: 0x060023E5 RID: 9189 RVA: 0x00086B2C File Offset: 0x00084D2C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass2_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023E6 RID: 9190 RVA: 0x00086B68 File Offset: 0x00084D68
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603754, XrefRangeEnd = 603755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateHDRDebugMode_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateHDRDebugMode_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060023E7 RID: 9191 RVA: 0x00086BA4 File Offset: 0x00084DA4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603755, XrefRangeEnd = 603756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateHDRDebugMode_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateHDRDebugMode_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023E8 RID: 9192 RVA: 0x00086BE4 File Offset: 0x00084DE4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603756, XrefRangeEnd = 603757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateHDRDebugMode_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateHDRDebugMode_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060023E9 RID: 9193 RVA: 0x00086C20 File Offset: 0x00084E20
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603757, XrefRangeEnd = 603758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateHDRDebugMode_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateHDRDebugMode_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023EA RID: 9194 RVA: 0x00014A5A File Offset: 0x00012C5A
				public __c__DisplayClass2_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CE5 RID: 3301
				// (get) Token: 0x060023EB RID: 9195 RVA: 0x00086C60 File Offset: 0x00084E60
				// (set) Token: 0x060023EC RID: 9196 RVA: 0x00014A63 File Offset: 0x00012C63
				public unsafe DebugDisplaySettingsLighting.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsLighting.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsLighting.WidgetFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040018FC RID: 6396
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x040018FD RID: 6397
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040018FE RID: 6398
				private static readonly IntPtr NativeMethodInfoPtr__CreateHDRDebugMode_b__0_Internal_Int32_0;

				// Token: 0x040018FF RID: 6399
				private static readonly IntPtr NativeMethodInfoPtr__CreateHDRDebugMode_b__1_Internal_Void_Int32_0;

				// Token: 0x04001900 RID: 6400
				private static readonly IntPtr NativeMethodInfoPtr__CreateHDRDebugMode_b__2_Internal_Int32_0;

				// Token: 0x04001901 RID: 6401
				private static readonly IntPtr NativeMethodInfoPtr__CreateHDRDebugMode_b__3_Internal_Void_Int32_0;
			}
		}

		// Token: 0x02000170 RID: 368
		public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsLighting>
		{
			// Token: 0x06001C18 RID: 7192 RVA: 0x0000FF6E File Offset: 0x0000E16E
			// Note: this type is marked as 'beforefieldinit'.
			static SettingsPanel()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsLighting.SettingsPanel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsLighting>.NativeClassPtr, "SettingsPanel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsLighting.SettingsPanel>.NativeClassPtr);
				DebugDisplaySettingsLighting.SettingsPanel.NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsLighting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsLighting.SettingsPanel>.NativeClassPtr, 100664160);
			}

			// Token: 0x06001C19 RID: 7193 RVA: 0x00073E6C File Offset: 0x0007206C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603899, XrefRangeEnd = 603923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SettingsPanel(DebugDisplaySettingsLighting data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsLighting.SettingsPanel>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsLighting.SettingsPanel.NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsLighting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C1A RID: 7194 RVA: 0x0000FFA2 File Offset: 0x0000E1A2
			public SettingsPanel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400146E RID: 5230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsLighting_0;
		}
	}
}
