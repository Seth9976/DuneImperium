using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000C5 RID: 197
	public class DecalRendererFeature : ScriptableRendererFeature
	{
		// Token: 0x06000F27 RID: 3879 RVA: 0x000498E4 File Offset: 0x00047AE4
		// Note: this type is marked as 'beforefieldinit'.
		static DecalRendererFeature()
		{
			Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalRendererFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr);
			DecalRendererFeature.NativeFieldInfoPtr__sharedDecalEntityManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "<sharedDecalEntityManager>k__BackingField");
			DecalRendererFeature.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_Settings");
			DecalRendererFeature.NativeFieldInfoPtr_m_CopyDepthPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_CopyDepthPS");
			DecalRendererFeature.NativeFieldInfoPtr_m_DBufferClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DBufferClear");
			DecalRendererFeature.NativeFieldInfoPtr_m_Technique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_Technique");
			DecalRendererFeature.NativeFieldInfoPtr_m_DBufferSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DBufferSettings");
			DecalRendererFeature.NativeFieldInfoPtr_m_ScreenSpaceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_ScreenSpaceSettings");
			DecalRendererFeature.NativeFieldInfoPtr_m_RecreateSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_RecreateSystems");
			DecalRendererFeature.NativeFieldInfoPtr_m_CopyDepthPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_CopyDepthPass");
			DecalRendererFeature.NativeFieldInfoPtr_m_DecalPreviewPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalPreviewPass");
			DecalRendererFeature.NativeFieldInfoPtr_m_CopyDepthMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_CopyDepthMaterial");
			DecalRendererFeature.NativeFieldInfoPtr_m_DecalEntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalEntityManager");
			DecalRendererFeature.NativeFieldInfoPtr_m_DecalUpdateCachedSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalUpdateCachedSystem");
			DecalRendererFeature.NativeFieldInfoPtr_m_DecalUpdateCullingGroupSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalUpdateCullingGroupSystem");
			DecalRendererFeature.NativeFieldInfoPtr_m_DecalUpdateCulledSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalUpdateCulledSystem");
			DecalRendererFeature.NativeFieldInfoPtr_m_DecalCreateDrawCallSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalCreateDrawCallSystem");
			DecalRendererFeature.NativeFieldInfoPtr_m_DrawErrorSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DrawErrorSystem");
			DecalRendererFeature.NativeFieldInfoPtr_m_DBufferRenderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DBufferRenderPass");
			DecalRendererFeature.NativeFieldInfoPtr_m_ForwardEmissivePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_ForwardEmissivePass");
			DecalRendererFeature.NativeFieldInfoPtr_m_DecalDrawDBufferSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalDrawDBufferSystem");
			DecalRendererFeature.NativeFieldInfoPtr_m_DecalDrawForwardEmissiveSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalDrawForwardEmissiveSystem");
			DecalRendererFeature.NativeFieldInfoPtr_m_DBufferClearMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DBufferClearMaterial");
			DecalRendererFeature.NativeFieldInfoPtr_m_ScreenSpaceDecalRenderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_ScreenSpaceDecalRenderPass");
			DecalRendererFeature.NativeFieldInfoPtr_m_DecalDrawScreenSpaceSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalDrawScreenSpaceSystem");
			DecalRendererFeature.NativeFieldInfoPtr_m_DecalSkipCulledSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalSkipCulledSystem");
			DecalRendererFeature.NativeFieldInfoPtr_m_GBufferRenderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_GBufferRenderPass");
			DecalRendererFeature.NativeFieldInfoPtr_m_DrawGBufferSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DrawGBufferSystem");
			DecalRendererFeature.NativeFieldInfoPtr_m_DeferredLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DeferredLights");
			DecalRendererFeature.NativeMethodInfoPtr_get_sharedDecalEntityManager_Private_Static_get_SharedDecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665216);
			DecalRendererFeature.NativeMethodInfoPtr_get_settings_Internal_get_byref_DecalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665217);
			DecalRendererFeature.NativeMethodInfoPtr_get_intermediateRendering_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665218);
			DecalRendererFeature.NativeMethodInfoPtr_get_requiresDecalLayers_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665219);
			DecalRendererFeature.NativeMethodInfoPtr_get_isGLDevice_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665220);
			DecalRendererFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665221);
			DecalRendererFeature.NativeMethodInfoPtr_RequireRenderingLayers_Internal_Virtual_Boolean_Boolean_Boolean_byref_Event_byref_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665222);
			DecalRendererFeature.NativeMethodInfoPtr_GetDBufferSettings_Internal_DBufferSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665223);
			DecalRendererFeature.NativeMethodInfoPtr_GetScreenSpaceSettings_Internal_DecalScreenSpaceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665224);
			DecalRendererFeature.NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_ScriptableRendererData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665225);
			DecalRendererFeature.NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665226);
			DecalRendererFeature.NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665227);
			DecalRendererFeature.NativeMethodInfoPtr_IsAutomaticDBuffer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665228);
			DecalRendererFeature.NativeMethodInfoPtr_RecreateSystemsIfNeeded_Private_Boolean_ScriptableRenderer_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665229);
			DecalRendererFeature.NativeMethodInfoPtr_OnCameraPreCull_Public_Virtual_Void_ScriptableRenderer_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665230);
			DecalRendererFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665231);
			DecalRendererFeature.NativeMethodInfoPtr_SupportsNativeRenderPass_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665232);
			DecalRendererFeature.NativeMethodInfoPtr_SetupRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665233);
			DecalRendererFeature.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665234);
			DecalRendererFeature.NativeMethodInfoPtr_ChangeAdaptivePerformanceDrawDistances_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665235);
			DecalRendererFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665236);
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00049CE8 File Offset: 0x00047EE8
		public unsafe static SharedDecalEntityManager sharedDecalEntityManager
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615010, XrefRangeEnd = 615014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr_get_sharedDecalEntityManager_Private_Static_get_SharedDecalEntityManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedDecalEntityManager>(intPtr3) : null;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00049D1C File Offset: 0x00047F1C
		public unsafe ref DecalSettings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr_get_settings_Internal_get_byref_DecalSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x00049D50 File Offset: 0x00047F50
		public unsafe bool intermediateRendering
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr_get_intermediateRendering_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x00049D8C File Offset: 0x00047F8C
		public unsafe bool requiresDecalLayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr_get_requiresDecalLayers_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x00049DC8 File Offset: 0x00047FC8
		public unsafe static bool isGLDevice
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 615017, RefRangeEnd = 615018, XrefRangeStart = 615014, XrefRangeEnd = 615017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr_get_isGLDevice_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00049DF8 File Offset: 0x00047FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615018, XrefRangeEnd = 615023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalRendererFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00049E34 File Offset: 0x00048034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615023, XrefRangeEnd = 615028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isDeferred;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needsGBufferAccurateNormals;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &atEvent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maskSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalRendererFeature.NativeMethodInfoPtr_RequireRenderingLayers_Internal_Virtual_Boolean_Boolean_Boolean_byref_Event_byref_MaskSize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00049EB4 File Offset: 0x000480B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615028, XrefRangeEnd = 615029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBufferSettings GetDBufferSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr_GetDBufferSettings_Internal_DBufferSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBufferSettings>(intPtr3) : null;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00049EF4 File Offset: 0x000480F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615029, XrefRangeEnd = 615030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalScreenSpaceSettings GetScreenSpaceSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr_GetScreenSpaceSettings_Internal_DecalScreenSpaceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecalScreenSpaceSettings>(intPtr3) : null;
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00049F34 File Offset: 0x00048134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615030, XrefRangeEnd = 615041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalTechnique GetTechnique(ScriptableRendererData renderer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_ScriptableRendererData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00049F84 File Offset: 0x00048184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615041, XrefRangeEnd = 615048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalTechnique GetTechnique(ScriptableRenderer renderer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_ScriptableRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00049FD4 File Offset: 0x000481D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 615071, RefRangeEnd = 615075, XrefRangeStart = 615048, XrefRangeEnd = 615071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalTechnique GetTechnique(bool isDeferred, bool needsGBufferAccurateNormals, bool checkForInvalidTechniques = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isDeferred;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needsGBufferAccurateNormals;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkForInvalidTechniques;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0004A03C File Offset: 0x0004823C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615075, XrefRangeEnd = 615080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAutomaticDBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr_IsAutomaticDBuffer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0004A078 File Offset: 0x00048278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 615192, RefRangeEnd = 615194, XrefRangeStart = 615080, XrefRangeEnd = 615192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RecreateSystemsIfNeeded(ScriptableRenderer renderer, [In] ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr_RecreateSystemsIfNeeded_Private_Boolean_ScriptableRenderer_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0004A0D8 File Offset: 0x000482D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615194, XrefRangeEnd = 615205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraPreCull(ScriptableRenderer renderer, [In] ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalRendererFeature.NativeMethodInfoPtr_OnCameraPreCull_Public_Virtual_Void_ScriptableRenderer_byref_CameraData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0004A138 File Offset: 0x00048338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615205, XrefRangeEnd = 615214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalRendererFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0004A198 File Offset: 0x00048398
		[CallerCount(0)]
		public unsafe override bool SupportsNativeRenderPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalRendererFeature.NativeMethodInfoPtr_SupportsNativeRenderPass_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0004A1E0 File Offset: 0x000483E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615214, XrefRangeEnd = 615218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetupRenderPasses(ScriptableRenderer renderer, [In] ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalRendererFeature.NativeMethodInfoPtr_SetupRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0004A240 File Offset: 0x00048440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615218, XrefRangeEnd = 615266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalRendererFeature.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0004A28C File Offset: 0x0004848C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAdaptivePerformanceDrawDistances()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr_ChangeAdaptivePerformanceDrawDistances_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0004A2C0 File Offset: 0x000484C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615266, XrefRangeEnd = 615272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalRendererFeature()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalRendererFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0000951A File Offset: 0x0000771A
		public DecalRendererFeature(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x0004A2FC File Offset: 0x000484FC
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x00009523 File Offset: 0x00007723
		public unsafe static SharedDecalEntityManager _sharedDecalEntityManager_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecalRendererFeature.NativeFieldInfoPtr__sharedDecalEntityManager_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SharedDecalEntityManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalRendererFeature.NativeFieldInfoPtr__sharedDecalEntityManager_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x0004A324 File Offset: 0x00048524
		// (set) Token: 0x06000F41 RID: 3905 RVA: 0x00009535 File Offset: 0x00007735
		public unsafe DecalSettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x0004A354 File Offset: 0x00048554
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x00009554 File Offset: 0x00007754
		public unsafe Shader m_CopyDepthPS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_CopyDepthPS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_CopyDepthPS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x0004A384 File Offset: 0x00048584
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x00009573 File Offset: 0x00007773
		public unsafe Shader m_DBufferClear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DBufferClear);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DBufferClear), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x0004A3B4 File Offset: 0x000485B4
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x00009592 File Offset: 0x00007792
		public unsafe DecalTechnique m_Technique
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_Technique);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_Technique)) = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x0004A3DC File Offset: 0x000485DC
		// (set) Token: 0x06000F49 RID: 3913 RVA: 0x000095AD File Offset: 0x000077AD
		public unsafe DBufferSettings m_DBufferSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DBufferSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBufferSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DBufferSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x0004A40C File Offset: 0x0004860C
		// (set) Token: 0x06000F4B RID: 3915 RVA: 0x000095CC File Offset: 0x000077CC
		public unsafe DecalScreenSpaceSettings m_ScreenSpaceSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_ScreenSpaceSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalScreenSpaceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_ScreenSpaceSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x0004A43C File Offset: 0x0004863C
		// (set) Token: 0x06000F4D RID: 3917 RVA: 0x000095EB File Offset: 0x000077EB
		public unsafe bool m_RecreateSystems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_RecreateSystems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_RecreateSystems)) = value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x0004A464 File Offset: 0x00048664
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x00009606 File Offset: 0x00007806
		public unsafe CopyDepthPass m_CopyDepthPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_CopyDepthPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyDepthPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_CopyDepthPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x0004A494 File Offset: 0x00048694
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x00009625 File Offset: 0x00007825
		public unsafe DecalPreviewPass m_DecalPreviewPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalPreviewPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalPreviewPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalPreviewPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x0004A4C4 File Offset: 0x000486C4
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x00009644 File Offset: 0x00007844
		public unsafe Material m_CopyDepthMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_CopyDepthMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_CopyDepthMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x0004A4F4 File Offset: 0x000486F4
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x00009663 File Offset: 0x00007863
		public unsafe DecalEntityManager m_DecalEntityManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalEntityManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalEntityManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalEntityManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x0004A524 File Offset: 0x00048724
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x00009682 File Offset: 0x00007882
		public unsafe DecalUpdateCachedSystem m_DecalUpdateCachedSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalUpdateCachedSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalUpdateCachedSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalUpdateCachedSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x0004A554 File Offset: 0x00048754
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x000096A1 File Offset: 0x000078A1
		public unsafe DecalUpdateCullingGroupSystem m_DecalUpdateCullingGroupSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalUpdateCullingGroupSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalUpdateCullingGroupSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalUpdateCullingGroupSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x0004A584 File Offset: 0x00048784
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x000096C0 File Offset: 0x000078C0
		public unsafe DecalUpdateCulledSystem m_DecalUpdateCulledSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalUpdateCulledSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalUpdateCulledSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalUpdateCulledSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x0004A5B4 File Offset: 0x000487B4
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x000096DF File Offset: 0x000078DF
		public unsafe DecalCreateDrawCallSystem m_DecalCreateDrawCallSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalCreateDrawCallSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalCreateDrawCallSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalCreateDrawCallSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x0004A5E4 File Offset: 0x000487E4
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x000096FE File Offset: 0x000078FE
		public unsafe DecalDrawErrorSystem m_DrawErrorSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DrawErrorSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalDrawErrorSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DrawErrorSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0004A614 File Offset: 0x00048814
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x0000971D File Offset: 0x0000791D
		public unsafe DBufferRenderPass m_DBufferRenderPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DBufferRenderPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBufferRenderPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DBufferRenderPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0004A644 File Offset: 0x00048844
		// (set) Token: 0x06000F63 RID: 3939 RVA: 0x0000973C File Offset: 0x0000793C
		public unsafe DecalForwardEmissivePass m_ForwardEmissivePass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_ForwardEmissivePass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalForwardEmissivePass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_ForwardEmissivePass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0004A674 File Offset: 0x00048874
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x0000975B File Offset: 0x0000795B
		public unsafe DecalDrawDBufferSystem m_DecalDrawDBufferSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalDrawDBufferSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalDrawDBufferSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalDrawDBufferSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x0004A6A4 File Offset: 0x000488A4
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x0000977A File Offset: 0x0000797A
		public unsafe DecalDrawFowardEmissiveSystem m_DecalDrawForwardEmissiveSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalDrawForwardEmissiveSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalDrawFowardEmissiveSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalDrawForwardEmissiveSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0004A6D4 File Offset: 0x000488D4
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x00009799 File Offset: 0x00007999
		public unsafe Material m_DBufferClearMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DBufferClearMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DBufferClearMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x0004A704 File Offset: 0x00048904
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x000097B8 File Offset: 0x000079B8
		public unsafe DecalScreenSpaceRenderPass m_ScreenSpaceDecalRenderPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_ScreenSpaceDecalRenderPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalScreenSpaceRenderPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_ScreenSpaceDecalRenderPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0004A734 File Offset: 0x00048934
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x000097D7 File Offset: 0x000079D7
		public unsafe DecalDrawScreenSpaceSystem m_DecalDrawScreenSpaceSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalDrawScreenSpaceSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalDrawScreenSpaceSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalDrawScreenSpaceSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x0004A764 File Offset: 0x00048964
		// (set) Token: 0x06000F6F RID: 3951 RVA: 0x000097F6 File Offset: 0x000079F6
		public unsafe DecalSkipCulledSystem m_DecalSkipCulledSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalSkipCulledSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalSkipCulledSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DecalSkipCulledSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x0004A794 File Offset: 0x00048994
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x00009815 File Offset: 0x00007A15
		public unsafe DecalGBufferRenderPass m_GBufferRenderPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_GBufferRenderPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalGBufferRenderPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_GBufferRenderPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x0004A7C4 File Offset: 0x000489C4
		// (set) Token: 0x06000F73 RID: 3955 RVA: 0x00009834 File Offset: 0x00007A34
		public unsafe DecalDrawGBufferSystem m_DrawGBufferSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DrawGBufferSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalDrawGBufferSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DrawGBufferSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x0004A7F4 File Offset: 0x000489F4
		// (set) Token: 0x06000F75 RID: 3957 RVA: 0x00009853 File Offset: 0x00007A53
		public unsafe DeferredLights m_DeferredLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DeferredLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeferredLights>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalRendererFeature.NativeFieldInfoPtr_m_DeferredLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeFieldInfoPtr__sharedDecalEntityManager_k__BackingField;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeFieldInfoPtr_m_CopyDepthPS;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeFieldInfoPtr_m_DBufferClear;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeFieldInfoPtr_m_Technique;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeFieldInfoPtr_m_DBufferSettings;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenSpaceSettings;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeFieldInfoPtr_m_RecreateSystems;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeFieldInfoPtr_m_CopyDepthPass;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalPreviewPass;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeFieldInfoPtr_m_CopyDepthMaterial;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalEntityManager;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalUpdateCachedSystem;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalUpdateCullingGroupSystem;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalUpdateCulledSystem;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalCreateDrawCallSystem;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawErrorSystem;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeFieldInfoPtr_m_DBufferRenderPass;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeFieldInfoPtr_m_ForwardEmissivePass;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalDrawDBufferSystem;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalDrawForwardEmissiveSystem;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeFieldInfoPtr_m_DBufferClearMaterial;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenSpaceDecalRenderPass;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalDrawScreenSpaceSystem;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalSkipCulledSystem;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeFieldInfoPtr_m_GBufferRenderPass;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawGBufferSystem;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeFieldInfoPtr_m_DeferredLights;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedDecalEntityManager_Private_Static_get_SharedDecalEntityManager_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Internal_get_byref_DecalSettings_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_get_intermediateRendering_Internal_get_Boolean_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_get_requiresDecalLayers_Internal_get_Boolean_0;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr_get_isGLDevice_Internal_Static_get_Boolean_0;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_RequireRenderingLayers_Internal_Virtual_Boolean_Boolean_Boolean_byref_Event_byref_MaskSize_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_GetDBufferSettings_Internal_DBufferSettings_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenSpaceSettings_Internal_DecalScreenSpaceSettings_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_ScriptableRendererData_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_ScriptableRenderer_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_Boolean_Boolean_Boolean_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_IsAutomaticDBuffer_Private_Boolean_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_RecreateSystemsIfNeeded_Private_Boolean_ScriptableRenderer_byref_CameraData_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraPreCull_Public_Virtual_Void_ScriptableRenderer_byref_CameraData_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_SupportsNativeRenderPass_Internal_Virtual_Boolean_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_SetupRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAdaptivePerformanceDrawDistances_Private_Void_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
