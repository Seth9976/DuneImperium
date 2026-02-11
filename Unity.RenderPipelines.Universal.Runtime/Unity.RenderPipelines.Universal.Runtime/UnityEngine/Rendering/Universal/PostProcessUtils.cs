using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000BB RID: 187
	public static class PostProcessUtils : Object
	{
		// Token: 0x06000ED5 RID: 3797 RVA: 0x0004897C File Offset: 0x00046B7C
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessUtils()
		{
			Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PostProcessUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr);
			PostProcessUtils.NativeMethodInfoPtr_ConfigureDithering_Public_Static_Int32_PostProcessData_Int32_Camera_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr, 100665191);
			PostProcessUtils.NativeMethodInfoPtr_ConfigureDithering_Public_Static_Int32_PostProcessData_Int32_Int32_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr, 100665192);
			PostProcessUtils.NativeMethodInfoPtr_ConfigureFilmGrain_Public_Static_Void_PostProcessData_FilmGrain_Camera_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr, 100665193);
			PostProcessUtils.NativeMethodInfoPtr_ConfigureFilmGrain_Public_Static_Void_PostProcessData_FilmGrain_Int32_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr, 100665194);
			PostProcessUtils.NativeMethodInfoPtr_SetSourceSize_Internal_Static_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr, 100665195);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00048A10 File Offset: 0x00046C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 614512, XrefRangeEnd = 614515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConfigureDithering(PostProcessData data, int index, Camera camera, Material material)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessUtils.NativeMethodInfoPtr_ConfigureDithering_Public_Static_Int32_PostProcessData_Int32_Camera_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00048A84 File Offset: 0x00046C84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 614528, RefRangeEnd = 614532, XrefRangeStart = 614515, XrefRangeEnd = 614528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConfigureDithering(PostProcessData data, int index, int cameraPixelWidth, int cameraPixelHeight, Material material)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraPixelWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraPixelHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessUtils.NativeMethodInfoPtr_ConfigureDithering_Public_Static_Int32_PostProcessData_Int32_Int32_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00048B04 File Offset: 0x00046D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 614532, XrefRangeEnd = 614535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, Camera camera, Material material)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessUtils.NativeMethodInfoPtr_ConfigureFilmGrain_Public_Static_Void_PostProcessData_FilmGrain_Camera_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00048B70 File Offset: 0x00046D70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 614557, RefRangeEnd = 614559, XrefRangeStart = 614535, XrefRangeEnd = 614557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, int cameraPixelWidth, int cameraPixelHeight, Material material)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraPixelWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraPixelHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessUtils.NativeMethodInfoPtr_ConfigureFilmGrain_Public_Static_Void_PostProcessData_FilmGrain_Int32_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00048BE8 File Offset: 0x00046DE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 614567, RefRangeEnd = 614572, XrefRangeStart = 614559, XrefRangeEnd = 614567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSourceSize(CommandBuffer cmd, RenderTextureDescriptor desc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessUtils.NativeMethodInfoPtr_SetSourceSize_Internal_Static_Void_CommandBuffer_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00009234 File Offset: 0x00007434
		public PostProcessUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDithering_Public_Static_Int32_PostProcessData_Int32_Camera_Material_0;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDithering_Public_Static_Int32_PostProcessData_Int32_Int32_Int32_Material_0;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureFilmGrain_Public_Static_Void_PostProcessData_FilmGrain_Camera_Material_0;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureFilmGrain_Public_Static_Void_PostProcessData_FilmGrain_Int32_Int32_Material_0;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_SetSourceSize_Internal_Static_Void_CommandBuffer_RenderTextureDescriptor_0;

		// Token: 0x020001AF RID: 431
		public static class ShaderConstants : Object
		{
			// Token: 0x06001F55 RID: 8021 RVA: 0x0007BECC File Offset: 0x0007A0CC
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderConstants()
			{
				Il2CppClassPointerStore<PostProcessUtils.ShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr, "ShaderConstants");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessUtils.ShaderConstants>.NativeClassPtr);
				PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__Grain_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessUtils.ShaderConstants>.NativeClassPtr, "_Grain_Texture");
				PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__Grain_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessUtils.ShaderConstants>.NativeClassPtr, "_Grain_Params");
				PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__Grain_TilingParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessUtils.ShaderConstants>.NativeClassPtr, "_Grain_TilingParams");
				PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__BlueNoise_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessUtils.ShaderConstants>.NativeClassPtr, "_BlueNoise_Texture");
				PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__Dithering_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessUtils.ShaderConstants>.NativeClassPtr, "_Dithering_Params");
				PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__SourceSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessUtils.ShaderConstants>.NativeClassPtr, "_SourceSize");
			}

			// Token: 0x06001F56 RID: 8022 RVA: 0x00011F32 File Offset: 0x00010132
			public ShaderConstants(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B40 RID: 2880
			// (get) Token: 0x06001F57 RID: 8023 RVA: 0x0007BF70 File Offset: 0x0007A170
			// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00011F3B File Offset: 0x0001013B
			public unsafe static int _Grain_Texture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__Grain_Texture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__Grain_Texture, (void*)(&value));
				}
			}

			// Token: 0x17000B41 RID: 2881
			// (get) Token: 0x06001F59 RID: 8025 RVA: 0x0007BF8C File Offset: 0x0007A18C
			// (set) Token: 0x06001F5A RID: 8026 RVA: 0x00011F49 File Offset: 0x00010149
			public unsafe static int _Grain_Params
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__Grain_Params, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__Grain_Params, (void*)(&value));
				}
			}

			// Token: 0x17000B42 RID: 2882
			// (get) Token: 0x06001F5B RID: 8027 RVA: 0x0007BFA8 File Offset: 0x0007A1A8
			// (set) Token: 0x06001F5C RID: 8028 RVA: 0x00011F57 File Offset: 0x00010157
			public unsafe static int _Grain_TilingParams
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__Grain_TilingParams, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__Grain_TilingParams, (void*)(&value));
				}
			}

			// Token: 0x17000B43 RID: 2883
			// (get) Token: 0x06001F5D RID: 8029 RVA: 0x0007BFC4 File Offset: 0x0007A1C4
			// (set) Token: 0x06001F5E RID: 8030 RVA: 0x00011F65 File Offset: 0x00010165
			public unsafe static int _BlueNoise_Texture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__BlueNoise_Texture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__BlueNoise_Texture, (void*)(&value));
				}
			}

			// Token: 0x17000B44 RID: 2884
			// (get) Token: 0x06001F5F RID: 8031 RVA: 0x0007BFE0 File Offset: 0x0007A1E0
			// (set) Token: 0x06001F60 RID: 8032 RVA: 0x00011F73 File Offset: 0x00010173
			public unsafe static int _Dithering_Params
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__Dithering_Params, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__Dithering_Params, (void*)(&value));
				}
			}

			// Token: 0x17000B45 RID: 2885
			// (get) Token: 0x06001F61 RID: 8033 RVA: 0x0007BFFC File Offset: 0x0007A1FC
			// (set) Token: 0x06001F62 RID: 8034 RVA: 0x00011F81 File Offset: 0x00010181
			public unsafe static int _SourceSize
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__SourceSize, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessUtils.ShaderConstants.NativeFieldInfoPtr__SourceSize, (void*)(&value));
				}
			}

			// Token: 0x0400164E RID: 5710
			private static readonly IntPtr NativeFieldInfoPtr__Grain_Texture;

			// Token: 0x0400164F RID: 5711
			private static readonly IntPtr NativeFieldInfoPtr__Grain_Params;

			// Token: 0x04001650 RID: 5712
			private static readonly IntPtr NativeFieldInfoPtr__Grain_TilingParams;

			// Token: 0x04001651 RID: 5713
			private static readonly IntPtr NativeFieldInfoPtr__BlueNoise_Texture;

			// Token: 0x04001652 RID: 5714
			private static readonly IntPtr NativeFieldInfoPtr__Dithering_Params;

			// Token: 0x04001653 RID: 5715
			private static readonly IntPtr NativeFieldInfoPtr__SourceSize;
		}
	}
}
