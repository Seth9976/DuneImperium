using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.XR;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200000C RID: 12
	public static class XRSystem : Object
	{
		// Token: 0x060000F1 RID: 241 RVA: 0x00011060 File Offset: 0x0000F260
		// Note: this type is marked as 'beforefieldinit'.
		static XRSystem()
		{
			Il2CppClassPointerStore<XRSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XRSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRSystem>.NativeClassPtr);
			XRSystem.NativeFieldInfoPtr_s_Layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_Layout");
			XRSystem.NativeFieldInfoPtr_s_PassAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_PassAllocator");
			XRSystem.NativeFieldInfoPtr_s_DisplayList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_DisplayList");
			XRSystem.NativeFieldInfoPtr_s_Display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_Display");
			XRSystem.NativeFieldInfoPtr_s_MSAASamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_MSAASamples");
			XRSystem.NativeFieldInfoPtr_s_OcclusionMeshMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_OcclusionMeshMaterial");
			XRSystem.NativeFieldInfoPtr_s_MirrorViewMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_MirrorViewMaterial");
			XRSystem.NativeFieldInfoPtr_s_LayoutOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_LayoutOverride");
			XRSystem.NativeFieldInfoPtr_emptyPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "emptyPass");
			XRSystem.NativeFieldInfoPtr__singlePassAllowed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "<singlePassAllowed>k__BackingField");
			XRSystem.NativeFieldInfoPtr__foveatedRenderingCaps_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "<foveatedRenderingCaps>k__BackingField");
			XRSystem.NativeFieldInfoPtr__dumpDebugInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "<dumpDebugInfo>k__BackingField");
			XRSystem.NativeMethodInfoPtr_GetActiveDisplay_Public_Static_XRDisplaySubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663387);
			XRSystem.NativeMethodInfoPtr_get_displayActive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663388);
			XRSystem.NativeMethodInfoPtr_get_isHDRDisplayOutputActive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663389);
			XRSystem.NativeMethodInfoPtr_get_singlePassAllowed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663390);
			XRSystem.NativeMethodInfoPtr_set_singlePassAllowed_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663391);
			XRSystem.NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663392);
			XRSystem.NativeMethodInfoPtr_set_foveatedRenderingCaps_Public_Static_set_Void_FoveatedRenderingCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663393);
			XRSystem.NativeMethodInfoPtr_get_dumpDebugInfo_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663394);
			XRSystem.NativeMethodInfoPtr_set_dumpDebugInfo_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663395);
			XRSystem.NativeMethodInfoPtr_Initialize_Public_Static_Void_Func_2_XRPassCreateInfo_XRPass_Shader_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663396);
			XRSystem.NativeMethodInfoPtr_SetDisplayMSAASamples_Public_Static_Void_MSAASamples_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663397);
			XRSystem.NativeMethodInfoPtr_GetDisplayMSAASamples_Public_Static_MSAASamples_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663398);
			XRSystem.NativeMethodInfoPtr_SetRenderScale_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663399);
			XRSystem.NativeMethodInfoPtr_NewLayout_Public_Static_XRLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663400);
			XRSystem.NativeMethodInfoPtr_EndLayout_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663401);
			XRSystem.NativeMethodInfoPtr_RenderMirrorView_Public_Static_Void_CommandBuffer_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663402);
			XRSystem.NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663403);
			XRSystem.NativeMethodInfoPtr_SetDisplayZRange_Internal_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663404);
			XRSystem.NativeMethodInfoPtr_SetLayoutOverride_Private_Static_Void_Action_2_XRLayout_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663405);
			XRSystem.NativeMethodInfoPtr_XRSystemInit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663406);
			XRSystem.NativeMethodInfoPtr_RefreshDeviceInfo_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663407);
			XRSystem.NativeMethodInfoPtr_CreateDefaultLayout_Internal_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663408);
			XRSystem.NativeMethodInfoPtr_ReconfigurePass_Internal_Static_Void_XRPass_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663409);
			XRSystem.NativeMethodInfoPtr_CanUseSinglePass_Private_Static_Boolean_Camera_XRRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663410);
			XRSystem.NativeMethodInfoPtr_BuildView_Private_Static_XRView_XRRenderPass_XRRenderParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663411);
			XRSystem.NativeMethodInfoPtr_BuildPass_Private_Static_XRPassCreateInfo_XRRenderPass_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663412);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00011388 File Offset: 0x0000F588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954081, XrefRangeEnd = 954085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XRDisplaySubsystem GetActiveDisplay()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_GetActiveDisplay_Public_Static_XRDisplaySubsystem_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XRDisplaySubsystem>(intPtr3) : null;
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000113BC File Offset: 0x0000F5BC
		public unsafe static bool displayActive
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 954092, RefRangeEnd = 954098, XrefRangeStart = 954085, XrefRangeEnd = 954092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_get_displayActive_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000113EC File Offset: 0x0000F5EC
		public unsafe static bool isHDRDisplayOutputActive
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 954108, RefRangeEnd = 954110, XrefRangeStart = 954098, XrefRangeEnd = 954108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_get_isHDRDisplayOutputActive_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0001141C File Offset: 0x0000F61C
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0001144C File Offset: 0x0000F64C
		public unsafe static bool singlePassAllowed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954110, XrefRangeEnd = 954114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_get_singlePassAllowed_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954114, XrefRangeEnd = 954118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_set_singlePassAllowed_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00011480 File Offset: 0x0000F680
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000114B0 File Offset: 0x0000F6B0
		public unsafe static FoveatedRenderingCaps foveatedRenderingCaps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954118, XrefRangeEnd = 954122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954122, XrefRangeEnd = 954126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_set_foveatedRenderingCaps_Public_Static_set_Void_FoveatedRenderingCaps_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000114E4 File Offset: 0x0000F6E4
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00011514 File Offset: 0x0000F714
		public unsafe static bool dumpDebugInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954126, XrefRangeEnd = 954130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_get_dumpDebugInfo_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954130, XrefRangeEnd = 954134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_set_dumpDebugInfo_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00011548 File Offset: 0x0000F748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 954208, RefRangeEnd = 954209, XrefRangeStart = 954134, XrefRangeEnd = 954208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(Func<XRPassCreateInfo, XRPass> passAllocator, Shader occlusionMeshPS, Shader mirrorViewPS)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(passAllocator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occlusionMeshPS);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mirrorViewPS);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_Initialize_Public_Static_Void_Func_2_XRPassCreateInfo_XRPass_Shader_Shader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000115A4 File Offset: 0x0000F7A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 954241, RefRangeEnd = 954243, XrefRangeStart = 954209, XrefRangeEnd = 954241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDisplayMSAASamples(MSAASamples msaaSamples)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref msaaSamples;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_SetDisplayMSAASamples_Public_Static_Void_MSAASamples_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000115D8 File Offset: 0x0000F7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954243, XrefRangeEnd = 954247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MSAASamples GetDisplayMSAASamples()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_GetDisplayMSAASamples_Public_Static_MSAASamples_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00011608 File Offset: 0x0000F808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 954273, RefRangeEnd = 954275, XrefRangeStart = 954247, XrefRangeEnd = 954273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderScale(float renderScale)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderScale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_SetRenderScale_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001163C File Offset: 0x0000F83C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 954293, RefRangeEnd = 954294, XrefRangeStart = 954275, XrefRangeEnd = 954293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XRLayout NewLayout()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_NewLayout_Public_Static_XRLayout_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XRLayout>(intPtr3) : null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00011670 File Offset: 0x0000F870
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 954319, RefRangeEnd = 954321, XrefRangeStart = 954294, XrefRangeEnd = 954319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndLayout()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_EndLayout_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00011698 File Offset: 0x0000F898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 954329, RefRangeEnd = 954330, XrefRangeStart = 954321, XrefRangeEnd = 954329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderMirrorView(CommandBuffer cmd, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_RenderMirrorView_Public_Static_Void_CommandBuffer_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000116E0 File Offset: 0x0000F8E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 954363, RefRangeEnd = 954364, XrefRangeStart = 954330, XrefRangeEnd = 954363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_Dispose_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00011708 File Offset: 0x0000F908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954364, XrefRangeEnd = 954373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDisplayZRange(float zNear, float zFar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zNear;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_SetDisplayZRange_Internal_Static_Void_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00011748 File Offset: 0x0000F948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954373, XrefRangeEnd = 954379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLayoutOverride(Action<XRLayout, Camera> action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_SetLayoutOverride_Private_Static_Void_Action_2_XRLayout_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00011780 File Offset: 0x0000F980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954379, XrefRangeEnd = 954388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XRSystemInit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_XRSystemInit_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000117A8 File Offset: 0x0000F9A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 954436, RefRangeEnd = 954439, XrefRangeStart = 954388, XrefRangeEnd = 954436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshDeviceInfo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_RefreshDeviceInfo_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000117D0 File Offset: 0x0000F9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954439, XrefRangeEnd = 954508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateDefaultLayout(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_CreateDefaultLayout_Internal_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00011808 File Offset: 0x0000FA08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 954544, RefRangeEnd = 954545, XrefRangeStart = 954508, XrefRangeEnd = 954544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReconfigurePass(XRPass xrPass, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xrPass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_ReconfigurePass_Internal_Static_Void_XRPass_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00011850 File Offset: 0x0000FA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954545, XrefRangeEnd = 954557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanUseSinglePass(Camera camera, XRDisplaySubsystem.XRRenderPass renderPass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderPass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_CanUseSinglePass_Private_Static_Boolean_Camera_XRRenderPass_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000118A0 File Offset: 0x0000FAA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 954564, RefRangeEnd = 954567, XrefRangeStart = 954557, XrefRangeEnd = 954564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XRView BuildView(XRDisplaySubsystem.XRRenderPass renderPass, XRDisplaySubsystem.XRRenderParameter renderParameter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderPass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderParameter));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_BuildView_Private_Static_XRView_XRRenderPass_XRRenderParameter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new XRView(intPtr);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000118F0 File Offset: 0x0000FAF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 954582, RefRangeEnd = 954584, XrefRangeStart = 954567, XrefRangeEnd = 954582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XRPassCreateInfo BuildPass(XRDisplaySubsystem.XRRenderPass xrRenderPass, ScriptableCullingParameters cullingParameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xrRenderPass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cullingParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystem.NativeMethodInfoPtr_BuildPass_Private_Static_XRPassCreateInfo_XRRenderPass_ScriptableCullingParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new XRPassCreateInfo(intPtr);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000026BA File Offset: 0x000008BA
		public XRSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00011938 File Offset: 0x0000FB38
		// (set) Token: 0x0600010E RID: 270 RVA: 0x000026C3 File Offset: 0x000008C3
		public unsafe static XRLayout s_Layout
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRSystem.NativeFieldInfoPtr_s_Layout, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XRLayout>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRSystem.NativeFieldInfoPtr_s_Layout, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00011960 File Offset: 0x0000FB60
		// (set) Token: 0x06000110 RID: 272 RVA: 0x000026D5 File Offset: 0x000008D5
		public unsafe static Func<XRPassCreateInfo, XRPass> s_PassAllocator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRSystem.NativeFieldInfoPtr_s_PassAllocator, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<XRPassCreateInfo, XRPass>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRSystem.NativeFieldInfoPtr_s_PassAllocator, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00011988 File Offset: 0x0000FB88
		// (set) Token: 0x06000112 RID: 274 RVA: 0x000026E7 File Offset: 0x000008E7
		public unsafe static List<XRDisplaySubsystem> s_DisplayList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRSystem.NativeFieldInfoPtr_s_DisplayList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<XRDisplaySubsystem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRSystem.NativeFieldInfoPtr_s_DisplayList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000119B0 File Offset: 0x0000FBB0
		// (set) Token: 0x06000114 RID: 276 RVA: 0x000026F9 File Offset: 0x000008F9
		public unsafe static XRDisplaySubsystem s_Display
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRSystem.NativeFieldInfoPtr_s_Display, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XRDisplaySubsystem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRSystem.NativeFieldInfoPtr_s_Display, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000119D8 File Offset: 0x0000FBD8
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000270B File Offset: 0x0000090B
		public unsafe static MSAASamples s_MSAASamples
		{
			get
			{
				MSAASamples msaasamples;
				IL2CPP.il2cpp_field_static_get_value(XRSystem.NativeFieldInfoPtr_s_MSAASamples, (void*)(&msaasamples));
				return msaasamples;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRSystem.NativeFieldInfoPtr_s_MSAASamples, (void*)(&value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000117 RID: 279 RVA: 0x000119F4 File Offset: 0x0000FBF4
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00002719 File Offset: 0x00000919
		public unsafe static Material s_OcclusionMeshMaterial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRSystem.NativeFieldInfoPtr_s_OcclusionMeshMaterial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRSystem.NativeFieldInfoPtr_s_OcclusionMeshMaterial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00011A1C File Offset: 0x0000FC1C
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000272B File Offset: 0x0000092B
		public unsafe static Material s_MirrorViewMaterial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRSystem.NativeFieldInfoPtr_s_MirrorViewMaterial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRSystem.NativeFieldInfoPtr_s_MirrorViewMaterial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00011A44 File Offset: 0x0000FC44
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0000273D File Offset: 0x0000093D
		public unsafe static Action<XRLayout, Camera> s_LayoutOverride
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRSystem.NativeFieldInfoPtr_s_LayoutOverride, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<XRLayout, Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRSystem.NativeFieldInfoPtr_s_LayoutOverride, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00011A6C File Offset: 0x0000FC6C
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0000274F File Offset: 0x0000094F
		public unsafe static XRPass emptyPass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRSystem.NativeFieldInfoPtr_emptyPass, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XRPass>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRSystem.NativeFieldInfoPtr_emptyPass, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00011A94 File Offset: 0x0000FC94
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00002761 File Offset: 0x00000961
		public unsafe static bool _singlePassAllowed_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(XRSystem.NativeFieldInfoPtr__singlePassAllowed_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRSystem.NativeFieldInfoPtr__singlePassAllowed_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00011AB0 File Offset: 0x0000FCB0
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000276F File Offset: 0x0000096F
		public unsafe static FoveatedRenderingCaps _foveatedRenderingCaps_k__BackingField
		{
			get
			{
				FoveatedRenderingCaps foveatedRenderingCaps;
				IL2CPP.il2cpp_field_static_get_value(XRSystem.NativeFieldInfoPtr__foveatedRenderingCaps_k__BackingField, (void*)(&foveatedRenderingCaps));
				return foveatedRenderingCaps;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRSystem.NativeFieldInfoPtr__foveatedRenderingCaps_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00011ACC File Offset: 0x0000FCCC
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000277D File Offset: 0x0000097D
		public unsafe static bool _dumpDebugInfo_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(XRSystem.NativeFieldInfoPtr__dumpDebugInfo_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRSystem.NativeFieldInfoPtr__dumpDebugInfo_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_s_Layout;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_s_PassAllocator;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_s_DisplayList;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_s_Display;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_s_MSAASamples;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_s_OcclusionMeshMaterial;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_s_MirrorViewMaterial;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_s_LayoutOverride;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_emptyPass;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr__singlePassAllowed_k__BackingField;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr__foveatedRenderingCaps_k__BackingField;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr__dumpDebugInfo_k__BackingField;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveDisplay_Public_Static_XRDisplaySubsystem_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_get_displayActive_Public_Static_get_Boolean_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_get_isHDRDisplayOutputActive_Public_Static_get_Boolean_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_get_singlePassAllowed_Public_Static_get_Boolean_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_set_singlePassAllowed_Public_Static_set_Void_Boolean_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_set_foveatedRenderingCaps_Public_Static_set_Void_FoveatedRenderingCaps_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_get_dumpDebugInfo_Public_Static_get_Boolean_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_set_dumpDebugInfo_Public_Static_set_Void_Boolean_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Func_2_XRPassCreateInfo_XRPass_Shader_Shader_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayMSAASamples_Public_Static_Void_MSAASamples_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayMSAASamples_Public_Static_MSAASamples_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderScale_Public_Static_Void_Single_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_NewLayout_Public_Static_XRLayout_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_EndLayout_Public_Static_Void_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_RenderMirrorView_Public_Static_Void_CommandBuffer_Camera_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayZRange_Internal_Static_Void_Single_Single_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutOverride_Private_Static_Void_Action_2_XRLayout_Camera_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_XRSystemInit_Private_Static_Void_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDeviceInfo_Private_Static_Void_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultLayout_Internal_Static_Void_Camera_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_ReconfigurePass_Internal_Static_Void_XRPass_Camera_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_CanUseSinglePass_Private_Static_Boolean_Camera_XRRenderPass_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_BuildView_Private_Static_XRView_XRRenderPass_XRRenderParameter_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_BuildPass_Private_Static_XRPassCreateInfo_XRRenderPass_ScriptableCullingParameters_0;

		// Token: 0x02000144 RID: 324
		[ObfuscatedName("UnityEngine.Experimental.Rendering.XRSystem+<>O")]
		public static class __O : Object
		{
			// Token: 0x0600151E RID: 5406 RVA: 0x0000AA2F File Offset: 0x00008C2F
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<XRSystem.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRSystem.__O>.NativeClassPtr);
				XRSystem.__O.NativeFieldInfoPtr__0___OverrideLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem.__O>.NativeClassPtr, "<0>__OverrideLayout");
			}

			// Token: 0x0600151F RID: 5407 RVA: 0x0000AA63 File Offset: 0x00008C63
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005EC RID: 1516
			// (get) Token: 0x06001520 RID: 5408 RVA: 0x0005CE80 File Offset: 0x0005B080
			// (set) Token: 0x06001521 RID: 5409 RVA: 0x0000AA6C File Offset: 0x00008C6C
			public unsafe static Action<XRLayout, Camera> _0___OverrideLayout
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XRSystem.__O.NativeFieldInfoPtr__0___OverrideLayout, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<XRLayout, Camera>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XRSystem.__O.NativeFieldInfoPtr__0___OverrideLayout, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F8F RID: 3983
			private static readonly IntPtr NativeFieldInfoPtr__0___OverrideLayout;
		}
	}
}
