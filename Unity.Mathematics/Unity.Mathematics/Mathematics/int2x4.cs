using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000030 RID: 48
	[Serializable]
	[StructLayout(2)]
	public struct int2x4
	{
		// Token: 0x060019EF RID: 6639 RVA: 0x00088218 File Offset: 0x00086418
		// Note: this type is marked as 'beforefieldinit'.
		static int2x4()
		{
			Il2CppClassPointerStore<int2x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "int2x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int2x4>.NativeClassPtr);
			int2x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2x4>.NativeClassPtr, "c0");
			int2x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2x4>.NativeClassPtr, "c1");
			int2x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2x4>.NativeClassPtr, "c2");
			int2x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2x4>.NativeClassPtr, "c3");
			int2x4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2x4>.NativeClassPtr, "zero");
			int2x4.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669744);
			int2x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669745);
			int2x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669746);
			int2x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669747);
			int2x4.NativeMethodInfoPtr__ctor_Public_Void_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669748);
			int2x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669749);
			int2x4.NativeMethodInfoPtr__ctor_Public_Void_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669750);
			int2x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669751);
			int2x4.NativeMethodInfoPtr__ctor_Public_Void_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669752);
			int2x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669753);
			int2x4.NativeMethodInfoPtr__ctor_Public_Void_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669754);
			int2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669755);
			int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669756);
			int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669757);
			int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669758);
			int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669759);
			int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669760);
			int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669761);
			int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669762);
			int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669763);
			int2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669764);
			int2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669765);
			int2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669766);
			int2x4.NativeMethodInfoPtr_op_Addition_Public_Static_int2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669767);
			int2x4.NativeMethodInfoPtr_op_Addition_Public_Static_int2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669768);
			int2x4.NativeMethodInfoPtr_op_Addition_Public_Static_int2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669769);
			int2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669770);
			int2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669771);
			int2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669772);
			int2x4.NativeMethodInfoPtr_op_Division_Public_Static_int2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669773);
			int2x4.NativeMethodInfoPtr_op_Division_Public_Static_int2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669774);
			int2x4.NativeMethodInfoPtr_op_Division_Public_Static_int2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669775);
			int2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669776);
			int2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669777);
			int2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669778);
			int2x4.NativeMethodInfoPtr_op_Increment_Public_Static_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669779);
			int2x4.NativeMethodInfoPtr_op_Decrement_Public_Static_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669780);
			int2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669781);
			int2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669782);
			int2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669783);
			int2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669784);
			int2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669785);
			int2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669786);
			int2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669787);
			int2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669788);
			int2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669789);
			int2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669790);
			int2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669791);
			int2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669792);
			int2x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669793);
			int2x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669794);
			int2x4.NativeMethodInfoPtr_op_LeftShift_Public_Static_int2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669795);
			int2x4.NativeMethodInfoPtr_op_RightShift_Public_Static_int2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669796);
			int2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669797);
			int2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669798);
			int2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669799);
			int2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669800);
			int2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669801);
			int2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669802);
			int2x4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669803);
			int2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669804);
			int2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669805);
			int2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669806);
			int2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669807);
			int2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669808);
			int2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669809);
			int2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x4_int2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669810);
			int2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x4_int2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669811);
			int2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x4_Int32_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669812);
			int2x4.NativeMethodInfoPtr_get_Item_Public_get_byref_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669813);
			int2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669814);
			int2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669815);
			int2x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669816);
			int2x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669817);
			int2x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x4>.NativeClassPtr, 100669818);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00088888 File Offset: 0x00086A88
		[CallerCount(0)]
		public unsafe int2x4(int2 c0, int2 c1, int2 c2, int2 c3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_int2_int2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x000888E4 File Offset: 0x00086AE4
		[CallerCount(0)]
		public unsafe int2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00088978 File Offset: 0x00086B78
		[CallerCount(0)]
		public unsafe int2x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x000889AC File Offset: 0x00086BAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639297, RefRangeEnd = 639299, XrefRangeStart = 639297, XrefRangeEnd = 639297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int2x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x000889E0 File Offset: 0x00086BE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 639299, RefRangeEnd = 639303, XrefRangeStart = 639299, XrefRangeEnd = 639299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int2x4(bool2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr__ctor_Public_Void_bool2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00088A14 File Offset: 0x00086C14
		[CallerCount(0)]
		public unsafe int2x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00088A48 File Offset: 0x00086C48
		[CallerCount(0)]
		public unsafe int2x4(uint2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr__ctor_Public_Void_uint2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00088A7C File Offset: 0x00086C7C
		[CallerCount(0)]
		public unsafe int2x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00088AB0 File Offset: 0x00086CB0
		[CallerCount(0)]
		public unsafe int2x4(float2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr__ctor_Public_Void_float2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00088AE4 File Offset: 0x00086CE4
		[CallerCount(0)]
		public unsafe int2x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00088B18 File Offset: 0x00086D18
		[CallerCount(0)]
		public unsafe int2x4(double2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr__ctor_Public_Void_double2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x00088B4C File Offset: 0x00086D4C
		[CallerCount(0)]
		public unsafe static implicit operator int2x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00088B8C File Offset: 0x00086D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639303, XrefRangeEnd = 639304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int2x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x00088BCC File Offset: 0x00086DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int2x4(bool2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_bool2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00088C0C File Offset: 0x00086E0C
		[CallerCount(0)]
		public unsafe static explicit operator int2x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00088C4C File Offset: 0x00086E4C
		[CallerCount(0)]
		public unsafe static explicit operator int2x4(uint2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00088C8C File Offset: 0x00086E8C
		[CallerCount(0)]
		public unsafe static explicit operator int2x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00088CCC File Offset: 0x00086ECC
		[CallerCount(0)]
		public unsafe static explicit operator int2x4(float2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x00088D0C File Offset: 0x00086F0C
		[CallerCount(0)]
		public unsafe static explicit operator int2x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x00088D4C File Offset: 0x00086F4C
		[CallerCount(0)]
		public unsafe static explicit operator int2x4(double2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00088D8C File Offset: 0x00086F8C
		[CallerCount(0)]
		public unsafe static int2x4 operator *(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00088DD8 File Offset: 0x00086FD8
		[CallerCount(0)]
		public unsafe static int2x4 operator *(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00088E24 File Offset: 0x00087024
		[CallerCount(0)]
		public unsafe static int2x4 operator *(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00088E70 File Offset: 0x00087070
		[CallerCount(0)]
		public unsafe static int2x4 operator +(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Addition_Public_Static_int2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00088EBC File Offset: 0x000870BC
		[CallerCount(0)]
		public unsafe static int2x4 operator +(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Addition_Public_Static_int2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00088F08 File Offset: 0x00087108
		[CallerCount(0)]
		public unsafe static int2x4 operator +(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Addition_Public_Static_int2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00088F54 File Offset: 0x00087154
		[CallerCount(0)]
		public unsafe static int2x4 operator -(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00088FA0 File Offset: 0x000871A0
		[CallerCount(0)]
		public unsafe static int2x4 operator -(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00088FEC File Offset: 0x000871EC
		[CallerCount(0)]
		public unsafe static int2x4 operator -(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00089038 File Offset: 0x00087238
		[CallerCount(0)]
		public unsafe static int2x4 operator /(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Division_Public_Static_int2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00089084 File Offset: 0x00087284
		[CallerCount(0)]
		public unsafe static int2x4 operator /(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Division_Public_Static_int2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x000890D0 File Offset: 0x000872D0
		[CallerCount(0)]
		public unsafe static int2x4 operator /(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Division_Public_Static_int2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0008911C File Offset: 0x0008731C
		[CallerCount(0)]
		public unsafe static int2x4 operator %(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00089168 File Offset: 0x00087368
		[CallerCount(0)]
		public unsafe static int2x4 operator %(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x000891B4 File Offset: 0x000873B4
		[CallerCount(0)]
		public unsafe static int2x4 operator %(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00089200 File Offset: 0x00087400
		[CallerCount(0)]
		public unsafe static int2x4 operator ++(int2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Increment_Public_Static_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00089240 File Offset: 0x00087440
		[CallerCount(0)]
		public unsafe static int2x4 operator --(int2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Decrement_Public_Static_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00089280 File Offset: 0x00087480
		[CallerCount(0)]
		public unsafe static bool2x4 operator <(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x000892CC File Offset: 0x000874CC
		[CallerCount(0)]
		public unsafe static bool2x4 operator <(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00089318 File Offset: 0x00087518
		[CallerCount(0)]
		public unsafe static bool2x4 operator <(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00089364 File Offset: 0x00087564
		[CallerCount(0)]
		public unsafe static bool2x4 operator <=(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x000893B0 File Offset: 0x000875B0
		[CallerCount(0)]
		public unsafe static bool2x4 operator <=(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x000893FC File Offset: 0x000875FC
		[CallerCount(0)]
		public unsafe static bool2x4 operator <=(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00089448 File Offset: 0x00087648
		[CallerCount(0)]
		public unsafe static bool2x4 operator >(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00089494 File Offset: 0x00087694
		[CallerCount(0)]
		public unsafe static bool2x4 operator >(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x000894E0 File Offset: 0x000876E0
		[CallerCount(0)]
		public unsafe static bool2x4 operator >(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x0008952C File Offset: 0x0008772C
		[CallerCount(0)]
		public unsafe static bool2x4 operator >=(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x00089578 File Offset: 0x00087778
		[CallerCount(0)]
		public unsafe static bool2x4 operator >=(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x000895C4 File Offset: 0x000877C4
		[CallerCount(0)]
		public unsafe static bool2x4 operator >=(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00089610 File Offset: 0x00087810
		[CallerCount(0)]
		public unsafe static int2x4 operator -(int2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x00089650 File Offset: 0x00087850
		[CallerCount(0)]
		public unsafe static int2x4 operator +(int2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00089690 File Offset: 0x00087890
		[CallerCount(0)]
		public unsafe static int2x4 operator <<(int2x4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_LeftShift_Public_Static_int2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x000896DC File Offset: 0x000878DC
		[CallerCount(0)]
		public unsafe static int2x4 operator >>(int2x4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_RightShift_Public_Static_int2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00089728 File Offset: 0x00087928
		[CallerCount(0)]
		public unsafe static bool2x4 operator ==(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00089774 File Offset: 0x00087974
		[CallerCount(0)]
		public unsafe static bool2x4 operator ==(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x000897C0 File Offset: 0x000879C0
		[CallerCount(0)]
		public unsafe static bool2x4 operator ==(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0008980C File Offset: 0x00087A0C
		[CallerCount(0)]
		public unsafe static bool2x4 operator !=(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00089858 File Offset: 0x00087A58
		[CallerCount(0)]
		public unsafe static bool2x4 operator !=(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x000898A4 File Offset: 0x00087AA4
		[CallerCount(0)]
		public unsafe static bool2x4 operator !=(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x000898F0 File Offset: 0x00087AF0
		[CallerCount(0)]
		public unsafe static int2x4 operator ~(int2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00089930 File Offset: 0x00087B30
		[CallerCount(0)]
		public unsafe static int2x4 operator &(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0008997C File Offset: 0x00087B7C
		[CallerCount(0)]
		public unsafe static int2x4 operator &(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x000899C8 File Offset: 0x00087BC8
		[CallerCount(0)]
		public unsafe static int2x4 operator &(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00089A14 File Offset: 0x00087C14
		[CallerCount(0)]
		public unsafe static int2x4 operator |(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00089A60 File Offset: 0x00087C60
		[CallerCount(0)]
		public unsafe static int2x4 operator |(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00089AAC File Offset: 0x00087CAC
		[CallerCount(0)]
		public unsafe static int2x4 operator |(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00089AF8 File Offset: 0x00087CF8
		[CallerCount(0)]
		public unsafe static int2x4 operator ^(int2x4 lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x4_int2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00089B44 File Offset: 0x00087D44
		[CallerCount(0)]
		public unsafe static int2x4 operator ^(int2x4 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x4_int2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00089B90 File Offset: 0x00087D90
		[CallerCount(0)]
		public unsafe static int2x4 operator ^(int lhs, int2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x4_Int32_int2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700080C RID: 2060
		public unsafe ref int2 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_get_Item_Public_get_byref_int2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00089C10 File Offset: 0x00087E10
		[CallerCount(0)]
		public unsafe bool Equals(int2x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00089C50 File Offset: 0x00087E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639304, XrefRangeEnd = 639307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00089C94 File Offset: 0x00087E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639307, XrefRangeEnd = 639308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00089CC4 File Offset: 0x00087EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639308, XrefRangeEnd = 639347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00089CF0 File Offset: 0x00087EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639347, XrefRangeEnd = 639395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000026F2 File Offset: 0x000008F2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<int2x4>.NativeClassPtr, ref this));
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x00089D40 File Offset: 0x00087F40
		// (set) Token: 0x06001A3D RID: 6717 RVA: 0x00002704 File Offset: 0x00000904
		public unsafe static int2x4 zero
		{
			get
			{
				int2x4 int2x;
				IL2CPP.il2cpp_field_static_get_value(int2x4.NativeFieldInfoPtr_zero, (void*)(&int2x));
				return int2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int2x4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_int2_int2_int2_0;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2x4_0;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2x4_0;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2x4_0;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2x4_0;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int2x4_Int32_0;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_Boolean_0;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_bool2x4_0;

		// Token: 0x04001A64 RID: 6756
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_UInt32_0;

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_uint2x4_0;

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_Single_0;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_float2x4_0;

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_Double_0;

		// Token: 0x04001A69 RID: 6761
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x4_double2x4_0;

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int2x4_int2x4_int2x4_0;

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int2x4_int2x4_Int32_0;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int2x4_Int32_int2x4_0;

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int2x4_int2x4_int2x4_0;

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int2x4_int2x4_Int32_0;

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int2x4_Int32_int2x4_0;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x4_int2x4_int2x4_0;

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x4_int2x4_Int32_0;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x4_Int32_int2x4_0;

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int2x4_int2x4_int2x4_0;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int2x4_int2x4_Int32_0;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int2x4_Int32_int2x4_0;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int2x4_int2x4_int2x4_0;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int2x4_int2x4_Int32_0;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int2x4_Int32_int2x4_0;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_int2x4_int2x4_0;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_int2x4_int2x4_0;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_int2x4_int2x4_0;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_int2x4_Int32_0;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_Int32_int2x4_0;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_int2x4_int2x4_0;

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_int2x4_Int32_0;

		// Token: 0x04001A80 RID: 6784
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_Int32_int2x4_0;

		// Token: 0x04001A81 RID: 6785
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_int2x4_int2x4_0;

		// Token: 0x04001A82 RID: 6786
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_int2x4_Int32_0;

		// Token: 0x04001A83 RID: 6787
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_Int32_int2x4_0;

		// Token: 0x04001A84 RID: 6788
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_int2x4_int2x4_0;

		// Token: 0x04001A85 RID: 6789
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_int2x4_Int32_0;

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_Int32_int2x4_0;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int2x4_int2x4_0;

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int2x4_int2x4_0;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_int2x4_int2x4_Int32_0;

		// Token: 0x04001A8A RID: 6794
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_int2x4_int2x4_Int32_0;

		// Token: 0x04001A8B RID: 6795
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_int2x4_int2x4_0;

		// Token: 0x04001A8C RID: 6796
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_int2x4_Int32_0;

		// Token: 0x04001A8D RID: 6797
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_Int32_int2x4_0;

		// Token: 0x04001A8E RID: 6798
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_int2x4_int2x4_0;

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_int2x4_Int32_0;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_Int32_int2x4_0;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_int2x4_int2x4_0;

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x4_int2x4_int2x4_0;

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x4_int2x4_Int32_0;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x4_Int32_int2x4_0;

		// Token: 0x04001A95 RID: 6805
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x4_int2x4_int2x4_0;

		// Token: 0x04001A96 RID: 6806
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x4_int2x4_Int32_0;

		// Token: 0x04001A97 RID: 6807
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x4_Int32_int2x4_0;

		// Token: 0x04001A98 RID: 6808
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x4_int2x4_int2x4_0;

		// Token: 0x04001A99 RID: 6809
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x4_int2x4_Int32_0;

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x4_Int32_int2x4_0;

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_int2_Int32_0;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2x4_0;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001AA1 RID: 6817
		[FieldOffset(0)]
		public int2 c0;

		// Token: 0x04001AA2 RID: 6818
		[FieldOffset(8)]
		public int2 c1;

		// Token: 0x04001AA3 RID: 6819
		[FieldOffset(16)]
		public int2 c2;

		// Token: 0x04001AA4 RID: 6820
		[FieldOffset(24)]
		public int2 c3;
	}
}
