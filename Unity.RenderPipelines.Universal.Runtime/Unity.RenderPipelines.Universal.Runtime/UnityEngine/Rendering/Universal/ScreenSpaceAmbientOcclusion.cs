using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000C8 RID: 200
	public class ScreenSpaceAmbientOcclusion : ScriptableRendererFeature
	{
		// Token: 0x06000F98 RID: 3992 RVA: 0x0004ACE4 File Offset: 0x00048EE4
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenSpaceAmbientOcclusion()
		{
			Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ScreenSpaceAmbientOcclusion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr);
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "m_Settings");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_BlueNoise256Textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "m_BlueNoise256Textures");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "m_Shader");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "m_Material");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_SSAOPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "m_SSAOPass");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_AOInterleavedGradientKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "k_AOInterleavedGradientKeyword");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_AOBlueNoiseKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "k_AOBlueNoiseKeyword");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_OrthographicCameraKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "k_OrthographicCameraKeyword");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SourceDepthLowKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "k_SourceDepthLowKeyword");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SourceDepthMediumKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "k_SourceDepthMediumKeyword");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SourceDepthHighKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "k_SourceDepthHighKeyword");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SourceDepthNormalsKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "k_SourceDepthNormalsKeyword");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SampleCountLowKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "k_SampleCountLowKeyword");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SampleCountMediumKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "k_SampleCountMediumKeyword");
			ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SampleCountHighKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "k_SampleCountHighKeyword");
			ScreenSpaceAmbientOcclusion.NativeMethodInfoPtr_get_settings_Internal_get_byref_ScreenSpaceAmbientOcclusionSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, 100665242);
			ScreenSpaceAmbientOcclusion.NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, 100665243);
			ScreenSpaceAmbientOcclusion.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, 100665244);
			ScreenSpaceAmbientOcclusion.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, 100665245);
			ScreenSpaceAmbientOcclusion.NativeMethodInfoPtr_GetMaterials_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, 100665246);
			ScreenSpaceAmbientOcclusion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, 100665247);
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x0004AEB8 File Offset: 0x000490B8
		public unsafe ref ScreenSpaceAmbientOcclusionSettings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceAmbientOcclusion.NativeMethodInfoPtr_get_settings_Internal_get_byref_ScreenSpaceAmbientOcclusionSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0004AEEC File Offset: 0x000490EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615606, XrefRangeEnd = 615613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceAmbientOcclusion.NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x0004AF28 File Offset: 0x00049128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615613, XrefRangeEnd = 615637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceAmbientOcclusion.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0004AF88 File Offset: 0x00049188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615637, XrefRangeEnd = 615648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceAmbientOcclusion.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0004AFD4 File Offset: 0x000491D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615648, XrefRangeEnd = 615663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceAmbientOcclusion.NativeMethodInfoPtr_GetMaterials_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0004B010 File Offset: 0x00049210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615663, XrefRangeEnd = 615669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenSpaceAmbientOcclusion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceAmbientOcclusion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x000099E7 File Offset: 0x00007BE7
		public ScreenSpaceAmbientOcclusion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x0004B04C File Offset: 0x0004924C
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x000099F0 File Offset: 0x00007BF0
		public unsafe ScreenSpaceAmbientOcclusionSettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenSpaceAmbientOcclusionSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x0004B07C File Offset: 0x0004927C
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x00009A0F File Offset: 0x00007C0F
		public unsafe Il2CppReferenceArray<Texture2D> m_BlueNoise256Textures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_BlueNoise256Textures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_BlueNoise256Textures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x0004B0AC File Offset: 0x000492AC
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00009A2E File Offset: 0x00007C2E
		public unsafe Shader m_Shader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_Shader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_Shader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x0004B0DC File Offset: 0x000492DC
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00009A4D File Offset: 0x00007C4D
		public unsafe Material m_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x0004B10C File Offset: 0x0004930C
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x00009A6C File Offset: 0x00007C6C
		public unsafe ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass m_SSAOPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_SSAOPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_m_SSAOPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0004B13C File Offset: 0x0004933C
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x00009A8B File Offset: 0x00007C8B
		public unsafe static string k_AOInterleavedGradientKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_AOInterleavedGradientKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_AOInterleavedGradientKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0004B15C File Offset: 0x0004935C
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x00009A9D File Offset: 0x00007C9D
		public unsafe static string k_AOBlueNoiseKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_AOBlueNoiseKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_AOBlueNoiseKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0004B17C File Offset: 0x0004937C
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x00009AAF File Offset: 0x00007CAF
		public unsafe static string k_OrthographicCameraKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_OrthographicCameraKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_OrthographicCameraKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0004B19C File Offset: 0x0004939C
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x00009AC1 File Offset: 0x00007CC1
		public unsafe static string k_SourceDepthLowKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SourceDepthLowKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SourceDepthLowKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x0004B1BC File Offset: 0x000493BC
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x00009AD3 File Offset: 0x00007CD3
		public unsafe static string k_SourceDepthMediumKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SourceDepthMediumKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SourceDepthMediumKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0004B1DC File Offset: 0x000493DC
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x00009AE5 File Offset: 0x00007CE5
		public unsafe static string k_SourceDepthHighKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SourceDepthHighKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SourceDepthHighKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0004B1FC File Offset: 0x000493FC
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x00009AF7 File Offset: 0x00007CF7
		public unsafe static string k_SourceDepthNormalsKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SourceDepthNormalsKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SourceDepthNormalsKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x0004B21C File Offset: 0x0004941C
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00009B09 File Offset: 0x00007D09
		public unsafe static string k_SampleCountLowKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SampleCountLowKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SampleCountLowKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x0004B23C File Offset: 0x0004943C
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x00009B1B File Offset: 0x00007D1B
		public unsafe static string k_SampleCountMediumKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SampleCountMediumKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SampleCountMediumKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x0004B25C File Offset: 0x0004945C
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x00009B2D File Offset: 0x00007D2D
		public unsafe static string k_SampleCountHighKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SampleCountHighKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.NativeFieldInfoPtr_k_SampleCountHighKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeFieldInfoPtr_m_BlueNoise256Textures;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeFieldInfoPtr_m_Shader;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeFieldInfoPtr_m_SSAOPass;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeFieldInfoPtr_k_AOInterleavedGradientKeyword;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeFieldInfoPtr_k_AOBlueNoiseKeyword;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeFieldInfoPtr_k_OrthographicCameraKeyword;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeFieldInfoPtr_k_SourceDepthLowKeyword;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeFieldInfoPtr_k_SourceDepthMediumKeyword;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeFieldInfoPtr_k_SourceDepthHighKeyword;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeFieldInfoPtr_k_SourceDepthNormalsKeyword;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeFieldInfoPtr_k_SampleCountLowKeyword;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeFieldInfoPtr_k_SampleCountMediumKeyword;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeFieldInfoPtr_k_SampleCountHighKeyword;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Internal_get_byref_ScreenSpaceAmbientOcclusionSettings_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterials_Private_Boolean_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001B7 RID: 439
		public class ScreenSpaceAmbientOcclusionPass : ScriptableRenderPass
		{
			// Token: 0x06001F86 RID: 8070 RVA: 0x0007C3B4 File Offset: 0x0007A5B4
			// Note: this type is marked as 'beforefieldinit'.
			static ScreenSpaceAmbientOcclusionPass()
			{
				Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion>.NativeClassPtr, "ScreenSpaceAmbientOcclusionPass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr);
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_profilerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "profilerTag");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_SupportsR8RenderTextureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_SupportsR8RenderTextureFormat");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlueNoiseTextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BlueNoiseTextureIndex");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlurRandomOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BlurRandomOffsetX");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlurRandomOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BlurRandomOffsetY");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_Material");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlueNoiseTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BlueNoiseTextures");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraTopLeftCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraTopLeftCorner");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraXExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraXExtent");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraYExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraYExtent");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraZExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraZExtent");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_SSAOTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_SSAOTextures");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlurType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BlurType");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraViewProjections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraViewProjections");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_ProfilingSampler");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_Renderer");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_AOPassDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_AOPassDescriptor");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CurrentSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CurrentSettings");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_k_FinalTexID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "k_FinalTexID");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_k_SSAOTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "k_SSAOTextureName");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_k_AmbientOcclusionParamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "k_AmbientOcclusionParamName");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_AmbientOcclusionParamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_AmbientOcclusionParamID");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_SSAOParamsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_SSAOParamsID");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_SSAOBlueNoiseParamsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_SSAOBlueNoiseParamsID");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_LastKawasePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_LastKawasePass");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_BlueNoiseTextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_BlueNoiseTextureID");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewXExtentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewXExtentID");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewYExtentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewYExtentID");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewZExtentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewZExtentID");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_ProjectionParams2ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_ProjectionParams2ID");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_KawaseBlurIterationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_KawaseBlurIterationID");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewProjectionsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewProjectionsID");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewTopLeftCornerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewTopLeftCornerID");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BilateralTexturesIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BilateralTexturesIndices");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BilateralPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BilateralPasses");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BilateralAfterOpaquePasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BilateralAfterOpaquePasses");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_GaussianTexturesIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_GaussianTexturesIndices");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_GaussianPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_GaussianPasses");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_GaussianAfterOpaquePasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_GaussianAfterOpaquePasses");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_KawaseTexturesIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_KawaseTexturesIndices");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_KawasePasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_KawasePasses");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_KawaseAfterOpaquePasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_KawaseAfterOpaquePasses");
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_get_isRendererDeferred_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665248);
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665249);
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_Setup_Internal_Boolean_byref_ScreenSpaceAmbientOcclusionSettings_byref_ScriptableRenderer_byref_Material_byref_Il2CppReferenceArray_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665250);
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665251);
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665252);
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_RenderAndSetBaseMap_Private_Static_Void_byref_CommandBuffer_byref_RenderingData_byref_ScriptableRenderer_byref_Material_byref_RTHandle_byref_RTHandle_ShaderPasses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665253);
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_GetPassOrder_Private_Static_Void_BlurTypes_Boolean_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_ShaderPasses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665254);
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_IsAfterOpaquePass_Private_Static_Boolean_byref_ShaderPasses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665255);
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665256);
				ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665257);
			}

			// Token: 0x17000B7F RID: 2943
			// (get) Token: 0x06001F87 RID: 8071 RVA: 0x0007C7F0 File Offset: 0x0007A9F0
			public unsafe bool isRendererDeferred
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615273, XrefRangeEnd = 615275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_get_isRendererDeferred_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F88 RID: 8072 RVA: 0x0007C82C File Offset: 0x0007AA2C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 615310, RefRangeEnd = 615311, XrefRangeStart = 615275, XrefRangeEnd = 615310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScreenSpaceAmbientOcclusionPass()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F89 RID: 8073 RVA: 0x0007C868 File Offset: 0x0007AA68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 615325, RefRangeEnd = 615326, XrefRangeStart = 615311, XrefRangeEnd = 615325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Setup(ref ScreenSpaceAmbientOcclusionSettings featureSettings, ref ScriptableRenderer renderer, ref Material material, ref Il2CppReferenceArray<Texture2D> blueNoiseTextures)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(featureSettings);
					ptr2 = &intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				ptr3 = &intPtr2;
				ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(material);
				ptr4 = &intPtr3;
				ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(blueNoiseTextures);
				ptr5 = &intPtr4;
				IntPtr intPtr6;
				IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_Setup_Internal_Boolean_byref_ScreenSpaceAmbientOcclusionSettings_byref_ScriptableRenderer_byref_Material_byref_Il2CppReferenceArray_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
				Il2CppException.RaiseExceptionIfNecessary(intPtr6);
				IntPtr intPtr7 = intPtr;
				featureSettings = ((intPtr7 == 0) ? null : new ScreenSpaceAmbientOcclusionSettings(intPtr7));
				IntPtr intPtr8 = intPtr2;
				renderer = ((intPtr8 == 0) ? null : new ScriptableRenderer(intPtr8));
				IntPtr intPtr9 = intPtr3;
				material = ((intPtr9 == 0) ? null : new Material(intPtr9));
				IntPtr intPtr10 = intPtr4;
				blueNoiseTextures = ((intPtr10 == 0) ? null : new Il2CppReferenceArray<Texture2D>(intPtr10));
				return *IL2CPP.il2cpp_object_unbox(intPtr5);
			}

			// Token: 0x06001F8A RID: 8074 RVA: 0x0007C94C File Offset: 0x0007AB4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615326, XrefRangeEnd = 615476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F8B RID: 8075 RVA: 0x0007C9AC File Offset: 0x0007ABAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615476, XrefRangeEnd = 615542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F8C RID: 8076 RVA: 0x0007CA08 File Offset: 0x0007AC08
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 615554, RefRangeEnd = 615556, XrefRangeStart = 615542, XrefRangeEnd = 615554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void RenderAndSetBaseMap(ref CommandBuffer cmd, ref RenderingData renderingData, ref ScriptableRenderer renderer, ref Material mat, ref RTHandle baseMap, ref RTHandle target, ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass)
			{
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				ptr3 = &intPtr2;
				ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(mat);
				ptr4 = &intPtr3;
				ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(baseMap);
				ptr5 = &intPtr4;
				ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr5 = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr6 = &intPtr5;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
				IntPtr intPtr7;
				IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_RenderAndSetBaseMap_Private_Static_Void_byref_CommandBuffer_byref_RenderingData_byref_ScriptableRenderer_byref_Material_byref_RTHandle_byref_RTHandle_ShaderPasses_0, 0, (void**)ptr, ref intPtr7);
				Il2CppException.RaiseExceptionIfNecessary(intPtr7);
				IntPtr intPtr8 = intPtr;
				cmd = ((intPtr8 == 0) ? null : new CommandBuffer(intPtr8));
				IntPtr intPtr9 = intPtr2;
				renderer = ((intPtr9 == 0) ? null : new ScriptableRenderer(intPtr9));
				IntPtr intPtr10 = intPtr3;
				mat = ((intPtr10 == 0) ? null : new Material(intPtr10));
				IntPtr intPtr11 = intPtr4;
				baseMap = ((intPtr11 == 0) ? null : new RTHandle(intPtr11));
				IntPtr intPtr12 = intPtr5;
				target = ((intPtr12 == 0) ? null : new RTHandle(intPtr12));
			}

			// Token: 0x06001F8D RID: 8077 RVA: 0x0007CB1C File Offset: 0x0007AD1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 615595, RefRangeEnd = 615596, XrefRangeStart = 615556, XrefRangeEnd = 615595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GetPassOrder(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.BlurTypes blurType, bool isAfterOpaque, out Il2CppStructArray<int> textureIndices, out Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses> shaderPasses)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref blurType;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAfterOpaque;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_GetPassOrder_Private_Static_Void_BlurTypes_Boolean_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_ShaderPasses_0, 0, (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr;
				textureIndices = ((intPtr5 == 0) ? null : new Il2CppStructArray<int>(intPtr5));
				IntPtr intPtr6 = intPtr2;
				shaderPasses = ((intPtr6 == 0) ? null : new Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses>(intPtr6));
			}

			// Token: 0x06001F8E RID: 8078 RVA: 0x0007CBA0 File Offset: 0x0007ADA0
			[CallerCount(0)]
			public unsafe static bool IsAfterOpaquePass(ref ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &pass;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_IsAfterOpaquePass_Private_Static_Boolean_byref_ShaderPasses_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F8F RID: 8079 RVA: 0x0007CBE0 File Offset: 0x0007ADE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615596, XrefRangeEnd = 615602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnCameraCleanup(CommandBuffer cmd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F90 RID: 8080 RVA: 0x0007CC30 File Offset: 0x0007AE30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615602, XrefRangeEnd = 615606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F91 RID: 8081 RVA: 0x000120FE File Offset: 0x000102FE
			public ScreenSpaceAmbientOcclusionPass(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B55 RID: 2901
			// (get) Token: 0x06001F92 RID: 8082 RVA: 0x0007CC64 File Offset: 0x0007AE64
			// (set) Token: 0x06001F93 RID: 8083 RVA: 0x00012107 File Offset: 0x00010307
			public unsafe string profilerTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_profilerTag);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_profilerTag), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000B56 RID: 2902
			// (get) Token: 0x06001F94 RID: 8084 RVA: 0x0007CC8C File Offset: 0x0007AE8C
			// (set) Token: 0x06001F95 RID: 8085 RVA: 0x00012126 File Offset: 0x00010326
			public unsafe bool m_SupportsR8RenderTextureFormat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_SupportsR8RenderTextureFormat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_SupportsR8RenderTextureFormat)) = value;
				}
			}

			// Token: 0x17000B57 RID: 2903
			// (get) Token: 0x06001F96 RID: 8086 RVA: 0x0007CCB4 File Offset: 0x0007AEB4
			// (set) Token: 0x06001F97 RID: 8087 RVA: 0x00012141 File Offset: 0x00010341
			public unsafe int m_BlueNoiseTextureIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlueNoiseTextureIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlueNoiseTextureIndex)) = value;
				}
			}

			// Token: 0x17000B58 RID: 2904
			// (get) Token: 0x06001F98 RID: 8088 RVA: 0x0007CCDC File Offset: 0x0007AEDC
			// (set) Token: 0x06001F99 RID: 8089 RVA: 0x0001215C File Offset: 0x0001035C
			public unsafe float m_BlurRandomOffsetX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlurRandomOffsetX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlurRandomOffsetX)) = value;
				}
			}

			// Token: 0x17000B59 RID: 2905
			// (get) Token: 0x06001F9A RID: 8090 RVA: 0x0007CD04 File Offset: 0x0007AF04
			// (set) Token: 0x06001F9B RID: 8091 RVA: 0x00012177 File Offset: 0x00010377
			public unsafe float m_BlurRandomOffsetY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlurRandomOffsetY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlurRandomOffsetY)) = value;
				}
			}

			// Token: 0x17000B5A RID: 2906
			// (get) Token: 0x06001F9C RID: 8092 RVA: 0x0007CD2C File Offset: 0x0007AF2C
			// (set) Token: 0x06001F9D RID: 8093 RVA: 0x00012192 File Offset: 0x00010392
			public unsafe Material m_Material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_Material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B5B RID: 2907
			// (get) Token: 0x06001F9E RID: 8094 RVA: 0x0007CD5C File Offset: 0x0007AF5C
			// (set) Token: 0x06001F9F RID: 8095 RVA: 0x000121B1 File Offset: 0x000103B1
			public unsafe Il2CppReferenceArray<Texture2D> m_BlueNoiseTextures
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlueNoiseTextures);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlueNoiseTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B5C RID: 2908
			// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x0007CD8C File Offset: 0x0007AF8C
			// (set) Token: 0x06001FA1 RID: 8097 RVA: 0x000121D0 File Offset: 0x000103D0
			public unsafe Il2CppStructArray<Vector4> m_CameraTopLeftCorner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraTopLeftCorner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraTopLeftCorner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B5D RID: 2909
			// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x0007CDBC File Offset: 0x0007AFBC
			// (set) Token: 0x06001FA3 RID: 8099 RVA: 0x000121EF File Offset: 0x000103EF
			public unsafe Il2CppStructArray<Vector4> m_CameraXExtent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraXExtent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraXExtent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B5E RID: 2910
			// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x0007CDEC File Offset: 0x0007AFEC
			// (set) Token: 0x06001FA5 RID: 8101 RVA: 0x0001220E File Offset: 0x0001040E
			public unsafe Il2CppStructArray<Vector4> m_CameraYExtent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraYExtent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraYExtent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B5F RID: 2911
			// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x0007CE1C File Offset: 0x0007B01C
			// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x0001222D File Offset: 0x0001042D
			public unsafe Il2CppStructArray<Vector4> m_CameraZExtent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraZExtent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraZExtent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B60 RID: 2912
			// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x0007CE4C File Offset: 0x0007B04C
			// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x0001224C File Offset: 0x0001044C
			public unsafe Il2CppReferenceArray<RTHandle> m_SSAOTextures
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_SSAOTextures);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_SSAOTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B61 RID: 2913
			// (get) Token: 0x06001FAA RID: 8106 RVA: 0x0007CE7C File Offset: 0x0007B07C
			// (set) Token: 0x06001FAB RID: 8107 RVA: 0x0001226B File Offset: 0x0001046B
			public unsafe ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.BlurTypes m_BlurType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlurType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BlurType)) = value;
				}
			}

			// Token: 0x17000B62 RID: 2914
			// (get) Token: 0x06001FAC RID: 8108 RVA: 0x0007CEA4 File Offset: 0x0007B0A4
			// (set) Token: 0x06001FAD RID: 8109 RVA: 0x00012286 File Offset: 0x00010486
			public unsafe Il2CppStructArray<Matrix4x4> m_CameraViewProjections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraViewProjections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CameraViewProjections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B63 RID: 2915
			// (get) Token: 0x06001FAE RID: 8110 RVA: 0x0007CED4 File Offset: 0x0007B0D4
			// (set) Token: 0x06001FAF RID: 8111 RVA: 0x000122A5 File Offset: 0x000104A5
			public unsafe ProfilingSampler m_ProfilingSampler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_ProfilingSampler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_ProfilingSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B64 RID: 2916
			// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x0007CF04 File Offset: 0x0007B104
			// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x000122C4 File Offset: 0x000104C4
			public unsafe ScriptableRenderer m_Renderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_Renderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B65 RID: 2917
			// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x0007CF34 File Offset: 0x0007B134
			// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x000122E3 File Offset: 0x000104E3
			public unsafe RenderTextureDescriptor m_AOPassDescriptor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_AOPassDescriptor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_AOPassDescriptor)) = value;
				}
			}

			// Token: 0x17000B66 RID: 2918
			// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x0007CF5C File Offset: 0x0007B15C
			// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x000122FE File Offset: 0x000104FE
			public unsafe ScreenSpaceAmbientOcclusionSettings m_CurrentSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CurrentSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenSpaceAmbientOcclusionSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_CurrentSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B67 RID: 2919
			// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x0007CF8C File Offset: 0x0007B18C
			// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x0001231D File Offset: 0x0001051D
			public unsafe static int k_FinalTexID
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_k_FinalTexID, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_k_FinalTexID, (void*)(&value));
				}
			}

			// Token: 0x17000B68 RID: 2920
			// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x0007CFA8 File Offset: 0x0007B1A8
			// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x0001232B File Offset: 0x0001052B
			public unsafe static string k_SSAOTextureName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_k_SSAOTextureName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_k_SSAOTextureName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000B69 RID: 2921
			// (get) Token: 0x06001FBA RID: 8122 RVA: 0x0007CFC8 File Offset: 0x0007B1C8
			// (set) Token: 0x06001FBB RID: 8123 RVA: 0x0001233D File Offset: 0x0001053D
			public unsafe static string k_AmbientOcclusionParamName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_k_AmbientOcclusionParamName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_k_AmbientOcclusionParamName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000B6A RID: 2922
			// (get) Token: 0x06001FBC RID: 8124 RVA: 0x0007CFE8 File Offset: 0x0007B1E8
			// (set) Token: 0x06001FBD RID: 8125 RVA: 0x0001234F File Offset: 0x0001054F
			public unsafe static int s_AmbientOcclusionParamID
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_AmbientOcclusionParamID, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_AmbientOcclusionParamID, (void*)(&value));
				}
			}

			// Token: 0x17000B6B RID: 2923
			// (get) Token: 0x06001FBE RID: 8126 RVA: 0x0007D004 File Offset: 0x0007B204
			// (set) Token: 0x06001FBF RID: 8127 RVA: 0x0001235D File Offset: 0x0001055D
			public unsafe static int s_SSAOParamsID
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_SSAOParamsID, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_SSAOParamsID, (void*)(&value));
				}
			}

			// Token: 0x17000B6C RID: 2924
			// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x0007D020 File Offset: 0x0007B220
			// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x0001236B File Offset: 0x0001056B
			public unsafe static int s_SSAOBlueNoiseParamsID
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_SSAOBlueNoiseParamsID, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_SSAOBlueNoiseParamsID, (void*)(&value));
				}
			}

			// Token: 0x17000B6D RID: 2925
			// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x0007D03C File Offset: 0x0007B23C
			// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x00012379 File Offset: 0x00010579
			public unsafe static int s_LastKawasePass
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_LastKawasePass, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_LastKawasePass, (void*)(&value));
				}
			}

			// Token: 0x17000B6E RID: 2926
			// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x0007D058 File Offset: 0x0007B258
			// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x00012387 File Offset: 0x00010587
			public unsafe static int s_BlueNoiseTextureID
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_BlueNoiseTextureID, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_BlueNoiseTextureID, (void*)(&value));
				}
			}

			// Token: 0x17000B6F RID: 2927
			// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x0007D074 File Offset: 0x0007B274
			// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x00012395 File Offset: 0x00010595
			public unsafe static int s_CameraViewXExtentID
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewXExtentID, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewXExtentID, (void*)(&value));
				}
			}

			// Token: 0x17000B70 RID: 2928
			// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x0007D090 File Offset: 0x0007B290
			// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x000123A3 File Offset: 0x000105A3
			public unsafe static int s_CameraViewYExtentID
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewYExtentID, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewYExtentID, (void*)(&value));
				}
			}

			// Token: 0x17000B71 RID: 2929
			// (get) Token: 0x06001FCA RID: 8138 RVA: 0x0007D0AC File Offset: 0x0007B2AC
			// (set) Token: 0x06001FCB RID: 8139 RVA: 0x000123B1 File Offset: 0x000105B1
			public unsafe static int s_CameraViewZExtentID
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewZExtentID, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewZExtentID, (void*)(&value));
				}
			}

			// Token: 0x17000B72 RID: 2930
			// (get) Token: 0x06001FCC RID: 8140 RVA: 0x0007D0C8 File Offset: 0x0007B2C8
			// (set) Token: 0x06001FCD RID: 8141 RVA: 0x000123BF File Offset: 0x000105BF
			public unsafe static int s_ProjectionParams2ID
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_ProjectionParams2ID, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_ProjectionParams2ID, (void*)(&value));
				}
			}

			// Token: 0x17000B73 RID: 2931
			// (get) Token: 0x06001FCE RID: 8142 RVA: 0x0007D0E4 File Offset: 0x0007B2E4
			// (set) Token: 0x06001FCF RID: 8143 RVA: 0x000123CD File Offset: 0x000105CD
			public unsafe static int s_KawaseBlurIterationID
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_KawaseBlurIterationID, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_KawaseBlurIterationID, (void*)(&value));
				}
			}

			// Token: 0x17000B74 RID: 2932
			// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x0007D100 File Offset: 0x0007B300
			// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x000123DB File Offset: 0x000105DB
			public unsafe static int s_CameraViewProjectionsID
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewProjectionsID, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewProjectionsID, (void*)(&value));
				}
			}

			// Token: 0x17000B75 RID: 2933
			// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x0007D11C File Offset: 0x0007B31C
			// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x000123E9 File Offset: 0x000105E9
			public unsafe static int s_CameraViewTopLeftCornerID
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewTopLeftCornerID, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_s_CameraViewTopLeftCornerID, (void*)(&value));
				}
			}

			// Token: 0x17000B76 RID: 2934
			// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x0007D138 File Offset: 0x0007B338
			// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x000123F7 File Offset: 0x000105F7
			public unsafe static Il2CppStructArray<int> m_BilateralTexturesIndices
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BilateralTexturesIndices, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BilateralTexturesIndices, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B77 RID: 2935
			// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x0007D160 File Offset: 0x0007B360
			// (set) Token: 0x06001FD7 RID: 8151 RVA: 0x00012409 File Offset: 0x00010609
			public unsafe static Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses> m_BilateralPasses
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BilateralPasses, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BilateralPasses, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B78 RID: 2936
			// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x0007D188 File Offset: 0x0007B388
			// (set) Token: 0x06001FD9 RID: 8153 RVA: 0x0001241B File Offset: 0x0001061B
			public unsafe static Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses> m_BilateralAfterOpaquePasses
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BilateralAfterOpaquePasses, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_BilateralAfterOpaquePasses, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B79 RID: 2937
			// (get) Token: 0x06001FDA RID: 8154 RVA: 0x0007D1B0 File Offset: 0x0007B3B0
			// (set) Token: 0x06001FDB RID: 8155 RVA: 0x0001242D File Offset: 0x0001062D
			public unsafe static Il2CppStructArray<int> m_GaussianTexturesIndices
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_GaussianTexturesIndices, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_GaussianTexturesIndices, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7A RID: 2938
			// (get) Token: 0x06001FDC RID: 8156 RVA: 0x0007D1D8 File Offset: 0x0007B3D8
			// (set) Token: 0x06001FDD RID: 8157 RVA: 0x0001243F File Offset: 0x0001063F
			public unsafe static Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses> m_GaussianPasses
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_GaussianPasses, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_GaussianPasses, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7B RID: 2939
			// (get) Token: 0x06001FDE RID: 8158 RVA: 0x0007D200 File Offset: 0x0007B400
			// (set) Token: 0x06001FDF RID: 8159 RVA: 0x00012451 File Offset: 0x00010651
			public unsafe static Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses> m_GaussianAfterOpaquePasses
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_GaussianAfterOpaquePasses, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_GaussianAfterOpaquePasses, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7C RID: 2940
			// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x0007D228 File Offset: 0x0007B428
			// (set) Token: 0x06001FE1 RID: 8161 RVA: 0x00012463 File Offset: 0x00010663
			public unsafe static Il2CppStructArray<int> m_KawaseTexturesIndices
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_KawaseTexturesIndices, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_KawaseTexturesIndices, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7D RID: 2941
			// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x0007D250 File Offset: 0x0007B450
			// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x00012475 File Offset: 0x00010675
			public unsafe static Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses> m_KawasePasses
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_KawasePasses, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_KawasePasses, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B7E RID: 2942
			// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x0007D278 File Offset: 0x0007B478
			// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x00012487 File Offset: 0x00010687
			public unsafe static Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses> m_KawaseAfterOpaquePasses
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_KawaseAfterOpaquePasses, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.NativeFieldInfoPtr_m_KawaseAfterOpaquePasses, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001675 RID: 5749
			private static readonly IntPtr NativeFieldInfoPtr_profilerTag;

			// Token: 0x04001676 RID: 5750
			private static readonly IntPtr NativeFieldInfoPtr_m_SupportsR8RenderTextureFormat;

			// Token: 0x04001677 RID: 5751
			private static readonly IntPtr NativeFieldInfoPtr_m_BlueNoiseTextureIndex;

			// Token: 0x04001678 RID: 5752
			private static readonly IntPtr NativeFieldInfoPtr_m_BlurRandomOffsetX;

			// Token: 0x04001679 RID: 5753
			private static readonly IntPtr NativeFieldInfoPtr_m_BlurRandomOffsetY;

			// Token: 0x0400167A RID: 5754
			private static readonly IntPtr NativeFieldInfoPtr_m_Material;

			// Token: 0x0400167B RID: 5755
			private static readonly IntPtr NativeFieldInfoPtr_m_BlueNoiseTextures;

			// Token: 0x0400167C RID: 5756
			private static readonly IntPtr NativeFieldInfoPtr_m_CameraTopLeftCorner;

			// Token: 0x0400167D RID: 5757
			private static readonly IntPtr NativeFieldInfoPtr_m_CameraXExtent;

			// Token: 0x0400167E RID: 5758
			private static readonly IntPtr NativeFieldInfoPtr_m_CameraYExtent;

			// Token: 0x0400167F RID: 5759
			private static readonly IntPtr NativeFieldInfoPtr_m_CameraZExtent;

			// Token: 0x04001680 RID: 5760
			private static readonly IntPtr NativeFieldInfoPtr_m_SSAOTextures;

			// Token: 0x04001681 RID: 5761
			private static readonly IntPtr NativeFieldInfoPtr_m_BlurType;

			// Token: 0x04001682 RID: 5762
			private static readonly IntPtr NativeFieldInfoPtr_m_CameraViewProjections;

			// Token: 0x04001683 RID: 5763
			private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

			// Token: 0x04001684 RID: 5764
			private static readonly IntPtr NativeFieldInfoPtr_m_Renderer;

			// Token: 0x04001685 RID: 5765
			private static readonly IntPtr NativeFieldInfoPtr_m_AOPassDescriptor;

			// Token: 0x04001686 RID: 5766
			private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSettings;

			// Token: 0x04001687 RID: 5767
			private static readonly IntPtr NativeFieldInfoPtr_k_FinalTexID;

			// Token: 0x04001688 RID: 5768
			private static readonly IntPtr NativeFieldInfoPtr_k_SSAOTextureName;

			// Token: 0x04001689 RID: 5769
			private static readonly IntPtr NativeFieldInfoPtr_k_AmbientOcclusionParamName;

			// Token: 0x0400168A RID: 5770
			private static readonly IntPtr NativeFieldInfoPtr_s_AmbientOcclusionParamID;

			// Token: 0x0400168B RID: 5771
			private static readonly IntPtr NativeFieldInfoPtr_s_SSAOParamsID;

			// Token: 0x0400168C RID: 5772
			private static readonly IntPtr NativeFieldInfoPtr_s_SSAOBlueNoiseParamsID;

			// Token: 0x0400168D RID: 5773
			private static readonly IntPtr NativeFieldInfoPtr_s_LastKawasePass;

			// Token: 0x0400168E RID: 5774
			private static readonly IntPtr NativeFieldInfoPtr_s_BlueNoiseTextureID;

			// Token: 0x0400168F RID: 5775
			private static readonly IntPtr NativeFieldInfoPtr_s_CameraViewXExtentID;

			// Token: 0x04001690 RID: 5776
			private static readonly IntPtr NativeFieldInfoPtr_s_CameraViewYExtentID;

			// Token: 0x04001691 RID: 5777
			private static readonly IntPtr NativeFieldInfoPtr_s_CameraViewZExtentID;

			// Token: 0x04001692 RID: 5778
			private static readonly IntPtr NativeFieldInfoPtr_s_ProjectionParams2ID;

			// Token: 0x04001693 RID: 5779
			private static readonly IntPtr NativeFieldInfoPtr_s_KawaseBlurIterationID;

			// Token: 0x04001694 RID: 5780
			private static readonly IntPtr NativeFieldInfoPtr_s_CameraViewProjectionsID;

			// Token: 0x04001695 RID: 5781
			private static readonly IntPtr NativeFieldInfoPtr_s_CameraViewTopLeftCornerID;

			// Token: 0x04001696 RID: 5782
			private static readonly IntPtr NativeFieldInfoPtr_m_BilateralTexturesIndices;

			// Token: 0x04001697 RID: 5783
			private static readonly IntPtr NativeFieldInfoPtr_m_BilateralPasses;

			// Token: 0x04001698 RID: 5784
			private static readonly IntPtr NativeFieldInfoPtr_m_BilateralAfterOpaquePasses;

			// Token: 0x04001699 RID: 5785
			private static readonly IntPtr NativeFieldInfoPtr_m_GaussianTexturesIndices;

			// Token: 0x0400169A RID: 5786
			private static readonly IntPtr NativeFieldInfoPtr_m_GaussianPasses;

			// Token: 0x0400169B RID: 5787
			private static readonly IntPtr NativeFieldInfoPtr_m_GaussianAfterOpaquePasses;

			// Token: 0x0400169C RID: 5788
			private static readonly IntPtr NativeFieldInfoPtr_m_KawaseTexturesIndices;

			// Token: 0x0400169D RID: 5789
			private static readonly IntPtr NativeFieldInfoPtr_m_KawasePasses;

			// Token: 0x0400169E RID: 5790
			private static readonly IntPtr NativeFieldInfoPtr_m_KawaseAfterOpaquePasses;

			// Token: 0x0400169F RID: 5791
			private static readonly IntPtr NativeMethodInfoPtr_get_isRendererDeferred_Private_get_Boolean_0;

			// Token: 0x040016A0 RID: 5792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040016A1 RID: 5793
			private static readonly IntPtr NativeMethodInfoPtr_Setup_Internal_Boolean_byref_ScreenSpaceAmbientOcclusionSettings_byref_ScriptableRenderer_byref_Material_byref_Il2CppReferenceArray_1_Texture2D_0;

			// Token: 0x040016A2 RID: 5794
			private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

			// Token: 0x040016A3 RID: 5795
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

			// Token: 0x040016A4 RID: 5796
			private static readonly IntPtr NativeMethodInfoPtr_RenderAndSetBaseMap_Private_Static_Void_byref_CommandBuffer_byref_RenderingData_byref_ScriptableRenderer_byref_Material_byref_RTHandle_byref_RTHandle_ShaderPasses_0;

			// Token: 0x040016A5 RID: 5797
			private static readonly IntPtr NativeMethodInfoPtr_GetPassOrder_Private_Static_Void_BlurTypes_Boolean_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_ShaderPasses_0;

			// Token: 0x040016A6 RID: 5798
			private static readonly IntPtr NativeMethodInfoPtr_IsAfterOpaquePass_Private_Static_Boolean_byref_ShaderPasses_0;

			// Token: 0x040016A7 RID: 5799
			private static readonly IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0;

			// Token: 0x040016A8 RID: 5800
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

			// Token: 0x0200024C RID: 588
			public enum BlurTypes
			{
				// Token: 0x040019D3 RID: 6611
				Bilateral,
				// Token: 0x040019D4 RID: 6612
				Gaussian,
				// Token: 0x040019D5 RID: 6613
				Kawase
			}

			// Token: 0x0200024D RID: 589
			public enum ShaderPasses
			{
				// Token: 0x040019D7 RID: 6615
				AmbientOcclusion,
				// Token: 0x040019D8 RID: 6616
				BilateralBlurHorizontal,
				// Token: 0x040019D9 RID: 6617
				BilateralBlurVertical,
				// Token: 0x040019DA RID: 6618
				BilateralBlurFinal,
				// Token: 0x040019DB RID: 6619
				BilateralAfterOpaque,
				// Token: 0x040019DC RID: 6620
				GaussianBlurHorizontal,
				// Token: 0x040019DD RID: 6621
				GaussianBlurVertical,
				// Token: 0x040019DE RID: 6622
				GaussianAfterOpaque,
				// Token: 0x040019DF RID: 6623
				KawaseBlur,
				// Token: 0x040019E0 RID: 6624
				KawaseAfterOpaque
			}
		}
	}
}
