using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x020000D4 RID: 212
	public static class CoreUtils : Object
	{
		// Token: 0x06000F5F RID: 3935 RVA: 0x00046EAC File Offset: 0x000450AC
		// Note: this type is marked as 'beforefieldinit'.
		static CoreUtils()
		{
			Il2CppClassPointerStore<CoreUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "CoreUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr);
			CoreUtils.NativeFieldInfoPtr_lookAtList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "lookAtList");
			CoreUtils.NativeFieldInfoPtr_upVectorList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "upVectorList");
			CoreUtils.NativeFieldInfoPtr_obsoletePriorityMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "obsoletePriorityMessage");
			CoreUtils.NativeFieldInfoPtr_editMenuPriority1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "editMenuPriority1");
			CoreUtils.NativeFieldInfoPtr_editMenuPriority2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "editMenuPriority2");
			CoreUtils.NativeFieldInfoPtr_editMenuPriority3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "editMenuPriority3");
			CoreUtils.NativeFieldInfoPtr_editMenuPriority4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "editMenuPriority4");
			CoreUtils.NativeFieldInfoPtr_assetCreateMenuPriority1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "assetCreateMenuPriority1");
			CoreUtils.NativeFieldInfoPtr_assetCreateMenuPriority2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "assetCreateMenuPriority2");
			CoreUtils.NativeFieldInfoPtr_assetCreateMenuPriority3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "assetCreateMenuPriority3");
			CoreUtils.NativeFieldInfoPtr_gameObjectMenuPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "gameObjectMenuPriority");
			CoreUtils.NativeFieldInfoPtr_m_BlackCubeTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "m_BlackCubeTexture");
			CoreUtils.NativeFieldInfoPtr_m_MagentaCubeTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "m_MagentaCubeTexture");
			CoreUtils.NativeFieldInfoPtr_m_MagentaCubeTextureArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "m_MagentaCubeTextureArray");
			CoreUtils.NativeFieldInfoPtr_m_WhiteCubeTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "m_WhiteCubeTexture");
			CoreUtils.NativeFieldInfoPtr_m_EmptyUAV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "m_EmptyUAV");
			CoreUtils.NativeFieldInfoPtr_m_BlackVolumeTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "m_BlackVolumeTexture");
			CoreUtils.NativeFieldInfoPtr_m_AssemblyTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "m_AssemblyTypes");
			CoreUtils.NativeMethodInfoPtr_get_blackCubeTexture_Public_Static_get_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665556);
			CoreUtils.NativeMethodInfoPtr_get_magentaCubeTexture_Public_Static_get_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665557);
			CoreUtils.NativeMethodInfoPtr_get_magentaCubeTextureArray_Public_Static_get_CubemapArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665558);
			CoreUtils.NativeMethodInfoPtr_get_whiteCubeTexture_Public_Static_get_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665559);
			CoreUtils.NativeMethodInfoPtr_get_emptyUAV_Public_Static_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665560);
			CoreUtils.NativeMethodInfoPtr_get_blackVolumeTexture_Public_Static_get_Texture3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665561);
			CoreUtils.NativeMethodInfoPtr_ClearRenderTarget_Public_Static_Void_CommandBuffer_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665562);
			CoreUtils.NativeMethodInfoPtr_FixupDepthSlice_Private_Static_Int32_Int32_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665563);
			CoreUtils.NativeMethodInfoPtr_FixupDepthSlice_Private_Static_Int32_Int32_CubemapFace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665564);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_ClearFlag_Color_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665565);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_ClearFlag_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665566);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665567);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665568);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665569);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665570);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665571);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665572);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665573);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665574);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665575);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665576);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665577);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665578);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665579);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665580);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665581);
			CoreUtils.NativeMethodInfoPtr_SetViewportAndClear_Private_Static_Void_CommandBuffer_RTHandle_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665582);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_ClearFlag_Color_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665583);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_ClearFlag_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665584);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665585);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665586);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665587);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665588);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665589);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665590);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_ClearFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665591);
			CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665592);
			CoreUtils.NativeMethodInfoPtr_SetViewport_Public_Static_Void_CommandBuffer_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665593);
			CoreUtils.NativeMethodInfoPtr_GetRenderTargetAutoName_Public_Static_String_Int32_Int32_Int32_RenderTextureFormat_String_Boolean_Boolean_MSAASamples_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665594);
			CoreUtils.NativeMethodInfoPtr_GetRenderTargetAutoName_Public_Static_String_Int32_Int32_Int32_GraphicsFormat_String_Boolean_Boolean_MSAASamples_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665595);
			CoreUtils.NativeMethodInfoPtr_GetRenderTargetAutoName_Public_Static_String_Int32_Int32_Int32_GraphicsFormat_TextureDimension_String_Boolean_Boolean_MSAASamples_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665596);
			CoreUtils.NativeMethodInfoPtr_GetRenderTargetAutoName_Private_Static_String_Int32_Int32_Int32_String_TextureDimension_String_Boolean_Boolean_MSAASamples_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665597);
			CoreUtils.NativeMethodInfoPtr_GetTextureAutoName_Public_Static_String_Int32_Int32_TextureFormat_TextureDimension_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665598);
			CoreUtils.NativeMethodInfoPtr_GetTextureAutoName_Public_Static_String_Int32_Int32_GraphicsFormat_TextureDimension_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665599);
			CoreUtils.NativeMethodInfoPtr_GetTextureAutoName_Private_Static_String_Int32_Int32_String_TextureDimension_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665600);
			CoreUtils.NativeMethodInfoPtr_ClearCubemap_Public_Static_Void_CommandBuffer_RenderTexture_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665601);
			CoreUtils.NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_MaterialPropertyBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665602);
			CoreUtils.NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_RenderTargetIdentifier_MaterialPropertyBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665603);
			CoreUtils.NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_RenderTargetIdentifier_RenderTargetIdentifier_MaterialPropertyBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665604);
			CoreUtils.NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_MaterialPropertyBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665605);
			CoreUtils.NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_Il2CppStructArray_1_RenderTargetIdentifier_MaterialPropertyBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665606);
			CoreUtils.NativeMethodInfoPtr_ConvertSRGBToActiveColorSpace_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665607);
			CoreUtils.NativeMethodInfoPtr_ConvertLinearToActiveColorSpace_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665608);
			CoreUtils.NativeMethodInfoPtr_CreateEngineMaterial_Public_Static_Material_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665609);
			CoreUtils.NativeMethodInfoPtr_CreateEngineMaterial_Public_Static_Material_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665610);
			CoreUtils.NativeMethodInfoPtr_HasFlag_Public_Static_Boolean_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665611);
			CoreUtils.NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665612);
			CoreUtils.NativeMethodInfoPtr_SetKeyword_Public_Static_Void_CommandBuffer_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665613);
			CoreUtils.NativeMethodInfoPtr_SetKeyword_Public_Static_Void_Material_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665614);
			CoreUtils.NativeMethodInfoPtr_SetKeyword_Public_Static_Void_ComputeShader_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665615);
			CoreUtils.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665616);
			CoreUtils.NativeMethodInfoPtr_GetAllAssemblyTypes_Public_Static_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665617);
			CoreUtils.NativeMethodInfoPtr_GetAllTypesDerivedFrom_Public_Static_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665618);
			CoreUtils.NativeMethodInfoPtr_SafeRelease_Public_Static_Void_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665619);
			CoreUtils.NativeMethodInfoPtr_SafeRelease_Public_Static_Void_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665620);
			CoreUtils.NativeMethodInfoPtr_CreateCubeMesh_Public_Static_Mesh_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665621);
			CoreUtils.NativeMethodInfoPtr_ArePostProcessesEnabled_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665622);
			CoreUtils.NativeMethodInfoPtr_AreAnimatedMaterialsEnabled_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665623);
			CoreUtils.NativeMethodInfoPtr_IsSceneLightingDisabled_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665624);
			CoreUtils.NativeMethodInfoPtr_IsLightOverlapDebugEnabled_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665625);
			CoreUtils.NativeMethodInfoPtr_IsSceneViewFogEnabled_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665626);
			CoreUtils.NativeMethodInfoPtr_IsSceneFilteringEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665627);
			CoreUtils.NativeMethodInfoPtr_IsSceneViewPrefabStageContextHidden_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665628);
			CoreUtils.NativeMethodInfoPtr_DrawRendererList_Public_Static_Void_ScriptableRenderContext_CommandBuffer_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665629);
			CoreUtils.NativeMethodInfoPtr_GetTextureHash_Public_Static_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665630);
			CoreUtils.NativeMethodInfoPtr_PreviousPowerOfTwo_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665631);
			CoreUtils.NativeMethodInfoPtr_GetLastEnumValue_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665632);
			CoreUtils.NativeMethodInfoPtr_GetCorePath_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100665633);
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0004765C File Offset: 0x0004585C
		public unsafe static Cubemap blackCubeTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976145, XrefRangeEnd = 976173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_get_blackCubeTexture_Public_Static_get_Cubemap_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr3) : null;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00047690 File Offset: 0x00045890
		public unsafe static Cubemap magentaCubeTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976173, XrefRangeEnd = 976201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_get_magentaCubeTexture_Public_Static_get_Cubemap_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr3) : null;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x000476C4 File Offset: 0x000458C4
		public unsafe static CubemapArray magentaCubeTextureArray
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976201, XrefRangeEnd = 976232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_get_magentaCubeTextureArray_Public_Static_get_CubemapArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CubemapArray>(intPtr3) : null;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x000476F8 File Offset: 0x000458F8
		public unsafe static Cubemap whiteCubeTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976232, XrefRangeEnd = 976260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_get_whiteCubeTexture_Public_Static_get_Cubemap_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr3) : null;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0004772C File Offset: 0x0004592C
		public unsafe static RenderTexture emptyUAV
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976260, XrefRangeEnd = 976284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_get_emptyUAV_Public_Static_get_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00047760 File Offset: 0x00045960
		public unsafe static Texture3D blackVolumeTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976284, XrefRangeEnd = 976311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_get_blackVolumeTexture_Public_Static_get_Texture3D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr3) : null;
			}
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00047794 File Offset: 0x00045994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976311, XrefRangeEnd = 976312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearRenderTarget(CommandBuffer cmd, ClearFlag clearFlag, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_ClearRenderTarget_Public_Static_Void_CommandBuffer_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x000477E8 File Offset: 0x000459E8
		[CallerCount(0)]
		public unsafe static int FixupDepthSlice(int depthSlice, RTHandle buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depthSlice;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_FixupDepthSlice_Private_Static_Int32_Int32_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00047838 File Offset: 0x00045A38
		[CallerCount(0)]
		public unsafe static int FixupDepthSlice(int depthSlice, CubemapFace cubemapFace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depthSlice;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_FixupDepthSlice_Private_Static_Int32_Int32_CubemapFace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00047884 File Offset: 0x00045A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976312, XrefRangeEnd = 976317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_ClearFlag_Color_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00047910 File Offset: 0x00045B10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976325, RefRangeEnd = 976326, XrefRangeStart = 976317, XrefRangeEnd = 976325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag = ClearFlag.None, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_ClearFlag_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0004798C File Offset: 0x00045B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976326, XrefRangeEnd = 976333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00047A08 File Offset: 0x00045C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976333, XrefRangeEnd = 976341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00047A94 File Offset: 0x00045C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976341, XrefRangeEnd = 976346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00047B2C File Offset: 0x00045D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976346, XrefRangeEnd = 976353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, Il2CppStructArray<RenderTargetIdentifier> colorBuffers, RenderTargetIdentifier depthBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorBuffers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00047B84 File Offset: 0x00045D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976353, XrefRangeEnd = 976361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, Il2CppStructArray<RenderTargetIdentifier> colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag = ClearFlag.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorBuffers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00047BE8 File Offset: 0x00045DE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976366, RefRangeEnd = 976367, XrefRangeStart = 976361, XrefRangeEnd = 976366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, Il2CppStructArray<RenderTargetIdentifier> colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorBuffers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00047C5C File Offset: 0x00045E5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 976372, RefRangeEnd = 976374, XrefRangeStart = 976367, XrefRangeEnd = 976372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00047CD8 File Offset: 0x00045ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976374, XrefRangeEnd = 976379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00047D64 File Offset: 0x00045F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976379, XrefRangeEnd = 976388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00047E0C File Offset: 0x0004600C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976388, XrefRangeEnd = 976396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00047E7C File Offset: 0x0004607C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 976401, RefRangeEnd = 976403, XrefRangeStart = 976396, XrefRangeEnd = 976401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00047F24 File Offset: 0x00046124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976403, XrefRangeEnd = 976409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00047FDC File Offset: 0x000461DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976409, XrefRangeEnd = 976419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x000480B0 File Offset: 0x000462B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976424, RefRangeEnd = 976425, XrefRangeStart = 976419, XrefRangeEnd = 976424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00048148 File Offset: 0x00046348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976425, XrefRangeEnd = 976433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000481E0 File Offset: 0x000463E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976433, XrefRangeEnd = 976440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetViewportAndClear(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetViewportAndClear_Private_Static_Void_CommandBuffer_RTHandle_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00048244 File Offset: 0x00046444
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 976452, RefRangeEnd = 976456, XrefRangeStart = 976440, XrefRangeEnd = 976452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_ClearFlag_Color_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x000482D4 File Offset: 0x000464D4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 976471, RefRangeEnd = 976481, XrefRangeStart = 976456, XrefRangeEnd = 976471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag = ClearFlag.None, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_ClearFlag_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00048354 File Offset: 0x00046554
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 976492, RefRangeEnd = 976494, XrefRangeStart = 976481, XrefRangeEnd = 976492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000483D8 File Offset: 0x000465D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976494, XrefRangeEnd = 976505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0004846C File Offset: 0x0004666C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 976530, RefRangeEnd = 976533, XrefRangeStart = 976505, XrefRangeEnd = 976530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0004850C File Offset: 0x0004670C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 976548, RefRangeEnd = 976555, XrefRangeStart = 976533, XrefRangeEnd = 976548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x000485B8 File Offset: 0x000467B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 976579, RefRangeEnd = 976584, XrefRangeStart = 976555, XrefRangeEnd = 976579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthBuffer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00048698 File Offset: 0x00046898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976594, RefRangeEnd = 976595, XrefRangeStart = 976584, XrefRangeEnd = 976594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, Il2CppStructArray<RenderTargetIdentifier> colorBuffers, RTHandle depthBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorBuffers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x000486F4 File Offset: 0x000468F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976595, XrefRangeEnd = 976612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, Il2CppStructArray<RenderTargetIdentifier> colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag = ClearFlag.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorBuffers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_ClearFlag_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0004875C File Offset: 0x0004695C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 976623, RefRangeEnd = 976625, XrefRangeStart = 976612, XrefRangeEnd = 976623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(CommandBuffer cmd, Il2CppStructArray<RenderTargetIdentifier> colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorBuffers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(depthBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_ClearFlag_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000487D4 File Offset: 0x000469D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976625, XrefRangeEnd = 976628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetViewport(CommandBuffer cmd, RTHandle target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetViewport_Public_Static_Void_CommandBuffer_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0004881C File Offset: 0x00046A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976635, RefRangeEnd = 976636, XrefRangeStart = 976628, XrefRangeEnd = 976635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRenderTargetAutoName(int width, int height, int depth, RenderTextureFormat format, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = MSAASamples.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mips;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableMSAA;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msaaSamples;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_GetRenderTargetAutoName_Public_Static_String_Int32_Int32_Int32_RenderTextureFormat_String_Boolean_Boolean_MSAASamples_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x000488BC File Offset: 0x00046ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976636, XrefRangeEnd = 976643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = MSAASamples.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mips;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableMSAA;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msaaSamples;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_GetRenderTargetAutoName_Public_Static_String_Int32_Int32_Int32_GraphicsFormat_String_Boolean_Boolean_MSAASamples_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0004895C File Offset: 0x00046B5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 976650, RefRangeEnd = 976654, XrefRangeStart = 976643, XrefRangeEnd = 976650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, TextureDimension dim, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = MSAASamples.None, bool dynamicRes = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mips;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableMSAA;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msaaSamples;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dynamicRes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_GetRenderTargetAutoName_Public_Static_String_Int32_Int32_Int32_GraphicsFormat_TextureDimension_String_Boolean_Boolean_MSAASamples_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00048A1C File Offset: 0x00046C1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 976688, RefRangeEnd = 976691, XrefRangeStart = 976654, XrefRangeEnd = 976688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRenderTargetAutoName(int width, int height, int depth, string format, TextureDimension dim, string name, bool mips, bool enableMSAA, MSAASamples msaaSamples, bool dynamicRes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mips;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableMSAA;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msaaSamples;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dynamicRes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_GetRenderTargetAutoName_Private_Static_String_Int32_Int32_Int32_String_TextureDimension_String_Boolean_Boolean_MSAASamples_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00048AE0 File Offset: 0x00046CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976691, XrefRangeEnd = 976698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTextureAutoName(int width, int height, TextureFormat format, TextureDimension dim = TextureDimension.None, string name = "", bool mips = false, int depth = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mips;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_GetTextureAutoName_Public_Static_String_Int32_Int32_TextureFormat_TextureDimension_String_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00048B74 File Offset: 0x00046D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976698, XrefRangeEnd = 976705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTextureAutoName(int width, int height, GraphicsFormat format, TextureDimension dim = TextureDimension.None, string name = "", bool mips = false, int depth = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mips;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_GetTextureAutoName_Public_Static_String_Int32_Int32_GraphicsFormat_TextureDimension_String_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00048C08 File Offset: 0x00046E08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 976761, RefRangeEnd = 976763, XrefRangeStart = 976705, XrefRangeEnd = 976761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTextureAutoName(int width, int height, string format, TextureDimension dim = TextureDimension.None, string name = "", bool mips = false, int depth = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mips;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_GetTextureAutoName_Private_Static_String_Int32_Int32_String_TextureDimension_String_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00048CA0 File Offset: 0x00046EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976763, XrefRangeEnd = 976777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCubemap(CommandBuffer cmd, RenderTexture renderTexture, Color clearColor, bool clearMips = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderTexture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearMips;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_ClearCubemap_Public_Static_Void_CommandBuffer_RenderTexture_Color_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00048D04 File Offset: 0x00046F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976777, XrefRangeEnd = 976780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawFullScreen(CommandBuffer commandBuffer, Material material, MaterialPropertyBlock properties = null, int shaderPassId = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderPassId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_MaterialPropertyBlock_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00048D6C File Offset: 0x00046F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976780, XrefRangeEnd = 976784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderPassId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_RenderTargetIdentifier_MaterialPropertyBlock_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00048DE4 File Offset: 0x00046FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976784, XrefRangeEnd = 976788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderPassId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_RenderTargetIdentifier_RenderTargetIdentifier_MaterialPropertyBlock_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00048E6C File Offset: 0x0004706C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976788, XrefRangeEnd = 976792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawFullScreen(CommandBuffer commandBuffer, Material material, Il2CppStructArray<RenderTargetIdentifier> colorBuffers, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorBuffers);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderPassId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_MaterialPropertyBlock_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00048EF8 File Offset: 0x000470F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976792, XrefRangeEnd = 976799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawFullScreen(CommandBuffer commandBuffer, Material material, Il2CppStructArray<RenderTargetIdentifier> colorBuffers, MaterialPropertyBlock properties = null, int shaderPassId = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colorBuffers);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderPassId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_Il2CppStructArray_1_RenderTargetIdentifier_MaterialPropertyBlock_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00048F74 File Offset: 0x00047174
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 976803, RefRangeEnd = 976809, XrefRangeStart = 976799, XrefRangeEnd = 976803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color ConvertSRGBToActiveColorSpace(Color color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_ConvertSRGBToActiveColorSpace_Public_Static_Color_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00048FB4 File Offset: 0x000471B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976810, RefRangeEnd = 976811, XrefRangeStart = 976809, XrefRangeEnd = 976810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color ConvertLinearToActiveColorSpace(Color color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_ConvertLinearToActiveColorSpace_Public_Static_Color_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00048FF4 File Offset: 0x000471F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976811, XrefRangeEnd = 976824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material CreateEngineMaterial(string shaderPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(shaderPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_CreateEngineMaterial_Public_Static_Material_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00049038 File Offset: 0x00047238
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 976835, RefRangeEnd = 976865, XrefRangeStart = 976824, XrefRangeEnd = 976835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material CreateEngineMaterial(Shader shader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_CreateEngineMaterial_Public_Static_Material_Shader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0004907C File Offset: 0x0004727C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976865, XrefRangeEnd = 976874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasFlag<T>(T mask, T flag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = mask;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref mask;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = flag;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref flag;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CoreUtils.MethodInfoStoreGeneric_HasFlag_Public_Static_Boolean_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0004913C File Offset: 0x0004733C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623019, RefRangeEnd = 623020, XrefRangeStart = 623019, XrefRangeEnd = 623020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Swap<T>(ref T a, ref T b)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CoreUtils.MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			a = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			b = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x000491B4 File Offset: 0x000473B4
		[CallerCount(84)]
		[CachedScanResults(RefRangeStart = 976877, RefRangeEnd = 976961, XrefRangeStart = 976874, XrefRangeEnd = 976877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKeyword(CommandBuffer cmd, string keyword, bool state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyword);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetKeyword_Public_Static_Void_CommandBuffer_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0004920C File Offset: 0x0004740C
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 976964, RefRangeEnd = 976997, XrefRangeStart = 976961, XrefRangeEnd = 976964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKeyword(Material material, string keyword, bool state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyword);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetKeyword_Public_Static_Void_Material_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00049264 File Offset: 0x00047464
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 977000, RefRangeEnd = 977004, XrefRangeStart = 976997, XrefRangeEnd = 977000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKeyword(ComputeShader cs, string keyword, bool state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyword);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SetKeyword_Public_Static_Void_ComputeShader_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000492BC File Offset: 0x000474BC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 977011, RefRangeEnd = 977085, XrefRangeStart = 977004, XrefRangeEnd = 977011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000492F4 File Offset: 0x000474F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 977117, RefRangeEnd = 977118, XrefRangeStart = 977085, XrefRangeEnd = 977117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Type> GetAllAssemblyTypes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_GetAllAssemblyTypes_Public_Static_IEnumerable_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00049328 File Offset: 0x00047528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 977146, RefRangeEnd = 977147, XrefRangeStart = 977118, XrefRangeEnd = 977146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Type> GetAllTypesDerivedFrom<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.MethodInfoStoreGeneric_GetAllTypesDerivedFrom_Public_Static_IEnumerable_1_Type_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0004935C File Offset: 0x0004755C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977147, XrefRangeEnd = 977148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SafeRelease(GraphicsBuffer buffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SafeRelease_Public_Static_Void_GraphicsBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00049394 File Offset: 0x00047594
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 977149, RefRangeEnd = 977154, XrefRangeStart = 977148, XrefRangeEnd = 977149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SafeRelease(ComputeBuffer buffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_SafeRelease_Public_Static_Void_ComputeBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x000493CC File Offset: 0x000475CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 977166, RefRangeEnd = 977167, XrefRangeStart = 977154, XrefRangeEnd = 977166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateCubeMesh(Vector3 min, Vector3 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_CreateCubeMesh_Public_Static_Mesh_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0004941C File Offset: 0x0004761C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ArePostProcessesEnabled(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_ArePostProcessesEnabled_Public_Static_Boolean_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00049460 File Offset: 0x00047660
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreAnimatedMaterialsEnabled(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_AreAnimatedMaterialsEnabled_Public_Static_Boolean_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x000494A4 File Offset: 0x000476A4
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSceneLightingDisabled(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_IsSceneLightingDisabled_Public_Static_Boolean_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x000494E8 File Offset: 0x000476E8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLightOverlapDebugEnabled(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_IsLightOverlapDebugEnabled_Public_Static_Boolean_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0004952C File Offset: 0x0004772C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSceneViewFogEnabled(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_IsSceneViewFogEnabled_Public_Static_Boolean_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00049570 File Offset: 0x00047770
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSceneFilteringEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_IsSceneFilteringEnabled_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000495A0 File Offset: 0x000477A0
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSceneViewPrefabStageContextHidden()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_IsSceneViewPrefabStageContextHidden_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x000495D0 File Offset: 0x000477D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977167, XrefRangeEnd = 977172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, RendererList rendererList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderContext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rendererList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_DrawRendererList_Public_Static_Void_ScriptableRenderContext_CommandBuffer_RendererList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00049624 File Offset: 0x00047824
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 977187, RefRangeEnd = 977203, XrefRangeStart = 977172, XrefRangeEnd = 977187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetTextureHash(Texture texture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_GetTextureHash_Public_Static_Int32_Texture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00049668 File Offset: 0x00047868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 977203, RefRangeEnd = 977204, XrefRangeStart = 977203, XrefRangeEnd = 977203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PreviousPowerOfTwo(int size)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_PreviousPowerOfTwo_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x000496A8 File Offset: 0x000478A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 977212, RefRangeEnd = 977214, XrefRangeStart = 977204, XrefRangeEnd = 977212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetLastEnumValue<T>() where T : Enum
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.MethodInfoStoreGeneric_GetLastEnumValue_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x000496D8 File Offset: 0x000478D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977214, XrefRangeEnd = 977216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCorePath()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_GetCorePath_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x000085AB File Offset: 0x000067AB
		public CoreUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x00049704 File Offset: 0x00047904
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x000085B4 File Offset: 0x000067B4
		public unsafe static Il2CppStructArray<Vector3> lookAtList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_lookAtList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_lookAtList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x0004972C File Offset: 0x0004792C
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x000085C6 File Offset: 0x000067C6
		public unsafe static Il2CppStructArray<Vector3> upVectorList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_upVectorList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_upVectorList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x00049754 File Offset: 0x00047954
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x000085D8 File Offset: 0x000067D8
		public unsafe static string obsoletePriorityMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_obsoletePriorityMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_obsoletePriorityMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00049774 File Offset: 0x00047974
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x000085EA File Offset: 0x000067EA
		public unsafe static int editMenuPriority1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_editMenuPriority1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_editMenuPriority1, (void*)(&value));
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x00049790 File Offset: 0x00047990
		// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x000085F8 File Offset: 0x000067F8
		public unsafe static int editMenuPriority2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_editMenuPriority2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_editMenuPriority2, (void*)(&value));
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x000497AC File Offset: 0x000479AC
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x00008606 File Offset: 0x00006806
		public unsafe static int editMenuPriority3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_editMenuPriority3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_editMenuPriority3, (void*)(&value));
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x000497C8 File Offset: 0x000479C8
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x00008614 File Offset: 0x00006814
		public unsafe static int editMenuPriority4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_editMenuPriority4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_editMenuPriority4, (void*)(&value));
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x000497E4 File Offset: 0x000479E4
		// (set) Token: 0x06000FBE RID: 4030 RVA: 0x00008622 File Offset: 0x00006822
		public unsafe static int assetCreateMenuPriority1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_assetCreateMenuPriority1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_assetCreateMenuPriority1, (void*)(&value));
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x00049800 File Offset: 0x00047A00
		// (set) Token: 0x06000FC0 RID: 4032 RVA: 0x00008630 File Offset: 0x00006830
		public unsafe static int assetCreateMenuPriority2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_assetCreateMenuPriority2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_assetCreateMenuPriority2, (void*)(&value));
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x0004981C File Offset: 0x00047A1C
		// (set) Token: 0x06000FC2 RID: 4034 RVA: 0x0000863E File Offset: 0x0000683E
		public unsafe static int assetCreateMenuPriority3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_assetCreateMenuPriority3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_assetCreateMenuPriority3, (void*)(&value));
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x00049838 File Offset: 0x00047A38
		// (set) Token: 0x06000FC4 RID: 4036 RVA: 0x0000864C File Offset: 0x0000684C
		public unsafe static int gameObjectMenuPriority
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_gameObjectMenuPriority, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_gameObjectMenuPriority, (void*)(&value));
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00049854 File Offset: 0x00047A54
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x0000865A File Offset: 0x0000685A
		public unsafe static Cubemap m_BlackCubeTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_m_BlackCubeTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_m_BlackCubeTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x0004987C File Offset: 0x00047A7C
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x0000866C File Offset: 0x0000686C
		public unsafe static Cubemap m_MagentaCubeTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_m_MagentaCubeTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_m_MagentaCubeTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x000498A4 File Offset: 0x00047AA4
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x0000867E File Offset: 0x0000687E
		public unsafe static CubemapArray m_MagentaCubeTextureArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_m_MagentaCubeTextureArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CubemapArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_m_MagentaCubeTextureArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x000498CC File Offset: 0x00047ACC
		// (set) Token: 0x06000FCC RID: 4044 RVA: 0x00008690 File Offset: 0x00006890
		public unsafe static Cubemap m_WhiteCubeTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_m_WhiteCubeTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_m_WhiteCubeTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x000498F4 File Offset: 0x00047AF4
		// (set) Token: 0x06000FCE RID: 4046 RVA: 0x000086A2 File Offset: 0x000068A2
		public unsafe static RenderTexture m_EmptyUAV
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_m_EmptyUAV, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_m_EmptyUAV, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x0004991C File Offset: 0x00047B1C
		// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x000086B4 File Offset: 0x000068B4
		public unsafe static Texture3D m_BlackVolumeTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_m_BlackVolumeTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_m_BlackVolumeTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00049944 File Offset: 0x00047B44
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x000086C6 File Offset: 0x000068C6
		public unsafe static IEnumerable<Type> m_AssemblyTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreUtils.NativeFieldInfoPtr_m_AssemblyTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUtils.NativeFieldInfoPtr_m_AssemblyTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeFieldInfoPtr_lookAtList;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeFieldInfoPtr_upVectorList;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeFieldInfoPtr_obsoletePriorityMessage;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeFieldInfoPtr_editMenuPriority1;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeFieldInfoPtr_editMenuPriority2;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeFieldInfoPtr_editMenuPriority3;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeFieldInfoPtr_editMenuPriority4;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeFieldInfoPtr_assetCreateMenuPriority1;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeFieldInfoPtr_assetCreateMenuPriority2;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeFieldInfoPtr_assetCreateMenuPriority3;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeFieldInfoPtr_gameObjectMenuPriority;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackCubeTexture;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeFieldInfoPtr_m_MagentaCubeTexture;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeFieldInfoPtr_m_MagentaCubeTextureArray;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeFieldInfoPtr_m_WhiteCubeTexture;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeFieldInfoPtr_m_EmptyUAV;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackVolumeTexture;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeFieldInfoPtr_m_AssemblyTypes;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_get_blackCubeTexture_Public_Static_get_Cubemap_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_get_magentaCubeTexture_Public_Static_get_Cubemap_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_get_magentaCubeTextureArray_Public_Static_get_CubemapArray_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_get_whiteCubeTexture_Public_Static_get_Cubemap_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_get_emptyUAV_Public_Static_get_RenderTexture_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_get_blackVolumeTexture_Public_Static_get_Texture3D_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_ClearRenderTarget_Public_Static_Void_CommandBuffer_ClearFlag_Color_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_FixupDepthSlice_Private_Static_Int32_Int32_RTHandle_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_FixupDepthSlice_Private_Static_Int32_Int32_CubemapFace_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_ClearFlag_Color_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_ClearFlag_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_ClearFlag_Color_0;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_0;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_0;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeMethodInfoPtr_SetViewportAndClear_Private_Static_Void_CommandBuffer_RTHandle_ClearFlag_Color_0;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_ClearFlag_Color_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_ClearFlag_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Int32_CubemapFace_Int32_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_0;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_ClearFlag_0;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_CommandBuffer_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_ClearFlag_Color_0;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_SetViewport_Public_Static_Void_CommandBuffer_RTHandle_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderTargetAutoName_Public_Static_String_Int32_Int32_Int32_RenderTextureFormat_String_Boolean_Boolean_MSAASamples_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderTargetAutoName_Public_Static_String_Int32_Int32_Int32_GraphicsFormat_String_Boolean_Boolean_MSAASamples_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderTargetAutoName_Public_Static_String_Int32_Int32_Int32_GraphicsFormat_TextureDimension_String_Boolean_Boolean_MSAASamples_Boolean_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderTargetAutoName_Private_Static_String_Int32_Int32_Int32_String_TextureDimension_String_Boolean_Boolean_MSAASamples_Boolean_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureAutoName_Public_Static_String_Int32_Int32_TextureFormat_TextureDimension_String_Boolean_Int32_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureAutoName_Public_Static_String_Int32_Int32_GraphicsFormat_TextureDimension_String_Boolean_Int32_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureAutoName_Private_Static_String_Int32_Int32_String_TextureDimension_String_Boolean_Int32_0;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr_ClearCubemap_Public_Static_Void_CommandBuffer_RenderTexture_Color_Boolean_0;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_MaterialPropertyBlock_Int32_0;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_RenderTargetIdentifier_MaterialPropertyBlock_Int32_0;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_RenderTargetIdentifier_RenderTargetIdentifier_MaterialPropertyBlock_Int32_0;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_MaterialPropertyBlock_Int32_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr_DrawFullScreen_Public_Static_Void_CommandBuffer_Material_Il2CppStructArray_1_RenderTargetIdentifier_MaterialPropertyBlock_Int32_0;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr_ConvertSRGBToActiveColorSpace_Public_Static_Color_Color_0;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_ConvertLinearToActiveColorSpace_Public_Static_Color_Color_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_CreateEngineMaterial_Public_Static_Material_String_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_CreateEngineMaterial_Public_Static_Material_Shader_0;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Public_Static_Boolean_T_T_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyword_Public_Static_Void_CommandBuffer_String_Boolean_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyword_Public_Static_Void_Material_String_Boolean_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyword_Public_Static_Void_ComputeShader_String_Boolean_0;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr_GetAllAssemblyTypes_Public_Static_IEnumerable_1_Type_0;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTypesDerivedFrom_Public_Static_IEnumerable_1_Type_0;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeMethodInfoPtr_SafeRelease_Public_Static_Void_GraphicsBuffer_0;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeMethodInfoPtr_SafeRelease_Public_Static_Void_ComputeBuffer_0;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr_CreateCubeMesh_Public_Static_Mesh_Vector3_Vector3_0;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr_ArePostProcessesEnabled_Public_Static_Boolean_Camera_0;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_AreAnimatedMaterialsEnabled_Public_Static_Boolean_Camera_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_IsSceneLightingDisabled_Public_Static_Boolean_Camera_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_IsLightOverlapDebugEnabled_Public_Static_Boolean_Camera_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_IsSceneViewFogEnabled_Public_Static_Boolean_Camera_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_IsSceneFilteringEnabled_Public_Static_Boolean_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr_IsSceneViewPrefabStageContextHidden_Public_Static_Boolean_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_DrawRendererList_Public_Static_Void_ScriptableRenderContext_CommandBuffer_RendererList_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureHash_Public_Static_Int32_Texture_0;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_PreviousPowerOfTwo_Public_Static_Int32_Int32_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr_GetLastEnumValue_Public_Static_T_0;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_GetCorePath_Internal_Static_String_0;

		// Token: 0x020001F3 RID: 499
		public static class Sections : Object
		{
			// Token: 0x06001A79 RID: 6777 RVA: 0x0006D4B0 File Offset: 0x0006B6B0
			// Note: this type is marked as 'beforefieldinit'.
			static Sections()
			{
				Il2CppClassPointerStore<CoreUtils.Sections>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "Sections");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreUtils.Sections>.NativeClassPtr);
				CoreUtils.Sections.NativeFieldInfoPtr_section1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.Sections>.NativeClassPtr, "section1");
				CoreUtils.Sections.NativeFieldInfoPtr_section2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.Sections>.NativeClassPtr, "section2");
				CoreUtils.Sections.NativeFieldInfoPtr_section3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.Sections>.NativeClassPtr, "section3");
				CoreUtils.Sections.NativeFieldInfoPtr_section4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.Sections>.NativeClassPtr, "section4");
				CoreUtils.Sections.NativeFieldInfoPtr_section5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.Sections>.NativeClassPtr, "section5");
				CoreUtils.Sections.NativeFieldInfoPtr_section6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.Sections>.NativeClassPtr, "section6");
				CoreUtils.Sections.NativeFieldInfoPtr_section7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.Sections>.NativeClassPtr, "section7");
				CoreUtils.Sections.NativeFieldInfoPtr_section8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.Sections>.NativeClassPtr, "section8");
			}

			// Token: 0x06001A7A RID: 6778 RVA: 0x0000D4B6 File Offset: 0x0000B6B6
			public Sections(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000770 RID: 1904
			// (get) Token: 0x06001A7B RID: 6779 RVA: 0x0006D57C File Offset: 0x0006B77C
			// (set) Token: 0x06001A7C RID: 6780 RVA: 0x0000D4BF File Offset: 0x0000B6BF
			public unsafe static int section1
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.Sections.NativeFieldInfoPtr_section1, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.Sections.NativeFieldInfoPtr_section1, (void*)(&value));
				}
			}

			// Token: 0x17000771 RID: 1905
			// (get) Token: 0x06001A7D RID: 6781 RVA: 0x0006D598 File Offset: 0x0006B798
			// (set) Token: 0x06001A7E RID: 6782 RVA: 0x0000D4CD File Offset: 0x0000B6CD
			public unsafe static int section2
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.Sections.NativeFieldInfoPtr_section2, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.Sections.NativeFieldInfoPtr_section2, (void*)(&value));
				}
			}

			// Token: 0x17000772 RID: 1906
			// (get) Token: 0x06001A7F RID: 6783 RVA: 0x0006D5B4 File Offset: 0x0006B7B4
			// (set) Token: 0x06001A80 RID: 6784 RVA: 0x0000D4DB File Offset: 0x0000B6DB
			public unsafe static int section3
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.Sections.NativeFieldInfoPtr_section3, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.Sections.NativeFieldInfoPtr_section3, (void*)(&value));
				}
			}

			// Token: 0x17000773 RID: 1907
			// (get) Token: 0x06001A81 RID: 6785 RVA: 0x0006D5D0 File Offset: 0x0006B7D0
			// (set) Token: 0x06001A82 RID: 6786 RVA: 0x0000D4E9 File Offset: 0x0000B6E9
			public unsafe static int section4
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.Sections.NativeFieldInfoPtr_section4, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.Sections.NativeFieldInfoPtr_section4, (void*)(&value));
				}
			}

			// Token: 0x17000774 RID: 1908
			// (get) Token: 0x06001A83 RID: 6787 RVA: 0x0006D5EC File Offset: 0x0006B7EC
			// (set) Token: 0x06001A84 RID: 6788 RVA: 0x0000D4F7 File Offset: 0x0000B6F7
			public unsafe static int section5
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.Sections.NativeFieldInfoPtr_section5, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.Sections.NativeFieldInfoPtr_section5, (void*)(&value));
				}
			}

			// Token: 0x17000775 RID: 1909
			// (get) Token: 0x06001A85 RID: 6789 RVA: 0x0006D608 File Offset: 0x0006B808
			// (set) Token: 0x06001A86 RID: 6790 RVA: 0x0000D505 File Offset: 0x0000B705
			public unsafe static int section6
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.Sections.NativeFieldInfoPtr_section6, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.Sections.NativeFieldInfoPtr_section6, (void*)(&value));
				}
			}

			// Token: 0x17000776 RID: 1910
			// (get) Token: 0x06001A87 RID: 6791 RVA: 0x0006D624 File Offset: 0x0006B824
			// (set) Token: 0x06001A88 RID: 6792 RVA: 0x0000D513 File Offset: 0x0000B713
			public unsafe static int section7
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.Sections.NativeFieldInfoPtr_section7, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.Sections.NativeFieldInfoPtr_section7, (void*)(&value));
				}
			}

			// Token: 0x17000777 RID: 1911
			// (get) Token: 0x06001A89 RID: 6793 RVA: 0x0006D640 File Offset: 0x0006B840
			// (set) Token: 0x06001A8A RID: 6794 RVA: 0x0000D521 File Offset: 0x0000B721
			public unsafe static int section8
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.Sections.NativeFieldInfoPtr_section8, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.Sections.NativeFieldInfoPtr_section8, (void*)(&value));
				}
			}

			// Token: 0x04001350 RID: 4944
			private static readonly IntPtr NativeFieldInfoPtr_section1;

			// Token: 0x04001351 RID: 4945
			private static readonly IntPtr NativeFieldInfoPtr_section2;

			// Token: 0x04001352 RID: 4946
			private static readonly IntPtr NativeFieldInfoPtr_section3;

			// Token: 0x04001353 RID: 4947
			private static readonly IntPtr NativeFieldInfoPtr_section4;

			// Token: 0x04001354 RID: 4948
			private static readonly IntPtr NativeFieldInfoPtr_section5;

			// Token: 0x04001355 RID: 4949
			private static readonly IntPtr NativeFieldInfoPtr_section6;

			// Token: 0x04001356 RID: 4950
			private static readonly IntPtr NativeFieldInfoPtr_section7;

			// Token: 0x04001357 RID: 4951
			private static readonly IntPtr NativeFieldInfoPtr_section8;
		}

		// Token: 0x020001F4 RID: 500
		public static class Priorities : Object
		{
			// Token: 0x06001A8B RID: 6795 RVA: 0x0006D65C File Offset: 0x0006B85C
			// Note: this type is marked as 'beforefieldinit'.
			static Priorities()
			{
				Il2CppClassPointerStore<CoreUtils.Priorities>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "Priorities");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreUtils.Priorities>.NativeClassPtr);
				CoreUtils.Priorities.NativeFieldInfoPtr_assetsCreateShaderMenuPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.Priorities>.NativeClassPtr, "assetsCreateShaderMenuPriority");
				CoreUtils.Priorities.NativeFieldInfoPtr_assetsCreateRenderingMenuPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.Priorities>.NativeClassPtr, "assetsCreateRenderingMenuPriority");
				CoreUtils.Priorities.NativeFieldInfoPtr_editMenuPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.Priorities>.NativeClassPtr, "editMenuPriority");
				CoreUtils.Priorities.NativeFieldInfoPtr_gameObjectMenuPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.Priorities>.NativeClassPtr, "gameObjectMenuPriority");
				CoreUtils.Priorities.NativeFieldInfoPtr_srpLensFlareMenuPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.Priorities>.NativeClassPtr, "srpLensFlareMenuPriority");
			}

			// Token: 0x06001A8C RID: 6796 RVA: 0x0000D52F File Offset: 0x0000B72F
			public Priorities(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000778 RID: 1912
			// (get) Token: 0x06001A8D RID: 6797 RVA: 0x0006D6EC File Offset: 0x0006B8EC
			// (set) Token: 0x06001A8E RID: 6798 RVA: 0x0000D538 File Offset: 0x0000B738
			public unsafe static int assetsCreateShaderMenuPriority
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.Priorities.NativeFieldInfoPtr_assetsCreateShaderMenuPriority, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.Priorities.NativeFieldInfoPtr_assetsCreateShaderMenuPriority, (void*)(&value));
				}
			}

			// Token: 0x17000779 RID: 1913
			// (get) Token: 0x06001A8F RID: 6799 RVA: 0x0006D708 File Offset: 0x0006B908
			// (set) Token: 0x06001A90 RID: 6800 RVA: 0x0000D546 File Offset: 0x0000B746
			public unsafe static int assetsCreateRenderingMenuPriority
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.Priorities.NativeFieldInfoPtr_assetsCreateRenderingMenuPriority, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.Priorities.NativeFieldInfoPtr_assetsCreateRenderingMenuPriority, (void*)(&value));
				}
			}

			// Token: 0x1700077A RID: 1914
			// (get) Token: 0x06001A91 RID: 6801 RVA: 0x0006D724 File Offset: 0x0006B924
			// (set) Token: 0x06001A92 RID: 6802 RVA: 0x0000D554 File Offset: 0x0000B754
			public unsafe static int editMenuPriority
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.Priorities.NativeFieldInfoPtr_editMenuPriority, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.Priorities.NativeFieldInfoPtr_editMenuPriority, (void*)(&value));
				}
			}

			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x06001A93 RID: 6803 RVA: 0x0006D740 File Offset: 0x0006B940
			// (set) Token: 0x06001A94 RID: 6804 RVA: 0x0000D562 File Offset: 0x0000B762
			public unsafe static int gameObjectMenuPriority
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.Priorities.NativeFieldInfoPtr_gameObjectMenuPriority, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.Priorities.NativeFieldInfoPtr_gameObjectMenuPriority, (void*)(&value));
				}
			}

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x06001A95 RID: 6805 RVA: 0x0006D75C File Offset: 0x0006B95C
			// (set) Token: 0x06001A96 RID: 6806 RVA: 0x0000D570 File Offset: 0x0000B770
			public unsafe static int srpLensFlareMenuPriority
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.Priorities.NativeFieldInfoPtr_srpLensFlareMenuPriority, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.Priorities.NativeFieldInfoPtr_srpLensFlareMenuPriority, (void*)(&value));
				}
			}

			// Token: 0x04001358 RID: 4952
			private static readonly IntPtr NativeFieldInfoPtr_assetsCreateShaderMenuPriority;

			// Token: 0x04001359 RID: 4953
			private static readonly IntPtr NativeFieldInfoPtr_assetsCreateRenderingMenuPriority;

			// Token: 0x0400135A RID: 4954
			private static readonly IntPtr NativeFieldInfoPtr_editMenuPriority;

			// Token: 0x0400135B RID: 4955
			private static readonly IntPtr NativeFieldInfoPtr_gameObjectMenuPriority;

			// Token: 0x0400135C RID: 4956
			private static readonly IntPtr NativeFieldInfoPtr_srpLensFlareMenuPriority;
		}

		// Token: 0x020001F5 RID: 501
		[ObfuscatedName("UnityEngine.Rendering.CoreUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001A97 RID: 6807 RVA: 0x0006D778 File Offset: 0x0006B978
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CoreUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreUtils.__c>.NativeClassPtr);
				CoreUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.__c>.NativeClassPtr, "<>9");
				CoreUtils.__c.NativeFieldInfoPtr___9__87_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.__c>.NativeClassPtr, "<>9__87_0");
				CoreUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils.__c>.NativeClassPtr, 100665636);
				CoreUtils.__c.NativeMethodInfoPtr__GetAllAssemblyTypes_b__87_0_Internal_IEnumerable_1_Type_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils.__c>.NativeClassPtr, 100665637);
			}

			// Token: 0x06001A98 RID: 6808 RVA: 0x0006D7F4 File Offset: 0x0006B9F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoreUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A99 RID: 6809 RVA: 0x0006D830 File Offset: 0x0006BA30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976131, XrefRangeEnd = 976135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Type> _GetAllAssemblyTypes_b__87_0(Assembly t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.__c.NativeMethodInfoPtr__GetAllAssemblyTypes_b__87_0_Internal_IEnumerable_1_Type_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
				}
			}

			// Token: 0x06001A9A RID: 6810 RVA: 0x0000D57E File Offset: 0x0000B77E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x06001A9B RID: 6811 RVA: 0x0006D880 File Offset: 0x0006BA80
			// (set) Token: 0x06001A9C RID: 6812 RVA: 0x0000D587 File Offset: 0x0000B787
			public unsafe static CoreUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CoreUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x06001A9D RID: 6813 RVA: 0x0006D8A8 File Offset: 0x0006BAA8
			// (set) Token: 0x06001A9E RID: 6814 RVA: 0x0000D599 File Offset: 0x0000B799
			public unsafe static Func<Assembly, IEnumerable<Type>> __9__87_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.__c.NativeFieldInfoPtr___9__87_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Assembly, IEnumerable<Type>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.__c.NativeFieldInfoPtr___9__87_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400135D RID: 4957
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400135E RID: 4958
			private static readonly IntPtr NativeFieldInfoPtr___9__87_0;

			// Token: 0x0400135F RID: 4959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001360 RID: 4960
			private static readonly IntPtr NativeMethodInfoPtr__GetAllAssemblyTypes_b__87_0_Internal_IEnumerable_1_Type_Assembly_0;
		}

		// Token: 0x020001F6 RID: 502
		[ObfuscatedName("UnityEngine.Rendering.CoreUtils+<>c__88`1")]
		[Serializable]
		public sealed class __c__88<T> : Object
		{
			// Token: 0x06001A9F RID: 6815 RVA: 0x0006D8D0 File Offset: 0x0006BAD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__88()
			{
				Il2CppClassPointerStore<CoreUtils.__c__88<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, "<>c__88`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreUtils.__c__88<T>>.NativeClassPtr);
				CoreUtils.__c__88<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.__c__88<T>>.NativeClassPtr, "<>9");
				CoreUtils.__c__88<T>.NativeFieldInfoPtr___9__88_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUtils.__c__88<T>>.NativeClassPtr, "<>9__88_0");
				CoreUtils.__c__88<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils.__c__88<T>>.NativeClassPtr, 100665639);
				CoreUtils.__c__88<T>.NativeMethodInfoPtr__GetAllTypesDerivedFrom_b__88_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils.__c__88<T>>.NativeClassPtr, 100665640);
			}

			// Token: 0x06001AA0 RID: 6816 RVA: 0x0006D988 File Offset: 0x0006BB88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__88()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoreUtils.__c__88<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.__c__88<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AA1 RID: 6817 RVA: 0x0006D9C4 File Offset: 0x0006BBC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976135, XrefRangeEnd = 976145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllTypesDerivedFrom_b__88_0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.__c__88<T>.NativeMethodInfoPtr__GetAllTypesDerivedFrom_b__88_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AA2 RID: 6818 RVA: 0x0000D5AB File Offset: 0x0000B7AB
			public __c__88(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x0006DA14 File Offset: 0x0006BC14
			// (set) Token: 0x06001AA4 RID: 6820 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
			public unsafe static CoreUtils.__c__88<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.__c__88<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CoreUtils.__c__88<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.__c__88<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x0006DA3C File Offset: 0x0006BC3C
			// (set) Token: 0x06001AA6 RID: 6822 RVA: 0x0000D5C6 File Offset: 0x0000B7C6
			public unsafe static Func<Type, bool> __9__88_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CoreUtils.__c__88<T>.NativeFieldInfoPtr___9__88_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CoreUtils.__c__88<T>.NativeFieldInfoPtr___9__88_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001361 RID: 4961
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001362 RID: 4962
			private static readonly IntPtr NativeFieldInfoPtr___9__88_0;

			// Token: 0x04001363 RID: 4963
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001364 RID: 4964
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTypesDerivedFrom_b__88_0_Internal_Boolean_Type_0;
		}

		// Token: 0x020001F7 RID: 503
		private sealed class MethodInfoStoreGeneric_HasFlag_Public_Static_Boolean_T_T_0<T>
		{
			// Token: 0x04001365 RID: 4965
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUtils.NativeMethodInfoPtr_HasFlag_Public_Static_Boolean_T_T_0, Il2CppClassPointerStore<CoreUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001F8 RID: 504
		private sealed class MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>
		{
			// Token: 0x04001366 RID: 4966
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUtils.NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0, Il2CppClassPointerStore<CoreUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001F9 RID: 505
		private sealed class MethodInfoStoreGeneric_GetAllTypesDerivedFrom_Public_Static_IEnumerable_1_Type_0<T>
		{
			// Token: 0x04001367 RID: 4967
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUtils.NativeMethodInfoPtr_GetAllTypesDerivedFrom_Public_Static_IEnumerable_1_Type_0, Il2CppClassPointerStore<CoreUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001FA RID: 506
		private sealed class MethodInfoStoreGeneric_GetLastEnumValue_Public_Static_T_0<T>
		{
			// Token: 0x04001368 RID: 4968
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CoreUtils.NativeMethodInfoPtr_GetLastEnumValue_Public_Static_T_0, Il2CppClassPointerStore<CoreUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
