using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200016D RID: 365
	public sealed class SystemInfo : Object
	{
		// Token: 0x06001A92 RID: 6802 RVA: 0x0007B878 File Offset: 0x00079A78
		// Note: this type is marked as 'beforefieldinit'.
		static SystemInfo()
		{
			Il2CppClassPointerStore<SystemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SystemInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr);
			SystemInfo.NativeMethodInfoPtr_get_operatingSystem_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666949);
			SystemInfo.NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666950);
			SystemInfo.NativeMethodInfoPtr_get_processorType_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666951);
			SystemInfo.NativeMethodInfoPtr_get_processorFrequency_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666952);
			SystemInfo.NativeMethodInfoPtr_get_processorCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666953);
			SystemInfo.NativeMethodInfoPtr_get_systemMemorySize_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666954);
			SystemInfo.NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666955);
			SystemInfo.NativeMethodInfoPtr_get_deviceName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666956);
			SystemInfo.NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666957);
			SystemInfo.NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666958);
			SystemInfo.NativeMethodInfoPtr_get_graphicsMemorySize_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666959);
			SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666960);
			SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceVendor_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666961);
			SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceID_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666962);
			SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceType_Public_Static_get_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666963);
			SystemInfo.NativeMethodInfoPtr_get_graphicsUVStartsAtTop_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666964);
			SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceVersion_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666965);
			SystemInfo.NativeMethodInfoPtr_get_graphicsShaderLevel_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666966);
			SystemInfo.NativeMethodInfoPtr_get_graphicsMultiThreaded_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666967);
			SystemInfo.NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666968);
			SystemInfo.NativeMethodInfoPtr_get_hasHiddenSurfaceRemovalOnGPU_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666969);
			SystemInfo.NativeMethodInfoPtr_get_supportsShadows_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666970);
			SystemInfo.NativeMethodInfoPtr_get_copyTextureSupport_Public_Static_get_CopyTextureSupport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666971);
			SystemInfo.NativeMethodInfoPtr_get_supportsComputeShaders_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666972);
			SystemInfo.NativeMethodInfoPtr_get_supportsRenderTargetArrayIndexFromVertexShader_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666973);
			SystemInfo.NativeMethodInfoPtr_get_supportsInstancing_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666974);
			SystemInfo.NativeMethodInfoPtr_get_supportedRenderTargetCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666975);
			SystemInfo.NativeMethodInfoPtr_get_supportsMultisampledTextures_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666976);
			SystemInfo.NativeMethodInfoPtr_get_supportsMultisampleAutoResolve_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666977);
			SystemInfo.NativeMethodInfoPtr_get_usesReversedZBuffer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666978);
			SystemInfo.NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666979);
			SystemInfo.NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666980);
			SystemInfo.NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666981);
			SystemInfo.NativeMethodInfoPtr_get_maxTextureSize_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666982);
			SystemInfo.NativeMethodInfoPtr_get_maxRenderTextureSize_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666983);
			SystemInfo.NativeMethodInfoPtr_get_supportsGraphicsFence_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666984);
			SystemInfo.NativeMethodInfoPtr_get_maxGraphicsBufferSize_Public_Static_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666985);
			SystemInfo.NativeMethodInfoPtr_get_usesLoadStoreActions_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666986);
			SystemInfo.NativeMethodInfoPtr_get_hdrDisplaySupportFlags_Public_Static_get_HDRDisplaySupportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666987);
			SystemInfo.NativeMethodInfoPtr_get_supportsMultiview_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666988);
			SystemInfo.NativeMethodInfoPtr_get_supportsStoreAndResolveAction_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666989);
			SystemInfo.NativeMethodInfoPtr_get_supportsMultisampleResolveDepth_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666990);
			SystemInfo.NativeMethodInfoPtr_get_supportsMultisampleResolveStencil_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666991);
			SystemInfo.NativeMethodInfoPtr_GetOperatingSystem_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666992);
			SystemInfo.NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666993);
			SystemInfo.NativeMethodInfoPtr_GetProcessorType_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666994);
			SystemInfo.NativeMethodInfoPtr_GetProcessorFrequencyMHz_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666995);
			SystemInfo.NativeMethodInfoPtr_GetProcessorCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666996);
			SystemInfo.NativeMethodInfoPtr_GetPhysicalMemoryMB_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666997);
			SystemInfo.NativeMethodInfoPtr_GetDeviceUniqueIdentifier_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666998);
			SystemInfo.NativeMethodInfoPtr_GetDeviceName_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666999);
			SystemInfo.NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667000);
			SystemInfo.NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667001);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsMemorySize_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667002);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceName_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667003);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceVendor_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667004);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceID_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667005);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceType_Private_Static_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667006);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsUVStartsAtTop_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667007);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceVersion_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667008);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsShaderLevel_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667009);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsMultiThreaded_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667010);
			SystemInfo.NativeMethodInfoPtr_GetFoveatedRenderingCaps_Private_Static_FoveatedRenderingCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667011);
			SystemInfo.NativeMethodInfoPtr_HasHiddenSurfaceRemovalOnGPU_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667012);
			SystemInfo.NativeMethodInfoPtr_SupportsShadows_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667013);
			SystemInfo.NativeMethodInfoPtr_GetCopyTextureSupport_Private_Static_CopyTextureSupport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667014);
			SystemInfo.NativeMethodInfoPtr_SupportsComputeShaders_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667015);
			SystemInfo.NativeMethodInfoPtr_SupportsRenderTargetArrayIndexFromVertexShader_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667016);
			SystemInfo.NativeMethodInfoPtr_SupportsInstancing_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667017);
			SystemInfo.NativeMethodInfoPtr_SupportedRenderTargetCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667018);
			SystemInfo.NativeMethodInfoPtr_SupportsMultisampledTextures_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667019);
			SystemInfo.NativeMethodInfoPtr_SupportsMultisampleAutoResolve_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667020);
			SystemInfo.NativeMethodInfoPtr_UsesReversedZBuffer_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667021);
			SystemInfo.NativeMethodInfoPtr_HasRenderTextureNative_Private_Static_Boolean_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667022);
			SystemInfo.NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667023);
			SystemInfo.NativeMethodInfoPtr_GetMaxTextureSize_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667024);
			SystemInfo.NativeMethodInfoPtr_GetMaxRenderTextureSize_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667025);
			SystemInfo.NativeMethodInfoPtr_SupportsGPUFence_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667026);
			SystemInfo.NativeMethodInfoPtr_MaxGraphicsBufferSize_Private_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667027);
			SystemInfo.NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667028);
			SystemInfo.NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667029);
			SystemInfo.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667030);
			SystemInfo.NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Public_Static_Int32_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667031);
			SystemInfo.NativeMethodInfoPtr_UsesLoadStoreActions_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667032);
			SystemInfo.NativeMethodInfoPtr_GetHDRDisplaySupportFlags_Private_Static_HDRDisplaySupportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667033);
			SystemInfo.NativeMethodInfoPtr_SupportsMultiview_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667034);
			SystemInfo.NativeMethodInfoPtr_SupportsStoreAndResolveAction_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667035);
			SystemInfo.NativeMethodInfoPtr_SupportsMultisampleResolveDepth_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667036);
			SystemInfo.NativeMethodInfoPtr_SupportsMultisampleResolveStencil_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667037);
			SystemInfo.NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Injected_Private_Static_Int32_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100667038);
			SystemInfo.GetBatteryLevelDelegateField = IL2CPP.ResolveICall<SystemInfo.GetBatteryLevelDelegate>("UnityEngine.SystemInfo::GetBatteryLevel");
			SystemInfo.GetBatteryStatusDelegateField = IL2CPP.ResolveICall<SystemInfo.GetBatteryStatusDelegate>("UnityEngine.SystemInfo::GetBatteryStatus");
			SystemInfo.SupportsAccelerometerDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAccelerometerDelegate>("UnityEngine.SystemInfo::SupportsAccelerometer");
			SystemInfo.IsGyroAvailableDelegateField = IL2CPP.ResolveICall<SystemInfo.IsGyroAvailableDelegate>("UnityEngine.SystemInfo::IsGyroAvailable");
			SystemInfo.SupportsLocationServiceDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsLocationServiceDelegate>("UnityEngine.SystemInfo::SupportsLocationService");
			SystemInfo.SupportsVibrationDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsVibrationDelegate>("UnityEngine.SystemInfo::SupportsVibration");
			SystemInfo.SupportsAudioDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAudioDelegate>("UnityEngine.SystemInfo::SupportsAudio");
			SystemInfo.GetGraphicsDeviceVendorIDDelegateField = IL2CPP.ResolveICall<SystemInfo.GetGraphicsDeviceVendorIDDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceVendorID");
			SystemInfo.GetRenderingThreadingModeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetRenderingThreadingModeDelegate>("UnityEngine.SystemInfo::GetRenderingThreadingMode");
			SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegateField = IL2CPP.ResolveICall<SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegate>("UnityEngine.SystemInfo::HasDynamicUniformArrayIndexingInFragmentShaders");
			SystemInfo.SupportsRawShadowDepthSamplingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsRawShadowDepthSamplingDelegate>("UnityEngine.SystemInfo::SupportsRawShadowDepthSampling");
			SystemInfo.SupportsMotionVectorsDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMotionVectorsDelegate>("UnityEngine.SystemInfo::SupportsMotionVectors");
			SystemInfo.Supports3DTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports3DTexturesDelegate>("UnityEngine.SystemInfo::Supports3DTextures");
			SystemInfo.SupportsCompressed3DTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsCompressed3DTexturesDelegate>("UnityEngine.SystemInfo::SupportsCompressed3DTextures");
			SystemInfo.Supports2DArrayTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports2DArrayTexturesDelegate>("UnityEngine.SystemInfo::Supports2DArrayTextures");
			SystemInfo.Supports3DRenderTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports3DRenderTexturesDelegate>("UnityEngine.SystemInfo::Supports3DRenderTextures");
			SystemInfo.SupportsCubemapArrayTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsCubemapArrayTexturesDelegate>("UnityEngine.SystemInfo::SupportsCubemapArrayTextures");
			SystemInfo.SupportsAnisotropicFilterDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAnisotropicFilterDelegate>("UnityEngine.SystemInfo::SupportsAnisotropicFilter");
			SystemInfo.SupportsGeometryShadersDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsGeometryShadersDelegate>("UnityEngine.SystemInfo::SupportsGeometryShaders");
			SystemInfo.SupportsTessellationShadersDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsTessellationShadersDelegate>("UnityEngine.SystemInfo::SupportsTessellationShaders");
			SystemInfo.SupportsHardwareQuadTopologyDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsHardwareQuadTopologyDelegate>("UnityEngine.SystemInfo::SupportsHardwareQuadTopology");
			SystemInfo.Supports32bitsIndexBufferDelegateField = IL2CPP.ResolveICall<SystemInfo.Supports32bitsIndexBufferDelegate>("UnityEngine.SystemInfo::Supports32bitsIndexBuffer");
			SystemInfo.SupportsSparseTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsSparseTexturesDelegate>("UnityEngine.SystemInfo::SupportsSparseTextures");
			SystemInfo.SupportsSeparatedRenderTargetsBlendDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsSeparatedRenderTargetsBlendDelegate>("UnityEngine.SystemInfo::SupportsSeparatedRenderTargetsBlend");
			SystemInfo.SupportedRandomWriteTargetCountDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportedRandomWriteTargetCountDelegate>("UnityEngine.SystemInfo::SupportedRandomWriteTargetCount");
			SystemInfo.MaxComputeBufferInputsVertexDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsVertexDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsVertex");
			SystemInfo.MaxComputeBufferInputsFragmentDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsFragmentDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsFragment");
			SystemInfo.MaxComputeBufferInputsGeometryDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsGeometryDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsGeometry");
			SystemInfo.MaxComputeBufferInputsDomainDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsDomainDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsDomain");
			SystemInfo.MaxComputeBufferInputsHullDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsHullDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsHull");
			SystemInfo.MaxComputeBufferInputsComputeDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxComputeBufferInputsComputeDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsCompute");
			SystemInfo.SupportsMultisampled2DArrayTexturesDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMultisampled2DArrayTexturesDelegate>("UnityEngine.SystemInfo::SupportsMultisampled2DArrayTextures");
			SystemInfo.SupportsTextureWrapMirrorOnceDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsTextureWrapMirrorOnceDelegate>("UnityEngine.SystemInfo::SupportsTextureWrapMirrorOnce");
			SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsBlendingOnRenderTextureFormatNative");
			SystemInfo.SupportsRandomWriteOnRenderTextureFormatNativeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsRandomWriteOnRenderTextureFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsRandomWriteOnRenderTextureFormatNative");
			SystemInfo.SupportsVertexAttributeFormatNativeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsVertexAttributeFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsVertexAttributeFormatNative");
			SystemInfo.GetNPOTSupportDelegateField = IL2CPP.ResolveICall<SystemInfo.GetNPOTSupportDelegate>("UnityEngine.SystemInfo::GetNPOTSupport");
			SystemInfo.GetMaxTexture3DSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxTexture3DSizeDelegate>("UnityEngine.SystemInfo::GetMaxTexture3DSize");
			SystemInfo.GetMaxTextureArraySlicesDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxTextureArraySlicesDelegate>("UnityEngine.SystemInfo::GetMaxTextureArraySlices");
			SystemInfo.GetMaxCubemapSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxCubemapSizeDelegate>("UnityEngine.SystemInfo::GetMaxCubemapSize");
			SystemInfo.GetMaxAnisotropyLevelDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxAnisotropyLevelDelegate>("UnityEngine.SystemInfo::GetMaxAnisotropyLevel");
			SystemInfo.GetMaxComputeWorkGroupSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSize");
			SystemInfo.GetMaxComputeWorkGroupSizeXDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeXDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeX");
			SystemInfo.GetMaxComputeWorkGroupSizeYDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeYDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeY");
			SystemInfo.GetMaxComputeWorkGroupSizeZDelegateField = IL2CPP.ResolveICall<SystemInfo.GetMaxComputeWorkGroupSizeZDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeZ");
			SystemInfo.GetComputeSubGroupSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.GetComputeSubGroupSizeDelegate>("UnityEngine.SystemInfo::GetComputeSubGroupSize");
			SystemInfo.SupportsAsyncComputeDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAsyncComputeDelegate>("UnityEngine.SystemInfo::SupportsAsyncCompute");
			SystemInfo.SupportsGpuRecorderDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsGpuRecorderDelegate>("UnityEngine.SystemInfo::SupportsGpuRecorder");
			SystemInfo.SupportsAsyncGPUReadbackDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsAsyncGPUReadbackDelegate>("UnityEngine.SystemInfo::SupportsAsyncGPUReadback");
			SystemInfo.SupportsRayTracingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsRayTracingDelegate>("UnityEngine.SystemInfo::SupportsRayTracing");
			SystemInfo.SupportsSetConstantBufferDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsSetConstantBufferDelegate>("UnityEngine.SystemInfo::SupportsSetConstantBuffer");
			SystemInfo.MinConstantBufferOffsetAlignmentDelegateField = IL2CPP.ResolveICall<SystemInfo.MinConstantBufferOffsetAlignmentDelegate>("UnityEngine.SystemInfo::MinConstantBufferOffsetAlignment");
			SystemInfo.MaxConstantBufferSizeDelegateField = IL2CPP.ResolveICall<SystemInfo.MaxConstantBufferSizeDelegate>("UnityEngine.SystemInfo::MaxConstantBufferSize");
			SystemInfo.HasMipMaxLevelDelegateField = IL2CPP.ResolveICall<SystemInfo.HasMipMaxLevelDelegate>("UnityEngine.SystemInfo::HasMipMaxLevel");
			SystemInfo.SupportsMipStreamingDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsMipStreamingDelegate>("UnityEngine.SystemInfo::SupportsMipStreaming");
			SystemInfo.SupportsConservativeRasterDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsConservativeRasterDelegate>("UnityEngine.SystemInfo::SupportsConservativeRaster");
			SystemInfo.SupportsIndirectArgumentsBufferDelegateField = IL2CPP.ResolveICall<SystemInfo.SupportsIndirectArgumentsBufferDelegate>("UnityEngine.SystemInfo::SupportsIndirectArgumentsBuffer");
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x0007C308 File Offset: 0x0007A508
		public unsafe static string operatingSystem
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 673244, RefRangeEnd = 673248, XrefRangeStart = 673242, XrefRangeEnd = 673244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_operatingSystem_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0007C334 File Offset: 0x0007A534
		public unsafe static OperatingSystemFamily operatingSystemFamily
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 673250, RefRangeEnd = 673256, XrefRangeStart = 673248, XrefRangeEnd = 673250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x0007C364 File Offset: 0x0007A564
		public unsafe static string processorType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 673258, RefRangeEnd = 673263, XrefRangeStart = 673256, XrefRangeEnd = 673258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_processorType_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x0007C390 File Offset: 0x0007A590
		public unsafe static int processorFrequency
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 673265, RefRangeEnd = 673269, XrefRangeStart = 673263, XrefRangeEnd = 673265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_processorFrequency_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x0007C3C0 File Offset: 0x0007A5C0
		public unsafe static int processorCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 673271, RefRangeEnd = 673273, XrefRangeStart = 673269, XrefRangeEnd = 673271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_processorCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x0007C3F0 File Offset: 0x0007A5F0
		public unsafe static int systemMemorySize
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 673275, RefRangeEnd = 673278, XrefRangeStart = 673273, XrefRangeEnd = 673275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_systemMemorySize_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x0007C420 File Offset: 0x0007A620
		public unsafe static string deviceUniqueIdentifier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 673280, RefRangeEnd = 673281, XrefRangeStart = 673278, XrefRangeEnd = 673280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x0007C44C File Offset: 0x0007A64C
		public unsafe static string deviceName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 673283, RefRangeEnd = 673285, XrefRangeStart = 673281, XrefRangeEnd = 673283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x0007C478 File Offset: 0x0007A678
		public unsafe static string deviceModel
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 673287, RefRangeEnd = 673295, XrefRangeStart = 673285, XrefRangeEnd = 673287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x0007C4A4 File Offset: 0x0007A6A4
		public unsafe static DeviceType deviceType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 673297, RefRangeEnd = 673304, XrefRangeStart = 673295, XrefRangeEnd = 673297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x0007C4D4 File Offset: 0x0007A6D4
		public unsafe static int graphicsMemorySize
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 673306, RefRangeEnd = 673309, XrefRangeStart = 673304, XrefRangeEnd = 673306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsMemorySize_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x0007C504 File Offset: 0x0007A704
		public unsafe static string graphicsDeviceName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 673311, RefRangeEnd = 673318, XrefRangeStart = 673309, XrefRangeEnd = 673311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x0007C530 File Offset: 0x0007A730
		public unsafe static string graphicsDeviceVendor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 673320, RefRangeEnd = 673321, XrefRangeStart = 673318, XrefRangeEnd = 673320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceVendor_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0007C55C File Offset: 0x0007A75C
		public unsafe static int graphicsDeviceID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 673323, RefRangeEnd = 673326, XrefRangeStart = 673321, XrefRangeEnd = 673323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceID_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x0007C58C File Offset: 0x0007A78C
		public unsafe static UnityEngine.Rendering.GraphicsDeviceType graphicsDeviceType
		{
			[CallerCount(57)]
			[CachedScanResults(RefRangeStart = 673328, RefRangeEnd = 673385, XrefRangeStart = 673326, XrefRangeEnd = 673328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceType_Public_Static_get_GraphicsDeviceType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x0007C5BC File Offset: 0x0007A7BC
		public unsafe static bool graphicsUVStartsAtTop
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 673387, RefRangeEnd = 673401, XrefRangeStart = 673385, XrefRangeEnd = 673387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsUVStartsAtTop_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x0007C5EC File Offset: 0x0007A7EC
		public unsafe static string graphicsDeviceVersion
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 673403, RefRangeEnd = 673405, XrefRangeStart = 673401, XrefRangeEnd = 673403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsDeviceVersion_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x0007C618 File Offset: 0x0007A818
		public unsafe static int graphicsShaderLevel
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 673407, RefRangeEnd = 673418, XrefRangeStart = 673405, XrefRangeEnd = 673407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsShaderLevel_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x0007C648 File Offset: 0x0007A848
		public unsafe static bool graphicsMultiThreaded
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 673420, RefRangeEnd = 673421, XrefRangeStart = 673418, XrefRangeEnd = 673420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_graphicsMultiThreaded_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x0007C678 File Offset: 0x0007A878
		public unsafe static UnityEngine.Rendering.FoveatedRenderingCaps foveatedRenderingCaps
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 673423, RefRangeEnd = 673427, XrefRangeStart = 673421, XrefRangeEnd = 673423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x0007C6A8 File Offset: 0x0007A8A8
		public unsafe static bool hasHiddenSurfaceRemovalOnGPU
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 673429, RefRangeEnd = 673430, XrefRangeStart = 673427, XrefRangeEnd = 673429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_hasHiddenSurfaceRemovalOnGPU_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x0007C6D8 File Offset: 0x0007A8D8
		public unsafe static bool supportsShadows
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 673432, RefRangeEnd = 673434, XrefRangeStart = 673430, XrefRangeEnd = 673432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsShadows_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x0007C708 File Offset: 0x0007A908
		public unsafe static UnityEngine.Rendering.CopyTextureSupport copyTextureSupport
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 673436, RefRangeEnd = 673438, XrefRangeStart = 673434, XrefRangeEnd = 673436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_copyTextureSupport_Public_Static_get_CopyTextureSupport_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x0007C738 File Offset: 0x0007A938
		public unsafe static bool supportsComputeShaders
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 673440, RefRangeEnd = 673443, XrefRangeStart = 673438, XrefRangeEnd = 673440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsComputeShaders_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x0007C768 File Offset: 0x0007A968
		public unsafe static bool supportsRenderTargetArrayIndexFromVertexShader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 673445, RefRangeEnd = 673446, XrefRangeStart = 673443, XrefRangeEnd = 673445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsRenderTargetArrayIndexFromVertexShader_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x0007C798 File Offset: 0x0007A998
		public unsafe static bool supportsInstancing
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 673448, RefRangeEnd = 673454, XrefRangeStart = 673446, XrefRangeEnd = 673448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsInstancing_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x0007C7C8 File Offset: 0x0007A9C8
		public unsafe static int supportedRenderTargetCount
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 673456, RefRangeEnd = 673465, XrefRangeStart = 673454, XrefRangeEnd = 673456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportedRenderTargetCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x0007C7F8 File Offset: 0x0007A9F8
		public unsafe static int supportsMultisampledTextures
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 673467, RefRangeEnd = 673471, XrefRangeStart = 673465, XrefRangeEnd = 673467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsMultisampledTextures_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x0007C828 File Offset: 0x0007AA28
		public unsafe static bool supportsMultisampleAutoResolve
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 673473, RefRangeEnd = 673477, XrefRangeStart = 673471, XrefRangeEnd = 673473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsMultisampleAutoResolve_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0007C858 File Offset: 0x0007AA58
		public unsafe static bool usesReversedZBuffer
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 673479, RefRangeEnd = 673484, XrefRangeStart = 673477, XrefRangeEnd = 673479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_usesReversedZBuffer_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0007C888 File Offset: 0x0007AA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673484, XrefRangeEnd = 673489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidEnumValue(Enum value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0007C8C8 File Offset: 0x0007AAC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 673499, RefRangeEnd = 673502, XrefRangeStart = 673489, XrefRangeEnd = 673499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0007C908 File Offset: 0x0007AB08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673512, RefRangeEnd = 673513, XrefRangeStart = 673502, XrefRangeEnd = 673512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsTextureFormat(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x0007C948 File Offset: 0x0007AB48
		public unsafe static int maxTextureSize
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 673515, RefRangeEnd = 673519, XrefRangeStart = 673513, XrefRangeEnd = 673515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_maxTextureSize_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x0007C978 File Offset: 0x0007AB78
		public unsafe static int maxRenderTextureSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 673521, RefRangeEnd = 673523, XrefRangeStart = 673519, XrefRangeEnd = 673521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_maxRenderTextureSize_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x0007C9A8 File Offset: 0x0007ABA8
		public unsafe static bool supportsGraphicsFence
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 673525, RefRangeEnd = 673530, XrefRangeStart = 673523, XrefRangeEnd = 673525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsGraphicsFence_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x0007C9D8 File Offset: 0x0007ABD8
		public unsafe static long maxGraphicsBufferSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 673532, RefRangeEnd = 673533, XrefRangeStart = 673530, XrefRangeEnd = 673532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_maxGraphicsBufferSize_Public_Static_get_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0007CA08 File Offset: 0x0007AC08
		public unsafe static bool usesLoadStoreActions
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 673535, RefRangeEnd = 673537, XrefRangeStart = 673533, XrefRangeEnd = 673535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_usesLoadStoreActions_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x0007CA38 File Offset: 0x0007AC38
		public unsafe static HDRDisplaySupportFlags hdrDisplaySupportFlags
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 673539, RefRangeEnd = 673542, XrefRangeStart = 673537, XrefRangeEnd = 673539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_hdrDisplaySupportFlags_Public_Static_get_HDRDisplaySupportFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x0007CA68 File Offset: 0x0007AC68
		public unsafe static bool supportsMultiview
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 673544, RefRangeEnd = 673549, XrefRangeStart = 673542, XrefRangeEnd = 673544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsMultiview_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001ABB RID: 6843 RVA: 0x0007CA98 File Offset: 0x0007AC98
		public unsafe static bool supportsStoreAndResolveAction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 673551, RefRangeEnd = 673552, XrefRangeStart = 673549, XrefRangeEnd = 673551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsStoreAndResolveAction_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x0007CAC8 File Offset: 0x0007ACC8
		public unsafe static bool supportsMultisampleResolveDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 673554, RefRangeEnd = 673555, XrefRangeStart = 673552, XrefRangeEnd = 673554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsMultisampleResolveDepth_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x0007CAF8 File Offset: 0x0007ACF8
		public unsafe static bool supportsMultisampleResolveStencil
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 673557, RefRangeEnd = 673558, XrefRangeStart = 673555, XrefRangeEnd = 673557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_get_supportsMultisampleResolveStencil_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0007CB28 File Offset: 0x0007AD28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 673244, RefRangeEnd = 673248, XrefRangeStart = 673244, XrefRangeEnd = 673248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetOperatingSystem()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetOperatingSystem_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0007CB54 File Offset: 0x0007AD54
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 673250, RefRangeEnd = 673256, XrefRangeStart = 673250, XrefRangeEnd = 673256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OperatingSystemFamily GetOperatingSystemFamily()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0007CB84 File Offset: 0x0007AD84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 673258, RefRangeEnd = 673263, XrefRangeStart = 673258, XrefRangeEnd = 673263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetProcessorType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetProcessorType_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0007CBB0 File Offset: 0x0007ADB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 673265, RefRangeEnd = 673269, XrefRangeStart = 673265, XrefRangeEnd = 673269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetProcessorFrequencyMHz()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetProcessorFrequencyMHz_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x0007CBE0 File Offset: 0x0007ADE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 673271, RefRangeEnd = 673273, XrefRangeStart = 673271, XrefRangeEnd = 673273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetProcessorCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetProcessorCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x0007CC10 File Offset: 0x0007AE10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 673275, RefRangeEnd = 673278, XrefRangeStart = 673275, XrefRangeEnd = 673278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPhysicalMemoryMB()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetPhysicalMemoryMB_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x0007CC40 File Offset: 0x0007AE40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673280, RefRangeEnd = 673281, XrefRangeStart = 673280, XrefRangeEnd = 673281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDeviceUniqueIdentifier()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceUniqueIdentifier_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0007CC6C File Offset: 0x0007AE6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 673283, RefRangeEnd = 673285, XrefRangeStart = 673283, XrefRangeEnd = 673285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDeviceName()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceName_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0007CC98 File Offset: 0x0007AE98
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 673287, RefRangeEnd = 673295, XrefRangeStart = 673287, XrefRangeEnd = 673295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDeviceModel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0007CCC4 File Offset: 0x0007AEC4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 673297, RefRangeEnd = 673304, XrefRangeStart = 673297, XrefRangeEnd = 673304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeviceType GetDeviceType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0007CCF4 File Offset: 0x0007AEF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 673306, RefRangeEnd = 673309, XrefRangeStart = 673306, XrefRangeEnd = 673309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGraphicsMemorySize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsMemorySize_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0007CD24 File Offset: 0x0007AF24
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 673311, RefRangeEnd = 673318, XrefRangeStart = 673311, XrefRangeEnd = 673318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGraphicsDeviceName()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceName_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0007CD50 File Offset: 0x0007AF50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673320, RefRangeEnd = 673321, XrefRangeStart = 673320, XrefRangeEnd = 673321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGraphicsDeviceVendor()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceVendor_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0007CD7C File Offset: 0x0007AF7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 673323, RefRangeEnd = 673326, XrefRangeStart = 673323, XrefRangeEnd = 673326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGraphicsDeviceID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceID_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0007CDAC File Offset: 0x0007AFAC
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 673328, RefRangeEnd = 673385, XrefRangeStart = 673328, XrefRangeEnd = 673385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.GraphicsDeviceType GetGraphicsDeviceType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceType_Private_Static_GraphicsDeviceType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0007CDDC File Offset: 0x0007AFDC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 673387, RefRangeEnd = 673401, XrefRangeStart = 673387, XrefRangeEnd = 673401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetGraphicsUVStartsAtTop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsUVStartsAtTop_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0007CE0C File Offset: 0x0007B00C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 673403, RefRangeEnd = 673405, XrefRangeStart = 673403, XrefRangeEnd = 673405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGraphicsDeviceVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsDeviceVersion_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0007CE38 File Offset: 0x0007B038
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 673407, RefRangeEnd = 673418, XrefRangeStart = 673407, XrefRangeEnd = 673418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGraphicsShaderLevel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsShaderLevel_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x0007CE68 File Offset: 0x0007B068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673420, RefRangeEnd = 673421, XrefRangeStart = 673420, XrefRangeEnd = 673421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetGraphicsMultiThreaded()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsMultiThreaded_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0007CE98 File Offset: 0x0007B098
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 673423, RefRangeEnd = 673427, XrefRangeStart = 673423, XrefRangeEnd = 673427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.FoveatedRenderingCaps GetFoveatedRenderingCaps()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetFoveatedRenderingCaps_Private_Static_FoveatedRenderingCaps_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x0007CEC8 File Offset: 0x0007B0C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673429, RefRangeEnd = 673430, XrefRangeStart = 673429, XrefRangeEnd = 673430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasHiddenSurfaceRemovalOnGPU()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_HasHiddenSurfaceRemovalOnGPU_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0007CEF8 File Offset: 0x0007B0F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 673432, RefRangeEnd = 673434, XrefRangeStart = 673432, XrefRangeEnd = 673434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsShadows()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsShadows_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x0007CF28 File Offset: 0x0007B128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 673436, RefRangeEnd = 673438, XrefRangeStart = 673436, XrefRangeEnd = 673438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.CopyTextureSupport GetCopyTextureSupport()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetCopyTextureSupport_Private_Static_CopyTextureSupport_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0007CF58 File Offset: 0x0007B158
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 673440, RefRangeEnd = 673443, XrefRangeStart = 673440, XrefRangeEnd = 673443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsComputeShaders()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsComputeShaders_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0007CF88 File Offset: 0x0007B188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673445, RefRangeEnd = 673446, XrefRangeStart = 673445, XrefRangeEnd = 673446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsRenderTargetArrayIndexFromVertexShader()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsRenderTargetArrayIndexFromVertexShader_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0007CFB8 File Offset: 0x0007B1B8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 673448, RefRangeEnd = 673454, XrefRangeStart = 673448, XrefRangeEnd = 673454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsInstancing()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsInstancing_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x0007CFE8 File Offset: 0x0007B1E8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 673456, RefRangeEnd = 673465, XrefRangeStart = 673456, XrefRangeEnd = 673465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SupportedRenderTargetCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportedRenderTargetCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0007D018 File Offset: 0x0007B218
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 673467, RefRangeEnd = 673471, XrefRangeStart = 673467, XrefRangeEnd = 673471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SupportsMultisampledTextures()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsMultisampledTextures_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x0007D048 File Offset: 0x0007B248
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 673473, RefRangeEnd = 673477, XrefRangeStart = 673473, XrefRangeEnd = 673477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsMultisampleAutoResolve()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsMultisampleAutoResolve_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x0007D078 File Offset: 0x0007B278
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 673479, RefRangeEnd = 673484, XrefRangeStart = 673479, XrefRangeEnd = 673484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UsesReversedZBuffer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_UsesReversedZBuffer_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0007D0A8 File Offset: 0x0007B2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673558, XrefRangeEnd = 673560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasRenderTextureNative(RenderTextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_HasRenderTextureNative_Private_Static_Boolean_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x0007D0E8 File Offset: 0x0007B2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673560, XrefRangeEnd = 673562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsTextureFormatNative(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x0007D128 File Offset: 0x0007B328
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 673515, RefRangeEnd = 673519, XrefRangeStart = 673515, XrefRangeEnd = 673519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxTextureSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetMaxTextureSize_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0007D158 File Offset: 0x0007B358
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 673521, RefRangeEnd = 673523, XrefRangeStart = 673521, XrefRangeEnd = 673523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxRenderTextureSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetMaxRenderTextureSize_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0007D188 File Offset: 0x0007B388
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 673525, RefRangeEnd = 673530, XrefRangeStart = 673525, XrefRangeEnd = 673530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsGPUFence()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsGPUFence_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0007D1B8 File Offset: 0x0007B3B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673532, RefRangeEnd = 673533, XrefRangeStart = 673532, XrefRangeEnd = 673533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long MaxGraphicsBufferSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_MaxGraphicsBufferSize_Private_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0007D1E8 File Offset: 0x0007B3E8
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 673564, RefRangeEnd = 673589, XrefRangeStart = 673562, XrefRangeEnd = 673564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_FormatUsage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x0007D234 File Offset: 0x0007B434
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 673591, RefRangeEnd = 673594, XrefRangeStart = 673589, XrefRangeEnd = 673591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_FormatUsage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0007D280 File Offset: 0x0007B480
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 673596, RefRangeEnd = 673618, XrefRangeStart = 673594, XrefRangeEnd = 673596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0007D2C0 File Offset: 0x0007B4C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673620, RefRangeEnd = 673621, XrefRangeStart = 673618, XrefRangeEnd = 673620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Public_Static_Int32_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x0007D300 File Offset: 0x0007B500
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 673535, RefRangeEnd = 673537, XrefRangeStart = 673535, XrefRangeEnd = 673537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UsesLoadStoreActions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_UsesLoadStoreActions_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x0007D330 File Offset: 0x0007B530
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 673539, RefRangeEnd = 673542, XrefRangeStart = 673539, XrefRangeEnd = 673542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HDRDisplaySupportFlags GetHDRDisplaySupportFlags()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetHDRDisplaySupportFlags_Private_Static_HDRDisplaySupportFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0007D360 File Offset: 0x0007B560
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 673544, RefRangeEnd = 673549, XrefRangeStart = 673544, XrefRangeEnd = 673549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsMultiview()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsMultiview_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x0007D390 File Offset: 0x0007B590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673551, RefRangeEnd = 673552, XrefRangeStart = 673551, XrefRangeEnd = 673552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsStoreAndResolveAction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsStoreAndResolveAction_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x0007D3C0 File Offset: 0x0007B5C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673554, RefRangeEnd = 673555, XrefRangeStart = 673554, XrefRangeEnd = 673555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsMultisampleResolveDepth()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsMultisampleResolveDepth_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0007D3F0 File Offset: 0x0007B5F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 673557, RefRangeEnd = 673558, XrefRangeStart = 673557, XrefRangeEnd = 673558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsMultisampleResolveStencil()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_SupportsMultisampleResolveStencil_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0007D420 File Offset: 0x0007B620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673621, XrefRangeEnd = 673623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRenderTextureSupportedMSAASampleCount_Injected(ref RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemInfo.NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Injected_Private_Static_Int32_byref_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0000A77E File Offset: 0x0000897E
		public SystemInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x0007D460 File Offset: 0x0007B660
		public static float batteryLevel
		{
			get
			{
				return SystemInfo.GetBatteryLevel();
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x0007D478 File Offset: 0x0007B678
		public static BatteryStatus batteryStatus
		{
			get
			{
				return SystemInfo.GetBatteryStatus();
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x0007D490 File Offset: 0x0007B690
		public static bool supportsAccelerometer
		{
			get
			{
				return SystemInfo.SupportsAccelerometer();
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x0007D4A8 File Offset: 0x0007B6A8
		public static bool supportsGyroscope
		{
			get
			{
				return SystemInfo.IsGyroAvailable();
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x0007D4C0 File Offset: 0x0007B6C0
		public static bool supportsLocationService
		{
			get
			{
				return SystemInfo.SupportsLocationService();
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x0007D4D8 File Offset: 0x0007B6D8
		public static bool supportsVibration
		{
			get
			{
				return SystemInfo.SupportsVibration();
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x0007D4F0 File Offset: 0x0007B6F0
		public static bool supportsAudio
		{
			get
			{
				return SystemInfo.SupportsAudio();
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x0007D508 File Offset: 0x0007B708
		public static int graphicsDeviceVendorID
		{
			get
			{
				return SystemInfo.GetGraphicsDeviceVendorID();
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x0007D520 File Offset: 0x0007B720
		public static UnityEngine.Rendering.RenderingThreadingMode renderingThreadingMode
		{
			get
			{
				return SystemInfo.GetRenderingThreadingMode();
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x0007D538 File Offset: 0x0007B738
		public static bool hasDynamicUniformArrayIndexingInFragmentShaders
		{
			get
			{
				return SystemInfo.HasDynamicUniformArrayIndexingInFragmentShaders();
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x0007D550 File Offset: 0x0007B750
		public static bool supportsRawShadowDepthSampling
		{
			get
			{
				return SystemInfo.SupportsRawShadowDepthSampling();
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x0007D568 File Offset: 0x0007B768
		public static bool supportsRenderTextures
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x0007D57C File Offset: 0x0007B77C
		public static bool supportsMotionVectors
		{
			get
			{
				return SystemInfo.SupportsMotionVectors();
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x0007D594 File Offset: 0x0007B794
		public static bool supportsRenderToCubemap
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x0007D5A8 File Offset: 0x0007B7A8
		public static bool supportsImageEffects
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x0007D5BC File Offset: 0x0007B7BC
		public static bool supports3DTextures
		{
			get
			{
				return SystemInfo.Supports3DTextures();
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001AFE RID: 6910 RVA: 0x0007D5D4 File Offset: 0x0007B7D4
		public static bool supportsCompressed3DTextures
		{
			get
			{
				return SystemInfo.SupportsCompressed3DTextures();
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0007D5EC File Offset: 0x0007B7EC
		public static bool supports2DArrayTextures
		{
			get
			{
				return SystemInfo.Supports2DArrayTextures();
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x0007D604 File Offset: 0x0007B804
		public static bool supports3DRenderTextures
		{
			get
			{
				return SystemInfo.Supports3DRenderTextures();
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x0007D61C File Offset: 0x0007B81C
		public static bool supportsCubemapArrayTextures
		{
			get
			{
				return SystemInfo.SupportsCubemapArrayTextures();
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x0007D634 File Offset: 0x0007B834
		public static bool supportsAnisotropicFilter
		{
			get
			{
				return SystemInfo.SupportsAnisotropicFilter();
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x0007D64C File Offset: 0x0007B84C
		public static bool supportsGeometryShaders
		{
			get
			{
				return SystemInfo.SupportsGeometryShaders();
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x0007D664 File Offset: 0x0007B864
		public static bool supportsTessellationShaders
		{
			get
			{
				return SystemInfo.SupportsTessellationShaders();
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x0007D67C File Offset: 0x0007B87C
		public static bool supportsHardwareQuadTopology
		{
			get
			{
				return SystemInfo.SupportsHardwareQuadTopology();
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0007D694 File Offset: 0x0007B894
		public static bool supports32bitsIndexBuffer
		{
			get
			{
				return SystemInfo.Supports32bitsIndexBuffer();
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x0007D6AC File Offset: 0x0007B8AC
		public static bool supportsSparseTextures
		{
			get
			{
				return SystemInfo.SupportsSparseTextures();
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0007D6C4 File Offset: 0x0007B8C4
		public static bool supportsSeparatedRenderTargetsBlend
		{
			get
			{
				return SystemInfo.SupportsSeparatedRenderTargetsBlend();
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0007D6DC File Offset: 0x0007B8DC
		public static int supportedRandomWriteTargetCount
		{
			get
			{
				return SystemInfo.SupportedRandomWriteTargetCount();
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x0007D6F4 File Offset: 0x0007B8F4
		public static bool supportsMultisampled2DArrayTextures
		{
			get
			{
				return SystemInfo.SupportsMultisampled2DArrayTextures();
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x0007D70C File Offset: 0x0007B90C
		public static int supportsTextureWrapMirrorOnce
		{
			get
			{
				return SystemInfo.SupportsTextureWrapMirrorOnce();
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0007D724 File Offset: 0x0007B924
		public static int supportsStencil
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0007D738 File Offset: 0x0007B938
		public static bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format)
		{
			bool flag = !SystemInfo.IsValidEnumValue(format);
			if (flag)
			{
				throw new ArgumentException("Failed SupportsBlendingOnRenderTextureFormat; format is not a valid RenderTextureFormat");
			}
			return SystemInfo.SupportsBlendingOnRenderTextureFormatNative(format);
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x0007D770 File Offset: 0x0007B970
		public static bool SupportsRandomWriteOnRenderTextureFormat(RenderTextureFormat format)
		{
			bool flag = !SystemInfo.IsValidEnumValue(format);
			if (flag)
			{
				throw new ArgumentException("Failed SupportsRandomWriteOnRenderTextureFormat; format is not a valid RenderTextureFormat");
			}
			return SystemInfo.SupportsRandomWriteOnRenderTextureFormatNative(format);
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0007D7A8 File Offset: 0x0007B9A8
		public static bool SupportsVertexAttributeFormat(UnityEngine.Rendering.VertexAttributeFormat format, int dimension)
		{
			bool flag = !SystemInfo.IsValidEnumValue(format);
			if (flag)
			{
				throw new ArgumentException("Failed SupportsVertexAttributeFormat; format is not a valid VertexAttributeFormat");
			}
			bool flag2 = dimension < 1 || dimension > 4;
			if (flag2)
			{
				throw new ArgumentException("Failed SupportsVertexAttributeFormat; dimension must be in 1..4 range");
			}
			return SystemInfo.SupportsVertexAttributeFormatNative(format, dimension);
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x0007D7F8 File Offset: 0x0007B9F8
		public static NPOTSupport npotSupport
		{
			get
			{
				return SystemInfo.GetNPOTSupport();
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x0007D810 File Offset: 0x0007BA10
		public static int maxTexture3DSize
		{
			get
			{
				return SystemInfo.GetMaxTexture3DSize();
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x0007D828 File Offset: 0x0007BA28
		public static int maxTextureArraySlices
		{
			get
			{
				return SystemInfo.GetMaxTextureArraySlices();
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x0007D840 File Offset: 0x0007BA40
		public static int maxCubemapSize
		{
			get
			{
				return SystemInfo.GetMaxCubemapSize();
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x0007D858 File Offset: 0x0007BA58
		public static int maxAnisotropyLevel
		{
			get
			{
				return SystemInfo.GetMaxAnisotropyLevel();
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x0007D870 File Offset: 0x0007BA70
		public static int maxComputeBufferInputsVertex
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsVertex();
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x0007D888 File Offset: 0x0007BA88
		public static int maxComputeBufferInputsFragment
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsFragment();
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x0007D8A0 File Offset: 0x0007BAA0
		public static int maxComputeBufferInputsGeometry
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsGeometry();
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x0007D8B8 File Offset: 0x0007BAB8
		public static int maxComputeBufferInputsDomain
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsDomain();
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x0007D8D0 File Offset: 0x0007BAD0
		public static int maxComputeBufferInputsHull
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsHull();
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x0007D8E8 File Offset: 0x0007BAE8
		public static int maxComputeBufferInputsCompute
		{
			get
			{
				return SystemInfo.MaxComputeBufferInputsCompute();
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x0007D900 File Offset: 0x0007BB00
		public static int maxComputeWorkGroupSize
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSize();
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001B1C RID: 6940 RVA: 0x0007D918 File Offset: 0x0007BB18
		public static int maxComputeWorkGroupSizeX
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSizeX();
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x0007D930 File Offset: 0x0007BB30
		public static int maxComputeWorkGroupSizeY
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSizeY();
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x0007D948 File Offset: 0x0007BB48
		public static int maxComputeWorkGroupSizeZ
		{
			get
			{
				return SystemInfo.GetMaxComputeWorkGroupSizeZ();
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x0007D960 File Offset: 0x0007BB60
		public static int computeSubGroupSize
		{
			get
			{
				return SystemInfo.GetComputeSubGroupSize();
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x0007D978 File Offset: 0x0007BB78
		public static bool supportsAsyncCompute
		{
			get
			{
				return SystemInfo.SupportsAsyncCompute();
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x0007D990 File Offset: 0x0007BB90
		public static bool supportsGpuRecorder
		{
			get
			{
				return SystemInfo.SupportsGpuRecorder();
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x0007D9A8 File Offset: 0x0007BBA8
		public static bool supportsAsyncGPUReadback
		{
			get
			{
				return SystemInfo.SupportsAsyncGPUReadback();
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x0007D9C0 File Offset: 0x0007BBC0
		public static bool supportsRayTracing
		{
			get
			{
				return SystemInfo.SupportsRayTracing();
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0007D9D8 File Offset: 0x0007BBD8
		public static bool supportsSetConstantBuffer
		{
			get
			{
				return SystemInfo.SupportsSetConstantBuffer();
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x0007D9F0 File Offset: 0x0007BBF0
		public static int constantBufferOffsetAlignment
		{
			get
			{
				return SystemInfo.MinConstantBufferOffsetAlignment();
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x0007DA08 File Offset: 0x0007BC08
		public static int maxConstantBufferSize
		{
			get
			{
				return SystemInfo.MaxConstantBufferSize();
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x0007DA20 File Offset: 0x0007BC20
		public static bool minConstantBufferOffsetAlignment
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x0007DA34 File Offset: 0x0007BC34
		public static bool hasMipMaxLevel
		{
			get
			{
				return SystemInfo.HasMipMaxLevel();
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x0007DA4C File Offset: 0x0007BC4C
		public static bool supportsMipStreaming
		{
			get
			{
				return SystemInfo.SupportsMipStreaming();
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001B2A RID: 6954 RVA: 0x0007DA64 File Offset: 0x0007BC64
		public static int graphicsPixelFillrate
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x0007DA78 File Offset: 0x0007BC78
		public static bool supportsConservativeRaster
		{
			get
			{
				return SystemInfo.SupportsConservativeRaster();
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x0007DA90 File Offset: 0x0007BC90
		public static bool supportsIndirectArgumentsBuffer
		{
			get
			{
				return SystemInfo.SupportsIndirectArgumentsBuffer();
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x0007DAA8 File Offset: 0x0007BCA8
		public static bool supportsVertexPrograms
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0000A787 File Offset: 0x00008987
		public static float GetBatteryLevel()
		{
			return SystemInfo.GetBatteryLevelDelegateField();
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0000A793 File Offset: 0x00008993
		public static BatteryStatus GetBatteryStatus()
		{
			return SystemInfo.GetBatteryStatusDelegateField();
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0000A79F File Offset: 0x0000899F
		public static bool SupportsAccelerometer()
		{
			return SystemInfo.SupportsAccelerometerDelegateField();
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0000A7AB File Offset: 0x000089AB
		public static bool IsGyroAvailable()
		{
			return SystemInfo.IsGyroAvailableDelegateField();
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0000A7B7 File Offset: 0x000089B7
		public static bool SupportsLocationService()
		{
			return SystemInfo.SupportsLocationServiceDelegateField();
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0000A7C3 File Offset: 0x000089C3
		public static bool SupportsVibration()
		{
			return SystemInfo.SupportsVibrationDelegateField();
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x0000A7CF File Offset: 0x000089CF
		public static bool SupportsAudio()
		{
			return SystemInfo.SupportsAudioDelegateField();
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0000A7DB File Offset: 0x000089DB
		public static int GetGraphicsDeviceVendorID()
		{
			return SystemInfo.GetGraphicsDeviceVendorIDDelegateField();
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0000A7E7 File Offset: 0x000089E7
		public static UnityEngine.Rendering.RenderingThreadingMode GetRenderingThreadingMode()
		{
			return SystemInfo.GetRenderingThreadingModeDelegateField();
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0000A7F3 File Offset: 0x000089F3
		public static bool HasDynamicUniformArrayIndexingInFragmentShaders()
		{
			return SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegateField();
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0000A7FF File Offset: 0x000089FF
		public static bool SupportsRawShadowDepthSampling()
		{
			return SystemInfo.SupportsRawShadowDepthSamplingDelegateField();
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0000A80B File Offset: 0x00008A0B
		public static bool SupportsMotionVectors()
		{
			return SystemInfo.SupportsMotionVectorsDelegateField();
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x0000A817 File Offset: 0x00008A17
		public static bool Supports3DTextures()
		{
			return SystemInfo.Supports3DTexturesDelegateField();
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x0000A823 File Offset: 0x00008A23
		public static bool SupportsCompressed3DTextures()
		{
			return SystemInfo.SupportsCompressed3DTexturesDelegateField();
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x0000A82F File Offset: 0x00008A2F
		public static bool Supports2DArrayTextures()
		{
			return SystemInfo.Supports2DArrayTexturesDelegateField();
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0000A83B File Offset: 0x00008A3B
		public static bool Supports3DRenderTextures()
		{
			return SystemInfo.Supports3DRenderTexturesDelegateField();
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0000A847 File Offset: 0x00008A47
		public static bool SupportsCubemapArrayTextures()
		{
			return SystemInfo.SupportsCubemapArrayTexturesDelegateField();
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0000A853 File Offset: 0x00008A53
		public static bool SupportsAnisotropicFilter()
		{
			return SystemInfo.SupportsAnisotropicFilterDelegateField();
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0000A85F File Offset: 0x00008A5F
		public static bool SupportsGeometryShaders()
		{
			return SystemInfo.SupportsGeometryShadersDelegateField();
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0000A86B File Offset: 0x00008A6B
		public static bool SupportsTessellationShaders()
		{
			return SystemInfo.SupportsTessellationShadersDelegateField();
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0000A877 File Offset: 0x00008A77
		public static bool SupportsHardwareQuadTopology()
		{
			return SystemInfo.SupportsHardwareQuadTopologyDelegateField();
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0000A883 File Offset: 0x00008A83
		public static bool Supports32bitsIndexBuffer()
		{
			return SystemInfo.Supports32bitsIndexBufferDelegateField();
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0000A88F File Offset: 0x00008A8F
		public static bool SupportsSparseTextures()
		{
			return SystemInfo.SupportsSparseTexturesDelegateField();
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0000A89B File Offset: 0x00008A9B
		public static bool SupportsSeparatedRenderTargetsBlend()
		{
			return SystemInfo.SupportsSeparatedRenderTargetsBlendDelegateField();
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x0000A8A7 File Offset: 0x00008AA7
		public static int SupportedRandomWriteTargetCount()
		{
			return SystemInfo.SupportedRandomWriteTargetCountDelegateField();
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0000A8B3 File Offset: 0x00008AB3
		public static int MaxComputeBufferInputsVertex()
		{
			return SystemInfo.MaxComputeBufferInputsVertexDelegateField();
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0000A8BF File Offset: 0x00008ABF
		public static int MaxComputeBufferInputsFragment()
		{
			return SystemInfo.MaxComputeBufferInputsFragmentDelegateField();
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0000A8CB File Offset: 0x00008ACB
		public static int MaxComputeBufferInputsGeometry()
		{
			return SystemInfo.MaxComputeBufferInputsGeometryDelegateField();
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0000A8D7 File Offset: 0x00008AD7
		public static int MaxComputeBufferInputsDomain()
		{
			return SystemInfo.MaxComputeBufferInputsDomainDelegateField();
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0000A8E3 File Offset: 0x00008AE3
		public static int MaxComputeBufferInputsHull()
		{
			return SystemInfo.MaxComputeBufferInputsHullDelegateField();
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0000A8EF File Offset: 0x00008AEF
		public static int MaxComputeBufferInputsCompute()
		{
			return SystemInfo.MaxComputeBufferInputsComputeDelegateField();
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0000A8FB File Offset: 0x00008AFB
		public static bool SupportsMultisampled2DArrayTextures()
		{
			return SystemInfo.SupportsMultisampled2DArrayTexturesDelegateField();
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0000A907 File Offset: 0x00008B07
		public static int SupportsTextureWrapMirrorOnce()
		{
			return SystemInfo.SupportsTextureWrapMirrorOnceDelegateField();
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0000A913 File Offset: 0x00008B13
		public static bool SupportsBlendingOnRenderTextureFormatNative(RenderTextureFormat format)
		{
			return SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegateField(format);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0000A920 File Offset: 0x00008B20
		public static bool SupportsRandomWriteOnRenderTextureFormatNative(RenderTextureFormat format)
		{
			return SystemInfo.SupportsRandomWriteOnRenderTextureFormatNativeDelegateField(format);
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0000A92D File Offset: 0x00008B2D
		public static bool SupportsVertexAttributeFormatNative(UnityEngine.Rendering.VertexAttributeFormat format, int dimension)
		{
			return SystemInfo.SupportsVertexAttributeFormatNativeDelegateField(format, dimension);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0000A93B File Offset: 0x00008B3B
		public static NPOTSupport GetNPOTSupport()
		{
			return SystemInfo.GetNPOTSupportDelegateField();
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0000A947 File Offset: 0x00008B47
		public static int GetMaxTexture3DSize()
		{
			return SystemInfo.GetMaxTexture3DSizeDelegateField();
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0000A953 File Offset: 0x00008B53
		public static int GetMaxTextureArraySlices()
		{
			return SystemInfo.GetMaxTextureArraySlicesDelegateField();
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0000A95F File Offset: 0x00008B5F
		public static int GetMaxCubemapSize()
		{
			return SystemInfo.GetMaxCubemapSizeDelegateField();
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0000A96B File Offset: 0x00008B6B
		public static int GetMaxAnisotropyLevel()
		{
			return SystemInfo.GetMaxAnisotropyLevelDelegateField();
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x0000A977 File Offset: 0x00008B77
		public static int GetMaxComputeWorkGroupSize()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeDelegateField();
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0000A983 File Offset: 0x00008B83
		public static int GetMaxComputeWorkGroupSizeX()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeXDelegateField();
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0000A98F File Offset: 0x00008B8F
		public static int GetMaxComputeWorkGroupSizeY()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeYDelegateField();
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0000A99B File Offset: 0x00008B9B
		public static int GetMaxComputeWorkGroupSizeZ()
		{
			return SystemInfo.GetMaxComputeWorkGroupSizeZDelegateField();
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0000A9A7 File Offset: 0x00008BA7
		public static int GetComputeSubGroupSize()
		{
			return SystemInfo.GetComputeSubGroupSizeDelegateField();
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0000A9B3 File Offset: 0x00008BB3
		public static bool SupportsAsyncCompute()
		{
			return SystemInfo.SupportsAsyncComputeDelegateField();
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0000A9BF File Offset: 0x00008BBF
		public static bool SupportsGpuRecorder()
		{
			return SystemInfo.SupportsGpuRecorderDelegateField();
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0000A9CB File Offset: 0x00008BCB
		public static bool SupportsAsyncGPUReadback()
		{
			return SystemInfo.SupportsAsyncGPUReadbackDelegateField();
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0000A9D7 File Offset: 0x00008BD7
		public static bool SupportsRayTracing()
		{
			return SystemInfo.SupportsRayTracingDelegateField();
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0000A9E3 File Offset: 0x00008BE3
		public static bool SupportsSetConstantBuffer()
		{
			return SystemInfo.SupportsSetConstantBufferDelegateField();
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0000A9EF File Offset: 0x00008BEF
		public static int MinConstantBufferOffsetAlignment()
		{
			return SystemInfo.MinConstantBufferOffsetAlignmentDelegateField();
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0000A9FB File Offset: 0x00008BFB
		public static int MaxConstantBufferSize()
		{
			return SystemInfo.MaxConstantBufferSizeDelegateField();
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0000AA07 File Offset: 0x00008C07
		public static bool HasMipMaxLevel()
		{
			return SystemInfo.HasMipMaxLevelDelegateField();
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0000AA13 File Offset: 0x00008C13
		public static bool SupportsMipStreaming()
		{
			return SystemInfo.SupportsMipStreamingDelegateField();
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0000AA1F File Offset: 0x00008C1F
		public static bool SupportsConservativeRaster()
		{
			return SystemInfo.SupportsConservativeRasterDelegateField();
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0000AA2B File Offset: 0x00008C2B
		public static bool SupportsIndirectArgumentsBuffer()
		{
			return SystemInfo.SupportsIndirectArgumentsBufferDelegateField();
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x0007DABC File Offset: 0x0007BCBC
		public static bool supportsGPUFence
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeMethodInfoPtr_get_operatingSystem_Public_Static_get_String_0;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeMethodInfoPtr_get_processorType_Public_Static_get_String_0;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeMethodInfoPtr_get_processorFrequency_Public_Static_get_Int32_0;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeMethodInfoPtr_get_processorCount_Public_Static_get_Int32_0;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeMethodInfoPtr_get_systemMemorySize_Public_Static_get_Int32_0;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceUniqueIdentifier_Public_Static_get_String_0;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceName_Public_Static_get_String_0;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsMemorySize_Public_Static_get_Int32_0;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsDeviceName_Public_Static_get_String_0;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsDeviceVendor_Public_Static_get_String_0;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsDeviceID_Public_Static_get_Int32_0;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsDeviceType_Public_Static_get_GraphicsDeviceType_0;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsUVStartsAtTop_Public_Static_get_Boolean_0;

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsDeviceVersion_Public_Static_get_String_0;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsShaderLevel_Public_Static_get_Int32_0;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsMultiThreaded_Public_Static_get_Boolean_0;

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0;

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeMethodInfoPtr_get_hasHiddenSurfaceRemovalOnGPU_Public_Static_get_Boolean_0;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsShadows_Public_Static_get_Boolean_0;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeMethodInfoPtr_get_copyTextureSupport_Public_Static_get_CopyTextureSupport_0;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsComputeShaders_Public_Static_get_Boolean_0;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsRenderTargetArrayIndexFromVertexShader_Public_Static_get_Boolean_0;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsInstancing_Public_Static_get_Boolean_0;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeMethodInfoPtr_get_supportedRenderTargetCount_Public_Static_get_Int32_0;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsMultisampledTextures_Public_Static_get_Int32_0;

		// Token: 0x0400179C RID: 6044
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsMultisampleAutoResolve_Public_Static_get_Boolean_0;

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeMethodInfoPtr_get_usesReversedZBuffer_Public_Static_get_Boolean_0;

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0;

		// Token: 0x040017A0 RID: 6048
		private static readonly IntPtr NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0;

		// Token: 0x040017A1 RID: 6049
		private static readonly IntPtr NativeMethodInfoPtr_get_maxTextureSize_Public_Static_get_Int32_0;

		// Token: 0x040017A2 RID: 6050
		private static readonly IntPtr NativeMethodInfoPtr_get_maxRenderTextureSize_Internal_Static_get_Int32_0;

		// Token: 0x040017A3 RID: 6051
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsGraphicsFence_Public_Static_get_Boolean_0;

		// Token: 0x040017A4 RID: 6052
		private static readonly IntPtr NativeMethodInfoPtr_get_maxGraphicsBufferSize_Public_Static_get_Int64_0;

		// Token: 0x040017A5 RID: 6053
		private static readonly IntPtr NativeMethodInfoPtr_get_usesLoadStoreActions_Public_Static_get_Boolean_0;

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeMethodInfoPtr_get_hdrDisplaySupportFlags_Public_Static_get_HDRDisplaySupportFlags_0;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsMultiview_Public_Static_get_Boolean_0;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsStoreAndResolveAction_Public_Static_get_Boolean_0;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsMultisampleResolveDepth_Public_Static_get_Boolean_0;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsMultisampleResolveStencil_Public_Static_get_Boolean_0;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeMethodInfoPtr_GetOperatingSystem_Private_Static_String_0;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessorType_Private_Static_String_0;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessorFrequencyMHz_Private_Static_Int32_0;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessorCount_Private_Static_Int32_0;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeMethodInfoPtr_GetPhysicalMemoryMB_Private_Static_Int32_0;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceUniqueIdentifier_Private_Static_String_0;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceName_Private_Static_String_0;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsMemorySize_Private_Static_Int32_0;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsDeviceName_Private_Static_String_0;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsDeviceVendor_Private_Static_String_0;

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsDeviceID_Private_Static_Int32_0;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsDeviceType_Private_Static_GraphicsDeviceType_0;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsUVStartsAtTop_Private_Static_Boolean_0;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsDeviceVersion_Private_Static_String_0;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsShaderLevel_Private_Static_Int32_0;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsMultiThreaded_Private_Static_Boolean_0;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeMethodInfoPtr_GetFoveatedRenderingCaps_Private_Static_FoveatedRenderingCaps_0;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeMethodInfoPtr_HasHiddenSurfaceRemovalOnGPU_Private_Static_Boolean_0;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeMethodInfoPtr_SupportsShadows_Private_Static_Boolean_0;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeMethodInfoPtr_GetCopyTextureSupport_Private_Static_CopyTextureSupport_0;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeMethodInfoPtr_SupportsComputeShaders_Private_Static_Boolean_0;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeMethodInfoPtr_SupportsRenderTargetArrayIndexFromVertexShader_Private_Static_Boolean_0;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeMethodInfoPtr_SupportsInstancing_Private_Static_Boolean_0;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeMethodInfoPtr_SupportedRenderTargetCount_Private_Static_Int32_0;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeMethodInfoPtr_SupportsMultisampledTextures_Private_Static_Int32_0;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeMethodInfoPtr_SupportsMultisampleAutoResolve_Private_Static_Boolean_0;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeMethodInfoPtr_UsesReversedZBuffer_Private_Static_Boolean_0;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeMethodInfoPtr_HasRenderTextureNative_Private_Static_Boolean_RenderTextureFormat_0;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxTextureSize_Private_Static_Int32_0;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxRenderTextureSize_Private_Static_Int32_0;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeMethodInfoPtr_SupportsGPUFence_Private_Static_Boolean_0;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeMethodInfoPtr_MaxGraphicsBufferSize_Private_Static_Int64_0;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_FormatUsage_0;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_FormatUsage_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Public_Static_Int32_RenderTextureDescriptor_0;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeMethodInfoPtr_UsesLoadStoreActions_Private_Static_Boolean_0;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeMethodInfoPtr_GetHDRDisplaySupportFlags_Private_Static_HDRDisplaySupportFlags_0;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeMethodInfoPtr_SupportsMultiview_Private_Static_Boolean_0;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeMethodInfoPtr_SupportsStoreAndResolveAction_Private_Static_Boolean_0;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeMethodInfoPtr_SupportsMultisampleResolveDepth_Private_Static_Boolean_0;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeMethodInfoPtr_SupportsMultisampleResolveStencil_Private_Static_Boolean_0;

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Injected_Private_Static_Int32_byref_RenderTextureDescriptor_0;

		// Token: 0x040017DA RID: 6106
		public const string unsupportedIdentifier = "n/a";

		// Token: 0x040017DB RID: 6107
		private static readonly SystemInfo.GetBatteryLevelDelegate GetBatteryLevelDelegateField;

		// Token: 0x040017DC RID: 6108
		private static readonly SystemInfo.GetBatteryStatusDelegate GetBatteryStatusDelegateField;

		// Token: 0x040017DD RID: 6109
		private static readonly SystemInfo.SupportsAccelerometerDelegate SupportsAccelerometerDelegateField;

		// Token: 0x040017DE RID: 6110
		private static readonly SystemInfo.IsGyroAvailableDelegate IsGyroAvailableDelegateField;

		// Token: 0x040017DF RID: 6111
		private static readonly SystemInfo.SupportsLocationServiceDelegate SupportsLocationServiceDelegateField;

		// Token: 0x040017E0 RID: 6112
		private static readonly SystemInfo.SupportsVibrationDelegate SupportsVibrationDelegateField;

		// Token: 0x040017E1 RID: 6113
		private static readonly SystemInfo.SupportsAudioDelegate SupportsAudioDelegateField;

		// Token: 0x040017E2 RID: 6114
		private static readonly SystemInfo.GetGraphicsDeviceVendorIDDelegate GetGraphicsDeviceVendorIDDelegateField;

		// Token: 0x040017E3 RID: 6115
		private static readonly SystemInfo.GetRenderingThreadingModeDelegate GetRenderingThreadingModeDelegateField;

		// Token: 0x040017E4 RID: 6116
		private static readonly SystemInfo.HasDynamicUniformArrayIndexingInFragmentShadersDelegate HasDynamicUniformArrayIndexingInFragmentShadersDelegateField;

		// Token: 0x040017E5 RID: 6117
		private static readonly SystemInfo.SupportsRawShadowDepthSamplingDelegate SupportsRawShadowDepthSamplingDelegateField;

		// Token: 0x040017E6 RID: 6118
		private static readonly SystemInfo.SupportsMotionVectorsDelegate SupportsMotionVectorsDelegateField;

		// Token: 0x040017E7 RID: 6119
		private static readonly SystemInfo.Supports3DTexturesDelegate Supports3DTexturesDelegateField;

		// Token: 0x040017E8 RID: 6120
		private static readonly SystemInfo.SupportsCompressed3DTexturesDelegate SupportsCompressed3DTexturesDelegateField;

		// Token: 0x040017E9 RID: 6121
		private static readonly SystemInfo.Supports2DArrayTexturesDelegate Supports2DArrayTexturesDelegateField;

		// Token: 0x040017EA RID: 6122
		private static readonly SystemInfo.Supports3DRenderTexturesDelegate Supports3DRenderTexturesDelegateField;

		// Token: 0x040017EB RID: 6123
		private static readonly SystemInfo.SupportsCubemapArrayTexturesDelegate SupportsCubemapArrayTexturesDelegateField;

		// Token: 0x040017EC RID: 6124
		private static readonly SystemInfo.SupportsAnisotropicFilterDelegate SupportsAnisotropicFilterDelegateField;

		// Token: 0x040017ED RID: 6125
		private static readonly SystemInfo.SupportsGeometryShadersDelegate SupportsGeometryShadersDelegateField;

		// Token: 0x040017EE RID: 6126
		private static readonly SystemInfo.SupportsTessellationShadersDelegate SupportsTessellationShadersDelegateField;

		// Token: 0x040017EF RID: 6127
		private static readonly SystemInfo.SupportsHardwareQuadTopologyDelegate SupportsHardwareQuadTopologyDelegateField;

		// Token: 0x040017F0 RID: 6128
		private static readonly SystemInfo.Supports32bitsIndexBufferDelegate Supports32bitsIndexBufferDelegateField;

		// Token: 0x040017F1 RID: 6129
		private static readonly SystemInfo.SupportsSparseTexturesDelegate SupportsSparseTexturesDelegateField;

		// Token: 0x040017F2 RID: 6130
		private static readonly SystemInfo.SupportsSeparatedRenderTargetsBlendDelegate SupportsSeparatedRenderTargetsBlendDelegateField;

		// Token: 0x040017F3 RID: 6131
		private static readonly SystemInfo.SupportedRandomWriteTargetCountDelegate SupportedRandomWriteTargetCountDelegateField;

		// Token: 0x040017F4 RID: 6132
		private static readonly SystemInfo.MaxComputeBufferInputsVertexDelegate MaxComputeBufferInputsVertexDelegateField;

		// Token: 0x040017F5 RID: 6133
		private static readonly SystemInfo.MaxComputeBufferInputsFragmentDelegate MaxComputeBufferInputsFragmentDelegateField;

		// Token: 0x040017F6 RID: 6134
		private static readonly SystemInfo.MaxComputeBufferInputsGeometryDelegate MaxComputeBufferInputsGeometryDelegateField;

		// Token: 0x040017F7 RID: 6135
		private static readonly SystemInfo.MaxComputeBufferInputsDomainDelegate MaxComputeBufferInputsDomainDelegateField;

		// Token: 0x040017F8 RID: 6136
		private static readonly SystemInfo.MaxComputeBufferInputsHullDelegate MaxComputeBufferInputsHullDelegateField;

		// Token: 0x040017F9 RID: 6137
		private static readonly SystemInfo.MaxComputeBufferInputsComputeDelegate MaxComputeBufferInputsComputeDelegateField;

		// Token: 0x040017FA RID: 6138
		private static readonly SystemInfo.SupportsMultisampled2DArrayTexturesDelegate SupportsMultisampled2DArrayTexturesDelegateField;

		// Token: 0x040017FB RID: 6139
		private static readonly SystemInfo.SupportsTextureWrapMirrorOnceDelegate SupportsTextureWrapMirrorOnceDelegateField;

		// Token: 0x040017FC RID: 6140
		private static readonly SystemInfo.SupportsBlendingOnRenderTextureFormatNativeDelegate SupportsBlendingOnRenderTextureFormatNativeDelegateField;

		// Token: 0x040017FD RID: 6141
		private static readonly SystemInfo.SupportsRandomWriteOnRenderTextureFormatNativeDelegate SupportsRandomWriteOnRenderTextureFormatNativeDelegateField;

		// Token: 0x040017FE RID: 6142
		private static readonly SystemInfo.SupportsVertexAttributeFormatNativeDelegate SupportsVertexAttributeFormatNativeDelegateField;

		// Token: 0x040017FF RID: 6143
		private static readonly SystemInfo.GetNPOTSupportDelegate GetNPOTSupportDelegateField;

		// Token: 0x04001800 RID: 6144
		private static readonly SystemInfo.GetMaxTexture3DSizeDelegate GetMaxTexture3DSizeDelegateField;

		// Token: 0x04001801 RID: 6145
		private static readonly SystemInfo.GetMaxTextureArraySlicesDelegate GetMaxTextureArraySlicesDelegateField;

		// Token: 0x04001802 RID: 6146
		private static readonly SystemInfo.GetMaxCubemapSizeDelegate GetMaxCubemapSizeDelegateField;

		// Token: 0x04001803 RID: 6147
		private static readonly SystemInfo.GetMaxAnisotropyLevelDelegate GetMaxAnisotropyLevelDelegateField;

		// Token: 0x04001804 RID: 6148
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeDelegate GetMaxComputeWorkGroupSizeDelegateField;

		// Token: 0x04001805 RID: 6149
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeXDelegate GetMaxComputeWorkGroupSizeXDelegateField;

		// Token: 0x04001806 RID: 6150
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeYDelegate GetMaxComputeWorkGroupSizeYDelegateField;

		// Token: 0x04001807 RID: 6151
		private static readonly SystemInfo.GetMaxComputeWorkGroupSizeZDelegate GetMaxComputeWorkGroupSizeZDelegateField;

		// Token: 0x04001808 RID: 6152
		private static readonly SystemInfo.GetComputeSubGroupSizeDelegate GetComputeSubGroupSizeDelegateField;

		// Token: 0x04001809 RID: 6153
		private static readonly SystemInfo.SupportsAsyncComputeDelegate SupportsAsyncComputeDelegateField;

		// Token: 0x0400180A RID: 6154
		private static readonly SystemInfo.SupportsGpuRecorderDelegate SupportsGpuRecorderDelegateField;

		// Token: 0x0400180B RID: 6155
		private static readonly SystemInfo.SupportsAsyncGPUReadbackDelegate SupportsAsyncGPUReadbackDelegateField;

		// Token: 0x0400180C RID: 6156
		private static readonly SystemInfo.SupportsRayTracingDelegate SupportsRayTracingDelegateField;

		// Token: 0x0400180D RID: 6157
		private static readonly SystemInfo.SupportsSetConstantBufferDelegate SupportsSetConstantBufferDelegateField;

		// Token: 0x0400180E RID: 6158
		private static readonly SystemInfo.MinConstantBufferOffsetAlignmentDelegate MinConstantBufferOffsetAlignmentDelegateField;

		// Token: 0x0400180F RID: 6159
		private static readonly SystemInfo.MaxConstantBufferSizeDelegate MaxConstantBufferSizeDelegateField;

		// Token: 0x04001810 RID: 6160
		private static readonly SystemInfo.HasMipMaxLevelDelegate HasMipMaxLevelDelegateField;

		// Token: 0x04001811 RID: 6161
		private static readonly SystemInfo.SupportsMipStreamingDelegate SupportsMipStreamingDelegateField;

		// Token: 0x04001812 RID: 6162
		private static readonly SystemInfo.SupportsConservativeRasterDelegate SupportsConservativeRasterDelegateField;

		// Token: 0x04001813 RID: 6163
		private static readonly SystemInfo.SupportsIndirectArgumentsBufferDelegate SupportsIndirectArgumentsBufferDelegateField;

		// Token: 0x020007A9 RID: 1961
		// (Invoke) Token: 0x060037FF RID: 14335
		private delegate float GetBatteryLevelDelegate();

		// Token: 0x020007AA RID: 1962
		// (Invoke) Token: 0x06003801 RID: 14337
		private delegate BatteryStatus GetBatteryStatusDelegate();

		// Token: 0x020007AB RID: 1963
		// (Invoke) Token: 0x06003803 RID: 14339
		private delegate bool SupportsAccelerometerDelegate();

		// Token: 0x020007AC RID: 1964
		// (Invoke) Token: 0x06003805 RID: 14341
		private delegate bool IsGyroAvailableDelegate();

		// Token: 0x020007AD RID: 1965
		// (Invoke) Token: 0x06003807 RID: 14343
		private delegate bool SupportsLocationServiceDelegate();

		// Token: 0x020007AE RID: 1966
		// (Invoke) Token: 0x06003809 RID: 14345
		private delegate bool SupportsVibrationDelegate();

		// Token: 0x020007AF RID: 1967
		// (Invoke) Token: 0x0600380B RID: 14347
		private delegate bool SupportsAudioDelegate();

		// Token: 0x020007B0 RID: 1968
		// (Invoke) Token: 0x0600380D RID: 14349
		private delegate int GetGraphicsDeviceVendorIDDelegate();

		// Token: 0x020007B1 RID: 1969
		// (Invoke) Token: 0x0600380F RID: 14351
		private delegate UnityEngine.Rendering.RenderingThreadingMode GetRenderingThreadingModeDelegate();

		// Token: 0x020007B2 RID: 1970
		// (Invoke) Token: 0x06003811 RID: 14353
		private delegate bool HasDynamicUniformArrayIndexingInFragmentShadersDelegate();

		// Token: 0x020007B3 RID: 1971
		// (Invoke) Token: 0x06003813 RID: 14355
		private delegate bool SupportsRawShadowDepthSamplingDelegate();

		// Token: 0x020007B4 RID: 1972
		// (Invoke) Token: 0x06003815 RID: 14357
		private delegate bool SupportsMotionVectorsDelegate();

		// Token: 0x020007B5 RID: 1973
		// (Invoke) Token: 0x06003817 RID: 14359
		private delegate bool Supports3DTexturesDelegate();

		// Token: 0x020007B6 RID: 1974
		// (Invoke) Token: 0x06003819 RID: 14361
		private delegate bool SupportsCompressed3DTexturesDelegate();

		// Token: 0x020007B7 RID: 1975
		// (Invoke) Token: 0x0600381B RID: 14363
		private delegate bool Supports2DArrayTexturesDelegate();

		// Token: 0x020007B8 RID: 1976
		// (Invoke) Token: 0x0600381D RID: 14365
		private delegate bool Supports3DRenderTexturesDelegate();

		// Token: 0x020007B9 RID: 1977
		// (Invoke) Token: 0x0600381F RID: 14367
		private delegate bool SupportsCubemapArrayTexturesDelegate();

		// Token: 0x020007BA RID: 1978
		// (Invoke) Token: 0x06003821 RID: 14369
		private delegate bool SupportsAnisotropicFilterDelegate();

		// Token: 0x020007BB RID: 1979
		// (Invoke) Token: 0x06003823 RID: 14371
		private delegate bool SupportsGeometryShadersDelegate();

		// Token: 0x020007BC RID: 1980
		// (Invoke) Token: 0x06003825 RID: 14373
		private delegate bool SupportsTessellationShadersDelegate();

		// Token: 0x020007BD RID: 1981
		// (Invoke) Token: 0x06003827 RID: 14375
		private delegate bool SupportsHardwareQuadTopologyDelegate();

		// Token: 0x020007BE RID: 1982
		// (Invoke) Token: 0x06003829 RID: 14377
		private delegate bool Supports32bitsIndexBufferDelegate();

		// Token: 0x020007BF RID: 1983
		// (Invoke) Token: 0x0600382B RID: 14379
		private delegate bool SupportsSparseTexturesDelegate();

		// Token: 0x020007C0 RID: 1984
		// (Invoke) Token: 0x0600382D RID: 14381
		private delegate bool SupportsSeparatedRenderTargetsBlendDelegate();

		// Token: 0x020007C1 RID: 1985
		// (Invoke) Token: 0x0600382F RID: 14383
		private delegate int SupportedRandomWriteTargetCountDelegate();

		// Token: 0x020007C2 RID: 1986
		// (Invoke) Token: 0x06003831 RID: 14385
		private delegate int MaxComputeBufferInputsVertexDelegate();

		// Token: 0x020007C3 RID: 1987
		// (Invoke) Token: 0x06003833 RID: 14387
		private delegate int MaxComputeBufferInputsFragmentDelegate();

		// Token: 0x020007C4 RID: 1988
		// (Invoke) Token: 0x06003835 RID: 14389
		private delegate int MaxComputeBufferInputsGeometryDelegate();

		// Token: 0x020007C5 RID: 1989
		// (Invoke) Token: 0x06003837 RID: 14391
		private delegate int MaxComputeBufferInputsDomainDelegate();

		// Token: 0x020007C6 RID: 1990
		// (Invoke) Token: 0x06003839 RID: 14393
		private delegate int MaxComputeBufferInputsHullDelegate();

		// Token: 0x020007C7 RID: 1991
		// (Invoke) Token: 0x0600383B RID: 14395
		private delegate int MaxComputeBufferInputsComputeDelegate();

		// Token: 0x020007C8 RID: 1992
		// (Invoke) Token: 0x0600383D RID: 14397
		private delegate bool SupportsMultisampled2DArrayTexturesDelegate();

		// Token: 0x020007C9 RID: 1993
		// (Invoke) Token: 0x0600383F RID: 14399
		private delegate int SupportsTextureWrapMirrorOnceDelegate();

		// Token: 0x020007CA RID: 1994
		// (Invoke) Token: 0x06003841 RID: 14401
		private delegate bool SupportsBlendingOnRenderTextureFormatNativeDelegate(RenderTextureFormat format);

		// Token: 0x020007CB RID: 1995
		// (Invoke) Token: 0x06003843 RID: 14403
		private delegate bool SupportsRandomWriteOnRenderTextureFormatNativeDelegate(RenderTextureFormat format);

		// Token: 0x020007CC RID: 1996
		// (Invoke) Token: 0x06003845 RID: 14405
		private delegate bool SupportsVertexAttributeFormatNativeDelegate(UnityEngine.Rendering.VertexAttributeFormat format, int dimension);

		// Token: 0x020007CD RID: 1997
		// (Invoke) Token: 0x06003847 RID: 14407
		private delegate NPOTSupport GetNPOTSupportDelegate();

		// Token: 0x020007CE RID: 1998
		// (Invoke) Token: 0x06003849 RID: 14409
		private delegate int GetMaxTexture3DSizeDelegate();

		// Token: 0x020007CF RID: 1999
		// (Invoke) Token: 0x0600384B RID: 14411
		private delegate int GetMaxTextureArraySlicesDelegate();

		// Token: 0x020007D0 RID: 2000
		// (Invoke) Token: 0x0600384D RID: 14413
		private delegate int GetMaxCubemapSizeDelegate();

		// Token: 0x020007D1 RID: 2001
		// (Invoke) Token: 0x0600384F RID: 14415
		private delegate int GetMaxAnisotropyLevelDelegate();

		// Token: 0x020007D2 RID: 2002
		// (Invoke) Token: 0x06003851 RID: 14417
		private delegate int GetMaxComputeWorkGroupSizeDelegate();

		// Token: 0x020007D3 RID: 2003
		// (Invoke) Token: 0x06003853 RID: 14419
		private delegate int GetMaxComputeWorkGroupSizeXDelegate();

		// Token: 0x020007D4 RID: 2004
		// (Invoke) Token: 0x06003855 RID: 14421
		private delegate int GetMaxComputeWorkGroupSizeYDelegate();

		// Token: 0x020007D5 RID: 2005
		// (Invoke) Token: 0x06003857 RID: 14423
		private delegate int GetMaxComputeWorkGroupSizeZDelegate();

		// Token: 0x020007D6 RID: 2006
		// (Invoke) Token: 0x06003859 RID: 14425
		private delegate int GetComputeSubGroupSizeDelegate();

		// Token: 0x020007D7 RID: 2007
		// (Invoke) Token: 0x0600385B RID: 14427
		private delegate bool SupportsAsyncComputeDelegate();

		// Token: 0x020007D8 RID: 2008
		// (Invoke) Token: 0x0600385D RID: 14429
		private delegate bool SupportsGpuRecorderDelegate();

		// Token: 0x020007D9 RID: 2009
		// (Invoke) Token: 0x0600385F RID: 14431
		private delegate bool SupportsAsyncGPUReadbackDelegate();

		// Token: 0x020007DA RID: 2010
		// (Invoke) Token: 0x06003861 RID: 14433
		private delegate bool SupportsRayTracingDelegate();

		// Token: 0x020007DB RID: 2011
		// (Invoke) Token: 0x06003863 RID: 14435
		private delegate bool SupportsSetConstantBufferDelegate();

		// Token: 0x020007DC RID: 2012
		// (Invoke) Token: 0x06003865 RID: 14437
		private delegate int MinConstantBufferOffsetAlignmentDelegate();

		// Token: 0x020007DD RID: 2013
		// (Invoke) Token: 0x06003867 RID: 14439
		private delegate int MaxConstantBufferSizeDelegate();

		// Token: 0x020007DE RID: 2014
		// (Invoke) Token: 0x06003869 RID: 14441
		private delegate bool HasMipMaxLevelDelegate();

		// Token: 0x020007DF RID: 2015
		// (Invoke) Token: 0x0600386B RID: 14443
		private delegate bool SupportsMipStreamingDelegate();

		// Token: 0x020007E0 RID: 2016
		// (Invoke) Token: 0x0600386D RID: 14445
		private delegate bool SupportsConservativeRasterDelegate();

		// Token: 0x020007E1 RID: 2017
		// (Invoke) Token: 0x0600386F RID: 14447
		private delegate bool SupportsIndirectArgumentsBufferDelegate();
	}
}
