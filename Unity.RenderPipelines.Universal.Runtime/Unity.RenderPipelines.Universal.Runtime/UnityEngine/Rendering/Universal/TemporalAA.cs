using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000DA RID: 218
	public static class TemporalAA : Object
	{
		// Token: 0x060010CD RID: 4301 RVA: 0x0004FEBC File Offset: 0x0004E0BC
		// Note: this type is marked as 'beforefieldinit'.
		static TemporalAA()
		{
			Il2CppClassPointerStore<TemporalAA>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TemporalAA");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr);
			TemporalAA.NativeFieldInfoPtr_taaFilterOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "taaFilterOffsets");
			TemporalAA.NativeFieldInfoPtr_taaFilterWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "taaFilterWeights");
			TemporalAA.NativeMethodInfoPtr_CalculateJitterMatrix_Internal_Static_Matrix4x4_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665437);
			TemporalAA.NativeMethodInfoPtr_CalculateJitter_Internal_Static_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665438);
			TemporalAA.NativeMethodInfoPtr_CalculateFilterWeights_Internal_Static_Il2CppStructArray_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665439);
			TemporalAA.NativeMethodInfoPtr_ValidateAndWarn_Internal_Static_String_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665440);
			TemporalAA.NativeMethodInfoPtr_ExecutePass_Internal_Static_Void_CommandBuffer_Material_byref_CameraData_RTHandle_RTHandle_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665441);
			TemporalAA.NativeMethodInfoPtr_Render_Internal_Static_Void_RenderGraph_Material_byref_CameraData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665442);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0004FF8C File Offset: 0x0004E18C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617685, RefRangeEnd = 617686, XrefRangeStart = 617675, XrefRangeEnd = 617685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 CalculateJitterMatrix(ref CameraData cameraData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.NativeMethodInfoPtr_CalculateJitterMatrix_Internal_Static_Matrix4x4_byref_CameraData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0004FFD0 File Offset: 0x0004E1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617686, XrefRangeEnd = 617688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 CalculateJitter(int frameIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref frameIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.NativeMethodInfoPtr_CalculateJitter_Internal_Static_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x00050010 File Offset: 0x0004E210
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 617704, RefRangeEnd = 617706, XrefRangeStart = 617688, XrefRangeEnd = 617704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> CalculateFilterWeights(float jitterScale)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jitterScale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.NativeMethodInfoPtr_CalculateFilterWeights_Internal_Static_Il2CppStructArray_1_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00050050 File Offset: 0x0004E250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617730, RefRangeEnd = 617731, XrefRangeStart = 617706, XrefRangeEnd = 617730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ValidateAndWarn(ref CameraData cameraData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.NativeMethodInfoPtr_ValidateAndWarn_Internal_Static_String_byref_CameraData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00050090 File Offset: 0x0004E290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617788, RefRangeEnd = 617789, XrefRangeStart = 617731, XrefRangeEnd = 617788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutePass(CommandBuffer cmd, Material taaMaterial, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderTexture motionVectors)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(taaMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(motionVectors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.NativeMethodInfoPtr_ExecutePass_Internal_Static_Void_CommandBuffer_Material_byref_CameraData_RTHandle_RTHandle_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00050124 File Offset: 0x0004E324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617789, XrefRangeEnd = 617872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Render(RenderGraph renderGraph, Material taaMaterial, ref CameraData cameraData, ref TextureHandle srcColor, ref TextureHandle srcDepth, ref TextureHandle srcMotionVectors, ref TextureHandle dstColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderGraph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(taaMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &srcColor;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &srcDepth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &srcMotionVectors;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dstColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.NativeMethodInfoPtr_Render_Internal_Static_Void_RenderGraph_Material_byref_CameraData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00009FD6 File Offset: 0x000081D6
		public TemporalAA(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x000501BC File Offset: 0x0004E3BC
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x00009FDF File Offset: 0x000081DF
		public unsafe static Il2CppStructArray<Vector2> taaFilterOffsets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TemporalAA.NativeFieldInfoPtr_taaFilterOffsets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TemporalAA.NativeFieldInfoPtr_taaFilterOffsets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x000501E4 File Offset: 0x0004E3E4
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x00009FF1 File Offset: 0x000081F1
		public unsafe static Il2CppStructArray<float> taaFilterWeights
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TemporalAA.NativeFieldInfoPtr_taaFilterWeights, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TemporalAA.NativeFieldInfoPtr_taaFilterWeights, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeFieldInfoPtr_taaFilterOffsets;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeFieldInfoPtr_taaFilterWeights;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_CalculateJitterMatrix_Internal_Static_Matrix4x4_byref_CameraData_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_CalculateJitter_Internal_Static_Vector2_Int32_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFilterWeights_Internal_Static_Il2CppStructArray_1_Single_Single_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAndWarn_Internal_Static_String_byref_CameraData_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Internal_Static_Void_CommandBuffer_Material_byref_CameraData_RTHandle_RTHandle_RenderTexture_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Static_Void_RenderGraph_Material_byref_CameraData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_0;

		// Token: 0x020001C0 RID: 448
		public static class ShaderConstants : Object
		{
			// Token: 0x06002011 RID: 8209 RVA: 0x0007DAC8 File Offset: 0x0007BCC8
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderConstants()
			{
				Il2CppClassPointerStore<TemporalAA.ShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "ShaderConstants");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemporalAA.ShaderConstants>.NativeClassPtr);
				TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaAccumulationTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.ShaderConstants>.NativeClassPtr, "_TaaAccumulationTex");
				TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaMotionVectorTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.ShaderConstants>.NativeClassPtr, "_TaaMotionVectorTex");
				TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaFilterWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.ShaderConstants>.NativeClassPtr, "_TaaFilterWeights");
				TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaFrameInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.ShaderConstants>.NativeClassPtr, "_TaaFrameInfluence");
				TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaVarianceClampScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.ShaderConstants>.NativeClassPtr, "_TaaVarianceClampScale");
				TemporalAA.ShaderConstants.NativeFieldInfoPtr__CameraDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.ShaderConstants>.NativeClassPtr, "_CameraDepthTexture");
			}

			// Token: 0x06002012 RID: 8210 RVA: 0x000125D1 File Offset: 0x000107D1
			public ShaderConstants(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B8B RID: 2955
			// (get) Token: 0x06002013 RID: 8211 RVA: 0x0007DB6C File Offset: 0x0007BD6C
			// (set) Token: 0x06002014 RID: 8212 RVA: 0x000125DA File Offset: 0x000107DA
			public unsafe static int _TaaAccumulationTex
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaAccumulationTex, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaAccumulationTex, (void*)(&value));
				}
			}

			// Token: 0x17000B8C RID: 2956
			// (get) Token: 0x06002015 RID: 8213 RVA: 0x0007DB88 File Offset: 0x0007BD88
			// (set) Token: 0x06002016 RID: 8214 RVA: 0x000125E8 File Offset: 0x000107E8
			public unsafe static int _TaaMotionVectorTex
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaMotionVectorTex, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaMotionVectorTex, (void*)(&value));
				}
			}

			// Token: 0x17000B8D RID: 2957
			// (get) Token: 0x06002017 RID: 8215 RVA: 0x0007DBA4 File Offset: 0x0007BDA4
			// (set) Token: 0x06002018 RID: 8216 RVA: 0x000125F6 File Offset: 0x000107F6
			public unsafe static int _TaaFilterWeights
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaFilterWeights, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaFilterWeights, (void*)(&value));
				}
			}

			// Token: 0x17000B8E RID: 2958
			// (get) Token: 0x06002019 RID: 8217 RVA: 0x0007DBC0 File Offset: 0x0007BDC0
			// (set) Token: 0x0600201A RID: 8218 RVA: 0x00012604 File Offset: 0x00010804
			public unsafe static int _TaaFrameInfluence
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaFrameInfluence, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaFrameInfluence, (void*)(&value));
				}
			}

			// Token: 0x17000B8F RID: 2959
			// (get) Token: 0x0600201B RID: 8219 RVA: 0x0007DBDC File Offset: 0x0007BDDC
			// (set) Token: 0x0600201C RID: 8220 RVA: 0x00012612 File Offset: 0x00010812
			public unsafe static int _TaaVarianceClampScale
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaVarianceClampScale, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TemporalAA.ShaderConstants.NativeFieldInfoPtr__TaaVarianceClampScale, (void*)(&value));
				}
			}

			// Token: 0x17000B90 RID: 2960
			// (get) Token: 0x0600201D RID: 8221 RVA: 0x0007DBF8 File Offset: 0x0007BDF8
			// (set) Token: 0x0600201E RID: 8222 RVA: 0x00012620 File Offset: 0x00010820
			public unsafe static int _CameraDepthTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(TemporalAA.ShaderConstants.NativeFieldInfoPtr__CameraDepthTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TemporalAA.ShaderConstants.NativeFieldInfoPtr__CameraDepthTexture, (void*)(&value));
				}
			}

			// Token: 0x040016C9 RID: 5833
			private static readonly IntPtr NativeFieldInfoPtr__TaaAccumulationTex;

			// Token: 0x040016CA RID: 5834
			private static readonly IntPtr NativeFieldInfoPtr__TaaMotionVectorTex;

			// Token: 0x040016CB RID: 5835
			private static readonly IntPtr NativeFieldInfoPtr__TaaFilterWeights;

			// Token: 0x040016CC RID: 5836
			private static readonly IntPtr NativeFieldInfoPtr__TaaFrameInfluence;

			// Token: 0x040016CD RID: 5837
			private static readonly IntPtr NativeFieldInfoPtr__TaaVarianceClampScale;

			// Token: 0x040016CE RID: 5838
			private static readonly IntPtr NativeFieldInfoPtr__CameraDepthTexture;
		}

		// Token: 0x020001C1 RID: 449
		public static class ShaderKeywords : Object
		{
			// Token: 0x0600201F RID: 8223 RVA: 0x0001262E File Offset: 0x0001082E
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderKeywords()
			{
				Il2CppClassPointerStore<TemporalAA.ShaderKeywords>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "ShaderKeywords");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemporalAA.ShaderKeywords>.NativeClassPtr);
				TemporalAA.ShaderKeywords.NativeFieldInfoPtr_TAA_LOW_PRECISION_SOURCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.ShaderKeywords>.NativeClassPtr, "TAA_LOW_PRECISION_SOURCE");
			}

			// Token: 0x06002020 RID: 8224 RVA: 0x00012662 File Offset: 0x00010862
			public ShaderKeywords(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B91 RID: 2961
			// (get) Token: 0x06002021 RID: 8225 RVA: 0x0007DC14 File Offset: 0x0007BE14
			// (set) Token: 0x06002022 RID: 8226 RVA: 0x0001266B File Offset: 0x0001086B
			public unsafe static string TAA_LOW_PRECISION_SOURCE
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TemporalAA.ShaderKeywords.NativeFieldInfoPtr_TAA_LOW_PRECISION_SOURCE, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TemporalAA.ShaderKeywords.NativeFieldInfoPtr_TAA_LOW_PRECISION_SOURCE, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040016CF RID: 5839
			private static readonly IntPtr NativeFieldInfoPtr_TAA_LOW_PRECISION_SOURCE;
		}

		// Token: 0x020001C2 RID: 450
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x06002023 RID: 8227 RVA: 0x0007DC34 File Offset: 0x0007BE34
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr);
				TemporalAA.Settings.NativeFieldInfoPtr_m_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, "m_Quality");
				TemporalAA.Settings.NativeFieldInfoPtr_m_FrameInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, "m_FrameInfluence");
				TemporalAA.Settings.NativeFieldInfoPtr_m_JitterScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, "m_JitterScale");
				TemporalAA.Settings.NativeFieldInfoPtr_m_MipBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, "m_MipBias");
				TemporalAA.Settings.NativeFieldInfoPtr_m_VarianceClampScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, "m_VarianceClampScale");
				TemporalAA.Settings.NativeFieldInfoPtr_m_ContrastAdaptiveSharpening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, "m_ContrastAdaptiveSharpening");
				TemporalAA.Settings.NativeFieldInfoPtr_resetHistoryFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, "resetHistoryFrames");
				TemporalAA.Settings.NativeFieldInfoPtr_jitterFrameCountOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, "jitterFrameCountOffset");
				TemporalAA.Settings.NativeMethodInfoPtr_get_quality_Public_get_TemporalAAQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, 100665446);
				TemporalAA.Settings.NativeMethodInfoPtr_set_quality_Public_set_Void_TemporalAAQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, 100665447);
				TemporalAA.Settings.NativeMethodInfoPtr_get_baseBlendFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, 100665448);
				TemporalAA.Settings.NativeMethodInfoPtr_set_baseBlendFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, 100665449);
				TemporalAA.Settings.NativeMethodInfoPtr_get_jitterScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, 100665450);
				TemporalAA.Settings.NativeMethodInfoPtr_set_jitterScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, 100665451);
				TemporalAA.Settings.NativeMethodInfoPtr_get_mipBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, 100665452);
				TemporalAA.Settings.NativeMethodInfoPtr_set_mipBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, 100665453);
				TemporalAA.Settings.NativeMethodInfoPtr_get_varianceClampScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, 100665454);
				TemporalAA.Settings.NativeMethodInfoPtr_set_varianceClampScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, 100665455);
				TemporalAA.Settings.NativeMethodInfoPtr_get_contrastAdaptiveSharpening_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, 100665456);
				TemporalAA.Settings.NativeMethodInfoPtr_set_contrastAdaptiveSharpening_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, 100665457);
				TemporalAA.Settings.NativeMethodInfoPtr_Create_Public_Static_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, 100665458);
			}

			// Token: 0x17000B92 RID: 2962
			// (get) Token: 0x06002024 RID: 8228 RVA: 0x0007DE04 File Offset: 0x0007C004
			// (set) Token: 0x06002025 RID: 8229 RVA: 0x0007DE34 File Offset: 0x0007C034
			public unsafe TemporalAAQuality quality
			{
				[CallerCount(200)]
				[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.Settings.NativeMethodInfoPtr_get_quality_Public_get_TemporalAAQuality_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.Settings.NativeMethodInfoPtr_set_quality_Public_set_Void_TemporalAAQuality_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000B93 RID: 2963
			// (get) Token: 0x06002026 RID: 8230 RVA: 0x0007DE68 File Offset: 0x0007C068
			// (set) Token: 0x06002027 RID: 8231 RVA: 0x0007DE98 File Offset: 0x0007C098
			public unsafe float baseBlendFactor
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.Settings.NativeMethodInfoPtr_get_baseBlendFactor_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.Settings.NativeMethodInfoPtr_set_baseBlendFactor_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000B94 RID: 2964
			// (get) Token: 0x06002028 RID: 8232 RVA: 0x0007DECC File Offset: 0x0007C0CC
			// (set) Token: 0x06002029 RID: 8233 RVA: 0x0007DEFC File Offset: 0x0007C0FC
			public unsafe float jitterScale
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.Settings.NativeMethodInfoPtr_get_jitterScale_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 617622, RefRangeEnd = 617623, XrefRangeStart = 617622, XrefRangeEnd = 617622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.Settings.NativeMethodInfoPtr_set_jitterScale_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000B95 RID: 2965
			// (get) Token: 0x0600202A RID: 8234 RVA: 0x0007DF30 File Offset: 0x0007C130
			// (set) Token: 0x0600202B RID: 8235 RVA: 0x0007DF60 File Offset: 0x0007C160
			public unsafe float mipBias
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.Settings.NativeMethodInfoPtr_get_mipBias_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.Settings.NativeMethodInfoPtr_set_mipBias_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000B96 RID: 2966
			// (get) Token: 0x0600202C RID: 8236 RVA: 0x0007DF94 File Offset: 0x0007C194
			// (set) Token: 0x0600202D RID: 8237 RVA: 0x0007DFC4 File Offset: 0x0007C1C4
			public unsafe float varianceClampScale
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.Settings.NativeMethodInfoPtr_get_varianceClampScale_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.Settings.NativeMethodInfoPtr_set_varianceClampScale_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000B97 RID: 2967
			// (get) Token: 0x0600202E RID: 8238 RVA: 0x0007DFF8 File Offset: 0x0007C1F8
			// (set) Token: 0x0600202F RID: 8239 RVA: 0x0007E028 File Offset: 0x0007C228
			public unsafe float contrastAdaptiveSharpening
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.Settings.NativeMethodInfoPtr_get_contrastAdaptiveSharpening_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.Settings.NativeMethodInfoPtr_set_contrastAdaptiveSharpening_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06002030 RID: 8240 RVA: 0x0007E05C File Offset: 0x0007C25C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 617623, RefRangeEnd = 617625, XrefRangeStart = 617623, XrefRangeEnd = 617623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TemporalAA.Settings Create()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.Settings.NativeMethodInfoPtr_Create_Public_Static_Settings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002031 RID: 8241 RVA: 0x0001267D File Offset: 0x0001087D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TemporalAA.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x040016D0 RID: 5840
			private static readonly IntPtr NativeFieldInfoPtr_m_Quality;

			// Token: 0x040016D1 RID: 5841
			private static readonly IntPtr NativeFieldInfoPtr_m_FrameInfluence;

			// Token: 0x040016D2 RID: 5842
			private static readonly IntPtr NativeFieldInfoPtr_m_JitterScale;

			// Token: 0x040016D3 RID: 5843
			private static readonly IntPtr NativeFieldInfoPtr_m_MipBias;

			// Token: 0x040016D4 RID: 5844
			private static readonly IntPtr NativeFieldInfoPtr_m_VarianceClampScale;

			// Token: 0x040016D5 RID: 5845
			private static readonly IntPtr NativeFieldInfoPtr_m_ContrastAdaptiveSharpening;

			// Token: 0x040016D6 RID: 5846
			private static readonly IntPtr NativeFieldInfoPtr_resetHistoryFrames;

			// Token: 0x040016D7 RID: 5847
			private static readonly IntPtr NativeFieldInfoPtr_jitterFrameCountOffset;

			// Token: 0x040016D8 RID: 5848
			private static readonly IntPtr NativeMethodInfoPtr_get_quality_Public_get_TemporalAAQuality_0;

			// Token: 0x040016D9 RID: 5849
			private static readonly IntPtr NativeMethodInfoPtr_set_quality_Public_set_Void_TemporalAAQuality_0;

			// Token: 0x040016DA RID: 5850
			private static readonly IntPtr NativeMethodInfoPtr_get_baseBlendFactor_Public_get_Single_0;

			// Token: 0x040016DB RID: 5851
			private static readonly IntPtr NativeMethodInfoPtr_set_baseBlendFactor_Public_set_Void_Single_0;

			// Token: 0x040016DC RID: 5852
			private static readonly IntPtr NativeMethodInfoPtr_get_jitterScale_Public_get_Single_0;

			// Token: 0x040016DD RID: 5853
			private static readonly IntPtr NativeMethodInfoPtr_set_jitterScale_Public_set_Void_Single_0;

			// Token: 0x040016DE RID: 5854
			private static readonly IntPtr NativeMethodInfoPtr_get_mipBias_Public_get_Single_0;

			// Token: 0x040016DF RID: 5855
			private static readonly IntPtr NativeMethodInfoPtr_set_mipBias_Public_set_Void_Single_0;

			// Token: 0x040016E0 RID: 5856
			private static readonly IntPtr NativeMethodInfoPtr_get_varianceClampScale_Public_get_Single_0;

			// Token: 0x040016E1 RID: 5857
			private static readonly IntPtr NativeMethodInfoPtr_set_varianceClampScale_Public_set_Void_Single_0;

			// Token: 0x040016E2 RID: 5858
			private static readonly IntPtr NativeMethodInfoPtr_get_contrastAdaptiveSharpening_Public_get_Single_0;

			// Token: 0x040016E3 RID: 5859
			private static readonly IntPtr NativeMethodInfoPtr_set_contrastAdaptiveSharpening_Public_set_Void_Single_0;

			// Token: 0x040016E4 RID: 5860
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Settings_0;

			// Token: 0x040016E5 RID: 5861
			[FieldOffset(0)]
			public TemporalAAQuality m_Quality;

			// Token: 0x040016E6 RID: 5862
			[FieldOffset(4)]
			public float m_FrameInfluence;

			// Token: 0x040016E7 RID: 5863
			[FieldOffset(8)]
			public float m_JitterScale;

			// Token: 0x040016E8 RID: 5864
			[FieldOffset(12)]
			public float m_MipBias;

			// Token: 0x040016E9 RID: 5865
			[FieldOffset(16)]
			public float m_VarianceClampScale;

			// Token: 0x040016EA RID: 5866
			[FieldOffset(20)]
			public float m_ContrastAdaptiveSharpening;

			// Token: 0x040016EB RID: 5867
			[NonSerialized]
			[FieldOffset(24)]
			public int resetHistoryFrames;

			// Token: 0x040016EC RID: 5868
			[NonSerialized]
			[FieldOffset(28)]
			public int jitterFrameCountOffset;
		}

		// Token: 0x020001C3 RID: 451
		public class TaaPassData : Object
		{
			// Token: 0x06002032 RID: 8242 RVA: 0x0007E08C File Offset: 0x0007C28C
			// Note: this type is marked as 'beforefieldinit'.
			static TaaPassData()
			{
				Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "TaaPassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr);
				TemporalAA.TaaPassData.NativeFieldInfoPtr_dstTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr, "dstTex");
				TemporalAA.TaaPassData.NativeFieldInfoPtr_srcColorTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr, "srcColorTex");
				TemporalAA.TaaPassData.NativeFieldInfoPtr_srcDepthTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr, "srcDepthTex");
				TemporalAA.TaaPassData.NativeFieldInfoPtr_srcMotionVectorTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr, "srcMotionVectorTex");
				TemporalAA.TaaPassData.NativeFieldInfoPtr_srcTaaAccumTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr, "srcTaaAccumTex");
				TemporalAA.TaaPassData.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr, "material");
				TemporalAA.TaaPassData.NativeFieldInfoPtr_passIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr, "passIndex");
				TemporalAA.TaaPassData.NativeFieldInfoPtr_taaFrameInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr, "taaFrameInfluence");
				TemporalAA.TaaPassData.NativeFieldInfoPtr_taaVarianceClampScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr, "taaVarianceClampScale");
				TemporalAA.TaaPassData.NativeFieldInfoPtr_taaFilterWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr, "taaFilterWeights");
				TemporalAA.TaaPassData.NativeFieldInfoPtr_taaLowPrecisionSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr, "taaLowPrecisionSource");
				TemporalAA.TaaPassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr, 100665459);
			}

			// Token: 0x06002033 RID: 8243 RVA: 0x0007E1A8 File Offset: 0x0007C3A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TaaPassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemporalAA.TaaPassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.TaaPassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002034 RID: 8244 RVA: 0x0001268F File Offset: 0x0001088F
			public TaaPassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B98 RID: 2968
			// (get) Token: 0x06002035 RID: 8245 RVA: 0x0007E1E4 File Offset: 0x0007C3E4
			// (set) Token: 0x06002036 RID: 8246 RVA: 0x00012698 File Offset: 0x00010898
			public unsafe TextureHandle dstTex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_dstTex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_dstTex)) = value;
				}
			}

			// Token: 0x17000B99 RID: 2969
			// (get) Token: 0x06002037 RID: 8247 RVA: 0x0007E20C File Offset: 0x0007C40C
			// (set) Token: 0x06002038 RID: 8248 RVA: 0x000126B3 File Offset: 0x000108B3
			public unsafe TextureHandle srcColorTex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_srcColorTex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_srcColorTex)) = value;
				}
			}

			// Token: 0x17000B9A RID: 2970
			// (get) Token: 0x06002039 RID: 8249 RVA: 0x0007E234 File Offset: 0x0007C434
			// (set) Token: 0x0600203A RID: 8250 RVA: 0x000126CE File Offset: 0x000108CE
			public unsafe TextureHandle srcDepthTex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_srcDepthTex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_srcDepthTex)) = value;
				}
			}

			// Token: 0x17000B9B RID: 2971
			// (get) Token: 0x0600203B RID: 8251 RVA: 0x0007E25C File Offset: 0x0007C45C
			// (set) Token: 0x0600203C RID: 8252 RVA: 0x000126E9 File Offset: 0x000108E9
			public unsafe TextureHandle srcMotionVectorTex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_srcMotionVectorTex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_srcMotionVectorTex)) = value;
				}
			}

			// Token: 0x17000B9C RID: 2972
			// (get) Token: 0x0600203D RID: 8253 RVA: 0x0007E284 File Offset: 0x0007C484
			// (set) Token: 0x0600203E RID: 8254 RVA: 0x00012704 File Offset: 0x00010904
			public unsafe TextureHandle srcTaaAccumTex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_srcTaaAccumTex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_srcTaaAccumTex)) = value;
				}
			}

			// Token: 0x17000B9D RID: 2973
			// (get) Token: 0x0600203F RID: 8255 RVA: 0x0007E2AC File Offset: 0x0007C4AC
			// (set) Token: 0x06002040 RID: 8256 RVA: 0x0001271F File Offset: 0x0001091F
			public unsafe Material material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B9E RID: 2974
			// (get) Token: 0x06002041 RID: 8257 RVA: 0x0007E2DC File Offset: 0x0007C4DC
			// (set) Token: 0x06002042 RID: 8258 RVA: 0x0001273E File Offset: 0x0001093E
			public unsafe int passIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_passIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_passIndex)) = value;
				}
			}

			// Token: 0x17000B9F RID: 2975
			// (get) Token: 0x06002043 RID: 8259 RVA: 0x0007E304 File Offset: 0x0007C504
			// (set) Token: 0x06002044 RID: 8260 RVA: 0x00012759 File Offset: 0x00010959
			public unsafe float taaFrameInfluence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_taaFrameInfluence);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_taaFrameInfluence)) = value;
				}
			}

			// Token: 0x17000BA0 RID: 2976
			// (get) Token: 0x06002045 RID: 8261 RVA: 0x0007E32C File Offset: 0x0007C52C
			// (set) Token: 0x06002046 RID: 8262 RVA: 0x00012774 File Offset: 0x00010974
			public unsafe float taaVarianceClampScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_taaVarianceClampScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_taaVarianceClampScale)) = value;
				}
			}

			// Token: 0x17000BA1 RID: 2977
			// (get) Token: 0x06002047 RID: 8263 RVA: 0x0007E354 File Offset: 0x0007C554
			// (set) Token: 0x06002048 RID: 8264 RVA: 0x0001278F File Offset: 0x0001098F
			public unsafe Il2CppStructArray<float> taaFilterWeights
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_taaFilterWeights);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_taaFilterWeights), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA2 RID: 2978
			// (get) Token: 0x06002049 RID: 8265 RVA: 0x0007E384 File Offset: 0x0007C584
			// (set) Token: 0x0600204A RID: 8266 RVA: 0x000127AE File Offset: 0x000109AE
			public unsafe bool taaLowPrecisionSource
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_taaLowPrecisionSource);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAA.TaaPassData.NativeFieldInfoPtr_taaLowPrecisionSource)) = value;
				}
			}

			// Token: 0x040016ED RID: 5869
			private static readonly IntPtr NativeFieldInfoPtr_dstTex;

			// Token: 0x040016EE RID: 5870
			private static readonly IntPtr NativeFieldInfoPtr_srcColorTex;

			// Token: 0x040016EF RID: 5871
			private static readonly IntPtr NativeFieldInfoPtr_srcDepthTex;

			// Token: 0x040016F0 RID: 5872
			private static readonly IntPtr NativeFieldInfoPtr_srcMotionVectorTex;

			// Token: 0x040016F1 RID: 5873
			private static readonly IntPtr NativeFieldInfoPtr_srcTaaAccumTex;

			// Token: 0x040016F2 RID: 5874
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x040016F3 RID: 5875
			private static readonly IntPtr NativeFieldInfoPtr_passIndex;

			// Token: 0x040016F4 RID: 5876
			private static readonly IntPtr NativeFieldInfoPtr_taaFrameInfluence;

			// Token: 0x040016F5 RID: 5877
			private static readonly IntPtr NativeFieldInfoPtr_taaVarianceClampScale;

			// Token: 0x040016F6 RID: 5878
			private static readonly IntPtr NativeFieldInfoPtr_taaFilterWeights;

			// Token: 0x040016F7 RID: 5879
			private static readonly IntPtr NativeFieldInfoPtr_taaLowPrecisionSource;

			// Token: 0x040016F8 RID: 5880
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001C4 RID: 452
		[ObfuscatedName("UnityEngine.Rendering.Universal.TemporalAA+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600204B RID: 8267 RVA: 0x0007E3AC File Offset: 0x0007C5AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TemporalAA.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemporalAA.__c>.NativeClassPtr);
				TemporalAA.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.__c>.NativeClassPtr, "<>9");
				TemporalAA.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.__c>.NativeClassPtr, "<>9__11_0");
				TemporalAA.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA.__c>.NativeClassPtr, "<>9__11_1");
				TemporalAA.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.__c>.NativeClassPtr, 100665461);
				TemporalAA.__c.NativeMethodInfoPtr__Render_b__11_0_Internal_Void_TaaPassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.__c>.NativeClassPtr, 100665462);
				TemporalAA.__c.NativeMethodInfoPtr__Render_b__11_1_Internal_Void_TaaPassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA.__c>.NativeClassPtr, 100665463);
			}

			// Token: 0x0600204C RID: 8268 RVA: 0x0007E450 File Offset: 0x0007C650
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemporalAA.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600204D RID: 8269 RVA: 0x0007E48C File Offset: 0x0007C68C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617625, XrefRangeEnd = 617665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__11_0(TemporalAA.TaaPassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.__c.NativeMethodInfoPtr__Render_b__11_0_Internal_Void_TaaPassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600204E RID: 8270 RVA: 0x0007E4E0 File Offset: 0x0007C6E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617665, XrefRangeEnd = 617675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__11_1(TemporalAA.TaaPassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAA.__c.NativeMethodInfoPtr__Render_b__11_1_Internal_Void_TaaPassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600204F RID: 8271 RVA: 0x000127C9 File Offset: 0x000109C9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BA3 RID: 2979
			// (get) Token: 0x06002050 RID: 8272 RVA: 0x0007E534 File Offset: 0x0007C734
			// (set) Token: 0x06002051 RID: 8273 RVA: 0x000127D2 File Offset: 0x000109D2
			public unsafe static TemporalAA.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TemporalAA.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TemporalAA.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TemporalAA.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA4 RID: 2980
			// (get) Token: 0x06002052 RID: 8274 RVA: 0x0007E55C File Offset: 0x0007C75C
			// (set) Token: 0x06002053 RID: 8275 RVA: 0x000127E4 File Offset: 0x000109E4
			public unsafe static RenderFunc<TemporalAA.TaaPassData> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TemporalAA.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<TemporalAA.TaaPassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TemporalAA.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA5 RID: 2981
			// (get) Token: 0x06002054 RID: 8276 RVA: 0x0007E584 File Offset: 0x0007C784
			// (set) Token: 0x06002055 RID: 8277 RVA: 0x000127F6 File Offset: 0x000109F6
			public unsafe static RenderFunc<TemporalAA.TaaPassData> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TemporalAA.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<TemporalAA.TaaPassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TemporalAA.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016F9 RID: 5881
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016FA RID: 5882
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x040016FB RID: 5883
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x040016FC RID: 5884
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016FD RID: 5885
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__11_0_Internal_Void_TaaPassData_RenderGraphContext_0;

			// Token: 0x040016FE RID: 5886
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__11_1_Internal_Void_TaaPassData_RenderGraphContext_0;
		}
	}
}
