using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000CA RID: 202
	public class ScreenSpaceShadows : ScriptableRendererFeature
	{
		// Token: 0x06000FC1 RID: 4033 RVA: 0x0004B2B8 File Offset: 0x000494B8
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenSpaceShadows()
		{
			Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ScreenSpaceShadows");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr);
			ScreenSpaceShadows.NativeFieldInfoPtr_m_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr, "m_Shader");
			ScreenSpaceShadows.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr, "m_Settings");
			ScreenSpaceShadows.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr, "m_Material");
			ScreenSpaceShadows.NativeFieldInfoPtr_m_SSShadowsPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr, "m_SSShadowsPass");
			ScreenSpaceShadows.NativeFieldInfoPtr_m_SSShadowsPostPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr, "m_SSShadowsPostPass");
			ScreenSpaceShadows.NativeFieldInfoPtr_k_ShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr, "k_ShaderName");
			ScreenSpaceShadows.NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr, 100665260);
			ScreenSpaceShadows.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr, 100665261);
			ScreenSpaceShadows.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr, 100665262);
			ScreenSpaceShadows.NativeMethodInfoPtr_LoadMaterial_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr, 100665263);
			ScreenSpaceShadows.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr, 100665264);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0004B3C4 File Offset: 0x000495C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615813, XrefRangeEnd = 615835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceShadows.NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0004B400 File Offset: 0x00049600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615835, XrefRangeEnd = 615852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceShadows.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0004B460 File Offset: 0x00049660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615852, XrefRangeEnd = 615858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceShadows.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0004B4AC File Offset: 0x000496AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 615873, RefRangeEnd = 615875, XrefRangeStart = 615858, XrefRangeEnd = 615873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LoadMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceShadows.NativeMethodInfoPtr_LoadMaterial_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0004B4E8 File Offset: 0x000496E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615875, XrefRangeEnd = 615881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenSpaceShadows()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceShadows.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00009B81 File Offset: 0x00007D81
		public ScreenSpaceShadows(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x0004B524 File Offset: 0x00049724
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x00009B8A File Offset: 0x00007D8A
		public unsafe Shader m_Shader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.NativeFieldInfoPtr_m_Shader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.NativeFieldInfoPtr_m_Shader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x0004B554 File Offset: 0x00049754
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x00009BA9 File Offset: 0x00007DA9
		public unsafe ScreenSpaceShadowsSettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenSpaceShadowsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x0004B584 File Offset: 0x00049784
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x00009BC8 File Offset: 0x00007DC8
		public unsafe Material m_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.NativeFieldInfoPtr_m_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x0004B5B4 File Offset: 0x000497B4
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x00009BE7 File Offset: 0x00007DE7
		public unsafe ScreenSpaceShadows.ScreenSpaceShadowsPass m_SSShadowsPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.NativeFieldInfoPtr_m_SSShadowsPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenSpaceShadows.ScreenSpaceShadowsPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.NativeFieldInfoPtr_m_SSShadowsPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0004B5E4 File Offset: 0x000497E4
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x00009C06 File Offset: 0x00007E06
		public unsafe ScreenSpaceShadows.ScreenSpaceShadowsPostPass m_SSShadowsPostPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.NativeFieldInfoPtr_m_SSShadowsPostPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenSpaceShadows.ScreenSpaceShadowsPostPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.NativeFieldInfoPtr_m_SSShadowsPostPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0004B614 File Offset: 0x00049814
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00009C25 File Offset: 0x00007E25
		public unsafe static string k_ShaderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenSpaceShadows.NativeFieldInfoPtr_k_ShaderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenSpaceShadows.NativeFieldInfoPtr_k_ShaderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeFieldInfoPtr_m_Shader;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeFieldInfoPtr_m_SSShadowsPass;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeFieldInfoPtr_m_SSShadowsPostPass;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderName;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_LoadMaterial_Private_Boolean_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001B8 RID: 440
		public class ScreenSpaceShadowsPass : ScriptableRenderPass
		{
			// Token: 0x06001FE6 RID: 8166 RVA: 0x0007D2A0 File Offset: 0x0007B4A0
			// Note: this type is marked as 'beforefieldinit'.
			static ScreenSpaceShadowsPass()
			{
				Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr, "ScreenSpaceShadowsPass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPass>.NativeClassPtr);
				ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_ProfilerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPass>.NativeClassPtr, "m_ProfilerTag");
				ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPass>.NativeClassPtr, "m_ProfilingSampler");
				ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPass>.NativeClassPtr, "m_Material");
				ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_CurrentSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPass>.NativeClassPtr, "m_CurrentSettings");
				ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_RenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPass>.NativeClassPtr, "m_RenderTarget");
				ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPass>.NativeClassPtr, 100665265);
				ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPass>.NativeClassPtr, 100665266);
				ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeMethodInfoPtr_Setup_Internal_Boolean_ScreenSpaceShadowsSettings_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPass>.NativeClassPtr, 100665267);
				ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPass>.NativeClassPtr, 100665268);
				ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPass>.NativeClassPtr, 100665269);
			}

			// Token: 0x06001FE7 RID: 8167 RVA: 0x0007D394 File Offset: 0x0007B594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615669, XrefRangeEnd = 615678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScreenSpaceShadowsPass()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPass>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FE8 RID: 8168 RVA: 0x0007D3D0 File Offset: 0x0007B5D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FE9 RID: 8169 RVA: 0x0007D404 File Offset: 0x0007B604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615678, XrefRangeEnd = 615699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Setup(ScreenSpaceShadowsSettings featureSettings, Material material)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(featureSettings);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeMethodInfoPtr_Setup_Internal_Boolean_ScreenSpaceShadowsSettings_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001FEA RID: 8170 RVA: 0x0007D464 File Offset: 0x0007B664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615699, XrefRangeEnd = 615742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FEB RID: 8171 RVA: 0x0007D4C4 File Offset: 0x0007B6C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615742, XrefRangeEnd = 615783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FEC RID: 8172 RVA: 0x00012499 File Offset: 0x00010699
			public ScreenSpaceShadowsPass(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B80 RID: 2944
			// (get) Token: 0x06001FED RID: 8173 RVA: 0x0007D520 File Offset: 0x0007B720
			// (set) Token: 0x06001FEE RID: 8174 RVA: 0x000124A2 File Offset: 0x000106A2
			public unsafe static string m_ProfilerTag
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_ProfilerTag, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_ProfilerTag, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000B81 RID: 2945
			// (get) Token: 0x06001FEF RID: 8175 RVA: 0x0007D540 File Offset: 0x0007B740
			// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x000124B4 File Offset: 0x000106B4
			public unsafe static ProfilingSampler m_ProfilingSampler
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_ProfilingSampler, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_ProfilingSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B82 RID: 2946
			// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x0007D568 File Offset: 0x0007B768
			// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x000124C6 File Offset: 0x000106C6
			public unsafe Material m_Material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_Material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B83 RID: 2947
			// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x0007D598 File Offset: 0x0007B798
			// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x000124E5 File Offset: 0x000106E5
			public unsafe ScreenSpaceShadowsSettings m_CurrentSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_CurrentSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenSpaceShadowsSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_CurrentSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B84 RID: 2948
			// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x0007D5C8 File Offset: 0x0007B7C8
			// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x00012504 File Offset: 0x00010704
			public unsafe RTHandle m_RenderTarget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_RenderTarget);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceShadows.ScreenSpaceShadowsPass.NativeFieldInfoPtr_m_RenderTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016A9 RID: 5801
			private static readonly IntPtr NativeFieldInfoPtr_m_ProfilerTag;

			// Token: 0x040016AA RID: 5802
			private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

			// Token: 0x040016AB RID: 5803
			private static readonly IntPtr NativeFieldInfoPtr_m_Material;

			// Token: 0x040016AC RID: 5804
			private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSettings;

			// Token: 0x040016AD RID: 5805
			private static readonly IntPtr NativeFieldInfoPtr_m_RenderTarget;

			// Token: 0x040016AE RID: 5806
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040016AF RID: 5807
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

			// Token: 0x040016B0 RID: 5808
			private static readonly IntPtr NativeMethodInfoPtr_Setup_Internal_Boolean_ScreenSpaceShadowsSettings_Material_0;

			// Token: 0x040016B1 RID: 5809
			private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

			// Token: 0x040016B2 RID: 5810
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;
		}

		// Token: 0x020001B9 RID: 441
		public class ScreenSpaceShadowsPostPass : ScriptableRenderPass
		{
			// Token: 0x06001FF7 RID: 8183 RVA: 0x0007D5F8 File Offset: 0x0007B7F8
			// Note: this type is marked as 'beforefieldinit'.
			static ScreenSpaceShadowsPostPass()
			{
				Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPostPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceShadows>.NativeClassPtr, "ScreenSpaceShadowsPostPass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPostPass>.NativeClassPtr);
				ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeFieldInfoPtr_m_ProfilerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPostPass>.NativeClassPtr, "m_ProfilerTag");
				ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPostPass>.NativeClassPtr, "m_ProfilingSampler");
				ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeFieldInfoPtr_k_CurrentActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPostPass>.NativeClassPtr, "k_CurrentActive");
				ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPostPass>.NativeClassPtr, 100665271);
				ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPostPass>.NativeClassPtr, 100665272);
				ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPostPass>.NativeClassPtr, 100665273);
			}

			// Token: 0x06001FF8 RID: 8184 RVA: 0x0007D69C File Offset: 0x0007B89C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615783, XrefRangeEnd = 615788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraTextureDescriptor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FF9 RID: 8185 RVA: 0x0007D6F8 File Offset: 0x0007B8F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615788, XrefRangeEnd = 615809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FFA RID: 8186 RVA: 0x0007D754 File Offset: 0x0007B954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615809, XrefRangeEnd = 615813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScreenSpaceShadowsPostPass()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceShadows.ScreenSpaceShadowsPostPass>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FFB RID: 8187 RVA: 0x00012523 File Offset: 0x00010723
			public ScreenSpaceShadowsPostPass(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B85 RID: 2949
			// (get) Token: 0x06001FFC RID: 8188 RVA: 0x0007D790 File Offset: 0x0007B990
			// (set) Token: 0x06001FFD RID: 8189 RVA: 0x0001252C File Offset: 0x0001072C
			public unsafe static string m_ProfilerTag
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeFieldInfoPtr_m_ProfilerTag, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeFieldInfoPtr_m_ProfilerTag, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000B86 RID: 2950
			// (get) Token: 0x06001FFE RID: 8190 RVA: 0x0007D7B0 File Offset: 0x0007B9B0
			// (set) Token: 0x06001FFF RID: 8191 RVA: 0x0001253E File Offset: 0x0001073E
			public unsafe static ProfilingSampler m_ProfilingSampler
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeFieldInfoPtr_m_ProfilingSampler, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeFieldInfoPtr_m_ProfilingSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B87 RID: 2951
			// (get) Token: 0x06002000 RID: 8192 RVA: 0x0007D7D8 File Offset: 0x0007B9D8
			// (set) Token: 0x06002001 RID: 8193 RVA: 0x00012550 File Offset: 0x00010750
			public unsafe static RTHandle k_CurrentActive
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeFieldInfoPtr_k_CurrentActive, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceShadows.ScreenSpaceShadowsPostPass.NativeFieldInfoPtr_k_CurrentActive, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016B3 RID: 5811
			private static readonly IntPtr NativeFieldInfoPtr_m_ProfilerTag;

			// Token: 0x040016B4 RID: 5812
			private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

			// Token: 0x040016B5 RID: 5813
			private static readonly IntPtr NativeFieldInfoPtr_k_CurrentActive;

			// Token: 0x040016B6 RID: 5814
			private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0;

			// Token: 0x040016B7 RID: 5815
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

			// Token: 0x040016B8 RID: 5816
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
