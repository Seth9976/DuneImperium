using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200003C RID: 60
	public static class ShadowRendering : Object
	{
		// Token: 0x06000574 RID: 1396 RVA: 0x00028804 File Offset: 0x00026A04
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowRendering()
		{
			Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShadowRendering");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr);
			ShadowRendering.NativeFieldInfoPtr_k_LightPosID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "k_LightPosID");
			ShadowRendering.NativeFieldInfoPtr_k_SelfShadowingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "k_SelfShadowingID");
			ShadowRendering.NativeFieldInfoPtr_k_ShadowStencilGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "k_ShadowStencilGroupID");
			ShadowRendering.NativeFieldInfoPtr_k_ShadowIntensityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "k_ShadowIntensityID");
			ShadowRendering.NativeFieldInfoPtr_k_ShadowVolumeIntensityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "k_ShadowVolumeIntensityID");
			ShadowRendering.NativeFieldInfoPtr_k_ShadowRadiusID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "k_ShadowRadiusID");
			ShadowRendering.NativeFieldInfoPtr_k_ShadowColorMaskID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "k_ShadowColorMaskID");
			ShadowRendering.NativeFieldInfoPtr_k_ShadowModelMatrixID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "k_ShadowModelMatrixID");
			ShadowRendering.NativeFieldInfoPtr_k_ShadowModelInvMatrixID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "k_ShadowModelInvMatrixID");
			ShadowRendering.NativeFieldInfoPtr_k_ShadowModelScaleID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "k_ShadowModelScaleID");
			ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "m_ProfilingSamplerShadows");
			ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowsA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "m_ProfilingSamplerShadowsA");
			ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowsR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "m_ProfilingSamplerShadowsR");
			ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowsG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "m_ProfilingSamplerShadowsG");
			ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowsB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "m_ProfilingSamplerShadowsB");
			ShadowRendering.NativeFieldInfoPtr_m_RenderTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "m_RenderTargets");
			ShadowRendering.NativeFieldInfoPtr_m_RenderTargetIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "m_RenderTargetIds");
			ShadowRendering.NativeFieldInfoPtr_m_LightInputTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "m_LightInputTextures");
			ShadowRendering.NativeFieldInfoPtr_k_ColorLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "k_ColorLookup");
			ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowColorsLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "m_ProfilingSamplerShadowColorsLookup");
			ShadowRendering.NativeFieldInfoPtr__maxTextureCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, "<maxTextureCount>k__BackingField");
			ShadowRendering.NativeMethodInfoPtr_get_maxTextureCount_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663928);
			ShadowRendering.NativeMethodInfoPtr_set_maxTextureCount_Private_Static_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663929);
			ShadowRendering.NativeMethodInfoPtr_InitializeBudget_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663930);
			ShadowRendering.NativeMethodInfoPtr_CreateMaterials_Private_Static_Il2CppReferenceArray_1_Material_Shader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663931);
			ShadowRendering.NativeMethodInfoPtr_GetProjectedShadowMaterial_Private_Static_Material_Renderer2DData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663932);
			ShadowRendering.NativeMethodInfoPtr_GetStencilOnlyShadowMaterial_Private_Static_Material_Renderer2DData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663933);
			ShadowRendering.NativeMethodInfoPtr_GetSpriteSelfShadowMaterial_Private_Static_Material_Renderer2DData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663934);
			ShadowRendering.NativeMethodInfoPtr_GetSpriteUnshadowMaterial_Private_Static_Material_Renderer2DData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663935);
			ShadowRendering.NativeMethodInfoPtr_GetGeometryUnshadowMaterial_Private_Static_Material_Renderer2DData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663936);
			ShadowRendering.NativeMethodInfoPtr_CreateShadowRenderTexture_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663937);
			ShadowRendering.NativeMethodInfoPtr_PrerenderShadows_Public_Static_Boolean_IRenderPass2D_RenderingData_CommandBuffer_Int32_Light2D_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663938);
			ShadowRendering.NativeMethodInfoPtr_SetGlobalShadowTexture_Public_Static_Void_CommandBuffer_Light2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663939);
			ShadowRendering.NativeMethodInfoPtr_DisableGlobalShadowTexture_Public_Static_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663940);
			ShadowRendering.NativeMethodInfoPtr_CreateShadowRenderTexture_Private_Static_Void_IRenderPass2D_Int32_RenderingData_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663941);
			ShadowRendering.NativeMethodInfoPtr_ReleaseShadowRenderTexture_Public_Static_Void_CommandBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663942);
			ShadowRendering.NativeMethodInfoPtr_SetShadowProjectionGlobals_Public_Static_Void_CommandBuffer_ShadowCaster2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663943);
			ShadowRendering.NativeMethodInfoPtr_RenderShadows_Public_Static_Boolean_IRenderPass2D_RenderingData_CommandBuffer_Int32_Light2D_Single_RenderTargetIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowRendering>.NativeClassPtr, 100663944);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00028B2C File Offset: 0x00026D2C
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00028B5C File Offset: 0x00026D5C
		public unsafe static uint maxTextureCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602514, XrefRangeEnd = 602518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_get_maxTextureCount_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602518, XrefRangeEnd = 602522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_set_maxTextureCount_Private_Static_set_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00028B90 File Offset: 0x00026D90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 602581, RefRangeEnd = 602582, XrefRangeStart = 602522, XrefRangeEnd = 602581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeBudget(uint maxTextureCount)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxTextureCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_InitializeBudget_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00028BC4 File Offset: 0x00026DC4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 602597, RefRangeEnd = 602607, XrefRangeStart = 602582, XrefRangeEnd = 602597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Material> CreateMaterials(Shader shader, int pass = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_CreateMaterials_Private_Static_Il2CppReferenceArray_1_Material_Shader_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00028C18 File Offset: 0x00026E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602607, XrefRangeEnd = 602617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetProjectedShadowMaterial(this Renderer2DData rendererData, int colorIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_GetProjectedShadowMaterial_Private_Static_Material_Renderer2DData_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00028C6C File Offset: 0x00026E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602617, XrefRangeEnd = 602627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetStencilOnlyShadowMaterial(this Renderer2DData rendererData, int colorIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_GetStencilOnlyShadowMaterial_Private_Static_Material_Renderer2DData_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00028CC0 File Offset: 0x00026EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602627, XrefRangeEnd = 602637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetSpriteSelfShadowMaterial(this Renderer2DData rendererData, int colorIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_GetSpriteSelfShadowMaterial_Private_Static_Material_Renderer2DData_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00028D14 File Offset: 0x00026F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602637, XrefRangeEnd = 602647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetSpriteUnshadowMaterial(this Renderer2DData rendererData, int colorIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_GetSpriteUnshadowMaterial_Private_Static_Material_Renderer2DData_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00028D68 File Offset: 0x00026F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602647, XrefRangeEnd = 602657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetGeometryUnshadowMaterial(this Renderer2DData rendererData, int colorIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_GetGeometryUnshadowMaterial_Private_Static_Material_Renderer2DData_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00028DBC File Offset: 0x00026FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602657, XrefRangeEnd = 602670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateShadowRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int shadowIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmdBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_CreateShadowRenderTexture_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00028E2C File Offset: 0x0002702C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 602691, RefRangeEnd = 602693, XrefRangeStart = 602670, XrefRangeEnd = 602691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PrerenderShadows(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int layerToRender, Light2D light, int shadowIndex, float shadowIntensity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmdBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerToRender;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(light);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowIntensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_PrerenderShadows_Public_Static_Boolean_IRenderPass2D_RenderingData_CommandBuffer_Int32_Light2D_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00028ED4 File Offset: 0x000270D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 602708, RefRangeEnd = 602710, XrefRangeStart = 602693, XrefRangeEnd = 602708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalShadowTexture(CommandBuffer cmdBuffer, Light2D light, int shadowIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmdBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(light);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_SetGlobalShadowTexture_Public_Static_Void_CommandBuffer_Light2D_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00028F2C File Offset: 0x0002712C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 602718, RefRangeEnd = 602720, XrefRangeStart = 602710, XrefRangeEnd = 602718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableGlobalShadowTexture(CommandBuffer cmdBuffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmdBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_DisableGlobalShadowTexture_Public_Static_Void_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00028F64 File Offset: 0x00027164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602720, XrefRangeEnd = 602729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateShadowRenderTexture(IRenderPass2D pass, int handleId, RenderingData renderingData, CommandBuffer cmdBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmdBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_CreateShadowRenderTexture_Private_Static_Void_IRenderPass2D_Int32_RenderingData_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00028FD4 File Offset: 0x000271D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 602734, RefRangeEnd = 602736, XrefRangeStart = 602729, XrefRangeEnd = 602734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseShadowRenderTexture(CommandBuffer cmdBuffer, int shadowIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmdBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_ReleaseShadowRenderTexture_Public_Static_Void_CommandBuffer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00029018 File Offset: 0x00027218
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 602745, RefRangeEnd = 602747, XrefRangeStart = 602736, XrefRangeEnd = 602745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetShadowProjectionGlobals(CommandBuffer cmdBuffer, ShadowCaster2D shadowCaster)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmdBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shadowCaster);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_SetShadowProjectionGlobals_Public_Static_Void_CommandBuffer_ShadowCaster2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00029060 File Offset: 0x00027260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 602914, RefRangeEnd = 602915, XrefRangeStart = 602747, XrefRangeEnd = 602914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RenderShadows(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int layerToRender, Light2D light, float shadowIntensity, RenderTargetIdentifier renderTexture, int colorBit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmdBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerToRender;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(light);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowIntensity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderTexture;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowRendering.NativeMethodInfoPtr_RenderShadows_Public_Static_Boolean_IRenderPass2D_RenderingData_CommandBuffer_Int32_Light2D_Single_RenderTargetIdentifier_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000046F9 File Offset: 0x000028F9
		public ShadowRendering(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00029118 File Offset: 0x00027318
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00004702 File Offset: 0x00002902
		public unsafe static int k_LightPosID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_k_LightPosID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_k_LightPosID, (void*)(&value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00029134 File Offset: 0x00027334
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00004710 File Offset: 0x00002910
		public unsafe static int k_SelfShadowingID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_k_SelfShadowingID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_k_SelfShadowingID, (void*)(&value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00029150 File Offset: 0x00027350
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0000471E File Offset: 0x0000291E
		public unsafe static int k_ShadowStencilGroupID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowStencilGroupID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowStencilGroupID, (void*)(&value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0002916C File Offset: 0x0002736C
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x0000472C File Offset: 0x0000292C
		public unsafe static int k_ShadowIntensityID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowIntensityID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowIntensityID, (void*)(&value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00029188 File Offset: 0x00027388
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0000473A File Offset: 0x0000293A
		public unsafe static int k_ShadowVolumeIntensityID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowVolumeIntensityID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowVolumeIntensityID, (void*)(&value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x000291A4 File Offset: 0x000273A4
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00004748 File Offset: 0x00002948
		public unsafe static int k_ShadowRadiusID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowRadiusID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowRadiusID, (void*)(&value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x000291C0 File Offset: 0x000273C0
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00004756 File Offset: 0x00002956
		public unsafe static int k_ShadowColorMaskID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowColorMaskID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowColorMaskID, (void*)(&value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x000291DC File Offset: 0x000273DC
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00004764 File Offset: 0x00002964
		public unsafe static int k_ShadowModelMatrixID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowModelMatrixID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowModelMatrixID, (void*)(&value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x000291F8 File Offset: 0x000273F8
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00004772 File Offset: 0x00002972
		public unsafe static int k_ShadowModelInvMatrixID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowModelInvMatrixID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowModelInvMatrixID, (void*)(&value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00029214 File Offset: 0x00027414
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00004780 File Offset: 0x00002980
		public unsafe static int k_ShadowModelScaleID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowModelScaleID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_k_ShadowModelScaleID, (void*)(&value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00029230 File Offset: 0x00027430
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x0000478E File Offset: 0x0000298E
		public unsafe static ProfilingSampler m_ProfilingSamplerShadows
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadows, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadows, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00029258 File Offset: 0x00027458
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x000047A0 File Offset: 0x000029A0
		public unsafe static ProfilingSampler m_ProfilingSamplerShadowsA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowsA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowsA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00029280 File Offset: 0x00027480
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x000047B2 File Offset: 0x000029B2
		public unsafe static ProfilingSampler m_ProfilingSamplerShadowsR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowsR, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowsR, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x000292A8 File Offset: 0x000274A8
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x000047C4 File Offset: 0x000029C4
		public unsafe static ProfilingSampler m_ProfilingSamplerShadowsG
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowsG, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowsG, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x000292D0 File Offset: 0x000274D0
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x000047D6 File Offset: 0x000029D6
		public unsafe static ProfilingSampler m_ProfilingSamplerShadowsB
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowsB, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowsB, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x000292F8 File Offset: 0x000274F8
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x000047E8 File Offset: 0x000029E8
		public unsafe static Il2CppReferenceArray<RTHandle> m_RenderTargets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_m_RenderTargets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_m_RenderTargets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00029320 File Offset: 0x00027520
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x000047FA File Offset: 0x000029FA
		public unsafe static Il2CppStructArray<int> m_RenderTargetIds
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_m_RenderTargetIds, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_m_RenderTargetIds, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00029348 File Offset: 0x00027548
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0000480C File Offset: 0x00002A0C
		public unsafe static Il2CppStructArray<RenderTargetIdentifier> m_LightInputTextures
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_m_LightInputTextures, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_m_LightInputTextures, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00029370 File Offset: 0x00027570
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0000481E File Offset: 0x00002A1E
		public unsafe static Il2CppStructArray<Color> k_ColorLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_k_ColorLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_k_ColorLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x00029398 File Offset: 0x00027598
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00004830 File Offset: 0x00002A30
		public unsafe static Il2CppReferenceArray<ProfilingSampler> m_ProfilingSamplerShadowColorsLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowColorsLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfilingSampler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr_m_ProfilingSamplerShadowColorsLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x000293C0 File Offset: 0x000275C0
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x00004842 File Offset: 0x00002A42
		public unsafe static uint _maxTextureCount_k__BackingField
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ShadowRendering.NativeFieldInfoPtr__maxTextureCount_k__BackingField, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowRendering.NativeFieldInfoPtr__maxTextureCount_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_k_LightPosID;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr_k_SelfShadowingID;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_k_ShadowStencilGroupID;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr_k_ShadowIntensityID;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_k_ShadowVolumeIntensityID;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_k_ShadowRadiusID;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_k_ShadowColorMaskID;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_k_ShadowModelMatrixID;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_k_ShadowModelInvMatrixID;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_k_ShadowModelScaleID;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSamplerShadows;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSamplerShadowsA;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSamplerShadowsR;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSamplerShadowsG;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSamplerShadowsB;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderTargets;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderTargetIds;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_m_LightInputTextures;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr_k_ColorLookup;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSamplerShadowColorsLookup;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr__maxTextureCount_k__BackingField;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_get_maxTextureCount_Public_Static_get_UInt32_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_set_maxTextureCount_Private_Static_set_Void_UInt32_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_InitializeBudget_Public_Static_Void_UInt32_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_CreateMaterials_Private_Static_Il2CppReferenceArray_1_Material_Shader_Int32_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_GetProjectedShadowMaterial_Private_Static_Material_Renderer2DData_Int32_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_GetStencilOnlyShadowMaterial_Private_Static_Material_Renderer2DData_Int32_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteSelfShadowMaterial_Private_Static_Material_Renderer2DData_Int32_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteUnshadowMaterial_Private_Static_Material_Renderer2DData_Int32_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_GetGeometryUnshadowMaterial_Private_Static_Material_Renderer2DData_Int32_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_CreateShadowRenderTexture_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Int32_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_PrerenderShadows_Public_Static_Boolean_IRenderPass2D_RenderingData_CommandBuffer_Int32_Light2D_Int32_Single_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalShadowTexture_Public_Static_Void_CommandBuffer_Light2D_Int32_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_DisableGlobalShadowTexture_Public_Static_Void_CommandBuffer_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_CreateShadowRenderTexture_Private_Static_Void_IRenderPass2D_Int32_RenderingData_CommandBuffer_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseShadowRenderTexture_Public_Static_Void_CommandBuffer_Int32_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_SetShadowProjectionGlobals_Public_Static_Void_CommandBuffer_ShadowCaster2D_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_RenderShadows_Public_Static_Boolean_IRenderPass2D_RenderingData_CommandBuffer_Int32_Light2D_Single_RenderTargetIdentifier_Int32_0;
	}
}
