using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	[StructLayout(2)]
	public struct double2x4
	{
		// Token: 0x06000C12 RID: 3090 RVA: 0x00044BB0 File Offset: 0x00042DB0
		// Note: this type is marked as 'beforefieldinit'.
		static double2x4()
		{
			Il2CppClassPointerStore<double2x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "double2x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<double2x4>.NativeClassPtr);
			double2x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2x4>.NativeClassPtr, "c0");
			double2x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2x4>.NativeClassPtr, "c1");
			double2x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2x4>.NativeClassPtr, "c2");
			double2x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2x4>.NativeClassPtr, "c3");
			double2x4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2x4>.NativeClassPtr, "zero");
			double2x4.NativeMethodInfoPtr__ctor_Public_Void_double2_double2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666303);
			double2x4.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666304);
			double2x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666305);
			double2x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666306);
			double2x4.NativeMethodInfoPtr__ctor_Public_Void_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666307);
			double2x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666308);
			double2x4.NativeMethodInfoPtr__ctor_Public_Void_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666309);
			double2x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666310);
			double2x4.NativeMethodInfoPtr__ctor_Public_Void_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666311);
			double2x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666312);
			double2x4.NativeMethodInfoPtr__ctor_Public_Void_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666313);
			double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666314);
			double2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_double2x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666315);
			double2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_double2x4_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666316);
			double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666317);
			double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666318);
			double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666319);
			double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666320);
			double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666321);
			double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666322);
			double2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double2x4_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666323);
			double2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double2x4_double2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666324);
			double2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double2x4_Double_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666325);
			double2x4.NativeMethodInfoPtr_op_Addition_Public_Static_double2x4_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666326);
			double2x4.NativeMethodInfoPtr_op_Addition_Public_Static_double2x4_double2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666327);
			double2x4.NativeMethodInfoPtr_op_Addition_Public_Static_double2x4_Double_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666328);
			double2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x4_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666329);
			double2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x4_double2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666330);
			double2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x4_Double_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666331);
			double2x4.NativeMethodInfoPtr_op_Division_Public_Static_double2x4_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666332);
			double2x4.NativeMethodInfoPtr_op_Division_Public_Static_double2x4_double2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666333);
			double2x4.NativeMethodInfoPtr_op_Division_Public_Static_double2x4_Double_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666334);
			double2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double2x4_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666335);
			double2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double2x4_double2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666336);
			double2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double2x4_Double_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666337);
			double2x4.NativeMethodInfoPtr_op_Increment_Public_Static_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666338);
			double2x4.NativeMethodInfoPtr_op_Decrement_Public_Static_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666339);
			double2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666340);
			double2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_double2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666341);
			double2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_Double_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666342);
			double2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666343);
			double2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_double2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666344);
			double2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_Double_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666345);
			double2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666346);
			double2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_double2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666347);
			double2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_Double_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666348);
			double2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666349);
			double2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_double2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666350);
			double2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_Double_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666351);
			double2x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666352);
			double2x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666353);
			double2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666354);
			double2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_double2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666355);
			double2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_Double_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666356);
			double2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_double2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666357);
			double2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_double2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666358);
			double2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_Double_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666359);
			double2x4.NativeMethodInfoPtr_get_Item_Public_get_byref_double2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666360);
			double2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666361);
			double2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666362);
			double2x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666363);
			double2x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666364);
			double2x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x4>.NativeClassPtr, 100666365);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00045130 File Offset: 0x00043330
		[CallerCount(0)]
		public unsafe double2x4(double2 c0, double2 c1, double2 c2, double2 c3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr__ctor_Public_Void_double2_double2_double2_double2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0004518C File Offset: 0x0004338C
		[CallerCount(0)]
		public unsafe double2x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m02;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m03;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m12;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m13;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00045220 File Offset: 0x00043420
		[CallerCount(0)]
		public unsafe double2x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00045254 File Offset: 0x00043454
		[CallerCount(0)]
		public unsafe double2x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00045288 File Offset: 0x00043488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 635057, RefRangeEnd = 635058, XrefRangeStart = 635050, XrefRangeEnd = 635057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double2x4(bool2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr__ctor_Public_Void_bool2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000452BC File Offset: 0x000434BC
		[CallerCount(0)]
		public unsafe double2x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000452F0 File Offset: 0x000434F0
		[CallerCount(0)]
		public unsafe double2x4(int2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr__ctor_Public_Void_int2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00045324 File Offset: 0x00043524
		[CallerCount(0)]
		public unsafe double2x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00045358 File Offset: 0x00043558
		[CallerCount(0)]
		public unsafe double2x4(uint2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr__ctor_Public_Void_uint2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0004538C File Offset: 0x0004358C
		[CallerCount(0)]
		public unsafe double2x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000453C0 File Offset: 0x000435C0
		[CallerCount(0)]
		public unsafe double2x4(float2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr__ctor_Public_Void_float2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000453F4 File Offset: 0x000435F4
		[CallerCount(0)]
		public unsafe static implicit operator double2x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00045434 File Offset: 0x00043634
		[CallerCount(0)]
		public unsafe static explicit operator double2x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_double2x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00045474 File Offset: 0x00043674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635058, XrefRangeEnd = 635059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double2x4(bool2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_double2x4_bool2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x000454B4 File Offset: 0x000436B4
		[CallerCount(0)]
		public unsafe static implicit operator double2x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000454F4 File Offset: 0x000436F4
		[CallerCount(0)]
		public unsafe static implicit operator double2x4(int2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00045534 File Offset: 0x00043734
		[CallerCount(0)]
		public unsafe static implicit operator double2x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00045574 File Offset: 0x00043774
		[CallerCount(0)]
		public unsafe static implicit operator double2x4(uint2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000455B4 File Offset: 0x000437B4
		[CallerCount(0)]
		public unsafe static implicit operator double2x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x000455F4 File Offset: 0x000437F4
		[CallerCount(0)]
		public unsafe static implicit operator double2x4(float2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00045634 File Offset: 0x00043834
		[CallerCount(0)]
		public unsafe static double2x4 operator *(double2x4 lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double2x4_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00045680 File Offset: 0x00043880
		[CallerCount(0)]
		public unsafe static double2x4 operator *(double2x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double2x4_double2x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x000456CC File Offset: 0x000438CC
		[CallerCount(0)]
		public unsafe static double2x4 operator *(double lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double2x4_Double_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00045718 File Offset: 0x00043918
		[CallerCount(0)]
		public unsafe static double2x4 operator +(double2x4 lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Addition_Public_Static_double2x4_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00045764 File Offset: 0x00043964
		[CallerCount(0)]
		public unsafe static double2x4 operator +(double2x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Addition_Public_Static_double2x4_double2x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x000457B0 File Offset: 0x000439B0
		[CallerCount(0)]
		public unsafe static double2x4 operator +(double lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Addition_Public_Static_double2x4_Double_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x000457FC File Offset: 0x000439FC
		[CallerCount(0)]
		public unsafe static double2x4 operator -(double2x4 lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x4_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00045848 File Offset: 0x00043A48
		[CallerCount(0)]
		public unsafe static double2x4 operator -(double2x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x4_double2x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00045894 File Offset: 0x00043A94
		[CallerCount(0)]
		public unsafe static double2x4 operator -(double lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x4_Double_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x000458E0 File Offset: 0x00043AE0
		[CallerCount(0)]
		public unsafe static double2x4 operator /(double2x4 lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Division_Public_Static_double2x4_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0004592C File Offset: 0x00043B2C
		[CallerCount(0)]
		public unsafe static double2x4 operator /(double2x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Division_Public_Static_double2x4_double2x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00045978 File Offset: 0x00043B78
		[CallerCount(0)]
		public unsafe static double2x4 operator /(double lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Division_Public_Static_double2x4_Double_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000459C4 File Offset: 0x00043BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635059, XrefRangeEnd = 635067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double2x4 operator %(double2x4 lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double2x4_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00045A10 File Offset: 0x00043C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635067, XrefRangeEnd = 635075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double2x4 operator %(double2x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double2x4_double2x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00045A5C File Offset: 0x00043C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635075, XrefRangeEnd = 635083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double2x4 operator %(double lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double2x4_Double_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00045AA8 File Offset: 0x00043CA8
		[CallerCount(0)]
		public unsafe static double2x4 operator ++(double2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Increment_Public_Static_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00045AE8 File Offset: 0x00043CE8
		[CallerCount(0)]
		public unsafe static double2x4 operator --(double2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Decrement_Public_Static_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00045B28 File Offset: 0x00043D28
		[CallerCount(0)]
		public unsafe static bool2x4 operator <(double2x4 lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00045B74 File Offset: 0x00043D74
		[CallerCount(0)]
		public unsafe static bool2x4 operator <(double2x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_double2x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00045BC0 File Offset: 0x00043DC0
		[CallerCount(0)]
		public unsafe static bool2x4 operator <(double lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_Double_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00045C0C File Offset: 0x00043E0C
		[CallerCount(0)]
		public unsafe static bool2x4 operator <=(double2x4 lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00045C58 File Offset: 0x00043E58
		[CallerCount(0)]
		public unsafe static bool2x4 operator <=(double2x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_double2x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00045CA4 File Offset: 0x00043EA4
		[CallerCount(0)]
		public unsafe static bool2x4 operator <=(double lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_Double_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00045CF0 File Offset: 0x00043EF0
		[CallerCount(0)]
		public unsafe static bool2x4 operator >(double2x4 lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00045D3C File Offset: 0x00043F3C
		[CallerCount(0)]
		public unsafe static bool2x4 operator >(double2x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_double2x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00045D88 File Offset: 0x00043F88
		[CallerCount(0)]
		public unsafe static bool2x4 operator >(double lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_Double_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00045DD4 File Offset: 0x00043FD4
		[CallerCount(0)]
		public unsafe static bool2x4 operator >=(double2x4 lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00045E20 File Offset: 0x00044020
		[CallerCount(0)]
		public unsafe static bool2x4 operator >=(double2x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_double2x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00045E6C File Offset: 0x0004406C
		[CallerCount(0)]
		public unsafe static bool2x4 operator >=(double lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_Double_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00045EB8 File Offset: 0x000440B8
		[CallerCount(0)]
		public unsafe static double2x4 operator -(double2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00045EF8 File Offset: 0x000440F8
		[CallerCount(0)]
		public unsafe static double2x4 operator +(double2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00045F38 File Offset: 0x00044138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635083, XrefRangeEnd = 635091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x4 operator ==(double2x4 lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00045F84 File Offset: 0x00044184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635091, XrefRangeEnd = 635099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x4 operator ==(double2x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_double2x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00045FD0 File Offset: 0x000441D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635099, XrefRangeEnd = 635106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x4 operator ==(double lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_Double_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0004601C File Offset: 0x0004421C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635106, XrefRangeEnd = 635114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x4 operator !=(double2x4 lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_double2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00046068 File Offset: 0x00044268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635114, XrefRangeEnd = 635122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x4 operator !=(double2x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_double2x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000460B4 File Offset: 0x000442B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635122, XrefRangeEnd = 635129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x4 operator !=(double lhs, double2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_Double_double2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000228 RID: 552
		public unsafe ref double2 this[int index]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_get_Item_Public_get_byref_double2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00046134 File Offset: 0x00044334
		[CallerCount(0)]
		public unsafe bool Equals(double2x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00046174 File Offset: 0x00044374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635129, XrefRangeEnd = 635132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000461B8 File Offset: 0x000443B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635132, XrefRangeEnd = 635133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000461E8 File Offset: 0x000443E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635133, XrefRangeEnd = 635172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00046214 File Offset: 0x00044414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635172, XrefRangeEnd = 635220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0000231E File Offset: 0x0000051E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<double2x4>.NativeClassPtr, ref this));
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00046264 File Offset: 0x00044464
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x00002330 File Offset: 0x00000530
		public unsafe static double2x4 zero
		{
			get
			{
				double2x4 double2x;
				IL2CPP.il2cpp_field_static_get_value(double2x4.NativeFieldInfoPtr_zero, (void*)(&double2x));
				return double2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(double2x4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2_double2_double2_double2_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2x4_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2x4_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2x4_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2x4_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_Double_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double2x4_Boolean_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double2x4_bool2x4_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_Int32_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_int2x4_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_UInt32_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_uint2x4_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_Single_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x4_float2x4_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double2x4_double2x4_double2x4_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double2x4_double2x4_Double_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double2x4_Double_double2x4_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double2x4_double2x4_double2x4_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double2x4_double2x4_Double_0;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double2x4_Double_double2x4_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x4_double2x4_double2x4_0;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x4_double2x4_Double_0;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x4_Double_double2x4_0;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double2x4_double2x4_double2x4_0;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double2x4_double2x4_Double_0;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double2x4_Double_double2x4_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double2x4_double2x4_double2x4_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double2x4_double2x4_Double_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double2x4_Double_double2x4_0;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_double2x4_double2x4_0;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_double2x4_double2x4_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_double2x4_double2x4_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_double2x4_Double_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_Double_double2x4_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_double2x4_double2x4_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_double2x4_Double_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_Double_double2x4_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_double2x4_double2x4_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_double2x4_Double_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_Double_double2x4_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_double2x4_double2x4_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_double2x4_Double_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_Double_double2x4_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double2x4_double2x4_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double2x4_double2x4_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_double2x4_double2x4_0;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_double2x4_Double_0;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_Double_double2x4_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_double2x4_double2x4_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_double2x4_Double_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_Double_double2x4_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_double2_Int32_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double2x4_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000C6E RID: 3182
		[FieldOffset(0)]
		public double2 c0;

		// Token: 0x04000C6F RID: 3183
		[FieldOffset(16)]
		public double2 c1;

		// Token: 0x04000C70 RID: 3184
		[FieldOffset(32)]
		public double2 c2;

		// Token: 0x04000C71 RID: 3185
		[FieldOffset(48)]
		public double2 c3;
	}
}
