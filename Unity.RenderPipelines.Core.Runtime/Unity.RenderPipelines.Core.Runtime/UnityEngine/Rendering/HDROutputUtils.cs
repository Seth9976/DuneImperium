using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000DA RID: 218
	public static class HDROutputUtils : Object
	{
		// Token: 0x06001016 RID: 4118 RVA: 0x0004A88C File Offset: 0x00048A8C
		// Note: this type is marked as 'beforefieldinit'.
		static HDROutputUtils()
		{
			Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "HDROutputUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr);
			HDROutputUtils.NativeMethodInfoPtr_GetColorSpaceForGamut_Public_Static_Boolean_ColorGamut_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100665687);
			HDROutputUtils.NativeMethodInfoPtr_GetColorEncodingForGamut_Public_Static_Boolean_ColorGamut_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100665688);
			HDROutputUtils.NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_Material_ColorGamut_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100665689);
			HDROutputUtils.NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_MaterialPropertyBlock_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100665690);
			HDROutputUtils.NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_Material_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100665691);
			HDROutputUtils.NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_ComputeShader_ColorGamut_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100665692);
			HDROutputUtils.NativeMethodInfoPtr_IsShaderVariantValid_Public_Static_Boolean_ShaderKeywordSet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100665693);
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0004A948 File Offset: 0x00048B48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 977355, RefRangeEnd = 977358, XrefRangeStart = 977338, XrefRangeEnd = 977355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetColorSpaceForGamut(ColorGamut gamut, out int colorspace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gamut;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &colorspace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputUtils.NativeMethodInfoPtr_GetColorSpaceForGamut_Public_Static_Boolean_ColorGamut_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0004A994 File Offset: 0x00048B94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 977363, RefRangeEnd = 977367, XrefRangeStart = 977358, XrefRangeEnd = 977363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetColorEncodingForGamut(ColorGamut gamut, out int encoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gamut;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &encoding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputUtils.NativeMethodInfoPtr_GetColorEncodingForGamut_Public_Static_Boolean_ColorGamut_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0004A9E0 File Offset: 0x00048BE0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 977406, RefRangeEnd = 977412, XrefRangeStart = 977367, XrefRangeEnd = 977406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureHDROutput(Material material, ColorGamut gamut, HDROutputUtils.Operation operations)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gamut;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputUtils.NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_Material_ColorGamut_Operation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0004AA34 File Offset: 0x00048C34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 977421, RefRangeEnd = 977422, XrefRangeStart = 977412, XrefRangeEnd = 977421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureHDROutput(MaterialPropertyBlock properties, ColorGamut gamut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gamut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputUtils.NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_MaterialPropertyBlock_ColorGamut_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0004AA78 File Offset: 0x00048C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 977452, RefRangeEnd = 977453, XrefRangeStart = 977422, XrefRangeEnd = 977452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureHDROutput(Material material, HDROutputUtils.Operation operations)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputUtils.NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_Material_Operation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0004AABC File Offset: 0x00048CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977453, XrefRangeEnd = 977492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureHDROutput(ComputeShader computeShader, ColorGamut gamut, HDROutputUtils.Operation operations)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gamut;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputUtils.NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_ComputeShader_ColorGamut_Operation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0004AB10 File Offset: 0x00048D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977492, XrefRangeEnd = 977509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsShaderVariantValid(ShaderKeywordSet shaderKeywordSet, bool isHDREnabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shaderKeywordSet;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHDREnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputUtils.NativeMethodInfoPtr_IsShaderVariantValid_Public_Static_Boolean_ShaderKeywordSet_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00008870 File Offset: 0x00006A70
		public HDROutputUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_GetColorSpaceForGamut_Public_Static_Boolean_ColorGamut_byref_Int32_0;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_GetColorEncodingForGamut_Public_Static_Boolean_ColorGamut_byref_Int32_0;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_Material_ColorGamut_Operation_0;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_MaterialPropertyBlock_ColorGamut_0;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_Material_Operation_0;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_ComputeShader_ColorGamut_Operation_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_IsShaderVariantValid_Public_Static_Boolean_ShaderKeywordSet_Boolean_0;

		// Token: 0x02000200 RID: 512
		[Flags]
		public enum Operation
		{
			// Token: 0x04001391 RID: 5009
			None = 0,
			// Token: 0x04001392 RID: 5010
			ColorConversion = 1,
			// Token: 0x04001393 RID: 5011
			ColorEncoding = 2
		}

		// Token: 0x02000201 RID: 513
		[StructLayout(2)]
		public struct HDRDisplayInformation
		{
			// Token: 0x06001AD6 RID: 6870 RVA: 0x0006E334 File Offset: 0x0006C534
			// Note: this type is marked as 'beforefieldinit'.
			static HDRDisplayInformation()
			{
				Il2CppClassPointerStore<HDROutputUtils.HDRDisplayInformation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, "HDRDisplayInformation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDROutputUtils.HDRDisplayInformation>.NativeClassPtr);
				HDROutputUtils.HDRDisplayInformation.NativeFieldInfoPtr_maxFullFrameToneMapLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.HDRDisplayInformation>.NativeClassPtr, "maxFullFrameToneMapLuminance");
				HDROutputUtils.HDRDisplayInformation.NativeFieldInfoPtr_maxToneMapLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.HDRDisplayInformation>.NativeClassPtr, "maxToneMapLuminance");
				HDROutputUtils.HDRDisplayInformation.NativeFieldInfoPtr_minToneMapLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.HDRDisplayInformation>.NativeClassPtr, "minToneMapLuminance");
				HDROutputUtils.HDRDisplayInformation.NativeFieldInfoPtr_paperWhiteNits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.HDRDisplayInformation>.NativeClassPtr, "paperWhiteNits");
				HDROutputUtils.HDRDisplayInformation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils.HDRDisplayInformation>.NativeClassPtr, 100665694);
			}

			// Token: 0x06001AD7 RID: 6871 RVA: 0x0006E3C4 File Offset: 0x0006C5C4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 977336, RefRangeEnd = 977338, XrefRangeStart = 977336, XrefRangeEnd = 977336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HDRDisplayInformation(int maxFullFrameToneMapLuminance, int maxToneMapLuminance, int minToneMapLuminance, float hdrPaperWhiteNits)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref maxFullFrameToneMapLuminance;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxToneMapLuminance;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minToneMapLuminance;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hdrPaperWhiteNits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputUtils.HDRDisplayInformation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AD8 RID: 6872 RVA: 0x0000D70C File Offset: 0x0000B90C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HDROutputUtils.HDRDisplayInformation>.NativeClassPtr, ref this));
			}

			// Token: 0x04001394 RID: 5012
			private static readonly IntPtr NativeFieldInfoPtr_maxFullFrameToneMapLuminance;

			// Token: 0x04001395 RID: 5013
			private static readonly IntPtr NativeFieldInfoPtr_maxToneMapLuminance;

			// Token: 0x04001396 RID: 5014
			private static readonly IntPtr NativeFieldInfoPtr_minToneMapLuminance;

			// Token: 0x04001397 RID: 5015
			private static readonly IntPtr NativeFieldInfoPtr_paperWhiteNits;

			// Token: 0x04001398 RID: 5016
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Single_0;

			// Token: 0x04001399 RID: 5017
			[FieldOffset(0)]
			public int maxFullFrameToneMapLuminance;

			// Token: 0x0400139A RID: 5018
			[FieldOffset(4)]
			public int maxToneMapLuminance;

			// Token: 0x0400139B RID: 5019
			[FieldOffset(8)]
			public int minToneMapLuminance;

			// Token: 0x0400139C RID: 5020
			[FieldOffset(12)]
			public float paperWhiteNits;
		}

		// Token: 0x02000202 RID: 514
		public static class ShaderKeywords : Object
		{
			// Token: 0x06001AD9 RID: 6873 RVA: 0x0006E420 File Offset: 0x0006C620
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderKeywords()
			{
				Il2CppClassPointerStore<HDROutputUtils.ShaderKeywords>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, "ShaderKeywords");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDROutputUtils.ShaderKeywords>.NativeClassPtr);
				HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.ShaderKeywords>.NativeClassPtr, "HDR_COLORSPACE_CONVERSION");
				HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDR_ENCODING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.ShaderKeywords>.NativeClassPtr, "HDR_ENCODING");
				HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION_AND_ENCODING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.ShaderKeywords>.NativeClassPtr, "HDR_COLORSPACE_CONVERSION_AND_ENCODING");
				HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDR_INPUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.ShaderKeywords>.NativeClassPtr, "HDR_INPUT");
				HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDRColorSpaceConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.ShaderKeywords>.NativeClassPtr, "HDRColorSpaceConversion");
				HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDREncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.ShaderKeywords>.NativeClassPtr, "HDREncoding");
				HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDRColorSpaceConversionAndEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.ShaderKeywords>.NativeClassPtr, "HDRColorSpaceConversionAndEncoding");
				HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDRInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.ShaderKeywords>.NativeClassPtr, "HDRInput");
			}

			// Token: 0x06001ADA RID: 6874 RVA: 0x0000D71E File Offset: 0x0000B91E
			public ShaderKeywords(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000794 RID: 1940
			// (get) Token: 0x06001ADB RID: 6875 RVA: 0x0006E4EC File Offset: 0x0006C6EC
			// (set) Token: 0x06001ADC RID: 6876 RVA: 0x0000D727 File Offset: 0x0000B927
			public unsafe static string HDR_COLORSPACE_CONVERSION
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000795 RID: 1941
			// (get) Token: 0x06001ADD RID: 6877 RVA: 0x0006E50C File Offset: 0x0006C70C
			// (set) Token: 0x06001ADE RID: 6878 RVA: 0x0000D739 File Offset: 0x0000B939
			public unsafe static string HDR_ENCODING
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDR_ENCODING, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDR_ENCODING, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x06001ADF RID: 6879 RVA: 0x0006E52C File Offset: 0x0006C72C
			// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x0000D74B File Offset: 0x0000B94B
			public unsafe static string HDR_COLORSPACE_CONVERSION_AND_ENCODING
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION_AND_ENCODING, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION_AND_ENCODING, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000797 RID: 1943
			// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x0006E54C File Offset: 0x0006C74C
			// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x0000D75D File Offset: 0x0000B95D
			public unsafe static string HDR_INPUT
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDR_INPUT, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDR_INPUT, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x0006E56C File Offset: 0x0006C76C
			// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x0000D76F File Offset: 0x0000B96F
			public unsafe static ShaderKeyword HDRColorSpaceConversion
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDRColorSpaceConversion, intPtr);
					return new ShaderKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDRColorSpaceConversion, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x0006E5A8 File Offset: 0x0006C7A8
			// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x0000D786 File Offset: 0x0000B986
			public unsafe static ShaderKeyword HDREncoding
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDREncoding, intPtr);
					return new ShaderKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDREncoding, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x0006E5E4 File Offset: 0x0006C7E4
			// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x0000D79D File Offset: 0x0000B99D
			public unsafe static ShaderKeyword HDRColorSpaceConversionAndEncoding
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDRColorSpaceConversionAndEncoding, intPtr);
					return new ShaderKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDRColorSpaceConversionAndEncoding, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x0006E620 File Offset: 0x0006C820
			// (set) Token: 0x06001AEA RID: 6890 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
			public unsafe static ShaderKeyword HDRInput
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDRInput, intPtr);
					return new ShaderKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDROutputUtils.ShaderKeywords.NativeFieldInfoPtr_HDRInput, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x0400139D RID: 5021
			private static readonly IntPtr NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION;

			// Token: 0x0400139E RID: 5022
			private static readonly IntPtr NativeFieldInfoPtr_HDR_ENCODING;

			// Token: 0x0400139F RID: 5023
			private static readonly IntPtr NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION_AND_ENCODING;

			// Token: 0x040013A0 RID: 5024
			private static readonly IntPtr NativeFieldInfoPtr_HDR_INPUT;

			// Token: 0x040013A1 RID: 5025
			private static readonly IntPtr NativeFieldInfoPtr_HDRColorSpaceConversion;

			// Token: 0x040013A2 RID: 5026
			private static readonly IntPtr NativeFieldInfoPtr_HDREncoding;

			// Token: 0x040013A3 RID: 5027
			private static readonly IntPtr NativeFieldInfoPtr_HDRColorSpaceConversionAndEncoding;

			// Token: 0x040013A4 RID: 5028
			private static readonly IntPtr NativeFieldInfoPtr_HDRInput;
		}

		// Token: 0x02000203 RID: 515
		public static class ShaderPropertyId : Object
		{
			// Token: 0x06001AEB RID: 6891 RVA: 0x0006E65C File Offset: 0x0006C85C
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderPropertyId()
			{
				Il2CppClassPointerStore<HDROutputUtils.ShaderPropertyId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, "ShaderPropertyId");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDROutputUtils.ShaderPropertyId>.NativeClassPtr);
				HDROutputUtils.ShaderPropertyId.NativeFieldInfoPtr_hdrColorSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.ShaderPropertyId>.NativeClassPtr, "hdrColorSpace");
				HDROutputUtils.ShaderPropertyId.NativeFieldInfoPtr_hdrEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputUtils.ShaderPropertyId>.NativeClassPtr, "hdrEncoding");
			}

			// Token: 0x06001AEC RID: 6892 RVA: 0x0000D7CB File Offset: 0x0000B9CB
			public ShaderPropertyId(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x06001AED RID: 6893 RVA: 0x0006E6B0 File Offset: 0x0006C8B0
			// (set) Token: 0x06001AEE RID: 6894 RVA: 0x0000D7D4 File Offset: 0x0000B9D4
			public unsafe static int hdrColorSpace
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(HDROutputUtils.ShaderPropertyId.NativeFieldInfoPtr_hdrColorSpace, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDROutputUtils.ShaderPropertyId.NativeFieldInfoPtr_hdrColorSpace, (void*)(&value));
				}
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x06001AEF RID: 6895 RVA: 0x0006E6CC File Offset: 0x0006C8CC
			// (set) Token: 0x06001AF0 RID: 6896 RVA: 0x0000D7E2 File Offset: 0x0000B9E2
			public unsafe static int hdrEncoding
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(HDROutputUtils.ShaderPropertyId.NativeFieldInfoPtr_hdrEncoding, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDROutputUtils.ShaderPropertyId.NativeFieldInfoPtr_hdrEncoding, (void*)(&value));
				}
			}

			// Token: 0x040013A5 RID: 5029
			private static readonly IntPtr NativeFieldInfoPtr_hdrColorSpace;

			// Token: 0x040013A6 RID: 5030
			private static readonly IntPtr NativeFieldInfoPtr_hdrEncoding;
		}
	}
}
