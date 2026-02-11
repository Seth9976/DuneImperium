using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000092 RID: 146
	public class Graphics : Object
	{
		// Token: 0x06000843 RID: 2115 RVA: 0x00030D98 File Offset: 0x0002EF98
		// Note: this type is marked as 'beforefieldinit'.
		static Graphics()
		{
			Il2CppClassPointerStore<Graphics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Graphics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Graphics>.NativeClassPtr);
			Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphics>.NativeClassPtr, "kMaxDrawMeshInstanceCount");
			Graphics.NativeFieldInfoPtr_s_RenderInstancedDataLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphics>.NativeClassPtr, "s_RenderInstancedDataLayouts");
			Graphics.NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664295);
			Graphics.NativeMethodInfoPtr_get_activeTier_Public_Static_get_GraphicsTier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664296);
			Graphics.NativeMethodInfoPtr_set_activeTier_Public_Static_set_Void_GraphicsTier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664297);
			Graphics.NativeMethodInfoPtr_GetPreserveFramebufferAlpha_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664298);
			Graphics.NativeMethodInfoPtr_get_preserveFramebufferAlpha_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664299);
			Graphics.NativeMethodInfoPtr_GetMinOpenGLESVersion_Internal_Static_OpenGLESVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664300);
			Graphics.NativeMethodInfoPtr_get_minOpenGLESVersion_Public_Static_get_OpenGLESVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664301);
			Graphics.NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664302);
			Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664303);
			Graphics.NativeMethodInfoPtr_CopyTexture_Slice_Private_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664304);
			Graphics.NativeMethodInfoPtr_CopyTexture_Region_Private_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664305);
			Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664306);
			Graphics.NativeMethodInfoPtr_Internal_DrawMeshInstanced_Private_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664307);
			Graphics.NativeMethodInfoPtr_Blit4_Private_Static_Void_Texture_RenderTexture_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664308);
			Graphics.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664309);
			Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664310);
			Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664311);
			Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664312);
			Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664313);
			Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664314);
			Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664315);
			Graphics.NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664316);
			Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664317);
			Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664318);
			Graphics.NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664319);
			Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664320);
			Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664321);
			Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664323);
			Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664324);
			Graphics.NativeMethodInfoPtr_Blit4_Injected_Private_Static_Void_Texture_RenderTexture_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664325);
			Graphics.GetActiveColorGamutDelegateField = IL2CPP.ResolveICall<Graphics.GetActiveColorGamutDelegate>("UnityEngine.Graphics::GetActiveColorGamut");
			Graphics.Internal_SetRandomWriteTargetRTDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetRTDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetRT");
			Graphics.Internal_SetRandomWriteTargetBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetBufferDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetBuffer");
			Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetGraphicsBuffer");
			Graphics.ClearRandomWriteTargetsDelegateField = IL2CPP.ResolveICall<Graphics.ClearRandomWriteTargetsDelegate>("UnityEngine.Graphics::ClearRandomWriteTargets");
			Graphics.CopyTexture_FullDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_FullDelegate>("UnityEngine.Graphics::CopyTexture_Full");
			Graphics.CopyTexture_Slice_AllMipsDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_Slice_AllMipsDelegate>("UnityEngine.Graphics::CopyTexture_Slice_AllMips");
			Graphics.ConvertTexture_FullDelegateField = IL2CPP.ResolveICall<Graphics.ConvertTexture_FullDelegate>("UnityEngine.Graphics::ConvertTexture_Full");
			Graphics.ConvertTexture_SliceDelegateField = IL2CPP.ResolveICall<Graphics.ConvertTexture_SliceDelegate>("UnityEngine.Graphics::ConvertTexture_Slice");
			Graphics.CopyBufferImplDelegateField = IL2CPP.ResolveICall<Graphics.CopyBufferImplDelegate>("UnityEngine.Graphics::CopyBufferImpl");
			Graphics.Internal_DrawProceduralNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralNow");
			Graphics.Internal_DrawProceduralIndexedNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedNow");
			Graphics.Internal_DrawProceduralIndirectNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirectNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectNow");
			Graphics.Internal_DrawProceduralIndexedIndirectNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirectNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectNow");
			Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectNowGraphicsBuffer");
			Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer");
			Graphics.Internal_BlitMaterial5DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMaterial5Delegate>("UnityEngine.Graphics::Internal_BlitMaterial5");
			Graphics.Internal_BlitMaterial6DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMaterial6Delegate>("UnityEngine.Graphics::Internal_BlitMaterial6");
			Graphics.Internal_BlitMultiTap4DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMultiTap4Delegate>("UnityEngine.Graphics::Internal_BlitMultiTap4");
			Graphics.Internal_BlitMultiTap5DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMultiTap5Delegate>("UnityEngine.Graphics::Internal_BlitMultiTap5");
			Graphics.Blit2DelegateField = IL2CPP.ResolveICall<Graphics.Blit2Delegate>("UnityEngine.Graphics::Blit2");
			Graphics.Blit3DelegateField = IL2CPP.ResolveICall<Graphics.Blit3Delegate>("UnityEngine.Graphics::Blit3");
			Graphics.CreateGPUFenceImplDelegateField = IL2CPP.ResolveICall<Graphics.CreateGPUFenceImplDelegate>("UnityEngine.Graphics::CreateGPUFenceImpl");
			Graphics.WaitOnGPUFenceImplDelegateField = IL2CPP.ResolveICall<Graphics.WaitOnGPUFenceImplDelegate>("UnityEngine.Graphics::WaitOnGPUFenceImpl");
			Graphics.ExecuteCommandBufferAsyncDelegateField = IL2CPP.ResolveICall<Graphics.ExecuteCommandBufferAsyncDelegate>("UnityEngine.Graphics::ExecuteCommandBufferAsync");
			Graphics.GetActiveColorBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.GetActiveColorBuffer_InjectedDelegate>("UnityEngine.Graphics::GetActiveColorBuffer_Injected");
			Graphics.GetActiveDepthBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.GetActiveDepthBuffer_InjectedDelegate>("UnityEngine.Graphics::GetActiveDepthBuffer_Injected");
			Graphics.Internal_SetMRTSimple_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetMRTSimple_InjectedDelegate>("UnityEngine.Graphics::Internal_SetMRTSimple_Injected");
			Graphics.Internal_SetMRTFullSetup_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetMRTFullSetup_InjectedDelegate>("UnityEngine.Graphics::Internal_SetMRTFullSetup_Injected");
			Graphics.Internal_DrawMeshNow1_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshNow1_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshNow1_Injected");
			Graphics.Internal_DrawMeshNow2_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshNow2_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshNow2_Injected");
			Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedProcedural_Injected");
			Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedIndirect_Injected");
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected");
			Graphics.Internal_DrawProcedural_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProcedural_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProcedural_Injected");
			Graphics.Internal_DrawProceduralIndexed_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexed_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexed_Injected");
			Graphics.Internal_DrawProceduralIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirect_Injected");
			Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectGraphicsBuffer_Injected");
			Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirect_Injected");
			Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected");
			Graphics.Blit5_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Blit5_InjectedDelegate>("UnityEngine.Graphics::Blit5_Injected");
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x000312B0 File Offset: 0x0002F4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649644, XrefRangeEnd = 649646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetMaxDrawMeshInstanceCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x000312E0 File Offset: 0x0002F4E0
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x00031310 File Offset: 0x0002F510
		public unsafe static UnityEngine.Rendering.GraphicsTier activeTier
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 649648, RefRangeEnd = 649650, XrefRangeStart = 649646, XrefRangeEnd = 649648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_get_activeTier_Public_Static_get_GraphicsTier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649650, XrefRangeEnd = 649652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_set_activeTier_Public_Static_set_Void_GraphicsTier_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00031344 File Offset: 0x0002F544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649652, XrefRangeEnd = 649654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetPreserveFramebufferAlpha()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_GetPreserveFramebufferAlpha_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00031374 File Offset: 0x0002F574
		public unsafe static bool preserveFramebufferAlpha
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 649659, RefRangeEnd = 649662, XrefRangeStart = 649654, XrefRangeEnd = 649659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_get_preserveFramebufferAlpha_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000313A4 File Offset: 0x0002F5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649662, XrefRangeEnd = 649664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_GetMinOpenGLESVersion_Internal_Static_OpenGLESVersion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x000313D4 File Offset: 0x0002F5D4
		public unsafe static UnityEngine.Rendering.OpenGLESVersion minOpenGLESVersion
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 649669, RefRangeEnd = 649671, XrefRangeStart = 649664, XrefRangeEnd = 649669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_get_minOpenGLESVersion_Public_Static_get_OpenGLESVersion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00031404 File Offset: 0x0002F604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649671, XrefRangeEnd = 649673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetNullRT()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0003142C File Offset: 0x0002F62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649673, XrefRangeEnd = 649678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00031498 File Offset: 0x0002F698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649678, XrefRangeEnd = 649680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcElement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcMip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstElement;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstMip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Slice_Private_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00031518 File Offset: 0x0002F718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649680, XrefRangeEnd = 649682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcElement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcMip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcX;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcY;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcWidth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcHeight;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstElement;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstMip;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstX;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Region_Private_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x000315F4 File Offset: 0x0002F7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649682, XrefRangeEnd = 649687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(probeAnchor);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x000316E0 File Offset: 0x0002F8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649687, XrefRangeEnd = 649689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matrices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMeshInstanced_Private_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000317CC File Offset: 0x0002F9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649689, XrefRangeEnd = 649694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit4(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit4_Private_Static_Void_Texture_RenderTexture_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00031830 File Offset: 0x0002FA30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 649696, RefRangeEnd = 649698, XrefRangeStart = 649694, XrefRangeEnd = 649696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer buffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00031868 File Offset: 0x0002FA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649698, XrefRangeEnd = 649706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref colorBuffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000318D4 File Offset: 0x0002FAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649706, XrefRangeEnd = 649715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00031934 File Offset: 0x0002FB34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 649727, RefRangeEnd = 649729, XrefRangeStart = 649715, XrefRangeEnd = 649727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00031994 File Offset: 0x0002FB94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 649734, RefRangeEnd = 649736, XrefRangeStart = 649729, XrefRangeEnd = 649734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcElement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcMip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstElement;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstMip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00031A14 File Offset: 0x0002FC14
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 649741, RefRangeEnd = 649752, XrefRangeStart = 649736, XrefRangeEnd = 649741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcElement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcMip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcX;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcY;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcWidth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcHeight;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstElement;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstMip;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstX;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00031AF0 File Offset: 0x0002FCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649752, XrefRangeEnd = 649764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(probeAnchor);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00031BDC File Offset: 0x0002FDDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 649786, RefRangeEnd = 649789, XrefRangeStart = 649764, XrefRangeEnd = 649786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matrices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00031CC8 File Offset: 0x0002FEC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649797, RefRangeEnd = 649798, XrefRangeStart = 649789, XrefRangeEnd = 649797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00031D2C File Offset: 0x0002FF2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649810, RefRangeEnd = 649811, XrefRangeStart = 649798, XrefRangeEnd = 649810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00031DC4 File Offset: 0x0002FFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649815, RefRangeEnd = 649816, XrefRangeStart = 649811, XrefRangeEnd = 649815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matrices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00031E8C File Offset: 0x0003008C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 649820, RefRangeEnd = 649823, XrefRangeStart = 649816, XrefRangeEnd = 649820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(RenderTexture rt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00031EC4 File Offset: 0x000300C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649827, RefRangeEnd = 649828, XrefRangeStart = 649823, XrefRangeEnd = 649827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(RenderTexture rt, int mipLevel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00031F08 File Offset: 0x00030108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649828, XrefRangeEnd = 649830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &depth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00031F74 File Offset: 0x00030174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649830, XrefRangeEnd = 649832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matrix;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(probeAnchor);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00032060 File Offset: 0x00030260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649832, XrefRangeEnd = 649834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit4_Injected(Texture source, RenderTexture dest, ref Vector2 scale, ref Vector2 offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit4_Injected_Private_Static_Void_Texture_RenderTexture_byref_Vector2_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x000051FE File Offset: 0x000033FE
		public Graphics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x000320C4 File Offset: 0x000302C4
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00005207 File Offset: 0x00003407
		public unsafe static int kMaxDrawMeshInstanceCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount, (void*)(&value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x000320E0 File Offset: 0x000302E0
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00005215 File Offset: 0x00003415
		public unsafe static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphics.NativeFieldInfoPtr_s_RenderInstancedDataLayouts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, RenderInstancedDataLayout>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphics.NativeFieldInfoPtr_s_RenderInstancedDataLayouts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00005227 File Offset: 0x00003427
		public static ColorGamut GetActiveColorGamut()
		{
			return Graphics.GetActiveColorGamutDelegateField();
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00032108 File Offset: 0x00030308
		public static ColorGamut activeColorGamut
		{
			get
			{
				return Graphics.GetActiveColorGamut();
			}
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00032120 File Offset: 0x00030320
		public static RenderBuffer GetActiveColorBuffer()
		{
			RenderBuffer renderBuffer;
			Graphics.GetActiveColorBuffer_Injected(out renderBuffer);
			return renderBuffer;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00032138 File Offset: 0x00030338
		public static RenderBuffer GetActiveDepthBuffer()
		{
			RenderBuffer renderBuffer;
			Graphics.GetActiveDepthBuffer_Injected(out renderBuffer);
			return renderBuffer;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00005233 File Offset: 0x00003433
		public static void Internal_SetMRTSimple(Il2CppStructArray<RenderBuffer> color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
			Graphics.Internal_SetMRTSimple_Injected(color, ref depth, mip, face, depthSlice);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00032150 File Offset: 0x00030350
		public static void Internal_SetMRTFullSetup(Il2CppStructArray<RenderBuffer> color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice, Il2CppStructArray<UnityEngine.Rendering.RenderBufferLoadAction> colorLA, Il2CppStructArray<UnityEngine.Rendering.RenderBufferStoreAction> colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA)
		{
			Graphics.Internal_SetMRTFullSetup_Injected(color, ref depth, mip, face, depthSlice, colorLA, colorSA, depthLA, depthSA);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00005241 File Offset: 0x00003441
		public static void Internal_SetRandomWriteTargetRT(int index, RenderTexture uav)
		{
			Graphics.Internal_SetRandomWriteTargetRTDelegateField(index, IL2CPP.Il2CppObjectBaseToPtr(uav));
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00005254 File Offset: 0x00003454
		public static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue)
		{
			Graphics.Internal_SetRandomWriteTargetBufferDelegateField(index, IL2CPP.Il2CppObjectBaseToPtr(uav), preserveCounterValue);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00005268 File Offset: 0x00003468
		public static void Internal_SetRandomWriteTargetGraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue)
		{
			Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegateField(index, IL2CPP.Il2CppObjectBaseToPtr(uav), preserveCounterValue);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0000527C File Offset: 0x0000347C
		public static void ClearRandomWriteTargets()
		{
			Graphics.ClearRandomWriteTargetsDelegateField();
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00005288 File Offset: 0x00003488
		public static void CopyTexture_Full(Texture src, Texture dst)
		{
			Graphics.CopyTexture_FullDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst));
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000052A0 File Offset: 0x000034A0
		public static void CopyTexture_Slice_AllMips(Texture src, int srcElement, Texture dst, int dstElement)
		{
			Graphics.CopyTexture_Slice_AllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), srcElement, IL2CPP.Il2CppObjectBaseToPtr(dst), dstElement);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000052BA File Offset: 0x000034BA
		public static bool ConvertTexture_Full(Texture src, Texture dst)
		{
			return Graphics.ConvertTexture_FullDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst));
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000052D2 File Offset: 0x000034D2
		public static bool ConvertTexture_Slice(Texture src, int srcElement, Texture dst, int dstElement)
		{
			return Graphics.ConvertTexture_SliceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), srcElement, IL2CPP.Il2CppObjectBaseToPtr(dst), dstElement);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000052EC File Offset: 0x000034EC
		public static void CopyBufferImpl(GraphicsBuffer source, GraphicsBuffer dest)
		{
			Graphics.CopyBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest));
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00005304 File Offset: 0x00003504
		public static void Internal_DrawMeshNow1(Mesh mesh, int subsetIndex, Vector3 position, Quaternion rotation)
		{
			Graphics.Internal_DrawMeshNow1_Injected(mesh, subsetIndex, ref position, ref rotation);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00005311 File Offset: 0x00003511
		public static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix)
		{
			Graphics.Internal_DrawMeshNow2_Injected(mesh, subsetIndex, ref matrix);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00032174 File Offset: 0x00030374
		public static void Internal_DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, Bounds bounds, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedProcedural_Injected(mesh, submeshIndex, material, ref bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0003219C File Offset: 0x0003039C
		public static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirect_Injected(mesh, submeshIndex, material, ref bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000321C8 File Offset: 0x000303C8
		public static void Internal_DrawMeshInstancedIndirectGraphicsBuffer(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(mesh, submeshIndex, material, ref bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0000531C File Offset: 0x0000351C
		public static void Internal_DrawProceduralNow(MeshTopology topology, int vertexCount, int instanceCount)
		{
			Graphics.Internal_DrawProceduralNowDelegateField(topology, vertexCount, instanceCount);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0000532B File Offset: 0x0000352B
		public static void Internal_DrawProceduralIndexedNow(MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount)
		{
			Graphics.Internal_DrawProceduralIndexedNowDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), indexCount, instanceCount);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00005340 File Offset: 0x00003540
		public static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndirectNowDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00005354 File Offset: 0x00003554
		public static void Internal_DrawProceduralIndexedIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndexedIndirectNowDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0000536E File Offset: 0x0000356E
		public static void Internal_DrawProceduralIndirectNowGraphicsBuffer(MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00005382 File Offset: 0x00003582
		public static void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000321F4 File Offset: 0x000303F4
		public static void Internal_DrawProcedural(Material material, Bounds bounds, MeshTopology topology, int vertexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProcedural_Injected(material, ref bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00032218 File Offset: 0x00030418
		public static void Internal_DrawProceduralIndexed(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexed_Injected(material, ref bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00032240 File Offset: 0x00030440
		public static void Internal_DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndirect_Injected(material, ref bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00032264 File Offset: 0x00030464
		public static void Internal_DrawProceduralIndirectGraphicsBuffer(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_Injected(material, ref bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00032288 File Offset: 0x00030488
		public static void Internal_DrawProceduralIndexedIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexedIndirect_Injected(material, ref bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000322B0 File Offset: 0x000304B0
		public static void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(material, ref bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0000539C File Offset: 0x0000359C
		public static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT)
		{
			Graphics.Internal_BlitMaterial5DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), pass, setRT);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000053BD File Offset: 0x000035BD
		public static void Internal_BlitMaterial6(Texture source, RenderTexture dest, Material mat, int pass, bool setRT, int destDepthSlice)
		{
			Graphics.Internal_BlitMaterial6DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), pass, setRT, destDepthSlice);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000053E0 File Offset: 0x000035E0
		public static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets)
		{
			Graphics.Internal_BlitMultiTap4DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), IL2CPP.Il2CppObjectBaseToPtr(offsets));
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00005404 File Offset: 0x00003604
		public static void Internal_BlitMultiTap5(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets, int destDepthSlice)
		{
			Graphics.Internal_BlitMultiTap5DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), IL2CPP.Il2CppObjectBaseToPtr(offsets), destDepthSlice);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0000542A File Offset: 0x0000362A
		public static void Blit2(Texture source, RenderTexture dest)
		{
			Graphics.Blit2DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest));
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00005442 File Offset: 0x00003642
		public static void Blit3(Texture source, RenderTexture dest, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit3DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0000545C File Offset: 0x0000365C
		public static void Blit5(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit5_Injected(source, dest, ref scale, ref offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0000546D File Offset: 0x0000366D
		public static IntPtr CreateGPUFenceImpl(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage)
		{
			return Graphics.CreateGPUFenceImplDelegateField(fenceType, stage);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0000547B File Offset: 0x0000367B
		public static void WaitOnGPUFenceImpl(IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage)
		{
			Graphics.WaitOnGPUFenceImplDelegateField(fencePtr, stage);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00005489 File Offset: 0x00003689
		public static void ExecuteCommandBufferAsync(UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			Graphics.ExecuteCommandBufferAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buffer), queueType);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0000549C File Offset: 0x0000369C
		public static void CheckLoadActionValid(UnityEngine.Rendering.RenderBufferLoadAction load, string bufferType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000054A9 File Offset: 0x000036A9
		public static void CheckStoreActionValid(UnityEngine.Rendering.RenderBufferStoreAction store, string bufferType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x000322D8 File Offset: 0x000304D8
		public static void SetRenderTargetImpl(Il2CppStructArray<RenderBuffer> colorBuffers, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
			Graphics.Internal_SetMRTSimple(colorBuffers, depthBuffer, mipLevel, face, depthSlice);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000054B6 File Offset: 0x000036B6
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
			Graphics.SetRenderTargetImpl(colorBuffer, depthBuffer, mipLevel, face, depthSlice);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000054C5 File Offset: 0x000036C5
		public static void SetRenderTarget(Il2CppStructArray<RenderBuffer> colorBuffers, RenderBuffer depthBuffer)
		{
			Graphics.SetRenderTargetImpl(colorBuffers, depthBuffer, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x000322F4 File Offset: 0x000304F4
		public static RenderBuffer activeColorBuffer
		{
			get
			{
				return Graphics.GetActiveColorBuffer();
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x0003230C File Offset: 0x0003050C
		public static RenderBuffer activeDepthBuffer
		{
			get
			{
				return Graphics.GetActiveDepthBuffer();
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00032324 File Offset: 0x00030524
		public static void SetRandomWriteTarget(int index, RenderTexture uav)
		{
			bool flag = index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("must be non-negative less than {0}.", SystemInfo.supportedRandomWriteTargetCount));
			}
			Graphics.Internal_SetRandomWriteTargetRT(index, uav);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00032370 File Offset: 0x00030570
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue)
		{
			bool flag = uav == null;
			if (flag)
			{
				throw new ArgumentNullException("uav");
			}
			bool flag2 = uav.m_Ptr == IntPtr.Zero;
			if (flag2)
			{
				throw new ObjectDisposedException("uav");
			}
			bool flag3 = index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("must be non-negative less than {0}.", SystemInfo.supportedRandomWriteTargetCount));
			}
			Graphics.Internal_SetRandomWriteTargetBuffer(index, uav, preserveCounterValue);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x000323F0 File Offset: 0x000305F0
		public static void SetRandomWriteTarget(int index, GraphicsBuffer uav, bool preserveCounterValue)
		{
			bool flag = uav == null;
			if (flag)
			{
				throw new ArgumentNullException("uav");
			}
			bool flag2 = uav.m_Ptr == IntPtr.Zero;
			if (flag2)
			{
				throw new ObjectDisposedException("uav");
			}
			bool flag3 = index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("must be non-negative less than {0}.", SystemInfo.supportedRandomWriteTargetCount));
			}
			Graphics.Internal_SetRandomWriteTargetGraphicsBuffer(index, uav, preserveCounterValue);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x000054D3 File Offset: 0x000036D3
		public static void CopyTexture(Texture src, Texture dst)
		{
			Graphics.CopyTexture_Full(src, dst);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x000054DE File Offset: 0x000036DE
		public static void CopyTexture(Texture src, int srcElement, Texture dst, int dstElement)
		{
			Graphics.CopyTexture_Slice_AllMips(src, srcElement, dst, dstElement);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00032470 File Offset: 0x00030670
		public static bool ConvertTexture(Texture src, Texture dst)
		{
			return Graphics.ConvertTexture_Full(src, dst);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0003248C File Offset: 0x0003068C
		public static bool ConvertTexture(Texture src, int srcElement, Texture dst, int dstElement)
		{
			return Graphics.ConvertTexture_Slice(src, srcElement, dst, dstElement);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x000324A8 File Offset: 0x000306A8
		public static UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence(UnityEngine.Rendering.SynchronisationStage stage)
		{
			return Graphics.CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType.AsyncQueueSynchronisation, UnityEngine.Rendering.GraphicsFence.TranslateSynchronizationStageToFlags(stage));
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x000324C8 File Offset: 0x000306C8
		public static UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence()
		{
			return Graphics.CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType.AsyncQueueSynchronisation, UnityEngine.Rendering.SynchronisationStageFlags.PixelProcessing);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x000324E4 File Offset: 0x000306E4
		public static UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage)
		{
			UnityEngine.Rendering.GraphicsFence graphicsFence = default(UnityEngine.Rendering.GraphicsFence);
			graphicsFence.m_FenceType = fenceType;
			graphicsFence.m_Ptr = Graphics.CreateGPUFenceImpl(fenceType, stage);
			graphicsFence.InitPostAllocation();
			graphicsFence.Validate();
			return graphicsFence;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x000054EB File Offset: 0x000036EB
		public static void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence)
		{
			Graphics.WaitOnAsyncGraphicsFence(fence, UnityEngine.Rendering.SynchronisationStage.PixelProcessing);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00032528 File Offset: 0x00030728
		public static void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStage stage)
		{
			bool flag = fence.m_FenceType > UnityEngine.Rendering.GraphicsFenceType.AsyncQueueSynchronisation;
			if (flag)
			{
				throw new ArgumentException("Graphics.WaitOnGraphicsFence can only be called with fences created with GraphicsFenceType.AsyncQueueSynchronization.");
			}
			fence.Validate();
			bool flag2 = fence.IsFencePending();
			if (flag2)
			{
				Graphics.WaitOnGPUFenceImpl(fence.m_Ptr, UnityEngine.Rendering.GraphicsFence.TranslateSynchronizationStageToFlags(stage));
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00032574 File Offset: 0x00030774
		public static void ValidateCopyBuffer(GraphicsBuffer source, GraphicsBuffer dest)
		{
			bool flag = source == null;
			if (flag)
			{
				throw new ArgumentNullException("source");
			}
			bool flag2 = dest == null;
			if (flag2)
			{
				throw new ArgumentNullException("dest");
			}
			long num = (long)source.count * (long)source.stride;
			long num2 = (long)dest.count * (long)dest.stride;
			bool flag3 = num != num2;
			if (flag3)
			{
				throw new ArgumentException(String.Format("CopyBuffer source and destination buffers must be the same size, source was {0} bytes, dest was {1} bytes", num, num2));
			}
			bool flag4 = (source.target & GraphicsBuffer.Target.CopySource) == (GraphicsBuffer.Target)0;
			if (flag4)
			{
				throw new ArgumentException("CopyBuffer source must have CopySource target", "source");
			}
			bool flag5 = (dest.target & GraphicsBuffer.Target.CopyDestination) == (GraphicsBuffer.Target)0;
			if (flag5)
			{
				throw new ArgumentException("CopyBuffer destination must have CopyDestination target", "dest");
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000054F6 File Offset: 0x000036F6
		public static void CopyBuffer(GraphicsBuffer source, GraphicsBuffer dest)
		{
			Graphics.ValidateCopyBuffer(source, dest);
			Graphics.CopyBufferImpl(source, dest);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00005509 File Offset: 0x00003709
		public static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00032634 File Offset: 0x00030834
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass)
		{
			Graphics.DrawTextureImpl(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00032658 File Offset: 0x00030858
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass)
		{
			Color32 color = new Color32(128, 128, 128, 128);
			Graphics.DrawTextureImpl(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0003269C File Offset: 0x0003089C
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass)
		{
			Graphics.DrawTexture(screenRect, texture, new Rect(0f, 0f, 1f, 1f), leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00005516 File Offset: 0x00003716
		public static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass)
		{
			Graphics.DrawTexture(screenRect, texture, 0, 0, 0, 0, mat, pass);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000326D8 File Offset: 0x000308D8
		public static RenderInstancedDataLayout GetCachedRenderInstancedDataLayout(Type type)
		{
			int hashCode = type.GetHashCode();
			RenderInstancedDataLayout renderInstancedDataLayout;
			bool flag = !Graphics.s_RenderInstancedDataLayouts.TryGetValue(hashCode, out renderInstancedDataLayout);
			if (flag)
			{
				renderInstancedDataLayout = new RenderInstancedDataLayout(type);
				Graphics.s_RenderInstancedDataLayouts.Add(hashCode, renderInstancedDataLayout);
			}
			return renderInstancedDataLayout;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00032720 File Offset: 0x00030920
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation, int materialIndex)
		{
			bool flag = mesh == null;
			if (flag)
			{
				throw new ArgumentNullException("mesh");
			}
			Graphics.Internal_DrawMeshNow1(mesh, materialIndex, position, rotation);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00032750 File Offset: 0x00030950
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex)
		{
			bool flag = mesh == null;
			if (flag)
			{
				throw new ArgumentNullException("mesh");
			}
			Graphics.Internal_DrawMeshNow2(mesh, materialIndex, matrix);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00005527 File Offset: 0x00003727
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Graphics.DrawMeshNow(mesh, position, rotation, -1);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00005534 File Offset: 0x00003734
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix)
		{
			Graphics.DrawMeshNow(mesh, matrix, -1);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00032780 File Offset: 0x00030980
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000327C0 File Offset: 0x000309C0
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000327FC File Offset: 0x000309FC
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00032830 File Offset: 0x00030A30
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			bool flag = matrices == null;
			if (flag)
			{
				throw new ArgumentNullException("matrices");
			}
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(matrices), matrices.Count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00032874 File Offset: 0x00030A74
		public static void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, Bounds bounds, int count, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] UnityEngine.Rendering.LightProbeUsage lightProbeUsage, [Optional] LightProbeProxyVolume lightProbeProxyVolume)
		{
			bool flag = !SystemInfo.supportsInstancing;
			if (flag)
			{
				throw new InvalidOperationException("Instancing is not supported.");
			}
			bool flag2 = mesh == null;
			if (flag2)
			{
				throw new ArgumentNullException("mesh");
			}
			bool flag3 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			bool flag4 = material == null;
			if (flag4)
			{
				throw new ArgumentNullException("material");
			}
			bool flag5 = count <= 0;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			bool flag6 = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag6)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			bool flag7 = count > 0;
			if (flag7)
			{
				Graphics.Internal_DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00032950 File Offset: 0x00030B50
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			bool flag = !SystemInfo.supportsInstancing;
			if (flag)
			{
				throw new InvalidOperationException("Instancing is not supported.");
			}
			bool flag2 = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag2)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag3 = mesh == null;
			if (flag3)
			{
				throw new ArgumentNullException("mesh");
			}
			bool flag4 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			bool flag5 = material == null;
			if (flag5)
			{
				throw new ArgumentNullException("material");
			}
			bool flag6 = bufferWithArgs == null;
			if (flag6)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			bool flag7 = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag7)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			Graphics.Internal_DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00032A3C File Offset: 0x00030C3C
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			bool flag = !SystemInfo.supportsInstancing;
			if (flag)
			{
				throw new InvalidOperationException("Instancing is not supported.");
			}
			bool flag2 = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag2)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag3 = mesh == null;
			if (flag3)
			{
				throw new ArgumentNullException("mesh");
			}
			bool flag4 = submeshIndex < 0 || submeshIndex >= mesh.subMeshCount;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			bool flag5 = material == null;
			if (flag5)
			{
				throw new ArgumentNullException("material");
			}
			bool flag6 = bufferWithArgs == null;
			if (flag6)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			bool flag7 = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag7)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00005540 File Offset: 0x00003740
		public static void DrawProceduralNow(MeshTopology topology, int vertexCount, [Optional] int instanceCount)
		{
			Graphics.Internal_DrawProceduralNow(topology, vertexCount, instanceCount);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00032B28 File Offset: 0x00030D28
		public static void DrawProceduralNow(MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, [Optional] int instanceCount)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			Graphics.Internal_DrawProceduralIndexedNow(topology, indexBuffer, indexCount, instanceCount);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00032B54 File Offset: 0x00030D54
		public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirectNow(topology, bufferWithArgs, argsOffset);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00032B98 File Offset: 0x00030D98
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = indexBuffer == null;
			if (flag2)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag3 = bufferWithArgs == null;
			if (flag3)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirectNow(topology, indexBuffer, bufferWithArgs, argsOffset);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00032BF0 File Offset: 0x00030DF0
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirectNowGraphicsBuffer(topology, bufferWithArgs, argsOffset);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00032C34 File Offset: 0x00030E34
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = indexBuffer == null;
			if (flag2)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag3 = bufferWithArgs == null;
			if (flag3)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(topology, indexBuffer, bufferWithArgs, argsOffset);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00032C8C File Offset: 0x00030E8C
		public static void DrawProcedural(Material material, Bounds bounds, MeshTopology topology, int vertexCount, [Optional] int instanceCount, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			Graphics.Internal_DrawProcedural(material, bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00032CB0 File Offset: 0x00030EB0
		public static void DrawProcedural(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, [Optional] int instanceCount, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			Graphics.Internal_DrawProceduralIndexed(material, bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00032CEC File Offset: 0x00030EEC
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00032D3C File Offset: 0x00030F3C
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirectGraphicsBuffer(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00032D8C File Offset: 0x00030F8C
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = indexBuffer == null;
			if (flag2)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag3 = bufferWithArgs == null;
			if (flag3)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00032DF0 File Offset: 0x00030FF0
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			bool flag2 = indexBuffer == null;
			if (flag2)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag3 = bufferWithArgs == null;
			if (flag3)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0000554C File Offset: 0x0000374C
		public static void Blit(Texture source, RenderTexture dest)
		{
			Graphics.Blit2(source, dest);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00005557 File Offset: 0x00003757
		public static void Blit(Texture source, RenderTexture dest, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit3(source, dest, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00005564 File Offset: 0x00003764
		public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit5(source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00005575 File Offset: 0x00003775
		public static void Blit(Texture source, RenderTexture dest, Material mat, int pass)
		{
			Graphics.Internal_BlitMaterial5(source, dest, mat, pass, true);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00005583 File Offset: 0x00003783
		public static void Blit(Texture source, RenderTexture dest, Material mat, int pass, int destDepthSlice)
		{
			Graphics.Internal_BlitMaterial6(source, dest, mat, pass, true, destDepthSlice);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00005593 File Offset: 0x00003793
		public static void Blit(Texture source, RenderTexture dest, Material mat)
		{
			Graphics.Blit(source, dest, mat, -1);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x000055A0 File Offset: 0x000037A0
		public static void Blit(Texture source, Material mat, int pass)
		{
			Graphics.Internal_BlitMaterial5(source, null, mat, pass, false);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000055AE File Offset: 0x000037AE
		public static void Blit(Texture source, Material mat, int pass, int destDepthSlice)
		{
			Graphics.Internal_BlitMaterial6(source, null, mat, pass, false, destDepthSlice);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x000055BD File Offset: 0x000037BD
		public static void Blit(Texture source, Material mat)
		{
			Graphics.Blit(source, mat, -1);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00032E54 File Offset: 0x00031054
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets)
		{
			bool flag = offsets.Length == 0;
			if (flag)
			{
				throw new ArgumentException("empty offsets list passed.", "offsets");
			}
			Graphics.Internal_BlitMultiTap4(source, dest, mat, offsets);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x000055C9 File Offset: 0x000037C9
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, params Vector2[] offsets)
		{
			Graphics.BlitMultiTap(source, dest, mat, new Il2CppStructArray<Vector2>(offsets));
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00032E8C File Offset: 0x0003108C
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, int destDepthSlice, Il2CppStructArray<Vector2> offsets)
		{
			bool flag = offsets.Length == 0;
			if (flag)
			{
				throw new ArgumentException("empty offsets list passed.", "offsets");
			}
			Graphics.Internal_BlitMultiTap5(source, dest, mat, offsets, destDepthSlice);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000055D9 File Offset: 0x000037D9
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, int destDepthSlice, params Vector2[] offsets)
		{
			Graphics.BlitMultiTap(source, dest, mat, destDepthSlice, new Il2CppStructArray<Vector2>(offsets));
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00032EC4 File Offset: 0x000310C4
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, null, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00032EF0 File Offset: 0x000310F0
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00032F20 File Offset: 0x00031120
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00032F50 File Offset: 0x00031150
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00032F80 File Offset: 0x00031180
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00032FB8 File Offset: 0x000311B8
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00032FF0 File Offset: 0x000311F0
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00033020 File Offset: 0x00031220
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00033054 File Offset: 0x00031254
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00033088 File Offset: 0x00031288
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, null, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x000330A8 File Offset: 0x000312A8
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x000330CC File Offset: 0x000312CC
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000330F0 File Offset: 0x000312F0
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0003311C File Offset: 0x0003131C
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00033148 File Offset: 0x00031348
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0003316C File Offset: 0x0003136C
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00033194 File Offset: 0x00031394
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x000331BC File Offset: 0x000313BC
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x000331EC File Offset: 0x000313EC
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.Internal_DrawMesh(mesh, submeshIndex, matrix, material, layer, camera, properties, castShadows, receiveShadows, probeAnchor, lightProbeUsage, null);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00033214 File Offset: 0x00031414
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, matrices.Length, null, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0003323C File Offset: 0x0003143C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, null, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00033260 File Offset: 0x00031460
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00033284 File Offset: 0x00031484
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x000332A8 File Offset: 0x000314A8
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000332CC File Offset: 0x000314CC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000332F4 File Offset: 0x000314F4
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0003331C File Offset: 0x0003151C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, null, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0003333C File Offset: 0x0003153C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0003335C File Offset: 0x0003155C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00033380 File Offset: 0x00031580
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x000333A4 File Offset: 0x000315A4
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x000333C8 File Offset: 0x000315C8
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x000333EC File Offset: 0x000315EC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00033414 File Offset: 0x00031614
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00033440 File Offset: 0x00031640
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0003346C File Offset: 0x0003166C
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, -1);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00033490 File Offset: 0x00031690
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, null, -1);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x000334B4 File Offset: 0x000316B4
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat, -1);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000334D8 File Offset: 0x000316D8
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, null, -1);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x000055EB File Offset: 0x000037EB
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat, -1);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x000055FF File Offset: 0x000037FF
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, null, -1);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00005612 File Offset: 0x00003812
		public static void DrawTexture(Rect screenRect, Texture texture, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, mat, -1);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0000561F File Offset: 0x0000381F
		public static void DrawTexture(Rect screenRect, Texture texture)
		{
			Graphics.DrawTexture(screenRect, texture, null, -1);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0000562C File Offset: 0x0000382C
		public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face)
		{
			Graphics.SetRenderTarget(rt, mipLevel, face, 0);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00005639 File Offset: 0x00003839
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
		{
			Graphics.SetRenderTarget(colorBuffer, depthBuffer, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00005647 File Offset: 0x00003847
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel)
		{
			Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel, CubemapFace.Unknown, 0);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00005655 File Offset: 0x00003855
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face)
		{
			Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel, face, 0);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00005663 File Offset: 0x00003863
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav)
		{
			Graphics.SetRandomWriteTarget(index, uav, false);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0000566F File Offset: 0x0000386F
		public static void SetRandomWriteTarget(int index, GraphicsBuffer uav)
		{
			Graphics.SetRandomWriteTarget(index, uav, false);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0000567B File Offset: 0x0000387B
		public static void GetActiveColorBuffer_Injected(out RenderBuffer ret)
		{
			Graphics.GetActiveColorBuffer_InjectedDelegateField(out ret);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00005688 File Offset: 0x00003888
		public static void GetActiveDepthBuffer_Injected(out RenderBuffer ret)
		{
			Graphics.GetActiveDepthBuffer_InjectedDelegateField(out ret);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00005695 File Offset: 0x00003895
		public static void Internal_SetMRTSimple_Injected(Il2CppStructArray<RenderBuffer> color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
			Graphics.Internal_SetMRTSimple_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(color), ref depth, mip, face, depthSlice);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000334F8 File Offset: 0x000316F8
		public static void Internal_SetMRTFullSetup_Injected(Il2CppStructArray<RenderBuffer> color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice, Il2CppStructArray<UnityEngine.Rendering.RenderBufferLoadAction> colorLA, Il2CppStructArray<UnityEngine.Rendering.RenderBufferStoreAction> colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA)
		{
			Graphics.Internal_SetMRTFullSetup_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(color), ref depth, mip, face, depthSlice, IL2CPP.Il2CppObjectBaseToPtr(colorLA), IL2CPP.Il2CppObjectBaseToPtr(colorSA), depthLA, depthSA);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000056AC File Offset: 0x000038AC
		public static void Internal_DrawMeshNow1_Injected(Mesh mesh, int subsetIndex, ref Vector3 position, ref Quaternion rotation)
		{
			Graphics.Internal_DrawMeshNow1_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), subsetIndex, ref position, ref rotation);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x000056C1 File Offset: 0x000038C1
		public static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix)
		{
			Graphics.Internal_DrawMeshNow2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), subsetIndex, ref matrix);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0003352C File Offset: 0x0003172C
		public static void Internal_DrawMeshInstancedProcedural_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, count, IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer, IL2CPP.Il2CppObjectBaseToPtr(camera), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00033570 File Offset: 0x00031770
		public static void Internal_DrawMeshInstancedIndirect_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer, IL2CPP.Il2CppObjectBaseToPtr(camera), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000335BC File Offset: 0x000317BC
		public static void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer, IL2CPP.Il2CppObjectBaseToPtr(camera), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00033608 File Offset: 0x00031808
		public static void Internal_DrawProcedural_Injected(Material material, ref Bounds bounds, MeshTopology topology, int vertexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProcedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, vertexCount, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00033640 File Offset: 0x00031840
		public static void Internal_DrawProceduralIndexed_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexed_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), indexCount, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00033680 File Offset: 0x00031880
		public static void Internal_DrawProceduralIndirect_Injected(Material material, ref Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x000336BC File Offset: 0x000318BC
		public static void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000336F8 File Offset: 0x000318F8
		public static void Internal_DrawProceduralIndexedIndirect_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0003373C File Offset: 0x0003193C
		public static void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000056D5 File Offset: 0x000038D5
		public static void Blit5_Injected(Texture source, RenderTexture dest, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit5_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), ref scale, ref offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr_kMaxDrawMeshInstanceCount;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeFieldInfoPtr_s_RenderInstancedDataLayouts;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_get_activeTier_Public_Static_get_GraphicsTier_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_set_activeTier_Public_Static_set_Void_GraphicsTier_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_GetPreserveFramebufferAlpha_Internal_Static_Boolean_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_get_preserveFramebufferAlpha_Public_Static_get_Boolean_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_GetMinOpenGLESVersion_Internal_Static_OpenGLESVersion_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_get_minOpenGLESVersion_Public_Static_get_OpenGLESVersion_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Slice_Private_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Region_Private_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMeshInstanced_Private_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_Blit4_Private_Static_Void_Texture_RenderTexture_Vector2_Vector2_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_CommandBuffer_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Vector2_Vector2_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_Blit4_Injected_Private_Static_Void_Texture_RenderTexture_byref_Vector2_byref_Vector2_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly Graphics.GetActiveColorGamutDelegate GetActiveColorGamutDelegateField;

		// Token: 0x040006D2 RID: 1746
		private static readonly Graphics.Internal_SetRandomWriteTargetRTDelegate Internal_SetRandomWriteTargetRTDelegateField;

		// Token: 0x040006D3 RID: 1747
		private static readonly Graphics.Internal_SetRandomWriteTargetBufferDelegate Internal_SetRandomWriteTargetBufferDelegateField;

		// Token: 0x040006D4 RID: 1748
		private static readonly Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegate Internal_SetRandomWriteTargetGraphicsBufferDelegateField;

		// Token: 0x040006D5 RID: 1749
		private static readonly Graphics.ClearRandomWriteTargetsDelegate ClearRandomWriteTargetsDelegateField;

		// Token: 0x040006D6 RID: 1750
		private static readonly Graphics.CopyTexture_FullDelegate CopyTexture_FullDelegateField;

		// Token: 0x040006D7 RID: 1751
		private static readonly Graphics.CopyTexture_Slice_AllMipsDelegate CopyTexture_Slice_AllMipsDelegateField;

		// Token: 0x040006D8 RID: 1752
		private static readonly Graphics.ConvertTexture_FullDelegate ConvertTexture_FullDelegateField;

		// Token: 0x040006D9 RID: 1753
		private static readonly Graphics.ConvertTexture_SliceDelegate ConvertTexture_SliceDelegateField;

		// Token: 0x040006DA RID: 1754
		private static readonly Graphics.CopyBufferImplDelegate CopyBufferImplDelegateField;

		// Token: 0x040006DB RID: 1755
		private static readonly Graphics.Internal_DrawProceduralNowDelegate Internal_DrawProceduralNowDelegateField;

		// Token: 0x040006DC RID: 1756
		private static readonly Graphics.Internal_DrawProceduralIndexedNowDelegate Internal_DrawProceduralIndexedNowDelegateField;

		// Token: 0x040006DD RID: 1757
		private static readonly Graphics.Internal_DrawProceduralIndirectNowDelegate Internal_DrawProceduralIndirectNowDelegateField;

		// Token: 0x040006DE RID: 1758
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirectNowDelegate Internal_DrawProceduralIndexedIndirectNowDelegateField;

		// Token: 0x040006DF RID: 1759
		private static readonly Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegate Internal_DrawProceduralIndirectNowGraphicsBufferDelegateField;

		// Token: 0x040006E0 RID: 1760
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegate Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegateField;

		// Token: 0x040006E1 RID: 1761
		private static readonly Graphics.Internal_BlitMaterial5Delegate Internal_BlitMaterial5DelegateField;

		// Token: 0x040006E2 RID: 1762
		private static readonly Graphics.Internal_BlitMaterial6Delegate Internal_BlitMaterial6DelegateField;

		// Token: 0x040006E3 RID: 1763
		private static readonly Graphics.Internal_BlitMultiTap4Delegate Internal_BlitMultiTap4DelegateField;

		// Token: 0x040006E4 RID: 1764
		private static readonly Graphics.Internal_BlitMultiTap5Delegate Internal_BlitMultiTap5DelegateField;

		// Token: 0x040006E5 RID: 1765
		private static readonly Graphics.Blit2Delegate Blit2DelegateField;

		// Token: 0x040006E6 RID: 1766
		private static readonly Graphics.Blit3Delegate Blit3DelegateField;

		// Token: 0x040006E7 RID: 1767
		private static readonly Graphics.CreateGPUFenceImplDelegate CreateGPUFenceImplDelegateField;

		// Token: 0x040006E8 RID: 1768
		private static readonly Graphics.WaitOnGPUFenceImplDelegate WaitOnGPUFenceImplDelegateField;

		// Token: 0x040006E9 RID: 1769
		private static readonly Graphics.ExecuteCommandBufferAsyncDelegate ExecuteCommandBufferAsyncDelegateField;

		// Token: 0x040006EA RID: 1770
		private static readonly Graphics.GetActiveColorBuffer_InjectedDelegate GetActiveColorBuffer_InjectedDelegateField;

		// Token: 0x040006EB RID: 1771
		private static readonly Graphics.GetActiveDepthBuffer_InjectedDelegate GetActiveDepthBuffer_InjectedDelegateField;

		// Token: 0x040006EC RID: 1772
		private static readonly Graphics.Internal_SetMRTSimple_InjectedDelegate Internal_SetMRTSimple_InjectedDelegateField;

		// Token: 0x040006ED RID: 1773
		private static readonly Graphics.Internal_SetMRTFullSetup_InjectedDelegate Internal_SetMRTFullSetup_InjectedDelegateField;

		// Token: 0x040006EE RID: 1774
		private static readonly Graphics.Internal_DrawMeshNow1_InjectedDelegate Internal_DrawMeshNow1_InjectedDelegateField;

		// Token: 0x040006EF RID: 1775
		private static readonly Graphics.Internal_DrawMeshNow2_InjectedDelegate Internal_DrawMeshNow2_InjectedDelegateField;

		// Token: 0x040006F0 RID: 1776
		private static readonly Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegate Internal_DrawMeshInstancedProcedural_InjectedDelegateField;

		// Token: 0x040006F1 RID: 1777
		private static readonly Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegate Internal_DrawMeshInstancedIndirect_InjectedDelegateField;

		// Token: 0x040006F2 RID: 1778
		private static readonly Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField;

		// Token: 0x040006F3 RID: 1779
		private static readonly Graphics.Internal_DrawProcedural_InjectedDelegate Internal_DrawProcedural_InjectedDelegateField;

		// Token: 0x040006F4 RID: 1780
		private static readonly Graphics.Internal_DrawProceduralIndexed_InjectedDelegate Internal_DrawProceduralIndexed_InjectedDelegateField;

		// Token: 0x040006F5 RID: 1781
		private static readonly Graphics.Internal_DrawProceduralIndirect_InjectedDelegate Internal_DrawProceduralIndirect_InjectedDelegateField;

		// Token: 0x040006F6 RID: 1782
		private static readonly Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField;

		// Token: 0x040006F7 RID: 1783
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegate Internal_DrawProceduralIndexedIndirect_InjectedDelegateField;

		// Token: 0x040006F8 RID: 1784
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField;

		// Token: 0x040006F9 RID: 1785
		private static readonly Graphics.Blit5_InjectedDelegate Blit5_InjectedDelegateField;

		// Token: 0x020004D3 RID: 1235
		// (Invoke) Token: 0x060032B7 RID: 12983
		private delegate ColorGamut GetActiveColorGamutDelegate();

		// Token: 0x020004D4 RID: 1236
		// (Invoke) Token: 0x060032B9 RID: 12985
		private delegate void Internal_SetRandomWriteTargetRTDelegate(int index, IntPtr uav);

		// Token: 0x020004D5 RID: 1237
		// (Invoke) Token: 0x060032BB RID: 12987
		private delegate void Internal_SetRandomWriteTargetBufferDelegate(int index, IntPtr uav, bool preserveCounterValue);

		// Token: 0x020004D6 RID: 1238
		// (Invoke) Token: 0x060032BD RID: 12989
		private delegate void Internal_SetRandomWriteTargetGraphicsBufferDelegate(int index, IntPtr uav, bool preserveCounterValue);

		// Token: 0x020004D7 RID: 1239
		// (Invoke) Token: 0x060032BF RID: 12991
		private delegate void ClearRandomWriteTargetsDelegate();

		// Token: 0x020004D8 RID: 1240
		// (Invoke) Token: 0x060032C1 RID: 12993
		private delegate void CopyTexture_FullDelegate(IntPtr src, IntPtr dst);

		// Token: 0x020004D9 RID: 1241
		// (Invoke) Token: 0x060032C3 RID: 12995
		private delegate void CopyTexture_Slice_AllMipsDelegate(IntPtr src, int srcElement, IntPtr dst, int dstElement);

		// Token: 0x020004DA RID: 1242
		// (Invoke) Token: 0x060032C5 RID: 12997
		private delegate bool ConvertTexture_FullDelegate(IntPtr src, IntPtr dst);

		// Token: 0x020004DB RID: 1243
		// (Invoke) Token: 0x060032C7 RID: 12999
		private delegate bool ConvertTexture_SliceDelegate(IntPtr src, int srcElement, IntPtr dst, int dstElement);

		// Token: 0x020004DC RID: 1244
		// (Invoke) Token: 0x060032C9 RID: 13001
		private delegate void CopyBufferImplDelegate(IntPtr source, IntPtr dest);

		// Token: 0x020004DD RID: 1245
		// (Invoke) Token: 0x060032CB RID: 13003
		private delegate void Internal_DrawProceduralNowDelegate(MeshTopology topology, int vertexCount, int instanceCount);

		// Token: 0x020004DE RID: 1246
		// (Invoke) Token: 0x060032CD RID: 13005
		private delegate void Internal_DrawProceduralIndexedNowDelegate(MeshTopology topology, IntPtr indexBuffer, int indexCount, int instanceCount);

		// Token: 0x020004DF RID: 1247
		// (Invoke) Token: 0x060032CF RID: 13007
		private delegate void Internal_DrawProceduralIndirectNowDelegate(MeshTopology topology, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x020004E0 RID: 1248
		// (Invoke) Token: 0x060032D1 RID: 13009
		private delegate void Internal_DrawProceduralIndexedIndirectNowDelegate(MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x020004E1 RID: 1249
		// (Invoke) Token: 0x060032D3 RID: 13011
		private delegate void Internal_DrawProceduralIndirectNowGraphicsBufferDelegate(MeshTopology topology, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x020004E2 RID: 1250
		// (Invoke) Token: 0x060032D5 RID: 13013
		private delegate void Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegate(MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x020004E3 RID: 1251
		// (Invoke) Token: 0x060032D7 RID: 13015
		private delegate void Internal_BlitMaterial5Delegate(IntPtr source, IntPtr dest, IntPtr mat, int pass, bool setRT);

		// Token: 0x020004E4 RID: 1252
		// (Invoke) Token: 0x060032D9 RID: 13017
		private delegate void Internal_BlitMaterial6Delegate(IntPtr source, IntPtr dest, IntPtr mat, int pass, bool setRT, int destDepthSlice);

		// Token: 0x020004E5 RID: 1253
		// (Invoke) Token: 0x060032DB RID: 13019
		private delegate void Internal_BlitMultiTap4Delegate(IntPtr source, IntPtr dest, IntPtr mat, IntPtr offsets);

		// Token: 0x020004E6 RID: 1254
		// (Invoke) Token: 0x060032DD RID: 13021
		private delegate void Internal_BlitMultiTap5Delegate(IntPtr source, IntPtr dest, IntPtr mat, IntPtr offsets, int destDepthSlice);

		// Token: 0x020004E7 RID: 1255
		// (Invoke) Token: 0x060032DF RID: 13023
		private delegate void Blit2Delegate(IntPtr source, IntPtr dest);

		// Token: 0x020004E8 RID: 1256
		// (Invoke) Token: 0x060032E1 RID: 13025
		private delegate void Blit3Delegate(IntPtr source, IntPtr dest, int sourceDepthSlice, int destDepthSlice);

		// Token: 0x020004E9 RID: 1257
		// (Invoke) Token: 0x060032E3 RID: 13027
		private delegate IntPtr CreateGPUFenceImplDelegate(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);

		// Token: 0x020004EA RID: 1258
		// (Invoke) Token: 0x060032E5 RID: 13029
		private delegate void WaitOnGPUFenceImplDelegate(IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage);

		// Token: 0x020004EB RID: 1259
		// (Invoke) Token: 0x060032E7 RID: 13031
		private delegate void ExecuteCommandBufferAsyncDelegate(IntPtr buffer, UnityEngine.Rendering.ComputeQueueType queueType);

		// Token: 0x020004EC RID: 1260
		// (Invoke) Token: 0x060032E9 RID: 13033
		private delegate void GetActiveColorBuffer_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020004ED RID: 1261
		// (Invoke) Token: 0x060032EB RID: 13035
		private delegate void GetActiveDepthBuffer_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020004EE RID: 1262
		// (Invoke) Token: 0x060032ED RID: 13037
		private delegate void Internal_SetMRTSimple_InjectedDelegate(IntPtr color, IntPtr depth, int mip, CubemapFace face, int depthSlice);

		// Token: 0x020004EF RID: 1263
		// (Invoke) Token: 0x060032EF RID: 13039
		private delegate void Internal_SetMRTFullSetup_InjectedDelegate(IntPtr color, IntPtr depth, int mip, CubemapFace face, int depthSlice, IntPtr colorLA, IntPtr colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA);

		// Token: 0x020004F0 RID: 1264
		// (Invoke) Token: 0x060032F1 RID: 13041
		private delegate void Internal_DrawMeshNow1_InjectedDelegate(IntPtr mesh, int subsetIndex, IntPtr position, IntPtr rotation);

		// Token: 0x020004F1 RID: 1265
		// (Invoke) Token: 0x060032F3 RID: 13043
		private delegate void Internal_DrawMeshNow2_InjectedDelegate(IntPtr mesh, int subsetIndex, IntPtr matrix);

		// Token: 0x020004F2 RID: 1266
		// (Invoke) Token: 0x060032F5 RID: 13045
		private delegate void Internal_DrawMeshInstancedProcedural_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr material, IntPtr bounds, int count, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x020004F3 RID: 1267
		// (Invoke) Token: 0x060032F7 RID: 13047
		private delegate void Internal_DrawMeshInstancedIndirect_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr material, IntPtr bounds, IntPtr bufferWithArgs, int argsOffset, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x020004F4 RID: 1268
		// (Invoke) Token: 0x060032F9 RID: 13049
		private delegate void Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr material, IntPtr bounds, IntPtr bufferWithArgs, int argsOffset, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x020004F5 RID: 1269
		// (Invoke) Token: 0x060032FB RID: 13051
		private delegate void Internal_DrawProcedural_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, int vertexCount, int instanceCount, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x020004F6 RID: 1270
		// (Invoke) Token: 0x060032FD RID: 13053
		private delegate void Internal_DrawProceduralIndexed_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr indexBuffer, int indexCount, int instanceCount, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x020004F7 RID: 1271
		// (Invoke) Token: 0x060032FF RID: 13055
		private delegate void Internal_DrawProceduralIndirect_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x020004F8 RID: 1272
		// (Invoke) Token: 0x06003301 RID: 13057
		private delegate void Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x020004F9 RID: 1273
		// (Invoke) Token: 0x06003303 RID: 13059
		private delegate void Internal_DrawProceduralIndexedIndirect_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x020004FA RID: 1274
		// (Invoke) Token: 0x06003305 RID: 13061
		private delegate void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x020004FB RID: 1275
		// (Invoke) Token: 0x06003307 RID: 13063
		private delegate void Blit5_InjectedDelegate(IntPtr source, IntPtr dest, IntPtr scale, IntPtr offset, int sourceDepthSlice, int destDepthSlice);
	}
}
