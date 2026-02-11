using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200005F RID: 95
	public class UniversalRenderPipelineVolumeDebugSettings : VolumeDebugSettings<UniversalAdditionalCameraData>
	{
		// Token: 0x06000852 RID: 2130 RVA: 0x000322EC File Offset: 0x000304EC
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalRenderPipelineVolumeDebugSettings()
		{
			Il2CppClassPointerStore<UniversalRenderPipelineVolumeDebugSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalRenderPipelineVolumeDebugSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipelineVolumeDebugSettings>.NativeClassPtr);
			UniversalRenderPipelineVolumeDebugSettings.NativeMethodInfoPtr_get_targetRenderPipeline_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineVolumeDebugSettings>.NativeClassPtr, 100664455);
			UniversalRenderPipelineVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraVolumeStack_Public_Virtual_get_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineVolumeDebugSettings>.NativeClassPtr, 100664456);
			UniversalRenderPipelineVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraLayerMask_Public_Virtual_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineVolumeDebugSettings>.NativeClassPtr, 100664457);
			UniversalRenderPipelineVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraPosition_Public_Virtual_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineVolumeDebugSettings>.NativeClassPtr, 100664458);
			UniversalRenderPipelineVolumeDebugSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineVolumeDebugSettings>.NativeClassPtr, 100664459);
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00032380 File Offset: 0x00030580
		public unsafe override Type targetRenderPipeline
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606254, XrefRangeEnd = 606260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalRenderPipelineVolumeDebugSettings.NativeMethodInfoPtr_get_targetRenderPipeline_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x000323CC File Offset: 0x000305CC
		public unsafe override VolumeStack selectedCameraVolumeStack
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606260, XrefRangeEnd = 606275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalRenderPipelineVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraVolumeStack_Public_Virtual_get_VolumeStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeStack>(intPtr3) : null;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00032418 File Offset: 0x00030618
		public unsafe override LayerMask selectedCameraLayerMask
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606275, XrefRangeEnd = 606283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalRenderPipelineVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraLayerMask_Public_Virtual_get_LayerMask_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00032460 File Offset: 0x00030660
		public unsafe override Vector3 selectedCameraPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606283, XrefRangeEnd = 606293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalRenderPipelineVolumeDebugSettings.NativeMethodInfoPtr_get_selectedCameraPosition_Public_Virtual_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000324A8 File Offset: 0x000306A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606293, XrefRangeEnd = 606299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalRenderPipelineVolumeDebugSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderPipelineVolumeDebugSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineVolumeDebugSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0000595D File Offset: 0x00003B5D
		public UniversalRenderPipelineVolumeDebugSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_get_targetRenderPipeline_Public_Virtual_get_Type_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedCameraVolumeStack_Public_Virtual_get_VolumeStack_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedCameraLayerMask_Public_Virtual_get_LayerMask_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedCameraPosition_Public_Virtual_get_Vector3_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
