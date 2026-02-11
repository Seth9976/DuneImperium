using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x02000125 RID: 293
	public class GBufferPass : ScriptableRenderPass
	{
		// Token: 0x06001977 RID: 6519 RVA: 0x0006B294 File Offset: 0x00069494
		// Note: this type is marked as 'beforefieldinit'.
		static GBufferPass()
		{
			Il2CppClassPointerStore<GBufferPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "GBufferPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr);
			GBufferPass.NativeFieldInfoPtr_s_CameraNormalsTextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "s_CameraNormalsTextureID");
			GBufferPass.NativeFieldInfoPtr_s_ShaderTagLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "s_ShaderTagLit");
			GBufferPass.NativeFieldInfoPtr_s_ShaderTagSimpleLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "s_ShaderTagSimpleLit");
			GBufferPass.NativeFieldInfoPtr_s_ShaderTagUnlit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "s_ShaderTagUnlit");
			GBufferPass.NativeFieldInfoPtr_s_ShaderTagComplexLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "s_ShaderTagComplexLit");
			GBufferPass.NativeFieldInfoPtr_s_ShaderTagUniversalGBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "s_ShaderTagUniversalGBuffer");
			GBufferPass.NativeFieldInfoPtr_s_ShaderTagUniversalMaterialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "s_ShaderTagUniversalMaterialType");
			GBufferPass.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "m_ProfilingSampler");
			GBufferPass.NativeFieldInfoPtr_m_DeferredLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "m_DeferredLights");
			GBufferPass.NativeFieldInfoPtr_s_ShaderTagValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "s_ShaderTagValues");
			GBufferPass.NativeFieldInfoPtr_s_RenderStateBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "s_RenderStateBlocks");
			GBufferPass.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "m_FilteringSettings");
			GBufferPass.NativeFieldInfoPtr_m_RenderStateBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "m_RenderStateBlock");
			GBufferPass.NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "m_PassData");
			GBufferPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_DeferredLights_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, 100666297);
			GBufferPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, 100666298);
			GBufferPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, 100666299);
			GBufferPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, 100666300);
			GBufferPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, 100666301);
			GBufferPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_byref_RenderingData_byref_RenderGraphFrameResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, 100666302);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x0006B454 File Offset: 0x00069654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 628312, RefRangeEnd = 628313, XrefRangeStart = 628240, XrefRangeEnd = 628312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GBufferPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference, DeferredLights deferredLights)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderQueueRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilState;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilReference;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deferredLights);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GBufferPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_DeferredLights_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x0006B4E8 File Offset: 0x000696E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628315, RefRangeEnd = 628317, XrefRangeStart = 628313, XrefRangeEnd = 628315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GBufferPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x0006B51C File Offset: 0x0006971C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628317, XrefRangeEnd = 628335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GBufferPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x0006B578 File Offset: 0x00069778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628335, XrefRangeEnd = 628352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GBufferPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x0006B5D4 File Offset: 0x000697D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628405, RefRangeEnd = 628407, XrefRangeStart = 628352, XrefRangeEnd = 628405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutePass(ScriptableRenderContext context, GBufferPass.PassData data, ref RenderingData renderingData, bool useRenderGraph = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useRenderGraph;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GBufferPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x0006B63C File Offset: 0x0006983C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 628491, RefRangeEnd = 628492, XrefRangeStart = 628407, XrefRangeEnd = 628491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderGraph renderGraph, TextureHandle cameraColor, TextureHandle cameraDepth, ref RenderingData renderingData, ref UniversalRenderer.RenderGraphFrameResources frameResources)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraDepth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(frameResources);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GBufferPass.NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_byref_RenderingData_byref_RenderGraphFrameResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			frameResources = ((intPtr4 == 0) ? null : new UniversalRenderer.RenderGraphFrameResources(intPtr4));
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x0000E6F7 File Offset: 0x0000C8F7
		public GBufferPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x0006B6D8 File Offset: 0x000698D8
		// (set) Token: 0x06001980 RID: 6528 RVA: 0x0000E700 File Offset: 0x0000C900
		public unsafe static int s_CameraNormalsTextureID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GBufferPass.NativeFieldInfoPtr_s_CameraNormalsTextureID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GBufferPass.NativeFieldInfoPtr_s_CameraNormalsTextureID, (void*)(&value));
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x0006B6F4 File Offset: 0x000698F4
		// (set) Token: 0x06001982 RID: 6530 RVA: 0x0000E70E File Offset: 0x0000C90E
		public unsafe static ShaderTagId s_ShaderTagLit
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagLit, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagLit, (void*)(&value));
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x0006B710 File Offset: 0x00069910
		// (set) Token: 0x06001984 RID: 6532 RVA: 0x0000E71C File Offset: 0x0000C91C
		public unsafe static ShaderTagId s_ShaderTagSimpleLit
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagSimpleLit, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagSimpleLit, (void*)(&value));
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x0006B72C File Offset: 0x0006992C
		// (set) Token: 0x06001986 RID: 6534 RVA: 0x0000E72A File Offset: 0x0000C92A
		public unsafe static ShaderTagId s_ShaderTagUnlit
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagUnlit, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagUnlit, (void*)(&value));
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x0006B748 File Offset: 0x00069948
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x0000E738 File Offset: 0x0000C938
		public unsafe static ShaderTagId s_ShaderTagComplexLit
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagComplexLit, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagComplexLit, (void*)(&value));
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x0006B764 File Offset: 0x00069964
		// (set) Token: 0x0600198A RID: 6538 RVA: 0x0000E746 File Offset: 0x0000C946
		public unsafe static ShaderTagId s_ShaderTagUniversalGBuffer
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagUniversalGBuffer, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagUniversalGBuffer, (void*)(&value));
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x0006B780 File Offset: 0x00069980
		// (set) Token: 0x0600198C RID: 6540 RVA: 0x0000E754 File Offset: 0x0000C954
		public unsafe static ShaderTagId s_ShaderTagUniversalMaterialType
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagUniversalMaterialType, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagUniversalMaterialType, (void*)(&value));
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x0006B79C File Offset: 0x0006999C
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x0000E762 File Offset: 0x0000C962
		public unsafe ProfilingSampler m_ProfilingSampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.NativeFieldInfoPtr_m_ProfilingSampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.NativeFieldInfoPtr_m_ProfilingSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x0006B7CC File Offset: 0x000699CC
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x0000E781 File Offset: 0x0000C981
		public unsafe DeferredLights m_DeferredLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.NativeFieldInfoPtr_m_DeferredLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeferredLights>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.NativeFieldInfoPtr_m_DeferredLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x0006B7FC File Offset: 0x000699FC
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x0000E7A0 File Offset: 0x0000C9A0
		public unsafe static Il2CppStructArray<ShaderTagId> s_ShaderTagValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GBufferPass.NativeFieldInfoPtr_s_ShaderTagValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x0006B824 File Offset: 0x00069A24
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x0000E7B2 File Offset: 0x0000C9B2
		public unsafe static Il2CppStructArray<RenderStateBlock> s_RenderStateBlocks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GBufferPass.NativeFieldInfoPtr_s_RenderStateBlocks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderStateBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GBufferPass.NativeFieldInfoPtr_s_RenderStateBlocks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x0006B84C File Offset: 0x00069A4C
		// (set) Token: 0x06001996 RID: 6550 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
		public unsafe FilteringSettings m_FilteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.NativeFieldInfoPtr_m_FilteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.NativeFieldInfoPtr_m_FilteringSettings)) = value;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x0006B874 File Offset: 0x00069A74
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x0000E7DF File Offset: 0x0000C9DF
		public unsafe RenderStateBlock m_RenderStateBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.NativeFieldInfoPtr_m_RenderStateBlock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.NativeFieldInfoPtr_m_RenderStateBlock)) = value;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x0006B89C File Offset: 0x00069A9C
		// (set) Token: 0x0600199A RID: 6554 RVA: 0x0000E7FA File Offset: 0x0000C9FA
		public unsafe GBufferPass.PassData m_PassData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.NativeFieldInfoPtr_m_PassData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GBufferPass.PassData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.NativeFieldInfoPtr_m_PassData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeFieldInfoPtr_s_CameraNormalsTextureID;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeFieldInfoPtr_s_ShaderTagLit;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeFieldInfoPtr_s_ShaderTagSimpleLit;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeFieldInfoPtr_s_ShaderTagUnlit;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeFieldInfoPtr_s_ShaderTagComplexLit;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeFieldInfoPtr_s_ShaderTagUniversalGBuffer;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeFieldInfoPtr_s_ShaderTagUniversalMaterialType;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeFieldInfoPtr_m_DeferredLights;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeFieldInfoPtr_s_ShaderTagValues;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeFieldInfoPtr_s_RenderStateBlocks;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderStateBlock;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeFieldInfoPtr_m_PassData;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_RenderQueueRange_LayerMask_StencilState_Int32_DeferredLights_0;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_ScriptableRenderContext_PassData_byref_RenderingData_Boolean_0;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_TextureHandle_TextureHandle_byref_RenderingData_byref_RenderGraphFrameResources_0;

		// Token: 0x02000200 RID: 512
		public class PassData : Object
		{
			// Token: 0x06002349 RID: 9033 RVA: 0x000854E4 File Offset: 0x000836E4
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<GBufferPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GBufferPass.PassData>.NativeClassPtr);
				GBufferPass.PassData.NativeFieldInfoPtr_gbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass.PassData>.NativeClassPtr, "gbuffer");
				GBufferPass.PassData.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass.PassData>.NativeClassPtr, "depth");
				GBufferPass.PassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass.PassData>.NativeClassPtr, "renderingData");
				GBufferPass.PassData.NativeFieldInfoPtr_deferredLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass.PassData>.NativeClassPtr, "deferredLights");
				GBufferPass.PassData.NativeFieldInfoPtr_filteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass.PassData>.NativeClassPtr, "filteringSettings");
				GBufferPass.PassData.NativeFieldInfoPtr_drawingSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass.PassData>.NativeClassPtr, "drawingSettings");
				GBufferPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GBufferPass.PassData>.NativeClassPtr, 100666304);
			}

			// Token: 0x0600234A RID: 9034 RVA: 0x0008559C File Offset: 0x0008379C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GBufferPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GBufferPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600234B RID: 9035 RVA: 0x00014363 File Offset: 0x00012563
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CC0 RID: 3264
			// (get) Token: 0x0600234C RID: 9036 RVA: 0x000855D8 File Offset: 0x000837D8
			// (set) Token: 0x0600234D RID: 9037 RVA: 0x0001436C File Offset: 0x0001256C
			public unsafe Il2CppStructArray<TextureHandle> gbuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.PassData.NativeFieldInfoPtr_gbuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.PassData.NativeFieldInfoPtr_gbuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC1 RID: 3265
			// (get) Token: 0x0600234E RID: 9038 RVA: 0x00085608 File Offset: 0x00083808
			// (set) Token: 0x0600234F RID: 9039 RVA: 0x0001438B File Offset: 0x0001258B
			public unsafe TextureHandle depth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.PassData.NativeFieldInfoPtr_depth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.PassData.NativeFieldInfoPtr_depth)) = value;
				}
			}

			// Token: 0x17000CC2 RID: 3266
			// (get) Token: 0x06002350 RID: 9040 RVA: 0x00085630 File Offset: 0x00083830
			// (set) Token: 0x06002351 RID: 9041 RVA: 0x000143A6 File Offset: 0x000125A6
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.PassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.PassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000CC3 RID: 3267
			// (get) Token: 0x06002352 RID: 9042 RVA: 0x00085660 File Offset: 0x00083860
			// (set) Token: 0x06002353 RID: 9043 RVA: 0x000143D4 File Offset: 0x000125D4
			public unsafe DeferredLights deferredLights
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.PassData.NativeFieldInfoPtr_deferredLights);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeferredLights>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.PassData.NativeFieldInfoPtr_deferredLights), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC4 RID: 3268
			// (get) Token: 0x06002354 RID: 9044 RVA: 0x00085690 File Offset: 0x00083890
			// (set) Token: 0x06002355 RID: 9045 RVA: 0x000143F3 File Offset: 0x000125F3
			public unsafe FilteringSettings filteringSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.PassData.NativeFieldInfoPtr_filteringSettings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.PassData.NativeFieldInfoPtr_filteringSettings)) = value;
				}
			}

			// Token: 0x17000CC5 RID: 3269
			// (get) Token: 0x06002356 RID: 9046 RVA: 0x000856B8 File Offset: 0x000838B8
			// (set) Token: 0x06002357 RID: 9047 RVA: 0x0001440E File Offset: 0x0001260E
			public unsafe DrawingSettings drawingSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.PassData.NativeFieldInfoPtr_drawingSettings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GBufferPass.PassData.NativeFieldInfoPtr_drawingSettings)) = value;
				}
			}

			// Token: 0x040018AF RID: 6319
			private static readonly IntPtr NativeFieldInfoPtr_gbuffer;

			// Token: 0x040018B0 RID: 6320
			private static readonly IntPtr NativeFieldInfoPtr_depth;

			// Token: 0x040018B1 RID: 6321
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x040018B2 RID: 6322
			private static readonly IntPtr NativeFieldInfoPtr_deferredLights;

			// Token: 0x040018B3 RID: 6323
			private static readonly IntPtr NativeFieldInfoPtr_filteringSettings;

			// Token: 0x040018B4 RID: 6324
			private static readonly IntPtr NativeFieldInfoPtr_drawingSettings;

			// Token: 0x040018B5 RID: 6325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000201 RID: 513
		[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.GBufferPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002358 RID: 9048 RVA: 0x000856E0 File Offset: 0x000838E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GBufferPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GBufferPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GBufferPass.__c>.NativeClassPtr);
				GBufferPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass.__c>.NativeClassPtr, "<>9");
				GBufferPass.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass.__c>.NativeClassPtr, "<>9__20_0");
				GBufferPass.__c.NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GBufferPass.__c>.NativeClassPtr, "<>9__20_1");
				GBufferPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GBufferPass.__c>.NativeClassPtr, 100666306);
				GBufferPass.__c.NativeMethodInfoPtr__Render_b__20_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GBufferPass.__c>.NativeClassPtr, 100666307);
				GBufferPass.__c.NativeMethodInfoPtr__Render_b__20_1_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GBufferPass.__c>.NativeClassPtr, 100666308);
			}

			// Token: 0x06002359 RID: 9049 RVA: 0x00085784 File Offset: 0x00083984
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GBufferPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GBufferPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600235A RID: 9050 RVA: 0x000857C0 File Offset: 0x000839C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628225, XrefRangeEnd = 628229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__20_0(GBufferPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GBufferPass.__c.NativeMethodInfoPtr__Render_b__20_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600235B RID: 9051 RVA: 0x00085814 File Offset: 0x00083A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628229, XrefRangeEnd = 628240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__20_1(GBufferPass.PassData data, RenderGraphContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GBufferPass.__c.NativeMethodInfoPtr__Render_b__20_1_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600235C RID: 9052 RVA: 0x00014429 File Offset: 0x00012629
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CC6 RID: 3270
			// (get) Token: 0x0600235D RID: 9053 RVA: 0x00085868 File Offset: 0x00083A68
			// (set) Token: 0x0600235E RID: 9054 RVA: 0x00014432 File Offset: 0x00012632
			public unsafe static GBufferPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GBufferPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GBufferPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GBufferPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC7 RID: 3271
			// (get) Token: 0x0600235F RID: 9055 RVA: 0x00085890 File Offset: 0x00083A90
			// (set) Token: 0x06002360 RID: 9056 RVA: 0x00014444 File Offset: 0x00012644
			public unsafe static RenderFunc<GBufferPass.PassData> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GBufferPass.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<GBufferPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GBufferPass.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC8 RID: 3272
			// (get) Token: 0x06002361 RID: 9057 RVA: 0x000858B8 File Offset: 0x00083AB8
			// (set) Token: 0x06002362 RID: 9058 RVA: 0x00014456 File Offset: 0x00012656
			public unsafe static RenderFunc<GBufferPass.PassData> __9__20_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GBufferPass.__c.NativeFieldInfoPtr___9__20_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<GBufferPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GBufferPass.__c.NativeFieldInfoPtr___9__20_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018B6 RID: 6326
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040018B7 RID: 6327
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x040018B8 RID: 6328
			private static readonly IntPtr NativeFieldInfoPtr___9__20_1;

			// Token: 0x040018B9 RID: 6329
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018BA RID: 6330
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__20_0_Internal_Void_PassData_RenderGraphContext_0;

			// Token: 0x040018BB RID: 6331
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__20_1_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
