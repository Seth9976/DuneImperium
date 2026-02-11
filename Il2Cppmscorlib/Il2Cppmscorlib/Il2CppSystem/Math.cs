using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x020000C0 RID: 192
	public static class Math : Object
	{
		// Token: 0x06000C77 RID: 3191 RVA: 0x0005F5C0 File Offset: 0x0005D7C0
		// Note: this type is marked as 'beforefieldinit'.
		static Math()
		{
			Il2CppClassPointerStore<Math>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Math");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Math>.NativeClassPtr);
			Math.NativeFieldInfoPtr_doubleRoundLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Math>.NativeClassPtr, "doubleRoundLimit");
			Math.NativeFieldInfoPtr_roundPower10Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Math>.NativeClassPtr, "roundPower10Double");
			Math.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665467);
			Math.NativeMethodInfoPtr_Abs_Public_Static_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665468);
			Math.NativeMethodInfoPtr_Abs_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665469);
			Math.NativeMethodInfoPtr_ThrowAbsOverflow_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665470);
			Math.NativeMethodInfoPtr_DivRem_Public_Static_Int32_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665471);
			Math.NativeMethodInfoPtr_Ceiling_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665472);
			Math.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665473);
			Math.NativeMethodInfoPtr_Floor_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665474);
			Math.NativeMethodInfoPtr_Log_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665475);
			Math.NativeMethodInfoPtr_Max_Public_Static_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665476);
			Math.NativeMethodInfoPtr_Max_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665477);
			Math.NativeMethodInfoPtr_Max_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665478);
			Math.NativeMethodInfoPtr_Max_Public_Static_Int16_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665479);
			Math.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665480);
			Math.NativeMethodInfoPtr_Max_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665481);
			Math.NativeMethodInfoPtr_Max_Public_Static_SByte_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665482);
			Math.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665483);
			Math.NativeMethodInfoPtr_Max_Public_Static_UInt16_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665484);
			Math.NativeMethodInfoPtr_Max_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665485);
			Math.NativeMethodInfoPtr_Max_Public_Static_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665486);
			Math.NativeMethodInfoPtr_Min_Public_Static_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665487);
			Math.NativeMethodInfoPtr_Min_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665488);
			Math.NativeMethodInfoPtr_Min_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665489);
			Math.NativeMethodInfoPtr_Min_Public_Static_Int16_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665490);
			Math.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665491);
			Math.NativeMethodInfoPtr_Min_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665492);
			Math.NativeMethodInfoPtr_Min_Public_Static_SByte_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665493);
			Math.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665494);
			Math.NativeMethodInfoPtr_Min_Public_Static_UInt16_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665495);
			Math.NativeMethodInfoPtr_Min_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665496);
			Math.NativeMethodInfoPtr_Min_Public_Static_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665497);
			Math.NativeMethodInfoPtr_Round_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665498);
			Math.NativeMethodInfoPtr_Round_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665499);
			Math.NativeMethodInfoPtr_Round_Public_Static_Double_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665500);
			Math.NativeMethodInfoPtr_Round_Public_Static_Double_Double_MidpointRounding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665501);
			Math.NativeMethodInfoPtr_Round_Public_Static_Double_Double_Int32_MidpointRounding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665502);
			Math.NativeMethodInfoPtr_Sign_Public_Static_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665503);
			Math.NativeMethodInfoPtr_Sign_Public_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665504);
			Math.NativeMethodInfoPtr_Truncate_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665505);
			Math.NativeMethodInfoPtr_Truncate_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665506);
			Math.NativeMethodInfoPtr_ThrowMinMaxException_Private_Static_Void_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665507);
			Math.NativeMethodInfoPtr_Abs_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665508);
			Math.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665509);
			Math.NativeMethodInfoPtr_Acos_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665510);
			Math.NativeMethodInfoPtr_Asin_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665511);
			Math.NativeMethodInfoPtr_Atan_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665512);
			Math.NativeMethodInfoPtr_Atan2_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665513);
			Math.NativeMethodInfoPtr_Ceiling_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665514);
			Math.NativeMethodInfoPtr_Cos_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665515);
			Math.NativeMethodInfoPtr_Cosh_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665516);
			Math.NativeMethodInfoPtr_Exp_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665517);
			Math.NativeMethodInfoPtr_Floor_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665518);
			Math.NativeMethodInfoPtr_Log_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665519);
			Math.NativeMethodInfoPtr_Log10_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665520);
			Math.NativeMethodInfoPtr_Pow_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665521);
			Math.NativeMethodInfoPtr_Sin_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665522);
			Math.NativeMethodInfoPtr_Sinh_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665523);
			Math.NativeMethodInfoPtr_Sqrt_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665524);
			Math.NativeMethodInfoPtr_Tan_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665525);
			Math.NativeMethodInfoPtr_Tanh_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665526);
			Math.NativeMethodInfoPtr_ModF_Private_Static_Double_Double_ptr_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665527);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0005FADC File Offset: 0x0005DCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310227, XrefRangeEnd = 1310228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Abs(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0005FB1C File Offset: 0x0005DD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310228, XrefRangeEnd = 1310229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Abs(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Abs_Public_Static_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0005FB5C File Offset: 0x0005DD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310229, XrefRangeEnd = 1310233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Abs(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Abs_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0005FB9C File Offset: 0x0005DD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310233, XrefRangeEnd = 1310239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAbsOverflow()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_ThrowAbsOverflow_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0005FBC4 File Offset: 0x0005DDC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1310239, RefRangeEnd = 1310244, XrefRangeStart = 1310239, XrefRangeEnd = 1310239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DivRem(int a, int b, out int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_DivRem_Public_Static_Int32_Int32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0005FC20 File Offset: 0x0005DE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310244, XrefRangeEnd = 1310248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Ceiling(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Ceiling_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0005FC60 File Offset: 0x0005DE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310248, XrefRangeEnd = 1310254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0005FCBC File Offset: 0x0005DEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310254, XrefRangeEnd = 1310258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Floor(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Floor_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0005FCFC File Offset: 0x0005DEFC
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 1310259, RefRangeEnd = 1310294, XrefRangeStart = 1310258, XrefRangeEnd = 1310259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Log(double a, double newBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Log_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0005FD48 File Offset: 0x0005DF48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1310294, RefRangeEnd = 1310297, XrefRangeStart = 1310294, XrefRangeEnd = 1310294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Max(byte val1, byte val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Max_Public_Static_Byte_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0005FD94 File Offset: 0x0005DF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310297, XrefRangeEnd = 1310301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Max(Decimal val1, Decimal val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Max_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0005FDE0 File Offset: 0x0005DFE0
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 1310301, RefRangeEnd = 1310342, XrefRangeStart = 1310301, XrefRangeEnd = 1310301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Max(double val1, double val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Max_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0005FE2C File Offset: 0x0005E02C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1310342, RefRangeEnd = 1310347, XrefRangeStart = 1310342, XrefRangeEnd = 1310342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short Max(short val1, short val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Max_Public_Static_Int16_Int16_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0005FE78 File Offset: 0x0005E078
		[CallerCount(129)]
		[CachedScanResults(RefRangeStart = 1310347, RefRangeEnd = 1310476, XrefRangeStart = 1310347, XrefRangeEnd = 1310347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Max(int val1, int val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0005FEC4 File Offset: 0x0005E0C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1310476, RefRangeEnd = 1310480, XrefRangeStart = 1310476, XrefRangeEnd = 1310476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Max(long val1, long val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Max_Public_Static_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0005FF10 File Offset: 0x0005E110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1310480, RefRangeEnd = 1310482, XrefRangeStart = 1310480, XrefRangeEnd = 1310480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte Max(sbyte val1, sbyte val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Max_Public_Static_SByte_SByte_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x0005FF5C File Offset: 0x0005E15C
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 1310482, RefRangeEnd = 1310520, XrefRangeStart = 1310482, XrefRangeEnd = 1310482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Max(float val1, float val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0005FFA8 File Offset: 0x0005E1A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1310520, RefRangeEnd = 1310522, XrefRangeStart = 1310520, XrefRangeEnd = 1310520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort Max(ushort val1, ushort val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Max_Public_Static_UInt16_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0005FFF4 File Offset: 0x0005E1F4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1310522, RefRangeEnd = 1310533, XrefRangeStart = 1310522, XrefRangeEnd = 1310522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Max(uint val1, uint val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Max_Public_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00060040 File Offset: 0x0005E240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1310533, RefRangeEnd = 1310534, XrefRangeStart = 1310533, XrefRangeEnd = 1310533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Max(ulong val1, ulong val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Max_Public_Static_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0006008C File Offset: 0x0005E28C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1310534, RefRangeEnd = 1310536, XrefRangeStart = 1310534, XrefRangeEnd = 1310534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Min(byte val1, byte val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Min_Public_Static_Byte_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x000600D8 File Offset: 0x0005E2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310536, XrefRangeEnd = 1310540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Min(Decimal val1, Decimal val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Min_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00060124 File Offset: 0x0005E324
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1310540, RefRangeEnd = 1310554, XrefRangeStart = 1310540, XrefRangeEnd = 1310540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Min(double val1, double val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Min_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00060170 File Offset: 0x0005E370
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1310554, RefRangeEnd = 1310559, XrefRangeStart = 1310554, XrefRangeEnd = 1310554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short Min(short val1, short val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Min_Public_Static_Int16_Int16_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x000601BC File Offset: 0x0005E3BC
		[CallerCount(251)]
		[CachedScanResults(RefRangeStart = 1310559, RefRangeEnd = 1310810, XrefRangeStart = 1310559, XrefRangeEnd = 1310559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Min(int val1, int val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00060208 File Offset: 0x0005E408
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1310810, RefRangeEnd = 1310825, XrefRangeStart = 1310810, XrefRangeEnd = 1310810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Min(long val1, long val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Min_Public_Static_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00060254 File Offset: 0x0005E454
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1310825, RefRangeEnd = 1310827, XrefRangeStart = 1310825, XrefRangeEnd = 1310825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte Min(sbyte val1, sbyte val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Min_Public_Static_SByte_SByte_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x000602A0 File Offset: 0x0005E4A0
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 1310827, RefRangeEnd = 1310872, XrefRangeStart = 1310827, XrefRangeEnd = 1310827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Min(float val1, float val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x000602EC File Offset: 0x0005E4EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1310872, RefRangeEnd = 1310874, XrefRangeStart = 1310872, XrefRangeEnd = 1310872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort Min(ushort val1, ushort val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Min_Public_Static_UInt16_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00060338 File Offset: 0x0005E538
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1310874, RefRangeEnd = 1310882, XrefRangeStart = 1310874, XrefRangeEnd = 1310874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Min(uint val1, uint val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Min_Public_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00060384 File Offset: 0x0005E584
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1310882, RefRangeEnd = 1310891, XrefRangeStart = 1310882, XrefRangeEnd = 1310882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Min(ulong val1, ulong val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Min_Public_Static_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x000603D0 File Offset: 0x0005E5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310891, XrefRangeEnd = 1310895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Round(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Round_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00060410 File Offset: 0x0005E610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310895, XrefRangeEnd = 1310896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Round(double a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Round_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00060450 File Offset: 0x0005E650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310896, XrefRangeEnd = 1310900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Round(double value, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Round_Public_Static_Double_Double_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0006049C File Offset: 0x0005E69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310900, XrefRangeEnd = 1310904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Round(double value, MidpointRounding mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Round_Public_Static_Double_Double_MidpointRounding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000604E8 File Offset: 0x0005E6E8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1310920, RefRangeEnd = 1310928, XrefRangeStart = 1310904, XrefRangeEnd = 1310920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Round(double value, int digits, MidpointRounding mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Round_Public_Static_Double_Double_Int32_MidpointRounding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00060544 File Offset: 0x0005E744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1310928, RefRangeEnd = 1310929, XrefRangeStart = 1310928, XrefRangeEnd = 1310928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Sign(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Sign_Public_Static_Int32_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00060584 File Offset: 0x0005E784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1310929, RefRangeEnd = 1310931, XrefRangeStart = 1310929, XrefRangeEnd = 1310929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Sign(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Sign_Public_Static_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x000605C4 File Offset: 0x0005E7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310931, XrefRangeEnd = 1310935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Truncate(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Truncate_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00060604 File Offset: 0x0005E804
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 1310939, RefRangeEnd = 1310983, XrefRangeStart = 1310935, XrefRangeEnd = 1310939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Truncate(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Truncate_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00060644 File Offset: 0x0005E844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1310994, RefRangeEnd = 1310996, XrefRangeStart = 1310983, XrefRangeEnd = 1310994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowMinMaxException<T>(T min, T max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = min;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref min;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = max;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref max;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Math.MethodInfoStoreGeneric_ThrowMinMaxException_Private_Static_Void_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000606F8 File Offset: 0x0005E8F8
		[CallerCount(0)]
		public unsafe static double Abs(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Abs_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00060738 File Offset: 0x0005E938
		[CallerCount(0)]
		public unsafe static float Abs(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00060778 File Offset: 0x0005E978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310996, XrefRangeEnd = 1310997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Acos(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Acos_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x000607B8 File Offset: 0x0005E9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310997, XrefRangeEnd = 1310998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Asin(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Asin_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x000607F8 File Offset: 0x0005E9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310998, XrefRangeEnd = 1310999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Atan(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Atan_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00060838 File Offset: 0x0005EA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310999, XrefRangeEnd = 1311000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Atan2(double y, double x)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref y;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Atan2_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00060884 File Offset: 0x0005EA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311000, XrefRangeEnd = 1311001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Ceiling(double a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Ceiling_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000608C4 File Offset: 0x0005EAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311001, XrefRangeEnd = 1311002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Cos(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Cos_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00060904 File Offset: 0x0005EB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311002, XrefRangeEnd = 1311003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Cosh(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Cosh_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00060944 File Offset: 0x0005EB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311003, XrefRangeEnd = 1311004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Exp(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Exp_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00060984 File Offset: 0x0005EB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311004, XrefRangeEnd = 1311005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Floor(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Floor_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x000609C4 File Offset: 0x0005EBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311005, XrefRangeEnd = 1311006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Log(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Log_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00060A04 File Offset: 0x0005EC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311006, XrefRangeEnd = 1311007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Log10(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Log10_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00060A44 File Offset: 0x0005EC44
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 1311008, RefRangeEnd = 1311057, XrefRangeStart = 1311007, XrefRangeEnd = 1311008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Pow(double x, double y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Pow_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00060A90 File Offset: 0x0005EC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311057, XrefRangeEnd = 1311058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Sin(double a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Sin_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00060AD0 File Offset: 0x0005ECD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311058, XrefRangeEnd = 1311059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Sinh(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Sinh_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00060B10 File Offset: 0x0005ED10
		[CallerCount(0)]
		public unsafe static double Sqrt(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Sqrt_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00060B50 File Offset: 0x0005ED50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311059, XrefRangeEnd = 1311060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Tan(double a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Tan_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00060B90 File Offset: 0x0005ED90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311060, XrefRangeEnd = 1311061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Tanh(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Tanh_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00060BD0 File Offset: 0x0005EDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311061, XrefRangeEnd = 1311062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ModF(double x, double* intptr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = intptr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_ModF_Private_Static_Double_Double_ptr_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000051AC File Offset: 0x000033AC
		public Math(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00060C1C File Offset: 0x0005EE1C
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x000051B5 File Offset: 0x000033B5
		public unsafe static double doubleRoundLimit
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Math.NativeFieldInfoPtr_doubleRoundLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Math.NativeFieldInfoPtr_doubleRoundLimit, (void*)(&value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00060C38 File Offset: 0x0005EE38
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x000051C3 File Offset: 0x000033C3
		public unsafe static Il2CppStructArray<double> roundPower10Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Math.NativeFieldInfoPtr_roundPower10Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Math.NativeFieldInfoPtr_roundPower10Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeFieldInfoPtr_doubleRoundLimit;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr_roundPower10Double;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Int64_Int64_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Decimal_Decimal_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAbsOverflow_Private_Static_Void_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_DivRem_Public_Static_Int32_Int32_Int32_byref_Int32_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_Ceiling_Public_Static_Decimal_Decimal_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_Floor_Public_Static_Decimal_Decimal_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Double_Double_Double_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Byte_Byte_Byte_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Double_Double_Double_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int16_Int16_Int16_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int64_Int64_Int64_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_SByte_SByte_SByte_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_UInt16_UInt16_UInt16_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_UInt64_UInt64_UInt64_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Byte_Byte_Byte_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Double_Double_Double_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Int16_Int16_Int16_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Int64_Int64_Int64_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_SByte_SByte_SByte_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_UInt16_UInt16_UInt16_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_UInt64_UInt64_UInt64_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_Round_Public_Static_Decimal_Decimal_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_Round_Public_Static_Double_Double_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_Round_Public_Static_Double_Double_Int32_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_Round_Public_Static_Double_Double_MidpointRounding_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_Round_Public_Static_Double_Double_Int32_MidpointRounding_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_Sign_Public_Static_Int32_Double_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr_Sign_Public_Static_Int32_Int64_0;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_Truncate_Public_Static_Decimal_Decimal_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr_Truncate_Public_Static_Double_Double_0;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_ThrowMinMaxException_Private_Static_Void_T_T_0;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Double_Double_0;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_Acos_Public_Static_Double_Double_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_Asin_Public_Static_Double_Double_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_Atan_Public_Static_Double_Double_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_Atan2_Public_Static_Double_Double_Double_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_Ceiling_Public_Static_Double_Double_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_Cos_Public_Static_Double_Double_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_Cosh_Public_Static_Double_Double_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_Exp_Public_Static_Double_Double_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_Floor_Public_Static_Double_Double_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Double_Double_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_Log10_Public_Static_Double_Double_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_Static_Double_Double_Double_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_Sin_Public_Static_Double_Double_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_Sinh_Public_Static_Double_Double_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_Sqrt_Public_Static_Double_Double_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_Tan_Public_Static_Double_Double_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_Tanh_Public_Static_Double_Double_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_ModF_Private_Static_Double_Double_ptr_Double_0;

		// Token: 0x02000593 RID: 1427
		private sealed class MethodInfoStoreGeneric_ThrowMinMaxException_Private_Static_Void_T_T_0<T>
		{
			// Token: 0x04004713 RID: 18195
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Math.NativeMethodInfoPtr_ThrowMinMaxException_Private_Static_Void_T_T_0, Il2CppClassPointerStore<Math>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
