using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000017 RID: 23
	public sealed class RenderGraphBuilder : ValueType
	{
		// Token: 0x06000222 RID: 546 RVA: 0x00015284 File Offset: 0x00013484
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphBuilder()
		{
			Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr);
			RenderGraphBuilder.NativeFieldInfoPtr_m_RenderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, "m_RenderPass");
			RenderGraphBuilder.NativeFieldInfoPtr_m_Resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, "m_Resources");
			RenderGraphBuilder.NativeFieldInfoPtr_m_RenderGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, "m_RenderGraph");
			RenderGraphBuilder.NativeFieldInfoPtr_m_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, "m_Disposed");
			RenderGraphBuilder.NativeMethodInfoPtr_UseColorBuffer_Public_TextureHandle_byref_TextureHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663540);
			RenderGraphBuilder.NativeMethodInfoPtr_UseDepthBuffer_Public_TextureHandle_byref_TextureHandle_DepthAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663541);
			RenderGraphBuilder.NativeMethodInfoPtr_ReadTexture_Public_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663542);
			RenderGraphBuilder.NativeMethodInfoPtr_WriteTexture_Public_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663543);
			RenderGraphBuilder.NativeMethodInfoPtr_ReadWriteTexture_Public_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663544);
			RenderGraphBuilder.NativeMethodInfoPtr_CreateTransientTexture_Public_TextureHandle_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663545);
			RenderGraphBuilder.NativeMethodInfoPtr_CreateTransientTexture_Public_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663546);
			RenderGraphBuilder.NativeMethodInfoPtr_UseRendererList_Public_RendererListHandle_byref_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663547);
			RenderGraphBuilder.NativeMethodInfoPtr_ReadComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663548);
			RenderGraphBuilder.NativeMethodInfoPtr_WriteComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663549);
			RenderGraphBuilder.NativeMethodInfoPtr_CreateTransientComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663550);
			RenderGraphBuilder.NativeMethodInfoPtr_CreateTransientComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663551);
			RenderGraphBuilder.NativeMethodInfoPtr_SetRenderFunc_Public_Void_RenderFunc_1_PassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663552);
			RenderGraphBuilder.NativeMethodInfoPtr_EnableAsyncCompute_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663553);
			RenderGraphBuilder.NativeMethodInfoPtr_AllowPassCulling_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663554);
			RenderGraphBuilder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663555);
			RenderGraphBuilder.NativeMethodInfoPtr_AllowRendererListCulling_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663556);
			RenderGraphBuilder.NativeMethodInfoPtr_DependsOn_Public_RendererListHandle_byref_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663557);
			RenderGraphBuilder.NativeMethodInfoPtr__ctor_Internal_Void_RenderGraphPass_RenderGraphResourceRegistry_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663558);
			RenderGraphBuilder.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663559);
			RenderGraphBuilder.NativeMethodInfoPtr_CheckResource_Private_Void_byref_ResourceHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663560);
			RenderGraphBuilder.NativeMethodInfoPtr_GenerateDebugData_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr, 100663561);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000154BC File Offset: 0x000136BC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 956577, RefRangeEnd = 956599, XrefRangeStart = 956571, XrefRangeEnd = 956577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle UseColorBuffer([In] ref TextureHandle input, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_UseColorBuffer_Public_TextureHandle_byref_TextureHandle_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00015518 File Offset: 0x00013718
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 956606, RefRangeEnd = 956625, XrefRangeStart = 956599, XrefRangeEnd = 956606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle UseDepthBuffer([In] ref TextureHandle input, DepthAccess flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_UseDepthBuffer_Public_TextureHandle_byref_TextureHandle_DepthAccess_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00015574 File Offset: 0x00013774
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 956632, RefRangeEnd = 956647, XrefRangeStart = 956625, XrefRangeEnd = 956632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle ReadTexture([In] ref TextureHandle input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_ReadTexture_Public_TextureHandle_byref_TextureHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000155C4 File Offset: 0x000137C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956647, XrefRangeEnd = 956649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle WriteTexture([In] ref TextureHandle input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_WriteTexture_Public_TextureHandle_byref_TextureHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00015614 File Offset: 0x00013814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956649, XrefRangeEnd = 956652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle ReadWriteTexture([In] ref TextureHandle input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_ReadWriteTexture_Public_TextureHandle_byref_TextureHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00015664 File Offset: 0x00013864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956652, XrefRangeEnd = 956654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle CreateTransientTexture([In] ref TextureDesc desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_CreateTransientTexture_Public_TextureHandle_byref_TextureDesc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000156B8 File Offset: 0x000138B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956654, XrefRangeEnd = 956657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle CreateTransientTexture([In] ref TextureHandle texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &texture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_CreateTransientTexture_Public_TextureHandle_byref_TextureHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00015708 File Offset: 0x00013908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956657, XrefRangeEnd = 956658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererListHandle UseRendererList([In] ref RendererListHandle input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_UseRendererList_Public_RendererListHandle_byref_RendererListHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00015758 File Offset: 0x00013958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956658, XrefRangeEnd = 956659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferHandle ReadComputeBuffer([In] ref ComputeBufferHandle input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_ReadComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000157A8 File Offset: 0x000139A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956659, XrefRangeEnd = 956661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferHandle WriteComputeBuffer([In] ref ComputeBufferHandle input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_WriteComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000157F8 File Offset: 0x000139F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956661, XrefRangeEnd = 956663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferHandle CreateTransientComputeBuffer([In] ref ComputeBufferDesc desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_CreateTransientComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferDesc_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0001584C File Offset: 0x00013A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956663, XrefRangeEnd = 956666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBufferHandle CreateTransientComputeBuffer([In] ref ComputeBufferHandle computebuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &computebuffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_CreateTransientComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0001589C File Offset: 0x00013A9C
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 956675, RefRangeEnd = 956710, XrefRangeStart = 956666, XrefRangeEnd = 956675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc) where PassData : class, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderFunc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.MethodInfoStoreGeneric_SetRenderFunc_Public_Void_RenderFunc_1_PassData_0<PassData>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000158E4 File Offset: 0x00013AE4
		[CallerCount(0)]
		public unsafe void EnableAsyncCompute(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_EnableAsyncCompute_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00015928 File Offset: 0x00013B28
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 956710, RefRangeEnd = 956738, XrefRangeStart = 956710, XrefRangeEnd = 956710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllowPassCulling(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_AllowPassCulling_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0001596C File Offset: 0x00013B6C
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 956740, RefRangeEnd = 956806, XrefRangeStart = 956738, XrefRangeEnd = 956740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000159A4 File Offset: 0x00013BA4
		[CallerCount(0)]
		public unsafe void AllowRendererListCulling(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_AllowRendererListCulling_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000159E8 File Offset: 0x00013BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererListHandle DependsOn([In] ref RendererListHandle input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_DependsOn_Public_RendererListHandle_byref_RendererListHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00015A38 File Offset: 0x00013C38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 956809, RefRangeEnd = 956811, XrefRangeStart = 956806, XrefRangeEnd = 956809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphBuilder(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderPass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resources);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr__ctor_Internal_Void_RenderGraphPass_RenderGraphResourceRegistry_RenderGraph_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00015AAC File Offset: 0x00013CAC
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 956740, RefRangeEnd = 956806, XrefRangeStart = 956740, XrefRangeEnd = 956806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00015AF0 File Offset: 0x00013CF0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckResource([In] ref ResourceHandle res, bool dontCheckTransientReadWrite = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &res;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dontCheckTransientReadWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_CheckResource_Private_Void_byref_ResourceHandle_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00015B44 File Offset: 0x00013D44
		[CallerCount(0)]
		public unsafe void GenerateDebugData(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphBuilder.NativeMethodInfoPtr_GenerateDebugData_Internal_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002ED0 File Offset: 0x000010D0
		public RenderGraphBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002ED9 File Offset: 0x000010D9
		public RenderGraphBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr))
		{
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00015B88 File Offset: 0x00013D88
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00002EEB File Offset: 0x000010EB
		public unsafe RenderGraphPass m_RenderPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphBuilder.NativeFieldInfoPtr_m_RenderPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphBuilder.NativeFieldInfoPtr_m_RenderPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00015BB8 File Offset: 0x00013DB8
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00002F0A File Offset: 0x0000110A
		public unsafe RenderGraphResourceRegistry m_Resources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphBuilder.NativeFieldInfoPtr_m_Resources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraphResourceRegistry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphBuilder.NativeFieldInfoPtr_m_Resources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00015BE8 File Offset: 0x00013DE8
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00002F29 File Offset: 0x00001129
		public unsafe RenderGraph m_RenderGraph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphBuilder.NativeFieldInfoPtr_m_RenderGraph);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraph>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphBuilder.NativeFieldInfoPtr_m_RenderGraph), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00015C18 File Offset: 0x00013E18
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002F48 File Offset: 0x00001148
		public unsafe bool m_Disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphBuilder.NativeFieldInfoPtr_m_Disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphBuilder.NativeFieldInfoPtr_m_Disposed)) = value;
			}
		}

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderPass;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_m_Resources;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderGraph;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_m_Disposed;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_UseColorBuffer_Public_TextureHandle_byref_TextureHandle_Int32_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_UseDepthBuffer_Public_TextureHandle_byref_TextureHandle_DepthAccess_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_ReadTexture_Public_TextureHandle_byref_TextureHandle_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_WriteTexture_Public_TextureHandle_byref_TextureHandle_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_ReadWriteTexture_Public_TextureHandle_byref_TextureHandle_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_CreateTransientTexture_Public_TextureHandle_byref_TextureDesc_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_CreateTransientTexture_Public_TextureHandle_byref_TextureHandle_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_UseRendererList_Public_RendererListHandle_byref_RendererListHandle_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_ReadComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferHandle_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_WriteComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferHandle_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_CreateTransientComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferDesc_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_CreateTransientComputeBuffer_Public_ComputeBufferHandle_byref_ComputeBufferHandle_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderFunc_Public_Void_RenderFunc_1_PassData_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_EnableAsyncCompute_Public_Void_Boolean_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_AllowPassCulling_Public_Void_Boolean_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_AllowRendererListCulling_Public_Void_Boolean_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_DependsOn_Public_RendererListHandle_byref_RendererListHandle_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RenderGraphPass_RenderGraphResourceRegistry_RenderGraph_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_CheckResource_Private_Void_byref_ResourceHandle_Boolean_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_GenerateDebugData_Internal_Void_Boolean_0;

		// Token: 0x02000150 RID: 336
		private sealed class MethodInfoStoreGeneric_SetRenderFunc_Public_Void_RenderFunc_1_PassData_0<PassData>
		{
			// Token: 0x04000FC9 RID: 4041
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderGraphBuilder.NativeMethodInfoPtr_SetRenderFunc_Public_Void_RenderFunc_1_PassData_0, Il2CppClassPointerStore<RenderGraphBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
		}
	}
}
