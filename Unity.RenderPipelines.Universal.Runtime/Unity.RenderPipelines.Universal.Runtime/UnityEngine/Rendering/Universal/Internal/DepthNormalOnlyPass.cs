using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x02000120 RID: 288
	public class DepthNormalOnlyPass : ScriptableRenderPass
	{
		// Token: 0x060018FA RID: 6394 RVA: 0x00069388 File Offset: 0x00067588
		// Note: this type is marked as 'beforefieldinit'.
		static DepthNormalOnlyPass()
		{
			Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "DepthNormalOnlyPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr);
			DepthNormalOnlyPass.NativeFieldInfoPtr__shaderTagIds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, "<shaderTagIds>k__BackingField");
			DepthNormalOnlyPass.NativeFieldInfoPtr__depthHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, "<depthHandle>k__BackingField");
			DepthNormalOnlyPass.NativeFieldInfoPtr__normalHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, "<normalHandle>k__BackingField");
			DepthNormalOnlyPass.NativeFieldInfoPtr__renderingLayersHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, "<renderingLayersHandle>k__BackingField");
			DepthNormalOnlyPass.NativeFieldInfoPtr__enableRenderingLayers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, "<enableRenderingLayers>k__BackingField");
			DepthNormalOnlyPass.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, "m_FilteringSettings");
			DepthNormalOnlyPass.NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, "m_PassData");
			DepthNormalOnlyPass.NativeFieldInfoPtr_k_DepthNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, "k_DepthNormals");
			DepthNormalOnlyPass.NativeFieldInfoPtr_k_ColorAttachment1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, "k_ColorAttachment1");
			DepthNormalOnlyPass.NativeFieldInfoPtr_k_ColorAttachment2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, "k_ColorAttachment2");
			DepthNormalOnlyPass.NativeMethodInfoPtr_get_shaderTagIds_Internal_get_List_1_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666226);
			DepthNormalOnlyPass.NativeMethodInfoPtr_set_shaderTagIds_Internal_set_Void_List_1_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666227);
			DepthNormalOnlyPass.NativeMethodInfoPtr_get_depthHandle_Private_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666228);
			DepthNormalOnlyPass.NativeMethodInfoPtr_set_depthHandle_Private_set_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666229);
			DepthNormalOnlyPass.NativeMethodInfoPtr_get_normalHandle_Private_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666230);
			DepthNormalOnlyPass.NativeMethodInfoPtr_set_normalHandle_Private_set_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666231);
			DepthNormalOnlyPass.NativeMethodInfoPtr_get_renderingLayersHandle_Private_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666232);
			DepthNormalOnlyPass.NativeMethodInfoPtr_set_renderingLayersHandle_Private_set_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666233);
			DepthNormalOnlyPass.NativeMethodInfoPtr_get_enableRenderingLayers_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666234);
			DepthNormalOnlyPass.NativeMethodInfoPtr_set_enableRenderingLayers_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666235);
			DepthNormalOnlyPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_RenderQueueRange_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666236);
			DepthNormalOnlyPass.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666237);
			DepthNormalOnlyPass.NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666238);
			DepthNormalOnlyPass.NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666239);
			DepthNormalOnlyPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666240);
			DepthNormalOnlyPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666241);
			DepthNormalOnlyPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666242);
			DepthNormalOnlyPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666243);
			DepthNormalOnlyPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, 100666244);
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x000695FC File Offset: 0x000677FC
		// (set) Token: 0x060018FC RID: 6396 RVA: 0x0006963C File Offset: 0x0006783C
		public unsafe List<ShaderTagId> shaderTagIds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_get_shaderTagIds_Internal_get_List_1_ShaderTagId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_set_shaderTagIds_Internal_set_Void_List_1_ShaderTagId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x00069680 File Offset: 0x00067880
		// (set) Token: 0x060018FE RID: 6398 RVA: 0x000696C0 File Offset: 0x000678C0
		public unsafe RTHandle depthHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_get_depthHandle_Private_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_set_depthHandle_Private_set_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x00069704 File Offset: 0x00067904
		// (set) Token: 0x06001900 RID: 6400 RVA: 0x00069744 File Offset: 0x00067944
		public unsafe RTHandle normalHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_get_normalHandle_Private_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_set_normalHandle_Private_set_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x00069788 File Offset: 0x00067988
		// (set) Token: 0x06001902 RID: 6402 RVA: 0x000697C8 File Offset: 0x000679C8
		public unsafe RTHandle renderingLayersHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_get_renderingLayersHandle_Private_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_set_renderingLayersHandle_Private_set_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x0006980C File Offset: 0x00067A0C
		// (set) Token: 0x06001904 RID: 6404 RVA: 0x00069848 File Offset: 0x00067A48
		public unsafe bool enableRenderingLayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_get_enableRenderingLayers_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_set_enableRenderingLayers_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00069888 File Offset: 0x00067A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 627380, RefRangeEnd = 627381, XrefRangeStart = 627354, XrefRangeEnd = 627380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DepthNormalOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderQueueRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_RenderQueueRange_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x000698EC File Offset: 0x00067AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 627388, RefRangeEnd = 627389, XrefRangeStart = 627381, XrefRangeEnd = 627388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0006991C File Offset: 0x00067B1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 627391, RefRangeEnd = 627393, XrefRangeStart = 627389, XrefRangeEnd = 627391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(RTHandle depthHandle, RTHandle normalHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(depthHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normalHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00069970 File Offset: 0x00067B70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 627396, RefRangeEnd = 627398, XrefRangeStart = 627393, XrefRangeEnd = 627396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(RTHandle depthHandle, RTHandle normalHandle, RTHandle decalLayerHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(depthHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normalHandle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalLayerHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x000699D8 File Offset: 0x00067BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627398, XrefRangeEnd = 627418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DepthNormalOnlyPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00069A38 File Offset: 0x00067C38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 627460, RefRangeEnd = 627462, XrefRangeStart = 627418, XrefRangeEnd = 627460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutePass(ScriptableRenderContext context, DepthNormalOnlyPass.PassData passData, ref RenderingData renderingData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(passData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00069A90 File Offset: 0x00067C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627462, XrefRangeEnd = 627468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DepthNormalOnlyPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00069AEC File Offset: 0x00067CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627468, XrefRangeEnd = 627482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraCleanup(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DepthNormalOnlyPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00069B3C File Offset: 0x00067D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 627536, RefRangeEnd = 627537, XrefRangeStart = 627482, XrefRangeEnd = 627536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderGraph renderGraph, out TextureHandle cameraNormalsTexture, out TextureHandle cameraDepthTexture, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cameraNormalsTexture;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cameraDepthTexture;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x0000E35F File Offset: 0x0000C55F
		public DepthNormalOnlyPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x00069BB0 File Offset: 0x00067DB0
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x0000E368 File Offset: 0x0000C568
		public unsafe List<ShaderTagId> _shaderTagIds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr__shaderTagIds_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr__shaderTagIds_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x00069BE0 File Offset: 0x00067DE0
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x0000E387 File Offset: 0x0000C587
		public unsafe RTHandle _depthHandle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr__depthHandle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr__depthHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x00069C10 File Offset: 0x00067E10
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x0000E3A6 File Offset: 0x0000C5A6
		public unsafe RTHandle _normalHandle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr__normalHandle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr__normalHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x00069C40 File Offset: 0x00067E40
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x0000E3C5 File Offset: 0x0000C5C5
		public unsafe RTHandle _renderingLayersHandle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr__renderingLayersHandle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr__renderingLayersHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x00069C70 File Offset: 0x00067E70
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x0000E3E4 File Offset: 0x0000C5E4
		public unsafe bool _enableRenderingLayers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr__enableRenderingLayers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr__enableRenderingLayers_k__BackingField)) = value;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x00069C98 File Offset: 0x00067E98
		// (set) Token: 0x0600191A RID: 6426 RVA: 0x0000E3FF File Offset: 0x0000C5FF
		public unsafe FilteringSettings m_FilteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr_m_FilteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr_m_FilteringSettings)) = value;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x00069CC0 File Offset: 0x00067EC0
		// (set) Token: 0x0600191C RID: 6428 RVA: 0x0000E41A File Offset: 0x0000C61A
		public unsafe DepthNormalOnlyPass.PassData m_PassData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr_m_PassData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthNormalOnlyPass.PassData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.NativeFieldInfoPtr_m_PassData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x00069CF0 File Offset: 0x00067EF0
		// (set) Token: 0x0600191E RID: 6430 RVA: 0x0000E439 File Offset: 0x0000C639
		public unsafe static List<ShaderTagId> k_DepthNormals
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DepthNormalOnlyPass.NativeFieldInfoPtr_k_DepthNormals, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DepthNormalOnlyPass.NativeFieldInfoPtr_k_DepthNormals, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x00069D18 File Offset: 0x00067F18
		// (set) Token: 0x06001920 RID: 6432 RVA: 0x0000E44B File Offset: 0x0000C64B
		public unsafe static Il2CppReferenceArray<RTHandle> k_ColorAttachment1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DepthNormalOnlyPass.NativeFieldInfoPtr_k_ColorAttachment1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DepthNormalOnlyPass.NativeFieldInfoPtr_k_ColorAttachment1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x00069D40 File Offset: 0x00067F40
		// (set) Token: 0x06001922 RID: 6434 RVA: 0x0000E45D File Offset: 0x0000C65D
		public unsafe static Il2CppReferenceArray<RTHandle> k_ColorAttachment2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DepthNormalOnlyPass.NativeFieldInfoPtr_k_ColorAttachment2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DepthNormalOnlyPass.NativeFieldInfoPtr_k_ColorAttachment2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeFieldInfoPtr__shaderTagIds_k__BackingField;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeFieldInfoPtr__depthHandle_k__BackingField;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeFieldInfoPtr__normalHandle_k__BackingField;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeFieldInfoPtr__renderingLayersHandle_k__BackingField;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeFieldInfoPtr__enableRenderingLayers_k__BackingField;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeFieldInfoPtr_m_PassData;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeFieldInfoPtr_k_DepthNormals;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeFieldInfoPtr_k_ColorAttachment1;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeFieldInfoPtr_k_ColorAttachment2;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_get_shaderTagIds_Internal_get_List_1_ShaderTagId_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_set_shaderTagIds_Internal_set_Void_List_1_ShaderTagId_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_get_depthHandle_Private_get_RTHandle_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_set_depthHandle_Private_set_Void_RTHandle_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_get_normalHandle_Private_get_RTHandle_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_set_normalHandle_Private_set_Void_RTHandle_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingLayersHandle_Private_get_RTHandle_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingLayersHandle_Private_set_Void_RTHandle_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr_get_enableRenderingLayers_Internal_get_Boolean_0;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_set_enableRenderingLayers_Internal_set_Void_Boolean_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_RenderQueueRange_LayerMask_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_0;

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_0;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_RTHandle_RTHandle_RTHandle_0;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_0;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_byref_RenderingData_0;

		// Token: 0x020001F5 RID: 501
		public class PassData : Object
		{
			// Token: 0x060022D3 RID: 8915 RVA: 0x00084460 File Offset: 0x00082660
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<DepthNormalOnlyPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthNormalOnlyPass.PassData>.NativeClassPtr);
				DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_cameraDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass.PassData>.NativeClassPtr, "cameraDepthTexture");
				DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_cameraNormalsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass.PassData>.NativeClassPtr, "cameraNormalsTexture");
				DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass.PassData>.NativeClassPtr, "renderingData");
				DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_shaderTagIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass.PassData>.NativeClassPtr, "shaderTagIds");
				DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_filteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass.PassData>.NativeClassPtr, "filteringSettings");
				DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_enableRenderingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass.PassData>.NativeClassPtr, "enableRenderingLayers");
				DepthNormalOnlyPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass.PassData>.NativeClassPtr, 100666246);
			}

			// Token: 0x060022D4 RID: 8916 RVA: 0x00084518 File Offset: 0x00082718
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthNormalOnlyPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022D5 RID: 8917 RVA: 0x00013E79 File Offset: 0x00012079
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C96 RID: 3222
			// (get) Token: 0x060022D6 RID: 8918 RVA: 0x00084554 File Offset: 0x00082754
			// (set) Token: 0x060022D7 RID: 8919 RVA: 0x00013E82 File Offset: 0x00012082
			public unsafe TextureHandle cameraDepthTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_cameraDepthTexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_cameraDepthTexture)) = value;
				}
			}

			// Token: 0x17000C97 RID: 3223
			// (get) Token: 0x060022D8 RID: 8920 RVA: 0x0008457C File Offset: 0x0008277C
			// (set) Token: 0x060022D9 RID: 8921 RVA: 0x00013E9D File Offset: 0x0001209D
			public unsafe TextureHandle cameraNormalsTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_cameraNormalsTexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_cameraNormalsTexture)) = value;
				}
			}

			// Token: 0x17000C98 RID: 3224
			// (get) Token: 0x060022DA RID: 8922 RVA: 0x000845A4 File Offset: 0x000827A4
			// (set) Token: 0x060022DB RID: 8923 RVA: 0x00013EB8 File Offset: 0x000120B8
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C99 RID: 3225
			// (get) Token: 0x060022DC RID: 8924 RVA: 0x000845D4 File Offset: 0x000827D4
			// (set) Token: 0x060022DD RID: 8925 RVA: 0x00013EE6 File Offset: 0x000120E6
			public unsafe List<ShaderTagId> shaderTagIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_shaderTagIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_shaderTagIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C9A RID: 3226
			// (get) Token: 0x060022DE RID: 8926 RVA: 0x00084604 File Offset: 0x00082804
			// (set) Token: 0x060022DF RID: 8927 RVA: 0x00013F05 File Offset: 0x00012105
			public unsafe FilteringSettings filteringSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_filteringSettings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_filteringSettings)) = value;
				}
			}

			// Token: 0x17000C9B RID: 3227
			// (get) Token: 0x060022E0 RID: 8928 RVA: 0x0008462C File Offset: 0x0008282C
			// (set) Token: 0x060022E1 RID: 8929 RVA: 0x00013F20 File Offset: 0x00012120
			public unsafe bool enableRenderingLayers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_enableRenderingLayers);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthNormalOnlyPass.PassData.NativeFieldInfoPtr_enableRenderingLayers)) = value;
				}
			}

			// Token: 0x04001874 RID: 6260
			private static readonly IntPtr NativeFieldInfoPtr_cameraDepthTexture;

			// Token: 0x04001875 RID: 6261
			private static readonly IntPtr NativeFieldInfoPtr_cameraNormalsTexture;

			// Token: 0x04001876 RID: 6262
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x04001877 RID: 6263
			private static readonly IntPtr NativeFieldInfoPtr_shaderTagIds;

			// Token: 0x04001878 RID: 6264
			private static readonly IntPtr NativeFieldInfoPtr_filteringSettings;

			// Token: 0x04001879 RID: 6265
			private static readonly IntPtr NativeFieldInfoPtr_enableRenderingLayers;

			// Token: 0x0400187A RID: 6266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F6 RID: 502
		[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060022E2 RID: 8930 RVA: 0x00084654 File Offset: 0x00082854
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DepthNormalOnlyPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DepthNormalOnlyPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthNormalOnlyPass.__c>.NativeClassPtr);
				DepthNormalOnlyPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass.__c>.NativeClassPtr, "<>9");
				DepthNormalOnlyPass.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthNormalOnlyPass.__c>.NativeClassPtr, "<>9__34_0");
				DepthNormalOnlyPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass.__c>.NativeClassPtr, 100666248);
				DepthNormalOnlyPass.__c.NativeMethodInfoPtr__Render_b__34_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthNormalOnlyPass.__c>.NativeClassPtr, 100666249);
			}

			// Token: 0x060022E3 RID: 8931 RVA: 0x000846D0 File Offset: 0x000828D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthNormalOnlyPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022E4 RID: 8932 RVA: 0x0008470C File Offset: 0x0008290C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627349, XrefRangeEnd = 627354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__34_0(DepthNormalOnlyPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthNormalOnlyPass.__c.NativeMethodInfoPtr__Render_b__34_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022E5 RID: 8933 RVA: 0x00013F3B File Offset: 0x0001213B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C9C RID: 3228
			// (get) Token: 0x060022E6 RID: 8934 RVA: 0x00084760 File Offset: 0x00082960
			// (set) Token: 0x060022E7 RID: 8935 RVA: 0x00013F44 File Offset: 0x00012144
			public unsafe static DepthNormalOnlyPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DepthNormalOnlyPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthNormalOnlyPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthNormalOnlyPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C9D RID: 3229
			// (get) Token: 0x060022E8 RID: 8936 RVA: 0x00084788 File Offset: 0x00082988
			// (set) Token: 0x060022E9 RID: 8937 RVA: 0x00013F56 File Offset: 0x00012156
			public unsafe static RenderFunc<DepthNormalOnlyPass.PassData> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DepthNormalOnlyPass.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<DepthNormalOnlyPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthNormalOnlyPass.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400187B RID: 6267
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400187C RID: 6268
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x0400187D RID: 6269
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400187E RID: 6270
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__34_0_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
