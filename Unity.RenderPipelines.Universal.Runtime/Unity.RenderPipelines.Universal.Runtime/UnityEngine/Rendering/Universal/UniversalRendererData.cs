using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000F2 RID: 242
	[Serializable]
	public class UniversalRendererData : ScriptableRendererData
	{
		// Token: 0x060012F9 RID: 4857 RVA: 0x00056C64 File Offset: 0x00054E64
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalRendererData()
		{
			Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalRendererData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr);
			UniversalRendererData.NativeFieldInfoPtr_postProcessData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "postProcessData");
			UniversalRendererData.NativeFieldInfoPtr_xrSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "xrSystemData");
			UniversalRendererData.NativeFieldInfoPtr_shaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "shaders");
			UniversalRendererData.NativeFieldInfoPtr_k_LatestAssetVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "k_LatestAssetVersion");
			UniversalRendererData.NativeFieldInfoPtr_m_AssetVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_AssetVersion");
			UniversalRendererData.NativeFieldInfoPtr_m_OpaqueLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_OpaqueLayerMask");
			UniversalRendererData.NativeFieldInfoPtr_m_TransparentLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_TransparentLayerMask");
			UniversalRendererData.NativeFieldInfoPtr_m_DefaultStencilState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_DefaultStencilState");
			UniversalRendererData.NativeFieldInfoPtr_m_ShadowTransparentReceive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_ShadowTransparentReceive");
			UniversalRendererData.NativeFieldInfoPtr_m_RenderingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_RenderingMode");
			UniversalRendererData.NativeFieldInfoPtr_m_DepthPrimingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_DepthPrimingMode");
			UniversalRendererData.NativeFieldInfoPtr_m_CopyDepthMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_CopyDepthMode");
			UniversalRendererData.NativeFieldInfoPtr_m_AccurateGbufferNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_AccurateGbufferNormals");
			UniversalRendererData.NativeFieldInfoPtr_m_IntermediateTextureMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_IntermediateTextureMode");
			UniversalRendererData.NativeMethodInfoPtr_Create_Protected_Virtual_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665656);
			UniversalRendererData.NativeMethodInfoPtr_get_opaqueLayerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665657);
			UniversalRendererData.NativeMethodInfoPtr_set_opaqueLayerMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665658);
			UniversalRendererData.NativeMethodInfoPtr_get_transparentLayerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665659);
			UniversalRendererData.NativeMethodInfoPtr_set_transparentLayerMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665660);
			UniversalRendererData.NativeMethodInfoPtr_get_defaultStencilState_Public_get_StencilStateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665661);
			UniversalRendererData.NativeMethodInfoPtr_set_defaultStencilState_Public_set_Void_StencilStateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665662);
			UniversalRendererData.NativeMethodInfoPtr_get_shadowTransparentReceive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665663);
			UniversalRendererData.NativeMethodInfoPtr_set_shadowTransparentReceive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665664);
			UniversalRendererData.NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665665);
			UniversalRendererData.NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665666);
			UniversalRendererData.NativeMethodInfoPtr_get_depthPrimingMode_Public_get_DepthPrimingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665667);
			UniversalRendererData.NativeMethodInfoPtr_set_depthPrimingMode_Public_set_Void_DepthPrimingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665668);
			UniversalRendererData.NativeMethodInfoPtr_get_copyDepthMode_Public_get_CopyDepthMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665669);
			UniversalRendererData.NativeMethodInfoPtr_set_copyDepthMode_Public_set_Void_CopyDepthMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665670);
			UniversalRendererData.NativeMethodInfoPtr_get_accurateGbufferNormals_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665671);
			UniversalRendererData.NativeMethodInfoPtr_set_accurateGbufferNormals_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665672);
			UniversalRendererData.NativeMethodInfoPtr_get_intermediateTextureMode_Public_get_IntermediateTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665673);
			UniversalRendererData.NativeMethodInfoPtr_set_intermediateTextureMode_Public_set_Void_IntermediateTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665674);
			UniversalRendererData.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665675);
			UniversalRendererData.NativeMethodInfoPtr_ReloadAllNullProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665676);
			UniversalRendererData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665677);
			UniversalRendererData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665678);
			UniversalRendererData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100665679);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00056F8C File Offset: 0x0005518C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620478, XrefRangeEnd = 620486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ScriptableRenderer Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalRendererData.NativeMethodInfoPtr_Create_Protected_Virtual_ScriptableRenderer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr3) : null;
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00056FD8 File Offset: 0x000551D8
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x00057014 File Offset: 0x00055214
		public unsafe LayerMask opaqueLayerMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_get_opaqueLayerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620486, XrefRangeEnd = 620487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_set_opaqueLayerMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00057054 File Offset: 0x00055254
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x00057090 File Offset: 0x00055290
		public unsafe LayerMask transparentLayerMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_get_transparentLayerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620487, XrefRangeEnd = 620488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_set_transparentLayerMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x000570D0 File Offset: 0x000552D0
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x00057110 File Offset: 0x00055310
		public unsafe StencilStateData defaultStencilState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_get_defaultStencilState_Public_get_StencilStateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StencilStateData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620488, XrefRangeEnd = 620490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_set_defaultStencilState_Public_set_Void_StencilStateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x00057154 File Offset: 0x00055354
		// (set) Token: 0x06001302 RID: 4866 RVA: 0x00057190 File Offset: 0x00055390
		public unsafe bool shadowTransparentReceive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_get_shadowTransparentReceive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620490, XrefRangeEnd = 620491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_set_shadowTransparentReceive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x000571D0 File Offset: 0x000553D0
		// (set) Token: 0x06001304 RID: 4868 RVA: 0x0005720C File Offset: 0x0005540C
		public unsafe RenderingMode renderingMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368218, RefRangeEnd = 368219, XrefRangeStart = 368218, XrefRangeEnd = 368219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620491, XrefRangeEnd = 620492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x0005724C File Offset: 0x0005544C
		// (set) Token: 0x06001306 RID: 4870 RVA: 0x00057288 File Offset: 0x00055488
		public unsafe DepthPrimingMode depthPrimingMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_get_depthPrimingMode_Public_get_DepthPrimingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620492, XrefRangeEnd = 620493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_set_depthPrimingMode_Public_set_Void_DepthPrimingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x000572C8 File Offset: 0x000554C8
		// (set) Token: 0x06001308 RID: 4872 RVA: 0x00057304 File Offset: 0x00055504
		public unsafe CopyDepthMode copyDepthMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_get_copyDepthMode_Public_get_CopyDepthMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620493, XrefRangeEnd = 620494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_set_copyDepthMode_Public_set_Void_CopyDepthMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x00057344 File Offset: 0x00055544
		// (set) Token: 0x0600130A RID: 4874 RVA: 0x00057380 File Offset: 0x00055580
		public unsafe bool accurateGbufferNormals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_get_accurateGbufferNormals_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620494, XrefRangeEnd = 620495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_set_accurateGbufferNormals_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x000573C0 File Offset: 0x000555C0
		// (set) Token: 0x0600130C RID: 4876 RVA: 0x000573FC File Offset: 0x000555FC
		public unsafe IntermediateTextureMode intermediateTextureMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_get_intermediateTextureMode_Public_get_IntermediateTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620495, XrefRangeEnd = 620496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_set_intermediateTextureMode_Public_set_Void_IntermediateTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0005743C File Offset: 0x0005563C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620496, XrefRangeEnd = 620497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalRendererData.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00057478 File Offset: 0x00055678
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadAllNullProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_ReloadAllNullProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000574AC File Offset: 0x000556AC
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000574E0 File Offset: 0x000556E0
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00057514 File Offset: 0x00055714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620497, XrefRangeEnd = 620506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalRendererData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0000B3E0 File Offset: 0x000095E0
		public UniversalRendererData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x00057550 File Offset: 0x00055750
		// (set) Token: 0x06001314 RID: 4884 RVA: 0x0000B3E9 File Offset: 0x000095E9
		public unsafe PostProcessData postProcessData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_postProcessData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_postProcessData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x00057580 File Offset: 0x00055780
		// (set) Token: 0x06001316 RID: 4886 RVA: 0x0000B408 File Offset: 0x00009608
		public unsafe XRSystemData xrSystemData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_xrSystemData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XRSystemData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_xrSystemData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x000575B0 File Offset: 0x000557B0
		// (set) Token: 0x06001318 RID: 4888 RVA: 0x0000B427 File Offset: 0x00009627
		public unsafe UniversalRendererData.ShaderResources shaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_shaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRendererData.ShaderResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_shaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x000575E0 File Offset: 0x000557E0
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x0000B446 File Offset: 0x00009646
		public unsafe static int k_LatestAssetVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UniversalRendererData.NativeFieldInfoPtr_k_LatestAssetVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRendererData.NativeFieldInfoPtr_k_LatestAssetVersion, (void*)(&value));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x000575FC File Offset: 0x000557FC
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x0000B454 File Offset: 0x00009654
		public unsafe int m_AssetVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_AssetVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_AssetVersion)) = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x00057624 File Offset: 0x00055824
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x0000B46F File Offset: 0x0000966F
		public unsafe LayerMask m_OpaqueLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_OpaqueLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_OpaqueLayerMask)) = value;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x0005764C File Offset: 0x0005584C
		// (set) Token: 0x06001320 RID: 4896 RVA: 0x0000B48A File Offset: 0x0000968A
		public unsafe LayerMask m_TransparentLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_TransparentLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_TransparentLayerMask)) = value;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x00057674 File Offset: 0x00055874
		// (set) Token: 0x06001322 RID: 4898 RVA: 0x0000B4A5 File Offset: 0x000096A5
		public unsafe StencilStateData m_DefaultStencilState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_DefaultStencilState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StencilStateData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_DefaultStencilState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x000576A4 File Offset: 0x000558A4
		// (set) Token: 0x06001324 RID: 4900 RVA: 0x0000B4C4 File Offset: 0x000096C4
		public unsafe bool m_ShadowTransparentReceive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_ShadowTransparentReceive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_ShadowTransparentReceive)) = value;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x000576CC File Offset: 0x000558CC
		// (set) Token: 0x06001326 RID: 4902 RVA: 0x0000B4DF File Offset: 0x000096DF
		public unsafe RenderingMode m_RenderingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_RenderingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_RenderingMode)) = value;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x000576F4 File Offset: 0x000558F4
		// (set) Token: 0x06001328 RID: 4904 RVA: 0x0000B4FA File Offset: 0x000096FA
		public unsafe DepthPrimingMode m_DepthPrimingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_DepthPrimingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_DepthPrimingMode)) = value;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x0005771C File Offset: 0x0005591C
		// (set) Token: 0x0600132A RID: 4906 RVA: 0x0000B515 File Offset: 0x00009715
		public unsafe CopyDepthMode m_CopyDepthMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_CopyDepthMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_CopyDepthMode)) = value;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x00057744 File Offset: 0x00055944
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x0000B530 File Offset: 0x00009730
		public unsafe bool m_AccurateGbufferNormals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_AccurateGbufferNormals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_AccurateGbufferNormals)) = value;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0005776C File Offset: 0x0005596C
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x0000B54B File Offset: 0x0000974B
		public unsafe IntermediateTextureMode m_IntermediateTextureMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_IntermediateTextureMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.NativeFieldInfoPtr_m_IntermediateTextureMode)) = value;
			}
		}

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeFieldInfoPtr_postProcessData;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeFieldInfoPtr_xrSystemData;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeFieldInfoPtr_shaders;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeFieldInfoPtr_k_LatestAssetVersion;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetVersion;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeFieldInfoPtr_m_OpaqueLayerMask;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeFieldInfoPtr_m_TransparentLayerMask;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultStencilState;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowTransparentReceive;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderingMode;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthPrimingMode;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeFieldInfoPtr_m_CopyDepthMode;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeFieldInfoPtr_m_AccurateGbufferNormals;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeFieldInfoPtr_m_IntermediateTextureMode;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_Create_Protected_Virtual_ScriptableRenderer_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_get_opaqueLayerMask_Public_get_LayerMask_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_set_opaqueLayerMask_Public_set_Void_LayerMask_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_get_transparentLayerMask_Public_get_LayerMask_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr_set_transparentLayerMask_Public_set_Void_LayerMask_0;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultStencilState_Public_get_StencilStateData_0;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultStencilState_Public_set_Void_StencilStateData_0;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowTransparentReceive_Public_get_Boolean_0;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowTransparentReceive_Public_set_Void_Boolean_0;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr_get_depthPrimingMode_Public_get_DepthPrimingMode_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeMethodInfoPtr_set_depthPrimingMode_Public_set_Void_DepthPrimingMode_0;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeMethodInfoPtr_get_copyDepthMode_Public_get_CopyDepthMode_0;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeMethodInfoPtr_set_copyDepthMode_Public_set_Void_CopyDepthMode_0;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr_get_accurateGbufferNormals_Public_get_Boolean_0;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_set_accurateGbufferNormals_Public_set_Void_Boolean_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_get_intermediateTextureMode_Public_get_IntermediateTextureMode_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_set_intermediateTextureMode_Public_set_Void_IntermediateTextureMode_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_ReloadAllNullProperties_Private_Void_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001CD RID: 461
		[Serializable]
		public sealed class ShaderResources : Object
		{
			// Token: 0x06002096 RID: 8342 RVA: 0x0007EF28 File Offset: 0x0007D128
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderResources()
			{
				Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "ShaderResources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr);
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_blitPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "blitPS");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_copyDepthPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "copyDepthPS");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_screenSpaceShadowPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "screenSpaceShadowPS");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_samplingPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "samplingPS");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_stencilDeferredPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "stencilDeferredPS");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_fallbackErrorPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "fallbackErrorPS");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_fallbackLoadingPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "fallbackLoadingPS");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_materialErrorPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "materialErrorPS");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_coreBlitPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "coreBlitPS");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_coreBlitColorAndDepthPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "coreBlitColorAndDepthPS");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_blitHDROverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "blitHDROverlay");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_cameraMotionVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "cameraMotionVector");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_objectMotionVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "objectMotionVector");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_dataDrivenLensFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "dataDrivenLensFlare");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_terrainDetailLitPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "terrainDetailLitPS");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_terrainDetailGrassPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "terrainDetailGrassPS");
				UniversalRendererData.ShaderResources.NativeFieldInfoPtr_terrainDetailGrassBillboardPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, "terrainDetailGrassBillboardPS");
				UniversalRendererData.ShaderResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr, 100665680);
			}

			// Token: 0x06002097 RID: 8343 RVA: 0x0007F0BC File Offset: 0x0007D2BC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShaderResources()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRendererData.ShaderResources>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRendererData.ShaderResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002098 RID: 8344 RVA: 0x00012A92 File Offset: 0x00010C92
			public ShaderResources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BBB RID: 3003
			// (get) Token: 0x06002099 RID: 8345 RVA: 0x0007F0F8 File Offset: 0x0007D2F8
			// (set) Token: 0x0600209A RID: 8346 RVA: 0x00012A9B File Offset: 0x00010C9B
			public unsafe Shader blitPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_blitPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_blitPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BBC RID: 3004
			// (get) Token: 0x0600209B RID: 8347 RVA: 0x0007F128 File Offset: 0x0007D328
			// (set) Token: 0x0600209C RID: 8348 RVA: 0x00012ABA File Offset: 0x00010CBA
			public unsafe Shader copyDepthPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_copyDepthPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_copyDepthPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BBD RID: 3005
			// (get) Token: 0x0600209D RID: 8349 RVA: 0x0007F158 File Offset: 0x0007D358
			// (set) Token: 0x0600209E RID: 8350 RVA: 0x00012AD9 File Offset: 0x00010CD9
			public unsafe Shader screenSpaceShadowPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_screenSpaceShadowPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_screenSpaceShadowPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BBE RID: 3006
			// (get) Token: 0x0600209F RID: 8351 RVA: 0x0007F188 File Offset: 0x0007D388
			// (set) Token: 0x060020A0 RID: 8352 RVA: 0x00012AF8 File Offset: 0x00010CF8
			public unsafe Shader samplingPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_samplingPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_samplingPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BBF RID: 3007
			// (get) Token: 0x060020A1 RID: 8353 RVA: 0x0007F1B8 File Offset: 0x0007D3B8
			// (set) Token: 0x060020A2 RID: 8354 RVA: 0x00012B17 File Offset: 0x00010D17
			public unsafe Shader stencilDeferredPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_stencilDeferredPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_stencilDeferredPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC0 RID: 3008
			// (get) Token: 0x060020A3 RID: 8355 RVA: 0x0007F1E8 File Offset: 0x0007D3E8
			// (set) Token: 0x060020A4 RID: 8356 RVA: 0x00012B36 File Offset: 0x00010D36
			public unsafe Shader fallbackErrorPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_fallbackErrorPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_fallbackErrorPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC1 RID: 3009
			// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0007F218 File Offset: 0x0007D418
			// (set) Token: 0x060020A6 RID: 8358 RVA: 0x00012B55 File Offset: 0x00010D55
			public unsafe Shader fallbackLoadingPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_fallbackLoadingPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_fallbackLoadingPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC2 RID: 3010
			// (get) Token: 0x060020A7 RID: 8359 RVA: 0x0007F248 File Offset: 0x0007D448
			// (set) Token: 0x060020A8 RID: 8360 RVA: 0x00012B74 File Offset: 0x00010D74
			public unsafe Shader materialErrorPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_materialErrorPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_materialErrorPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC3 RID: 3011
			// (get) Token: 0x060020A9 RID: 8361 RVA: 0x0007F278 File Offset: 0x0007D478
			// (set) Token: 0x060020AA RID: 8362 RVA: 0x00012B93 File Offset: 0x00010D93
			public unsafe Shader coreBlitPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_coreBlitPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_coreBlitPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC4 RID: 3012
			// (get) Token: 0x060020AB RID: 8363 RVA: 0x0007F2A8 File Offset: 0x0007D4A8
			// (set) Token: 0x060020AC RID: 8364 RVA: 0x00012BB2 File Offset: 0x00010DB2
			public unsafe Shader coreBlitColorAndDepthPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_coreBlitColorAndDepthPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_coreBlitColorAndDepthPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC5 RID: 3013
			// (get) Token: 0x060020AD RID: 8365 RVA: 0x0007F2D8 File Offset: 0x0007D4D8
			// (set) Token: 0x060020AE RID: 8366 RVA: 0x00012BD1 File Offset: 0x00010DD1
			public unsafe Shader blitHDROverlay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_blitHDROverlay);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_blitHDROverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC6 RID: 3014
			// (get) Token: 0x060020AF RID: 8367 RVA: 0x0007F308 File Offset: 0x0007D508
			// (set) Token: 0x060020B0 RID: 8368 RVA: 0x00012BF0 File Offset: 0x00010DF0
			public unsafe Shader cameraMotionVector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_cameraMotionVector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_cameraMotionVector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC7 RID: 3015
			// (get) Token: 0x060020B1 RID: 8369 RVA: 0x0007F338 File Offset: 0x0007D538
			// (set) Token: 0x060020B2 RID: 8370 RVA: 0x00012C0F File Offset: 0x00010E0F
			public unsafe Shader objectMotionVector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_objectMotionVector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_objectMotionVector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC8 RID: 3016
			// (get) Token: 0x060020B3 RID: 8371 RVA: 0x0007F368 File Offset: 0x0007D568
			// (set) Token: 0x060020B4 RID: 8372 RVA: 0x00012C2E File Offset: 0x00010E2E
			public unsafe Shader dataDrivenLensFlare
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_dataDrivenLensFlare);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_dataDrivenLensFlare), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC9 RID: 3017
			// (get) Token: 0x060020B5 RID: 8373 RVA: 0x0007F398 File Offset: 0x0007D598
			// (set) Token: 0x060020B6 RID: 8374 RVA: 0x00012C4D File Offset: 0x00010E4D
			public unsafe Shader terrainDetailLitPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_terrainDetailLitPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_terrainDetailLitPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BCA RID: 3018
			// (get) Token: 0x060020B7 RID: 8375 RVA: 0x0007F3C8 File Offset: 0x0007D5C8
			// (set) Token: 0x060020B8 RID: 8376 RVA: 0x00012C6C File Offset: 0x00010E6C
			public unsafe Shader terrainDetailGrassPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_terrainDetailGrassPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_terrainDetailGrassPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BCB RID: 3019
			// (get) Token: 0x060020B9 RID: 8377 RVA: 0x0007F3F8 File Offset: 0x0007D5F8
			// (set) Token: 0x060020BA RID: 8378 RVA: 0x00012C8B File Offset: 0x00010E8B
			public unsafe Shader terrainDetailGrassBillboardPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_terrainDetailGrassBillboardPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRendererData.ShaderResources.NativeFieldInfoPtr_terrainDetailGrassBillboardPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400173C RID: 5948
			private static readonly IntPtr NativeFieldInfoPtr_blitPS;

			// Token: 0x0400173D RID: 5949
			private static readonly IntPtr NativeFieldInfoPtr_copyDepthPS;

			// Token: 0x0400173E RID: 5950
			private static readonly IntPtr NativeFieldInfoPtr_screenSpaceShadowPS;

			// Token: 0x0400173F RID: 5951
			private static readonly IntPtr NativeFieldInfoPtr_samplingPS;

			// Token: 0x04001740 RID: 5952
			private static readonly IntPtr NativeFieldInfoPtr_stencilDeferredPS;

			// Token: 0x04001741 RID: 5953
			private static readonly IntPtr NativeFieldInfoPtr_fallbackErrorPS;

			// Token: 0x04001742 RID: 5954
			private static readonly IntPtr NativeFieldInfoPtr_fallbackLoadingPS;

			// Token: 0x04001743 RID: 5955
			private static readonly IntPtr NativeFieldInfoPtr_materialErrorPS;

			// Token: 0x04001744 RID: 5956
			private static readonly IntPtr NativeFieldInfoPtr_coreBlitPS;

			// Token: 0x04001745 RID: 5957
			private static readonly IntPtr NativeFieldInfoPtr_coreBlitColorAndDepthPS;

			// Token: 0x04001746 RID: 5958
			private static readonly IntPtr NativeFieldInfoPtr_blitHDROverlay;

			// Token: 0x04001747 RID: 5959
			private static readonly IntPtr NativeFieldInfoPtr_cameraMotionVector;

			// Token: 0x04001748 RID: 5960
			private static readonly IntPtr NativeFieldInfoPtr_objectMotionVector;

			// Token: 0x04001749 RID: 5961
			private static readonly IntPtr NativeFieldInfoPtr_dataDrivenLensFlare;

			// Token: 0x0400174A RID: 5962
			private static readonly IntPtr NativeFieldInfoPtr_terrainDetailLitPS;

			// Token: 0x0400174B RID: 5963
			private static readonly IntPtr NativeFieldInfoPtr_terrainDetailGrassPS;

			// Token: 0x0400174C RID: 5964
			private static readonly IntPtr NativeFieldInfoPtr_terrainDetailGrassBillboardPS;

			// Token: 0x0400174D RID: 5965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
