using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.U2D;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000025 RID: 37
	public sealed class Light2D : Light2DBase
	{
		// Token: 0x06000257 RID: 599 RVA: 0x0001E20C File Offset: 0x0001C40C
		// Note: this type is marked as 'beforefieldinit'.
		static Light2D()
		{
			Il2CppClassPointerStore<Light2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Light2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light2D>.NativeClassPtr);
			Light2D.NativeFieldInfoPtr_k_CurrentComponentVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "k_CurrentComponentVersion");
			Light2D.NativeFieldInfoPtr_m_ComponentVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_ComponentVersion");
			Light2D.NativeFieldInfoPtr_m_LightType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_LightType");
			Light2D.NativeFieldInfoPtr_m_BlendStyleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_BlendStyleIndex");
			Light2D.NativeFieldInfoPtr_m_FalloffIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_FalloffIntensity");
			Light2D.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_Color");
			Light2D.NativeFieldInfoPtr_m_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_Intensity");
			Light2D.NativeFieldInfoPtr_m_LightVolumeIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_LightVolumeIntensity");
			Light2D.NativeFieldInfoPtr_m_LightVolumeIntensityEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_LightVolumeIntensityEnabled");
			Light2D.NativeFieldInfoPtr_m_ApplyToSortingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_ApplyToSortingLayers");
			Light2D.NativeFieldInfoPtr_m_LightCookieSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_LightCookieSprite");
			Light2D.NativeFieldInfoPtr_m_DeprecatedPointLightCookieSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_DeprecatedPointLightCookieSprite");
			Light2D.NativeFieldInfoPtr_m_LightOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_LightOrder");
			Light2D.NativeFieldInfoPtr_m_AlphaBlendOnOverlap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_AlphaBlendOnOverlap");
			Light2D.NativeFieldInfoPtr_m_OverlapOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_OverlapOperation");
			Light2D.NativeFieldInfoPtr_m_NormalMapDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_NormalMapDistance");
			Light2D.NativeFieldInfoPtr_m_NormalMapQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_NormalMapQuality");
			Light2D.NativeFieldInfoPtr_m_UseNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_UseNormalMap");
			Light2D.NativeFieldInfoPtr_m_ShadowIntensityEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_ShadowIntensityEnabled");
			Light2D.NativeFieldInfoPtr_m_ShadowIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_ShadowIntensity");
			Light2D.NativeFieldInfoPtr_m_ShadowVolumeIntensityEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_ShadowVolumeIntensityEnabled");
			Light2D.NativeFieldInfoPtr_m_ShadowVolumeIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_ShadowVolumeIntensity");
			Light2D.NativeFieldInfoPtr_m_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_Mesh");
			Light2D.NativeFieldInfoPtr_m_Vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_Vertices");
			Light2D.NativeFieldInfoPtr_m_Triangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_Triangles");
			Light2D.NativeFieldInfoPtr_m_PreviousLightCookieSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_PreviousLightCookieSprite");
			Light2D.NativeFieldInfoPtr_m_CachedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_CachedPosition");
			Light2D.NativeFieldInfoPtr_m_LocalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_LocalBounds");
			Light2D.NativeFieldInfoPtr__boundingSphere_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "<boundingSphere>k__BackingField");
			Light2D.NativeFieldInfoPtr_forceUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "forceUpdate");
			Light2D.NativeFieldInfoPtr_m_PointLightInnerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_PointLightInnerAngle");
			Light2D.NativeFieldInfoPtr_m_PointLightOuterAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_PointLightOuterAngle");
			Light2D.NativeFieldInfoPtr_m_PointLightInnerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_PointLightInnerRadius");
			Light2D.NativeFieldInfoPtr_m_PointLightOuterRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_PointLightOuterRadius");
			Light2D.NativeFieldInfoPtr_m_ShapeLightParametricSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_ShapeLightParametricSides");
			Light2D.NativeFieldInfoPtr_m_ShapeLightParametricAngleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_ShapeLightParametricAngleOffset");
			Light2D.NativeFieldInfoPtr_m_ShapeLightParametricRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_ShapeLightParametricRadius");
			Light2D.NativeFieldInfoPtr_m_ShapeLightFalloffSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_ShapeLightFalloffSize");
			Light2D.NativeFieldInfoPtr_m_ShapeLightFalloffOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_ShapeLightFalloffOffset");
			Light2D.NativeFieldInfoPtr_m_ShapePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_ShapePath");
			Light2D.NativeFieldInfoPtr_m_PreviousShapeLightFalloffSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_PreviousShapeLightFalloffSize");
			Light2D.NativeFieldInfoPtr_m_PreviousShapeLightParametricSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_PreviousShapeLightParametricSides");
			Light2D.NativeFieldInfoPtr_m_PreviousShapeLightParametricAngleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_PreviousShapeLightParametricAngleOffset");
			Light2D.NativeFieldInfoPtr_m_PreviousShapeLightParametricRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_PreviousShapeLightParametricRadius");
			Light2D.NativeFieldInfoPtr_m_PreviousShapePathHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_PreviousShapePathHash");
			Light2D.NativeFieldInfoPtr_m_PreviousLightType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2D>.NativeClassPtr, "m_PreviousLightType");
			Light2D.NativeMethodInfoPtr_get_vertices_Internal_get_Il2CppStructArray_1_LightMeshVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663600);
			Light2D.NativeMethodInfoPtr_set_vertices_Internal_set_Void_Il2CppStructArray_1_LightMeshVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663601);
			Light2D.NativeMethodInfoPtr_get_indices_Internal_get_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663602);
			Light2D.NativeMethodInfoPtr_set_indices_Internal_set_Void_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663603);
			Light2D.NativeMethodInfoPtr_get_affectedSortingLayers_Internal_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663604);
			Light2D.NativeMethodInfoPtr_get_lightCookieSpriteInstanceID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663605);
			Light2D.NativeMethodInfoPtr_get_boundingSphere_Internal_get_BoundingSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663606);
			Light2D.NativeMethodInfoPtr_set_boundingSphere_Private_set_Void_BoundingSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663607);
			Light2D.NativeMethodInfoPtr_get_lightMesh_Internal_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663608);
			Light2D.NativeMethodInfoPtr_get_hasCachedMesh_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663609);
			Light2D.NativeMethodInfoPtr_get_lightType_Public_get_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663610);
			Light2D.NativeMethodInfoPtr_set_lightType_Public_set_Void_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663611);
			Light2D.NativeMethodInfoPtr_get_blendStyleIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663612);
			Light2D.NativeMethodInfoPtr_set_blendStyleIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663613);
			Light2D.NativeMethodInfoPtr_get_shadowIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663614);
			Light2D.NativeMethodInfoPtr_set_shadowIntensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663615);
			Light2D.NativeMethodInfoPtr_get_shadowsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663616);
			Light2D.NativeMethodInfoPtr_set_shadowsEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663617);
			Light2D.NativeMethodInfoPtr_get_shadowVolumeIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663618);
			Light2D.NativeMethodInfoPtr_set_shadowVolumeIntensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663619);
			Light2D.NativeMethodInfoPtr_get_volumetricShadowsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663620);
			Light2D.NativeMethodInfoPtr_set_volumetricShadowsEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663621);
			Light2D.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663622);
			Light2D.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663623);
			Light2D.NativeMethodInfoPtr_get_intensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663624);
			Light2D.NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663625);
			Light2D.NativeMethodInfoPtr_get_volumeOpacity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663626);
			Light2D.NativeMethodInfoPtr_get_volumeIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663627);
			Light2D.NativeMethodInfoPtr_set_volumeIntensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663628);
			Light2D.NativeMethodInfoPtr_get_volumeIntensityEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663629);
			Light2D.NativeMethodInfoPtr_set_volumeIntensityEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663630);
			Light2D.NativeMethodInfoPtr_get_lightCookieSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663631);
			Light2D.NativeMethodInfoPtr_set_lightCookieSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663632);
			Light2D.NativeMethodInfoPtr_get_falloffIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663633);
			Light2D.NativeMethodInfoPtr_set_falloffIntensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663634);
			Light2D.NativeMethodInfoPtr_get_alphaBlendOnOverlap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663635);
			Light2D.NativeMethodInfoPtr_get_overlapOperation_Public_get_OverlapOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663636);
			Light2D.NativeMethodInfoPtr_set_overlapOperation_Public_set_Void_OverlapOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663637);
			Light2D.NativeMethodInfoPtr_get_lightOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663638);
			Light2D.NativeMethodInfoPtr_set_lightOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663639);
			Light2D.NativeMethodInfoPtr_get_normalMapDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663640);
			Light2D.NativeMethodInfoPtr_get_normalMapQuality_Public_get_NormalMapQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663641);
			Light2D.NativeMethodInfoPtr_get_renderVolumetricShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663642);
			Light2D.NativeMethodInfoPtr_MarkForUpdate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663643);
			Light2D.NativeMethodInfoPtr_CacheValues_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663644);
			Light2D.NativeMethodInfoPtr_GetTopMostLitLayer_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663645);
			Light2D.NativeMethodInfoPtr_UpdateSpriteMesh_Internal_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663646);
			Light2D.NativeMethodInfoPtr_UpdateMesh_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663647);
			Light2D.NativeMethodInfoPtr_UpdateBoundingSphere_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663648);
			Light2D.NativeMethodInfoPtr_IsLitLayer_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663649);
			Light2D.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663650);
			Light2D.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663651);
			Light2D.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663652);
			Light2D.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663653);
			Light2D.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663654);
			Light2D.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663655);
			Light2D.NativeMethodInfoPtr_get_pointLightInnerAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663656);
			Light2D.NativeMethodInfoPtr_set_pointLightInnerAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663657);
			Light2D.NativeMethodInfoPtr_get_pointLightOuterAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663658);
			Light2D.NativeMethodInfoPtr_set_pointLightOuterAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663659);
			Light2D.NativeMethodInfoPtr_get_pointLightInnerRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663660);
			Light2D.NativeMethodInfoPtr_set_pointLightInnerRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663661);
			Light2D.NativeMethodInfoPtr_get_pointLightOuterRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663662);
			Light2D.NativeMethodInfoPtr_set_pointLightOuterRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663663);
			Light2D.NativeMethodInfoPtr_get_pointLightDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663664);
			Light2D.NativeMethodInfoPtr_get_pointLightQuality_Public_get_NormalMapQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663665);
			Light2D.NativeMethodInfoPtr_get_isPointLight_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663666);
			Light2D.NativeMethodInfoPtr_get_shapeLightParametricSides_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663667);
			Light2D.NativeMethodInfoPtr_get_shapeLightParametricAngleOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663668);
			Light2D.NativeMethodInfoPtr_get_shapeLightParametricRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663669);
			Light2D.NativeMethodInfoPtr_set_shapeLightParametricRadius_Internal_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663670);
			Light2D.NativeMethodInfoPtr_get_shapeLightFalloffSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663671);
			Light2D.NativeMethodInfoPtr_set_shapeLightFalloffSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663672);
			Light2D.NativeMethodInfoPtr_get_shapePath_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663673);
			Light2D.NativeMethodInfoPtr_set_shapePath_Internal_set_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663674);
			Light2D.NativeMethodInfoPtr_SetShapePath_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663675);
			Light2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2D>.NativeClassPtr, 100663676);
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0001EBD8 File Offset: 0x0001CDD8
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0001EC18 File Offset: 0x0001CE18
		public unsafe Il2CppStructArray<LightUtility.LightMeshVertex> vertices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_vertices_Internal_get_Il2CppStructArray_1_LightMeshVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<LightUtility.LightMeshVertex>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_vertices_Internal_set_Void_Il2CppStructArray_1_LightMeshVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0001EC5C File Offset: 0x0001CE5C
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0001EC9C File Offset: 0x0001CE9C
		public unsafe Il2CppStructArray<ushort> indices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_indices_Internal_get_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_indices_Internal_set_Void_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0001ECE0 File Offset: 0x0001CEE0
		public unsafe Il2CppStructArray<int> affectedSortingLayers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_affectedSortingLayers_Internal_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0001ED20 File Offset: 0x0001CF20
		public unsafe int lightCookieSpriteInstanceID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599539, XrefRangeEnd = 599540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_lightCookieSpriteInstanceID_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0001ED5C File Offset: 0x0001CF5C
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0001ED98 File Offset: 0x0001CF98
		public unsafe BoundingSphere boundingSphere
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_boundingSphere_Internal_get_BoundingSphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_boundingSphere_Private_set_Void_BoundingSphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0001EDD8 File Offset: 0x0001CFD8
		public unsafe Mesh lightMesh
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 599549, RefRangeEnd = 599556, XrefRangeStart = 599540, XrefRangeEnd = 599549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_lightMesh_Internal_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0001EE18 File Offset: 0x0001D018
		public unsafe bool hasCachedMesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_hasCachedMesh_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0001EE54 File Offset: 0x0001D054
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0001EE90 File Offset: 0x0001D090
		public unsafe Light2D.LightType lightType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_lightType_Public_get_LightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599556, XrefRangeEnd = 599561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_lightType_Public_set_Void_LightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0001EED0 File Offset: 0x0001D0D0
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0001EF0C File Offset: 0x0001D10C
		public unsafe int blendStyleIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_blendStyleIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_blendStyleIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0001EF4C File Offset: 0x0001D14C
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0001EF88 File Offset: 0x0001D188
		public unsafe float shadowIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_shadowIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_shadowIntensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0001EFC8 File Offset: 0x0001D1C8
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0001F004 File Offset: 0x0001D204
		public unsafe bool shadowsEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_shadowsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_shadowsEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0001F044 File Offset: 0x0001D244
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0001F080 File Offset: 0x0001D280
		public unsafe float shadowVolumeIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_shadowVolumeIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_shadowVolumeIntensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0001F0C0 File Offset: 0x0001D2C0
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0001F0FC File Offset: 0x0001D2FC
		public unsafe bool volumetricShadowsEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_volumetricShadowsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_volumetricShadowsEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0001F13C File Offset: 0x0001D33C
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0001F178 File Offset: 0x0001D378
		public unsafe Color color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0001F1B8 File Offset: 0x0001D3B8
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0001F1F4 File Offset: 0x0001D3F4
		public unsafe float intensity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300360, RefRangeEnd = 300361, XrefRangeStart = 300360, XrefRangeEnd = 300361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_intensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 599561, RefRangeEnd = 599562, XrefRangeStart = 599561, XrefRangeEnd = 599561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0001F234 File Offset: 0x0001D434
		public unsafe float volumeOpacity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300359, RefRangeEnd = 300360, XrefRangeStart = 300359, XrefRangeEnd = 300360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_volumeOpacity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0001F270 File Offset: 0x0001D470
		// (set) Token: 0x06000274 RID: 628 RVA: 0x0001F2AC File Offset: 0x0001D4AC
		public unsafe float volumeIntensity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300359, RefRangeEnd = 300360, XrefRangeStart = 300359, XrefRangeEnd = 300360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_volumeIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 599562, RefRangeEnd = 599563, XrefRangeStart = 599562, XrefRangeEnd = 599562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_volumeIntensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0001F2EC File Offset: 0x0001D4EC
		// (set) Token: 0x06000276 RID: 630 RVA: 0x0001F328 File Offset: 0x0001D528
		public unsafe bool volumeIntensityEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_volumeIntensityEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_volumeIntensityEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0001F368 File Offset: 0x0001D568
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0001F3A8 File Offset: 0x0001D5A8
		public unsafe Sprite lightCookieSprite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_lightCookieSprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_lightCookieSprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0001F3EC File Offset: 0x0001D5EC
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0001F428 File Offset: 0x0001D628
		public unsafe float falloffIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_falloffIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_falloffIntensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0001F468 File Offset: 0x0001D668
		public unsafe bool alphaBlendOnOverlap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_alphaBlendOnOverlap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0001F4A4 File Offset: 0x0001D6A4
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0001F4E0 File Offset: 0x0001D6E0
		public unsafe Light2D.OverlapOperation overlapOperation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368217, RefRangeEnd = 368218, XrefRangeStart = 368217, XrefRangeEnd = 368218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_overlapOperation_Public_get_OverlapOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_overlapOperation_Public_set_Void_OverlapOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0001F520 File Offset: 0x0001D720
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0001F55C File Offset: 0x0001D75C
		public unsafe int lightOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_lightOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 337738, RefRangeEnd = 337747, XrefRangeStart = 337738, XrefRangeEnd = 337747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_lightOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0001F59C File Offset: 0x0001D79C
		public unsafe float normalMapDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_normalMapDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
		public unsafe Light2D.NormalMapQuality normalMapQuality
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_normalMapQuality_Public_get_NormalMapQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0001F614 File Offset: 0x0001D814
		public unsafe bool renderVolumetricShadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_renderVolumetricShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0001F650 File Offset: 0x0001D850
		[CallerCount(0)]
		public unsafe void MarkForUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_MarkForUpdate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0001F684 File Offset: 0x0001D884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599563, XrefRangeEnd = 599565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_CacheValues_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0001F6B8 File Offset: 0x0001D8B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 599572, RefRangeEnd = 599575, XrefRangeStart = 599565, XrefRangeEnd = 599572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTopMostLitLayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_GetTopMostLitLayer_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0001F6F4 File Offset: 0x0001D8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599575, XrefRangeEnd = 599588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds UpdateSpriteMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_UpdateSpriteMesh_Internal_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0001F730 File Offset: 0x0001D930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 599615, RefRangeEnd = 599617, XrefRangeStart = 599588, XrefRangeEnd = 599615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMesh(bool forceUpdate = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forceUpdate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_UpdateMesh_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0001F770 File Offset: 0x0001D970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 599627, RefRangeEnd = 599628, XrefRangeStart = 599617, XrefRangeEnd = 599627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBoundingSphere()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_UpdateBoundingSphere_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0001F7A4 File Offset: 0x0001D9A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 599629, RefRangeEnd = 599631, XrefRangeStart = 599628, XrefRangeEnd = 599629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLitLayer(int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_IsLitLayer_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0001F7F0 File Offset: 0x0001D9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599631, XrefRangeEnd = 599639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0001F824 File Offset: 0x0001DA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599639, XrefRangeEnd = 599659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0001F858 File Offset: 0x0001DA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599659, XrefRangeEnd = 599673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0001F88C File Offset: 0x0001DA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599673, XrefRangeEnd = 599675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001F8C0 File Offset: 0x0001DAC0
		[CallerCount(0)]
		public unsafe void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001F8F4 File Offset: 0x0001DAF4
		[CallerCount(0)]
		public unsafe void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0001F928 File Offset: 0x0001DB28
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0001F964 File Offset: 0x0001DB64
		public unsafe float pointLightInnerAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_pointLightInnerAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_pointLightInnerAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0001F9A4 File Offset: 0x0001DBA4
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0001F9E0 File Offset: 0x0001DBE0
		public unsafe float pointLightOuterAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_pointLightOuterAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_pointLightOuterAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0001FA20 File Offset: 0x0001DC20
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0001FA5C File Offset: 0x0001DC5C
		public unsafe float pointLightInnerRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_pointLightInnerRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_pointLightInnerRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0001FA9C File Offset: 0x0001DC9C
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0001FAD8 File Offset: 0x0001DCD8
		public unsafe float pointLightOuterRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_pointLightOuterRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_pointLightOuterRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0001FB18 File Offset: 0x0001DD18
		public unsafe float pointLightDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_pointLightDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0001FB54 File Offset: 0x0001DD54
		public unsafe Light2D.NormalMapQuality pointLightQuality
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_pointLightQuality_Public_get_NormalMapQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0001FB90 File Offset: 0x0001DD90
		public unsafe bool isPointLight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_isPointLight_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0001FBCC File Offset: 0x0001DDCC
		public unsafe int shapeLightParametricSides
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_shapeLightParametricSides_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0001FC08 File Offset: 0x0001DE08
		public unsafe float shapeLightParametricAngleOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_shapeLightParametricAngleOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0001FC44 File Offset: 0x0001DE44
		// (set) Token: 0x0600029E RID: 670 RVA: 0x0001FC80 File Offset: 0x0001DE80
		public unsafe float shapeLightParametricRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_shapeLightParametricRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_shapeLightParametricRadius_Internal_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0001FCC0 File Offset: 0x0001DEC0
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0001FCFC File Offset: 0x0001DEFC
		public unsafe float shapeLightFalloffSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_shapeLightFalloffSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_shapeLightFalloffSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0001FD3C File Offset: 0x0001DF3C
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x0001FD7C File Offset: 0x0001DF7C
		public unsafe Il2CppStructArray<Vector3> shapePath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_get_shapePath_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_set_shapePath_Internal_set_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0001FDC0 File Offset: 0x0001DFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShapePath(Il2CppStructArray<Vector3> path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr_SetShapePath_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0001FE04 File Offset: 0x0001E004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599675, XrefRangeEnd = 599686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Light2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Light2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002FFE File Offset: 0x000011FE
		public Light2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0001FE40 File Offset: 0x0001E040
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00003007 File Offset: 0x00001207
		public unsafe static Light2D.ComponentVersions k_CurrentComponentVersion
		{
			get
			{
				Light2D.ComponentVersions componentVersions;
				IL2CPP.il2cpp_field_static_get_value(Light2D.NativeFieldInfoPtr_k_CurrentComponentVersion, (void*)(&componentVersions));
				return componentVersions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Light2D.NativeFieldInfoPtr_k_CurrentComponentVersion, (void*)(&value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0001FE5C File Offset: 0x0001E05C
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00003015 File Offset: 0x00001215
		public unsafe Light2D.ComponentVersions m_ComponentVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ComponentVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ComponentVersion)) = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0001FE84 File Offset: 0x0001E084
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00003030 File Offset: 0x00001230
		public unsafe Light2D.LightType m_LightType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_LightType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_LightType)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0001FEAC File Offset: 0x0001E0AC
		// (set) Token: 0x060002AD RID: 685 RVA: 0x0000304B File Offset: 0x0000124B
		public unsafe int m_BlendStyleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_BlendStyleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_BlendStyleIndex)) = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0001FED4 File Offset: 0x0001E0D4
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00003066 File Offset: 0x00001266
		public unsafe float m_FalloffIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_FalloffIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_FalloffIntensity)) = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0001FEFC File Offset: 0x0001E0FC
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00003081 File Offset: 0x00001281
		public unsafe Color m_Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_Color)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0001FF24 File Offset: 0x0001E124
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x0000309C File Offset: 0x0000129C
		public unsafe float m_Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_Intensity)) = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0001FF4C File Offset: 0x0001E14C
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000030B7 File Offset: 0x000012B7
		public unsafe float m_LightVolumeIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_LightVolumeIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_LightVolumeIntensity)) = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0001FF74 File Offset: 0x0001E174
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x000030D2 File Offset: 0x000012D2
		public unsafe bool m_LightVolumeIntensityEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_LightVolumeIntensityEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_LightVolumeIntensityEnabled)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0001FF9C File Offset: 0x0001E19C
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x000030ED File Offset: 0x000012ED
		public unsafe Il2CppStructArray<int> m_ApplyToSortingLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ApplyToSortingLayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ApplyToSortingLayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0001FFCC File Offset: 0x0001E1CC
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000310C File Offset: 0x0000130C
		public unsafe Sprite m_LightCookieSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_LightCookieSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_LightCookieSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0001FFFC File Offset: 0x0001E1FC
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000312B File Offset: 0x0000132B
		public unsafe Sprite m_DeprecatedPointLightCookieSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_DeprecatedPointLightCookieSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_DeprecatedPointLightCookieSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0002002C File Offset: 0x0001E22C
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000314A File Offset: 0x0000134A
		public unsafe int m_LightOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_LightOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_LightOrder)) = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00020054 File Offset: 0x0001E254
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00003165 File Offset: 0x00001365
		public unsafe bool m_AlphaBlendOnOverlap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_AlphaBlendOnOverlap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_AlphaBlendOnOverlap)) = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0002007C File Offset: 0x0001E27C
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00003180 File Offset: 0x00001380
		public unsafe Light2D.OverlapOperation m_OverlapOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_OverlapOperation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_OverlapOperation)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x000200A4 File Offset: 0x0001E2A4
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x0000319B File Offset: 0x0000139B
		public unsafe float m_NormalMapDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_NormalMapDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_NormalMapDistance)) = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x000200CC File Offset: 0x0001E2CC
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x000031B6 File Offset: 0x000013B6
		public unsafe Light2D.NormalMapQuality m_NormalMapQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_NormalMapQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_NormalMapQuality)) = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000200F4 File Offset: 0x0001E2F4
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x000031D1 File Offset: 0x000013D1
		public unsafe bool m_UseNormalMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_UseNormalMap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_UseNormalMap)) = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0002011C File Offset: 0x0001E31C
		// (set) Token: 0x060002CB RID: 715 RVA: 0x000031EC File Offset: 0x000013EC
		public unsafe bool m_ShadowIntensityEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShadowIntensityEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShadowIntensityEnabled)) = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00020144 File Offset: 0x0001E344
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00003207 File Offset: 0x00001407
		public unsafe float m_ShadowIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShadowIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShadowIntensity)) = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0002016C File Offset: 0x0001E36C
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00003222 File Offset: 0x00001422
		public unsafe bool m_ShadowVolumeIntensityEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShadowVolumeIntensityEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShadowVolumeIntensityEnabled)) = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00020194 File Offset: 0x0001E394
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x0000323D File Offset: 0x0000143D
		public unsafe float m_ShadowVolumeIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShadowVolumeIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShadowVolumeIntensity)) = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000201BC File Offset: 0x0001E3BC
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00003258 File Offset: 0x00001458
		public unsafe Mesh m_Mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_Mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x000201EC File Offset: 0x0001E3EC
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00003277 File Offset: 0x00001477
		public unsafe Il2CppStructArray<LightUtility.LightMeshVertex> m_Vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_Vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<LightUtility.LightMeshVertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_Vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0002021C File Offset: 0x0001E41C
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00003296 File Offset: 0x00001496
		public unsafe Il2CppStructArray<ushort> m_Triangles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_Triangles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_Triangles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0002024C File Offset: 0x0001E44C
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x000032B5 File Offset: 0x000014B5
		public unsafe int m_PreviousLightCookieSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousLightCookieSprite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousLightCookieSprite)) = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00020274 File Offset: 0x0001E474
		// (set) Token: 0x060002DB RID: 731 RVA: 0x000032D0 File Offset: 0x000014D0
		public unsafe Vector3 m_CachedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_CachedPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_CachedPosition)) = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0002029C File Offset: 0x0001E49C
		// (set) Token: 0x060002DD RID: 733 RVA: 0x000032EB File Offset: 0x000014EB
		public unsafe Bounds m_LocalBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_LocalBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_LocalBounds)) = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002DE RID: 734 RVA: 0x000202C4 File Offset: 0x0001E4C4
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00003306 File Offset: 0x00001506
		public unsafe BoundingSphere _boundingSphere_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr__boundingSphere_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr__boundingSphere_k__BackingField)) = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x000202EC File Offset: 0x0001E4EC
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00003321 File Offset: 0x00001521
		public unsafe bool forceUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_forceUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_forceUpdate)) = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00020314 File Offset: 0x0001E514
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0000333C File Offset: 0x0000153C
		public unsafe float m_PointLightInnerAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PointLightInnerAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PointLightInnerAngle)) = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0002033C File Offset: 0x0001E53C
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00003357 File Offset: 0x00001557
		public unsafe float m_PointLightOuterAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PointLightOuterAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PointLightOuterAngle)) = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00020364 File Offset: 0x0001E564
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00003372 File Offset: 0x00001572
		public unsafe float m_PointLightInnerRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PointLightInnerRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PointLightInnerRadius)) = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0002038C File Offset: 0x0001E58C
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x0000338D File Offset: 0x0000158D
		public unsafe float m_PointLightOuterRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PointLightOuterRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PointLightOuterRadius)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002EA RID: 746 RVA: 0x000203B4 File Offset: 0x0001E5B4
		// (set) Token: 0x060002EB RID: 747 RVA: 0x000033A8 File Offset: 0x000015A8
		public unsafe int m_ShapeLightParametricSides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShapeLightParametricSides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShapeLightParametricSides)) = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002EC RID: 748 RVA: 0x000203DC File Offset: 0x0001E5DC
		// (set) Token: 0x060002ED RID: 749 RVA: 0x000033C3 File Offset: 0x000015C3
		public unsafe float m_ShapeLightParametricAngleOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShapeLightParametricAngleOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShapeLightParametricAngleOffset)) = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00020404 File Offset: 0x0001E604
		// (set) Token: 0x060002EF RID: 751 RVA: 0x000033DE File Offset: 0x000015DE
		public unsafe float m_ShapeLightParametricRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShapeLightParametricRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShapeLightParametricRadius)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0002042C File Offset: 0x0001E62C
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x000033F9 File Offset: 0x000015F9
		public unsafe float m_ShapeLightFalloffSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShapeLightFalloffSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShapeLightFalloffSize)) = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00020454 File Offset: 0x0001E654
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00003414 File Offset: 0x00001614
		public unsafe Vector2 m_ShapeLightFalloffOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShapeLightFalloffOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShapeLightFalloffOffset)) = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0002047C File Offset: 0x0001E67C
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x0000342F File Offset: 0x0000162F
		public unsafe Il2CppStructArray<Vector3> m_ShapePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShapePath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_ShapePath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x000204AC File Offset: 0x0001E6AC
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x0000344E File Offset: 0x0000164E
		public unsafe float m_PreviousShapeLightFalloffSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousShapeLightFalloffSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousShapeLightFalloffSize)) = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x000204D4 File Offset: 0x0001E6D4
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00003469 File Offset: 0x00001669
		public unsafe int m_PreviousShapeLightParametricSides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousShapeLightParametricSides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousShapeLightParametricSides)) = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002FA RID: 762 RVA: 0x000204FC File Offset: 0x0001E6FC
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00003484 File Offset: 0x00001684
		public unsafe float m_PreviousShapeLightParametricAngleOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousShapeLightParametricAngleOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousShapeLightParametricAngleOffset)) = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00020524 File Offset: 0x0001E724
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0000349F File Offset: 0x0000169F
		public unsafe float m_PreviousShapeLightParametricRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousShapeLightParametricRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousShapeLightParametricRadius)) = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0002054C File Offset: 0x0001E74C
		// (set) Token: 0x060002FF RID: 767 RVA: 0x000034BA File Offset: 0x000016BA
		public unsafe int m_PreviousShapePathHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousShapePathHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousShapePathHash)) = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00020574 File Offset: 0x0001E774
		// (set) Token: 0x06000301 RID: 769 RVA: 0x000034D5 File Offset: 0x000016D5
		public unsafe Light2D.LightType m_PreviousLightType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousLightType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2D.NativeFieldInfoPtr_m_PreviousLightType)) = value;
			}
		}

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeFieldInfoPtr_k_CurrentComponentVersion;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeFieldInfoPtr_m_ComponentVersion;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr_m_LightType;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendStyleIndex;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeFieldInfoPtr_m_FalloffIntensity;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeFieldInfoPtr_m_Intensity;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeFieldInfoPtr_m_LightVolumeIntensity;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeFieldInfoPtr_m_LightVolumeIntensityEnabled;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeFieldInfoPtr_m_ApplyToSortingLayers;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeFieldInfoPtr_m_LightCookieSprite;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeFieldInfoPtr_m_DeprecatedPointLightCookieSprite;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeFieldInfoPtr_m_LightOrder;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaBlendOnOverlap;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr_m_OverlapOperation;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalMapDistance;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalMapQuality;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr_m_UseNormalMap;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowIntensityEnabled;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowIntensity;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowVolumeIntensityEnabled;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowVolumeIntensity;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_m_Mesh;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr_m_Vertices;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr_m_Triangles;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousLightCookieSprite;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedPosition;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalBounds;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr__boundingSphere_k__BackingField;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_forceUpdate;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_m_PointLightInnerAngle;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_m_PointLightOuterAngle;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_m_PointLightInnerRadius;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_m_PointLightOuterRadius;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr_m_ShapeLightParametricSides;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr_m_ShapeLightParametricAngleOffset;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_m_ShapeLightParametricRadius;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_m_ShapeLightFalloffSize;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_m_ShapeLightFalloffOffset;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_m_ShapePath;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousShapeLightFalloffSize;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousShapeLightParametricSides;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousShapeLightParametricAngleOffset;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousShapeLightParametricRadius;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousShapePathHash;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousLightType;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_get_vertices_Internal_get_Il2CppStructArray_1_LightMeshVertex_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_set_vertices_Internal_set_Void_Il2CppStructArray_1_LightMeshVertex_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_get_indices_Internal_get_Il2CppStructArray_1_UInt16_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_set_indices_Internal_set_Void_Il2CppStructArray_1_UInt16_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_get_affectedSortingLayers_Internal_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_get_lightCookieSpriteInstanceID_Private_get_Int32_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_get_boundingSphere_Internal_get_BoundingSphere_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_set_boundingSphere_Private_set_Void_BoundingSphere_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_get_lightMesh_Internal_get_Mesh_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_get_hasCachedMesh_Internal_get_Boolean_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_get_lightType_Public_get_LightType_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_set_lightType_Public_set_Void_LightType_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_get_blendStyleIndex_Public_get_Int32_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_set_blendStyleIndex_Public_set_Void_Int32_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowIntensity_Public_get_Single_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowIntensity_Public_set_Void_Single_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowsEnabled_Public_get_Boolean_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowsEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowVolumeIntensity_Public_get_Single_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowVolumeIntensity_Public_set_Void_Single_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_get_volumetricShadowsEnabled_Public_get_Boolean_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_set_volumetricShadowsEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_get_intensity_Public_get_Single_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeOpacity_Public_get_Single_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeIntensity_Public_get_Single_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_set_volumeIntensity_Public_set_Void_Single_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeIntensityEnabled_Public_get_Boolean_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_set_volumeIntensityEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_get_lightCookieSprite_Public_get_Sprite_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_set_lightCookieSprite_Public_set_Void_Sprite_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_get_falloffIntensity_Public_get_Single_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_set_falloffIntensity_Public_set_Void_Single_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaBlendOnOverlap_Public_get_Boolean_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_get_overlapOperation_Public_get_OverlapOperation_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_set_overlapOperation_Public_set_Void_OverlapOperation_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_get_lightOrder_Public_get_Int32_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_set_lightOrder_Public_set_Void_Int32_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_get_normalMapDistance_Public_get_Single_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_get_normalMapQuality_Public_get_NormalMapQuality_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_get_renderVolumetricShadows_Public_get_Boolean_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_MarkForUpdate_Internal_Void_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_CacheValues_Internal_Void_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_GetTopMostLitLayer_Internal_Int32_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpriteMesh_Internal_Bounds_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMesh_Internal_Void_Boolean_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBoundingSphere_Internal_Void_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_IsLitLayer_Internal_Boolean_Int32_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_get_pointLightInnerAngle_Public_get_Single_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_set_pointLightInnerAngle_Public_set_Void_Single_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_get_pointLightOuterAngle_Public_get_Single_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_set_pointLightOuterAngle_Public_set_Void_Single_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_get_pointLightInnerRadius_Public_get_Single_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_set_pointLightInnerRadius_Public_set_Void_Single_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_get_pointLightOuterRadius_Public_get_Single_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_set_pointLightOuterRadius_Public_set_Void_Single_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_get_pointLightDistance_Public_get_Single_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_get_pointLightQuality_Public_get_NormalMapQuality_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_get_isPointLight_Internal_get_Boolean_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_get_shapeLightParametricSides_Public_get_Int32_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_get_shapeLightParametricAngleOffset_Public_get_Single_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_get_shapeLightParametricRadius_Public_get_Single_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_set_shapeLightParametricRadius_Internal_set_Void_Single_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_get_shapeLightFalloffSize_Public_get_Single_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_set_shapeLightFalloffSize_Public_set_Void_Single_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_get_shapePath_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_set_shapePath_Internal_set_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_SetShapePath_Public_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000150 RID: 336
		public enum DeprecatedLightType
		{
			// Token: 0x040013D3 RID: 5075
			Parametric
		}

		// Token: 0x02000151 RID: 337
		public enum LightType
		{
			// Token: 0x040013D5 RID: 5077
			Parametric,
			// Token: 0x040013D6 RID: 5078
			Freeform,
			// Token: 0x040013D7 RID: 5079
			Sprite,
			// Token: 0x040013D8 RID: 5080
			Point,
			// Token: 0x040013D9 RID: 5081
			Global
		}

		// Token: 0x02000152 RID: 338
		public enum NormalMapQuality
		{
			// Token: 0x040013DB RID: 5083
			Disabled = 2,
			// Token: 0x040013DC RID: 5084
			Fast = 0,
			// Token: 0x040013DD RID: 5085
			Accurate
		}

		// Token: 0x02000153 RID: 339
		public enum OverlapOperation
		{
			// Token: 0x040013DF RID: 5087
			Additive,
			// Token: 0x040013E0 RID: 5088
			AlphaBlend
		}

		// Token: 0x02000154 RID: 340
		public enum ComponentVersions
		{
			// Token: 0x040013E2 RID: 5090
			Version_Unserialized,
			// Token: 0x040013E3 RID: 5091
			Version_1
		}
	}
}
