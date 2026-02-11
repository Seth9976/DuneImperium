using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000037 RID: 55
	[Serializable]
	[StructLayout(2)]
	public struct int4x3
	{
		// Token: 0x06001E31 RID: 7729 RVA: 0x0009CFF0 File Offset: 0x0009B1F0
		// Note: this type is marked as 'beforefieldinit'.
		static int4x3()
		{
			Il2CppClassPointerStore<int4x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "int4x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int4x3>.NativeClassPtr);
			int4x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4x3>.NativeClassPtr, "c0");
			int4x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4x3>.NativeClassPtr, "c1");
			int4x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4x3>.NativeClassPtr, "c2");
			int4x3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4x3>.NativeClassPtr, "zero");
			int4x3.NativeMethodInfoPtr__ctor_Public_Void_int4_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670807);
			int4x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670808);
			int4x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670809);
			int4x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670810);
			int4x3.NativeMethodInfoPtr__ctor_Public_Void_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670811);
			int4x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670812);
			int4x3.NativeMethodInfoPtr__ctor_Public_Void_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670813);
			int4x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670814);
			int4x3.NativeMethodInfoPtr__ctor_Public_Void_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670815);
			int4x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670816);
			int4x3.NativeMethodInfoPtr__ctor_Public_Void_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670817);
			int4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670818);
			int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670819);
			int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670820);
			int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670821);
			int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670822);
			int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670823);
			int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670824);
			int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670825);
			int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670826);
			int4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670827);
			int4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670828);
			int4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670829);
			int4x3.NativeMethodInfoPtr_op_Addition_Public_Static_int4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670830);
			int4x3.NativeMethodInfoPtr_op_Addition_Public_Static_int4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670831);
			int4x3.NativeMethodInfoPtr_op_Addition_Public_Static_int4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670832);
			int4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670833);
			int4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670834);
			int4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670835);
			int4x3.NativeMethodInfoPtr_op_Division_Public_Static_int4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670836);
			int4x3.NativeMethodInfoPtr_op_Division_Public_Static_int4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670837);
			int4x3.NativeMethodInfoPtr_op_Division_Public_Static_int4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670838);
			int4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670839);
			int4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670840);
			int4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670841);
			int4x3.NativeMethodInfoPtr_op_Increment_Public_Static_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670842);
			int4x3.NativeMethodInfoPtr_op_Decrement_Public_Static_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670843);
			int4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670844);
			int4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670845);
			int4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670846);
			int4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670847);
			int4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670848);
			int4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670849);
			int4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670850);
			int4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670851);
			int4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670852);
			int4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670853);
			int4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670854);
			int4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670855);
			int4x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670856);
			int4x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670857);
			int4x3.NativeMethodInfoPtr_op_LeftShift_Public_Static_int4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670858);
			int4x3.NativeMethodInfoPtr_op_RightShift_Public_Static_int4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670859);
			int4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670860);
			int4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670861);
			int4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670862);
			int4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670863);
			int4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670864);
			int4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670865);
			int4x3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670866);
			int4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670867);
			int4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670868);
			int4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670869);
			int4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670870);
			int4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670871);
			int4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670872);
			int4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x3_int4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670873);
			int4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x3_int4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670874);
			int4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x3_Int32_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670875);
			int4x3.NativeMethodInfoPtr_get_Item_Public_get_byref_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670876);
			int4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670877);
			int4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670878);
			int4x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670879);
			int4x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670880);
			int4x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x3>.NativeClassPtr, 100670881);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0009D64C File Offset: 0x0009B84C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556238, RefRangeEnd = 556240, XrefRangeStart = 556238, XrefRangeEnd = 556240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int4x3(int4 c0, int4 c1, int4 c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr__ctor_Public_Void_int4_int4_int4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0009D69C File Offset: 0x0009B89C
		[CallerCount(0)]
		public unsafe int4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m02;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m12;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m20;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m21;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m22;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m30;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m31;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m32;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x0009D76C File Offset: 0x0009B96C
		[CallerCount(0)]
		public unsafe int4x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0009D7A0 File Offset: 0x0009B9A0
		[CallerCount(0)]
		public unsafe int4x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0009D7D4 File Offset: 0x0009B9D4
		[CallerCount(0)]
		public unsafe int4x3(bool4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr__ctor_Public_Void_bool4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x0009D808 File Offset: 0x0009BA08
		[CallerCount(0)]
		public unsafe int4x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0009D83C File Offset: 0x0009BA3C
		[CallerCount(0)]
		public unsafe int4x3(uint4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr__ctor_Public_Void_uint4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0009D870 File Offset: 0x0009BA70
		[CallerCount(0)]
		public unsafe int4x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x0009D8A4 File Offset: 0x0009BAA4
		[CallerCount(0)]
		public unsafe int4x3(float4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr__ctor_Public_Void_float4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x0009D8D8 File Offset: 0x0009BAD8
		[CallerCount(0)]
		public unsafe int4x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x0009D90C File Offset: 0x0009BB0C
		[CallerCount(0)]
		public unsafe int4x3(double4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr__ctor_Public_Void_double4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x0009D940 File Offset: 0x0009BB40
		[CallerCount(0)]
		public unsafe static implicit operator int4x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0009D980 File Offset: 0x0009BB80
		[CallerCount(0)]
		public unsafe static explicit operator int4x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0009D9C0 File Offset: 0x0009BBC0
		[CallerCount(0)]
		public unsafe static explicit operator int4x3(bool4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_bool4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0009DA00 File Offset: 0x0009BC00
		[CallerCount(0)]
		public unsafe static explicit operator int4x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x0009DA40 File Offset: 0x0009BC40
		[CallerCount(0)]
		public unsafe static explicit operator int4x3(uint4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x0009DA80 File Offset: 0x0009BC80
		[CallerCount(0)]
		public unsafe static explicit operator int4x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x0009DAC0 File Offset: 0x0009BCC0
		[CallerCount(0)]
		public unsafe static explicit operator int4x3(float4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0009DB00 File Offset: 0x0009BD00
		[CallerCount(0)]
		public unsafe static explicit operator int4x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x0009DB40 File Offset: 0x0009BD40
		[CallerCount(0)]
		public unsafe static explicit operator int4x3(double4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0009DB80 File Offset: 0x0009BD80
		[CallerCount(0)]
		public unsafe static int4x3 operator *(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x0009DBCC File Offset: 0x0009BDCC
		[CallerCount(0)]
		public unsafe static int4x3 operator *(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x0009DC18 File Offset: 0x0009BE18
		[CallerCount(0)]
		public unsafe static int4x3 operator *(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x0009DC64 File Offset: 0x0009BE64
		[CallerCount(0)]
		public unsafe static int4x3 operator +(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Addition_Public_Static_int4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x0009DCB0 File Offset: 0x0009BEB0
		[CallerCount(0)]
		public unsafe static int4x3 operator +(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Addition_Public_Static_int4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x0009DCFC File Offset: 0x0009BEFC
		[CallerCount(0)]
		public unsafe static int4x3 operator +(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Addition_Public_Static_int4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x0009DD48 File Offset: 0x0009BF48
		[CallerCount(0)]
		public unsafe static int4x3 operator -(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x0009DD94 File Offset: 0x0009BF94
		[CallerCount(0)]
		public unsafe static int4x3 operator -(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x0009DDE0 File Offset: 0x0009BFE0
		[CallerCount(0)]
		public unsafe static int4x3 operator -(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x0009DE2C File Offset: 0x0009C02C
		[CallerCount(0)]
		public unsafe static int4x3 operator /(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Division_Public_Static_int4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x0009DE78 File Offset: 0x0009C078
		[CallerCount(0)]
		public unsafe static int4x3 operator /(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Division_Public_Static_int4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x0009DEC4 File Offset: 0x0009C0C4
		[CallerCount(0)]
		public unsafe static int4x3 operator /(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Division_Public_Static_int4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x0009DF10 File Offset: 0x0009C110
		[CallerCount(0)]
		public unsafe static int4x3 operator %(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0009DF5C File Offset: 0x0009C15C
		[CallerCount(0)]
		public unsafe static int4x3 operator %(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x0009DFA8 File Offset: 0x0009C1A8
		[CallerCount(0)]
		public unsafe static int4x3 operator %(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x0009DFF4 File Offset: 0x0009C1F4
		[CallerCount(0)]
		public unsafe static int4x3 operator ++(int4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Increment_Public_Static_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x0009E034 File Offset: 0x0009C234
		[CallerCount(0)]
		public unsafe static int4x3 operator --(int4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Decrement_Public_Static_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x0009E074 File Offset: 0x0009C274
		[CallerCount(0)]
		public unsafe static bool4x3 operator <(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0009E0C0 File Offset: 0x0009C2C0
		[CallerCount(0)]
		public unsafe static bool4x3 operator <(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0009E10C File Offset: 0x0009C30C
		[CallerCount(0)]
		public unsafe static bool4x3 operator <(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x0009E158 File Offset: 0x0009C358
		[CallerCount(0)]
		public unsafe static bool4x3 operator <=(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x0009E1A4 File Offset: 0x0009C3A4
		[CallerCount(0)]
		public unsafe static bool4x3 operator <=(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x0009E1F0 File Offset: 0x0009C3F0
		[CallerCount(0)]
		public unsafe static bool4x3 operator <=(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x0009E23C File Offset: 0x0009C43C
		[CallerCount(0)]
		public unsafe static bool4x3 operator >(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0009E288 File Offset: 0x0009C488
		[CallerCount(0)]
		public unsafe static bool4x3 operator >(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x0009E2D4 File Offset: 0x0009C4D4
		[CallerCount(0)]
		public unsafe static bool4x3 operator >(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x0009E320 File Offset: 0x0009C520
		[CallerCount(0)]
		public unsafe static bool4x3 operator >=(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x0009E36C File Offset: 0x0009C56C
		[CallerCount(0)]
		public unsafe static bool4x3 operator >=(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x0009E3B8 File Offset: 0x0009C5B8
		[CallerCount(0)]
		public unsafe static bool4x3 operator >=(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x0009E404 File Offset: 0x0009C604
		[CallerCount(0)]
		public unsafe static int4x3 operator -(int4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x0009E444 File Offset: 0x0009C644
		[CallerCount(0)]
		public unsafe static int4x3 operator +(int4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0009E484 File Offset: 0x0009C684
		[CallerCount(0)]
		public unsafe static int4x3 operator <<(int4x3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_LeftShift_Public_Static_int4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x0009E4D0 File Offset: 0x0009C6D0
		[CallerCount(0)]
		public unsafe static int4x3 operator >>(int4x3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_RightShift_Public_Static_int4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x0009E51C File Offset: 0x0009C71C
		[CallerCount(0)]
		public unsafe static bool4x3 operator ==(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x0009E568 File Offset: 0x0009C768
		[CallerCount(0)]
		public unsafe static bool4x3 operator ==(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x0009E5B4 File Offset: 0x0009C7B4
		[CallerCount(0)]
		public unsafe static bool4x3 operator ==(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0009E600 File Offset: 0x0009C800
		[CallerCount(0)]
		public unsafe static bool4x3 operator !=(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0009E64C File Offset: 0x0009C84C
		[CallerCount(0)]
		public unsafe static bool4x3 operator !=(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0009E698 File Offset: 0x0009C898
		[CallerCount(0)]
		public unsafe static bool4x3 operator !=(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0009E6E4 File Offset: 0x0009C8E4
		[CallerCount(0)]
		public unsafe static int4x3 operator ~(int4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0009E724 File Offset: 0x0009C924
		[CallerCount(0)]
		public unsafe static int4x3 operator &(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0009E770 File Offset: 0x0009C970
		[CallerCount(0)]
		public unsafe static int4x3 operator &(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0009E7BC File Offset: 0x0009C9BC
		[CallerCount(0)]
		public unsafe static int4x3 operator &(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x0009E808 File Offset: 0x0009CA08
		[CallerCount(0)]
		public unsafe static int4x3 operator |(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x0009E854 File Offset: 0x0009CA54
		[CallerCount(0)]
		public unsafe static int4x3 operator |(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0009E8A0 File Offset: 0x0009CAA0
		[CallerCount(0)]
		public unsafe static int4x3 operator |(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x0009E8EC File Offset: 0x0009CAEC
		[CallerCount(0)]
		public unsafe static int4x3 operator ^(int4x3 lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x3_int4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0009E938 File Offset: 0x0009CB38
		[CallerCount(0)]
		public unsafe static int4x3 operator ^(int4x3 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x3_int4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0009E984 File Offset: 0x0009CB84
		[CallerCount(0)]
		public unsafe static int4x3 operator ^(int lhs, int4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x3_Int32_int4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170009E0 RID: 2528
		public unsafe ref int4 this[int index]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 634855, RefRangeEnd = 634861, XrefRangeStart = 634855, XrefRangeEnd = 634861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_get_Item_Public_get_byref_int4_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0009EA04 File Offset: 0x0009CC04
		[CallerCount(0)]
		public unsafe bool Equals(int4x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0009EA44 File Offset: 0x0009CC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639891, XrefRangeEnd = 639894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x0009EA88 File Offset: 0x0009CC88
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x0009EAB8 File Offset: 0x0009CCB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639894, XrefRangeEnd = 639949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x0009EAE4 File Offset: 0x0009CCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639949, XrefRangeEnd = 640017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x000027E0 File Offset: 0x000009E0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<int4x3>.NativeClassPtr, ref this));
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x0009EB34 File Offset: 0x0009CD34
		// (set) Token: 0x06001E7F RID: 7807 RVA: 0x000027F2 File Offset: 0x000009F2
		public unsafe static int4x3 zero
		{
			get
			{
				int4x3 int4x;
				IL2CPP.il2cpp_field_static_get_value(int4x3.NativeFieldInfoPtr_zero, (void*)(&int4x));
				return int4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int4x3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001EAD RID: 7853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4_int4_int4_0;

		// Token: 0x04001EAE RID: 7854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001EAF RID: 7855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001EB0 RID: 7856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001EB1 RID: 7857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4x3_0;

		// Token: 0x04001EB2 RID: 7858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4x3_0;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4x3_0;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001EB7 RID: 7863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4x3_0;

		// Token: 0x04001EB8 RID: 7864
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int4x3_Int32_0;

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_Boolean_0;

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_bool4x3_0;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_UInt32_0;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_uint4x3_0;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_Single_0;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_float4x3_0;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_Double_0;

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x3_double4x3_0;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int4x3_int4x3_int4x3_0;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int4x3_int4x3_Int32_0;

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int4x3_Int32_int4x3_0;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int4x3_int4x3_int4x3_0;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int4x3_int4x3_Int32_0;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int4x3_Int32_int4x3_0;

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x3_int4x3_int4x3_0;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x3_int4x3_Int32_0;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x3_Int32_int4x3_0;

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int4x3_int4x3_int4x3_0;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int4x3_int4x3_Int32_0;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int4x3_Int32_int4x3_0;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int4x3_int4x3_int4x3_0;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int4x3_int4x3_Int32_0;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int4x3_Int32_int4x3_0;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_int4x3_int4x3_0;

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_int4x3_int4x3_0;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_int4x3_int4x3_0;

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_int4x3_Int32_0;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_Int32_int4x3_0;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_int4x3_int4x3_0;

		// Token: 0x04001ED6 RID: 7894
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_int4x3_Int32_0;

		// Token: 0x04001ED7 RID: 7895
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_Int32_int4x3_0;

		// Token: 0x04001ED8 RID: 7896
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_int4x3_int4x3_0;

		// Token: 0x04001ED9 RID: 7897
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_int4x3_Int32_0;

		// Token: 0x04001EDA RID: 7898
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_Int32_int4x3_0;

		// Token: 0x04001EDB RID: 7899
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_int4x3_int4x3_0;

		// Token: 0x04001EDC RID: 7900
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_int4x3_Int32_0;

		// Token: 0x04001EDD RID: 7901
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_Int32_int4x3_0;

		// Token: 0x04001EDE RID: 7902
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int4x3_int4x3_0;

		// Token: 0x04001EDF RID: 7903
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int4x3_int4x3_0;

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_int4x3_int4x3_Int32_0;

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_int4x3_int4x3_Int32_0;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_int4x3_int4x3_0;

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_int4x3_Int32_0;

		// Token: 0x04001EE4 RID: 7908
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_Int32_int4x3_0;

		// Token: 0x04001EE5 RID: 7909
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_int4x3_int4x3_0;

		// Token: 0x04001EE6 RID: 7910
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_int4x3_Int32_0;

		// Token: 0x04001EE7 RID: 7911
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_Int32_int4x3_0;

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_int4x3_int4x3_0;

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x3_int4x3_int4x3_0;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x3_int4x3_Int32_0;

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x3_Int32_int4x3_0;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x3_int4x3_int4x3_0;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x3_int4x3_Int32_0;

		// Token: 0x04001EEE RID: 7918
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x3_Int32_int4x3_0;

		// Token: 0x04001EEF RID: 7919
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x3_int4x3_int4x3_0;

		// Token: 0x04001EF0 RID: 7920
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x3_int4x3_Int32_0;

		// Token: 0x04001EF1 RID: 7921
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x3_Int32_int4x3_0;

		// Token: 0x04001EF2 RID: 7922
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_int4_Int32_0;

		// Token: 0x04001EF3 RID: 7923
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int4x3_0;

		// Token: 0x04001EF4 RID: 7924
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001EF5 RID: 7925
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001EF6 RID: 7926
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001EF7 RID: 7927
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001EF8 RID: 7928
		[FieldOffset(0)]
		public int4 c0;

		// Token: 0x04001EF9 RID: 7929
		[FieldOffset(16)]
		public int4 c1;

		// Token: 0x04001EFA RID: 7930
		[FieldOffset(32)]
		public int4 c2;
	}
}
