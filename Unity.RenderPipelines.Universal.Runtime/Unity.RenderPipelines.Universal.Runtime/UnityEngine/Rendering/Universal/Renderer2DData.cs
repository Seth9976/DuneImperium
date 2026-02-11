using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000037 RID: 55
	[Serializable]
	public class Renderer2DData : ScriptableRendererData
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x000258F8 File Offset: 0x00023AF8
		// Note: this type is marked as 'beforefieldinit'.
		static Renderer2DData()
		{
			Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Renderer2DData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr);
			Renderer2DData.NativeFieldInfoPtr_m_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_LayerMask");
			Renderer2DData.NativeFieldInfoPtr_m_TransparencySortMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_TransparencySortMode");
			Renderer2DData.NativeFieldInfoPtr_m_TransparencySortAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_TransparencySortAxis");
			Renderer2DData.NativeFieldInfoPtr_m_HDREmulationScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_HDREmulationScale");
			Renderer2DData.NativeFieldInfoPtr_m_LightRenderTextureScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_LightRenderTextureScale");
			Renderer2DData.NativeFieldInfoPtr_m_LightBlendStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_LightBlendStyles");
			Renderer2DData.NativeFieldInfoPtr_m_UseDepthStencilBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_UseDepthStencilBuffer");
			Renderer2DData.NativeFieldInfoPtr_m_UseCameraSortingLayersTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_UseCameraSortingLayersTexture");
			Renderer2DData.NativeFieldInfoPtr_m_CameraSortingLayersTextureBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_CameraSortingLayersTextureBound");
			Renderer2DData.NativeFieldInfoPtr_m_CameraSortingLayerDownsamplingMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_CameraSortingLayerDownsamplingMethod");
			Renderer2DData.NativeFieldInfoPtr_m_MaxLightRenderTextureCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_MaxLightRenderTextureCount");
			Renderer2DData.NativeFieldInfoPtr_m_MaxShadowRenderTextureCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_MaxShadowRenderTextureCount");
			Renderer2DData.NativeFieldInfoPtr_m_ShapeLightShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_ShapeLightShader");
			Renderer2DData.NativeFieldInfoPtr_m_ShapeLightVolumeShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_ShapeLightVolumeShader");
			Renderer2DData.NativeFieldInfoPtr_m_PointLightShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_PointLightShader");
			Renderer2DData.NativeFieldInfoPtr_m_PointLightVolumeShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_PointLightVolumeShader");
			Renderer2DData.NativeFieldInfoPtr_m_CoreBlitShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_CoreBlitShader");
			Renderer2DData.NativeFieldInfoPtr_m_BlitHDROverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_BlitHDROverlay");
			Renderer2DData.NativeFieldInfoPtr_m_CoreBlitColorAndDepthPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_CoreBlitColorAndDepthPS");
			Renderer2DData.NativeFieldInfoPtr_m_SamplingShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_SamplingShader");
			Renderer2DData.NativeFieldInfoPtr_m_ProjectedShadowShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_ProjectedShadowShader");
			Renderer2DData.NativeFieldInfoPtr_m_SpriteShadowShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_SpriteShadowShader");
			Renderer2DData.NativeFieldInfoPtr_m_SpriteUnshadowShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_SpriteUnshadowShader");
			Renderer2DData.NativeFieldInfoPtr_m_GeometryUnshadowShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_GeometryUnshadowShader");
			Renderer2DData.NativeFieldInfoPtr_m_FallbackErrorShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_FallbackErrorShader");
			Renderer2DData.NativeFieldInfoPtr_m_PostProcessData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_PostProcessData");
			Renderer2DData.NativeFieldInfoPtr_m_FallOffLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "m_FallOffLookup");
			Renderer2DData.NativeFieldInfoPtr__lightMaterials_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "<lightMaterials>k__BackingField");
			Renderer2DData.NativeFieldInfoPtr__spriteSelfShadowMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "<spriteSelfShadowMaterial>k__BackingField");
			Renderer2DData.NativeFieldInfoPtr__spriteUnshadowMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "<spriteUnshadowMaterial>k__BackingField");
			Renderer2DData.NativeFieldInfoPtr__geometryUnshadowMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "<geometryUnshadowMaterial>k__BackingField");
			Renderer2DData.NativeFieldInfoPtr__projectedShadowMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "<projectedShadowMaterial>k__BackingField");
			Renderer2DData.NativeFieldInfoPtr__stencilOnlyShadowMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "<stencilOnlyShadowMaterial>k__BackingField");
			Renderer2DData.NativeFieldInfoPtr__isNormalsRenderTargetValid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "<isNormalsRenderTargetValid>k__BackingField");
			Renderer2DData.NativeFieldInfoPtr__normalsRenderTargetScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "<normalsRenderTargetScale>k__BackingField");
			Renderer2DData.NativeFieldInfoPtr_normalsRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "normalsRenderTarget");
			Renderer2DData.NativeFieldInfoPtr_normalsRenderTargetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "normalsRenderTargetId");
			Renderer2DData.NativeFieldInfoPtr_shadowsRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "shadowsRenderTarget");
			Renderer2DData.NativeFieldInfoPtr_shadowsRenderTargetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "shadowsRenderTargetId");
			Renderer2DData.NativeFieldInfoPtr_cameraSortingLayerRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "cameraSortingLayerRenderTarget");
			Renderer2DData.NativeFieldInfoPtr_cameraSortingLayerRenderTargetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "cameraSortingLayerRenderTargetId");
			Renderer2DData.NativeFieldInfoPtr__lightCullResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, "<lightCullResult>k__BackingField");
			Renderer2DData.NativeMethodInfoPtr_get_hdrEmulationScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663838);
			Renderer2DData.NativeMethodInfoPtr_get_lightRenderTextureScale_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663839);
			Renderer2DData.NativeMethodInfoPtr_get_lightBlendStyles_Public_get_Il2CppReferenceArray_1_Light2DBlendStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663840);
			Renderer2DData.NativeMethodInfoPtr_get_useDepthStencilBuffer_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663841);
			Renderer2DData.NativeMethodInfoPtr_get_fallOffLookup_Internal_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663842);
			Renderer2DData.NativeMethodInfoPtr_get_shapeLightShader_Internal_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663843);
			Renderer2DData.NativeMethodInfoPtr_get_shapeLightVolumeShader_Internal_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663844);
			Renderer2DData.NativeMethodInfoPtr_get_pointLightShader_Internal_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663845);
			Renderer2DData.NativeMethodInfoPtr_get_pointLightVolumeShader_Internal_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663846);
			Renderer2DData.NativeMethodInfoPtr_get_blitShader_Internal_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663847);
			Renderer2DData.NativeMethodInfoPtr_get_blitHDROverlay_Internal_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663848);
			Renderer2DData.NativeMethodInfoPtr_get_coreBlitPS_Internal_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663849);
			Renderer2DData.NativeMethodInfoPtr_get_coreBlitColorAndDepthPS_Internal_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663850);
			Renderer2DData.NativeMethodInfoPtr_get_samplingShader_Internal_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663851);
			Renderer2DData.NativeMethodInfoPtr_get_postProcessData_Internal_get_PostProcessData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663852);
			Renderer2DData.NativeMethodInfoPtr_set_postProcessData_Internal_set_Void_PostProcessData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663853);
			Renderer2DData.NativeMethodInfoPtr_get_spriteShadowShader_Internal_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663854);
			Renderer2DData.NativeMethodInfoPtr_get_spriteUnshadowShader_Internal_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663855);
			Renderer2DData.NativeMethodInfoPtr_get_geometryUnshadowShader_Internal_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663856);
			Renderer2DData.NativeMethodInfoPtr_get_projectedShadowShader_Internal_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663857);
			Renderer2DData.NativeMethodInfoPtr_get_transparencySortMode_Internal_get_TransparencySortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663858);
			Renderer2DData.NativeMethodInfoPtr_get_transparencySortAxis_Internal_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663859);
			Renderer2DData.NativeMethodInfoPtr_get_lightRenderTextureMemoryBudget_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663860);
			Renderer2DData.NativeMethodInfoPtr_get_shadowRenderTextureMemoryBudget_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663861);
			Renderer2DData.NativeMethodInfoPtr_get_useCameraSortingLayerTexture_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663862);
			Renderer2DData.NativeMethodInfoPtr_get_cameraSortingLayerTextureBound_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663863);
			Renderer2DData.NativeMethodInfoPtr_get_cameraSortingLayerDownsamplingMethod_Internal_get_Downsampling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663864);
			Renderer2DData.NativeMethodInfoPtr_get_layerMask_Internal_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663865);
			Renderer2DData.NativeMethodInfoPtr_Create_Protected_Virtual_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663866);
			Renderer2DData.NativeMethodInfoPtr_Dispose_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663867);
			Renderer2DData.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663868);
			Renderer2DData.NativeMethodInfoPtr_get_lightMaterials_Internal_get_Dictionary_2_UInt32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663869);
			Renderer2DData.NativeMethodInfoPtr_get_spriteSelfShadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663870);
			Renderer2DData.NativeMethodInfoPtr_set_spriteSelfShadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663871);
			Renderer2DData.NativeMethodInfoPtr_get_spriteUnshadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663872);
			Renderer2DData.NativeMethodInfoPtr_set_spriteUnshadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663873);
			Renderer2DData.NativeMethodInfoPtr_get_geometryUnshadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663874);
			Renderer2DData.NativeMethodInfoPtr_set_geometryUnshadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663875);
			Renderer2DData.NativeMethodInfoPtr_get_projectedShadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663876);
			Renderer2DData.NativeMethodInfoPtr_set_projectedShadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663877);
			Renderer2DData.NativeMethodInfoPtr_get_stencilOnlyShadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663878);
			Renderer2DData.NativeMethodInfoPtr_set_stencilOnlyShadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663879);
			Renderer2DData.NativeMethodInfoPtr_get_isNormalsRenderTargetValid_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663880);
			Renderer2DData.NativeMethodInfoPtr_set_isNormalsRenderTargetValid_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663881);
			Renderer2DData.NativeMethodInfoPtr_get_normalsRenderTargetScale_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663882);
			Renderer2DData.NativeMethodInfoPtr_set_normalsRenderTargetScale_Internal_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663883);
			Renderer2DData.NativeMethodInfoPtr_get_lightCullResult_Internal_get_ILight2DCullResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663884);
			Renderer2DData.NativeMethodInfoPtr_set_lightCullResult_Internal_set_Void_ILight2DCullResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663885);
			Renderer2DData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr, 100663886);
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00026044 File Offset: 0x00024244
		public unsafe float hdrEmulationScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_hdrEmulationScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00026080 File Offset: 0x00024280
		public unsafe float lightRenderTextureScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_lightRenderTextureScale_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x000260BC File Offset: 0x000242BC
		public unsafe Il2CppReferenceArray<Light2DBlendStyle> lightBlendStyles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_lightBlendStyles_Public_get_Il2CppReferenceArray_1_Light2DBlendStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light2DBlendStyle>>(intPtr3) : null;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x000260FC File Offset: 0x000242FC
		public unsafe bool useDepthStencilBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_useDepthStencilBuffer_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00026138 File Offset: 0x00024338
		public unsafe Texture2D fallOffLookup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_fallOffLookup_Internal_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00026178 File Offset: 0x00024378
		public unsafe Shader shapeLightShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_shapeLightShader_Internal_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x000261B8 File Offset: 0x000243B8
		public unsafe Shader shapeLightVolumeShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_shapeLightVolumeShader_Internal_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x000261F8 File Offset: 0x000243F8
		public unsafe Shader pointLightShader
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_pointLightShader_Internal_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00026238 File Offset: 0x00024438
		public unsafe Shader pointLightVolumeShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_pointLightVolumeShader_Internal_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00026278 File Offset: 0x00024478
		public unsafe Shader blitShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_blitShader_Internal_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x000262B8 File Offset: 0x000244B8
		public unsafe Shader blitHDROverlay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_blitHDROverlay_Internal_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x000262F8 File Offset: 0x000244F8
		public unsafe Shader coreBlitPS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_coreBlitPS_Internal_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00026338 File Offset: 0x00024538
		public unsafe Shader coreBlitColorAndDepthPS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_coreBlitColorAndDepthPS_Internal_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00026378 File Offset: 0x00024578
		public unsafe Shader samplingShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_samplingShader_Internal_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x000263B8 File Offset: 0x000245B8
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x000263F8 File Offset: 0x000245F8
		public unsafe PostProcessData postProcessData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_postProcessData_Internal_get_PostProcessData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessData>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_set_postProcessData_Internal_set_Void_PostProcessData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0002643C File Offset: 0x0002463C
		public unsafe Shader spriteShadowShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_spriteShadowShader_Internal_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0002647C File Offset: 0x0002467C
		public unsafe Shader spriteUnshadowShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_spriteUnshadowShader_Internal_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x000264BC File Offset: 0x000246BC
		public unsafe Shader geometryUnshadowShader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39587, RefRangeEnd = 39588, XrefRangeStart = 39587, XrefRangeEnd = 39588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_geometryUnshadowShader_Internal_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x000264FC File Offset: 0x000246FC
		public unsafe Shader projectedShadowShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_projectedShadowShader_Internal_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0002653C File Offset: 0x0002473C
		public unsafe TransparencySortMode transparencySortMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_transparencySortMode_Internal_get_TransparencySortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00026578 File Offset: 0x00024778
		public unsafe Vector3 transparencySortAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_transparencySortAxis_Internal_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000265B4 File Offset: 0x000247B4
		public unsafe uint lightRenderTextureMemoryBudget
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368218, RefRangeEnd = 368219, XrefRangeStart = 368218, XrefRangeEnd = 368219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_lightRenderTextureMemoryBudget_Internal_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x000265F0 File Offset: 0x000247F0
		public unsafe uint shadowRenderTextureMemoryBudget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_shadowRenderTextureMemoryBudget_Internal_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0002662C File Offset: 0x0002482C
		public unsafe bool useCameraSortingLayerTexture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_useCameraSortingLayerTexture_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00026668 File Offset: 0x00024868
		public unsafe int cameraSortingLayerTextureBound
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_cameraSortingLayerTextureBound_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000266A4 File Offset: 0x000248A4
		public unsafe Downsampling cameraSortingLayerDownsamplingMethod
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368217, RefRangeEnd = 368218, XrefRangeStart = 368217, XrefRangeEnd = 368218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_cameraSortingLayerDownsamplingMethod_Internal_get_Downsampling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x000266E0 File Offset: 0x000248E0
		public unsafe LayerMask layerMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_layerMask_Internal_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0002671C File Offset: 0x0002491C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602133, XrefRangeEnd = 602137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ScriptableRenderer Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Renderer2DData.NativeMethodInfoPtr_Create_Protected_Virtual_ScriptableRenderer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr3) : null;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00026768 File Offset: 0x00024968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 602161, RefRangeEnd = 602162, XrefRangeStart = 602137, XrefRangeEnd = 602161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_Dispose_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0002679C File Offset: 0x0002499C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602162, XrefRangeEnd = 602211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Renderer2DData.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x000267D8 File Offset: 0x000249D8
		public unsafe Dictionary<uint, Material> lightMaterials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_lightMaterials_Internal_get_Dictionary_2_UInt32_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, Material>>(intPtr3) : null;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00026818 File Offset: 0x00024A18
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00026858 File Offset: 0x00024A58
		public unsafe Il2CppReferenceArray<Material> spriteSelfShadowMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_spriteSelfShadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_set_spriteSelfShadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0002689C File Offset: 0x00024A9C
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x000268DC File Offset: 0x00024ADC
		public unsafe Il2CppReferenceArray<Material> spriteUnshadowMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_spriteUnshadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_set_spriteUnshadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00026920 File Offset: 0x00024B20
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00026960 File Offset: 0x00024B60
		public unsafe Il2CppReferenceArray<Material> geometryUnshadowMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_geometryUnshadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_set_geometryUnshadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x000269A4 File Offset: 0x00024BA4
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x000269E4 File Offset: 0x00024BE4
		public unsafe Il2CppReferenceArray<Material> projectedShadowMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_projectedShadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_set_projectedShadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00026A28 File Offset: 0x00024C28
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00026A68 File Offset: 0x00024C68
		public unsafe Il2CppReferenceArray<Material> stencilOnlyShadowMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_stencilOnlyShadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_set_stencilOnlyShadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00026AAC File Offset: 0x00024CAC
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00026AE8 File Offset: 0x00024CE8
		public unsafe bool isNormalsRenderTargetValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_isNormalsRenderTargetValid_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_set_isNormalsRenderTargetValid_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00026B28 File Offset: 0x00024D28
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00026B64 File Offset: 0x00024D64
		public unsafe float normalsRenderTargetScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_normalsRenderTargetScale_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_set_normalsRenderTargetScale_Internal_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00026BA4 File Offset: 0x00024DA4
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00026BE4 File Offset: 0x00024DE4
		public unsafe ILight2DCullResult lightCullResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_get_lightCullResult_Internal_get_ILight2DCullResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILight2DCullResult>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602211, XrefRangeEnd = 602212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr_set_lightCullResult_Internal_set_Void_ILight2DCullResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00026C28 File Offset: 0x00024E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602212, XrefRangeEnd = 602223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Renderer2DData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Renderer2DData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2DData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00003F1B File Offset: 0x0000211B
		public Renderer2DData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00026C64 File Offset: 0x00024E64
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00003F24 File Offset: 0x00002124
		public unsafe LayerMask m_LayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_LayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_LayerMask)) = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00026C8C File Offset: 0x00024E8C
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00003F3F File Offset: 0x0000213F
		public unsafe TransparencySortMode m_TransparencySortMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_TransparencySortMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_TransparencySortMode)) = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00026CB4 File Offset: 0x00024EB4
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x00003F5A File Offset: 0x0000215A
		public unsafe Vector3 m_TransparencySortAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_TransparencySortAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_TransparencySortAxis)) = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00026CDC File Offset: 0x00024EDC
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00003F75 File Offset: 0x00002175
		public unsafe float m_HDREmulationScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_HDREmulationScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_HDREmulationScale)) = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00026D04 File Offset: 0x00024F04
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00003F90 File Offset: 0x00002190
		public unsafe float m_LightRenderTextureScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_LightRenderTextureScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_LightRenderTextureScale)) = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00026D2C File Offset: 0x00024F2C
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00003FAB File Offset: 0x000021AB
		public unsafe Il2CppReferenceArray<Light2DBlendStyle> m_LightBlendStyles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_LightBlendStyles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light2DBlendStyle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_LightBlendStyles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00026D5C File Offset: 0x00024F5C
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00003FCA File Offset: 0x000021CA
		public unsafe bool m_UseDepthStencilBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_UseDepthStencilBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_UseDepthStencilBuffer)) = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00026D84 File Offset: 0x00024F84
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00003FE5 File Offset: 0x000021E5
		public unsafe bool m_UseCameraSortingLayersTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_UseCameraSortingLayersTexture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_UseCameraSortingLayersTexture)) = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00026DAC File Offset: 0x00024FAC
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00004000 File Offset: 0x00002200
		public unsafe int m_CameraSortingLayersTextureBound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_CameraSortingLayersTextureBound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_CameraSortingLayersTextureBound)) = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00026DD4 File Offset: 0x00024FD4
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x0000401B File Offset: 0x0000221B
		public unsafe Downsampling m_CameraSortingLayerDownsamplingMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_CameraSortingLayerDownsamplingMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_CameraSortingLayerDownsamplingMethod)) = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00026DFC File Offset: 0x00024FFC
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00004036 File Offset: 0x00002236
		public unsafe uint m_MaxLightRenderTextureCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_MaxLightRenderTextureCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_MaxLightRenderTextureCount)) = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00026E24 File Offset: 0x00025024
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00004051 File Offset: 0x00002251
		public unsafe uint m_MaxShadowRenderTextureCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_MaxShadowRenderTextureCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_MaxShadowRenderTextureCount)) = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00026E4C File Offset: 0x0002504C
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x0000406C File Offset: 0x0000226C
		public unsafe Shader m_ShapeLightShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_ShapeLightShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_ShapeLightShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00026E7C File Offset: 0x0002507C
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x0000408B File Offset: 0x0000228B
		public unsafe Shader m_ShapeLightVolumeShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_ShapeLightVolumeShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_ShapeLightVolumeShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00026EAC File Offset: 0x000250AC
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x000040AA File Offset: 0x000022AA
		public unsafe Shader m_PointLightShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_PointLightShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_PointLightShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00026EDC File Offset: 0x000250DC
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x000040C9 File Offset: 0x000022C9
		public unsafe Shader m_PointLightVolumeShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_PointLightVolumeShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_PointLightVolumeShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00026F0C File Offset: 0x0002510C
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x000040E8 File Offset: 0x000022E8
		public unsafe Shader m_CoreBlitShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_CoreBlitShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_CoreBlitShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00026F3C File Offset: 0x0002513C
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00004107 File Offset: 0x00002307
		public unsafe Shader m_BlitHDROverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_BlitHDROverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_BlitHDROverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00026F6C File Offset: 0x0002516C
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00004126 File Offset: 0x00002326
		public unsafe Shader m_CoreBlitColorAndDepthPS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_CoreBlitColorAndDepthPS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_CoreBlitColorAndDepthPS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00026F9C File Offset: 0x0002519C
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00004145 File Offset: 0x00002345
		public unsafe Shader m_SamplingShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_SamplingShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_SamplingShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00026FCC File Offset: 0x000251CC
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00004164 File Offset: 0x00002364
		public unsafe Shader m_ProjectedShadowShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_ProjectedShadowShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_ProjectedShadowShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00026FFC File Offset: 0x000251FC
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00004183 File Offset: 0x00002383
		public unsafe Shader m_SpriteShadowShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_SpriteShadowShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_SpriteShadowShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0002702C File Offset: 0x0002522C
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x000041A2 File Offset: 0x000023A2
		public unsafe Shader m_SpriteUnshadowShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_SpriteUnshadowShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_SpriteUnshadowShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0002705C File Offset: 0x0002525C
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x000041C1 File Offset: 0x000023C1
		public unsafe Shader m_GeometryUnshadowShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_GeometryUnshadowShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_GeometryUnshadowShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0002708C File Offset: 0x0002528C
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x000041E0 File Offset: 0x000023E0
		public unsafe Shader m_FallbackErrorShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_FallbackErrorShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_FallbackErrorShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x000270BC File Offset: 0x000252BC
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x000041FF File Offset: 0x000023FF
		public unsafe PostProcessData m_PostProcessData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_PostProcessData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_PostProcessData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x000270EC File Offset: 0x000252EC
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x0000421E File Offset: 0x0000241E
		public unsafe Texture2D m_FallOffLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_FallOffLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_m_FallOffLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x0002711C File Offset: 0x0002531C
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x0000423D File Offset: 0x0000243D
		public unsafe Dictionary<uint, Material> _lightMaterials_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__lightMaterials_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__lightMaterials_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0002714C File Offset: 0x0002534C
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x0000425C File Offset: 0x0000245C
		public unsafe Il2CppReferenceArray<Material> _spriteSelfShadowMaterial_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__spriteSelfShadowMaterial_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__spriteSelfShadowMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0002717C File Offset: 0x0002537C
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x0000427B File Offset: 0x0000247B
		public unsafe Il2CppReferenceArray<Material> _spriteUnshadowMaterial_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__spriteUnshadowMaterial_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__spriteUnshadowMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x000271AC File Offset: 0x000253AC
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x0000429A File Offset: 0x0000249A
		public unsafe Il2CppReferenceArray<Material> _geometryUnshadowMaterial_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__geometryUnshadowMaterial_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__geometryUnshadowMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x000271DC File Offset: 0x000253DC
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x000042B9 File Offset: 0x000024B9
		public unsafe Il2CppReferenceArray<Material> _projectedShadowMaterial_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__projectedShadowMaterial_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__projectedShadowMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0002720C File Offset: 0x0002540C
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x000042D8 File Offset: 0x000024D8
		public unsafe Il2CppReferenceArray<Material> _stencilOnlyShadowMaterial_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__stencilOnlyShadowMaterial_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__stencilOnlyShadowMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0002723C File Offset: 0x0002543C
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x000042F7 File Offset: 0x000024F7
		public unsafe bool _isNormalsRenderTargetValid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__isNormalsRenderTargetValid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__isNormalsRenderTargetValid_k__BackingField)) = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00027264 File Offset: 0x00025464
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00004312 File Offset: 0x00002512
		public unsafe float _normalsRenderTargetScale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__normalsRenderTargetScale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__normalsRenderTargetScale_k__BackingField)) = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0002728C File Offset: 0x0002548C
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x0000432D File Offset: 0x0000252D
		public unsafe RTHandle normalsRenderTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_normalsRenderTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_normalsRenderTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x000272BC File Offset: 0x000254BC
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x0000434C File Offset: 0x0000254C
		public unsafe int normalsRenderTargetId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_normalsRenderTargetId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_normalsRenderTargetId)) = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000272E4 File Offset: 0x000254E4
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00004367 File Offset: 0x00002567
		public unsafe RTHandle shadowsRenderTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_shadowsRenderTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_shadowsRenderTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00027314 File Offset: 0x00025514
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x00004386 File Offset: 0x00002586
		public unsafe int shadowsRenderTargetId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_shadowsRenderTargetId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_shadowsRenderTargetId)) = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0002733C File Offset: 0x0002553C
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x000043A1 File Offset: 0x000025A1
		public unsafe RTHandle cameraSortingLayerRenderTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_cameraSortingLayerRenderTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_cameraSortingLayerRenderTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0002736C File Offset: 0x0002556C
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x000043C0 File Offset: 0x000025C0
		public unsafe int cameraSortingLayerRenderTargetId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_cameraSortingLayerRenderTargetId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr_cameraSortingLayerRenderTargetId)) = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00027394 File Offset: 0x00025594
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x000043DB File Offset: 0x000025DB
		public unsafe ILight2DCullResult _lightCullResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__lightCullResult_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILight2DCullResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2DData.NativeFieldInfoPtr__lightCullResult_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeFieldInfoPtr_m_LayerMask;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr_m_TransparencySortMode;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeFieldInfoPtr_m_TransparencySortAxis;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeFieldInfoPtr_m_HDREmulationScale;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeFieldInfoPtr_m_LightRenderTextureScale;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeFieldInfoPtr_m_LightBlendStyles;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeFieldInfoPtr_m_UseDepthStencilBuffer;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeFieldInfoPtr_m_UseCameraSortingLayersTexture;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraSortingLayersTextureBound;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraSortingLayerDownsamplingMethod;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxLightRenderTextureCount;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxShadowRenderTextureCount;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeFieldInfoPtr_m_ShapeLightShader;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeFieldInfoPtr_m_ShapeLightVolumeShader;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeFieldInfoPtr_m_PointLightShader;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeFieldInfoPtr_m_PointLightVolumeShader;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeFieldInfoPtr_m_CoreBlitShader;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeFieldInfoPtr_m_BlitHDROverlay;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr_m_CoreBlitColorAndDepthPS;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeFieldInfoPtr_m_SamplingShader;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeFieldInfoPtr_m_ProjectedShadowShader;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteShadowShader;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteUnshadowShader;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeFieldInfoPtr_m_GeometryUnshadowShader;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeFieldInfoPtr_m_FallbackErrorShader;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeFieldInfoPtr_m_PostProcessData;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr_m_FallOffLookup;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr__lightMaterials_k__BackingField;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeFieldInfoPtr__spriteSelfShadowMaterial_k__BackingField;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeFieldInfoPtr__spriteUnshadowMaterial_k__BackingField;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeFieldInfoPtr__geometryUnshadowMaterial_k__BackingField;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeFieldInfoPtr__projectedShadowMaterial_k__BackingField;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeFieldInfoPtr__stencilOnlyShadowMaterial_k__BackingField;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeFieldInfoPtr__isNormalsRenderTargetValid_k__BackingField;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeFieldInfoPtr__normalsRenderTargetScale_k__BackingField;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeFieldInfoPtr_normalsRenderTarget;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeFieldInfoPtr_normalsRenderTargetId;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeFieldInfoPtr_shadowsRenderTarget;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeFieldInfoPtr_shadowsRenderTargetId;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeFieldInfoPtr_cameraSortingLayerRenderTarget;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeFieldInfoPtr_cameraSortingLayerRenderTargetId;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeFieldInfoPtr__lightCullResult_k__BackingField;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_get_hdrEmulationScale_Public_get_Single_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_get_lightRenderTextureScale_Internal_get_Single_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_get_lightBlendStyles_Public_get_Il2CppReferenceArray_1_Light2DBlendStyle_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_get_useDepthStencilBuffer_Internal_get_Boolean_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_get_fallOffLookup_Internal_get_Texture2D_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_get_shapeLightShader_Internal_get_Shader_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_get_shapeLightVolumeShader_Internal_get_Shader_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_get_pointLightShader_Internal_get_Shader_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_get_pointLightVolumeShader_Internal_get_Shader_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_get_blitShader_Internal_get_Shader_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_get_blitHDROverlay_Internal_get_Shader_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_get_coreBlitPS_Internal_get_Shader_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_get_coreBlitColorAndDepthPS_Internal_get_Shader_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_get_samplingShader_Internal_get_Shader_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_get_postProcessData_Internal_get_PostProcessData_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_set_postProcessData_Internal_set_Void_PostProcessData_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteShadowShader_Internal_get_Shader_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteUnshadowShader_Internal_get_Shader_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_get_geometryUnshadowShader_Internal_get_Shader_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_get_projectedShadowShader_Internal_get_Shader_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_get_transparencySortMode_Internal_get_TransparencySortMode_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_get_transparencySortAxis_Internal_get_Vector3_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_get_lightRenderTextureMemoryBudget_Internal_get_UInt32_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowRenderTextureMemoryBudget_Internal_get_UInt32_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_get_useCameraSortingLayerTexture_Internal_get_Boolean_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraSortingLayerTextureBound_Internal_get_Int32_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraSortingLayerDownsamplingMethod_Internal_get_Downsampling_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_get_layerMask_Internal_get_LayerMask_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_Create_Protected_Virtual_ScriptableRenderer_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_get_lightMaterials_Internal_get_Dictionary_2_UInt32_Material_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteSelfShadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteSelfShadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteUnshadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteUnshadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_get_geometryUnshadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_set_geometryUnshadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_get_projectedShadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_set_projectedShadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_get_stencilOnlyShadowMaterial_Internal_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_set_stencilOnlyShadowMaterial_Internal_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_get_isNormalsRenderTargetValid_Internal_get_Boolean_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_set_isNormalsRenderTargetValid_Internal_set_Void_Boolean_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_get_normalsRenderTargetScale_Internal_get_Single_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_set_normalsRenderTargetScale_Internal_set_Void_Single_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_get_lightCullResult_Internal_get_ILight2DCullResult_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_set_lightCullResult_Internal_set_Void_ILight2DCullResult_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000161 RID: 353
		public enum Renderer2DDefaultMaterialType
		{
			// Token: 0x04001423 RID: 5155
			Lit,
			// Token: 0x04001424 RID: 5156
			Unlit,
			// Token: 0x04001425 RID: 5157
			Custom
		}
	}
}
