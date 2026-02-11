using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000042 RID: 66
	[Serializable]
	[StructLayout(2)]
	public struct uint2x4
	{
		// Token: 0x06002096 RID: 8342 RVA: 0x000A996C File Offset: 0x000A7B6C
		// Note: this type is marked as 'beforefieldinit'.
		static uint2x4()
		{
			Il2CppClassPointerStore<uint2x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "uint2x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint2x4>.NativeClassPtr);
			uint2x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, "c0");
			uint2x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, "c1");
			uint2x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, "c2");
			uint2x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, "c3");
			uint2x4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, "zero");
			uint2x4.NativeMethodInfoPtr__ctor_Public_Void_uint2_uint2_uint2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671385);
			uint2x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671386);
			uint2x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671387);
			uint2x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671388);
			uint2x4.NativeMethodInfoPtr__ctor_Public_Void_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671389);
			uint2x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671390);
			uint2x4.NativeMethodInfoPtr__ctor_Public_Void_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671391);
			uint2x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671392);
			uint2x4.NativeMethodInfoPtr__ctor_Public_Void_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671393);
			uint2x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671394);
			uint2x4.NativeMethodInfoPtr__ctor_Public_Void_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671395);
			uint2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671396);
			uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671397);
			uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_bool2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671398);
			uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671399);
			uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_int2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671400);
			uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671401);
			uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_float2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671402);
			uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671403);
			uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_double2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671404);
			uint2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671405);
			uint2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671406);
			uint2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671407);
			uint2x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671408);
			uint2x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671409);
			uint2x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671410);
			uint2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671411);
			uint2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671412);
			uint2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671413);
			uint2x4.NativeMethodInfoPtr_op_Division_Public_Static_uint2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671414);
			uint2x4.NativeMethodInfoPtr_op_Division_Public_Static_uint2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671415);
			uint2x4.NativeMethodInfoPtr_op_Division_Public_Static_uint2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671416);
			uint2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671417);
			uint2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671418);
			uint2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671419);
			uint2x4.NativeMethodInfoPtr_op_Increment_Public_Static_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671420);
			uint2x4.NativeMethodInfoPtr_op_Decrement_Public_Static_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671421);
			uint2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671422);
			uint2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671423);
			uint2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671424);
			uint2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671425);
			uint2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671426);
			uint2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671427);
			uint2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671428);
			uint2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671429);
			uint2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671430);
			uint2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671431);
			uint2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671432);
			uint2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671433);
			uint2x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671434);
			uint2x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671435);
			uint2x4.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint2x4_uint2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671436);
			uint2x4.NativeMethodInfoPtr_op_RightShift_Public_Static_uint2x4_uint2x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671437);
			uint2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671438);
			uint2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671439);
			uint2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671440);
			uint2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671441);
			uint2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671442);
			uint2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671443);
			uint2x4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671444);
			uint2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671445);
			uint2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671446);
			uint2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671447);
			uint2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671448);
			uint2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671449);
			uint2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671450);
			uint2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x4_uint2x4_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671451);
			uint2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x4_uint2x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671452);
			uint2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x4_UInt32_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671453);
			uint2x4.NativeMethodInfoPtr_get_Item_Public_get_byref_uint2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671454);
			uint2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint2x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671455);
			uint2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671456);
			uint2x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671457);
			uint2x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671458);
			uint2x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, 100671459);
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x000A9FDC File Offset: 0x000A81DC
		[CallerCount(0)]
		public unsafe uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr__ctor_Public_Void_uint2_uint2_uint2_uint2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x000AA038 File Offset: 0x000A8238
		[CallerCount(0)]
		public unsafe uint2x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x000AA0CC File Offset: 0x000A82CC
		[CallerCount(0)]
		public unsafe uint2x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x000AA100 File Offset: 0x000A8300
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 639297, RefRangeEnd = 639299, XrefRangeStart = 639297, XrefRangeEnd = 639299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x000AA134 File Offset: 0x000A8334
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 639299, RefRangeEnd = 639303, XrefRangeStart = 639299, XrefRangeEnd = 639303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x4(bool2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr__ctor_Public_Void_bool2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x000AA168 File Offset: 0x000A8368
		[CallerCount(0)]
		public unsafe uint2x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x000AA19C File Offset: 0x000A839C
		[CallerCount(0)]
		public unsafe uint2x4(int2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr__ctor_Public_Void_int2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x000AA1D0 File Offset: 0x000A83D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641630, RefRangeEnd = 641631, XrefRangeStart = 641623, XrefRangeEnd = 641630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x000AA204 File Offset: 0x000A8404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641638, RefRangeEnd = 641639, XrefRangeStart = 641631, XrefRangeEnd = 641638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x4(float2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr__ctor_Public_Void_float2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x000AA238 File Offset: 0x000A8438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641646, RefRangeEnd = 641647, XrefRangeStart = 641639, XrefRangeEnd = 641646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x000AA26C File Offset: 0x000A846C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 641654, RefRangeEnd = 641655, XrefRangeStart = 641647, XrefRangeEnd = 641654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint2x4(double2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr__ctor_Public_Void_double2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x000AA2A0 File Offset: 0x000A84A0
		[CallerCount(0)]
		public unsafe static implicit operator uint2x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Implicit_Public_Static_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x000AA2E0 File Offset: 0x000A84E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x000AA320 File Offset: 0x000A8520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x4(bool2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_bool2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x000AA360 File Offset: 0x000A8560
		[CallerCount(0)]
		public unsafe static explicit operator uint2x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x000AA3A0 File Offset: 0x000A85A0
		[CallerCount(0)]
		public unsafe static explicit operator uint2x4(int2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_int2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x000AA3E0 File Offset: 0x000A85E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641655, XrefRangeEnd = 641656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x000AA420 File Offset: 0x000A8620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641656, XrefRangeEnd = 641657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x4(float2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_float2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x000AA460 File Offset: 0x000A8660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641657, XrefRangeEnd = 641658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x000AA4A0 File Offset: 0x000A86A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641658, XrefRangeEnd = 641659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint2x4(double2x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_double2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x000AA4E0 File Offset: 0x000A86E0
		[CallerCount(0)]
		public unsafe static uint2x4 operator *(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x000AA52C File Offset: 0x000A872C
		[CallerCount(0)]
		public unsafe static uint2x4 operator *(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x000AA578 File Offset: 0x000A8778
		[CallerCount(0)]
		public unsafe static uint2x4 operator *(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x000AA5C4 File Offset: 0x000A87C4
		[CallerCount(0)]
		public unsafe static uint2x4 operator +(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x000AA610 File Offset: 0x000A8810
		[CallerCount(0)]
		public unsafe static uint2x4 operator +(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x000AA65C File Offset: 0x000A885C
		[CallerCount(0)]
		public unsafe static uint2x4 operator +(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x000AA6A8 File Offset: 0x000A88A8
		[CallerCount(0)]
		public unsafe static uint2x4 operator -(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x000AA6F4 File Offset: 0x000A88F4
		[CallerCount(0)]
		public unsafe static uint2x4 operator -(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x000AA740 File Offset: 0x000A8940
		[CallerCount(0)]
		public unsafe static uint2x4 operator -(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x000AA78C File Offset: 0x000A898C
		[CallerCount(0)]
		public unsafe static uint2x4 operator /(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Division_Public_Static_uint2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x000AA7D8 File Offset: 0x000A89D8
		[CallerCount(0)]
		public unsafe static uint2x4 operator /(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Division_Public_Static_uint2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x000AA824 File Offset: 0x000A8A24
		[CallerCount(0)]
		public unsafe static uint2x4 operator /(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Division_Public_Static_uint2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x000AA870 File Offset: 0x000A8A70
		[CallerCount(0)]
		public unsafe static uint2x4 operator %(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x000AA8BC File Offset: 0x000A8ABC
		[CallerCount(0)]
		public unsafe static uint2x4 operator %(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x000AA908 File Offset: 0x000A8B08
		[CallerCount(0)]
		public unsafe static uint2x4 operator %(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x000AA954 File Offset: 0x000A8B54
		[CallerCount(0)]
		public unsafe static uint2x4 operator ++(uint2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Increment_Public_Static_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x000AA994 File Offset: 0x000A8B94
		[CallerCount(0)]
		public unsafe static uint2x4 operator --(uint2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Decrement_Public_Static_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x000AA9D4 File Offset: 0x000A8BD4
		[CallerCount(0)]
		public unsafe static bool2x4 operator <(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x000AAA20 File Offset: 0x000A8C20
		[CallerCount(0)]
		public unsafe static bool2x4 operator <(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x000AAA6C File Offset: 0x000A8C6C
		[CallerCount(0)]
		public unsafe static bool2x4 operator <(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x000AAAB8 File Offset: 0x000A8CB8
		[CallerCount(0)]
		public unsafe static bool2x4 operator <=(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x000AAB04 File Offset: 0x000A8D04
		[CallerCount(0)]
		public unsafe static bool2x4 operator <=(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x000AAB50 File Offset: 0x000A8D50
		[CallerCount(0)]
		public unsafe static bool2x4 operator <=(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x000AAB9C File Offset: 0x000A8D9C
		[CallerCount(0)]
		public unsafe static bool2x4 operator >(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x000AABE8 File Offset: 0x000A8DE8
		[CallerCount(0)]
		public unsafe static bool2x4 operator >(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x000AAC34 File Offset: 0x000A8E34
		[CallerCount(0)]
		public unsafe static bool2x4 operator >(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x000AAC80 File Offset: 0x000A8E80
		[CallerCount(0)]
		public unsafe static bool2x4 operator >=(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x000AACCC File Offset: 0x000A8ECC
		[CallerCount(0)]
		public unsafe static bool2x4 operator >=(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x000AAD18 File Offset: 0x000A8F18
		[CallerCount(0)]
		public unsafe static bool2x4 operator >=(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x000AAD64 File Offset: 0x000A8F64
		[CallerCount(0)]
		public unsafe static uint2x4 operator -(uint2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x000AADA4 File Offset: 0x000A8FA4
		[CallerCount(0)]
		public unsafe static uint2x4 operator +(uint2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x000AADE4 File Offset: 0x000A8FE4
		[CallerCount(0)]
		public unsafe static uint2x4 operator <<(uint2x4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint2x4_uint2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x000AAE30 File Offset: 0x000A9030
		[CallerCount(0)]
		public unsafe static uint2x4 operator >>(uint2x4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_RightShift_Public_Static_uint2x4_uint2x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x000AAE7C File Offset: 0x000A907C
		[CallerCount(0)]
		public unsafe static bool2x4 operator ==(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x000AAEC8 File Offset: 0x000A90C8
		[CallerCount(0)]
		public unsafe static bool2x4 operator ==(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x000AAF14 File Offset: 0x000A9114
		[CallerCount(0)]
		public unsafe static bool2x4 operator ==(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x000AAF60 File Offset: 0x000A9160
		[CallerCount(0)]
		public unsafe static bool2x4 operator !=(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x000AAFAC File Offset: 0x000A91AC
		[CallerCount(0)]
		public unsafe static bool2x4 operator !=(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x000AAFF8 File Offset: 0x000A91F8
		[CallerCount(0)]
		public unsafe static bool2x4 operator !=(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x000AB044 File Offset: 0x000A9244
		[CallerCount(0)]
		public unsafe static uint2x4 operator ~(uint2x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x000AB084 File Offset: 0x000A9284
		[CallerCount(0)]
		public unsafe static uint2x4 operator &(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x000AB0D0 File Offset: 0x000A92D0
		[CallerCount(0)]
		public unsafe static uint2x4 operator &(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x000AB11C File Offset: 0x000A931C
		[CallerCount(0)]
		public unsafe static uint2x4 operator &(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x000AB168 File Offset: 0x000A9368
		[CallerCount(0)]
		public unsafe static uint2x4 operator |(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x000AB1B4 File Offset: 0x000A93B4
		[CallerCount(0)]
		public unsafe static uint2x4 operator |(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x000AB200 File Offset: 0x000A9400
		[CallerCount(0)]
		public unsafe static uint2x4 operator |(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x000AB24C File Offset: 0x000A944C
		[CallerCount(0)]
		public unsafe static uint2x4 operator ^(uint2x4 lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x4_uint2x4_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x000AB298 File Offset: 0x000A9498
		[CallerCount(0)]
		public unsafe static uint2x4 operator ^(uint2x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x4_uint2x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x000AB2E4 File Offset: 0x000A94E4
		[CallerCount(0)]
		public unsafe static uint2x4 operator ^(uint lhs, uint2x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x4_UInt32_uint2x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000A0A RID: 2570
		public unsafe ref uint2 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_get_Item_Public_get_byref_uint2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x000AB364 File Offset: 0x000A9564
		[CallerCount(0)]
		public unsafe bool Equals(uint2x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint2x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x000AB3A4 File Offset: 0x000A95A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641659, XrefRangeEnd = 641662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x000AB3E8 File Offset: 0x000A95E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641662, XrefRangeEnd = 641663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x000AB418 File Offset: 0x000A9618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641663, XrefRangeEnd = 641702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x000AB444 File Offset: 0x000A9644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 641702, XrefRangeEnd = 641750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint2x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x0000297B File Offset: 0x00000B7B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<uint2x4>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x000AB494 File Offset: 0x000A9694
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x0000298D File Offset: 0x00000B8D
		public unsafe static uint2x4 zero
		{
			get
			{
				uint2x4 uint2x;
				IL2CPP.il2cpp_field_static_get_value(uint2x4.NativeFieldInfoPtr_zero, (void*)(&uint2x));
				return uint2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint2x4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04002113 RID: 8467
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04002114 RID: 8468
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04002115 RID: 8469
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04002116 RID: 8470
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x04002117 RID: 8471
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04002118 RID: 8472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2_uint2_uint2_uint2_0;

		// Token: 0x04002119 RID: 8473
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x0400211A RID: 8474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x0400211B RID: 8475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400211C RID: 8476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2x4_0;

		// Token: 0x0400211D RID: 8477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400211E RID: 8478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2x4_0;

		// Token: 0x0400211F RID: 8479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04002120 RID: 8480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2x4_0;

		// Token: 0x04002121 RID: 8481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04002122 RID: 8482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2x4_0;

		// Token: 0x04002123 RID: 8483
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_uint2x4_UInt32_0;

		// Token: 0x04002124 RID: 8484
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_Boolean_0;

		// Token: 0x04002125 RID: 8485
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_bool2x4_0;

		// Token: 0x04002126 RID: 8486
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_Int32_0;

		// Token: 0x04002127 RID: 8487
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_int2x4_0;

		// Token: 0x04002128 RID: 8488
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_Single_0;

		// Token: 0x04002129 RID: 8489
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_float2x4_0;

		// Token: 0x0400212A RID: 8490
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_Double_0;

		// Token: 0x0400212B RID: 8491
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint2x4_double2x4_0;

		// Token: 0x0400212C RID: 8492
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x4_uint2x4_uint2x4_0;

		// Token: 0x0400212D RID: 8493
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x4_uint2x4_UInt32_0;

		// Token: 0x0400212E RID: 8494
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint2x4_UInt32_uint2x4_0;

		// Token: 0x0400212F RID: 8495
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint2x4_uint2x4_uint2x4_0;

		// Token: 0x04002130 RID: 8496
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint2x4_uint2x4_UInt32_0;

		// Token: 0x04002131 RID: 8497
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint2x4_UInt32_uint2x4_0;

		// Token: 0x04002132 RID: 8498
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x4_uint2x4_uint2x4_0;

		// Token: 0x04002133 RID: 8499
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x4_uint2x4_UInt32_0;

		// Token: 0x04002134 RID: 8500
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint2x4_UInt32_uint2x4_0;

		// Token: 0x04002135 RID: 8501
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint2x4_uint2x4_uint2x4_0;

		// Token: 0x04002136 RID: 8502
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint2x4_uint2x4_UInt32_0;

		// Token: 0x04002137 RID: 8503
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint2x4_UInt32_uint2x4_0;

		// Token: 0x04002138 RID: 8504
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x4_uint2x4_uint2x4_0;

		// Token: 0x04002139 RID: 8505
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x4_uint2x4_UInt32_0;

		// Token: 0x0400213A RID: 8506
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint2x4_UInt32_uint2x4_0;

		// Token: 0x0400213B RID: 8507
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_uint2x4_uint2x4_0;

		// Token: 0x0400213C RID: 8508
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_uint2x4_uint2x4_0;

		// Token: 0x0400213D RID: 8509
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_uint2x4_uint2x4_0;

		// Token: 0x0400213E RID: 8510
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_uint2x4_UInt32_0;

		// Token: 0x0400213F RID: 8511
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x4_UInt32_uint2x4_0;

		// Token: 0x04002140 RID: 8512
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_uint2x4_uint2x4_0;

		// Token: 0x04002141 RID: 8513
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_uint2x4_UInt32_0;

		// Token: 0x04002142 RID: 8514
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x4_UInt32_uint2x4_0;

		// Token: 0x04002143 RID: 8515
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_uint2x4_uint2x4_0;

		// Token: 0x04002144 RID: 8516
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_uint2x4_UInt32_0;

		// Token: 0x04002145 RID: 8517
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x4_UInt32_uint2x4_0;

		// Token: 0x04002146 RID: 8518
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_uint2x4_uint2x4_0;

		// Token: 0x04002147 RID: 8519
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_uint2x4_UInt32_0;

		// Token: 0x04002148 RID: 8520
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x4_UInt32_uint2x4_0;

		// Token: 0x04002149 RID: 8521
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint2x4_uint2x4_0;

		// Token: 0x0400214A RID: 8522
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint2x4_uint2x4_0;

		// Token: 0x0400214B RID: 8523
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_uint2x4_uint2x4_Int32_0;

		// Token: 0x0400214C RID: 8524
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_uint2x4_uint2x4_Int32_0;

		// Token: 0x0400214D RID: 8525
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_uint2x4_uint2x4_0;

		// Token: 0x0400214E RID: 8526
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_uint2x4_UInt32_0;

		// Token: 0x0400214F RID: 8527
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x4_UInt32_uint2x4_0;

		// Token: 0x04002150 RID: 8528
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_uint2x4_uint2x4_0;

		// Token: 0x04002151 RID: 8529
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_uint2x4_UInt32_0;

		// Token: 0x04002152 RID: 8530
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x4_UInt32_uint2x4_0;

		// Token: 0x04002153 RID: 8531
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint2x4_uint2x4_0;

		// Token: 0x04002154 RID: 8532
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x4_uint2x4_uint2x4_0;

		// Token: 0x04002155 RID: 8533
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x4_uint2x4_UInt32_0;

		// Token: 0x04002156 RID: 8534
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint2x4_UInt32_uint2x4_0;

		// Token: 0x04002157 RID: 8535
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x4_uint2x4_uint2x4_0;

		// Token: 0x04002158 RID: 8536
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x4_uint2x4_UInt32_0;

		// Token: 0x04002159 RID: 8537
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint2x4_UInt32_uint2x4_0;

		// Token: 0x0400215A RID: 8538
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x4_uint2x4_uint2x4_0;

		// Token: 0x0400215B RID: 8539
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x4_uint2x4_UInt32_0;

		// Token: 0x0400215C RID: 8540
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint2x4_UInt32_uint2x4_0;

		// Token: 0x0400215D RID: 8541
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_uint2_Int32_0;

		// Token: 0x0400215E RID: 8542
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint2x4_0;

		// Token: 0x0400215F RID: 8543
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002160 RID: 8544
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002161 RID: 8545
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002162 RID: 8546
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04002163 RID: 8547
		[FieldOffset(0)]
		public uint2 c0;

		// Token: 0x04002164 RID: 8548
		[FieldOffset(8)]
		public uint2 c1;

		// Token: 0x04002165 RID: 8549
		[FieldOffset(16)]
		public uint2 c2;

		// Token: 0x04002166 RID: 8550
		[FieldOffset(24)]
		public uint2 c3;
	}
}
