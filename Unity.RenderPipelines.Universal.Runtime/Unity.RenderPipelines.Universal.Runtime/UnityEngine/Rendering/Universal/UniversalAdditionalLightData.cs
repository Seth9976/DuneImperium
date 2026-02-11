using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000ED RID: 237
	public class UniversalAdditionalLightData : MonoBehaviour
	{
		// Token: 0x06001203 RID: 4611 RVA: 0x00053E64 File Offset: 0x00052064
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalAdditionalLightData()
		{
			Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalAdditionalLightData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr);
			UniversalAdditionalLightData.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_Version");
			UniversalAdditionalLightData.NativeFieldInfoPtr_m_UsePipelineSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_UsePipelineSettings");
			UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierCustom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowResolutionTierCustom");
			UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowResolutionTierLow");
			UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierMedium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowResolutionTierMedium");
			UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowResolutionTierHigh");
			UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowDefaultResolutionTier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowDefaultResolutionTier");
			UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowDefaultCustomResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowDefaultCustomResolution");
			UniversalAdditionalLightData.NativeFieldInfoPtr_m_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_Light");
			UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowMinimumResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowMinimumResolution");
			UniversalAdditionalLightData.NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_AdditionalLightsShadowResolutionTier");
			UniversalAdditionalLightData.NativeFieldInfoPtr_m_LightLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_LightLayerMask");
			UniversalAdditionalLightData.NativeFieldInfoPtr_m_RenderingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_RenderingLayers");
			UniversalAdditionalLightData.NativeFieldInfoPtr_m_CustomShadowLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_CustomShadowLayers");
			UniversalAdditionalLightData.NativeFieldInfoPtr_m_ShadowLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_ShadowLayerMask");
			UniversalAdditionalLightData.NativeFieldInfoPtr_m_ShadowRenderingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_ShadowRenderingLayers");
			UniversalAdditionalLightData.NativeFieldInfoPtr_m_LightCookieSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_LightCookieSize");
			UniversalAdditionalLightData.NativeFieldInfoPtr_m_LightCookieOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_LightCookieOffset");
			UniversalAdditionalLightData.NativeFieldInfoPtr_m_SoftShadowQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_SoftShadowQuality");
			UniversalAdditionalLightData.NativeMethodInfoPtr_get_version_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665580);
			UniversalAdditionalLightData.NativeMethodInfoPtr_get_usePipelineSettings_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665581);
			UniversalAdditionalLightData.NativeMethodInfoPtr_set_usePipelineSettings_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665582);
			UniversalAdditionalLightData.NativeMethodInfoPtr_get_light_Internal_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665583);
			UniversalAdditionalLightData.NativeMethodInfoPtr_get_additionalLightsShadowResolutionTier_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665584);
			UniversalAdditionalLightData.NativeMethodInfoPtr_get_lightLayerMask_Public_get_LightLayerEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665585);
			UniversalAdditionalLightData.NativeMethodInfoPtr_set_lightLayerMask_Public_set_Void_LightLayerEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665586);
			UniversalAdditionalLightData.NativeMethodInfoPtr_get_renderingLayers_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665587);
			UniversalAdditionalLightData.NativeMethodInfoPtr_set_renderingLayers_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665588);
			UniversalAdditionalLightData.NativeMethodInfoPtr_get_customShadowLayers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665589);
			UniversalAdditionalLightData.NativeMethodInfoPtr_set_customShadowLayers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665590);
			UniversalAdditionalLightData.NativeMethodInfoPtr_get_shadowLayerMask_Public_get_LightLayerEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665591);
			UniversalAdditionalLightData.NativeMethodInfoPtr_set_shadowLayerMask_Public_set_Void_LightLayerEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665592);
			UniversalAdditionalLightData.NativeMethodInfoPtr_get_shadowRenderingLayers_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665593);
			UniversalAdditionalLightData.NativeMethodInfoPtr_set_shadowRenderingLayers_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665594);
			UniversalAdditionalLightData.NativeMethodInfoPtr_get_lightCookieSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665595);
			UniversalAdditionalLightData.NativeMethodInfoPtr_set_lightCookieSize_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665596);
			UniversalAdditionalLightData.NativeMethodInfoPtr_get_lightCookieOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665597);
			UniversalAdditionalLightData.NativeMethodInfoPtr_set_lightCookieOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665598);
			UniversalAdditionalLightData.NativeMethodInfoPtr_get_softShadowQuality_Public_get_SoftShadowQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665599);
			UniversalAdditionalLightData.NativeMethodInfoPtr_set_softShadowQuality_Public_set_Void_SoftShadowQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665600);
			UniversalAdditionalLightData.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665601);
			UniversalAdditionalLightData.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665602);
			UniversalAdditionalLightData.NativeMethodInfoPtr_SyncLightAndShadowLayers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665603);
			UniversalAdditionalLightData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665604);
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x00054204 File Offset: 0x00052404
		public unsafe int version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_get_version_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x00054240 File Offset: 0x00052440
		// (set) Token: 0x06001206 RID: 4614 RVA: 0x0005427C File Offset: 0x0005247C
		public unsafe bool usePipelineSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_get_usePipelineSettings_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_set_usePipelineSettings_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x000542BC File Offset: 0x000524BC
		public unsafe Light light
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 619216, RefRangeEnd = 619218, XrefRangeStart = 619209, XrefRangeEnd = 619216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_get_light_Internal_get_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Light>(intPtr3) : null;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x000542FC File Offset: 0x000524FC
		public unsafe int additionalLightsShadowResolutionTier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_get_additionalLightsShadowResolutionTier_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x00054338 File Offset: 0x00052538
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x00054374 File Offset: 0x00052574
		public unsafe LightLayerEnum lightLayerMask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_get_lightLayerMask_Public_get_LightLayerEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_set_lightLayerMask_Public_set_Void_LightLayerEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x000543B4 File Offset: 0x000525B4
		// (set) Token: 0x0600120C RID: 4620 RVA: 0x000543F0 File Offset: 0x000525F0
		public unsafe uint renderingLayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_get_renderingLayers_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619218, XrefRangeEnd = 619219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_set_renderingLayers_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x00054430 File Offset: 0x00052630
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x0005446C File Offset: 0x0005266C
		public unsafe bool customShadowLayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_get_customShadowLayers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619219, XrefRangeEnd = 619220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_set_customShadowLayers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x000544AC File Offset: 0x000526AC
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x000544E8 File Offset: 0x000526E8
		public unsafe LightLayerEnum shadowLayerMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_get_shadowLayerMask_Public_get_LightLayerEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_set_shadowLayerMask_Public_set_Void_LightLayerEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x00054528 File Offset: 0x00052728
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x00054564 File Offset: 0x00052764
		public unsafe uint shadowRenderingLayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_get_shadowRenderingLayers_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619220, XrefRangeEnd = 619221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_set_shadowRenderingLayers_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x000545A4 File Offset: 0x000527A4
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x000545E0 File Offset: 0x000527E0
		public unsafe Vector2 lightCookieSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_get_lightCookieSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_set_lightCookieSize_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00054620 File Offset: 0x00052820
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x0005465C File Offset: 0x0005285C
		public unsafe Vector2 lightCookieOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_get_lightCookieOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_set_lightCookieOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0005469C File Offset: 0x0005289C
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x000546D8 File Offset: 0x000528D8
		public unsafe SoftShadowQuality softShadowQuality
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_get_softShadowQuality_Public_get_SoftShadowQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 403849, RefRangeEnd = 403852, XrefRangeStart = 403849, XrefRangeEnd = 403852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_set_softShadowQuality_Public_set_Void_SoftShadowQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00054718 File Offset: 0x00052918
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0005474C File Offset: 0x0005294C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619221, XrefRangeEnd = 619227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x00054780 File Offset: 0x00052980
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 619235, RefRangeEnd = 619238, XrefRangeStart = 619227, XrefRangeEnd = 619235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncLightAndShadowLayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr_SyncLightAndShadowLayers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x000547B4 File Offset: 0x000529B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619238, XrefRangeEnd = 619247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalAdditionalLightData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalLightData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0000AA9B File Offset: 0x00008C9B
		public UniversalAdditionalLightData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x000547F0 File Offset: 0x000529F0
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x0000AAA4 File Offset: 0x00008CA4
		public unsafe int m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x00054818 File Offset: 0x00052A18
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x0000AABF File Offset: 0x00008CBF
		public unsafe bool m_UsePipelineSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_UsePipelineSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_UsePipelineSettings)) = value;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x00054840 File Offset: 0x00052A40
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x0000AADA File Offset: 0x00008CDA
		public unsafe static int AdditionalLightsShadowResolutionTierCustom
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierCustom, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierCustom, (void*)(&value));
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x0005485C File Offset: 0x00052A5C
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		public unsafe static int AdditionalLightsShadowResolutionTierLow
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierLow, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierLow, (void*)(&value));
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x00054878 File Offset: 0x00052A78
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x0000AAF6 File Offset: 0x00008CF6
		public unsafe static int AdditionalLightsShadowResolutionTierMedium
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierMedium, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierMedium, (void*)(&value));
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00054894 File Offset: 0x00052A94
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x0000AB04 File Offset: 0x00008D04
		public unsafe static int AdditionalLightsShadowResolutionTierHigh
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierHigh, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierHigh, (void*)(&value));
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x000548B0 File Offset: 0x00052AB0
		// (set) Token: 0x0600122B RID: 4651 RVA: 0x0000AB12 File Offset: 0x00008D12
		public unsafe static int AdditionalLightsShadowDefaultResolutionTier
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowDefaultResolutionTier, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowDefaultResolutionTier, (void*)(&value));
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x000548CC File Offset: 0x00052ACC
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x0000AB20 File Offset: 0x00008D20
		public unsafe static int AdditionalLightsShadowDefaultCustomResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowDefaultCustomResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowDefaultCustomResolution, (void*)(&value));
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x000548E8 File Offset: 0x00052AE8
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x0000AB2E File Offset: 0x00008D2E
		public unsafe Light m_Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00054918 File Offset: 0x00052B18
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x0000AB4D File Offset: 0x00008D4D
		public unsafe static int AdditionalLightsShadowMinimumResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowMinimumResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalLightData.NativeFieldInfoPtr_AdditionalLightsShadowMinimumResolution, (void*)(&value));
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00054934 File Offset: 0x00052B34
		// (set) Token: 0x06001233 RID: 4659 RVA: 0x0000AB5B File Offset: 0x00008D5B
		public unsafe int m_AdditionalLightsShadowResolutionTier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTier)) = value;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x0005495C File Offset: 0x00052B5C
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x0000AB76 File Offset: 0x00008D76
		public unsafe LightLayerEnum m_LightLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_LightLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_LightLayerMask)) = value;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x00054984 File Offset: 0x00052B84
		// (set) Token: 0x06001237 RID: 4663 RVA: 0x0000AB91 File Offset: 0x00008D91
		public unsafe uint m_RenderingLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_RenderingLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_RenderingLayers)) = value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x000549AC File Offset: 0x00052BAC
		// (set) Token: 0x06001239 RID: 4665 RVA: 0x0000ABAC File Offset: 0x00008DAC
		public unsafe bool m_CustomShadowLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_CustomShadowLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_CustomShadowLayers)) = value;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x000549D4 File Offset: 0x00052BD4
		// (set) Token: 0x0600123B RID: 4667 RVA: 0x0000ABC7 File Offset: 0x00008DC7
		public unsafe LightLayerEnum m_ShadowLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_ShadowLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_ShadowLayerMask)) = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x000549FC File Offset: 0x00052BFC
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x0000ABE2 File Offset: 0x00008DE2
		public unsafe uint m_ShadowRenderingLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_ShadowRenderingLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_ShadowRenderingLayers)) = value;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x00054A24 File Offset: 0x00052C24
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x0000ABFD File Offset: 0x00008DFD
		public unsafe Vector2 m_LightCookieSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_LightCookieSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_LightCookieSize)) = value;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x00054A4C File Offset: 0x00052C4C
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x0000AC18 File Offset: 0x00008E18
		public unsafe Vector2 m_LightCookieOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_LightCookieOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_LightCookieOffset)) = value;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x00054A74 File Offset: 0x00052C74
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x0000AC33 File Offset: 0x00008E33
		public unsafe SoftShadowQuality m_SoftShadowQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_SoftShadowQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalLightData.NativeFieldInfoPtr_m_SoftShadowQuality)) = value;
			}
		}

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeFieldInfoPtr_m_UsePipelineSettings;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierCustom;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierLow;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierMedium;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierHigh;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowDefaultResolutionTier;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowDefaultCustomResolution;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeFieldInfoPtr_m_Light;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowMinimumResolution;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTier;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeFieldInfoPtr_m_LightLayerMask;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderingLayers;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomShadowLayers;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowLayerMask;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowRenderingLayers;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeFieldInfoPtr_m_LightCookieSize;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeFieldInfoPtr_m_LightCookieOffset;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeFieldInfoPtr_m_SoftShadowQuality;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Internal_get_Int32_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_get_usePipelineSettings_Public_get_Boolean_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_set_usePipelineSettings_Public_set_Void_Boolean_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_get_light_Internal_get_Light_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_get_additionalLightsShadowResolutionTier_Public_get_Int32_0;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_get_lightLayerMask_Public_get_LightLayerEnum_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_set_lightLayerMask_Public_set_Void_LightLayerEnum_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingLayers_Public_get_UInt32_0;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingLayers_Public_set_Void_UInt32_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_get_customShadowLayers_Public_get_Boolean_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_set_customShadowLayers_Public_set_Void_Boolean_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowLayerMask_Public_get_LightLayerEnum_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowLayerMask_Public_set_Void_LightLayerEnum_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowRenderingLayers_Public_get_UInt32_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowRenderingLayers_Public_set_Void_UInt32_0;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeMethodInfoPtr_get_lightCookieSize_Public_get_Vector2_0;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeMethodInfoPtr_set_lightCookieSize_Public_set_Void_Vector2_0;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_get_lightCookieOffset_Public_get_Vector2_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_set_lightCookieOffset_Public_set_Void_Vector2_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_get_softShadowQuality_Public_get_SoftShadowQuality_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_set_softShadowQuality_Public_set_Void_SoftShadowQuality_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_SyncLightAndShadowLayers_Private_Void_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
