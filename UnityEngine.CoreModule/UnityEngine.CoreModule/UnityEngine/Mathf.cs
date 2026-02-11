using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000100 RID: 256
	[StructLayout(2)]
	public struct Mathf
	{
		// Token: 0x06001498 RID: 5272 RVA: 0x00065DC4 File Offset: 0x00063FC4
		// Note: this type is marked as 'beforefieldinit'.
		static Mathf()
		{
			Il2CppClassPointerStore<Mathf>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Mathf");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mathf>.NativeClassPtr);
			Mathf.NativeFieldInfoPtr_Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mathf>.NativeClassPtr, "Epsilon");
			Mathf.NativeMethodInfoPtr_IsPowerOfTwo_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666197);
			Mathf.NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666198);
			Mathf.NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666199);
			Mathf.NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666200);
			Mathf.NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Public_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666201);
			Mathf.NativeMethodInfoPtr_FloatToHalf_Public_Static_UInt16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666202);
			Mathf.NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666203);
			Mathf.NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666204);
			Mathf.NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666205);
			Mathf.NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666206);
			Mathf.NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666207);
			Mathf.NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666208);
			Mathf.NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666209);
			Mathf.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666210);
			Mathf.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666211);
			Mathf.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666212);
			Mathf.NativeMethodInfoPtr_Min_Public_Static_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666213);
			Mathf.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666214);
			Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666215);
			Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666216);
			Mathf.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666217);
			Mathf.NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666218);
			Mathf.NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666219);
			Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666220);
			Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666221);
			Mathf.NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666222);
			Mathf.NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666223);
			Mathf.NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666224);
			Mathf.NativeMethodInfoPtr_Round_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666225);
			Mathf.NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666226);
			Mathf.NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666227);
			Mathf.NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666228);
			Mathf.NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666229);
			Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666230);
			Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666231);
			Mathf.NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666232);
			Mathf.NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666233);
			Mathf.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666234);
			Mathf.NativeMethodInfoPtr_MoveTowards_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666235);
			Mathf.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666236);
			Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666237);
			Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666238);
			Mathf.NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666239);
			Mathf.NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666240);
			Mathf.NativeMethodInfoPtr_ClampToFloat_Internal_Static_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666241);
			Mathf.NativeMethodInfoPtr_ClampToInt_Internal_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666242);
			Mathf.NativeMethodInfoPtr_ClampToUInt_Internal_Static_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666243);
			Mathf.NativeMethodInfoPtr_GetNumberOfDecimalsForMinimumDifference_Internal_Static_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666244);
			Mathf.NativeMethodInfoPtr_RoundBasedOnMinimumDifference_Internal_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666245);
			Mathf.NativeMethodInfoPtr_DiscardLeastSignificantDecimal_Internal_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666246);
			Mathf.NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Injected_Private_Static_Void_Single_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100666248);
			Mathf.ClosestPowerOfTwoDelegateField = IL2CPP.ResolveICall<Mathf.ClosestPowerOfTwoDelegate>("UnityEngine.Mathf::ClosestPowerOfTwo");
			Mathf.HalfToFloatDelegateField = IL2CPP.ResolveICall<Mathf.HalfToFloatDelegate>("UnityEngine.Mathf::HalfToFloat");
			Mathf.PerlinNoiseDelegateField = IL2CPP.ResolveICall<Mathf.PerlinNoiseDelegate>("UnityEngine.Mathf::PerlinNoise");
			Mathf.PerlinNoise1DDelegateField = IL2CPP.ResolveICall<Mathf.PerlinNoise1DDelegate>("UnityEngine.Mathf::PerlinNoise1D");
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00066240 File Offset: 0x00064440
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 659281, RefRangeEnd = 659307, XrefRangeStart = 659279, XrefRangeEnd = 659281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPowerOfTwo(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_IsPowerOfTwo_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00066280 File Offset: 0x00064480
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 659309, RefRangeEnd = 659375, XrefRangeStart = 659307, XrefRangeEnd = 659309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NextPowerOfTwo(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x000662C0 File Offset: 0x000644C0
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 659377, RefRangeEnd = 659438, XrefRangeStart = 659375, XrefRangeEnd = 659377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GammaToLinearSpace(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00066300 File Offset: 0x00064500
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 659440, RefRangeEnd = 659443, XrefRangeStart = 659438, XrefRangeEnd = 659440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float LinearToGammaSpace(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00066340 File Offset: 0x00064540
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 659445, RefRangeEnd = 659452, XrefRangeStart = 659443, XrefRangeEnd = 659445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color CorrelatedColorTemperatureToRGB(float kelvin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref kelvin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Public_Static_Color_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00066380 File Offset: 0x00064580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 659454, RefRangeEnd = 659456, XrefRangeStart = 659452, XrefRangeEnd = 659454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort FloatToHalf(float val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_FloatToHalf_Public_Static_UInt16_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x000663C0 File Offset: 0x000645C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659456, XrefRangeEnd = 659460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Sin(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00066400 File Offset: 0x00064600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659460, XrefRangeEnd = 659464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Cos(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00066440 File Offset: 0x00064640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659464, XrefRangeEnd = 659468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Tan(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00066480 File Offset: 0x00064680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659468, XrefRangeEnd = 659472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Acos(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x000664C0 File Offset: 0x000646C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659472, XrefRangeEnd = 659476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Atan(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00066500 File Offset: 0x00064700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659476, XrefRangeEnd = 659480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Atan2(float y, float x)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref y;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x0006654C File Offset: 0x0006474C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659480, XrefRangeEnd = 659483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Sqrt(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0006658C File Offset: 0x0006478C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659483, XrefRangeEnd = 659486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Abs(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x000665CC File Offset: 0x000647CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659486, XrefRangeEnd = 659489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Abs(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0006660C File Offset: 0x0006480C
		[CallerCount(0)]
		public unsafe static float Min(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00066658 File Offset: 0x00064858
		[CallerCount(0)]
		public unsafe static float Min([Optional] Il2CppStructArray<float> values)
		{
			if (values == null)
			{
				values = new Il2CppStructArray<float>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Min_Public_Static_Single_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x000666A8 File Offset: 0x000648A8
		[CallerCount(0)]
		public unsafe static int Min(int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x000666F4 File Offset: 0x000648F4
		[CallerCount(0)]
		public unsafe static float Max(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00066740 File Offset: 0x00064940
		[CallerCount(0)]
		public unsafe static float Max([Optional] Il2CppStructArray<float> values)
		{
			if (values == null)
			{
				values = new Il2CppStructArray<float>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00066790 File Offset: 0x00064990
		[CallerCount(0)]
		public unsafe static int Max(int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x000667DC File Offset: 0x000649DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659489, XrefRangeEnd = 659493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Pow(float f, float p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00066828 File Offset: 0x00064A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659493, XrefRangeEnd = 659497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Exp(float power)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref power;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00066868 File Offset: 0x00064A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659497, XrefRangeEnd = 659501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Log(float f, float p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x000668B4 File Offset: 0x00064AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659501, XrefRangeEnd = 659505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Log(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x000668F4 File Offset: 0x00064AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659505, XrefRangeEnd = 659509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Log10(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00066934 File Offset: 0x00064B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659509, XrefRangeEnd = 659513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Ceil(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00066974 File Offset: 0x00064B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659513, XrefRangeEnd = 659517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Floor(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x000669B4 File Offset: 0x00064BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659517, XrefRangeEnd = 659521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Round(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Round_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x000669F4 File Offset: 0x00064BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659521, XrefRangeEnd = 659525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CeilToInt(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00066A34 File Offset: 0x00064C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659525, XrefRangeEnd = 659529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FloorToInt(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00066A74 File Offset: 0x00064C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659529, XrefRangeEnd = 659533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RoundToInt(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00066AB4 File Offset: 0x00064CB4
		[CallerCount(0)]
		public unsafe static float Sign(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00066AF4 File Offset: 0x00064CF4
		[CallerCount(0)]
		public unsafe static float Clamp(float value, float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00066B50 File Offset: 0x00064D50
		[CallerCount(0)]
		public unsafe static int Clamp(int value, int min, int max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00066BAC File Offset: 0x00064DAC
		[CallerCount(0)]
		public unsafe static float Clamp01(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00066BEC File Offset: 0x00064DEC
		[CallerCount(0)]
		public unsafe static float Lerp(float a, float b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00066C48 File Offset: 0x00064E48
		[CallerCount(0)]
		public unsafe static float LerpUnclamped(float a, float b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00066CA4 File Offset: 0x00064EA4
		[CallerCount(0)]
		public unsafe static float MoveTowards(float current, float target, float maxDelta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_MoveTowards_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00066D00 File Offset: 0x00064F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659533, XrefRangeEnd = 659535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Approximately(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00066D4C File Offset: 0x00064F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659535, XrefRangeEnd = 659538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00066DB4 File Offset: 0x00064FB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 659540, RefRangeEnd = 659545, XrefRangeStart = 659538, XrefRangeEnd = 659540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00066E38 File Offset: 0x00065038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659545, XrefRangeEnd = 659546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Repeat(float t, float length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00066E84 File Offset: 0x00065084
		[CallerCount(0)]
		public unsafe static float InverseLerp(float a, float b, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00066EE0 File Offset: 0x000650E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 659546, RefRangeEnd = 659547, XrefRangeStart = 659546, XrefRangeEnd = 659546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ClampToFloat(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_ClampToFloat_Internal_Static_Single_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00066F20 File Offset: 0x00065120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 659547, RefRangeEnd = 659548, XrefRangeStart = 659547, XrefRangeEnd = 659547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ClampToInt(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_ClampToInt_Internal_Static_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00066F60 File Offset: 0x00065160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 659548, RefRangeEnd = 659549, XrefRangeStart = 659548, XrefRangeEnd = 659548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ClampToUInt(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_ClampToUInt_Internal_Static_UInt32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00066FA0 File Offset: 0x000651A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659549, XrefRangeEnd = 659555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNumberOfDecimalsForMinimumDifference(double minDifference)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minDifference;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_GetNumberOfDecimalsForMinimumDifference_Internal_Static_Int32_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00066FE0 File Offset: 0x000651E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 659567, RefRangeEnd = 659569, XrefRangeStart = 659555, XrefRangeEnd = 659567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valueToRound;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDifference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_RoundBasedOnMinimumDifference_Internal_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0006702C File Offset: 0x0006522C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 659581, RefRangeEnd = 659582, XrefRangeStart = 659569, XrefRangeEnd = 659581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double DiscardLeastSignificantDecimal(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_DiscardLeastSignificantDecimal_Internal_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0006706C File Offset: 0x0006526C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659582, XrefRangeEnd = 659584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref kelvin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Injected_Private_Static_Void_Single_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x000084A9 File Offset: 0x000066A9
		public static float Min(params float[] values)
		{
			return Mathf.Min(new Il2CppStructArray<float>(values));
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x000084B6 File Offset: 0x000066B6
		public static float Max(params float[] values)
		{
			return Mathf.Max(new Il2CppStructArray<float>(values));
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x000084C3 File Offset: 0x000066C3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mathf>.NativeClassPtr, ref this));
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x000670AC File Offset: 0x000652AC
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x000084D5 File Offset: 0x000066D5
		public unsafe static float Epsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Mathf.NativeFieldInfoPtr_Epsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Mathf.NativeFieldInfoPtr_Epsilon, (void*)(&value));
			}
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000084E3 File Offset: 0x000066E3
		public static int ClosestPowerOfTwo(int value)
		{
			return Mathf.ClosestPowerOfTwoDelegateField(value);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x000084F0 File Offset: 0x000066F0
		public static float HalfToFloat(ushort val)
		{
			return Mathf.HalfToFloatDelegateField(val);
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x000084FD File Offset: 0x000066FD
		public static float PerlinNoise(float x, float y)
		{
			return Mathf.PerlinNoiseDelegateField(x, y);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0000850B File Offset: 0x0000670B
		public static float PerlinNoise1D(float x)
		{
			return Mathf.PerlinNoise1DDelegateField(x);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x000670C8 File Offset: 0x000652C8
		public static float Asin(float f)
		{
			return (float)Math.Asin((double)f);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00008518 File Offset: 0x00006718
		public static int Min(Il2CppStructArray<int> values)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00008525 File Offset: 0x00006725
		public static int Min(params int[] values)
		{
			return Mathf.Min(new Il2CppStructArray<int>(values));
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00008532 File Offset: 0x00006732
		public static int Max(Il2CppStructArray<int> values)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0000853F File Offset: 0x0000673F
		public static int Max(params int[] values)
		{
			return Mathf.Max(new Il2CppStructArray<int>(values));
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x000670E4 File Offset: 0x000652E4
		public static float LerpAngle(float a, float b, float t)
		{
			float num = Mathf.Repeat(b - a, 360f);
			bool flag = num > 180f;
			if (flag)
			{
				num -= 360f;
			}
			return a + num * Mathf.Clamp01(t);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00067124 File Offset: 0x00065324
		public static float MoveTowardsAngle(float current, float target, float maxDelta)
		{
			float num = Mathf.DeltaAngle(current, target);
			bool flag = -maxDelta < num && num < maxDelta;
			float num2;
			if (flag)
			{
				num2 = target;
			}
			else
			{
				target = current + num;
				num2 = Mathf.MoveTowards(current, target, maxDelta);
			}
			return num2;
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00067160 File Offset: 0x00065360
		public static float SmoothStep(float from, float to, float t)
		{
			t = Mathf.Clamp01(t);
			t = -2f * t * t * t + 3f * t * t;
			return to * t + from * (1f - t);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x000671A0 File Offset: 0x000653A0
		public static float Gamma(float value, float absmax, float gamma)
		{
			bool flag = value < 0f;
			float num = Mathf.Abs(value);
			bool flag2 = num > absmax;
			float num2;
			if (flag2)
			{
				num2 = (flag ? (-num) : num);
			}
			else
			{
				float num3 = Mathf.Pow(num / absmax, gamma) * absmax;
				num2 = (flag ? (-num3) : num3);
			}
			return num2;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x000671EC File Offset: 0x000653EC
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00067210 File Offset: 0x00065410
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00067234 File Offset: 0x00065434
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime)
		{
			float deltaTime = Time.deltaTime;
			float positiveInfinity = float.PositiveInfinity;
			return Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, positiveInfinity, deltaTime);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00067260 File Offset: 0x00065460
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			target = current + Mathf.DeltaAngle(current, target);
			return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0006728C File Offset: 0x0006548C
		public static float PingPong(float t, float length)
		{
			t = Mathf.Repeat(t, length * 2f);
			return length - Mathf.Abs(t - length);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x000672B8 File Offset: 0x000654B8
		public static float DeltaAngle(float current, float target)
		{
			float num = Mathf.Repeat(target - current, 360f);
			bool flag = num > 180f;
			if (flag)
			{
				num -= 360f;
			}
			return num;
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x000672F0 File Offset: 0x000654F0
		public static bool LineIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
		{
			float num = p2.x - p1.x;
			float num2 = p2.y - p1.y;
			float num3 = p4.x - p3.x;
			float num4 = p4.y - p3.y;
			float num5 = num * num4 - num2 * num3;
			bool flag = num5 == 0f;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				float num6 = p3.x - p1.x;
				float num7 = p3.y - p1.y;
				float num8 = (num6 * num4 - num7 * num3) / num5;
				result.x = p1.x + num8 * num;
				result.y = p1.y + num8 * num2;
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000673AC File Offset: 0x000655AC
		public static bool LineSegmentIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
		{
			float num = p2.x - p1.x;
			float num2 = p2.y - p1.y;
			float num3 = p4.x - p3.x;
			float num4 = p4.y - p3.y;
			float num5 = num * num4 - num2 * num3;
			bool flag = num5 == 0f;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				float num6 = p3.x - p1.x;
				float num7 = p3.y - p1.y;
				float num8 = (num6 * num4 - num7 * num3) / num5;
				bool flag3 = num8 < 0f || num8 > 1f;
				if (flag3)
				{
					flag2 = false;
				}
				else
				{
					float num9 = (num6 * num2 - num7 * num) / num5;
					bool flag4 = num9 < 0f || num9 > 1f;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						result.x = p1.x + num8 * num;
						result.y = p1.y + num8 * num2;
						flag2 = true;
					}
				}
			}
			return flag2;
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0000854C File Offset: 0x0000674C
		public static long RandomToLong(Random r)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x000674BC File Offset: 0x000656BC
		public static float RoundToMultipleOf(float value, float roundingValue)
		{
			bool flag = roundingValue == 0f;
			float num;
			if (flag)
			{
				num = value;
			}
			else
			{
				num = Mathf.Round(value / roundingValue) * roundingValue;
			}
			return num;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x000674E8 File Offset: 0x000656E8
		public static float GetClosestPowerOfTen(float positiveNumber)
		{
			bool flag = positiveNumber <= 0f;
			float num;
			if (flag)
			{
				num = 1f;
			}
			else
			{
				num = Mathf.Pow(10f, (float)Mathf.RoundToInt(Mathf.Log10(positiveNumber)));
			}
			return num;
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00067528 File Offset: 0x00065728
		public static int GetNumberOfDecimalsForMinimumDifference(float minDifference)
		{
			return Mathf.Clamp(-Mathf.FloorToInt(Mathf.Log10(Mathf.Abs(minDifference))), 0, 15);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00067554 File Offset: 0x00065754
		public static float RoundBasedOnMinimumDifference(float valueToRound, float minDifference)
		{
			bool flag = minDifference == 0f;
			float num;
			if (flag)
			{
				num = Mathf.DiscardLeastSignificantDecimal(valueToRound);
			}
			else
			{
				num = (float)Math.Round((double)valueToRound, Mathf.GetNumberOfDecimalsForMinimumDifference(minDifference), MidpointRounding.AwayFromZero);
			}
			return num;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0006758C File Offset: 0x0006578C
		public static float DiscardLeastSignificantDecimal(float v)
		{
			int num = Mathf.Clamp((int)(5f - Mathf.Log10(Mathf.Abs(v))), 0, 15);
			return (float)Math.Round((double)v, num, MidpointRounding.AwayFromZero);
		}

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeFieldInfoPtr_Epsilon;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeMethodInfoPtr_IsPowerOfTwo_Public_Static_Boolean_Int32_0;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Single_Single_0;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Public_Static_Color_Single_0;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr_FloatToHalf_Public_Static_UInt16_Single_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Il2CppStructArray_1_Single_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Il2CppStructArray_1_Single_0;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Single_Single_0;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeMethodInfoPtr_Round_Public_Static_Single_Single_0;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeMethodInfoPtr_MoveTowards_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_0;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeMethodInfoPtr_ClampToFloat_Internal_Static_Single_Double_0;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeMethodInfoPtr_ClampToInt_Internal_Static_Int32_Int64_0;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeMethodInfoPtr_ClampToUInt_Internal_Static_UInt32_Int64_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberOfDecimalsForMinimumDifference_Internal_Static_Int32_Double_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr_RoundBasedOnMinimumDifference_Internal_Static_Double_Double_Double_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_DiscardLeastSignificantDecimal_Internal_Static_Double_Double_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Injected_Private_Static_Void_Single_byref_Color_0;

		// Token: 0x040013B5 RID: 5045
		public const float PI = 3.1415927f;

		// Token: 0x040013B6 RID: 5046
		public const float Infinity = float.PositiveInfinity;

		// Token: 0x040013B7 RID: 5047
		public const float NegativeInfinity = float.NegativeInfinity;

		// Token: 0x040013B8 RID: 5048
		public const float Deg2Rad = 0.017453292f;

		// Token: 0x040013B9 RID: 5049
		public const float Rad2Deg = 57.29578f;

		// Token: 0x040013BA RID: 5050
		public const int kMaxDecimals = 15;

		// Token: 0x040013BB RID: 5051
		private static readonly Mathf.ClosestPowerOfTwoDelegate ClosestPowerOfTwoDelegateField;

		// Token: 0x040013BC RID: 5052
		private static readonly Mathf.HalfToFloatDelegate HalfToFloatDelegateField;

		// Token: 0x040013BD RID: 5053
		private static readonly Mathf.PerlinNoiseDelegate PerlinNoiseDelegateField;

		// Token: 0x040013BE RID: 5054
		private static readonly Mathf.PerlinNoise1DDelegate PerlinNoise1DDelegateField;

		// Token: 0x020006F4 RID: 1780
		// (Invoke) Token: 0x060036C7 RID: 14023
		private delegate int ClosestPowerOfTwoDelegate(int value);

		// Token: 0x020006F5 RID: 1781
		// (Invoke) Token: 0x060036C9 RID: 14025
		private delegate float HalfToFloatDelegate(ushort val);

		// Token: 0x020006F6 RID: 1782
		// (Invoke) Token: 0x060036CB RID: 14027
		private delegate float PerlinNoiseDelegate(float x, float y);

		// Token: 0x020006F7 RID: 1783
		// (Invoke) Token: 0x060036CD RID: 14029
		private delegate float PerlinNoise1DDelegate(float x);
	}
}
