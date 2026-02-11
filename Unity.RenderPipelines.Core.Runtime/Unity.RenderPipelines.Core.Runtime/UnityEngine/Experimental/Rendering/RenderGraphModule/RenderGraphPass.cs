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

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x0200001C RID: 28
	public class RenderGraphPass : Object
	{
		// Token: 0x060002A3 RID: 675 RVA: 0x00016FF4 File Offset: 0x000151F4
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphPass()
		{
			Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr);
			RenderGraphPass.NativeFieldInfoPtr__name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "<name>k__BackingField");
			RenderGraphPass.NativeFieldInfoPtr__index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "<index>k__BackingField");
			RenderGraphPass.NativeFieldInfoPtr__customSampler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "<customSampler>k__BackingField");
			RenderGraphPass.NativeFieldInfoPtr__enableAsyncCompute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "<enableAsyncCompute>k__BackingField");
			RenderGraphPass.NativeFieldInfoPtr__allowPassCulling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "<allowPassCulling>k__BackingField");
			RenderGraphPass.NativeFieldInfoPtr__depthBuffer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "<depthBuffer>k__BackingField");
			RenderGraphPass.NativeFieldInfoPtr__colorBuffers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "<colorBuffers>k__BackingField");
			RenderGraphPass.NativeFieldInfoPtr__colorBufferMaxIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "<colorBufferMaxIndex>k__BackingField");
			RenderGraphPass.NativeFieldInfoPtr__refCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "<refCount>k__BackingField");
			RenderGraphPass.NativeFieldInfoPtr__generateDebugData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "<generateDebugData>k__BackingField");
			RenderGraphPass.NativeFieldInfoPtr__allowRendererListCulling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "<allowRendererListCulling>k__BackingField");
			RenderGraphPass.NativeFieldInfoPtr_resourceReadLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "resourceReadLists");
			RenderGraphPass.NativeFieldInfoPtr_resourceWriteLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "resourceWriteLists");
			RenderGraphPass.NativeFieldInfoPtr_transientResourceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "transientResourceList");
			RenderGraphPass.NativeFieldInfoPtr_usedRendererListList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, "usedRendererListList");
			RenderGraphPass.NativeMethodInfoPtr_GetExecuteDelegate_Public_RenderFunc_1_PassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663613);
			RenderGraphPass.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663614);
			RenderGraphPass.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_RenderGraphObjectPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663615);
			RenderGraphPass.NativeMethodInfoPtr_HasRenderFunc_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663616);
			RenderGraphPass.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663617);
			RenderGraphPass.NativeMethodInfoPtr_set_name_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663618);
			RenderGraphPass.NativeMethodInfoPtr_get_index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663619);
			RenderGraphPass.NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663620);
			RenderGraphPass.NativeMethodInfoPtr_get_customSampler_Public_get_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663621);
			RenderGraphPass.NativeMethodInfoPtr_set_customSampler_Protected_set_Void_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663622);
			RenderGraphPass.NativeMethodInfoPtr_get_enableAsyncCompute_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663623);
			RenderGraphPass.NativeMethodInfoPtr_set_enableAsyncCompute_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663624);
			RenderGraphPass.NativeMethodInfoPtr_get_allowPassCulling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663625);
			RenderGraphPass.NativeMethodInfoPtr_set_allowPassCulling_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663626);
			RenderGraphPass.NativeMethodInfoPtr_get_depthBuffer_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663627);
			RenderGraphPass.NativeMethodInfoPtr_set_depthBuffer_Protected_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663628);
			RenderGraphPass.NativeMethodInfoPtr_get_colorBuffers_Public_get_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663629);
			RenderGraphPass.NativeMethodInfoPtr_set_colorBuffers_Protected_set_Void_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663630);
			RenderGraphPass.NativeMethodInfoPtr_get_colorBufferMaxIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663631);
			RenderGraphPass.NativeMethodInfoPtr_set_colorBufferMaxIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663632);
			RenderGraphPass.NativeMethodInfoPtr_get_refCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663633);
			RenderGraphPass.NativeMethodInfoPtr_set_refCount_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663634);
			RenderGraphPass.NativeMethodInfoPtr_get_generateDebugData_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663635);
			RenderGraphPass.NativeMethodInfoPtr_set_generateDebugData_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663636);
			RenderGraphPass.NativeMethodInfoPtr_get_allowRendererListCulling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663637);
			RenderGraphPass.NativeMethodInfoPtr_set_allowRendererListCulling_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663638);
			RenderGraphPass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663639);
			RenderGraphPass.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663640);
			RenderGraphPass.NativeMethodInfoPtr_AddResourceWrite_Public_Void_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663641);
			RenderGraphPass.NativeMethodInfoPtr_AddResourceRead_Public_Void_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663642);
			RenderGraphPass.NativeMethodInfoPtr_AddTransientResource_Public_Void_byref_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663643);
			RenderGraphPass.NativeMethodInfoPtr_UseRendererList_Public_Void_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663644);
			RenderGraphPass.NativeMethodInfoPtr_EnableAsyncCompute_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663645);
			RenderGraphPass.NativeMethodInfoPtr_AllowPassCulling_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663646);
			RenderGraphPass.NativeMethodInfoPtr_AllowRendererListCulling_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663647);
			RenderGraphPass.NativeMethodInfoPtr_GenerateDebugData_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663648);
			RenderGraphPass.NativeMethodInfoPtr_SetColorBuffer_Public_Void_TextureHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663649);
			RenderGraphPass.NativeMethodInfoPtr_SetDepthBuffer_Public_Void_TextureHandle_DepthAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr, 100663650);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00017448 File Offset: 0x00015648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 957205, RefRangeEnd = 957206, XrefRangeStart = 957202, XrefRangeEnd = 957205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderFunc<PassData> GetExecuteDelegate<PassData>() where PassData : class, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.MethodInfoStoreGeneric_GetExecuteDelegate_Public_RenderFunc_1_PassData_0<PassData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderFunc<PassData>>(intPtr3) : null;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00017488 File Offset: 0x00015688
		[CallerCount(0)]
		public unsafe virtual void Execute(RenderGraphContext renderGraphContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraphContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphPass.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_RenderGraphContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000174D8 File Offset: 0x000156D8
		[CallerCount(0)]
		public unsafe virtual void Release(RenderGraphObjectPool pool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphPass.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_RenderGraphObjectPool_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00017528 File Offset: 0x00015728
		[CallerCount(0)]
		public unsafe virtual bool HasRenderFunc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderGraphPass.NativeMethodInfoPtr_HasRenderFunc_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00017570 File Offset: 0x00015770
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x000175A8 File Offset: 0x000157A8
		public unsafe string name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_set_name_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002AA RID: 682 RVA: 0x000175EC File Offset: 0x000157EC
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00017628 File Offset: 0x00015828
		public unsafe int index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_get_index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00017668 File Offset: 0x00015868
		// (set) Token: 0x060002AD RID: 685 RVA: 0x000176A8 File Offset: 0x000158A8
		public unsafe ProfilingSampler customSampler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_get_customSampler_Public_get_ProfilingSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_set_customSampler_Protected_set_Void_ProfilingSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002AE RID: 686 RVA: 0x000176EC File Offset: 0x000158EC
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00017728 File Offset: 0x00015928
		public unsafe bool enableAsyncCompute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_get_enableAsyncCompute_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_set_enableAsyncCompute_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00017768 File Offset: 0x00015968
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x000177A4 File Offset: 0x000159A4
		public unsafe bool allowPassCulling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_get_allowPassCulling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_set_allowPassCulling_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x000177E4 File Offset: 0x000159E4
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00017820 File Offset: 0x00015A20
		public unsafe TextureHandle depthBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_get_depthBuffer_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_set_depthBuffer_Protected_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00017860 File Offset: 0x00015A60
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000178A0 File Offset: 0x00015AA0
		public unsafe Il2CppStructArray<TextureHandle> colorBuffers
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_get_colorBuffers_Public_get_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_set_colorBuffers_Protected_set_Void_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x000178E4 File Offset: 0x00015AE4
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00017920 File Offset: 0x00015B20
		public unsafe int colorBufferMaxIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_get_colorBufferMaxIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_set_colorBufferMaxIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00017960 File Offset: 0x00015B60
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0001799C File Offset: 0x00015B9C
		public unsafe int refCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_get_refCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_set_refCount_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002BA RID: 698 RVA: 0x000179DC File Offset: 0x00015BDC
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00017A18 File Offset: 0x00015C18
		public unsafe bool generateDebugData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_get_generateDebugData_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_set_generateDebugData_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00017A58 File Offset: 0x00015C58
		// (set) Token: 0x060002BD RID: 701 RVA: 0x00017A94 File Offset: 0x00015C94
		public unsafe bool allowRendererListCulling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_get_allowRendererListCulling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_set_allowRendererListCulling_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00017AD4 File Offset: 0x00015CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 957252, RefRangeEnd = 957253, XrefRangeStart = 957206, XrefRangeEnd = 957252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphPass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00017B10 File Offset: 0x00015D10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 957277, RefRangeEnd = 957279, XrefRangeStart = 957253, XrefRangeEnd = 957277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00017B44 File Offset: 0x00015D44
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 957288, RefRangeEnd = 957297, XrefRangeStart = 957279, XrefRangeEnd = 957288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddResourceWrite([In] ref ResourceHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &res;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_AddResourceWrite_Public_Void_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00017B84 File Offset: 0x00015D84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 957306, RefRangeEnd = 957311, XrefRangeStart = 957297, XrefRangeEnd = 957306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddResourceRead([In] ref ResourceHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &res;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_AddResourceRead_Public_Void_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00017BC4 File Offset: 0x00015DC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 957320, RefRangeEnd = 957324, XrefRangeStart = 957311, XrefRangeEnd = 957320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTransientResource([In] ref ResourceHandle res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &res;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_AddTransientResource_Public_Void_byref_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00017C04 File Offset: 0x00015E04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 957327, RefRangeEnd = 957329, XrefRangeStart = 957324, XrefRangeEnd = 957327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UseRendererList(RendererListHandle rendererList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rendererList;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_UseRendererList_Public_Void_RendererListHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00017C44 File Offset: 0x00015E44
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableAsyncCompute(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_EnableAsyncCompute_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00017C84 File Offset: 0x00015E84
		[CallerCount(0)]
		public unsafe void AllowPassCulling(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_AllowPassCulling_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00017CC4 File Offset: 0x00015EC4
		[CallerCount(0)]
		public unsafe void AllowRendererListCulling(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_AllowRendererListCulling_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00017D04 File Offset: 0x00015F04
		[CallerCount(0)]
		public unsafe void GenerateDebugData(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_GenerateDebugData_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00017D44 File Offset: 0x00015F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957329, XrefRangeEnd = 957334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColorBuffer(TextureHandle resource, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_SetColorBuffer_Public_Void_TextureHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00017D90 File Offset: 0x00015F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957334, XrefRangeEnd = 957336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDepthBuffer(TextureHandle resource, DepthAccess flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphPass.NativeMethodInfoPtr_SetDepthBuffer_Public_Void_TextureHandle_DepthAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003239 File Offset: 0x00001439
		public RenderGraphPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00017DDC File Offset: 0x00015FDC
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00003242 File Offset: 0x00001442
		public unsafe string _name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00017E04 File Offset: 0x00016004
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00003261 File Offset: 0x00001461
		public unsafe int _index_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__index_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__index_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00017E2C File Offset: 0x0001602C
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x0000327C File Offset: 0x0000147C
		public unsafe ProfilingSampler _customSampler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__customSampler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__customSampler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00017E5C File Offset: 0x0001605C
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000329B File Offset: 0x0000149B
		public unsafe bool _enableAsyncCompute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__enableAsyncCompute_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__enableAsyncCompute_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00017E84 File Offset: 0x00016084
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x000032B6 File Offset: 0x000014B6
		public unsafe bool _allowPassCulling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__allowPassCulling_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__allowPassCulling_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00017EAC File Offset: 0x000160AC
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x000032D1 File Offset: 0x000014D1
		public unsafe TextureHandle _depthBuffer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__depthBuffer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__depthBuffer_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00017ED4 File Offset: 0x000160D4
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x000032EC File Offset: 0x000014EC
		public unsafe Il2CppStructArray<TextureHandle> _colorBuffers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__colorBuffers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__colorBuffers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00017F04 File Offset: 0x00016104
		// (set) Token: 0x060002DA RID: 730 RVA: 0x0000330B File Offset: 0x0000150B
		public unsafe int _colorBufferMaxIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__colorBufferMaxIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__colorBufferMaxIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00017F2C File Offset: 0x0001612C
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00003326 File Offset: 0x00001526
		public unsafe int _refCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__refCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__refCount_k__BackingField)) = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00017F54 File Offset: 0x00016154
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00003341 File Offset: 0x00001541
		public unsafe bool _generateDebugData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__generateDebugData_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__generateDebugData_k__BackingField)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00017F7C File Offset: 0x0001617C
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x0000335C File Offset: 0x0000155C
		public unsafe bool _allowRendererListCulling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__allowRendererListCulling_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr__allowRendererListCulling_k__BackingField)) = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00017FA4 File Offset: 0x000161A4
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x00003377 File Offset: 0x00001577
		public unsafe Il2CppReferenceArray<List<ResourceHandle>> resourceReadLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr_resourceReadLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<ResourceHandle>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr_resourceReadLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00017FD4 File Offset: 0x000161D4
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00003396 File Offset: 0x00001596
		public unsafe Il2CppReferenceArray<List<ResourceHandle>> resourceWriteLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr_resourceWriteLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<ResourceHandle>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr_resourceWriteLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00018004 File Offset: 0x00016204
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x000033B5 File Offset: 0x000015B5
		public unsafe Il2CppReferenceArray<List<ResourceHandle>> transientResourceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr_transientResourceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<ResourceHandle>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr_transientResourceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00018034 File Offset: 0x00016234
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x000033D4 File Offset: 0x000015D4
		public unsafe List<RendererListHandle> usedRendererListList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr_usedRendererListList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RendererListHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphPass.NativeFieldInfoPtr_usedRendererListList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr__name_k__BackingField;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr__index_k__BackingField;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr__customSampler_k__BackingField;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr__enableAsyncCompute_k__BackingField;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr__allowPassCulling_k__BackingField;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr__depthBuffer_k__BackingField;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr__colorBuffers_k__BackingField;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr__colorBufferMaxIndex_k__BackingField;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr__refCount_k__BackingField;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr__generateDebugData_k__BackingField;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr__allowRendererListCulling_k__BackingField;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_resourceReadLists;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_resourceWriteLists;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_transientResourceList;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_usedRendererListList;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_GetExecuteDelegate_Public_RenderFunc_1_PassData_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_RenderGraphContext_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_RenderGraphObjectPool_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_HasRenderFunc_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Protected_set_Void_String_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_get_index_Public_get_Int32_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_get_customSampler_Public_get_ProfilingSampler_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_set_customSampler_Protected_set_Void_ProfilingSampler_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_get_enableAsyncCompute_Public_get_Boolean_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_set_enableAsyncCompute_Protected_set_Void_Boolean_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_get_allowPassCulling_Public_get_Boolean_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_set_allowPassCulling_Protected_set_Void_Boolean_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_get_depthBuffer_Public_get_TextureHandle_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_set_depthBuffer_Protected_set_Void_TextureHandle_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_get_colorBuffers_Public_get_Il2CppStructArray_1_TextureHandle_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_set_colorBuffers_Protected_set_Void_Il2CppStructArray_1_TextureHandle_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_get_colorBufferMaxIndex_Public_get_Int32_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_set_colorBufferMaxIndex_Protected_set_Void_Int32_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_get_refCount_Public_get_Int32_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_set_refCount_Protected_set_Void_Int32_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_get_generateDebugData_Public_get_Boolean_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_set_generateDebugData_Protected_set_Void_Boolean_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_get_allowRendererListCulling_Public_get_Boolean_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_set_allowRendererListCulling_Protected_set_Void_Boolean_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_AddResourceWrite_Public_Void_byref_ResourceHandle_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_AddResourceRead_Public_Void_byref_ResourceHandle_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_AddTransientResource_Public_Void_byref_ResourceHandle_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_UseRendererList_Public_Void_RendererListHandle_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_EnableAsyncCompute_Public_Void_Boolean_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_AllowPassCulling_Public_Void_Boolean_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_AllowRendererListCulling_Public_Void_Boolean_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_GenerateDebugData_Public_Void_Boolean_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_SetColorBuffer_Public_Void_TextureHandle_Int32_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_SetDepthBuffer_Public_Void_TextureHandle_DepthAccess_0;

		// Token: 0x02000156 RID: 342
		private sealed class MethodInfoStoreGeneric_GetExecuteDelegate_Public_RenderFunc_1_PassData_0<PassData>
		{
			// Token: 0x04000FD9 RID: 4057
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderGraphPass.NativeMethodInfoPtr_GetExecuteDelegate_Public_RenderFunc_1_PassData_0, Il2CppClassPointerStore<RenderGraphPass>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
		}
	}
}
