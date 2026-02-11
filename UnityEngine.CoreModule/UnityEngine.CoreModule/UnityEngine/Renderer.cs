using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x020000A4 RID: 164
	public class Renderer : Component
	{
		// Token: 0x06000B8B RID: 2955 RVA: 0x00039C60 File Offset: 0x00037E60
		// Note: this type is marked as 'beforefieldinit'.
		static Renderer()
		{
			Il2CppClassPointerStore<Renderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Renderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Renderer>.NativeClassPtr);
			Renderer.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664526);
			Renderer.NativeMethodInfoPtr_GetMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664527);
			Renderer.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664528);
			Renderer.NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664529);
			Renderer.NativeMethodInfoPtr_GetMaterialArray_Private_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664530);
			Renderer.NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664531);
			Renderer.NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664532);
			Renderer.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664533);
			Renderer.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664534);
			Renderer.NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664535);
			Renderer.NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664536);
			Renderer.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664537);
			Renderer.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664538);
			Renderer.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664539);
			Renderer.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664540);
			Renderer.NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664541);
			Renderer.NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664542);
			Renderer.NativeMethodInfoPtr_get_materials_Public_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664543);
			Renderer.NativeMethodInfoPtr_set_materials_Public_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664544);
			Renderer.NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664545);
			Renderer.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664546);
			Renderer.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664547);
			Renderer.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664548);
			Renderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664549);
			Renderer.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664550);
			Renderer.ResetBoundsDelegateField = IL2CPP.ResolveICall<Renderer.ResetBoundsDelegate>("UnityEngine.Renderer::ResetBounds");
			Renderer.ResetLocalBoundsDelegateField = IL2CPP.ResolveICall<Renderer.ResetLocalBoundsDelegate>("UnityEngine.Renderer::ResetLocalBounds");
			Renderer.CopyMaterialArrayDelegateField = IL2CPP.ResolveICall<Renderer.CopyMaterialArrayDelegate>("UnityEngine.Renderer::CopyMaterialArray");
			Renderer.CopySharedMaterialArrayDelegateField = IL2CPP.ResolveICall<Renderer.CopySharedMaterialArrayDelegate>("UnityEngine.Renderer::CopySharedMaterialArray");
			Renderer.Internal_SetPropertyBlockDelegateField = IL2CPP.ResolveICall<Renderer.Internal_SetPropertyBlockDelegate>("UnityEngine.Renderer::Internal_SetPropertyBlock");
			Renderer.Internal_GetPropertyBlockDelegateField = IL2CPP.ResolveICall<Renderer.Internal_GetPropertyBlockDelegate>("UnityEngine.Renderer::Internal_GetPropertyBlock");
			Renderer.Internal_SetPropertyBlockMaterialIndexDelegateField = IL2CPP.ResolveICall<Renderer.Internal_SetPropertyBlockMaterialIndexDelegate>("UnityEngine.Renderer::Internal_SetPropertyBlockMaterialIndex");
			Renderer.Internal_GetPropertyBlockMaterialIndexDelegateField = IL2CPP.ResolveICall<Renderer.Internal_GetPropertyBlockMaterialIndexDelegate>("UnityEngine.Renderer::Internal_GetPropertyBlockMaterialIndex");
			Renderer.HasPropertyBlockDelegateField = IL2CPP.ResolveICall<Renderer.HasPropertyBlockDelegate>("UnityEngine.Renderer::HasPropertyBlock");
			Renderer.GetClosestReflectionProbesInternalDelegateField = IL2CPP.ResolveICall<Renderer.GetClosestReflectionProbesInternalDelegate>("UnityEngine.Renderer::GetClosestReflectionProbesInternal");
			Renderer.get_isVisibleDelegateField = IL2CPP.ResolveICall<Renderer.get_isVisibleDelegate>("UnityEngine.Renderer::get_isVisible");
			Renderer.get_shadowCastingModeDelegateField = IL2CPP.ResolveICall<Renderer.get_shadowCastingModeDelegate>("UnityEngine.Renderer::get_shadowCastingMode");
			Renderer.get_receiveShadowsDelegateField = IL2CPP.ResolveICall<Renderer.get_receiveShadowsDelegate>("UnityEngine.Renderer::get_receiveShadows");
			Renderer.get_forceRenderingOffDelegateField = IL2CPP.ResolveICall<Renderer.get_forceRenderingOffDelegate>("UnityEngine.Renderer::get_forceRenderingOff");
			Renderer.set_forceRenderingOffDelegateField = IL2CPP.ResolveICall<Renderer.set_forceRenderingOffDelegate>("UnityEngine.Renderer::set_forceRenderingOff");
			Renderer.GetIsStaticShadowCasterDelegateField = IL2CPP.ResolveICall<Renderer.GetIsStaticShadowCasterDelegate>("UnityEngine.Renderer::GetIsStaticShadowCaster");
			Renderer.SetIsStaticShadowCasterDelegateField = IL2CPP.ResolveICall<Renderer.SetIsStaticShadowCasterDelegate>("UnityEngine.Renderer::SetIsStaticShadowCaster");
			Renderer.get_motionVectorGenerationModeDelegateField = IL2CPP.ResolveICall<Renderer.get_motionVectorGenerationModeDelegate>("UnityEngine.Renderer::get_motionVectorGenerationMode");
			Renderer.set_motionVectorGenerationModeDelegateField = IL2CPP.ResolveICall<Renderer.set_motionVectorGenerationModeDelegate>("UnityEngine.Renderer::set_motionVectorGenerationMode");
			Renderer.get_lightProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.get_lightProbeUsageDelegate>("UnityEngine.Renderer::get_lightProbeUsage");
			Renderer.set_lightProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.set_lightProbeUsageDelegate>("UnityEngine.Renderer::set_lightProbeUsage");
			Renderer.get_reflectionProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.get_reflectionProbeUsageDelegate>("UnityEngine.Renderer::get_reflectionProbeUsage");
			Renderer.set_reflectionProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.set_reflectionProbeUsageDelegate>("UnityEngine.Renderer::set_reflectionProbeUsage");
			Renderer.get_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Renderer.get_renderingLayerMaskDelegate>("UnityEngine.Renderer::get_renderingLayerMask");
			Renderer.set_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Renderer.set_renderingLayerMaskDelegate>("UnityEngine.Renderer::set_renderingLayerMask");
			Renderer.get_rendererPriorityDelegateField = IL2CPP.ResolveICall<Renderer.get_rendererPriorityDelegate>("UnityEngine.Renderer::get_rendererPriority");
			Renderer.set_rendererPriorityDelegateField = IL2CPP.ResolveICall<Renderer.set_rendererPriorityDelegate>("UnityEngine.Renderer::set_rendererPriority");
			Renderer.get_rayTracingModeDelegateField = IL2CPP.ResolveICall<Renderer.get_rayTracingModeDelegate>("UnityEngine.Renderer::get_rayTracingMode");
			Renderer.set_rayTracingModeDelegateField = IL2CPP.ResolveICall<Renderer.set_rayTracingModeDelegate>("UnityEngine.Renderer::set_rayTracingMode");
			Renderer.get_sortingLayerNameDelegateField = IL2CPP.ResolveICall<Renderer.get_sortingLayerNameDelegate>("UnityEngine.Renderer::get_sortingLayerName");
			Renderer.set_sortingLayerNameDelegateField = IL2CPP.ResolveICall<Renderer.set_sortingLayerNameDelegate>("UnityEngine.Renderer::set_sortingLayerName");
			Renderer.get_sortingKeyDelegateField = IL2CPP.ResolveICall<Renderer.get_sortingKeyDelegate>("UnityEngine.Renderer::get_sortingKey");
			Renderer.set_sortingGroupIDDelegateField = IL2CPP.ResolveICall<Renderer.set_sortingGroupIDDelegate>("UnityEngine.Renderer::set_sortingGroupID");
			Renderer.set_sortingGroupOrderDelegateField = IL2CPP.ResolveICall<Renderer.set_sortingGroupOrderDelegate>("UnityEngine.Renderer::set_sortingGroupOrder");
			Renderer.get_sortingGroupKeyDelegateField = IL2CPP.ResolveICall<Renderer.get_sortingGroupKeyDelegate>("UnityEngine.Renderer::get_sortingGroupKey");
			Renderer.get_allowOcclusionWhenDynamicDelegateField = IL2CPP.ResolveICall<Renderer.get_allowOcclusionWhenDynamicDelegate>("UnityEngine.Renderer::get_allowOcclusionWhenDynamic");
			Renderer.set_allowOcclusionWhenDynamicDelegateField = IL2CPP.ResolveICall<Renderer.set_allowOcclusionWhenDynamicDelegate>("UnityEngine.Renderer::set_allowOcclusionWhenDynamic");
			Renderer.get_staticBatchRootTransformDelegateField = IL2CPP.ResolveICall<Renderer.get_staticBatchRootTransformDelegate>("UnityEngine.Renderer::get_staticBatchRootTransform");
			Renderer.set_staticBatchRootTransformDelegateField = IL2CPP.ResolveICall<Renderer.set_staticBatchRootTransformDelegate>("UnityEngine.Renderer::set_staticBatchRootTransform");
			Renderer.get_staticBatchIndexDelegateField = IL2CPP.ResolveICall<Renderer.get_staticBatchIndexDelegate>("UnityEngine.Renderer::get_staticBatchIndex");
			Renderer.SetStaticBatchInfoDelegateField = IL2CPP.ResolveICall<Renderer.SetStaticBatchInfoDelegate>("UnityEngine.Renderer::SetStaticBatchInfo");
			Renderer.get_isPartOfStaticBatchDelegateField = IL2CPP.ResolveICall<Renderer.get_isPartOfStaticBatchDelegate>("UnityEngine.Renderer::get_isPartOfStaticBatch");
			Renderer.get_lightProbeProxyVolumeOverrideDelegateField = IL2CPP.ResolveICall<Renderer.get_lightProbeProxyVolumeOverrideDelegate>("UnityEngine.Renderer::get_lightProbeProxyVolumeOverride");
			Renderer.set_lightProbeProxyVolumeOverrideDelegateField = IL2CPP.ResolveICall<Renderer.set_lightProbeProxyVolumeOverrideDelegate>("UnityEngine.Renderer::set_lightProbeProxyVolumeOverride");
			Renderer.get_probeAnchorDelegateField = IL2CPP.ResolveICall<Renderer.get_probeAnchorDelegate>("UnityEngine.Renderer::get_probeAnchor");
			Renderer.set_probeAnchorDelegateField = IL2CPP.ResolveICall<Renderer.set_probeAnchorDelegate>("UnityEngine.Renderer::set_probeAnchor");
			Renderer.GetLightmapIndexDelegateField = IL2CPP.ResolveICall<Renderer.GetLightmapIndexDelegate>("UnityEngine.Renderer::GetLightmapIndex");
			Renderer.SetLightmapIndexDelegateField = IL2CPP.ResolveICall<Renderer.SetLightmapIndexDelegate>("UnityEngine.Renderer::SetLightmapIndex");
			Renderer.GetMaterialCountDelegateField = IL2CPP.ResolveICall<Renderer.GetMaterialCountDelegate>("UnityEngine.Renderer::GetMaterialCount");
			Renderer.GetSharedMaterialArrayDelegateField = IL2CPP.ResolveICall<Renderer.GetSharedMaterialArrayDelegate>("UnityEngine.Renderer::GetSharedMaterialArray");
			Renderer.set_bounds_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.set_bounds_InjectedDelegate>("UnityEngine.Renderer::set_bounds_Injected");
			Renderer.get_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.get_localBounds_InjectedDelegate>("UnityEngine.Renderer::get_localBounds_Injected");
			Renderer.set_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.set_localBounds_InjectedDelegate>("UnityEngine.Renderer::set_localBounds_Injected");
			Renderer.SetStaticLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.SetStaticLightmapST_InjectedDelegate>("UnityEngine.Renderer::SetStaticLightmapST_Injected");
			Renderer.get_worldToLocalMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.get_worldToLocalMatrix_InjectedDelegate>("UnityEngine.Renderer::get_worldToLocalMatrix_Injected");
			Renderer.get_localToWorldMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.get_localToWorldMatrix_InjectedDelegate>("UnityEngine.Renderer::get_localToWorldMatrix_Injected");
			Renderer.GetLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.GetLightmapST_InjectedDelegate>("UnityEngine.Renderer::GetLightmapST_Injected");
			Renderer.SetLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.SetLightmapST_InjectedDelegate>("UnityEngine.Renderer::SetLightmapST_Injected");
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0003A1EC File Offset: 0x000383EC
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00006A79 File Offset: 0x00004C79
		public unsafe Bounds bounds
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650669, RefRangeEnd = 650670, XrefRangeStart = 650667, XrefRangeEnd = 650669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_bounds_Injected(ref value);
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0003A228 File Offset: 0x00038428
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 650672, RefRangeEnd = 650696, XrefRangeStart = 650670, XrefRangeEnd = 650672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0003A268 File Offset: 0x00038468
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 650698, RefRangeEnd = 650703, XrefRangeStart = 650696, XrefRangeEnd = 650698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetSharedMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0003A2A8 File Offset: 0x000384A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 650705, RefRangeEnd = 650710, XrefRangeStart = 650703, XrefRangeEnd = 650705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial(Material m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0003A2EC File Offset: 0x000384EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650710, XrefRangeEnd = 650712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Material> GetMaterialArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetMaterialArray_Private_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0003A32C File Offset: 0x0003852C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650712, XrefRangeEnd = 650714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialArray(Il2CppReferenceArray<Material> m, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0003A37C File Offset: 0x0003857C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650714, XrefRangeEnd = 650718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialArray(Il2CppReferenceArray<Material> m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0003A3C0 File Offset: 0x000385C0
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x0003A3FC File Offset: 0x000385FC
		public unsafe bool enabled
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 650720, RefRangeEnd = 650723, XrefRangeStart = 650718, XrefRangeEnd = 650720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 650725, RefRangeEnd = 650730, XrefRangeStart = 650723, XrefRangeEnd = 650725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00006BB7 File Offset: 0x00004DB7
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x0003A43C File Offset: 0x0003863C
		public unsafe UnityEngine.Rendering.ShadowCastingMode shadowCastingMode
		{
			get
			{
				return Renderer.get_shadowCastingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650732, RefRangeEnd = 650733, XrefRangeStart = 650730, XrefRangeEnd = 650732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x00006BC9 File Offset: 0x00004DC9
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x0003A47C File Offset: 0x0003867C
		public unsafe bool receiveShadows
		{
			get
			{
				return Renderer.get_receiveShadowsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650735, RefRangeEnd = 650736, XrefRangeStart = 650733, XrefRangeEnd = 650735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0003A4BC File Offset: 0x000386BC
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x0003A4F8 File Offset: 0x000386F8
		public unsafe int sortingLayerID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 650738, RefRangeEnd = 650741, XrefRangeStart = 650736, XrefRangeEnd = 650738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 650743, RefRangeEnd = 650747, XrefRangeStart = 650741, XrefRangeEnd = 650743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0003A538 File Offset: 0x00038738
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x0003A574 File Offset: 0x00038774
		public unsafe int sortingOrder
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 650749, RefRangeEnd = 650752, XrefRangeStart = 650747, XrefRangeEnd = 650749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 650754, RefRangeEnd = 650760, XrefRangeStart = 650752, XrefRangeEnd = 650754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0003A5B4 File Offset: 0x000387B4
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x00006D38 File Offset: 0x00004F38
		public unsafe int sortingGroupID
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650762, RefRangeEnd = 650764, XrefRangeStart = 650760, XrefRangeEnd = 650762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Renderer.set_sortingGroupIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x0003A5F0 File Offset: 0x000387F0
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x00006D4B File Offset: 0x00004F4B
		public unsafe int sortingGroupOrder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650766, RefRangeEnd = 650767, XrefRangeStart = 650764, XrefRangeEnd = 650766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Renderer.set_sortingGroupOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x0003A62C File Offset: 0x0003882C
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x0003A66C File Offset: 0x0003886C
		public unsafe Il2CppReferenceArray<Material> materials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_materials_Public_get_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_materials_Public_set_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0003A6B0 File Offset: 0x000388B0
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x0003A6F0 File Offset: 0x000388F0
		public unsafe Material material
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 650672, RefRangeEnd = 650696, XrefRangeStart = 650672, XrefRangeEnd = 650696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 650705, RefRangeEnd = 650710, XrefRangeStart = 650705, XrefRangeEnd = 650710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x0003A734 File Offset: 0x00038934
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x0003A774 File Offset: 0x00038974
		public unsafe Material sharedMaterial
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 650698, RefRangeEnd = 650703, XrefRangeStart = 650698, XrefRangeEnd = 650703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 650705, RefRangeEnd = 650710, XrefRangeStart = 650705, XrefRangeEnd = 650710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0003A7B8 File Offset: 0x000389B8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Renderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Renderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0003A7F4 File Offset: 0x000389F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650767, XrefRangeEnd = 650769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00006A3D File Offset: 0x00004C3D
		public Renderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0003A834 File Offset: 0x00038A34
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x00006A46 File Offset: 0x00004C46
		public bool castShadows
		{
			get
			{
				return this.shadowCastingMode > UnityEngine.Rendering.ShadowCastingMode.Off;
			}
			set
			{
				this.shadowCastingMode = (value ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0003A850 File Offset: 0x00038A50
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x00006A57 File Offset: 0x00004C57
		public bool motionVectors
		{
			get
			{
				return this.motionVectorGenerationMode == MotionVectorGenerationMode.Object;
			}
			set
			{
				this.motionVectorGenerationMode = (value ? MotionVectorGenerationMode.Object : MotionVectorGenerationMode.Camera);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0003A86C File Offset: 0x00038A6C
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x00006A68 File Offset: 0x00004C68
		public bool useLightProbes
		{
			get
			{
				return this.lightProbeUsage > UnityEngine.Rendering.LightProbeUsage.Off;
			}
			set
			{
				this.lightProbeUsage = (value ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x0003A888 File Offset: 0x00038A88
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x00006A83 File Offset: 0x00004C83
		public Bounds localBounds
		{
			get
			{
				Bounds bounds;
				this.get_localBounds_Injected(out bounds);
				return bounds;
			}
			set
			{
				this.set_localBounds_Injected(ref value);
			}
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00006A8D File Offset: 0x00004C8D
		public void ResetBounds()
		{
			Renderer.ResetBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00006A9F File Offset: 0x00004C9F
		public void ResetLocalBounds()
		{
			Renderer.ResetLocalBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00006AB1 File Offset: 0x00004CB1
		public void SetStaticLightmapST(Vector4 st)
		{
			this.SetStaticLightmapST_Injected(ref st);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00006ABB File Offset: 0x00004CBB
		public void CopyMaterialArray([Out] Il2CppReferenceArray<Material> m)
		{
			Renderer.CopyMaterialArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(m));
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00006AD3 File Offset: 0x00004CD3
		public void CopySharedMaterialArray([Out] Il2CppReferenceArray<Material> m)
		{
			Renderer.CopySharedMaterialArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(m));
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00006AEB File Offset: 0x00004CEB
		public void Internal_SetPropertyBlock(MaterialPropertyBlock properties)
		{
			Renderer.Internal_SetPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00006B03 File Offset: 0x00004D03
		public void Internal_GetPropertyBlock(MaterialPropertyBlock dest)
		{
			Renderer.Internal_GetPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(dest));
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00006B1B File Offset: 0x00004D1B
		public void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex)
		{
			Renderer.Internal_SetPropertyBlockMaterialIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(properties), materialIndex);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00006B34 File Offset: 0x00004D34
		public void Internal_GetPropertyBlockMaterialIndex(MaterialPropertyBlock dest, int materialIndex)
		{
			Renderer.Internal_GetPropertyBlockMaterialIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(dest), materialIndex);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00006B4D File Offset: 0x00004D4D
		public bool HasPropertyBlock()
		{
			return Renderer.HasPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00006B5F File Offset: 0x00004D5F
		public void SetPropertyBlock(MaterialPropertyBlock properties)
		{
			this.Internal_SetPropertyBlock(properties);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00006B6A File Offset: 0x00004D6A
		public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
		{
			this.Internal_SetPropertyBlockMaterialIndex(properties, materialIndex);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00006B76 File Offset: 0x00004D76
		public void GetPropertyBlock(MaterialPropertyBlock properties)
		{
			this.Internal_GetPropertyBlock(properties);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00006B81 File Offset: 0x00004D81
		public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
		{
			this.Internal_GetPropertyBlockMaterialIndex(properties, materialIndex);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00006B8D File Offset: 0x00004D8D
		public void GetClosestReflectionProbesInternal(Object result)
		{
			Renderer.GetClosestReflectionProbesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(result));
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x00006BA5 File Offset: 0x00004DA5
		public bool isVisible
		{
			get
			{
				return Renderer.get_isVisibleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00006BDB File Offset: 0x00004DDB
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x00006BED File Offset: 0x00004DED
		public bool forceRenderingOff
		{
			get
			{
				return Renderer.get_forceRenderingOffDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_forceRenderingOffDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00006C00 File Offset: 0x00004E00
		public bool GetIsStaticShadowCaster()
		{
			return Renderer.GetIsStaticShadowCasterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00006C12 File Offset: 0x00004E12
		public void SetIsStaticShadowCaster(bool value)
		{
			Renderer.SetIsStaticShadowCasterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0003A8A0 File Offset: 0x00038AA0
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x00006C25 File Offset: 0x00004E25
		public bool staticShadowCaster
		{
			get
			{
				return this.GetIsStaticShadowCaster();
			}
			set
			{
				this.SetIsStaticShadowCaster(value);
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00006C30 File Offset: 0x00004E30
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00006C42 File Offset: 0x00004E42
		public MotionVectorGenerationMode motionVectorGenerationMode
		{
			get
			{
				return Renderer.get_motionVectorGenerationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_motionVectorGenerationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00006C55 File Offset: 0x00004E55
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00006C67 File Offset: 0x00004E67
		public UnityEngine.Rendering.LightProbeUsage lightProbeUsage
		{
			get
			{
				return Renderer.get_lightProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_lightProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00006C7A File Offset: 0x00004E7A
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00006C8C File Offset: 0x00004E8C
		public UnityEngine.Rendering.ReflectionProbeUsage reflectionProbeUsage
		{
			get
			{
				return Renderer.get_reflectionProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_reflectionProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00006C9F File Offset: 0x00004E9F
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x00006CB1 File Offset: 0x00004EB1
		public uint renderingLayerMask
		{
			get
			{
				return Renderer.get_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x00006CC4 File Offset: 0x00004EC4
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x00006CD6 File Offset: 0x00004ED6
		public int rendererPriority
		{
			get
			{
				return Renderer.get_rendererPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_rendererPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x00006CE9 File Offset: 0x00004EE9
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x00006CFB File Offset: 0x00004EFB
		public UnityEngine.Experimental.Rendering.RayTracingMode rayTracingMode
		{
			get
			{
				return Renderer.get_rayTracingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_rayTracingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0003A8B8 File Offset: 0x00038AB8
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x00006D0E File Offset: 0x00004F0E
		public string sortingLayerName
		{
			get
			{
				IntPtr intPtr = Renderer.get_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Renderer.set_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x00006D26 File Offset: 0x00004F26
		public uint sortingKey
		{
			get
			{
				return Renderer.get_sortingKeyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00006D5E File Offset: 0x00004F5E
		public uint sortingGroupKey
		{
			get
			{
				return Renderer.get_sortingGroupKeyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x00006D70 File Offset: 0x00004F70
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x00006D82 File Offset: 0x00004F82
		public bool allowOcclusionWhenDynamic
		{
			get
			{
				return Renderer.get_allowOcclusionWhenDynamicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_allowOcclusionWhenDynamicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x0003A8DC File Offset: 0x00038ADC
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x00006D95 File Offset: 0x00004F95
		public Transform staticBatchRootTransform
		{
			get
			{
				IntPtr intPtr = Renderer.get_staticBatchRootTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				Renderer.set_staticBatchRootTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00006DAD File Offset: 0x00004FAD
		public int staticBatchIndex
		{
			get
			{
				return Renderer.get_staticBatchIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00006DBF File Offset: 0x00004FBF
		public void SetStaticBatchInfo(int firstSubMesh, int subMeshCount)
		{
			Renderer.SetStaticBatchInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), firstSubMesh, subMeshCount);
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00006DD3 File Offset: 0x00004FD3
		public bool isPartOfStaticBatch
		{
			get
			{
				return Renderer.get_isPartOfStaticBatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0003A908 File Offset: 0x00038B08
		public Matrix4x4 worldToLocalMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_worldToLocalMatrix_Injected(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0003A920 File Offset: 0x00038B20
		public Matrix4x4 localToWorldMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_localToWorldMatrix_Injected(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0003A938 File Offset: 0x00038B38
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x00006DE5 File Offset: 0x00004FE5
		public GameObject lightProbeProxyVolumeOverride
		{
			get
			{
				IntPtr intPtr = Renderer.get_lightProbeProxyVolumeOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				Renderer.set_lightProbeProxyVolumeOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0003A964 File Offset: 0x00038B64
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x00006DFD File Offset: 0x00004FFD
		public Transform probeAnchor
		{
			get
			{
				IntPtr intPtr = Renderer.get_probeAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				Renderer.set_probeAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00006E15 File Offset: 0x00005015
		public int GetLightmapIndex(global::UnityEngineInternal.LightmapType lt)
		{
			return Renderer.GetLightmapIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), lt);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00006E28 File Offset: 0x00005028
		public void SetLightmapIndex(int index, global::UnityEngineInternal.LightmapType lt)
		{
			Renderer.SetLightmapIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, lt);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0003A990 File Offset: 0x00038B90
		public Vector4 GetLightmapST(global::UnityEngineInternal.LightmapType lt)
		{
			Vector4 vector;
			this.GetLightmapST_Injected(lt, out vector);
			return vector;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00006E3C File Offset: 0x0000503C
		public void SetLightmapST(Vector4 st, global::UnityEngineInternal.LightmapType lt)
		{
			this.SetLightmapST_Injected(ref st, lt);
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x0003A9A8 File Offset: 0x00038BA8
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x00006E47 File Offset: 0x00005047
		public int lightmapIndex
		{
			get
			{
				return this.GetLightmapIndex(global::UnityEngineInternal.LightmapType.StaticLightmap);
			}
			set
			{
				this.SetLightmapIndex(value, global::UnityEngineInternal.LightmapType.StaticLightmap);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0003A9C4 File Offset: 0x00038BC4
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x00006E53 File Offset: 0x00005053
		public int realtimeLightmapIndex
		{
			get
			{
				return this.GetLightmapIndex(global::UnityEngineInternal.LightmapType.DynamicLightmap);
			}
			set
			{
				this.SetLightmapIndex(value, global::UnityEngineInternal.LightmapType.DynamicLightmap);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0003A9E0 File Offset: 0x00038BE0
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x00006E5F File Offset: 0x0000505F
		public Vector4 lightmapScaleOffset
		{
			get
			{
				return this.GetLightmapST(global::UnityEngineInternal.LightmapType.StaticLightmap);
			}
			set
			{
				this.SetStaticLightmapST(value);
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0003A9FC File Offset: 0x00038BFC
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00006E6A File Offset: 0x0000506A
		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				return this.GetLightmapST(global::UnityEngineInternal.LightmapType.DynamicLightmap);
			}
			set
			{
				this.SetLightmapST(value, global::UnityEngineInternal.LightmapType.DynamicLightmap);
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00006E76 File Offset: 0x00005076
		public int GetMaterialCount()
		{
			return Renderer.GetMaterialCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0003AA18 File Offset: 0x00038C18
		public Il2CppReferenceArray<Material> GetSharedMaterialArray()
		{
			IntPtr intPtr = Renderer.GetSharedMaterialArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0003AA44 File Offset: 0x00038C44
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x00006E88 File Offset: 0x00005088
		public Il2CppReferenceArray<Material> sharedMaterials
		{
			get
			{
				return this.GetSharedMaterialArray();
			}
			set
			{
				this.SetMaterialArray(value);
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0003AA5C File Offset: 0x00038C5C
		public void GetMaterials(List<Material> m)
		{
			bool flag = m == null;
			if (flag)
			{
				throw new ArgumentNullException("The result material list cannot be null.", "m");
			}
			NoAllocHelpers.EnsureListElemCount<Material>(m, this.GetMaterialCount());
			this.CopyMaterialArray(NoAllocHelpers.ExtractArrayFromListT<Material>(m));
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0003AA9C File Offset: 0x00038C9C
		public void SetSharedMaterials(List<Material> materials)
		{
			bool flag = materials == null;
			if (flag)
			{
				throw new ArgumentNullException("The material list to set cannot be null.", "materials");
			}
			this.SetMaterialArray(NoAllocHelpers.ExtractArrayFromListT<Material>(materials), materials.Count);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0003AAD8 File Offset: 0x00038CD8
		public void SetMaterials(List<Material> materials)
		{
			bool flag = materials == null;
			if (flag)
			{
				throw new ArgumentNullException("The material list to set cannot be null.", "materials");
			}
			this.SetMaterialArray(NoAllocHelpers.ExtractArrayFromListT<Material>(materials), materials.Count);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0003AB14 File Offset: 0x00038D14
		public void GetSharedMaterials(List<Material> m)
		{
			bool flag = m == null;
			if (flag)
			{
				throw new ArgumentNullException("The result material list cannot be null.", "m");
			}
			NoAllocHelpers.EnsureListElemCount<Material>(m, this.GetMaterialCount());
			this.CopySharedMaterialArray(NoAllocHelpers.ExtractArrayFromListT<Material>(m));
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00006E93 File Offset: 0x00005093
		public void set_bounds_Injected(ref Bounds value)
		{
			Renderer.set_bounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00006EA6 File Offset: 0x000050A6
		public void get_localBounds_Injected(out Bounds ret)
		{
			Renderer.get_localBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00006EB9 File Offset: 0x000050B9
		public void set_localBounds_Injected(ref Bounds value)
		{
			Renderer.set_localBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00006ECC File Offset: 0x000050CC
		public void SetStaticLightmapST_Injected(ref Vector4 st)
		{
			Renderer.SetStaticLightmapST_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref st);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00006EDF File Offset: 0x000050DF
		public void get_worldToLocalMatrix_Injected(out Matrix4x4 ret)
		{
			Renderer.get_worldToLocalMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00006EF2 File Offset: 0x000050F2
		public void get_localToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			Renderer.get_localToWorldMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00006F05 File Offset: 0x00005105
		public void GetLightmapST_Injected(global::UnityEngineInternal.LightmapType lt, out Vector4 ret)
		{
			Renderer.GetLightmapST_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), lt, out ret);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00006F19 File Offset: 0x00005119
		public void SetLightmapST_Injected(ref Vector4 st, global::UnityEngineInternal.LightmapType lt)
		{
			Renderer.SetLightmapST_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref st, lt);
		}

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Private_Material_0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterialArray_Private_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_Int32_0;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_get_materials_Public_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_set_materials_Public_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_set_Void_Material_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x040008E2 RID: 2274
		private static readonly Renderer.ResetBoundsDelegate ResetBoundsDelegateField;

		// Token: 0x040008E3 RID: 2275
		private static readonly Renderer.ResetLocalBoundsDelegate ResetLocalBoundsDelegateField;

		// Token: 0x040008E4 RID: 2276
		private static readonly Renderer.CopyMaterialArrayDelegate CopyMaterialArrayDelegateField;

		// Token: 0x040008E5 RID: 2277
		private static readonly Renderer.CopySharedMaterialArrayDelegate CopySharedMaterialArrayDelegateField;

		// Token: 0x040008E6 RID: 2278
		private static readonly Renderer.Internal_SetPropertyBlockDelegate Internal_SetPropertyBlockDelegateField;

		// Token: 0x040008E7 RID: 2279
		private static readonly Renderer.Internal_GetPropertyBlockDelegate Internal_GetPropertyBlockDelegateField;

		// Token: 0x040008E8 RID: 2280
		private static readonly Renderer.Internal_SetPropertyBlockMaterialIndexDelegate Internal_SetPropertyBlockMaterialIndexDelegateField;

		// Token: 0x040008E9 RID: 2281
		private static readonly Renderer.Internal_GetPropertyBlockMaterialIndexDelegate Internal_GetPropertyBlockMaterialIndexDelegateField;

		// Token: 0x040008EA RID: 2282
		private static readonly Renderer.HasPropertyBlockDelegate HasPropertyBlockDelegateField;

		// Token: 0x040008EB RID: 2283
		private static readonly Renderer.GetClosestReflectionProbesInternalDelegate GetClosestReflectionProbesInternalDelegateField;

		// Token: 0x040008EC RID: 2284
		private static readonly Renderer.get_isVisibleDelegate get_isVisibleDelegateField;

		// Token: 0x040008ED RID: 2285
		private static readonly Renderer.get_shadowCastingModeDelegate get_shadowCastingModeDelegateField;

		// Token: 0x040008EE RID: 2286
		private static readonly Renderer.get_receiveShadowsDelegate get_receiveShadowsDelegateField;

		// Token: 0x040008EF RID: 2287
		private static readonly Renderer.get_forceRenderingOffDelegate get_forceRenderingOffDelegateField;

		// Token: 0x040008F0 RID: 2288
		private static readonly Renderer.set_forceRenderingOffDelegate set_forceRenderingOffDelegateField;

		// Token: 0x040008F1 RID: 2289
		private static readonly Renderer.GetIsStaticShadowCasterDelegate GetIsStaticShadowCasterDelegateField;

		// Token: 0x040008F2 RID: 2290
		private static readonly Renderer.SetIsStaticShadowCasterDelegate SetIsStaticShadowCasterDelegateField;

		// Token: 0x040008F3 RID: 2291
		private static readonly Renderer.get_motionVectorGenerationModeDelegate get_motionVectorGenerationModeDelegateField;

		// Token: 0x040008F4 RID: 2292
		private static readonly Renderer.set_motionVectorGenerationModeDelegate set_motionVectorGenerationModeDelegateField;

		// Token: 0x040008F5 RID: 2293
		private static readonly Renderer.get_lightProbeUsageDelegate get_lightProbeUsageDelegateField;

		// Token: 0x040008F6 RID: 2294
		private static readonly Renderer.set_lightProbeUsageDelegate set_lightProbeUsageDelegateField;

		// Token: 0x040008F7 RID: 2295
		private static readonly Renderer.get_reflectionProbeUsageDelegate get_reflectionProbeUsageDelegateField;

		// Token: 0x040008F8 RID: 2296
		private static readonly Renderer.set_reflectionProbeUsageDelegate set_reflectionProbeUsageDelegateField;

		// Token: 0x040008F9 RID: 2297
		private static readonly Renderer.get_renderingLayerMaskDelegate get_renderingLayerMaskDelegateField;

		// Token: 0x040008FA RID: 2298
		private static readonly Renderer.set_renderingLayerMaskDelegate set_renderingLayerMaskDelegateField;

		// Token: 0x040008FB RID: 2299
		private static readonly Renderer.get_rendererPriorityDelegate get_rendererPriorityDelegateField;

		// Token: 0x040008FC RID: 2300
		private static readonly Renderer.set_rendererPriorityDelegate set_rendererPriorityDelegateField;

		// Token: 0x040008FD RID: 2301
		private static readonly Renderer.get_rayTracingModeDelegate get_rayTracingModeDelegateField;

		// Token: 0x040008FE RID: 2302
		private static readonly Renderer.set_rayTracingModeDelegate set_rayTracingModeDelegateField;

		// Token: 0x040008FF RID: 2303
		private static readonly Renderer.get_sortingLayerNameDelegate get_sortingLayerNameDelegateField;

		// Token: 0x04000900 RID: 2304
		private static readonly Renderer.set_sortingLayerNameDelegate set_sortingLayerNameDelegateField;

		// Token: 0x04000901 RID: 2305
		private static readonly Renderer.get_sortingKeyDelegate get_sortingKeyDelegateField;

		// Token: 0x04000902 RID: 2306
		private static readonly Renderer.set_sortingGroupIDDelegate set_sortingGroupIDDelegateField;

		// Token: 0x04000903 RID: 2307
		private static readonly Renderer.set_sortingGroupOrderDelegate set_sortingGroupOrderDelegateField;

		// Token: 0x04000904 RID: 2308
		private static readonly Renderer.get_sortingGroupKeyDelegate get_sortingGroupKeyDelegateField;

		// Token: 0x04000905 RID: 2309
		private static readonly Renderer.get_allowOcclusionWhenDynamicDelegate get_allowOcclusionWhenDynamicDelegateField;

		// Token: 0x04000906 RID: 2310
		private static readonly Renderer.set_allowOcclusionWhenDynamicDelegate set_allowOcclusionWhenDynamicDelegateField;

		// Token: 0x04000907 RID: 2311
		private static readonly Renderer.get_staticBatchRootTransformDelegate get_staticBatchRootTransformDelegateField;

		// Token: 0x04000908 RID: 2312
		private static readonly Renderer.set_staticBatchRootTransformDelegate set_staticBatchRootTransformDelegateField;

		// Token: 0x04000909 RID: 2313
		private static readonly Renderer.get_staticBatchIndexDelegate get_staticBatchIndexDelegateField;

		// Token: 0x0400090A RID: 2314
		private static readonly Renderer.SetStaticBatchInfoDelegate SetStaticBatchInfoDelegateField;

		// Token: 0x0400090B RID: 2315
		private static readonly Renderer.get_isPartOfStaticBatchDelegate get_isPartOfStaticBatchDelegateField;

		// Token: 0x0400090C RID: 2316
		private static readonly Renderer.get_lightProbeProxyVolumeOverrideDelegate get_lightProbeProxyVolumeOverrideDelegateField;

		// Token: 0x0400090D RID: 2317
		private static readonly Renderer.set_lightProbeProxyVolumeOverrideDelegate set_lightProbeProxyVolumeOverrideDelegateField;

		// Token: 0x0400090E RID: 2318
		private static readonly Renderer.get_probeAnchorDelegate get_probeAnchorDelegateField;

		// Token: 0x0400090F RID: 2319
		private static readonly Renderer.set_probeAnchorDelegate set_probeAnchorDelegateField;

		// Token: 0x04000910 RID: 2320
		private static readonly Renderer.GetLightmapIndexDelegate GetLightmapIndexDelegateField;

		// Token: 0x04000911 RID: 2321
		private static readonly Renderer.SetLightmapIndexDelegate SetLightmapIndexDelegateField;

		// Token: 0x04000912 RID: 2322
		private static readonly Renderer.GetMaterialCountDelegate GetMaterialCountDelegateField;

		// Token: 0x04000913 RID: 2323
		private static readonly Renderer.GetSharedMaterialArrayDelegate GetSharedMaterialArrayDelegateField;

		// Token: 0x04000914 RID: 2324
		private static readonly Renderer.set_bounds_InjectedDelegate set_bounds_InjectedDelegateField;

		// Token: 0x04000915 RID: 2325
		private static readonly Renderer.get_localBounds_InjectedDelegate get_localBounds_InjectedDelegateField;

		// Token: 0x04000916 RID: 2326
		private static readonly Renderer.set_localBounds_InjectedDelegate set_localBounds_InjectedDelegateField;

		// Token: 0x04000917 RID: 2327
		private static readonly Renderer.SetStaticLightmapST_InjectedDelegate SetStaticLightmapST_InjectedDelegateField;

		// Token: 0x04000918 RID: 2328
		private static readonly Renderer.get_worldToLocalMatrix_InjectedDelegate get_worldToLocalMatrix_InjectedDelegateField;

		// Token: 0x04000919 RID: 2329
		private static readonly Renderer.get_localToWorldMatrix_InjectedDelegate get_localToWorldMatrix_InjectedDelegateField;

		// Token: 0x0400091A RID: 2330
		private static readonly Renderer.GetLightmapST_InjectedDelegate GetLightmapST_InjectedDelegateField;

		// Token: 0x0400091B RID: 2331
		private static readonly Renderer.SetLightmapST_InjectedDelegate SetLightmapST_InjectedDelegateField;

		// Token: 0x020005CA RID: 1482
		// (Invoke) Token: 0x060034A5 RID: 13477
		private delegate void ResetBoundsDelegate(IntPtr @this);

		// Token: 0x020005CB RID: 1483
		// (Invoke) Token: 0x060034A7 RID: 13479
		private delegate void ResetLocalBoundsDelegate(IntPtr @this);

		// Token: 0x020005CC RID: 1484
		// (Invoke) Token: 0x060034A9 RID: 13481
		private delegate void CopyMaterialArrayDelegate(IntPtr @this, [Out] IntPtr m);

		// Token: 0x020005CD RID: 1485
		// (Invoke) Token: 0x060034AB RID: 13483
		private delegate void CopySharedMaterialArrayDelegate(IntPtr @this, [Out] IntPtr m);

		// Token: 0x020005CE RID: 1486
		// (Invoke) Token: 0x060034AD RID: 13485
		private delegate void Internal_SetPropertyBlockDelegate(IntPtr @this, IntPtr properties);

		// Token: 0x020005CF RID: 1487
		// (Invoke) Token: 0x060034AF RID: 13487
		private delegate void Internal_GetPropertyBlockDelegate(IntPtr @this, IntPtr dest);

		// Token: 0x020005D0 RID: 1488
		// (Invoke) Token: 0x060034B1 RID: 13489
		private delegate void Internal_SetPropertyBlockMaterialIndexDelegate(IntPtr @this, IntPtr properties, int materialIndex);

		// Token: 0x020005D1 RID: 1489
		// (Invoke) Token: 0x060034B3 RID: 13491
		private delegate void Internal_GetPropertyBlockMaterialIndexDelegate(IntPtr @this, IntPtr dest, int materialIndex);

		// Token: 0x020005D2 RID: 1490
		// (Invoke) Token: 0x060034B5 RID: 13493
		private delegate bool HasPropertyBlockDelegate(IntPtr @this);

		// Token: 0x020005D3 RID: 1491
		// (Invoke) Token: 0x060034B7 RID: 13495
		private delegate void GetClosestReflectionProbesInternalDelegate(IntPtr @this, IntPtr result);

		// Token: 0x020005D4 RID: 1492
		// (Invoke) Token: 0x060034B9 RID: 13497
		private delegate bool get_isVisibleDelegate(IntPtr @this);

		// Token: 0x020005D5 RID: 1493
		// (Invoke) Token: 0x060034BB RID: 13499
		private delegate UnityEngine.Rendering.ShadowCastingMode get_shadowCastingModeDelegate(IntPtr @this);

		// Token: 0x020005D6 RID: 1494
		// (Invoke) Token: 0x060034BD RID: 13501
		private delegate bool get_receiveShadowsDelegate(IntPtr @this);

		// Token: 0x020005D7 RID: 1495
		// (Invoke) Token: 0x060034BF RID: 13503
		private delegate bool get_forceRenderingOffDelegate(IntPtr @this);

		// Token: 0x020005D8 RID: 1496
		// (Invoke) Token: 0x060034C1 RID: 13505
		private delegate void set_forceRenderingOffDelegate(IntPtr @this, bool value);

		// Token: 0x020005D9 RID: 1497
		// (Invoke) Token: 0x060034C3 RID: 13507
		private delegate bool GetIsStaticShadowCasterDelegate(IntPtr @this);

		// Token: 0x020005DA RID: 1498
		// (Invoke) Token: 0x060034C5 RID: 13509
		private delegate void SetIsStaticShadowCasterDelegate(IntPtr @this, bool value);

		// Token: 0x020005DB RID: 1499
		// (Invoke) Token: 0x060034C7 RID: 13511
		private delegate MotionVectorGenerationMode get_motionVectorGenerationModeDelegate(IntPtr @this);

		// Token: 0x020005DC RID: 1500
		// (Invoke) Token: 0x060034C9 RID: 13513
		private delegate void set_motionVectorGenerationModeDelegate(IntPtr @this, MotionVectorGenerationMode value);

		// Token: 0x020005DD RID: 1501
		// (Invoke) Token: 0x060034CB RID: 13515
		private delegate UnityEngine.Rendering.LightProbeUsage get_lightProbeUsageDelegate(IntPtr @this);

		// Token: 0x020005DE RID: 1502
		// (Invoke) Token: 0x060034CD RID: 13517
		private delegate void set_lightProbeUsageDelegate(IntPtr @this, UnityEngine.Rendering.LightProbeUsage value);

		// Token: 0x020005DF RID: 1503
		// (Invoke) Token: 0x060034CF RID: 13519
		private delegate UnityEngine.Rendering.ReflectionProbeUsage get_reflectionProbeUsageDelegate(IntPtr @this);

		// Token: 0x020005E0 RID: 1504
		// (Invoke) Token: 0x060034D1 RID: 13521
		private delegate void set_reflectionProbeUsageDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeUsage value);

		// Token: 0x020005E1 RID: 1505
		// (Invoke) Token: 0x060034D3 RID: 13523
		private delegate uint get_renderingLayerMaskDelegate(IntPtr @this);

		// Token: 0x020005E2 RID: 1506
		// (Invoke) Token: 0x060034D5 RID: 13525
		private delegate void set_renderingLayerMaskDelegate(IntPtr @this, uint value);

		// Token: 0x020005E3 RID: 1507
		// (Invoke) Token: 0x060034D7 RID: 13527
		private delegate int get_rendererPriorityDelegate(IntPtr @this);

		// Token: 0x020005E4 RID: 1508
		// (Invoke) Token: 0x060034D9 RID: 13529
		private delegate void set_rendererPriorityDelegate(IntPtr @this, int value);

		// Token: 0x020005E5 RID: 1509
		// (Invoke) Token: 0x060034DB RID: 13531
		private delegate UnityEngine.Experimental.Rendering.RayTracingMode get_rayTracingModeDelegate(IntPtr @this);

		// Token: 0x020005E6 RID: 1510
		// (Invoke) Token: 0x060034DD RID: 13533
		private delegate void set_rayTracingModeDelegate(IntPtr @this, UnityEngine.Experimental.Rendering.RayTracingMode value);

		// Token: 0x020005E7 RID: 1511
		// (Invoke) Token: 0x060034DF RID: 13535
		private delegate IntPtr get_sortingLayerNameDelegate(IntPtr @this);

		// Token: 0x020005E8 RID: 1512
		// (Invoke) Token: 0x060034E1 RID: 13537
		private delegate void set_sortingLayerNameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020005E9 RID: 1513
		// (Invoke) Token: 0x060034E3 RID: 13539
		private delegate uint get_sortingKeyDelegate(IntPtr @this);

		// Token: 0x020005EA RID: 1514
		// (Invoke) Token: 0x060034E5 RID: 13541
		private delegate void set_sortingGroupIDDelegate(IntPtr @this, int value);

		// Token: 0x020005EB RID: 1515
		// (Invoke) Token: 0x060034E7 RID: 13543
		private delegate void set_sortingGroupOrderDelegate(IntPtr @this, int value);

		// Token: 0x020005EC RID: 1516
		// (Invoke) Token: 0x060034E9 RID: 13545
		private delegate uint get_sortingGroupKeyDelegate(IntPtr @this);

		// Token: 0x020005ED RID: 1517
		// (Invoke) Token: 0x060034EB RID: 13547
		private delegate bool get_allowOcclusionWhenDynamicDelegate(IntPtr @this);

		// Token: 0x020005EE RID: 1518
		// (Invoke) Token: 0x060034ED RID: 13549
		private delegate void set_allowOcclusionWhenDynamicDelegate(IntPtr @this, bool value);

		// Token: 0x020005EF RID: 1519
		// (Invoke) Token: 0x060034EF RID: 13551
		private delegate IntPtr get_staticBatchRootTransformDelegate(IntPtr @this);

		// Token: 0x020005F0 RID: 1520
		// (Invoke) Token: 0x060034F1 RID: 13553
		private delegate void set_staticBatchRootTransformDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020005F1 RID: 1521
		// (Invoke) Token: 0x060034F3 RID: 13555
		private delegate int get_staticBatchIndexDelegate(IntPtr @this);

		// Token: 0x020005F2 RID: 1522
		// (Invoke) Token: 0x060034F5 RID: 13557
		private delegate void SetStaticBatchInfoDelegate(IntPtr @this, int firstSubMesh, int subMeshCount);

		// Token: 0x020005F3 RID: 1523
		// (Invoke) Token: 0x060034F7 RID: 13559
		private delegate bool get_isPartOfStaticBatchDelegate(IntPtr @this);

		// Token: 0x020005F4 RID: 1524
		// (Invoke) Token: 0x060034F9 RID: 13561
		private delegate IntPtr get_lightProbeProxyVolumeOverrideDelegate(IntPtr @this);

		// Token: 0x020005F5 RID: 1525
		// (Invoke) Token: 0x060034FB RID: 13563
		private delegate void set_lightProbeProxyVolumeOverrideDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020005F6 RID: 1526
		// (Invoke) Token: 0x060034FD RID: 13565
		private delegate IntPtr get_probeAnchorDelegate(IntPtr @this);

		// Token: 0x020005F7 RID: 1527
		// (Invoke) Token: 0x060034FF RID: 13567
		private delegate void set_probeAnchorDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020005F8 RID: 1528
		// (Invoke) Token: 0x06003501 RID: 13569
		private delegate int GetLightmapIndexDelegate(IntPtr @this, global::UnityEngineInternal.LightmapType lt);

		// Token: 0x020005F9 RID: 1529
		// (Invoke) Token: 0x06003503 RID: 13571
		private delegate void SetLightmapIndexDelegate(IntPtr @this, int index, global::UnityEngineInternal.LightmapType lt);

		// Token: 0x020005FA RID: 1530
		// (Invoke) Token: 0x06003505 RID: 13573
		private delegate int GetMaterialCountDelegate(IntPtr @this);

		// Token: 0x020005FB RID: 1531
		// (Invoke) Token: 0x06003507 RID: 13575
		private delegate IntPtr GetSharedMaterialArrayDelegate(IntPtr @this);

		// Token: 0x020005FC RID: 1532
		// (Invoke) Token: 0x06003509 RID: 13577
		private delegate void set_bounds_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020005FD RID: 1533
		// (Invoke) Token: 0x0600350B RID: 13579
		private delegate void get_localBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020005FE RID: 1534
		// (Invoke) Token: 0x0600350D RID: 13581
		private delegate void set_localBounds_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020005FF RID: 1535
		// (Invoke) Token: 0x0600350F RID: 13583
		private delegate void SetStaticLightmapST_InjectedDelegate(IntPtr @this, IntPtr st);

		// Token: 0x02000600 RID: 1536
		// (Invoke) Token: 0x06003511 RID: 13585
		private delegate void get_worldToLocalMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000601 RID: 1537
		// (Invoke) Token: 0x06003513 RID: 13587
		private delegate void get_localToWorldMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000602 RID: 1538
		// (Invoke) Token: 0x06003515 RID: 13589
		private delegate void GetLightmapST_InjectedDelegate(IntPtr @this, global::UnityEngineInternal.LightmapType lt, [Out] IntPtr ret);

		// Token: 0x02000603 RID: 1539
		// (Invoke) Token: 0x06003517 RID: 13591
		private delegate void SetLightmapST_InjectedDelegate(IntPtr @this, IntPtr st, global::UnityEngineInternal.LightmapType lt);
	}
}
