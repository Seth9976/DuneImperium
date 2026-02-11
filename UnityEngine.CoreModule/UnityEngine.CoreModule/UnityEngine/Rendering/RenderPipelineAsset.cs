using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x0200023F RID: 575
	public class RenderPipelineAsset : ScriptableObject
	{
		// Token: 0x06002665 RID: 9829 RVA: 0x000A2DAC File Offset: 0x000A0FAC
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipelineAsset()
		{
			Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipelineAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr);
			RenderPipelineAsset.NativeMethodInfoPtr_InternalCreatePipeline_Internal_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668219);
			RenderPipelineAsset.NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668220);
			RenderPipelineAsset.NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668221);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668222);
			RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668223);
			RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveTransparentShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668224);
			RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveMaskedShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668225);
			RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668226);
			RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668227);
			RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668228);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668229);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668230);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668231);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668232);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIOverdrawMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668233);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIETC1SupportedMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668234);
			RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668235);
			RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaskMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668236);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668237);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree7Shader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668238);
			RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree8Shader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668239);
			RenderPipelineAsset.NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668240);
			RenderPipelineAsset.NativeMethodInfoPtr_CreatePipeline_Protected_Abstract_Virtual_New_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668241);
			RenderPipelineAsset.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668242);
			RenderPipelineAsset.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668243);
			RenderPipelineAsset.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100668244);
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x000A2FE4 File Offset: 0x000A11E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683980, RefRangeEnd = 683981, XrefRangeStart = 683964, XrefRangeEnd = 683980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPipeline InternalCreatePipeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineAsset.NativeMethodInfoPtr_InternalCreatePipeline_Internal_RenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr3) : null;
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002667 RID: 9831 RVA: 0x000A3024 File Offset: 0x000A1224
		public unsafe virtual Il2CppStringArray renderingLayerMaskNames
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x000A3070 File Offset: 0x000A1270
		public unsafe virtual Il2CppStringArray prefixedRenderingLayerMaskNames
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002669 RID: 9833 RVA: 0x000A30BC File Offset: 0x000A12BC
		public unsafe virtual Material defaultMaterial
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x000A3108 File Offset: 0x000A1308
		public unsafe virtual Shader autodeskInteractiveShader
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x0600266B RID: 9835 RVA: 0x000A3154 File Offset: 0x000A1354
		public unsafe virtual Shader autodeskInteractiveTransparentShader
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveTransparentShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x000A31A0 File Offset: 0x000A13A0
		public unsafe virtual Shader autodeskInteractiveMaskedShader
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveMaskedShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600266D RID: 9837 RVA: 0x000A31EC File Offset: 0x000A13EC
		public unsafe virtual Shader terrainDetailLitShader
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x000A3238 File Offset: 0x000A1438
		public unsafe virtual Shader terrainDetailGrassShader
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x0600266F RID: 9839 RVA: 0x000A3284 File Offset: 0x000A1484
		public unsafe virtual Shader terrainDetailGrassBillboardShader
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002670 RID: 9840 RVA: 0x000A32D0 File Offset: 0x000A14D0
		public unsafe virtual Material defaultParticleMaterial
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002671 RID: 9841 RVA: 0x000A331C File Offset: 0x000A151C
		public unsafe virtual Material defaultLineMaterial
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002672 RID: 9842 RVA: 0x000A3368 File Offset: 0x000A1568
		public unsafe virtual Material defaultTerrainMaterial
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002673 RID: 9843 RVA: 0x000A33B4 File Offset: 0x000A15B4
		public unsafe virtual Material defaultUIMaterial
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x000A3400 File Offset: 0x000A1600
		public unsafe virtual Material defaultUIOverdrawMaterial
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIOverdrawMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x000A344C File Offset: 0x000A164C
		public unsafe virtual Material defaultUIETC1SupportedMaterial
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIETC1SupportedMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x000A3498 File Offset: 0x000A1698
		public unsafe virtual Material default2DMaterial
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x000A34E4 File Offset: 0x000A16E4
		public unsafe virtual Material default2DMaskMaterial
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaskMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x000A3530 File Offset: 0x000A1730
		public unsafe virtual Shader defaultShader
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x000A357C File Offset: 0x000A177C
		public unsafe virtual Shader defaultSpeedTree7Shader
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree7Shader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x000A35C8 File Offset: 0x000A17C8
		public unsafe virtual Shader defaultSpeedTree8Shader
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree8Shader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x0600267B RID: 9851 RVA: 0x000A3614 File Offset: 0x000A1814
		public unsafe virtual string renderPipelineShaderTag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683981, XrefRangeEnd = 683989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x000A3658 File Offset: 0x000A1858
		[CallerCount(0)]
		public unsafe virtual RenderPipeline CreatePipeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_CreatePipeline_Protected_Abstract_Virtual_New_RenderPipeline_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr3) : null;
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x000A36A4 File Offset: 0x000A18A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683989, XrefRangeEnd = 684001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x000A36E0 File Offset: 0x000A18E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684005, RefRangeEnd = 684006, XrefRangeStart = 684001, XrefRangeEnd = 684005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipelineAsset.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x000A371C File Offset: 0x000A191C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPipelineAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineAsset.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x0000F0A9 File Offset: 0x0000D2A9
		public RenderPipelineAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400225F RID: 8799
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreatePipeline_Internal_RenderPipeline_0;

		// Token: 0x04002260 RID: 8800
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0;

		// Token: 0x04002261 RID: 8801
		private static readonly IntPtr NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0;

		// Token: 0x04002262 RID: 8802
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04002263 RID: 8803
		private static readonly IntPtr NativeMethodInfoPtr_get_autodeskInteractiveShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002264 RID: 8804
		private static readonly IntPtr NativeMethodInfoPtr_get_autodeskInteractiveTransparentShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002265 RID: 8805
		private static readonly IntPtr NativeMethodInfoPtr_get_autodeskInteractiveMaskedShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002266 RID: 8806
		private static readonly IntPtr NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002267 RID: 8807
		private static readonly IntPtr NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002268 RID: 8808
		private static readonly IntPtr NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002269 RID: 8809
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400226A RID: 8810
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400226B RID: 8811
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400226C RID: 8812
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultUIMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400226D RID: 8813
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultUIOverdrawMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400226E RID: 8814
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultUIETC1SupportedMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x0400226F RID: 8815
		private static readonly IntPtr NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04002270 RID: 8816
		private static readonly IntPtr NativeMethodInfoPtr_get_default2DMaskMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04002271 RID: 8817
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultShader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002272 RID: 8818
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpeedTree7Shader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002273 RID: 8819
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpeedTree8Shader_Public_Virtual_New_get_Shader_0;

		// Token: 0x04002274 RID: 8820
		private static readonly IntPtr NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_New_get_String_0;

		// Token: 0x04002275 RID: 8821
		private static readonly IntPtr NativeMethodInfoPtr_CreatePipeline_Protected_Abstract_Virtual_New_RenderPipeline_0;

		// Token: 0x04002276 RID: 8822
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0;

		// Token: 0x04002277 RID: 8823
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x04002278 RID: 8824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
