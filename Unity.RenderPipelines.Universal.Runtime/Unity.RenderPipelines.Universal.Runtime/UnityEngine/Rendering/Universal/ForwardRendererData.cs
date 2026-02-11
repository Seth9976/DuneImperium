using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000084 RID: 132
	[Serializable]
	public class ForwardRendererData : ScriptableRendererData
	{
		// Token: 0x06000BDC RID: 3036 RVA: 0x0003EFE0 File Offset: 0x0003D1E0
		// Note: this type is marked as 'beforefieldinit'.
		static ForwardRendererData()
		{
			Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ForwardRendererData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr);
			ForwardRendererData.NativeFieldInfoPtr_k_ErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "k_ErrorMessage");
			ForwardRendererData.NativeFieldInfoPtr_shaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "shaders");
			ForwardRendererData.NativeFieldInfoPtr_postProcessData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "postProcessData");
			ForwardRendererData.NativeFieldInfoPtr_xrSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "xrSystemData");
			ForwardRendererData.NativeFieldInfoPtr_m_OpaqueLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "m_OpaqueLayerMask");
			ForwardRendererData.NativeFieldInfoPtr_m_TransparentLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "m_TransparentLayerMask");
			ForwardRendererData.NativeFieldInfoPtr_m_DefaultStencilState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "m_DefaultStencilState");
			ForwardRendererData.NativeFieldInfoPtr_m_ShadowTransparentReceive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "m_ShadowTransparentReceive");
			ForwardRendererData.NativeFieldInfoPtr_m_RenderingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "m_RenderingMode");
			ForwardRendererData.NativeFieldInfoPtr_m_DepthPrimingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "m_DepthPrimingMode");
			ForwardRendererData.NativeFieldInfoPtr_m_AccurateGbufferNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "m_AccurateGbufferNormals");
			ForwardRendererData.NativeFieldInfoPtr_m_ClusteredRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "m_ClusteredRendering");
			ForwardRendererData.NativeFieldInfoPtr_m_TileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "m_TileSize");
			ForwardRendererData.NativeMethodInfoPtr_Create_Protected_Virtual_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664877);
			ForwardRendererData.NativeMethodInfoPtr_get_opaqueLayerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664878);
			ForwardRendererData.NativeMethodInfoPtr_set_opaqueLayerMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664879);
			ForwardRendererData.NativeMethodInfoPtr_get_transparentLayerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664880);
			ForwardRendererData.NativeMethodInfoPtr_set_transparentLayerMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664881);
			ForwardRendererData.NativeMethodInfoPtr_get_defaultStencilState_Public_get_StencilStateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664882);
			ForwardRendererData.NativeMethodInfoPtr_set_defaultStencilState_Public_set_Void_StencilStateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664883);
			ForwardRendererData.NativeMethodInfoPtr_get_shadowTransparentReceive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664884);
			ForwardRendererData.NativeMethodInfoPtr_set_shadowTransparentReceive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664885);
			ForwardRendererData.NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664886);
			ForwardRendererData.NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664887);
			ForwardRendererData.NativeMethodInfoPtr_get_accurateGbufferNormals_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664888);
			ForwardRendererData.NativeMethodInfoPtr_set_accurateGbufferNormals_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664889);
			ForwardRendererData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, 100664890);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0003F22C File Offset: 0x0003D42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611088, XrefRangeEnd = 611098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ScriptableRenderer Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForwardRendererData.NativeMethodInfoPtr_Create_Protected_Virtual_ScriptableRenderer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr3) : null;
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x0003F278 File Offset: 0x0003D478
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x0003F2B4 File Offset: 0x0003D4B4
		public unsafe LayerMask opaqueLayerMask
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611098, XrefRangeEnd = 611104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.NativeMethodInfoPtr_get_opaqueLayerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611104, XrefRangeEnd = 611110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.NativeMethodInfoPtr_set_opaqueLayerMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0003F2F4 File Offset: 0x0003D4F4
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x0003F330 File Offset: 0x0003D530
		public unsafe LayerMask transparentLayerMask
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611110, XrefRangeEnd = 611116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.NativeMethodInfoPtr_get_transparentLayerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611116, XrefRangeEnd = 611122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.NativeMethodInfoPtr_set_transparentLayerMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0003F370 File Offset: 0x0003D570
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x0003F3B0 File Offset: 0x0003D5B0
		public unsafe StencilStateData defaultStencilState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611122, XrefRangeEnd = 611128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.NativeMethodInfoPtr_get_defaultStencilState_Public_get_StencilStateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StencilStateData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611128, XrefRangeEnd = 611134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.NativeMethodInfoPtr_set_defaultStencilState_Public_set_Void_StencilStateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0003F3F4 File Offset: 0x0003D5F4
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x0003F430 File Offset: 0x0003D630
		public unsafe bool shadowTransparentReceive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611134, XrefRangeEnd = 611140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.NativeMethodInfoPtr_get_shadowTransparentReceive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611140, XrefRangeEnd = 611146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.NativeMethodInfoPtr_set_shadowTransparentReceive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0003F470 File Offset: 0x0003D670
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x0003F4AC File Offset: 0x0003D6AC
		public unsafe RenderingMode renderingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611146, XrefRangeEnd = 611152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611152, XrefRangeEnd = 611158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x0003F4EC File Offset: 0x0003D6EC
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x0003F528 File Offset: 0x0003D728
		public unsafe bool accurateGbufferNormals
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611158, XrefRangeEnd = 611164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.NativeMethodInfoPtr_get_accurateGbufferNormals_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611164, XrefRangeEnd = 611170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.NativeMethodInfoPtr_set_accurateGbufferNormals_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0003F568 File Offset: 0x0003D768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611170, XrefRangeEnd = 611171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForwardRendererData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x000075DE File Offset: 0x000057DE
		public ForwardRendererData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0003F5A4 File Offset: 0x0003D7A4
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x000075E7 File Offset: 0x000057E7
		public unsafe static string k_ErrorMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ForwardRendererData.NativeFieldInfoPtr_k_ErrorMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ForwardRendererData.NativeFieldInfoPtr_k_ErrorMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0003F5C4 File Offset: 0x0003D7C4
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x000075F9 File Offset: 0x000057F9
		public unsafe ForwardRendererData.ShaderResources shaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_shaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ForwardRendererData.ShaderResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_shaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0003F5F4 File Offset: 0x0003D7F4
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00007618 File Offset: 0x00005818
		public unsafe PostProcessData postProcessData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_postProcessData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_postProcessData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0003F624 File Offset: 0x0003D824
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x00007637 File Offset: 0x00005837
		public unsafe XRSystemData xrSystemData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_xrSystemData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XRSystemData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_xrSystemData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0003F654 File Offset: 0x0003D854
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x00007656 File Offset: 0x00005856
		public unsafe LayerMask m_OpaqueLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_OpaqueLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_OpaqueLayerMask)) = value;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0003F67C File Offset: 0x0003D87C
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x00007671 File Offset: 0x00005871
		public unsafe LayerMask m_TransparentLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_TransparentLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_TransparentLayerMask)) = value;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0003F6A4 File Offset: 0x0003D8A4
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x0000768C File Offset: 0x0000588C
		public unsafe StencilStateData m_DefaultStencilState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_DefaultStencilState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StencilStateData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_DefaultStencilState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0003F6D4 File Offset: 0x0003D8D4
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x000076AB File Offset: 0x000058AB
		public unsafe bool m_ShadowTransparentReceive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_ShadowTransparentReceive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_ShadowTransparentReceive)) = value;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x0003F6FC File Offset: 0x0003D8FC
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x000076C6 File Offset: 0x000058C6
		public unsafe RenderingMode m_RenderingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_RenderingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_RenderingMode)) = value;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x0003F724 File Offset: 0x0003D924
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x000076E1 File Offset: 0x000058E1
		public unsafe DepthPrimingMode m_DepthPrimingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_DepthPrimingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_DepthPrimingMode)) = value;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x0003F74C File Offset: 0x0003D94C
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x000076FC File Offset: 0x000058FC
		public unsafe bool m_AccurateGbufferNormals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_AccurateGbufferNormals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_AccurateGbufferNormals)) = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0003F774 File Offset: 0x0003D974
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x00007717 File Offset: 0x00005917
		public unsafe bool m_ClusteredRendering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_ClusteredRendering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_ClusteredRendering)) = value;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x0003F79C File Offset: 0x0003D99C
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x00007732 File Offset: 0x00005932
		public unsafe TileSize m_TileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_TileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.NativeFieldInfoPtr_m_TileSize)) = value;
			}
		}

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeFieldInfoPtr_k_ErrorMessage;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeFieldInfoPtr_shaders;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr_postProcessData;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr_xrSystemData;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeFieldInfoPtr_m_OpaqueLayerMask;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeFieldInfoPtr_m_TransparentLayerMask;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultStencilState;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowTransparentReceive;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderingMode;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthPrimingMode;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeFieldInfoPtr_m_AccurateGbufferNormals;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeFieldInfoPtr_m_ClusteredRendering;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeFieldInfoPtr_m_TileSize;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_Create_Protected_Virtual_ScriptableRenderer_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_get_opaqueLayerMask_Public_get_LayerMask_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_set_opaqueLayerMask_Public_set_Void_LayerMask_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_get_transparentLayerMask_Public_get_LayerMask_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_set_transparentLayerMask_Public_set_Void_LayerMask_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultStencilState_Public_get_StencilStateData_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultStencilState_Public_set_Void_StencilStateData_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowTransparentReceive_Public_get_Boolean_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowTransparentReceive_Public_set_Void_Boolean_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_get_accurateGbufferNormals_Public_get_Boolean_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_set_accurateGbufferNormals_Public_set_Void_Boolean_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000191 RID: 401
		[Serializable]
		public sealed class ShaderResources : Object
		{
			// Token: 0x06001DA1 RID: 7585 RVA: 0x00077F48 File Offset: 0x00076148
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderResources()
			{
				Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForwardRendererData>.NativeClassPtr, "ShaderResources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr);
				ForwardRendererData.ShaderResources.NativeFieldInfoPtr_blitPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr, "blitPS");
				ForwardRendererData.ShaderResources.NativeFieldInfoPtr_copyDepthPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr, "copyDepthPS");
				ForwardRendererData.ShaderResources.NativeFieldInfoPtr_screenSpaceShadowPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr, "screenSpaceShadowPS");
				ForwardRendererData.ShaderResources.NativeFieldInfoPtr_samplingPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr, "samplingPS");
				ForwardRendererData.ShaderResources.NativeFieldInfoPtr_stencilDeferredPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr, "stencilDeferredPS");
				ForwardRendererData.ShaderResources.NativeFieldInfoPtr_fallbackErrorPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr, "fallbackErrorPS");
				ForwardRendererData.ShaderResources.NativeFieldInfoPtr_fallbackLoadingPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr, "fallbackLoadingPS");
				ForwardRendererData.ShaderResources.NativeFieldInfoPtr_materialErrorPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr, "materialErrorPS");
				ForwardRendererData.ShaderResources.NativeFieldInfoPtr_coreBlitPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr, "coreBlitPS");
				ForwardRendererData.ShaderResources.NativeFieldInfoPtr_coreBlitColorAndDepthPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr, "coreBlitColorAndDepthPS");
				ForwardRendererData.ShaderResources.NativeFieldInfoPtr_cameraMotionVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr, "cameraMotionVector");
				ForwardRendererData.ShaderResources.NativeFieldInfoPtr_objectMotionVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr, "objectMotionVector");
				ForwardRendererData.ShaderResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr, 100664891);
			}

			// Token: 0x06001DA2 RID: 7586 RVA: 0x00078078 File Offset: 0x00076278
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShaderResources()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForwardRendererData.ShaderResources>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRendererData.ShaderResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DA3 RID: 7587 RVA: 0x00011023 File Offset: 0x0000F223
			public ShaderResources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A95 RID: 2709
			// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x000780B4 File Offset: 0x000762B4
			// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x0001102C File Offset: 0x0000F22C
			public unsafe Shader blitPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_blitPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_blitPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A96 RID: 2710
			// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x000780E4 File Offset: 0x000762E4
			// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x0001104B File Offset: 0x0000F24B
			public unsafe Shader copyDepthPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_copyDepthPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_copyDepthPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A97 RID: 2711
			// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x00078114 File Offset: 0x00076314
			// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x0001106A File Offset: 0x0000F26A
			public unsafe Shader screenSpaceShadowPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_screenSpaceShadowPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_screenSpaceShadowPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A98 RID: 2712
			// (get) Token: 0x06001DAA RID: 7594 RVA: 0x00078144 File Offset: 0x00076344
			// (set) Token: 0x06001DAB RID: 7595 RVA: 0x00011089 File Offset: 0x0000F289
			public unsafe Shader samplingPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_samplingPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_samplingPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A99 RID: 2713
			// (get) Token: 0x06001DAC RID: 7596 RVA: 0x00078174 File Offset: 0x00076374
			// (set) Token: 0x06001DAD RID: 7597 RVA: 0x000110A8 File Offset: 0x0000F2A8
			public unsafe Shader stencilDeferredPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_stencilDeferredPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_stencilDeferredPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A9A RID: 2714
			// (get) Token: 0x06001DAE RID: 7598 RVA: 0x000781A4 File Offset: 0x000763A4
			// (set) Token: 0x06001DAF RID: 7599 RVA: 0x000110C7 File Offset: 0x0000F2C7
			public unsafe Shader fallbackErrorPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_fallbackErrorPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_fallbackErrorPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A9B RID: 2715
			// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x000781D4 File Offset: 0x000763D4
			// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x000110E6 File Offset: 0x0000F2E6
			public unsafe Shader fallbackLoadingPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_fallbackLoadingPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_fallbackLoadingPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A9C RID: 2716
			// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x00078204 File Offset: 0x00076404
			// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x00011105 File Offset: 0x0000F305
			public unsafe Shader materialErrorPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_materialErrorPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_materialErrorPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A9D RID: 2717
			// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x00078234 File Offset: 0x00076434
			// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x00011124 File Offset: 0x0000F324
			public unsafe Shader coreBlitPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_coreBlitPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_coreBlitPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A9E RID: 2718
			// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x00078264 File Offset: 0x00076464
			// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x00011143 File Offset: 0x0000F343
			public unsafe Shader coreBlitColorAndDepthPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_coreBlitColorAndDepthPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_coreBlitColorAndDepthPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A9F RID: 2719
			// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00078294 File Offset: 0x00076494
			// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x00011162 File Offset: 0x0000F362
			public unsafe Shader cameraMotionVector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_cameraMotionVector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_cameraMotionVector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AA0 RID: 2720
			// (get) Token: 0x06001DBA RID: 7610 RVA: 0x000782C4 File Offset: 0x000764C4
			// (set) Token: 0x06001DBB RID: 7611 RVA: 0x00011181 File Offset: 0x0000F381
			public unsafe Shader objectMotionVector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_objectMotionVector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardRendererData.ShaderResources.NativeFieldInfoPtr_objectMotionVector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001559 RID: 5465
			private static readonly IntPtr NativeFieldInfoPtr_blitPS;

			// Token: 0x0400155A RID: 5466
			private static readonly IntPtr NativeFieldInfoPtr_copyDepthPS;

			// Token: 0x0400155B RID: 5467
			private static readonly IntPtr NativeFieldInfoPtr_screenSpaceShadowPS;

			// Token: 0x0400155C RID: 5468
			private static readonly IntPtr NativeFieldInfoPtr_samplingPS;

			// Token: 0x0400155D RID: 5469
			private static readonly IntPtr NativeFieldInfoPtr_stencilDeferredPS;

			// Token: 0x0400155E RID: 5470
			private static readonly IntPtr NativeFieldInfoPtr_fallbackErrorPS;

			// Token: 0x0400155F RID: 5471
			private static readonly IntPtr NativeFieldInfoPtr_fallbackLoadingPS;

			// Token: 0x04001560 RID: 5472
			private static readonly IntPtr NativeFieldInfoPtr_materialErrorPS;

			// Token: 0x04001561 RID: 5473
			private static readonly IntPtr NativeFieldInfoPtr_coreBlitPS;

			// Token: 0x04001562 RID: 5474
			private static readonly IntPtr NativeFieldInfoPtr_coreBlitColorAndDepthPS;

			// Token: 0x04001563 RID: 5475
			private static readonly IntPtr NativeFieldInfoPtr_cameraMotionVector;

			// Token: 0x04001564 RID: 5476
			private static readonly IntPtr NativeFieldInfoPtr_objectMotionVector;

			// Token: 0x04001565 RID: 5477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
