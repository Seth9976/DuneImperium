using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000AD RID: 173
	public sealed class Light : Behaviour
	{
		// Token: 0x06000E2B RID: 3627 RVA: 0x0004656C File Offset: 0x0004476C
		// Note: this type is marked as 'beforefieldinit'.
		static Light()
		{
			Il2CppClassPointerStore<Light>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Light");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light>.NativeClassPtr);
			Light.NativeFieldInfoPtr_m_BakedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light>.NativeClassPtr, "m_BakedIndex");
			Light.NativeMethodInfoPtr_get_type_Public_get_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665054);
			Light.NativeMethodInfoPtr_set_type_Public_set_Void_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665055);
			Light.NativeMethodInfoPtr_get_shape_Public_get_LightShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665056);
			Light.NativeMethodInfoPtr_set_shape_Public_set_Void_LightShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665057);
			Light.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665058);
			Light.NativeMethodInfoPtr_set_spotAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665059);
			Light.NativeMethodInfoPtr_get_innerSpotAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665060);
			Light.NativeMethodInfoPtr_set_innerSpotAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665061);
			Light.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665062);
			Light.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665063);
			Light.NativeMethodInfoPtr_get_colorTemperature_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665064);
			Light.NativeMethodInfoPtr_set_colorTemperature_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665065);
			Light.NativeMethodInfoPtr_get_useColorTemperature_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665066);
			Light.NativeMethodInfoPtr_set_useColorTemperature_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665067);
			Light.NativeMethodInfoPtr_get_intensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665068);
			Light.NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665069);
			Light.NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665070);
			Light.NativeMethodInfoPtr_set_bounceIntensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665071);
			Light.NativeMethodInfoPtr_get_useBoundingSphereOverride_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665072);
			Light.NativeMethodInfoPtr_set_useBoundingSphereOverride_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665073);
			Light.NativeMethodInfoPtr_get_boundingSphereOverride_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665074);
			Light.NativeMethodInfoPtr_set_boundingSphereOverride_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665075);
			Light.NativeMethodInfoPtr_get_useViewFrustumForShadowCasterCull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665076);
			Light.NativeMethodInfoPtr_set_useViewFrustumForShadowCasterCull_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665077);
			Light.NativeMethodInfoPtr_get_shadowCustomResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665078);
			Light.NativeMethodInfoPtr_set_shadowCustomResolution_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665079);
			Light.NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665080);
			Light.NativeMethodInfoPtr_set_shadowBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665081);
			Light.NativeMethodInfoPtr_get_shadowNormalBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665082);
			Light.NativeMethodInfoPtr_set_shadowNormalBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665083);
			Light.NativeMethodInfoPtr_get_shadowNearPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665084);
			Light.NativeMethodInfoPtr_set_shadowNearPlane_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665085);
			Light.NativeMethodInfoPtr_get_useShadowMatrixOverride_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665086);
			Light.NativeMethodInfoPtr_set_useShadowMatrixOverride_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665087);
			Light.NativeMethodInfoPtr_get_shadowMatrixOverride_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665088);
			Light.NativeMethodInfoPtr_set_shadowMatrixOverride_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665089);
			Light.NativeMethodInfoPtr_get_range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665090);
			Light.NativeMethodInfoPtr_set_range_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665091);
			Light.NativeMethodInfoPtr_get_flare_Public_get_Flare_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665092);
			Light.NativeMethodInfoPtr_set_flare_Public_set_Void_Flare_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665093);
			Light.NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665094);
			Light.NativeMethodInfoPtr_set_bakingOutput_Public_set_Void_LightBakingOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665095);
			Light.NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665096);
			Light.NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665097);
			Light.NativeMethodInfoPtr_get_renderingLayerMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665098);
			Light.NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665099);
			Light.NativeMethodInfoPtr_get_lightShadowCasterMode_Public_get_LightShadowCasterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665100);
			Light.NativeMethodInfoPtr_set_lightShadowCasterMode_Public_set_Void_LightShadowCasterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665101);
			Light.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665102);
			Light.NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665103);
			Light.NativeMethodInfoPtr_set_shadows_Public_set_Void_LightShadows_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665104);
			Light.NativeMethodInfoPtr_get_shadowStrength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665105);
			Light.NativeMethodInfoPtr_set_shadowStrength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665106);
			Light.NativeMethodInfoPtr_get_shadowResolution_Public_get_LightShadowResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665107);
			Light.NativeMethodInfoPtr_set_shadowResolution_Public_set_Void_LightShadowResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665108);
			Light.NativeMethodInfoPtr_get_shadowSoftness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665109);
			Light.NativeMethodInfoPtr_set_shadowSoftness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665110);
			Light.NativeMethodInfoPtr_get_shadowSoftnessFade_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665111);
			Light.NativeMethodInfoPtr_set_shadowSoftnessFade_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665112);
			Light.NativeMethodInfoPtr_get_layerShadowCullDistances_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665113);
			Light.NativeMethodInfoPtr_set_layerShadowCullDistances_Public_set_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665114);
			Light.NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665115);
			Light.NativeMethodInfoPtr_set_cookieSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665116);
			Light.NativeMethodInfoPtr_get_cookie_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665117);
			Light.NativeMethodInfoPtr_set_cookie_Public_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665118);
			Light.NativeMethodInfoPtr_get_renderMode_Public_get_LightRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665119);
			Light.NativeMethodInfoPtr_set_renderMode_Public_set_Void_LightRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665120);
			Light.NativeMethodInfoPtr_get_bakedIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665121);
			Light.NativeMethodInfoPtr_set_bakedIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665122);
			Light.NativeMethodInfoPtr_AddCommandBuffer_Public_Void_LightEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665123);
			Light.NativeMethodInfoPtr_AddCommandBuffer_Public_Void_LightEvent_CommandBuffer_ShadowMapPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665124);
			Light.NativeMethodInfoPtr_AddCommandBufferAsync_Public_Void_LightEvent_CommandBuffer_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665125);
			Light.NativeMethodInfoPtr_AddCommandBufferAsync_Public_Void_LightEvent_CommandBuffer_ShadowMapPass_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665126);
			Light.NativeMethodInfoPtr_RemoveCommandBuffer_Public_Void_LightEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665127);
			Light.NativeMethodInfoPtr_RemoveCommandBuffers_Public_Void_LightEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665128);
			Light.NativeMethodInfoPtr_RemoveAllCommandBuffers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665129);
			Light.NativeMethodInfoPtr_GetCommandBuffers_Public_Il2CppReferenceArray_1_CommandBuffer_LightEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665130);
			Light.NativeMethodInfoPtr_get_commandBufferCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665131);
			Light.NativeMethodInfoPtr_get_pixelLightCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665132);
			Light.NativeMethodInfoPtr_set_pixelLightCount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665133);
			Light.NativeMethodInfoPtr_GetLights_Public_Static_Il2CppReferenceArray_1_Light_LightType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665134);
			Light.NativeMethodInfoPtr_get_shadowConstantBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665135);
			Light.NativeMethodInfoPtr_set_shadowConstantBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665136);
			Light.NativeMethodInfoPtr_get_shadowObjectSizeBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665137);
			Light.NativeMethodInfoPtr_set_shadowObjectSizeBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665138);
			Light.NativeMethodInfoPtr_get_attenuate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665139);
			Light.NativeMethodInfoPtr_set_attenuate_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665140);
			Light.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665141);
			Light.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665142);
			Light.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665143);
			Light.NativeMethodInfoPtr_get_boundingSphereOverride_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665144);
			Light.NativeMethodInfoPtr_set_boundingSphereOverride_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665145);
			Light.NativeMethodInfoPtr_get_shadowMatrixOverride_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665146);
			Light.NativeMethodInfoPtr_set_shadowMatrixOverride_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665147);
			Light.NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665148);
			Light.NativeMethodInfoPtr_set_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100665149);
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x00046D30 File Offset: 0x00044F30
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x00046D6C File Offset: 0x00044F6C
		public unsafe LightType type
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 653303, RefRangeEnd = 653308, XrefRangeStart = 653301, XrefRangeEnd = 653303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_type_Public_get_LightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653308, XrefRangeEnd = 653310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_type_Public_set_Void_LightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00046DAC File Offset: 0x00044FAC
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x00046DE8 File Offset: 0x00044FE8
		public unsafe LightShape shape
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653310, XrefRangeEnd = 653312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shape_Public_get_LightShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653312, XrefRangeEnd = 653314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shape_Public_set_Void_LightShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x00046E28 File Offset: 0x00045028
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x00046E64 File Offset: 0x00045064
		public unsafe float spotAngle
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 653316, RefRangeEnd = 653319, XrefRangeStart = 653314, XrefRangeEnd = 653316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653319, XrefRangeEnd = 653321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_spotAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x00046EA4 File Offset: 0x000450A4
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x00046EE0 File Offset: 0x000450E0
		public unsafe float innerSpotAngle
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 653323, RefRangeEnd = 653325, XrefRangeStart = 653321, XrefRangeEnd = 653323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_innerSpotAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653325, XrefRangeEnd = 653327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_innerSpotAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00046F20 File Offset: 0x00045120
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00046F5C File Offset: 0x0004515C
		public unsafe Color color
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 653329, RefRangeEnd = 653345, XrefRangeStart = 653327, XrefRangeEnd = 653329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 653347, RefRangeEnd = 653349, XrefRangeStart = 653345, XrefRangeEnd = 653347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00046F9C File Offset: 0x0004519C
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00046FD8 File Offset: 0x000451D8
		public unsafe float colorTemperature
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 653351, RefRangeEnd = 653358, XrefRangeStart = 653349, XrefRangeEnd = 653351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_colorTemperature_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653358, XrefRangeEnd = 653360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_colorTemperature_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00047018 File Offset: 0x00045218
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00047054 File Offset: 0x00045254
		public unsafe bool useColorTemperature
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 653362, RefRangeEnd = 653369, XrefRangeStart = 653360, XrefRangeEnd = 653362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_useColorTemperature_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653369, XrefRangeEnd = 653371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_useColorTemperature_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00047094 File Offset: 0x00045294
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x000470D0 File Offset: 0x000452D0
		public unsafe float intensity
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 653373, RefRangeEnd = 653387, XrefRangeStart = 653371, XrefRangeEnd = 653373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_intensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 653389, RefRangeEnd = 653390, XrefRangeStart = 653387, XrefRangeEnd = 653389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00047110 File Offset: 0x00045310
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x0004714C File Offset: 0x0004534C
		public unsafe float bounceIntensity
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 653392, RefRangeEnd = 653398, XrefRangeStart = 653390, XrefRangeEnd = 653392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653398, XrefRangeEnd = 653400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_bounceIntensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x0004718C File Offset: 0x0004538C
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x000471C8 File Offset: 0x000453C8
		public unsafe bool useBoundingSphereOverride
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653400, XrefRangeEnd = 653402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_useBoundingSphereOverride_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653402, XrefRangeEnd = 653404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_useBoundingSphereOverride_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00047208 File Offset: 0x00045408
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00047244 File Offset: 0x00045444
		public unsafe Vector4 boundingSphereOverride
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653404, XrefRangeEnd = 653406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_boundingSphereOverride_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653406, XrefRangeEnd = 653408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_boundingSphereOverride_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00047284 File Offset: 0x00045484
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x000472C0 File Offset: 0x000454C0
		public unsafe bool useViewFrustumForShadowCasterCull
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653408, XrefRangeEnd = 653410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_useViewFrustumForShadowCasterCull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653410, XrefRangeEnd = 653412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_useViewFrustumForShadowCasterCull_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00047300 File Offset: 0x00045500
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x0004733C File Offset: 0x0004553C
		public unsafe int shadowCustomResolution
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653412, XrefRangeEnd = 653414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowCustomResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653414, XrefRangeEnd = 653416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowCustomResolution_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x0004737C File Offset: 0x0004557C
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x000473B8 File Offset: 0x000455B8
		public unsafe float shadowBias
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 653418, RefRangeEnd = 653419, XrefRangeStart = 653416, XrefRangeEnd = 653418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653419, XrefRangeEnd = 653421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x000473F8 File Offset: 0x000455F8
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00047434 File Offset: 0x00045634
		public unsafe float shadowNormalBias
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 653423, RefRangeEnd = 653424, XrefRangeStart = 653421, XrefRangeEnd = 653423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowNormalBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653424, XrefRangeEnd = 653426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowNormalBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00047474 File Offset: 0x00045674
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x000474B0 File Offset: 0x000456B0
		public unsafe float shadowNearPlane
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 653428, RefRangeEnd = 653429, XrefRangeStart = 653426, XrefRangeEnd = 653428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowNearPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653429, XrefRangeEnd = 653431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowNearPlane_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x000474F0 File Offset: 0x000456F0
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x0004752C File Offset: 0x0004572C
		public unsafe bool useShadowMatrixOverride
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653431, XrefRangeEnd = 653433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_useShadowMatrixOverride_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653433, XrefRangeEnd = 653435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_useShadowMatrixOverride_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x0004756C File Offset: 0x0004576C
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x000475A8 File Offset: 0x000457A8
		public unsafe Matrix4x4 shadowMatrixOverride
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653435, XrefRangeEnd = 653437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowMatrixOverride_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653437, XrefRangeEnd = 653439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowMatrixOverride_Public_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x000475E8 File Offset: 0x000457E8
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x00047624 File Offset: 0x00045824
		public unsafe float range
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 653441, RefRangeEnd = 653445, XrefRangeStart = 653439, XrefRangeEnd = 653441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_range_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653445, XrefRangeEnd = 653447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_range_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00047664 File Offset: 0x00045864
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x000476A4 File Offset: 0x000458A4
		public unsafe Flare flare
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653447, XrefRangeEnd = 653449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_flare_Public_get_Flare_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Flare>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653449, XrefRangeEnd = 653451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_flare_Public_set_Void_Flare_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x000476E8 File Offset: 0x000458E8
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x00047724 File Offset: 0x00045924
		public unsafe LightBakingOutput bakingOutput
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 653453, RefRangeEnd = 653469, XrefRangeStart = 653451, XrefRangeEnd = 653453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653469, XrefRangeEnd = 653471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_bakingOutput_Public_set_Void_LightBakingOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00047764 File Offset: 0x00045964
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x000477A0 File Offset: 0x000459A0
		public unsafe int cullingMask
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653471, XrefRangeEnd = 653473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653473, XrefRangeEnd = 653475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x000477E0 File Offset: 0x000459E0
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x0004781C File Offset: 0x00045A1C
		public unsafe int renderingLayerMask
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653475, XrefRangeEnd = 653477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_renderingLayerMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 653479, RefRangeEnd = 653480, XrefRangeStart = 653477, XrefRangeEnd = 653479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x0004785C File Offset: 0x00045A5C
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00047898 File Offset: 0x00045A98
		public unsafe LightShadowCasterMode lightShadowCasterMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653480, XrefRangeEnd = 653482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_lightShadowCasterMode_Public_get_LightShadowCasterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653482, XrefRangeEnd = 653484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_lightShadowCasterMode_Public_set_Void_LightShadowCasterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000478D8 File Offset: 0x00045AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653484, XrefRangeEnd = 653486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x0004790C File Offset: 0x00045B0C
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x00047948 File Offset: 0x00045B48
		public unsafe LightShadows shadows
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 653488, RefRangeEnd = 653519, XrefRangeStart = 653486, XrefRangeEnd = 653488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653519, XrefRangeEnd = 653521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadows_Public_set_Void_LightShadows_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00047988 File Offset: 0x00045B88
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x000479C4 File Offset: 0x00045BC4
		public unsafe float shadowStrength
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 653523, RefRangeEnd = 653529, XrefRangeStart = 653521, XrefRangeEnd = 653523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowStrength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 653531, RefRangeEnd = 653532, XrefRangeStart = 653529, XrefRangeEnd = 653531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowStrength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x00047A04 File Offset: 0x00045C04
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x00047A40 File Offset: 0x00045C40
		public unsafe UnityEngine.Rendering.LightShadowResolution shadowResolution
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 653534, RefRangeEnd = 653535, XrefRangeStart = 653532, XrefRangeEnd = 653534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowResolution_Public_get_LightShadowResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653535, XrefRangeEnd = 653537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowResolution_Public_set_Void_LightShadowResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00047A80 File Offset: 0x00045C80
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x00047ABC File Offset: 0x00045CBC
		public unsafe float shadowSoftness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowSoftness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowSoftness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00047AFC File Offset: 0x00045CFC
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x00047B38 File Offset: 0x00045D38
		public unsafe float shadowSoftnessFade
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowSoftnessFade_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowSoftnessFade_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x00047B78 File Offset: 0x00045D78
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00047BB8 File Offset: 0x00045DB8
		public unsafe Il2CppStructArray<float> layerShadowCullDistances
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653537, XrefRangeEnd = 653539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_layerShadowCullDistances_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653539, XrefRangeEnd = 653541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_layerShadowCullDistances_Public_set_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00047BFC File Offset: 0x00045DFC
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x00047C38 File Offset: 0x00045E38
		public unsafe float cookieSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 653543, RefRangeEnd = 653545, XrefRangeStart = 653541, XrefRangeEnd = 653543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653545, XrefRangeEnd = 653547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_cookieSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00047C78 File Offset: 0x00045E78
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x00047CB8 File Offset: 0x00045EB8
		public unsafe Texture cookie
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 653549, RefRangeEnd = 653559, XrefRangeStart = 653547, XrefRangeEnd = 653549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_cookie_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653559, XrefRangeEnd = 653561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_cookie_Public_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00047CFC File Offset: 0x00045EFC
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00047D38 File Offset: 0x00045F38
		public unsafe LightRenderMode renderMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653561, XrefRangeEnd = 653563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_renderMode_Public_get_LightRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653563, XrefRangeEnd = 653565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_renderMode_Public_set_Void_LightRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00047D78 File Offset: 0x00045F78
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x00047DB4 File Offset: 0x00045FB4
		public unsafe int bakedIndex
		{
			[CallerCount(66)]
			[CachedScanResults(RefRangeStart = 320372, RefRangeEnd = 320438, XrefRangeStart = 320372, XrefRangeEnd = 320438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_bakedIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_bakedIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00047DF4 File Offset: 0x00045FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653565, XrefRangeEnd = 653567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_AddCommandBuffer_Public_Void_LightEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00047E44 File Offset: 0x00046044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653567, XrefRangeEnd = 653569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowPassMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_AddCommandBuffer_Public_Void_LightEvent_CommandBuffer_ShadowMapPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00047EA4 File Offset: 0x000460A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653569, XrefRangeEnd = 653571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queueType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_AddCommandBufferAsync_Public_Void_LightEvent_CommandBuffer_ComputeQueueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00047F04 File Offset: 0x00046104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653571, XrefRangeEnd = 653573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowPassMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queueType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_AddCommandBufferAsync_Public_Void_LightEvent_CommandBuffer_ShadowMapPass_ComputeQueueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00047F70 File Offset: 0x00046170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653573, XrefRangeEnd = 653575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_RemoveCommandBuffer_Public_Void_LightEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00047FC0 File Offset: 0x000461C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653575, XrefRangeEnd = 653577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCommandBuffers(UnityEngine.Rendering.LightEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_RemoveCommandBuffers_Public_Void_LightEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00048000 File Offset: 0x00046200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653577, XrefRangeEnd = 653579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAllCommandBuffers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_RemoveAllCommandBuffers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00048034 File Offset: 0x00046234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653579, XrefRangeEnd = 653581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer> GetCommandBuffers(UnityEngine.Rendering.LightEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_GetCommandBuffers_Public_Il2CppReferenceArray_1_CommandBuffer_LightEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer>>(intPtr3) : null;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x00048080 File Offset: 0x00046280
		public unsafe int commandBufferCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653581, XrefRangeEnd = 653583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_commandBufferCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x000480BC File Offset: 0x000462BC
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x000480EC File Offset: 0x000462EC
		public unsafe static int pixelLightCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653583, XrefRangeEnd = 653584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_pixelLightCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653584, XrefRangeEnd = 653585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_pixelLightCount_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00048120 File Offset: 0x00046320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653585, XrefRangeEnd = 653587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Light> GetLights(LightType type, int layer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_GetLights_Public_Static_Il2CppReferenceArray_1_Light_LightType_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr3) : null;
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x00048170 File Offset: 0x00046370
		// (set) Token: 0x06000E7E RID: 3710 RVA: 0x000481AC File Offset: 0x000463AC
		public unsafe float shadowConstantBias
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowConstantBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowConstantBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x000481EC File Offset: 0x000463EC
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x00048228 File Offset: 0x00046428
		public unsafe float shadowObjectSizeBias
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowObjectSizeBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowObjectSizeBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x00048268 File Offset: 0x00046468
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x000482A4 File Offset: 0x000464A4
		public unsafe bool attenuate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_attenuate_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_attenuate_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000482E4 File Offset: 0x000464E4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Light()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Light>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00048320 File Offset: 0x00046520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653587, XrefRangeEnd = 653589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_color_Injected(out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00048360 File Offset: 0x00046560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653589, XrefRangeEnd = 653591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_color_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x000483A0 File Offset: 0x000465A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653591, XrefRangeEnd = 653593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_boundingSphereOverride_Injected(out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_boundingSphereOverride_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x000483E0 File Offset: 0x000465E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653593, XrefRangeEnd = 653595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_boundingSphereOverride_Injected(ref Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_boundingSphereOverride_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00048420 File Offset: 0x00046620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653595, XrefRangeEnd = 653597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_shadowMatrixOverride_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowMatrixOverride_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00048460 File Offset: 0x00046660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653597, XrefRangeEnd = 653599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_shadowMatrixOverride_Injected(ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowMatrixOverride_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x000484A0 File Offset: 0x000466A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653599, XrefRangeEnd = 653601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bakingOutput_Injected(out LightBakingOutput ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x000484E0 File Offset: 0x000466E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653601, XrefRangeEnd = 653603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_bakingOutput_Injected(ref LightBakingOutput value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0000712F File Offset: 0x0000532F
		public Light(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x00048520 File Offset: 0x00046720
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x00007138 File Offset: 0x00005338
		public unsafe int m_BakedIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light.NativeFieldInfoPtr_m_BakedIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light.NativeFieldInfoPtr_m_BakedIndex)) = value;
			}
		}

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeFieldInfoPtr_m_BakedIndex;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_LightType_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_LightType_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_get_shape_Public_get_LightShape_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_set_shape_Public_set_Void_LightShape_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_set_spotAngle_Public_set_Void_Single_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_get_innerSpotAngle_Public_get_Single_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_set_innerSpotAngle_Public_set_Void_Single_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr_get_colorTemperature_Public_get_Single_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_set_colorTemperature_Public_set_Void_Single_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_get_useColorTemperature_Public_get_Boolean_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_set_useColorTemperature_Public_set_Void_Boolean_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_get_intensity_Public_get_Single_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_set_bounceIntensity_Public_set_Void_Single_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_get_useBoundingSphereOverride_Public_get_Boolean_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_set_useBoundingSphereOverride_Public_set_Void_Boolean_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_get_boundingSphereOverride_Public_get_Vector4_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_set_boundingSphereOverride_Public_set_Void_Vector4_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_get_useViewFrustumForShadowCasterCull_Public_get_Boolean_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_set_useViewFrustumForShadowCasterCull_Public_set_Void_Boolean_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowCustomResolution_Public_get_Int32_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowCustomResolution_Public_set_Void_Int32_0;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowBias_Public_set_Void_Single_0;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowNormalBias_Public_get_Single_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowNormalBias_Public_set_Void_Single_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowNearPlane_Public_get_Single_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowNearPlane_Public_set_Void_Single_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_get_useShadowMatrixOverride_Public_get_Boolean_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_set_useShadowMatrixOverride_Public_set_Void_Boolean_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowMatrixOverride_Public_get_Matrix4x4_0;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowMatrixOverride_Public_set_Void_Matrix4x4_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_get_range_Public_get_Single_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_set_range_Public_set_Void_Single_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_get_flare_Public_get_Flare_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_set_flare_Public_set_Void_Flare_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_set_bakingOutput_Public_set_Void_LightBakingOutput_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingLayerMask_Public_get_Int32_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_Int32_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_get_lightShadowCasterMode_Public_get_LightShadowCasterMode_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_set_lightShadowCasterMode_Public_set_Void_LightShadowCasterMode_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_set_shadows_Public_set_Void_LightShadows_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowStrength_Public_get_Single_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowStrength_Public_set_Void_Single_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowResolution_Public_get_LightShadowResolution_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowResolution_Public_set_Void_LightShadowResolution_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowSoftness_Public_get_Single_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowSoftness_Public_set_Void_Single_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowSoftnessFade_Public_get_Single_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowSoftnessFade_Public_set_Void_Single_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_get_layerShadowCullDistances_Public_get_Il2CppStructArray_1_Single_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_set_layerShadowCullDistances_Public_set_Void_Il2CppStructArray_1_Single_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_set_cookieSize_Public_set_Void_Single_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_get_cookie_Public_get_Texture_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_set_cookie_Public_set_Void_Texture_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_get_renderMode_Public_get_LightRenderMode_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_set_renderMode_Public_set_Void_LightRenderMode_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_get_bakedIndex_Public_get_Int32_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_set_bakedIndex_Public_set_Void_Int32_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_AddCommandBuffer_Public_Void_LightEvent_CommandBuffer_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_AddCommandBuffer_Public_Void_LightEvent_CommandBuffer_ShadowMapPass_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_AddCommandBufferAsync_Public_Void_LightEvent_CommandBuffer_ComputeQueueType_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_AddCommandBufferAsync_Public_Void_LightEvent_CommandBuffer_ShadowMapPass_ComputeQueueType_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCommandBuffer_Public_Void_LightEvent_CommandBuffer_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCommandBuffers_Public_Void_LightEvent_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllCommandBuffers_Public_Void_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_GetCommandBuffers_Public_Il2CppReferenceArray_1_CommandBuffer_LightEvent_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_get_commandBufferCount_Public_get_Int32_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelLightCount_Public_Static_get_Int32_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelLightCount_Public_Static_set_Void_Int32_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_GetLights_Public_Static_Il2CppReferenceArray_1_Light_LightType_Int32_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowConstantBias_Public_get_Single_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowConstantBias_Public_set_Void_Single_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowObjectSizeBias_Public_get_Single_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowObjectSizeBias_Public_set_Void_Single_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_get_attenuate_Public_get_Boolean_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_set_attenuate_Public_set_Void_Boolean_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_get_boundingSphereOverride_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_set_boundingSphereOverride_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowMatrixOverride_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowMatrixOverride_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_set_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0;
	}
}
