using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	[StructLayout(2)]
	public struct double2x2
	{
		// Token: 0x06000B8A RID: 2954 RVA: 0x00041E98 File Offset: 0x00040098
		// Note: this type is marked as 'beforefieldinit'.
		static double2x2()
		{
			Il2CppClassPointerStore<double2x2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "double2x2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<double2x2>.NativeClassPtr);
			double2x2.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2x2>.NativeClassPtr, "c0");
			double2x2.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2x2>.NativeClassPtr, "c1");
			double2x2.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2x2>.NativeClassPtr, "identity");
			double2x2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double2x2>.NativeClassPtr, "zero");
			double2x2.NativeMethodInfoPtr__ctor_Public_Void_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666176);
			double2x2.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666177);
			double2x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666178);
			double2x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666179);
			double2x2.NativeMethodInfoPtr__ctor_Public_Void_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666180);
			double2x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666181);
			double2x2.NativeMethodInfoPtr__ctor_Public_Void_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666182);
			double2x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666183);
			double2x2.NativeMethodInfoPtr__ctor_Public_Void_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666184);
			double2x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666185);
			double2x2.NativeMethodInfoPtr__ctor_Public_Void_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666186);
			double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666187);
			double2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_double2x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666188);
			double2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_double2x2_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666189);
			double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666190);
			double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666191);
			double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666192);
			double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666193);
			double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666194);
			double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666195);
			double2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_double2x2_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666196);
			double2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_double2x2_double2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666197);
			double2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_double2x2_Double_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666198);
			double2x2.NativeMethodInfoPtr_op_Addition_Public_Static_double2x2_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666199);
			double2x2.NativeMethodInfoPtr_op_Addition_Public_Static_double2x2_double2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666200);
			double2x2.NativeMethodInfoPtr_op_Addition_Public_Static_double2x2_Double_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666201);
			double2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x2_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666202);
			double2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x2_double2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666203);
			double2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x2_Double_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666204);
			double2x2.NativeMethodInfoPtr_op_Division_Public_Static_double2x2_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666205);
			double2x2.NativeMethodInfoPtr_op_Division_Public_Static_double2x2_double2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666206);
			double2x2.NativeMethodInfoPtr_op_Division_Public_Static_double2x2_Double_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666207);
			double2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_double2x2_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666208);
			double2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_double2x2_double2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666209);
			double2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_double2x2_Double_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666210);
			double2x2.NativeMethodInfoPtr_op_Increment_Public_Static_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666211);
			double2x2.NativeMethodInfoPtr_op_Decrement_Public_Static_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666212);
			double2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666213);
			double2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_double2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666214);
			double2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_Double_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666215);
			double2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666216);
			double2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_double2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666217);
			double2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_Double_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666218);
			double2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666219);
			double2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_double2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666220);
			double2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_Double_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666221);
			double2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666222);
			double2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_double2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666223);
			double2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_Double_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666224);
			double2x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666225);
			double2x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666226);
			double2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666227);
			double2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_double2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666228);
			double2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_Double_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666229);
			double2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_double2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666230);
			double2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_double2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666231);
			double2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_Double_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666232);
			double2x2.NativeMethodInfoPtr_get_Item_Public_get_byref_double2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666233);
			double2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666234);
			double2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666235);
			double2x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666236);
			double2x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666237);
			double2x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double2x2>.NativeClassPtr, 100666238);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00042404 File Offset: 0x00040604
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 599697, RefRangeEnd = 599699, XrefRangeStart = 599697, XrefRangeEnd = 599699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double2x2(double2 c0, double2 c1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr__ctor_Public_Void_double2_double2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00042444 File Offset: 0x00040644
		[CallerCount(0)]
		public unsafe double2x2(double m00, double m01, double m10, double m11)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000424A0 File Offset: 0x000406A0
		[CallerCount(0)]
		public unsafe double2x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000424D4 File Offset: 0x000406D4
		[CallerCount(0)]
		public unsafe double2x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00042508 File Offset: 0x00040708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634818, XrefRangeEnd = 634821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double2x2(bool2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr__ctor_Public_Void_bool2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0004253C File Offset: 0x0004073C
		[CallerCount(0)]
		public unsafe double2x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00042570 File Offset: 0x00040770
		[CallerCount(0)]
		public unsafe double2x2(int2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr__ctor_Public_Void_int2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000425A4 File Offset: 0x000407A4
		[CallerCount(0)]
		public unsafe double2x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000425D8 File Offset: 0x000407D8
		[CallerCount(0)]
		public unsafe double2x2(uint2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr__ctor_Public_Void_uint2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0004260C File Offset: 0x0004080C
		[CallerCount(0)]
		public unsafe double2x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00042640 File Offset: 0x00040840
		[CallerCount(0)]
		public unsafe double2x2(float2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr__ctor_Public_Void_float2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00042674 File Offset: 0x00040874
		[CallerCount(0)]
		public unsafe static implicit operator double2x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x000426B4 File Offset: 0x000408B4
		[CallerCount(0)]
		public unsafe static explicit operator double2x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_double2x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x000426F4 File Offset: 0x000408F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double2x2(bool2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_double2x2_bool2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00042734 File Offset: 0x00040934
		[CallerCount(0)]
		public unsafe static implicit operator double2x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00042774 File Offset: 0x00040974
		[CallerCount(0)]
		public unsafe static implicit operator double2x2(int2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000427B4 File Offset: 0x000409B4
		[CallerCount(0)]
		public unsafe static implicit operator double2x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000427F4 File Offset: 0x000409F4
		[CallerCount(0)]
		public unsafe static implicit operator double2x2(uint2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00042834 File Offset: 0x00040A34
		[CallerCount(0)]
		public unsafe static implicit operator double2x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00042874 File Offset: 0x00040A74
		[CallerCount(0)]
		public unsafe static implicit operator double2x2(float2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x000428B4 File Offset: 0x00040AB4
		[CallerCount(0)]
		public unsafe static double2x2 operator *(double2x2 lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_double2x2_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00042900 File Offset: 0x00040B00
		[CallerCount(0)]
		public unsafe static double2x2 operator *(double2x2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_double2x2_double2x2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0004294C File Offset: 0x00040B4C
		[CallerCount(0)]
		public unsafe static double2x2 operator *(double lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_double2x2_Double_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00042998 File Offset: 0x00040B98
		[CallerCount(0)]
		public unsafe static double2x2 operator +(double2x2 lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Addition_Public_Static_double2x2_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000429E4 File Offset: 0x00040BE4
		[CallerCount(0)]
		public unsafe static double2x2 operator +(double2x2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Addition_Public_Static_double2x2_double2x2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00042A30 File Offset: 0x00040C30
		[CallerCount(0)]
		public unsafe static double2x2 operator +(double lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Addition_Public_Static_double2x2_Double_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00042A7C File Offset: 0x00040C7C
		[CallerCount(0)]
		public unsafe static double2x2 operator -(double2x2 lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x2_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00042AC8 File Offset: 0x00040CC8
		[CallerCount(0)]
		public unsafe static double2x2 operator -(double2x2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x2_double2x2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00042B14 File Offset: 0x00040D14
		[CallerCount(0)]
		public unsafe static double2x2 operator -(double lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x2_Double_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00042B60 File Offset: 0x00040D60
		[CallerCount(0)]
		public unsafe static double2x2 operator /(double2x2 lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Division_Public_Static_double2x2_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00042BAC File Offset: 0x00040DAC
		[CallerCount(0)]
		public unsafe static double2x2 operator /(double2x2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Division_Public_Static_double2x2_double2x2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00042BF8 File Offset: 0x00040DF8
		[CallerCount(0)]
		public unsafe static double2x2 operator /(double lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Division_Public_Static_double2x2_Double_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00042C44 File Offset: 0x00040E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634821, XrefRangeEnd = 634825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double2x2 operator %(double2x2 lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_double2x2_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00042C90 File Offset: 0x00040E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634825, XrefRangeEnd = 634829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double2x2 operator %(double2x2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_double2x2_double2x2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00042CDC File Offset: 0x00040EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634829, XrefRangeEnd = 634833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double2x2 operator %(double lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_double2x2_Double_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00042D28 File Offset: 0x00040F28
		[CallerCount(0)]
		public unsafe static double2x2 operator ++(double2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Increment_Public_Static_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00042D68 File Offset: 0x00040F68
		[CallerCount(0)]
		public unsafe static double2x2 operator --(double2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Decrement_Public_Static_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00042DA8 File Offset: 0x00040FA8
		[CallerCount(0)]
		public unsafe static bool2x2 operator <(double2x2 lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00042DF4 File Offset: 0x00040FF4
		[CallerCount(0)]
		public unsafe static bool2x2 operator <(double2x2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_double2x2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00042E40 File Offset: 0x00041040
		[CallerCount(0)]
		public unsafe static bool2x2 operator <(double lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_Double_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00042E8C File Offset: 0x0004108C
		[CallerCount(0)]
		public unsafe static bool2x2 operator <=(double2x2 lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00042ED8 File Offset: 0x000410D8
		[CallerCount(0)]
		public unsafe static bool2x2 operator <=(double2x2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_double2x2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00042F24 File Offset: 0x00041124
		[CallerCount(0)]
		public unsafe static bool2x2 operator <=(double lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_Double_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00042F70 File Offset: 0x00041170
		[CallerCount(0)]
		public unsafe static bool2x2 operator >(double2x2 lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00042FBC File Offset: 0x000411BC
		[CallerCount(0)]
		public unsafe static bool2x2 operator >(double2x2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_double2x2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00043008 File Offset: 0x00041208
		[CallerCount(0)]
		public unsafe static bool2x2 operator >(double lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_Double_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00043054 File Offset: 0x00041254
		[CallerCount(0)]
		public unsafe static bool2x2 operator >=(double2x2 lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x000430A0 File Offset: 0x000412A0
		[CallerCount(0)]
		public unsafe static bool2x2 operator >=(double2x2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_double2x2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x000430EC File Offset: 0x000412EC
		[CallerCount(0)]
		public unsafe static bool2x2 operator >=(double lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_Double_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00043138 File Offset: 0x00041338
		[CallerCount(0)]
		public unsafe static double2x2 operator -(double2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00043178 File Offset: 0x00041378
		[CallerCount(0)]
		public unsafe static double2x2 operator +(double2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x000431B8 File Offset: 0x000413B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634833, XrefRangeEnd = 634837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x2 operator ==(double2x2 lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00043204 File Offset: 0x00041404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634837, XrefRangeEnd = 634841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x2 operator ==(double2x2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_double2x2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00043250 File Offset: 0x00041450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634841, XrefRangeEnd = 634844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x2 operator ==(double lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_Double_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0004329C File Offset: 0x0004149C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634844, XrefRangeEnd = 634848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x2 operator !=(double2x2 lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_double2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x000432E8 File Offset: 0x000414E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634848, XrefRangeEnd = 634852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x2 operator !=(double2x2 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_double2x2_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00043334 File Offset: 0x00041534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634852, XrefRangeEnd = 634855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x2 operator !=(double lhs, double2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_Double_double2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000224 RID: 548
		public unsafe ref double2 this[int index]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 634855, RefRangeEnd = 634861, XrefRangeStart = 634855, XrefRangeEnd = 634855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_get_Item_Public_get_byref_double2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x000433B4 File Offset: 0x000415B4
		[CallerCount(0)]
		public unsafe bool Equals(double2x2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x000433F4 File Offset: 0x000415F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634861, XrefRangeEnd = 634864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00043438 File Offset: 0x00041638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634864, XrefRangeEnd = 634865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00043468 File Offset: 0x00041668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634865, XrefRangeEnd = 634888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00043494 File Offset: 0x00041694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634888, XrefRangeEnd = 634918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double2x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000022D0 File Offset: 0x000004D0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<double2x2>.NativeClassPtr, ref this));
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x000434E4 File Offset: 0x000416E4
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x000022E2 File Offset: 0x000004E2
		public unsafe static double2x2 identity
		{
			get
			{
				double2x2 double2x;
				IL2CPP.il2cpp_field_static_get_value(double2x2.NativeFieldInfoPtr_identity, (void*)(&double2x));
				return double2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(double2x2.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00043500 File Offset: 0x00041700
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x000022F0 File Offset: 0x000004F0
		public unsafe static double2x2 zero
		{
			get
			{
				double2x2 double2x;
				IL2CPP.il2cpp_field_static_get_value(double2x2.NativeFieldInfoPtr_zero, (void*)(&double2x));
				return double2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(double2x2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2_double2_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2x2_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2x2_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2x2_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2x2_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_Double_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double2x2_Boolean_0;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double2x2_bool2x2_0;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_Int32_0;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_int2x2_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_UInt32_0;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_uint2x2_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_Single_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double2x2_float2x2_0;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double2x2_double2x2_double2x2_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double2x2_double2x2_Double_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double2x2_Double_double2x2_0;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double2x2_double2x2_double2x2_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double2x2_double2x2_Double_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double2x2_Double_double2x2_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x2_double2x2_double2x2_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x2_double2x2_Double_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double2x2_Double_double2x2_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double2x2_double2x2_double2x2_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double2x2_double2x2_Double_0;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double2x2_Double_double2x2_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double2x2_double2x2_double2x2_0;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double2x2_double2x2_Double_0;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double2x2_Double_double2x2_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_double2x2_double2x2_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_double2x2_double2x2_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_double2x2_double2x2_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_double2x2_Double_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_Double_double2x2_0;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_double2x2_double2x2_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_double2x2_Double_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_Double_double2x2_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_double2x2_double2x2_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_double2x2_Double_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_Double_double2x2_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_double2x2_double2x2_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_double2x2_Double_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_Double_double2x2_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double2x2_double2x2_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double2x2_double2x2_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_double2x2_double2x2_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_double2x2_Double_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_Double_double2x2_0;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_double2x2_double2x2_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_double2x2_Double_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_Double_double2x2_0;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_double2_Int32_0;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double2x2_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000BE2 RID: 3042
		[FieldOffset(0)]
		public double2 c0;

		// Token: 0x04000BE3 RID: 3043
		[FieldOffset(16)]
		public double2 c1;
	}
}
