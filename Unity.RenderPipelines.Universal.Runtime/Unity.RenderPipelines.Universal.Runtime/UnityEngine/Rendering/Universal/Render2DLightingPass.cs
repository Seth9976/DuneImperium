using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200002E RID: 46
	public class Render2DLightingPass : ScriptableRenderPass
	{
		// Token: 0x06000356 RID: 854 RVA: 0x00021A00 File Offset: 0x0001FC00
		// Note: this type is marked as 'beforefieldinit'.
		static Render2DLightingPass()
		{
			Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Render2DLightingPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr);
			Render2DLightingPass.NativeFieldInfoPtr_k_HDREmulationScaleID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "k_HDREmulationScaleID");
			Render2DLightingPass.NativeFieldInfoPtr_k_InverseHDREmulationScaleID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "k_InverseHDREmulationScaleID");
			Render2DLightingPass.NativeFieldInfoPtr_k_UseSceneLightingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "k_UseSceneLightingID");
			Render2DLightingPass.NativeFieldInfoPtr_k_RendererColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "k_RendererColorID");
			Render2DLightingPass.NativeFieldInfoPtr_k_ShapeLightTextureIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "k_ShapeLightTextureIDs");
			Render2DLightingPass.NativeFieldInfoPtr_k_CombinedRenderingPassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "k_CombinedRenderingPassName");
			Render2DLightingPass.NativeFieldInfoPtr_k_NormalsRenderingPassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "k_NormalsRenderingPassName");
			Render2DLightingPass.NativeFieldInfoPtr_k_LegacyPassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "k_LegacyPassName");
			Render2DLightingPass.NativeFieldInfoPtr_k_ShaderTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "k_ShaderTags");
			Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingDrawLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "m_ProfilingDrawLights");
			Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingDrawLightTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "m_ProfilingDrawLightTextures");
			Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingDrawRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "m_ProfilingDrawRenderers");
			Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingDrawLayerBatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "m_ProfilingDrawLayerBatch");
			Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingSamplerUnlit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "m_ProfilingSamplerUnlit");
			Render2DLightingPass.NativeFieldInfoPtr_m_BlitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "m_BlitMaterial");
			Render2DLightingPass.NativeFieldInfoPtr_m_SamplingMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "m_SamplingMaterial");
			Render2DLightingPass.NativeFieldInfoPtr_m_Renderer2DData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "m_Renderer2DData");
			Render2DLightingPass.NativeFieldInfoPtr_m_NeedsDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "m_NeedsDepth");
			Render2DLightingPass.NativeFieldInfoPtr_m_CameraSortingLayerBoundsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "m_CameraSortingLayerBoundsIndex");
			Render2DLightingPass.NativeMethodInfoPtr__ctor_Public_Void_Renderer2DData_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, 100663731);
			Render2DLightingPass.NativeMethodInfoPtr_Setup_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, 100663732);
			Render2DLightingPass.NativeMethodInfoPtr_GetTransparencySortingMode_Private_Void_Camera_byref_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, 100663733);
			Render2DLightingPass.NativeMethodInfoPtr_CopyCameraSortingLayerRenderTexture_Private_Void_ScriptableRenderContext_RenderingData_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, 100663734);
			Render2DLightingPass.NativeMethodInfoPtr_GetCameraSortingLayerBoundsIndex_Internal_Static_Int16_Renderer2DData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, 100663735);
			Render2DLightingPass.NativeMethodInfoPtr_DetermineWhenToResolve_Private_Void_Int32_Int32_Int32_Il2CppStructArray_1_LayerBatch_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, 100663736);
			Render2DLightingPass.NativeMethodInfoPtr_Render_Private_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_byref_FilteringSettings_DrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, 100663737);
			Render2DLightingPass.NativeMethodInfoPtr_DrawLayerBatches_Private_Int32_Il2CppStructArray_1_LayerBatch_Int32_Int32_CommandBuffer_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_DrawingSettings_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, 100663738);
			Render2DLightingPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, 100663739);
			Render2DLightingPass.NativeMethodInfoPtr_UnityEngine_Rendering_Universal_IRenderPass2D_get_rendererData_Private_Virtual_Final_New_get_Renderer2DData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, 100663740);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00021C74 File Offset: 0x0001FE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600426, XrefRangeEnd = 600444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Render2DLightingPass(Renderer2DData rendererData, Material blitMaterial, Material samplingMaterial)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(blitMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(samplingMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Render2DLightingPass.NativeMethodInfoPtr__ctor_Public_Void_Renderer2DData_Material_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00021CE4 File Offset: 0x0001FEE4
		[CallerCount(0)]
		public unsafe void Setup(bool useDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useDepth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Render2DLightingPass.NativeMethodInfoPtr_Setup_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00021D24 File Offset: 0x0001FF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600444, XrefRangeEnd = 600449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTransparencySortingMode(Camera camera, ref SortingSettings sortingSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sortingSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Render2DLightingPass.NativeMethodInfoPtr_GetTransparencySortingMode_Private_Void_Camera_byref_SortingSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00021D74 File Offset: 0x0001FF74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 600481, RefRangeEnd = 600483, XrefRangeStart = 600449, XrefRangeEnd = 600481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyCameraSortingLayerRenderTexture(ScriptableRenderContext context, RenderingData renderingData, RenderBufferStoreAction mainTargetStoreAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainTargetStoreAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Render2DLightingPass.NativeMethodInfoPtr_CopyCameraSortingLayerRenderTexture_Private_Void_ScriptableRenderContext_RenderingData_RenderBufferStoreAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00021DD8 File Offset: 0x0001FFD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 600490, RefRangeEnd = 600491, XrefRangeStart = 600483, XrefRangeEnd = 600490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short GetCameraSortingLayerBoundsIndex(Renderer2DData rendererData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Render2DLightingPass.NativeMethodInfoPtr_GetCameraSortingLayerBoundsIndex_Internal_Static_Int16_Renderer2DData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00021E1C File Offset: 0x0002001C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 600503, RefRangeEnd = 600504, XrefRangeStart = 600491, XrefRangeEnd = 600503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetermineWhenToResolve(int startIndex, int batchesDrawn, int batchCount, Il2CppStructArray<LayerBatch> layerBatches, out int resolveDuringBatch, out bool resolveIsAfterCopy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref batchesDrawn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref batchCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(layerBatches);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &resolveDuringBatch;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &resolveIsAfterCopy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Render2DLightingPass.NativeMethodInfoPtr_DetermineWhenToResolve_Private_Void_Int32_Int32_Int32_Il2CppStructArray_1_LayerBatch_byref_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00021EA8 File Offset: 0x000200A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 600515, RefRangeEnd = 600518, XrefRangeStart = 600504, XrefRangeEnd = 600515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, ref FilteringSettings filterSettings, DrawingSettings drawSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filterSettings;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Render2DLightingPass.NativeMethodInfoPtr_Render_Private_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_byref_FilteringSettings_DrawingSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00021F28 File Offset: 0x00020128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 600633, RefRangeEnd = 600634, XrefRangeStart = 600518, XrefRangeEnd = 600633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DrawLayerBatches(Il2CppStructArray<LayerBatch> layerBatches, int batchCount, int startIndex, CommandBuffer cmd, ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings normalsDrawSettings, ref DrawingSettings drawSettings, ref RenderTextureDescriptor desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layerBatches);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref batchCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &normalsDrawSettings;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawSettings;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &desc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Render2DLightingPass.NativeMethodInfoPtr_DrawLayerBatches_Private_Int32_Il2CppStructArray_1_LayerBatch_Int32_Int32_CommandBuffer_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_DrawingSettings_byref_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00021FF4 File Offset: 0x000201F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600634, XrefRangeEnd = 600819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Render2DLightingPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00022050 File Offset: 0x00020250
		public unsafe virtual Renderer2DData UnityEngine.Rendering.Universal.IRenderPass2D.rendererData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Render2DLightingPass.NativeMethodInfoPtr_UnityEngine_Rendering_Universal_IRenderPass2D_get_rendererData_Private_Virtual_Final_New_get_Renderer2DData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Renderer2DData>(intPtr3) : null;
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000036BB File Offset: 0x000018BB
		public Render2DLightingPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00022090 File Offset: 0x00020290
		// (set) Token: 0x06000363 RID: 867 RVA: 0x000036C4 File Offset: 0x000018C4
		public unsafe static int k_HDREmulationScaleID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_k_HDREmulationScaleID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_k_HDREmulationScaleID, (void*)(&value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000364 RID: 868 RVA: 0x000220AC File Offset: 0x000202AC
		// (set) Token: 0x06000365 RID: 869 RVA: 0x000036D2 File Offset: 0x000018D2
		public unsafe static int k_InverseHDREmulationScaleID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_k_InverseHDREmulationScaleID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_k_InverseHDREmulationScaleID, (void*)(&value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000366 RID: 870 RVA: 0x000220C8 File Offset: 0x000202C8
		// (set) Token: 0x06000367 RID: 871 RVA: 0x000036E0 File Offset: 0x000018E0
		public unsafe static int k_UseSceneLightingID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_k_UseSceneLightingID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_k_UseSceneLightingID, (void*)(&value));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000368 RID: 872 RVA: 0x000220E4 File Offset: 0x000202E4
		// (set) Token: 0x06000369 RID: 873 RVA: 0x000036EE File Offset: 0x000018EE
		public unsafe static int k_RendererColorID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_k_RendererColorID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_k_RendererColorID, (void*)(&value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00022100 File Offset: 0x00020300
		// (set) Token: 0x0600036B RID: 875 RVA: 0x000036FC File Offset: 0x000018FC
		public unsafe static Il2CppStructArray<int> k_ShapeLightTextureIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_k_ShapeLightTextureIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_k_ShapeLightTextureIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00022128 File Offset: 0x00020328
		// (set) Token: 0x0600036D RID: 877 RVA: 0x0000370E File Offset: 0x0000190E
		public unsafe static ShaderTagId k_CombinedRenderingPassName
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_k_CombinedRenderingPassName, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_k_CombinedRenderingPassName, (void*)(&value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00022144 File Offset: 0x00020344
		// (set) Token: 0x0600036F RID: 879 RVA: 0x0000371C File Offset: 0x0000191C
		public unsafe static ShaderTagId k_NormalsRenderingPassName
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_k_NormalsRenderingPassName, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_k_NormalsRenderingPassName, (void*)(&value));
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00022160 File Offset: 0x00020360
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0000372A File Offset: 0x0000192A
		public unsafe static ShaderTagId k_LegacyPassName
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_k_LegacyPassName, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_k_LegacyPassName, (void*)(&value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0002217C File Offset: 0x0002037C
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00003738 File Offset: 0x00001938
		public unsafe static List<ShaderTagId> k_ShaderTags
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_k_ShaderTags, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_k_ShaderTags, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000374 RID: 884 RVA: 0x000221A4 File Offset: 0x000203A4
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0000374A File Offset: 0x0000194A
		public unsafe static ProfilingSampler m_ProfilingDrawLights
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingDrawLights, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingDrawLights, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000376 RID: 886 RVA: 0x000221CC File Offset: 0x000203CC
		// (set) Token: 0x06000377 RID: 887 RVA: 0x0000375C File Offset: 0x0000195C
		public unsafe static ProfilingSampler m_ProfilingDrawLightTextures
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingDrawLightTextures, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingDrawLightTextures, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000378 RID: 888 RVA: 0x000221F4 File Offset: 0x000203F4
		// (set) Token: 0x06000379 RID: 889 RVA: 0x0000376E File Offset: 0x0000196E
		public unsafe static ProfilingSampler m_ProfilingDrawRenderers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingDrawRenderers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingDrawRenderers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0002221C File Offset: 0x0002041C
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00003780 File Offset: 0x00001980
		public unsafe static ProfilingSampler m_ProfilingDrawLayerBatch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingDrawLayerBatch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingDrawLayerBatch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00022244 File Offset: 0x00020444
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00003792 File Offset: 0x00001992
		public unsafe static ProfilingSampler m_ProfilingSamplerUnlit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingSamplerUnlit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.NativeFieldInfoPtr_m_ProfilingSamplerUnlit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0002226C File Offset: 0x0002046C
		// (set) Token: 0x0600037F RID: 895 RVA: 0x000037A4 File Offset: 0x000019A4
		public unsafe Material m_BlitMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Render2DLightingPass.NativeFieldInfoPtr_m_BlitMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Render2DLightingPass.NativeFieldInfoPtr_m_BlitMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0002229C File Offset: 0x0002049C
		// (set) Token: 0x06000381 RID: 897 RVA: 0x000037C3 File Offset: 0x000019C3
		public unsafe Material m_SamplingMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Render2DLightingPass.NativeFieldInfoPtr_m_SamplingMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Render2DLightingPass.NativeFieldInfoPtr_m_SamplingMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000382 RID: 898 RVA: 0x000222CC File Offset: 0x000204CC
		// (set) Token: 0x06000383 RID: 899 RVA: 0x000037E2 File Offset: 0x000019E2
		public unsafe Renderer2DData m_Renderer2DData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Render2DLightingPass.NativeFieldInfoPtr_m_Renderer2DData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer2DData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Render2DLightingPass.NativeFieldInfoPtr_m_Renderer2DData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000384 RID: 900 RVA: 0x000222FC File Offset: 0x000204FC
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00003801 File Offset: 0x00001A01
		public unsafe bool m_NeedsDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Render2DLightingPass.NativeFieldInfoPtr_m_NeedsDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Render2DLightingPass.NativeFieldInfoPtr_m_NeedsDepth)) = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00022324 File Offset: 0x00020524
		// (set) Token: 0x06000387 RID: 903 RVA: 0x0000381C File Offset: 0x00001A1C
		public unsafe short m_CameraSortingLayerBoundsIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Render2DLightingPass.NativeFieldInfoPtr_m_CameraSortingLayerBoundsIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Render2DLightingPass.NativeFieldInfoPtr_m_CameraSortingLayerBoundsIndex)) = value;
			}
		}

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeFieldInfoPtr_k_HDREmulationScaleID;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr_k_InverseHDREmulationScaleID;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeFieldInfoPtr_k_UseSceneLightingID;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeFieldInfoPtr_k_RendererColorID;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeFieldInfoPtr_k_ShapeLightTextureIDs;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_k_CombinedRenderingPassName;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_k_NormalsRenderingPassName;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_k_LegacyPassName;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderTags;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingDrawLights;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingDrawLightTextures;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingDrawRenderers;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingDrawLayerBatch;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSamplerUnlit;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_m_BlitMaterial;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_m_SamplingMaterial;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr_m_Renderer2DData;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedsDepth;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraSortingLayerBoundsIndex;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Renderer2DData_Material_Material_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Internal_Void_Boolean_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_GetTransparencySortingMode_Private_Void_Camera_byref_SortingSettings_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_CopyCameraSortingLayerRenderTexture_Private_Void_ScriptableRenderContext_RenderingData_RenderBufferStoreAction_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraSortingLayerBoundsIndex_Internal_Static_Int16_Renderer2DData_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_DetermineWhenToResolve_Private_Void_Int32_Int32_Int32_Il2CppStructArray_1_LayerBatch_byref_Int32_byref_Boolean_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_Render_Private_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_byref_FilteringSettings_DrawingSettings_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_DrawLayerBatches_Private_Int32_Il2CppStructArray_1_LayerBatch_Int32_Int32_CommandBuffer_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_DrawingSettings_byref_RenderTextureDescriptor_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Rendering_Universal_IRenderPass2D_get_rendererData_Private_Virtual_Final_New_get_Renderer2DData_0;

		// Token: 0x0200015C RID: 348
		[ObfuscatedName("UnityEngine.Rendering.Universal.Render2DLightingPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001B7F RID: 7039 RVA: 0x00072708 File Offset: 0x00070908
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Render2DLightingPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Render2DLightingPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Render2DLightingPass.__c>.NativeClassPtr);
				Render2DLightingPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass.__c>.NativeClassPtr, "<>9");
				Render2DLightingPass.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Render2DLightingPass.__c>.NativeClassPtr, "<>9__25_0");
				Render2DLightingPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Render2DLightingPass.__c>.NativeClassPtr, 100663743);
				Render2DLightingPass.__c.NativeMethodInfoPtr__Render_b__25_0_Internal_Void_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Render2DLightingPass.__c>.NativeClassPtr, 100663744);
			}

			// Token: 0x06001B80 RID: 7040 RVA: 0x00072784 File Offset: 0x00070984
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Render2DLightingPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Render2DLightingPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B81 RID: 7041 RVA: 0x000727C0 File Offset: 0x000709C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600422, XrefRangeEnd = 600426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__25_0(ScriptableRenderContext ctx, ref RenderingData data, ref DrawingSettings ds, ref FilteringSettings fs, ref RenderStateBlock rsb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ctx;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ds;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fs;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rsb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Render2DLightingPass.__c.NativeMethodInfoPtr__Render_b__25_0_Internal_Void_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B82 RID: 7042 RVA: 0x0000F8ED File Offset: 0x0000DAED
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009E3 RID: 2531
			// (get) Token: 0x06001B83 RID: 7043 RVA: 0x00072840 File Offset: 0x00070A40
			// (set) Token: 0x06001B84 RID: 7044 RVA: 0x0000F8F6 File Offset: 0x0000DAF6
			public unsafe static Render2DLightingPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Render2DLightingPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009E4 RID: 2532
			// (get) Token: 0x06001B85 RID: 7045 RVA: 0x00072868 File Offset: 0x00070A68
			// (set) Token: 0x06001B86 RID: 7046 RVA: 0x0000F908 File Offset: 0x0000DB08
			public unsafe static DebugHandler.DrawFunction __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Render2DLightingPass.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugHandler.DrawFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Render2DLightingPass.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001410 RID: 5136
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001411 RID: 5137
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x04001412 RID: 5138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001413 RID: 5139
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__25_0_Internal_Void_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0;
		}
	}
}
