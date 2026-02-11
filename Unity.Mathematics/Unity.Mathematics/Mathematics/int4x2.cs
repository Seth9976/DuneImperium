using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000036 RID: 54
	[Serializable]
	[StructLayout(2)]
	public struct int4x2
	{
		// Token: 0x06001DE2 RID: 7650 RVA: 0x0009B4F0 File Offset: 0x000996F0
		// Note: this type is marked as 'beforefieldinit'.
		static int4x2()
		{
			Il2CppClassPointerStore<int4x2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "int4x2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int4x2>.NativeClassPtr);
			int4x2.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4x2>.NativeClassPtr, "c0");
			int4x2.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4x2>.NativeClassPtr, "c1");
			int4x2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int4x2>.NativeClassPtr, "zero");
			int4x2.NativeMethodInfoPtr__ctor_Public_Void_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670732);
			int4x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670733);
			int4x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670734);
			int4x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670735);
			int4x2.NativeMethodInfoPtr__ctor_Public_Void_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670736);
			int4x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670737);
			int4x2.NativeMethodInfoPtr__ctor_Public_Void_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670738);
			int4x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670739);
			int4x2.NativeMethodInfoPtr__ctor_Public_Void_float4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670740);
			int4x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670741);
			int4x2.NativeMethodInfoPtr__ctor_Public_Void_double4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670742);
			int4x2.NativeMethodInfoPtr_op_Implicit_Public_Static_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670743);
			int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670744);
			int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_bool4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670745);
			int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670746);
			int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_uint4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670747);
			int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670748);
			int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_float4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670749);
			int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670750);
			int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_double4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670751);
			int4x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670752);
			int4x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670753);
			int4x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670754);
			int4x2.NativeMethodInfoPtr_op_Addition_Public_Static_int4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670755);
			int4x2.NativeMethodInfoPtr_op_Addition_Public_Static_int4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670756);
			int4x2.NativeMethodInfoPtr_op_Addition_Public_Static_int4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670757);
			int4x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670758);
			int4x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670759);
			int4x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670760);
			int4x2.NativeMethodInfoPtr_op_Division_Public_Static_int4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670761);
			int4x2.NativeMethodInfoPtr_op_Division_Public_Static_int4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670762);
			int4x2.NativeMethodInfoPtr_op_Division_Public_Static_int4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670763);
			int4x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670764);
			int4x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670765);
			int4x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670766);
			int4x2.NativeMethodInfoPtr_op_Increment_Public_Static_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670767);
			int4x2.NativeMethodInfoPtr_op_Decrement_Public_Static_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670768);
			int4x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670769);
			int4x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670770);
			int4x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670771);
			int4x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670772);
			int4x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670773);
			int4x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670774);
			int4x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670775);
			int4x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670776);
			int4x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670777);
			int4x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670778);
			int4x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670779);
			int4x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670780);
			int4x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670781);
			int4x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670782);
			int4x2.NativeMethodInfoPtr_op_LeftShift_Public_Static_int4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670783);
			int4x2.NativeMethodInfoPtr_op_RightShift_Public_Static_int4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670784);
			int4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670785);
			int4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670786);
			int4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670787);
			int4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670788);
			int4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670789);
			int4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670790);
			int4x2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670791);
			int4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670792);
			int4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670793);
			int4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670794);
			int4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670795);
			int4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670796);
			int4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670797);
			int4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x2_int4x2_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670798);
			int4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x2_int4x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670799);
			int4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x2_Int32_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670800);
			int4x2.NativeMethodInfoPtr_get_Item_Public_get_byref_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670801);
			int4x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int4x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670802);
			int4x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670803);
			int4x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670804);
			int4x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670805);
			int4x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int4x2>.NativeClassPtr, 100670806);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x0009BB38 File Offset: 0x00099D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 599697, RefRangeEnd = 599699, XrefRangeStart = 599697, XrefRangeEnd = 599699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int4x2(int4 c0, int4 c1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr__ctor_Public_Void_int4_int4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x0009BB78 File Offset: 0x00099D78
		[CallerCount(0)]
		public unsafe int4x2(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m20;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m21;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m30;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m31;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0009BC0C File Offset: 0x00099E0C
		[CallerCount(0)]
		public unsafe int4x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x0009BC40 File Offset: 0x00099E40
		[CallerCount(0)]
		public unsafe int4x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x0009BC74 File Offset: 0x00099E74
		[CallerCount(0)]
		public unsafe int4x2(bool4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr__ctor_Public_Void_bool4x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x0009BCA8 File Offset: 0x00099EA8
		[CallerCount(0)]
		public unsafe int4x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x0009BCDC File Offset: 0x00099EDC
		[CallerCount(0)]
		public unsafe int4x2(uint4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr__ctor_Public_Void_uint4x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x0009BD10 File Offset: 0x00099F10
		[CallerCount(0)]
		public unsafe int4x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x0009BD44 File Offset: 0x00099F44
		[CallerCount(0)]
		public unsafe int4x2(float4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr__ctor_Public_Void_float4x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x0009BD78 File Offset: 0x00099F78
		[CallerCount(0)]
		public unsafe int4x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x0009BDAC File Offset: 0x00099FAC
		[CallerCount(0)]
		public unsafe int4x2(double4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr__ctor_Public_Void_double4x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0009BDE0 File Offset: 0x00099FE0
		[CallerCount(0)]
		public unsafe static implicit operator int4x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Implicit_Public_Static_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x0009BE20 File Offset: 0x0009A020
		[CallerCount(0)]
		public unsafe static explicit operator int4x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x0009BE60 File Offset: 0x0009A060
		[CallerCount(0)]
		public unsafe static explicit operator int4x2(bool4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_bool4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x0009BEA0 File Offset: 0x0009A0A0
		[CallerCount(0)]
		public unsafe static explicit operator int4x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x0009BEE0 File Offset: 0x0009A0E0
		[CallerCount(0)]
		public unsafe static explicit operator int4x2(uint4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_uint4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x0009BF20 File Offset: 0x0009A120
		[CallerCount(0)]
		public unsafe static explicit operator int4x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x0009BF60 File Offset: 0x0009A160
		[CallerCount(0)]
		public unsafe static explicit operator int4x2(float4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_float4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0009BFA0 File Offset: 0x0009A1A0
		[CallerCount(0)]
		public unsafe static explicit operator int4x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x0009BFE0 File Offset: 0x0009A1E0
		[CallerCount(0)]
		public unsafe static explicit operator int4x2(double4x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_double4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0009C020 File Offset: 0x0009A220
		[CallerCount(0)]
		public unsafe static int4x2 operator *(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0009C06C File Offset: 0x0009A26C
		[CallerCount(0)]
		public unsafe static int4x2 operator *(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x0009C0B8 File Offset: 0x0009A2B8
		[CallerCount(0)]
		public unsafe static int4x2 operator *(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x0009C104 File Offset: 0x0009A304
		[CallerCount(0)]
		public unsafe static int4x2 operator +(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Addition_Public_Static_int4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x0009C150 File Offset: 0x0009A350
		[CallerCount(0)]
		public unsafe static int4x2 operator +(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Addition_Public_Static_int4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x0009C19C File Offset: 0x0009A39C
		[CallerCount(0)]
		public unsafe static int4x2 operator +(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Addition_Public_Static_int4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x0009C1E8 File Offset: 0x0009A3E8
		[CallerCount(0)]
		public unsafe static int4x2 operator -(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x0009C234 File Offset: 0x0009A434
		[CallerCount(0)]
		public unsafe static int4x2 operator -(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x0009C280 File Offset: 0x0009A480
		[CallerCount(0)]
		public unsafe static int4x2 operator -(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x0009C2CC File Offset: 0x0009A4CC
		[CallerCount(0)]
		public unsafe static int4x2 operator /(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Division_Public_Static_int4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x0009C318 File Offset: 0x0009A518
		[CallerCount(0)]
		public unsafe static int4x2 operator /(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Division_Public_Static_int4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x0009C364 File Offset: 0x0009A564
		[CallerCount(0)]
		public unsafe static int4x2 operator /(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Division_Public_Static_int4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0009C3B0 File Offset: 0x0009A5B0
		[CallerCount(0)]
		public unsafe static int4x2 operator %(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x0009C3FC File Offset: 0x0009A5FC
		[CallerCount(0)]
		public unsafe static int4x2 operator %(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x0009C448 File Offset: 0x0009A648
		[CallerCount(0)]
		public unsafe static int4x2 operator %(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x0009C494 File Offset: 0x0009A694
		[CallerCount(0)]
		public unsafe static int4x2 operator ++(int4x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Increment_Public_Static_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x0009C4D4 File Offset: 0x0009A6D4
		[CallerCount(0)]
		public unsafe static int4x2 operator --(int4x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Decrement_Public_Static_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0009C514 File Offset: 0x0009A714
		[CallerCount(0)]
		public unsafe static bool4x2 operator <(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x0009C560 File Offset: 0x0009A760
		[CallerCount(0)]
		public unsafe static bool4x2 operator <(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x0009C5AC File Offset: 0x0009A7AC
		[CallerCount(0)]
		public unsafe static bool4x2 operator <(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0009C5F8 File Offset: 0x0009A7F8
		[CallerCount(0)]
		public unsafe static bool4x2 operator <=(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x0009C644 File Offset: 0x0009A844
		[CallerCount(0)]
		public unsafe static bool4x2 operator <=(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x0009C690 File Offset: 0x0009A890
		[CallerCount(0)]
		public unsafe static bool4x2 operator <=(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x0009C6DC File Offset: 0x0009A8DC
		[CallerCount(0)]
		public unsafe static bool4x2 operator >(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x0009C728 File Offset: 0x0009A928
		[CallerCount(0)]
		public unsafe static bool4x2 operator >(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x0009C774 File Offset: 0x0009A974
		[CallerCount(0)]
		public unsafe static bool4x2 operator >(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0009C7C0 File Offset: 0x0009A9C0
		[CallerCount(0)]
		public unsafe static bool4x2 operator >=(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0009C80C File Offset: 0x0009AA0C
		[CallerCount(0)]
		public unsafe static bool4x2 operator >=(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x0009C858 File Offset: 0x0009AA58
		[CallerCount(0)]
		public unsafe static bool4x2 operator >=(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0009C8A4 File Offset: 0x0009AAA4
		[CallerCount(0)]
		public unsafe static int4x2 operator -(int4x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x0009C8E4 File Offset: 0x0009AAE4
		[CallerCount(0)]
		public unsafe static int4x2 operator +(int4x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0009C924 File Offset: 0x0009AB24
		[CallerCount(0)]
		public unsafe static int4x2 operator <<(int4x2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_LeftShift_Public_Static_int4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0009C970 File Offset: 0x0009AB70
		[CallerCount(0)]
		public unsafe static int4x2 operator >>(int4x2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_RightShift_Public_Static_int4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x0009C9BC File Offset: 0x0009ABBC
		[CallerCount(0)]
		public unsafe static bool4x2 operator ==(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0009CA08 File Offset: 0x0009AC08
		[CallerCount(0)]
		public unsafe static bool4x2 operator ==(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x0009CA54 File Offset: 0x0009AC54
		[CallerCount(0)]
		public unsafe static bool4x2 operator ==(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x0009CAA0 File Offset: 0x0009ACA0
		[CallerCount(0)]
		public unsafe static bool4x2 operator !=(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x0009CAEC File Offset: 0x0009ACEC
		[CallerCount(0)]
		public unsafe static bool4x2 operator !=(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x0009CB38 File Offset: 0x0009AD38
		[CallerCount(0)]
		public unsafe static bool4x2 operator !=(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0009CB84 File Offset: 0x0009AD84
		[CallerCount(0)]
		public unsafe static int4x2 operator ~(int4x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0009CBC4 File Offset: 0x0009ADC4
		[CallerCount(0)]
		public unsafe static int4x2 operator &(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0009CC10 File Offset: 0x0009AE10
		[CallerCount(0)]
		public unsafe static int4x2 operator &(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x0009CC5C File Offset: 0x0009AE5C
		[CallerCount(0)]
		public unsafe static int4x2 operator &(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0009CCA8 File Offset: 0x0009AEA8
		[CallerCount(0)]
		public unsafe static int4x2 operator |(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x0009CCF4 File Offset: 0x0009AEF4
		[CallerCount(0)]
		public unsafe static int4x2 operator |(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x0009CD40 File Offset: 0x0009AF40
		[CallerCount(0)]
		public unsafe static int4x2 operator |(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x0009CD8C File Offset: 0x0009AF8C
		[CallerCount(0)]
		public unsafe static int4x2 operator ^(int4x2 lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x2_int4x2_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x0009CDD8 File Offset: 0x0009AFD8
		[CallerCount(0)]
		public unsafe static int4x2 operator ^(int4x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x2_int4x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0009CE24 File Offset: 0x0009B024
		[CallerCount(0)]
		public unsafe static int4x2 operator ^(int lhs, int4x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x2_Int32_int4x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170009DE RID: 2526
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_get_Item_Public_get_byref_int4_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x0009CEA4 File Offset: 0x0009B0A4
		[CallerCount(0)]
		public unsafe bool Equals(int4x2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int4x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0009CEE4 File Offset: 0x0009B0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639801, XrefRangeEnd = 639804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x0009CF28 File Offset: 0x0009B128
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0009CF58 File Offset: 0x0009B158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639804, XrefRangeEnd = 639843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0009CF84 File Offset: 0x0009B184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639843, XrefRangeEnd = 639891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int4x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000027C0 File Offset: 0x000009C0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<int4x2>.NativeClassPtr, ref this));
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x0009CFD4 File Offset: 0x0009B1D4
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x000027D2 File Offset: 0x000009D2
		public unsafe static int4x2 zero
		{
			get
			{
				int4x2 int4x;
				IL2CPP.il2cpp_field_static_get_value(int4x2.NativeFieldInfoPtr_zero, (void*)(&int4x));
				return int4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int4x2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001E59 RID: 7769
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04001E5A RID: 7770
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04001E5B RID: 7771
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001E5C RID: 7772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4_int4_0;

		// Token: 0x04001E5D RID: 7773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001E5E RID: 7774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001E5F RID: 7775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001E60 RID: 7776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4x2_0;

		// Token: 0x04001E61 RID: 7777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4x2_0;

		// Token: 0x04001E63 RID: 7779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001E64 RID: 7780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4x2_0;

		// Token: 0x04001E65 RID: 7781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001E66 RID: 7782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4x2_0;

		// Token: 0x04001E67 RID: 7783
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int4x2_Int32_0;

		// Token: 0x04001E68 RID: 7784
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_Boolean_0;

		// Token: 0x04001E69 RID: 7785
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_bool4x2_0;

		// Token: 0x04001E6A RID: 7786
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_UInt32_0;

		// Token: 0x04001E6B RID: 7787
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_uint4x2_0;

		// Token: 0x04001E6C RID: 7788
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_Single_0;

		// Token: 0x04001E6D RID: 7789
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_float4x2_0;

		// Token: 0x04001E6E RID: 7790
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_Double_0;

		// Token: 0x04001E6F RID: 7791
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int4x2_double4x2_0;

		// Token: 0x04001E70 RID: 7792
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int4x2_int4x2_int4x2_0;

		// Token: 0x04001E71 RID: 7793
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int4x2_int4x2_Int32_0;

		// Token: 0x04001E72 RID: 7794
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int4x2_Int32_int4x2_0;

		// Token: 0x04001E73 RID: 7795
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int4x2_int4x2_int4x2_0;

		// Token: 0x04001E74 RID: 7796
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int4x2_int4x2_Int32_0;

		// Token: 0x04001E75 RID: 7797
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int4x2_Int32_int4x2_0;

		// Token: 0x04001E76 RID: 7798
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x2_int4x2_int4x2_0;

		// Token: 0x04001E77 RID: 7799
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x2_int4x2_Int32_0;

		// Token: 0x04001E78 RID: 7800
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int4x2_Int32_int4x2_0;

		// Token: 0x04001E79 RID: 7801
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int4x2_int4x2_int4x2_0;

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int4x2_int4x2_Int32_0;

		// Token: 0x04001E7B RID: 7803
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int4x2_Int32_int4x2_0;

		// Token: 0x04001E7C RID: 7804
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int4x2_int4x2_int4x2_0;

		// Token: 0x04001E7D RID: 7805
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int4x2_int4x2_Int32_0;

		// Token: 0x04001E7E RID: 7806
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int4x2_Int32_int4x2_0;

		// Token: 0x04001E7F RID: 7807
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_int4x2_int4x2_0;

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_int4x2_int4x2_0;

		// Token: 0x04001E81 RID: 7809
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_int4x2_int4x2_0;

		// Token: 0x04001E82 RID: 7810
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_int4x2_Int32_0;

		// Token: 0x04001E83 RID: 7811
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x2_Int32_int4x2_0;

		// Token: 0x04001E84 RID: 7812
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_int4x2_int4x2_0;

		// Token: 0x04001E85 RID: 7813
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_int4x2_Int32_0;

		// Token: 0x04001E86 RID: 7814
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x2_Int32_int4x2_0;

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_int4x2_int4x2_0;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_int4x2_Int32_0;

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x2_Int32_int4x2_0;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_int4x2_int4x2_0;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_int4x2_Int32_0;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x2_Int32_int4x2_0;

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int4x2_int4x2_0;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int4x2_int4x2_0;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_int4x2_int4x2_Int32_0;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_int4x2_int4x2_Int32_0;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_int4x2_int4x2_0;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_int4x2_Int32_0;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x2_Int32_int4x2_0;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_int4x2_int4x2_0;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_int4x2_Int32_0;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x2_Int32_int4x2_0;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_int4x2_int4x2_0;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x2_int4x2_int4x2_0;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x2_int4x2_Int32_0;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int4x2_Int32_int4x2_0;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x2_int4x2_int4x2_0;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x2_int4x2_Int32_0;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int4x2_Int32_int4x2_0;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x2_int4x2_int4x2_0;

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x2_int4x2_Int32_0;

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int4x2_Int32_int4x2_0;

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_int4_Int32_0;

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int4x2_0;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001EA7 RID: 7847
		[FieldOffset(0)]
		public int4 c0;

		// Token: 0x04001EA8 RID: 7848
		[FieldOffset(16)]
		public int4 c1;
	}
}
