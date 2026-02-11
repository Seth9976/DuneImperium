using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200000B RID: 11
	public class XRPass : Object
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x00010008 File Offset: 0x0000E208
		// Note: this type is marked as 'beforefieldinit'.
		static XRPass()
		{
			Il2CppClassPointerStore<XRPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XRPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRPass>.NativeClassPtr);
			XRPass.NativeFieldInfoPtr_m_Views = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "m_Views");
			XRPass.NativeFieldInfoPtr_m_OcclusionMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "m_OcclusionMesh");
			XRPass.NativeFieldInfoPtr__copyDepth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<copyDepth>k__BackingField");
			XRPass.NativeFieldInfoPtr__multipassId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<multipassId>k__BackingField");
			XRPass.NativeFieldInfoPtr__cullingPassId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<cullingPassId>k__BackingField");
			XRPass.NativeFieldInfoPtr__renderTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<renderTarget>k__BackingField");
			XRPass.NativeFieldInfoPtr__renderTargetDesc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<renderTargetDesc>k__BackingField");
			XRPass.NativeFieldInfoPtr__cullingParams_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<cullingParams>k__BackingField");
			XRPass.NativeFieldInfoPtr__foveatedRenderingInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<foveatedRenderingInfo>k__BackingField");
			XRPass.NativeFieldInfoPtr__occlusionMeshScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<occlusionMeshScale>k__BackingField");
			XRPass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663346);
			XRPass.NativeMethodInfoPtr_CreateDefault_Public_Static_XRPass_XRPassCreateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663347);
			XRPass.NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663348);
			XRPass.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663349);
			XRPass.NativeMethodInfoPtr_get_supportsFoveatedRendering_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663350);
			XRPass.NativeMethodInfoPtr_get_copyDepth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663351);
			XRPass.NativeMethodInfoPtr_set_copyDepth_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663352);
			XRPass.NativeMethodInfoPtr_get_multipassId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663353);
			XRPass.NativeMethodInfoPtr_set_multipassId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663354);
			XRPass.NativeMethodInfoPtr_get_cullingPassId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663355);
			XRPass.NativeMethodInfoPtr_set_cullingPassId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663356);
			XRPass.NativeMethodInfoPtr_get_renderTarget_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663357);
			XRPass.NativeMethodInfoPtr_set_renderTarget_Private_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663358);
			XRPass.NativeMethodInfoPtr_get_renderTargetDesc_Public_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663359);
			XRPass.NativeMethodInfoPtr_set_renderTargetDesc_Private_set_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663360);
			XRPass.NativeMethodInfoPtr_get_cullingParams_Public_get_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663361);
			XRPass.NativeMethodInfoPtr_set_cullingParams_Private_set_Void_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663362);
			XRPass.NativeMethodInfoPtr_get_viewCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663363);
			XRPass.NativeMethodInfoPtr_get_singlePassEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663364);
			XRPass.NativeMethodInfoPtr_get_foveatedRenderingInfo_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663365);
			XRPass.NativeMethodInfoPtr_set_foveatedRenderingInfo_Private_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663366);
			XRPass.NativeMethodInfoPtr_get_isHDRDisplayOutputActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663367);
			XRPass.NativeMethodInfoPtr_get_hdrDisplayOutputColorGamut_Public_get_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663368);
			XRPass.NativeMethodInfoPtr_get_hdrDisplayOutputInformation_Public_get_HDRDisplayInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663369);
			XRPass.NativeMethodInfoPtr_get_occlusionMeshScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663370);
			XRPass.NativeMethodInfoPtr_set_occlusionMeshScale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663371);
			XRPass.NativeMethodInfoPtr_GetProjMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663372);
			XRPass.NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663373);
			XRPass.NativeMethodInfoPtr_GetViewport_Public_Rect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663374);
			XRPass.NativeMethodInfoPtr_GetOcclusionMesh_Public_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663375);
			XRPass.NativeMethodInfoPtr_GetTextureArraySlice_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663376);
			XRPass.NativeMethodInfoPtr_StartSinglePass_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663377);
			XRPass.NativeMethodInfoPtr_StopSinglePass_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663378);
			XRPass.NativeMethodInfoPtr_get_hasValidOcclusionMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663379);
			XRPass.NativeMethodInfoPtr_RenderOcclusionMesh_Public_Void_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663380);
			XRPass.NativeMethodInfoPtr_ApplyXRViewCenterOffset_Public_Vector4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663381);
			XRPass.NativeMethodInfoPtr_AssignView_Internal_Void_Int32_XRView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663382);
			XRPass.NativeMethodInfoPtr_AssignCullingParams_Internal_Void_Int32_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663383);
			XRPass.NativeMethodInfoPtr_UpdateCombinedOcclusionMesh_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663384);
			XRPass.NativeMethodInfoPtr_InitBase_Public_Void_XRPassCreateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663385);
			XRPass.NativeMethodInfoPtr_AddView_Internal_Void_XRView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663386);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00010434 File Offset: 0x0000E634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 953738, RefRangeEnd = 953739, XrefRangeStart = 953724, XrefRangeEnd = 953738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRPass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRPass>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00010470 File Offset: 0x0000E670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953739, XrefRangeEnd = 953766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XRPass CreateDefault(XRPassCreateInfo createInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(createInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_CreateDefault_Public_Static_XRPass_XRPassCreateInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XRPass>(intPtr3) : null;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000104BC File Offset: 0x0000E6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953766, XrefRangeEnd = 953772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XRPass.NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000104F8 File Offset: 0x0000E6F8
		public unsafe bool enabled
		{
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 953773, RefRangeEnd = 953842, XrefRangeStart = 953772, XrefRangeEnd = 953773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00010534 File Offset: 0x0000E734
		public unsafe bool supportsFoveatedRendering
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 953851, RefRangeEnd = 953864, XrefRangeStart = 953842, XrefRangeEnd = 953851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_supportsFoveatedRendering_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00010570 File Offset: 0x0000E770
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000105AC File Offset: 0x0000E7AC
		public unsafe bool copyDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_copyDepth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_set_copyDepth_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000105EC File Offset: 0x0000E7EC
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00010628 File Offset: 0x0000E828
		public unsafe int multipassId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_multipassId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_set_multipassId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00010668 File Offset: 0x0000E868
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000106A4 File Offset: 0x0000E8A4
		public unsafe int cullingPassId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_cullingPassId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_set_cullingPassId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000106E4 File Offset: 0x0000E8E4
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00010720 File Offset: 0x0000E920
		public unsafe RenderTargetIdentifier renderTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_renderTarget_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_set_renderTarget_Private_set_Void_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00010760 File Offset: 0x0000E960
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0001079C File Offset: 0x0000E99C
		public unsafe RenderTextureDescriptor renderTargetDesc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_renderTargetDesc_Public_get_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_set_renderTargetDesc_Private_set_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000107DC File Offset: 0x0000E9DC
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00010818 File Offset: 0x0000EA18
		public unsafe ScriptableCullingParameters cullingParams
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953864, XrefRangeEnd = 953865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_cullingParams_Public_get_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953865, XrefRangeEnd = 953866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_set_cullingParams_Private_set_Void_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00010858 File Offset: 0x0000EA58
		public unsafe int viewCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 953867, RefRangeEnd = 953871, XrefRangeStart = 953866, XrefRangeEnd = 953867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_viewCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00010894 File Offset: 0x0000EA94
		public unsafe bool singlePassEnabled
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 953872, RefRangeEnd = 953886, XrefRangeStart = 953871, XrefRangeEnd = 953872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_singlePassEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000108D0 File Offset: 0x0000EAD0
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0001090C File Offset: 0x0000EB0C
		public unsafe IntPtr foveatedRenderingInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_foveatedRenderingInfo_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_set_foveatedRenderingInfo_Private_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0001094C File Offset: 0x0000EB4C
		public unsafe bool isHDRDisplayOutputActive
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 953895, RefRangeEnd = 953897, XrefRangeStart = 953886, XrefRangeEnd = 953895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_isHDRDisplayOutputActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00010988 File Offset: 0x0000EB88
		public unsafe ColorGamut hdrDisplayOutputColorGamut
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 953906, RefRangeEnd = 953907, XrefRangeStart = 953897, XrefRangeEnd = 953906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_hdrDisplayOutputColorGamut_Public_get_ColorGamut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000109C4 File Offset: 0x0000EBC4
		public unsafe HDROutputUtils.HDRDisplayInformation hdrDisplayOutputInformation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953907, XrefRangeEnd = 953944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_hdrDisplayOutputInformation_Public_get_HDRDisplayInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00010A00 File Offset: 0x0000EC00
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00010A3C File Offset: 0x0000EC3C
		public unsafe float occlusionMeshScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_occlusionMeshScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_set_occlusionMeshScale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00010A7C File Offset: 0x0000EC7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 953947, RefRangeEnd = 953952, XrefRangeStart = 953944, XrefRangeEnd = 953947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetProjMatrix(int viewIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_GetProjMatrix_Public_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00010AC8 File Offset: 0x0000ECC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 953955, RefRangeEnd = 953959, XrefRangeStart = 953952, XrefRangeEnd = 953955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetViewMatrix(int viewIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00010B14 File Offset: 0x0000ED14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 953962, RefRangeEnd = 953967, XrefRangeStart = 953959, XrefRangeEnd = 953962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetViewport(int viewIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_GetViewport_Public_Rect_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00010B60 File Offset: 0x0000ED60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 953970, RefRangeEnd = 953971, XrefRangeStart = 953967, XrefRangeEnd = 953970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh GetOcclusionMesh(int viewIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_GetOcclusionMesh_Public_Mesh_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00010BAC File Offset: 0x0000EDAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 953974, RefRangeEnd = 953977, XrefRangeStart = 953971, XrefRangeEnd = 953974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTextureArraySlice(int viewIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_GetTextureArraySlice_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 953994, RefRangeEnd = 953999, XrefRangeStart = 953977, XrefRangeEnd = 953994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSinglePass(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_StartSinglePass_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00010C3C File Offset: 0x0000EE3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 954007, RefRangeEnd = 954011, XrefRangeStart = 953999, XrefRangeEnd = 954007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSinglePass(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_StopSinglePass_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00010C80 File Offset: 0x0000EE80
		public unsafe bool hasValidOcclusionMesh
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 954013, RefRangeEnd = 954016, XrefRangeStart = 954011, XrefRangeEnd = 954013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_get_hasValidOcclusionMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00010CBC File Offset: 0x0000EEBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 954017, RefRangeEnd = 954018, XrefRangeStart = 954016, XrefRangeEnd = 954017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderOcclusionMesh(CommandBuffer cmd, bool renderIntoTexture = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderIntoTexture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_RenderOcclusionMesh_Public_Void_CommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00010D0C File Offset: 0x0000EF0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 954030, RefRangeEnd = 954032, XrefRangeStart = 954018, XrefRangeEnd = 954030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 ApplyXRViewCenterOffset(Vector2 center)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_ApplyXRViewCenterOffset_Public_Vector4_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00010D58 File Offset: 0x0000EF58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 954036, RefRangeEnd = 954037, XrefRangeStart = 954032, XrefRangeEnd = 954036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignView(int viewId, XRView xrView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(xrView));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_AssignView_Internal_Void_Int32_XRView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00010DB0 File Offset: 0x0000EFB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 954043, RefRangeEnd = 954044, XrefRangeStart = 954037, XrefRangeEnd = 954043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignCullingParams(int cullingPassId, ScriptableCullingParameters cullingParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingPassId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cullingParams;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_AssignCullingParams_Internal_Void_Int32_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00010DFC File Offset: 0x0000EFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954044, XrefRangeEnd = 954046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCombinedOcclusionMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_UpdateCombinedOcclusionMesh_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00010E30 File Offset: 0x0000F030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 954067, RefRangeEnd = 954068, XrefRangeStart = 954046, XrefRangeEnd = 954067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitBase(XRPassCreateInfo createInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(createInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_InitBase_Public_Void_XRPassCreateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00010E78 File Offset: 0x0000F078
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 954079, RefRangeEnd = 954081, XrefRangeStart = 954068, XrefRangeEnd = 954079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddView(XRView xrView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(xrView));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPass.NativeMethodInfoPtr_AddView_Internal_Void_XRView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000259B File Offset: 0x0000079B
		public XRPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		// (set) Token: 0x060000DE RID: 222 RVA: 0x000025A4 File Offset: 0x000007A4
		public unsafe List<XRView> m_Views
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr_m_Views);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<XRView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr_m_Views), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000025C3 File Offset: 0x000007C3
		public unsafe XROcclusionMesh m_OcclusionMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr_m_OcclusionMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XROcclusionMesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr_m_OcclusionMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00010F20 File Offset: 0x0000F120
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000025E2 File Offset: 0x000007E2
		public unsafe bool _copyDepth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__copyDepth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__copyDepth_k__BackingField)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00010F48 File Offset: 0x0000F148
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000025FD File Offset: 0x000007FD
		public unsafe int _multipassId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__multipassId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__multipassId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00010F70 File Offset: 0x0000F170
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002618 File Offset: 0x00000818
		public unsafe int _cullingPassId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__cullingPassId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__cullingPassId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00010F98 File Offset: 0x0000F198
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002633 File Offset: 0x00000833
		public unsafe RenderTargetIdentifier _renderTarget_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__renderTarget_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__renderTarget_k__BackingField)) = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00010FC0 File Offset: 0x0000F1C0
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000264E File Offset: 0x0000084E
		public unsafe RenderTextureDescriptor _renderTargetDesc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__renderTargetDesc_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__renderTargetDesc_k__BackingField)) = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00010FE8 File Offset: 0x0000F1E8
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002669 File Offset: 0x00000869
		public unsafe ScriptableCullingParameters _cullingParams_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__cullingParams_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__cullingParams_k__BackingField)) = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00011010 File Offset: 0x0000F210
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002684 File Offset: 0x00000884
		public unsafe IntPtr _foveatedRenderingInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__foveatedRenderingInfo_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__foveatedRenderingInfo_k__BackingField)) = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00011038 File Offset: 0x0000F238
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000269F File Offset: 0x0000089F
		public unsafe float _occlusionMeshScale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__occlusionMeshScale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPass.NativeFieldInfoPtr__occlusionMeshScale_k__BackingField)) = value;
			}
		}

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_m_Views;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_m_OcclusionMesh;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr__copyDepth_k__BackingField;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr__multipassId_k__BackingField;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr__cullingPassId_k__BackingField;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr__renderTarget_k__BackingField;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr__renderTargetDesc_k__BackingField;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr__cullingParams_k__BackingField;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr__foveatedRenderingInfo_k__BackingField;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr__occlusionMeshScale_k__BackingField;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_XRPass_XRPassCreateInfo_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsFoveatedRendering_Public_get_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_get_copyDepth_Public_get_Boolean_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_set_copyDepth_Private_set_Void_Boolean_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_get_multipassId_Public_get_Int32_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_set_multipassId_Private_set_Void_Int32_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingPassId_Public_get_Int32_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_set_cullingPassId_Private_set_Void_Int32_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_get_renderTarget_Public_get_RenderTargetIdentifier_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_set_renderTarget_Private_set_Void_RenderTargetIdentifier_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_renderTargetDesc_Public_get_RenderTextureDescriptor_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_set_renderTargetDesc_Private_set_Void_RenderTextureDescriptor_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingParams_Public_get_ScriptableCullingParameters_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_set_cullingParams_Private_set_Void_ScriptableCullingParameters_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_viewCount_Public_get_Int32_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_singlePassEnabled_Public_get_Boolean_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_get_foveatedRenderingInfo_Public_get_IntPtr_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_set_foveatedRenderingInfo_Private_set_Void_IntPtr_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_get_isHDRDisplayOutputActive_Public_get_Boolean_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_get_hdrDisplayOutputColorGamut_Public_get_ColorGamut_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_get_hdrDisplayOutputInformation_Public_get_HDRDisplayInformation_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_occlusionMeshScale_Public_get_Single_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_set_occlusionMeshScale_Private_set_Void_Single_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_GetProjMatrix_Public_Matrix4x4_Int32_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_GetViewport_Public_Rect_Int32_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_GetOcclusionMesh_Public_Mesh_Int32_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureArraySlice_Public_Int32_Int32_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_StartSinglePass_Public_Void_CommandBuffer_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_StopSinglePass_Public_Void_CommandBuffer_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_get_hasValidOcclusionMesh_Public_get_Boolean_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_RenderOcclusionMesh_Public_Void_CommandBuffer_Boolean_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_ApplyXRViewCenterOffset_Public_Vector4_Vector2_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_AssignView_Internal_Void_Int32_XRView_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_AssignCullingParams_Internal_Void_Int32_ScriptableCullingParameters_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCombinedOcclusionMesh_Internal_Void_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_InitBase_Public_Void_XRPassCreateInfo_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_AddView_Internal_Void_XRView_0;
	}
}
