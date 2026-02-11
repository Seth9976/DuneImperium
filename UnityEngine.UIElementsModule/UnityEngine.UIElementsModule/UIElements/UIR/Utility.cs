using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.Rendering;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000243 RID: 579
	public class Utility : Object
	{
		// Token: 0x06002A8B RID: 10891 RVA: 0x000B9118 File Offset: 0x000B7318
		// Note: this type is marked as 'beforefieldinit'.
		static Utility()
		{
			Il2CppClassPointerStore<Utility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "Utility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utility>.NativeClassPtr);
			Utility.NativeFieldInfoPtr_GraphicsResourcesRecreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "GraphicsResourcesRecreate");
			Utility.NativeFieldInfoPtr_EngineUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "EngineUpdate");
			Utility.NativeFieldInfoPtr_FlushPendingResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "FlushPendingResources");
			Utility.NativeFieldInfoPtr_RegisterIntermediateRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "RegisterIntermediateRenderers");
			Utility.NativeFieldInfoPtr_RenderNodeAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "RenderNodeAdd");
			Utility.NativeFieldInfoPtr_RenderNodeExecute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "RenderNodeExecute");
			Utility.NativeFieldInfoPtr_RenderNodeCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "RenderNodeCleanup");
			Utility.NativeFieldInfoPtr_s_MarkerRaiseEngineUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "s_MarkerRaiseEngineUpdate");
			Utility.NativeMethodInfoPtr_SetVectorArray_Public_Static_Void_MaterialPropertyBlock_Int32_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669652);
			Utility.NativeMethodInfoPtr_add_GraphicsResourcesRecreate_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669653);
			Utility.NativeMethodInfoPtr_remove_GraphicsResourcesRecreate_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669654);
			Utility.NativeMethodInfoPtr_add_EngineUpdate_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669655);
			Utility.NativeMethodInfoPtr_remove_EngineUpdate_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669656);
			Utility.NativeMethodInfoPtr_add_FlushPendingResources_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669657);
			Utility.NativeMethodInfoPtr_remove_FlushPendingResources_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669658);
			Utility.NativeMethodInfoPtr_add_RegisterIntermediateRenderers_Public_Static_add_Void_Action_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669659);
			Utility.NativeMethodInfoPtr_remove_RegisterIntermediateRenderers_Public_Static_rem_Void_Action_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669660);
			Utility.NativeMethodInfoPtr_add_RenderNodeExecute_Public_Static_add_Void_Action_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669661);
			Utility.NativeMethodInfoPtr_remove_RenderNodeExecute_Public_Static_rem_Void_Action_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669662);
			Utility.NativeMethodInfoPtr_RaiseGraphicsResourcesRecreate_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669663);
			Utility.NativeMethodInfoPtr_RaiseEngineUpdate_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669664);
			Utility.NativeMethodInfoPtr_RaiseFlushPendingResources_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669665);
			Utility.NativeMethodInfoPtr_RaiseRegisterIntermediateRenderers_Internal_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669666);
			Utility.NativeMethodInfoPtr_RaiseRenderNodeAdd_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669667);
			Utility.NativeMethodInfoPtr_RaiseRenderNodeExecute_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669668);
			Utility.NativeMethodInfoPtr_RaiseRenderNodeCleanup_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669669);
			Utility.NativeMethodInfoPtr_AllocateBuffer_Private_Static_IntPtr_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669670);
			Utility.NativeMethodInfoPtr_FreeBuffer_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669671);
			Utility.NativeMethodInfoPtr_UpdateBufferRanges_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669672);
			Utility.NativeMethodInfoPtr_SetVectorArray_Private_Static_Void_MaterialPropertyBlock_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669673);
			Utility.NativeMethodInfoPtr_GetVertexDeclaration_Public_Static_IntPtr_Il2CppStructArray_1_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669674);
			Utility.NativeMethodInfoPtr_RegisterIntermediateRenderer_Public_Static_Void_Camera_Material_Matrix4x4_Bounds_Int32_Int32_Boolean_Int32_UInt64_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669675);
			Utility.NativeMethodInfoPtr_DrawRanges_Public_Static_Void_IntPtr_ptr_IntPtr_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669676);
			Utility.NativeMethodInfoPtr_SetPropertyBlock_Public_Static_Void_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669677);
			Utility.NativeMethodInfoPtr_SetScissorRect_Public_Static_Void_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669678);
			Utility.NativeMethodInfoPtr_DisableScissor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669679);
			Utility.NativeMethodInfoPtr_CreateStencilState_Public_Static_IntPtr_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669680);
			Utility.NativeMethodInfoPtr_SetStencilState_Public_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669681);
			Utility.NativeMethodInfoPtr_HasMappedBufferRange_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669682);
			Utility.NativeMethodInfoPtr_InsertCPUFence_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669683);
			Utility.NativeMethodInfoPtr_CPUFencePassed_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669684);
			Utility.NativeMethodInfoPtr_WaitForCPUFencePassed_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669685);
			Utility.NativeMethodInfoPtr_SyncRenderThread_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669686);
			Utility.NativeMethodInfoPtr_GetActiveViewport_Public_Static_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669687);
			Utility.NativeMethodInfoPtr_ProfileDrawChainBegin_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669688);
			Utility.NativeMethodInfoPtr_ProfileDrawChainEnd_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669689);
			Utility.NativeMethodInfoPtr_NotifyOfUIREvents_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669690);
			Utility.NativeMethodInfoPtr_GetUnityProjectionMatrix_Public_Static_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669691);
			Utility.NativeMethodInfoPtr_RegisterIntermediateRenderer_Injected_Private_Static_Void_Camera_Material_byref_Matrix4x4_byref_Bounds_Int32_Int32_Boolean_Int32_UInt64_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669693);
			Utility.NativeMethodInfoPtr_SetScissorRect_Injected_Private_Static_Void_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669694);
			Utility.NativeMethodInfoPtr_CreateStencilState_Injected_Private_Static_IntPtr_byref_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669695);
			Utility.NativeMethodInfoPtr_GetActiveViewport_Injected_Private_Static_Void_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669696);
			Utility.NativeMethodInfoPtr_GetUnityProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100669697);
			Utility.IsScissorEnabledDelegateField = IL2CPP.ResolveICall<Utility.IsScissorEnabledDelegate>("UnityEngine.UIElements.UIR.Utility::IsScissorEnabled");
			Utility.DebugIsMainThreadDelegateField = IL2CPP.ResolveICall<Utility.DebugIsMainThreadDelegate>("UnityEngine.UIElements.UIR.Utility::DebugIsMainThread");
			Utility.GetDeviceProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Utility.GetDeviceProjectionMatrix_InjectedDelegate>("UnityEngine.UIElements.UIR.Utility::GetDeviceProjectionMatrix_Injected");
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x000B959C File Offset: 0x000B779C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347802, RefRangeEnd = 347804, XrefRangeStart = 347795, XrefRangeEnd = 347802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetVectorArray<T>(MaterialPropertyBlock props, int name, NativeSlice<T> vector4s) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(props);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vector4s));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.MethodInfoStoreGeneric_SetVectorArray_Public_Static_Void_MaterialPropertyBlock_Int32_NativeSlice_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x000B95F8 File Offset: 0x000B77F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347804, XrefRangeEnd = 347817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_GraphicsResourcesRecreate(Action<bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_add_GraphicsResourcesRecreate_Public_Static_add_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x000B9630 File Offset: 0x000B7830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347817, XrefRangeEnd = 347830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_GraphicsResourcesRecreate(Action<bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_remove_GraphicsResourcesRecreate_Public_Static_rem_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x000B9668 File Offset: 0x000B7868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347830, XrefRangeEnd = 347841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_EngineUpdate(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_add_EngineUpdate_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x000B96A0 File Offset: 0x000B78A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347841, XrefRangeEnd = 347852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_EngineUpdate(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_remove_EngineUpdate_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x000B96D8 File Offset: 0x000B78D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347852, XrefRangeEnd = 347863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_FlushPendingResources(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_add_FlushPendingResources_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x000B9710 File Offset: 0x000B7910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347863, XrefRangeEnd = 347874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_FlushPendingResources(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_remove_FlushPendingResources_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x000B9748 File Offset: 0x000B7948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347874, XrefRangeEnd = 347887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_RegisterIntermediateRenderers(Action<Camera> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_add_RegisterIntermediateRenderers_Public_Static_add_Void_Action_1_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x000B9780 File Offset: 0x000B7980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347887, XrefRangeEnd = 347900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_RegisterIntermediateRenderers(Action<Camera> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_remove_RegisterIntermediateRenderers_Public_Static_rem_Void_Action_1_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x000B97B8 File Offset: 0x000B79B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347900, XrefRangeEnd = 347913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_RenderNodeExecute(Action<IntPtr> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_add_RenderNodeExecute_Public_Static_add_Void_Action_1_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x000B97F0 File Offset: 0x000B79F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347913, XrefRangeEnd = 347926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_RenderNodeExecute(Action<IntPtr> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_remove_RenderNodeExecute_Public_Static_rem_Void_Action_1_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x000B9828 File Offset: 0x000B7A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347926, XrefRangeEnd = 347930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseGraphicsResourcesRecreate(bool recreate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recreate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseGraphicsResourcesRecreate_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x000B985C File Offset: 0x000B7A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347930, XrefRangeEnd = 347936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseEngineUpdate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseEngineUpdate_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x000B9884 File Offset: 0x000B7A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347936, XrefRangeEnd = 347940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseFlushPendingResources()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseFlushPendingResources_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x000B98AC File Offset: 0x000B7AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347940, XrefRangeEnd = 347944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseRegisterIntermediateRenderers(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseRegisterIntermediateRenderers_Internal_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x000B98E4 File Offset: 0x000B7AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347944, XrefRangeEnd = 347948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseRenderNodeAdd(IntPtr userData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseRenderNodeAdd_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x000B9918 File Offset: 0x000B7B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347948, XrefRangeEnd = 347952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseRenderNodeExecute(IntPtr userData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseRenderNodeExecute_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x000B994C File Offset: 0x000B7B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347952, XrefRangeEnd = 347956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseRenderNodeCleanup(IntPtr userData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseRenderNodeCleanup_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x000B9980 File Offset: 0x000B7B80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347958, RefRangeEnd = 347959, XrefRangeStart = 347956, XrefRangeEnd = 347958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementStride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_AllocateBuffer_Private_Static_IntPtr_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x000B99DC File Offset: 0x000B7BDC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 347961, RefRangeEnd = 347966, XrefRangeStart = 347959, XrefRangeEnd = 347961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeBuffer(IntPtr buffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_FreeBuffer_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x000B9A10 File Offset: 0x000B7C10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347968, RefRangeEnd = 347970, XrefRangeStart = 347966, XrefRangeEnd = 347968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ranges;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rangeCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeRangeStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeRangeEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_UpdateBufferRanges_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x000B9A7C File Offset: 0x000B7C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347972, RefRangeEnd = 347973, XrefRangeStart = 347970, XrefRangeEnd = 347972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetVectorArray(MaterialPropertyBlock props, int name, IntPtr vector4s, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(props);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector4s;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_SetVectorArray_Private_Static_Void_MaterialPropertyBlock_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x000B9ADC File Offset: 0x000B7CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347973, XrefRangeEnd = 347975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetVertexDeclaration(Il2CppStructArray<VertexAttributeDescriptor> vertexAttributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertexAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_GetVertexDeclaration_Public_Static_IntPtr_Il2CppStructArray_1_VertexAttributeDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x000B9B20 File Offset: 0x000B7D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347975, XrefRangeEnd = 347980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterIntermediateRenderer(Camera camera, Material material, Matrix4x4 transform, Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transform;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aabb;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderLayer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowCasting;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sameDistanceSortPriority;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneCullingMask;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rendererCallbackFlags;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userData;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userDataSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RegisterIntermediateRenderer_Public_Static_Void_Camera_Material_Matrix4x4_Bounds_Int32_Int32_Boolean_Int32_UInt64_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x000B9BF8 File Offset: 0x000B7DF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347982, RefRangeEnd = 347983, XrefRangeStart = 347980, XrefRangeEnd = 347982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ib;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = vertexStreams;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref streamCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ranges;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rangeCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexDecl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_DrawRanges_Public_Static_Void_IntPtr_ptr_IntPtr_Int32_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x000B9C70 File Offset: 0x000B7E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347985, RefRangeEnd = 347986, XrefRangeStart = 347983, XrefRangeEnd = 347985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPropertyBlock(MaterialPropertyBlock props)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(props);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_SetPropertyBlock_Public_Static_Void_MaterialPropertyBlock_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x000B9CA8 File Offset: 0x000B7EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347986, XrefRangeEnd = 347991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetScissorRect(RectInt scissorRect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scissorRect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_SetScissorRect_Public_Static_Void_RectInt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x000B9CDC File Offset: 0x000B7EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347991, XrefRangeEnd = 347993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableScissor()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_DisableScissor_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x000B9D04 File Offset: 0x000B7F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347993, XrefRangeEnd = 347998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateStencilState(StencilState stencilState)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stencilState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_CreateStencilState_Public_Static_IntPtr_StencilState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x000B9D44 File Offset: 0x000B7F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347998, XrefRangeEnd = 348000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStencilState(IntPtr stencilState, int stencilRef)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stencilState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_SetStencilState_Public_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x000B9D84 File Offset: 0x000B7F84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 348002, RefRangeEnd = 348006, XrefRangeStart = 348000, XrefRangeEnd = 348002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasMappedBufferRange()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_HasMappedBufferRange_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x000B9DB4 File Offset: 0x000B7FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348006, XrefRangeEnd = 348008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint InsertCPUFence()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_InsertCPUFence_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x000B9DE4 File Offset: 0x000B7FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348008, XrefRangeEnd = 348010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CPUFencePassed(uint fence)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fence;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_CPUFencePassed_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x000B9E24 File Offset: 0x000B8024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348010, XrefRangeEnd = 348017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WaitForCPUFencePassed(uint fence)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fence;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_WaitForCPUFencePassed_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x000B9E58 File Offset: 0x000B8058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348017, XrefRangeEnd = 348019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SyncRenderThread()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_SyncRenderThread_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x000B9E80 File Offset: 0x000B8080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348024, RefRangeEnd = 348025, XrefRangeStart = 348019, XrefRangeEnd = 348024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RectInt GetActiveViewport()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_GetActiveViewport_Public_Static_RectInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x000B9EB0 File Offset: 0x000B80B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348025, XrefRangeEnd = 348027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProfileDrawChainBegin()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_ProfileDrawChainBegin_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x000B9ED8 File Offset: 0x000B80D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348027, XrefRangeEnd = 348029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProfileDrawChainEnd()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_ProfileDrawChainEnd_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x000B9F00 File Offset: 0x000B8100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348029, XrefRangeEnd = 348031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyOfUIREvents(bool subscribe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subscribe;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_NotifyOfUIREvents_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x000B9F34 File Offset: 0x000B8134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348031, XrefRangeEnd = 348036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetUnityProjectionMatrix()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_GetUnityProjectionMatrix_Public_Static_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x000B9F64 File Offset: 0x000B8164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348036, XrefRangeEnd = 348038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterIntermediateRenderer_Injected(Camera camera, Material material, ref Matrix4x4 transform, ref Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transform;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &aabb;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderLayer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowCasting;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sameDistanceSortPriority;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneCullingMask;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rendererCallbackFlags;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userData;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userDataSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RegisterIntermediateRenderer_Injected_Private_Static_Void_Camera_Material_byref_Matrix4x4_byref_Bounds_Int32_Int32_Boolean_Int32_UInt64_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x000BA03C File Offset: 0x000B823C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348038, XrefRangeEnd = 348040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetScissorRect_Injected(ref RectInt scissorRect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &scissorRect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_SetScissorRect_Injected_Private_Static_Void_byref_RectInt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x000BA070 File Offset: 0x000B8270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348040, XrefRangeEnd = 348042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateStencilState_Injected(ref StencilState stencilState)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &stencilState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_CreateStencilState_Injected_Private_Static_IntPtr_byref_StencilState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x000BA0B0 File Offset: 0x000B82B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348042, XrefRangeEnd = 348044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetActiveViewport_Injected(out RectInt ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_GetActiveViewport_Injected_Private_Static_Void_byref_RectInt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x000BA0E4 File Offset: 0x000B82E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348044, XrefRangeEnd = 348046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_GetUnityProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0001126E File Offset: 0x0000F46E
		public Utility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06002ABA RID: 10938 RVA: 0x000BA118 File Offset: 0x000B8318
		// (set) Token: 0x06002ABB RID: 10939 RVA: 0x00011277 File Offset: 0x0000F477
		public unsafe static Action<bool> GraphicsResourcesRecreate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_GraphicsResourcesRecreate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_GraphicsResourcesRecreate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x000BA140 File Offset: 0x000B8340
		// (set) Token: 0x06002ABD RID: 10941 RVA: 0x00011289 File Offset: 0x0000F489
		public unsafe static Action EngineUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_EngineUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_EngineUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x000BA168 File Offset: 0x000B8368
		// (set) Token: 0x06002ABF RID: 10943 RVA: 0x0001129B File Offset: 0x0000F49B
		public unsafe static Action FlushPendingResources
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_FlushPendingResources, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_FlushPendingResources, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x000BA190 File Offset: 0x000B8390
		// (set) Token: 0x06002AC1 RID: 10945 RVA: 0x000112AD File Offset: 0x0000F4AD
		public unsafe static Action<Camera> RegisterIntermediateRenderers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_RegisterIntermediateRenderers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_RegisterIntermediateRenderers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x000BA1B8 File Offset: 0x000B83B8
		// (set) Token: 0x06002AC3 RID: 10947 RVA: 0x000112BF File Offset: 0x0000F4BF
		public unsafe static Action<IntPtr> RenderNodeAdd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_RenderNodeAdd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_RenderNodeAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x000BA1E0 File Offset: 0x000B83E0
		// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x000112D1 File Offset: 0x0000F4D1
		public unsafe static Action<IntPtr> RenderNodeExecute
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_RenderNodeExecute, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_RenderNodeExecute, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x000BA208 File Offset: 0x000B8408
		// (set) Token: 0x06002AC7 RID: 10951 RVA: 0x000112E3 File Offset: 0x0000F4E3
		public unsafe static Action<IntPtr> RenderNodeCleanup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_RenderNodeCleanup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_RenderNodeCleanup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x000BA230 File Offset: 0x000B8430
		// (set) Token: 0x06002AC9 RID: 10953 RVA: 0x000112F5 File Offset: 0x0000F4F5
		public unsafe static ProfilerMarker s_MarkerRaiseEngineUpdate
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_s_MarkerRaiseEngineUpdate, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_s_MarkerRaiseEngineUpdate, (void*)(&value));
			}
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x00011303 File Offset: 0x0000F503
		public static void add_RenderNodeAdd(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x00011310 File Offset: 0x0000F510
		public static void remove_RenderNodeAdd(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x0001131D File Offset: 0x0000F51D
		public static void add_RenderNodeCleanup(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x0001132A File Offset: 0x0000F52A
		public static void remove_RenderNodeCleanup(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x00011337 File Offset: 0x0000F537
		public static bool IsScissorEnabled()
		{
			return Utility.IsScissorEnabledDelegateField();
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x000BA24C File Offset: 0x000B844C
		public static Matrix4x4 GetDeviceProjectionMatrix()
		{
			Matrix4x4 matrix4x;
			Utility.GetDeviceProjectionMatrix_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x00011343 File Offset: 0x0000F543
		public static bool DebugIsMainThread()
		{
			return Utility.DebugIsMainThreadDelegateField();
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x0001134F File Offset: 0x0000F54F
		public static void GetDeviceProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			Utility.GetDeviceProjectionMatrix_InjectedDelegateField(out ret);
		}

		// Token: 0x04001E4F RID: 7759
		private static readonly IntPtr NativeFieldInfoPtr_GraphicsResourcesRecreate;

		// Token: 0x04001E50 RID: 7760
		private static readonly IntPtr NativeFieldInfoPtr_EngineUpdate;

		// Token: 0x04001E51 RID: 7761
		private static readonly IntPtr NativeFieldInfoPtr_FlushPendingResources;

		// Token: 0x04001E52 RID: 7762
		private static readonly IntPtr NativeFieldInfoPtr_RegisterIntermediateRenderers;

		// Token: 0x04001E53 RID: 7763
		private static readonly IntPtr NativeFieldInfoPtr_RenderNodeAdd;

		// Token: 0x04001E54 RID: 7764
		private static readonly IntPtr NativeFieldInfoPtr_RenderNodeExecute;

		// Token: 0x04001E55 RID: 7765
		private static readonly IntPtr NativeFieldInfoPtr_RenderNodeCleanup;

		// Token: 0x04001E56 RID: 7766
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerRaiseEngineUpdate;

		// Token: 0x04001E57 RID: 7767
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Static_Void_MaterialPropertyBlock_Int32_NativeSlice_1_T_0;

		// Token: 0x04001E58 RID: 7768
		private static readonly IntPtr NativeMethodInfoPtr_add_GraphicsResourcesRecreate_Public_Static_add_Void_Action_1_Boolean_0;

		// Token: 0x04001E59 RID: 7769
		private static readonly IntPtr NativeMethodInfoPtr_remove_GraphicsResourcesRecreate_Public_Static_rem_Void_Action_1_Boolean_0;

		// Token: 0x04001E5A RID: 7770
		private static readonly IntPtr NativeMethodInfoPtr_add_EngineUpdate_Public_Static_add_Void_Action_0;

		// Token: 0x04001E5B RID: 7771
		private static readonly IntPtr NativeMethodInfoPtr_remove_EngineUpdate_Public_Static_rem_Void_Action_0;

		// Token: 0x04001E5C RID: 7772
		private static readonly IntPtr NativeMethodInfoPtr_add_FlushPendingResources_Public_Static_add_Void_Action_0;

		// Token: 0x04001E5D RID: 7773
		private static readonly IntPtr NativeMethodInfoPtr_remove_FlushPendingResources_Public_Static_rem_Void_Action_0;

		// Token: 0x04001E5E RID: 7774
		private static readonly IntPtr NativeMethodInfoPtr_add_RegisterIntermediateRenderers_Public_Static_add_Void_Action_1_Camera_0;

		// Token: 0x04001E5F RID: 7775
		private static readonly IntPtr NativeMethodInfoPtr_remove_RegisterIntermediateRenderers_Public_Static_rem_Void_Action_1_Camera_0;

		// Token: 0x04001E60 RID: 7776
		private static readonly IntPtr NativeMethodInfoPtr_add_RenderNodeExecute_Public_Static_add_Void_Action_1_IntPtr_0;

		// Token: 0x04001E61 RID: 7777
		private static readonly IntPtr NativeMethodInfoPtr_remove_RenderNodeExecute_Public_Static_rem_Void_Action_1_IntPtr_0;

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeMethodInfoPtr_RaiseGraphicsResourcesRecreate_Internal_Static_Void_Boolean_0;

		// Token: 0x04001E63 RID: 7779
		private static readonly IntPtr NativeMethodInfoPtr_RaiseEngineUpdate_Internal_Static_Void_0;

		// Token: 0x04001E64 RID: 7780
		private static readonly IntPtr NativeMethodInfoPtr_RaiseFlushPendingResources_Internal_Static_Void_0;

		// Token: 0x04001E65 RID: 7781
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRegisterIntermediateRenderers_Internal_Static_Void_Camera_0;

		// Token: 0x04001E66 RID: 7782
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRenderNodeAdd_Internal_Static_Void_IntPtr_0;

		// Token: 0x04001E67 RID: 7783
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRenderNodeExecute_Internal_Static_Void_IntPtr_0;

		// Token: 0x04001E68 RID: 7784
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRenderNodeCleanup_Internal_Static_Void_IntPtr_0;

		// Token: 0x04001E69 RID: 7785
		private static readonly IntPtr NativeMethodInfoPtr_AllocateBuffer_Private_Static_IntPtr_Int32_Int32_Boolean_0;

		// Token: 0x04001E6A RID: 7786
		private static readonly IntPtr NativeMethodInfoPtr_FreeBuffer_Private_Static_Void_IntPtr_0;

		// Token: 0x04001E6B RID: 7787
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBufferRanges_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_0;

		// Token: 0x04001E6C RID: 7788
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArray_Private_Static_Void_MaterialPropertyBlock_Int32_IntPtr_Int32_0;

		// Token: 0x04001E6D RID: 7789
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexDeclaration_Public_Static_IntPtr_Il2CppStructArray_1_VertexAttributeDescriptor_0;

		// Token: 0x04001E6E RID: 7790
		private static readonly IntPtr NativeMethodInfoPtr_RegisterIntermediateRenderer_Public_Static_Void_Camera_Material_Matrix4x4_Bounds_Int32_Int32_Boolean_Int32_UInt64_Int32_IntPtr_Int32_0;

		// Token: 0x04001E6F RID: 7791
		private static readonly IntPtr NativeMethodInfoPtr_DrawRanges_Public_Static_Void_IntPtr_ptr_IntPtr_Int32_IntPtr_Int32_IntPtr_0;

		// Token: 0x04001E70 RID: 7792
		private static readonly IntPtr NativeMethodInfoPtr_SetPropertyBlock_Public_Static_Void_MaterialPropertyBlock_0;

		// Token: 0x04001E71 RID: 7793
		private static readonly IntPtr NativeMethodInfoPtr_SetScissorRect_Public_Static_Void_RectInt_0;

		// Token: 0x04001E72 RID: 7794
		private static readonly IntPtr NativeMethodInfoPtr_DisableScissor_Public_Static_Void_0;

		// Token: 0x04001E73 RID: 7795
		private static readonly IntPtr NativeMethodInfoPtr_CreateStencilState_Public_Static_IntPtr_StencilState_0;

		// Token: 0x04001E74 RID: 7796
		private static readonly IntPtr NativeMethodInfoPtr_SetStencilState_Public_Static_Void_IntPtr_Int32_0;

		// Token: 0x04001E75 RID: 7797
		private static readonly IntPtr NativeMethodInfoPtr_HasMappedBufferRange_Public_Static_Boolean_0;

		// Token: 0x04001E76 RID: 7798
		private static readonly IntPtr NativeMethodInfoPtr_InsertCPUFence_Public_Static_UInt32_0;

		// Token: 0x04001E77 RID: 7799
		private static readonly IntPtr NativeMethodInfoPtr_CPUFencePassed_Public_Static_Boolean_UInt32_0;

		// Token: 0x04001E78 RID: 7800
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCPUFencePassed_Public_Static_Void_UInt32_0;

		// Token: 0x04001E79 RID: 7801
		private static readonly IntPtr NativeMethodInfoPtr_SyncRenderThread_Public_Static_Void_0;

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveViewport_Public_Static_RectInt_0;

		// Token: 0x04001E7B RID: 7803
		private static readonly IntPtr NativeMethodInfoPtr_ProfileDrawChainBegin_Public_Static_Void_0;

		// Token: 0x04001E7C RID: 7804
		private static readonly IntPtr NativeMethodInfoPtr_ProfileDrawChainEnd_Public_Static_Void_0;

		// Token: 0x04001E7D RID: 7805
		private static readonly IntPtr NativeMethodInfoPtr_NotifyOfUIREvents_Public_Static_Void_Boolean_0;

		// Token: 0x04001E7E RID: 7806
		private static readonly IntPtr NativeMethodInfoPtr_GetUnityProjectionMatrix_Public_Static_Matrix4x4_0;

		// Token: 0x04001E7F RID: 7807
		private static readonly IntPtr NativeMethodInfoPtr_RegisterIntermediateRenderer_Injected_Private_Static_Void_Camera_Material_byref_Matrix4x4_byref_Bounds_Int32_Int32_Boolean_Int32_UInt64_Int32_IntPtr_Int32_0;

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeMethodInfoPtr_SetScissorRect_Injected_Private_Static_Void_byref_RectInt_0;

		// Token: 0x04001E81 RID: 7809
		private static readonly IntPtr NativeMethodInfoPtr_CreateStencilState_Injected_Private_Static_IntPtr_byref_StencilState_0;

		// Token: 0x04001E82 RID: 7810
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveViewport_Injected_Private_Static_Void_byref_RectInt_0;

		// Token: 0x04001E83 RID: 7811
		private static readonly IntPtr NativeMethodInfoPtr_GetUnityProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

		// Token: 0x04001E84 RID: 7812
		private static readonly Utility.IsScissorEnabledDelegate IsScissorEnabledDelegateField;

		// Token: 0x04001E85 RID: 7813
		private static readonly Utility.DebugIsMainThreadDelegate DebugIsMainThreadDelegateField;

		// Token: 0x04001E86 RID: 7814
		private static readonly Utility.GetDeviceProjectionMatrix_InjectedDelegate GetDeviceProjectionMatrix_InjectedDelegateField;

		// Token: 0x02000539 RID: 1337
		public enum GPUBufferType
		{
			// Token: 0x04002D91 RID: 11665
			Vertex,
			// Token: 0x04002D92 RID: 11666
			Index
		}

		// Token: 0x0200053A RID: 1338
		public class GPUBuffer<T> : Object where T : new()
		{
			// Token: 0x060040BA RID: 16570 RVA: 0x00100848 File Offset: 0x000FEA48
			// Note: this type is marked as 'beforefieldinit'.
			static GPUBuffer()
			{
				Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Utility>.NativeClassPtr, "GPUBuffer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr);
				Utility.GPUBuffer<T>.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr, "buffer");
				Utility.GPUBuffer<T>.NativeFieldInfoPtr_elemCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr, "elemCount");
				Utility.GPUBuffer<T>.NativeFieldInfoPtr_elemStride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr, "elemStride");
				Utility.GPUBuffer<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_GPUBufferType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr, 100669698);
				Utility.GPUBuffer<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr, 100669699);
				Utility.GPUBuffer<T>.NativeMethodInfoPtr_UpdateRanges_Public_Void_NativeSlice_1_GfxUpdateBufferRange_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr, 100669700);
				Utility.GPUBuffer<T>.NativeMethodInfoPtr_get_ElementStride_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr, 100669701);
				Utility.GPUBuffer<T>.NativeMethodInfoPtr_get_BufferPointer_Internal_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr, 100669702);
			}

			// Token: 0x060040BB RID: 16571 RVA: 0x00100950 File Offset: 0x000FEB50
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 347764, RefRangeEnd = 347765, XrefRangeStart = 347759, XrefRangeEnd = 347764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GPUBuffer(int elementCount, Utility.GPUBufferType type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref elementCount;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.GPUBuffer<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_GPUBufferType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060040BC RID: 16572 RVA: 0x001009A8 File Offset: 0x000FEBA8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 347779, RefRangeEnd = 347781, XrefRangeStart = 347765, XrefRangeEnd = 347779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.GPUBuffer<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060040BD RID: 16573 RVA: 0x001009DC File Offset: 0x000FEBDC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 347791, RefRangeEnd = 347794, XrefRangeStart = 347781, XrefRangeEnd = 347791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateRanges(NativeSlice<GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ranges));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rangesMin;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rangesMax;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.GPUBuffer<T>.NativeMethodInfoPtr_UpdateRanges_Public_Void_NativeSlice_1_GfxUpdateBufferRange_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001363 RID: 4963
			// (get) Token: 0x060040BE RID: 16574 RVA: 0x00100A40 File Offset: 0x000FEC40
			public unsafe int ElementStride
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 347794, RefRangeEnd = 347795, XrefRangeStart = 347794, XrefRangeEnd = 347794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.GPUBuffer<T>.NativeMethodInfoPtr_get_ElementStride_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001364 RID: 4964
			// (get) Token: 0x060040BF RID: 16575 RVA: 0x00100A7C File Offset: 0x000FEC7C
			public unsafe IntPtr BufferPointer
			{
				[CallerCount(169)]
				[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.GPUBuffer<T>.NativeMethodInfoPtr_get_BufferPointer_Internal_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060040C0 RID: 16576 RVA: 0x0001B409 File Offset: 0x00019609
			public GPUBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001360 RID: 4960
			// (get) Token: 0x060040C1 RID: 16577 RVA: 0x00100AB8 File Offset: 0x000FECB8
			// (set) Token: 0x060040C2 RID: 16578 RVA: 0x0001B412 File Offset: 0x00019612
			public unsafe IntPtr buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_buffer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_buffer)) = value;
				}
			}

			// Token: 0x17001361 RID: 4961
			// (get) Token: 0x060040C3 RID: 16579 RVA: 0x00100AE0 File Offset: 0x000FECE0
			// (set) Token: 0x060040C4 RID: 16580 RVA: 0x0001B42D File Offset: 0x0001962D
			public unsafe int elemCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_elemCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_elemCount)) = value;
				}
			}

			// Token: 0x17001362 RID: 4962
			// (get) Token: 0x060040C5 RID: 16581 RVA: 0x00100B08 File Offset: 0x000FED08
			// (set) Token: 0x060040C6 RID: 16582 RVA: 0x0001B448 File Offset: 0x00019648
			public unsafe int elemStride
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_elemStride);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_elemStride)) = value;
				}
			}

			// Token: 0x04002D93 RID: 11667
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04002D94 RID: 11668
			private static readonly IntPtr NativeFieldInfoPtr_elemCount;

			// Token: 0x04002D95 RID: 11669
			private static readonly IntPtr NativeFieldInfoPtr_elemStride;

			// Token: 0x04002D96 RID: 11670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_GPUBufferType_0;

			// Token: 0x04002D97 RID: 11671
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002D98 RID: 11672
			private static readonly IntPtr NativeMethodInfoPtr_UpdateRanges_Public_Void_NativeSlice_1_GfxUpdateBufferRange_Int32_Int32_0;

			// Token: 0x04002D99 RID: 11673
			private static readonly IntPtr NativeMethodInfoPtr_get_ElementStride_Public_get_Int32_0;

			// Token: 0x04002D9A RID: 11674
			private static readonly IntPtr NativeMethodInfoPtr_get_BufferPointer_Internal_get_IntPtr_0;
		}

		// Token: 0x0200053B RID: 1339
		private sealed class MethodInfoStoreGeneric_SetVectorArray_Public_Static_Void_MaterialPropertyBlock_Int32_NativeSlice_1_T_0<T>
		{
			// Token: 0x04002D9B RID: 11675
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utility.NativeMethodInfoPtr_SetVectorArray_Public_Static_Void_MaterialPropertyBlock_Int32_NativeSlice_1_T_0, Il2CppClassPointerStore<Utility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200053C RID: 1340
		public enum RendererCallbacks
		{
			// Token: 0x04002D9D RID: 11677
			RendererCallback_Init = 1,
			// Token: 0x04002D9E RID: 11678
			RendererCallback_Exec,
			// Token: 0x04002D9F RID: 11679
			RendererCallback_Cleanup = 4
		}

		// Token: 0x0200053D RID: 1341
		// (Invoke) Token: 0x060040C9 RID: 16585
		private delegate bool IsScissorEnabledDelegate();

		// Token: 0x0200053E RID: 1342
		// (Invoke) Token: 0x060040CB RID: 16587
		private delegate bool DebugIsMainThreadDelegate();

		// Token: 0x0200053F RID: 1343
		// (Invoke) Token: 0x060040CD RID: 16589
		private delegate void GetDeviceProjectionMatrix_InjectedDelegate([Out] IntPtr ret);
	}
}
