using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000025 RID: 37
	public class RenderGraphResourceRegistry : Object
	{
		// Token: 0x0600033E RID: 830 RVA: 0x000198BC File Offset: 0x00017ABC
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphResourceRegistry()
		{
			Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphResourceRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr);
			RenderGraphResourceRegistry.NativeFieldInfoPtr_kSharedResourceLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "kSharedResourceLifetime");
			RenderGraphResourceRegistry.NativeFieldInfoPtr_m_CurrentRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_CurrentRegistry");
			RenderGraphResourceRegistry.NativeFieldInfoPtr_m_RenderGraphResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_RenderGraphResources");
			RenderGraphResourceRegistry.NativeFieldInfoPtr_m_RendererListResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_RendererListResources");
			RenderGraphResourceRegistry.NativeFieldInfoPtr_m_RenderGraphDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_RenderGraphDebug");
			RenderGraphResourceRegistry.NativeFieldInfoPtr_m_ResourceLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_ResourceLogger");
			RenderGraphResourceRegistry.NativeFieldInfoPtr_m_FrameInformationLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_FrameInformationLogger");
			RenderGraphResourceRegistry.NativeFieldInfoPtr_m_CurrentFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_CurrentFrameIndex");
			RenderGraphResourceRegistry.NativeFieldInfoPtr_m_ExecutionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_ExecutionCount");
			RenderGraphResourceRegistry.NativeFieldInfoPtr_m_CurrentBackbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_CurrentBackbuffer");
			RenderGraphResourceRegistry.NativeFieldInfoPtr_kInitialRendererListCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "kInitialRendererListCount");
			RenderGraphResourceRegistry.NativeFieldInfoPtr_m_ActiveRendererLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "m_ActiveRendererLists");
			RenderGraphResourceRegistry.NativeMethodInfoPtr_get_current_Internal_Static_get_RenderGraphResourceRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663701);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_set_current_Internal_Static_set_Void_RenderGraphResourceRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663702);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_GetTexture_Internal_RTHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663703);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_TextureNeedsFallback_Internal_Boolean_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663704);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_GetRendererList_Internal_RendererList_byref_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663705);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_GetComputeBuffer_Internal_ComputeBuffer_byref_ComputeBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663706);
			RenderGraphResourceRegistry.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663707);
			RenderGraphResourceRegistry.NativeMethodInfoPtr__ctor_Internal_Void_RenderGraphDebugParams_RenderGraphLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663708);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_BeginRenderGraph_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663709);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_BeginExecute_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663710);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_EndExecute_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663711);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_CheckHandleValidity_Private_Void_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663712);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_CheckHandleValidity_Private_Void_RenderGraphResourceType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663713);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_IncrementWriteCount_Internal_Void_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663714);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_GetRenderGraphResourceName_Internal_String_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663715);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_GetRenderGraphResourceName_Internal_String_RenderGraphResourceType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663716);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_IsRenderGraphResourceImported_Internal_Boolean_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663717);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_IsRenderGraphResourceShared_Internal_Boolean_RenderGraphResourceType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663718);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_IsGraphicsResourceCreated_Internal_Boolean_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663719);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_IsRendererListCreated_Internal_Boolean_byref_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663720);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_IsRenderGraphResourceImported_Internal_Boolean_RenderGraphResourceType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663721);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_GetRenderGraphResourceTransientIndex_Internal_Int32_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663722);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663723);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_CreateSharedTexture_Internal_TextureHandle_byref_TextureDesc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663724);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_RefreshSharedTextureDesc_Internal_Void_TextureHandle_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663725);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_ReleaseSharedTexture_Internal_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663726);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_ImportBackbuffer_Internal_TextureHandle_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663727);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_CreateTexture_Internal_TextureHandle_byref_TextureDesc_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663728);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_GetResourceCount_Internal_Int32_RenderGraphResourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663729);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_GetTextureResourceCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663730);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_GetTextureResource_Internal_TextureResource_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663731);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_GetTextureResourceDesc_Internal_TextureDesc_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663732);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_CreateRendererList_Internal_RendererListHandle_byref_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663733);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_ImportComputeBuffer_Internal_ComputeBufferHandle_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663734);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_CreateComputeBuffer_Internal_ComputeBufferHandle_byref_ComputeBufferDesc_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663735);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_GetComputeBufferResourceDesc_Internal_ComputeBufferDesc_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663736);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_GetComputeBufferResourceCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663737);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_GetComputeBufferResource_Private_ComputeBufferResource_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663738);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_UpdateSharedResourceLastFrameIndex_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663739);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_ManageSharedRenderGraphResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663740);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_CreatePooledResource_Internal_Boolean_RenderGraphContext_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663741);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_CreatePooledResource_Internal_Boolean_RenderGraphContext_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663742);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_CreateTextureCallback_Private_Boolean_RenderGraphContext_IRenderGraphResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663743);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_ReleasePooledResource_Internal_Void_RenderGraphContext_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663744);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_ReleasePooledResource_Internal_Void_RenderGraphContext_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663745);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_ReleaseTextureCallback_Private_Void_RenderGraphContext_IRenderGraphResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663746);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_ValidateTextureDesc_Private_Void_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663747);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_ValidateRendererListDesc_Private_Void_byref_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663748);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_ValidateComputeBufferDesc_Private_Void_byref_ComputeBufferDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663749);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_CreateRendererLists_Internal_Void_List_1_RendererListHandle_ScriptableRenderContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663750);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663751);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_PurgeUnusedGraphicsResources_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663752);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663753);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_FlushLogs_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663754);
			RenderGraphResourceRegistry.NativeMethodInfoPtr_LogResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, 100663755);
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00019E28 File Offset: 0x00018028
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00019E5C File Offset: 0x0001805C
		public unsafe static RenderGraphResourceRegistry current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957758, XrefRangeEnd = 957760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_get_current_Internal_Static_get_RenderGraphResourceRegistry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderGraphResourceRegistry>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957760, XrefRangeEnd = 957764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_set_current_Internal_Static_set_Void_RenderGraphResourceRegistry_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00019E94 File Offset: 0x00018094
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 957772, RefRangeEnd = 957778, XrefRangeStart = 957764, XrefRangeEnd = 957772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle GetTexture([In] ref TextureHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_GetTexture_Internal_RTHandle_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00019EE0 File Offset: 0x000180E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 957786, RefRangeEnd = 957788, XrefRangeStart = 957778, XrefRangeEnd = 957786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TextureNeedsFallback([In] ref TextureHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_TextureNeedsFallback_Internal_Boolean_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00019F2C File Offset: 0x0001812C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 957797, RefRangeEnd = 957798, XrefRangeStart = 957788, XrefRangeEnd = 957797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererList GetRendererList([In] ref RendererListHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_GetRendererList_Internal_RendererList_byref_RendererListHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00019F78 File Offset: 0x00018178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 957818, RefRangeEnd = 957819, XrefRangeStart = 957798, XrefRangeEnd = 957818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer GetComputeBuffer([In] ref ComputeBufferHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_GetComputeBuffer_Internal_ComputeBuffer_byref_ComputeBufferHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00019FC4 File Offset: 0x000181C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957819, XrefRangeEnd = 957843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphResourceRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001A000 File Offset: 0x00018200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 957932, RefRangeEnd = 957933, XrefRangeStart = 957843, XrefRangeEnd = 957932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphResourceRegistry(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger frameInformationLogger)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraphDebug);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frameInformationLogger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr__ctor_Internal_Void_RenderGraphDebugParams_RenderGraphLogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0001A060 File Offset: 0x00018260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957933, XrefRangeEnd = 957949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginRenderGraph(int executionCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executionCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_BeginRenderGraph_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0001A0A0 File Offset: 0x000182A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 957960, RefRangeEnd = 957962, XrefRangeStart = 957949, XrefRangeEnd = 957960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginExecute(int currentFrameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentFrameIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_BeginExecute_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0001A0E0 File Offset: 0x000182E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957962, XrefRangeEnd = 957966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndExecute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_EndExecute_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0001A114 File Offset: 0x00018314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957966, XrefRangeEnd = 957970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckHandleValidity([In] ref ResourceHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &res;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_CheckHandleValidity_Private_Void_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0001A154 File Offset: 0x00018354
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 957971, RefRangeEnd = 957982, XrefRangeStart = 957970, XrefRangeEnd = 957971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckHandleValidity(RenderGraphResourceType type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_CheckHandleValidity_Private_Void_RenderGraphResourceType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0001A1A0 File Offset: 0x000183A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 957997, RefRangeEnd = 958004, XrefRangeStart = 957982, XrefRangeEnd = 957997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementWriteCount([In] ref ResourceHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &res;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_IncrementWriteCount_Internal_Void_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0001A1E0 File Offset: 0x000183E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958004, XrefRangeEnd = 958019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRenderGraphResourceName([In] ref ResourceHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &res;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_GetRenderGraphResourceName_Internal_String_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0001A224 File Offset: 0x00018424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 958025, RefRangeEnd = 958026, XrefRangeStart = 958019, XrefRangeEnd = 958025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRenderGraphResourceName(RenderGraphResourceType type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_GetRenderGraphResourceName_Internal_String_RenderGraphResourceType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0001A278 File Offset: 0x00018478
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 958039, RefRangeEnd = 958043, XrefRangeStart = 958026, XrefRangeEnd = 958039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRenderGraphResourceImported([In] ref ResourceHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &res;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_IsRenderGraphResourceImported_Internal_Boolean_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0001A2C4 File Offset: 0x000184C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 958044, RefRangeEnd = 958045, XrefRangeStart = 958043, XrefRangeEnd = 958044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRenderGraphResourceShared(RenderGraphResourceType type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_IsRenderGraphResourceShared_Internal_Boolean_RenderGraphResourceType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0001A31C File Offset: 0x0001851C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 958060, RefRangeEnd = 958061, XrefRangeStart = 958045, XrefRangeEnd = 958060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGraphicsResourceCreated([In] ref ResourceHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &res;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_IsGraphicsResourceCreated_Internal_Boolean_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0001A368 File Offset: 0x00018568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958061, XrefRangeEnd = 958069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRendererListCreated([In] ref RendererListHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &res;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_IsRendererListCreated_Internal_Boolean_byref_RendererListHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0001A3B4 File Offset: 0x000185B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 958073, RefRangeEnd = 958074, XrefRangeStart = 958069, XrefRangeEnd = 958073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRenderGraphResourceImported(RenderGraphResourceType type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_IsRenderGraphResourceImported_Internal_Boolean_RenderGraphResourceType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0001A40C File Offset: 0x0001860C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958074, XrefRangeEnd = 958087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRenderGraphResourceTransientIndex([In] ref ResourceHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &res;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_GetRenderGraphResourceTransientIndex_Internal_Int32_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0001A458 File Offset: 0x00018658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958087, XrefRangeEnd = 958096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle ImportTexture(RTHandle rt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0001A4A8 File Offset: 0x000186A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 958113, RefRangeEnd = 958114, XrefRangeStart = 958096, XrefRangeEnd = 958113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle CreateSharedTexture([In] ref TextureDesc desc, bool explicitRelease)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref explicitRelease;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_CreateSharedTexture_Internal_TextureHandle_byref_TextureDesc_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0001A504 File Offset: 0x00018704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958114, XrefRangeEnd = 958134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSharedTextureDesc(TextureHandle texture, [In] ref TextureDesc desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref texture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_RefreshSharedTextureDesc_Internal_Void_TextureHandle_byref_TextureDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0001A558 File Offset: 0x00018758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958134, XrefRangeEnd = 958154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseSharedTexture(TextureHandle texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref texture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_ReleaseSharedTexture_Internal_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0001A598 File Offset: 0x00018798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958154, XrefRangeEnd = 958172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle ImportBackbuffer(RenderTargetIdentifier rt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_ImportBackbuffer_Internal_TextureHandle_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0001A5E4 File Offset: 0x000187E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 958181, RefRangeEnd = 958186, XrefRangeStart = 958172, XrefRangeEnd = 958181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle CreateTexture([In] ref TextureDesc desc, int transientPassIndex = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transientPassIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_CreateTexture_Internal_TextureHandle_byref_TextureDesc_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0001A640 File Offset: 0x00018840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958186, XrefRangeEnd = 958187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetResourceCount(RenderGraphResourceType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_GetResourceCount_Internal_Int32_RenderGraphResourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0001A68C File Offset: 0x0001888C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958187, XrefRangeEnd = 958188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTextureResourceCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_GetTextureResourceCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0001A6C8 File Offset: 0x000188C8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 958198, RefRangeEnd = 958206, XrefRangeStart = 958188, XrefRangeEnd = 958198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureResource GetTextureResource([In] ref ResourceHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_GetTextureResource_Internal_TextureResource_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextureResource>(intPtr3) : null;
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0001A714 File Offset: 0x00018914
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 958217, RefRangeEnd = 958220, XrefRangeStart = 958206, XrefRangeEnd = 958217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureDesc GetTextureResourceDesc([In] ref ResourceHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_GetTextureResourceDesc_Internal_TextureDesc_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TextureDesc(intPtr);
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0001A758 File Offset: 0x00018958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958220, XrefRangeEnd = 958225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererListHandle CreateRendererList([In] ref RendererListDesc desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_CreateRendererList_Internal_RendererListHandle_byref_RendererListDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0001A7A8 File Offset: 0x000189A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958225, XrefRangeEnd = 958234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_ImportComputeBuffer_Internal_ComputeBufferHandle_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0001A7F8 File Offset: 0x000189F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 958243, RefRangeEnd = 958247, XrefRangeStart = 958234, XrefRangeEnd = 958243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferHandle CreateComputeBuffer([In] ref ComputeBufferDesc desc, int transientPassIndex = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transientPassIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_CreateComputeBuffer_Internal_ComputeBufferHandle_byref_ComputeBufferDesc_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0001A854 File Offset: 0x00018A54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 958258, RefRangeEnd = 958261, XrefRangeStart = 958247, XrefRangeEnd = 958258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferDesc GetComputeBufferResourceDesc([In] ref ResourceHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_GetComputeBufferResourceDesc_Internal_ComputeBufferDesc_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ComputeBufferDesc(intPtr);
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0001A898 File Offset: 0x00018A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958261, XrefRangeEnd = 958262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetComputeBufferResourceCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_GetComputeBufferResourceCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0001A8D4 File Offset: 0x00018AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958262, XrefRangeEnd = 958272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferResource GetComputeBufferResource([In] ref ResourceHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_GetComputeBufferResource_Private_ComputeBufferResource_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ComputeBufferResource>(intPtr3) : null;
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0001A920 File Offset: 0x00018B20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 958275, RefRangeEnd = 958276, XrefRangeStart = 958272, XrefRangeEnd = 958275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSharedResourceLastFrameIndex(int type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_UpdateSharedResourceLastFrameIndex_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0001A96C File Offset: 0x00018B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958276, XrefRangeEnd = 958281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManageSharedRenderGraphResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_ManageSharedRenderGraphResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0001A9A0 File Offset: 0x00018BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 958291, RefRangeEnd = 958293, XrefRangeStart = 958281, XrefRangeEnd = 958291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CreatePooledResource(RenderGraphContext rgContext, int type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_CreatePooledResource_Internal_Boolean_RenderGraphContext_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0001AA0C File Offset: 0x00018C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958293, XrefRangeEnd = 958300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CreatePooledResource(RenderGraphContext rgContext, ResourceHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_CreatePooledResource_Internal_Boolean_RenderGraphContext_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0001AA68 File Offset: 0x00018C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958300, XrefRangeEnd = 958317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CreateTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_CreateTextureCallback_Private_Boolean_RenderGraphContext_IRenderGraphResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0001AAC8 File Offset: 0x00018CC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 958320, RefRangeEnd = 958323, XrefRangeStart = 958317, XrefRangeEnd = 958320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleasePooledResource(RenderGraphContext rgContext, int type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_ReleasePooledResource_Internal_Void_RenderGraphContext_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0001AB28 File Offset: 0x00018D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958323, XrefRangeEnd = 958330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleasePooledResource(RenderGraphContext rgContext, ResourceHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_ReleasePooledResource_Internal_Void_RenderGraphContext_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0001AB78 File Offset: 0x00018D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958330, XrefRangeEnd = 958345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_ReleaseTextureCallback_Private_Void_RenderGraphContext_IRenderGraphResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0001ABCC File Offset: 0x00018DCC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateTextureDesc([In] ref TextureDesc desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_ValidateTextureDesc_Private_Void_byref_TextureDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0001AC10 File Offset: 0x00018E10
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateRendererListDesc([In] ref RendererListDesc desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_ValidateRendererListDesc_Private_Void_byref_RendererListDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0001AC54 File Offset: 0x00018E54
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateComputeBufferDesc([In] ref ComputeBufferDesc desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_ValidateComputeBufferDesc_Private_Void_byref_ComputeBufferDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0001AC98 File Offset: 0x00018E98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 958374, RefRangeEnd = 958377, XrefRangeStart = 958345, XrefRangeEnd = 958374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererLists);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref manualDispatch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_CreateRendererLists_Internal_Void_List_1_RendererListHandle_ScriptableRenderContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0001ACF8 File Offset: 0x00018EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958377, XrefRangeEnd = 958385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool onException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onException;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0001AD38 File Offset: 0x00018F38
		[CallerCount(0)]
		public unsafe void PurgeUnusedGraphicsResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_PurgeUnusedGraphicsResources_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0001AD6C File Offset: 0x00018F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958385, XrefRangeEnd = 958394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0001ADA0 File Offset: 0x00018FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958394, XrefRangeEnd = 958400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushLogs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_FlushLogs_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0001ADD4 File Offset: 0x00018FD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 958416, RefRangeEnd = 958418, XrefRangeStart = 958400, XrefRangeEnd = 958416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.NativeMethodInfoPtr_LogResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00003563 File Offset: 0x00001763
		public RenderGraphResourceRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0001AE08 File Offset: 0x00019008
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0000356C File Offset: 0x0000176C
		public unsafe static int kSharedResourceLifetime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderGraphResourceRegistry.NativeFieldInfoPtr_kSharedResourceLifetime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderGraphResourceRegistry.NativeFieldInfoPtr_kSharedResourceLifetime, (void*)(&value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0001AE24 File Offset: 0x00019024
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0000357A File Offset: 0x0000177A
		public unsafe static RenderGraphResourceRegistry m_CurrentRegistry
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_CurrentRegistry, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphResourceRegistry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_CurrentRegistry, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0001AE4C File Offset: 0x0001904C
		// (set) Token: 0x0600037C RID: 892 RVA: 0x0000358C File Offset: 0x0000178C
		public unsafe Il2CppReferenceArray<RenderGraphResourceRegistry.RenderGraphResourcesData> m_RenderGraphResources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_RenderGraphResources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderGraphResourceRegistry.RenderGraphResourcesData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_RenderGraphResources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0001AE7C File Offset: 0x0001907C
		// (set) Token: 0x0600037E RID: 894 RVA: 0x000035AB File Offset: 0x000017AB
		public unsafe DynamicArray<RendererListResource> m_RendererListResources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_RendererListResources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicArray<RendererListResource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_RendererListResources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0001AEAC File Offset: 0x000190AC
		// (set) Token: 0x06000380 RID: 896 RVA: 0x000035CA File Offset: 0x000017CA
		public unsafe RenderGraphDebugParams m_RenderGraphDebug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_RenderGraphDebug);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphDebugParams>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_RenderGraphDebug), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0001AEDC File Offset: 0x000190DC
		// (set) Token: 0x06000382 RID: 898 RVA: 0x000035E9 File Offset: 0x000017E9
		public unsafe RenderGraphLogger m_ResourceLogger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_ResourceLogger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphLogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_ResourceLogger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0001AF0C File Offset: 0x0001910C
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00003608 File Offset: 0x00001808
		public unsafe RenderGraphLogger m_FrameInformationLogger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_FrameInformationLogger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphLogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_FrameInformationLogger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0001AF3C File Offset: 0x0001913C
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00003627 File Offset: 0x00001827
		public unsafe int m_CurrentFrameIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_CurrentFrameIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_CurrentFrameIndex)) = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0001AF64 File Offset: 0x00019164
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00003642 File Offset: 0x00001842
		public unsafe int m_ExecutionCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_ExecutionCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_ExecutionCount)) = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0001AF8C File Offset: 0x0001918C
		// (set) Token: 0x0600038A RID: 906 RVA: 0x0000365D File Offset: 0x0000185D
		public unsafe RTHandle m_CurrentBackbuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_CurrentBackbuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_CurrentBackbuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0001AFBC File Offset: 0x000191BC
		// (set) Token: 0x0600038C RID: 908 RVA: 0x0000367C File Offset: 0x0000187C
		public unsafe static int kInitialRendererListCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderGraphResourceRegistry.NativeFieldInfoPtr_kInitialRendererListCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderGraphResourceRegistry.NativeFieldInfoPtr_kInitialRendererListCount, (void*)(&value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600038D RID: 909 RVA: 0x0001AFD8 File Offset: 0x000191D8
		// (set) Token: 0x0600038E RID: 910 RVA: 0x0000368A File Offset: 0x0000188A
		public unsafe List<RendererList> m_ActiveRendererLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_ActiveRendererLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RendererList>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.NativeFieldInfoPtr_m_ActiveRendererLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_kSharedResourceLifetime;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentRegistry;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderGraphResources;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr_m_RendererListResources;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderGraphDebug;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourceLogger;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameInformationLogger;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFrameIndex;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutionCount;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentBackbuffer;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr_kInitialRendererListCount;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveRendererLists;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Internal_Static_get_RenderGraphResourceRegistry_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_set_current_Internal_Static_set_Void_RenderGraphResourceRegistry_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Internal_RTHandle_byref_TextureHandle_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_TextureNeedsFallback_Internal_Boolean_byref_TextureHandle_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_GetRendererList_Internal_RendererList_byref_RendererListHandle_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_GetComputeBuffer_Internal_ComputeBuffer_byref_ComputeBufferHandle_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RenderGraphDebugParams_RenderGraphLogger_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_BeginRenderGraph_Internal_Void_Int32_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecute_Internal_Void_Int32_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_EndExecute_Internal_Void_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_CheckHandleValidity_Private_Void_byref_ResourceHandle_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_CheckHandleValidity_Private_Void_RenderGraphResourceType_Int32_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_IncrementWriteCount_Internal_Void_byref_ResourceHandle_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderGraphResourceName_Internal_String_byref_ResourceHandle_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderGraphResourceName_Internal_String_RenderGraphResourceType_Int32_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderGraphResourceImported_Internal_Boolean_byref_ResourceHandle_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderGraphResourceShared_Internal_Boolean_RenderGraphResourceType_Int32_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_IsGraphicsResourceCreated_Internal_Boolean_byref_ResourceHandle_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_IsRendererListCreated_Internal_Boolean_byref_RendererListHandle_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderGraphResourceImported_Internal_Boolean_RenderGraphResourceType_Int32_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderGraphResourceTransientIndex_Internal_Int32_byref_ResourceHandle_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_RTHandle_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_CreateSharedTexture_Internal_TextureHandle_byref_TextureDesc_Boolean_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSharedTextureDesc_Internal_Void_TextureHandle_byref_TextureDesc_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseSharedTexture_Internal_Void_TextureHandle_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_ImportBackbuffer_Internal_TextureHandle_RenderTargetIdentifier_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_CreateTexture_Internal_TextureHandle_byref_TextureDesc_Int32_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceCount_Internal_Int32_RenderGraphResourceType_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureResourceCount_Internal_Int32_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureResource_Internal_TextureResource_byref_ResourceHandle_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureResourceDesc_Internal_TextureDesc_byref_ResourceHandle_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_CreateRendererList_Internal_RendererListHandle_byref_RendererListDesc_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_ImportComputeBuffer_Internal_ComputeBufferHandle_ComputeBuffer_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_CreateComputeBuffer_Internal_ComputeBufferHandle_byref_ComputeBufferDesc_Int32_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_GetComputeBufferResourceDesc_Internal_ComputeBufferDesc_byref_ResourceHandle_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_GetComputeBufferResourceCount_Internal_Int32_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_GetComputeBufferResource_Private_ComputeBufferResource_byref_ResourceHandle_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSharedResourceLastFrameIndex_Internal_Void_Int32_Int32_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_ManageSharedRenderGraphResources_Private_Void_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_CreatePooledResource_Internal_Boolean_RenderGraphContext_Int32_Int32_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_CreatePooledResource_Internal_Boolean_RenderGraphContext_ResourceHandle_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextureCallback_Private_Boolean_RenderGraphContext_IRenderGraphResource_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePooledResource_Internal_Void_RenderGraphContext_Int32_Int32_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePooledResource_Internal_Void_RenderGraphContext_ResourceHandle_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseTextureCallback_Private_Void_RenderGraphContext_IRenderGraphResource_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_ValidateTextureDesc_Private_Void_byref_TextureDesc_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_ValidateRendererListDesc_Private_Void_byref_RendererListDesc_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_ValidateComputeBufferDesc_Private_Void_byref_ComputeBufferDesc_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_CreateRendererLists_Internal_Void_List_1_RendererListHandle_ScriptableRenderContext_Boolean_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_PurgeUnusedGraphicsResources_Internal_Void_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_FlushLogs_Internal_Void_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_LogResources_Private_Void_0;

		// Token: 0x02000159 RID: 345
		public sealed class ResourceCreateCallback : MulticastDelegate
		{
			// Token: 0x060015C6 RID: 5574 RVA: 0x0005E944 File Offset: 0x0005CB44
			// Note: this type is marked as 'beforefieldinit'.
			static ResourceCreateCallback()
			{
				Il2CppClassPointerStore<RenderGraphResourceRegistry.ResourceCreateCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "ResourceCreateCallback");
				RenderGraphResourceRegistry.ResourceCreateCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry.ResourceCreateCallback>.NativeClassPtr, 100663756);
				RenderGraphResourceRegistry.ResourceCreateCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_RenderGraphContext_IRenderGraphResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry.ResourceCreateCallback>.NativeClassPtr, 100663757);
				RenderGraphResourceRegistry.ResourceCreateCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraphContext_IRenderGraphResource_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry.ResourceCreateCallback>.NativeClassPtr, 100663758);
				RenderGraphResourceRegistry.ResourceCreateCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry.ResourceCreateCallback>.NativeClassPtr, 100663759);
			}

			// Token: 0x060015C7 RID: 5575 RVA: 0x0005E9B8 File Offset: 0x0005CBB8
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 957694, RefRangeEnd = 957707, XrefRangeStart = 957685, XrefRangeEnd = 957694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResourceCreateCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphResourceRegistry.ResourceCreateCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.ResourceCreateCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015C8 RID: 5576 RVA: 0x0005EA14 File Offset: 0x0005CC14
			[CallerCount(0)]
			public unsafe bool Invoke(RenderGraphContext rgContext, IRenderGraphResource res)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.ResourceCreateCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_RenderGraphContext_IRenderGraphResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060015C9 RID: 5577 RVA: 0x0005EA74 File Offset: 0x0005CC74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(RenderGraphContext rgContext, IRenderGraphResource res, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(res);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.ResourceCreateCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraphContext_IRenderGraphResource_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060015CA RID: 5578 RVA: 0x0005EAFC File Offset: 0x0005CCFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.ResourceCreateCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060015CB RID: 5579 RVA: 0x0000B071 File Offset: 0x00009271
			public ResourceCreateCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060015CC RID: 5580 RVA: 0x0000B07A File Offset: 0x0000927A
			public static implicit operator RenderGraphResourceRegistry.ResourceCreateCallback(Func<RenderGraphContext, IRenderGraphResource, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<RenderGraphResourceRegistry.ResourceCreateCallback>(A_0);
			}

			// Token: 0x060015CD RID: 5581 RVA: 0x0000B082 File Offset: 0x00009282
			public static RenderGraphResourceRegistry.ResourceCreateCallback operator +(RenderGraphResourceRegistry.ResourceCreateCallback A_0, RenderGraphResourceRegistry.ResourceCreateCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RenderGraphResourceRegistry.ResourceCreateCallback>();
			}

			// Token: 0x060015CE RID: 5582 RVA: 0x0000B090 File Offset: 0x00009290
			public static RenderGraphResourceRegistry.ResourceCreateCallback operator -(RenderGraphResourceRegistry.ResourceCreateCallback A_0, RenderGraphResourceRegistry.ResourceCreateCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RenderGraphResourceRegistry.ResourceCreateCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000FE0 RID: 4064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000FE1 RID: 4065
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_RenderGraphContext_IRenderGraphResource_0;

			// Token: 0x04000FE2 RID: 4066
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraphContext_IRenderGraphResource_AsyncCallback_Object_0;

			// Token: 0x04000FE3 RID: 4067
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
		}

		// Token: 0x0200015A RID: 346
		public sealed class ResourceCallback : MulticastDelegate
		{
			// Token: 0x060015CF RID: 5583 RVA: 0x0005EB4C File Offset: 0x0005CD4C
			// Note: this type is marked as 'beforefieldinit'.
			static ResourceCallback()
			{
				Il2CppClassPointerStore<RenderGraphResourceRegistry.ResourceCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "ResourceCallback");
				RenderGraphResourceRegistry.ResourceCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry.ResourceCallback>.NativeClassPtr, 100663760);
				RenderGraphResourceRegistry.ResourceCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraphContext_IRenderGraphResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry.ResourceCallback>.NativeClassPtr, 100663761);
				RenderGraphResourceRegistry.ResourceCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraphContext_IRenderGraphResource_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry.ResourceCallback>.NativeClassPtr, 100663762);
				RenderGraphResourceRegistry.ResourceCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry.ResourceCallback>.NativeClassPtr, 100663763);
			}

			// Token: 0x060015D0 RID: 5584 RVA: 0x0005EBC0 File Offset: 0x0005CDC0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResourceCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphResourceRegistry.ResourceCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.ResourceCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015D1 RID: 5585 RVA: 0x0005EC1C File Offset: 0x0005CE1C
			[CallerCount(0)]
			public unsafe void Invoke(RenderGraphContext rgContext, IRenderGraphResource res)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.ResourceCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraphContext_IRenderGraphResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015D2 RID: 5586 RVA: 0x0005EC70 File Offset: 0x0005CE70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(RenderGraphContext rgContext, IRenderGraphResource res, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgContext);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(res);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.ResourceCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraphContext_IRenderGraphResource_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060015D3 RID: 5587 RVA: 0x0005ECF8 File Offset: 0x0005CEF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.ResourceCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060015D4 RID: 5588 RVA: 0x0000B0A1 File Offset: 0x000092A1
			public ResourceCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060015D5 RID: 5589 RVA: 0x0000B0AA File Offset: 0x000092AA
			public static implicit operator RenderGraphResourceRegistry.ResourceCallback(Action<RenderGraphContext, IRenderGraphResource> A_0)
			{
				return DelegateSupport.ConvertDelegate<RenderGraphResourceRegistry.ResourceCallback>(A_0);
			}

			// Token: 0x060015D6 RID: 5590 RVA: 0x0000B0B2 File Offset: 0x000092B2
			public static RenderGraphResourceRegistry.ResourceCallback operator +(RenderGraphResourceRegistry.ResourceCallback A_0, RenderGraphResourceRegistry.ResourceCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RenderGraphResourceRegistry.ResourceCallback>();
			}

			// Token: 0x060015D7 RID: 5591 RVA: 0x0000B0C0 File Offset: 0x000092C0
			public static RenderGraphResourceRegistry.ResourceCallback operator -(RenderGraphResourceRegistry.ResourceCallback A_0, RenderGraphResourceRegistry.ResourceCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RenderGraphResourceRegistry.ResourceCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000FE4 RID: 4068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000FE5 RID: 4069
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraphContext_IRenderGraphResource_0;

			// Token: 0x04000FE6 RID: 4070
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraphContext_IRenderGraphResource_AsyncCallback_Object_0;

			// Token: 0x04000FE7 RID: 4071
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200015B RID: 347
		public class RenderGraphResourcesData : Object
		{
			// Token: 0x060015D8 RID: 5592 RVA: 0x0005ED3C File Offset: 0x0005CF3C
			// Note: this type is marked as 'beforefieldinit'.
			static RenderGraphResourcesData()
			{
				Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphResourceRegistry>.NativeClassPtr, "RenderGraphResourcesData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr);
				RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_resourceArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr, "resourceArray");
				RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_sharedResourcesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr, "sharedResourcesCount");
				RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr, "pool");
				RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_createResourceCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr, "createResourceCallback");
				RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_releaseResourceCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr, "releaseResourceCallback");
				RenderGraphResourceRegistry.RenderGraphResourcesData.NativeMethodInfoPtr_Clear_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr, 100663764);
				RenderGraphResourceRegistry.RenderGraphResourcesData.NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr, 100663765);
				RenderGraphResourceRegistry.RenderGraphResourcesData.NativeMethodInfoPtr_PurgeUnusedGraphicsResources_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr, 100663766);
				RenderGraphResourceRegistry.RenderGraphResourcesData.NativeMethodInfoPtr_AddNewRenderGraphResource_Public_Int32_byref_ResType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr, 100663767);
				RenderGraphResourceRegistry.RenderGraphResourcesData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr, 100663768);
			}

			// Token: 0x060015D9 RID: 5593 RVA: 0x0005EE30 File Offset: 0x0005D030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957707, XrefRangeEnd = 957711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear(bool onException, int frameIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref onException;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeMethodInfoPtr_Clear_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015DA RID: 5594 RVA: 0x0005EE7C File Offset: 0x0005D07C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957711, XrefRangeEnd = 957715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Cleanup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015DB RID: 5595 RVA: 0x0005EEB0 File Offset: 0x0005D0B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957715, XrefRangeEnd = 957716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void PurgeUnusedGraphicsResources(int frameIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref frameIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeMethodInfoPtr_PurgeUnusedGraphicsResources_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060015DC RID: 5596 RVA: 0x0005EEF0 File Offset: 0x0005D0F0
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 957741, RefRangeEnd = 957750, XrefRangeStart = 957716, XrefRangeEnd = 957741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int AddNewRenderGraphResource<ResType>(out ResType outRes, bool pooledResource = true) where ResType : IRenderGraphResource, new()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr2;
					if (!typeof(ResType).IsValueType)
					{
						intPtr = 0;
						intPtr2 = &intPtr;
					}
					else
					{
						intPtr2 = ref outRes;
					}
					ptr2 = intPtr2;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pooledResource;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.RenderGraphResourcesData.MethodInfoStoreGeneric_AddNewRenderGraphResource_Public_Int32_byref_ResType_Boolean_0<ResType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(ResType).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					outRes = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<ResType>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x060015DD RID: 5597 RVA: 0x0005EF88 File Offset: 0x0005D188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957750, XrefRangeEnd = 957758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RenderGraphResourcesData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015DE RID: 5598 RVA: 0x0000B0D1 File Offset: 0x000092D1
			public RenderGraphResourcesData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700061E RID: 1566
			// (get) Token: 0x060015DF RID: 5599 RVA: 0x0005EFC4 File Offset: 0x0005D1C4
			// (set) Token: 0x060015E0 RID: 5600 RVA: 0x0000B0DA File Offset: 0x000092DA
			public unsafe DynamicArray<IRenderGraphResource> resourceArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_resourceArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicArray<IRenderGraphResource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_resourceArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x060015E1 RID: 5601 RVA: 0x0005EFF4 File Offset: 0x0005D1F4
			// (set) Token: 0x060015E2 RID: 5602 RVA: 0x0000B0F9 File Offset: 0x000092F9
			public unsafe int sharedResourcesCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_sharedResourcesCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_sharedResourcesCount)) = value;
				}
			}

			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x060015E3 RID: 5603 RVA: 0x0005F01C File Offset: 0x0005D21C
			// (set) Token: 0x060015E4 RID: 5604 RVA: 0x0000B114 File Offset: 0x00009314
			public unsafe IRenderGraphResourcePool pool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_pool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IRenderGraphResourcePool>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x060015E5 RID: 5605 RVA: 0x0005F04C File Offset: 0x0005D24C
			// (set) Token: 0x060015E6 RID: 5606 RVA: 0x0000B133 File Offset: 0x00009333
			public unsafe RenderGraphResourceRegistry.ResourceCreateCallback createResourceCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_createResourceCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphResourceRegistry.ResourceCreateCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_createResourceCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000622 RID: 1570
			// (get) Token: 0x060015E7 RID: 5607 RVA: 0x0005F07C File Offset: 0x0005D27C
			// (set) Token: 0x060015E8 RID: 5608 RVA: 0x0000B152 File Offset: 0x00009352
			public unsafe RenderGraphResourceRegistry.ResourceCallback releaseResourceCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_releaseResourceCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphResourceRegistry.ResourceCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeFieldInfoPtr_releaseResourceCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FE8 RID: 4072
			private static readonly IntPtr NativeFieldInfoPtr_resourceArray;

			// Token: 0x04000FE9 RID: 4073
			private static readonly IntPtr NativeFieldInfoPtr_sharedResourcesCount;

			// Token: 0x04000FEA RID: 4074
			private static readonly IntPtr NativeFieldInfoPtr_pool;

			// Token: 0x04000FEB RID: 4075
			private static readonly IntPtr NativeFieldInfoPtr_createResourceCallback;

			// Token: 0x04000FEC RID: 4076
			private static readonly IntPtr NativeFieldInfoPtr_releaseResourceCallback;

			// Token: 0x04000FED RID: 4077
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_Boolean_Int32_0;

			// Token: 0x04000FEE RID: 4078
			private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

			// Token: 0x04000FEF RID: 4079
			private static readonly IntPtr NativeMethodInfoPtr_PurgeUnusedGraphicsResources_Public_Void_Int32_0;

			// Token: 0x04000FF0 RID: 4080
			private static readonly IntPtr NativeMethodInfoPtr_AddNewRenderGraphResource_Public_Int32_byref_ResType_Boolean_0;

			// Token: 0x04000FF1 RID: 4081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000226 RID: 550
			private sealed class MethodInfoStoreGeneric_AddNewRenderGraphResource_Public_Int32_byref_ResType_Boolean_0<ResType>
			{
				// Token: 0x040013F8 RID: 5112
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderGraphResourceRegistry.RenderGraphResourcesData.NativeMethodInfoPtr_AddNewRenderGraphResource_Public_Int32_byref_ResType_Boolean_0, Il2CppClassPointerStore<RenderGraphResourceRegistry.RenderGraphResourcesData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ResType>.NativeClassPtr)) }))));
			}
		}
	}
}
