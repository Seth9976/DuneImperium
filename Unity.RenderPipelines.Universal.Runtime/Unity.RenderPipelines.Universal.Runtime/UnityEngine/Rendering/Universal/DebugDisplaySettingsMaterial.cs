using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000058 RID: 88
	public class DebugDisplaySettingsMaterial : Object
	{
		// Token: 0x06000728 RID: 1832 RVA: 0x0002E4B0 File Offset: 0x0002C6B0
		// Note: this type is marked as 'beforefieldinit'.
		static DebugDisplaySettingsMaterial()
		{
			Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DebugDisplaySettingsMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr);
			DebugDisplaySettingsMaterial.NativeFieldInfoPtr_m_AlbedoDebugValidationPresetData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "m_AlbedoDebugValidationPresetData");
			DebugDisplaySettingsMaterial.NativeFieldInfoPtr_m_AlbedoValidationPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "m_AlbedoValidationPreset");
			DebugDisplaySettingsMaterial.NativeFieldInfoPtr__albedoMinLuminance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "<albedoMinLuminance>k__BackingField");
			DebugDisplaySettingsMaterial.NativeFieldInfoPtr__albedoMaxLuminance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "<albedoMaxLuminance>k__BackingField");
			DebugDisplaySettingsMaterial.NativeFieldInfoPtr_m_AlbedoHueTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "m_AlbedoHueTolerance");
			DebugDisplaySettingsMaterial.NativeFieldInfoPtr_m_AlbedoSaturationTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "m_AlbedoSaturationTolerance");
			DebugDisplaySettingsMaterial.NativeFieldInfoPtr__albedoCompareColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "<albedoCompareColor>k__BackingField");
			DebugDisplaySettingsMaterial.NativeFieldInfoPtr__metallicMinValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "<metallicMinValue>k__BackingField");
			DebugDisplaySettingsMaterial.NativeFieldInfoPtr__metallicMaxValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "<metallicMaxValue>k__BackingField");
			DebugDisplaySettingsMaterial.NativeFieldInfoPtr__materialValidationMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "<materialValidationMode>k__BackingField");
			DebugDisplaySettingsMaterial.NativeFieldInfoPtr__materialDebugMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "<materialDebugMode>k__BackingField");
			DebugDisplaySettingsMaterial.NativeFieldInfoPtr__vertexAttributeDebugMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "<vertexAttributeDebugMode>k__BackingField");
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_albedoValidationPreset_Public_get_AlbedoDebugValidationPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664161);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_albedoValidationPreset_Public_set_Void_AlbedoDebugValidationPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664162);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_albedoMinLuminance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664163);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_albedoMinLuminance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664164);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_albedoMaxLuminance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664165);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_albedoMaxLuminance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664166);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_albedoHueTolerance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664167);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_albedoHueTolerance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664168);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_albedoSaturationTolerance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664169);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_albedoSaturationTolerance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664170);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_albedoCompareColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664171);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_albedoCompareColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664172);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_metallicMinValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664173);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_metallicMinValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664174);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_metallicMaxValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664175);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_metallicMaxValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664176);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_materialValidationMode_Public_get_DebugMaterialValidationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664177);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_materialValidationMode_Public_set_Void_DebugMaterialValidationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664178);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_materialDebugMode_Public_get_DebugMaterialMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664179);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_materialDebugMode_Public_set_Void_DebugMaterialMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664180);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_vertexAttributeDebugMode_Public_get_DebugVertexAttributeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664181);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_vertexAttributeDebugMode_Public_set_Void_DebugVertexAttributeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664182);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664183);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664184);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664185);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664186);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr_UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel_Private_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664187);
			DebugDisplaySettingsMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, 100664188);
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x0002E800 File Offset: 0x0002CA00
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x0002E83C File Offset: 0x0002CA3C
		public unsafe DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset albedoValidationPreset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_albedoValidationPreset_Public_get_AlbedoDebugValidationPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_albedoValidationPreset_Public_set_Void_AlbedoDebugValidationPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x0002E87C File Offset: 0x0002CA7C
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x0002E8B8 File Offset: 0x0002CAB8
		public unsafe float albedoMinLuminance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_albedoMinLuminance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 604702, RefRangeEnd = 604705, XrefRangeStart = 604702, XrefRangeEnd = 604702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_albedoMinLuminance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x0002E8F8 File Offset: 0x0002CAF8
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x0002E934 File Offset: 0x0002CB34
		public unsafe float albedoMaxLuminance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_albedoMaxLuminance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_albedoMaxLuminance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x0002E974 File Offset: 0x0002CB74
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x0002E9B0 File Offset: 0x0002CBB0
		public unsafe float albedoHueTolerance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_albedoHueTolerance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604705, RefRangeEnd = 604706, XrefRangeStart = 604705, XrefRangeEnd = 604705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_albedoHueTolerance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x0002E9F0 File Offset: 0x0002CBF0
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x0002EA2C File Offset: 0x0002CC2C
		public unsafe float albedoSaturationTolerance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_albedoSaturationTolerance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604706, RefRangeEnd = 604707, XrefRangeStart = 604706, XrefRangeEnd = 604706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_albedoSaturationTolerance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x0002EAA8 File Offset: 0x0002CCA8
		public unsafe Color albedoCompareColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_albedoCompareColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_albedoCompareColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x0002EAE8 File Offset: 0x0002CCE8
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x0002EB24 File Offset: 0x0002CD24
		public unsafe float metallicMinValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_metallicMinValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604707, RefRangeEnd = 604708, XrefRangeStart = 604707, XrefRangeEnd = 604707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_metallicMinValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x0002EB64 File Offset: 0x0002CD64
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x0002EBA0 File Offset: 0x0002CDA0
		public unsafe float metallicMaxValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300360, RefRangeEnd = 300361, XrefRangeStart = 300360, XrefRangeEnd = 300361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_metallicMaxValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 599561, RefRangeEnd = 599562, XrefRangeStart = 599561, XrefRangeEnd = 599562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_metallicMaxValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x0002EC1C File Offset: 0x0002CE1C
		public unsafe DebugMaterialValidationMode materialValidationMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_materialValidationMode_Public_get_DebugMaterialValidationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_materialValidationMode_Public_set_Void_DebugMaterialValidationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x0002EC5C File Offset: 0x0002CE5C
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x0002EC98 File Offset: 0x0002CE98
		public unsafe DebugMaterialMode materialDebugMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_materialDebugMode_Public_get_DebugMaterialMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_materialDebugMode_Public_set_Void_DebugMaterialMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x0002ECD8 File Offset: 0x0002CED8
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x0002ED14 File Offset: 0x0002CF14
		public unsafe DebugVertexAttributeMode vertexAttributeDebugMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_vertexAttributeDebugMode_Public_get_DebugVertexAttributeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_set_vertexAttributeDebugMode_Public_set_Void_DebugVertexAttributeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x0002ED54 File Offset: 0x0002CF54
		public unsafe virtual bool AreAnySettingsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0002ED90 File Offset: 0x0002CF90
		public unsafe virtual bool IsPostProcessingAllowed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x0002EDCC File Offset: 0x0002CFCC
		public unsafe virtual bool IsLightingActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0002EE08 File Offset: 0x0002D008
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0002EE54 File Offset: 0x0002D054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604708, XrefRangeEnd = 604712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDebugDisplaySettingsPanelDisposable UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr_UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel_Private_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDebugDisplaySettingsPanelDisposable>(intPtr3) : null;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0002EE94 File Offset: 0x0002D094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 604789, RefRangeEnd = 604790, XrefRangeStart = 604712, XrefRangeEnd = 604789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugDisplaySettingsMaterial()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00005219 File Offset: 0x00003419
		public DebugDisplaySettingsMaterial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x0002EED0 File Offset: 0x0002D0D0
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00005222 File Offset: 0x00003422
		public unsafe Il2CppReferenceArray<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData> m_AlbedoDebugValidationPresetData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr_m_AlbedoDebugValidationPresetData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr_m_AlbedoDebugValidationPresetData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0002EF00 File Offset: 0x0002D100
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00005241 File Offset: 0x00003441
		public unsafe DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset m_AlbedoValidationPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr_m_AlbedoValidationPreset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr_m_AlbedoValidationPreset)) = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x0002EF28 File Offset: 0x0002D128
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x0000525C File Offset: 0x0000345C
		public unsafe float _albedoMinLuminance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__albedoMinLuminance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__albedoMinLuminance_k__BackingField)) = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x0002EF50 File Offset: 0x0002D150
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00005277 File Offset: 0x00003477
		public unsafe float _albedoMaxLuminance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__albedoMaxLuminance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__albedoMaxLuminance_k__BackingField)) = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x0002EF78 File Offset: 0x0002D178
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00005292 File Offset: 0x00003492
		public unsafe float m_AlbedoHueTolerance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr_m_AlbedoHueTolerance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr_m_AlbedoHueTolerance)) = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0002EFA0 File Offset: 0x0002D1A0
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x000052AD File Offset: 0x000034AD
		public unsafe float m_AlbedoSaturationTolerance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr_m_AlbedoSaturationTolerance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr_m_AlbedoSaturationTolerance)) = value;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x0002EFC8 File Offset: 0x0002D1C8
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x000052C8 File Offset: 0x000034C8
		public unsafe Color _albedoCompareColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__albedoCompareColor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__albedoCompareColor_k__BackingField)) = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x0002EFF0 File Offset: 0x0002D1F0
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x000052E3 File Offset: 0x000034E3
		public unsafe float _metallicMinValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__metallicMinValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__metallicMinValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x0002F018 File Offset: 0x0002D218
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x000052FE File Offset: 0x000034FE
		public unsafe float _metallicMaxValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__metallicMaxValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__metallicMaxValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0002F040 File Offset: 0x0002D240
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00005319 File Offset: 0x00003519
		public unsafe DebugMaterialValidationMode _materialValidationMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__materialValidationMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__materialValidationMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x0002F068 File Offset: 0x0002D268
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00005334 File Offset: 0x00003534
		public unsafe DebugMaterialMode _materialDebugMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__materialDebugMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__materialDebugMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x0002F090 File Offset: 0x0002D290
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x0000534F File Offset: 0x0000354F
		public unsafe DebugVertexAttributeMode _vertexAttributeDebugMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__vertexAttributeDebugMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.NativeFieldInfoPtr__vertexAttributeDebugMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeFieldInfoPtr_m_AlbedoDebugValidationPresetData;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeFieldInfoPtr_m_AlbedoValidationPreset;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeFieldInfoPtr__albedoMinLuminance_k__BackingField;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeFieldInfoPtr__albedoMaxLuminance_k__BackingField;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeFieldInfoPtr_m_AlbedoHueTolerance;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeFieldInfoPtr_m_AlbedoSaturationTolerance;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeFieldInfoPtr__albedoCompareColor_k__BackingField;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeFieldInfoPtr__metallicMinValue_k__BackingField;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeFieldInfoPtr__metallicMaxValue_k__BackingField;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeFieldInfoPtr__materialValidationMode_k__BackingField;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr__materialDebugMode_k__BackingField;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeFieldInfoPtr__vertexAttributeDebugMode_k__BackingField;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_get_albedoValidationPreset_Public_get_AlbedoDebugValidationPreset_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_set_albedoValidationPreset_Public_set_Void_AlbedoDebugValidationPreset_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_get_albedoMinLuminance_Public_get_Single_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_set_albedoMinLuminance_Public_set_Void_Single_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_get_albedoMaxLuminance_Public_get_Single_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_set_albedoMaxLuminance_Public_set_Void_Single_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_get_albedoHueTolerance_Public_get_Single_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_set_albedoHueTolerance_Public_set_Void_Single_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_get_albedoSaturationTolerance_Public_get_Single_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_set_albedoSaturationTolerance_Public_set_Void_Single_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_get_albedoCompareColor_Public_get_Color_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_set_albedoCompareColor_Public_set_Void_Color_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_get_metallicMinValue_Public_get_Single_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_set_metallicMinValue_Public_set_Void_Single_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_get_metallicMaxValue_Public_get_Single_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_set_metallicMaxValue_Public_set_Void_Single_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_get_materialValidationMode_Public_get_DebugMaterialValidationMode_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_set_materialValidationMode_Public_set_Void_DebugMaterialValidationMode_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_get_materialDebugMode_Public_get_DebugMaterialMode_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_set_materialDebugMode_Public_set_Void_DebugMaterialMode_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexAttributeDebugMode_Public_get_DebugVertexAttributeMode_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_set_vertexAttributeDebugMode_Public_set_Void_DebugVertexAttributeMode_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel_Private_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000171 RID: 369
		public enum AlbedoDebugValidationPreset
		{
			// Token: 0x04001470 RID: 5232
			DefaultLuminance,
			// Token: 0x04001471 RID: 5233
			BlackAcrylicPaint,
			// Token: 0x04001472 RID: 5234
			DarkSoil,
			// Token: 0x04001473 RID: 5235
			WornAsphalt,
			// Token: 0x04001474 RID: 5236
			DryClaySoil,
			// Token: 0x04001475 RID: 5237
			GreenGrass,
			// Token: 0x04001476 RID: 5238
			OldConcrete,
			// Token: 0x04001477 RID: 5239
			RedClayTile,
			// Token: 0x04001478 RID: 5240
			DrySand,
			// Token: 0x04001479 RID: 5241
			NewConcrete,
			// Token: 0x0400147A RID: 5242
			WhiteAcrylicPaint,
			// Token: 0x0400147B RID: 5243
			FreshSnow,
			// Token: 0x0400147C RID: 5244
			BlueSky,
			// Token: 0x0400147D RID: 5245
			Foliage,
			// Token: 0x0400147E RID: 5246
			Custom
		}

		// Token: 0x02000172 RID: 370
		public sealed class AlbedoDebugValidationPresetData : ValueType
		{
			// Token: 0x06001C1B RID: 7195 RVA: 0x00073EB8 File Offset: 0x000720B8
			// Note: this type is marked as 'beforefieldinit'.
			static AlbedoDebugValidationPresetData()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "AlbedoDebugValidationPresetData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>.NativeClassPtr);
				DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>.NativeClassPtr, "name");
				DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>.NativeClassPtr, "color");
				DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData.NativeFieldInfoPtr_minLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>.NativeClassPtr, "minLuminance");
				DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData.NativeFieldInfoPtr_maxLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>.NativeClassPtr, "maxLuminance");
			}

			// Token: 0x06001C1C RID: 7196 RVA: 0x0000FFAB File Offset: 0x0000E1AB
			public AlbedoDebugValidationPresetData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C1D RID: 7197 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
			public AlbedoDebugValidationPresetData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>.NativeClassPtr))
			{
			}

			// Token: 0x17000A12 RID: 2578
			// (get) Token: 0x06001C1E RID: 7198 RVA: 0x00073F34 File Offset: 0x00072134
			// (set) Token: 0x06001C1F RID: 7199 RVA: 0x0000FFC6 File Offset: 0x0000E1C6
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A13 RID: 2579
			// (get) Token: 0x06001C20 RID: 7200 RVA: 0x00073F5C File Offset: 0x0007215C
			// (set) Token: 0x06001C21 RID: 7201 RVA: 0x0000FFE5 File Offset: 0x0000E1E5
			public unsafe Color color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17000A14 RID: 2580
			// (get) Token: 0x06001C22 RID: 7202 RVA: 0x00073F84 File Offset: 0x00072184
			// (set) Token: 0x06001C23 RID: 7203 RVA: 0x00010000 File Offset: 0x0000E200
			public unsafe float minLuminance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData.NativeFieldInfoPtr_minLuminance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData.NativeFieldInfoPtr_minLuminance)) = value;
				}
			}

			// Token: 0x17000A15 RID: 2581
			// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00073FAC File Offset: 0x000721AC
			// (set) Token: 0x06001C25 RID: 7205 RVA: 0x0001001B File Offset: 0x0000E21B
			public unsafe float maxLuminance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData.NativeFieldInfoPtr_maxLuminance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData.NativeFieldInfoPtr_maxLuminance)) = value;
				}
			}

			// Token: 0x0400147F RID: 5247
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04001480 RID: 5248
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04001481 RID: 5249
			private static readonly IntPtr NativeFieldInfoPtr_minLuminance;

			// Token: 0x04001482 RID: 5250
			private static readonly IntPtr NativeFieldInfoPtr_maxLuminance;
		}

		// Token: 0x02000173 RID: 371
		public static class Strings : Object
		{
			// Token: 0x06001C26 RID: 7206 RVA: 0x00073FD4 File Offset: 0x000721D4
			// Note: this type is marked as 'beforefieldinit'.
			static Strings()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "Strings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr);
				DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoSettingsContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr, "AlbedoSettingsContainerName");
				DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MetallicSettingsContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr, "MetallicSettingsContainerName");
				DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MaterialOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr, "MaterialOverride");
				DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_VertexAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr, "VertexAttribute");
				DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MaterialValidationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr, "MaterialValidationMode");
				DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_ValidationPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr, "ValidationPreset");
				DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoCustomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr, "AlbedoCustomColor");
				DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoMinLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr, "AlbedoMinLuminance");
				DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoMaxLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr, "AlbedoMaxLuminance");
				DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoHueTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr, "AlbedoHueTolerance");
				DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoSaturationTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr, "AlbedoSaturationTolerance");
				DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MetallicMinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr, "MetallicMinValue");
				DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MetallicMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.Strings>.NativeClassPtr, "MetallicMaxValue");
			}

			// Token: 0x06001C27 RID: 7207 RVA: 0x00010036 File Offset: 0x0000E236
			public Strings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A16 RID: 2582
			// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00074104 File Offset: 0x00072304
			// (set) Token: 0x06001C29 RID: 7209 RVA: 0x0001003F File Offset: 0x0000E23F
			public unsafe static string AlbedoSettingsContainerName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoSettingsContainerName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoSettingsContainerName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A17 RID: 2583
			// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00074124 File Offset: 0x00072324
			// (set) Token: 0x06001C2B RID: 7211 RVA: 0x00010051 File Offset: 0x0000E251
			public unsafe static string MetallicSettingsContainerName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MetallicSettingsContainerName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MetallicSettingsContainerName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A18 RID: 2584
			// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00074144 File Offset: 0x00072344
			// (set) Token: 0x06001C2D RID: 7213 RVA: 0x00010063 File Offset: 0x0000E263
			public unsafe static DebugUI.Widget.NameAndTooltip MaterialOverride
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MaterialOverride, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MaterialOverride, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A19 RID: 2585
			// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00074180 File Offset: 0x00072380
			// (set) Token: 0x06001C2F RID: 7215 RVA: 0x0001007A File Offset: 0x0000E27A
			public unsafe static DebugUI.Widget.NameAndTooltip VertexAttribute
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_VertexAttribute, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_VertexAttribute, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A1A RID: 2586
			// (get) Token: 0x06001C30 RID: 7216 RVA: 0x000741BC File Offset: 0x000723BC
			// (set) Token: 0x06001C31 RID: 7217 RVA: 0x00010091 File Offset: 0x0000E291
			public unsafe static DebugUI.Widget.NameAndTooltip MaterialValidationMode
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MaterialValidationMode, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MaterialValidationMode, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A1B RID: 2587
			// (get) Token: 0x06001C32 RID: 7218 RVA: 0x000741F8 File Offset: 0x000723F8
			// (set) Token: 0x06001C33 RID: 7219 RVA: 0x000100A8 File Offset: 0x0000E2A8
			public unsafe static DebugUI.Widget.NameAndTooltip ValidationPreset
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_ValidationPreset, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_ValidationPreset, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A1C RID: 2588
			// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00074234 File Offset: 0x00072434
			// (set) Token: 0x06001C35 RID: 7221 RVA: 0x000100BF File Offset: 0x0000E2BF
			public unsafe static DebugUI.Widget.NameAndTooltip AlbedoCustomColor
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoCustomColor, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoCustomColor, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A1D RID: 2589
			// (get) Token: 0x06001C36 RID: 7222 RVA: 0x00074270 File Offset: 0x00072470
			// (set) Token: 0x06001C37 RID: 7223 RVA: 0x000100D6 File Offset: 0x0000E2D6
			public unsafe static DebugUI.Widget.NameAndTooltip AlbedoMinLuminance
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoMinLuminance, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoMinLuminance, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A1E RID: 2590
			// (get) Token: 0x06001C38 RID: 7224 RVA: 0x000742AC File Offset: 0x000724AC
			// (set) Token: 0x06001C39 RID: 7225 RVA: 0x000100ED File Offset: 0x0000E2ED
			public unsafe static DebugUI.Widget.NameAndTooltip AlbedoMaxLuminance
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoMaxLuminance, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoMaxLuminance, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A1F RID: 2591
			// (get) Token: 0x06001C3A RID: 7226 RVA: 0x000742E8 File Offset: 0x000724E8
			// (set) Token: 0x06001C3B RID: 7227 RVA: 0x00010104 File Offset: 0x0000E304
			public unsafe static DebugUI.Widget.NameAndTooltip AlbedoHueTolerance
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoHueTolerance, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoHueTolerance, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A20 RID: 2592
			// (get) Token: 0x06001C3C RID: 7228 RVA: 0x00074324 File Offset: 0x00072524
			// (set) Token: 0x06001C3D RID: 7229 RVA: 0x0001011B File Offset: 0x0000E31B
			public unsafe static DebugUI.Widget.NameAndTooltip AlbedoSaturationTolerance
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoSaturationTolerance, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_AlbedoSaturationTolerance, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A21 RID: 2593
			// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00074360 File Offset: 0x00072560
			// (set) Token: 0x06001C3F RID: 7231 RVA: 0x00010132 File Offset: 0x0000E332
			public unsafe static DebugUI.Widget.NameAndTooltip MetallicMinValue
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MetallicMinValue, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MetallicMinValue, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A22 RID: 2594
			// (get) Token: 0x06001C40 RID: 7232 RVA: 0x0007439C File Offset: 0x0007259C
			// (set) Token: 0x06001C41 RID: 7233 RVA: 0x00010149 File Offset: 0x0000E349
			public unsafe static DebugUI.Widget.NameAndTooltip MetallicMaxValue
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MetallicMaxValue, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.Strings.NativeFieldInfoPtr_MetallicMaxValue, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x04001483 RID: 5251
			private static readonly IntPtr NativeFieldInfoPtr_AlbedoSettingsContainerName;

			// Token: 0x04001484 RID: 5252
			private static readonly IntPtr NativeFieldInfoPtr_MetallicSettingsContainerName;

			// Token: 0x04001485 RID: 5253
			private static readonly IntPtr NativeFieldInfoPtr_MaterialOverride;

			// Token: 0x04001486 RID: 5254
			private static readonly IntPtr NativeFieldInfoPtr_VertexAttribute;

			// Token: 0x04001487 RID: 5255
			private static readonly IntPtr NativeFieldInfoPtr_MaterialValidationMode;

			// Token: 0x04001488 RID: 5256
			private static readonly IntPtr NativeFieldInfoPtr_ValidationPreset;

			// Token: 0x04001489 RID: 5257
			private static readonly IntPtr NativeFieldInfoPtr_AlbedoCustomColor;

			// Token: 0x0400148A RID: 5258
			private static readonly IntPtr NativeFieldInfoPtr_AlbedoMinLuminance;

			// Token: 0x0400148B RID: 5259
			private static readonly IntPtr NativeFieldInfoPtr_AlbedoMaxLuminance;

			// Token: 0x0400148C RID: 5260
			private static readonly IntPtr NativeFieldInfoPtr_AlbedoHueTolerance;

			// Token: 0x0400148D RID: 5261
			private static readonly IntPtr NativeFieldInfoPtr_AlbedoSaturationTolerance;

			// Token: 0x0400148E RID: 5262
			private static readonly IntPtr NativeFieldInfoPtr_MetallicMinValue;

			// Token: 0x0400148F RID: 5263
			private static readonly IntPtr NativeFieldInfoPtr_MetallicMaxValue;
		}

		// Token: 0x02000174 RID: 372
		public static class WidgetFactory : Object
		{
			// Token: 0x06001C42 RID: 7234 RVA: 0x000743D8 File Offset: 0x000725D8
			// Note: this type is marked as 'beforefieldinit'.
			static WidgetFactory()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "WidgetFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr);
				DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateMaterialOverride_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, 100664190);
				DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateVertexAttribute_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, 100664191);
				DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateMaterialValidationMode_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, 100664192);
				DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateAlbedoPreset_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, 100664193);
				DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateAlbedoCustomColor_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, 100664194);
				DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateAlbedoMinLuminance_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, 100664195);
				DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateAlbedoMaxLuminance_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, 100664196);
				DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateAlbedoHueTolerance_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, 100664197);
				DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateAlbedoSaturationTolerance_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, 100664198);
				DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateMetallicMinValue_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, 100664199);
				DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateMetallicMaxValue_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, 100664200);
			}

			// Token: 0x06001C43 RID: 7235 RVA: 0x000744E0 File Offset: 0x000726E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604043, RefRangeEnd = 604044, XrefRangeStart = 603994, XrefRangeEnd = 604043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateMaterialOverride(DebugDisplaySettingsMaterial.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateMaterialOverride_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C44 RID: 7236 RVA: 0x00074524 File Offset: 0x00072724
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604093, RefRangeEnd = 604094, XrefRangeStart = 604044, XrefRangeEnd = 604093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateVertexAttribute(DebugDisplaySettingsMaterial.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateVertexAttribute_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C45 RID: 7237 RVA: 0x00074568 File Offset: 0x00072768
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604159, RefRangeEnd = 604160, XrefRangeStart = 604094, XrefRangeEnd = 604159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateMaterialValidationMode(DebugDisplaySettingsMaterial.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateMaterialValidationMode_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C46 RID: 7238 RVA: 0x000745AC File Offset: 0x000727AC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604225, RefRangeEnd = 604226, XrefRangeStart = 604160, XrefRangeEnd = 604225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateAlbedoPreset(DebugDisplaySettingsMaterial.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateAlbedoPreset_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C47 RID: 7239 RVA: 0x000745F0 File Offset: 0x000727F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604226, XrefRangeEnd = 604263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateAlbedoCustomColor(DebugDisplaySettingsMaterial.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateAlbedoCustomColor_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C48 RID: 7240 RVA: 0x00074634 File Offset: 0x00072834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604263, XrefRangeEnd = 604293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateAlbedoMinLuminance(DebugDisplaySettingsMaterial.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateAlbedoMinLuminance_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C49 RID: 7241 RVA: 0x00074678 File Offset: 0x00072878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604293, XrefRangeEnd = 604323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateAlbedoMaxLuminance(DebugDisplaySettingsMaterial.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateAlbedoMaxLuminance_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C4A RID: 7242 RVA: 0x000746BC File Offset: 0x000728BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604360, RefRangeEnd = 604361, XrefRangeStart = 604323, XrefRangeEnd = 604360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateAlbedoHueTolerance(DebugDisplaySettingsMaterial.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateAlbedoHueTolerance_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C4B RID: 7243 RVA: 0x00074700 File Offset: 0x00072900
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604398, RefRangeEnd = 604399, XrefRangeStart = 604361, XrefRangeEnd = 604398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateAlbedoSaturationTolerance(DebugDisplaySettingsMaterial.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateAlbedoSaturationTolerance_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C4C RID: 7244 RVA: 0x00074744 File Offset: 0x00072944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604399, XrefRangeEnd = 604429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateMetallicMinValue(DebugDisplaySettingsMaterial.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateMetallicMinValue_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C4D RID: 7245 RVA: 0x00074788 File Offset: 0x00072988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604429, XrefRangeEnd = 604459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateMetallicMaxValue(DebugDisplaySettingsMaterial.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.NativeMethodInfoPtr_CreateMetallicMaxValue_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C4E RID: 7246 RVA: 0x00010160 File Offset: 0x0000E360
			public WidgetFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001490 RID: 5264
			private static readonly IntPtr NativeMethodInfoPtr_CreateMaterialOverride_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x04001491 RID: 5265
			private static readonly IntPtr NativeMethodInfoPtr_CreateVertexAttribute_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x04001492 RID: 5266
			private static readonly IntPtr NativeMethodInfoPtr_CreateMaterialValidationMode_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x04001493 RID: 5267
			private static readonly IntPtr NativeMethodInfoPtr_CreateAlbedoPreset_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x04001494 RID: 5268
			private static readonly IntPtr NativeMethodInfoPtr_CreateAlbedoCustomColor_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x04001495 RID: 5269
			private static readonly IntPtr NativeMethodInfoPtr_CreateAlbedoMinLuminance_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x04001496 RID: 5270
			private static readonly IntPtr NativeMethodInfoPtr_CreateAlbedoMaxLuminance_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x04001497 RID: 5271
			private static readonly IntPtr NativeMethodInfoPtr_CreateAlbedoHueTolerance_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x04001498 RID: 5272
			private static readonly IntPtr NativeMethodInfoPtr_CreateAlbedoSaturationTolerance_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x04001499 RID: 5273
			private static readonly IntPtr NativeMethodInfoPtr_CreateMetallicMinValue_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x0400149A RID: 5274
			private static readonly IntPtr NativeMethodInfoPtr_CreateMetallicMaxValue_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x02000220 RID: 544
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060023ED RID: 9197 RVA: 0x00086C90 File Offset: 0x00084E90
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c>.NativeClassPtr);
					DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c>.NativeClassPtr, "<>9");
					DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeFieldInfoPtr___9__2_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c>.NativeClassPtr, "<>9__2_4");
					DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeFieldInfoPtr___9__3_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c>.NativeClassPtr, "<>9__3_4");
					DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c>.NativeClassPtr, 100664202);
					DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeMethodInfoPtr__CreateMaterialValidationMode_b__2_4_Internal_Void_Field_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c>.NativeClassPtr, 100664203);
					DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeMethodInfoPtr__CreateAlbedoPreset_b__3_4_Internal_Void_Field_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c>.NativeClassPtr, 100664204);
				}

				// Token: 0x060023EE RID: 9198 RVA: 0x00086D34 File Offset: 0x00084F34
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023EF RID: 9199 RVA: 0x00086D70 File Offset: 0x00084F70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603949, XrefRangeEnd = 603955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateMaterialValidationMode_b__2_4(DebugUI.Field<int> _, int _)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeMethodInfoPtr__CreateMaterialValidationMode_b__2_4_Internal_Void_Field_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023F0 RID: 9200 RVA: 0x00086DC0 File Offset: 0x00084FC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603955, XrefRangeEnd = 603961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateAlbedoPreset_b__3_4(DebugUI.Field<int> _, int _)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeMethodInfoPtr__CreateAlbedoPreset_b__3_4_Internal_Void_Field_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023F1 RID: 9201 RVA: 0x00014A82 File Offset: 0x00012C82
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CE6 RID: 3302
				// (get) Token: 0x060023F2 RID: 9202 RVA: 0x00086E10 File Offset: 0x00085010
				// (set) Token: 0x060023F3 RID: 9203 RVA: 0x00014A8B File Offset: 0x00012C8B
				public unsafe static DebugDisplaySettingsMaterial.WidgetFactory.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial.WidgetFactory.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000CE7 RID: 3303
				// (get) Token: 0x060023F4 RID: 9204 RVA: 0x00086E38 File Offset: 0x00085038
				// (set) Token: 0x060023F5 RID: 9205 RVA: 0x00014A9D File Offset: 0x00012C9D
				public unsafe static Action<DebugUI.Field<int>, int> __9__2_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeFieldInfoPtr___9__2_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DebugUI.Field<int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeFieldInfoPtr___9__2_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000CE8 RID: 3304
				// (get) Token: 0x060023F6 RID: 9206 RVA: 0x00086E60 File Offset: 0x00085060
				// (set) Token: 0x060023F7 RID: 9207 RVA: 0x00014AAF File Offset: 0x00012CAF
				public unsafe static Action<DebugUI.Field<int>, int> __9__3_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeFieldInfoPtr___9__3_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DebugUI.Field<int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsMaterial.WidgetFactory.__c.NativeFieldInfoPtr___9__3_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001902 RID: 6402
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04001903 RID: 6403
				private static readonly IntPtr NativeFieldInfoPtr___9__2_4;

				// Token: 0x04001904 RID: 6404
				private static readonly IntPtr NativeFieldInfoPtr___9__3_4;

				// Token: 0x04001905 RID: 6405
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001906 RID: 6406
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaterialValidationMode_b__2_4_Internal_Void_Field_1_Int32_Int32_0;

				// Token: 0x04001907 RID: 6407
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoPreset_b__3_4_Internal_Void_Field_1_Int32_Int32_0;
			}

			// Token: 0x02000221 RID: 545
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c__DisplayClass0_0")]
			public sealed class __c__DisplayClass0_0 : Object
			{
				// Token: 0x060023F8 RID: 9208 RVA: 0x00086E88 File Offset: 0x00085088
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass0_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass0_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664205);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMaterialOverride_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664206);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMaterialOverride_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664207);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMaterialOverride_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664208);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMaterialOverride_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664209);
				}

				// Token: 0x060023F9 RID: 9209 RVA: 0x00086F2C File Offset: 0x0008512C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass0_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023FA RID: 9210 RVA: 0x00086F68 File Offset: 0x00085168
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603961, XrefRangeEnd = 603962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateMaterialOverride_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMaterialOverride_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060023FB RID: 9211 RVA: 0x00086FA4 File Offset: 0x000851A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603962, XrefRangeEnd = 603963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateMaterialOverride_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMaterialOverride_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023FC RID: 9212 RVA: 0x00086FE4 File Offset: 0x000851E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603963, XrefRangeEnd = 603964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateMaterialOverride_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMaterialOverride_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060023FD RID: 9213 RVA: 0x00087020 File Offset: 0x00085220
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603964, XrefRangeEnd = 603965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateMaterialOverride_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMaterialOverride_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023FE RID: 9214 RVA: 0x00014AC1 File Offset: 0x00012CC1
				public __c__DisplayClass0_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CE9 RID: 3305
				// (get) Token: 0x060023FF RID: 9215 RVA: 0x00087060 File Offset: 0x00085260
				// (set) Token: 0x06002400 RID: 9216 RVA: 0x00014ACA File Offset: 0x00012CCA
				public unsafe DebugDisplaySettingsMaterial.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001908 RID: 6408
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001909 RID: 6409
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400190A RID: 6410
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaterialOverride_b__0_Internal_Int32_0;

				// Token: 0x0400190B RID: 6411
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaterialOverride_b__1_Internal_Void_Int32_0;

				// Token: 0x0400190C RID: 6412
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaterialOverride_b__2_Internal_Int32_0;

				// Token: 0x0400190D RID: 6413
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaterialOverride_b__3_Internal_Void_Int32_0;
			}

			// Token: 0x02000222 RID: 546
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c__DisplayClass10_0")]
			public sealed class __c__DisplayClass10_0 : Object
			{
				// Token: 0x06002401 RID: 9217 RVA: 0x00087090 File Offset: 0x00085290
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass10_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass10_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr, 100664210);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__CreateMetallicMaxValue_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr, 100664211);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__CreateMetallicMaxValue_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr, 100664212);
				}

				// Token: 0x06002402 RID: 9218 RVA: 0x0008710C File Offset: 0x0008530C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass10_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002403 RID: 9219 RVA: 0x00087148 File Offset: 0x00085348
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603965, XrefRangeEnd = 603966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe float _CreateMetallicMaxValue_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__CreateMetallicMaxValue_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002404 RID: 9220 RVA: 0x00087184 File Offset: 0x00085384
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603966, XrefRangeEnd = 603967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateMetallicMaxValue_b__1(float value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__CreateMetallicMaxValue_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002405 RID: 9221 RVA: 0x00014AE9 File Offset: 0x00012CE9
				public __c__DisplayClass10_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CEA RID: 3306
				// (get) Token: 0x06002406 RID: 9222 RVA: 0x000871C4 File Offset: 0x000853C4
				// (set) Token: 0x06002407 RID: 9223 RVA: 0x00014AF2 File Offset: 0x00012CF2
				public unsafe DebugDisplaySettingsMaterial.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass10_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400190E RID: 6414
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x0400190F RID: 6415
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001910 RID: 6416
				private static readonly IntPtr NativeMethodInfoPtr__CreateMetallicMaxValue_b__0_Internal_Single_0;

				// Token: 0x04001911 RID: 6417
				private static readonly IntPtr NativeMethodInfoPtr__CreateMetallicMaxValue_b__1_Internal_Void_Single_0;
			}

			// Token: 0x02000223 RID: 547
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c__DisplayClass1_0")]
			public sealed class __c__DisplayClass1_0 : Object
			{
				// Token: 0x06002408 RID: 9224 RVA: 0x000871F4 File Offset: 0x000853F4
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass1_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass1_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664213);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateVertexAttribute_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664214);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateVertexAttribute_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664215);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateVertexAttribute_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664216);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateVertexAttribute_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664217);
				}

				// Token: 0x06002409 RID: 9225 RVA: 0x00087298 File Offset: 0x00085498
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass1_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600240A RID: 9226 RVA: 0x000872D4 File Offset: 0x000854D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603967, XrefRangeEnd = 603968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateVertexAttribute_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateVertexAttribute_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600240B RID: 9227 RVA: 0x00087310 File Offset: 0x00085510
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603968, XrefRangeEnd = 603969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateVertexAttribute_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateVertexAttribute_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600240C RID: 9228 RVA: 0x00087350 File Offset: 0x00085550
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603969, XrefRangeEnd = 603970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateVertexAttribute_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateVertexAttribute_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600240D RID: 9229 RVA: 0x0008738C File Offset: 0x0008558C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603970, XrefRangeEnd = 603971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateVertexAttribute_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateVertexAttribute_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600240E RID: 9230 RVA: 0x00014B11 File Offset: 0x00012D11
				public __c__DisplayClass1_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CEB RID: 3307
				// (get) Token: 0x0600240F RID: 9231 RVA: 0x000873CC File Offset: 0x000855CC
				// (set) Token: 0x06002410 RID: 9232 RVA: 0x00014B1A File Offset: 0x00012D1A
				public unsafe DebugDisplaySettingsMaterial.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001912 RID: 6418
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001913 RID: 6419
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001914 RID: 6420
				private static readonly IntPtr NativeMethodInfoPtr__CreateVertexAttribute_b__0_Internal_Int32_0;

				// Token: 0x04001915 RID: 6421
				private static readonly IntPtr NativeMethodInfoPtr__CreateVertexAttribute_b__1_Internal_Void_Int32_0;

				// Token: 0x04001916 RID: 6422
				private static readonly IntPtr NativeMethodInfoPtr__CreateVertexAttribute_b__2_Internal_Int32_0;

				// Token: 0x04001917 RID: 6423
				private static readonly IntPtr NativeMethodInfoPtr__CreateVertexAttribute_b__3_Internal_Void_Int32_0;
			}

			// Token: 0x02000224 RID: 548
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c__DisplayClass2_0")]
			public sealed class __c__DisplayClass2_0 : Object
			{
				// Token: 0x06002411 RID: 9233 RVA: 0x000873FC File Offset: 0x000855FC
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass2_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass2_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664218);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateMaterialValidationMode_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664219);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateMaterialValidationMode_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664220);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateMaterialValidationMode_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664221);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateMaterialValidationMode_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664222);
				}

				// Token: 0x06002412 RID: 9234 RVA: 0x000874A0 File Offset: 0x000856A0
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass2_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002413 RID: 9235 RVA: 0x000874DC File Offset: 0x000856DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603971, XrefRangeEnd = 603972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateMaterialValidationMode_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateMaterialValidationMode_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002414 RID: 9236 RVA: 0x00087518 File Offset: 0x00085718
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603972, XrefRangeEnd = 603973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateMaterialValidationMode_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateMaterialValidationMode_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002415 RID: 9237 RVA: 0x00087558 File Offset: 0x00085758
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603973, XrefRangeEnd = 603974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateMaterialValidationMode_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateMaterialValidationMode_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002416 RID: 9238 RVA: 0x00087594 File Offset: 0x00085794
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603974, XrefRangeEnd = 603975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateMaterialValidationMode_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateMaterialValidationMode_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002417 RID: 9239 RVA: 0x00014B39 File Offset: 0x00012D39
				public __c__DisplayClass2_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CEC RID: 3308
				// (get) Token: 0x06002418 RID: 9240 RVA: 0x000875D4 File Offset: 0x000857D4
				// (set) Token: 0x06002419 RID: 9241 RVA: 0x00014B42 File Offset: 0x00012D42
				public unsafe DebugDisplaySettingsMaterial.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001918 RID: 6424
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001919 RID: 6425
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400191A RID: 6426
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaterialValidationMode_b__0_Internal_Int32_0;

				// Token: 0x0400191B RID: 6427
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaterialValidationMode_b__1_Internal_Void_Int32_0;

				// Token: 0x0400191C RID: 6428
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaterialValidationMode_b__2_Internal_Int32_0;

				// Token: 0x0400191D RID: 6429
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaterialValidationMode_b__3_Internal_Void_Int32_0;
			}

			// Token: 0x02000225 RID: 549
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c__DisplayClass3_0")]
			public sealed class __c__DisplayClass3_0 : Object
			{
				// Token: 0x0600241A RID: 9242 RVA: 0x00087604 File Offset: 0x00085804
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass3_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass3_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr, 100664223);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateAlbedoPreset_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr, 100664224);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateAlbedoPreset_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr, 100664225);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateAlbedoPreset_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr, 100664226);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateAlbedoPreset_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr, 100664227);
				}

				// Token: 0x0600241B RID: 9243 RVA: 0x000876A8 File Offset: 0x000858A8
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass3_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600241C RID: 9244 RVA: 0x000876E4 File Offset: 0x000858E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603975, XrefRangeEnd = 603976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateAlbedoPreset_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateAlbedoPreset_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600241D RID: 9245 RVA: 0x00087720 File Offset: 0x00085920
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603976, XrefRangeEnd = 603977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateAlbedoPreset_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateAlbedoPreset_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600241E RID: 9246 RVA: 0x00087760 File Offset: 0x00085960
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603977, XrefRangeEnd = 603978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateAlbedoPreset_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateAlbedoPreset_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600241F RID: 9247 RVA: 0x0008779C File Offset: 0x0008599C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603978, XrefRangeEnd = 603979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateAlbedoPreset_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateAlbedoPreset_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002420 RID: 9248 RVA: 0x00014B61 File Offset: 0x00012D61
				public __c__DisplayClass3_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CED RID: 3309
				// (get) Token: 0x06002421 RID: 9249 RVA: 0x000877DC File Offset: 0x000859DC
				// (set) Token: 0x06002422 RID: 9250 RVA: 0x00014B6A File Offset: 0x00012D6A
				public unsafe DebugDisplaySettingsMaterial.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400191E RID: 6430
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x0400191F RID: 6431
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001920 RID: 6432
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoPreset_b__0_Internal_Int32_0;

				// Token: 0x04001921 RID: 6433
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoPreset_b__1_Internal_Void_Int32_0;

				// Token: 0x04001922 RID: 6434
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoPreset_b__2_Internal_Int32_0;

				// Token: 0x04001923 RID: 6435
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoPreset_b__3_Internal_Void_Int32_0;
			}

			// Token: 0x02000226 RID: 550
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c__DisplayClass4_0")]
			public sealed class __c__DisplayClass4_0 : Object
			{
				// Token: 0x06002423 RID: 9251 RVA: 0x0008780C File Offset: 0x00085A0C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass4_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass4_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr, 100664228);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateAlbedoCustomColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr, 100664229);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateAlbedoCustomColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr, 100664230);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateAlbedoCustomColor_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr, 100664231);
				}

				// Token: 0x06002424 RID: 9252 RVA: 0x0008789C File Offset: 0x00085A9C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass4_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002425 RID: 9253 RVA: 0x000878D8 File Offset: 0x00085AD8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603979, XrefRangeEnd = 603980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Color _CreateAlbedoCustomColor_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateAlbedoCustomColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002426 RID: 9254 RVA: 0x00087914 File Offset: 0x00085B14
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603980, XrefRangeEnd = 603981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateAlbedoCustomColor_b__1(Color value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateAlbedoCustomColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002427 RID: 9255 RVA: 0x00087954 File Offset: 0x00085B54
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603981, XrefRangeEnd = 603982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _CreateAlbedoCustomColor_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateAlbedoCustomColor_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002428 RID: 9256 RVA: 0x00014B89 File Offset: 0x00012D89
				public __c__DisplayClass4_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CEE RID: 3310
				// (get) Token: 0x06002429 RID: 9257 RVA: 0x00087990 File Offset: 0x00085B90
				// (set) Token: 0x0600242A RID: 9258 RVA: 0x00014B92 File Offset: 0x00012D92
				public unsafe DebugDisplaySettingsMaterial.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001924 RID: 6436
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001925 RID: 6437
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001926 RID: 6438
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoCustomColor_b__0_Internal_Color_0;

				// Token: 0x04001927 RID: 6439
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoCustomColor_b__1_Internal_Void_Color_0;

				// Token: 0x04001928 RID: 6440
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoCustomColor_b__2_Internal_Boolean_0;
			}

			// Token: 0x02000227 RID: 551
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c__DisplayClass5_0")]
			public sealed class __c__DisplayClass5_0 : Object
			{
				// Token: 0x0600242B RID: 9259 RVA: 0x000879C0 File Offset: 0x00085BC0
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass5_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass5_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr, 100664232);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__CreateAlbedoMinLuminance_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr, 100664233);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__CreateAlbedoMinLuminance_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr, 100664234);
				}

				// Token: 0x0600242C RID: 9260 RVA: 0x00087A3C File Offset: 0x00085C3C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass5_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600242D RID: 9261 RVA: 0x00087A78 File Offset: 0x00085C78
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603982, XrefRangeEnd = 603983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe float _CreateAlbedoMinLuminance_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__CreateAlbedoMinLuminance_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600242E RID: 9262 RVA: 0x00087AB4 File Offset: 0x00085CB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603983, XrefRangeEnd = 603984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateAlbedoMinLuminance_b__1(float value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__CreateAlbedoMinLuminance_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600242F RID: 9263 RVA: 0x00014BB1 File Offset: 0x00012DB1
				public __c__DisplayClass5_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CEF RID: 3311
				// (get) Token: 0x06002430 RID: 9264 RVA: 0x00087AF4 File Offset: 0x00085CF4
				// (set) Token: 0x06002431 RID: 9265 RVA: 0x00014BBA File Offset: 0x00012DBA
				public unsafe DebugDisplaySettingsMaterial.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass5_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001929 RID: 6441
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x0400192A RID: 6442
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400192B RID: 6443
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoMinLuminance_b__0_Internal_Single_0;

				// Token: 0x0400192C RID: 6444
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoMinLuminance_b__1_Internal_Void_Single_0;
			}

			// Token: 0x02000228 RID: 552
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Object
			{
				// Token: 0x06002432 RID: 9266 RVA: 0x00087B24 File Offset: 0x00085D24
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr, 100664235);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__CreateAlbedoMaxLuminance_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr, 100664236);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__CreateAlbedoMaxLuminance_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr, 100664237);
				}

				// Token: 0x06002433 RID: 9267 RVA: 0x00087BA0 File Offset: 0x00085DA0
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002434 RID: 9268 RVA: 0x00087BDC File Offset: 0x00085DDC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603984, XrefRangeEnd = 603985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe float _CreateAlbedoMaxLuminance_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__CreateAlbedoMaxLuminance_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002435 RID: 9269 RVA: 0x00087C18 File Offset: 0x00085E18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603985, XrefRangeEnd = 603986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateAlbedoMaxLuminance_b__1(float value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__CreateAlbedoMaxLuminance_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002436 RID: 9270 RVA: 0x00014BD9 File Offset: 0x00012DD9
				public __c__DisplayClass6_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CF0 RID: 3312
				// (get) Token: 0x06002437 RID: 9271 RVA: 0x00087C58 File Offset: 0x00085E58
				// (set) Token: 0x06002438 RID: 9272 RVA: 0x00014BE2 File Offset: 0x00012DE2
				public unsafe DebugDisplaySettingsMaterial.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400192D RID: 6445
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x0400192E RID: 6446
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400192F RID: 6447
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoMaxLuminance_b__0_Internal_Single_0;

				// Token: 0x04001930 RID: 6448
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoMaxLuminance_b__1_Internal_Void_Single_0;
			}

			// Token: 0x02000229 RID: 553
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c__DisplayClass7_0")]
			public sealed class __c__DisplayClass7_0 : Object
			{
				// Token: 0x06002439 RID: 9273 RVA: 0x00087C88 File Offset: 0x00085E88
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass7_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass7_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, 100664238);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__CreateAlbedoHueTolerance_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, 100664239);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__CreateAlbedoHueTolerance_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, 100664240);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__CreateAlbedoHueTolerance_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, 100664241);
				}

				// Token: 0x0600243A RID: 9274 RVA: 0x00087D18 File Offset: 0x00085F18
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass7_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600243B RID: 9275 RVA: 0x00087D54 File Offset: 0x00085F54
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603986, XrefRangeEnd = 603987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe float _CreateAlbedoHueTolerance_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__CreateAlbedoHueTolerance_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600243C RID: 9276 RVA: 0x00087D90 File Offset: 0x00085F90
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603987, XrefRangeEnd = 603988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateAlbedoHueTolerance_b__1(float value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__CreateAlbedoHueTolerance_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600243D RID: 9277 RVA: 0x00087DD0 File Offset: 0x00085FD0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603988, XrefRangeEnd = 603989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _CreateAlbedoHueTolerance_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__CreateAlbedoHueTolerance_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600243E RID: 9278 RVA: 0x00014C01 File Offset: 0x00012E01
				public __c__DisplayClass7_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CF1 RID: 3313
				// (get) Token: 0x0600243F RID: 9279 RVA: 0x00087E0C File Offset: 0x0008600C
				// (set) Token: 0x06002440 RID: 9280 RVA: 0x00014C0A File Offset: 0x00012E0A
				public unsafe DebugDisplaySettingsMaterial.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001931 RID: 6449
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001932 RID: 6450
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001933 RID: 6451
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoHueTolerance_b__0_Internal_Single_0;

				// Token: 0x04001934 RID: 6452
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoHueTolerance_b__1_Internal_Void_Single_0;

				// Token: 0x04001935 RID: 6453
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoHueTolerance_b__2_Internal_Boolean_0;
			}

			// Token: 0x0200022A RID: 554
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c__DisplayClass8_0")]
			public sealed class __c__DisplayClass8_0 : Object
			{
				// Token: 0x06002441 RID: 9281 RVA: 0x00087E3C File Offset: 0x0008603C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass8_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass8_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr, 100664242);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateAlbedoSaturationTolerance_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr, 100664243);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateAlbedoSaturationTolerance_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr, 100664244);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateAlbedoSaturationTolerance_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr, 100664245);
				}

				// Token: 0x06002442 RID: 9282 RVA: 0x00087ECC File Offset: 0x000860CC
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass8_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002443 RID: 9283 RVA: 0x00087F08 File Offset: 0x00086108
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603989, XrefRangeEnd = 603990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe float _CreateAlbedoSaturationTolerance_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateAlbedoSaturationTolerance_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002444 RID: 9284 RVA: 0x00087F44 File Offset: 0x00086144
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603990, XrefRangeEnd = 603991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateAlbedoSaturationTolerance_b__1(float value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateAlbedoSaturationTolerance_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002445 RID: 9285 RVA: 0x00087F84 File Offset: 0x00086184
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603991, XrefRangeEnd = 603992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _CreateAlbedoSaturationTolerance_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateAlbedoSaturationTolerance_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002446 RID: 9286 RVA: 0x00014C29 File Offset: 0x00012E29
				public __c__DisplayClass8_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CF2 RID: 3314
				// (get) Token: 0x06002447 RID: 9287 RVA: 0x00087FC0 File Offset: 0x000861C0
				// (set) Token: 0x06002448 RID: 9288 RVA: 0x00014C32 File Offset: 0x00012E32
				public unsafe DebugDisplaySettingsMaterial.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass8_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001936 RID: 6454
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001937 RID: 6455
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001938 RID: 6456
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoSaturationTolerance_b__0_Internal_Single_0;

				// Token: 0x04001939 RID: 6457
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoSaturationTolerance_b__1_Internal_Void_Single_0;

				// Token: 0x0400193A RID: 6458
				private static readonly IntPtr NativeMethodInfoPtr__CreateAlbedoSaturationTolerance_b__2_Internal_Boolean_0;
			}

			// Token: 0x0200022B RID: 555
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c__DisplayClass9_0")]
			public sealed class __c__DisplayClass9_0 : Object
			{
				// Token: 0x06002449 RID: 9289 RVA: 0x00087FF0 File Offset: 0x000861F0
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass9_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass9_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr, 100664246);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateMetallicMinValue_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr, 100664247);
					DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateMetallicMinValue_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr, 100664248);
				}

				// Token: 0x0600244A RID: 9290 RVA: 0x0008806C File Offset: 0x0008626C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass9_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600244B RID: 9291 RVA: 0x000880A8 File Offset: 0x000862A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603992, XrefRangeEnd = 603993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe float _CreateMetallicMinValue_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateMetallicMinValue_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600244C RID: 9292 RVA: 0x000880E4 File Offset: 0x000862E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603993, XrefRangeEnd = 603994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateMetallicMinValue_b__1(float value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateMetallicMinValue_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600244D RID: 9293 RVA: 0x00014C51 File Offset: 0x00012E51
				public __c__DisplayClass9_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CF3 RID: 3315
				// (get) Token: 0x0600244E RID: 9294 RVA: 0x00088124 File Offset: 0x00086324
				// (set) Token: 0x0600244F RID: 9295 RVA: 0x00014C5A File Offset: 0x00012E5A
				public unsafe DebugDisplaySettingsMaterial.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.WidgetFactory.__c__DisplayClass9_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400193B RID: 6459
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x0400193C RID: 6460
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400193D RID: 6461
				private static readonly IntPtr NativeMethodInfoPtr__CreateMetallicMinValue_b__0_Internal_Single_0;

				// Token: 0x0400193E RID: 6462
				private static readonly IntPtr NativeMethodInfoPtr__CreateMetallicMinValue_b__1_Internal_Void_Single_0;
			}
		}

		// Token: 0x02000175 RID: 373
		public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsMaterial>
		{
			// Token: 0x06001C4F RID: 7247 RVA: 0x00010169 File Offset: 0x0000E369
			// Note: this type is marked as 'beforefieldinit'.
			static SettingsPanel()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsMaterial.SettingsPanel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial>.NativeClassPtr, "SettingsPanel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.SettingsPanel>.NativeClassPtr);
				DebugDisplaySettingsMaterial.SettingsPanel.NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.SettingsPanel>.NativeClassPtr, 100664249);
			}

			// Token: 0x06001C50 RID: 7248 RVA: 0x000747CC File Offset: 0x000729CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604701, RefRangeEnd = 604702, XrefRangeStart = 604459, XrefRangeEnd = 604701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SettingsPanel(DebugDisplaySettingsMaterial data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.SettingsPanel>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.SettingsPanel.NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C51 RID: 7249 RVA: 0x0001019D File Offset: 0x0000E39D
			public SettingsPanel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400149B RID: 5275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsMaterial_0;

			// Token: 0x0200022C RID: 556
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel+<>c__DisplayClass0_0")]
			public sealed class __c__DisplayClass0_0 : Object
			{
				// Token: 0x06002450 RID: 9296 RVA: 0x00088154 File Offset: 0x00086354
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass0_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.SettingsPanel>.NativeClassPtr, "<>c__DisplayClass0_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0>.NativeClassPtr);
					DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0>.NativeClassPtr, "data");
					DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0>.NativeClassPtr, 100664250);
					DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0>.NativeClassPtr, 100664251);
					DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0.NativeMethodInfoPtr___ctor_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0>.NativeClassPtr, 100664252);
				}

				// Token: 0x06002451 RID: 9297 RVA: 0x000881D0 File Offset: 0x000863D0
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass0_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002452 RID: 9298 RVA: 0x0008820C File Offset: 0x0008640C
				[CallerCount(0)]
				public unsafe bool __ctor_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002453 RID: 9299 RVA: 0x00088248 File Offset: 0x00086448
				[CallerCount(0)]
				public unsafe bool __ctor_b__1()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0.NativeMethodInfoPtr___ctor_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002454 RID: 9300 RVA: 0x00014C79 File Offset: 0x00012E79
				public __c__DisplayClass0_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CF4 RID: 3316
				// (get) Token: 0x06002455 RID: 9301 RVA: 0x00088284 File Offset: 0x00086484
				// (set) Token: 0x06002456 RID: 9302 RVA: 0x00014C82 File Offset: 0x00012E82
				public unsafe DebugDisplaySettingsMaterial data
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0.NativeFieldInfoPtr_data);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsMaterial.SettingsPanel.__c__DisplayClass0_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400193F RID: 6463
				private static readonly IntPtr NativeFieldInfoPtr_data;

				// Token: 0x04001940 RID: 6464
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001941 RID: 6465
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_0;

				// Token: 0x04001942 RID: 6466
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__1_Internal_Boolean_0;
			}
		}
	}
}
