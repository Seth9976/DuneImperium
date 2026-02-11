using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000D2 RID: 210
	public static class ColorUtils : Object
	{
		// Token: 0x06000F41 RID: 3905 RVA: 0x000465DC File Offset: 0x000447DC
		// Note: this type is marked as 'beforefieldinit'.
		static ColorUtils()
		{
			Il2CppClassPointerStore<ColorUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ColorUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr);
			ColorUtils.NativeFieldInfoPtr_s_LightMeterCalibrationConstant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, "s_LightMeterCalibrationConstant");
			ColorUtils.NativeFieldInfoPtr_s_LensAttenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, "s_LensAttenuation");
			ColorUtils.NativeMethodInfoPtr_get_lensImperfectionExposureScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665533);
			ColorUtils.NativeMethodInfoPtr_StandardIlluminantY_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665534);
			ColorUtils.NativeMethodInfoPtr_CIExyToLMS_Public_Static_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665535);
			ColorUtils.NativeMethodInfoPtr_ColorBalanceToLMSCoeffs_Public_Static_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665536);
			ColorUtils.NativeMethodInfoPtr_PrepareShadowsMidtonesHighlights_Public_Static_ValueTuple_3_Vector4_Vector4_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665537);
			ColorUtils.NativeMethodInfoPtr_PrepareLiftGammaGain_Public_Static_ValueTuple_3_Vector4_Vector4_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665538);
			ColorUtils.NativeMethodInfoPtr_PrepareSplitToning_Public_Static_ValueTuple_2_Vector4_Vector4_byref_Vector4_byref_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665539);
			ColorUtils.NativeMethodInfoPtr_Luminance_Public_Static_Single_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665540);
			ColorUtils.NativeMethodInfoPtr_ComputeEV100_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665541);
			ColorUtils.NativeMethodInfoPtr_ConvertEV100ToExposure_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665542);
			ColorUtils.NativeMethodInfoPtr_ConvertExposureToEV100_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665543);
			ColorUtils.NativeMethodInfoPtr_ComputeEV100FromAvgLuminance_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665544);
			ColorUtils.NativeMethodInfoPtr_ComputeISO_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665545);
			ColorUtils.NativeMethodInfoPtr_ToHex_Public_Static_UInt32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665546);
			ColorUtils.NativeMethodInfoPtr_ToRGBA_Public_Static_Color_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100665547);
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x00046760 File Offset: 0x00044960
		public unsafe static float lensImperfectionExposureScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976048, XrefRangeEnd = 976052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_get_lensImperfectionExposureScale_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00046790 File Offset: 0x00044990
		[CallerCount(0)]
		public unsafe static float StandardIlluminantY(float x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_StandardIlluminantY_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x000467D0 File Offset: 0x000449D0
		[CallerCount(0)]
		public unsafe static Vector3 CIExyToLMS(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_CIExyToLMS_Public_Static_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0004681C File Offset: 0x00044A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976056, RefRangeEnd = 976057, XrefRangeStart = 976052, XrefRangeEnd = 976056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref temperature;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_ColorBalanceToLMSCoeffs_Public_Static_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00046868 File Offset: 0x00044A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976071, RefRangeEnd = 976072, XrefRangeStart = 976057, XrefRangeEnd = 976071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<Vector4, Vector4, Vector4> PrepareShadowsMidtonesHighlights([In] ref Vector4 inShadows, [In] ref Vector4 inMidtones, [In] ref Vector4 inHighlights)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &inShadows;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &inMidtones;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &inHighlights;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_PrepareShadowsMidtonesHighlights_Public_Static_ValueTuple_3_Vector4_Vector4_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<Vector4, Vector4, Vector4>(intPtr);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x000468BC File Offset: 0x00044ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976087, RefRangeEnd = 976088, XrefRangeStart = 976072, XrefRangeEnd = 976087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<Vector4, Vector4, Vector4> PrepareLiftGammaGain([In] ref Vector4 inLift, [In] ref Vector4 inGamma, [In] ref Vector4 inGain)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &inLift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &inGamma;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &inGain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_PrepareLiftGammaGain_Public_Static_ValueTuple_3_Vector4_Vector4_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<Vector4, Vector4, Vector4>(intPtr);
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00046910 File Offset: 0x00044B10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976091, RefRangeEnd = 976092, XrefRangeStart = 976088, XrefRangeEnd = 976091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<Vector4, Vector4> PrepareSplitToning([In] ref Vector4 inShadows, [In] ref Vector4 inHighlights, float balance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &inShadows;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &inHighlights;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref balance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_PrepareSplitToning_Public_Static_ValueTuple_2_Vector4_Vector4_byref_Vector4_byref_Vector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<Vector4, Vector4>(intPtr);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00046964 File Offset: 0x00044B64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976092, RefRangeEnd = 976093, XrefRangeStart = 976092, XrefRangeEnd = 976092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Luminance([In] ref Color color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_Luminance_Public_Static_Single_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x000469A4 File Offset: 0x00044BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976093, XrefRangeEnd = 976097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ComputeEV100(float aperture, float shutterSpeed, float ISO)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aperture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shutterSpeed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ISO;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_ComputeEV100_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00046A00 File Offset: 0x00044C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976097, XrefRangeEnd = 976105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ConvertEV100ToExposure(float EV100)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref EV100;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_ConvertEV100ToExposure_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00046A40 File Offset: 0x00044C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976105, XrefRangeEnd = 976116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ConvertExposureToEV100(float exposure)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exposure;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_ConvertExposureToEV100_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00046A80 File Offset: 0x00044C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976116, XrefRangeEnd = 976124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ComputeEV100FromAvgLuminance(float avgLuminance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref avgLuminance;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_ComputeEV100FromAvgLuminance_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00046AC0 File Offset: 0x00044CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976124, XrefRangeEnd = 976125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ComputeISO(float aperture, float shutterSpeed, float targetEV100)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aperture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shutterSpeed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetEV100;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_ComputeISO_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00046B1C File Offset: 0x00044D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976125, XrefRangeEnd = 976128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToHex(Color c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_ToHex_Public_Static_UInt32_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00046B5C File Offset: 0x00044D5C
		[CallerCount(0)]
		public unsafe static Color ToRGBA(uint hex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtils.NativeMethodInfoPtr_ToRGBA_Public_Static_Color_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0000857D File Offset: 0x0000677D
		public ColorUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x00046B9C File Offset: 0x00044D9C
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x00008586 File Offset: 0x00006786
		public unsafe static float s_LightMeterCalibrationConstant
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ColorUtils.NativeFieldInfoPtr_s_LightMeterCalibrationConstant, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorUtils.NativeFieldInfoPtr_s_LightMeterCalibrationConstant, (void*)(&value));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x00046BB8 File Offset: 0x00044DB8
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x00008594 File Offset: 0x00006794
		public unsafe static float s_LensAttenuation
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ColorUtils.NativeFieldInfoPtr_s_LensAttenuation, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorUtils.NativeFieldInfoPtr_s_LensAttenuation, (void*)(&value));
			}
		}

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeFieldInfoPtr_s_LightMeterCalibrationConstant;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeFieldInfoPtr_s_LensAttenuation;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_get_lensImperfectionExposureScale_Public_Static_get_Single_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr_StandardIlluminantY_Public_Static_Single_Single_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_CIExyToLMS_Public_Static_Vector3_Single_Single_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_ColorBalanceToLMSCoeffs_Public_Static_Vector3_Single_Single_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_PrepareShadowsMidtonesHighlights_Public_Static_ValueTuple_3_Vector4_Vector4_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_PrepareLiftGammaGain_Public_Static_ValueTuple_3_Vector4_Vector4_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_PrepareSplitToning_Public_Static_ValueTuple_2_Vector4_Vector4_byref_Vector4_byref_Vector4_Single_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_Luminance_Public_Static_Single_byref_Color_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr_ComputeEV100_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_ConvertEV100ToExposure_Public_Static_Single_Single_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_ConvertExposureToEV100_Public_Static_Single_Single_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_ComputeEV100FromAvgLuminance_Public_Static_Single_Single_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_ComputeISO_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr_ToHex_Public_Static_UInt32_Color_0;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr_ToRGBA_Public_Static_Color_UInt32_0;
	}
}
