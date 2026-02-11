using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x02000123 RID: 291
	public class DrawObjectsPass : ScriptableRenderPass
	{
		// Token: 0x06001945 RID: 6469 RVA: 0x0006A5B0 File Offset: 0x000687B0
		// Note: this type is marked as 'beforefieldinit'.
		static DrawObjectsPass()
		{
			Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "DrawObjectsPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr);
			DrawObjectsPass.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, "m_FilteringSettings");
			DrawObjectsPass.NativeFieldInfoPtr_m_RenderStateBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, "m_RenderStateBlock");
			DrawObjectsPass.NativeFieldInfoPtr_m_ShaderTagIdList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, "m_ShaderTagIdList");
			DrawObjectsPass.NativeFieldInfoPtr_m_ProfilerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, "m_ProfilerTag");
			DrawObjectsPass.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, "m_ProfilingSampler");
			DrawObjectsPass.NativeFieldInfoPtr_m_IsOpaque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, "m_IsOpaque");
			DrawObjectsPass.NativeFieldInfoPtr_m_IsActiveTargetBackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, "m_IsActiveTargetBackBuffer");
			DrawObjectsPass.NativeFieldInfoPtr_m_ShouldTransparentsReceiveShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, "m_ShouldTransparentsReceiveShadows");
			DrawObjectsPass.NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, "m_PassData");
			DrawObjectsPass.NativeFieldInfoPtr_m_UseDepthPriming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, "m_UseDepthPriming");
			DrawObjectsPass.NativeFieldInfoPtr_s_DrawObjectPassDataPropID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, "s_DrawObjectPassDataPropID");
			DrawObjectsPass.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_ShaderTagId_Boolean_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, 100666269);
			DrawObjectsPass.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, 100666270);
			DrawObjectsPass.NativeMethodInfoPtr__ctor_Internal_Void_URPProfileId_Boolean_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, 100666271);
			DrawObjectsPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, 100666272);
			DrawObjectsPass.NativeMethodInfoPtr_CameraSetup_Private_Static_Void_CommandBuffer_PassData_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, 100666273);
			DrawObjectsPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, 100666274);
			DrawObjectsPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_TextureHandle_TextureHandle_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, 100666275);
			DrawObjectsPass.NativeMethodInfoPtr_OnExecute_Protected_Virtual_New_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, 100666276);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0006A75C File Offset: 0x0006895C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 627788, RefRangeEnd = 627792, XrefRangeStart = 627743, XrefRangeEnd = 627788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawObjectsPass(string profilerTag, Il2CppStructArray<ShaderTagId> shaderTagIds, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(profilerTag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shaderTagIds);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opaque;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderQueueRange;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilState;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilReference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawObjectsPass.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_ShaderTagId_Boolean_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0006A810 File Offset: 0x00068A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627792, XrefRangeEnd = 627805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawObjectsPass(string profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(profilerTag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opaque;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderQueueRange;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilState;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilReference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawObjectsPass.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0006A8B0 File Offset: 0x00068AB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 627826, RefRangeEnd = 627828, XrefRangeStart = 627805, XrefRangeEnd = 627826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawObjectsPass(URPProfileId profileId, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref profileId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opaque;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderQueueRange;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilState;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilReference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawObjectsPass.NativeMethodInfoPtr__ctor_Internal_Void_URPProfileId_Boolean_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x0006A94C File Offset: 0x00068B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627828, XrefRangeEnd = 627838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrawObjectsPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0006A9A8 File Offset: 0x00068BA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 627845, RefRangeEnd = 627847, XrefRangeStart = 627838, XrefRangeEnd = 627845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CameraSetup(CommandBuffer cmd, DrawObjectsPass.PassData data, ref RenderingData renderingData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawObjectsPass.NativeMethodInfoPtr_CameraSetup_Private_Static_Void_CommandBuffer_PassData_byref_RenderingData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0006AA04 File Offset: 0x00068C04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 627916, RefRangeEnd = 627918, XrefRangeStart = 627847, XrefRangeEnd = 627916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutePass(ScriptableRenderContext context, DrawObjectsPass.PassData data, ref RenderingData renderingData, bool yFlip)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yFlip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawObjectsPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0006AA6C File Offset: 0x00068C6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 627960, RefRangeEnd = 627962, XrefRangeStart = 627918, XrefRangeEnd = 627960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget, TextureHandle mainShadowsTexture, TextureHandle additionalShadowsTexture, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorTarget;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTarget;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainShadowsTexture;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalShadowsTexture;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawObjectsPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_TextureHandle_TextureHandle_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x0006AAFC File Offset: 0x00068CFC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnExecute(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrawObjectsPass.NativeMethodInfoPtr_OnExecute_Protected_Virtual_New_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0000E55C File Offset: 0x0000C75C
		public DrawObjectsPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x0006AB4C File Offset: 0x00068D4C
		// (set) Token: 0x06001950 RID: 6480 RVA: 0x0000E565 File Offset: 0x0000C765
		public unsafe FilteringSettings m_FilteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_FilteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_FilteringSettings)) = value;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x0006AB74 File Offset: 0x00068D74
		// (set) Token: 0x06001952 RID: 6482 RVA: 0x0000E580 File Offset: 0x0000C780
		public unsafe RenderStateBlock m_RenderStateBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_RenderStateBlock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_RenderStateBlock)) = value;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x0006AB9C File Offset: 0x00068D9C
		// (set) Token: 0x06001954 RID: 6484 RVA: 0x0000E59B File Offset: 0x0000C79B
		public unsafe List<ShaderTagId> m_ShaderTagIdList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_ShaderTagIdList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_ShaderTagIdList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x0006ABCC File Offset: 0x00068DCC
		// (set) Token: 0x06001956 RID: 6486 RVA: 0x0000E5BA File Offset: 0x0000C7BA
		public unsafe string m_ProfilerTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_ProfilerTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_ProfilerTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x0006ABF4 File Offset: 0x00068DF4
		// (set) Token: 0x06001958 RID: 6488 RVA: 0x0000E5D9 File Offset: 0x0000C7D9
		public unsafe ProfilingSampler m_ProfilingSampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_ProfilingSampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_ProfilingSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x0006AC24 File Offset: 0x00068E24
		// (set) Token: 0x0600195A RID: 6490 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		public unsafe bool m_IsOpaque
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_IsOpaque);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_IsOpaque)) = value;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x0006AC4C File Offset: 0x00068E4C
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x0000E613 File Offset: 0x0000C813
		public unsafe bool m_IsActiveTargetBackBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_IsActiveTargetBackBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_IsActiveTargetBackBuffer)) = value;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x0006AC74 File Offset: 0x00068E74
		// (set) Token: 0x0600195E RID: 6494 RVA: 0x0000E62E File Offset: 0x0000C82E
		public unsafe bool m_ShouldTransparentsReceiveShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_ShouldTransparentsReceiveShadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_ShouldTransparentsReceiveShadows)) = value;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x0006AC9C File Offset: 0x00068E9C
		// (set) Token: 0x06001960 RID: 6496 RVA: 0x0000E649 File Offset: 0x0000C849
		public unsafe DrawObjectsPass.PassData m_PassData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_PassData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawObjectsPass.PassData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_PassData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001961 RID: 6497 RVA: 0x0006ACCC File Offset: 0x00068ECC
		// (set) Token: 0x06001962 RID: 6498 RVA: 0x0000E668 File Offset: 0x0000C868
		public unsafe bool m_UseDepthPriming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_UseDepthPriming);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.NativeFieldInfoPtr_m_UseDepthPriming)) = value;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001963 RID: 6499 RVA: 0x0006ACF4 File Offset: 0x00068EF4
		// (set) Token: 0x06001964 RID: 6500 RVA: 0x0000E683 File Offset: 0x0000C883
		public unsafe static int s_DrawObjectPassDataPropID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DrawObjectsPass.NativeFieldInfoPtr_s_DrawObjectPassDataPropID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DrawObjectsPass.NativeFieldInfoPtr_s_DrawObjectPassDataPropID, (void*)(&value));
			}
		}

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderStateBlock;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeFieldInfoPtr_m_ShaderTagIdList;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilerTag;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeFieldInfoPtr_m_IsOpaque;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeFieldInfoPtr_m_IsActiveTargetBackBuffer;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldTransparentsReceiveShadows;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeFieldInfoPtr_m_PassData;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeFieldInfoPtr_m_UseDepthPriming;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeFieldInfoPtr_s_DrawObjectPassDataPropID;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_ShaderTagId_Boolean_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_0;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_0;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_URPProfileId_Boolean_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_0;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr_CameraSetup_Private_Static_Void_CommandBuffer_PassData_byref_RenderingData_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_Boolean_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_TextureHandle_TextureHandle_byref_RenderingData_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_OnExecute_Protected_Virtual_New_Void_CommandBuffer_0;

		// Token: 0x020001F9 RID: 505
		public class PassData : Object
		{
			// Token: 0x060022FD RID: 8957 RVA: 0x00084A80 File Offset: 0x00082C80
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr);
				DrawObjectsPass.PassData.NativeFieldInfoPtr_m_Albedo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr, "m_Albedo");
				DrawObjectsPass.PassData.NativeFieldInfoPtr_m_Depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr, "m_Depth");
				DrawObjectsPass.PassData.NativeFieldInfoPtr_m_RenderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr, "m_RenderingData");
				DrawObjectsPass.PassData.NativeFieldInfoPtr_m_IsOpaque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr, "m_IsOpaque");
				DrawObjectsPass.PassData.NativeFieldInfoPtr_m_RenderStateBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr, "m_RenderStateBlock");
				DrawObjectsPass.PassData.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr, "m_FilteringSettings");
				DrawObjectsPass.PassData.NativeFieldInfoPtr_m_ShaderTagIdList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr, "m_ShaderTagIdList");
				DrawObjectsPass.PassData.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr, "m_ProfilingSampler");
				DrawObjectsPass.PassData.NativeFieldInfoPtr_m_ShouldTransparentsReceiveShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr, "m_ShouldTransparentsReceiveShadows");
				DrawObjectsPass.PassData.NativeFieldInfoPtr_m_IsActiveTargetBackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr, "m_IsActiveTargetBackBuffer");
				DrawObjectsPass.PassData.NativeFieldInfoPtr_pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr, "pass");
				DrawObjectsPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr, 100666278);
			}

			// Token: 0x060022FE RID: 8958 RVA: 0x00084B9C File Offset: 0x00082D9C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawObjectsPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawObjectsPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022FF RID: 8959 RVA: 0x0001401D File Offset: 0x0001221D
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CA4 RID: 3236
			// (get) Token: 0x06002300 RID: 8960 RVA: 0x00084BD8 File Offset: 0x00082DD8
			// (set) Token: 0x06002301 RID: 8961 RVA: 0x00014026 File Offset: 0x00012226
			public unsafe TextureHandle m_Albedo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_Albedo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_Albedo)) = value;
				}
			}

			// Token: 0x17000CA5 RID: 3237
			// (get) Token: 0x06002302 RID: 8962 RVA: 0x00084C00 File Offset: 0x00082E00
			// (set) Token: 0x06002303 RID: 8963 RVA: 0x00014041 File Offset: 0x00012241
			public unsafe TextureHandle m_Depth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_Depth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_Depth)) = value;
				}
			}

			// Token: 0x17000CA6 RID: 3238
			// (get) Token: 0x06002304 RID: 8964 RVA: 0x00084C28 File Offset: 0x00082E28
			// (set) Token: 0x06002305 RID: 8965 RVA: 0x0001405C File Offset: 0x0001225C
			public RenderingData m_RenderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_RenderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_RenderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000CA7 RID: 3239
			// (get) Token: 0x06002306 RID: 8966 RVA: 0x00084C58 File Offset: 0x00082E58
			// (set) Token: 0x06002307 RID: 8967 RVA: 0x0001408A File Offset: 0x0001228A
			public unsafe bool m_IsOpaque
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_IsOpaque);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_IsOpaque)) = value;
				}
			}

			// Token: 0x17000CA8 RID: 3240
			// (get) Token: 0x06002308 RID: 8968 RVA: 0x00084C80 File Offset: 0x00082E80
			// (set) Token: 0x06002309 RID: 8969 RVA: 0x000140A5 File Offset: 0x000122A5
			public unsafe RenderStateBlock m_RenderStateBlock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_RenderStateBlock);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_RenderStateBlock)) = value;
				}
			}

			// Token: 0x17000CA9 RID: 3241
			// (get) Token: 0x0600230A RID: 8970 RVA: 0x00084CA8 File Offset: 0x00082EA8
			// (set) Token: 0x0600230B RID: 8971 RVA: 0x000140C0 File Offset: 0x000122C0
			public unsafe FilteringSettings m_FilteringSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_FilteringSettings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_FilteringSettings)) = value;
				}
			}

			// Token: 0x17000CAA RID: 3242
			// (get) Token: 0x0600230C RID: 8972 RVA: 0x00084CD0 File Offset: 0x00082ED0
			// (set) Token: 0x0600230D RID: 8973 RVA: 0x000140DB File Offset: 0x000122DB
			public unsafe List<ShaderTagId> m_ShaderTagIdList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_ShaderTagIdList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_ShaderTagIdList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CAB RID: 3243
			// (get) Token: 0x0600230E RID: 8974 RVA: 0x00084D00 File Offset: 0x00082F00
			// (set) Token: 0x0600230F RID: 8975 RVA: 0x000140FA File Offset: 0x000122FA
			public unsafe ProfilingSampler m_ProfilingSampler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_ProfilingSampler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_ProfilingSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CAC RID: 3244
			// (get) Token: 0x06002310 RID: 8976 RVA: 0x00084D30 File Offset: 0x00082F30
			// (set) Token: 0x06002311 RID: 8977 RVA: 0x00014119 File Offset: 0x00012319
			public unsafe bool m_ShouldTransparentsReceiveShadows
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_ShouldTransparentsReceiveShadows);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_ShouldTransparentsReceiveShadows)) = value;
				}
			}

			// Token: 0x17000CAD RID: 3245
			// (get) Token: 0x06002312 RID: 8978 RVA: 0x00084D58 File Offset: 0x00082F58
			// (set) Token: 0x06002313 RID: 8979 RVA: 0x00014134 File Offset: 0x00012334
			public unsafe bool m_IsActiveTargetBackBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_IsActiveTargetBackBuffer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_m_IsActiveTargetBackBuffer)) = value;
				}
			}

			// Token: 0x17000CAE RID: 3246
			// (get) Token: 0x06002314 RID: 8980 RVA: 0x00084D80 File Offset: 0x00082F80
			// (set) Token: 0x06002315 RID: 8981 RVA: 0x0001414F File Offset: 0x0001234F
			public unsafe DrawObjectsPass pass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_pass);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawObjectsPass>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawObjectsPass.PassData.NativeFieldInfoPtr_pass), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001888 RID: 6280
			private static readonly IntPtr NativeFieldInfoPtr_m_Albedo;

			// Token: 0x04001889 RID: 6281
			private static readonly IntPtr NativeFieldInfoPtr_m_Depth;

			// Token: 0x0400188A RID: 6282
			private static readonly IntPtr NativeFieldInfoPtr_m_RenderingData;

			// Token: 0x0400188B RID: 6283
			private static readonly IntPtr NativeFieldInfoPtr_m_IsOpaque;

			// Token: 0x0400188C RID: 6284
			private static readonly IntPtr NativeFieldInfoPtr_m_RenderStateBlock;

			// Token: 0x0400188D RID: 6285
			private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

			// Token: 0x0400188E RID: 6286
			private static readonly IntPtr NativeFieldInfoPtr_m_ShaderTagIdList;

			// Token: 0x0400188F RID: 6287
			private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

			// Token: 0x04001890 RID: 6288
			private static readonly IntPtr NativeFieldInfoPtr_m_ShouldTransparentsReceiveShadows;

			// Token: 0x04001891 RID: 6289
			private static readonly IntPtr NativeFieldInfoPtr_m_IsActiveTargetBackBuffer;

			// Token: 0x04001892 RID: 6290
			private static readonly IntPtr NativeFieldInfoPtr_pass;

			// Token: 0x04001893 RID: 6291
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001FA RID: 506
		[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.DrawObjectsPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002316 RID: 8982 RVA: 0x00084DB0 File Offset: 0x00082FB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DrawObjectsPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawObjectsPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawObjectsPass.__c>.NativeClassPtr);
				DrawObjectsPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.__c>.NativeClassPtr, "<>9");
				DrawObjectsPass.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.__c>.NativeClassPtr, "<>9__16_0");
				DrawObjectsPass.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawObjectsPass.__c>.NativeClassPtr, "<>9__18_0");
				DrawObjectsPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsPass.__c>.NativeClassPtr, 100666280);
				DrawObjectsPass.__c.NativeMethodInfoPtr__ExecutePass_b__16_0_Internal_Void_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsPass.__c>.NativeClassPtr, 100666281);
				DrawObjectsPass.__c.NativeMethodInfoPtr__Render_b__18_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawObjectsPass.__c>.NativeClassPtr, 100666282);
			}

			// Token: 0x06002317 RID: 8983 RVA: 0x00084E54 File Offset: 0x00083054
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawObjectsPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawObjectsPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002318 RID: 8984 RVA: 0x00084E90 File Offset: 0x00083090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627713, XrefRangeEnd = 627717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ExecutePass_b__16_0(ScriptableRenderContext ctx, ref RenderingData data, ref DrawingSettings ds, ref FilteringSettings fs, ref RenderStateBlock rsb)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawObjectsPass.__c.NativeMethodInfoPtr__ExecutePass_b__16_0_Internal_Void_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002319 RID: 8985 RVA: 0x00084F10 File Offset: 0x00083110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 627717, XrefRangeEnd = 627743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__18_0(DrawObjectsPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawObjectsPass.__c.NativeMethodInfoPtr__Render_b__18_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600231A RID: 8986 RVA: 0x0001416E File Offset: 0x0001236E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CAF RID: 3247
			// (get) Token: 0x0600231B RID: 8987 RVA: 0x00084F64 File Offset: 0x00083164
			// (set) Token: 0x0600231C RID: 8988 RVA: 0x00014177 File Offset: 0x00012377
			public unsafe static DrawObjectsPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DrawObjectsPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawObjectsPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DrawObjectsPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CB0 RID: 3248
			// (get) Token: 0x0600231D RID: 8989 RVA: 0x00084F8C File Offset: 0x0008318C
			// (set) Token: 0x0600231E RID: 8990 RVA: 0x00014189 File Offset: 0x00012389
			public unsafe static DebugHandler.DrawFunction __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DrawObjectsPass.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugHandler.DrawFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DrawObjectsPass.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CB1 RID: 3249
			// (get) Token: 0x0600231F RID: 8991 RVA: 0x00084FB4 File Offset: 0x000831B4
			// (set) Token: 0x06002320 RID: 8992 RVA: 0x0001419B File Offset: 0x0001239B
			public unsafe static RenderFunc<DrawObjectsPass.PassData> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DrawObjectsPass.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<DrawObjectsPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DrawObjectsPass.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001894 RID: 6292
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001895 RID: 6293
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04001896 RID: 6294
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04001897 RID: 6295
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001898 RID: 6296
			private static readonly IntPtr NativeMethodInfoPtr__ExecutePass_b__16_0_Internal_Void_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0;

			// Token: 0x04001899 RID: 6297
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__18_0_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
