using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	// Token: 0x02000009 RID: 9
	public class RenderObjects : ScriptableRendererFeature
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00017130 File Offset: 0x00015330
		// Note: this type is marked as 'beforefieldinit'.
		static RenderObjects()
		{
			Il2CppClassPointerStore<RenderObjects>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Experimental.Rendering.Universal", "RenderObjects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderObjects>.NativeClassPtr);
			RenderObjects.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects>.NativeClassPtr, "settings");
			RenderObjects.NativeFieldInfoPtr_renderObjectsPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects>.NativeClassPtr, "renderObjectsPass");
			RenderObjects.NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjects>.NativeClassPtr, 100663375);
			RenderObjects.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjects>.NativeClassPtr, 100663376);
			RenderObjects.NativeMethodInfoPtr_SupportsNativeRenderPass_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjects>.NativeClassPtr, 100663377);
			RenderObjects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjects>.NativeClassPtr, 100663378);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000171D8 File Offset: 0x000153D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596838, XrefRangeEnd = 596866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderObjects.NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00017214 File Offset: 0x00015414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596866, XrefRangeEnd = 596871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderObjects.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00017274 File Offset: 0x00015474
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool SupportsNativeRenderPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderObjects.NativeMethodInfoPtr_SupportsNativeRenderPass_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000172BC File Offset: 0x000154BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596871, XrefRangeEnd = 596897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderObjects()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderObjects>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000242F File Offset: 0x0000062F
		public RenderObjects(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000172F8 File Offset: 0x000154F8
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002438 File Offset: 0x00000638
		public unsafe RenderObjects.RenderObjectsSettings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderObjects.RenderObjectsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00017328 File Offset: 0x00015528
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002457 File Offset: 0x00000657
		public unsafe RenderObjectsPass renderObjectsPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.NativeFieldInfoPtr_renderObjectsPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderObjectsPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.NativeFieldInfoPtr_renderObjectsPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_renderObjectsPass;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_SupportsNativeRenderPass_Internal_Virtual_Boolean_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200014C RID: 332
		[Serializable]
		public class RenderObjectsSettings : Object
		{
			// Token: 0x06001B39 RID: 6969 RVA: 0x00071C94 File Offset: 0x0006FE94
			// Note: this type is marked as 'beforefieldinit'.
			static RenderObjectsSettings()
			{
				Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderObjects>.NativeClassPtr, "RenderObjectsSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr);
				RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_passTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, "passTag");
				RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, "Event");
				RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_filterSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, "filterSettings");
				RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, "overrideMaterial");
				RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideMaterialPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, "overrideMaterialPassIndex");
				RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, "overrideShader");
				RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideShaderPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, "overrideShaderPassIndex");
				RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, "overrideMode");
				RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideDepthState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, "overrideDepthState");
				RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_depthCompareFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, "depthCompareFunction");
				RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_enableWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, "enableWrite");
				RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_stencilSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, "stencilSettings");
				RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_cameraSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, "cameraSettings");
				RenderObjects.RenderObjectsSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr, 100663379);
			}

			// Token: 0x06001B3A RID: 6970 RVA: 0x00071DD8 File Offset: 0x0006FFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596814, XrefRangeEnd = 596835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RenderObjectsSettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderObjects.RenderObjectsSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjects.RenderObjectsSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B3B RID: 6971 RVA: 0x0000F625 File Offset: 0x0000D825
			public RenderObjectsSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009CA RID: 2506
			// (get) Token: 0x06001B3C RID: 6972 RVA: 0x00071E14 File Offset: 0x00070014
			// (set) Token: 0x06001B3D RID: 6973 RVA: 0x0000F62E File Offset: 0x0000D82E
			public unsafe string passTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_passTag);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_passTag), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009CB RID: 2507
			// (get) Token: 0x06001B3E RID: 6974 RVA: 0x00071E3C File Offset: 0x0007003C
			// (set) Token: 0x06001B3F RID: 6975 RVA: 0x0000F64D File Offset: 0x0000D84D
			public unsafe RenderPassEvent Event
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_Event);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_Event)) = value;
				}
			}

			// Token: 0x170009CC RID: 2508
			// (get) Token: 0x06001B40 RID: 6976 RVA: 0x00071E64 File Offset: 0x00070064
			// (set) Token: 0x06001B41 RID: 6977 RVA: 0x0000F668 File Offset: 0x0000D868
			public unsafe RenderObjects.FilterSettings filterSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_filterSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderObjects.FilterSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_filterSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009CD RID: 2509
			// (get) Token: 0x06001B42 RID: 6978 RVA: 0x00071E94 File Offset: 0x00070094
			// (set) Token: 0x06001B43 RID: 6979 RVA: 0x0000F687 File Offset: 0x0000D887
			public unsafe Material overrideMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009CE RID: 2510
			// (get) Token: 0x06001B44 RID: 6980 RVA: 0x00071EC4 File Offset: 0x000700C4
			// (set) Token: 0x06001B45 RID: 6981 RVA: 0x0000F6A6 File Offset: 0x0000D8A6
			public unsafe int overrideMaterialPassIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideMaterialPassIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideMaterialPassIndex)) = value;
				}
			}

			// Token: 0x170009CF RID: 2511
			// (get) Token: 0x06001B46 RID: 6982 RVA: 0x00071EEC File Offset: 0x000700EC
			// (set) Token: 0x06001B47 RID: 6983 RVA: 0x0000F6C1 File Offset: 0x0000D8C1
			public unsafe Shader overrideShader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideShader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideShader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009D0 RID: 2512
			// (get) Token: 0x06001B48 RID: 6984 RVA: 0x00071F1C File Offset: 0x0007011C
			// (set) Token: 0x06001B49 RID: 6985 RVA: 0x0000F6E0 File Offset: 0x0000D8E0
			public unsafe int overrideShaderPassIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideShaderPassIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideShaderPassIndex)) = value;
				}
			}

			// Token: 0x170009D1 RID: 2513
			// (get) Token: 0x06001B4A RID: 6986 RVA: 0x00071F44 File Offset: 0x00070144
			// (set) Token: 0x06001B4B RID: 6987 RVA: 0x0000F6FB File Offset: 0x0000D8FB
			public unsafe RenderObjects.RenderObjectsSettings.OverrideMaterialMode overrideMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideMode)) = value;
				}
			}

			// Token: 0x170009D2 RID: 2514
			// (get) Token: 0x06001B4C RID: 6988 RVA: 0x00071F6C File Offset: 0x0007016C
			// (set) Token: 0x06001B4D RID: 6989 RVA: 0x0000F716 File Offset: 0x0000D916
			public unsafe bool overrideDepthState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideDepthState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_overrideDepthState)) = value;
				}
			}

			// Token: 0x170009D3 RID: 2515
			// (get) Token: 0x06001B4E RID: 6990 RVA: 0x00071F94 File Offset: 0x00070194
			// (set) Token: 0x06001B4F RID: 6991 RVA: 0x0000F731 File Offset: 0x0000D931
			public unsafe CompareFunction depthCompareFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_depthCompareFunction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_depthCompareFunction)) = value;
				}
			}

			// Token: 0x170009D4 RID: 2516
			// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00071FBC File Offset: 0x000701BC
			// (set) Token: 0x06001B51 RID: 6993 RVA: 0x0000F74C File Offset: 0x0000D94C
			public unsafe bool enableWrite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_enableWrite);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_enableWrite)) = value;
				}
			}

			// Token: 0x170009D5 RID: 2517
			// (get) Token: 0x06001B52 RID: 6994 RVA: 0x00071FE4 File Offset: 0x000701E4
			// (set) Token: 0x06001B53 RID: 6995 RVA: 0x0000F767 File Offset: 0x0000D967
			public unsafe StencilStateData stencilSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_stencilSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StencilStateData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_stencilSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009D6 RID: 2518
			// (get) Token: 0x06001B54 RID: 6996 RVA: 0x00072014 File Offset: 0x00070214
			// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0000F786 File Offset: 0x0000D986
			public unsafe RenderObjects.CustomCameraSettings cameraSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_cameraSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderObjects.CustomCameraSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.RenderObjectsSettings.NativeFieldInfoPtr_cameraSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013B7 RID: 5047
			private static readonly IntPtr NativeFieldInfoPtr_passTag;

			// Token: 0x040013B8 RID: 5048
			private static readonly IntPtr NativeFieldInfoPtr_Event;

			// Token: 0x040013B9 RID: 5049
			private static readonly IntPtr NativeFieldInfoPtr_filterSettings;

			// Token: 0x040013BA RID: 5050
			private static readonly IntPtr NativeFieldInfoPtr_overrideMaterial;

			// Token: 0x040013BB RID: 5051
			private static readonly IntPtr NativeFieldInfoPtr_overrideMaterialPassIndex;

			// Token: 0x040013BC RID: 5052
			private static readonly IntPtr NativeFieldInfoPtr_overrideShader;

			// Token: 0x040013BD RID: 5053
			private static readonly IntPtr NativeFieldInfoPtr_overrideShaderPassIndex;

			// Token: 0x040013BE RID: 5054
			private static readonly IntPtr NativeFieldInfoPtr_overrideMode;

			// Token: 0x040013BF RID: 5055
			private static readonly IntPtr NativeFieldInfoPtr_overrideDepthState;

			// Token: 0x040013C0 RID: 5056
			private static readonly IntPtr NativeFieldInfoPtr_depthCompareFunction;

			// Token: 0x040013C1 RID: 5057
			private static readonly IntPtr NativeFieldInfoPtr_enableWrite;

			// Token: 0x040013C2 RID: 5058
			private static readonly IntPtr NativeFieldInfoPtr_stencilSettings;

			// Token: 0x040013C3 RID: 5059
			private static readonly IntPtr NativeFieldInfoPtr_cameraSettings;

			// Token: 0x040013C4 RID: 5060
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200021A RID: 538
			public enum OverrideMaterialMode
			{
				// Token: 0x040018E8 RID: 6376
				None,
				// Token: 0x040018E9 RID: 6377
				Material,
				// Token: 0x040018EA RID: 6378
				Shader
			}
		}

		// Token: 0x0200014D RID: 333
		[Serializable]
		public class FilterSettings : Object
		{
			// Token: 0x06001B56 RID: 6998 RVA: 0x00072044 File Offset: 0x00070244
			// Note: this type is marked as 'beforefieldinit'.
			static FilterSettings()
			{
				Il2CppClassPointerStore<RenderObjects.FilterSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderObjects>.NativeClassPtr, "FilterSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderObjects.FilterSettings>.NativeClassPtr);
				RenderObjects.FilterSettings.NativeFieldInfoPtr_RenderQueueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.FilterSettings>.NativeClassPtr, "RenderQueueType");
				RenderObjects.FilterSettings.NativeFieldInfoPtr_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.FilterSettings>.NativeClassPtr, "LayerMask");
				RenderObjects.FilterSettings.NativeFieldInfoPtr_PassNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.FilterSettings>.NativeClassPtr, "PassNames");
				RenderObjects.FilterSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjects.FilterSettings>.NativeClassPtr, 100663380);
			}

			// Token: 0x06001B57 RID: 6999 RVA: 0x000720C0 File Offset: 0x000702C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596835, XrefRangeEnd = 596837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FilterSettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderObjects.FilterSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjects.FilterSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B58 RID: 7000 RVA: 0x0000F7A5 File Offset: 0x0000D9A5
			public FilterSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009D7 RID: 2519
			// (get) Token: 0x06001B59 RID: 7001 RVA: 0x000720FC File Offset: 0x000702FC
			// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0000F7AE File Offset: 0x0000D9AE
			public unsafe RenderQueueType RenderQueueType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.FilterSettings.NativeFieldInfoPtr_RenderQueueType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.FilterSettings.NativeFieldInfoPtr_RenderQueueType)) = value;
				}
			}

			// Token: 0x170009D8 RID: 2520
			// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00072124 File Offset: 0x00070324
			// (set) Token: 0x06001B5C RID: 7004 RVA: 0x0000F7C9 File Offset: 0x0000D9C9
			public unsafe LayerMask LayerMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.FilterSettings.NativeFieldInfoPtr_LayerMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.FilterSettings.NativeFieldInfoPtr_LayerMask)) = value;
				}
			}

			// Token: 0x170009D9 RID: 2521
			// (get) Token: 0x06001B5D RID: 7005 RVA: 0x0007214C File Offset: 0x0007034C
			// (set) Token: 0x06001B5E RID: 7006 RVA: 0x0000F7E4 File Offset: 0x0000D9E4
			public unsafe Il2CppStringArray PassNames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.FilterSettings.NativeFieldInfoPtr_PassNames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.FilterSettings.NativeFieldInfoPtr_PassNames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013C5 RID: 5061
			private static readonly IntPtr NativeFieldInfoPtr_RenderQueueType;

			// Token: 0x040013C6 RID: 5062
			private static readonly IntPtr NativeFieldInfoPtr_LayerMask;

			// Token: 0x040013C7 RID: 5063
			private static readonly IntPtr NativeFieldInfoPtr_PassNames;

			// Token: 0x040013C8 RID: 5064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200014E RID: 334
		[Serializable]
		public class CustomCameraSettings : Object
		{
			// Token: 0x06001B5F RID: 7007 RVA: 0x0007217C File Offset: 0x0007037C
			// Note: this type is marked as 'beforefieldinit'.
			static CustomCameraSettings()
			{
				Il2CppClassPointerStore<RenderObjects.CustomCameraSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderObjects>.NativeClassPtr, "CustomCameraSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderObjects.CustomCameraSettings>.NativeClassPtr);
				RenderObjects.CustomCameraSettings.NativeFieldInfoPtr_overrideCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.CustomCameraSettings>.NativeClassPtr, "overrideCamera");
				RenderObjects.CustomCameraSettings.NativeFieldInfoPtr_restoreCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.CustomCameraSettings>.NativeClassPtr, "restoreCamera");
				RenderObjects.CustomCameraSettings.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.CustomCameraSettings>.NativeClassPtr, "offset");
				RenderObjects.CustomCameraSettings.NativeFieldInfoPtr_cameraFieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderObjects.CustomCameraSettings>.NativeClassPtr, "cameraFieldOfView");
				RenderObjects.CustomCameraSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderObjects.CustomCameraSettings>.NativeClassPtr, 100663381);
			}

			// Token: 0x06001B60 RID: 7008 RVA: 0x0007220C File Offset: 0x0007040C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596837, XrefRangeEnd = 596838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CustomCameraSettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderObjects.CustomCameraSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderObjects.CustomCameraSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B61 RID: 7009 RVA: 0x0000F803 File Offset: 0x0000DA03
			public CustomCameraSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009DA RID: 2522
			// (get) Token: 0x06001B62 RID: 7010 RVA: 0x00072248 File Offset: 0x00070448
			// (set) Token: 0x06001B63 RID: 7011 RVA: 0x0000F80C File Offset: 0x0000DA0C
			public unsafe bool overrideCamera
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.CustomCameraSettings.NativeFieldInfoPtr_overrideCamera);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.CustomCameraSettings.NativeFieldInfoPtr_overrideCamera)) = value;
				}
			}

			// Token: 0x170009DB RID: 2523
			// (get) Token: 0x06001B64 RID: 7012 RVA: 0x00072270 File Offset: 0x00070470
			// (set) Token: 0x06001B65 RID: 7013 RVA: 0x0000F827 File Offset: 0x0000DA27
			public unsafe bool restoreCamera
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.CustomCameraSettings.NativeFieldInfoPtr_restoreCamera);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.CustomCameraSettings.NativeFieldInfoPtr_restoreCamera)) = value;
				}
			}

			// Token: 0x170009DC RID: 2524
			// (get) Token: 0x06001B66 RID: 7014 RVA: 0x00072298 File Offset: 0x00070498
			// (set) Token: 0x06001B67 RID: 7015 RVA: 0x0000F842 File Offset: 0x0000DA42
			public unsafe Vector4 offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.CustomCameraSettings.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.CustomCameraSettings.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x170009DD RID: 2525
			// (get) Token: 0x06001B68 RID: 7016 RVA: 0x000722C0 File Offset: 0x000704C0
			// (set) Token: 0x06001B69 RID: 7017 RVA: 0x0000F85D File Offset: 0x0000DA5D
			public unsafe float cameraFieldOfView
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.CustomCameraSettings.NativeFieldInfoPtr_cameraFieldOfView);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderObjects.CustomCameraSettings.NativeFieldInfoPtr_cameraFieldOfView)) = value;
				}
			}

			// Token: 0x040013C9 RID: 5065
			private static readonly IntPtr NativeFieldInfoPtr_overrideCamera;

			// Token: 0x040013CA RID: 5066
			private static readonly IntPtr NativeFieldInfoPtr_restoreCamera;

			// Token: 0x040013CB RID: 5067
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040013CC RID: 5068
			private static readonly IntPtr NativeFieldInfoPtr_cameraFieldOfView;

			// Token: 0x040013CD RID: 5069
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
