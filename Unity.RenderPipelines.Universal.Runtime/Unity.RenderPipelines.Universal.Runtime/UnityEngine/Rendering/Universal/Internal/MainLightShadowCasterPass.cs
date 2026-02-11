using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x02000126 RID: 294
	public class MainLightShadowCasterPass : ScriptableRenderPass
	{
		// Token: 0x0600199B RID: 6555 RVA: 0x0006B8CC File Offset: 0x00069ACC
		// Note: this type is marked as 'beforefieldinit'.
		static MainLightShadowCasterPass()
		{
			Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "MainLightShadowCasterPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr);
			MainLightShadowCasterPass.NativeFieldInfoPtr_k_MaxCascades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "k_MaxCascades");
			MainLightShadowCasterPass.NativeFieldInfoPtr_k_ShadowmapBufferBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "k_ShadowmapBufferBits");
			MainLightShadowCasterPass.NativeFieldInfoPtr_m_CascadeBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "m_CascadeBorder");
			MainLightShadowCasterPass.NativeFieldInfoPtr_m_MaxShadowDistanceSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "m_MaxShadowDistanceSq");
			MainLightShadowCasterPass.NativeFieldInfoPtr_m_ShadowCasterCascadesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "m_ShadowCasterCascadesCount");
			MainLightShadowCasterPass.NativeFieldInfoPtr_m_MainLightShadowmapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "m_MainLightShadowmapID");
			MainLightShadowCasterPass.NativeFieldInfoPtr_m_MainLightShadowmapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "m_MainLightShadowmapTexture");
			MainLightShadowCasterPass.NativeFieldInfoPtr_m_EmptyMainLightShadowmapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "m_EmptyMainLightShadowmapTexture");
			MainLightShadowCasterPass.NativeFieldInfoPtr_k_EmptyShadowMapDimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "k_EmptyShadowMapDimensions");
			MainLightShadowCasterPass.NativeFieldInfoPtr_k_MainLightShadowMapTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "k_MainLightShadowMapTextureName");
			MainLightShadowCasterPass.NativeFieldInfoPtr_k_EmptyMainLightShadowMapTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "k_EmptyMainLightShadowMapTextureName");
			MainLightShadowCasterPass.NativeFieldInfoPtr_s_EmptyShadowParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "s_EmptyShadowParams");
			MainLightShadowCasterPass.NativeFieldInfoPtr_s_EmptyShadowmapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "s_EmptyShadowmapSize");
			MainLightShadowCasterPass.NativeFieldInfoPtr_m_MainLightShadowMatrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "m_MainLightShadowMatrices");
			MainLightShadowCasterPass.NativeFieldInfoPtr_m_CascadeSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "m_CascadeSlices");
			MainLightShadowCasterPass.NativeFieldInfoPtr_m_CascadeSplitDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "m_CascadeSplitDistances");
			MainLightShadowCasterPass.NativeFieldInfoPtr_m_CreateEmptyShadowmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "m_CreateEmptyShadowmap");
			MainLightShadowCasterPass.NativeFieldInfoPtr_renderTargetWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "renderTargetWidth");
			MainLightShadowCasterPass.NativeFieldInfoPtr_renderTargetHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "renderTargetHeight");
			MainLightShadowCasterPass.NativeFieldInfoPtr_m_ProfilingSetupSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "m_ProfilingSetupSampler");
			MainLightShadowCasterPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, 100666309);
			MainLightShadowCasterPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, 100666310);
			MainLightShadowCasterPass.NativeMethodInfoPtr_Setup_Public_Boolean_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, 100666311);
			MainLightShadowCasterPass.NativeMethodInfoPtr_SetupForEmptyRendering_Private_Boolean_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, 100666312);
			MainLightShadowCasterPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, 100666313);
			MainLightShadowCasterPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, 100666314);
			MainLightShadowCasterPass.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, 100666315);
			MainLightShadowCasterPass.NativeMethodInfoPtr_SetEmptyMainLightCascadeShadowmap_Private_Void_byref_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, 100666316);
			MainLightShadowCasterPass.NativeMethodInfoPtr_SetEmptyMainLightShadowParams_Internal_Static_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, 100666317);
			MainLightShadowCasterPass.NativeMethodInfoPtr_RenderMainLightCascadeShadowmap_Private_Void_byref_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, 100666318);
			MainLightShadowCasterPass.NativeMethodInfoPtr_SetupMainLightShadowReceiverConstants_Private_Void_CommandBuffer_byref_VisibleLight_byref_ShadowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, 100666319);
			MainLightShadowCasterPass.NativeMethodInfoPtr_Render_Internal_TextureHandle_RenderGraph_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, 100666320);
			MainLightShadowCasterPass.NativeMethodInfoPtr_InitPassData_Private_Void_byref_PassData_byref_RenderingData_byref_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, 100666321);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0006BB90 File Offset: 0x00069D90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 628578, RefRangeEnd = 628579, XrefRangeStart = 628499, XrefRangeEnd = 628578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainLightShadowCasterPass(RenderPassEvent evt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0006BBD8 File Offset: 0x00069DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 628581, RefRangeEnd = 628582, XrefRangeStart = 628579, XrefRangeEnd = 628581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0006BC0C File Offset: 0x00069E0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 628631, RefRangeEnd = 628634, XrefRangeStart = 628582, XrefRangeEnd = 628631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Setup(ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.NativeMethodInfoPtr_Setup_Public_Boolean_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0006BC5C File Offset: 0x00069E5C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 628640, RefRangeEnd = 628645, XrefRangeStart = 628634, XrefRangeEnd = 628640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetupForEmptyRendering(ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.NativeMethodInfoPtr_SetupForEmptyRendering_Private_Boolean_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0006BCAC File Offset: 0x00069EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628645, XrefRangeEnd = 628647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraTextureDescriptor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainLightShadowCasterPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x0006BD08 File Offset: 0x00069F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628647, XrefRangeEnd = 628651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainLightShadowCasterPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x0006BD64 File Offset: 0x00069F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628651, XrefRangeEnd = 628657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0006BD98 File Offset: 0x00069F98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628682, RefRangeEnd = 628684, XrefRangeStart = 628657, XrefRangeEnd = 628682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEmptyMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.NativeMethodInfoPtr_SetEmptyMainLightCascadeShadowmap_Private_Void_byref_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0006BDEC File Offset: 0x00069FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 628694, RefRangeEnd = 628695, XrefRangeStart = 628684, XrefRangeEnd = 628694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetEmptyMainLightShadowParams(CommandBuffer cmd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.NativeMethodInfoPtr_SetEmptyMainLightShadowParams_Internal_Static_Void_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0006BE24 File Offset: 0x0006A024
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628742, RefRangeEnd = 628744, XrefRangeStart = 628695, XrefRangeEnd = 628742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.NativeMethodInfoPtr_RenderMainLightCascadeShadowmap_Private_Void_byref_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0006BE78 File Offset: 0x0006A078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 628777, RefRangeEnd = 628778, XrefRangeStart = 628744, XrefRangeEnd = 628777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupMainLightShadowReceiverConstants(CommandBuffer cmd, ref VisibleLight shadowLight, ref ShadowData shadowData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowLight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(shadowData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.NativeMethodInfoPtr_SetupMainLightShadowReceiverConstants_Private_Void_CommandBuffer_byref_VisibleLight_byref_ShadowData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0006BEDC File Offset: 0x0006A0DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628851, RefRangeEnd = 628853, XrefRangeStart = 628778, XrefRangeEnd = 628851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle Render(RenderGraph graph, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(graph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.NativeMethodInfoPtr_Render_Internal_TextureHandle_RenderGraph_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x0006BF3C File Offset: 0x0006A13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628853, XrefRangeEnd = 628857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitPassData(ref MainLightShadowCasterPass.PassData passData, ref RenderingData renderingData, ref RenderGraph graph)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(passData);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(graph);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.NativeMethodInfoPtr_InitPassData_Private_Void_byref_PassData_byref_RenderingData_byref_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			passData = ((intPtr5 == 0) ? null : new MainLightShadowCasterPass.PassData(intPtr5));
			IntPtr intPtr6 = intPtr2;
			graph = ((intPtr6 == 0) ? null : new RenderGraph(intPtr6));
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x0000E819 File Offset: 0x0000CA19
		public MainLightShadowCasterPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x0006BFD0 File Offset: 0x0006A1D0
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x0000E822 File Offset: 0x0000CA22
		public unsafe static int k_MaxCascades
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.NativeFieldInfoPtr_k_MaxCascades, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.NativeFieldInfoPtr_k_MaxCascades, (void*)(&value));
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x0006BFEC File Offset: 0x0006A1EC
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x0000E830 File Offset: 0x0000CA30
		public unsafe static int k_ShadowmapBufferBits
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.NativeFieldInfoPtr_k_ShadowmapBufferBits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.NativeFieldInfoPtr_k_ShadowmapBufferBits, (void*)(&value));
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x0006C008 File Offset: 0x0006A208
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x0000E83E File Offset: 0x0000CA3E
		public unsafe float m_CascadeBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_CascadeBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_CascadeBorder)) = value;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x0006C030 File Offset: 0x0006A230
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x0000E859 File Offset: 0x0000CA59
		public unsafe float m_MaxShadowDistanceSq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_MaxShadowDistanceSq);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_MaxShadowDistanceSq)) = value;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x0006C058 File Offset: 0x0006A258
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x0000E874 File Offset: 0x0000CA74
		public unsafe int m_ShadowCasterCascadesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_ShadowCasterCascadesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_ShadowCasterCascadesCount)) = value;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x0006C080 File Offset: 0x0006A280
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x0000E88F File Offset: 0x0000CA8F
		public unsafe int m_MainLightShadowmapID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_MainLightShadowmapID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_MainLightShadowmapID)) = value;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x0006C0A8 File Offset: 0x0006A2A8
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x0000E8AA File Offset: 0x0000CAAA
		public unsafe RTHandle m_MainLightShadowmapTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_MainLightShadowmapTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_MainLightShadowmapTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x0006C0D8 File Offset: 0x0006A2D8
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x0000E8C9 File Offset: 0x0000CAC9
		public unsafe RTHandle m_EmptyMainLightShadowmapTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_EmptyMainLightShadowmapTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_EmptyMainLightShadowmapTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x0006C108 File Offset: 0x0006A308
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x0000E8E8 File Offset: 0x0000CAE8
		public unsafe static int k_EmptyShadowMapDimensions
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.NativeFieldInfoPtr_k_EmptyShadowMapDimensions, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.NativeFieldInfoPtr_k_EmptyShadowMapDimensions, (void*)(&value));
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x0006C124 File Offset: 0x0006A324
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x0000E8F6 File Offset: 0x0000CAF6
		public unsafe static string k_MainLightShadowMapTextureName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.NativeFieldInfoPtr_k_MainLightShadowMapTextureName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.NativeFieldInfoPtr_k_MainLightShadowMapTextureName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x0006C144 File Offset: 0x0006A344
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x0000E908 File Offset: 0x0000CB08
		public unsafe static string k_EmptyMainLightShadowMapTextureName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.NativeFieldInfoPtr_k_EmptyMainLightShadowMapTextureName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.NativeFieldInfoPtr_k_EmptyMainLightShadowMapTextureName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x0006C164 File Offset: 0x0006A364
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x0000E91A File Offset: 0x0000CB1A
		public unsafe static Vector4 s_EmptyShadowParams
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.NativeFieldInfoPtr_s_EmptyShadowParams, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.NativeFieldInfoPtr_s_EmptyShadowParams, (void*)(&value));
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x0006C180 File Offset: 0x0006A380
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0000E928 File Offset: 0x0000CB28
		public unsafe static Vector4 s_EmptyShadowmapSize
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.NativeFieldInfoPtr_s_EmptyShadowmapSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.NativeFieldInfoPtr_s_EmptyShadowmapSize, (void*)(&value));
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x0006C19C File Offset: 0x0006A39C
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0000E936 File Offset: 0x0000CB36
		public unsafe Il2CppStructArray<Matrix4x4> m_MainLightShadowMatrices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_MainLightShadowMatrices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_MainLightShadowMatrices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x0006C1CC File Offset: 0x0006A3CC
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0000E955 File Offset: 0x0000CB55
		public unsafe Il2CppStructArray<ShadowSliceData> m_CascadeSlices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_CascadeSlices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShadowSliceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_CascadeSlices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x0006C1FC File Offset: 0x0006A3FC
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x0000E974 File Offset: 0x0000CB74
		public unsafe Il2CppStructArray<Vector4> m_CascadeSplitDistances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_CascadeSplitDistances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_CascadeSplitDistances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x0006C22C File Offset: 0x0006A42C
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x0000E993 File Offset: 0x0000CB93
		public unsafe bool m_CreateEmptyShadowmap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_CreateEmptyShadowmap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_CreateEmptyShadowmap)) = value;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x0006C254 File Offset: 0x0006A454
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x0000E9AE File Offset: 0x0000CBAE
		public unsafe int renderTargetWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_renderTargetWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_renderTargetWidth)) = value;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x0006C27C File Offset: 0x0006A47C
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x0000E9C9 File Offset: 0x0000CBC9
		public unsafe int renderTargetHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_renderTargetHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_renderTargetHeight)) = value;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x0006C2A4 File Offset: 0x0006A4A4
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0000E9E4 File Offset: 0x0000CBE4
		public unsafe ProfilingSampler m_ProfilingSetupSampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_ProfilingSetupSampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.NativeFieldInfoPtr_m_ProfilingSetupSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxCascades;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeFieldInfoPtr_k_ShadowmapBufferBits;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeFieldInfoPtr_m_CascadeBorder;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxShadowDistanceSq;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowCasterCascadesCount;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeFieldInfoPtr_m_MainLightShadowmapID;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeFieldInfoPtr_m_MainLightShadowmapTexture;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeFieldInfoPtr_m_EmptyMainLightShadowmapTexture;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeFieldInfoPtr_k_EmptyShadowMapDimensions;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeFieldInfoPtr_k_MainLightShadowMapTextureName;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeFieldInfoPtr_k_EmptyMainLightShadowMapTextureName;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyShadowParams;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyShadowmapSize;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeFieldInfoPtr_m_MainLightShadowMatrices;

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeFieldInfoPtr_m_CascadeSlices;

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeFieldInfoPtr_m_CascadeSplitDistances;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateEmptyShadowmap;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeFieldInfoPtr_renderTargetWidth;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeFieldInfoPtr_renderTargetHeight;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSetupSampler;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Boolean_byref_RenderingData_0;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeMethodInfoPtr_SetupForEmptyRendering_Private_Boolean_byref_RenderingData_0;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeMethodInfoPtr_SetEmptyMainLightCascadeShadowmap_Private_Void_byref_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeMethodInfoPtr_SetEmptyMainLightShadowParams_Internal_Static_Void_CommandBuffer_0;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeMethodInfoPtr_RenderMainLightCascadeShadowmap_Private_Void_byref_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeMethodInfoPtr_SetupMainLightShadowReceiverConstants_Private_Void_CommandBuffer_byref_VisibleLight_byref_ShadowData_0;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_TextureHandle_RenderGraph_byref_RenderingData_0;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeMethodInfoPtr_InitPassData_Private_Void_byref_PassData_byref_RenderingData_byref_RenderGraph_0;

		// Token: 0x02000202 RID: 514
		public static class MainLightShadowConstantBuffer : Object
		{
			// Token: 0x06002363 RID: 9059 RVA: 0x000858E0 File Offset: 0x00083AE0
			// Note: this type is marked as 'beforefieldinit'.
			static MainLightShadowConstantBuffer()
			{
				Il2CppClassPointerStore<MainLightShadowCasterPass.MainLightShadowConstantBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "MainLightShadowConstantBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainLightShadowCasterPass.MainLightShadowConstantBuffer>.NativeClassPtr);
				MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__WorldToShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.MainLightShadowConstantBuffer>.NativeClassPtr, "_WorldToShadow");
				MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__ShadowParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.MainLightShadowConstantBuffer>.NativeClassPtr, "_ShadowParams");
				MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSpheres0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.MainLightShadowConstantBuffer>.NativeClassPtr, "_CascadeShadowSplitSpheres0");
				MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSpheres1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.MainLightShadowConstantBuffer>.NativeClassPtr, "_CascadeShadowSplitSpheres1");
				MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSpheres2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.MainLightShadowConstantBuffer>.NativeClassPtr, "_CascadeShadowSplitSpheres2");
				MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSpheres3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.MainLightShadowConstantBuffer>.NativeClassPtr, "_CascadeShadowSplitSpheres3");
				MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSphereRadii = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.MainLightShadowConstantBuffer>.NativeClassPtr, "_CascadeShadowSplitSphereRadii");
				MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__ShadowOffset0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.MainLightShadowConstantBuffer>.NativeClassPtr, "_ShadowOffset0");
				MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__ShadowOffset1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.MainLightShadowConstantBuffer>.NativeClassPtr, "_ShadowOffset1");
				MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__ShadowmapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.MainLightShadowConstantBuffer>.NativeClassPtr, "_ShadowmapSize");
			}

			// Token: 0x06002364 RID: 9060 RVA: 0x00014468 File Offset: 0x00012668
			public MainLightShadowConstantBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CC9 RID: 3273
			// (get) Token: 0x06002365 RID: 9061 RVA: 0x000859D4 File Offset: 0x00083BD4
			// (set) Token: 0x06002366 RID: 9062 RVA: 0x00014471 File Offset: 0x00012671
			public unsafe static int _WorldToShadow
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__WorldToShadow, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__WorldToShadow, (void*)(&value));
				}
			}

			// Token: 0x17000CCA RID: 3274
			// (get) Token: 0x06002367 RID: 9063 RVA: 0x000859F0 File Offset: 0x00083BF0
			// (set) Token: 0x06002368 RID: 9064 RVA: 0x0001447F File Offset: 0x0001267F
			public unsafe static int _ShadowParams
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__ShadowParams, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__ShadowParams, (void*)(&value));
				}
			}

			// Token: 0x17000CCB RID: 3275
			// (get) Token: 0x06002369 RID: 9065 RVA: 0x00085A0C File Offset: 0x00083C0C
			// (set) Token: 0x0600236A RID: 9066 RVA: 0x0001448D File Offset: 0x0001268D
			public unsafe static int _CascadeShadowSplitSpheres0
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSpheres0, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSpheres0, (void*)(&value));
				}
			}

			// Token: 0x17000CCC RID: 3276
			// (get) Token: 0x0600236B RID: 9067 RVA: 0x00085A28 File Offset: 0x00083C28
			// (set) Token: 0x0600236C RID: 9068 RVA: 0x0001449B File Offset: 0x0001269B
			public unsafe static int _CascadeShadowSplitSpheres1
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSpheres1, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSpheres1, (void*)(&value));
				}
			}

			// Token: 0x17000CCD RID: 3277
			// (get) Token: 0x0600236D RID: 9069 RVA: 0x00085A44 File Offset: 0x00083C44
			// (set) Token: 0x0600236E RID: 9070 RVA: 0x000144A9 File Offset: 0x000126A9
			public unsafe static int _CascadeShadowSplitSpheres2
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSpheres2, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSpheres2, (void*)(&value));
				}
			}

			// Token: 0x17000CCE RID: 3278
			// (get) Token: 0x0600236F RID: 9071 RVA: 0x00085A60 File Offset: 0x00083C60
			// (set) Token: 0x06002370 RID: 9072 RVA: 0x000144B7 File Offset: 0x000126B7
			public unsafe static int _CascadeShadowSplitSpheres3
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSpheres3, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSpheres3, (void*)(&value));
				}
			}

			// Token: 0x17000CCF RID: 3279
			// (get) Token: 0x06002371 RID: 9073 RVA: 0x00085A7C File Offset: 0x00083C7C
			// (set) Token: 0x06002372 RID: 9074 RVA: 0x000144C5 File Offset: 0x000126C5
			public unsafe static int _CascadeShadowSplitSphereRadii
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSphereRadii, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__CascadeShadowSplitSphereRadii, (void*)(&value));
				}
			}

			// Token: 0x17000CD0 RID: 3280
			// (get) Token: 0x06002373 RID: 9075 RVA: 0x00085A98 File Offset: 0x00083C98
			// (set) Token: 0x06002374 RID: 9076 RVA: 0x000144D3 File Offset: 0x000126D3
			public unsafe static int _ShadowOffset0
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__ShadowOffset0, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__ShadowOffset0, (void*)(&value));
				}
			}

			// Token: 0x17000CD1 RID: 3281
			// (get) Token: 0x06002375 RID: 9077 RVA: 0x00085AB4 File Offset: 0x00083CB4
			// (set) Token: 0x06002376 RID: 9078 RVA: 0x000144E1 File Offset: 0x000126E1
			public unsafe static int _ShadowOffset1
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__ShadowOffset1, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__ShadowOffset1, (void*)(&value));
				}
			}

			// Token: 0x17000CD2 RID: 3282
			// (get) Token: 0x06002377 RID: 9079 RVA: 0x00085AD0 File Offset: 0x00083CD0
			// (set) Token: 0x06002378 RID: 9080 RVA: 0x000144EF File Offset: 0x000126EF
			public unsafe static int _ShadowmapSize
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__ShadowmapSize, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.MainLightShadowConstantBuffer.NativeFieldInfoPtr__ShadowmapSize, (void*)(&value));
				}
			}

			// Token: 0x040018BC RID: 6332
			private static readonly IntPtr NativeFieldInfoPtr__WorldToShadow;

			// Token: 0x040018BD RID: 6333
			private static readonly IntPtr NativeFieldInfoPtr__ShadowParams;

			// Token: 0x040018BE RID: 6334
			private static readonly IntPtr NativeFieldInfoPtr__CascadeShadowSplitSpheres0;

			// Token: 0x040018BF RID: 6335
			private static readonly IntPtr NativeFieldInfoPtr__CascadeShadowSplitSpheres1;

			// Token: 0x040018C0 RID: 6336
			private static readonly IntPtr NativeFieldInfoPtr__CascadeShadowSplitSpheres2;

			// Token: 0x040018C1 RID: 6337
			private static readonly IntPtr NativeFieldInfoPtr__CascadeShadowSplitSpheres3;

			// Token: 0x040018C2 RID: 6338
			private static readonly IntPtr NativeFieldInfoPtr__CascadeShadowSplitSphereRadii;

			// Token: 0x040018C3 RID: 6339
			private static readonly IntPtr NativeFieldInfoPtr__ShadowOffset0;

			// Token: 0x040018C4 RID: 6340
			private static readonly IntPtr NativeFieldInfoPtr__ShadowOffset1;

			// Token: 0x040018C5 RID: 6341
			private static readonly IntPtr NativeFieldInfoPtr__ShadowmapSize;
		}

		// Token: 0x02000203 RID: 515
		public class PassData : Object
		{
			// Token: 0x06002379 RID: 9081 RVA: 0x00085AEC File Offset: 0x00083CEC
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<MainLightShadowCasterPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainLightShadowCasterPass.PassData>.NativeClassPtr);
				MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.PassData>.NativeClassPtr, "pass");
				MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_graph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.PassData>.NativeClassPtr, "graph");
				MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_shadowmapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.PassData>.NativeClassPtr, "shadowmapTexture");
				MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.PassData>.NativeClassPtr, "renderingData");
				MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_shadowmapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.PassData>.NativeClassPtr, "shadowmapID");
				MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_emptyShadowmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.PassData>.NativeClassPtr, "emptyShadowmap");
				MainLightShadowCasterPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass.PassData>.NativeClassPtr, 100666323);
			}

			// Token: 0x0600237A RID: 9082 RVA: 0x00085BA4 File Offset: 0x00083DA4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainLightShadowCasterPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600237B RID: 9083 RVA: 0x000144FD File Offset: 0x000126FD
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CD3 RID: 3283
			// (get) Token: 0x0600237C RID: 9084 RVA: 0x00085BE0 File Offset: 0x00083DE0
			// (set) Token: 0x0600237D RID: 9085 RVA: 0x00014506 File Offset: 0x00012706
			public unsafe MainLightShadowCasterPass pass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_pass);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainLightShadowCasterPass>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_pass), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CD4 RID: 3284
			// (get) Token: 0x0600237E RID: 9086 RVA: 0x00085C10 File Offset: 0x00083E10
			// (set) Token: 0x0600237F RID: 9087 RVA: 0x00014525 File Offset: 0x00012725
			public unsafe RenderGraph graph
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_graph);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraph>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_graph), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CD5 RID: 3285
			// (get) Token: 0x06002380 RID: 9088 RVA: 0x00085C40 File Offset: 0x00083E40
			// (set) Token: 0x06002381 RID: 9089 RVA: 0x00014544 File Offset: 0x00012744
			public unsafe TextureHandle shadowmapTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_shadowmapTexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_shadowmapTexture)) = value;
				}
			}

			// Token: 0x17000CD6 RID: 3286
			// (get) Token: 0x06002382 RID: 9090 RVA: 0x00085C68 File Offset: 0x00083E68
			// (set) Token: 0x06002383 RID: 9091 RVA: 0x0001455F File Offset: 0x0001275F
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000CD7 RID: 3287
			// (get) Token: 0x06002384 RID: 9092 RVA: 0x00085C98 File Offset: 0x00083E98
			// (set) Token: 0x06002385 RID: 9093 RVA: 0x0001458D File Offset: 0x0001278D
			public unsafe int shadowmapID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_shadowmapID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_shadowmapID)) = value;
				}
			}

			// Token: 0x17000CD8 RID: 3288
			// (get) Token: 0x06002386 RID: 9094 RVA: 0x00085CC0 File Offset: 0x00083EC0
			// (set) Token: 0x06002387 RID: 9095 RVA: 0x000145A8 File Offset: 0x000127A8
			public unsafe bool emptyShadowmap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_emptyShadowmap);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainLightShadowCasterPass.PassData.NativeFieldInfoPtr_emptyShadowmap)) = value;
				}
			}

			// Token: 0x040018C6 RID: 6342
			private static readonly IntPtr NativeFieldInfoPtr_pass;

			// Token: 0x040018C7 RID: 6343
			private static readonly IntPtr NativeFieldInfoPtr_graph;

			// Token: 0x040018C8 RID: 6344
			private static readonly IntPtr NativeFieldInfoPtr_shadowmapTexture;

			// Token: 0x040018C9 RID: 6345
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x040018CA RID: 6346
			private static readonly IntPtr NativeFieldInfoPtr_shadowmapID;

			// Token: 0x040018CB RID: 6347
			private static readonly IntPtr NativeFieldInfoPtr_emptyShadowmap;

			// Token: 0x040018CC RID: 6348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000204 RID: 516
		[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002388 RID: 9096 RVA: 0x00085CE8 File Offset: 0x00083EE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MainLightShadowCasterPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainLightShadowCasterPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainLightShadowCasterPass.__c>.NativeClassPtr);
				MainLightShadowCasterPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.__c>.NativeClassPtr, "<>9");
				MainLightShadowCasterPass.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.__c>.NativeClassPtr, "<>9__33_0");
				MainLightShadowCasterPass.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowCasterPass.__c>.NativeClassPtr, "<>9__33_1");
				MainLightShadowCasterPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass.__c>.NativeClassPtr, 100666325);
				MainLightShadowCasterPass.__c.NativeMethodInfoPtr__Render_b__33_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass.__c>.NativeClassPtr, 100666326);
				MainLightShadowCasterPass.__c.NativeMethodInfoPtr__Render_b__33_1_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainLightShadowCasterPass.__c>.NativeClassPtr, 100666327);
			}

			// Token: 0x06002389 RID: 9097 RVA: 0x00085D8C File Offset: 0x00083F8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainLightShadowCasterPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600238A RID: 9098 RVA: 0x00085DC8 File Offset: 0x00083FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628492, XrefRangeEnd = 628493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__33_0(MainLightShadowCasterPass.PassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.__c.NativeMethodInfoPtr__Render_b__33_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600238B RID: 9099 RVA: 0x00085E1C File Offset: 0x0008401C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628493, XrefRangeEnd = 628499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__33_1(MainLightShadowCasterPass.PassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainLightShadowCasterPass.__c.NativeMethodInfoPtr__Render_b__33_1_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600238C RID: 9100 RVA: 0x000145C3 File Offset: 0x000127C3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CD9 RID: 3289
			// (get) Token: 0x0600238D RID: 9101 RVA: 0x00085E70 File Offset: 0x00084070
			// (set) Token: 0x0600238E RID: 9102 RVA: 0x000145CC File Offset: 0x000127CC
			public unsafe static MainLightShadowCasterPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainLightShadowCasterPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CDA RID: 3290
			// (get) Token: 0x0600238F RID: 9103 RVA: 0x00085E98 File Offset: 0x00084098
			// (set) Token: 0x06002390 RID: 9104 RVA: 0x000145DE File Offset: 0x000127DE
			public unsafe static RenderFunc<MainLightShadowCasterPass.PassData> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<MainLightShadowCasterPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CDB RID: 3291
			// (get) Token: 0x06002391 RID: 9105 RVA: 0x00085EC0 File Offset: 0x000840C0
			// (set) Token: 0x06002392 RID: 9106 RVA: 0x000145F0 File Offset: 0x000127F0
			public unsafe static RenderFunc<MainLightShadowCasterPass.PassData> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainLightShadowCasterPass.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<MainLightShadowCasterPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainLightShadowCasterPass.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018CD RID: 6349
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040018CE RID: 6350
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x040018CF RID: 6351
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x040018D0 RID: 6352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018D1 RID: 6353
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__33_0_Internal_Void_PassData_RenderGraphContext_0;

			// Token: 0x040018D2 RID: 6354
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__33_1_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
