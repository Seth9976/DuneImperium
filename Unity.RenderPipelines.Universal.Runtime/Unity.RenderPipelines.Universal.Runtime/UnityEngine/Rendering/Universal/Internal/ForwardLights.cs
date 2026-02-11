using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x0200011A RID: 282
	public class ForwardLights : Object
	{
		// Token: 0x06001841 RID: 6209 RVA: 0x00066B98 File Offset: 0x00064D98
		// Note: this type is marked as 'beforefieldinit'.
		static ForwardLights()
		{
			Il2CppClassPointerStore<ForwardLights>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "ForwardLights");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr);
			ForwardLights.NativeFieldInfoPtr_m_AdditionalLightsBufferId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightsBufferId");
			ForwardLights.NativeFieldInfoPtr_m_AdditionalLightsIndicesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightsIndicesId");
			ForwardLights.NativeFieldInfoPtr_k_SetupLightConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "k_SetupLightConstants");
			ForwardLights.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ProfilingSampler");
			ForwardLights.NativeFieldInfoPtr_m_ProfilingSamplerFPSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ProfilingSamplerFPSetup");
			ForwardLights.NativeFieldInfoPtr_m_ProfilingSamplerFPComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ProfilingSamplerFPComplete");
			ForwardLights.NativeFieldInfoPtr_m_ProfilingSamplerFPUpload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ProfilingSamplerFPUpload");
			ForwardLights.NativeFieldInfoPtr_m_MixedLightingSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_MixedLightingSetup");
			ForwardLights.NativeFieldInfoPtr_m_AdditionalLightPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightPositions");
			ForwardLights.NativeFieldInfoPtr_m_AdditionalLightColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightColors");
			ForwardLights.NativeFieldInfoPtr_m_AdditionalLightAttenuations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightAttenuations");
			ForwardLights.NativeFieldInfoPtr_m_AdditionalLightSpotDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightSpotDirections");
			ForwardLights.NativeFieldInfoPtr_m_AdditionalLightOcclusionProbeChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightOcclusionProbeChannels");
			ForwardLights.NativeFieldInfoPtr_m_AdditionalLightsLayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightsLayerMasks");
			ForwardLights.NativeFieldInfoPtr_m_UseStructuredBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_UseStructuredBuffer");
			ForwardLights.NativeFieldInfoPtr_m_UseForwardPlus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_UseForwardPlus");
			ForwardLights.NativeFieldInfoPtr_m_DirectionalLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_DirectionalLightCount");
			ForwardLights.NativeFieldInfoPtr_m_ActualTileWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ActualTileWidth");
			ForwardLights.NativeFieldInfoPtr_m_TileResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_TileResolution");
			ForwardLights.NativeFieldInfoPtr_m_CullingHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_CullingHandle");
			ForwardLights.NativeFieldInfoPtr_m_ZBins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ZBins");
			ForwardLights.NativeFieldInfoPtr_m_ZBinsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ZBinsBuffer");
			ForwardLights.NativeFieldInfoPtr_m_TileMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_TileMasks");
			ForwardLights.NativeFieldInfoPtr_m_TileMasksBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_TileMasksBuffer");
			ForwardLights.NativeFieldInfoPtr_m_LightCookieManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_LightCookieManager");
			ForwardLights.NativeFieldInfoPtr_m_ReflectionProbeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ReflectionProbeManager");
			ForwardLights.NativeFieldInfoPtr_m_WordsPerTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_WordsPerTile");
			ForwardLights.NativeFieldInfoPtr_m_ZBinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ZBinScale");
			ForwardLights.NativeFieldInfoPtr_m_ZBinOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ZBinOffset");
			ForwardLights.NativeFieldInfoPtr_m_LightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_LightCount");
			ForwardLights.NativeFieldInfoPtr_m_BinCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_BinCount");
			ForwardLights.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666144);
			ForwardLights.NativeMethodInfoPtr__ctor_Internal_Void_InitParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666145);
			ForwardLights.NativeMethodInfoPtr_CreateForwardPlusBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666146);
			ForwardLights.NativeMethodInfoPtr_get_reflectionProbeManager_Internal_get_ReflectionProbeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666147);
			ForwardLights.NativeMethodInfoPtr_AlignByteCount_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666148);
			ForwardLights.NativeMethodInfoPtr_GetViewParams_Private_Void_Camera_float4x4_byref_Single_byref_Single_byref_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666149);
			ForwardLights.NativeMethodInfoPtr_PreSetup_Internal_Void_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666150);
			ForwardLights.NativeMethodInfoPtr_Setup_Public_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666151);
			ForwardLights.NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666152);
			ForwardLights.NativeMethodInfoPtr_InitializeLightConstants_Private_Void_NativeArray_1_VisibleLight_Int32_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_UInt32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666153);
			ForwardLights.NativeMethodInfoPtr_SetupShaderLightConstants_Private_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666154);
			ForwardLights.NativeMethodInfoPtr_SetupMainLightConstants_Private_Void_CommandBuffer_byref_LightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666155);
			ForwardLights.NativeMethodInfoPtr_SetupAdditionalLightConstants_Private_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666156);
			ForwardLights.NativeMethodInfoPtr_SetupPerObjectLightIndices_Private_Int32_CullingResults_byref_LightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666157);
			ForwardLights.NativeMethodInfoPtr_Method_Internal_Static_Boolean_VisibleReflectionProbe_VisibleReflectionProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666159);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00066F60 File Offset: 0x00065160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 625947, XrefRangeEnd = 625964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForwardLights()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00066F9C File Offset: 0x0006519C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 626049, RefRangeEnd = 626051, XrefRangeStart = 625964, XrefRangeEnd = 626049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForwardLights(ForwardLights.InitParams initParams)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(initParams));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr__ctor_Internal_Void_InitParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00066FEC File Offset: 0x000651EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 626079, RefRangeEnd = 626081, XrefRangeStart = 626051, XrefRangeEnd = 626079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateForwardPlusBuffers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr_CreateForwardPlusBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x00067020 File Offset: 0x00065220
		public unsafe ReflectionProbeManager reflectionProbeManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr_get_reflectionProbeManager_Internal_get_ReflectionProbeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReflectionProbeManager(intPtr);
			}
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00067058 File Offset: 0x00065258
		[CallerCount(0)]
		public unsafe static int AlignByteCount(int count, int align)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr_AlignByteCount_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x000670A4 File Offset: 0x000652A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 626095, RefRangeEnd = 626097, XrefRangeStart = 626081, XrefRangeEnd = 626095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetViewParams(Camera camera, float4x4 viewToClip, out float viewPlaneBot, out float viewPlaneTop, out float4 viewToViewportScaleBias)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewToClip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewPlaneBot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewPlaneTop;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewToViewportScaleBias;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr_GetViewParams_Private_Void_Camera_float4x4_byref_Single_byref_Single_byref_float4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00067120 File Offset: 0x00065320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 626250, RefRangeEnd = 626251, XrefRangeStart = 626097, XrefRangeEnd = 626250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreSetup(ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr_PreSetup_Internal_Void_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00067164 File Offset: 0x00065364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 626385, RefRangeEnd = 626386, XrefRangeStart = 626251, XrefRangeEnd = 626385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr_Setup_Public_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x000671B8 File Offset: 0x000653B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 626400, RefRangeEnd = 626401, XrefRangeStart = 626386, XrefRangeEnd = 626400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x000671EC File Offset: 0x000653EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 626401, XrefRangeEnd = 626419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeLightConstants(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel, out uint lightLayerMask, out bool isSubtractive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lights));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightColor;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightAttenuation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightSpotDir;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightOcclusionProbeChannel;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightLayerMask;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isSubtractive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr_InitializeLightConstants_Private_Void_NativeArray_1_VisibleLight_Int32_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_UInt32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x000672AC File Offset: 0x000654AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 626419, XrefRangeEnd = 626421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupShaderLightConstants(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr_SetupShaderLightConstants_Private_Void_CommandBuffer_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00067304 File Offset: 0x00065504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 626450, RefRangeEnd = 626452, XrefRangeStart = 626421, XrefRangeEnd = 626450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(lightData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr_SetupMainLightConstants_Private_Void_CommandBuffer_byref_LightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x0006735C File Offset: 0x0006555C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 626465, RefRangeEnd = 626467, XrefRangeStart = 626452, XrefRangeEnd = 626465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupAdditionalLightConstants(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr_SetupAdditionalLightConstants_Private_Void_CommandBuffer_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x000673B4 File Offset: 0x000655B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 626481, RefRangeEnd = 626482, XrefRangeStart = 626467, XrefRangeEnd = 626481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SetupPerObjectLightIndices(CullingResults cullResults, ref LightData lightData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullResults;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(lightData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr_SetupPerObjectLightIndices_Private_Int32_CullingResults_byref_LightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00067410 File Offset: 0x00065610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 626484, RefRangeEnd = 626485, XrefRangeStart = 626482, XrefRangeEnd = 626484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_VisibleReflectionProbe_VisibleReflectionProbe_0(VisibleReflectionProbe probe, VisibleReflectionProbe otherProbe)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref probe;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref otherProbe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.NativeMethodInfoPtr_Method_Internal_Static_Boolean_VisibleReflectionProbe_VisibleReflectionProbe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0000DCD4 File Offset: 0x0000BED4
		public ForwardLights(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x0006745C File Offset: 0x0006565C
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x0000DCDD File Offset: 0x0000BEDD
		public unsafe int m_AdditionalLightsBufferId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightsBufferId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightsBufferId)) = value;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x00067484 File Offset: 0x00065684
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		public unsafe int m_AdditionalLightsIndicesId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightsIndicesId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightsIndicesId)) = value;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x000674AC File Offset: 0x000656AC
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x0000DD13 File Offset: 0x0000BF13
		public unsafe static string k_SetupLightConstants
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ForwardLights.NativeFieldInfoPtr_k_SetupLightConstants, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ForwardLights.NativeFieldInfoPtr_k_SetupLightConstants, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x000674CC File Offset: 0x000656CC
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x0000DD25 File Offset: 0x0000BF25
		public unsafe static ProfilingSampler m_ProfilingSampler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ForwardLights.NativeFieldInfoPtr_m_ProfilingSampler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ForwardLights.NativeFieldInfoPtr_m_ProfilingSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x000674F4 File Offset: 0x000656F4
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x0000DD37 File Offset: 0x0000BF37
		public unsafe static ProfilingSampler m_ProfilingSamplerFPSetup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ForwardLights.NativeFieldInfoPtr_m_ProfilingSamplerFPSetup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ForwardLights.NativeFieldInfoPtr_m_ProfilingSamplerFPSetup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x0006751C File Offset: 0x0006571C
		// (set) Token: 0x0600185D RID: 6237 RVA: 0x0000DD49 File Offset: 0x0000BF49
		public unsafe static ProfilingSampler m_ProfilingSamplerFPComplete
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ForwardLights.NativeFieldInfoPtr_m_ProfilingSamplerFPComplete, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ForwardLights.NativeFieldInfoPtr_m_ProfilingSamplerFPComplete, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x00067544 File Offset: 0x00065744
		// (set) Token: 0x0600185F RID: 6239 RVA: 0x0000DD5B File Offset: 0x0000BF5B
		public unsafe static ProfilingSampler m_ProfilingSamplerFPUpload
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ForwardLights.NativeFieldInfoPtr_m_ProfilingSamplerFPUpload, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ForwardLights.NativeFieldInfoPtr_m_ProfilingSamplerFPUpload, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x0006756C File Offset: 0x0006576C
		// (set) Token: 0x06001861 RID: 6241 RVA: 0x0000DD6D File Offset: 0x0000BF6D
		public unsafe MixedLightingSetup m_MixedLightingSetup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_MixedLightingSetup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_MixedLightingSetup)) = value;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x00067594 File Offset: 0x00065794
		// (set) Token: 0x06001863 RID: 6243 RVA: 0x0000DD88 File Offset: 0x0000BF88
		public unsafe Il2CppStructArray<Vector4> m_AdditionalLightPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x000675C4 File Offset: 0x000657C4
		// (set) Token: 0x06001865 RID: 6245 RVA: 0x0000DDA7 File Offset: 0x0000BFA7
		public unsafe Il2CppStructArray<Vector4> m_AdditionalLightColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x000675F4 File Offset: 0x000657F4
		// (set) Token: 0x06001867 RID: 6247 RVA: 0x0000DDC6 File Offset: 0x0000BFC6
		public unsafe Il2CppStructArray<Vector4> m_AdditionalLightAttenuations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightAttenuations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightAttenuations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x00067624 File Offset: 0x00065824
		// (set) Token: 0x06001869 RID: 6249 RVA: 0x0000DDE5 File Offset: 0x0000BFE5
		public unsafe Il2CppStructArray<Vector4> m_AdditionalLightSpotDirections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightSpotDirections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightSpotDirections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x00067654 File Offset: 0x00065854
		// (set) Token: 0x0600186B RID: 6251 RVA: 0x0000DE04 File Offset: 0x0000C004
		public unsafe Il2CppStructArray<Vector4> m_AdditionalLightOcclusionProbeChannels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightOcclusionProbeChannels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightOcclusionProbeChannels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x00067684 File Offset: 0x00065884
		// (set) Token: 0x0600186D RID: 6253 RVA: 0x0000DE23 File Offset: 0x0000C023
		public unsafe Il2CppStructArray<float> m_AdditionalLightsLayerMasks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightsLayerMasks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_AdditionalLightsLayerMasks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x000676B4 File Offset: 0x000658B4
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x0000DE42 File Offset: 0x0000C042
		public unsafe bool m_UseStructuredBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_UseStructuredBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_UseStructuredBuffer)) = value;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x000676DC File Offset: 0x000658DC
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x0000DE5D File Offset: 0x0000C05D
		public unsafe bool m_UseForwardPlus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_UseForwardPlus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_UseForwardPlus)) = value;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00067704 File Offset: 0x00065904
		// (set) Token: 0x06001873 RID: 6259 RVA: 0x0000DE78 File Offset: 0x0000C078
		public unsafe int m_DirectionalLightCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_DirectionalLightCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_DirectionalLightCount)) = value;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x0006772C File Offset: 0x0006592C
		// (set) Token: 0x06001875 RID: 6261 RVA: 0x0000DE93 File Offset: 0x0000C093
		public unsafe int m_ActualTileWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_ActualTileWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_ActualTileWidth)) = value;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x00067754 File Offset: 0x00065954
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x0000DEAE File Offset: 0x0000C0AE
		public unsafe int2 m_TileResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_TileResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_TileResolution)) = value;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x0006777C File Offset: 0x0006597C
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x0000DEC9 File Offset: 0x0000C0C9
		public unsafe JobHandle m_CullingHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_CullingHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_CullingHandle)) = value;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x000677A4 File Offset: 0x000659A4
		// (set) Token: 0x0600187B RID: 6267 RVA: 0x0000DEE4 File Offset: 0x0000C0E4
		public NativeArray<uint> m_ZBins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_ZBins);
				return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_ZBins), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x000677D4 File Offset: 0x000659D4
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x0000DF12 File Offset: 0x0000C112
		public unsafe GraphicsBuffer m_ZBinsBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_ZBinsBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_ZBinsBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x00067804 File Offset: 0x00065A04
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x0000DF31 File Offset: 0x0000C131
		public NativeArray<uint> m_TileMasks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_TileMasks);
				return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_TileMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x00067834 File Offset: 0x00065A34
		// (set) Token: 0x06001881 RID: 6273 RVA: 0x0000DF5F File Offset: 0x0000C15F
		public unsafe GraphicsBuffer m_TileMasksBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_TileMasksBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_TileMasksBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x00067864 File Offset: 0x00065A64
		// (set) Token: 0x06001883 RID: 6275 RVA: 0x0000DF7E File Offset: 0x0000C17E
		public unsafe LightCookieManager m_LightCookieManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_LightCookieManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightCookieManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_LightCookieManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x00067894 File Offset: 0x00065A94
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x0000DF9D File Offset: 0x0000C19D
		public ReflectionProbeManager m_ReflectionProbeManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_ReflectionProbeManager);
				return new ReflectionProbeManager(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_ReflectionProbeManager), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x000678C4 File Offset: 0x00065AC4
		// (set) Token: 0x06001887 RID: 6279 RVA: 0x0000DFCB File Offset: 0x0000C1CB
		public unsafe int m_WordsPerTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_WordsPerTile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_WordsPerTile)) = value;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x000678EC File Offset: 0x00065AEC
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x0000DFE6 File Offset: 0x0000C1E6
		public unsafe float m_ZBinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_ZBinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_ZBinScale)) = value;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x00067914 File Offset: 0x00065B14
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x0000E001 File Offset: 0x0000C201
		public unsafe float m_ZBinOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_ZBinOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_ZBinOffset)) = value;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x0006793C File Offset: 0x00065B3C
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x0000E01C File Offset: 0x0000C21C
		public unsafe int m_LightCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_LightCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_LightCount)) = value;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x00067964 File Offset: 0x00065B64
		// (set) Token: 0x0600188F RID: 6287 RVA: 0x0000E037 File Offset: 0x0000C237
		public unsafe int m_BinCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_BinCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.NativeFieldInfoPtr_m_BinCount)) = value;
			}
		}

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightsBufferId;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightsIndicesId;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeFieldInfoPtr_k_SetupLightConstants;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSamplerFPSetup;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSamplerFPComplete;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSamplerFPUpload;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeFieldInfoPtr_m_MixedLightingSetup;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightPositions;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightColors;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightAttenuations;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightSpotDirections;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightOcclusionProbeChannels;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightsLayerMasks;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeFieldInfoPtr_m_UseStructuredBuffer;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeFieldInfoPtr_m_UseForwardPlus;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeFieldInfoPtr_m_DirectionalLightCount;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeFieldInfoPtr_m_ActualTileWidth;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeFieldInfoPtr_m_TileResolution;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingHandle;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeFieldInfoPtr_m_ZBins;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeFieldInfoPtr_m_ZBinsBuffer;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeFieldInfoPtr_m_TileMasks;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeFieldInfoPtr_m_TileMasksBuffer;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeFieldInfoPtr_m_LightCookieManager;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeFieldInfoPtr_m_ReflectionProbeManager;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeFieldInfoPtr_m_WordsPerTile;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeFieldInfoPtr_m_ZBinScale;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeFieldInfoPtr_m_ZBinOffset;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeFieldInfoPtr_m_LightCount;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeFieldInfoPtr_m_BinCount;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InitParams_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr_CreateForwardPlusBuffers_Private_Void_0;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeMethodInfoPtr_get_reflectionProbeManager_Internal_get_ReflectionProbeManager_0;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr_AlignByteCount_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr_GetViewParams_Private_Void_Camera_float4x4_byref_Single_byref_Single_byref_float4_0;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeMethodInfoPtr_PreSetup_Internal_Void_byref_RenderingData_0;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeMethodInfoPtr_InitializeLightConstants_Private_Void_NativeArray_1_VisibleLight_Int32_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_UInt32_byref_Boolean_0;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeMethodInfoPtr_SetupShaderLightConstants_Private_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeMethodInfoPtr_SetupMainLightConstants_Private_Void_CommandBuffer_byref_LightData_0;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeMethodInfoPtr_SetupAdditionalLightConstants_Private_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeMethodInfoPtr_SetupPerObjectLightIndices_Private_Int32_CullingResults_byref_LightData_0;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_VisibleReflectionProbe_VisibleReflectionProbe_0;

		// Token: 0x020001EA RID: 490
		public static class LightConstantBuffer : Object
		{
			// Token: 0x06002214 RID: 8724 RVA: 0x00082C58 File Offset: 0x00080E58
			// Note: this type is marked as 'beforefieldinit'.
			static LightConstantBuffer()
			{
				Il2CppClassPointerStore<ForwardLights.LightConstantBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "LightConstantBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForwardLights.LightConstantBuffer>.NativeClassPtr);
				ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__MainLightPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights.LightConstantBuffer>.NativeClassPtr, "_MainLightPosition");
				ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__MainLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights.LightConstantBuffer>.NativeClassPtr, "_MainLightColor");
				ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__MainLightOcclusionProbesChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights.LightConstantBuffer>.NativeClassPtr, "_MainLightOcclusionProbesChannel");
				ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__MainLightLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights.LightConstantBuffer>.NativeClassPtr, "_MainLightLayerMask");
				ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights.LightConstantBuffer>.NativeClassPtr, "_AdditionalLightsCount");
				ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights.LightConstantBuffer>.NativeClassPtr, "_AdditionalLightsPosition");
				ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights.LightConstantBuffer>.NativeClassPtr, "_AdditionalLightsColor");
				ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsAttenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights.LightConstantBuffer>.NativeClassPtr, "_AdditionalLightsAttenuation");
				ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsSpotDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights.LightConstantBuffer>.NativeClassPtr, "_AdditionalLightsSpotDir");
				ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightOcclusionProbeChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights.LightConstantBuffer>.NativeClassPtr, "_AdditionalLightOcclusionProbeChannel");
				ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsLayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights.LightConstantBuffer>.NativeClassPtr, "_AdditionalLightsLayerMasks");
			}

			// Token: 0x06002215 RID: 8725 RVA: 0x000137CD File Offset: 0x000119CD
			public LightConstantBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C4A RID: 3146
			// (get) Token: 0x06002216 RID: 8726 RVA: 0x00082D60 File Offset: 0x00080F60
			// (set) Token: 0x06002217 RID: 8727 RVA: 0x000137D6 File Offset: 0x000119D6
			public unsafe static int _MainLightPosition
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__MainLightPosition, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__MainLightPosition, (void*)(&value));
				}
			}

			// Token: 0x17000C4B RID: 3147
			// (get) Token: 0x06002218 RID: 8728 RVA: 0x00082D7C File Offset: 0x00080F7C
			// (set) Token: 0x06002219 RID: 8729 RVA: 0x000137E4 File Offset: 0x000119E4
			public unsafe static int _MainLightColor
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__MainLightColor, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__MainLightColor, (void*)(&value));
				}
			}

			// Token: 0x17000C4C RID: 3148
			// (get) Token: 0x0600221A RID: 8730 RVA: 0x00082D98 File Offset: 0x00080F98
			// (set) Token: 0x0600221B RID: 8731 RVA: 0x000137F2 File Offset: 0x000119F2
			public unsafe static int _MainLightOcclusionProbesChannel
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__MainLightOcclusionProbesChannel, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__MainLightOcclusionProbesChannel, (void*)(&value));
				}
			}

			// Token: 0x17000C4D RID: 3149
			// (get) Token: 0x0600221C RID: 8732 RVA: 0x00082DB4 File Offset: 0x00080FB4
			// (set) Token: 0x0600221D RID: 8733 RVA: 0x00013800 File Offset: 0x00011A00
			public unsafe static int _MainLightLayerMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__MainLightLayerMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__MainLightLayerMask, (void*)(&value));
				}
			}

			// Token: 0x17000C4E RID: 3150
			// (get) Token: 0x0600221E RID: 8734 RVA: 0x00082DD0 File Offset: 0x00080FD0
			// (set) Token: 0x0600221F RID: 8735 RVA: 0x0001380E File Offset: 0x00011A0E
			public unsafe static int _AdditionalLightsCount
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsCount, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsCount, (void*)(&value));
				}
			}

			// Token: 0x17000C4F RID: 3151
			// (get) Token: 0x06002220 RID: 8736 RVA: 0x00082DEC File Offset: 0x00080FEC
			// (set) Token: 0x06002221 RID: 8737 RVA: 0x0001381C File Offset: 0x00011A1C
			public unsafe static int _AdditionalLightsPosition
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsPosition, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsPosition, (void*)(&value));
				}
			}

			// Token: 0x17000C50 RID: 3152
			// (get) Token: 0x06002222 RID: 8738 RVA: 0x00082E08 File Offset: 0x00081008
			// (set) Token: 0x06002223 RID: 8739 RVA: 0x0001382A File Offset: 0x00011A2A
			public unsafe static int _AdditionalLightsColor
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsColor, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsColor, (void*)(&value));
				}
			}

			// Token: 0x17000C51 RID: 3153
			// (get) Token: 0x06002224 RID: 8740 RVA: 0x00082E24 File Offset: 0x00081024
			// (set) Token: 0x06002225 RID: 8741 RVA: 0x00013838 File Offset: 0x00011A38
			public unsafe static int _AdditionalLightsAttenuation
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsAttenuation, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsAttenuation, (void*)(&value));
				}
			}

			// Token: 0x17000C52 RID: 3154
			// (get) Token: 0x06002226 RID: 8742 RVA: 0x00082E40 File Offset: 0x00081040
			// (set) Token: 0x06002227 RID: 8743 RVA: 0x00013846 File Offset: 0x00011A46
			public unsafe static int _AdditionalLightsSpotDir
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsSpotDir, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsSpotDir, (void*)(&value));
				}
			}

			// Token: 0x17000C53 RID: 3155
			// (get) Token: 0x06002228 RID: 8744 RVA: 0x00082E5C File Offset: 0x0008105C
			// (set) Token: 0x06002229 RID: 8745 RVA: 0x00013854 File Offset: 0x00011A54
			public unsafe static int _AdditionalLightOcclusionProbeChannel
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightOcclusionProbeChannel, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightOcclusionProbeChannel, (void*)(&value));
				}
			}

			// Token: 0x17000C54 RID: 3156
			// (get) Token: 0x0600222A RID: 8746 RVA: 0x00082E78 File Offset: 0x00081078
			// (set) Token: 0x0600222B RID: 8747 RVA: 0x00013862 File Offset: 0x00011A62
			public unsafe static int _AdditionalLightsLayerMasks
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsLayerMasks, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ForwardLights.LightConstantBuffer.NativeFieldInfoPtr__AdditionalLightsLayerMasks, (void*)(&value));
				}
			}

			// Token: 0x04001818 RID: 6168
			private static readonly IntPtr NativeFieldInfoPtr__MainLightPosition;

			// Token: 0x04001819 RID: 6169
			private static readonly IntPtr NativeFieldInfoPtr__MainLightColor;

			// Token: 0x0400181A RID: 6170
			private static readonly IntPtr NativeFieldInfoPtr__MainLightOcclusionProbesChannel;

			// Token: 0x0400181B RID: 6171
			private static readonly IntPtr NativeFieldInfoPtr__MainLightLayerMask;

			// Token: 0x0400181C RID: 6172
			private static readonly IntPtr NativeFieldInfoPtr__AdditionalLightsCount;

			// Token: 0x0400181D RID: 6173
			private static readonly IntPtr NativeFieldInfoPtr__AdditionalLightsPosition;

			// Token: 0x0400181E RID: 6174
			private static readonly IntPtr NativeFieldInfoPtr__AdditionalLightsColor;

			// Token: 0x0400181F RID: 6175
			private static readonly IntPtr NativeFieldInfoPtr__AdditionalLightsAttenuation;

			// Token: 0x04001820 RID: 6176
			private static readonly IntPtr NativeFieldInfoPtr__AdditionalLightsSpotDir;

			// Token: 0x04001821 RID: 6177
			private static readonly IntPtr NativeFieldInfoPtr__AdditionalLightOcclusionProbeChannel;

			// Token: 0x04001822 RID: 6178
			private static readonly IntPtr NativeFieldInfoPtr__AdditionalLightsLayerMasks;
		}

		// Token: 0x020001EB RID: 491
		public sealed class InitParams : ValueType
		{
			// Token: 0x0600222C RID: 8748 RVA: 0x00082E94 File Offset: 0x00081094
			// Note: this type is marked as 'beforefieldinit'.
			static InitParams()
			{
				Il2CppClassPointerStore<ForwardLights.InitParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "InitParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForwardLights.InitParams>.NativeClassPtr);
				ForwardLights.InitParams.NativeFieldInfoPtr_lightCookieManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights.InitParams>.NativeClassPtr, "lightCookieManager");
				ForwardLights.InitParams.NativeFieldInfoPtr_forwardPlus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights.InitParams>.NativeClassPtr, "forwardPlus");
				ForwardLights.InitParams.NativeMethodInfoPtr_Create_Internal_Static_InitParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights.InitParams>.NativeClassPtr, 100666160);
			}

			// Token: 0x0600222D RID: 8749 RVA: 0x00082EFC File Offset: 0x000810FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 625931, XrefRangeEnd = 625947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ForwardLights.InitParams Create()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardLights.InitParams.NativeMethodInfoPtr_Create_Internal_Static_InitParams_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ForwardLights.InitParams(intPtr);
			}

			// Token: 0x0600222E RID: 8750 RVA: 0x00013870 File Offset: 0x00011A70
			public InitParams(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600222F RID: 8751 RVA: 0x00013879 File Offset: 0x00011A79
			public InitParams()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForwardLights.InitParams>.NativeClassPtr))
			{
			}

			// Token: 0x17000C55 RID: 3157
			// (get) Token: 0x06002230 RID: 8752 RVA: 0x00082F28 File Offset: 0x00081128
			// (set) Token: 0x06002231 RID: 8753 RVA: 0x0001388B File Offset: 0x00011A8B
			public unsafe LightCookieManager lightCookieManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.InitParams.NativeFieldInfoPtr_lightCookieManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightCookieManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.InitParams.NativeFieldInfoPtr_lightCookieManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C56 RID: 3158
			// (get) Token: 0x06002232 RID: 8754 RVA: 0x00082F58 File Offset: 0x00081158
			// (set) Token: 0x06002233 RID: 8755 RVA: 0x000138AA File Offset: 0x00011AAA
			public unsafe bool forwardPlus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.InitParams.NativeFieldInfoPtr_forwardPlus);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardLights.InitParams.NativeFieldInfoPtr_forwardPlus)) = value;
				}
			}

			// Token: 0x04001823 RID: 6179
			private static readonly IntPtr NativeFieldInfoPtr_lightCookieManager;

			// Token: 0x04001824 RID: 6180
			private static readonly IntPtr NativeFieldInfoPtr_forwardPlus;

			// Token: 0x04001825 RID: 6181
			private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_InitParams_0;
		}
	}
}
