using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200002E RID: 46
	[Serializable]
	[StructLayout(2)]
	public struct int2x2
	{
		// Token: 0x0600194F RID: 6479 RVA: 0x00084C18 File Offset: 0x00082E18
		// Note: this type is marked as 'beforefieldinit'.
		static int2x2()
		{
			Il2CppClassPointerStore<int2x2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "int2x2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<int2x2>.NativeClassPtr);
			int2x2.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2x2>.NativeClassPtr, "c0");
			int2x2.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2x2>.NativeClassPtr, "c1");
			int2x2.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2x2>.NativeClassPtr, "identity");
			int2x2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<int2x2>.NativeClassPtr, "zero");
			int2x2.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669593);
			int2x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669594);
			int2x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669595);
			int2x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669596);
			int2x2.NativeMethodInfoPtr__ctor_Public_Void_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669597);
			int2x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669598);
			int2x2.NativeMethodInfoPtr__ctor_Public_Void_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669599);
			int2x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669600);
			int2x2.NativeMethodInfoPtr__ctor_Public_Void_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669601);
			int2x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669602);
			int2x2.NativeMethodInfoPtr__ctor_Public_Void_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669603);
			int2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669604);
			int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669605);
			int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669606);
			int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669607);
			int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669608);
			int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669609);
			int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669610);
			int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669611);
			int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669612);
			int2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669613);
			int2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669614);
			int2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669615);
			int2x2.NativeMethodInfoPtr_op_Addition_Public_Static_int2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669616);
			int2x2.NativeMethodInfoPtr_op_Addition_Public_Static_int2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669617);
			int2x2.NativeMethodInfoPtr_op_Addition_Public_Static_int2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669618);
			int2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669619);
			int2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669620);
			int2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669621);
			int2x2.NativeMethodInfoPtr_op_Division_Public_Static_int2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669622);
			int2x2.NativeMethodInfoPtr_op_Division_Public_Static_int2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669623);
			int2x2.NativeMethodInfoPtr_op_Division_Public_Static_int2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669624);
			int2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669625);
			int2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669626);
			int2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669627);
			int2x2.NativeMethodInfoPtr_op_Increment_Public_Static_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669628);
			int2x2.NativeMethodInfoPtr_op_Decrement_Public_Static_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669629);
			int2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669630);
			int2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669631);
			int2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669632);
			int2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669633);
			int2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669634);
			int2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669635);
			int2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669636);
			int2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669637);
			int2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669638);
			int2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669639);
			int2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669640);
			int2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669641);
			int2x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669642);
			int2x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669643);
			int2x2.NativeMethodInfoPtr_op_LeftShift_Public_Static_int2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669644);
			int2x2.NativeMethodInfoPtr_op_RightShift_Public_Static_int2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669645);
			int2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669646);
			int2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669647);
			int2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669648);
			int2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669649);
			int2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669650);
			int2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669651);
			int2x2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669652);
			int2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669653);
			int2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669654);
			int2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669655);
			int2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669656);
			int2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669657);
			int2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669658);
			int2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x2_int2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669659);
			int2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x2_int2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669660);
			int2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x2_Int32_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669661);
			int2x2.NativeMethodInfoPtr_get_Item_Public_get_byref_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669662);
			int2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669663);
			int2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669664);
			int2x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669665);
			int2x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669666);
			int2x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<int2x2>.NativeClassPtr, 100669667);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00085274 File Offset: 0x00083474
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 636721, RefRangeEnd = 636742, XrefRangeStart = 636721, XrefRangeEnd = 636742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int2x2(int2 c0, int2 c1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000852B4 File Offset: 0x000834B4
		[CallerCount(0)]
		public unsafe int2x2(int m00, int m01, int m10, int m11)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00085310 File Offset: 0x00083510
		[CallerCount(0)]
		public unsafe int2x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00085344 File Offset: 0x00083544
		[CallerCount(0)]
		public unsafe int2x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00085378 File Offset: 0x00083578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639159, RefRangeEnd = 639161, XrefRangeStart = 639159, XrefRangeEnd = 639159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int2x2(bool2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr__ctor_Public_Void_bool2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x000853AC File Offset: 0x000835AC
		[CallerCount(0)]
		public unsafe int2x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x000853E0 File Offset: 0x000835E0
		[CallerCount(0)]
		public unsafe int2x2(uint2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr__ctor_Public_Void_uint2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00085414 File Offset: 0x00083614
		[CallerCount(0)]
		public unsafe int2x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00085448 File Offset: 0x00083648
		[CallerCount(0)]
		public unsafe int2x2(float2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr__ctor_Public_Void_float2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0008547C File Offset: 0x0008367C
		[CallerCount(0)]
		public unsafe int2x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x000854B0 File Offset: 0x000836B0
		[CallerCount(0)]
		public unsafe int2x2(double2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr__ctor_Public_Void_double2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000854E4 File Offset: 0x000836E4
		[CallerCount(0)]
		public unsafe static implicit operator int2x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00085524 File Offset: 0x00083724
		[CallerCount(0)]
		public unsafe static explicit operator int2x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00085564 File Offset: 0x00083764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639161, XrefRangeEnd = 639162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int2x2(bool2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_bool2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x000855A4 File Offset: 0x000837A4
		[CallerCount(0)]
		public unsafe static explicit operator int2x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x000855E4 File Offset: 0x000837E4
		[CallerCount(0)]
		public unsafe static explicit operator int2x2(uint2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00085624 File Offset: 0x00083824
		[CallerCount(0)]
		public unsafe static explicit operator int2x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00085664 File Offset: 0x00083864
		[CallerCount(0)]
		public unsafe static explicit operator int2x2(float2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x000856A4 File Offset: 0x000838A4
		[CallerCount(0)]
		public unsafe static explicit operator int2x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x000856E4 File Offset: 0x000838E4
		[CallerCount(0)]
		public unsafe static explicit operator int2x2(double2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00085724 File Offset: 0x00083924
		[CallerCount(0)]
		public unsafe static int2x2 operator *(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00085770 File Offset: 0x00083970
		[CallerCount(0)]
		public unsafe static int2x2 operator *(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x000857BC File Offset: 0x000839BC
		[CallerCount(0)]
		public unsafe static int2x2 operator *(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_int2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00085808 File Offset: 0x00083A08
		[CallerCount(0)]
		public unsafe static int2x2 operator +(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Addition_Public_Static_int2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x00085854 File Offset: 0x00083A54
		[CallerCount(0)]
		public unsafe static int2x2 operator +(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Addition_Public_Static_int2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000858A0 File Offset: 0x00083AA0
		[CallerCount(0)]
		public unsafe static int2x2 operator +(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Addition_Public_Static_int2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x000858EC File Offset: 0x00083AEC
		[CallerCount(0)]
		public unsafe static int2x2 operator -(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x00085938 File Offset: 0x00083B38
		[CallerCount(0)]
		public unsafe static int2x2 operator -(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00085984 File Offset: 0x00083B84
		[CallerCount(0)]
		public unsafe static int2x2 operator -(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x000859D0 File Offset: 0x00083BD0
		[CallerCount(0)]
		public unsafe static int2x2 operator /(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Division_Public_Static_int2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00085A1C File Offset: 0x00083C1C
		[CallerCount(0)]
		public unsafe static int2x2 operator /(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Division_Public_Static_int2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00085A68 File Offset: 0x00083C68
		[CallerCount(0)]
		public unsafe static int2x2 operator /(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Division_Public_Static_int2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00085AB4 File Offset: 0x00083CB4
		[CallerCount(0)]
		public unsafe static int2x2 operator %(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00085B00 File Offset: 0x00083D00
		[CallerCount(0)]
		public unsafe static int2x2 operator %(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00085B4C File Offset: 0x00083D4C
		[CallerCount(0)]
		public unsafe static int2x2 operator %(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_int2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00085B98 File Offset: 0x00083D98
		[CallerCount(0)]
		public unsafe static int2x2 operator ++(int2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Increment_Public_Static_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00085BD8 File Offset: 0x00083DD8
		[CallerCount(0)]
		public unsafe static int2x2 operator --(int2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Decrement_Public_Static_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00085C18 File Offset: 0x00083E18
		[CallerCount(0)]
		public unsafe static bool2x2 operator <(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00085C64 File Offset: 0x00083E64
		[CallerCount(0)]
		public unsafe static bool2x2 operator <(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00085CB0 File Offset: 0x00083EB0
		[CallerCount(0)]
		public unsafe static bool2x2 operator <(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00085CFC File Offset: 0x00083EFC
		[CallerCount(0)]
		public unsafe static bool2x2 operator <=(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00085D48 File Offset: 0x00083F48
		[CallerCount(0)]
		public unsafe static bool2x2 operator <=(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00085D94 File Offset: 0x00083F94
		[CallerCount(0)]
		public unsafe static bool2x2 operator <=(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00085DE0 File Offset: 0x00083FE0
		[CallerCount(0)]
		public unsafe static bool2x2 operator >(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00085E2C File Offset: 0x0008402C
		[CallerCount(0)]
		public unsafe static bool2x2 operator >(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00085E78 File Offset: 0x00084078
		[CallerCount(0)]
		public unsafe static bool2x2 operator >(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00085EC4 File Offset: 0x000840C4
		[CallerCount(0)]
		public unsafe static bool2x2 operator >=(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00085F10 File Offset: 0x00084110
		[CallerCount(0)]
		public unsafe static bool2x2 operator >=(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00085F5C File Offset: 0x0008415C
		[CallerCount(0)]
		public unsafe static bool2x2 operator >=(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00085FA8 File Offset: 0x000841A8
		[CallerCount(0)]
		public unsafe static int2x2 operator -(int2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00085FE8 File Offset: 0x000841E8
		[CallerCount(0)]
		public unsafe static int2x2 operator +(int2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00086028 File Offset: 0x00084228
		[CallerCount(0)]
		public unsafe static int2x2 operator <<(int2x2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_LeftShift_Public_Static_int2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00086074 File Offset: 0x00084274
		[CallerCount(0)]
		public unsafe static int2x2 operator >>(int2x2 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_RightShift_Public_Static_int2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x000860C0 File Offset: 0x000842C0
		[CallerCount(0)]
		public unsafe static bool2x2 operator ==(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x0008610C File Offset: 0x0008430C
		[CallerCount(0)]
		public unsafe static bool2x2 operator ==(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00086158 File Offset: 0x00084358
		[CallerCount(0)]
		public unsafe static bool2x2 operator ==(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x000861A4 File Offset: 0x000843A4
		[CallerCount(0)]
		public unsafe static bool2x2 operator !=(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x000861F0 File Offset: 0x000843F0
		[CallerCount(0)]
		public unsafe static bool2x2 operator !=(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0008623C File Offset: 0x0008443C
		[CallerCount(0)]
		public unsafe static bool2x2 operator !=(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00086288 File Offset: 0x00084488
		[CallerCount(0)]
		public unsafe static int2x2 operator ~(int2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_OnesComplement_Public_Static_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x000862C8 File Offset: 0x000844C8
		[CallerCount(0)]
		public unsafe static int2x2 operator &(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00086314 File Offset: 0x00084514
		[CallerCount(0)]
		public unsafe static int2x2 operator &(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00086360 File Offset: 0x00084560
		[CallerCount(0)]
		public unsafe static int2x2 operator &(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x000863AC File Offset: 0x000845AC
		[CallerCount(0)]
		public unsafe static int2x2 operator |(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x000863F8 File Offset: 0x000845F8
		[CallerCount(0)]
		public unsafe static int2x2 operator |(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00086444 File Offset: 0x00084644
		[CallerCount(0)]
		public unsafe static int2x2 operator |(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00086490 File Offset: 0x00084690
		[CallerCount(0)]
		public unsafe static int2x2 operator ^(int2x2 lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x2_int2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x000864DC File Offset: 0x000846DC
		[CallerCount(0)]
		public unsafe static int2x2 operator ^(int2x2 lhs, int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x2_int2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00086528 File Offset: 0x00084728
		[CallerCount(0)]
		public unsafe static int2x2 operator ^(int lhs, int2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x2_Int32_int2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000808 RID: 2056
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_get_Item_Public_get_byref_int2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x000865A8 File Offset: 0x000847A8
		[CallerCount(0)]
		public unsafe bool Equals(int2x2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x000865E8 File Offset: 0x000847E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639162, XrefRangeEnd = 639165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0008662C File Offset: 0x0008482C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0008665C File Offset: 0x0008485C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639165, XrefRangeEnd = 639188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00086688 File Offset: 0x00084888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639188, XrefRangeEnd = 639218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(int2x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x000026A4 File Offset: 0x000008A4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<int2x2>.NativeClassPtr, ref this));
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x000866D8 File Offset: 0x000848D8
		// (set) Token: 0x0600199D RID: 6557 RVA: 0x000026B6 File Offset: 0x000008B6
		public unsafe static int2x2 identity
		{
			get
			{
				int2x2 int2x;
				IL2CPP.il2cpp_field_static_get_value(int2x2.NativeFieldInfoPtr_identity, (void*)(&int2x));
				return int2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int2x2.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x000866F4 File Offset: 0x000848F4
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x000026C4 File Offset: 0x000008C4
		public unsafe static int2x2 zero
		{
			get
			{
				int2x2 int2x;
				IL2CPP.il2cpp_field_static_get_value(int2x2.NativeFieldInfoPtr_zero, (void*)(&int2x));
				return int2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(int2x2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2x2_0;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2x2_0;

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2x2_0;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2x2_0;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int2x2_Int32_0;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_Boolean_0;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_bool2x2_0;

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_UInt32_0;

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_uint2x2_0;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_Single_0;

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_float2x2_0;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_Double_0;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_int2x2_double2x2_0;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int2x2_int2x2_int2x2_0;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int2x2_int2x2_Int32_0;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_int2x2_Int32_int2x2_0;

		// Token: 0x040019C9 RID: 6601
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int2x2_int2x2_int2x2_0;

		// Token: 0x040019CA RID: 6602
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int2x2_int2x2_Int32_0;

		// Token: 0x040019CB RID: 6603
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_int2x2_Int32_int2x2_0;

		// Token: 0x040019CC RID: 6604
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x2_int2x2_int2x2_0;

		// Token: 0x040019CD RID: 6605
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x2_int2x2_Int32_0;

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_int2x2_Int32_int2x2_0;

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int2x2_int2x2_int2x2_0;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int2x2_int2x2_Int32_0;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_int2x2_Int32_int2x2_0;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int2x2_int2x2_int2x2_0;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int2x2_int2x2_Int32_0;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_int2x2_Int32_int2x2_0;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_int2x2_int2x2_0;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_int2x2_int2x2_0;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_int2x2_int2x2_0;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_int2x2_Int32_0;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_Int32_int2x2_0;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_int2x2_int2x2_0;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_int2x2_Int32_0;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_Int32_int2x2_0;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_int2x2_int2x2_0;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_int2x2_Int32_0;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_Int32_int2x2_0;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_int2x2_int2x2_0;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_int2x2_Int32_0;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_Int32_int2x2_0;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_int2x2_int2x2_0;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_int2x2_int2x2_0;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_int2x2_int2x2_Int32_0;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_int2x2_int2x2_Int32_0;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_int2x2_int2x2_0;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_int2x2_Int32_0;

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_Int32_int2x2_0;

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_int2x2_int2x2_0;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_int2x2_Int32_0;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_Int32_int2x2_0;

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_int2x2_int2x2_0;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x2_int2x2_int2x2_0;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x2_int2x2_Int32_0;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_int2x2_Int32_int2x2_0;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x2_int2x2_int2x2_0;

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x2_int2x2_Int32_0;

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_int2x2_Int32_int2x2_0;

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x2_int2x2_int2x2_0;

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x2_int2x2_Int32_0;

		// Token: 0x040019F6 RID: 6646
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_int2x2_Int32_int2x2_0;

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_int2_Int32_0;

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2x2_0;

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040019FB RID: 6651
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040019FD RID: 6653
		[FieldOffset(0)]
		public int2 c0;

		// Token: 0x040019FE RID: 6654
		[FieldOffset(8)]
		public int2 c1;
	}
}
