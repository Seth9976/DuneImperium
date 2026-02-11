using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000018 RID: 24
	[Serializable]
	[StructLayout(2)]
	public struct double3x4
	{
		// Token: 0x06000DA8 RID: 3496 RVA: 0x0004CAE4 File Offset: 0x0004ACE4
		// Note: this type is marked as 'beforefieldinit'.
		static double3x4()
		{
			Il2CppClassPointerStore<double3x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "double3x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<double3x4>.NativeClassPtr);
			double3x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3x4>.NativeClassPtr, "c0");
			double3x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3x4>.NativeClassPtr, "c1");
			double3x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3x4>.NativeClassPtr, "c2");
			double3x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3x4>.NativeClassPtr, "c3");
			double3x4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double3x4>.NativeClassPtr, "zero");
			double3x4.NativeMethodInfoPtr__ctor_Public_Void_double3_double3_double3_double3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666693);
			double3x4.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666694);
			double3x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666695);
			double3x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666696);
			double3x4.NativeMethodInfoPtr__ctor_Public_Void_bool3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666697);
			double3x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666698);
			double3x4.NativeMethodInfoPtr__ctor_Public_Void_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666699);
			double3x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666700);
			double3x4.NativeMethodInfoPtr__ctor_Public_Void_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666701);
			double3x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666702);
			double3x4.NativeMethodInfoPtr__ctor_Public_Void_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666703);
			double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666704);
			double3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_double3x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666705);
			double3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_double3x4_bool3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666706);
			double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666707);
			double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_int3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666708);
			double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666709);
			double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_uint3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666710);
			double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666711);
			double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_float3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666712);
			double3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double3x4_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666713);
			double3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double3x4_double3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666714);
			double3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double3x4_Double_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666715);
			double3x4.NativeMethodInfoPtr_op_Addition_Public_Static_double3x4_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666716);
			double3x4.NativeMethodInfoPtr_op_Addition_Public_Static_double3x4_double3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666717);
			double3x4.NativeMethodInfoPtr_op_Addition_Public_Static_double3x4_Double_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666718);
			double3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x4_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666719);
			double3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x4_double3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666720);
			double3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x4_Double_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666721);
			double3x4.NativeMethodInfoPtr_op_Division_Public_Static_double3x4_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666722);
			double3x4.NativeMethodInfoPtr_op_Division_Public_Static_double3x4_double3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666723);
			double3x4.NativeMethodInfoPtr_op_Division_Public_Static_double3x4_Double_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666724);
			double3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double3x4_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666725);
			double3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double3x4_double3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666726);
			double3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double3x4_Double_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666727);
			double3x4.NativeMethodInfoPtr_op_Increment_Public_Static_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666728);
			double3x4.NativeMethodInfoPtr_op_Decrement_Public_Static_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666729);
			double3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666730);
			double3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_double3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666731);
			double3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_Double_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666732);
			double3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666733);
			double3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_double3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666734);
			double3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_Double_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666735);
			double3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666736);
			double3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_double3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666737);
			double3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_Double_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666738);
			double3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666739);
			double3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_double3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666740);
			double3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_Double_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666741);
			double3x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666742);
			double3x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666743);
			double3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666744);
			double3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_double3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666745);
			double3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_Double_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666746);
			double3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_double3x4_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666747);
			double3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_double3x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666748);
			double3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_Double_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666749);
			double3x4.NativeMethodInfoPtr_get_Item_Public_get_byref_double3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666750);
			double3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double3x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666751);
			double3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666752);
			double3x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666753);
			double3x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666754);
			double3x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double3x4>.NativeClassPtr, 100666755);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0004D064 File Offset: 0x0004B264
		[CallerCount(0)]
		public unsafe double3x4(double3 c0, double3 c1, double3 c2, double3 c3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr__ctor_Public_Void_double3_double3_double3_double3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0004D0C0 File Offset: 0x0004B2C0
		[CallerCount(0)]
		public unsafe double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m02;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m03;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m12;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m13;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m20;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m21;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m22;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m23;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0004D190 File Offset: 0x0004B390
		[CallerCount(0)]
		public unsafe double3x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0004D1C4 File Offset: 0x0004B3C4
		[CallerCount(0)]
		public unsafe double3x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0004D1F8 File Offset: 0x0004B3F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 635601, RefRangeEnd = 635603, XrefRangeStart = 635590, XrefRangeEnd = 635601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double3x4(bool3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr__ctor_Public_Void_bool3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0004D22C File Offset: 0x0004B42C
		[CallerCount(0)]
		public unsafe double3x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0004D260 File Offset: 0x0004B460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 635603, RefRangeEnd = 635604, XrefRangeStart = 635603, XrefRangeEnd = 635603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double3x4(int3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr__ctor_Public_Void_int3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0004D294 File Offset: 0x0004B494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 635604, RefRangeEnd = 635605, XrefRangeStart = 635604, XrefRangeEnd = 635604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double3x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0004D2C8 File Offset: 0x0004B4C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 635605, RefRangeEnd = 635606, XrefRangeStart = 635605, XrefRangeEnd = 635605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double3x4(uint3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr__ctor_Public_Void_uint3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0004D2FC File Offset: 0x0004B4FC
		[CallerCount(0)]
		public unsafe double3x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0004D330 File Offset: 0x0004B530
		[CallerCount(0)]
		public unsafe double3x4(float3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr__ctor_Public_Void_float3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0004D364 File Offset: 0x0004B564
		[CallerCount(0)]
		public unsafe static implicit operator double3x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0004D3A4 File Offset: 0x0004B5A4
		[CallerCount(0)]
		public unsafe static explicit operator double3x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_double3x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0004D3E4 File Offset: 0x0004B5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double3x4(bool3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Explicit_Public_Static_double3x4_bool3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0004D424 File Offset: 0x0004B624
		[CallerCount(0)]
		public unsafe static implicit operator double3x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0004D464 File Offset: 0x0004B664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635606, XrefRangeEnd = 635607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double3x4(int3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_int3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0004D4A4 File Offset: 0x0004B6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635607, XrefRangeEnd = 635608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double3x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0004D4E4 File Offset: 0x0004B6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635608, XrefRangeEnd = 635609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double3x4(uint3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_uint3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0004D524 File Offset: 0x0004B724
		[CallerCount(0)]
		public unsafe static implicit operator double3x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0004D564 File Offset: 0x0004B764
		[CallerCount(0)]
		public unsafe static implicit operator double3x4(float3x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_float3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0004D5A4 File Offset: 0x0004B7A4
		[CallerCount(0)]
		public unsafe static double3x4 operator *(double3x4 lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double3x4_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0004D5F0 File Offset: 0x0004B7F0
		[CallerCount(0)]
		public unsafe static double3x4 operator *(double3x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double3x4_double3x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0004D63C File Offset: 0x0004B83C
		[CallerCount(0)]
		public unsafe static double3x4 operator *(double lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Multiply_Public_Static_double3x4_Double_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0004D688 File Offset: 0x0004B888
		[CallerCount(0)]
		public unsafe static double3x4 operator +(double3x4 lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Addition_Public_Static_double3x4_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0004D6D4 File Offset: 0x0004B8D4
		[CallerCount(0)]
		public unsafe static double3x4 operator +(double3x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Addition_Public_Static_double3x4_double3x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0004D720 File Offset: 0x0004B920
		[CallerCount(0)]
		public unsafe static double3x4 operator +(double lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Addition_Public_Static_double3x4_Double_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0004D76C File Offset: 0x0004B96C
		[CallerCount(0)]
		public unsafe static double3x4 operator -(double3x4 lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x4_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0004D7B8 File Offset: 0x0004B9B8
		[CallerCount(0)]
		public unsafe static double3x4 operator -(double3x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x4_double3x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0004D804 File Offset: 0x0004BA04
		[CallerCount(0)]
		public unsafe static double3x4 operator -(double lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x4_Double_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0004D850 File Offset: 0x0004BA50
		[CallerCount(0)]
		public unsafe static double3x4 operator /(double3x4 lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Division_Public_Static_double3x4_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0004D89C File Offset: 0x0004BA9C
		[CallerCount(0)]
		public unsafe static double3x4 operator /(double3x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Division_Public_Static_double3x4_double3x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0004D8E8 File Offset: 0x0004BAE8
		[CallerCount(0)]
		public unsafe static double3x4 operator /(double lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Division_Public_Static_double3x4_Double_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0004D934 File Offset: 0x0004BB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635609, XrefRangeEnd = 635621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double3x4 operator %(double3x4 lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double3x4_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0004D980 File Offset: 0x0004BB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635621, XrefRangeEnd = 635633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double3x4 operator %(double3x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double3x4_double3x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0004D9CC File Offset: 0x0004BBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635633, XrefRangeEnd = 635645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double3x4 operator %(double lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Modulus_Public_Static_double3x4_Double_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0004DA18 File Offset: 0x0004BC18
		[CallerCount(0)]
		public unsafe static double3x4 operator ++(double3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Increment_Public_Static_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0004DA58 File Offset: 0x0004BC58
		[CallerCount(0)]
		public unsafe static double3x4 operator --(double3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Decrement_Public_Static_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0004DA98 File Offset: 0x0004BC98
		[CallerCount(0)]
		public unsafe static bool3x4 operator <(double3x4 lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0004DAE4 File Offset: 0x0004BCE4
		[CallerCount(0)]
		public unsafe static bool3x4 operator <(double3x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_double3x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0004DB30 File Offset: 0x0004BD30
		[CallerCount(0)]
		public unsafe static bool3x4 operator <(double lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_Double_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0004DB7C File Offset: 0x0004BD7C
		[CallerCount(0)]
		public unsafe static bool3x4 operator <=(double3x4 lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0004DBC8 File Offset: 0x0004BDC8
		[CallerCount(0)]
		public unsafe static bool3x4 operator <=(double3x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_double3x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0004DC14 File Offset: 0x0004BE14
		[CallerCount(0)]
		public unsafe static bool3x4 operator <=(double lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_Double_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0004DC60 File Offset: 0x0004BE60
		[CallerCount(0)]
		public unsafe static bool3x4 operator >(double3x4 lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0004DCAC File Offset: 0x0004BEAC
		[CallerCount(0)]
		public unsafe static bool3x4 operator >(double3x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_double3x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0004DCF8 File Offset: 0x0004BEF8
		[CallerCount(0)]
		public unsafe static bool3x4 operator >(double lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_Double_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0004DD44 File Offset: 0x0004BF44
		[CallerCount(0)]
		public unsafe static bool3x4 operator >=(double3x4 lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0004DD90 File Offset: 0x0004BF90
		[CallerCount(0)]
		public unsafe static bool3x4 operator >=(double3x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_double3x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0004DDDC File Offset: 0x0004BFDC
		[CallerCount(0)]
		public unsafe static bool3x4 operator >=(double lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_Double_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0004DE28 File Offset: 0x0004C028
		[CallerCount(0)]
		public unsafe static double3x4 operator -(double3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0004DE68 File Offset: 0x0004C068
		[CallerCount(0)]
		public unsafe static double3x4 operator +(double3x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0004DEA8 File Offset: 0x0004C0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635645, XrefRangeEnd = 635657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x4 operator ==(double3x4 lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0004DEF4 File Offset: 0x0004C0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635657, XrefRangeEnd = 635669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x4 operator ==(double3x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_double3x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x0004DF40 File Offset: 0x0004C140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635669, XrefRangeEnd = 635681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x4 operator ==(double lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_Double_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0004DF8C File Offset: 0x0004C18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635681, XrefRangeEnd = 635693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x4 operator !=(double3x4 lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_double3x4_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0004DFD8 File Offset: 0x0004C1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635693, XrefRangeEnd = 635705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x4 operator !=(double3x4 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_double3x4_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0004E024 File Offset: 0x0004C224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635705, XrefRangeEnd = 635717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool3x4 operator !=(double lhs, double3x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_Double_double3x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002A6 RID: 678
		public unsafe ref double3 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_get_Item_Public_get_byref_double3_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0004E0A4 File Offset: 0x0004C2A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 635717, RefRangeEnd = 635718, XrefRangeStart = 635717, XrefRangeEnd = 635717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(double3x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double3x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0004E0E4 File Offset: 0x0004C2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635718, XrefRangeEnd = 635722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0004E128 File Offset: 0x0004C328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635722, XrefRangeEnd = 635723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0004E158 File Offset: 0x0004C358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635723, XrefRangeEnd = 635778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0004E184 File Offset: 0x0004C384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635778, XrefRangeEnd = 635846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double3x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x000023AC File Offset: 0x000005AC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<double3x4>.NativeClassPtr, ref this));
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x0004E1D4 File Offset: 0x0004C3D4
		// (set) Token: 0x06000DEA RID: 3562 RVA: 0x000023BE File Offset: 0x000005BE
		public unsafe static double3x4 zero
		{
			get
			{
				double3x4 double3x;
				IL2CPP.il2cpp_field_static_get_value(double3x4.NativeFieldInfoPtr_zero, (void*)(&double3x));
				return double3x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(double3x4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double3_double3_double3_double3_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool3x4_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3x4_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint3x4_0;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3x4_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_Double_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double3x4_Boolean_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double3x4_bool3x4_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_Int32_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_int3x4_0;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_UInt32_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_uint3x4_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_Single_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double3x4_float3x4_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double3x4_double3x4_double3x4_0;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double3x4_double3x4_Double_0;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double3x4_Double_double3x4_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double3x4_double3x4_double3x4_0;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double3x4_double3x4_Double_0;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double3x4_Double_double3x4_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x4_double3x4_double3x4_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x4_double3x4_Double_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double3x4_Double_double3x4_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double3x4_double3x4_double3x4_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double3x4_double3x4_Double_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double3x4_Double_double3x4_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double3x4_double3x4_double3x4_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double3x4_double3x4_Double_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double3x4_Double_double3x4_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_double3x4_double3x4_0;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_double3x4_double3x4_0;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_double3x4_double3x4_0;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_double3x4_Double_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool3x4_Double_double3x4_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_double3x4_double3x4_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_double3x4_Double_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool3x4_Double_double3x4_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_double3x4_double3x4_0;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_double3x4_Double_0;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool3x4_Double_double3x4_0;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_double3x4_double3x4_0;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_double3x4_Double_0;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool3x4_Double_double3x4_0;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double3x4_double3x4_0;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double3x4_double3x4_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_double3x4_double3x4_0;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_double3x4_Double_0;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool3x4_Double_double3x4_0;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_double3x4_double3x4_0;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_double3x4_Double_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool3x4_Double_double3x4_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_double3_Int32_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double3x4_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000E0F RID: 3599
		[FieldOffset(0)]
		public double3 c0;

		// Token: 0x04000E10 RID: 3600
		[FieldOffset(24)]
		public double3 c1;

		// Token: 0x04000E11 RID: 3601
		[FieldOffset(48)]
		public double3 c2;

		// Token: 0x04000E12 RID: 3602
		[FieldOffset(72)]
		public double3 c3;
	}
}
